Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Control_Panels_Structures_Platforms
'$ GenerateDate: 07/12/2025 13:20:28

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

    Public Class [CAE_Control_Panels_Structures_Platforms]
    
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

    Private this as CAE_Control_Panels_Structures_Platforms = me

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
    
          Public Property [BarGratingFootage]() As Double
      Get
      Return Properties("BarGratingFootage").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BarGratingFootage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BarGratingHours]() As Double
      Get
      Return Properties("BarGratingHours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BarGratingHours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CatwalkHours]() As Double
      Get
      Return Properties("CatwalkHours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("CatwalkHours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CatwalkLinearFeet]() As Double
      Get
      Return Properties("CatwalkLinearFeet").Value
      End Get
      Set(ByVal Value As Double)
      Properties("CatwalkLinearFeet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CPNumber]() As String
      Get
      Return Properties("CPNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("CPNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [GridStructureFootage]() As Double
      Get
      Return Properties("GridStructureFootage").Value
      End Get
      Set(ByVal Value As Double)
      Properties("GridStructureFootage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [GridStructureHours]() As Double
      Get
      Return Properties("GridStructureHours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("GridStructureHours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LadderHours]() As Double
      Get
      Return Properties("LadderHours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("LadderHours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ResindeckFootage]() As Double
      Get
      Return Properties("ResindeckFootage").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ResindeckFootage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ResindeckHours]() As Double
      Get
      Return Properties("ResindeckHours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ResindeckHours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [StairHours]() As Double
      Get
      Return Properties("StairHours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("StairHours").CalculatedValue = Value
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
    
          Public Shadows Property [DisplayName]() As String
      Get
      Return Properties("DisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("DisplayName").CalculatedValue = Value
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
    InitPart("CAE_Control_Panels_Structures_Platforms", <a><![CDATA[CAE_Control_Panels_Structures_Platforms]]></a>.Value, 387, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "06/27/2025 19:19:43")
    AddProperty("5320", "BarGratingFootage", <a><![CDATA[Bar Grating Footage]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 5:19:39 PM")
    AddProperty("5319", "BarGratingHours", <a><![CDATA[Bar Grating Hours]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 5:21:22 PM")
    AddProperty("5323", "CatwalkHours", <a><![CDATA[Catwalk Hours]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 7:18:02 PM")
    AddProperty("5324", "CatwalkLinearFeet", <a><![CDATA[Catwalk Linear Feet]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 7:17:35 PM")
    AddProperty("5317", "CPNumber", <a><![CDATA[CP Number]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 1:23:02 PM")
    AddProperty("5322", "GridStructureFootage", <a><![CDATA[Grid Structure Footage]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 5:19:11 PM")
    AddProperty("5321", "GridStructureHours", <a><![CDATA[Grid Structure Hours]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 5:18:55 PM")
    AddProperty("5326", "LadderHours", <a><![CDATA[Ladder Hours]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 7:19:18 PM")
    AddProperty("5318", "ResindeckFootage", <a><![CDATA[Resindeck Footage]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 5:19:48 PM")
    AddProperty("5316", "ResindeckHours", <a><![CDATA[Resindeck Hours]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 3:14:57 PM")
    AddProperty("5325", "StairHours", <a><![CDATA[Stair Hours]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 7:19:43 PM")
    AddProperty("5297", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 11:53:42 AM")
    AddProperty("5327", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 12:53:42 PM")
    
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
          InitProperty("BarGratingFootage", "4933", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 5:19:39 PM", "", "In Development",  0,8171)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BarGratingHours", "4932", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 5:21:22 PM", "", "In Development",  0,8174)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CatwalkHours", "4936", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 7:18:02 PM", "", "In Development",  0,8197)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CatwalkLinearFeet", "4937", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 7:17:35 PM", "", "In Development",  0,8196)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CPNumber", "4930", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 1:23:02 PM", "", "In Development",  0,7577)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("GridStructureFootage", "4935", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 5:19:11 PM", "", "In Development",  0,8169)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("GridStructureHours", "4934", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 5:18:55 PM", "", "In Development",  0,8168)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LadderHours", "4939", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 7:19:18 PM", "", "In Development",  0,8198)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ResindeckFootage", "4931", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 5:19:48 PM", "", "In Development",  0,8172)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ResindeckHours", "4929", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 3:14:57 PM", "", "In Development",  0,8114)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("StairHours", "4938", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 7:19:43 PM", "", "In Development",  0,8199)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "4940", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 12:53:42 PM", "", "In Development",  0,7565)
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
          Public Function Formula_BarGratingFootage() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BarGratingFootage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4933; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).BarGratingFootage
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Structure_Sq_Ft_Catwalk_Linear")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Bar Grating Platform" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4933; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_BarGratingFootage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BarGratingHours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BarGratingHours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4932; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).BarGratingHours
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Hours_Platform_Structure_Catwalk")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Bar Grating Platform" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4932; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_BarGratingHours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CatwalkHours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CatwalkHours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4936; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).CatwalkHours
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Hours_Platform_Structure_Catwalk")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Catwalk" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4936; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_CatwalkHours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CatwalkLinearFeet() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CatwalkLinearFeet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4937; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).CatwalkLinearFeet
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Structure_Sq_Ft_Catwalk_Linear")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Catwalk" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4937; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_CatwalkLinearFeet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CPNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CPNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4930; TYPE:PF
      Select Case Me.SubpartID
	Case 1
		Result = "Total"
	Case Else
		Result = Me.Parent.Parent.Control_Panels(Me.SubpartID - 1).DATA_CPNumber
End Select
      '   END FORMULA; PROP ID:4930; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_CPNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_GridStructureFootage() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("GridStructureFootage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4935; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).GridStructureFootage
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Structure_Sq_Ft_Catwalk_Linear")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Grid Structure" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4935; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_GridStructureFootage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_GridStructureHours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("GridStructureHours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4934; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).GridStructureHours
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Hours_Platform_Structure_Catwalk")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Grid Structure" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4934; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_GridStructureHours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LadderHours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LadderHours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4939; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).LadderHours
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propVal As PropertySF = item.Properties("Hours_Ladders")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4939; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_LadderHours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ResindeckFootage() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ResindeckFootage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4931; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).ResindeckFootage
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Structure_Sq_Ft_Catwalk_Linear")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Resindeck Platform" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4931; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_ResindeckFootage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ResindeckHours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ResindeckHours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4929; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).ResindeckHours
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Hours_Platform_Structure_Catwalk")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Resindeck Platform" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4929; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_ResindeckHours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_StairHours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("StairHours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4938; TYPE:PF
      Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).StairHours
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propVal As PropertySF = item.Properties("Hours_Stairs")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
      '   END FORMULA; PROP ID:4938; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_StairHours", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:4940; TYPE:PF
      Select Case Me.SubpartID
	Case 1
		Result = "CP Total"
	Case Else
		Result = Me.CPNumber
End Select
      '   END FORMULA; PROP ID:4940; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_DisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BarGratingFootage_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BarGratingHours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CatwalkHours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CatwalkLinearFeet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GridStructureFootage_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GridStructureHours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LadderHours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ResindeckFootage_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ResindeckHours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_StairHours_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_BarGratingFootage_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BarGratingHours_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("BarGratingHours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:4932; TYPE:UC
              Result = 0
Dim count As Double = 0

Select Case Me.SubpartID
	Case 1
		
		Dim cps As Integer = Me.Parent.Control_Panels.Quantity
		Dim i As Integer = 2
		
		While i <= cps
			Result += Me.Parent.Control_Panels(i).BarGratingHours
			i += 1
		End While
		
	Case Else

		For Each item As Rulestream.Kernel.Part In Me.Parent.Structure_Platform.Parts
			Dim propItem As PropertySF = item.Properties("Subsystem")
			Dim propType As PropertySF = item.Properties("Structure_Platform_Catwalk_Type")
			Dim propVal As PropertySF = item.Properties("Hours_Platform_Structure_Catwalk")
			Dim dblVal As Double = propVal.Value
	
			If propItem.Value.ToString() = Me.CPNumber AndAlso propType.Value = "Bar Grating Platform" Then
		
				count += dblVal	
		
			End If
	
		Next

Result = count

End Select
              '   END FORMULA; PROP ID:4932; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_Control_Panels_Structures_Platforms.Formula_BarGratingHours_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CatwalkHours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CatwalkLinearFeet_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GridStructureFootage_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GridStructureHours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LadderHours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ResindeckFootage_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ResindeckHours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_StairHours_USERCHANGE() as Boolean
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

  