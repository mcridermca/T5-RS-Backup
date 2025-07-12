Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: CAE_ME_Hours_App
'$ GenerateDate: 07/12/2025 14:40:53

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

    Public Class [CAE_ME_Hours_App]
    
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

    Private this as CAE_ME_Hours_App = me

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
    
          Public Property [Approved_By]() As String
      Get
      Return Properties("Approved_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Approved_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Approved_Date]() As Date
      Get
      Return Properties("Approved_Date").Value
      End Get
      Set(ByVal Value As Date)
      Properties("Approved_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Name]() As String
      Get
      Return Properties("Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Escalated_Equipment_USD]() As Double
      Get
      Return Properties("Escalated_Equipment_USD").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Escalated_Equipment_USD").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Estimated_By]() As String
      Get
      Return Properties("Estimated_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Estimated_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Facility_Location]() As String
      Get
      Return Properties("Facility_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Facility_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Mexico_Split_PCNT]() As Double
      Get
      Return Properties("Mexico_Split_PCNT").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Mexico_Split_PCNT").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_No]() As String
      Get
      Return Properties("Proposal_No").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_No").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Revision_No]() As String
      Get
      Return Properties("Revision_No").Value
      End Get
      Set(ByVal Value As String)
      Properties("Revision_No").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [US_Split_PCNT]() As Double
      Get
      Return Properties("US_Split_PCNT").Value
      End Get
      Set(ByVal Value As Double)
      Properties("US_Split_PCNT").CalculatedValue = Value
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
    
      Public ReadOnly Property [ME_ASRS_Hours]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("ME_ASRS_Hours")
      End Get
      End Property
    
      Public ReadOnly Property [ME_Hours]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("ME_Hours")
      End Get
      End Property
    
      Public ReadOnly Property [ME_System_Hours]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("ME_System_Hours")
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
    InitPart("CAE_ME_Hours_App", <a><![CDATA[CAE_ME_Hours_App]]></a>.Value, 303, "APCTMP01",  "N", "N", False, False, "In Development", "", "Concept And Estimating Mech Engineering Hours Estimator App", "", "", "",  "GLOBAL\H601424", "03/28/2025 05:03:36")
    AddProperty("1490", "Approved_By", <a><![CDATA[Approved By]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1491", "Approved_Date", <a><![CDATA[Approved Date]]></a>.Value, "", "Date","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1478", "Customer_Name", <a><![CDATA[Customer Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1494", "Escalated_Equipment_USD", <a><![CDATA[Escalated Equipment USD]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1480", "Estimated_By", <a><![CDATA[Estimated By]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1479", "Facility_Location", <a><![CDATA[Facility Location]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1496", "Mexico_Split_PCNT", <a><![CDATA[Mexico Split PCNT]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1492", "Proposal_No", <a><![CDATA[Proposal No]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1493", "Revision_No", <a><![CDATA[Revision No]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1495", "US_Split_PCNT", <a><![CDATA[US Split PCNT]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:03:35 AM")
    AddProperty("1474", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 4:50:10 AM")
    
      oSubpart = AddSubpart(168,"ME_ASRS_Hours", <a><![CDATA[ME ASRS Hours]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/28/2025 5:03:36 AM")
      
        oSubpart.AddVPF (305, "CAE_ME_ASRS_Hours", "CAE_ME_ASRS_Hours")
      
      oSubpart = AddSubpart(167,"ME_Hours", <a><![CDATA[ME Hours]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/28/2025 5:03:36 AM")
      
        oSubpart.AddVPF (304, "CAE_ME_Hours", "CAE_ME_Hours")
      
      oSubpart = AddSubpart(169,"ME_System_Hours", <a><![CDATA[ME System Hours]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/28/2025 5:03:36 AM")
      
        oSubpart.AddVPF (306, "CAE_ME_System_Hours", "CAE_ME_System_Hours")
      
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
          InitProperty("Approved_By", "1184", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1274)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Approved_Date", "1185", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1275)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "1172", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1262)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Escalated_Equipment_USD", "1188", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1278)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Estimated_By", "1174", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1264)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Facility_Location", "1173", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1263)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mexico_Split_PCNT", "1190", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1280)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_No", "1186", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1276)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revision_No", "1187", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1277)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("US_Split_PCNT", "1189", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:03:35 AM", "", "In Development",  0,1279)
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
          
        InitSubpart("ME_ASRS_Hours", 108, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 5:03:36 AM", "", "In Development", "N",0,243,244)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("ME_Hours", 107, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 5:03:36 AM", "", "In Development", "N",0,241,242)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("ME_System_Hours", 109, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 5:03:36 AM", "", "In Development", "N",0,245,246)
        
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
          Public Function Formula_Approved_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Approved_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1184; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1184; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Approved_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Approved_Date() As Date
          Dim Result as Date
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Approved_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1185; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1185; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Approved_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1172; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1172; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Escalated_Equipment_USD() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Escalated_Equipment_USD").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1188; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:1188; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Escalated_Equipment_USD", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Estimated_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Estimated_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1174; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1174; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Estimated_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Facility_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Facility_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1173; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1173; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Facility_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Mexico_Split_PCNT() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mexico_Split_PCNT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1190; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:1190; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Mexico_Split_PCNT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_No() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_No").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1186; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1186; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Proposal_No", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Revision_No() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Revision_No").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1187; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1187; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_Revision_No", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_US_Split_PCNT() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("US_Split_PCNT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1189; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:1189; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_US_Split_PCNT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Escalated_Equipment_USD_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Estimated_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Facility_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mexico_Split_PCNT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_No_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revision_No_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_US_Split_PCNT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Escalated_Equipment_USD_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Estimated_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Facility_Location_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mexico_Split_PCNT_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_No_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revision_No_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_US_Split_PCNT_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_ASRS_Hours_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:108; TYPE:PN
      
      '   END FORMULA; SUB ID:108; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_ASRS_Hours_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_ASRS_Hours_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_ASRS_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:108; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:108; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_ASRS_Hours_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_ASRS_Hours_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_ASRS_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:108; TYPE:OP
      result = "CAE_ME_ASRS_Hours"
      '   END FORMULA; SUB ID:108; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_ASRS_Hours_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_Hours_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:107; TYPE:PN
      
      '   END FORMULA; SUB ID:107; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_Hours_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_Hours_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:107; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:107; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_Hours_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_Hours_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:107; TYPE:OP
      result = "CAE_ME_Hours"
      '   END FORMULA; SUB ID:107; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_Hours_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_System_Hours_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:109; TYPE:PN
      
      '   END FORMULA; SUB ID:109; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_System_Hours_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_System_Hours_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_System_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:109; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:109; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_System_Hours_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_System_Hours_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_System_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:109; TYPE:OP
      result = "CAE_ME_System_Hours"
      '   END FORMULA; SUB ID:109; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_ME_Hours_App.Formula_ME_System_Hours_OPTIMALPARTFAMILY", ex.Message)
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

  