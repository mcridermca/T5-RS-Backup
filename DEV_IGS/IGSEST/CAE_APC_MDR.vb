Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_APC_MDR
'$ GenerateDate: 07/18/2025 18:34:28

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

    Public Class [CAE_APC_MDR]
    
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

    Private this as CAE_APC_MDR = me

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
    
          Public Property [Gen_Sorter_Type]() As String
      Get
      Return Properties("Gen_Sorter_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_Sorter_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [User_UOM_System]() As String
      Get
      Return Properties("User_UOM_System").Value
      End Get
      Set(ByVal Value As String)
      Properties("User_UOM_System").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Divert_Angle]() As Double
      Get
      Return Properties("Sort_Char_Divert_Angle").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Divert_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Max_Speed_FPM]() As Double
      Get
      Return Properties("Sort_Char_Max_Speed_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Max_Speed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Max_Speed_User]() As Double
      Get
      Return Properties("Sort_Char_Max_Speed_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Max_Speed_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Acq_Label_Data_Acquisition_Travel_User_UOM]() As String
      Get
      Return Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Max_Speed_User_UOM]() As String
      Get
      Return Properties("Sort_Char_Max_Speed_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sort_Char_Max_Speed_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Min_Operating_Temp_User_UOM]() As String
      Get
      Return Properties("Sort_Char_Min_Operating_Temp_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sort_Char_Min_Operating_Temp_User_UOM").CalculatedValue = Value
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
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
      End Get
      End Property
    
      Public ReadOnly Property [My_Setup]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Setup")
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
    InitPart("CAE_APC_MDR", <a><![CDATA[CAE_APC_MDR]]></a>.Value, 439, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/18/2025 18:34:08")
    AddProperty("10697", "Gen_Sorter_Type", <a><![CDATA[Gen_Sorter_Type]]></a>.Value, "AppCalc^'MDR Sort'!C17", "String","","AppCalc_MDR","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 4:23:00 PM")
    AddProperty("10703", "User_UOM_System", <a><![CDATA[User_UOM_System]]></a>.Value, "", "String","","AppCalc_MDR","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:20:27 PM")
    AddProperty("10700", "Sort_Char_Divert_Angle", <a><![CDATA[Sort_Char_Divert_Angle]]></a>.Value, "AppCalc^'MDR Sort'!J19", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:16:50 PM")
    AddProperty("10706", "Sort_Char_Max_Speed_FPM", <a><![CDATA[Sort_Char_Max_Speed_FPM]]></a>.Value, "Unit conversion to FT/MIN", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:31:55 PM")
    AddProperty("10705", "Sort_Char_Max_Speed_User", <a><![CDATA[Sort_Char_Max_Speed_User]]></a>.Value, "AppCalc^'MDR Sort'!J19", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:29:10 PM")
    AddProperty("10701", "Acq_Label_Data_Acquisition_Travel_User_UOM", <a><![CDATA[Acq_Label_Data_Acquisition_Travel_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:18:39 PM")
    AddProperty("10702", "Sort_Char_Max_Speed_User_UOM", <a><![CDATA[Sort_Char_Max_Speed_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:25:36 PM")
    AddProperty("10704", "Sort_Char_Min_Operating_Temp_User_UOM", <a><![CDATA[Sort_Char_Min_Operating_Temp_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:25:19 PM")
    AddProperty("10696", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 4:20:38 PM")
    
      AddValidValue("Gen_Sorter_Type")
    
      AddValidValue("User_UOM_System")
    
      AddValidValue("Acq_Label_Data_Acquisition_Travel_User_UOM")
    
      AddValidValue("Sort_Char_Max_Speed_User_UOM")
    
      AddValidValue("Sort_Char_Min_Operating_Temp_User_UOM")
    
      oConnection = AddConnection("My_PRD", <a><![CDATA[My_PRD]]></a>.Value, "", "207", "OO", 0, "","AppCalc_MDR", 9999, "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "", "208", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM")
      
        oConnection.AddVPF(119, "APC_Setup")
      
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
          InitProperty("Gen_Sorter_Type", "10258", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 4:23:00 PM", "", "In Development",  0,19129)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("User_UOM_System", "10264", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:20:27 PM", "", "In Development",  0,19147)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Divert_Angle", "10261", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:16:50 PM", "", "In Development",  0,19141)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Max_Speed_FPM", "10267", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:31:55 PM", "", "In Development",  0,19160)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Max_Speed_User", "10266", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:29:10 PM", "", "In Development",  0,19157)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Acq_Label_Data_Acquisition_Travel_User_UOM", "10262", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:18:39 PM", "", "In Development",  0,19142)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Max_Speed_User_UOM", "10263", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:25:36 PM", "", "In Development",  0,19149)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Min_Operating_Temp_User_UOM", "10265", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:25:19 PM", "", "In Development",  0,19152)
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
          
        InitValidValue("Gen_Sorter_Type_ValidValues", "10258", "-1", 19130)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("User_UOM_System_ValidValues", "10264", "-1", 19148)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Acq_Label_Data_Acquisition_Travel_User_UOM_ValidValues", "10262", "-1", 19143)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sort_Char_Max_Speed_User_UOM_ValidValues", "10263", "-1", 19154)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sort_Char_Min_Operating_Temp_User_UOM_ValidValues", "10265", "-1", 19153)
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
          
        InitConnection("My_PRD", "186", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM", "", "In Development", "N",334)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "187", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM", "", "In Development", "N",335)
        
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
      Public Function Formula_My_PRD_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:186; TYPE:PF
        Result = me.Parent.Parent.Parent
        '   END FORMULA; CON ID:186; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Setup_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:187; TYPE:PF
        Result = me.Parent.Setup(1)
        '   END FORMULA; CON ID:187; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_My_Setup_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Sorter_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Sorter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10258; TYPE:PF
      Result = "MDR - RT3 RAT"
      '   END FORMULA; PROP ID:10258; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Gen_Sorter_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_User_UOM_System() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("User_UOM_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10264; TYPE:PF
      Result = me.My_Setup(1).User_UOM_System
      '   END FORMULA; PROP ID:10264; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_User_UOM_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Divert_Angle() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Divert_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10261; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Divert_Angle").Value	
		Exit For
	End If
Next
      '   END FORMULA; PROP ID:10261; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Divert_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Max_Speed_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10267; TYPE:PF
      Result = Units.Convert(Me.Sort_Char_Max_Speed_FPM, Me.Sort_Char_Max_Speed_User_UOM, "FT/MIN")
      '   END FORMULA; PROP ID:10267; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Max_Speed_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10266; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Max_Speed").Value	
		Exit For
	End If
Next

If Me.Sort_Char_Max_Speed_User_UOM = "M/SEC" Then
	Result = Units.Convert(Result, "FT/MIN", "M/SEC")
End If
      '   END FORMULA; PROP ID:10266; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10262; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10262; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Acq_Label_Data_Acquisition_Travel_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Max_Speed_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10263; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "FT/MIN" Else Result = "M/SEC"
      '   END FORMULA; PROP ID:10263; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Min_Operating_Temp_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10265; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "F" Else Result = "C"
      '   END FORMULA; PROP ID:10265; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Min_Operating_Temp_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Sorter_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_User_UOM_System_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Divert_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Sorter_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_User_UOM_System_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Divert_Angle_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Sorter_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Sorter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10258; TYPE:VV
      Result = MakeValidValues(Array("MDR - Blue Wheel Diverter", "MDR - RT3 RAT", "MDR - 710 RAT Pneumatic"))
      '   END FORMULA; PROP ID:10258; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Gen_Sorter_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_User_UOM_System_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("User_UOM_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10264; TYPE:VV
      Result = MakeValidValues(Array("Imperial", "Metric"))
      '   END FORMULA; PROP ID:10264; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_User_UOM_System_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10262; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10262; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10263; TYPE:VV
      Result = MakeValidValues(Array("FT/MIN", "M/SEC"))
      '   END FORMULA; PROP ID:10263; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Min_Operating_Temp_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10265; TYPE:VV
      Result = MakeValidValues(Array("F", "C"))
      '   END FORMULA; PROP ID:10265; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Min_Operating_Temp_User_UOM_ValidValues", ex.Message)
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

  