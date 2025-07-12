Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: SFD_sm_PRD_Base_Item
'$ GenerateDate: 07/12/2025 19:19:17

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

    Public Class [SFD_sm_PRD_Base_Item]
    
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

    Private this as SFD_sm_PRD_Base_Item = me

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
    
          Public Property [PRD_Input_Text_Tab_Formatted]() As String
      Get
      Return Properties("PRD_Input_Text_Tab_Formatted").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Input_Text_Tab_Formatted").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Line_Input_Data]() As String
      Get
      Return Properties("PRD_Line_Input_Data").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Line_Input_Data").CalculatedValue = Value
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
    InitPart("SFD_sm_PRD_Base_Item", <a><![CDATA[SubMst PRD Base Item]]></a>.Value, 371, "APCTMP01",  "N", "N", False, False, "In Development", "", "sm PRD SubMst PRD Base Item", "", "", "",  "GLOBAL\H601424", "06/18/2025 15:39:14")
    AddProperty("3879", "Debug", <a><![CDATA[Debug]]></a>.Value, "General Debuggery", "String","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 8:55:22 PM")
    AddProperty("3932", "PRD_Input_Text_Tab_Formatted", <a><![CDATA[PRD Input Text Tab Formatted]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/16/2025 5:51:29 PM")
    AddProperty("3891", "PRD_Line_Input_Data", <a><![CDATA[PRD Line Input Data]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 8:53:30 PM")
    AddProperty("4482", "Product_Class", <a><![CDATA[Product Class]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 3:02:26 PM")
    AddProperty("4484", "Product_FT", <a><![CDATA[Product_FT]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 8:45:32 PM")
    AddProperty("4485", "Product_Indentifier", <a><![CDATA[Product_Indentifier]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 2:49:46 PM")
    AddProperty("4486", "Qty", <a><![CDATA[Qty]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 1:22:28 PM")
    AddProperty("3878", "Task_ID", <a><![CDATA[Task_ID]]></a>.Value, "PRD Task ID (NOT Unique!!!)", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 12:43:36 PM")
    AddProperty("4489", "UOM", <a><![CDATA[UOM]]></a>.Value, "Unit of Masure (UOM) Extract from the PRD for this Line", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 3:39:14 PM")
    AddProperty("3877", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/16/2025 4:39:48 PM")
    
      AddValidValue("Product_Class")
    
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
          InitProperty("Debug", "3508", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 8:55:22 PM", "General Debuggery", "In Development",  0,5590)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Input_Text_Tab_Formatted", "3561", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 5:51:29 PM", "", "In Development",  0,4957)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Line_Input_Data", "3520", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 8:53:30 PM", "", "In Development",  0,5558)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Class", "4110", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 3:02:25 PM", "", "In Development",  0,5632)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_FT", "4112", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 8:45:32 PM", "", "In Development",  0,5585)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Indentifier", "4113", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 2:49:46 PM", "", "In Development",  0,5629)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty", "4114", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 1:22:28 PM", "", "In Development",  0,5621)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Task_ID", "3507", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 12:43:36 PM", "PRD Task ID (NOT Unique!!!)", "In Development",  0,5615)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UOM", "4117", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 3:39:14 PM", "Unit of Masure (UOM) Extract from the PRD for this Line", "In Development",  0,5657)
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
          
        InitValidValue("Product_Class_ValidValues", "4110", "-1", 5571)
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
          Public Function Formula_Debug() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Debug").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3508; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:3508; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_Debug", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Input_Text_Tab_Formatted() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Input_Text_Tab_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3561; TYPE:PF
      result = Me.Parent.PRD_Input_Text_Tab_Formatted
      '   END FORMULA; PROP ID:3561; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_PRD_Input_Text_Tab_Formatted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Line_Input_Data() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Line_Input_Data").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3520; TYPE:PF
      Result = ""
Dim PropName As String = Me.Name.split(":")(0).Trim() & "_VV"


If Me.Parent.ValidValues(PropName).Count > 0
	 Result = Me.Parent.ValidValues(PropName)(Me.subpartid -1)
End If
      '   END FORMULA; PROP ID:3520; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_PRD_Line_Input_Data", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:4110; TYPE:PF
      Result = ""
Dim MyName As String = Me.Name.split(":")(0).Trim()

Select Case MyName.ToLower()
	Case = "PRD_Conveyor_HCAD".ToLower()
		Result = "HCAD"
	Case =  "PRD_Conveyor_HCAD_Metric".ToLower()
		Result = "HCAD"
	Case = "PRD_Conveyor_NON_STD".ToLower()
		Result = "Non-Standard"
	Case = "PRD_Conveyor_ASRS".ToLower()
		Result = "ASRS"
	Case = "PRD_Conveyor_Electrical".ToLower()
		Result = "Electrical"
	Case Else
		Result = "ERROR"
End Select
      '   END FORMULA; PROP ID:4110; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_Product_Class", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:4112; TYPE:PF
      Result = 0.0

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Const Index As Integer = 5

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.PRD_Line_Input_Data.Split("|")(Index).Replace(",","").Replace("$","").Replace("ft(or M)","").Replace("units","").Trim()
If Isnumeric(ItemValue) Then
	Result = CDbl(ItemValue)
End If
      '   END FORMULA; PROP ID:4112; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_Product_FT", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:4113; TYPE:PF
      result = ""
result = Me.PRD_Line_Input_Data.Split("|")(1).Replace(",","").Replace("$","").Replace("ft(or M)","").Replace("units","").Trim()
      '   END FORMULA; PROP ID:4113; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_Product_Indentifier", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:4114; TYPE:PF
      Result = 0.0

Const Index As Integer = 5

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.PRD_Line_Input_Data.Split("|")(Index).Replace(",","").Replace("$","").Replace("ft(or M)","").Replace("units","").Trim()
If Isnumeric(ItemValue) Then
	Result = CDbl(ItemValue)
Else If Me.UOM = "ON/OFF"
	If ItemValue.Trim() = "ON" Then
		Result = 1
	Else
		Result = 0
	End If
	
End If
      '   END FORMULA; PROP ID:4114; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_Qty", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:3507; TYPE:PF
      Result = 0.0

Const Index As Integer = 2

'TODO: Error Handle Conversion
Result  = Me.PRD_Line_Input_Data.Split("|")(Index).Replace(",","").Replace("$","").Replace("ft(or M)","").Replace("units","").Trim()
If right(Result.Trim(),1) = "/" Then 
	Result = Result.replace("/","").Trim()
End If
      '   END FORMULA; PROP ID:3507; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_Task_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:4117; TYPE:PF
      Result = 0.0
Dim MyName As String = Me.Name.split(":")(0).Trim()
Const Index As Integer = 5

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.PRD_Line_Input_Data.Split("|")(Index)
If ItemValue.Contains("ft(or M)") Then
	Select Case MyName.ToLower()
	Case = "PRD_Conveyor_HCAD".ToLower()
		Result = "ft"
 	Case = "PRD_Conveyor_ASRS".ToLower()
		Result = "ft"
	Case = "PRD_Conveyor_HCAD_Metric".ToLower()
		Result = "M"
	Case Else
		Result = "ERROR"
	End Select
Else If ItemValue.Contains("units")
	Result = "Unit(s)"
Else If ItemValue.Contains("ON") Or ItemValue.Contains("OFF") Then
	Result = "ON/OFF"
End If
      '   END FORMULA; PROP ID:4117; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_UOM", ex.Message)
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
      Public Function Formula_PRD_Input_Text_Tab_Formatted_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Line_Input_Data_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Debug_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Input_Text_Tab_Formatted_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Line_Input_Data_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Product_Class_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Class").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4110; TYPE:VV
      'Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Lookup_Type]", "[Lookup_Type]", "WHERE [Product_Name] = " & FormatCriteria(Me.Product_Indentifier) & " ORDER BY [Priority] desc")
Result = Nothing
      '   END FORMULA; PROP ID:4110; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_sm_PRD_Base_Item.Formula_Product_Class_ValidValues", ex.Message)
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

  