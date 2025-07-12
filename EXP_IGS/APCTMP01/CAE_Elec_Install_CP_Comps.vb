Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: CAE_Elec_Install_CP_Comps
'$ GenerateDate: 06/12/2025 19:28:00

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

    Public Class [CAE_Elec_Install_CP_Comps]
    
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

    Private this as CAE_Elec_Install_CP_Comps = me

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
    
          Public Property [Motor_Qty_00050HP]() As Long
      Get
      Return Properties("Motor_Qty_00050HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00050HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_00075HP]() As Long
      Get
      Return Properties("Motor_Qty_00075HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00075HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_00100HP]() As Long
      Get
      Return Properties("Motor_Qty_00100HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00100HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_00150HP]() As Long
      Get
      Return Properties("Motor_Qty_00150HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00150HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_00200HP]() As Long
      Get
      Return Properties("Motor_Qty_00200HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00200HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_00300HP]() As Long
      Get
      Return Properties("Motor_Qty_00300HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00300HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_00500HP]() As Long
      Get
      Return Properties("Motor_Qty_00500HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00500HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_00750HP]() As Long
      Get
      Return Properties("Motor_Qty_00750HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_00750HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_01000HP]() As Long
      Get
      Return Properties("Motor_Qty_01000HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_01000HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Qty_Disconnects]() As Long
      Get
      Return Properties("Motor_Qty_Disconnects").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Motor_Qty_Disconnects").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [VFD_Qty_00100HP]() As Long
      Get
      Return Properties("VFD_Qty_00100HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("VFD_Qty_00100HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [VFD_Qty_00200HP]() As Long
      Get
      Return Properties("VFD_Qty_00200HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("VFD_Qty_00200HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [VFD_Qty_00300HP]() As Long
      Get
      Return Properties("VFD_Qty_00300HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("VFD_Qty_00300HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [VFD_Qty_00500HP]() As Long
      Get
      Return Properties("VFD_Qty_00500HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("VFD_Qty_00500HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [VFD_Qty_07500HP]() As Long
      Get
      Return Properties("VFD_Qty_07500HP").Value
      End Get
      Set(ByVal Value As Long)
      Properties("VFD_Qty_07500HP").CalculatedValue = Value
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
    InitPart("CAE_Elec_Install_CP_Comps", <a><![CDATA[CAE Elec Install CP Comps]]></a>.Value, 366, "APCTMP01",  "N", "N", False, False, "In Development", "", "C&E Electrical Install Estimator App", "", "", "",  "GLOBAL\H601424", "05/29/2025 17:08:38")
    AddProperty("2490", "Motor_Qty_00050HP", <a><![CDATA[Motor Qty 00050HP]]></a>.Value, "Main ^ 0.5 Hp Motors ( 'Control Panel Breakout'!P11 ) ^ 19", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2491", "Motor_Qty_00075HP", <a><![CDATA[Motor Qty 00075HP]]></a>.Value, "Main ^ 0.75Hp Motors ( 'Control Panel Breakout'!P12 ) ^ 20", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2492", "Motor_Qty_00100HP", <a><![CDATA[Motor Qty 00100HP]]></a>.Value, "Main ^ 1Hp Motors ( 'Control Panel Breakout'!P13 ) ^ 21", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2493", "Motor_Qty_00150HP", <a><![CDATA[Motor Qty 00150HP]]></a>.Value, "Main ^ 1.5Hp Motors ( 'Control Panel Breakout'!P14 ) ^ 22", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2494", "Motor_Qty_00200HP", <a><![CDATA[Motor Qty 00200HP]]></a>.Value, "Main ^ 2Hp Motors ( 'Control Panel Breakout'!P15 ) ^ 23", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2495", "Motor_Qty_00300HP", <a><![CDATA[Motor Qty 00300HP]]></a>.Value, "Main ^ 3Hp Motors ( 'Control Panel Breakout'!P16 ) ^ 24", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2496", "Motor_Qty_00500HP", <a><![CDATA[Motor Qty 00500HP]]></a>.Value, "Main ^ 5Hp Motors ( 'Control Panel Breakout'!P17 ) ^ 25", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2497", "Motor_Qty_00750HP", <a><![CDATA[Motor Qty 00750HP]]></a>.Value, "Main ^ 7.5Hp Motors ( 'Control Panel Breakout'!P18 ) ^ 26", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2498", "Motor_Qty_01000HP", <a><![CDATA[Motor Qty 01000HP]]></a>.Value, "Main ^ 10Hp Motors ( 'Control Panel Breakout'!P19 ) ^ 27", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2489", "Motor_Qty_Disconnects", <a><![CDATA[Motor Qty Disconnects]]></a>.Value, "Main ^ Motor Disconnects ( 'Control Panel Breakout'!P10 ) ^ 18", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2499", "VFD_Qty_00100HP", <a><![CDATA[VFD Qty 00100HP]]></a>.Value, "Main ^ 1HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P20 ) ^ 28", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2500", "VFD_Qty_00200HP", <a><![CDATA[VFD Qty 00200HP]]></a>.Value, "Main ^ 2HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P21 ) ^ 29", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2501", "VFD_Qty_00300HP", <a><![CDATA[VFD Qty 00300HP]]></a>.Value, "Main ^ 3HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P22 ) ^ 30", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2502", "VFD_Qty_00500HP", <a><![CDATA[VFD Qty 00500HP]]></a>.Value, "Main ^ 5HP VFD Allen-Bradley NEMA12Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P23 ) ^ 31", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2503", "VFD_Qty_07500HP", <a><![CDATA[VFD Qty 07500HP]]></a>.Value, "Main ^ 7.5HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P24 ) ^ 32", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 5:08:38 PM")
    AddProperty("2488", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 4:29:55 PM")
    
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
          InitProperty("Motor_Qty_00050HP", "2124", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 0.5 Hp Motors ( 'Control Panel Breakout'!P11 ) ^ 19", "In Development",  0,3444)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_00075HP", "2125", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 0.75Hp Motors ( 'Control Panel Breakout'!P12 ) ^ 20", "In Development",  0,3445)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_00100HP", "2126", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 1Hp Motors ( 'Control Panel Breakout'!P13 ) ^ 21", "In Development",  0,3446)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_00150HP", "2127", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 1.5Hp Motors ( 'Control Panel Breakout'!P14 ) ^ 22", "In Development",  0,3447)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_00200HP", "2128", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 2Hp Motors ( 'Control Panel Breakout'!P15 ) ^ 23", "In Development",  0,3448)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_00300HP", "2129", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 3Hp Motors ( 'Control Panel Breakout'!P16 ) ^ 24", "In Development",  0,3449)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_00500HP", "2130", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 5Hp Motors ( 'Control Panel Breakout'!P17 ) ^ 25", "In Development",  0,3450)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_00750HP", "2131", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 7.5Hp Motors ( 'Control Panel Breakout'!P18 ) ^ 26", "In Development",  0,3451)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_01000HP", "2132", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 10Hp Motors ( 'Control Panel Breakout'!P19 ) ^ 27", "In Development",  0,3452)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Qty_Disconnects", "2123", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ Motor Disconnects ( 'Control Panel Breakout'!P10 ) ^ 18", "In Development",  0,3443)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VFD_Qty_00100HP", "2133", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 1HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P20 ) ^ 28", "In Development",  0,3453)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VFD_Qty_00200HP", "2134", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 2HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P21 ) ^ 29", "In Development",  0,3454)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VFD_Qty_00300HP", "2135", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 3HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P22 ) ^ 30", "In Development",  0,3455)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VFD_Qty_00500HP", "2136", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 5HP VFD Allen-Bradley NEMA12Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P23 ) ^ 31", "In Development",  0,3456)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VFD_Qty_07500HP", "2137", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/29/2025 5:08:38 PM", "Main ^ 7.5HP VFD Allen-Bradley NEMA12 Kit Externally Mounted w/Motor ( 'Control Panel Breakout'!P24 ) ^ 32", "In Development",  0,3457)
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
          Public Function Formula_Motor_Qty_00050HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00050HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2124; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2124; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00050HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_00075HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00075HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2125; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2125; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00075HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_00100HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00100HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2126; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2126; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00100HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_00150HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00150HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2127; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2127; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00150HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_00200HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00200HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2128; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2128; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00200HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_00300HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00300HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2129; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2129; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00300HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_00500HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00500HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2130; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2130; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00500HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_00750HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_00750HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2131; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2131; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_00750HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_01000HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_01000HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2132; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2132; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_01000HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Qty_Disconnects() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Qty_Disconnects").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2123; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2123; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_Motor_Qty_Disconnects", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_VFD_Qty_00100HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VFD_Qty_00100HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2133; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2133; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_VFD_Qty_00100HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_VFD_Qty_00200HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VFD_Qty_00200HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2134; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2134; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_VFD_Qty_00200HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_VFD_Qty_00300HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VFD_Qty_00300HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2135; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2135; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_VFD_Qty_00300HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_VFD_Qty_00500HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VFD_Qty_00500HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2136; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2136; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_VFD_Qty_00500HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_VFD_Qty_07500HP() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VFD_Qty_07500HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2137; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2137; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_CP_Comps.Formula_VFD_Qty_07500HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00050HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00075HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00100HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00150HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00200HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00300HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00500HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00750HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_01000HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_Disconnects_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00100HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00200HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00300HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00500HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_07500HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00050HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00075HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00100HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00150HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00200HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00300HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00500HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_00750HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_01000HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Qty_Disconnects_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00100HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00200HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00300HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_00500HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_Qty_07500HP_USERCHANGE() as Boolean
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

  