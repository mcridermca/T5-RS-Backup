Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: DWG_HBS
'$ PartFamily: TBBlock
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

    Public Class [TBBlock]
    
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

    Private this as TBBlock = me

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
    
          Public Property [LabelText]() As String
      Get
      Return Properties("LabelText").Value
      End Get
      Set(ByVal Value As String)
      Properties("LabelText").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LabelText_FromApp]() As String
      Get
      Return Properties("LabelText_FromApp").Value
      End Get
      Set(ByVal Value As String)
      Properties("LabelText_FromApp").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LabelText_Show]() As Boolean
      Get
      Return Properties("LabelText_Show").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("LabelText_Show").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LabelTextLocation]() As String
      Get
      Return Properties("LabelTextLocation").Value
      End Get
      Set(ByVal Value As String)
      Properties("LabelTextLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [NodeText]() As String
      Get
      Return Properties("NodeText").Value
      End Get
      Set(ByVal Value As String)
      Properties("NodeText").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [NodeText_FromApp]() As String
      Get
      Return Properties("NodeText_FromApp").Value
      End Get
      Set(ByVal Value As String)
      Properties("NodeText_FromApp").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [NodeText_Show]() As Boolean
      Get
      Return Properties("NodeText_Show").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("NodeText_Show").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [NodeTextLocation]() As String
      Get
      Return Properties("NodeTextLocation").Value
      End Get
      Set(ByVal Value As String)
      Properties("NodeTextLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_LowerLeft]() As String
      Get
      Return Properties("TerminalBlock_LowerLeft").Value
      End Get
      Set(ByVal Value As String)
      Properties("TerminalBlock_LowerLeft").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_Show]() As Boolean
      Get
      Return Properties("TerminalBlock_Show").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("TerminalBlock_Show").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_UpperRight]() As String
      Get
      Return Properties("TerminalBlock_UpperRight").Value
      End Get
      Set(ByVal Value As String)
      Properties("TerminalBlock_UpperRight").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TextScale]() As Double
      Get
      Return Properties("TextScale").Value
      End Get
      Set(ByVal Value As Double)
      Properties("TextScale").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TextToAvoid]() As String
      Get
      Return Properties("TextToAvoid").Value
      End Get
      Set(ByVal Value As String)
      Properties("TextToAvoid").CalculatedValue = Value
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
    InitPart("TBBlock", <a><![CDATA[TB Block]]></a>.Value, 28, "DWG_HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/19/2025 19:41:00")
    AddProperty("515", "LabelText", <a><![CDATA[Label Text]]></a>.Value, "The text just above the Terminal Block individual block", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("522", "LabelText_FromApp", <a><![CDATA[Label Text_From App]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("518", "LabelText_Show", <a><![CDATA[Label Text_Show]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("516", "LabelTextLocation", <a><![CDATA[Label Text Location]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("510", "NodeText", <a><![CDATA[Node Text]]></a>.Value, "The text inside the Terminal Block individual block", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("523", "NodeText_FromApp", <a><![CDATA[Node Text_From App]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("517", "NodeText_Show", <a><![CDATA[Node Text_Show]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("511", "NodeTextLocation", <a><![CDATA[Node Text Location]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("508", "TerminalBlock_LowerLeft", <a><![CDATA[Terminal Block_Lower Left]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("521", "TerminalBlock_Show", <a><![CDATA[Terminal Block_Show]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("512", "TerminalBlock_UpperRight", <a><![CDATA[Terminal Block_Upper Right]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("514", "TextScale", <a><![CDATA[Text Scale]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("519", "TextToAvoid", <a><![CDATA[Text To Avoid]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("507", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "4/21/2025 6:26:15 PM")
    oSpec = AddSpec("9","", 17, "TBSpec", "", "GLOBAL\H601424", "2025-06-19T19:41:00.377", "TB Spec")
      oSpec.Attributes.Add("DIM", "OwningModelSpec", <a><![CDATA[DWG_HBS#Drawing_HBS#DWGSpec]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Rect.0.Enable", <a><![CDATA[TerminalBlock_Show]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Rect.0.Layer", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Rect.0.LineType", <a><![CDATA[CONTINUOUS]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Rect.0.LowerLeft", <a><![CDATA[TerminalBlock_LowerLeft]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Rect.0.Name", <a><![CDATA[TB Spec]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Rect.0.UpperRight", <a><![CDATA[TerminalBlock_UpperRight]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Rect.0.ZORDER", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.0.Enable", <a><![CDATA[NodeText_Show]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.0.Layer", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.0.LineType", <a><![CDATA[CONTINUOUS]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.0.Name", <a><![CDATA[TB Number]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.0.Position", <a><![CDATA[NodeTextLocation]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.0.TextColor", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.0.TextHeight", <a><![CDATA[TextScale]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.0.TextString", <a><![CDATA[NodeText]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.0.TextWidth", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.0.ZORDER", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.1.Enable", <a><![CDATA[LabelText_Show]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.1.Layer", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.1.LineType", <a><![CDATA[CONTINUOUS]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.1.Name", <a><![CDATA[TB Label]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.1.Position", <a><![CDATA[LabelTextLocation]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.1.TextColor", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.1.TextHeight", <a><![CDATA[TextScale]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.1.TextString", <a><![CDATA[LabelText]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Text.1.TextWidth", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Text.1.ZORDER", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      
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
          InitProperty("LabelText", "489", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:13:27 PM", "", "In Development",  0,1200)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LabelText_FromApp", "496", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:22:25 PM", "", "In Development",  0,1203)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LabelText_Show", "492", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:12:50 PM", "", "In Development",  0,1199)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LabelTextLocation", "490", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 1:10:08 PM", "", "In Development",  0,1182)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("NodeText", "484", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:15:48 PM", "", "In Development",  0,1202)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("NodeText_FromApp", "497", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:21:06 PM", "", "In Development",  0,1204)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("NodeText_Show", "491", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:15:04 PM", "", "In Development",  0,1201)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("NodeTextLocation", "485", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 7:12:10 PM", "", "In Development",  0,1178)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_LowerLeft", "482", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 6:51:32 PM", "", "In Development",  0,1168)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_Show", "495", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:08:13 PM", "", "In Development",  0,1196)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_UpperRight", "486", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 6:53:07 PM", "", "In Development",  0,1173)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TextScale", "488", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 7:02:41 PM", "", "In Development",  0,1175)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TextToAvoid", "493", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/22/2025 3:35:46 PM", "", "In Development",  0,1205)
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
          Public Function Formula_LabelText() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LabelText").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:489; TYPE:PF
      Result = Me.LabelText_FromApp
      '   END FORMULA; PROP ID:489; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_LabelText", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LabelText_FromApp() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LabelText_FromApp").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:496; TYPE:PF
      Result = "~"
      '   END FORMULA; PROP ID:496; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_LabelText_FromApp", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LabelText_Show() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LabelText_Show").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:492; TYPE:PF
      Result = True

For Each str As String In Me.TextToAvoid.Split(",")
	
	If Me.LabelText_FromApp.ToUpper() = str.ToUpper() Then
		Result = False
	End If
	
Next
      '   END FORMULA; PROP ID:492; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_LabelText_Show", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LabelTextLocation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LabelTextLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:490; TYPE:PF
      Dim numOfChar As Long = Me.LabelText.Length
Dim offset1 As Double = (Me.Parent.TerminalBlock_DefaultLength - (numOfChar * Me.TextScale)) / 2
Dim offset2 As Double = (Me.Parent.TerminalBlock_DefaultLength - Me.TextScale) / 2

Result = Me.Parent.BlockPlacement_XLocation + ((Me.SubpartID - 1) * Me.Parent.TerminalBlock_DefaultLength) + offset1 & "," & Me.Parent.BlockPlacement_YLocation + Me.Parent.TerminalBlock_DefaultLength + offset2 & ",0"
      '   END FORMULA; PROP ID:490; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_LabelTextLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_NodeText() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("NodeText").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:484; TYPE:PF
      Result = Me.NodeText_FromApp
      '   END FORMULA; PROP ID:484; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_NodeText", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_NodeText_FromApp() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("NodeText_FromApp").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:497; TYPE:PF
      Result = "%CLL"
      '   END FORMULA; PROP ID:497; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_NodeText_FromApp", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_NodeText_Show() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("NodeText_Show").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:491; TYPE:PF
      Result = True

For Each str As String In Me.TextToAvoid.Split(",")
	
	If Me.NodeText_FromApp.ToUpper() = str.ToUpper() Then
		Result = False
	End If
	
Next
      '   END FORMULA; PROP ID:491; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_NodeText_Show", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_NodeTextLocation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("NodeTextLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:485; TYPE:PF
      Dim numOfChar As Long = Me.NodeText.Length
Dim offset1 As Double = (Me.Parent.TerminalBlock_DefaultLength - (numOfChar * Me.TextScale)) / 2
Dim offset2 As Double = (Me.Parent.TerminalBlock_DefaultLength - Me.TextScale) / 2

Result = Me.Parent.BlockPlacement_XLocation + ((Me.SubpartID - 1) * Me.Parent.TerminalBlock_DefaultLength) + offset1 & "," & Me.Parent.BlockPlacement_YLocation + offset2 & ",0"
      '   END FORMULA; PROP ID:485; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_NodeTextLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_LowerLeft() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_LowerLeft").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:482; TYPE:PF
      Result = Me.Parent.BlockPlacement_XLocation + ((Me.SubpartID - 1) * Me.Parent.TerminalBlock_DefaultLength) & "," & Me.Parent.BlockPlacement_YLocation & ",0"
      '   END FORMULA; PROP ID:482; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_TerminalBlock_LowerLeft", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_Show() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_Show").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:495; TYPE:PF
      Result = If(Me.Parent.TerminalBlock_Quantity >= Me.SubpartID, True, False)
      '   END FORMULA; PROP ID:495; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_TerminalBlock_Show", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_UpperRight() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_UpperRight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:486; TYPE:PF
      Result = Me.Parent.BlockPlacement_XLocation + (Me.SubpartID * Me.Parent.TerminalBlock_DefaultLength) & "," & Me.Parent.BlockPlacement_YLocation + Me.Parent.TerminalBlock_DefaultLength & ",0"
      '   END FORMULA; PROP ID:486; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_TerminalBlock_UpperRight", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TextScale() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TextScale").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:488; TYPE:PF
      Result = me.Parent.TerminalBlock_TextScale
      '   END FORMULA; PROP ID:488; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_TextScale", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TextToAvoid() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TextToAvoid").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:493; TYPE:PF
      'Result = "~,_,H,N,+,-,S,C,@,%CLL,%CLR,%CHL,%CHR,%CLHM,%NOL,%NOR,%NCL,%NCR,%NCOM,%NOCM"

Result = "~,_,@,%CLL,%CLR,%CHL,%CHR,%CLHM,%NOL,%NOR,%NCL,%NCR,%NCOM,%NOCM"
      '   END FORMULA; PROP ID:493; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " TBBlock.Formula_TextToAvoid", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelText_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelText_FromApp_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelText_Show_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelTextLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeText_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeText_FromApp_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeText_Show_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeTextLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_LowerLeft_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Show_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_UpperRight_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TextScale_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TextToAvoid_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelText_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelText_FromApp_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelText_Show_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LabelTextLocation_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeText_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeText_FromApp_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeText_Show_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NodeTextLocation_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_LowerLeft_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Show_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_UpperRight_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TextScale_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TextToAvoid_USERCHANGE() as Boolean
      Return False
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

  