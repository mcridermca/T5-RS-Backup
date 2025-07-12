Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: HHS_Sway_Bracing
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

    Public Class [HHS_Sway_Bracing]
    
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

    Private this as HHS_Sway_Bracing = me

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
    
          Public Property [Amazon_Only]() As Boolean
      Get
      Return Properties("Amazon_Only").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Amazon_Only").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Component_Type]() As String
      Get
      Return Properties("Component_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Component_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DBID]() As Long
      Get
      Return Properties("DBID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("DBID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Display_1]() As String
      Get
      Return Properties("Display_1").Value
      End Get
      Set(ByVal Value As String)
      Properties("Display_1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drop_Length]() As Long
      Get
      Return Properties("Drop_Length").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Drop_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ExtCost]() As Double
      Get
      Return Properties("ExtCost").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ExtCost").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ExtCost_Formatted]() As Double
      Get
      Return Properties("ExtCost_Formatted").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ExtCost_Formatted").CalculatedValue = Value
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
    
          Public Property [Hanger_Type]() As String
      Get
      Return Properties("Hanger_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Hanger_Type").CalculatedValue = Value
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
    
          Public Property [Item_Description]() As String
      Get
      Return Properties("Item_Description").Value
      End Get
      Set(ByVal Value As String)
      Properties("Item_Description").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Kit_Part_Numbers]() As String
      Get
      Return Properties("Kit_Part_Numbers").Value
      End Get
      Set(ByVal Value As String)
      Properties("Kit_Part_Numbers").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Location]() As String
      Get
      Return Properties("Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Part_Number_ERP]() As String
      Get
      Return Properties("Part_Number_ERP").Value
      End Get
      Set(ByVal Value As String)
      Properties("Part_Number_ERP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Qty_Per_Hanger]() As Double
      Get
      Return Properties("Qty_Per_Hanger").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Qty_Per_Hanger").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Qty_Per_Hanger_Per72_FT]() As Long
      Get
      Return Properties("Qty_Per_Hanger_Per72_FT").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Qty_Per_Hanger_Per72_FT").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Qty_Total_Per_Hanger]() As Double
      Get
      Return Properties("Qty_Total_Per_Hanger").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Qty_Total_Per_Hanger").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Qty_Total_Per_Hanger_Formatted]() As Double
      Get
      Return Properties("Qty_Total_Per_Hanger_Formatted").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Qty_Total_Per_Hanger_Formatted").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Section]() As String
      Get
      Return Properties("Section").Value
      End Get
      Set(ByVal Value As String)
      Properties("Section").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Order_1]() As Long
      Get
      Return Properties("Sort_Order_1").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sort_Order_1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Order_1_Dbg_Grouping]() As Long
      Get
      Return Properties("Sort_Order_1_Dbg_Grouping").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sort_Order_1_Dbg_Grouping").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UnitCost]() As Double
      Get
      Return Properties("UnitCost").Value
      End Get
      Set(ByVal Value As Double)
      Properties("UnitCost").CalculatedValue = Value
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
    
      Public ReadOnly Property [DB_Data]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("DB_Data")
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
    InitPart("HHS_Sway_Bracing", <a><![CDATA[HHS_Sway_Bracing]]></a>.Value, 413, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/11/2025 12:24:27")
    AddProperty("9736", "Amazon_Only", <a><![CDATA[Amazon Only]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:29:34 PM")
    AddProperty("9737", "Component_Type", <a><![CDATA[Component Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:29:01 PM")
    AddProperty("9738", "DBID", <a><![CDATA[DBID]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 3:37:32 AM")
    AddProperty("9739", "Display_1", <a><![CDATA[Display 1]]></a>.Value, "Default Display Value for DropDowns / reports, etc", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:30:00 PM")
    AddProperty("9740", "Drop_Length", <a><![CDATA[Drop Length]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:30:21 PM")
    AddProperty("9886", "ExtCost", <a><![CDATA[ExtCost]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 2:19:20 AM")
    AddProperty("9896", "ExtCost_Formatted", <a><![CDATA[ExtCost_Formatted]]></a>.Value, "Extended Cost, Formatted for Display, Grids", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 12:24:27 PM")
    AddProperty("9879", "Hanger_Spacing", <a><![CDATA[Hanger Spacing]]></a>.Value, "Hanger Spacing in Feet", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 7:41:25 PM")
    AddProperty("9741", "Hanger_Type", <a><![CDATA[Hanger Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:30:29 PM")
    AddProperty("9742", "Is_Seismic", <a><![CDATA[Is Seismic]]></a>.Value, "Does this application require siesmic standards", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:31:24 AM")
    AddProperty("9743", "Item_Description", <a><![CDATA[Item Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:30:47 PM")
    AddProperty("9744", "Kit_Part_Numbers", <a><![CDATA[Kit Part Numbers]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:30:55 PM")
    AddProperty("9745", "Location", <a><![CDATA[Location]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:31:01 PM")
    AddProperty("9746", "Part_Number_ERP", <a><![CDATA[Part Number ERP]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:31:13 PM")
    AddProperty("9876", "Qty_Per_Hanger", <a><![CDATA[Qty_Per_Hanger]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 1:28:50 AM")
    AddProperty("9865", "Qty_Per_Hanger_Per72_FT", <a><![CDATA[Qty_Per_Hanger_Per72_FT]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 7:33:12 PM")
    AddProperty("9889", "Qty_Total_Per_Hanger", <a><![CDATA[Qty_Total_Per_Hanger]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 11:50:15 PM")
    AddProperty("9900", "Qty_Total_Per_Hanger_Formatted", <a><![CDATA[Qty_Total_Per_Hanger_Formatted]]></a>.Value, "Total Componenent Qty for this Calculation Group", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 12:19:46 PM")
    AddProperty("9749", "Section", <a><![CDATA[Section]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:31:24 AM")
    AddProperty("9750", "Sort_Order_1", <a><![CDATA[Sort Order 1]]></a>.Value, "Default Sort Order for Grids , Lookups, Forms", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:32:13 PM")
    AddProperty("9751", "Sort_Order_1_Dbg_Grouping", <a><![CDATA[Sort_Order_1_Dbg_Grouping]]></a>.Value, "Default Sort Order for Grids , Lookups, Forms", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:32:29 PM")
    AddProperty("9752", "UnitCost", <a><![CDATA[UnitCost]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:32:42 PM")
    AddProperty("9735", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:31:24 AM")
    
      oSubpart = AddSubpart(315,"DB_Data", <a><![CDATA[DB Data]]></a>.Value, "FD", "Database Specific Component Data", "General", 9999, "", "GLOBAL\H601424", "7/10/2025 2:34:56 AM")
      
        oSubpart.AddVPF (414, "HHS_Sway_Bracing_DB_Data", "HHS_Sway_Bracing_DB_Data")
      
      oConnection = AddConnection("MySource", <a><![CDATA[MySource]]></a>.Value, "Connection to the ACAD Block Element Driving this Item", "155", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/10/2025 6:26:08 PM")
      
        oConnection.AddVPF(335, "HHS_DWGXLSX_Import_Line")
      
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
          InitProperty("Amazon_Only", "9312", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:29:34 PM", "", "In Development",  0,16094)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Component_Type", "9313", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:29:01 PM", "", "In Development",  0,16093)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DBID", "9314", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 3:37:32 AM", "", "In Development",  0,15909)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Display_1", "9315", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:30:00 PM", "Default Display Value for DropDowns / reports, etc", "In Development",  0,16095)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drop_Length", "9316", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:30:21 PM", "", "In Development",  0,16096)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ExtCost", "9470", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 2:19:20 AM", "", "In Development",  0,16333)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ExtCost_Formatted", "9480", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 12:23:48 PM", "", "In Development",  0,16406)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hanger_Spacing", "9463", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 7:37:53 PM", "Hanger Spacing in Feet", "In Development",  0,16241)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hanger_Type", "9317", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:30:29 PM", "", "In Development",  0,16097)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Seismic", "9318", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:31:24 AM", "Does this application require siesmic standards", "In Development",  0,15801)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Item_Description", "9319", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:30:47 PM", "", "In Development",  0,16098)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Kit_Part_Numbers", "9320", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:30:55 PM", "", "In Development",  0,16099)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Location", "9321", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:31:01 PM", "", "In Development",  0,16100)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Part_Number_ERP", "9322", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:31:13 PM", "", "In Development",  0,16101)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty_Per_Hanger", "9460", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 1:28:33 AM", "", "In Development",  0,16315)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty_Per_Hanger_Per72_FT", "9449", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 7:33:12 PM", "", "In Development",  0,16214)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty_Total_Per_Hanger", "9473", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 11:50:15 PM", "", "In Development",  0,16304)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty_Total_Per_Hanger_Formatted", "9484", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/11/2025 12:19:46 PM", "Total Componenent Qty for this Calculation Group", "In Development",  0,16405)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Section", "9325", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:31:24 AM", "", "In Development",  0,15808)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order_1", "9326", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:32:13 PM", "Default Sort Order for Grids , Lookups, Forms", "In Development",  0,16103)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order_1_Dbg_Grouping", "9327", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:32:29 PM", "Default Sort Order for Grids , Lookups, Forms", "In Development",  0,16104)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UnitCost", "9328", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:32:42 PM", "", "In Development",  0,16105)
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
          
        InitSubpart("DB_Data", 242, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/10/2025 2:34:35 AM", "Database Specific Component Data", "In Development", "Y",0,681,653)
        
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
          
        InitConnection("MySource", "135", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/10/2025 6:23:17 PM", "", "In Development", "N",249)
        
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
        '   BEGIN FORMULA; CON ID:135; TYPE:PF
        Result = Nothing
For Each p As part In Me.Parent.My_HHS_Items.Parts
	If p.properties("Drop_Length").Value = Me.Drop_Length _
			 AndAlso  p.properties("Block_Type").Value.Trim().ToUpper() = Me.Hanger_Type.Trim().ToUpper() Then
			 Result = New RSCollection()
			 Result.Add(p)
			 Exit For
	End If
Next p
        '   END FORMULA; CON ID:135; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_MySource_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Amazon_Only() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Amazon_Only").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9312; TYPE:PF
      Result = False
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9312; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Amazon_Only", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Component_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Component_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9313; TYPE:PF
      Result = ""
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9313; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Component_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DBID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DBID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9314; TYPE:PF
      Result = Me.Parent.ValidValues("Sway_Bracing_Keys")(Me.SubpartID-1)
      '   END FORMULA; PROP ID:9314; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_DBID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Display_1() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Display_1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9315; TYPE:PF
      Result = ""
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9315; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Display_1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drop_Length() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drop_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9316; TYPE:PF
      Result = 0
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9316; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Drop_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ExtCost() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ExtCost").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9470; TYPE:PF
      Result = Me.Qty_Total_Per_Hanger * Me.UnitCost
      '   END FORMULA; PROP ID:9470; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_ExtCost", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ExtCost_Formatted() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ExtCost_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9480; TYPE:PF
      Result = rounding(.01, Me.ExtCost)
      '   END FORMULA; PROP ID:9480; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_ExtCost_Formatted", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9463; TYPE:PF
      result = Me.Parent.Hanger_Spacing
      '   END FORMULA; PROP ID:9463; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Hanger_Spacing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Hanger_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hanger_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9317; TYPE:PF
      Result = ""
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9317; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Hanger_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9318; TYPE:PF
      result = me.Parent.Is_Seismic
      '   END FORMULA; PROP ID:9318; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Is_Seismic", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Item_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Item_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9319; TYPE:PF
      Result = ""
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9319; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Item_Description", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Kit_Part_Numbers() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Kit_Part_Numbers").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9320; TYPE:PF
      Result = ""
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9320; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Kit_Part_Numbers", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9321; TYPE:PF
      Result = ""
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9321; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Part_Number_ERP() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Part_Number_ERP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9322; TYPE:PF
      Result = ""
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9322; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Part_Number_ERP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty_Per_Hanger() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty_Per_Hanger").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9460; TYPE:PF
      Result = 0.0

Result = Me.Qty_Per_Hanger_Per72_ft ' * Me.Hanger_Spacing
      '   END FORMULA; PROP ID:9460; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Qty_Per_Hanger", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty_Per_Hanger_Per72_FT() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty_Per_Hanger_Per72_FT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9449; TYPE:PF
      Result = 0
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9449; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Qty_Per_Hanger_Per72_FT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty_Total_Per_Hanger() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty_Total_Per_Hanger").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9473; TYPE:PF
      Result = 0.0
Result = Me.Qty_Per_Hanger  * Me.MySource(1).Qty  / 72 * Me.Hanger_Spacing
      '   END FORMULA; PROP ID:9473; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Qty_Total_Per_Hanger", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty_Total_Per_Hanger_Formatted() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty_Total_Per_Hanger_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9484; TYPE:PF
      Result = 0
Result = Rounding(.01 , Me.Qty_Total_Per_Hanger)
      '   END FORMULA; PROP ID:9484; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Qty_Total_Per_Hanger_Formatted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Section() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Section").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9325; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
      '   END FORMULA; PROP ID:9325; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Section", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Order_1() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Order_1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9326; TYPE:PF
      Result = 0
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9326; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Sort_Order_1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Order_1_Dbg_Grouping() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Order_1_Dbg_Grouping").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9327; TYPE:PF
      Result = 0
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9327; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_Sort_Order_1_Dbg_Grouping", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UnitCost() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UnitCost").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9328; TYPE:PF
      Result = 0.0
If Me.DB_Data.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DB_Data(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:9328; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_UnitCost", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Amazon_Only_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DBID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Display_1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drop_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ExtCost_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ExtCost_Formatted_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Hanger_Type_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Item_Description_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Kit_Part_Numbers_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Part_Number_ERP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Per_Hanger_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Per_Hanger_Per72_FT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Total_Per_Hanger_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Total_Per_Hanger_Formatted_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Section_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_1_Dbg_Grouping_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UnitCost_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Amazon_Only_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DBID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Display_1_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drop_Length_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ExtCost_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ExtCost_Formatted_USERCHANGE() as Boolean
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
      Public Function Formula_Hanger_Type_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_Item_Description_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Kit_Part_Numbers_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Location_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Part_Number_ERP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Per_Hanger_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Per_Hanger_Per72_FT_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Total_Per_Hanger_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_Total_Per_Hanger_Formatted_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Section_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_1_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_1_Dbg_Grouping_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UnitCost_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DB_Data_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:242; TYPE:PN
      
      '   END FORMULA; SUB ID:242; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_DB_Data_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DB_Data_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("DB_Data").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:242; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:242; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_DB_Data_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DB_Data_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("DB_Data").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:242; TYPE:OP
      Result = "HHS_Sway_Bracing_DB_Data"
      '   END FORMULA; SUB ID:242; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing.Formula_DB_Data_OPTIMALPARTFAMILY", ex.Message)
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

  