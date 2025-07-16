Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_App_Calc_Print_And_Apply_Theoretical_Max
'$ GenerateDate: 07/16/2025 19:07:43

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

    Public Class [CAE_App_Calc_Print_And_Apply_Theoretical_Max]
    
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

    Private this as CAE_App_Calc_Print_And_Apply_Theoretical_Max = me

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
    
          Public Property [Summary_Carton_Length_IN]() As Double
      Get
      Return Properties("Summary_Carton_Length_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_Carton_Length_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Carton_Length_User]() As Double
      Get
      Return Properties("Summary_Carton_Length_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_Carton_Length_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Carton_Length_User_UOM]() As String
      Get
      Return Properties("Summary_Carton_Length_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_Carton_Length_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Carton_Rate_Display]() As Double
      Get
      Return Properties("Summary_Carton_Rate_Display").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_Carton_Rate_Display").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Carton_Rate_User]() As Double
      Get
      Return Properties("Summary_Carton_Rate_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_Carton_Rate_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_H_H_Spacing_IN]() As Double
      Get
      Return Properties("Summary_H_H_Spacing_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_H_H_Spacing_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_H_H_Spacing_User]() As Double
      Get
      Return Properties("Summary_H_H_Spacing_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_H_H_Spacing_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_H_H_Spacing_User_UOM]() As String
      Get
      Return Properties("Summary_H_H_Spacing_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_H_H_Spacing_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Limited_By]() As String
      Get
      Return Properties("Summary_Limited_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_Limited_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Volume_Flow_Rate_CFPM]() As Double
      Get
      Return Properties("Summary_Volume_Flow_Rate_CFPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_Volume_Flow_Rate_CFPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Volume_Flow_Rate_User]() As Double
      Get
      Return Properties("Summary_Volume_Flow_Rate_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Summary_Volume_Flow_Rate_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_Volume_Flow_Rate_User_UOM]() As String
      Get
      Return Properties("Summary_Volume_Flow_Rate_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_Volume_Flow_Rate_User_UOM").CalculatedValue = Value
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
    InitPart("CAE_App_Calc_Print_And_Apply_Theoretical_Max", <a><![CDATA[CAE_App_Calc_Print_And_Apply_Theoretical_Max]]></a>.Value, 422, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/16/2025 18:08:52")
    AddProperty("10280", "Summary_Carton_Length_IN", <a><![CDATA[Summary_Carton_Length_IN]]></a>.Value, "Unit conversion to Imperial", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 6:33:21 PM")
    AddProperty("10279", "Summary_Carton_Length_User", <a><![CDATA[Summary_Carton_Length_User]]></a>.Value, "AppCalc^'Belted PandA'!C145", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 6:32:00 PM")
    AddProperty("10276", "Summary_Carton_Length_User_UOM", <a><![CDATA[Summary_Carton_Length_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 6:29:01 PM")
    AddProperty("10294", "Summary_Carton_Rate_Display", <a><![CDATA[Summary_Carton_Rate_Display]]></a>.Value, "AppCalc^'Belted PandA'!G145", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 7:11:39 PM")
    AddProperty("10293", "Summary_Carton_Rate_User", <a><![CDATA[Summary_Carton_Rate_User]]></a>.Value, "AppCalc^'Belted PandA'!G145", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/16/2025 5:55:39 PM")
    AddProperty("10292", "Summary_H_H_Spacing_IN", <a><![CDATA[Summary_H_H_Spacing_IN]]></a>.Value, "Unit conversion to Imperial", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 7:07:29 PM")
    AddProperty("10281", "Summary_H_H_Spacing_User", <a><![CDATA[Summary_H_H_Spacing_User]]></a>.Value, "AppCalc^'Belted PandA'!E145", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 7:06:48 PM")
    AddProperty("10277", "Summary_H_H_Spacing_User_UOM", <a><![CDATA[Summary_H_H_Spacing_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 6:29:19 PM")
    AddProperty("10297", "Summary_Limited_By", <a><![CDATA[Summary_Limited_By]]></a>.Value, "AppCalc^'Belted PandA'!J145", "String","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 7:22:28 PM")
    AddProperty("10296", "Summary_Volume_Flow_Rate_CFPM", <a><![CDATA[Summary_Volume_Flow_Rate_CFPM]]></a>.Value, "Unit conversion to Imperial", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 8:35:35 PM")
    AddProperty("10295", "Summary_Volume_Flow_Rate_User", <a><![CDATA[Summary_Volume_Flow_Rate_User]]></a>.Value, "AppCalc^'Belted PandA'!E145", "Double","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/16/2025 6:08:52 PM")
    AddProperty("10278", "Summary_Volume_Flow_Rate_User_UOM", <a><![CDATA[Summary_Volume_Flow_Rate_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Summary","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 8:36:05 PM")
    AddProperty("10428", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "True = Debug On / False = Debug Off", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/16/2025 4:02:35 PM")
    AddProperty("10429", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "XML Export Object Name", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/16/2025 4:03:26 PM")
    AddProperty("10430", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "XML Export Object Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/16/2025 4:02:36 PM")
    AddProperty("10431", "XMLObjectValue", <a><![CDATA[XMLObjectValue]]></a>.Value, "XML Export Object Value", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/16/2025 4:02:36 PM")
    AddProperty("10273", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/15/2025 4:22:19 PM")
    
      AddValidValue("Summary_Carton_Length_User_UOM")
    
      AddValidValue("Summary_H_H_Spacing_User_UOM")
    
      AddValidValue("Summary_Volume_Flow_Rate_User_UOM")
    
      oConnection = AddConnection("MySource", <a><![CDATA[My Source Part Family]]></a>.Value, "Connection to the Value Provider Part Family Instance", "194", "OO", 0, "","Oracle Config XML", 9999, "Oracle Configurator Transfer", "GLOBAL\H602502", "7/16/2025 4:02:36 PM")
      
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
          InitProperty("Summary_Carton_Length_IN", "9858", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/15/2025 6:33:21 PM", "", "In Development",  0,17563)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Carton_Length_User", "9857", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/15/2025 6:32:00 PM", "", "In Development",  0,17562)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Carton_Length_User_UOM", "9854", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/15/2025 6:29:01 PM", "", "In Development",  0,17556)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Carton_Rate_Display", "9872", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/15/2025 7:11:39 PM", "", "In Development",  0,17599)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Carton_Rate_User", "9871", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/16/2025 5:55:39 PM", "", "In Development",  0,18177)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_H_H_Spacing_IN", "9870", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/15/2025 7:07:29 PM", "", "In Development",  0,17595)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_H_H_Spacing_User", "9859", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/15/2025 7:06:48 PM", "", "In Development",  0,17593)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_H_H_Spacing_User_UOM", "9855", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/15/2025 6:29:19 PM", "", "In Development",  0,17557)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Limited_By", "9875", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/15/2025 7:22:28 PM", "", "In Development",  0,17605)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Volume_Flow_Rate_CFPM", "9874", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/15/2025 8:35:35 PM", "", "In Development",  0,17608)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Volume_Flow_Rate_User", "9873", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/16/2025 6:08:52 PM", "", "In Development",  0,18178)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_Volume_Flow_Rate_User_UOM", "9856", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/15/2025 8:36:05 PM", "", "In Development",  0,17561)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Debug_Mode", "10001", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/16/2025 4:02:35 PM", "True = Debug On / False = Debug Off", "In Development",  0,18163)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "10002", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/16/2025 4:03:26 PM", "XML Export Object Name", "In Development",  0,18167)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "10003", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/16/2025 4:02:36 PM", "XML Export Object Type", "In Development",  0,18165)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectValue", "10004", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/16/2025 4:02:36 PM", "XML Export Object Value", "In Development",  0,18166)
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
          
        InitValidValue("Summary_Carton_Length_User_UOM_ValidValues", "9854", "-1", 17555)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Summary_H_H_Spacing_User_UOM_ValidValues", "9855", "-1", 17558)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Summary_Volume_Flow_Rate_User_UOM_ValidValues", "9856", "-1", 17609)
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
          
        InitConnection("MySource", "174", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/16/2025 4:02:36 PM", "Connection to the Value Provider Part Family Instance", "In Development", "Y",316)
        
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
        
        '   BEGIN FORMULA; CON ID:174; TYPE:PF
        Result = Nothing ' Set to Object that has the data you need to report on ' Me.Parent.HHS_Output(1)
        '   END FORMULA; CON ID:174; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_MySource_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Carton_Length_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Carton_Length_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9858; TYPE:PF
      Result = Units.Convert(Me.Summary_Carton_Length_User, Me.Summary_Carton_Length_User_UOM, "IN")
      '   END FORMULA; PROP ID:9858; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Carton_Length_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Carton_Length_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Carton_Length_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9857; TYPE:PF
      Result = Me.Parent.MTBH_Length_Maximum_IN + Me.SubpartID - 1

If Me.Summary_Carton_Length_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:9857; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Carton_Length_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Carton_Length_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Carton_Length_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9854; TYPE:PF
      If Me.parent.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9854; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Carton_Length_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Carton_Rate_Display() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Carton_Rate_Display").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9872; TYPE:PF
      Select Case Me.Parent.Summary_Caclucation_Errors_Present
	Case 0
		Result = Me.Summary_Carton_Rate_User.ToString()
	Case Else
		Result = "ERROR"
End Select
      '   END FORMULA; PROP ID:9872; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Carton_Rate_Display", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Carton_Rate_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Carton_Rate_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9871; TYPE:PF
      Result = math.ceiling(((Me.Parent.Gen_BM_Belt_Input_Speed_IN * 12) / Me.Summary_H_H_Spacing_IN) * 10^2) / 10^2
      '   END FORMULA; PROP ID:9871; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Carton_Rate_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_H_H_Spacing_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_H_H_Spacing_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9870; TYPE:PF
      Result = Units.Convert(Me.Summary_H_H_Spacing_User, Me.Summary_H_H_Spacing_User_UOM, "IN")
      '   END FORMULA; PROP ID:9870; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_H_H_Spacing_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_H_H_Spacing_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_H_H_Spacing_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9859; TYPE:PF
      If (Me.Summary_Carton_Length_IN + Me.Parent.Summary_Min_T_to_H_Gap_Req_IN) >= Me.Parent.Summary_Min_H_to_H_Spacing_Req_IN _
	 OrElse (Me.Summary_Carton_Length_IN * Me.Parent.Gen_BM_Belt_PTO_Ratio) >= Me.Parent.Summary_Min_H_to_H_Spacing_Req_IN Then
	 
	 If (Me.Summary_Carton_Length_IN + Me.Parent.Summary_Min_T_to_H_Gap_Req_IN) > (Me.Summary_Carton_Length_IN * Me.Parent.Gen_BM_Belt_PTO_Ratio) Then
		 Result = Me.Summary_Carton_Length_IN + Me.Parent.Summary_Min_T_to_H_Gap_Req_IN
	 Else
		 Result = Me.Summary_Carton_Length_IN * Me.Parent.Gen_BM_Belt_PTO_Ratio
	 End If
	
Else
	Result = Me.Parent.Summary_Min_H_to_H_Spacing_Req_IN
End If
      '   END FORMULA; PROP ID:9859; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_H_H_Spacing_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_H_H_Spacing_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_H_H_Spacing_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9855; TYPE:PF
      If Me.parent.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9855; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_H_H_Spacing_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Limited_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Limited_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9875; TYPE:PF
      If Me.Summary_H_H_Spacing_IN < Me.Parent.Summary_Min_H_to_H_Spacing_Req_IN Then
	Result = Me.Parent.Summary_Min_H_to_H_Spacing_Limit_Set_By
Else
	If Me.Summary_Volume_Flow_Rate_CFPM < Me.Parent.Gen_BM_Belt_Input_Speed_IN Then
		Result = Me.Parent.Summary_Min_T_to_H_Gap_Limit_Set_By	
	Else
		Result = "B/M Belt PTO Ratio"
	End If
End If
      '   END FORMULA; PROP ID:9875; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Limited_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Volume_Flow_Rate_CFPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Volume_Flow_Rate_CFPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9874; TYPE:PF
      Result = Units.Convert(Me.Summary_Volume_Flow_Rate_User, Me.Summary_Volume_Flow_Rate_User_UOM, "CFPM")
      '   END FORMULA; PROP ID:9874; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Volume_Flow_Rate_CFPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Volume_Flow_Rate_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Volume_Flow_Rate_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9873; TYPE:PF
      Result = Math.Ceiling(((Me.Summary_Carton_Rate_User * Me.Summary_Carton_Length_IN) / 12) * 10^2) / 10^2

If Me.Summary_Volume_Flow_Rate_User_UOM = "CMPM" Then
	Result = Units.Convert(Result, "CFPM", "CMPM")
End If
      '   END FORMULA; PROP ID:9873; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Volume_Flow_Rate_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_Volume_Flow_Rate_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Volume_Flow_Rate_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9856; TYPE:PF
      If Me.parent.User_UOM_System = "Imperial" Then Result = "CFPM" Else Result = "CMPM"
      '   END FORMULA; PROP ID:9856; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Volume_Flow_Rate_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10001; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:10001; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Debug_Mode", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10002; TYPE:PF
      Result = "PandA_Theoretical_Max"
      '   END FORMULA; PROP ID:10002; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_XMLObjectName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10003; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:10003; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_XMLObjectType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10004; TYPE:PF
      Dim Prop As PropertySF = Me.CurrentProperty
Result = Custom.GetPFXMLRepresentation(Prop) 'Generate XML For this and Children Classes
      '   END FORMULA; PROP ID:10004; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_XMLObjectValue", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Length_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Length_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Length_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Rate_Display_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Rate_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_H_H_Spacing_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_H_H_Spacing_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_H_H_Spacing_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Limited_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Volume_Flow_Rate_CFPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Volume_Flow_Rate_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Volume_Flow_Rate_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Summary_Carton_Length_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Length_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Length_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Rate_Display_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Carton_Rate_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_H_H_Spacing_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_H_H_Spacing_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_H_H_Spacing_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Limited_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Volume_Flow_Rate_CFPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Volume_Flow_Rate_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Volume_Flow_Rate_User_UOM_USERCHANGE() as Boolean
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
      Public Function Formula_Summary_Carton_Length_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Carton_Length_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9854; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9854; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Carton_Length_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_H_H_Spacing_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_H_H_Spacing_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9855; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9855; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_H_H_Spacing_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_Volume_Flow_Rate_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_Volume_Flow_Rate_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9856; TYPE:VV
      Result = MakeValidValues(Array("CFPM", "CMPM"))
      '   END FORMULA; PROP ID:9856; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply_Theoretical_Max.Formula_Summary_Volume_Flow_Rate_User_UOM_ValidValues", ex.Message)
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

  