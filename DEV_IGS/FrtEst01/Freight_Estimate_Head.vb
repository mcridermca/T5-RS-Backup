Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: FrtEst01
'$ PartFamily: Freight_Estimate_Head
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
    Imports FrtEst01.swMateType_e
    Imports FrtEst01.swMateAlign_e
    Imports FrtEst01.severity

    Public Class [Freight_Estimate_Head]
    
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

    Private this as Freight_Estimate_Head = me

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
    
          Public Property [Cost_Adder_Trailer_Each]() As Double
      Get
      Return Properties("Cost_Adder_Trailer_Each").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Adder_Trailer_Each").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Adder_Wood_Product]() As Double
      Get
      Return Properties("Cost_Adder_Wood_Product").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Adder_Wood_Product").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Adder_Wood_Product_Pcnt]() As Double
      Get
      Return Properties("Cost_Adder_Wood_Product_Pcnt").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Adder_Wood_Product_Pcnt").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Fuel_Adder]() As Double
      Get
      Return Properties("Cost_Fuel_Adder").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Fuel_Adder").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Fuel_Adder_Pcnt]() As Double
      Get
      Return Properties("Cost_Fuel_Adder_Pcnt").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Fuel_Adder_Pcnt").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Subtotal_Mfg_Product]() As Double
      Get
      Return Properties("Cost_Subtotal_Mfg_Product").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Subtotal_Mfg_Product").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Total_All_Products]() As Double
      Get
      Return Properties("Cost_Total_All_Products").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Total_All_Products").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Info_1]() As String
      Get
      Return Properties("Customer_Info_1").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Info_1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Info_2]() As String
      Get
      Return Properties("Customer_Info_2").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Info_2").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Info_3]() As String
      Get
      Return Properties("Customer_Info_3").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Info_3").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Freight_Data_Source_Type]() As String
      Get
      Return Properties("Freight_Data_Source_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Freight_Data_Source_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Opportunity_Data_Source_Type]() As String
      Get
      Return Properties("Opportunity_Data_Source_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Opportunity_Data_Source_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_TOTAL_DEBUG]() As String
      Get
      Return Properties("PRD_TOTAL_DEBUG").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_TOTAL_DEBUG").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Total_Text]() As String
      Get
      Return Properties("PRD_Total_Text").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Total_Text").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ship_From_Locations_In_Use]() As Long
      Get
      Return Properties("Ship_From_Locations_In_Use").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Ship_From_Locations_In_Use").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sum_Products_Cost_Escalated]() As Double
      Get
      Return Properties("Sum_Products_Cost_Escalated").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sum_Products_Cost_Escalated").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sum_Products_Cost_Standard]() As Double
      Get
      Return Properties("Sum_Products_Cost_Standard").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sum_Products_Cost_Standard").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sum_Products_Ft_Total]() As Double
      Get
      Return Properties("Sum_Products_Ft_Total").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sum_Products_Ft_Total").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sum_Products_Weight_Total]() As Double
      Get
      Return Properties("Sum_Products_Weight_Total").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sum_Products_Weight_Total").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sum_Weight_Avg_Per_Ft]() As Double
      Get
      Return Properties("Sum_Weight_Avg_Per_Ft").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sum_Weight_Avg_Per_Ft").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Max_Load_Lbs]() As Double
      Get
      Return Properties("Trailer_Max_Load_Lbs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Max_Load_Lbs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Qty_from_STL_Est]() As Double
      Get
      Return Properties("Trailer_Qty_from_STL_Est").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Qty_from_STL_Est").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Qty_from_TTCB_Est]() As Double
      Get
      Return Properties("Trailer_Qty_from_TTCB_Est").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Qty_from_TTCB_Est").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Qty_from_USS_Est]() As Double
      Get
      Return Properties("Trailer_Qty_from_USS_Est").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Qty_from_USS_Est").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Qty_Misc_Equip]() As Double
      Get
      Return Properties("Trailer_Qty_Misc_Equip").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Qty_Misc_Equip").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Qty_Misc_Equip_Pcnt]() As Double
      Get
      Return Properties("Trailer_Qty_Misc_Equip_Pcnt").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Qty_Misc_Equip_Pcnt").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Qty_No_Misc]() As Double
      Get
      Return Properties("Trailer_Qty_No_Misc").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Qty_No_Misc").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Trailer_Qty_Total_Est]() As Double
      Get
      Return Properties("Trailer_Qty_Total_Est").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Trailer_Qty_Total_Est").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Use_PRD_Total_Text]() As Boolean
      Get
      Return Properties("Use_PRD_Total_Text").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Use_PRD_Total_Text").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_Total_Conveyors_Only]() As Double
      Get
      Return Properties("Weight_Total_Conveyors_Only").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Weight_Total_Conveyors_Only").CalculatedValue = Value
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
    
      Public ReadOnly Property [Product_Details_ASRS]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Product_Details_ASRS")
      End Get
      End Property
    
      Public ReadOnly Property [Product_Details_Electrical]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Product_Details_Electrical")
      End Get
      End Property
    
      Public ReadOnly Property [Product_Details_HCAD]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Product_Details_HCAD")
      End Get
      End Property
    
      Public ReadOnly Property [Product_Details_NonStd]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Product_Details_NonStd")
      End Get
      End Property
    
      Public ReadOnly Property [ShipFrom_Summaries]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("ShipFrom_Summaries")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD_Header]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD_Header")
      End Get
      End Property
    
      Public ReadOnly Property [testConn]() As Rulestream.Kernel.Connection
      Get
      Return Connections("testConn")
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
    InitPart("Freight_Estimate_Head", <a><![CDATA[Freight_Estimate_Head]]></a>.Value, 22, "FrtEst01",  "N", "N", True, False, "In Development", "", "Trailer Freight Calculator", "", "", "",  "GLOBAL\H601424", "04/02/2025 16:45:47")
    AddProperty("250", "Cost_Adder_Trailer_Each", <a><![CDATA[Cost_Adder_Trailer_Each]]></a>.Value, "Per Trailer $ Cost Adder", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 9:41:39 PM")
    AddProperty("253", "Cost_Adder_Wood_Product", <a><![CDATA[Cost_Adder_Wood_Product]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 1:04:16 AM")
    AddProperty("252", "Cost_Adder_Wood_Product_Pcnt", <a><![CDATA[Cost_Adder_Wood_Product_Pcnt]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 5:58:49 PM")
    AddProperty("255", "Cost_Fuel_Adder", <a><![CDATA[Cost_Fuel_Adder]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 1:03:07 AM")
    AddProperty("254", "Cost_Fuel_Adder_Pcnt", <a><![CDATA[Cost_Fuel_Adder_Pcnt]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 9:42:00 PM")
    AddProperty("251", "Cost_Subtotal_Mfg_Product", <a><![CDATA[Cost_Subtotal_Mfg_Product]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "4/2/2025 4:45:47 PM")
    AddProperty("256", "Cost_Total_All_Products", <a><![CDATA[Cost_Total_All_Products]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 12:26:55 PM")
    AddProperty("247", "Customer_Info_1", <a><![CDATA[Customer_Info_1]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "CORA Data", "", "GLOBAL\H601424", "3/19/2025 12:29:01 AM")
    AddProperty("248", "Customer_Info_2", <a><![CDATA[Customer_Info_2]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "CORA Data", "", "GLOBAL\H601424", "3/19/2025 12:29:01 AM")
    AddProperty("249", "Customer_Info_3", <a><![CDATA[Customer_Info_3]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "CORA Data", "", "GLOBAL\H601424", "3/19/2025 12:29:01 AM")
    AddProperty("1446", "Freight_Data_Source_Type", <a><![CDATA[Freight_Data_Source_Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "CORA Data", "", "GLOBAL\H601424", "3/27/2025 8:36:53 PM")
    AddProperty("1528", "Opportunity_Data_Source_Type", <a><![CDATA[Opportunity_Data_Source_Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "CORA Data", "", "GLOBAL\H601424", "3/28/2025 11:26:00 AM")
    AddProperty("367", "PRD_TOTAL_DEBUG", <a><![CDATA[PRD_TOTAL_DEBUG]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/25/2025 8:55:14 PM")
    AddProperty("365", "PRD_Total_Text", <a><![CDATA[PRD Total Text]]></a>.Value, "Text Coming from an unknown system", "String","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/27/2025 12:32:23 PM")
    AddProperty("473", "Ship_From_Locations_In_Use", <a><![CDATA[Ship_From_Locations_In_Use]]></a>.Value, "Count of Distinct Ship From Locations In Use in Product Items", "Long","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 10:21:05 PM")
    AddProperty("268", "Sum_Products_Cost_Escalated", <a><![CDATA[Sum_Products_Cost_Escalated]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 10:02:56 PM")
    AddProperty("267", "Sum_Products_Cost_Standard", <a><![CDATA[Sum_Products_Cost_Standard]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 10:03:15 PM")
    AddProperty("266", "Sum_Products_Ft_Total", <a><![CDATA[Sum_Products_Ft_Total]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 10:03:21 PM")
    AddProperty("269", "Sum_Products_Weight_Total", <a><![CDATA[Sum_Products_Weight_Total]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 10:18:35 PM")
    AddProperty("265", "Sum_Weight_Avg_Per_Ft", <a><![CDATA[Sum_Weight_Avg_Per_Ft]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 12:29:01 AM")
    AddProperty("362", "Trailer_Max_Load_Lbs", <a><![CDATA[Trailer_Max_Load_Lbs]]></a>.Value, "Maximum Trailer Weight (10,000 Lbs Default)", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 9:31:12 PM")
    AddProperty("261", "Trailer_Qty_from_STL_Est", <a><![CDATA[Trailer_Qty_from_STL_Est]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 12:28:09 AM")
    AddProperty("259", "Trailer_Qty_from_TTCB_Est", <a><![CDATA[Trailer_Qty_from_TTCB_Est]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 12:28:20 AM")
    AddProperty("260", "Trailer_Qty_from_USS_Est", <a><![CDATA[Trailer_Qty_from_USS_Est]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 12:28:26 AM")
    AddProperty("263", "Trailer_Qty_Misc_Equip", <a><![CDATA[Trailer_Qty_Misc_Equip]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 12:15:28 AM")
    AddProperty("262", "Trailer_Qty_Misc_Equip_Pcnt", <a><![CDATA[Trailer_Qty_Misc_Equip_Pcnt]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 9:40:44 PM")
    AddProperty("258", "Trailer_Qty_No_Misc", <a><![CDATA[Trailer_Qty_No_Misc]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 1:07:05 AM")
    AddProperty("264", "Trailer_Qty_Total_Est", <a><![CDATA[Trailer_Qty_Total_Est]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/21/2025 12:31:02 AM")
    AddProperty("366", "Use_PRD_Total_Text", <a><![CDATA[Use_PRD_Total_Text]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/27/2025 10:03:20 PM")
    AddProperty("257", "Weight_Total_Conveyors_Only", <a><![CDATA[Weight_Total_Conveyors_Only]]></a>.Value, "Rollup of Conveyor Weights", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 10:01:05 PM")
    AddProperty("246", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/19/2025 12:29:01 AM")
    
      AddValidValue("Freight_Data_Source_Type")
    
      AddValidValue("Opportunity_Data_Source_Type")
    
      AddValidValue("PRD_TOTAL_DEBUG")
    
      AddValidValue("Ship_From_Locations_In_Use")
    
      oSubpart = AddSubpart(7,"Product_Details_ASRS", <a><![CDATA[Product_Details_ASRS]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H601424", "3/20/2025 9:57:43 PM")
      
        oSubpart.AddVPF (21, "Freight_Estimate_Item", "Freight_Estimate_Item")
      
      oSubpart = AddSubpart(8,"Product_Details_Electrical", <a><![CDATA[Product_Details_Electrical]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H601424", "3/20/2025 9:58:34 PM")
      
        oSubpart.AddVPF (21, "Freight_Estimate_Item", "Freight_Estimate_Item")
      
      oSubpart = AddSubpart(5,"Product_Details_HCAD", <a><![CDATA[Product_Details_HCAD]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H601424", "3/20/2025 9:59:05 PM")
      
        oSubpart.AddVPF (21, "Freight_Estimate_Item", "Freight_Estimate_Item")
      
      oSubpart = AddSubpart(6,"Product_Details_NonStd", <a><![CDATA[Product_Details_NonStd]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H601424", "3/20/2025 9:57:02 PM")
      
        oSubpart.AddVPF (21, "Freight_Estimate_Item", "Freight_Estimate_Item")
      
      oSubpart = AddSubpart(4,"ShipFrom_Summaries", <a><![CDATA[Ship From Summaries]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/20/2025 9:13:06 PM")
      
        oSubpart.AddVPF (35, "Freight_Estimate_ShipFrom_Sum", "Freight_Estimate_ShipFrom_Sum")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My_PRD]]></a>.Value, "", "47", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "3/28/2025 11:52:20 AM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_PRD_Header", <a><![CDATA[My PRD Header]]></a>.Value, "Connetion to Salesforce PRD Header", "14", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "3/25/2025 10:32:01 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("testConn", <a><![CDATA[testConn]]></a>.Value, "", "2", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "3/19/2025 2:29:47 PM")
      
        oConnection.AddVPF(21, "Freight_Estimate_Item")
      
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
          InitProperty("Cost_Adder_Trailer_Each", "228", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 9:37:50 PM", "", "In Development",  0,237)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Adder_Wood_Product", "231", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 1:04:16 AM", "", "In Development",  0,613)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Adder_Wood_Product_Pcnt", "230", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 5:58:49 PM", "", "In Development",  0,526)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Fuel_Adder", "233", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 1:03:07 AM", "", "In Development",  0,612)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Fuel_Adder_Pcnt", "232", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 9:41:56 PM", "", "In Development",  0,387)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Subtotal_Mfg_Product", "229", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/2/2025 4:45:47 PM", "", "In Development",  0,1323)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Total_All_Products", "234", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 12:26:55 PM", "", "In Development",  0,611)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Info_1", "225", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 12:29:01 AM", "", "In Development",  0,234)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Info_2", "226", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 12:29:01 AM", "", "In Development",  0,235)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Info_3", "227", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 12:29:01 AM", "", "In Development",  0,236)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Freight_Data_Source_Type", "1145", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 5:19:36 PM", "", "In Development",  0,1227)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Opportunity_Data_Source_Type", "1222", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 11:25:40 AM", "", "In Development",  0,1313)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_TOTAL_DEBUG", "339", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 1:06:14 AM", "", "In Development",  0,432)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Total_Text", "337", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 12:32:23 PM", "", "In Development",  0,398)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_From_Locations_In_Use", "437", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 10:21:05 PM", "Count of Ship Locations In Use in Product Items", "In Development",  0,560)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sum_Products_Cost_Escalated", "246", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 10:02:56 PM", "", "In Development",  0,580)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sum_Products_Cost_Standard", "245", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 10:03:15 PM", "", "In Development",  0,581)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sum_Products_Ft_Total", "244", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 10:03:21 PM", "", "In Development",  0,582)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sum_Products_Weight_Total", "247", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 10:03:41 PM", "", "In Development",  0,584)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sum_Weight_Avg_Per_Ft", "243", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 12:29:01 AM", "", "In Development",  0,252)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Max_Load_Lbs", "334", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 9:30:42 PM", "Maximum Trailer Weight (10,000 Lbs Default)", "In Development",  0,385)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Qty_from_STL_Est", "239", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 12:28:09 AM", "", "In Development",  0,248)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Qty_from_TTCB_Est", "237", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 12:28:20 AM", "", "In Development",  0,246)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Qty_from_USS_Est", "238", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 12:28:26 AM", "", "In Development",  0,247)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Qty_Misc_Equip", "241", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 12:15:28 AM", "", "In Development",  0,606)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Qty_Misc_Equip_Pcnt", "240", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 9:40:34 PM", "", "In Development",  0,386)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Qty_No_Misc", "236", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 1:07:00 AM", "", "In Development",  0,614)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Trailer_Qty_Total_Est", "242", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/21/2025 12:30:59 AM", "", "In Development",  0,607)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Use_PRD_Total_Text", "338", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 10:03:08 PM", "", "In Development",  0,1232)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_Total_Conveyors_Only", "235", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 10:01:05 PM", "", "In Development",  0,579)
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
          
        InitValidValue("Freight_Data_Source_Type_ValidValues", "1145", "-1", 1228)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Opportunity_Data_Source_Type_ValidValues", "1222", "-1", 1314)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_TOTAL_DEBUG_ValidValues", "339", "-1", 416)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ship_From_Locations_In_Use_ValidValues", "437", "-1", 585)
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
          
        InitSubpart("Product_Details_HCAD", 4, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "3/20/2025 9:55:36 PM", "", "In Development", "N",0,23,22)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("ShipFrom_Summaries", 3, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "3/20/2025 9:13:06 PM", "", "In Development", "N",0,6,21)
        
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
          
        InitConnection("My_PRD", "27", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 11:52:20 AM", "", "In Development", "N",37)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_PRD_Header", "10", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "3/25/2025 10:31:48 PM", "", "In Development", "N",16)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("testConn", "2", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "3/19/2025 2:29:47 PM", "", "In Development", "N",3)
        
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
      Public Function Formula_My_PRD_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:27; TYPE:PF
        Result = Nothing
If Me.Use_PRD_Total_Text Then
	'Result = Me.Parent.PRD_Document(1)
	'RootPart.Project_Information(1).Salesforce_Opportunity(1).PRD_Document(1)
	Result = RootPart.Project_Information(1).Salesforce_Opportunity(1).PRD_Document(1)
End If
        '   END FORMULA; CON ID:27; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_PRD_Header_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:10; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:10; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_My_PRD_Header_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_testConn_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:2; TYPE:PF
        Result = TraverseCollection(Me, "Freight_Estimate_Item", True)
        '   END FORMULA; CON ID:2; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_testConn_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Adder_Trailer_Each() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Adder_Trailer_Each").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:228; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:228; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Cost_Adder_Trailer_Each", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Adder_Wood_Product() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Adder_Wood_Product").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:231; TYPE:PF
      Result = Cost_SubTotal_Mfg_Product * Cost_Adder_Wood_Product_Pcnt / 100
      '   END FORMULA; PROP ID:231; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Cost_Adder_Wood_Product", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Adder_Wood_Product_Pcnt() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Adder_Wood_Product_Pcnt").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:230; TYPE:PF
      Result = 3
      '   END FORMULA; PROP ID:230; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Cost_Adder_Wood_Product_Pcnt", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Fuel_Adder() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Fuel_Adder").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:233; TYPE:PF
      Result = Cost_SubTotal_Mfg_Product * Cost_Fuel_Adder_Pcnt / 100
      '   END FORMULA; PROP ID:233; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Cost_Fuel_Adder", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Fuel_Adder_Pcnt() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Fuel_Adder_Pcnt").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:232; TYPE:PF
      Result = 35
      '   END FORMULA; PROP ID:232; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Cost_Fuel_Adder_Pcnt", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Subtotal_Mfg_Product() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Subtotal_Mfg_Product").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:229; TYPE:PF
      Result = 0.0

Const RollupPropertyName As String = "Cost_Freight_All_Trucks"

For Each P As Part In Me.ShipFrom_Summaries.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.properties(RollupPropertyName).value
	End If
Next P
      '   END FORMULA; PROP ID:229; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Cost_Subtotal_Mfg_Product", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Total_All_Products() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Total_All_Products").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:234; TYPE:PF
      Result = Me.Cost_Adder_Wood_Product + _
    	 Me.Cost_Fuel_Adder + _ 
		 Me.Cost_Subtotal_Mfg_Product + _
		 (Me.Cost_Adder_Trailer_Each * Me.Trailer_Qty_Total_Est)
      '   END FORMULA; PROP ID:234; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Cost_Total_All_Products", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Info_1() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Info_1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:225; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:225; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Customer_Info_1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Info_2() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Info_2").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:226; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:226; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Customer_Info_2", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Info_3() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Info_3").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:227; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:227; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Customer_Info_3", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Freight_Data_Source_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Freight_Data_Source_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1145; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:1145; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Freight_Data_Source_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Opportunity_Data_Source_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Opportunity_Data_Source_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1222; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:1222; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Opportunity_Data_Source_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_TOTAL_DEBUG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_TOTAL_DEBUG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:339; TYPE:PF
      Result = ""

If Me.Use_PRD_Total_Text Then
	Dim lines() As String = PRD_Total_Text.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length > 1 Then
			If elements(0).trim().ToLower() = "metrics" Then
				StartProd = True
			End If
			
			If StartProd Then
				If Me.validvalues("PRD_TOTAL_DEBUG").contains(elements(0).Trim()) Then
				Result = Result & $"Line: {linemarker} | Item: {elements(0)} | QTY: {elements(2)} | $/UOM: {elements(3)} | FT: {left(elements(4),4).TRim()} | CstSTD: {elements(5)} | CstESC: {elements(6)}{vbcrlf}"
			End If
			End If
	End If
	Next line
End If

Dim productlines() As String = Result.Split(New String() {vbCrLf}, StringSplitOptions.None)
Dim NewResult As String = $"{productlines.length -1} Products Found"  &  vbcrlf &  "--------------------------------------" &  vbcrlf
Result = NewResult & Result
      '   END FORMULA; PROP ID:339; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_PRD_TOTAL_DEBUG", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Total_Text() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Total_Text").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:337; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:337; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_PRD_Total_Text", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ship_From_Locations_In_Use() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ship_From_Locations_In_Use").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:437; TYPE:PF
      Result = Me.ValidValues("Ship_From_Locations_In_Use").count
      '   END FORMULA; PROP ID:437; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Ship_From_Locations_In_Use", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sum_Products_Cost_Escalated() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sum_Products_Cost_Escalated").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:246; TYPE:PF
      'Setup Default Value First to prevent a runtime error condition
Result = 0

' Literals PartFamily and Property Names should be constants. 
'     Will improve performnce, As the value Is compiled In and Not evaluated at runtime

Const RollupPFName As  String  = "Freight_Estimate_Item"
Const RollupPropertyName As String = "Cost_Escalated"

' Do not create a new Collection object, use Traverse Collection Directly
'    Prevents memory bloat on large collections

For Each P As Part In Me.Product_Details_ASRS.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_Electrical.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_HCAD.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_NonStd.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
      '   END FORMULA; PROP ID:246; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Sum_Products_Cost_Escalated", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sum_Products_Cost_Standard() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sum_Products_Cost_Standard").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:245; TYPE:PF
      'Setup Default Value First to prevent a runtime error condition
Result = 0

' Literals PartFamily and Property Names should be constants. 
'     Will improve performnce, As the value Is compiled In and Not evaluated at runtime

Const RollupPFName As  String  = "Freight_Estimate_Item"
Const RollupPropertyName As String = "Cost_Standard"

' Do not create a new Collection object, use Traverse Collection Directly
'    Prevents memory bloat on large collections

For Each P As Part In Me.Product_Details_ASRS.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_Electrical.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_HCAD.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_NonStd.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
      '   END FORMULA; PROP ID:245; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Sum_Products_Cost_Standard", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sum_Products_Ft_Total() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sum_Products_Ft_Total").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:244; TYPE:PF
      'Setup Default Value First to prevent a runtime error condition
Result = 0

' Literals PartFamily and Property Names should be constants. 
'     Will improve performnce, As the value Is compiled In and Not evaluated at runtime

Const RollupPFName As  String  = "Freight_Estimate_Item"
Const RollupPropertyName As String = "Ft_Per_Qty"

' Do not create a new Collection object, use Traverse Collection Directly
'    Prevents memory bloat on large collections

For Each P As Part In Me.Product_Details_ASRS.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_Electrical.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_HCAD.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_NonStd.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
      '   END FORMULA; PROP ID:244; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Sum_Products_Ft_Total", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sum_Products_Weight_Total() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sum_Products_Weight_Total").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:247; TYPE:PF
      'Setup Default Value First to prevent an runtime error condition
Result = 0

' Literals PartFamily and Property Names should be constants. 
'     Will improve performnce, As the value Is compiled In and Not evaluated at runtime

Const RollupPFName As  String  = "Freight_Estimate_Item"
Const RollupPropertyName As String = "Weight_In_Lbs"

For Each P As Part In Me.Product_Details_ASRS.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_Electrical.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_HCAD.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
For Each P As Part In Me.Product_Details_NonStd.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.Properties(RollupPropertyName).Value
	End If
Next P
      '   END FORMULA; PROP ID:247; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Sum_Products_Weight_Total", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sum_Weight_Avg_Per_Ft() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sum_Weight_Avg_Per_Ft").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:243; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:243; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Sum_Weight_Avg_Per_Ft", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Max_Load_Lbs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Max_Load_Lbs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:334; TYPE:PF
      result = 10000
      '   END FORMULA; PROP ID:334; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Max_Load_Lbs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Qty_from_STL_Est() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Qty_from_STL_Est").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:239; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:239; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Qty_from_STL_Est", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Qty_from_TTCB_Est() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Qty_from_TTCB_Est").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:237; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:237; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Qty_from_TTCB_Est", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Qty_from_USS_Est() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Qty_from_USS_Est").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:238; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:238; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Qty_from_USS_Est", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Qty_Misc_Equip() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Qty_Misc_Equip").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:241; TYPE:PF
      Result = roundup(1, Me.Trailer_Qty_No_Misc * (Me.Trailer_Qty_Misc_Equip_Pcnt/100))
      '   END FORMULA; PROP ID:241; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Qty_Misc_Equip", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Qty_Misc_Equip_Pcnt() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Qty_Misc_Equip_Pcnt").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:240; TYPE:PF
      Result = 15.0
      '   END FORMULA; PROP ID:240; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Qty_Misc_Equip_Pcnt", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Qty_No_Misc() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Qty_No_Misc").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:236; TYPE:PF
      Result = 0.0

Const RollupPropertyName As String = "Trailer_Qty"

For Each P As Part In Me.ShipFrom_Summaries.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		Result = Result + P.properties(RollupPropertyName).value
	End If
Next P
Result = Result - Me.Trailer_Qty_From_TTCB_Est
      '   END FORMULA; PROP ID:236; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Qty_No_Misc", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Trailer_Qty_Total_Est() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Trailer_Qty_Total_Est").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:242; TYPE:PF
      Result = Me.Trailer_Qty_No_Misc _ 
		+ Me.Trailer_Qty_Misc_Equip _
	    + Me.Trailer_Qty_from_STL_Est _
	 	+ Me.Trailer_Qty_from_TTCB_Est _
		+ me.Trailer_Qty_from_USS_Est
      '   END FORMULA; PROP ID:242; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Trailer_Qty_Total_Est", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Use_PRD_Total_Text() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Use_PRD_Total_Text").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:338; TYPE:PF
      Result = (Me.Freight_Data_Source_Type.Trim().ToUpper()="SALESFORCE PRD")
      '   END FORMULA; PROP ID:338; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Use_PRD_Total_Text", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_Total_Conveyors_Only() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_Total_Conveyors_Only").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:235; TYPE:PF
      'Setup Default Value First to prevent a runtime error condition
Result = 0

' Literal PartFamily and Property Names should be constants. 
'     Will improve performnce, As the value Is compiled In and Not evaluated at runtime

Const RollupPFName As  String  = "Freight_Estimate_Item"
Const RollupPropertyName As String = "Weight_in_Lbs"
Const SearchProperty1Name As String = "Product_Class"
Const SearchProperty1Value As String = "HCAD"
Const SearchProperty2Name As String = "Product_Name"
Const SearchProperty2Value As String = "Conveyor"

' Do not create a new Collection object, use Traverse Collection Directly
'    Prevents memory bloat on large collections
For Each P As Part In Me.Product_Details_ASRS.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) AndAlso  P.Properties.ContainsKey(SearchProperty1Name) Then
		If P.Properties(SearchProperty1Name).Value = SearchProperty1Value Or P.Properties(SearchProperty2Name).Value = SearchProperty2Value
			Result = Result + P.Properties(RollupPropertyName).Value
		End If
	End If
Next P
For Each P As Part In Me.Product_Details_Electrical.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) AndAlso  P.Properties.ContainsKey(SearchProperty1Name) Then
		If P.Properties(SearchProperty1Name).Value = SearchProperty1Value Or P.Properties(SearchProperty2Name).Value = SearchProperty2Value
			Result = Result + P.Properties(RollupPropertyName).Value
		End If
	End If
Next P
For Each P As Part In Me.Product_Details_HCAD.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) AndAlso  P.Properties.ContainsKey(SearchProperty1Name) Then
		If P.Properties(SearchProperty1Name).Value = SearchProperty1Value Or P.Properties(SearchProperty2Name).Value = SearchProperty2Value
			Result = Result + P.Properties(RollupPropertyName).Value
		End If
	End If
Next P
For Each P As Part In Me.Product_Details_NonStd.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) AndAlso  P.Properties.ContainsKey(SearchProperty1Name) Then
		If P.Properties(SearchProperty1Name).Value = SearchProperty1Value Or P.Properties(SearchProperty2Name).Value = SearchProperty2Value
			Result = Result + P.Properties(RollupPropertyName).Value
		End If
	End If
Next P
      '   END FORMULA; PROP ID:235; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Weight_Total_Conveyors_Only", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Adder_Trailer_Each_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Adder_Wood_Product_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Adder_Wood_Product_Pcnt_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Fuel_Adder_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Fuel_Adder_Pcnt_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Subtotal_Mfg_Product_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Total_All_Products_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Info_1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Info_2_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Info_3_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Freight_Data_Source_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Opportunity_Data_Source_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_TOTAL_DEBUG_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Total_Text_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_From_Locations_In_Use_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Cost_Escalated_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Cost_Standard_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Ft_Total_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Weight_Total_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Weight_Avg_Per_Ft_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Max_Load_Lbs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_from_STL_Est_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_from_TTCB_Est_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_from_USS_Est_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_Misc_Equip_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_Misc_Equip_Pcnt_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_No_Misc_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_Total_Est_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Use_PRD_Total_Text_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Total_Conveyors_Only_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Adder_Trailer_Each_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Adder_Wood_Product_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Adder_Wood_Product_Pcnt_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Fuel_Adder_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Fuel_Adder_Pcnt_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Subtotal_Mfg_Product_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Total_All_Products_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Info_1_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Info_2_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Info_3_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Freight_Data_Source_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Opportunity_Data_Source_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_TOTAL_DEBUG_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Total_Text_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_From_Locations_In_Use_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Cost_Escalated_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Cost_Standard_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Ft_Total_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Products_Weight_Total_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sum_Weight_Avg_Per_Ft_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Max_Load_Lbs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_from_STL_Est_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_from_TTCB_Est_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_from_USS_Est_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_Misc_Equip_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_Misc_Equip_Pcnt_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_No_Misc_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Trailer_Qty_Total_Est_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Use_PRD_Total_Text_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Total_Conveyors_Only_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Freight_Data_Source_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Freight_Data_Source_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1145; TYPE:VV
      Result = MakeValidValues(Array("Please Select", "Manual", "Salesforce PRD"))
      '   END FORMULA; PROP ID:1145; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Freight_Data_Source_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Opportunity_Data_Source_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Opportunity_Data_Source_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1222; TYPE:VV
      Result = MakeValidValues(Array("Please Select", "Manual", "Salesforce PRD"))
      '   END FORMULA; PROP ID:1222; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Opportunity_Data_Source_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_TOTAL_DEBUG_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_TOTAL_DEBUG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:339; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Product_Name]", "[Product_Name]", " ORDER BY [Product_Name]")
      '   END FORMULA; PROP ID:339; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_PRD_TOTAL_DEBUG_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_From_Locations_In_Use_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ship_From_Locations_In_Use").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:437; TYPE:VV
      Const RollupPFName As  String  = "Freight_Estimate_Item"
Const RollupPropertyName As String = "Ship_From"
Dim ShipLocations As  New ValidValues()

' Do not create a new Collection object, use Traverse Collection Directly
'    Prevents memory bloat on large collections
For Each P As Part In Me.Product_Details_HCAD.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		If Not ShipLocations.Contains(P.Properties(RollupPropertyName).Value.ToUpper()) Then
			If P.Properties(RollupPropertyName).Value.Trim().Length > 0
           		ShipLocations.Add(P.Properties(RollupPropertyName).Value.ToUpper())
	   		End If
		End If
	End If
Next P
For Each P As Part In Me.Product_Details_NonStd.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		If Not ShipLocations.Contains(P.Properties(RollupPropertyName).Value.ToUpper()) Then
			If P.Properties(RollupPropertyName).Value.Trim().Length > 0
           		ShipLocations.Add(P.Properties(RollupPropertyName).Value.ToUpper())
	   		End If
		End If
	End If
Next P
For Each P As Part In Me.Product_Details_ASRS.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		If Not ShipLocations.Contains(P.Properties(RollupPropertyName).Value.ToUpper()) Then
			If P.Properties(RollupPropertyName).Value.Trim().Length > 0
           		ShipLocations.Add(P.Properties(RollupPropertyName).Value.ToUpper())
	   		End If
		End If
	End If
Next P
For Each P As Part In Me.Product_Details_Electrical.Parts()
	If P.Properties.ContainsKey(RollupPropertyName) Then
		If Not ShipLocations.Contains(P.Properties(RollupPropertyName).Value.ToUpper()) Then
			If P.Properties(RollupPropertyName).Value.Trim().Length > 0
           		ShipLocations.Add(P.Properties(RollupPropertyName).Value.ToUpper())
	   		End If
		End If
	End If
Next P
Result = ShipLocations
      '   END FORMULA; PROP ID:437; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Ship_From_Locations_In_Use_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Details_HCAD_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:4; TYPE:PN
      
      '   END FORMULA; SUB ID:4; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Product_Details_HCAD_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Details_HCAD_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Product_Details_HCAD").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:4; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:4; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Product_Details_HCAD_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Details_HCAD_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Product_Details_HCAD").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:4; TYPE:OP
      result = "Freight_Estimate_Item"
      '   END FORMULA; SUB ID:4; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_Product_Details_HCAD_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipFrom_Summaries_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:3; TYPE:PN
      
      '   END FORMULA; SUB ID:3; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_ShipFrom_Summaries_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipFrom_Summaries_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ShipFrom_Summaries").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:3; TYPE:QF
      Result = Me.Ship_From_Locations_In_Use
      '   END FORMULA; SUB ID:3; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_ShipFrom_Summaries_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShipFrom_Summaries_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ShipFrom_Summaries").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:3; TYPE:OP
      result = "Freight_Estimate_ShipFrom_Sum"
      '   END FORMULA; SUB ID:3; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Head.Formula_ShipFrom_Summaries_OPTIMALPARTFAMILY", ex.Message)
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

  