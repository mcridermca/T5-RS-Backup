Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: HHS_Sway_Bracing_DB_Data
'$ GenerateDate: 07/12/2025 13:20:28

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

    Public Class [HHS_Sway_Bracing_DB_Data]
    
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

    Private this as HHS_Sway_Bracing_DB_Data = me

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
    
          Public Property [Location]() As String
      Get
      Return Properties("Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Location").CalculatedValue = Value
      End Set
      End Property
    
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
    
          Public Property [Part_Number_ERP]() As String
      Get
      Return Properties("Part_Number_ERP").Value
      End Get
      Set(ByVal Value As String)
      Properties("Part_Number_ERP").CalculatedValue = Value
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
    
          Public Property [Section]() As String
      Get
      Return Properties("Section").Value
      End Get
      Set(ByVal Value As String)
      Properties("Section").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sequence_ID]() As Long
      Get
      Return Properties("Sequence_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sequence_ID").CalculatedValue = Value
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
    InitPart("HHS_Sway_Bracing_DB_Data", <a><![CDATA[HHS_Sway_Bracing_DB_Data]]></a>.Value, 414, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/10/2025 19:36:14")
    AddProperty("9762", "Location", <a><![CDATA[Location]]></a>.Value, "", "String","","Database Output","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9754", "Amazon_Only", <a><![CDATA[Amazon Only]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9755", "Component_Type", <a><![CDATA[Component Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9756", "DBID", <a><![CDATA[DBID]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:16:35 PM")
    AddProperty("9757", "Display_1", <a><![CDATA[Display 1]]></a>.Value, "Default Display Value for DropDowns / reports, etc", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9804", "Drop_Length", <a><![CDATA[Drop Length]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:22:37 PM")
    AddProperty("9758", "Hanger_Type", <a><![CDATA[Hanger Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:19:17 PM")
    AddProperty("9759", "Is_Seismic", <a><![CDATA[Is Seismic]]></a>.Value, "Does this application require siesmic standards", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 4:21:48 PM")
    AddProperty("9760", "Item_Description", <a><![CDATA[Item Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9761", "Kit_Part_Numbers", <a><![CDATA[Kit Part Numbers]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9763", "Part_Number_ERP", <a><![CDATA[Part Number ERP]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9869", "Qty_Per_Hanger_Per72_FT", <a><![CDATA[Qty_Per_Hanger_Per72_FT]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 7:34:34 PM")
    AddProperty("9765", "Section", <a><![CDATA[Section]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 3:21:22 AM")
    AddProperty("9766", "Sequence_ID", <a><![CDATA[Sequence ID]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9767", "Sort_Order_1", <a><![CDATA[Sort Order 1]]></a>.Value, "Default Sort Order for Grids , Lookups, Forms", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9768", "Sort_Order_1_Dbg_Grouping", <a><![CDATA[Sort_Order_1_Dbg_Grouping]]></a>.Value, "Default Sort Order for Grids , Lookups, Forms", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9769", "UnitCost", <a><![CDATA[UnitCost]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    AddProperty("9753", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/10/2025 2:32:04 AM")
    
      AddDBConstraint(10, "db_HHS_Hanger_Item_DBSpec", <a><![CDATA[db_HHS_Hanger_Item_DBSpec]]></a>.Value,"Database Lookup", 9999)
    
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
          InitProperty("Location", "9337", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "", "In Development",  0,15820)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Amazon_Only", "9329", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "", "In Development",  0,15812)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Component_Type", "9330", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "", "In Development",  0,15813)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DBID", "9331", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:16:35 PM", "", "In Development",  0,16084)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Display_1", "9332", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "Default Display Value for DropDowns / reports, etc", "In Development",  0,15815)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drop_Length", "9389", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:22:37 PM", "", "In Development",  0,16091)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hanger_Type", "9333", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:19:16 PM", "", "In Development",  0,16087)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Seismic", "9334", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 4:21:48 PM", "Does this application require siesmic standards", "In Development",  0,16090)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Item_Description", "9335", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "", "In Development",  0,15818)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Kit_Part_Numbers", "9336", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "", "In Development",  0,15819)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Part_Number_ERP", "9338", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "", "In Development",  0,15821)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty_Per_Hanger_Per72_FT", "9453", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 7:34:34 PM", "", "In Development",  0,16222)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Section", "9340", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 3:21:22 AM", "", "In Development",  0,15894)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sequence_ID", "9341", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:04 AM", "", "In Development",  0,15824)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order_1", "9342", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:05 AM", "Default Sort Order for Grids , Lookups, Forms", "In Development",  0,15825)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order_1_Dbg_Grouping", "9343", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:05 AM", "Default Sort Order for Grids , Lookups, Forms", "In Development",  0,15826)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UnitCost", "9344", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:32:05 AM", "", "In Development",  0,15827)
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
          
        InitDBConstraint("db_HHS_Hanger_Item_DBSpec", 10,"", "Y","", "", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Amazon_Only",10, "Amazon_Only", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Component_Type",10, "Component_Type", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "DBID",10, "DBID", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Display_1",10, "Display1", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Drop_Length",10, "Drop_Length", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Hanger_Type",10, "Hanger_Type", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Item_Description",10, "Description", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Kit_Part_Numbers",10, "Kit_Part_Numbers", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Location",10, "Location", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Part_Number_ERP",10, "Part_Number_ERP", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Qty_Per_Hanger_Per72_FT",10, "Qty_Per_Hanger", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Section",10, "Section", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Sequence_ID",10, "Sequence", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Sort_Order_1",10, "Sort_Order_1", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "Sort_Order_1_Dbg_Grouping",10, "Sort_Order_1_Dbg_Grouping", "vw_HHS_Component_Items")
        
          InitDBproperty("db_HHS_Hanger_Item_DBSpec", "UnitCost",10, "UnitCost", "vw_HHS_Component_Items")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
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
      '   BEGIN FORMULA; PROP ID:9337; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9337; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      '   BEGIN FORMULA; PROP ID:9329; TYPE:PF
      result = false
      '   END FORMULA; PROP ID:9329; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Amazon_Only", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9330; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9330; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Component_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9331; TYPE:PF
      Result = Me.Parent.DBID
      '   END FORMULA; PROP ID:9331; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_DBID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9332; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9332; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Display_1", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9389; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:9389; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Drop_Length", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9333; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:9333; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Hanger_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9334; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:9334; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Is_Seismic", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9335; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9335; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Item_Description", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9336; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9336; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Kit_Part_Numbers", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9338; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9338; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Part_Number_ERP", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9453; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:9453; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Qty_Per_Hanger_Per72_FT", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9340; TYPE:PF
      If Me.Is_Seismic Then Result = "XXX" Else Result = "SWB"
If Me.Hanger_Type = "E" Then Result = "XXX" ' E Is always H3 Type
      '   END FORMULA; PROP ID:9340; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Section", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sequence_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sequence_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9341; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:9341; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Sequence_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9342; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:9342; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Sort_Order_1", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9343; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:9343; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_Sort_Order_1_Dbg_Grouping", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9344; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9344; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.Formula_UnitCost", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_Part_Number_ERP_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Section_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sequence_ID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Location_USERCHANGE() as Boolean
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
      Public Function Formula_Part_Number_ERP_USERCHANGE() as Boolean
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
      Public Function Formula_Section_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sequence_ID_USERCHANGE() as Boolean
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
      
        Case 10
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Amazon_Only" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Component_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "DBID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Display1" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Drop_Length" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Hanger_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Kit_Part_Numbers" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Location" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Number_ERP" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Qty_Per_Hanger" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Section" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sequence" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sort_Order_1" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sort_Order_1_Dbg_Grouping" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "UnitCost" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.DBID
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[DBID]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("vw_HHS_Component_Items"), strWhereClause, leftDelimiter & "Sort_Order_1" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " HHS_Sway_Bracing_DB_Data.GetRecordset", strError)
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

  