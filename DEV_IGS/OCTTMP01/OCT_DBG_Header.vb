Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: OCTTMP01
'$ PartFamily: OCT_DBG_Header
'$ GenerateDate: 04/17/2025 23:15:25

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
    Imports OCTTMP01.swMateType_e
    Imports OCTTMP01.swMateAlign_e
    Imports OCTTMP01.severity

    Public Class [OCT_DBG_Header]
    
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

    Private this as OCT_DBG_Header = me

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
    
          Public Property [BillToAddressID]() As String
      Get
      Return Properties("BillToAddressID").Value
      End Get
      Set(ByVal Value As String)
      Properties("BillToAddressID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer]() As String
      Get
      Return Properties("Customer").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer").CalculatedValue = Value
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
    
          Public Property [JSONObjectName]() As String
      Get
      Return Properties("JSONObjectName").Value
      End Get
      Set(ByVal Value As String)
      Properties("JSONObjectName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [JSONObjectType]() As String
      Get
      Return Properties("JSONObjectType").Value
      End Get
      Set(ByVal Value As String)
      Properties("JSONObjectType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MfgBuildDate]() As String
      Get
      Return Properties("MfgBuildDate").Value
      End Get
      Set(ByVal Value As String)
      Properties("MfgBuildDate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [OrderType]() As String
      Get
      Return Properties("OrderType").Value
      End Get
      Set(ByVal Value As String)
      Properties("OrderType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PaintColor]() As String
      Get
      Return Properties("PaintColor").Value
      End Get
      Set(ByVal Value As String)
      Properties("PaintColor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ScheduleShipDate]() As String
      Get
      Return Properties("ScheduleShipDate").Value
      End Get
      Set(ByVal Value As String)
      Properties("ScheduleShipDate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ShipDate]() As String
      Get
      Return Properties("ShipDate").Value
      End Get
      Set(ByVal Value As String)
      Properties("ShipDate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ShipFromOrgId]() As String
      Get
      Return Properties("ShipFromOrgId").Value
      End Get
      Set(ByVal Value As String)
      Properties("ShipFromOrgId").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ShipMethod]() As String
      Get
      Return Properties("ShipMethod").Value
      End Get
      Set(ByVal Value As String)
      Properties("ShipMethod").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ShipToAddressID]() As Long
      Get
      Return Properties("ShipToAddressID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ShipToAddressID").CalculatedValue = Value
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
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [SOLine]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("SOLine")
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
    InitPart("OCT_DBG_Header", <a><![CDATA[OCT_DBG_Header]]></a>.Value, 327, "OCTTMP01",  "N", "N", False, False, "In Development", "", "Debug/Test Stub for Oracle Transfer DBG_Header Object", "", "", "",  "GLOBAL\H601424", "04/16/2025 01:50:10")
    AddProperty("1990", "BillToAddressID", <a><![CDATA[BillToAddressID]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1991", "Customer", <a><![CDATA[Customer]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2136", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1992", "JSONObjectName", <a><![CDATA[JSONObjectName]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1993", "JSONObjectType", <a><![CDATA[JSONObjectType]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1996", "MfgBuildDate", <a><![CDATA[MfgBuildDate]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1997", "OrderType", <a><![CDATA[OrderType]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1998", "PaintColor", <a><![CDATA[PaintColor]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1999", "ScheduleShipDate", <a><![CDATA[ScheduleShipDate]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2000", "ShipDate", <a><![CDATA[ShipDate]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2001", "ShipFromOrgId", <a><![CDATA[ShipFromOrgId]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2002", "ShipMethod", <a><![CDATA[ShipMethod]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2003", "ShipToAddressID", <a><![CDATA[ShipToAddressID]]></a>.Value, "", "Long","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1994", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1995", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("1973", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/9/2025 1:07:11 AM")
    
      oSubpart = AddSubpart(192,"SOLine", <a><![CDATA[SOLine]]></a>.Value, "MN", "", "Debugging", 9999, "Oracle Configurator Transfer", "GLOBAL\H601424", "4/16/2025 1:36:14 AM")
      
        oSubpart.AddVPF (328, "OCT_DBG_SOLine", "OCT_DBG_SOLine")
      
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
          InitProperty("BillToAddressID", "1658", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1812)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer", "1659", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1813)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Debug_Mode", "1804", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1995)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectName", "1660", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1814)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectType", "1661", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1815)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MfgBuildDate", "1664", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1818)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("OrderType", "1665", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1819)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PaintColor", "1666", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1820)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ScheduleShipDate", "1667", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1821)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShipDate", "1668", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1822)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShipFromOrgId", "1669", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1823)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShipMethod", "1670", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1824)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShipToAddressID", "1671", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1825)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "1662", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1816)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "1663", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1817)
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
          
        InitSubpart("SOLine", 130, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/9/2025 1:07:13 AM", "", "In Development", "Y",0,287,288)
        
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
          Public Function Formula_BillToAddressID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BillToAddressID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1658; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1658; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_BillToAddressID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1659; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1659; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_Customer", ex.Message)
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
      If Me.Properties("Debug_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1804; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:1804; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_Debug_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_JSONObjectName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("JSONObjectName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1660; TYPE:PF
      result = "Header"
      '   END FORMULA; PROP ID:1660; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_JSONObjectName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_JSONObjectType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("JSONObjectType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1661; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:1661; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_JSONObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MfgBuildDate() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MfgBuildDate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1664; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1664; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_MfgBuildDate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_OrderType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("OrderType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1665; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1665; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_OrderType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PaintColor() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PaintColor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1666; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1666; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_PaintColor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ScheduleShipDate() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ScheduleShipDate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1667; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1667; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_ScheduleShipDate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ShipDate() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShipDate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1668; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1668; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_ShipDate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ShipFromOrgId() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShipFromOrgId").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1669; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1669; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_ShipFromOrgId", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ShipMethod() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShipMethod").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1670; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1670; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_ShipMethod", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ShipToAddressID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShipToAddressID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1671; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1671; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_ShipToAddressID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1662; TYPE:PF
      result = "Header"
      '   END FORMULA; PROP ID:1662; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_XMLObjectName", ex.Message)
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
      If Me.Properties("XMLObjectType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1663; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:1663; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_XMLObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BillToAddressID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_JSONObjectName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_JSONObjectType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MfgBuildDate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OrderType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PaintColor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScheduleShipDate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipDate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipFromOrgId_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipMethod_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipToAddressID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_BillToAddressID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_JSONObjectName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_JSONObjectType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MfgBuildDate_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OrderType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PaintColor_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScheduleShipDate_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipDate_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipFromOrgId_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipMethod_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipToAddressID_USERCHANGE() as Boolean
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
      Public Function Formula_SOLine_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:130; TYPE:PN
      
      '   END FORMULA; SUB ID:130; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_SOLine_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SOLine_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("SOLine").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:130; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:130; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_SOLine_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SOLine_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("SOLine").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:130; TYPE:OP
      result = "OCT_DBG_SOLine"
      '   END FORMULA; SUB ID:130; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_Header.Formula_SOLine_OPTIMALPARTFAMILY", ex.Message)
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

  