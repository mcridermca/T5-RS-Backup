Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Project_Information
'$ GenerateDate: 06/27/2025 20:11:14

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

    Public Class [Project_Information]
    
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

    Private this as Project_Information = me

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
    
          Public Property [Architect_Address]() As String
      Get
      Return Properties("Architect_Address").Value
      End Get
      Set(ByVal Value As String)
      Properties("Architect_Address").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Architect_Email]() As String
      Get
      Return Properties("Architect_Email").Value
      End Get
      Set(ByVal Value As String)
      Properties("Architect_Email").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Architect_Fax]() As String
      Get
      Return Properties("Architect_Fax").Value
      End Get
      Set(ByVal Value As String)
      Properties("Architect_Fax").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Architect_Name]() As String
      Get
      Return Properties("Architect_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Architect_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Architect_Telephone]() As String
      Get
      Return Properties("Architect_Telephone").Value
      End Get
      Set(ByVal Value As String)
      Properties("Architect_Telephone").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Consultant_Address]() As String
      Get
      Return Properties("Consultant_Address").Value
      End Get
      Set(ByVal Value As String)
      Properties("Consultant_Address").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Consultant_Email]() As String
      Get
      Return Properties("Consultant_Email").Value
      End Get
      Set(ByVal Value As String)
      Properties("Consultant_Email").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Consultant_Fax]() As String
      Get
      Return Properties("Consultant_Fax").Value
      End Get
      Set(ByVal Value As String)
      Properties("Consultant_Fax").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Consultant_Name]() As String
      Get
      Return Properties("Consultant_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Consultant_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Consultant_Telephone]() As String
      Get
      Return Properties("Consultant_Telephone").Value
      End Get
      Set(ByVal Value As String)
      Properties("Consultant_Telephone").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Consultant_Type]() As String
      Get
      Return Properties("Consultant_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Consultant_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Contractor_Address]() As String
      Get
      Return Properties("Contractor_Address").Value
      End Get
      Set(ByVal Value As String)
      Properties("Contractor_Address").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Contractor_Email]() As String
      Get
      Return Properties("Contractor_Email").Value
      End Get
      Set(ByVal Value As String)
      Properties("Contractor_Email").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Contractor_Fax]() As String
      Get
      Return Properties("Contractor_Fax").Value
      End Get
      Set(ByVal Value As String)
      Properties("Contractor_Fax").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Contractor_Name]() As String
      Get
      Return Properties("Contractor_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Contractor_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Contractor_Telephone]() As String
      Get
      Return Properties("Contractor_Telephone").Value
      End Get
      Set(ByVal Value As String)
      Properties("Contractor_Telephone").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Contractor_Type]() As String
      Get
      Return Properties("Contractor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Contractor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Design_Inputs]() As String
      Get
      Return Properties("Design_Inputs").Value
      End Get
      Set(ByVal Value As String)
      Properties("Design_Inputs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Engineering_Units]() As String
      Get
      Return Properties("Engineering_Units").Value
      End Get
      Set(ByVal Value As String)
      Properties("Engineering_Units").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Designer]() As String
      Get
      Return Properties("Honeywell_Designer").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Designer").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Designer_EID]() As String
      Get
      Return Properties("Honeywell_Designer_EID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Designer_EID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Office]() As String
      Get
      Return Properties("Honeywell_Office").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Office").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Office_Email]() As String
      Get
      Return Properties("Honeywell_Office_Email").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Office_Email").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Office_Fax]() As String
      Get
      Return Properties("Honeywell_Office_Fax").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Office_Fax").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Office_Telephone]() As String
      Get
      Return Properties("Honeywell_Office_Telephone").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Office_Telephone").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Technician]() As String
      Get
      Return Properties("Honeywell_Technician").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Technician").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_Technician_EID]() As String
      Get
      Return Properties("Honeywell_Technician_EID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Technician_EID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Inputs_Log_Link]() As String
      Get
      Return Properties("Inputs_Log_Link").Value
      End Get
      Set(ByVal Value As String)
      Properties("Inputs_Log_Link").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Site_Plant]() As String
      Get
      Return Properties("Project_Site_Plant").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Site_Plant").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Unit_Flow]() As String
      Get
      Return Properties("Unit_Flow").Value
      End Get
      Set(ByVal Value As String)
      Properties("Unit_Flow").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Unit_Length]() As String
      Get
      Return Properties("Unit_Length").Value
      End Get
      Set(ByVal Value As String)
      Properties("Unit_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Unit_Pressure]() As String
      Get
      Return Properties("Unit_Pressure").Value
      End Get
      Set(ByVal Value As String)
      Properties("Unit_Pressure").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Unit_Temperature]() As String
      Get
      Return Properties("Unit_Temperature").Value
      End Get
      Set(ByVal Value As String)
      Properties("Unit_Temperature").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Unit_Volume]() As String
      Get
      Return Properties("Unit_Volume").Value
      End Get
      Set(ByVal Value As String)
      Properties("Unit_Volume").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Unit_Weight]() As String
      Get
      Return Properties("Unit_Weight").Value
      End Get
      Set(ByVal Value As String)
      Properties("Unit_Weight").CalculatedValue = Value
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
    InitPart("Project_Information", <a><![CDATA[Project_Information]]></a>.Value, 47, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/19/2025 19:41:00")
    AddProperty("648", "Architect_Address", <a><![CDATA[Architect Address]]></a>.Value, "The address, city/state, and PIN of the architect.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("651", "Architect_Email", <a><![CDATA[Architect Email]]></a>.Value, "The email of the architect.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("650", "Architect_Fax", <a><![CDATA[Architect Fax]]></a>.Value, "The fax of the architect.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("647", "Architect_Name", <a><![CDATA[Architect Name]]></a>.Value, "The name of the architect of this project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("649", "Architect_Telephone", <a><![CDATA[Architect Telephone]]></a>.Value, "The telephone of the architect.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("654", "Consultant_Address", <a><![CDATA[Consultant Address]]></a>.Value, "The address, city/state, and PIN of the consultant.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("657", "Consultant_Email", <a><![CDATA[Consultant Email]]></a>.Value, "The email of the consultant.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("656", "Consultant_Fax", <a><![CDATA[Consultant Fax]]></a>.Value, "The fax of the consultant.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("653", "Consultant_Name", <a><![CDATA[Consultant Name]]></a>.Value, "The name of the consultant.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("655", "Consultant_Telephone", <a><![CDATA[Consultant Telephone]]></a>.Value, "The telephone of the consultant.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("652", "Consultant_Type", <a><![CDATA[Consultant Type]]></a>.Value, "The title of the consultant. Default is Consultant.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("664", "Contractor_Address", <a><![CDATA[Contractor Address]]></a>.Value, "The address, city/state, and PIN of the contractor.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("660", "Contractor_Email", <a><![CDATA[Contractor Email]]></a>.Value, "The email of the contractor.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("663", "Contractor_Fax", <a><![CDATA[Contractor Fax]]></a>.Value, "The fax of the contractor.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("662", "Contractor_Name", <a><![CDATA[Contractor Name]]></a>.Value, "The name of the contractor.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("661", "Contractor_Telephone", <a><![CDATA[Contractor Telephone]]></a>.Value, "The telephone of the contractor.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("658", "Contractor_Type", <a><![CDATA[Contractor Type]]></a>.Value, "The title of the contractor. Default is Contractor.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("665", "Design_Inputs", <a><![CDATA[Design Inputs]]></a>.Value, "The name, revision number, and date of the Design Inputs document.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("640", "Engineering_Units", <a><![CDATA[Engineering Units]]></a>.Value, "The engineering units (Metric/Imperial/Mixed) used in the project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("638", "Honeywell_Designer", <a><![CDATA[Honeywell Designer]]></a>.Value, "The name of the Honeywell designer for this project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("639", "Honeywell_Designer_EID", <a><![CDATA[Honeywell Designer EID]]></a>.Value, "The EID of the Honeywell designer for this project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("632", "Honeywell_Office", <a><![CDATA[Honeywell Office]]></a>.Value, "The address, city/state, and PIN of the Honeywell Office for the project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("635", "Honeywell_Office_Email", <a><![CDATA[Honeywell Office - Email]]></a>.Value, "The email address of the Honeywell office.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("634", "Honeywell_Office_Fax", <a><![CDATA[Honeywell Office - Fax]]></a>.Value, "The fax of the Honeywell office.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("633", "Honeywell_Office_Telephone", <a><![CDATA[Honeywell Office - Telephone]]></a>.Value, "The telephone of the Honeywell office.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("636", "Honeywell_Technician", <a><![CDATA[Honeywell Technician]]></a>.Value, "The name of the Honeywell technician for the project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("637", "Honeywell_Technician_EID", <a><![CDATA[Honeywell Technician EID]]></a>.Value, "The EID of the Honeywell technician for the project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("666", "Inputs_Log_Link", <a><![CDATA[Inputs Log Link]]></a>.Value, "A link to the Inputs Log.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("631", "Project_Site_Plant", <a><![CDATA[Project Site Plant]]></a>.Value, "The site plant of the project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("643", "Unit_Flow", <a><![CDATA[Unit_Flow]]></a>.Value, "Choose the unit of flow: Metric (L/s) or Imperial (gpm)", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("645", "Unit_Length", <a><![CDATA[Unit_Length]]></a>.Value, "Choose the unit of length: Metric (m) or Imperial (in)", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("642", "Unit_Pressure", <a><![CDATA[Unit_Pressure]]></a>.Value, "Choose the unit of pressure: Metric (Pa) or Imperial (inwc)", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("641", "Unit_Temperature", <a><![CDATA[Unit_Temperature]]></a>.Value, "Choose the unit of temperature: Metric (°C) or Imperial (°F)", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("644", "Unit_Volume", <a><![CDATA[Unit_Volume]]></a>.Value, "Choose the unit of volume: Metric (l) or Imperial (g)", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("646", "Unit_Weight", <a><![CDATA[Unit_Weight]]></a>.Value, "Choose the unit of weight: Metric (kg) or Imperial (lb)", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("630", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601423", "5/6/2025 5:32:12 PM")
    
      AddPropertyExtended(651,"Architect_Email", "606", "EXTHINT ", "Hint", "Email", "GLOBAL\H601423", "5/6/2025 7:28:17 PM")
    
      AddPropertyExtended(650,"Architect_Fax", "605", "EXTHINT ", "Hint", "Fax", "GLOBAL\H601423", "5/6/2025 7:27:51 PM")
    
      AddPropertyExtended(649,"Architect_Telephone", "604", "EXTHINT ", "Hint", "Telephone", "GLOBAL\H601423", "5/6/2025 7:26:34 PM")
    
      AddPropertyExtended(657,"Consultant_Email", "612", "EXTHINT ", "Hint", "Email", "GLOBAL\H601423", "5/6/2025 7:32:45 PM")
    
      AddPropertyExtended(656,"Consultant_Fax", "611", "EXTHINT ", "Hint", "Fax", "GLOBAL\H601423", "5/6/2025 7:32:25 PM")
    
      AddPropertyExtended(653,"Consultant_Name", "608", "EXTHINT ", "Hint", "Name", "GLOBAL\H601423", "5/6/2025 7:30:35 PM")
    
      AddPropertyExtended(655,"Consultant_Telephone", "610", "EXTHINT ", "Hint", "Telephone", "GLOBAL\H601423", "5/6/2025 7:32:00 PM")
    
      AddPropertyExtended(660,"Contractor_Email", "615", "EXTHINT ", "Hint", "Email", "GLOBAL\H601423", "5/6/2025 7:35:09 PM")
    
      AddPropertyExtended(663,"Contractor_Fax", "618", "EXTHINT ", "Hint", "Fax", "GLOBAL\H601423", "5/6/2025 7:37:35 PM")
    
      AddPropertyExtended(662,"Contractor_Name", "617", "EXTHINT ", "Hint", "Name", "GLOBAL\H601423", "5/6/2025 7:36:35 PM")
    
      AddPropertyExtended(661,"Contractor_Telephone", "616", "EXTHINT ", "Hint", "Telephone", "GLOBAL\H601423", "5/6/2025 7:36:06 PM")
    
      AddPropertyExtended(637,"Honeywell_Technician_EID", "592", "EXTHINT ", "Hint", "EID", "GLOBAL\H601423", "5/6/2025 6:09:29 PM")
    
      AddValidValue("Engineering_Units")
    
      AddValidValue("Unit_Flow")
    
      AddValidValue("Unit_Length")
    
      AddValidValue("Unit_Pressure")
    
      AddValidValue("Unit_Temperature")
    
      AddValidValue("Unit_Volume")
    
      AddValidValue("Unit_Weight")
    
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
          InitProperty("Architect_Address", "603", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:21:44 PM", "", "In Development",  0,1443)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Architect_Email", "606", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:28:07 PM", "", "In Development",  0,1446)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Architect_Fax", "605", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:27:44 PM", "", "In Development",  0,1445)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Architect_Name", "602", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:15:56 PM", "", "In Development",  0,1442)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Architect_Telephone", "604", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:23:20 PM", "", "In Development",  0,1444)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Consultant_Address", "609", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:30:57 PM", "", "In Development",  0,1449)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Consultant_Email", "612", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:32:39 PM", "", "In Development",  0,1452)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Consultant_Fax", "611", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:32:17 PM", "", "In Development",  0,1451)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Consultant_Name", "608", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:30:29 PM", "", "In Development",  0,1448)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Consultant_Telephone", "610", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:31:47 PM", "", "In Development",  0,1450)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Consultant_Type", "607", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:29:44 PM", "", "In Development",  0,1447)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Contractor_Address", "619", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:38:25 PM", "", "In Development",  0,1460)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Contractor_Email", "615", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:35:09 PM", "", "In Development",  0,1456)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Contractor_Fax", "618", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:37:26 PM", "", "In Development",  0,1459)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Contractor_Name", "617", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:36:25 PM", "", "In Development",  0,1458)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Contractor_Telephone", "616", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:35:55 PM", "", "In Development",  0,1457)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Contractor_Type", "613", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:33:32 PM", "", "In Development",  0,1454)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Design_Inputs", "620", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:39:58 PM", "", "In Development",  0,1461)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Engineering_Units", "595", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:16:43 PM", "", "In Development",  0,1422)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Designer", "593", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:11:02 PM", "", "In Development",  0,1420)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Designer_EID", "594", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:11:46 PM", "", "In Development",  0,1421)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Office", "587", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:02:34 PM", "", "In Development",  0,1414)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Office_Email", "590", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:06:43 PM", "", "In Development",  0,1417)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Office_Fax", "589", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:04:55 PM", "", "In Development",  0,1416)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Office_Telephone", "588", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:03:13 PM", "", "In Development",  0,1415)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Technician", "591", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:08:28 PM", "", "In Development",  0,1418)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Technician_EID", "592", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 6:09:29 PM", "", "In Development",  0,1419)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Inputs_Log_Link", "621", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 7:43:54 PM", "", "In Development",  0,1462)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Site_Plant", "586", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 5:53:52 PM", "", "In Development",  0,1413)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unit_Flow", "598", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:56:06 PM", "", "In Development",  0,1430)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unit_Length", "600", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:56:01 PM", "", "In Development",  0,1436)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unit_Pressure", "597", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:55:56 PM", "", "In Development",  0,1427)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unit_Temperature", "596", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:55:51 PM", "", "In Development",  0,1424)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unit_Volume", "599", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:55:46 PM", "", "In Development",  0,1433)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unit_Weight", "601", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:55:40 PM", "", "In Development",  0,1439)
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
          
        InitValidValue("Engineering_Units_ValidValues", "595", "-1", 1423)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Unit_Flow_ValidValues", "598", "-1", 1432)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Unit_Length_ValidValues", "600", "-1", 1438)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Unit_Pressure_ValidValues", "597", "-1", 1429)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Unit_Temperature_ValidValues", "596", "-1", 1426)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Unit_Volume_ValidValues", "599", "-1", 1435)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Unit_Weight_ValidValues", "601", "-1", 1441)
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
          Public Function Formula_Architect_Address() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Architect_Address").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:603; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:603; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Architect_Address", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Architect_Email() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Architect_Email").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:606; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:606; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Architect_Email", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Architect_Fax() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Architect_Fax").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:605; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:605; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Architect_Fax", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Architect_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Architect_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:602; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:602; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Architect_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Architect_Telephone() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Architect_Telephone").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:604; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:604; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Architect_Telephone", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Consultant_Address() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Consultant_Address").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:609; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:609; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Consultant_Address", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Consultant_Email() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Consultant_Email").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:612; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:612; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Consultant_Email", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Consultant_Fax() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Consultant_Fax").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:611; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:611; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Consultant_Fax", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Consultant_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Consultant_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:608; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:608; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Consultant_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Consultant_Telephone() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Consultant_Telephone").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:610; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:610; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Consultant_Telephone", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Consultant_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Consultant_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:607; TYPE:PF
      Result = "Consultant"
      '   END FORMULA; PROP ID:607; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Consultant_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Contractor_Address() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Contractor_Address").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:619; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:619; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Contractor_Address", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Contractor_Email() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Contractor_Email").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:615; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:615; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Contractor_Email", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Contractor_Fax() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Contractor_Fax").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:618; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:618; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Contractor_Fax", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Contractor_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Contractor_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:617; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:617; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Contractor_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Contractor_Telephone() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Contractor_Telephone").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:616; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:616; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Contractor_Telephone", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Contractor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Contractor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:613; TYPE:PF
      Result = "Contractor"
      '   END FORMULA; PROP ID:613; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Contractor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Design_Inputs() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Design_Inputs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:620; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:620; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Design_Inputs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Engineering_Units() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Engineering_Units").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:595; TYPE:PF
      Result = "Metric"
      '   END FORMULA; PROP ID:595; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Engineering_Units", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Designer() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Designer").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:593; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:593; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Designer", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Designer_EID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Designer_EID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:594; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:594; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Designer_EID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Office() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Office").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:587; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:587; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Office", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Office_Email() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Office_Email").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:590; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:590; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Office_Email", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Office_Fax() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Office_Fax").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:589; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:589; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Office_Fax", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Office_Telephone() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Office_Telephone").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:588; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:588; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Office_Telephone", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Technician() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Technician").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:591; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:591; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Technician", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Technician_EID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Technician_EID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:592; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:592; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Honeywell_Technician_EID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Inputs_Log_Link() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Inputs_Log_Link").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:621; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:621; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Inputs_Log_Link", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Site_Plant() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Site_Plant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:586; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:586; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Project_Site_Plant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unit_Flow() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Flow").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:598; TYPE:PF
      Result = "Metric (L/s)"
If (Me.Engineering_Units = "Imperial") Then
	Result = "Imperial (gpm)"
End If
      '   END FORMULA; PROP ID:598; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Flow", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unit_Length() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:600; TYPE:PF
      Result = "Metric (m)"
If (Me.Engineering_Units = "Imperial") Then
	Result = "Imperial (in)"
End If
      '   END FORMULA; PROP ID:600; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unit_Pressure() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Pressure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:597; TYPE:PF
      Result = "Metric (Pa)"
If (Me.Engineering_Units = "Imperial") Then
	Result = "Imperial (inwc)"
End If
      '   END FORMULA; PROP ID:597; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Pressure", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unit_Temperature() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Temperature").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:596; TYPE:PF
      Result = "Metric (°C)"
If (Me.Engineering_Units = "Imperial") Then
	Result = "Imperial (°F)"
End If
      '   END FORMULA; PROP ID:596; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Temperature", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unit_Volume() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Volume").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:599; TYPE:PF
      Result = "Metric (l)"
If (Me.Engineering_Units = "Imperial") Then
	Result = "Imperial (g)"
End If
      '   END FORMULA; PROP ID:599; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Volume", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unit_Weight() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Weight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:601; TYPE:PF
      Result = "Metric (kg)"
If (Me.Engineering_Units = "Imperial") Then
	Result = "Imperial (lb)"
End If
      '   END FORMULA; PROP ID:601; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Weight", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Address_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Email_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Fax_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Telephone_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Address_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Email_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Fax_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Telephone_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Address_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Email_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Fax_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Telephone_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Design_Inputs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engineering_Units_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Designer_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Designer_EID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_Email_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_Fax_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_Telephone_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Technician_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Technician_EID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Inputs_Log_Link_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Plant_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Flow_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Pressure_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Temperature_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Volume_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Weight_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Address_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Email_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Fax_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Architect_Telephone_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Address_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Email_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Fax_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Telephone_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Consultant_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Address_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Email_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Fax_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Telephone_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Contractor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Design_Inputs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engineering_Units_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Designer_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Designer_EID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_Email_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_Fax_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Office_Telephone_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Technician_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Technician_EID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Inputs_Log_Link_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Plant_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Flow_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Unit_Flow").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:598; TYPE:UC
              If Not(Me.Engineering_Units = "Mixed") Then
	Result = False
Else
	Result = True
End If
              '   END FORMULA; PROP ID:598; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Flow_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Length_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Unit_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:600; TYPE:UC
              If Not(Me.Engineering_Units = "Mixed") Then
	Result = False
Else
	Result = True
End If
              '   END FORMULA; PROP ID:600; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Length_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Pressure_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Unit_Pressure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:597; TYPE:UC
              If Not(Me.Engineering_Units = "Mixed") Then
	Result = False
Else
	Result = True
End If
              '   END FORMULA; PROP ID:597; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Pressure_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Temperature_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Unit_Temperature").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:596; TYPE:UC
              If Not(Me.Engineering_Units = "Mixed") Then
	Result = False
Else
	Result = True
End If
              '   END FORMULA; PROP ID:596; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Temperature_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Volume_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Unit_Volume").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:599; TYPE:UC
              If Not(Me.Engineering_Units = "Mixed") Then
	Result = False
Else
	Result = True
End If
              '   END FORMULA; PROP ID:599; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Volume_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Weight_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Unit_Weight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:601; TYPE:UC
              If Not(Me.Engineering_Units = "Mixed") Then
	Result = False
Else
	Result = True
End If
              '   END FORMULA; PROP ID:601; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Weight_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engineering_Units_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Engineering_Units").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:595; TYPE:VV
      Result = MakeValidValues(Array("Metric", "Imperial", "Mixed"))
      '   END FORMULA; PROP ID:595; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Engineering_Units_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Flow_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Flow").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:598; TYPE:VV
      Result = MakeValidValues(Array("Metric (L/s)", "Imperial (gpm)"))
      '   END FORMULA; PROP ID:598; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Flow_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Length_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:600; TYPE:VV
      Result = MakeValidValues(Array("Metric (m)", "Imperial (in)"))
      '   END FORMULA; PROP ID:600; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Length_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Pressure_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Pressure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:597; TYPE:VV
      Result = MakeValidValues(Array("Metric (Pa)", "Imperial (inwc)"))
      '   END FORMULA; PROP ID:597; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Pressure_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Temperature_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Temperature").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:596; TYPE:VV
      Result = MakeValidValues(Array("Metric (°C)", "Imperial (°F)"))
      '   END FORMULA; PROP ID:596; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Temperature_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Volume_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Volume").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:599; TYPE:VV
      Result = MakeValidValues(Array("Metric (l)", "Imperial (g)"))
      '   END FORMULA; PROP ID:599; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Volume_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Weight_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Weight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:601; TYPE:VV
      Result = MakeValidValues(Array("Metric (kg)", "Imperial (lb)"))
      '   END FORMULA; PROP ID:601; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Project_Information.Formula_Unit_Weight_ValidValues", ex.Message)
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

  