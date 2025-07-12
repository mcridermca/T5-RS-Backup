Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: IGS_Tool_Instance_Mgr
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

    Public Class [IGS_Tool_Instance_Mgr]
    
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

    Private this as IGS_Tool_Instance_Mgr = me

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
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [AppCalc_Instances]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("AppCalc_Instances")
      End Get
      End Property
    
      Public ReadOnly Property [Elec_Install_Estimator]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Elec_Install_Estimator")
      End Get
      End Property
    
      Public ReadOnly Property [EQS_Estimator]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("EQS_Estimator")
      End Get
      End Property
    
      Public ReadOnly Property [Freight_Estimator]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Freight_Estimator")
      End Get
      End Property
    
      Public ReadOnly Property [Header_Hanger]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Header_Hanger")
      End Get
      End Property
    
      Public ReadOnly Property [ME_Hours_Estimator]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("ME_Hours_Estimator")
      End Get
      End Property
    
      Public ReadOnly Property [Mech_Install_Estimator]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Mech_Install_Estimator")
      End Get
      End Property
    
      Public ReadOnly Property [Netting_Estimator]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Netting_Estimator")
      End Get
      End Property
    
      Public ReadOnly Property [PM_Calc]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PM_Calc")
      End Get
      End Property
    
      Public ReadOnly Property [PQI]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PQI")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
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
    InitPart("IGS_Tool_Instance_Mgr", <a><![CDATA[IGS_Tool_Instance_Mgr]]></a>.Value, 288, "APCTMP01",  "N", "N", False, False, "In Development", "", "Tool Manager. A Collection of tools  used in an IGS Project", "", "", "",  "GLOBAL\H601424", "06/18/2025 21:25:49")
    AddProperty("1278", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:17 AM")
    
      oSubpart = AddSubpart(156,"AppCalc_Instances", <a><![CDATA[AppCalc_Instances]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:21 AM")
      
        oSubpart.AddVPF (116, "IGS_AppCalc_App", "IGS_AppCalc_App")
      
      oSubpart = AddSubpart(236,"Elec_Install_Estimator", <a><![CDATA[Elec Install Estimator]]></a>.Value, "FD", "Electrical Install Estimator", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oSubpart.AddVPF (361, "CAE_Elec_Install_App", "CAE_Elec_Install_App")
      
      oSubpart = AddSubpart(237,"EQS_Estimator", <a><![CDATA[EQS Estimator]]></a>.Value, "FD", "Equipment Quote Estimator", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oSubpart.AddVPF (359, "CAE_EQS_App", "CAE EQS App")
      
      oSubpart = AddSubpart(157,"Freight_Estimator", <a><![CDATA[Freight_Estimator]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:21 AM")
      
        oSubpart.AddVPF (18, "IGS_Freight_App", "IGS_Freight_App")
      
      oSubpart = AddSubpart(234,"Header_Hanger", <a><![CDATA[Header_Hanger]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "5/13/2025 5:29:30 PM")
      
        oSubpart.AddVPF (333, "HHS_HeaderHanger_Calc", "Header Hanger Calculator")
      
      oSubpart = AddSubpart(166,"ME_Hours_Estimator", <a><![CDATA[ME_Hours_Estimator]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/28/2025 5:17:55 AM")
      
        oSubpart.AddVPF (303, "CAE_ME_Hours_App", "CAE_ME_Hours_App")
      
      oSubpart = AddSubpart(235,"Mech_Install_Estimator", <a><![CDATA[Mech Install Estimator]]></a>.Value, "FD", "Mechanical Install Estimator", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oSubpart.AddVPF (360, "CAE_Mech_Install_App", "CAE Mech Install App")
      
      oSubpart = AddSubpart(240,"Netting_Estimator", <a><![CDATA[Netting Estimator]]></a>.Value, "FD", "Netting Estimator", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oSubpart.AddVPF (364, "CAE_Netting_Estimator_App", "CAE Netting Estimator App")
      
      oSubpart = AddSubpart(239,"PM_Calc", <a><![CDATA[PM Calc]]></a>.Value, "FD", "Project  Management Estimation App", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oSubpart.AddVPF (363, "CAE_PM_Calc_App", "CAE PM Calc App")
      
      oSubpart = AddSubpart(238,"PQI", <a><![CDATA[PQI]]></a>.Value, "FD", "Project Quote Information App", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oSubpart.AddVPF (362, "CAE_PQI_App", "CAE PQI App")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "113", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/18/2025 9:25:49 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
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
          
        InitSubpart("Elec_Install_Estimator", 174, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM", "Electrical Install Estimator", "In Development", "Y",0,488,489)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("EQS_Estimator", 175, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM", "Equipment Quote Estimator", "In Development", "Y",0,490,491)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Freight_Estimator", 101, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:21 AM", "", "In Development", "N",0,224,225)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Header_Hanger", 172, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "5/13/2025 5:29:30 PM", "", "In Development", "N",0,485,484)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("ME_Hours_Estimator", 106, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 5:17:55 AM", "", "In Development", "N",0,239,240)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Mech_Install_Estimator", 173, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM", "Mechanical Install Estimator", "In Development", "Y",0,486,487)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Netting_Estimator", 178, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM", "Netting Estimator", "In Development", "Y",0,496,497)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PM_Calc", 177, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM", "Project  Management Estimation App", "In Development", "Y",0,494,495)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PQI", 176, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM", "Project Quote Information App", "In Development", "Y",0,492,493)
        
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
          
        InitConnection("My_PRD", "93", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "6/18/2025 9:25:49 PM", "", "In Development", "N",160)
        
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
        '   BEGIN FORMULA; CON ID:93; TYPE:PF
        Result = Nothing
Result = Me.Parent.Parent.Project_Information(1).Salesforce_Opportunity(1).PRD_Document(1)
        '   END FORMULA; CON ID:93; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Estimator_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:174; TYPE:PN
      
      '   END FORMULA; SUB ID:174; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Elec_Install_Estimator_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Estimator_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Elec_Install_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:174; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:174; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Elec_Install_Estimator_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Estimator_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Elec_Install_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:174; TYPE:OP
      result = "CAE_Elec_Install_App"
      '   END FORMULA; SUB ID:174; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Elec_Install_Estimator_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EQS_Estimator_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:175; TYPE:PN
      
      '   END FORMULA; SUB ID:175; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_EQS_Estimator_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EQS_Estimator_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("EQS_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:175; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:175; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_EQS_Estimator_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EQS_Estimator_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("EQS_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:175; TYPE:OP
      result = "CAE_EQS_App"
      '   END FORMULA; SUB ID:175; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_EQS_Estimator_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Freight_Estimator_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:101; TYPE:PN
      
      '   END FORMULA; SUB ID:101; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Freight_Estimator_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Freight_Estimator_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Freight_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:101; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:101; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Freight_Estimator_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Freight_Estimator_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Freight_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:101; TYPE:OP
      result = "IGS_Freight_App"
      '   END FORMULA; SUB ID:101; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Freight_Estimator_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Header_Hanger_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:172; TYPE:PN
      
      '   END FORMULA; SUB ID:172; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Header_Hanger_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Header_Hanger_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Header_Hanger").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:172; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:172; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Header_Hanger_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Header_Hanger_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Header_Hanger").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:172; TYPE:OP
      result = "HHS_HeaderHanger_Calc"
      '   END FORMULA; SUB ID:172; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Header_Hanger_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_Hours_Estimator_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:106; TYPE:PN
      
      '   END FORMULA; SUB ID:106; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_ME_Hours_Estimator_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_Hours_Estimator_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_Hours_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:106; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:106; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_ME_Hours_Estimator_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ME_Hours_Estimator_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ME_Hours_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:106; TYPE:OP
      result = "CAE_ME_Hours_App"
      '   END FORMULA; SUB ID:106; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_ME_Hours_Estimator_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Estimator_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:173; TYPE:PN
      
      '   END FORMULA; SUB ID:173; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Mech_Install_Estimator_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Estimator_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Mech_Install_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:173; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:173; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Mech_Install_Estimator_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Estimator_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Mech_Install_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:173; TYPE:OP
      result = "CAE_Mech_Install_App"
      '   END FORMULA; SUB ID:173; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Mech_Install_Estimator_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Netting_Estimator_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:178; TYPE:PN
      
      '   END FORMULA; SUB ID:178; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Netting_Estimator_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Netting_Estimator_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Netting_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:178; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:178; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Netting_Estimator_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Netting_Estimator_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Netting_Estimator").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:178; TYPE:OP
      result = "CAE_Netting_Estimator_App"
      '   END FORMULA; SUB ID:178; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_Netting_Estimator_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PM_Calc_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:177; TYPE:PN
      
      '   END FORMULA; SUB ID:177; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_PM_Calc_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PM_Calc_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PM_Calc").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:177; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:177; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_PM_Calc_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PM_Calc_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PM_Calc").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:177; TYPE:OP
      result = "CAE_PM_Calc_App"
      '   END FORMULA; SUB ID:177; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_PM_Calc_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PQI_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:176; TYPE:PN
      
      '   END FORMULA; SUB ID:176; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_PQI_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PQI_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PQI").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:176; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:176; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_PQI_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PQI_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PQI").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:176; TYPE:OP
      result = "CAE_PQI_App"
      '   END FORMULA; SUB ID:176; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Tool_Instance_Mgr.Formula_PQI_OPTIMALPARTFAMILY", ex.Message)
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

  