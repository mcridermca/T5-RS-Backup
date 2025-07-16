Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Mech_Install_Metrics
'$ GenerateDate: 07/16/2025 15:12:37

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

    Public Class [CAE_Mech_Install_Metrics]
    
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

    Private this as CAE_Mech_Install_Metrics = me

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
    
          Public Property [Conveyor_Hours_Row_DBKeys]() As Long
      Get
      Return Properties("Conveyor_Hours_Row_DBKeys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Conveyor_Hours_Row_DBKeys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Misc_Constants_Row_DBKeys]() As Long
      Get
      Return Properties("Misc_Constants_Row_DBKeys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Misc_Constants_Row_DBKeys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Package_Flow_Rates_Row_DBKeys]() As Long
      Get
      Return Properties("Package_Flow_Rates_Row_DBKeys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Package_Flow_Rates_Row_DBKeys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Pallet_Conveyor_Row_DBKeys]() As Long
      Get
      Return Properties("Pallet_Conveyor_Row_DBKeys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Pallet_Conveyor_Row_DBKeys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Average_Bed_Length]() As Double
      Get
      Return Properties("Average_Bed_Length").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Average_Bed_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Mech_Install_Metrics_Conveyor_Type]() As String
      Get
      Return Properties("Mech_Install_Metrics_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Mech_Install_Metrics_Conveyor_Type").CalculatedValue = Value
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
    
      Public ReadOnly Property [Conveyor_Hours]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Conveyor_Hours")
      End Get
      End Property
    
      Public ReadOnly Property [Misc_Constants]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Misc_Constants")
      End Get
      End Property
    
      Public ReadOnly Property [Package_Flow_Rates]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Package_Flow_Rates")
      End Get
      End Property
    
      Public ReadOnly Property [Pallet_Conveyor]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Pallet_Conveyor")
      End Get
      End Property
    
      Public ReadOnly Property [My_Conveyor_Hours]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Conveyor_Hours")
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
    InitPart("CAE_Mech_Install_Metrics", <a><![CDATA[CAE_Mech_Install_Metrics]]></a>.Value, 382, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/16/2025 15:03:44")
    AddProperty("5585", "Conveyor_Hours_Row_DBKeys", <a><![CDATA[Conveyor_Hours_Row_DBKeys]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 4:39:59 PM")
    AddProperty("8357", "Misc_Constants_Row_DBKeys", <a><![CDATA[Misc_Constants_Row_DBKeys]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H617242", "7/7/2025 6:17:58 AM")
    AddProperty("9713", "Package_Flow_Rates_Row_DBKeys", <a><![CDATA[Package_Flow_Rates_Row_DBKeys]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H617242", "7/9/2025 11:08:52 AM")
    AddProperty("9802", "Pallet_Conveyor_Row_DBKeys", <a><![CDATA[Pallet_Conveyor_Row_DBKeys]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H617242", "7/10/2025 3:34:57 PM")
    AddProperty("5033", "Average_Bed_Length", <a><![CDATA[Average_Bed_Length]]></a>.Value, "Mech Install^'Metrics'!L3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H617242", "7/3/2025 6:23:48 AM")
    AddProperty("5032", "Mech_Install_Metrics_Conveyor_Type", <a><![CDATA[Mech_Install_Metrics_Conveyor_Type]]></a>.Value, "Mech Install^'Metrics'!A3", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H617242", "7/3/2025 6:13:48 AM")
    AddProperty("4896", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/24/2025 6:28:55 PM")
    
      AddValidValue("Conveyor_Hours_Row_DBKeys")
    
      AddValidValue("Misc_Constants_Row_DBKeys")
    
      AddValidValue("Package_Flow_Rates_Row_DBKeys")
    
      AddValidValue("Pallet_Conveyor_Row_DBKeys")
    
      AddValidValue("Mech_Install_Metrics_Conveyor_Type")
    
      oSubpart = AddSubpart(267,"Conveyor_Hours", <a><![CDATA[Conveyor_Hours]]></a>.Value, "FD", "Please See Notes in My Conveyour Hours Connection", "General", 9999, "", "GLOBAL\H601424", "6/30/2025 1:09:32 PM")
      
        oSubpart.AddVPF (384, "CAE_Mech_Install_Conveyor_Hours", "CAE Mech Install Conveyor Hours")
      
      oSubpart = AddSubpart(301,"Misc_Constants", <a><![CDATA[Misc_Constants]]></a>.Value, "FD", "", "Mech Install Metrics", 9999, "", "GLOBAL\H602502", "7/16/2025 3:03:44 PM")
      
        oSubpart.AddVPF (427, "CAE_Misc_Constant", "CAE_Misc_Constant")
      
      oSubpart = AddSubpart(313,"Package_Flow_Rates", <a><![CDATA[Package_Flow_Rates]]></a>.Value, "FD", "Package Flow Rates from Mech install Metrics tab.", "Mech Install Metrics", 9999, "", "GLOBAL\H617242", "7/9/2025 11:14:22 AM")
      
        oSubpart.AddVPF (410, "CAE_MEI_Package_Flow_Rates", "CAE_MEI_Package_Flow_Rates")
      
      oSubpart = AddSubpart(329,"Pallet_Conveyor", <a><![CDATA[Pallet_Conveyor]]></a>.Value, "FD", "", "Mech Install Metrics", 9999, "", "GLOBAL\H617242", "7/11/2025 10:49:26 AM")
      
        oSubpart.AddVPF (415, "CAE_MEI_Pallet_Conveyor", "CAE_MEI_Pallet_Conveyor")
      
      oConnection = AddConnection("My_Conveyor_Hours", <a><![CDATA[My Conveyor Hours]]></a>.Value, "'Find the associated db row / part family record associated with the parent conveyor type  This connection / db access pattern is specifically designed to elliminate database connection / query loads on the db. Using this pattern, each record becom", "117", "OO", 0, "","General", 9999, "CAE Mech Install", "GLOBAL\H601424", "6/30/2025 1:12:15 PM")
      
        oConnection.AddVPF(384, "CAE_Mech_Install_Conveyor_Hours")
      
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
          InitProperty("Conveyor_Hours_Row_DBKeys", "5198", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "6/27/2025 4:39:59 PM", "", "In Development",  0,8155)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Misc_Constants_Row_DBKeys", "7942", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H617242", "7/7/2025 6:17:58 AM", "", "In Development",  0,12730)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Package_Flow_Rates_Row_DBKeys", "9292", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H617242", "7/9/2025 11:08:41 AM", "", "In Development",  0,15641)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pallet_Conveyor_Row_DBKeys", "9387", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H617242", "7/10/2025 3:34:57 PM", "", "In Development",  0,16077)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Average_Bed_Length", "4651", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H617242", "7/3/2025 6:23:48 AM", "", "In Development",  0,11975)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mech_Install_Metrics_Conveyor_Type", "4650", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H617242", "7/3/2025 6:13:48 AM", "", "In Development",  0,11974)
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
          
        InitValidValue("Conveyor_Hours_Row_DBKeys_ValidValues", "5198", "-1", 8158)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Misc_Constants_Row_DBKeys_ValidValues", "7942", "-1", 12731)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Package_Flow_Rates_Row_DBKeys_ValidValues", "9292", "-1", 15642)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pallet_Conveyor_Row_DBKeys_ValidValues", "9387", "-1", 16078)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Mech_Install_Metrics_Conveyor_Type_ValidValues", "4650", "-1", 8837)
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
            If Incontext("-1", ctx) Then
          
        InitSubpart("Conveyor_Hours", 198, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "6/27/2025 4:13:36 PM", "", "In Development", "N",0,546,555)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Misc_Constants", 228, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/16/2025 3:03:07 PM", "", "In Development", "N",0,739,615)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Package_Flow_Rates", 240, "", "", "Y", 0, "-1", "", "GLOBAL\H617242", "7/9/2025 11:14:22 AM", "", "In Development", "N",0,648,649)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Pallet_Conveyor", 256, "", "", "Y", 0, "-1", "", "GLOBAL\H617242", "7/11/2025 10:49:26 AM", "", "In Development", "N",0,699,703)
        
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
          
        InitConnection("My_Conveyor_Hours", "97", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "6/30/2025 1:12:15 PM", "", "In Development", "N",178)
        
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
      Public Function Formula_My_Conveyor_Hours_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:97; TYPE:PF
        Result = Nothing
'Find the associated db row / part family record associated with the parent conveyor type
' Using this pattern, each record becomes static once demanded (resolbed), and can be reused from the connection constantly querying the databse.

Dim Search As String = Me.Mech_Install_Metrics_Conveyor_Type.ToLower().Trim()

For Each p As part In Me.Conveyor_Hours
	If p.properties("Conveyor_Type").Value.Trim().ToLower = Search Then
		Result = p
	End If
Next p
        '   END FORMULA; CON ID:97; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_My_Conveyor_Hours_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Hours_Row_DBKeys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Hours_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:5198; TYPE:PF
      Result = Me.ValidValues("Conveyor_Hours_Row_DBKeys").Count
      '   END FORMULA; PROP ID:5198; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Conveyor_Hours_Row_DBKeys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Misc_Constants_Row_DBKeys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Misc_Constants_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:7942; TYPE:PF
      Result = Me.ValidValues("Misc_Constants_Row_DBKeys").Count
      '   END FORMULA; PROP ID:7942; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Misc_Constants_Row_DBKeys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Package_Flow_Rates_Row_DBKeys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Package_Flow_Rates_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9292; TYPE:PF
      Result = Me.ValidValues("Package_Flow_Rates_Row_DBKeys").Count
      '   END FORMULA; PROP ID:9292; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Package_Flow_Rates_Row_DBKeys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Pallet_Conveyor_Row_DBKeys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pallet_Conveyor_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9387; TYPE:PF
      Result = Me.ValidValues("Pallet_Conveyor_Row_DBKeys").Count
      '   END FORMULA; PROP ID:9387; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Pallet_Conveyor_Row_DBKeys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Average_Bed_Length() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Average_Bed_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4651; TYPE:PF
      Result = My_Conveyor_Hours(1).Bed_Lgth_Avg
      '   END FORMULA; PROP ID:4651; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Average_Bed_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Mech_Install_Metrics_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mech_Install_Metrics_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4650; TYPE:PF
      Result = "Gravity"
      '   END FORMULA; PROP ID:4650; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Mech_Install_Metrics_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Hours_Row_DBKeys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Misc_Constants_Row_DBKeys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Package_Flow_Rates_Row_DBKeys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pallet_Conveyor_Row_DBKeys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Average_Bed_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Metrics_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Hours_Row_DBKeys_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Misc_Constants_Row_DBKeys_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Package_Flow_Rates_Row_DBKeys_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pallet_Conveyor_Row_DBKeys_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Average_Bed_Length_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Metrics_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Hours_Row_DBKeys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Hours_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:5198; TYPE:VV
      Dim TableName As String = "CAE_MEI_CONVEYOR_HRS_MASTER"
Dim PK_Name As String =  "CAE_MCHINST_CONVEYOR_HRS_MASTER_ID"

Result = MakeValidValueKeyFromDatabase($"[{TableName}]", $"[{PK_Name}]", $"[{PK_Name}]", $"Where [{PK_Name}] > " & FormatCriteria(0) & $" Order By [{PK_Name}]")
      '   END FORMULA; PROP ID:5198; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Conveyor_Hours_Row_DBKeys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Misc_Constants_Row_DBKeys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Misc_Constants_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:7942; TYPE:VV
      Dim TableName As String = "CAE_MEI_Misc_Constants"
Dim PK_Name As String =  "CAE_MEI_Misc_Constants_ID"

Result = MakeValidValueKeyFromDatabase($"[{TableName}]", $"[{PK_Name}]", $"[{PK_Name}]", $"Where [{PK_Name}] > " & FormatCriteria(0) & $" Order By [{PK_Name}]")
      '   END FORMULA; PROP ID:7942; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Misc_Constants_Row_DBKeys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Package_Flow_Rates_Row_DBKeys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Package_Flow_Rates_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9292; TYPE:VV
      Dim TableName As String = "CAE_MEI_Package_Flow_Rates"
Dim PK_Name As String =  "CAE_MEI_Package_Flow_Rates_ID"

Result = MakeValidValueKeyFromDatabase($"[{TableName}]", $"[{PK_Name}]", $"[{PK_Name}]", $"Where [{PK_Name}] > " & FormatCriteria(0) & $" Order By [{PK_Name}]")
      '   END FORMULA; PROP ID:9292; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Package_Flow_Rates_Row_DBKeys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pallet_Conveyor_Row_DBKeys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pallet_Conveyor_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9387; TYPE:VV
      Dim TableName As String = "CAE_MEI_Pallet_Conveyor"
Dim PK_Name As String =  "CAE_MEI_Pallet_Conveyor_ID"

Result = MakeValidValueKeyFromDatabase($"[{TableName}]", $"[{PK_Name}]", $"[{PK_Name}]", $"Where [{PK_Name}] > " & FormatCriteria(0) & $" Order By [{PK_Name}]")
      '   END FORMULA; PROP ID:9387; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Pallet_Conveyor_Row_DBKeys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Metrics_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mech_Install_Metrics_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4650; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_CAE_MEI_CONVEYOR_HRS_MASTER]", "[Conveyor_Type]", "[Conveyor_Type]", " ORDER BY [Conveyor_Type]")
      '   END FORMULA; PROP ID:4650; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Mech_Install_Metrics_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Hours_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:198; TYPE:PN
      
      '   END FORMULA; SUB ID:198; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Conveyor_Hours_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Hours_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:198; TYPE:QF
      Result = Me.Conveyor_Hours_Row_DBKeys
      '   END FORMULA; SUB ID:198; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Conveyor_Hours_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Hours_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Hours").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:198; TYPE:OP
      result = "CAE_Mech_Install_Conveyor_Hours"
      '   END FORMULA; SUB ID:198; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Conveyor_Hours_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Misc_Constants_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:228; TYPE:PN
      
      '   END FORMULA; SUB ID:228; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Misc_Constants_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Misc_Constants_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Misc_Constants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:228; TYPE:QF
      Result = Me.Misc_Constants_Row_DBKeys
      '   END FORMULA; SUB ID:228; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Misc_Constants_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Misc_Constants_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Misc_Constants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:228; TYPE:OP
      Result = "CAE_Misc_Constant"
      '   END FORMULA; SUB ID:228; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Misc_Constants_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Package_Flow_Rates_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:240; TYPE:PN
      
      '   END FORMULA; SUB ID:240; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Package_Flow_Rates_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Package_Flow_Rates_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Package_Flow_Rates").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:240; TYPE:QF
      Result = Me.Package_Flow_Rates_Row_DBKeys
      '   END FORMULA; SUB ID:240; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Package_Flow_Rates_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Package_Flow_Rates_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Package_Flow_Rates").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:240; TYPE:OP
      result = "CAE_MEI_Package_Flow_Rates"
      '   END FORMULA; SUB ID:240; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Package_Flow_Rates_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pallet_Conveyor_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:256; TYPE:PN
      
      '   END FORMULA; SUB ID:256; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Pallet_Conveyor_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pallet_Conveyor_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Pallet_Conveyor").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:256; TYPE:QF
      Result = Me.Pallet_Conveyor_Row_DBKeys
      '   END FORMULA; SUB ID:256; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Pallet_Conveyor_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pallet_Conveyor_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Pallet_Conveyor").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:256; TYPE:OP
      result = "CAE_MEI_Pallet_Conveyor"
      '   END FORMULA; SUB ID:256; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Metrics.Formula_Pallet_Conveyor_OPTIMALPARTFAMILY", ex.Message)
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

  