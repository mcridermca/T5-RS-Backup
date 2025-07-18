Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Sourcing_Inputs
'$ GenerateDate: 07/18/2025 11:37:15

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
    Imports IGSEST.swMateType_e
    Imports IGSEST.swMateAlign_e
    Imports IGSEST.severity

    Public Class [CAE_Sourcing_Inputs]
    
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

    Private this as CAE_Sourcing_Inputs = me

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
    
          Public Property [Debug_Mode]() As Boolean
      Get
      Return Properties("Debug_Mode").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Debug_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Labor_Type]() As String
      Get
      Return Properties("Sourcing_Labor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sourcing_Labor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Work_Week_Hours]() As Double
      Get
      Return Properties("Sourcing_Work_Week_Hours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sourcing_Work_Week_Hours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Work_Week_Type]() As String
      Get
      Return Properties("Sourcing_Work_Week_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sourcing_Work_Week_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectName]() As String
      Get
      Return Properties("XMLObjectName").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectType]() As String
      Get
      Return Properties("XMLObjectType").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectValue]() As String
      Get
      Return Properties("XMLObjectValue").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectValue").CalculatedValue = Value
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
    
      Public ReadOnly Property [Sourcing_Input]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Sourcing_Input")
      End Get
      End Property
    
      Public ReadOnly Property [MySource]() As Rulestream.Kernel.Connection
      Get
      Return Connections("MySource")
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
    InitPart("CAE_Sourcing_Inputs", <a><![CDATA[CAE_Sourcing_Inputs]]></a>.Value, 432, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/17/2025 20:25:52")
    AddProperty("10628", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "True = Debug On / False = Debug Off", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 8:00:10 PM")
    AddProperty("10623", "Sourcing_Labor_Type", <a><![CDATA[Sourcing_Labor_Type]]></a>.Value, "Mech Install^'Sourcing Inputs'!U1", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:54:29 PM")
    AddProperty("10627", "Sourcing_Work_Week_Hours", <a><![CDATA[Sourcing_Work_Week_Hours]]></a>.Value, "Mech Install^'Sourcing INputs'!V2", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 8:25:52 PM")
    AddProperty("10626", "Sourcing_Work_Week_Type", <a><![CDATA[Sourcing_Work_Week_Type]]></a>.Value, "Mech Install^'Sourcing Inputs'!U2", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:54:25 PM")
    AddProperty("10629", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "XML Export Object Name", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/17/2025 8:00:32 PM")
    AddProperty("10630", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "XML Export Object Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/17/2025 8:00:10 PM")
    AddProperty("10631", "XMLObjectValue", <a><![CDATA[XMLObjectValue]]></a>.Value, "XML Export Object Value", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/17/2025 8:00:10 PM")
    AddProperty("10609", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:19:20 PM")
    
      oSubpart = AddSubpart(347,"Sourcing_Input", <a><![CDATA[Sourcing_Input]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/17/2025 7:21:02 PM")
      
        oSubpart.AddVPF (431, "CAE_Sourcing_Input", "CAE_Sourcing_Input")
      
      oConnection = AddConnection("MySource", <a><![CDATA[My Source Part Family]]></a>.Value, "Connection to the Value Provider Part Family Instance", "202", "OO", 0, "","Oracle Config XML", 9999, "Oracle Configurator Transfer", "GLOBAL\H602502", "7/17/2025 8:00:10 PM")
      
        oConnection.AddVPF(33, "OCT_Accessory")
      
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
          InitProperty("Debug_Mode", "10196", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:00:10 PM", "True = Debug On / False = Debug Off", "In Development",  0,18938)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Labor_Type", "10191", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:53:23 PM", "", "In Development",  0,18934)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Work_Week_Hours", "10195", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:25:52 PM", "", "In Development",  0,18948)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Work_Week_Type", "10194", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:54:25 PM", "", "In Development",  0,18936)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "10197", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:00:32 PM", "XML Export Object Name", "In Development",  0,18942)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "10198", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:00:10 PM", "XML Export Object Type", "In Development",  0,18940)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectValue", "10199", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:00:10 PM", "XML Export Object Value", "In Development",  0,18941)
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
          
        InitSubpart("Sourcing_Input", 274, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 7:21:02 PM", "", "In Development", "N",0,759,760)
        
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
          
        InitConnection("MySource", "182", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 8:00:10 PM", "Connection to the Value Provider Part Family Instance", "In Development", "Y",330)
        
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
      Public Function Formula_MySource_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
          '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
        
        '   BEGIN FORMULA; CON ID:182; TYPE:PF
        Result = Nothing ' Set to Object that has the data you need to report on ' Me.Parent.HHS_Output(1)
        '   END FORMULA; CON ID:182; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_MySource_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Debug_Mode() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("Debug_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10196; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:10196; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_Debug_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Labor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Labor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10191; TYPE:PF
      Result = me.Parent.Input_Labor_Type
      '   END FORMULA; PROP ID:10191; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_Sourcing_Labor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Work_Week_Hours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Work_Week_Hours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10195; TYPE:PF
      Result = 58 ''' ToDo - Connect to application - TB 17 July, 2025
      '   END FORMULA; PROP ID:10195; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_Sourcing_Work_Week_Hours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Work_Week_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Work_Week_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10194; TYPE:PF
      Result = Me.Parent.Input_Work_Week_Type
      '   END FORMULA; PROP ID:10194; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_Sourcing_Work_Week_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("XMLObjectName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10197; TYPE:PF
      Result = "Soucing_Inputs"
      '   END FORMULA; PROP ID:10197; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_XMLObjectName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("XMLObjectType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10198; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:10198; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_XMLObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectValue() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("XMLObjectValue").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10199; TYPE:PF
      Dim Prop As PropertySF = Me.CurrentProperty
Result = Custom.GetPFXMLRepresentation(Prop) 'Generate XML For this and Children Classes
      '   END FORMULA; PROP ID:10199; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_XMLObjectValue", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_Mode_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Labor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Work_Week_Hours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Work_Week_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectValue_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_Mode_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Labor_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Work_Week_Hours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Work_Week_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectValue_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Input_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:274; TYPE:PN
      
      '   END FORMULA; SUB ID:274; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_Sourcing_Input_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Input_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sourcing_Input").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:274; TYPE:QF
      Result = me.Parent.Base_Options_Alternates.Quantity
      '   END FORMULA; SUB ID:274; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_Sourcing_Input_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Input_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sourcing_Input").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:274; TYPE:OP
      result = "CAE_Sourcing_Input"
      '   END FORMULA; SUB ID:274; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Inputs.Formula_Sourcing_Input_OPTIMALPARTFAMILY", ex.Message)
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

  