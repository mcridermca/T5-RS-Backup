Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Circuit
'$ GenerateDate: 07/21/2025 12:30:00

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

    Public Class [Circuit]
    
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

    Private this as Circuit = me

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
    
      Case "button_AssignAll_"
      Formula_button_AssignAll_WHENCHANGED(Value, OldValue)
    
      Case "button_UnassignAll_"
      Formula_button_UnassignAll_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "button_AssignAll_"
      'Formula_button_AssignAll_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "button_UnassignAll_"
      'Formula_button_UnassignAll_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [button_AssignAll]() As String
      Get
      Return Properties("button_AssignAll").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_AssignAll").CalculatedValue = Value
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
    
          Public Property [CircuitDescription]() As String
      Get
      Return Properties("CircuitDescription").Value
      End Get
      Set(ByVal Value As String)
      Properties("CircuitDescription").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CircuitPartsLabel]() As String
      Get
      Return Properties("CircuitPartsLabel").Value
      End Get
      Set(ByVal Value As String)
      Properties("CircuitPartsLabel").CalculatedValue = Value
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
    
          Public Property [InputVoltage]() As String
      Get
      Return Properties("InputVoltage").Value
      End Get
      Set(ByVal Value As String)
      Properties("InputVoltage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [OutputVoltage]() As String
      Get
      Return Properties("OutputVoltage").Value
      End Get
      Set(ByVal Value As String)
      Properties("OutputVoltage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerConsumption]() As Double
      Get
      Return Properties("PowerConsumption").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PowerConsumption").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PoweredPartsText]() As String
      Get
      Return Properties("PoweredPartsText").Value
      End Get
      Set(ByVal Value As String)
      Properties("PoweredPartsText").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerRating]() As String
      Get
      Return Properties("PowerRating").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerRating").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerRemaining]() As Double
      Get
      Return Properties("PowerRemaining").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PowerRemaining").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerUnits]() As String
      Get
      Return Properties("PowerUnits").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerUnits").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SafetyMargin]() As Long
      Get
      Return Properties("SafetyMargin").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SafetyMargin").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Tag]() As String
      Get
      Return Properties("Tag").Value
      End Get
      Set(ByVal Value As String)
      Properties("Tag").CalculatedValue = Value
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
    
      Public ReadOnly Property [PoweredParts]() As Rulestream.Kernel.Connection
      Get
      Return Connections("PoweredParts")
      End Get
      End Property
    
      Public ReadOnly Property [PowerSupplyViewNodes]() As Rulestream.Kernel.Connection
      Get
      Return Connections("PowerSupplyViewNodes")
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
    InitPart("Circuit", <a><![CDATA[Circuit]]></a>.Value, 23, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/16/2025 04:32:33")
    AddProperty("1186", "button_AssignAll", <a><![CDATA[button_Assign All]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/14/2025 10:11:52 PM")
    AddProperty("1185", "button_UnassignAll", <a><![CDATA[button_Unassign All]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/14/2025 3:51:55 PM")
    AddProperty("423", "CircuitDescription", <a><![CDATA[Circuit Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1287", "CircuitPartsLabel", <a><![CDATA[Circuit Parts Label]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/8/2025 6:13:17 PM")
    AddProperty("425", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("420", "InputVoltage", <a><![CDATA[Input Voltage]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("421", "OutputVoltage", <a><![CDATA[Output Voltage]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1174", "PowerConsumption", <a><![CDATA[Power Consumption]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/28/2025 5:44:14 AM")
    AddProperty("1181", "PoweredPartsText", <a><![CDATA[Powered Parts Text]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 3:24:33 AM")
    AddProperty("424", "PowerRating", <a><![CDATA[Power Rating]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1672", "PowerRemaining", <a><![CDATA[Power Remaining]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/16/2025 4:32:33 AM")
    AddProperty("1182", "PowerUnits", <a><![CDATA[Power Units]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/16/2025 4:27:03 AM")
    AddProperty("432", "SafetyMargin", <a><![CDATA[Safety Margin]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/27/2025 4:07:49 AM")
    AddProperty("728", "Tag", <a><![CDATA[Tag]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/28/2025 4:50:15 AM")
    AddProperty("418", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 1:37:17 AM")
    
      AddPropertyExtended(1186,"button_AssignAll", "1096", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/14/2025 10:11:52 PM")
    
      AddPropertyExtended(1185,"button_UnassignAll", "1095", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/14/2025 3:51:56 PM")
    
      AddValidValue("InputVoltage")
    
      AddValidValue("PoweredPartsText")
    
      oConnection = AddConnection("PoweredParts", <a><![CDATA[Powered Parts]]></a>.Value, "", "24", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "7/10/2025 4:27:17 AM")
      
        oConnection.AddVPF(5, "Device")
      
        oConnection.AddVPF(6, "Controller")
      
      oConnection = AddConnection("PowerSupplyViewNodes", <a><![CDATA[Power Supply View Nodes]]></a>.Value, "", "77", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "7/14/2025 2:55:38 AM")
      
        oConnection.AddVPF(17, "HBSSystem")
      
        oConnection.AddVPF(122, "DevicePhysical")
      
        oConnection.AddVPF(123, "ControllerPhysical")
      
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
          InitProperty("button_AssignAll", "1096", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/14/2025 10:11:52 PM", "", "In Development",  0,2114)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_UnassignAll", "1095", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/14/2025 3:51:55 PM", "", "In Development",  0,2110)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CircuitDescription", "402", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/8/2025 6:38:38 PM", "", "In Development",  0,971)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CircuitPartsLabel", "1188", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/8/2025 6:13:17 PM", "", "In Development",  0,2251)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "404", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/8/2025 8:00:20 PM", "", "In Development",  0,975)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("InputVoltage", "398", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "4/19/2025 4:36:16 AM", "", "In Development",  0,1074)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("OutputVoltage", "399", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/8/2025 7:12:53 PM", "", "In Development",  0,972)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumption", "1084", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/28/2025 5:44:14 AM", "", "In Development",  0,2075)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PoweredPartsText", "1091", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 3:24:33 AM", "", "In Development",  0,2089)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerRating", "403", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/8/2025 7:49:59 PM", "", "In Development",  0,974)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerRemaining", "1541", "0", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/16/2025 4:32:33 AM", "", "In Development",  0,2817)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerUnits", "1092", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/16/2025 4:27:03 AM", "", "In Development",  0,2965)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SafetyMargin", "411", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/27/2025 4:07:49 AM", "", "In Development",  0,1767)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tag", "677", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/28/2025 4:50:15 AM", "", "In Development",  0,2073)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartNumber", "401", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 12:28:01 AM", "", "In Development",  0,2088)
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
          
        InitValidValue("InputVoltage_ValidValues", "398", "-1", 1075)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PoweredPartsText_ValidValues", "1091", "-1", 2092)
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
          
        InitConnection("PoweredParts", "22", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/10/2025 4:27:17 AM", "", "In Development", "N",142)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("PowerSupplyViewNodes", "66", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/14/2025 2:55:38 AM", "", "In Development", "N",155)
        
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
      Public Function Formula_PoweredParts_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:22; TYPE:PF
        Result = New rsCollection

For Each _system In RootPart.PlantView(1).Systems
	For Each _part As Object In _system.AllParts
		For Each _partPhysical As Object In _part.Physical
			If IsConnected(_partPhysical.Circuit) AndAlso _partPhysical.Circuit(1) Is Me Then Result.Add(_partPhysical)
		Next
	Next
Next
        '   END FORMULA; CON ID:22; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PoweredParts_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyViewNodes_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:66; TYPE:PF
        Result = New rsCollection
Dim _selectedElement As Object = RootPart.PowerSupplyView(1).SelectedElement(1) 'this shouldn't be Nothing so no need to check for it

For Each _system As Object In RootPart.PlantView(1).Systems
	'include the part if the selected element is the 'Project' Or if it is this 'System'
	If _selectedElement.PartFamily <> "HBSSystem" OrElse _selectedElement Is _system Then
		Result.Add(_system)

		For Each _part As Object In _system.PowerSupplyViewNodes
			Result.Add(_part)
		Next
	End If
Next
        '   END FORMULA; CON ID:66; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PowerSupplyViewNodes_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_AssignAll() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AssignAll").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1096; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:1096; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_button_AssignAll", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1095; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:1095; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_button_UnassignAll", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CircuitDescription() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CircuitDescription").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:402; TYPE:PF
      Result = Parent.PartDescription
      '   END FORMULA; PROP ID:402; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_CircuitDescription", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CircuitPartsLabel() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CircuitPartsLabel").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1188; TYPE:PF
      Result = "All " & OutputVoltage & " Parts"
      '   END FORMULA; PROP ID:1188; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_CircuitPartsLabel", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:404; TYPE:PF
      Result = PartNumber
      '   END FORMULA; PROP ID:404; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_DisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_InputVoltage() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("InputVoltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:398; TYPE:PF
      Result = ValidValues("InputVoltage").FirstDisplayValue
      '   END FORMULA; PROP ID:398; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_InputVoltage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_OutputVoltage() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("OutputVoltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:399; TYPE:PF
      Result = (Parent.OutputVoltage.Split(";")(SubpartId - 1)).Trim()
      '   END FORMULA; PROP ID:399; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_OutputVoltage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerConsumption() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumption").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1084; TYPE:PF
      For Each _part As Object In PoweredParts
	Result += _part.PowerConsumption
Next

Result = Result * (1 + (SafetyMargin / 100))
      '   END FORMULA; PROP ID:1084; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PowerConsumption", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PoweredPartsText() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PoweredPartsText").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1091; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:1091; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PoweredPartsText", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerRating() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerRating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:403; TYPE:PF
      Result = (Parent.PowerRatingsByCircuit.Split(";")(SubpartId - 1)).Trim()
      '   END FORMULA; PROP ID:403; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PowerRating", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerRemaining() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerRemaining").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1541; TYPE:PF
      Result = Val(PowerRating) - PowerConsumption
      '   END FORMULA; PROP ID:1541; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PowerRemaining", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerUnits() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerUnits").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1092; TYPE:PF
      Result = If(OutputVoltage.ToUpper().Contains("DC"), "mA", "VA")
      '   END FORMULA; PROP ID:1092; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PowerUnits", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SafetyMargin() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SafetyMargin").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:411; TYPE:PF
      Result = Parent.SafetyMargin
      '   END FORMULA; PROP ID:411; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_SafetyMargin", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Tag() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tag").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:677; TYPE:PF
      Result = PartNumber
      '   END FORMULA; PROP ID:677; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_Tag", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:401; TYPE:PF
      Result = Parent.Tag & "." & SubpartId
      '   END FORMULA; PROP ID:401; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AssignAll_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_CircuitDescription_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CircuitPartsLabel_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_InputVoltage_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OutputVoltage_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumption_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PoweredPartsText_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRating_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRemaining_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerUnits_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Tag_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AssignAll_USERCHANGE() as Boolean
      Return True
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
              '   BEGIN FORMULA; PROP ID:1095; TYPE:UC
              Result = False

'enable this button if there's at least one part that is connected to a circuit
For Each _part As Object In PowerSupplyViewNodes
	If _part.PartFamily <> "HBSSystem" AndAlso IsConnected(_part.Circuit) AndAlso _part.Circuit(1) Is Me Then Result = True : Exit For
Next
              '   END FORMULA; PROP ID:1095; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_button_UnassignAll_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CircuitDescription_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CircuitPartsLabel_USERCHANGE() as Boolean
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
      Public Function Formula_InputVoltage_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OutputVoltage_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumption_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PoweredPartsText_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRating_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRemaining_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerUnits_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Tag_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartNumber_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_InputVoltage_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("InputVoltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:398; TYPE:VV
      Result = MakeValidValues(Parent.InputVoltage.Split(";"))
      '   END FORMULA; PROP ID:398; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_InputVoltage_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PoweredPartsText_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PoweredPartsText").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1091; TYPE:VV
      Result = New ValidValues

For Each _part As Object In PoweredParts
	Result.Add(_part.Tag)
Next

Result.Add(String.Empty)
      '   END FORMULA; PROP ID:1091; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_PoweredPartsText_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_AssignAll_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AssignAll").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1096; TYPE:WC
      Dim _devicePowerTotal As Double
Dim _safetyMarginFactor As Double = 1 + (SafetyMargin / 100)
Dim _myPowerRating As Double = Val(PowerRating)
Dim _circuit As Object

For Each _part As Object In PowerSupplyViewNodes
	If _part.PartFamily <> "HBSSystem" Then
		_circuit = If(IsConnected(_part.Circuit), _part.Circuit(1), Nothing)
		If _circuit Is Nothing OrElse _circuit = Me Then
			'include it in total power calculation
			_devicePowerTotal += _part.PowerConsumption * _safetyMarginFactor

			If _devicePowerTotal <= _myPowerRating Then
				If _circuit Is Nothing Then _part.Circuit.Connect(Me) 'connect only if not already connected
			Else 'exceeded power supply power rating including safety margin
				Exit For
			End If
		End If
	End If
Next
      '   END FORMULA; PROP ID:1096; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_button_AssignAll_WHENCHANGED", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1095; TYPE:WC
      For Each _part As Object In PowerSupplyViewNodes
	If _part.PartFamily <> "HBSSystem" AndAlso IsConnected(_part.Circuit) AndAlso _part.Circuit(1) Is Me Then _part.Circuit.RevertToCalc()
Next
      '   END FORMULA; PROP ID:1095; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Circuit.Formula_button_UnassignAll_WHENCHANGED", ex.Message)
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

  