Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Mech_Install_Data_Market_Labor_Rates
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

    Public Class [CAE_Mech_Install_Data_Market_Labor_Rates]
    
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

    Private this as CAE_Mech_Install_Data_Market_Labor_Rates = me

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
    
          Public Property [MEI_Data_Freight_for_Tools]() As Double
      Get
      Return Properties("MEI_Data_Freight_for_Tools").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Data_Freight_for_Tools").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Data_Local_Labor_Unskilled]() As Double
      Get
      Return Properties("MEI_Data_Local_Labor_Unskilled").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Data_Local_Labor_Unskilled").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Data_Other_Mileage_Rate]() As Double
      Get
      Return Properties("MEI_Data_Other_Mileage_Rate").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Data_Other_Mileage_Rate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Data_Safety_Person]() As Double
      Get
      Return Properties("MEI_Data_Safety_Person").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Data_Safety_Person").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_MLR_Install_Labor]() As Double
      Get
      Return Properties("MEI_MLR_Install_Labor").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_MLR_Install_Labor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_MLR_Lead_Labor]() As Double
      Get
      Return Properties("MEI_MLR_Lead_Labor").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_MLR_Lead_Labor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_MLR_License_Warning]() As String
      Get
      Return Properties("MEI_MLR_License_Warning").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_MLR_License_Warning").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_MLR_Mobilization]() As Double
      Get
      Return Properties("MEI_MLR_Mobilization").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_MLR_Mobilization").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_MLR_Super_Labor]() As Double
      Get
      Return Properties("MEI_MLR_Super_Labor").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_MLR_Super_Labor").CalculatedValue = Value
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
    InitPart("CAE_Mech_Install_Data_Market_Labor_Rates", <a><![CDATA[CAE_Mech_Install_Data_Market_Labor_Rates]]></a>.Value, 435, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H611896", "07/18/2025 09:05:39")
    AddProperty("10641", "MEI_Data_Freight_for_Tools", <a><![CDATA[MEI_Data_Freight_for_Tools]]></a>.Value, "Mech Install^'Data'!X3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 8:58:07 AM")
    AddProperty("10642", "MEI_Data_Local_Labor_Unskilled", <a><![CDATA[MEI_Data_Local_Labor_Unskilled]]></a>.Value, "Mech Install^'Data'!B6", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 8:59:07 AM")
    AddProperty("10640", "MEI_Data_Other_Mileage_Rate", <a><![CDATA[MEI_Data_Other_Mileage_Rate]]></a>.Value, "Mech Install^'Data'!X2", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 8:57:00 AM")
    AddProperty("10643", "MEI_Data_Safety_Person", <a><![CDATA[MEI_Data_Safety_Person]]></a>.Value, "Mech Install^'Data'!B7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 9:00:20 AM")
    AddProperty("10644", "MEI_MLR_Install_Labor", <a><![CDATA[MEI_MLR_Install_Labor]]></a>.Value, "Mech Install^'Market Labor Rates'!B16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 9:01:06 AM")
    AddProperty("10645", "MEI_MLR_Lead_Labor", <a><![CDATA[MEI_MLR_Lead_Labor]]></a>.Value, "Mech Install^'Market Labor Rates'!B17", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 9:01:48 AM")
    AddProperty("10648", "MEI_MLR_License_Warning", <a><![CDATA[MEI_MLR_License_Warning]]></a>.Value, "Mech Install^'Market Labor Rates'!B20", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 9:05:39 AM")
    AddProperty("10647", "MEI_MLR_Mobilization", <a><![CDATA[MEI_MLR_Mobilization]]></a>.Value, "Mech Install^'Market Labor Rates'!B19", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 9:03:05 AM")
    AddProperty("10646", "MEI_MLR_Super_Labor", <a><![CDATA[MEI_MLR_Super_Labor]]></a>.Value, "Mech Install^'Market Labor Rates'!B18", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 9:02:29 AM")
    AddProperty("10639", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H611896", "7/18/2025 8:52:37 AM")
    
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
          InitProperty("MEI_Data_Freight_for_Tools", "10206", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 8:58:07 AM", "", "In Development",  0,19006)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Data_Local_Labor_Unskilled", "10207", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 8:59:07 AM", "", "In Development",  0,19007)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Data_Other_Mileage_Rate", "10205", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 8:57:00 AM", "", "In Development",  0,19005)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Data_Safety_Person", "10208", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 9:00:20 AM", "", "In Development",  0,19008)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_MLR_Install_Labor", "10209", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 9:01:06 AM", "", "In Development",  0,19009)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_MLR_Lead_Labor", "10210", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 9:01:48 AM", "", "In Development",  0,19010)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_MLR_License_Warning", "10213", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 9:05:39 AM", "", "In Development",  0,19013)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_MLR_Mobilization", "10212", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 9:03:05 AM", "", "In Development",  0,19012)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_MLR_Super_Labor", "10211", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "7/18/2025 9:02:29 AM", "", "In Development",  0,19011)
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
          Public Function Formula_MEI_Data_Freight_for_Tools() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Data_Freight_for_Tools").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10206; TYPE:PF
      Result = 1.25
      '   END FORMULA; PROP ID:10206; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_Data_Freight_for_Tools", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Data_Local_Labor_Unskilled() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Data_Local_Labor_Unskilled").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10207; TYPE:PF
      Result = 39.04
      '   END FORMULA; PROP ID:10207; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_Data_Local_Labor_Unskilled", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Data_Other_Mileage_Rate() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Data_Other_Mileage_Rate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10205; TYPE:PF
      Result = 0.58
      '   END FORMULA; PROP ID:10205; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_Data_Other_Mileage_Rate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Data_Safety_Person() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Data_Safety_Person").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10208; TYPE:PF
      Result = 114.83
      '   END FORMULA; PROP ID:10208; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_Data_Safety_Person", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_MLR_Install_Labor() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_MLR_Install_Labor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10209; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10209; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_MLR_Install_Labor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_MLR_Lead_Labor() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_MLR_Lead_Labor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10210; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10210; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_MLR_Lead_Labor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_MLR_License_Warning() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_MLR_License_Warning").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10213; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:10213; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_MLR_License_Warning", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_MLR_Mobilization() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_MLR_Mobilization").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10212; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10212; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_MLR_Mobilization", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_MLR_Super_Labor() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_MLR_Super_Labor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10211; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10211; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Data_Market_Labor_Rates.Formula_MEI_MLR_Super_Labor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Freight_for_Tools_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Local_Labor_Unskilled_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Other_Mileage_Rate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Safety_Person_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Install_Labor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Lead_Labor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_License_Warning_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Mobilization_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Super_Labor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Freight_for_Tools_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Local_Labor_Unskilled_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Other_Mileage_Rate_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Data_Safety_Person_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Install_Labor_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Lead_Labor_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_License_Warning_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Mobilization_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_MLR_Super_Labor_USERCHANGE() as Boolean
      Return True
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

  