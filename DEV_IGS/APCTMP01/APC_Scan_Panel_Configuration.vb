Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Scan_Panel_Configuration
'$ GenerateDate: 07/15/2025 16:24:26

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

    Public Class [APC_Scan_Panel_Configuration]
    
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

    Private this as APC_Scan_Panel_Configuration = me

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
    
          Public Property [BP_ConvWidth]() As Double
      Get
      Return Properties("BP_ConvWidth").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BP_ConvWidth").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Presentation]() As String
      Get
      Return Properties("Carton_Presentation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Carton_Presentation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Is_Scanned]() As Boolean
      Get
      Return Properties("Is_Scanned").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_Scanned").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Min_Gap_Required]() As Double
      Get
      Return Properties("Min_Gap_Required").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Min_Gap_Required").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PandAAvgBoxHeight]() As Double
      Get
      Return Properties("PandAAvgBoxHeight").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PandAAvgBoxHeight").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PandAAvgBoxWidth]() As Double
      Get
      Return Properties("PandAAvgBoxWidth").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PandAAvgBoxWidth").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PandAMaxBoxHeight]() As Double
      Get
      Return Properties("PandAMaxBoxHeight").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PandAMaxBoxHeight").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PandaMaxBoxWidth]() As Double
      Get
      Return Properties("PandaMaxBoxWidth").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PandaMaxBoxWidth").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PandaMinBoxLength]() As Double
      Get
      Return Properties("PandaMinBoxLength").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PandaMinBoxLength").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Panel_ID]() As String
      Get
      Return Properties("Panel_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Panel_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Spacing_Category]() As Double
      Get
      Return Properties("Product_Spacing_Category").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Product_Spacing_Category").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Read_Window_Size]() As Double
      Get
      Return Properties("Read_Window_Size").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Read_Window_Size").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scan_Angle_Degrees]() As Double
      Get
      Return Properties("Scan_Angle_Degrees").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scan_Angle_Degrees").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scan_Head_Location]() As String
      Get
      Return Properties("Scan_Head_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scan_Head_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scan_Type]() As String
      Get
      Return Properties("Scan_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scan_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_CCD_Position]() As String
      Get
      Return Properties("Scanner_CCD_Position").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scanner_CCD_Position").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_Selected]() As String
      Get
      Return Properties("Scanner_Selected").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scanner_Selected").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sorter_Selected_Width_IN]() As Double
      Get
      Return Properties("Sorter_Selected_Width_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sorter_Selected_Width_IN").CalculatedValue = Value
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
    
      Public ReadOnly Property [Belted_Panda]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Belted_Panda")
      End Get
      End Property
    
      Public ReadOnly Property [Sortation_Master_Config]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Sortation_Master_Config")
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
    InitPart("APC_Scan_Panel_Configuration", <a><![CDATA[APC_Scan_Panel_Configuration]]></a>.Value, 418, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/15/2025 16:24:11")
    AddProperty("10151", "BP_ConvWidth", <a><![CDATA[Belt Panda  Conveyor Width]]></a>.Value, "Belt Panda  Conveyor Width from (Belt Panda Object)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/14/2025 10:31:35 PM")
    AddProperty("10202", "Carton_Presentation", <a><![CDATA[Carton_Presentation]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/15/2025 4:24:11 PM")
    AddProperty("9943", "Is_Scanned", <a><![CDATA[Is_Scanned]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:28:07 PM")
    AddProperty("9983", "Min_Gap_Required", <a><![CDATA[Min_Gap_Required]]></a>.Value, "Calculation of Minimum Gap Required, either from the Global MTBF or the refereced PandA MTBF", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/14/2025 7:45:56 PM")
    AddProperty("10016", "PandAAvgBoxHeight", <a><![CDATA[PandAAvgBoxHeight]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 8:24:53 PM")
    AddProperty("10015", "PandAAvgBoxWidth", <a><![CDATA[PandAAvgBoxWidth]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 8:25:26 PM")
    AddProperty("10017", "PandAMaxBoxHeight", <a><![CDATA[PandAMaxBoxHeight]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 8:23:50 PM")
    AddProperty("10018", "PandaMaxBoxWidth", <a><![CDATA[PandaMaxBoxWidth]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 8:24:08 PM")
    AddProperty("10013", "PandaMinBoxLength", <a><![CDATA[PandaMinBoxLength]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 9:08:54 PM")
    AddProperty("9942", "Panel_ID", <a><![CDATA[Panel_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:26:55 PM")
    AddProperty("9957", "Product_Spacing_Category", <a><![CDATA[Product_Spacing_Category]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 9:49:05 PM")
    AddProperty("10021", "Read_Window_Size", <a><![CDATA[Read_Window_Size]]></a>.Value, "Calculation of Read Window Size", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/15/2025 4:17:26 PM")
    AddProperty("9950", "Scan_Angle_Degrees", <a><![CDATA[Scan_Angle_Degrees]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 12:05:01 PM")
    AddProperty("10008", "Scan_Head_Location", <a><![CDATA[Scan_Head_Location]]></a>.Value, "Scanner CCD Position", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 9:18:22 PM")
    AddProperty("9945", "Scan_Type", <a><![CDATA[Scan_Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:38:33 PM")
    AddProperty("9946", "Scanner_CCD_Position", <a><![CDATA[Scanner_CCD_Position]]></a>.Value, "Scanner CCD Position", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 6:07:09 PM")
    AddProperty("9944", "Scanner_Selected", <a><![CDATA[Scanner_Selected]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:32:38 PM")
    AddProperty("10124", "Sorter_Selected_Width_IN", <a><![CDATA[Sorter_Selected_Width_IN]]></a>.Value, "Master Sorter Width (From Sortation Object)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/14/2025 4:56:20 PM")
    AddProperty("9941", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 6:02:49 PM")
    
      AddValidValue("Scanner_CCD_Position")
    
      AddValidValue("Scanner_Selected")
    
      AddValidValue("Sorter_Selected_Width_IN")
    
      oConnection = AddConnection("Belted_Panda", <a><![CDATA[Belted_Panda]]></a>.Value, "", "180", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/15/2025 12:08:47 PM")
      
        oConnection.AddVPF(412, "CAE_Print_And_Apply")
      
      oConnection = AddConnection("Sortation_Master_Config", <a><![CDATA[Sortation_Master_Config]]></a>.Value, "Connection / Reference to the Sortation Configuration Object", "168", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/14/2025 10:08:43 PM")
      
        oConnection.AddVPF(120, "APC_Sortation")
      
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
          InitProperty("BP_ConvWidth", "9732", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/14/2025 10:31:35 PM", "", "In Development",  0,17188)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Presentation", "9783", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/15/2025 4:24:11 PM", "", "In Development",  0,17484)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Scanned", "9525", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:28:07 PM", "", "In Development",  0,16541)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Min_Gap_Required", "9565", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/14/2025 7:45:56 PM", "", "In Development",  0,17135)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PandAAvgBoxHeight", "9598", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 8:24:53 PM", "", "In Development",  0,16814)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PandAAvgBoxWidth", "9597", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 8:23:35 PM", "", "In Development",  0,16811)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PandAMaxBoxHeight", "9599", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 8:23:50 PM", "", "In Development",  0,16812)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PandaMaxBoxWidth", "9600", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 8:24:08 PM", "", "In Development",  0,16813)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PandaMinBoxLength", "9595", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 9:08:54 PM", "", "In Development",  0,16821)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Panel_ID", "9524", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:26:55 PM", "", "In Development",  0,16540)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Spacing_Category", "9539", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 9:49:05 PM", "", "In Development",  0,16824)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Read_Window_Size", "9603", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/15/2025 4:17:26 PM", "", "In Development",  0,17480)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scan_Angle_Degrees", "9532", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 12:05:01 PM", "", "In Development",  0,16611)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scan_Head_Location", "9590", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 6:16:38 PM", "", "In Development",  0,16770)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scan_Type", "9527", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:38:29 PM", "", "In Development",  0,16550)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_CCD_Position", "9528", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/12/2025 6:07:09 PM", "", "In Development",  0,16682)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_Selected", "9526", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/11/2025 6:32:38 PM", "", "In Development",  0,16543)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_Selected_Width_IN", "9705", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/14/2025 4:55:11 PM", "", "In Development",  0,17102)
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
          
        InitValidValue("Scanner_CCD_Position_ValidValues", "9528", "-1", 16769)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Scanner_Selected_ValidValues", "9526", "-1", 16545)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sorter_Selected_Width_IN_ValidValues", "9705", "-1", 17101)
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
            If Incontext("-1", ctx) Then
          
        InitConnection("Belted_Panda", "160", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/15/2025 12:08:41 PM", "", "In Development", "N",293)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Sortation_Master_Config", "148", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/14/2025 10:08:43 PM", "", "In Development", "N",285)
        
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
      Public Function Formula_Belted_Panda_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:160; TYPE:PF
        Result = Me.Parent.CAE_App_Calc_Print_And_Apply(1)
        '   END FORMULA; CON ID:160; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Belted_Panda_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sortation_Master_Config_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:148; TYPE:PF
        Result = Me.Parent.Sortation_Master_Config
        '   END FORMULA; CON ID:148; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Sortation_Master_Config_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BP_ConvWidth() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BP_ConvWidth").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9732; TYPE:PF
      Result = 28 'Todo: MPC Pull from Belt Panda. Talk to Tyler ' BP_ConvWidth Cell $S$24
      '   END FORMULA; PROP ID:9732; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_BP_ConvWidth", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Presentation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Presentation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9783; TYPE:PF
      Result = Me.Parent.CartonPresentation
      '   END FORMULA; PROP ID:9783; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Carton_Presentation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Is_Scanned() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_Scanned").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9525; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:9525; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Is_Scanned", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Min_Gap_Required() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Min_Gap_Required").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9565; TYPE:PF
      Result = 0.0

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
		Select Case Me.Product_Spacing_Category 
			Case 1, 2
				'1 = PandaMinBoxLength
				'2 = PandaMinBoxLength
				Result = Me.PandaMinBoxLength
			Case 3
				'3 = If($K99="No",PandAMaxBoxHeight,If($K99="Partial",MAX(PandAAvgBoxHeight,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = Me.PandAMaxBoxHeight
					Case "Partial"
						If Me.PandAAvgBoxHeight >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxHeight
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Full"
						Result = PandaMinBoxLength 'Todo: Unhandled / Incorrectly (MPC 20250712)
				End Select
			Case 4
				'4 = If($K99="No",PandaMaxBoxWidth+1,If($K99="Partial",MAX(PandAAvgBoxWidth+1,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = Me.PandaMaxBoxWidth+1
					Case "Partial"
						If Me.PandAAvgBoxWidth+1 >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxWidth+1
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Full"
						Result = PandaMinBoxLength
				End Select
			Case 5
				'5 = If($K99="No",MAX((PandaMaxBoxWidth/2)+3,PandaMinBoxLength),If($K99="Partial",MAX((PandAAvgBoxWidth/2)+3,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						If (Me.PandaMaxBoxWidth/2)+3 >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxWidth+1
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Partial"
						If (PandAAvgBoxWidth/2)+3 > Me.PandaMinBoxLength Then
							Result = (PandAAvgBoxWidth/2)+3
						Else
							Result = Me.PandaMinBoxLength
						End If
						
					Case "Full"
						Result = PandaMinBoxLength
				End Select
		End Select
	Else
		Dim BoxSize_Height_Min_IN As Double = Me.Parent.My_Setup(1).BoxSize_Height_Min_IN
		Dim BoxSize_Length_Min_IN As Double = Me.Parent.My_Setup(1).BoxSize_Length_Min_IN
		Dim BoxSize_Height_Avg_IN As Double = Me.Parent.My_Setup(1).BoxSize_Height_Avg_IN
		Dim BoxSize_Width_Avg_IN As Double = Me.Parent.My_Setup(1).BoxSize_Width_Avg_IN
		Dim BoxSize_Height_Max_IN As Double = Me.Parent.My_Setup(1).BoxSize_Height_Max_IN
		Dim BoxSize_Width_Max_IN As Double = Me.Parent.My_Setup(1).BoxSize_Width_Max_IN
		Dim MinGapForScan As Double = Me.Parent.MinGapForScan_IN
		
		'Please Note: Case Else was used below in many cases as the excel spreadsheet did not have formulas that specifically called out "Full" ShadowingStatus. (20250712)
		Select Case Me.Product_Spacing_Category 
			Case 1
				'1 = MinGapForScan
				Result = MinGapForScan
			Case 2
				'2 = If(K99<>"Full",If(BoxSize_Height_Min_IN<BoxSize_Length_Min_IN,MAX(BoxSize_Height_Min_IN,BoxSize_Length_Min_IN,MinGapForScan),BoxSize_Length_Min_IN),MinGapForScan)
		
				Select Case Parent.ShadowingStatus
					Case "Full"
						Result = MinGapForScan
						Case Else
						If  BoxSize_Height_Min_IN  < BoxSize_Length_Min_IN Then
							Result = MAX(BoxSize_Height_Min_IN, BoxSize_Length_Min_IN)
							Result = MAX(Result,MinGapForScan)
						Else
							Result = BoxSize_Length_Min_IN
						End If
				End Select
			Case 3
				'3 = If(K99="No",BoxSize_Height_Max_IN,If(K99="Partial",BoxSize_Height_Avg_IN,MinGapForScan))			
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = BoxSize_Height_Max_IN
					Case "Partial"
						Result = BoxSize_Height_Avg_IN				
					Case Else
						Result = MinGapForScan
				End Select
			Case 4
				'4 = If(K99="No",BoxSize_Width_Max_IN+1,If(K99="Partial",BoxSize_Width_Avg_IN+1,MinGapForScan))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = BoxSize_Width_Max_IN + 1
					Case "Partial"
						Result = BoxSize_Width_Avg_IN + 1					
					Case  Else
						Result = MinGapForScan
				End Select
			Case 5
				'5 = If(K99="No",(BoxSize_Width_Max_IN/2)+3,If(K99="Partial",(BoxSize_Width_Avg_IN/2)+3,MinGapForScan))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = (BoxSize_Width_Max_IN/2) + 3
					Case "Partial"
						Result = (BoxSize_Width_Avg_IN/2)+3						
					Case Else
						Result = MinGapForScan
				End Select
		End Select
	End If
End If
      '   END FORMULA; PROP ID:9565; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Min_Gap_Required", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PandAAvgBoxHeight() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PandAAvgBoxHeight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9598; TYPE:PF
      Result = 0

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
		Result = 12 ' Todo : Pull from Panda PF
	End If
End If
      '   END FORMULA; PROP ID:9598; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_PandAAvgBoxHeight", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PandAAvgBoxWidth() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PandAAvgBoxWidth").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9597; TYPE:PF
      Result = 0

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
		Result = 12 ' Todo : Pull from Panda PF
	End If
End If
      '   END FORMULA; PROP ID:9597; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_PandAAvgBoxWidth", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PandAMaxBoxHeight() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PandAMaxBoxHeight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9599; TYPE:PF
      Result = 0

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
		Result = 30 ' Todo : Pull from Panda PF
	End If
End If
      '   END FORMULA; PROP ID:9599; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_PandAMaxBoxHeight", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PandaMaxBoxWidth() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PandaMaxBoxWidth").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9600; TYPE:PF
      Result = 0

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
		Result = 24 ' Todo : Pull from Panda PF
	End If
End If
      '   END FORMULA; PROP ID:9600; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_PandaMaxBoxWidth", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PandaMinBoxLength() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PandaMinBoxLength").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9595; TYPE:PF
      Result = 0

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
		Result = 6 ' Todo : Pull from Panda PF
	End If
End If
      '   END FORMULA; PROP ID:9595; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_PandaMinBoxLength", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Panel_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Panel_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9524; TYPE:PF
      Result = ""
Select Case Me.SubpartID
	Case 1 
			Result = "Top"
		Case 2 
			Result = "Bottom"
		Case 3 
			Result = "Left"
		Case 4
			 Result = "Right"
		 Case 5
			 Result = "Front"
		 Case 6
			 Result = "Back"
		 Case Else
			 Result = "ERROR!"
	 End Select
      '   END FORMULA; PROP ID:9524; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Panel_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Spacing_Category() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Spacing_Category").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9539; TYPE:PF
      Result = 0.0

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_Underside As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Underside")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	
	Select Case Me.Panel_ID
		Case "Top"
			'T =If(C89="Yes",If(And(I89=45,C94="Yes",H93="Overhead"),3,If(I89=90,1,If(And(GapControlMethod="Passive",ScanConfigAUsePandAMTBH="No"),2,3))),"")
			If Me.Scan_Angle_Degrees = 45 And FrontScanned And FrontScanned_Overhead Then
				Result = 3
			Else
				If Me.Scan_Angle_Degrees = 90 Then
					Result = 1
				Else
					If Me.Parent.UsePandAMTBH = False AndAlso Me.Parent.GapControlMethod = "Passive" Then
						Result = 2
					Else
						Result = 3
					End If
				End If
			End If
			
		Case "Bottom"
			'BT =If(C90="Yes",If(And(Or(C93="Yes",C94="Yes"),H93="Underside"),3,1),"")
			If FrontScanned_Underside And (FrontScanned Or BackScanned) Then
				Result = 3
			Else
				Result = 1
			End If

		Case "Left", "Right"
			'L =If(C91="Yes",If(I91=45,If(H93="1 Side",4,5),1),"")
			'R =If(C92="Yes",If(I92=45,If(H93="1 Side",4,5),1),"")
			If Me.Scan_Angle_Degrees = 45 Then
				If FrontScanned_1Side Then
					Result = 4
				Else
					Result = 5
				End If
			Else
				Result = 1	
			End If

		Case "Front"
			'F =If(C93="Yes",If(And(H93="Overhead",GapControlMethod="Passive",ScanConfigAUsePandAMTBH="No"),2,If(Or(H93="Underside",And(H93="Overhead",Or(GapControlMethod="Active",ScanConfigAUsePandAMTBH="Yes"))),3,If(H93="1 Side",4,5))),"")
			If FrontScanned_Overhead AndAlso Me.Parent.GapControlMethod = "Passive" And Me.Parent.UsePandAMTBH = False Then
				Result = 2
			Else
				If FrontScanned_Underside = True OrElse (FrontScanned_Overhead = True AndAlso (Me.Parent.GapControlMethod = "Active"Or  Me.Parent.UsePandAMTBH = True)) Then
        			Return 3
    			ElseIf FrontScanned_Overhead = True Then
        			Return 4
    			Else
        			Return 5
    			End If
			End If
			
		Case "Back"
			'BK =If(C94="Yes",If(H93="Overhead",3,If(H93="Underside",3,If(H93="1 Side",4,5))),"")
			If  FrontScanned_Overhead Then 
				Result = 3
			Else
				If FrontScanned_1Side Then
					Result = 4
				Else
					Result = 5
				End If
			End If	
	End Select
End If
      '   END FORMULA; PROP ID:9539; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Product_Spacing_Category", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Read_Window_Size() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Read_Window_Size").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9603; TYPE:PF
      Result = 0.0

'Dim x As Boolean = If(And(1,2),1,2)
'TODO: This needs completed (MPC - 20250712) ' Currently faked to support tyler dev.

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_Underside As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Underside")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim PandAMaxBoxHeightWidthDim As Double = MAX(PandAMaxBoxHeight,PandaMaxBoxWidth)
	'Dim BP_ConvWidth
	
	If Me.Parent.UsePandAMTBH Then
		'T = If($C89="Yes",If(And($G89="O",ScanConfigACartonPresentation="Edge Aligned"),PandAMaxBoxHeightWidthDim+6,If(And($G89="O",ScanConfigACartonPresentation="Random"),BP_ConvWidth+6,5)),"")
		'BT = If($C90="Yes",If(And($G90="O",ScanConfigACartonPresentation="Edge Aligned"),PandAMaxBoxHeightWidthDim+6,If(And($G90="O",ScanConfigACartonPresentation="Random"),BP_ConvWidth+6,5)),"")
		'L = If($C91="Yes",If($G91="O",PandAMaxBoxHeightWidthDim+6,5),"")
		'R = If($C92="Yes",If($G92="O",PandAMaxBoxHeightWidthDim+6,5),"")
		'F = If($C93="Yes",If(Or($H93="Overhead",$H93="Underside"),PandAMaxBoxHeightWidthDim+6,$L93+6),"")
		'B = If($C94="Yes",If(Or($H93="Overhead",$H93="Underside"),PandAMaxBoxHeightWidthDim+6,$L94+6),"")

		Select Case Me.Product_Spacing_Category 
			Case 1
				'If($C89="Yes",If                 And($G89="O",       ScanConfigACartonPresentation="Edge Aligned"),PandAMaxBoxHeightWidthDim+6,If(   And($G89="O", ScanConfigACartonPresentation="Random"),BP_ConvWidth+6,5)),"")
				  Result = If(Me.Is_Scanned,If(XlsAnd(Me.Scan_Type="O",      Me.Carton_Presentation="Edge Aligned"),PandAMaxBoxHeightWidthDim+6,If(XlsAnd(Me.Scan_Type="O",Me.Carton_Presentation="Random"),BP_ConvWidth+6,5  )), 0)
			Case 2
			
			Case 3
				'3 = If($K99="No",PandAMaxBoxHeight,If($K99="Partial",MAX(PandAAvgBoxHeight,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = Me.PandAMaxBoxHeight
					Case "Partial"
						If Me.PandAAvgBoxHeight >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxHeight
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Full"
						Result = PandaMinBoxLength 'Todo: Unhandled / Incorrectly (MPC 20250712)
				End Select
			Case 4
				'4 = If($K99="No",PandaMaxBoxWidth+1,If($K99="Partial",MAX(PandAAvgBoxWidth+1,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = Me.PandaMaxBoxWidth+1
					Case "Partial"
						If Me.PandAAvgBoxWidth+1 >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxWidth+1
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Full"
						Result = PandaMinBoxLength
				End Select
			Case 5
				'5 = If($K99="No",MAX((PandaMaxBoxWidth/2)+3,PandaMinBoxLength),If($K99="Partial",MAX((PandAAvgBoxWidth/2)+3,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						If (Me.PandaMaxBoxWidth/2)+3 >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxWidth+1
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Partial"
						If (PandAAvgBoxWidth/2)+3 > Me.PandaMinBoxLength Then
							Result = (PandAAvgBoxWidth/2)+3
						Else
							Result = Me.PandaMinBoxLength
						End If
						
					Case "Full"
						Result = PandaMinBoxLength
				End Select
		End Select
	Else
		Dim BoxSize_Height_Min_IN As Double = Me.Parent.My_Setup(1).BoxSize_Height_Min_IN
		Dim BoxSize_Length_Min_IN As Double = Me.Parent.My_Setup(1).BoxSize_Length_Min_IN
		Dim BoxSize_Height_Avg_IN As Double = Me.Parent.My_Setup(1).BoxSize_Height_Avg_IN
		Dim BoxSize_Width_Avg_IN As Double = Me.Parent.My_Setup(1).BoxSize_Width_Avg_IN
		Dim BoxSize_Height_Max_IN As Double = Me.Parent.My_Setup(1).BoxSize_Height_Max_IN
		Dim BoxSize_Width_Max_IN As Double = Me.Parent.My_Setup(1).BoxSize_Width_Max_IN
		Dim MinGapForScan As Double = Me.Parent.MinGapForScan_IN
		
		Dim MaxBoxHeightWidthDim As Integer = Me.Parent.My_Seup(1).MaxBoxHeightWidthDim
		
		
		

		'Please Note: Case Else was used below in many cases as the excel spreadsheet did not have formulas that specifically called out "Full" ShadowingStatus. (20250712)
		Select Case Me.Panel_ID 
			Case "Top"
				'T = If($C89="Yes",If(And($G89="O",ScanConfigACartonPresentation="Edge Aligned"),MaxBoxHeightWidthDim+6,If(And($G89="O",ScanConfigACartonPresentation="Random"),SorterWidth+6,5)),"")
				Result = If(Me.Is_Scanned,If(XlsAnd(Me.Scan_Type="O",Me.Parent.Carton_Presentation="Edge Aligned"),MaxBoxHeightWidthDim+6,If(XlsAnd(Me.Scan_Type="O",Me.Parent.ACartonPresentation="Random"),Sorter_Selected_Width_In+6,5)),0)
			Case "Bottom"
				'BT = If($C90="Yes",If(And($G90="O",ScanConfigACartonPresentation="Edge Aligned"),MaxBoxHeightWidthDim+6,If(And($G90="O",ScanConfigACartonPresentation="Random"),SorterWidth+6,5)),"")
				Result = If(Me.Is_Scanned,If(XlsAnd(Me.Scan_Type="O",Me.Parent.Carton_Presentation="Edge Aligned"),MaxBoxHeightWidthDim + 6,If(XlsAnd(Me.Scan_Type="O",Me.Parent.ACartonPresentation="Random"),Me.Sorter_Selected_Width_In+6,5)),0)
				
			Case "Left", "Right"
				'L = If($C91="Yes",If($G91="O",MaxBoxHeightWidthDim+6,5),"")
				'R = If($C92="Yes",If($G92="O",MaxBoxHeightWidthDim+6,5),"")
				 Result = If(Me.Is_Scanned,If(Me.Scan_Type="O",MaxBoxHeightWidthDim +6 ,5),0)
			Case "Front", "Back"
				'F = If($C93="Yes",If(Or($H93="Overhead",$H93="Underside"),MaxBoxHeightWidthDim+6,$L93+6),"")
				'BK = If($C94="Yes",If(Or($H93="Overhead",$H93="Underside"),MaxBoxHeightWidthDim+6,$L94+6),"")
				Result = If(Me.Is_Scanned,If( XlsOR(FrontScanned_OverHead,FrontScanned_Underside), MaxBoxHeightWidthDim + 6,Me.Min_Gap_Required + 6),0)
				
			
		End Select
	End If
End If
      '   END FORMULA; PROP ID:9603; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Read_Window_Size", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scan_Angle_Degrees() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scan_Angle_Degrees").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9532; TYPE:PF
      Result = 0.0

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Select Case Me.Panel_ID
		Case  "Top"
			' =IF(AND(OR(C93="YES",C94="Yes"),H93="Overhead"),45,90)
				'C93 = Front Scanded
				'C94 = Back Scanned
			If (FrontScanned OrElse BackScanned ) AndAlso FrontScanned_Overhead Then
            	Return 45  ' Condition is true
        	Else
            	Return 90  ' Condition is false
        	End If
		Case  "Bottom"
			Result = 45
		Case "Left","Right"
			'=IF(OR(AND(C93="YES",OR(H93="1 Side",H93="2 Sides")),AND(C94="Yes",OR(H93="1 Side",H93="2 Sides"))),45,90)
			'=IF(OR(AND(FrontScanned=TRUE, OR(FrontScanned_1Side ,FrontScanned_2Side)),AND(BackScanned,OR(FrontScanned_1Side,FrontScanned_2Side))),45,90)
			 If ((FrontScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side)) OrElse _
            	(BackScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side))) Then
            	
            	Return 45  ' At least one condition is true
        	Else
            	Return 90  ' Both conditions are false
        	End If
		Case "Front", "Back"
					
			Result = 45
	 End Select

End If
      '   END FORMULA; PROP ID:9532; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scan_Angle_Degrees", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scan_Head_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scan_Head_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9590; TYPE:PF
      Result = 0.0

If Me.Is_Scanned Then
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim LeftScanned As Boolean = Me.Parent.Panel_Config_Left(1).Is_Scanned
	Dim RightScanned As Boolean = Me.Parent.Panel_Config_Right(1).Is_Scanned
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BottomScanned As Boolean = Me.Parent.Panel_Config_Bottom(1).Is_Scanned
	 
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_Underside As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Underside")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Dim LeftAngle  As Double = Me.Parent.Panel_Config_Left(1).Scan_Angle_Degrees
	Dim RightAngle As Double = Me.Parent.Panel_Config_Right(1).Scan_Angle_Degrees
	
	Select Case Me.Panel_ID
		Case  "Top"
			'=IF(Scan_Angle_Degrees_Top=90,"O2",IF(AND(FrontScanned="Yes",BackScanned="Yes"),"O1 & O3",IF(FrontScanned="Yes","O1","O3")))
			If Me.Scan_Angle_Degrees = 90 Then
				Result = "O2"
			Else
				If FrontScanned And BackScanned   Then
					Result = "O1 & O3"
				Else
					If FrontScanned Then
					Result = "O1"
					Else
						Result = "O3"
					End If
				End If
			End If
		Case  "Bottom"
			' LEFT  =IF(AND(FrontScanned="Yes",BackScanned="Yes",H93="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",H93="Underside"),"U1","U2"))
			' RIGHT =IF(AND(FrontScanned="Yes",BackScanned="Yes",FrontScanned_Underside="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",FrontScanned_Underside="Underside"),"U1","U2")) 
			If FrontScanned = True And BackScanned = True And FrontScanned_Underside = True
				Result = "U1 & U2"
			Else
				If FrontScanned_Underside Then 
					Result = "U1"
				Else
					Result = "U2"
				End If
			End If 
		Case "Left"
			'I91 = LeftAngle
			'I92 = RightAngle
			' LEFT  =IF(AND(FrontScanned="Yes",BackScanned="Yes",H93="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",H93="Underside"),"U1","U2"))
			' RIGHT =IF(AND(FrontScanned="Yes",BackScanned="Yes",FrontScanned_Underside="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",FrontScanned_Underside="Underside"),"U1","U2"))
			If LeftAngle = 90 Then
				Result = "L2"
			Else
				If FrontScanned And BackScanned And FrontScanned_2Side Then
					Result = "L1 & L3"
				Else
				 	If	FrontScanned And BackScanned And FrontScanned_1Side	Then
						Result = "L1 or L3"
					Else
						If FrontScanned Then
							Result = "L3"
						Else
							Result = "L1"
						End If 
					End If
				End If
			End If
		Case "Right"
			'I91 = LeftAngle
			'I92 = RightAngle
			'=IF(I91=90,"L2",If(And(C93="Yes",C94="Yes",H93="2 Sides"),"L1 & L3",If(And(C93="Yes",C94="Yes",H93="1 Side"),"L1 or L3",If(C93="Yes","L3","L1"))))
			'=IF(I92=90,"R2",IF(AND(C93="Yes",C94="Yes",H93="2 Sides"),"R1 & R3",IF(AND(C93="Yes",C94="Yes",H93="1 Side"),"R1 or R3",IF(C94="Yes","R1","R3"))))
			If RightAngle = 90 Then
				Result = "R2"
			Else
				If FrontScanned And BackScanned And FrontScanned_2Side Then
					Result = "R1 & R3"
				Else
				 	If	FrontScanned And BackScanned And FrontScanned_1Side	Then
						Result = "R1 or R3"
					Else
						If FrontScanned Then
							Result = "R3"
						Else
							Result = "R1"
						End If 
					End If
				End If
			End If
		Case "Front"
			'FRONT = IF(H93="Overhead","O3",         IF(H93="Underside",         "U3",IF(AND(H93="1 Side",        OR(AND(C91="No",           C92="No"),                 AND(C91="Yes",           C92="Yes"))),            "R3 or L3", IF(AND(H93="1 Side",C91="Yes",C92="No"),                                "L3",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R3","R3 & L3")))))
			'BACK  = IF(H93="Overhead","O1",IF(H93="Underside","U1",IF(AND(H93="1 Side",OR(AND(C91="No",$C$92="No"),AND(C91="Yes",C92="Yes"))),"R1 or L1",IF(AND(H93="1 Side",C91="Yes",C92="No"),"L1",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R1","R1 & L1"))))) 
			'FRONT = IF(FrontSide_Overhead=True,"O3",IF(FrontSide_Underside=true,"U3",IF(AND(FrontSide_1Side=True,OR(AND(LeftSideScanned=False,RightSideScannede=False),AND(LeftSideScanned=True,RightSideScanned=True))),"R3 or L3", IF(AND(FrontSide_1Side=True,LeftSideScanned=True,RightSideScanned=False),"L3",IF(AND(FrontSide_1Side=True,LeftSideScanned=False,RighSideScanned=True),"R3","R3 & L3")))))
			If FrontScanned_Overhead Then
            	Return "O3"
        	ElseIf FrontScanned_Underside Then
            	Return "U3"
        	ElseIf FrontScanned_1Side AndAlso ((Not LeftScanned AndAlso Not RightScanned) OrElse (LeftScanned AndAlso RightScanned)) Then
            	Return "R3 or L3"
        	ElseIf FrontScanned_1Side AndAlso LeftScanned AndAlso Not RightScanned Then
            	Return "L3"
        	ElseIf FrontScanned_1Side AndAlso Not LeftScanned AndAlso RightScanned Then
            	Return "R3"
        	Else
            	Return "R3 & L3"
        	End If
		Case "Back"
			'FRONT = IF(H93="Overhead","O3",IF(H93="Underside","U3",IF(AND(H93="1 Side",OR(AND(C91="No",C92="No"),AND(C91="Yes",C92="Yes"))),"R3 or L3",IF(AND(H93="1 Side",C91="Yes",C92="No"),  "L3",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R3","R3 & L3")))))
			'BACK  = IF(H93="Overhead","O1",IF(H93="Underside","U1",IF(AND(H93="1 Side",OR(AND(C91="No",$C$92="No"),AND(C91="Yes",C92="Yes"))),"R1 or L1",IF(AND(H93="1 Side",C91="Yes",C92="No"),"L1",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R1","R1 & L1"))))) 
			'FRONT = IF(FrontSide_Overhead=True,"O3",IF(FrontSide_Underside=true,"U3",IF(AND(FrontSide_1Side=True,OR(AND(LeftSideScanned=False,RightSideScannede=False),AND(LeftSideScanned=True,RightSideScanned=True))),"R3 or L3", IF(AND(FrontSide_1Side=True,LeftSideScanned=True,RightSideScanned=False),"L3",IF(AND(FrontSide_1Side=True,LeftSideScanned=False,RighSideScanned=True),"R3","R3 & L3")))))
			If FrontScanned_Overhead Then
            	Return "O1"
        	ElseIf FrontScanned_Underside Then
            	Return "U1"
        	ElseIf FrontScanned_1Side AndAlso ((Not LeftScanned AndAlso Not RightScanned) OrElse (LeftScanned AndAlso RightScanned)) Then
            	Return "R1 or L1"
        	ElseIf FrontScanned_1Side AndAlso LeftScanned AndAlso Not RightScanned Then
            	Return "L1"
        	ElseIf FrontScanned_1Side AndAlso Not LeftScanned AndAlso RightScanned Then
            	Return "R1"
        	Else
            	Return "R1 & L1"
        	End If
		End Select
End If
      '   END FORMULA; PROP ID:9590; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scan_Head_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scan_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scan_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9527; TYPE:PF
      Result = ""
If Me.Is_Scanned Then
	'=IF(C89="Yes",IF(OR(D89="Laser Omni-Directional",D89="Camera Omni-Directional"),"O","U"),"")
	Select Case Me.Scanner_Selected
		Case "Laser Omni-Directional", "Camera Omni-Directional"
			Result = "O"
		Case Else
			Result = "U"
	End Select
End If
      '   END FORMULA; PROP ID:9527; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scan_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_CCD_Position() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_CCD_Position").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9528; TYPE:PF
      Result = ""
If Me.Is_Scanned Then
	Select Case Me.SubpartID
		Case 1 
			Result = "Overhead"
		Case 2 
			Result = "Underside"
		Case 3 
			Result = "1 Side"
		Case 4
			 Result = "1 Side"
		 Case 5
			 Result = "Please Select"
		 Case 6
			 Result = Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position
		 Case Else
			 Result = "ERROR!"
	 End Select

End If
      '   END FORMULA; PROP ID:9528; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_CCD_Position", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_Selected() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9526; TYPE:PF
      Result = ""
If Me.Is_Scanned Then
	Result = "Please Select"
End If
      '   END FORMULA; PROP ID:9526; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_Selected", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sorter_Selected_Width_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Selected_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9705; TYPE:PF
      Result = Me.Sortation_Master_Config(1).Sorter_Selected_Width_IN
      '   END FORMULA; PROP ID:9705; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Sorter_Selected_Width_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BP_ConvWidth_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Presentation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Scanned_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Gap_Required_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandAAvgBoxHeight_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandAAvgBoxWidth_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandAMaxBoxHeight_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandaMaxBoxWidth_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandaMinBoxLength_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Spacing_Category_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Read_Window_Size_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Angle_Degrees_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Head_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_CCD_Position_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Selected_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Selected_Width_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BP_ConvWidth_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Presentation_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Scanned_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Gap_Required_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandAAvgBoxHeight_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandAAvgBoxWidth_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandAMaxBoxHeight_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandaMaxBoxWidth_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PandaMinBoxLength_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Spacing_Category_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Read_Window_Size_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Angle_Degrees_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Head_Location_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_CCD_Position_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scanner_CCD_Position").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9528; TYPE:UC
              Result = False
If Me.Is_Scanned And Me.SubPartID = 5 Then 
 	Result = True '(Back Follows Front)
End If
              '   END FORMULA; PROP ID:9528; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_CCD_Position_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Selected_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scanner_Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9526; TYPE:UC
              Result = Me.Is_Scanned
              '   END FORMULA; PROP ID:9526; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_Selected_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Selected_Width_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_CCD_Position_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_CCD_Position").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9528; TYPE:VV
      If Me.Is_Scanned Then
	Select Case Me.SubpartID
		Case 1 
			Result = MakeValidValues(Array("Overhead")) ' "Overhead"
		Case 2 
			Result = MakeValidValues(Array("Underside"))  ' "Underside"
		Case 3 
			Result = MakeValidValues(Array("1 Side")) ' "1 Side"
		Case 4
			 Result = MakeValidValues(Array("1 Side")) ' "1 Side"
		 Case 5
			 Result = MakeValidValues(Array("Overhead", "Underside", "1 Side", "2 Sides"))
		 Case 6
			 Result = MakeValidValues(Array("Overhead", "Underside", "1 Side", "2 Sides")) '"Please Select"
		 Case Else
			 Result = MakeValidValues(Array(""))
	 End Select
 Else
	 Result = MakeValidValues(Array(""))
End If
      '   END FORMULA; PROP ID:9528; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_CCD_Position_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Selected_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9526; TYPE:VV
      If Me.Is_Scanned Then
	Result = MakeValidValues(Array("Laser Uni-Directional", "Laser Omni-Directional", "Camera Omni-Directional"))
Else
	Result = MakeValidValues(Array(""))
End If
      '   END FORMULA; PROP ID:9526; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Scanner_Selected_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Selected_Width_IN_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Selected_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9705; TYPE:VV
      Result = MakeValidValues(Array(22, 28, 34, 38))
      '   END FORMULA; PROP ID:9705; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Panel_Configuration.Formula_Sorter_Selected_Width_IN_ValidValues", ex.Message)
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

  