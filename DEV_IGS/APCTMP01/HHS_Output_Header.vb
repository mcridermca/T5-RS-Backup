Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: HHS_Output_Header
'$ GenerateDate: 07/12/2025 14:40:53

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

    Public Class [HHS_Output_Header]
    
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

    Private this as HHS_Output_Header = me

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
    
          Public Property [BOM_PartNo_Unique_Keys]() As Long
      Get
      Return Properties("BOM_PartNo_Unique_Keys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("BOM_PartNo_Unique_Keys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Per_Hanger]() As Double
      Get
      Return Properties("Cost_Per_Hanger").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Per_Hanger").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Display_Zero_Qty_Items]() As Boolean
      Get
      Return Properties("Display_Zero_Qty_Items").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Display_Zero_Qty_Items").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Hanger_Spacing]() As Long
      Get
      Return Properties("Hanger_Spacing").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Hanger_Spacing").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Imported_Data_Raw]() As String
      Get
      Return Properties("Imported_Data_Raw").Value
      End Get
      Set(ByVal Value As String)
      Properties("Imported_Data_Raw").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Is_Seismic]() As Boolean
      Get
      Return Properties("Is_Seismic").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_Seismic").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Output_Lines_DBKeys]() As String
      Get
      Return Properties("Output_Lines_DBKeys").Value
      End Get
      Set(ByVal Value As String)
      Properties("Output_Lines_DBKeys").CalculatedValue = Value
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
    
          Public Property [Seismic_Requirement]() As String
      Get
      Return Properties("Seismic_Requirement").Value
      End Get
      Set(ByVal Value As String)
      Properties("Seismic_Requirement").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Total_Cost]() As Double
      Get
      Return Properties("Total_Cost").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Total_Cost").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Total_Hanger_Qty]() As Long
      Get
      Return Properties("Total_Hanger_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Total_Hanger_Qty").CalculatedValue = Value
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
    
      Public ReadOnly Property [Bom_Items_Flat]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Bom_Items_Flat")
      End Get
      End Property
    
      Public ReadOnly Property [Grouping_Matrix_Controller]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Grouping_Matrix_Controller")
      End Get
      End Property
    
      Public ReadOnly Property [Output_Lines]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Output_Lines")
      End Get
      End Property
    
      Public ReadOnly Property [Bom_Items_Flat_Sorted]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Bom_Items_Flat_Sorted")
      End Get
      End Property
    
      Public ReadOnly Property [Calculated_Items]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Calculated_Items")
      End Get
      End Property
    
      Public ReadOnly Property [HHS_Import_App]() As Rulestream.Kernel.Connection
      Get
      Return Connections("HHS_Import_App")
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
    InitPart("HHS_Output_Header", <a><![CDATA[HHS Output Header]]></a>.Value, 336, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/11/2025 12:27:29")
    AddProperty("2480", "BOM_PartNo_Unique_Keys", <a><![CDATA[BOM PartNo Unique Keys]]></a>.Value, "Count / VV List of Unique Part Numbers in Solution", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 5:50:15 PM")
    AddProperty("9901", "Cost_Per_Hanger", <a><![CDATA[Cost Per Hanger]]></a>.Value, "Total Cost Rollup", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 12:27:29 PM")
    AddProperty("2465", "Display_Zero_Qty_Items", <a><![CDATA[Display Zero Qty Items]]></a>.Value, "Include Non-Zero Items in Connections / Grids", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/29/2025 5:08:07 PM")
    AddProperty("2350", "Hanger_Spacing", <a><![CDATA[Hanger Spacing]]></a>.Value, "Hanger Spacing in Feet", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/3/2025 4:37:25 PM")
    AddProperty("9505", "Imported_Data_Raw", <a><![CDATA[Imported_Data_Raw]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 5:26:37 PM")
    AddProperty("2320", "Is_Seismic", <a><![CDATA[Is Seismic]]></a>.Value, "Does this application require siesmic standards", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
    AddProperty("2219", "Output_Lines_DBKeys", <a><![CDATA[Output Lines DBKeys]]></a>.Value, "DataBase Extract of Key Values for Lines", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 5:44:04 PM")
    AddProperty("8111", "PRD_Name", <a><![CDATA[PRD_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 10:41:57 AM")
    AddProperty("8112", "Project_Code", <a><![CDATA[Project_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 10:42:04 AM")
    AddProperty("8113", "Project_Identifier", <a><![CDATA[Project_Identifier]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:21:48 AM")
    AddProperty("8114", "Project_Name", <a><![CDATA[Project_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:21:54 AM")
    AddProperty("8115", "Proposal_City_State", <a><![CDATA[Proposal City State]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:22:01 AM")
    AddProperty("8116", "Proposal_Customer_Name", <a><![CDATA[Proposal Customer Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:22:07 AM")
    AddProperty("8117", "Proposal_Customer_Number", <a><![CDATA[Proposal Customer Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:22:14 AM")
    AddProperty("8118", "Proposal_Description", <a><![CDATA[Proposal Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:22:20 AM")
    AddProperty("8119", "Proposal_ID", <a><![CDATA[Proposal ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:22:25 AM")
    AddProperty("8120", "Proposal_Name", <a><![CDATA[Proposal Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:22:32 AM")
    AddProperty("2321", "Seismic_Requirement", <a><![CDATA[Seismic Requirement]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
    AddProperty("9807", "Total_Cost", <a><![CDATA[Total_Cost]]></a>.Value, "Total Cost Rollup", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 5:42:17 PM")
    AddProperty("9515", "Total_Hanger_Qty", <a><![CDATA[Total Hanger Qty]]></a>.Value, "Total Hanger Quantity", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 7:12:40 PM")
    AddProperty("2217", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/22/2025 12:12:08 AM")
    
      AddValidValue("BOM_PartNo_Unique_Keys")
    
      AddValidValue("Output_Lines_DBKeys")
    
      AddValidValue("Seismic_Requirement")
    
      oSubpart = AddSubpart(233,"Bom_Items_Flat", <a><![CDATA[Bom Items Flat]]></a>.Value, "FD", "SubPart Collection of Unique Bom Items/w Total Qty Each", "General", 9999, "", "GLOBAL\H601424", "4/30/2025 8:42:58 PM")
      
        oSubpart.AddVPF (358, "HHS_BOM_Item", "HHS BOM Item")
      
        oSubpart.AddVPF (357, "sm_Generic_BOM_Item", "sm Generic BOM Item")
      
      oSubpart = AddSubpart(203,"Grouping_Matrix_Controller", <a><![CDATA[Grouping Matrix Controller]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "4/23/2025 4:55:24 PM")
      
        oSubpart.AddVPF (339, "HHS_Grouping_Matrix_Controller", "HHS Grouping Matrix Controller")
      
      oSubpart = AddSubpart(199,"Output_Lines", <a><![CDATA[Output Lines]]></a>.Value, "FD", "HHS Output Lines Collection", "General", 9999, "", "GLOBAL\H601424", "4/22/2025 12:45:36 AM")
      
        oSubpart.AddVPF (337, "HHS_Output_Line", "HHS Output Line")
      
      oConnection = AddConnection("Bom_Items_Flat_Sorted", <a><![CDATA[Bom Items Flat Sorted]]></a>.Value, "", "106", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "7/10/2025 12:06:30 AM")
      
        oConnection.AddVPF(357, "sm_Generic_BOM_Item")
      
        oConnection.AddVPF(358, "HHS_BOM_Item")
      
      oConnection = AddConnection("Calculated_Items", <a><![CDATA[Calculated Items]]></a>.Value, "Connection to All Component , Sway Brace, and Hanger Items", "102", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "7/10/2025 11:14:56 PM")
      
        oConnection.AddVPF(353, "HHS_Component_Item")
      
      oConnection = AddConnection("HHS_Import_App", <a><![CDATA[HHS Import App]]></a>.Value, "", "86", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
      
        oConnection.AddVPF(334, "HHS_DWGXLSX_Importer")
      
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
          InitProperty("BOM_PartNo_Unique_Keys", "2122", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 5:50:15 PM", "Count / VV List of Unique Part Numbers in Solution", "In Development",  0,3382)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Per_Hanger", "9485", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 12:27:29 PM", "", "In Development",  0,16410)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Display_Zero_Qty_Items", "2109", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/29/2025 5:08:07 PM", "Include Non-Zero Items in Connections / Grids", "In Development",  0,3278)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hanger_Spacing", "1998", "1", "10", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/3/2025 4:37:25 PM", "Hanger Spacing in Feet", "In Development",  0,2795)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Imported_Data_Raw", "9085", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 5:26:37 PM", "", "In Development",  0,15177)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Seismic", "1968", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "Does this application require siesmic standards", "In Development",  0,2731)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Output_Lines_DBKeys", "1882", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "4/22/2025 12:58:52 AM", "DataBase Extract of Key Values for Lines", "In Development",  0,2515)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Name", "9373", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 10:41:57 AM", "", "In Development",  0,15990)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "9374", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 10:42:04 AM", "", "In Development",  0,15991)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Identifier", "9375", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:21:48 AM", "", "In Development",  0,15999)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "9379", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:21:54 AM", "", "In Development",  0,15998)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_City_State", "9370", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:22:01 AM", "", "In Development",  0,15987)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Customer_Name", "9371", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:22:07 AM", "", "In Development",  0,15988)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Customer_Number", "9372", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:22:14 AM", "", "In Development",  0,15989)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Description", "9376", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:22:20 AM", "", "In Development",  0,15993)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_ID", "9377", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:22:25 AM", "", "In Development",  0,15994)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Name", "9378", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:22:32 AM", "", "In Development",  0,15995)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Seismic_Requirement", "1969", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "", "In Development",  0,2734)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Total_Cost", "9391", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 5:42:17 PM", "", "In Development",  0,16111)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Total_Hanger_Qty", "9095", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 7:12:40 PM", "Hanger Spacing in Feet", "In Development",  0,15195)
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
          
        InitValidValue("BOM_PartNo_Unique_Keys_ValidValues", "2122", "-1", 16114)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Output_Lines_DBKeys_ValidValues", "1882", "-1", 2538)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Seismic_Requirement_ValidValues", "1969", "-1", 2733)
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
            If Incontext("-1", ctx) Then
          
        InitSubpart("Bom_Items_Flat", 171, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/30/2025 8:42:58 PM", "SubPart Collection of Unique Bom Items/w Total Qty Each", "In Development", "Y",0,483,482)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Grouping_Matrix_Controller", 141, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/23/2025 4:55:24 PM", "", "In Development", "Y",0,327,328)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Output_Lines", 137, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "4/22/2025 12:45:36 AM", "HHS Output Lines Collection", "In Development", "Y",0,317,326)
        
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
          
        InitConnection("Bom_Items_Flat_Sorted", "86", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/10/2025 12:06:30 AM", "", "In Development", "Y",224)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Calculated_Items", "82", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/10/2025 11:14:56 PM", "Connection to All Component and Hanger Items", "In Development", "N",252)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("HHS_Import_App", "66", "N","N", "N", 0, "-1", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "", "In Development", "Y",97)
        
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
      Public Function Formula_Bom_Items_Flat_Sorted_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:86; TYPE:PF
        If Me.Display_Zero_Qty_Items Then
	Result = SortObjectsByProperty(Me.Bom_Items_Flat.Parts,"Sort_Order_1", False)
Else
	Result = New collection()
	For Each p As part In Me.Bom_Items_Flat.Parts
		If p.Properties("Qty").Value <> 0 Then 
			Result.add(p)
		End If
	Next p	
	Result = SortObjectsByProperty(Result,"Sort_Order_1", False)
End If
        '   END FORMULA; CON ID:86; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Bom_Items_Flat_Sorted_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Calculated_Items_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:82; TYPE:PF
        Result = New RSCollection()
'Get Component Items

For Each p1 As part In Me.Grouping_Matrix_Controller(1).Valid_Calculators.Parts
	For Each p2 As part In P1.Subparts("Component_Items").Parts
		Dim Qty As Integer = p2.properties("Qty_Total_Per_Hanger").Value		
		If Qty <> 0 Then
			Result.add(p2)
		Else If Qty = 0 And Me.Display_Zero_Qty_Items Then
			Result.add(p2)
		End If
	Next p2
Next p1
'Add Hanger Items

For Each p1 As part In Me.Grouping_Matrix_Controller(1).Valid_Calculators.Parts
	For Each p2 As part In P1.Subparts("Hanger_Items").Parts
		Dim Qty As Integer = p2.properties("Qty_Total_Per_Hanger").Value
		If Qty <> 0 Then
			Result.add(p2)
		Else If Qty = 0 And Me.Display_Zero_Qty_Items Then
			Result.add(p2)
		End If
	Next p2
Next p1	

For Each p1 As part In Me.Grouping_Matrix_Controller(1).Valid_Calculators.Parts
	For Each p2 As part In P1.Subparts("Sway_Bracing_Items").Parts
		Dim Qty As Integer = p2.properties("Qty_Total_Per_Hanger").Value
		If Qty <> 0 Then
			Result.add(p2)
		Else If Qty = 0 And Me.Display_Zero_Qty_Items Then
			Result.add(p2)
		End If
	Next p2
Next p1	

Result = SortObjectsByProperty(Result,"Sort_Order_1", False)
        '   END FORMULA; CON ID:82; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Calculated_Items_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Import_App_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:66; TYPE:PF
        Result = Me.Parent.HHS_Importer(1)
        '   END FORMULA; CON ID:66; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_HHS_Import_App_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BOM_PartNo_Unique_Keys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BOM_PartNo_Unique_Keys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2122; TYPE:PF
      result = Me.ValidValues("BOM_PartNo_Unique_Keys").Count
      '   END FORMULA; PROP ID:2122; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_BOM_PartNo_Unique_Keys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Per_Hanger() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Per_Hanger").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9485; TYPE:PF
      Result = rounding(.01,Total_Cost / Total_Hanger_Qty)
      '   END FORMULA; PROP ID:9485; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Cost_Per_Hanger", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Display_Zero_Qty_Items() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Display_Zero_Qty_Items").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2109; TYPE:PF
      result = false
      '   END FORMULA; PROP ID:2109; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Display_Zero_Qty_Items", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Hanger_Spacing() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hanger_Spacing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1998; TYPE:PF
      result = Me.HHS_Import_App(1).Hanger_Spacing
      '   END FORMULA; PROP ID:1998; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Hanger_Spacing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Imported_Data_Raw() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Imported_Data_Raw").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9085; TYPE:PF
      Result = Me.HHS_Import_App(1).HHS_Input_Text_Tab_Formatted
      '   END FORMULA; PROP ID:9085; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Imported_Data_Raw", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Is_Seismic() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_Seismic").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1968; TYPE:PF
      result = Not (Me.Seismic_Requirement="No")
      '   END FORMULA; PROP ID:1968; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Is_Seismic", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Output_Lines_DBKeys() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Output_Lines_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1882; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1882; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Output_Lines_DBKeys", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9373; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9373; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_PRD_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9374; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9374; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Project_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9375; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:9375; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Project_Identifier", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9379; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9379; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Project_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9370; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9370; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Proposal_City_State", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9371; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9371; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Proposal_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9372; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9372; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Proposal_Customer_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9376; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9376; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Proposal_Description", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9377; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9377; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Proposal_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9378; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9378; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Proposal_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Seismic_Requirement() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Seismic_Requirement").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1969; TYPE:PF
      Result = Me.HHS_Import_App(1).Seismic_Requirement
      '   END FORMULA; PROP ID:1969; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Seismic_Requirement", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Total_Cost() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Total_Cost").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9391; TYPE:PF
      Result = 0.0
For Each p As part In bom_Items_flat_sorted.Parts
	If p.Properties.ContainsKey("ExtdCost") Then
		Result = Result + p.Properties("ExtdCost").Value
	End If
Next p
      '   END FORMULA; PROP ID:9391; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Total_Cost", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Total_Hanger_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Total_Hanger_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9095; TYPE:PF
      Result = Me.HHS_Import_App(1).Total_Hanger_Qty
      '   END FORMULA; PROP ID:9095; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Total_Hanger_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BOM_PartNo_Unique_Keys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Per_Hanger_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Display_Zero_Qty_Items_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Spacing_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Imported_Data_Raw_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Seismic_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Output_Lines_DBKeys_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Seismic_Requirement_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Total_Cost_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Total_Hanger_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BOM_PartNo_Unique_Keys_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Per_Hanger_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Display_Zero_Qty_Items_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Spacing_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Imported_Data_Raw_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Seismic_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Output_Lines_DBKeys_USERCHANGE() as Boolean
      Return True
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
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_City_State_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Number_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Description_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Seismic_Requirement_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Total_Cost_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Total_Hanger_Qty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BOM_PartNo_Unique_Keys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BOM_PartNo_Unique_Keys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2122; TYPE:VV
      Result = New validvalues()

For Each p1 As part In Me.Grouping_Matrix_Controller(1).Valid_Calculators.Parts
	For Each pC As part In p1.SubParts("Component_Items").Parts
		Dim part_number As String  = pC.Properties("Part_Number_ERP").DisplayValue
		If Not Result.Contains(part_number) AndAlso part_number.trim() <> "" Then
			result.add(part_number)
		End If
	Next pC	
	For Each pH As part In p1.SubParts("Hanger_Items").Parts
		Dim part_number As String = pH.Properties("Part_Number_ERP").DisplayValue
		If Not Result.Contains(part_number) AndAlso part_number.trim() <> "" Then
			result.add(part_number)
		End If
	Next pH	
	For Each pS As part In p1.SubParts("Sway_Bracing_Items").Parts
		Dim part_number As String = pS.Properties("Part_Number_ERP").DisplayValue
		If Not Result.Contains(part_number) AndAlso part_number.trim() <> "" Then
			Result.add(part_number)
		End If
	Next pS	
Next p1
      '   END FORMULA; PROP ID:2122; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_BOM_PartNo_Unique_Keys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Output_Lines_DBKeys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Output_Lines_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1882; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_HHS_Parts_Master_List]", "[DBID]", "[DBID]", "WHERE [DBID] > " & FormatCriteria(0) & " ORDER BY [DBID]")
      '   END FORMULA; PROP ID:1882; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Output_Lines_DBKeys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Seismic_Requirement_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Seismic_Requirement").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1969; TYPE:VV
      result = MakeValidValues(Array("(0.0-0.5)","(0.5-1.0)","(1.0-1.9)","No"))
      '   END FORMULA; PROP ID:1969; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Seismic_Requirement_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Bom_Items_Flat_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:171; TYPE:PN
      
      '   END FORMULA; SUB ID:171; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Bom_Items_Flat_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Bom_Items_Flat_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Bom_Items_Flat").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:171; TYPE:QF
      result = Me.BOM_PartNo_Unique_Keys
      '   END FORMULA; SUB ID:171; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Bom_Items_Flat_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Bom_Items_Flat_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Bom_Items_Flat").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:171; TYPE:OP
      Result = "sm_Generic_BOM_Item"
      '   END FORMULA; SUB ID:171; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Bom_Items_Flat_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Grouping_Matrix_Controller_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:141; TYPE:PN
      
      '   END FORMULA; SUB ID:141; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Grouping_Matrix_Controller_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Grouping_Matrix_Controller_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Grouping_Matrix_Controller").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:141; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:141; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Grouping_Matrix_Controller_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Grouping_Matrix_Controller_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Grouping_Matrix_Controller").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:141; TYPE:OP
      Result = "HHS_Grouping_Matrix_Controller"
      '   END FORMULA; SUB ID:141; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Grouping_Matrix_Controller_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      '   BEGIN FORMULA; SUB ID:137; TYPE:PN
      
      '   END FORMULA; SUB ID:137; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Output_Lines_PARTNAMES", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:137; TYPE:QF
      Result = Me.ValidValues("Output_Lines_DBKeys").Count
      '   END FORMULA; SUB ID:137; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Output_Lines_QUANTITY", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:137; TYPE:OP
      Result = "HHS_Output_Line"
      '   END FORMULA; SUB ID:137; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Output_Header.Formula_Output_Lines_OPTIMALPARTFAMILY", ex.Message)
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

  