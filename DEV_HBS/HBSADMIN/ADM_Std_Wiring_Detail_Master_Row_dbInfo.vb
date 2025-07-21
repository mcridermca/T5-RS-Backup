Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBSADMIN
'$ PartFamily: ADM_Std_Wiring_Detail_Master_Row_dbInfo
'$ GenerateDate: 07/21/2025 12:33:29

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
    Imports HBSADMIN.swMateType_e
    Imports HBSADMIN.swMateAlign_e
    Imports HBSADMIN.severity

    Public Class [ADM_Std_Wiring_Detail_Master_Row_dbInfo]
    
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

    Private this as ADM_Std_Wiring_Detail_Master_Row_dbInfo = me

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
    
          Public Property [Deleted]() As Boolean
      Get
      Return Properties("Deleted").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Deleted").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Do_Type]() As String
      Get
      Return Properties("Do_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Do_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Is_Active]() As Boolean
      Get
      Return Properties("Is_Active").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_Active").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [No_Of_Terminals]() As Long
      Get
      Return Properties("No_Of_Terminals").Value
      End Get
      Set(ByVal Value As Long)
      Properties("No_Of_Terminals").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Point_Type]() As String
      Get
      Return Properties("Point_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Point_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Power_Supply]() As String
      Get
      Return Properties("Power_Supply").Value
      End Get
      Set(ByVal Value As String)
      Properties("Power_Supply").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Resistor_Required]() As String
      Get
      Return Properties("Resistor_Required").Value
      End Get
      Set(ByVal Value As String)
      Properties("Resistor_Required").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Order]() As Long
      Get
      Return Properties("Sort_Order").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sort_Order").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Wiring_Std_Detail_Description]() As String
      Get
      Return Properties("Wiring_Std_Detail_Description").Value
      End Get
      Set(ByVal Value As String)
      Properties("Wiring_Std_Detail_Description").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Wiring_Std_Detail_Dwg]() As String
      Get
      Return Properties("Wiring_Std_Detail_Dwg").Value
      End Get
      Set(ByVal Value As String)
      Properties("Wiring_Std_Detail_Dwg").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Wiring_Type]() As String
      Get
      Return Properties("Wiring_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Wiring_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Std_Wiring_Detail_Master_Id]() As Long
      Get
      Return Properties("Std_Wiring_Detail_Master_Id").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Std_Wiring_Detail_Master_Id").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Std_Wiring_Detail_Master_Id_String]() As String
      Get
      Return Properties("Std_Wiring_Detail_Master_Id_String").Value
      End Get
      Set(ByVal Value As String)
      Properties("Std_Wiring_Detail_Master_Id_String").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Created_By]() As String
      Get
      Return Properties("Created_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Created_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Created_On]() As String
      Get
      Return Properties("Created_On").Value
      End Get
      Set(ByVal Value As String)
      Properties("Created_On").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Hash]() As String
      Get
      Return Properties("Data_Hash").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Hash").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Modified_By]() As String
      Get
      Return Properties("Modified_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Modified_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Modified_On]() As String
      Get
      Return Properties("Modified_On").Value
      End Get
      Set(ByVal Value As String)
      Properties("Modified_On").CalculatedValue = Value
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
    InitPart("ADM_Std_Wiring_Detail_Master_Row_dbInfo", <a><![CDATA[ADM_Std_Wiring_Detail_Master_Row_dbInfo]]></a>.Value, 77, "HBSADMIN",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601423", "06/30/2025 17:18:30")
    AddProperty("968", "Deleted", <a><![CDATA[Deleted]]></a>.Value, "Deleted Flag", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:43:32 PM")
    AddProperty("975", "Do_Type", <a><![CDATA[Do_Type]]></a>.Value, "Do Type", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:45:53 PM")
    AddProperty("969", "Is_Active", <a><![CDATA[Is_Active]]></a>.Value, "Is Record Active (Not Obsolute)", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:43:48 PM")
    AddProperty("977", "No_Of_Terminals", <a><![CDATA[No_Of_Terminals]]></a>.Value, "Number of Terminals", "Long","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:46:36 PM")
    AddProperty("974", "Point_Type", <a><![CDATA[Point_Type]]></a>.Value, "Point Type", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:45:41 PM")
    AddProperty("978", "Power_Supply", <a><![CDATA[Power_Supply]]></a>.Value, "Power Supply for Wiring", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:46:52 PM")
    AddProperty("980", "Resistor_Required", <a><![CDATA[Resistor_Required]]></a>.Value, "Is Resistor Required", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:47:42 PM")
    AddProperty("981", "Sort_Order", <a><![CDATA[Sort_Order]]></a>.Value, "First Sort Order 0 = Default = 100 , Adjust Accordingly", "Long","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:48:17 PM")
    AddProperty("973", "Wiring_Std_Detail_Description", <a><![CDATA[Wiring_Std_Detail_Description]]></a>.Value, "Standard Wiring Detail Description", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:45:23 PM")
    AddProperty("979", "Wiring_Std_Detail_Dwg", <a><![CDATA[Wiring_Std_Detail_Dwg]]></a>.Value, "File Name of Wiring Drawing", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:47:30 PM")
    AddProperty("976", "Wiring_Type", <a><![CDATA[Wiring_Type]]></a>.Value, "Wiring Type", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:46:09 PM")
    AddProperty("972", "Std_Wiring_Detail_Master_Id", <a><![CDATA[Std_Wiring_Detail_Master_Id]]></a>.Value, "Primary Key", "Long","","Master Data PK","FD", 9999, "", 0,0, "", "", "GLOBAL\H601423", "6/29/2025 1:02:46 PM")
    AddProperty("1180", "Std_Wiring_Detail_Master_Id_String", <a><![CDATA[Std_Wiring_Detail_Master_Id_String]]></a>.Value, "Primary Key", "String","","Master Data PK","FD", 9999, "", 0,0, "", "", "GLOBAL\H601423", "6/29/2025 12:54:02 PM")
    AddProperty("965", "Created_By", <a><![CDATA[Created_By]]></a>.Value, "User that created the record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:42:27 PM")
    AddProperty("966", "Created_On", <a><![CDATA[Created_On]]></a>.Value, "Date User Created record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:42:45 PM")
    AddProperty("967", "Data_Hash", <a><![CDATA[Data_Hash]]></a>.Value, "Hash of Master Data Fields", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:43:14 PM")
    AddProperty("970", "Modified_By", <a><![CDATA[Modified_By]]></a>.Value, "User that modified the record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:44:13 PM")
    AddProperty("971", "Modified_On", <a><![CDATA[Modified_On]]></a>.Value, "Date modified", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:44:44 PM")
    AddProperty("942", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 1:32:43 PM")
    
      AddDBConstraint(29, "dbInfo", <a><![CDATA[dbInfo]]></a>.Value,"Master DBInfo", 9999)
    
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
          InitProperty("Deleted", "893", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:43:32 PM", "Deleted Flag", "In Development",  0,1875)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Do_Type", "900", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:45:53 PM", "Do Type", "In Development",  0,1882)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Active", "894", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:43:48 PM", "Is Record Active (Not Obsolute)", "In Development",  0,1876)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("No_Of_Terminals", "902", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:46:36 PM", "Number of Terminals", "In Development",  0,1884)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point_Type", "899", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:45:41 PM", "Point Type", "In Development",  0,1881)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Supply", "903", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:46:52 PM", "Power Supply for Wiring", "In Development",  0,1885)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Resistor_Required", "905", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:47:42 PM", "Is Resistor Required", "In Development",  0,1887)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order", "906", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:48:17 PM", "First Sort Order 0 = Default = 100 , Adjust Accordingly", "In Development",  0,1888)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Wiring_Std_Detail_Description", "898", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:45:23 PM", "Standard Wiring Detail Description", "In Development",  0,1880)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Wiring_Std_Detail_Dwg", "904", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:47:30 PM", "File Name of Wiring Drawing", "In Development",  0,1886)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Wiring_Type", "901", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:46:09 PM", "Wiring Type", "In Development",  0,1883)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Std_Wiring_Detail_Master_Id", "897", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:45:07 PM", "Primary Key", "In Development",  0,1879)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Std_Wiring_Detail_Master_Id_String", "1090", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "6/29/2025 12:54:02 PM", "", "In Development",  0,2083)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Created_By", "890", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:42:27 PM", "User that created the record", "In Development",  0,1872)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Created_On", "891", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:42:45 PM", "Date User Created record", "In Development",  0,1873)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Hash", "892", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:43:14 PM", "Hash of Master Data Fields", "In Development",  0,1874)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_By", "895", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:44:13 PM", "User that modified the record", "In Development",  0,1877)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_On", "896", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 1:44:44 PM", "Date modified", "In Development",  0,1878)
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("dbInfo", 29,"", "Y","", "", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Created_By",29, "Created_By", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Created_On",29, "Created_On", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Deleted",29, "Deleted", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Do_Type",29, "Do_Type", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Is_Active",29, "Is_Active", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Modified_By",29, "Modified_By", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Modified_On",29, "Modified_On", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "No_Of_Terminals",29, "No_Of_Terminals", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Point_Type",29, "Point_Type", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Power_Supply",29, "Power_Supply", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Resistor_Required",29, "Resistor_Required", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Sort_Order",29, "Sort_Order", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Std_Wiring_Detail_Master_Id_String",29, "Std_Wiring_Detail_Master_ID_String", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Wiring_Std_Detail_Description",29, "Wiring_Std_Detail_Description", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Wiring_Std_Detail_Dwg",29, "Wiring_Std_Detail_Dwg", "Std_Wiring_Detail_Master")
        
          InitDBproperty("dbInfo", "Wiring_Type",29, "Wiring_Type", "Std_Wiring_Detail_Master")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Deleted() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Deleted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:893; TYPE:PF
      result = False
      '   END FORMULA; PROP ID:893; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Deleted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Do_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Do_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:900; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:900; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Do_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Is_Active() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_Active").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:894; TYPE:PF
      result = True
      '   END FORMULA; PROP ID:894; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Is_Active", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_No_Of_Terminals() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("No_Of_Terminals").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:902; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:902; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_No_Of_Terminals", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Point_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Point_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:899; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:899; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Point_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Power_Supply() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Power_Supply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:903; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:903; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Power_Supply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Resistor_Required() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Resistor_Required").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:905; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:905; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Resistor_Required", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Order() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Order").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:906; TYPE:PF
      result = 100
      '   END FORMULA; PROP ID:906; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Sort_Order", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Wiring_Std_Detail_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Wiring_Std_Detail_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:898; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:898; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Wiring_Std_Detail_Description", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Wiring_Std_Detail_Dwg() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Wiring_Std_Detail_Dwg").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:904; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:904; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Wiring_Std_Detail_Dwg", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Wiring_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Wiring_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:901; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:901; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Wiring_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Std_Wiring_Detail_Master_Id() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Std_Wiring_Detail_Master_Id").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:897; TYPE:PF
      result = Me.Parent.Properties("Std_Wiring_Detail_Master_ID").Value
      '   END FORMULA; PROP ID:897; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Std_Wiring_Detail_Master_Id", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Std_Wiring_Detail_Master_Id_String() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Std_Wiring_Detail_Master_Id_String").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1090; TYPE:PF
      Result = Me.Parent.Properties("Std_Wiring_Detail_Master_ID").Value
      '   END FORMULA; PROP ID:1090; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Std_Wiring_Detail_Master_Id_String", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Created_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Created_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:890; TYPE:PF
      result = "ERROR"
      '   END FORMULA; PROP ID:890; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Created_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Created_On() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Created_On").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:891; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:891; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Created_On", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Hash() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Hash").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:892; TYPE:PF
      Result = ""

For Each p As PropertySF In Me.properties
	If P.CategoryName.Trim().ToLower() = "master data" Or P.CategoryName.Trim().ToLower() = "master data pk"Then
		Result = Result & $"{P.Value}".Tolower() & ";"
	End If
Next P
      '   END FORMULA; PROP ID:892; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Data_Hash", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Modified_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Modified_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:895; TYPE:PF
      result = "ERROR"
      '   END FORMULA; PROP ID:895; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Modified_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Modified_On() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Modified_On").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:896; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:896; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.Formula_Modified_On", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Deleted_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Do_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Active_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_No_Of_Terminals_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Resistor_Required_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wiring_Std_Detail_Description_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wiring_Std_Detail_Dwg_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wiring_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Wiring_Detail_Master_Id_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Wiring_Detail_Master_Id_String_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Created_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Created_On_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Hash_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_On_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Deleted_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Do_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Active_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_No_Of_Terminals_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Resistor_Required_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wiring_Std_Detail_Description_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wiring_Std_Detail_Dwg_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wiring_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Wiring_Detail_Master_Id_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Wiring_Detail_Master_Id_String_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Created_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Created_On_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Hash_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_On_USERCHANGE() as Boolean
      Return False
      End Function
    

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Function GetRecordsetSQL(ByVal lngDBConID as Long) as String Implements RuleStream.IRsPartFormulas.GetRecordsetSQL
    Dim strSelectStmt As String = ""
    
      Dim strWhereClause as String = ""
      Dim strSelectList as String = ""
      Dim varPropSpecVal As Object
      Dim ctx As Object
      Dim leftDelimiter As String = String.Empty
      Dim rightDelimiter As String = String.Empty
      Try
      Select Case g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.MSAccess, RuleStream.DataService.PublicEnumerations.DatabaseTypes.SQLServer
      leftDelimiter = "["
      rightDelimiter = "]"
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.Oracle
      leftDelimiter = """"
      rightDelimiter = """"
      End Select
      ObjectManager.UnitConversion = False
      'Used to set the parameters results
      Select Case lngDBConID
      
        Case 29
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Created_By" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Created_On" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Deleted" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Do_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Is_Active" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Modified_By" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Modified_On" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "No_Of_Terminals" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Point_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Power_Supply" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Resistor_Required" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sort_Order" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Std_Wiring_Detail_Master_ID_String" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Wiring_Std_Detail_Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Wiring_Std_Detail_Dwg" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Wiring_Type" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.Std_Wiring_Detail_Master_Id
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Std_Wiring_Detail_Master_ID]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("Std_Wiring_Detail_Master"), strWhereClause, leftDelimiter & "Std_Wiring_Detail_Master_ID" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Std_Wiring_Detail_Master_Row_dbInfo.GetRecordset", strError)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      ObjectManager.UnitConversion = True
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

  