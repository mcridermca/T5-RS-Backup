Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_APC_Scan_Belt
'$ GenerateDate: 07/24/2025 22:14:38

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

    Public Class [CAE_APC_Scan_Belt]
    
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

    Private this as CAE_APC_Scan_Belt = me

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
    
          Public Property [Barcode_Transmit_Calculated_Distance_In]() As Double
      Get
      Return Properties("Barcode_Transmit_Calculated_Distance_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Barcode_Transmit_Calculated_Distance_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belt_Total_Length_Required_IN]() As Double
      Get
      Return Properties("Belt_Total_Length_Required_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belt_Total_Length_Required_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Length_Max_IN]() As Double
      Get
      Return Properties("Carton_Length_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Length_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Speed_FPM]() As Double
      Get
      Return Properties("Conveyor_Speed_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Speed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Host_Destination_Calculated_Distance_In]() As Double
      Get
      Return Properties("Host_Destination_Calculated_Distance_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Host_Destination_Calculated_Distance_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Host_Destination_Time_Sec]() As Double
      Get
      Return Properties("Host_Destination_Time_Sec").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Host_Destination_Time_Sec").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LocalMachine_Destination_Time_Sec]() As Double
      Get
      Return Properties("LocalMachine_Destination_Time_Sec").Value
      End Get
      Set(ByVal Value As Double)
      Properties("LocalMachine_Destination_Time_Sec").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Photocell_Calculated_Tracking_Distance_In]() As Double
      Get
      Return Properties("Photocell_Calculated_Tracking_Distance_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Photocell_Calculated_Tracking_Distance_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scan_Pattern_Calculated_Length_In]() As Double
      Get
      Return Properties("Scan_Pattern_Calculated_Length_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scan_Pattern_Calculated_Length_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_Transmit_Configuration]() As String
      Get
      Return Properties("Scanner_Transmit_Configuration").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scanner_Transmit_Configuration").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sorter_2Sided_Calculated_Distance_In]() As Double
      Get
      Return Properties("Sorter_2Sided_Calculated_Distance_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sorter_2Sided_Calculated_Distance_In").CalculatedValue = Value
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
    
      Public ReadOnly Property [My_Induction]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Induction")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
      End Get
      End Property
    
      Public ReadOnly Property [My_Setup]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Setup")
      End Get
      End Property
    
      Public ReadOnly Property [My_Sortation]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Sortation")
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
    InitPart("CAE_APC_Scan_Belt", <a><![CDATA[CAE_APC_Scan_Belt]]></a>.Value, 451, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H621516", "07/24/2025 20:54:43")
    AddProperty("11364", "Barcode_Transmit_Calculated_Distance_In", <a><![CDATA[Barcode_Transmit_Calculated_Distance_In]]></a>.Value, "(C) Distance to Barcode Transmit point", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H621516", "7/24/2025 8:49:49 PM")
    AddProperty("11324", "Belt_Total_Length_Required_IN", <a><![CDATA[Belt_Total_Length_Required_IN]]></a>.Value, "Total Belt Length Required", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 2:13:41 PM")
    AddProperty("11321", "Carton_Length_Max_IN", <a><![CDATA[Carton_Length_Max_IN]]></a>.Value, "(A) 3/4 of The Length of Longest Product", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 9:56:48 PM")
    AddProperty("11370", "Conveyor_Speed_FPM", <a><![CDATA[Conveyor_Speed_FPM]]></a>.Value, "Conveyor speed of induction plate", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H621516", "7/24/2025 8:50:26 PM")
    AddProperty("11366", "Host_Destination_Calculated_Distance_In", <a><![CDATA[Host_Destination_Calculated_Distance_In]]></a>.Value, "(E) Distance required to receive destination from host", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H621516", "7/24/2025 8:50:52 PM")
    AddProperty("11369", "Host_Destination_Time_Sec", <a><![CDATA[Host_Destination_Time_Sec]]></a>.Value, "Time required to receive destination from host ( Host Query Mode)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H621516", "7/24/2025 8:52:14 PM")
    AddProperty("11368", "LocalMachine_Destination_Time_Sec", <a><![CDATA[LocalMachine_Destination_Time_Sec]]></a>.Value, "Time required for local machine control to determine Destination (local lookuo mode)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H621516", "7/24/2025 8:52:52 PM")
    AddProperty("11365", "Photocell_Calculated_Tracking_Distance_In", <a><![CDATA[Photocell_Calculated_Tracking_Distance_In]]></a>.Value, "(D) Distance required from Xmit point to Tracking photocell", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H621516", "7/24/2025 8:54:26 PM")
    AddProperty("11373", "Scan_Pattern_Calculated_Length_In", <a><![CDATA[Scan_Pattern_Calculated_Length_In]]></a>.Value, "(B) Length of scan pattern", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H621516", "7/24/2025 8:54:43 PM")
    AddProperty("11322", "Scanner_Transmit_Configuration", <a><![CDATA[Scanner_Transmit_Configuration]]></a>.Value, "Scanner Transmit Configuration (Leading Edge or Trailing Edge): Enter T or L   Leading Edge Transmit point is used for typical scanner tracking application  Trailing Edge Transmit point is used for most non-tracking applications  Note: Enter ""L"" for Leading Edge if not  enough information is known", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 10:32:32 PM")
    AddProperty("11371", "Sorter_2Sided_Calculated_Distance_In", <a><![CDATA[Sorter_2Sided_Calculated_Distance_In]]></a>.Value, "(F) Additional distance required to stage shoes for 2-sided sorting", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H621516", "7/24/2025 8:48:24 PM")
    AddProperty("11320", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 9:51:48 PM")
    
      oConnection = AddConnection("My_Induction", <a><![CDATA[My_Induction]]></a>.Value, "Connection to My Induction Object", "232", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/23/2025 9:54:17 PM")
      
        oConnection.AddVPF(448, "CAE_APC_Induction")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "233", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/23/2025 9:54:17 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "My App Calc Setup Object", "234", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/23/2025 9:54:17 PM")
      
        oConnection.AddVPF(119, "APC_Setup")
      
      oConnection = AddConnection("My_Sortation", <a><![CDATA[My_Sortation]]></a>.Value, "", "245", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/24/2025 2:21:19 PM")
      
        oConnection.AddVPF(436, "APC_Setup_Sort_Equip_Option")
      
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
          InitProperty("Barcode_Transmit_Calculated_Distance_In", "10909", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:49:49 PM", "", "In Development",  0,21753)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Total_Length_Required_IN", "10873", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 10:42:55 PM", "", "In Development",  0,21424)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Length_Max_IN", "10870", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 9:56:48 PM", "", "In Development",  0,21411)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Speed_FPM", "10915", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:50:26 PM", "", "In Development",  0,21754)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Host_Destination_Calculated_Distance_In", "10911", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:50:52 PM", "", "In Development",  0,21755)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Host_Destination_Time_Sec", "10914", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:52:14 PM", "", "In Development",  0,21756)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LocalMachine_Destination_Time_Sec", "10913", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:52:52 PM", "", "In Development",  0,21757)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Photocell_Calculated_Tracking_Distance_In", "10910", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:54:26 PM", "", "In Development",  0,21758)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scan_Pattern_Calculated_Length_In", "10918", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:54:43 PM", "", "In Development",  0,21759)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_Transmit_Configuration", "10871", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 10:31:38 PM", "", "In Development",  0,21415)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_2Sided_Calculated_Distance_In", "10916", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/24/2025 8:48:24 PM", "", "In Development",  0,21752)
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
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Induction", "211", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 9:54:17 PM", "", "In Development", "N",379)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_PRD", "212", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 9:54:17 PM", "", "In Development", "N",380)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "213", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 9:54:18 PM", "", "In Development", "N",381)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Sortation", "224", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/24/2025 2:21:19 PM", "", "In Development", "N",392)
        
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
      Public Function Formula_My_Induction_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:211; TYPE:PF
        Result = Nothing
If Me.Parent.Induction.Quantity > 0 Then
	Result = Me.Parent.Induction(1)
End If
        '   END FORMULA; CON ID:211; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_My_Induction_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
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
        '   BEGIN FORMULA; CON ID:212; TYPE:PF
        Result = Me.Parent.My_Prd(1)
        '   END FORMULA; CON ID:212; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Setup_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:213; TYPE:PF
        Result = Me.Parent.My_Setup(1)
        '   END FORMULA; CON ID:213; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_My_Setup_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Sortation_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:224; TYPE:PF
        Result = Me.Parent.Sortation(1)
        '   END FORMULA; CON ID:224; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_My_Sortation_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Barcode_Transmit_Calculated_Distance_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Barcode_Transmit_Calculated_Distance_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10909; TYPE:PF
      Result = 0.0
'=Induction!F32
Result = My_Induction(1).Carton_Maximum_Linear_Length_Scanned_In
      '   END FORMULA; PROP ID:10909; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Barcode_Transmit_Calculated_Distance_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_Total_Length_Required_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Total_Length_Required_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10873; TYPE:PF
      'Todo: VY Implement - Dependent on Scan Belt
'='Scan Belt'!G56/12

Result = 99 '!! <<--FAKE NUMBER
      '   END FORMULA; PROP ID:10873; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Belt_Total_Length_Required_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Length_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Length_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10870; TYPE:PF
      Result = 0.0
'=max_carton_length*0.75
Result = Me.My_Setup(1).BoxSize_Length_Max_IN * .75
      '   END FORMULA; PROP ID:10870; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Carton_Length_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Speed_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10915; TYPE:PF
      Result = 0.0
'=Sortation!H48
Result = My_Sortation(1).Chosen_Sort_Speed_FPM
      '   END FORMULA; PROP ID:10915; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Conveyor_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Host_Destination_Calculated_Distance_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Host_Destination_Calculated_Distance_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10911; TYPE:PF
      Result = 0.0
'=IF(InductionRoutingMethod="Real-Time Host Query",((L36*12)/60)*L38,((L36*12)/60)*L40)
If My_Induction(1).Induction_Routing_Method = "Real-Time Host Query" Then
	Result = ((Conveyor_Speed_FPM * 12)/60) * Host_Destination_Time_Sec
Else
	Result = ((Conveyor_Speed_FPM * 12)/60) * LocalMachine_Destination_Time_Sec
End If
      '   END FORMULA; PROP ID:10911; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Host_Destination_Calculated_Distance_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Host_Destination_Time_Sec() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Host_Destination_Time_Sec").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10914; TYPE:PF
      Result = 0.0
'=Induction!F50
Result = My_Induction(1).Host_Response_Max_Time_Sec
      '   END FORMULA; PROP ID:10914; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Host_Destination_Time_Sec", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LocalMachine_Destination_Time_Sec() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LocalMachine_Destination_Time_Sec").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10913; TYPE:PF
      Result = 0.0
'=Induction!F51
Result = My_Induction(1).Local_LookupTime_Max_Sec
      '   END FORMULA; PROP ID:10913; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_LocalMachine_Destination_Time_Sec", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Photocell_Calculated_Tracking_Distance_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Photocell_Calculated_Tracking_Distance_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10910; TYPE:PF
      Result = 0.0
'=Induction!F31
Result = My_Induction(1).Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN
      '   END FORMULA; PROP ID:10910; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Photocell_Calculated_Tracking_Distance_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scan_Pattern_Calculated_Length_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scan_Pattern_Calculated_Length_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10918; TYPE:PF
      Result = 0.0
'=Induction!F28
Result = My_Induction(1).ReadWindowSize_IN
      '   END FORMULA; PROP ID:10918; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Scan_Pattern_Calculated_Length_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_Transmit_Configuration() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Transmit_Configuration").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10871; TYPE:PF
      Result = ""

'=If(Induction!$F$29="Lead Edge","L","T")

Result = If(Me.My_Induction(1).Scanner_Data_Transmit_Mode="Lead Edge","L","T")
      '   END FORMULA; PROP ID:10871; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Scanner_Transmit_Configuration", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sorter_2Sided_Calculated_Distance_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_2Sided_Calculated_Distance_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10916; TYPE:PF
      Result = 0.0'
'If(VLOOKUP(SorterType,'Lists-1'!$D$4:$O$21,12,FALSE)="No",0,
If( My_Sortation(1).Check_Width = False) Then
	Result = 0 
Else  
	Result = My_Sortation(1).Sorter_Selected_Width_IN * 1.375+91.375
End if
      '   END FORMULA; PROP ID:10916; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Sorter_2Sided_Calculated_Distance_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Barcode_Transmit_Calculated_Distance_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Total_Length_Required_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Speed_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Host_Destination_Calculated_Distance_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Host_Destination_Time_Sec_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LocalMachine_Destination_Time_Sec_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Photocell_Calculated_Tracking_Distance_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Pattern_Calculated_Length_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Transmit_Configuration_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_2Sided_Calculated_Distance_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Barcode_Transmit_Calculated_Distance_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Total_Length_Required_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Belt_Total_Length_Required_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10873; TYPE:UC
              'Todo: MPC Implement
Result = False
              '   END FORMULA; PROP ID:10873; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Scan_Belt.Formula_Belt_Total_Length_Required_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Speed_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Host_Destination_Calculated_Distance_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Host_Destination_Time_Sec_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LocalMachine_Destination_Time_Sec_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Photocell_Calculated_Tracking_Distance_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Pattern_Calculated_Length_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Transmit_Configuration_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_2Sided_Calculated_Distance_In_USERCHANGE() as Boolean
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

  