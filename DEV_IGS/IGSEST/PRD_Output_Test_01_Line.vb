Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: PRD_Output_Test_01_Line
'$ GenerateDate: 07/16/2025 15:31:09

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

    Public Class [PRD_Output_Test_01_Line]
    
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

    Private this as PRD_Output_Test_01_Line = me

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
    
          Public Property [Debug]() As String
      Get
      Return Properties("Debug").Value
      End Get
      Set(ByVal Value As String)
      Properties("Debug").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Debug_Mode]() As Boolean
      Get
      Return Properties("Debug_Mode").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Debug_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Class]() As String
      Get
      Return Properties("Product_Class").Value
      End Get
      Set(ByVal Value As String)
      Properties("Product_Class").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_FT]() As Double
      Get
      Return Properties("Product_FT").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Product_FT").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Indentifier]() As String
      Get
      Return Properties("Product_Indentifier").Value
      End Get
      Set(ByVal Value As String)
      Properties("Product_Indentifier").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Qty]() As Double
      Get
      Return Properties("Qty").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Task_ID]() As String
      Get
      Return Properties("Task_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Task_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UOM]() As String
      Get
      Return Properties("UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("UOM").CalculatedValue = Value
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
    InitPart("PRD_Output_Test_01_Line", <a><![CDATA[PRD_Output_Test_01_Line]]></a>.Value, 426, "IGSEST",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/16/2025 15:31:01")
    AddProperty("10417", "Debug", <a><![CDATA[Debug]]></a>.Value, "General Debuggery", "String","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:24:14 PM")
    AddProperty("10396", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "True = Debug On / False = Debug Off", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 2:41:31 PM")
    AddProperty("10418", "Product_Class", <a><![CDATA[Product Class]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:28:21 PM")
    AddProperty("10419", "Product_FT", <a><![CDATA[Product_FT]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:31:01 PM")
    AddProperty("10420", "Product_Indentifier", <a><![CDATA[Product_Indentifier]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:28:38 PM")
    AddProperty("10421", "Qty", <a><![CDATA[Qty]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:28:52 PM")
    AddProperty("10422", "Task_ID", <a><![CDATA[Task_ID]]></a>.Value, "PRD Task ID (NOT Unique!!!)", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:29:00 PM")
    AddProperty("10423", "UOM", <a><![CDATA[UOM]]></a>.Value, "Unit of Masure (UOM) Extract from the PRD for this Line", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:29:07 PM")
    AddProperty("10397", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "XML Export Object Name", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "7/16/2025 2:43:03 PM")
    AddProperty("10398", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "XML Export Object Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "7/16/2025 2:41:31 PM")
    AddProperty("10399", "XMLObjectValue", <a><![CDATA[XMLObjectValue]]></a>.Value, "XML Export Object Value", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "7/16/2025 2:41:31 PM")
    AddProperty("10395", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 2:40:09 PM")
    
      AddValidValue("Product_Class")
    
      oConnection = AddConnection("MySource", <a><![CDATA[My Source Part Family]]></a>.Value, "Connection to the Value Provider Part Family Instance", "192", "OO", 0, "","Oracle Config XML", 9999, "Oracle Configurator Transfer", "GLOBAL\H601424", "7/16/2025 2:46:37 PM")
      
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
          InitProperty("Debug", "9990", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:24:14 PM", "General Debuggery", "In Development",  0,18142)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Debug_Mode", "9970", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 2:41:31 PM", "True = Debug On / False = Debug Off", "In Development",  0,18080)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Class", "9991", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:28:21 PM", "", "In Development",  0,18151)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_FT", "9992", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:31:01 PM", "", "In Development",  0,18158)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Indentifier", "9993", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:28:38 PM", "", "In Development",  0,18153)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty", "9994", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:28:52 PM", "", "In Development",  0,18155)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Task_ID", "9995", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:29:00 PM", "PRD Task ID (NOT Unique!!!)", "In Development",  0,18156)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UOM", "9996", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:29:07 PM", "Unit of Masure (UOM) Extract from the PRD for this Line", "In Development",  0,18157)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "9971", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 2:42:59 PM", "XML Export Object Name", "In Development",  0,18085)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "9972", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 2:41:31 PM", "XML Export Object Type", "In Development",  0,18082)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectValue", "9973", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 2:41:31 PM", "XML Export Object Value", "In Development",  0,18083)
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
          
        InitValidValue("Product_Class_ValidValues", "9991", "-1", 18144)
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
          
        InitConnection("MySource", "172", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/16/2025 2:46:13 PM", "Connection to the Value Provider Part Family Instance", "In Development", "Y",314)
        
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
        '   BEGIN FORMULA; CON ID:172; TYPE:PF
        Result = Me.Parent.MySource(1).All_PRD_Product_Items(Me.SubpartID) ' Set to Object that has the data you need to report on ' Me.Parent.HHS_Output(1)
        '   END FORMULA; CON ID:172; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_MySource_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Debug() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Debug").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9990; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9990; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Debug", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      '   BEGIN FORMULA; PROP ID:9970; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:9970; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Debug_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Class() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Class").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9991; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9991; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Product_Class", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_FT() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_FT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9992; TYPE:PF
      Result = 0
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9992; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Product_FT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Indentifier() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Indentifier").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9993; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9993; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Product_Indentifier", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9994; TYPE:PF
      Result = 0
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9994; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Task_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Task_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9995; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9995; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Task_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9996; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9996; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9971; TYPE:PF
      Result = "PRD_Output_Test_Line"
      '   END FORMULA; PROP ID:9971; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_XMLObjectName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9972; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:9972; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_XMLObjectType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9973; TYPE:PF
      Dim Prop As PropertySF = Me.CurrentProperty
Result = Custom.GetPFXMLRepresentation(Prop) 'Generate XML For this and Children Classes
      '   END FORMULA; PROP ID:9973; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_XMLObjectValue", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_Product_Class_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_FT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Indentifier_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Task_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UOM_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Debug_USERCHANGE() as Boolean
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
      Public Function Formula_Product_Class_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_FT_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Indentifier_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Task_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UOM_USERCHANGE() as Boolean
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
      Public Function Formula_Product_Class_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Class").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9991; TYPE:VV
      'Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Lookup_Type]", "[Lookup_Type]", "WHERE [Product_Name] = " & FormatCriteria(Me.Product_Indentifier) & " ORDER BY [Priority] desc")
Result = Nothing
      '   END FORMULA; PROP ID:9991; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01_Line.Formula_Product_Class_ValidValues", ex.Message)
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

  