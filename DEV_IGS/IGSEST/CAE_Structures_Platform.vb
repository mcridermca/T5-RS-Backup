Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Structures_Platform

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

    Public Class [CAE_Structures_Platform]
    
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

    Private this as CAE_Structures_Platform = me

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
    
          Public Property [Hours_Ladders]() As Double
      Get
      Return Properties("Hours_Ladders").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Hours_Ladders").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Hours_Platform_Structure_Catwalk]() As Double
      Get
      Return Properties("Hours_Platform_Structure_Catwalk").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Hours_Platform_Structure_Catwalk").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Hours_Stairs]() As Double
      Get
      Return Properties("Hours_Stairs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Hours_Stairs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Bar_Grated_Platform_Large]() As Double
      Get
      Return Properties("Metrics_Bar_Grated_Platform_Large").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Bar_Grated_Platform_Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Bar_Grated_Platform_Medium]() As Double
      Get
      Return Properties("Metrics_Bar_Grated_Platform_Medium").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Bar_Grated_Platform_Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Bar_Grated_Platform_Small]() As Double
      Get
      Return Properties("Metrics_Bar_Grated_Platform_Small").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Bar_Grated_Platform_Small").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Catwalk]() As Double
      Get
      Return Properties("Metrics_Catwalk").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Catwalk").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Grid_Structures_Large]() As Double
      Get
      Return Properties("Metrics_Grid_Structures_Large").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Grid_Structures_Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Grid_Structures_Medium]() As Double
      Get
      Return Properties("Metrics_Grid_Structures_Medium").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Grid_Structures_Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Grid_Structures_Small]() As Double
      Get
      Return Properties("Metrics_Grid_Structures_Small").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Grid_Structures_Small").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Ladders_Large]() As Double
      Get
      Return Properties("Metrics_Ladders_Large").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Ladders_Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Ladders_Medium]() As Double
      Get
      Return Properties("Metrics_Ladders_Medium").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Ladders_Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Ladders_Small]() As Double
      Get
      Return Properties("Metrics_Ladders_Small").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Ladders_Small").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Resindeck_Platform_Large]() As Double
      Get
      Return Properties("Metrics_Resindeck_Platform_Large").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Resindeck_Platform_Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Resindeck_Platform_Medium]() As Double
      Get
      Return Properties("Metrics_Resindeck_Platform_Medium").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Resindeck_Platform_Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Resindeck_Platform_Small]() As Double
      Get
      Return Properties("Metrics_Resindeck_Platform_Small").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Resindeck_Platform_Small").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Stairs_Large]() As Double
      Get
      Return Properties("Metrics_Stairs_Large").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Stairs_Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Stairs_Medium]() As Double
      Get
      Return Properties("Metrics_Stairs_Medium").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Stairs_Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Metrics_Stairs_Small]() As Double
      Get
      Return Properties("Metrics_Stairs_Small").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Metrics_Stairs_Small").CalculatedValue = Value
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
    
          Public Property [Ladder_Large]() As Long
      Get
      Return Properties("Ladder_Large").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Ladder_Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ladder_Medium]() As Long
      Get
      Return Properties("Ladder_Medium").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Ladder_Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ladder_Small]() As Long
      Get
      Return Properties("Ladder_Small").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Ladder_Small").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Landing]() As Long
      Get
      Return Properties("Landing").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Landing").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Staircase_Large]() As Long
      Get
      Return Properties("Staircase_Large").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Staircase_Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Staircase_Medium]() As Long
      Get
      Return Properties("Staircase_Medium").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Staircase_Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Staircase_Small]() As Long
      Get
      Return Properties("Staircase_Small").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Staircase_Small").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Structure_Platform_Catwalk_Type]() As String
      Get
      Return Properties("Structure_Platform_Catwalk_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Structure_Platform_Catwalk_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Structure_Platform_Name]() As String
      Get
      Return Properties("Structure_Platform_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Structure_Platform_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Structure_Sq_Ft_Catwalk_Linear]() As Double
      Get
      Return Properties("Structure_Sq_Ft_Catwalk_Linear").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Structure_Sq_Ft_Catwalk_Linear").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Subsystem]() As Long
      Get
      Return Properties("Subsystem").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Subsystem").CalculatedValue = Value
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
    InitPart("CAE_Structures_Platform", <a><![CDATA[CAE_Structures_Platform]]></a>.Value, 385, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "06/27/2025 15:48:23")
    AddProperty("5281", "Hours_Ladders", <a><![CDATA[Hours_Ladders]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:18:56 PM")
    AddProperty("5282", "Hours_Platform_Structure_Catwalk", <a><![CDATA[Hours_Platform_Structure_Catwalk]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 8:12:17 PM")
    AddProperty("5280", "Hours_Stairs", <a><![CDATA[Hours_Stairs]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:19:05 PM")
    AddProperty("5269", "Metrics_Bar_Grated_Platform_Large", <a><![CDATA[Metrics_Bar_Grated_Platform_Large]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:00:55 PM")
    AddProperty("5268", "Metrics_Bar_Grated_Platform_Medium", <a><![CDATA[Metrics_Bar_Grated_Platform_Medium]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:00:40 PM")
    AddProperty("5267", "Metrics_Bar_Grated_Platform_Small", <a><![CDATA[Metrics_Bar_Grated_Platform_Small]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:00:25 PM")
    AddProperty("5273", "Metrics_Catwalk", <a><![CDATA[Metrics_Catwalk]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:02:43 PM")
    AddProperty("5266", "Metrics_Grid_Structures_Large", <a><![CDATA[Metrics_Grid_Structures_Large]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:59:45 PM")
    AddProperty("5265", "Metrics_Grid_Structures_Medium", <a><![CDATA[Metrics_Grid_Structures_Medium]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:59:28 PM")
    AddProperty("5264", "Metrics_Grid_Structures_Small", <a><![CDATA[Metrics_Grid_Structures_Small]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:59:06 PM")
    AddProperty("5279", "Metrics_Ladders_Large", <a><![CDATA[Metrics_Ladders_Large]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:04:45 PM")
    AddProperty("5278", "Metrics_Ladders_Medium", <a><![CDATA[Metrics_Ladders_Medium]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:04:35 PM")
    AddProperty("5277", "Metrics_Ladders_Small", <a><![CDATA[Metrics_Ladders_Small]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:04:22 PM")
    AddProperty("5272", "Metrics_Resindeck_Platform_Large", <a><![CDATA[Metrics_Resindeck_Platform_Large]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:02:35 PM")
    AddProperty("5271", "Metrics_Resindeck_Platform_Medium", <a><![CDATA[Metrics_Resindeck_Platform_Medium]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:01:43 PM")
    AddProperty("5270", "Metrics_Resindeck_Platform_Small", <a><![CDATA[Metrics_Resindeck_Platform_Small]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:01:31 PM")
    AddProperty("5276", "Metrics_Stairs_Large", <a><![CDATA[Metrics_Stairs_Large]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:03:52 PM")
    AddProperty("5275", "Metrics_Stairs_Medium", <a><![CDATA[Metrics_Stairs_Medium]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:03:39 PM")
    AddProperty("5274", "Metrics_Stairs_Small", <a><![CDATA[Metrics_Stairs_Small]]></a>.Value, "", "Double","","Mech Install Metrics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:03:19 PM")
    AddProperty("5250", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:42:08 PM")
    AddProperty("5259", "Ladder_Large", <a><![CDATA[Ladder_Large]]></a>.Value, "Large Ladder is over 12'", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:05:10 PM")
    AddProperty("5261", "Ladder_Medium", <a><![CDATA[Ladder_Medium]]></a>.Value, "Medium Ladder is from 8' to 11'11""", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:05:34 PM")
    AddProperty("5262", "Ladder_Small", <a><![CDATA[Ladder_Small]]></a>.Value, "Small ladder is beneath 8'", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:05:51 PM")
    AddProperty("5260", "Landing", <a><![CDATA[Landing]]></a>.Value, "", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:51:01 PM")
    AddProperty("5255", "Staircase_Large", <a><![CDATA[Staircase_Large]]></a>.Value, "Large Stair is eight steps or more", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:06:12 PM")
    AddProperty("5256", "Staircase_Medium", <a><![CDATA[Staircase_Medium]]></a>.Value, "Medium Stair is from four steps to seven steps", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:06:28 PM")
    AddProperty("5257", "Staircase_Small", <a><![CDATA[Staircase_Small]]></a>.Value, "Small steps is three steps or less", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 7:06:40 PM")
    AddProperty("5253", "Structure_Platform_Catwalk_Type", <a><![CDATA[Structure_Platform_Catwalk_Type]]></a>.Value, "", "String","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:48:00 PM")
    AddProperty("5251", "Structure_Platform_Name", <a><![CDATA[Structure_Platform_Name]]></a>.Value, "", "String","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:45:51 PM")
    AddProperty("5252", "Structure_Sq_Ft_Catwalk_Linear", <a><![CDATA[Structure_Sq_Ft_Catwalk_Linear]]></a>.Value, "", "Double","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/26/2025 6:43:44 PM")
    AddProperty("5254", "Subsystem", <a><![CDATA[Subsystem]]></a>.Value, "", "Long","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 3:48:23 PM")
    
      AddValidValue("Structure_Platform_Catwalk_Type")
    
      AddValidValue("Subsystem")
    
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
          InitProperty("Hours_Ladders", "4896", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:18:56 PM", "", "In Development",  0,7366)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hours_Platform_Structure_Catwalk", "4897", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 8:12:17 PM", "", "In Development",  0,7377)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hours_Stairs", "4895", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:19:05 PM", "", "In Development",  0,7364)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Bar_Grated_Platform_Large", "4884", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:00:55 PM", "", "In Development",  0,7343)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Bar_Grated_Platform_Medium", "4883", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:00:40 PM", "", "In Development",  0,7341)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Bar_Grated_Platform_Small", "4882", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:00:25 PM", "", "In Development",  0,7339)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Catwalk", "4888", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:02:43 PM", "", "In Development",  0,7351)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Grid_Structures_Large", "4881", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:59:45 PM", "", "In Development",  0,7337)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Grid_Structures_Medium", "4880", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:59:28 PM", "", "In Development",  0,7335)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Grid_Structures_Small", "4879", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:59:06 PM", "", "In Development",  0,7333)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Ladders_Large", "4894", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:04:45 PM", "", "In Development",  0,7363)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Ladders_Medium", "4893", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:04:35 PM", "", "In Development",  0,7361)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Ladders_Small", "4892", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:04:22 PM", "", "In Development",  0,7359)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Resindeck_Platform_Large", "4887", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:02:35 PM", "", "In Development",  0,7350)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Resindeck_Platform_Medium", "4886", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:01:43 PM", "", "In Development",  0,7347)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Resindeck_Platform_Small", "4885", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:01:31 PM", "", "In Development",  0,7345)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Stairs_Large", "4891", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:03:52 PM", "", "In Development",  0,7357)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Stairs_Medium", "4890", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:03:39 PM", "", "In Development",  0,7355)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Metrics_Stairs_Small", "4889", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 7:03:19 PM", "", "In Development",  0,7353)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ladder_Large", "4874", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:50:41 PM", "", "In Development",  0,7328)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ladder_Medium", "4876", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:51:27 PM", "", "In Development",  0,7330)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ladder_Small", "4877", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:51:39 PM", "", "In Development",  0,7331)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Landing", "4875", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:51:01 PM", "", "In Development",  0,7329)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Staircase_Large", "4870", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:49:52 PM", "", "In Development",  0,7324)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Staircase_Medium", "4871", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:50:01 PM", "", "In Development",  0,7325)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Staircase_Small", "4872", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:50:17 PM", "", "In Development",  0,7326)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Structure_Platform_Catwalk_Type", "4868", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:48:00 PM", "", "In Development",  0,7321)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Structure_Platform_Name", "4866", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:42:51 PM", "", "In Development",  0,7319)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Structure_Sq_Ft_Catwalk_Linear", "4867", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/26/2025 6:43:44 PM", "", "In Development",  0,7320)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Subsystem", "4869", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "6/27/2025 3:48:23 PM", "", "In Development",  0,8136)
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
          
        InitValidValue("Structure_Platform_Catwalk_Type_ValidValues", "4868", "-1", 7322)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Subsystem_ValidValues", "4869", "-1", 8137)
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
          Public Function Formula_Hours_Ladders() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hours_Ladders").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4896; TYPE:PF
      Result = (Me.Ladder_Large * Me.Metrics_Ladders_Large) + (Me.Ladder_Medium * Me.Metrics_Ladders_Medium) + (Me.Ladder_Small * Me.Metrics_Ladders_Small)
      '   END FORMULA; PROP ID:4896; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Hours_Ladders", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Hours_Platform_Structure_Catwalk() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hours_Platform_Structure_Catwalk").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4897; TYPE:PF
      Dim d = Me.Structure_Sq_Ft_Catwalk_Linear

Select Case Me.Structure_Platform_Catwalk_Type
	Case "Resindeck Platform"
		If d < -1000.1 Then
			Result = math.Ceiling(((((Me.Metrics_Resindeck_Platform_Large * 7500.1)- (Me.Metrics_Resindeck_Platform_Small *1000.1))/6500) * d) - ((Me.Metrics_Resindeck_Platform_Small * 1000) - (((Me.Metrics_Resindeck_Platform_Large * 7500) - (Me.Metrics_Resindeck_Platform_Small * 1000))/6500)*1000))
		ElseIf d < 0 Then
			Result = math.Ceiling(d * Me.Metrics_Resindeck_Platform_Small)
		ElseIf d < 1000.1 Then
			Result = math.Ceiling(d * Me.Metrics_Resindeck_Platform_Small)
		ElseIf d < 7500 Then
			Result = math.Ceiling(((((Me.Metrics_Resindeck_Platform_Large * 7500.1)- (Me.Metrics_Resindeck_Platform_Small *1000.1))/6500) * d) - ((Me.Metrics_Resindeck_Platform_Small * 1000) - (((Me.Metrics_Resindeck_Platform_Large * 7500) - (Me.Metrics_Resindeck_Platform_Small * 1000))/6500)*1000))
		Else
			Result = math.Ceiling(d * Me.Metrics_Resindeck_Platform_Large)
		End If
	Case "Bar Grating Platform"
		If d < -1000.1 Then
			Result = math.Ceiling(((((Me.Metrics_Bar_Grated_Platform_Large * 7500.1)- (Me.Metrics_Bar_Grated_Platform_Small *1000.1))/6500) * d) - ((Me.Metrics_Bar_Grated_Platform_Small * 1000) - (((Me.Metrics_Bar_Grated_Platform_Large * 7500) - (Me.Metrics_Bar_Grated_Platform_Small * 1000))/6500)*1000))
		ElseIf d < 0 Then
			Result = math.Ceiling(d * Me.Metrics_Bar_Grated_Platform_Small)
		ElseIf d < 1000.1 Then
			Result = math.Ceiling(d * Me.Metrics_Bar_Grated_Platform_Small)
		ElseIf d < 7500 Then
			Result = math.Ceiling(((((Me.Metrics_Bar_Grated_Platform_Large * 7500.1)- (Me.Metrics_Bar_Grated_Platform_Small *1000.1))/6500) * d) - ((Me.Metrics_Bar_Grated_Platform_Small * 1000) - (((Me.Metrics_Bar_Grated_Platform_Large * 7500) - (Me.Metrics_Bar_Grated_Platform_Small * 1000))/6500)*1000))
		Else
			Result = math.Ceiling(d * Me.Metrics_Bar_Grated_Platform_Large)
		End If
	Case "Grid Structure"
		If d < -1000.1 Then
			Result = math.Ceiling(((((Me.Metrics_Grid_Structures_Large * 7500.1)- (Me.Metrics_Grid_Structures_Small *1000.1))/6500) * d) - ((Me.Metrics_Grid_Structures_Small * 1000) - (((Me.Metrics_Grid_Structures_Large * 7500) - (Me.Metrics_Grid_Structures_Small * 1000))/6500)*1000))
		ElseIf d < 0 Then
			Result = math.Ceiling(d * Me.Metrics_Grid_Structures_Small)
		ElseIf d < 1000.1 Then
			Result = math.Ceiling(d * Me.Metrics_Grid_Structures_Small)
		ElseIf d < 7500 Then
			Result = math.Ceiling(((((Me.Metrics_Grid_Structures_Large * 7500.1)- (Me.Metrics_Grid_Structures_Small *1000.1))/6500) * d) - ((Me.Metrics_Grid_Structures_Small * 1000) - (((Me.Metrics_Grid_Structures_Large * 7500) - (Me.Metrics_Grid_Structures_Small * 1000))/6500)*1000))
		Else
			Result = math.Ceiling(d * Me.Metrics_Grid_Structures_Large)
		End If
	Case "CATWALK"
		Result = math.Ceiling(d * Me.Metrics_Catwalk)
End Select
      '   END FORMULA; PROP ID:4897; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Hours_Platform_Structure_Catwalk", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Hours_Stairs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hours_Stairs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4895; TYPE:PF
      Result = (Me.Staircase_Large * Me.Metrics_Stairs_Large) + (Me.Staircase_Medium * Me.Metrics_Stairs_Medium) + (Me.Staircase_Small * Me.Metrics_Stairs_Small) + (Me.Landing * Me.Metrics_Stairs_Large)
      '   END FORMULA; PROP ID:4895; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Hours_Stairs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Bar_Grated_Platform_Large() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Bar_Grated_Platform_Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4884; TYPE:PF
      Result = 0.08
      '   END FORMULA; PROP ID:4884; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Bar_Grated_Platform_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Bar_Grated_Platform_Medium() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Bar_Grated_Platform_Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4883; TYPE:PF
      Result = 0.16
      '   END FORMULA; PROP ID:4883; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Bar_Grated_Platform_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Bar_Grated_Platform_Small() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Bar_Grated_Platform_Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4882; TYPE:PF
      Result = 0.32
      '   END FORMULA; PROP ID:4882; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Bar_Grated_Platform_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Catwalk() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Catwalk").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4888; TYPE:PF
      Result = 0.62
      '   END FORMULA; PROP ID:4888; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Catwalk", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Grid_Structures_Large() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Grid_Structures_Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4881; TYPE:PF
      Result = 0.06
      '   END FORMULA; PROP ID:4881; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Grid_Structures_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Grid_Structures_Medium() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Grid_Structures_Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4880; TYPE:PF
      Result = 0.12
      '   END FORMULA; PROP ID:4880; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Grid_Structures_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Grid_Structures_Small() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Grid_Structures_Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4879; TYPE:PF
      Result = 0.24
      '   END FORMULA; PROP ID:4879; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Grid_Structures_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Ladders_Large() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Ladders_Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4894; TYPE:PF
      Result = 12
      '   END FORMULA; PROP ID:4894; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Ladders_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Ladders_Medium() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Ladders_Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4893; TYPE:PF
      Result = 8
      '   END FORMULA; PROP ID:4893; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Ladders_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Ladders_Small() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Ladders_Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4892; TYPE:PF
      Result = 6
      '   END FORMULA; PROP ID:4892; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Ladders_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Resindeck_Platform_Large() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Resindeck_Platform_Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4887; TYPE:PF
      Result = 0.10
      '   END FORMULA; PROP ID:4887; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Resindeck_Platform_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Resindeck_Platform_Medium() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Resindeck_Platform_Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4886; TYPE:PF
      Result = 0.20
      '   END FORMULA; PROP ID:4886; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Resindeck_Platform_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Resindeck_Platform_Small() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Resindeck_Platform_Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4885; TYPE:PF
      Result = 0.40
      '   END FORMULA; PROP ID:4885; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Resindeck_Platform_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Stairs_Large() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Stairs_Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4891; TYPE:PF
      Result = 12
      '   END FORMULA; PROP ID:4891; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Stairs_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Stairs_Medium() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Stairs_Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4890; TYPE:PF
      Result = 11
      '   END FORMULA; PROP ID:4890; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Stairs_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Metrics_Stairs_Small() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Metrics_Stairs_Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4889; TYPE:PF
      Result = 10.00
      '   END FORMULA; PROP ID:4889; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Metrics_Stairs_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ladder_Large() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ladder_Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4874; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4874; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Ladder_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ladder_Medium() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ladder_Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4876; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4876; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Ladder_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ladder_Small() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ladder_Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4877; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4877; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Ladder_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Landing() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Landing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4875; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4875; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Landing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Staircase_Large() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Staircase_Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4870; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4870; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Staircase_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Staircase_Medium() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Staircase_Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4871; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4871; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Staircase_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Staircase_Small() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Staircase_Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4872; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4872; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Staircase_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Structure_Platform_Catwalk_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Structure_Platform_Catwalk_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4868; TYPE:PF
      Result = "Resindeck Platform"
      '   END FORMULA; PROP ID:4868; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Structure_Platform_Catwalk_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Structure_Platform_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Structure_Platform_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4866; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:4866; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Structure_Platform_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Structure_Sq_Ft_Catwalk_Linear() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Structure_Sq_Ft_Catwalk_Linear").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4867; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4867; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Structure_Sq_Ft_Catwalk_Linear", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Subsystem() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Subsystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4869; TYPE:PF
      Select Case Me.Parent.Control_Panels.Quantity
	Case 0 
		Result = 0
	Case Else
		Result = Me.Parent.Control_Panels(2).CPNumber
End Select
      '   END FORMULA; PROP ID:4869; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Subsystem", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hours_Ladders_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hours_Platform_Structure_Catwalk_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hours_Stairs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Bar_Grated_Platform_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Bar_Grated_Platform_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Bar_Grated_Platform_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Catwalk_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Grid_Structures_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Grid_Structures_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Grid_Structures_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Ladders_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Ladders_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Ladders_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Resindeck_Platform_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Resindeck_Platform_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Resindeck_Platform_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Stairs_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Stairs_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Stairs_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ladder_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ladder_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ladder_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Landing_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Staircase_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Staircase_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Staircase_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structure_Platform_Catwalk_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structure_Platform_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structure_Sq_Ft_Catwalk_Linear_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Subsystem_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hours_Ladders_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hours_Platform_Structure_Catwalk_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hours_Stairs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Bar_Grated_Platform_Large_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Bar_Grated_Platform_Medium_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Bar_Grated_Platform_Small_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Catwalk_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Grid_Structures_Large_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Grid_Structures_Medium_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Grid_Structures_Small_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Ladders_Large_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Ladders_Medium_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Ladders_Small_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Resindeck_Platform_Large_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Resindeck_Platform_Medium_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Resindeck_Platform_Small_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Stairs_Large_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Stairs_Medium_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Metrics_Stairs_Small_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ladder_Large_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ladder_Medium_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ladder_Small_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Landing_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Staircase_Large_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Staircase_Medium_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Staircase_Small_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structure_Platform_Catwalk_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structure_Platform_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structure_Sq_Ft_Catwalk_Linear_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Subsystem_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structure_Platform_Catwalk_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Structure_Platform_Catwalk_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4868; TYPE:VV
      Result = MakeValidValues(Array("Resindeck Platform", "Bar Grating Platform", "Grid Structure", "Catwalk"))
      '   END FORMULA; PROP ID:4868; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Structure_Platform_Catwalk_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Subsystem_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Subsystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4869; TYPE:VV
      Dim vv As New ValidValues()
Dim cps As Integer = Me.Parent.Control_Panels.Quantity
Dim i As Integer = 2

While i <= cps
	vv.add(Me.Parent.Control_Panels(i).CPNumber)
	i += 1
End While

Result = vv
      '   END FORMULA; PROP ID:4869; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Structures_Platform.Formula_Subsystem_ValidValues", ex.Message)
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

  