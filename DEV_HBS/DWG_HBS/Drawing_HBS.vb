Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: DWG_HBS
'$ PartFamily: Drawing_HBS
'$ GenerateDate: 07/12/2025 14:09:10

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
    Imports DWG_HBS.swMateType_e
    Imports DWG_HBS.swMateAlign_e
    Imports DWG_HBS.severity

    Public Class [Drawing_HBS]
    
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

    Private this as Drawing_HBS = me

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
      Case "4"
      Select Case processStep
        Case "15"
        Result = Process_DefaultProcess_Step_1_COMMENT()
        
        Case "16"
        Result = Process_DefaultProcess_Drawing_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "4"
      Select Case processStep
        Case "15"
        Result = Process_DefaultProcess_Step_1_STATUS()
        
        Case "16"
        Result = Process_DefaultProcess_Drawing_STATUS()
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
    
      Public ReadOnly Property [Drawing_Plants]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Drawing_Plants")
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
    InitPart("Drawing_HBS", <a><![CDATA[Drawing_HBS]]></a>.Value, 25, "DWG_HBS",  "", "", False, True, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/19/2025 19:41:00")
    AddProperty("459", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "4/21/2025 2:25:22 PM")
    
      oSubpart = AddSubpart(29,"Drawing_Plants", <a><![CDATA[Drawing_Plants]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (26, "Drawing_Plant", "Drawing_Plant")
      oSpec = AddSpec("5","", 15, "DWGSpec", "", "GLOBAL\H601424", "2025-06-19T19:41:00.377", "DWG Spec")
      oSpec.Attributes.Add("DIM", "DWGFORMAT", <a><![CDATA[DWG]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "DWGVERSION", <a><![CDATA[AutoCAD 2010]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "EXPORTINDIVIDUALPDF", <a><![CDATA[FALSE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "EXPORTPDF", <a><![CDATA[FALSE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "HONORLAYOUTPARAMETERS", <a><![CDATA[FALSE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELENABLED", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELFILE", <a><![CDATA[Empty Template.dwg]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELOUTPUTFILE", <a><![CDATA[DWG Spec]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELRESTRICTTOVALID", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "PDFORIENTATION", <a><![CDATA[Landscape]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "PlotLineWeights", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "RasterImageDPI", <a><![CDATA[400]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "VectorDPI", <a><![CDATA[600]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oMasterDoc = oSpec.AddMasterDoc("Empty Template.dwg", "2025-04-21T14:26:39.087")
        
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 4
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Step_1()
        Initialize_Process_DefaultProcess_Drawing()
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
        oProcessStep = AddProcessStep(15, "Step 1", "This process step was created automatically by RuleStream.", 1, 4, 1, 1, 50, 50)
        oProcessStep.AddPath("Drawing_HBS")
        oProcessStep.AddFilter(1, 25, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 25, "1", "0", "RsGrid", 0, "", 70, 88, 319, 497, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,29,Drawing_Plants;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 25, "2", "1", "RsGridColumn", 0, "PlantName", 0, 0, 0, 100, 0, "Plant Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 25, "3", "0", "RsAddDeleteCopy", 0, "", 395, 427, 22, 158, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,29,Drawing_Plants;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 25, "4", "0", "RsSubForm", 0, "", 480, 56, 359, 566, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,29,Drawing_Plants")
        oProcessStep.AddCustomLayout(1, 25, "5", "4", "RsGrid", 0, "", 3, 32, 319, 497, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,30,Drawing_Devices;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 25, "6", "5", "RsGridColumn", 0, "DeviceName", 0, 0, 0, 100, 0, "Device Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 25, "7", "5", "RsGridColumn", 0, "TerminalBlock_Quantity", 0, 0, 0, 100, 0, "TB Quantity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 25, "8", "5", "RsGridColumn", 0, "FromDWG_XLocation", 0, 0, 0, 100, 0, "X Loc", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 25, "9", "5", "RsGridColumn", 0, "FromDWG_YLocation", 0, 0, 0, 100, 0, "Y Loc", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 25, "10", "4", "RsAddDeleteCopy", 0, "", 328, 371, 22, 158, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,30,Drawing_Devices;CanDelete:;AddPrompt:False;ShowCopy:True")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Drawing()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(16, "Drawing", "", 4, 4, 1, 2, 50, 50)
        oProcessStep.AddPath("Drawing_HBS")
        oProcessStep.AddLayout(1, 23, "DWGSpec")
        
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
          
        InitSubpart("Drawing_Plants", 29, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "4/21/2025 2:28:22 PM", "", "In Development", "Y",0,69,68)
        
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
      Public Function Process_DefaultProcess_Step_1_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:15; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:15; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_HBS.Process_DefaultProcess_Step_1_STATUS", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:15; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:15; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_HBS.Process_DefaultProcess_Step_1_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Drawing_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:16; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:16; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_HBS.Process_DefaultProcess_Drawing_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Drawing_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:16; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:16; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_HBS.Process_DefaultProcess_Drawing_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drawing_Plants_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:29; TYPE:PN
      
      '   END FORMULA; SUB ID:29; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_HBS.Formula_Drawing_Plants_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drawing_Plants_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Drawing_Plants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:29; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:29; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_HBS.Formula_Drawing_Plants_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drawing_Plants_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Drawing_Plants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:29; TYPE:OP
      result = "Drawing_Plant"
      '   END FORMULA; SUB ID:29; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_HBS.Formula_Drawing_Plants_OPTIMALPARTFAMILY", ex.Message)
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

  