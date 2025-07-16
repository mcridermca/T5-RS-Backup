Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: PRD_Output_Test_01
'$ GenerateDate: 07/16/2025 15:29:13

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

    Public Class [PRD_Output_Test_01]
    
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

    Private this as PRD_Output_Test_01 = me

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
    
          Public Property [Debug_Mode]() As Boolean
      Get
      Return Properties("Debug_Mode").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Debug_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Data_Entered]() As Boolean
      Get
      Return Properties("PRD_Data_Entered").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("PRD_Data_Entered").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Date_Contract_Award]() As String
      Get
      Return Properties("PRD_Date_Contract_Award").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Date_Contract_Award").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Date_Eng_InHouse_Start]() As String
      Get
      Return Properties("PRD_Date_Eng_InHouse_Start").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Date_Eng_InHouse_Start").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Name]() As String
      Get
      Return Properties("PRD_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Code]() As String
      Get
      Return Properties("Project_Code").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Code").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Identifier]() As Long
      Get
      Return Properties("Project_Identifier").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Project_Identifier").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Name]() As String
      Get
      Return Properties("Project_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_City_State]() As String
      Get
      Return Properties("Proposal_City_State").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_City_State").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Customer_Name]() As String
      Get
      Return Properties("Proposal_Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Customer_Number]() As String
      Get
      Return Properties("Proposal_Customer_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Customer_Number").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Description]() As String
      Get
      Return Properties("Proposal_Description").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Description").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_ID]() As String
      Get
      Return Properties("Proposal_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Name]() As String
      Get
      Return Properties("Proposal_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Name").CalculatedValue = Value
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
    
          Public Property [XMLObjectValue]() As String
      Get
      Return Properties("XMLObjectValue").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectValue").CalculatedValue = Value
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
    
      Public ReadOnly Property [Output_Lines]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Output_Lines")
      End Get
      End Property
    
      Public ReadOnly Property [MySource]() As Rulestream.Kernel.Connection
      Get
      Return Connections("MySource")
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
    InitPart("PRD_Output_Test_01", <a><![CDATA[PRD_Output_Test_01]]></a>.Value, 425, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/16/2025 15:27:18")
    AddProperty("10391", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "True = Debug On / False = Debug Off", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 1:29:46 PM")
    AddProperty("10400", "PRD_Data_Entered", <a><![CDATA[PRD_Data_Entered]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:14:51 PM")
    AddProperty("10401", "PRD_Date_Contract_Award", <a><![CDATA[PRD Date Contract Award]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:27:18 PM")
    AddProperty("10402", "PRD_Date_Eng_InHouse_Start", <a><![CDATA[PRD Date Eng InHouse Start]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:15:07 PM")
    AddProperty("10403", "PRD_Name", <a><![CDATA[PRD_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:15:16 PM")
    AddProperty("10404", "Project_Code", <a><![CDATA[Project_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:15:24 PM")
    AddProperty("10405", "Project_Identifier", <a><![CDATA[Project_Identifier]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:15:47 PM")
    AddProperty("10406", "Project_Name", <a><![CDATA[Project_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:15:57 PM")
    AddProperty("10407", "Proposal_City_State", <a><![CDATA[Proposal City State]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:16:06 PM")
    AddProperty("10408", "Proposal_Customer_Name", <a><![CDATA[Proposal Customer Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:16:15 PM")
    AddProperty("10409", "Proposal_Customer_Number", <a><![CDATA[Proposal Customer Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:16:24 PM")
    AddProperty("10410", "Proposal_Description", <a><![CDATA[Proposal Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:16:33 PM")
    AddProperty("10411", "Proposal_ID", <a><![CDATA[Proposal ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:16:42 PM")
    AddProperty("10412", "Proposal_Name", <a><![CDATA[Proposal Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 3:17:01 PM")
    AddProperty("10392", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "XML Export Object Name", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "7/16/2025 2:42:32 PM")
    AddProperty("10393", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "XML Export Object Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "7/16/2025 1:29:46 PM")
    AddProperty("10394", "XMLObjectValue", <a><![CDATA[XMLObjectValue]]></a>.Value, "XML Export Object Value", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "7/16/2025 1:29:46 PM")
    AddProperty("10385", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 1:29:46 PM")
    
      oSubpart = AddSubpart(343,"Output_Lines", <a><![CDATA[Output_lines]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/16/2025 3:12:17 PM")
      
        oSubpart.AddVPF (426, "PRD_Output_Test_01_Line", "PRD_Output_Test_01_Line")
      
      oConnection = AddConnection("MySource", <a><![CDATA[My Source Part Family]]></a>.Value, "Connection to the Value Provider Part Family Instance", "190", "OO", 0, "","Oracle Config XML", 9999, "Oracle Configurator Transfer", "GLOBAL\H601424", "7/16/2025 2:45:58 PM")
      
        oConnection.AddVPF(143, "SFD_Salesforce_Data_Mock")
      
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
          InitProperty("Debug_Mode", "9966", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 1:29:46 PM", "True = Debug On / False = Debug Off", "In Development",  0,18065)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Data_Entered", "9974", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:14:51 PM", "", "In Development",  0,18129)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Date_Contract_Award", "9975", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:27:18 PM", "", "In Development",  0,18150)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Date_Eng_InHouse_Start", "9976", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:15:07 PM", "", "In Development",  0,18131)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Name", "9977", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:15:16 PM", "", "In Development",  0,18132)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "9978", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:15:24 PM", "", "In Development",  0,18133)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Identifier", "9979", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:15:47 PM", "", "In Development",  0,18134)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "9980", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:15:57 PM", "", "In Development",  0,18135)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_City_State", "9981", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:16:06 PM", "", "In Development",  0,18136)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Customer_Name", "9982", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:16:15 PM", "", "In Development",  0,18137)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Customer_Number", "9983", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:16:24 PM", "", "In Development",  0,18138)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Description", "9984", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:16:33 PM", "", "In Development",  0,18139)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_ID", "9985", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:16:42 PM", "", "In Development",  0,18140)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Name", "9986", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 3:16:54 PM", "", "In Development",  0,18141)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "9967", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 2:42:32 PM", "XML Export Object Name", "In Development",  0,18084)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "9968", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 1:29:46 PM", "XML Export Object Type", "In Development",  0,18067)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectValue", "9969", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 1:29:46 PM", "XML Export Object Value", "In Development",  0,18068)
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
          
        InitSubpart("Output_Lines", 270, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/16/2025 3:12:17 PM", "", "In Development", "N",0,736,740)
        
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
          
        InitConnection("MySource", "170", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/16/2025 2:39:08 PM", "Connection to the Value Provider Part Family Instance", "In Development", "Y",311)
        
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
      Public Function Formula_MySource_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:170; TYPE:PF
        Result = Me.Parent
        '   END FORMULA; CON ID:170; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_MySource_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("Debug_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9966; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:9966; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Debug_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Data_Entered() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Data_Entered").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9974; TYPE:PF
      Result = False
Dim MyPropertyName = Me.CurrentProperty.Name
If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9974; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_PRD_Data_Entered", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Date_Contract_Award() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Date_Contract_Award").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9975; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9975; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_PRD_Date_Contract_Award", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Date_Eng_InHouse_Start() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Date_Eng_InHouse_Start").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9976; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name
If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9976; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_PRD_Date_Eng_InHouse_Start", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9977; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name
If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9977; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_PRD_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Code() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Code").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9978; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name
If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9978; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Project_Code", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Identifier() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Identifier").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9979; TYPE:PF
      result = 0

Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9979; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Project_Identifier", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9980; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9980; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Project_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_City_State() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_City_State").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9981; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9981; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Proposal_City_State", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9982; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9982; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Proposal_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Customer_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Customer_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9983; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9983; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Proposal_Customer_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9984; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9984; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Proposal_Description", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9985; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9985; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Proposal_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9986; TYPE:PF
      Result = ""
Dim MyPropertyName = Me.CurrentProperty.Name

If Me.MySource.Quantity = 1 Then 
	Result = Me.MySource(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:9986; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Proposal_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9967; TYPE:PF
      Result = "PRD_Output_Test"
      '   END FORMULA; PROP ID:9967; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_XMLObjectName", ex.Message)
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
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("XMLObjectType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9968; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:9968; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_XMLObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectValue() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("XMLObjectValue").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9969; TYPE:PF
      Dim Prop As PropertySF = Me.CurrentProperty
Result = Custom.GetPFXMLRepresentation(Prop) 'Generate XML For this and Children Classes
      '   END FORMULA; PROP ID:9969; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_XMLObjectValue", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_PRD_Data_Entered_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Contract_Award_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Eng_InHouse_Start_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Code_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Identifier_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_City_State_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Number_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Description_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Name_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_XMLObjectValue_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_PRD_Data_Entered_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Contract_Award_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Eng_InHouse_Start_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Code_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Identifier_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_City_State_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Number_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Description_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Name_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_XMLObjectValue_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Output_Lines_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:270; TYPE:PN
      
      '   END FORMULA; SUB ID:270; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Output_Lines_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Output_Lines_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Output_Lines").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:270; TYPE:QF
      Result = Me.MySource(1).All_PRD_Product_Items.Quantity
      '   END FORMULA; SUB ID:270; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Output_Lines_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Output_Lines_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Output_Lines").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:270; TYPE:OP
      result = "PRD_Output_Test_01_Line"
      '   END FORMULA; SUB ID:270; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PRD_Output_Test_01.Formula_Output_Lines_OPTIMALPARTFAMILY", ex.Message)
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

  