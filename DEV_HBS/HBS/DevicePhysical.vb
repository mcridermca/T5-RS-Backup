Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: DevicePhysical
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

    Public Class [DevicePhysical]
    
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

    Private this as DevicePhysical = me

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
    
      Case "SelectedForPowerSupply_"
      Formula_SelectedForPowerSupply_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "SelectedForPowerSupply_"
      'Formula_SelectedForPowerSupply_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [ElementName]() As String
      Get
      Return Properties("ElementName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ElementName").CalculatedValue = Value
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
    
          Public Property [PowerConsumption]() As String
      Get
      Return Properties("PowerConsumption").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerConsumption").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerConsumptionDisplay]() As String
      Get
      Return Properties("PowerConsumptionDisplay").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerConsumptionDisplay").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [RowIconPowerSupplyAvailability]() As String
      Get
      Return Properties("RowIconPowerSupplyAvailability").Value
      End Get
      Set(ByVal Value As String)
      Properties("RowIconPowerSupplyAvailability").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SelectedForPowerSupply]() As Boolean
      Get
      Return Properties("SelectedForPowerSupply").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("SelectedForPowerSupply").CalculatedValue = Value
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
    
      Public ReadOnly Property [Circuit]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Circuit")
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
    InitPart("DevicePhysical", <a><![CDATA[Device Physical]]></a>.Value, 122, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/10/2025 04:37:43")
    AddProperty("1528", "ElementName", <a><![CDATA[Element Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/10/2025 4:36:53 AM")
    AddProperty("1515", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/10/2025 4:28:47 AM")
    AddProperty("1517", "PowerConsumption", <a><![CDATA[Power Consumption]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/10/2025 4:02:44 AM")
    AddProperty("1518", "PowerConsumptionDisplay", <a><![CDATA[Power Consumption Display]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/10/2025 4:04:32 AM")
    AddProperty("1520", "RowIconPowerSupplyAvailability", <a><![CDATA[Row Icon Power Supply Availability]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/10/2025 4:24:02 AM")
    AddProperty("1519", "SelectedForPowerSupply", <a><![CDATA[Selected For Power Supply]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/10/2025 4:24:22 AM")
    AddProperty("1516", "Tag", <a><![CDATA[Tag]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/10/2025 4:37:43 AM")
    
      oConnection = AddConnection("Circuit", <a><![CDATA[Circuit]]></a>.Value, "", "78", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/10/2025 3:08:39 AM")
      
        oConnection.AddVPF(23, "Circuit")
      
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
          InitProperty("ElementName", "1409", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/10/2025 4:36:53 AM", "", "In Development",  0,2527)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartNumber", "1405", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/10/2025 4:28:47 AM", "", "In Development",  0,2523)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumption", "1397", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/10/2025 4:02:44 AM", "", "In Development",  0,2507)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumptionDisplay", "1398", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/10/2025 4:04:32 AM", "", "In Development",  0,2508)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RowIconPowerSupplyAvailability", "1400", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/10/2025 4:24:02 AM", "", "In Development",  0,2521)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedForPowerSupply", "1399", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/10/2025 4:24:22 AM", "", "In Development",  0,2509)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tag", "1396", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/10/2025 4:37:43 AM", "", "In Development",  0,2505)
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
            If Incontext("-1", ctx) Then
          
        InitConnection("Circuit", "70", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/10/2025 3:08:39 AM", "", "In Development", "Y",139)
        
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
      Public Function Formula_Circuit_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:70; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:70; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_Circuit_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:1409; TYPE:PF
      Result = Tag
      '   END FORMULA; PROP ID:1409; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_ElementName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1405; TYPE:PF
      Result = Parent.PartNumber
      '   END FORMULA; PROP ID:1405; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_PartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerConsumption() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumption").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1397; TYPE:PF
      Result = Parent.PowerConsumption
      '   END FORMULA; PROP ID:1397; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_PowerConsumption", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerConsumptionDisplay() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumptionDisplay").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1398; TYPE:PF
      Result = PowerConsumption & " " & If(Parent.PowerSupply.ToUpper().Contains("AC"), "VA", "mA")
      '   END FORMULA; PROP ID:1398; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_PowerConsumptionDisplay", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_RowIconPowerSupplyAvailability() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RowIconPowerSupplyAvailability").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1400; TYPE:PF
      Dim _available As Boolean

If Not IsConnected(Circuit) Then
	If Parent.PowerSupply.ToUpper().Trim() = "N/A" Then
		_available = False
	Else
		_available = True
	End If
Else 'connected to a circuit
	Dim _selectedCircuit As Object = If(IsConnected(RootPart.PowerSupplyView(1).SelectedCircuit), RootPart.PowerSupplyView(1).SelectedCircuit(1), Nothing)

	_available = _selectedCircuit IsNot Nothing AndAlso _selectedCircuit Is Circuit(1)
End If

Result = If(_available, "Green Hand Point Right.png", "Red Hand Stop.png")
      '   END FORMULA; PROP ID:1400; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_RowIconPowerSupplyAvailability", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedForPowerSupply() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedForPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1399; TYPE:PF
      Result = IsConnected(Circuit) AndAlso IsConnected(RootPart.PowerSupplyView(1).SelectedCircuit) AndAlso RootPart.PowerSupplyView(1).SelectedCircuit(1) Is Circuit(1)
      '   END FORMULA; PROP ID:1399; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_SelectedForPowerSupply", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1396; TYPE:PF
      Result = PartNumber & "-" & Parent.DeviceIndex & "-" & SubpartId
      '   END FORMULA; PROP ID:1396; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_Tag", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_PartNumber_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PowerConsumptionDisplay_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RowIconPowerSupplyAvailability_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedForPowerSupply_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ElementName_USERCHANGE() as Boolean
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
      Public Function Formula_PowerConsumption_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumptionDisplay_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RowIconPowerSupplyAvailability_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedForPowerSupply_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("SelectedForPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1399; TYPE:UC
              If Parent.PowerSupply.ToUpper().Trim() = "N/A" Then
	Result = False
Else
	Result = Not IsConnected(Circuit) OrElse (IsConnected(RootPart.PowerSupplyView(1).SelectedCircuit) AndAlso RootPart.PowerSupplyView(1).SelectedCircuit(1) Is Circuit(1))
End If
              '   END FORMULA; PROP ID:1399; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_SelectedForPowerSupply_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tag_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_SelectedForPowerSupply_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedForPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1399; TYPE:WC
      Dim _me As Object = Properties("SelectedForPowerSupply")

If Not _me.UseCalculatedValue Then
	If Value Then
		If IsConnected(RootPart.PowerSupplyView(1).SelectedCircuit) Then
			Dim _ckt As Object = RootPart.PowerSupplyView(1).SelectedCircuit(1)
			Dim _cktPowerRating As Double = Val(_ckt.PowerRating)
			Dim _cktPowerConsumption As Double = _ckt.PowerConsumption
			Dim _cktSafetyMargin As Double = _ckt.SafetyMargin

			If PowerConsumption * (1 + (_cktSafetyMargin / 100)) + _cktPowerConsumption > _cktPowerRating Then
				MessageBox.Show("Cannot assign device! Assigning it will exceed power supply rating", "Assign Device to Power Supply", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else 'total power consumption lower than power rating
				Circuit.Connect(_ckt)
			End If
		End If
	Else
		Circuit.RevertToCalc()
	End If

	_me.RevertToCalc()
End If
      '   END FORMULA; PROP ID:1399; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " DevicePhysical.Formula_SelectedForPowerSupply_WHENCHANGED", ex.Message)
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

  