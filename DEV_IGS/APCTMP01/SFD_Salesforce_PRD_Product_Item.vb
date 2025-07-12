Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: SFD_Salesforce_PRD_Product_Item

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

    Public Class [SFD_Salesforce_PRD_Product_Item]
    
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

    Private this as SFD_Salesforce_PRD_Product_Item = me

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
    
          Public Property [Cost_Escalated]() As Double
      Get
      Return Properties("Cost_Escalated").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Escalated").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Standard]() As Double
      Get
      Return Properties("Cost_Standard").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Standard").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Line_Number]() As Long
      Get
      Return Properties("Line_Number").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Line_Number").CalculatedValue = Value
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
    
          Public Property [PRD_TOTAL_DEBUG]() As String
      Get
      Return Properties("PRD_TOTAL_DEBUG").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_TOTAL_DEBUG").CalculatedValue = Value
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
    
          Public Property [USD_Per_OUM]() As Double
      Get
      Return Properties("USD_Per_OUM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("USD_Per_OUM").CalculatedValue = Value
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
    InitPart("SFD_Salesforce_PRD_Product_Item", <a><![CDATA[SFD_Salesforce_PRD_Product_Item]]></a>.Value, 164, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/17/2025 17:31:36")
    AddProperty("1441", "Debug", <a><![CDATA[Debug]]></a>.Value, "General Debuggery", "String","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:54:34 PM")
    AddProperty("1386", "Cost_Escalated", <a><![CDATA[Cost_Escalated]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 10:37:34 PM")
    AddProperty("1385", "Cost_Standard", <a><![CDATA[Cost_Standard]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 10:37:21 PM")
    AddProperty("1380", "Line_Number", <a><![CDATA[Line_Number]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 9:55:33 PM")
    AddProperty("1379", "PRD_Line_Input_Data", <a><![CDATA[PRD_Line_Input_Data]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 5:31:36 PM")
    AddProperty("1437", "PRD_TOTAL_DEBUG", <a><![CDATA[PRD_TOTAL_DEBUG]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:12:28 AM")
    AddProperty("1443", "Product_Class", <a><![CDATA[Product_Class]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/27/2025 11:06:08 AM")
    AddProperty("1384", "Product_FT", <a><![CDATA[Product_FT]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 10:52:06 PM")
    AddProperty("1381", "Product_Indentifier", <a><![CDATA[Product_Indentifier]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 10:29:16 PM")
    AddProperty("1382", "Qty", <a><![CDATA[Qty]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 10:36:52 PM")
    AddProperty("1383", "USD_Per_OUM", <a><![CDATA[USD_Per_OUM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 10:36:45 PM")
    AddProperty("928", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/25/2025 9:02:46 PM")
    
      AddValidValue("PRD_Line_Input_Data")
    
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
          InitProperty("Debug", "1140", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:54:34 PM", "", "In Development",  0,1210)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Escalated", "1085", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 10:37:34 PM", "", "In Development",  0,1203)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Standard", "1084", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 10:37:21 PM", "", "In Development",  0,1202)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Line_Number", "1079", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 9:55:29 PM", "", "In Development",  0,1176)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Line_Input_Data", "1078", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 5:31:36 PM", "", "In Development",  0,5567)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_TOTAL_DEBUG", "1136", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:12:28 AM", "", "In Development",  0,1146)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Class", "1142", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 11:06:04 AM", "", "In Development",  0,1219)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_FT", "1083", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 10:52:06 PM", "", "In Development",  0,1207)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Indentifier", "1080", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 10:29:16 PM", "", "In Development",  0,1190)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty", "1081", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 10:36:52 PM", "", "In Development",  0,1201)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("USD_Per_OUM", "1082", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 10:36:45 PM", "", "In Development",  0,1200)
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
          
        InitValidValue("PRD_Line_Input_Data_ValidValues", "1078", "-1", 1175)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Product_Class_ValidValues", "1142", "-1", 1217)
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
      '   BEGIN FORMULA; PROP ID:1140; TYPE:PF
      result = ""

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Const Index As Integer = 4

'TODO: Error Handle Conversion
Result = Me.ValidValues(VVSrcProperty)(Index).Replace(",","").Replace("$","").Replace("ft(or M)","").Replace("units","").Trim()
      '   END FORMULA; PROP ID:1140; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Debug", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Escalated() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Escalated").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1085; TYPE:PF
      Result = 0.0

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Const Index As Integer = 6

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.ValidValues(VVSrcProperty)(Index).Replace(",","").Replace("$","").Trim()
If Isnumeric(ItemValue) Then
	Result = CDbl(ItemValue)
End If
      '   END FORMULA; PROP ID:1085; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Cost_Escalated", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Standard() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Standard").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1084; TYPE:PF
      Result = 0.0

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Const Index As Integer = 5

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.ValidValues(VVSrcProperty)(Index).Replace(",","").Replace("$","").Trim()
If Isnumeric(ItemValue) Then
	Result = CDbl(ItemValue)
End If
      '   END FORMULA; PROP ID:1084; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Cost_Standard", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Line_Number() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Line_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1079; TYPE:PF
      Result = 0

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Result = Me.ValidValues(VVSrcProperty)(0)
      '   END FORMULA; PROP ID:1079; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Line_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1078; TYPE:PF
      Result = ""
	
If Me.Parent.ValidValues("PRD_Lines_Distinct_VV").Count > 0
	 Result = Me.Parent.ValidValues("PRD_Lines_Distinct_VV")(Me.subpartid -1)
End If
      '   END FORMULA; PROP ID:1078; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_PRD_Line_Input_Data", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_TOTAL_DEBUG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_TOTAL_DEBUG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1136; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:1136; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_PRD_TOTAL_DEBUG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1142; TYPE:PF
      result = ""

Const VVSrcProperty As String = "Product_Class"
Result = Me.ValidValues(VVSrcProperty).FirstValue
      '   END FORMULA; PROP ID:1142; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Product_Class", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1083; TYPE:PF
      Result = 0.0

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Const Index As Integer = 4

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.ValidValues(VVSrcProperty)(Index).Replace(",","").Replace("$","").Replace("ft(or M)","").Replace("units","").Trim()
If Isnumeric(ItemValue) Then
	Result = CDbl(ItemValue)
End If
      '   END FORMULA; PROP ID:1083; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Product_FT", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1080; TYPE:PF
      result = ""

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Result = Me.ValidValues(VVSrcProperty)(1).Trim()
      '   END FORMULA; PROP ID:1080; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Product_Indentifier", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1081; TYPE:PF
      Result = 0.0

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Const Index As Integer = 2

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.ValidValues(VVSrcProperty)(Index).Replace(",","").Replace("$","").Trim()
If Isnumeric(ItemValue) Then
	Result = CDbl(ItemValue)
End If
      '   END FORMULA; PROP ID:1081; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_USD_Per_OUM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("USD_Per_OUM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1082; TYPE:PF
      Result = 0.0

Const VVSrcProperty As String = "PRD_Line_Input_Data"
Const Index As Integer = 3

'TODO: Error Handle Conversion
Dim ItemValue As String = Me.ValidValues(VVSrcProperty)(Index).Replace(",","").Replace("$","").Trim()
If Isnumeric(ItemValue) Then
	Result = CDbl(ItemValue)
End If
      '   END FORMULA; PROP ID:1082; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_USD_Per_OUM", ex.Message)
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
      Public Function Formula_Cost_Escalated_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Standard_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Line_Number_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PRD_TOTAL_DEBUG_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_USD_Per_OUM_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Cost_Escalated_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Standard_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Line_Number_USERCHANGE() as Boolean
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
      Public Function Formula_PRD_TOTAL_DEBUG_USERCHANGE() as Boolean
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
      Public Function Formula_USD_Per_OUM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Line_Input_Data_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Line_Input_Data").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1078; TYPE:VV
      Result = New ValidValues()

Dim input As String = ""

If Me.Parent.ValidValues("PRD_Lines_Distinct_VV").Count > 0
	 input = Me.Parent.ValidValues("PRD_Lines_Distinct_VV")(Me.subpartid -1)
End If

For Each S As String In input.split("|")
	Result.add(S)
Next S
      '   END FORMULA; PROP ID:1078; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_PRD_Line_Input_Data_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      '   BEGIN FORMULA; PROP ID:1142; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Lookup_Type]", "[Lookup_Type]", "WHERE [Product_Name] = " & FormatCriteria(Me.Product_Indentifier) & " ORDER BY [Priority] desc")
      '   END FORMULA; PROP ID:1142; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Product_Item.Formula_Product_Class_ValidValues", ex.Message)
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

  