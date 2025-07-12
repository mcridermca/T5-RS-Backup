Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Scan_Panel_Configuration

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

    Public Class [APC_Scan_Panel_Configuration]
    
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

    Private this as APC_Scan_Panel_Configuration = me

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
    
          Public Property [Is_Scanned]() As Boolean
      Get
      Return Properties("Is_Scanned").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_Scanned").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Min_Gap_Required]() As Double
      Get
      Return Properties("Min_Gap_Required").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Min_Gap_Required").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Panel_ID]() As String
      Get
      Return Properties("Panel_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Panel_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Spacing_Category]() As Double
      Get
      Return Properties("Product_Spacing_Category").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Product_Spacing_Category").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scan_Angle_Degrees]() As Double
      Get
      Return Properties("Scan_Angle_Degrees").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scan_Angle_Degrees").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scan_Head_Location]() As Double
      Get
      Return Properties("Scan_Head_Location").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scan_Head_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scan_Type]() As String
      Get
      Return Properties("Scan_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scan_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_CCD_Position]() As String
      Get
      Return Properties("Scanner_CCD_Position").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scanner_CCD_Position").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_Selected]() As String
      Get
      Return Properties("Scanner_Selected").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scanner_Selected").CalculatedValue = Value
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
    InitPart("APC_Scan_Panel_Configuration", <a><![CDATA[APC_Scan_Panel_Configuration]]></a>.Value, 418, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/12/2025 13:19:00")
    AddProperty("9943", "Is_Scanned", <a><![CDATA[Is_Scanned]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:28:07 PM")
    AddProperty("9983", "Min_Gap_Required", <a><![CDATA[Min_Gap_Required]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:15:49 PM")
    AddProperty("9942", "Panel_ID", <a><![CDATA[Panel_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:26:55 PM")
    AddProperty("9957", "Product_Spacing_Category", <a><![CDATA[Product_Spacing_Category]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 12:05:35 PM")
    AddProperty("9950", "Scan_Angle_Degrees", <a><![CDATA[Scan_Angle_Degrees]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 12:05:01 PM")
    AddProperty("9958", "Scan_Head_Location", <a><![CDATA[Scan_Head_Location]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 12:16:51 PM")
    AddProperty("9945", "Scan_Type", <a><![CDATA[Scan_Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:38:33 PM")
    AddProperty("9946", "Scanner_CCD_Position", <a><![CDATA[Scanner_CCD_Position]]></a>.Value, "Scanner CCD Position", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:19:00 PM")
    AddProperty("9944", "Scanner_Selected", <a><![CDATA[Scanner_Selected]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:32:38 PM")
    AddProperty("9941", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:02:49 PM")
    
      AddValidValue("Scanner_CCD_Position")
    
      AddValidValue("Scanner_Selected")
    
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
          InitProperty("Is_Scanned", "9525", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:28:07 PM", "", "In Development",  0,16541)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Min_Gap_Required", "9565", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:15:49 PM", "", "In Development",  0,16674)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Panel_ID", "9524", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:26:55 PM", "", "In Development",  0,16540)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Spacing_Category", "9539", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 12:05:35 PM", "", "In Development",  0,16612)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scan_Angle_Degrees", "9532", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 12:05:01 PM", "", "In Development",  0,16611)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scan_Head_Location", "9540", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 12:16:51 PM", "", "In Development",  0,16614)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scan_Type", "9527", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:38:29 PM", "", "In Development",  0,16550)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_CCD_Position", "9528", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:18:42 PM", "", "In Development",  0,16682)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_Selected", "9526", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:32:38 PM", "", "In Development",  0,16543)
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
          
        InitValidValue("Scanner_CCD_Position_ValidValues", "9528", "-1", 16565)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Scanner_Selected_ValidValues", "9526", "-1", 16545)
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
          Public Function Formula_Is_Scanned() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_Scanned").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9525; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:9525; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Is_Scanned", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Min_Gap_Required() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Min_Gap_Required").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9565; TYPE:PF
      Result = 0.0

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Select Case Me.Panel_ID
		Case  "Top"
			' =IF(AND(OR(C93="YES",C94="Yes"),H93="Overhead"),45,90)
				'C93 = Front Scanded
				'C94 = Back Scanned
			If (FrontScanned OrElse BackScanned ) AndAlso FrontScanned_Overhead Then
            	Return 45  ' Condition is true
        	Else
            	Return 90  ' Condition is false
        	End If
		Case  "Bottom"
			Result = 45
		Case "Left","Right"
			'=IF(OR(AND(C93="YES",OR(H93="1 Side",H93="2 Sides")),AND(C94="Yes",OR(H93="1 Side",H93="2 Sides"))),45,90)
			'=IF(OR(AND(FrontScanned=TRUE, OR(FrontScanned_1Side ,FrontScanned_2Side)),AND(BackScanned,OR(FrontScanned_1Side,FrontScanned_2Side))),45,90)
			 If ((FrontScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side)) OrElse _
            	(BackScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side))) Then
            	
            	Return 45  ' At least one condition is true
        	Else
            	Return 90  ' Both conditions are false
        	End If
		Case "Front", "Back"
					
			Result = 45
	 End Select

End If
      '   END FORMULA; PROP ID:9565; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Min_Gap_Required", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Panel_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Panel_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9524; TYPE:PF
      Result = ""
Select Case Me.SubpartID
	Case 1 
			Result = "Top"
		Case 2 
			Result = "Bottom"
		Case 3 
			Result = "Left"
		Case 4
			 Result = "Right"
		 Case 5
			 Result = "Front"
		 Case 6
			 Result = "Back"
		 Case Else
			 Result = "ERROR!"
	 End Select
      '   END FORMULA; PROP ID:9524; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Panel_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Spacing_Category() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Spacing_Category").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9539; TYPE:PF
      Result = 0.0

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Select Case Me.Panel_ID
		Case  "Top"
			' =IF(AND(OR(C93="YES",C94="Yes"),H93="Overhead"),45,90)
				'C93 = Front Scanded
				'C94 = Back Scanned
			If (FrontScanned OrElse BackScanned ) AndAlso FrontScanned_Overhead Then
            	Return 45  ' Condition is true
        	Else
            	Return 90  ' Condition is false
        	End If
		Case  "Bottom"
			Result = 45
		Case "Left","Right"
			'=IF(OR(AND(C93="YES",OR(H93="1 Side",H93="2 Sides")),AND(C94="Yes",OR(H93="1 Side",H93="2 Sides"))),45,90)
			'=IF(OR(AND(FrontScanned=TRUE, OR(FrontScanned_1Side ,FrontScanned_2Side)),AND(BackScanned,OR(FrontScanned_1Side,FrontScanned_2Side))),45,90)
			 If ((FrontScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side)) OrElse _
            	(BackScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side))) Then
            	
            	Return 45  ' At least one condition is true
        	Else
            	Return 90  ' Both conditions are false
        	End If
		Case "Front", "Back"
					
			Result = 45
	 End Select

End If
      '   END FORMULA; PROP ID:9539; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Product_Spacing_Category", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scan_Angle_Degrees() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scan_Angle_Degrees").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9532; TYPE:PF
      Result = 0.0

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Select Case Me.Panel_ID
		Case  "Top"
			' =IF(AND(OR(C93="YES",C94="Yes"),H93="Overhead"),45,90)
				'C93 = Front Scanded
				'C94 = Back Scanned
			If (FrontScanned OrElse BackScanned ) AndAlso FrontScanned_Overhead Then
            	Return 45  ' Condition is true
        	Else
            	Return 90  ' Condition is false
        	End If
		Case  "Bottom"
			Result = 45
		Case "Left","Right"
			'=IF(OR(AND(C93="YES",OR(H93="1 Side",H93="2 Sides")),AND(C94="Yes",OR(H93="1 Side",H93="2 Sides"))),45,90)
			'=IF(OR(AND(FrontScanned=TRUE, OR(FrontScanned_1Side ,FrontScanned_2Side)),AND(BackScanned,OR(FrontScanned_1Side,FrontScanned_2Side))),45,90)
			 If ((FrontScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side)) OrElse _
            	(BackScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side))) Then
            	
            	Return 45  ' At least one condition is true
        	Else
            	Return 90  ' Both conditions are false
        	End If
		Case "Front", "Back"
					
			Result = 45
	 End Select

End If
      '   END FORMULA; PROP ID:9532; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scan_Angle_Degrees", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scan_Head_Location() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scan_Head_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9540; TYPE:PF
      Result = 0.0

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Select Case Me.Panel_ID
		Case  "Top"
			'=IF(Scan_Angle_Degrees_Top=90,"O2",IF(AND(FrontScanned="Yes",BackScanned="Yes"),"O1 & O3",IF(FrontScanned="Yes","O1","O3")))
			If Me.Scan_Angle_Degrees = 90 And FrontScanned And BackScanned Then
				Result = "O1 & O3"
        	Else
            	If FrontScanned Then
					Result = "O1"
				Else
					Result = "O3"
				End If
        	End If
		Case  "Bottom"
			Result = 45
		Case "Left","Right"
			'=IF(OR(AND(C93="YES",OR(H93="1 Side",H93="2 Sides")),AND(C94="Yes",OR(H93="1 Side",H93="2 Sides"))),45,90)
			'=IF(OR(AND(FrontScanned=TRUE, OR(FrontScanned_1Side ,FrontScanned_2Side)),AND(BackScanned,OR(FrontScanned_1Side,FrontScanned_2Side))),45,90)
			 If ((FrontScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side)) OrElse _
            	(BackScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side))) Then
            	
            	Return 45  ' At least one condition is true
        	Else
            	Return 90  ' Both conditions are false
        	End If
		Case "Front", "Back"
					
			Result = 45
	 End Select

End If
      '   END FORMULA; PROP ID:9540; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scan_Head_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scan_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scan_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9527; TYPE:PF
      Result = ""
If Me.Is_Scanned Then
	'=IF(C89="Yes",IF(OR(D89="Laser Omni-Directional",D89="Camera Omni-Directional"),"O","U"),"")
	Select Case Me.Scanner_Selected
		Case "Laser Omni-Directional", "Camera Omni-Directional"
			Result = "O"
		Case Else
			Result = "U"
	End Select
End If
      '   END FORMULA; PROP ID:9527; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scan_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_CCD_Position() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_CCD_Position").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9528; TYPE:PF
      Result = ""
If Me.Is_Scanned Then
	Select Case Me.SubpartID
		Case 1 
			Result = "Overhead"
		Case 2 
			Result = "Underside"
		Case 3 
			Result = "1 Side"
		Case 4
			 Result = "1 Side"
		 Case 5
			 Result = "Please Select"
		 Case 6
			 Result = Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position
		 Case Else
			 Result = "ERROR!"
	 End Select

End If
      '   END FORMULA; PROP ID:9528; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_CCD_Position", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_Selected() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9526; TYPE:PF
      Result = ""
If Me.Is_Scanned Then
	Result = "Please Select"
End If
      '   END FORMULA; PROP ID:9526; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_Selected", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Scanned_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Gap_Required_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Spacing_Category_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Angle_Degrees_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Head_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_CCD_Position_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Selected_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Scanned_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Gap_Required_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Spacing_Category_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Angle_Degrees_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Head_Location_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_CCD_Position_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scanner_CCD_Position").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9528; TYPE:UC
              Result = False
If Me.Is_Scanned Then Result = True
	If Me.SubPartID = 6 Then Result = False '(Back Follows Front)
              '   END FORMULA; PROP ID:9528; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_CCD_Position_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Selected_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scanner_Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9526; TYPE:UC
              Result = Me.Is_Scanned
              '   END FORMULA; PROP ID:9526; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_Selected_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_CCD_Position_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_CCD_Position").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9528; TYPE:VV
      If Me.Is_Scanned Then
	Select Case Me.SubpartID
		Case 1 
			Result = MakeValidValues(Array("Overhead")) ' "Overhead"
		Case 2 
			Result = MakeValidValues(Array("Underside"))  ' "Underside"
		Case 3 
			Result = MakeValidValues(Array("1 Side")) ' "1 Side"
		Case 4
			 Result = MakeValidValues(Array("1 Side")) ' "1 Side"
		 Case 5
			 Result = MakeValidValues(Array("Overhead")) ' "Please Select"
		 Case 6
			 Result = MakeValidValues(Array("Overhead", "Underside", "1 Side", "2 Sides")) '"Please Select"
		 Case Else
			 Result = MakeValidValues(Array(""))
	 End Select
 Else
	 Result = MakeValidValues(Array(""))
End If
      '   END FORMULA; PROP ID:9528; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_CCD_Position_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Selected_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9526; TYPE:VV
      If Me.Is_Scanned Then
	Result = MakeValidValues(Array("Laser Uni-Directional", "Laser Omni-Directional", "Camera Omni-Directional"))
Else
	Result = MakeValidValues(Array(""))
End If
      '   END FORMULA; PROP ID:9526; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_Selected_ValidValues", ex.Message)
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

  