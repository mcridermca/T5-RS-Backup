Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: HHS_DWGXLSX_Importer
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

    Public Class [HHS_DWGXLSX_Importer]
    
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

    Private this as HHS_DWGXLSX_Importer = me

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
      Case "40"
      Select Case processStep
        Case "49"
        Result = Process_DefaultProcess_Step_1_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "40"
      Select Case processStep
        Case "49"
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
    
          Public Property [Hanger_Spacing]() As Long
      Get
      Return Properties("Hanger_Spacing").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Hanger_Spacing").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [HHS_Debug_Output_Text]() As String
      Get
      Return Properties("HHS_Debug_Output_Text").Value
      End Get
      Set(ByVal Value As String)
      Properties("HHS_Debug_Output_Text").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [HHS_Input_Text_Tab_Formatted]() As String
      Get
      Return Properties("HHS_Input_Text_Tab_Formatted").Value
      End Get
      Set(ByVal Value As String)
      Properties("HHS_Input_Text_Tab_Formatted").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [HHS_Lines_Distinct_VV]() As Long
      Get
      Return Properties("HHS_Lines_Distinct_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("HHS_Lines_Distinct_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Is_Seismic]() As Boolean
      Get
      Return Properties("Is_Seismic").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_Seismic").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Seismic_Requirement]() As String
      Get
      Return Properties("Seismic_Requirement").Value
      End Get
      Set(ByVal Value As String)
      Properties("Seismic_Requirement").CalculatedValue = Value
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
    
      Public ReadOnly Property [Product_Lines]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Product_Lines")
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
    InitPart("HHS_DWGXLSX_Importer", <a><![CDATA[Header Hanger DWG Excel Importer]]></a>.Value, 334, "APCTMP01",  "", "", False, True, "In Development", "", "Imports Header Hanger Information from DWG Files", "", "", "",  "GLOBAL\H601424", "04/30/2025 19:47:08")
    AddProperty("2366", "Hanger_Spacing", <a><![CDATA[Hanger Spacing]]></a>.Value, "Hanger Spacing in Feet", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
    AddProperty("2203", "HHS_Debug_Output_Text", <a><![CDATA[HHS Debug Output Text]]></a>.Value, "Header Hanger Debug Parse Text", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/21/2025 9:57:36 PM")
    AddProperty("2201", "HHS_Input_Text_Tab_Formatted", <a><![CDATA[HHS Input Text Tab Formatted]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/30/2025 7:46:32 PM")
    AddProperty("2206", "HHS_Lines_Distinct_VV", <a><![CDATA[HHS_Input_Lines_Distinct_VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/30/2025 7:47:08 PM")
    AddProperty("2215", "Is_Seismic", <a><![CDATA[Is Seismic]]></a>.Value, "Does this application require siesmic standards", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 4:51:55 PM")
    AddProperty("2316", "Seismic_Requirement", <a><![CDATA[Seismic Requirement]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 4:51:55 PM")
    AddProperty("2200", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/21/2025 3:45:13 PM")
    
      AddValidValue("HHS_Input_Text_Tab_Formatted")
    
      AddValidValue("HHS_Lines_Distinct_VV")
    
      AddValidValue("Seismic_Requirement")
    
      oSubpart = AddSubpart(198,"Product_Lines", <a><![CDATA[Product Lines]]></a>.Value, "FD", "HHS Lines Collection", "General", 9999, "", "GLOBAL\H601424", "4/21/2025 11:11:38 PM")
      
        oSubpart.AddVPF (335, "HHS_DWGXLSX_Import_Line", "HHS Import Line")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 40
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
        oProcessStep = AddProcessStep(49, "Step 1", "This process step was created automatically by RuleStream.", 1, 40, 1, 1, 50, 50)
        oProcessStep.AddPath("HHS_DWGXLSX_Importer")
        oProcessStep.AddFilter(1, 334, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 334, "1", "0", "RsTextbox", 0, "HHS_Input_Text_Tab_Formatted", 77, 43, 350, 1092, 0, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 334, "2", "0", "RsTextbox", 0, "HHS_Debug_Output_Text", 464, 43, 350, 1092, 1, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 334, "3", "0", "RsLabel", 0, "", 0, 27, 37, 514, 2, "Debug / Development Use Only", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.17;Font_Style:1.;ForeColor:Firebrick;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "4", "0", "RsLabel", 0, "", 37, 27, 22, 514, 3, "Header Hanger Input from DWG =&amp;gt;  Excel", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
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
          InitProperty("Hanger_Spacing", "2014", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "Hanger Spacing in Feet", "In Development",  0,2793)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HHS_Debug_Output_Text", "1869", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/21/2025 9:57:36 PM", "Header Hanger Debug Parse Text", "In Development",  0,2493)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HHS_Input_Text_Tab_Formatted", "1867", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/30/2025 7:46:32 PM", "", "In Development",  0,2470)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HHS_Lines_Distinct_VV", "1872", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/30/2025 7:47:08 PM", "", "In Development",  0,2495)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Seismic", "1880", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 4:51:55 PM", "Does this application require siesmic standards", "In Development",  0,2723)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Seismic_Requirement", "1964", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 4:51:55 PM", "", "In Development",  0,2724)
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
          
        InitValidValue("HHS_Input_Text_Tab_Formatted_ValidValues", "1867", "-1", 3411)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("HHS_Lines_Distinct_VV_ValidValues", "1872", "-1", 3412)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Seismic_Requirement_ValidValues", "1964", "-1", 2725)
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
          
        InitSubpart("Product_Lines", 136, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/21/2025 11:11:38 PM", "HHS Lines Collection", "In Development", "Y",0,315,316)
        
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
      '   BEGIN FORMULA; PROC ID:49; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:49; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Process_DefaultProcess_Step_1_STATUS", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:49; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:49; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Process_DefaultProcess_Step_1_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Hanger_Spacing() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hanger_Spacing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2014; TYPE:PF
      result = 10
      '   END FORMULA; PROP ID:2014; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_Hanger_Spacing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_HHS_Debug_Output_Text() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HHS_Debug_Output_Text").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1869; TYPE:PF
      result = ""
For Each o As String In Me.ValidValues("HHS_Input_Text_Tab_Formatted").Values
	Result = Result & O & vbcrlf
Next o
      '   END FORMULA; PROP ID:1869; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_HHS_Debug_Output_Text", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_HHS_Input_Text_Tab_Formatted() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HHS_Input_Text_Tab_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1867; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1867; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_HHS_Input_Text_Tab_Formatted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_HHS_Lines_Distinct_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HHS_Lines_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1872; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:1872; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_HHS_Lines_Distinct_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Is_Seismic() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_Seismic").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1880; TYPE:PF
      result = Not (Me.Seismic_Requirement="No")
      '   END FORMULA; PROP ID:1880; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_Is_Seismic", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Seismic_Requirement() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Seismic_Requirement").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1964; TYPE:PF
      result = "No"
      '   END FORMULA; PROP ID:1964; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_Seismic_Requirement", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Spacing_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Debug_Output_Text_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Input_Text_Tab_Formatted_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Lines_Distinct_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Seismic_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Seismic_Requirement_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Spacing_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Debug_Output_Text_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Input_Text_Tab_Formatted_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Lines_Distinct_VV_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Seismic_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Seismic_Requirement_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Input_Text_Tab_Formatted_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HHS_Input_Text_Tab_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1867; TYPE:VV
      Result = New ValidValues()

If True Then 'And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.HHS_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	
	Dim StartProd As Boolean = False
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length > 1 Then
			StartProd = True
			' If elements(0).trim().ToLower() = "metrics" Then
			'	StartProd = True
			' End If
			
			If StartProd Then
				'If Me.validvalues("PRD_Generic_Product_List_Distinct_VV").contains(elements(0).Trim()) Then
					Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(1)}|{elements(2)}|{elements(3)}" '|{elements(4)}|{elements(5)}|{elements(6)}"
					Result.Add(VVText)
				'End If
			End If
	End If
	Next line
End If
      '   END FORMULA; PROP ID:1867; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_HHS_Input_Text_Tab_Formatted_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Lines_Distinct_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HHS_Lines_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1872; TYPE:VV
      Result = New ValidValues()

If True Then 'And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.HHS_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	
	Dim StartProd As Boolean = False
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length > 1 Then
			StartProd = True
			' If elements(0).trim().ToLower() = "metrics" Then
			'	StartProd = True
			' End If
			
			If StartProd Then
				'If Me.validvalues("PRD_Generic_Product_List_Distinct_VV").contains(elements(0).Trim()) Then
					Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(1)}|{elements(2)}|{elements(3)}" '|{elements(4)}|{elements(5)}|{elements(6)}"
					Result.Add(VVText)
				'End If
			End If
	End If
	Next line
End If
      '   END FORMULA; PROP ID:1872; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_HHS_Lines_Distinct_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Seismic_Requirement_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Seismic_Requirement").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1964; TYPE:VV
      result = MakeValidValues(Array("(0.0-0.5)","(0.5-1.0)","(1.0-1.9)","No"))
      '   END FORMULA; PROP ID:1964; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_Seismic_Requirement_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Lines_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:136; TYPE:PN
      
      '   END FORMULA; SUB ID:136; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_Product_Lines_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Lines_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Product_Lines").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:136; TYPE:QF
      Result = Me.HHS_Lines_Distinct_VV
      '   END FORMULA; SUB ID:136; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_Product_Lines_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Lines_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Product_Lines").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:136; TYPE:OP
      Result = "HHS_DWGXLSX_Import_Line"
      '   END FORMULA; SUB ID:136; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_DWGXLSX_Importer.Formula_Product_Lines_OPTIMALPARTFAMILY", ex.Message)
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

  