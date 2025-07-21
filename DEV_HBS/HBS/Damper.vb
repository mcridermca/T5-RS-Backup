Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Damper
'$ GenerateDate: 07/21/2025 12:30:00

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
    Imports HBS.swMateType_e
    Imports HBS.swMateAlign_e
    Imports HBS.severity

    Public Class [Damper]
    
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

    Private this as Damper = me

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
    
      Case "Height_"
      Formula_Height_WHENCHANGED(Value, OldValue)
    
      Case "InletVolume_CFM_"
      Formula_InletVolume_CFM_WHENCHANGED(Value, OldValue)
    
      Case "NoOfSection_"
      Formula_NoOfSection_WHENCHANGED(Value, OldValue)
    
      Case "WidthOrDiameter_"
      Formula_WidthOrDiameter_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "Height_"
      'Formula_Height_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "InletVolume_CFM_"
      'Formula_InletVolume_CFM_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "NoOfSection_"
      'Formula_NoOfSection_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "WidthOrDiameter_"
      'Formula_WidthOrDiameter_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [ActuatorAuxSwitch]() As String
      Get
      Return Properties("ActuatorAuxSwitch").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorAuxSwitch").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorTrqInLB]() As String
      Get
      Return Properties("ActuatorTrqInLB").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorTrqInLB").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorTrqReqd]() As String
      Get
      Return Properties("ActuatorTrqReqd").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorTrqReqd").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorVARating]() As String
      Get
      Return Properties("ActuatorVARating").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorVARating").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorVolt]() As String
      Get
      Return Properties("ActuatorVolt").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorVolt").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LeakageClass]() As String
      Get
      Return Properties("LeakageClass").Value
      End Get
      Set(ByVal Value As String)
      Properties("LeakageClass").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Notes]() As String
      Get
      Return Properties("Notes").Value
      End Get
      Set(ByVal Value As String)
      Properties("Notes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Tamco_Trq_Multiplier]() As String
      Get
      Return Properties("Tamco_Trq_Multiplier").Value
      End Get
      Set(ByVal Value As String)
      Properties("Tamco_Trq_Multiplier").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Torque_Reqd]() As String
      Get
      Return Properties("Torque_Reqd").Value
      End Get
      Set(ByVal Value As String)
      Properties("Torque_Reqd").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TorqueModPerFt2]() As String
      Get
      Return Properties("TorqueModPerFt2").Value
      End Get
      Set(ByVal Value As String)
      Properties("TorqueModPerFt2").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TorqueMultiplier]() As String
      Get
      Return Properties("TorqueMultiplier").Value
      End Get
      Set(ByVal Value As String)
      Properties("TorqueMultiplier").CalculatedValue = Value
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
    
          Public Property [ActuatorDistribution]() As String
      Get
      Return Properties("ActuatorDistribution").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorDistribution").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorMount]() As String
      Get
      Return Properties("ActuatorMount").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorMount").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorPartNumber]() As String
      Get
      Return Properties("ActuatorPartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorPartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorProvidedByHoneywell]() As String
      Get
      Return Properties("ActuatorProvidedByHoneywell").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorProvidedByHoneywell").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorQtyReqd]() As String
      Get
      Return Properties("ActuatorQtyReqd").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorQtyReqd").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Area]() As String
      Get
      Return Properties("Area").Value
      End Get
      Set(ByVal Value As String)
      Properties("Area").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BladeType]() As String
      Get
      Return Properties("BladeType").Value
      End Get
      Set(ByVal Value As String)
      Properties("BladeType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Control_FailPos]() As String
      Get
      Return Properties("Control_FailPos").Value
      End Get
      Set(ByVal Value As String)
      Properties("Control_FailPos").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Control_Signal]() As String
      Get
      Return Properties("Control_Signal").Value
      End Get
      Set(ByVal Value As String)
      Properties("Control_Signal").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Control_Spr_Ret]() As String
      Get
      Return Properties("Control_Spr_Ret").Value
      End Get
      Set(ByVal Value As String)
      Properties("Control_Spr_Ret").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Damper_Unit]() As String
      Get
      Return Properties("Damper_Unit").Value
      End Get
      Set(ByVal Value As String)
      Properties("Damper_Unit").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DamperTag]() As String
      Get
      Return Properties("DamperTag").Value
      End Get
      Set(ByVal Value As String)
      Properties("DamperTag").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DamperType]() As String
      Get
      Return Properties("DamperType").Value
      End Get
      Set(ByVal Value As String)
      Properties("DamperType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EquipmentLocation]() As String
      Get
      Return Properties("EquipmentLocation").Value
      End Get
      Set(ByVal Value As String)
      Properties("EquipmentLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FaceVelocity_FPM]() As String
      Get
      Return Properties("FaceVelocity_FPM").Value
      End Get
      Set(ByVal Value As String)
      Properties("FaceVelocity_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Height]() As String
      Get
      Return Properties("Height").Value
      End Get
      Set(ByVal Value As String)
      Properties("Height").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [InletVolume_CFM]() As String
      Get
      Return Properties("InletVolume_CFM").Value
      End Get
      Set(ByVal Value As String)
      Properties("InletVolume_CFM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ManufacturerType]() As String
      Get
      Return Properties("ManufacturerType").Value
      End Get
      Set(ByVal Value As String)
      Properties("ManufacturerType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MechDwg]() As String
      Get
      Return Properties("MechDwg").Value
      End Get
      Set(ByVal Value As String)
      Properties("MechDwg").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ModelNumber]() As String
      Get
      Return Properties("ModelNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ModelNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [NoOfSection]() As String
      Get
      Return Properties("NoOfSection").Value
      End Get
      Set(ByVal Value As String)
      Properties("NoOfSection").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ProvidedByHoneywell]() As String
      Get
      Return Properties("ProvidedByHoneywell").Value
      End Get
      Set(ByVal Value As String)
      Properties("ProvidedByHoneywell").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SafetyFactor]() As Long
      Get
      Return Properties("SafetyFactor").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SafetyFactor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ServiceApplication]() As String
      Get
      Return Properties("ServiceApplication").Value
      End Get
      Set(ByVal Value As String)
      Properties("ServiceApplication").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [StatDiffPressure]() As String
      Get
      Return Properties("StatDiffPressure").Value
      End Get
      Set(ByVal Value As String)
      Properties("StatDiffPressure").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SystemTag]() As String
      Get
      Return Properties("SystemTag").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemTag").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [WidthOrDiameter]() As String
      Get
      Return Properties("WidthOrDiameter").Value
      End Get
      Set(ByVal Value As String)
      Properties("WidthOrDiameter").CalculatedValue = Value
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
    InitPart("Damper", <a><![CDATA[Damper]]></a>.Value, 139, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H599123", "07/20/2025 18:58:57")
    AddProperty("1865", "ActuatorAuxSwitch", <a><![CDATA[ActuatorAuxSwitch]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:27:33 PM")
    AddProperty("1863", "ActuatorTrqInLB", <a><![CDATA[ActuatorTrqInLB]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 5:34:46 PM")
    AddProperty("1861", "ActuatorTrqReqd", <a><![CDATA[ActuatorTrqReqd]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:32:31 PM")
    AddProperty("1866", "ActuatorVARating", <a><![CDATA[ActuatorVARating]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:18:01 PM")
    AddProperty("1864", "ActuatorVolt", <a><![CDATA[ActuatorVolt]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:24:30 PM")
    AddProperty("1851", "LeakageClass", <a><![CDATA[Leakage Class]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:05:46 PM")
    AddProperty("1869", "Notes", <a><![CDATA[Notes]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 5:49:45 PM")
    AddProperty("1854", "Tamco_Trq_Multiplier", <a><![CDATA[Tamco_Trq_Multiplier]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/19/2025 6:03:41 PM")
    AddProperty("1829", "Torque_Reqd", <a><![CDATA[Torque_Reqd]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:18:31 PM")
    AddProperty("1856", "TorqueModPerFt2", <a><![CDATA[Torque Mod Per Ft2]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:06:51 PM")
    AddProperty("1853", "TorqueMultiplier", <a><![CDATA[Torque Multiplier]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:57:23 PM")
    AddProperty("1760", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 5:32:46 AM")
    AddProperty("1837", "ActuatorDistribution", <a><![CDATA[Actuator Distribution]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/18/2025 4:11:25 AM")
    AddProperty("1868", "ActuatorMount", <a><![CDATA[ActuatorMount]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 5:49:18 PM")
    AddProperty("1862", "ActuatorPartNumber", <a><![CDATA[ActuatorPartNumber]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:58:57 PM")
    AddProperty("1867", "ActuatorProvidedByHoneywell", <a><![CDATA[ActuatorProvidedByHoneywell]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 5:48:18 PM")
    AddProperty("1870", "ActuatorQtyReqd", <a><![CDATA[ActuatorQtyReqd]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:02:55 PM")
    AddProperty("1832", "Area", <a><![CDATA[Area]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:36:01 PM")
    AddProperty("1817", "BladeType", <a><![CDATA[Blade Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:39:10 PM")
    AddProperty("1828", "Control_FailPos", <a><![CDATA[Control_FailPos]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:21:33 PM")
    AddProperty("1825", "Control_Signal", <a><![CDATA[Control_Signal]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:53:18 PM")
    AddProperty("1827", "Control_Spr_Ret", <a><![CDATA[Control_Spr_Ret]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:21:17 PM")
    AddProperty("1831", "Damper_Unit", <a><![CDATA[Damper_Unit]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 4:36:32 PM")
    AddProperty("1860", "DamperTag", <a><![CDATA[Damper Tag]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 5:05:21 PM")
    AddProperty("1816", "DamperType", <a><![CDATA[Damper Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:11:30 PM")
    AddProperty("1858", "EquipmentLocation", <a><![CDATA[Equipment Location]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 4:56:09 PM")
    AddProperty("1823", "FaceVelocity_FPM", <a><![CDATA[Face Velocity_FPM]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:09:54 PM")
    AddProperty("1820", "Height", <a><![CDATA[Height]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 2:18:06 PM")
    AddProperty("1822", "InletVolume_CFM", <a><![CDATA[Inlet Volume_CFM]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 2:19:47 PM")
    AddProperty("1814", "ManufacturerType", <a><![CDATA[Manufacturer Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:38:32 PM")
    AddProperty("1857", "MechDwg", <a><![CDATA[Mech Dwg]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 4:55:34 PM")
    AddProperty("1815", "ModelNumber", <a><![CDATA[Model Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:10:39 PM")
    AddProperty("1821", "NoOfSection", <a><![CDATA[No Of Section]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 2:19:03 PM")
    AddProperty("1818", "ProvidedByHoneywell", <a><![CDATA[Provided By Honeywell]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 2:14:57 PM")
    AddProperty("1830", "SafetyFactor", <a><![CDATA[Safety Factor]]></a>.Value, "", "Long","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 4:34:58 PM")
    AddProperty("1813", "ServiceApplication", <a><![CDATA[Service/Application]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 6:37:49 PM")
    AddProperty("1824", "StatDiffPressure", <a><![CDATA[Stat Diff Pressure]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 3:02:42 PM")
    AddProperty("1859", "SystemTag", <a><![CDATA[System Tag]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/20/2025 4:56:39 PM")
    AddProperty("1819", "WidthOrDiameter", <a><![CDATA[Width Or Diameter]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 2:17:28 PM")
    
      AddValidValue("ActuatorDistribution")
    
      AddValidValue("ActuatorMount")
    
      AddValidValue("ActuatorPartNumber")
    
      AddValidValue("ActuatorProvidedByHoneywell")
    
      AddValidValue("BladeType")
    
      AddValidValue("Control_FailPos")
    
      AddValidValue("Control_Signal")
    
      AddValidValue("Control_Spr_Ret")
    
      AddValidValue("Damper_Unit")
    
      AddValidValue("DamperType")
    
      AddValidValue("ManufacturerType")
    
      AddValidValue("ModelNumber")
    
      AddValidValue("ProvidedByHoneywell")
    
      AddValidValue("ServiceApplication")
    
      AddValidValue("StatDiffPressure")
    
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
          InitProperty("ActuatorAuxSwitch", "1730", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:27:33 PM", "", "In Development",  0,3472)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorTrqInLB", "1728", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 5:34:46 PM", "", "In Development",  0,3444)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorTrqReqd", "1726", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:32:31 PM", "", "In Development",  0,3473)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorVARating", "1731", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:18:01 PM", "", "In Development",  0,3466)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorVolt", "1729", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:24:30 PM", "", "In Development",  0,3470)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LeakageClass", "1716", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:05:46 PM", "", "In Development",  0,3456)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Notes", "1734", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 5:49:45 PM", "", "In Development",  0,3453)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tamco_Trq_Multiplier", "1719", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/19/2025 6:03:41 PM", "", "In Development",  0,3422)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Torque_Reqd", "1694", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:18:31 PM", "", "In Development",  0,3433)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TorqueModPerFt2", "1721", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:06:51 PM", "", "In Development",  0,3457)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TorqueMultiplier", "1718", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:57:17 PM", "", "In Development",  0,3481)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorDistribution", "1702", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/18/2025 4:11:25 AM", "", "In Development",  0,3362)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorMount", "1733", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 5:49:18 PM", "", "In Development",  0,3451)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorPartNumber", "1727", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:58:57 PM", "", "In Development",  0,3440)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorProvidedByHoneywell", "1732", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 5:48:14 PM", "", "In Development",  0,3449)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorQtyReqd", "1735", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:02:55 PM", "", "In Development",  0,3455)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Area", "1697", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:36:01 PM", "", "In Development",  0,3475)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BladeType", "1682", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:39:10 PM", "", "In Development",  0,3319)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Control_FailPos", "1693", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:21:33 PM", "", "In Development",  0,3341)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Control_Signal", "1690", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:53:18 PM", "", "In Development",  0,3335)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Control_Spr_Ret", "1692", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:21:17 PM", "", "In Development",  0,3339)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Damper_Unit", "1696", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 4:36:32 PM", "", "In Development",  0,3345)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DamperTag", "1725", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 5:05:21 PM", "", "In Development",  0,3437)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DamperType", "1681", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:11:27 PM", "", "In Development",  0,3317)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EquipmentLocation", "1723", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 4:56:09 PM", "", "In Development",  0,3435)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FaceVelocity_FPM", "1688", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:09:52 PM", "", "In Development",  0,3460)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Height", "1685", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 2:18:06 PM", "", "In Development",  0,3325)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("InletVolume_CFM", "1687", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 2:19:47 PM", "", "In Development",  0,3329)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ManufacturerType", "1679", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:38:32 PM", "", "In Development",  0,3312)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MechDwg", "1722", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 4:55:34 PM", "", "In Development",  0,3434)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ModelNumber", "1680", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:10:39 PM", "", "In Development",  0,3314)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("NoOfSection", "1686", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 2:19:03 PM", "", "In Development",  0,3327)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ProvidedByHoneywell", "1683", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 2:14:52 PM", "", "In Development",  0,3321)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SafetyFactor", "1695", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 4:34:58 PM", "", "In Development",  0,3344)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ServiceApplication", "1678", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 6:37:49 PM", "", "In Development",  0,3310)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("StatDiffPressure", "1689", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 3:02:42 PM", "", "In Development",  0,3333)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemTag", "1724", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/20/2025 4:56:39 PM", "", "In Development",  0,3436)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("WidthOrDiameter", "1684", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 2:17:28 PM", "", "In Development",  0,3323)
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
          
        InitValidValue("ActuatorDistribution_ValidValues", "1702", "-1", 3363)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ActuatorMount_ValidValues", "1733", "-1", 3452)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ActuatorPartNumber_ValidValues", "1727", "-1", 3482)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ActuatorProvidedByHoneywell_ValidValues", "1732", "-1", 3450)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BladeType_ValidValues", "1682", "-1", 3478)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Control_FailPos_ValidValues", "1693", "-1", 3469)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Control_Signal_ValidValues", "1690", "-1", 3480)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Control_Spr_Ret_ValidValues", "1692", "-1", 3468)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Damper_Unit_ValidValues", "1696", "-1", 3346)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("DamperType_ValidValues", "1681", "-1", 3462)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ManufacturerType_ValidValues", "1679", "-1", 3477)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ModelNumber_ValidValues", "1680", "-1", 3461)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ProvidedByHoneywell_ValidValues", "1683", "-1", 3322)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ServiceApplication_ValidValues", "1678", "-1", 3476)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("StatDiffPressure_ValidValues", "1689", "-1", 3334)
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
          Public Function Formula_ActuatorAuxSwitch() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorAuxSwitch").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1730; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Switches from Damper_Actuator_Master Where Signal_Type_Ref = '" & Me.Control_Signal & "' And SPR_RET_Ref ='" & Me.Control_Spr_ret & "' And Part_Number = '" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Actuator Aux Switch", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1730; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorAuxSwitch", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorTrqInLB() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorTrqInLB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1728; TYPE:PF
      Return Me.ActuatorTrqReqd
      '   END FORMULA; PROP ID:1728; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorTrqInLB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorTrqReqd() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorTrqReqd").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1726; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Torque_Reqd <> "-" AndAlso Me.Torque_Reqd <> "" Then
	SQLToExecute = "select Distinct Torque_Ref from Damper_Actuator_Master Where Signal_Type_Ref = '" & Me.Control_Signal & "' And SPR_RET_Ref ='" & Me.Control_Spr_ret & "' And (Torque_Ref > " & Me.Torque_Reqd & " or Torque_Ref = " & Me.Torque_Reqd & ")"
	ds = g_ComponentData.ExecuteSQL(SQLToExecute)

	Try
    	If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        	For Each dr As DataRow In ds.Tables(0).Rows
            	If IsDBNull(dr.Item(0)) Then
                	displayValue = String.Empty
            	Else
                	displayValue = dr.Item(0).ToString.Trim
            	End If
        	Next
    	End If

	Catch ex As Exception
    	g_ObjectManager.LogError("Leakage Class", ex.ToString)
	End Try
End If	

Return displayValue
      '   END FORMULA; PROP ID:1726; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorTrqReqd", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorVARating() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorVARating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1731; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select VA_Rating from Damper_Actuator_Master Where Signal_Type_Ref = '" & Me.Control_Signal & "' And SPR_RET_Ref ='" & Me.Control_Spr_ret & "' And Part_Number = '" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Actuator VA Rating", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1731; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorVARating", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorVolt() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorVolt").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1729; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Power_Supply from Damper_Actuator_Master Where Signal_Type_Ref = '" & Me.Control_Signal & "' And SPR_RET_Ref ='" & Me.Control_Spr_ret & "' And Part_Number = '" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Actuator Volt", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1729; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorVolt", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LeakageClass() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LeakageClass").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1716; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "Select Distinct [Leakage Class] from Damper_Data_Master where Manufacturer_Type ='" & Me.ManufacturerType & "' And Model ='" & Me.ModelNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Leakage Class", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1716; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_LeakageClass", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Notes() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Notes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1734; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1734; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Notes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Tamco_Trq_Multiplier() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tamco_Trq_Multiplier").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1719; TYPE:PF
      If Me.ManufacturerType = "Tamco" Then
	If Me.BladeType = "Opposed" Then
		Return (Me.Area * 0.714285714) '(1/1.4 = 0.714285714)
	Else
		Return (Me.Area * 1)
	End If
End If
      '   END FORMULA; PROP ID:1719; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Tamco_Trq_Multiplier", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Torque_Reqd() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Torque_Reqd").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1694; TYPE:PF
      If Me.InletVolume_CFM = "" Then
	Return "-"
Else
	If Me.ManufacturerType = "Tamco" Then
		Return (Me.Tamco_Trq_Multiplier * Me.TorqueModPerFt2)
	Else
		If Me.ActuatorDistribution = "Linked" Then
			If Me.ModelNumber = "CDR25" OrElse Me.ModelNumber = "CDRS25" Then
				Return ((Math.Sqrt((576 * Me.Area)/3.14))*4) + 20
			Else
				Return (Me.Area * Me.TorqueMultiplier)
			End If
		Else
			If Me.ModelNumber = "CDR25" OrElse Me.ModelNumber = "CDRS25" Then
				Return ((Math.Sqrt((576*(Me.Area/Me.NoOfSection))/3.14))*4) + 20
			Else
				Return (Me.Area * Me.TorqueMultiplier)
			End If
		End If
	End If
End If
      '   END FORMULA; PROP ID:1694; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Torque_Reqd", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TorqueModPerFt2() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TorqueModPerFt2").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1721; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String
Dim Blade_Col_Name As String = ""


If Me.ManufacturerType = "TAMCO" Then
	SQLToExecute = "Select Blade_Col_Name from Damper_TrqMod_Tamco where " & Integer.Parse(Me.FaceVelocity_FPM) & "Between FPM_Min and FPM_Max"
	
	ds = g_ComponentData.ExecuteSQL(SQLToExecute)
	Try
    	If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        	For Each dr As DataRow In ds.Tables(0).Rows
            	If IsDBNull(dr.Item(0)) Then
                	displayValue = String.Empty
            	Else
                	displayValue = dr.Item(0).ToString.Trim
            	End If
        	Next
    	End If

	Catch ex As Exception
    	g_ObjectManager.LogError("Torque Mod Per Ft2", ex.ToString)
	End Try

	Return displayValue
End If
      '   END FORMULA; PROP ID:1721; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_TorqueModPerFt2", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TorqueMultiplier() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TorqueMultiplier").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1718; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String
Dim Blade_Col_Name As String = ""


If Me.ManufacturerType = "HONEYWELL" OrElse Me.ManufacturerType = "OTHERS"
	If Me.FaceVelocity_FPM <> "" Then
		If Integer.Parse(Me.FaceVelocity_FPM) <=2500 Then
			Blade_Col_Name = "Blade_" & Me.StatDiffPressure
			SQLToExecute = "Select " & Blade_Col_Name & " from Damper_TrqMulti_HonOth where Leakage_Class ='" & Me.LeakageClass & "' And Blade_Type_Ref ='" & Me.BladeType & "' And " & Integer.Parse(Me.FaceVelocity_FPM) & "Between FPM_Min and FPM_Max"
		Else
			Return "-"
		End If
	End If
ElseIf Me.ManufacturerType = "RUSKIN"
	SQLToExecute = "Select * from Damper_TrqMulti_Rusk where Model_Type = '" & Me.ModelNumber & "' And Blade_Type_Ref = '"	& Me.BladeType & "'"
ElseIf Me.ManufacturerType = "TAMCO"
	Return  "-"
ElseIf Me.ManufacturerType = "Please Select..."
	Return  "-"	
End If

ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Torque Multiplier", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1718; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_TorqueMultiplier", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorDistribution() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorDistribution").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1702; TYPE:PF
      Return FirstValidValue(Me,"ActuatorDistribution")
      '   END FORMULA; PROP ID:1702; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorDistribution", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorMount() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorMount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1733; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1733; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorMount", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorPartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1727; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1727; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorPartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorProvidedByHoneywell() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorProvidedByHoneywell").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1732; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1732; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorProvidedByHoneywell", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorQtyReqd() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorQtyReqd").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1735; TYPE:PF
      If Me.InletVolume_CFM = "" Then
	Return "-"
Else
	If Me.ActuatorDistribution = "Linked" Then
		Return Math.Round(((Me.Torque_Reqd * 1.2)/Me.ActuatorTrqInLB) + 0.499)
	Else
		Return Me.NoOfSection
	End If
End If
      '   END FORMULA; PROP ID:1735; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorQtyReqd", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Area() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Area").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1697; TYPE:PF
      If WidthOrDiameter <> "" AndAlso Me.Height <> "" Then
	If Me.Damper_Unit = "PI" Then
		If Me.DamperType = "Round" Then
			Return ((22/4032)*(Me.WidthOrDiameter)^2)
		Else
			Return (Me.WidthOrDiameter * Me.Height)/144
		End If
	ElseIf Me.Damper_Unit <> ""
		If Me.DamperType = "Round" Then
			Return ((22/4032)*(Me.WidthOrDiameter/25.4)^2)
		Else
			Return ((Me.WidthOrDiameter/25.4) * (Me.Height/25.4))/144
		End If	
	End If
End If
      '   END FORMULA; PROP ID:1697; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Area", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BladeType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BladeType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1682; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1682; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_BladeType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Control_FailPos() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Control_FailPos").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1693; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:1693; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Control_FailPos", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Control_Signal() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Control_Signal").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1690; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1690; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Control_Signal", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Control_Spr_Ret() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Control_Spr_Ret").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1692; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1692; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Control_Spr_Ret", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Damper_Unit() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Damper_Unit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1696; TYPE:PF
      Return FirstValidValue(Me,"Damper_Unit")
      '   END FORMULA; PROP ID:1696; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Damper_Unit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DamperTag() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DamperTag").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1725; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1725; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_DamperTag", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DamperType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DamperType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1681; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1681; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_DamperType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EquipmentLocation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EquipmentLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1723; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1723; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_EquipmentLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FaceVelocity_FPM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FaceVelocity_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1688; TYPE:PF
      If Me.InletVolume_CFM <> "" AndAlso Me.WidthOrDiameter <> "" AndAlso Me.Height <> "" Then
	Return ((144 * Me.InletVolume_CFM)/Me.WidthOrDiameter)/Me.Height
End If
      '   END FORMULA; PROP ID:1688; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_FaceVelocity_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Height() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Height").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1685; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1685; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Height", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_InletVolume_CFM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("InletVolume_CFM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1687; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1687; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_InletVolume_CFM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ManufacturerType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ManufacturerType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1679; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1679; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ManufacturerType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MechDwg() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MechDwg").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1722; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1722; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_MechDwg", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ModelNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ModelNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1680; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1680; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ModelNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_NoOfSection() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("NoOfSection").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1686; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1686; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_NoOfSection", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ProvidedByHoneywell() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ProvidedByHoneywell").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1683; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1683; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ProvidedByHoneywell", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SafetyFactor() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SafetyFactor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1695; TYPE:PF
      Result = 20
      '   END FORMULA; PROP ID:1695; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_SafetyFactor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ServiceApplication() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ServiceApplication").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1678; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1678; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ServiceApplication", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_StatDiffPressure() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("StatDiffPressure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1689; TYPE:PF
      Result = "Please Seelct..."
      '   END FORMULA; PROP ID:1689; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_StatDiffPressure", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SystemTag() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SystemTag").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1724; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1724; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_SystemTag", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_WidthOrDiameter() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("WidthOrDiameter").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1684; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1684; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_WidthOrDiameter", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorAuxSwitch_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorTrqInLB_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorTrqReqd_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorVARating_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorVolt_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LeakageClass_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Notes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tamco_Trq_Multiplier_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Torque_Reqd_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TorqueModPerFt2_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TorqueMultiplier_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorDistribution_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorMount_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorPartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorProvidedByHoneywell_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorQtyReqd_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Area_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BladeType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_FailPos_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Signal_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Spr_Ret_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Damper_Unit_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DamperTag_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DamperType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EquipmentLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FaceVelocity_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Height_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_InletVolume_CFM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ManufacturerType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MechDwg_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ModelNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NoOfSection_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProvidedByHoneywell_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SafetyFactor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ServiceApplication_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_StatDiffPressure_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemTag_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_WidthOrDiameter_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorAuxSwitch_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorTrqInLB_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorTrqReqd_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorVARating_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorVolt_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LeakageClass_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Notes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tamco_Trq_Multiplier_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Torque_Reqd_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TorqueModPerFt2_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TorqueMultiplier_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorDistribution_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorMount_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorPartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorProvidedByHoneywell_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorQtyReqd_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Area_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BladeType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_FailPos_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Signal_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Spr_Ret_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Damper_Unit_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DamperTag_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DamperType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EquipmentLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FaceVelocity_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Height_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_InletVolume_CFM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ManufacturerType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MechDwg_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ModelNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NoOfSection_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProvidedByHoneywell_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SafetyFactor_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ServiceApplication_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_StatDiffPressure_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemTag_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_WidthOrDiameter_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorDistribution_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorDistribution").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1702; TYPE:VV
      Result = MakeValidValues(Array("Linked", "Section"))
      '   END FORMULA; PROP ID:1702; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorDistribution_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorMount_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorMount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1733; TYPE:VV
      Result = MakeValidValues(Array("Internal", "External"))
      '   END FORMULA; PROP ID:1733; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorMount_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorPartNumber_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1727; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Torque_Reqd <> "-" AndAlso Me.Torque_Reqd <> "" Then
	SQLToExecute = "select Distinct Torque_Ref from Damper_Actuator_Master Where Signal_Type_Ref = '" & Me.Control_Signal & "' And SPR_RET_Ref ='" & Me.Control_Spr_ret & "' And (Torque_Ref > " & Me.Torque_Reqd & " or Torque_Ref = " & Me.Torque_Reqd & ") "
	ds = g_ComponentData.ExecuteSQL(SQLToExecute)

	Try
    	If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        	For Each dr As DataRow In ds.Tables(0).Rows
            	If IsDBNull(dr.Item(0)) Then
                	displayValue = String.Empty
            	Else
                	displayValue = dr.Item(0).ToString.Trim
            	End If

            	If Not validValuesCollection.Contains(displayValue) Then
                	validValuesCollection.Add(displayValue)
            	End If
        	Next
    	End If

	Catch ex As Exception
    	g_ObjectManager.LogError("Manufacturer Type", ex.ToString)
	End Try
End If	

Return validValuesCollection
      '   END FORMULA; PROP ID:1727; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorPartNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorProvidedByHoneywell_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorProvidedByHoneywell").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1732; TYPE:VV
      Result = MakeValidValues(Array("Yes", "No"))
      '   END FORMULA; PROP ID:1732; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ActuatorProvidedByHoneywell_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BladeType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BladeType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1682; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "Select Blade_Type from [dbo].[Damper_Blade_Type_Master]  Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Blade Type", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1682; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_BladeType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_FailPos_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Control_FailPos").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1693; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select  Fail_Pos_Ref From [dbo].[Damper_Control_Master] Where Signal_Type_Ref = '" & Me.Control_Signal & "' AND SPR_RET_Ref = '" & Me.Control_Spr_Ret & "' Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Control Fail POS", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1693; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Control_FailPos_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Signal_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Control_Signal").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1690; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "Select Signal_Type from [dbo].[Damper_Signal_Type_Master] Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Control Signal", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1690; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Control_Signal_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Spr_Ret_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Control_Spr_Ret").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1692; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select  SPR_RET_Ref From [dbo].[Damper_Control_Master] Where Signal_Type_Ref = '" & Me.Control_Signal & "' Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Control SPR RET", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1692; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Control_Spr_Ret_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Damper_Unit_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Damper_Unit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1696; TYPE:VV
      result = MakeValidValues(Array("IP", "SI"))
      '   END FORMULA; PROP ID:1696; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Damper_Unit_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DamperType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DamperType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1681; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Dmp_Type From [dbo].[Damper_Data_Master] Where Manufacturer_Type = '" & Me.ManufacturerType & "' Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Damper Type", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1681; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_DamperType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ManufacturerType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ManufacturerType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1679; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Manufacturer_Type from [dbo].[Manufacturer_Type_Master] Where Media = 'DAMPER' Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Manufacturer Type", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1679; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ManufacturerType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ModelNumber_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ModelNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1680; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Distinct Model From [dbo].[Damper_Data_Master] Where Manufacturer_Type = '" & Me.ManufacturerType & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Model Number", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1680; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ModelNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProvidedByHoneywell_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ProvidedByHoneywell").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1683; TYPE:VV
      Result = MakeValidKeyValues(Array("Y", "N"), Array("Yes", "No"))
      '   END FORMULA; PROP ID:1683; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ProvidedByHoneywell_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ServiceApplication_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ServiceApplication").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1678; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Service_Application from [dbo].[Damper_Serv_Appl_Master] Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Service/Application", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1678; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_ServiceApplication_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_StatDiffPressure_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("StatDiffPressure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1689; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select * From [dbo].[Damper_Pressure_Master] Where Manufacturer_Type = '" & Me.ManufacturerType & "' Order By [SOrt_Order]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Stat Diff Pressure", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1689; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_StatDiffPressure_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_Height_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Height").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1685; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Height",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1685; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_Height_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_InletVolume_CFM_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("InletVolume_CFM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1687; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Inlet Volume_CFM",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1687; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_InletVolume_CFM_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_NoOfSection_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("NoOfSection").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1686; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","No. Of Sect.",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1686; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_NoOfSection_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_WidthOrDiameter_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("WidthOrDiameter").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1684; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Width/Diameter",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1684; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Damper.Formula_WidthOrDiameter_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    

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

  