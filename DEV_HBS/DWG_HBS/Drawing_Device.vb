Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: DWG_HBS
'$ PartFamily: Drawing_Device
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

    Public Class [Drawing_Device]
    
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

    Private this as Drawing_Device = me

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
    
          Public Property [BlockPlacement_XLocation]() As Double
      Get
      Return Properties("BlockPlacement_XLocation").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BlockPlacement_XLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BlockPlacement_YLocation]() As Double
      Get
      Return Properties("BlockPlacement_YLocation").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BlockPlacement_YLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DeviceName]() As String
      Get
      Return Properties("DeviceName").Value
      End Get
      Set(ByVal Value As String)
      Properties("DeviceName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FromDWG_XLocation]() As Double
      Get
      Return Properties("FromDWG_XLocation").Value
      End Get
      Set(ByVal Value As Double)
      Properties("FromDWG_XLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FromDWG_YLocation]() As Double
      Get
      Return Properties("FromDWG_YLocation").Value
      End Get
      Set(ByVal Value As Double)
      Properties("FromDWG_YLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_DefaultLength]() As Double
      Get
      Return Properties("TerminalBlock_DefaultLength").Value
      End Get
      Set(ByVal Value As Double)
      Properties("TerminalBlock_DefaultLength").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_Height]() As Double
      Get
      Return Properties("TerminalBlock_Height").Value
      End Get
      Set(ByVal Value As Double)
      Properties("TerminalBlock_Height").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_Quantity]() As Long
      Get
      Return Properties("TerminalBlock_Quantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("TerminalBlock_Quantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_TextScale]() As Double
      Get
      Return Properties("TerminalBlock_TextScale").Value
      End Get
      Set(ByVal Value As Double)
      Properties("TerminalBlock_TextScale").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlock_Width]() As Double
      Get
      Return Properties("TerminalBlock_Width").Value
      End Get
      Set(ByVal Value As Double)
      Properties("TerminalBlock_Width").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlockDrawing_LowerLeft]() As String
      Get
      Return Properties("TerminalBlockDrawing_LowerLeft").Value
      End Get
      Set(ByVal Value As String)
      Properties("TerminalBlockDrawing_LowerLeft").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlockDrawing_UpperRight]() As String
      Get
      Return Properties("TerminalBlockDrawing_UpperRight").Value
      End Get
      Set(ByVal Value As String)
      Properties("TerminalBlockDrawing_UpperRight").CalculatedValue = Value
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
    
      Public ReadOnly Property [TBBlocks]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("TBBlocks")
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
    InitPart("Drawing_Device", <a><![CDATA[Drawing_Device]]></a>.Value, 27, "DWG_HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/19/2025 19:41:00")
    AddProperty("465", "BlockPlacement_XLocation", <a><![CDATA[Block Placement_X Location]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("466", "BlockPlacement_YLocation", <a><![CDATA[Block Placement_Y Location]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("463", "DeviceName", <a><![CDATA[Device Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("467", "FromDWG_XLocation", <a><![CDATA[From DWG_X Location]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("468", "FromDWG_YLocation", <a><![CDATA[From DWG_Y Location]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("469", "TerminalBlock_DefaultLength", <a><![CDATA[Terminal Block_Default Length]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("470", "TerminalBlock_Height", <a><![CDATA[Terminal Block_Height]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("471", "TerminalBlock_Quantity", <a><![CDATA[Terminal Block_Quantity]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("495", "TerminalBlock_TextScale", <a><![CDATA[Terminal Block_Text Scale]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("472", "TerminalBlock_Width", <a><![CDATA[Terminal Block_Width]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("475", "TerminalBlockDrawing_LowerLeft", <a><![CDATA[Terminal Block Drawing_Lower Left]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("476", "TerminalBlockDrawing_UpperRight", <a><![CDATA[Terminal Block Drawing_Upper Right]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("462", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "4/21/2025 2:31:35 PM")
    
      oSubpart = AddSubpart(31,"TBBlocks", <a><![CDATA[TB Blocks]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (28, "TBBlock", "TB Block")
      oSpec = AddSpec("7","", 17, "TerminalBlockSpec", "", "GLOBAL\H601424", "2025-06-19T19:41:00.377", "Terminal Block Spec")
      oSpec.Attributes.Add("DIM", "OwningModelSpec", <a><![CDATA[DWG_HBS#Drawing_HBS#DWGSpec]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Rect.0.Enable", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Rect.0.Layer", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Rect.0.LineType", <a><![CDATA[CONTINUOUS]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Rect.0.LowerLeft", <a><![CDATA[TerminalBlockDrawing_LowerLeft]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Rect.0.Name", <a><![CDATA[Terminal Block Outline]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Rect.0.UpperRight", <a><![CDATA[TerminalBlockDrawing_UpperRight]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Rect.0.ZORDER", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      
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
          InitProperty("BlockPlacement_XLocation", "440", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:39:04 PM", "", "In Development",  0,1109)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BlockPlacement_YLocation", "441", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:39:37 PM", "", "In Development",  0,1110)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DeviceName", "438", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:32:50 PM", "", "In Development",  0,1103)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FromDWG_XLocation", "442", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:37:49 PM", "", "In Development",  0,1107)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FromDWG_YLocation", "443", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:38:25 PM", "", "In Development",  0,1108)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_DefaultLength", "444", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:40:17 PM", "", "In Development",  0,1111)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_Height", "445", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:41:16 PM", "", "In Development",  0,1112)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_Quantity", "446", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:42:11 PM", "", "In Development",  0,1113)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_TextScale", "470", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 4:36:58 PM", "", "In Development",  0,1138)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlock_Width", "447", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:43:28 PM", "", "In Development",  0,1114)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockDrawing_LowerLeft", "450", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:49:26 PM", "", "In Development",  0,1117)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockDrawing_UpperRight", "451", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/21/2025 2:50:30 PM", "", "In Development",  0,1118)
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
          
        InitSubpart("TBBlocks", 31, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "4/21/2025 6:27:06 PM", "", "In Development", "N",0,73,72)
        
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
          Public Function Formula_BlockPlacement_XLocation() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BlockPlacement_XLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:440; TYPE:PF
      Result = Me.FromDWG_XLocation
      '   END FORMULA; PROP ID:440; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_BlockPlacement_XLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BlockPlacement_YLocation() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BlockPlacement_YLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:441; TYPE:PF
      Result = Me.FromDWG_YLocation
      '   END FORMULA; PROP ID:441; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_BlockPlacement_YLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DeviceName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DeviceName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:438; TYPE:PF
      Result = Me.Parent.PlantName & ": Device " & Me.SubpartID
      '   END FORMULA; PROP ID:438; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_DeviceName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FromDWG_XLocation() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FromDWG_XLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:442; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:442; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_FromDWG_XLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FromDWG_YLocation() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FromDWG_YLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:443; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:443; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_FromDWG_YLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_DefaultLength() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_DefaultLength").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:444; TYPE:PF
      Result = 0.2
      '   END FORMULA; PROP ID:444; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TerminalBlock_DefaultLength", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_Height() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_Height").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:445; TYPE:PF
      Result = Me.TerminalBlock_DefaultLength * 3
      '   END FORMULA; PROP ID:445; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TerminalBlock_Height", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_Quantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_Quantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:446; TYPE:PF
      Result = 2
      '   END FORMULA; PROP ID:446; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TerminalBlock_Quantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_TextScale() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_TextScale").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:470; TYPE:PF
      Result = 0.1
      '   END FORMULA; PROP ID:470; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TerminalBlock_TextScale", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlock_Width() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlock_Width").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:447; TYPE:PF
      Result = Me.TerminalBlock_DefaultLength * me.TerminalBlock_Quantity
      '   END FORMULA; PROP ID:447; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TerminalBlock_Width", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlockDrawing_LowerLeft() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlockDrawing_LowerLeft").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:450; TYPE:PF
      Result = Me.BlockPlacement_XLocation & "," & Me.BlockPlacement_YLocation & ",0"
      '   END FORMULA; PROP ID:450; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TerminalBlockDrawing_LowerLeft", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlockDrawing_UpperRight() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlockDrawing_UpperRight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:451; TYPE:PF
      Result = Me.BlockPlacement_XLocation + Me.TerminalBlock_Width & "," & Me.BlockPlacement_YLocation + Me.TerminalBlock_Height & ",0"
      '   END FORMULA; PROP ID:451; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TerminalBlockDrawing_UpperRight", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BlockPlacement_XLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BlockPlacement_YLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeviceName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FromDWG_XLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FromDWG_YLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_DefaultLength_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Height_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Quantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_TextScale_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Width_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockDrawing_LowerLeft_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockDrawing_UpperRight_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BlockPlacement_XLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BlockPlacement_YLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeviceName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FromDWG_XLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FromDWG_YLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_DefaultLength_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Height_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Quantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_TextScale_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlock_Width_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockDrawing_LowerLeft_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockDrawing_UpperRight_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TBBlocks_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:31; TYPE:PN
      
      '   END FORMULA; SUB ID:31; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TBBlocks_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TBBlocks_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("TBBlocks").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:31; TYPE:QF
      Result = me.TerminalBlock_Quantity
      '   END FORMULA; SUB ID:31; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TBBlocks_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TBBlocks_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("TBBlocks").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:31; TYPE:OP
      result = "TBBlock"
      '   END FORMULA; SUB ID:31; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing_Device.Formula_TBBlocks_OPTIMALPARTFAMILY", ex.Message)
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

  