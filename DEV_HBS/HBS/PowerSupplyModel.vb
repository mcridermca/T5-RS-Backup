Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: PowerSupplyModel
'$ GenerateDate: 07/12/2025 14:09:33

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
    Imports HBS.swMateType_e
    Imports HBS.swMateAlign_e
    Imports HBS.severity

    Public Class [PowerSupplyModel]
    
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

    Private this as PowerSupplyModel = me

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
    
      Case "button_AddPowerSupply_"
      Formula_button_AddPowerSupply_WHENCHANGED(Value, OldValue)
    
      Case "button_UnassignAll_"
      Formula_button_UnassignAll_WHENCHANGED(Value, OldValue)
    
      Case "PowerSupplyPick_"
      Formula_PowerSupplyPick_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "button_AddPowerSupply_"
      'Formula_button_AddPowerSupply_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "button_UnassignAll_"
      'Formula_button_UnassignAll_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "PowerSupplyPick_"
      'Formula_PowerSupplyPick_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [button_AddPowerSupply]() As String
      Get
      Return Properties("button_AddPowerSupply").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_AddPowerSupply").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [button_UnassignAll]() As String
      Get
      Return Properties("button_UnassignAll").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_UnassignAll").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ElementName]() As String
      Get
      Return Properties("ElementName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ElementName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerSupplyDescription]() As String
      Get
      Return Properties("PowerSupplyDescription").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerSupplyDescription").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerSupplyPick]() As String
      Get
      Return Properties("PowerSupplyPick").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerSupplyPick").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SafetyMargin]() As Double
      Get
      Return Properties("SafetyMargin").Value
      End Get
      Set(ByVal Value As Double)
      Properties("SafetyMargin").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SelectedElementIndex]() As Long
      Get
      Return Properties("SelectedElementIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SelectedElementIndex").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SelectedTransformerIndex]() As Long
      Get
      Return Properties("SelectedTransformerIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SelectedTransformerIndex").CalculatedValue = Value
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
    
      Public ReadOnly Property [PowerSupplies]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PowerSupplies")
      End Get
      End Property
    
      Public ReadOnly Property [AllParts]() As Rulestream.Kernel.Connection
      Get
      Return Connections("AllParts")
      End Get
      End Property
    
      Public ReadOnly Property [ProjectElements]() As Rulestream.Kernel.Connection
      Get
      Return Connections("ProjectElements")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedCircuit]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedCircuit")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedElement]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedElement")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedTransformer]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedTransformer")
      End Get
      End Property
    
      Public ReadOnly Property [Transformers]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Transformers")
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
    InitPart("PowerSupplyModel", <a><![CDATA[Power Supply Model]]></a>.Value, 48, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/01/2025 03:12:43")
    AddProperty("686", "button_AddPowerSupply", <a><![CDATA[button_Add Power Supply Delete]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 7:58:44 PM")
    AddProperty("1184", "button_UnassignAll", <a><![CDATA[button_Unassign All]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 5:17:41 AM")
    AddProperty("807", "ElementName", <a><![CDATA[Element Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/25/2025 8:40:28 PM")
    AddProperty("765", "PowerSupplyDescription", <a><![CDATA[Power Supply Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/23/2025 9:10:18 PM")
    AddProperty("683", "PowerSupplyPick", <a><![CDATA[Power Supply Pick]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 1:48:36 AM")
    AddProperty("852", "SafetyMargin", <a><![CDATA[Safety Margin]]></a>.Value, "%", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/1/2025 3:12:43 AM")
    AddProperty("685", "SelectedElementIndex", <a><![CDATA[Selected Element Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 5:50:56 AM")
    AddProperty("775", "SelectedTransformerIndex", <a><![CDATA[Selected Transformer Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 4:44:53 AM")
    AddProperty("682", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/18/2025 4:47:52 PM")
    
      AddPropertyExtended(686,"button_AddPowerSupply", "640", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "6/26/2025 7:58:44 PM")
    
      AddPropertyExtended(1184,"button_UnassignAll", "1094", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "6/30/2025 5:17:41 AM")
    
      AddValidValue("PowerSupplyPick")
    
      oSubpart = AddSubpart(68,"PowerSupplies", <a><![CDATA[Power Supplies]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (22, "PowerSupply", "Power Supply")
      
      oConnection = AddConnection("AllParts", <a><![CDATA[All Parts DELETE]]></a>.Value, "", "66", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "6/30/2025 6:10:02 AM")
      
        oConnection.AddVPF(5, "Device")
      
        oConnection.AddVPF(6, "Controller")
      
        oConnection.AddVPF(17, "HBSSystem")
      
      oConnection = AddConnection("ProjectElements", <a><![CDATA[Project Elements]]></a>.Value, "", "61", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(22, "PowerSupply")
      
        oConnection.AddVPF(48, "PowerSupplyModel")
      
      oConnection = AddConnection("SelectedCircuit", <a><![CDATA[Selected Circuit]]></a>.Value, "", "68", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "6/30/2025 5:52:37 AM")
      
        oConnection.AddVPF(23, "Circuit")
      
      oConnection = AddConnection("SelectedElement", <a><![CDATA[Selected Element]]></a>.Value, "", "62", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "6/30/2025 4:53:49 AM")
      
        oConnection.AddVPF(17, "HBSSystem")
      
        oConnection.AddVPF(48, "PowerSupplyModel")
      
      oConnection = AddConnection("SelectedTransformer", <a><![CDATA[Selected Transformer]]></a>.Value, "", "67", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "6/30/2025 4:53:41 AM")
      
        oConnection.AddVPF(22, "PowerSupply")
      
      oConnection = AddConnection("Transformers", <a><![CDATA[Transformers]]></a>.Value, "This is a list of power supplies that are at project level (vs. system level)", "63", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(22, "PowerSupply")
      
      AddDBConstraint(22, "AvailablePowerSupplies", <a><![CDATA[Available Power Supplies]]></a>.Value,"General", 9999)
    
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
          InitProperty("button_AddPowerSupply", "640", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/24/2025 1:21:54 AM", "", "In Development",  0,1522)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_UnassignAll", "1094", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 5:17:41 AM", "", "In Development",  0,2106)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ElementName", "747", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/25/2025 8:40:28 PM", "", "In Development",  0,1708)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupplyDescription", "709", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/23/2025 9:10:18 PM", "", "In Development",  0,1644)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupplyPick", "637", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "6/26/2025 1:48:36 AM", "", "In Development",  0,1712)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SafetyMargin", "789", "5", "100", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "7/1/2025 3:12:43 AM", "", "In Development",  0,1766)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedElementIndex", "639", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 5:50:56 AM", "", "In Development",  0,1520)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedTransformerIndex", "719", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 4:44:53 AM", "", "In Development",  0,1662)
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
          
        InitValidValue("PowerSupplyPick_ValidValues", "637", "-1", 1518)
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
          
        InitSubpart("PowerSupplies", 68, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "6/18/2025 5:07:55 PM", "", "In Development", "Y",0,162,161)
        
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
          
        InitConnection("AllParts", "59", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/30/2025 5:49:19 AM", "", "In Development", "N",125)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("ProjectElements", "55", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/18/2025 8:16:32 PM", "", "In Development", "N",100)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedCircuit", "61", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/30/2025 5:52:37 AM", "", "In Development", "N",111)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedElement", "56", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/30/2025 4:53:49 AM", "", "In Development", "N",101)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedTransformer", "60", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/30/2025 4:53:41 AM", "", "In Development", "N",110)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Transformers", "57", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/19/2025 4:34:08 AM", "", "In Development", "N",104)
        
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("AvailablePowerSupplies", 22,"", "Y","", "", "Power_Supply_Vest")
        
          InitDBproperty("AvailablePowerSupplies", "PowerSupplyDescription",22, "Part_Description", "Power_Supply_Vest")
        
          InitDBproperty("AvailablePowerSupplies", "PowerSupplyPick",22, "Part_Number", "Power_Supply_Vest")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AllParts_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:59; TYPE:PF
        Result = New rsCollection
Return Result
Dim _psType As String = String.Empty

If IsConnected(SelectedCircuit) Then
	Dim _psTypePart As String

	Dim _ckt As Object = SelectedCircuit(1)
	_psType = _ckt.OutputVoltage.Replace(" ", String.Empty).Trim().ToUpper()

	For Each _system As Object In RootPart.PlantView(1).Systems
		Result.Add(_system)

		For Each _part As Object In _system.AllParts
			_psTypePart = _part.PowerSupply.Replace(" ", String.Empty).Trim().ToUpper()

			'if the part's power supply type is exactly same as selected circuit's power supply then
			'add it to the list
			If _psType = _psTypePart Then	Result.Add(_part)
		Next
	Next
End If
        '   END FORMULA; CON ID:59; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_AllParts_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProjectElements_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:55; TYPE:PF
        Result = New rsCollection

Result.Add(Me)

For Each _element As Object In RootPart.PlantView(1).GroupTree
	If _element.PartFamily = "HBSSystem" Then Result.Add(_element)
Next
        '   END FORMULA; CON ID:55; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_ProjectElements_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedCircuit_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:61; TYPE:PF
        If IsConnected(SelectedTransformer) Then
	Dim _xfmr As Object = SelectedTransformer(1)
	Dim _cktIndex As Integer = _xfmr.SelectedCircuitIndex

	If _cktIndex > 0 Then Result = _xfmr.Circuits(_cktIndex)
End If
        '   END FORMULA; CON ID:61; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_SelectedCircuit_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedElement_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:56; TYPE:PF
        Dim _selectedIndex As Integer = SelectedElementIndex

If _selectedIndex > 0 Then Result = ProjectElements(_selectedIndex)
        '   END FORMULA; CON ID:56; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_SelectedElement_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedTransformer_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:60; TYPE:PF
        Result = New rsCollection

If IsConnected(SelectedElement) Then
	Dim _element As Object = SelectedElement(1)
	Dim _psIndex As Integer = _element.SelectedTransformerIndex

	If _psIndex > 0 Then
		Result = _element.Transformers(_psIndex)
	End If
End If
        '   END FORMULA; CON ID:60; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_SelectedTransformer_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transformers_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:57; TYPE:PF
        Result = New rsCollection

For Each _ps As Object In PowerSupplies
	'if it is not assigned to a specific system, it is a project level power supply
	If Not IsConnected(_ps.HBSSystem) Then Result.Add(_ps)
Next
        '   END FORMULA; CON ID:57; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_Transformers_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_AddPowerSupply() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:640; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:640; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_button_AddPowerSupply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_UnassignAll() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_UnassignAll").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1094; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:1094; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_button_UnassignAll", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ElementName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ElementName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:747; TYPE:PF
      Result = RootPart.CORA_Info(1).ERP_Project_Description
      '   END FORMULA; PROP ID:747; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_ElementName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerSupplyDescription() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyDescription").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:709; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:709; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_PowerSupplyDescription", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerSupplyPick() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyPick").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:637; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:637; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_PowerSupplyPick", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SafetyMargin() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SafetyMargin").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:789; TYPE:PF
      Result = 15.0
      '   END FORMULA; PROP ID:789; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_SafetyMargin", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedElementIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedElementIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:639; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:639; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_SelectedElementIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedTransformerIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedTransformerIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:719; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:719; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_SelectedTransformerIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddPowerSupply_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_UnassignAll_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ElementName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyDescription_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyPick_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SafetyMargin_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedElementIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedTransformerIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddPowerSupply_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("button_AddPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:640; TYPE:UC
              Result = IsConnected(SelectedElement) AndAlso PowerSupplyPick.Length > 0
              '   END FORMULA; PROP ID:640; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_button_AddPowerSupply_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_UnassignAll_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("button_UnassignAll").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1094; TYPE:UC
              Result = False

For Each _part As Object In AllParts
	If _part.AssignedPowerSupply.Length > 0 Then Result = True : Exit For
Next
              '   END FORMULA; PROP ID:1094; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_button_UnassignAll_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ElementName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyDescription_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyPick_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SafetyMargin_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedElementIndex_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedTransformerIndex_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyPick_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyPick").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:637; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[Power_Supply_Vest]", "[Part_Number]", "[Part_Number] + '-' + [Part_Description]", String.Empty)
Result.Add(String.Empty, String.Empty)
      '   END FORMULA; PROP ID:637; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_PowerSupplyPick_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplies_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:68; TYPE:PN
      
      '   END FORMULA; SUB ID:68; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_PowerSupplies_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplies_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PowerSupplies").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:68; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:68; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_PowerSupplies_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplies_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PowerSupplies").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:68; TYPE:OP
      result = "PowerSupply"
      '   END FORMULA; SUB ID:68; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_PowerSupplies_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_AddPowerSupply_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:640; TYPE:WC
      Dim _selectedItem As Object = SelectedElement(1)
Dim _newPowerSupply As Object = Subparts("PowerSupplies").AddPart("PowerSupply")

_newPowerSupply.Properties("PartNumber").InputValue = PowerSupplyPick

Select Case _selectedItem.PartFamily
	Case "HBSSystem" : _newPowerSupply.HBSSystem.Connect(_selectedItem)
End Select
      '   END FORMULA; PROP ID:640; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_button_AddPowerSupply_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_UnassignAll_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_UnassignAll").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1094; TYPE:WC
      For Each _part As Object In AllParts
	If _part.AssignedPowerSupply.Length > 0 Then _part.Properties("AssignedPowerSupply").RevertToCalc()
Next
      '   END FORMULA; PROP ID:1094; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_button_UnassignAll_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_PowerSupplyPick_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyPick").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:637; TYPE:WC
      Dim _me As Object = Properties("PowerSupplyPick")

If Not _me.UseCalculatedValue Then 'if it is user-input
	Dim _psPartNumber As String = Value
	If _psPartNumber IsNot Nothing AndAlso _psPartNumber.Length > 0 Then
		Dim _selectedItem As Object = SelectedElement(1)
		Dim _newPowerSupply As Object = Subparts("PowerSupplies").AddPart("PowerSupply")

		_newPowerSupply.Properties("PartNumber").InputValue = _psPartNumber

		Select Case _selectedItem.PartFamily
			Case "HBSSystem" : _newPowerSupply.HBSSystem.Connect(_selectedItem)
		End Select

		Properties("PowerSupplyDescription").RevertToCalc()
	End If

	_me.RevertToCalc()
End If
      '   END FORMULA; PROP ID:637; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.Formula_PowerSupplyPick_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Function GetRecordsetSQL(ByVal lngDBConID as Long) as String Implements RuleStream.IRsPartFormulas.GetRecordsetSQL
    Dim strSelectStmt As String = ""
    
      Dim strWhereClause as String = ""
      Dim strSelectList as String = ""
      Dim varPropSpecVal As Object
      Dim ctx As Object
      Dim leftDelimiter As String = String.Empty
      Dim rightDelimiter As String = String.Empty
      Try
      Select Case g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.MSAccess, RuleStream.DataService.PublicEnumerations.DatabaseTypes.SQLServer
      leftDelimiter = "["
      rightDelimiter = "]"
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.Oracle
      leftDelimiter = """"
      rightDelimiter = """"
      End Select
      ObjectManager.UnitConversion = False
      'Used to set the parameters results
      Select Case lngDBConID
      
        Case 22
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Part_Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Number" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("Power_Supply_Vest"), strWhereClause, leftDelimiter & "" & rightDelimiter, "")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupplyModel.GetRecordset", strError)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      ObjectManager.UnitConversion = True
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

  