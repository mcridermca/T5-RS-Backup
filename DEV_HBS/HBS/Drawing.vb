Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Drawing
'$ GenerateDate: 07/12/2025 14:09:33

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

    Public Class [Drawing]
    
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

    Private this as Drawing = me

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
    
          Public Property [DWG_CreationDate]() As String
      Get
      Return Properties("DWG_CreationDate").Value
      End Get
      Set(ByVal Value As String)
      Properties("DWG_CreationDate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DWG_FilePath]() As String
      Get
      Return Properties("DWG_FilePath").Value
      End Get
      Set(ByVal Value As String)
      Properties("DWG_FilePath").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DWG_PlantName]() As String
      Get
      Return Properties("DWG_PlantName").Value
      End Get
      Set(ByVal Value As String)
      Properties("DWG_PlantName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Fan_Location]() As String
      Get
      Return Properties("Fan_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Fan_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LOCATION]() As String
      Get
      Return Properties("LOCATION").Value
      End Get
      Set(ByVal Value As String)
      Properties("LOCATION").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ScaleX]() As Double
      Get
      Return Properties("ScaleX").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ScaleX").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ScaleY]() As Double
      Get
      Return Properties("ScaleY").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ScaleY").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SCALING]() As String
      Get
      Return Properties("SCALING").Value
      End Get
      Set(ByVal Value As String)
      Properties("SCALING").CalculatedValue = Value
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
    
      Public ReadOnly Property [AHU]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("AHU")
      End Get
      End Property
    
      Public ReadOnly Property [Layouts]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Layouts")
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
    InitPart("Drawing", <a><![CDATA[Drawing]]></a>.Value, 29, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/19/2025 19:41:00")
    AddProperty("533", "DWG_CreationDate", <a><![CDATA[DWG_CreationDate]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("534", "DWG_FilePath", <a><![CDATA[DWG_FilePath]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("535", "DWG_PlantName", <a><![CDATA[DWG_PlantName]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("536", "Fan_Location", <a><![CDATA[Fan_Location]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("537", "LOCATION", <a><![CDATA[PositionXYZ]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("538", "ScaleX", <a><![CDATA[Scale X]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("539", "ScaleY", <a><![CDATA[Scale Y]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("540", "SCALING", <a><![CDATA[SCALING]]></a>.Value, "", "Point3D","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("532", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "4/23/2025 5:41:25 PM")
    
      oSubpart = AddSubpart(36,"AHU", <a><![CDATA[AHU]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (33, "CV1", "CV1")
      
        oSubpart.AddVPF (34, "CV2", "CV2")
      
      oSubpart = AddSubpart(33,"Layouts", <a><![CDATA[Layouts]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (30, "Layout", "Layout")
      oSpec = AddSpec("12","", 15, "DWGSpec", "", "GLOBAL\H601424", "2025-06-19T19:41:00.377", "DWGSpec")
      oSpec.Attributes.Add("DIM", "DWGFORMAT", <a><![CDATA[DWG]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "DWGVERSION", <a><![CDATA[AutoCAD 2010]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "EXPORTINDIVIDUALPDF", <a><![CDATA[FALSE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "EXPORTPDF", <a><![CDATA[FALSE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "HONORLAYOUTPARAMETERS", <a><![CDATA[FALSE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELENABLED", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELFILE", <a><![CDATA[HBS_Master.dwg]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELOUTPUTFILE", <a><![CDATA[DWGSpec]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "MODELRESTRICTTOVALID", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "PDFORIENTATION", <a><![CDATA[Landscape]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "PlotLineWeights", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "RasterImageDPI", <a><![CDATA[400]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "VectorDPI", <a><![CDATA[600]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oMasterDoc = oSpec.AddMasterDoc("HBS_Master.dwg", "2025-04-23T17:59:26.217")
        oSpec = AddSpec("11","", 16, "ABC", "", "GLOBAL\H601424", "2025-06-19T19:41:00.377", "ABC")
      oSpec.Attributes.Add("DIM", "Attr.0.AttributeName", <a><![CDATA[DATE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.0.AttributeValue", <a><![CDATA[DWG_CreationDate]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Attr.0.ReadOnly", <a><![CDATA[false]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.1.AttributeName", <a><![CDATA[SHT_TITLE_1]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.1.AttributeValue", <a><![CDATA[DWG_PlantName]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Attr.1.ReadOnly", <a><![CDATA[false]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.2.AttributeName", <a><![CDATA[DWG_NUM]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.2.AttributeValue", <a><![CDATA[0101]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.2.ReadOnly", <a><![CDATA[false]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.3.AttributeName", <a><![CDATA[SHT_NUM]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.3.AttributeValue", <a><![CDATA[1]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.3.ReadOnly", <a><![CDATA[false]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.4.AttributeName", <a><![CDATA[FILEPATH]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "Attr.4.AttributeValue", <a><![CDATA[DWG_FilePath]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "Attr.4.ReadOnly", <a><![CDATA[false]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "BLOCKFILE", <a><![CDATA[AHU-CV1 1-Ref.dwg]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "BLOCKNAME", <a><![CDATA[XD-SIZE]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "BLOCKRESTRICTTOVALID", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "ENABLE", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "LOCATION", <a><![CDATA[LOCATION]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "SCALING", <a><![CDATA[SCALING]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("DIM", "ZORDER", <a><![CDATA[0]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oMasterDoc = oSpec.AddMasterDoc("AHU-CV1 1-Ref.dwg", "2025-04-24T06:50:38.030")
        oSpec = AddSpec("10","", 16, "DWG_AHU_CV1_PIpeTunnel", "", "GLOBAL\H601424", "2025-06-19T19:41:00.377", "DWG_AHU_CV1_PIpeTunnel")
      oSpec.Attributes.Add("DIM", "BLOCKFILE", <a><![CDATA[AHU-CV1 1-Ref.dwg]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "BLOCKNAME", <a><![CDATA[AHU_CV1_PIPETUNNEL]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "BLOCKRESTRICTTOVALID", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "ENABLE", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "LOCATION", <a><![CDATA[5.7626,14.5844,0]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "SCALING", <a><![CDATA[1,1,1]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("DIM", "ZORDER", <a><![CDATA[0]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oMasterDoc = oSpec.AddMasterDoc("AHU-CV1 1-Ref.dwg", "2025-04-24T06:50:38.030")
        
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
          InitProperty("DWG_CreationDate", "506", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 5:47:20 PM", "", "In Development",  0,1220)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DWG_FilePath", "507", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 5:50:10 PM", "", "In Development",  0,1223)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DWG_PlantName", "508", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "4/24/2025 2:07:38 PM", "", "In Development",  0,1244)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Fan_Location", "509", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 5:50:45 PM", "", "In Development",  0,1224)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LOCATION", "510", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 5:51:21 PM", "", "In Development",  0,1225)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ScaleX", "511", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 5:51:56 PM", "", "In Development",  0,1226)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ScaleY", "512", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 5:52:32 PM", "", "In Development",  0,1227)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SCALING", "513", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 5:53:17 PM", "", "In Development",  0,1228)
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
          
        InitSubpart("AHU", 36, "", "", "Y", 0, "-1", "", "GLOBAL\H599123", "4/24/2025 2:06:16 PM", "", "In Development", "N",0,139,86)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Layouts", 33, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "4/23/2025 6:13:23 PM", "", "In Development", "N",0,77,76)
        
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
          Public Function Formula_DWG_CreationDate() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DWG_CreationDate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:506; TYPE:PF
      Return RootPart.CreationDate
      '   END FORMULA; PROP ID:506; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_DWG_CreationDate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DWG_FilePath() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DWG_FilePath").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:507; TYPE:PF
      Result = "C:\ProgramData\RuleStream\2412.0000\" & Me.DWG_PlantName
      '   END FORMULA; PROP ID:507; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_DWG_FilePath", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DWG_PlantName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DWG_PlantName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:508; TYPE:PF
      For Each _plantview As Object In RootPart.PlantView
    If IsConnected(_plantview.SelectedPlantItem) Then
        Return _plantview.SelectedPlantItem(1).PlantName_Selected
    End If
Next
      '   END FORMULA; PROP ID:508; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_DWG_PlantName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Fan_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Fan_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:509; TYPE:PF
      Return "100,2,2"
      '   END FORMULA; PROP ID:509; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_Fan_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LOCATION() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LOCATION").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:510; TYPE:PF
      result = "0,0,0"
      '   END FORMULA; PROP ID:510; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_LOCATION", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ScaleX() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ScaleX").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:511; TYPE:PF
      Result = 1.0
      '   END FORMULA; PROP ID:511; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_ScaleX", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ScaleY() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ScaleY").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:512; TYPE:PF
      Result = 1.0
      '   END FORMULA; PROP ID:512; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_ScaleY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SCALING() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SCALING").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:513; TYPE:PF
      Result = "1,1,1"
      '   END FORMULA; PROP ID:513; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_SCALING", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DWG_CreationDate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DWG_FilePath_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DWG_PlantName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Fan_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LOCATION_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleX_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleY_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SCALING_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DWG_CreationDate_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DWG_FilePath_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DWG_PlantName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Fan_Location_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LOCATION_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleX_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleY_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SCALING_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AHU_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:36; TYPE:PN
      
      '   END FORMULA; SUB ID:36; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_AHU_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AHU_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("AHU").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:36; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:36; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_AHU_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AHU_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("AHU").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:36; TYPE:OP
      For Each _plantview As Object In RootPart.PlantView
	If ISconnected(_plantview.SelectedPlantItem) Then
		If (_plantview.SelectedPlantItem(1).PlantName_Selected = "AHU-CV1") Then
			Return  "CV1"
		ElseIf (_plantview.SelectedPlantItem(1).PlantName_Selected = "AHU-CV2") Then
			Return  "CV2"
		End If
	End If
Next
      '   END FORMULA; SUB ID:36; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_AHU_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Layouts_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:33; TYPE:PN
      
      '   END FORMULA; SUB ID:33; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_Layouts_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Layouts_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Layouts").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:33; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:33; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_Layouts_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Layouts_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Layouts").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:33; TYPE:OP
      result = "Layout"
      '   END FORMULA; SUB ID:33; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Drawing.Formula_Layouts_OPTIMALPARTFAMILY", ex.Message)
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

  