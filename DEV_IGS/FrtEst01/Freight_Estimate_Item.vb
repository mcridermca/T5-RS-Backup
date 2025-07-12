Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: FrtEst01
'$ PartFamily: Freight_Estimate_Item
'$ GenerateDate: 07/12/2025 19:19:17

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

    Public Class [Freight_Estimate_Item]
    
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

    Private this as Freight_Estimate_Item = me

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
    
          Public Property [Debug]() As String
      Get
      Return Properties("Debug").Value
      End Get
      Set(ByVal Value As String)
      Properties("Debug").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Escalated]() As Double
      Get
      Return Properties("Cost_Escalated").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Escalated").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Per_UOM]() As Double
      Get
      Return Properties("Cost_Per_UOM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Per_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cost_Standard]() As Double
      Get
      Return Properties("Cost_Standard").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Cost_Standard").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ft_Per_Qty]() As Double
      Get
      Return Properties("Ft_Per_Qty").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ft_Per_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Percent_of_Total]() As Double
      Get
      Return Properties("Percent_of_Total").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Percent_of_Total").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Percent_of_Total_Display]() As String
      Get
      Return Properties("Percent_of_Total_Display").Value
      End Get
      Set(ByVal Value As String)
      Properties("Percent_of_Total_Display").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Class]() As String
      Get
      Return Properties("Product_Class").Value
      End Get
      Set(ByVal Value As String)
      Properties("Product_Class").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Name]() As String
      Get
      Return Properties("Product_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Product_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Ship_From_Default]() As String
      Get
      Return Properties("Product_Ship_From_Default").Value
      End Get
      Set(ByVal Value As String)
      Properties("Product_Ship_From_Default").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ship_From]() As String
      Get
      Return Properties("Ship_From").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ship_From").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_In_Lbs]() As Double
      Get
      Return Properties("Weight_In_Lbs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Weight_In_Lbs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_Lookup_Key]() As String
      Get
      Return Properties("Weight_Lookup_Key").Value
      End Get
      Set(ByVal Value As String)
      Properties("Weight_Lookup_Key").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_Per_Ft]() As Double
      Get
      Return Properties("Weight_Per_Ft").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Weight_Per_Ft").CalculatedValue = Value
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
    InitPart("Freight_Estimate_Item", <a><![CDATA[Freight_Estimate_Item]]></a>.Value, 21, "FrtEst01",  "N", "N", True, False, "In Development", "Trailer Freight Calc Spreadsheet (Freight Calc)", "Represents a list of products / weights used for determining trailer freight costs", "", "", "",  "GLOBAL\H601424", "05/02/2025 12:42:30")
    AddProperty("474", "Debug", <a><![CDATA[Debug]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/20/2025 10:30:42 PM")
    AddProperty("242", "Cost_Escalated", <a><![CDATA[Cost_Escalated]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 2:08:10 PM")
    AddProperty("239", "Cost_Per_UOM", <a><![CDATA[Cost_Per_UOM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 3:47:46 PM")
    AddProperty("241", "Cost_Standard", <a><![CDATA[Cost_Standard]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 2:08:01 PM")
    AddProperty("240", "Ft_Per_Qty", <a><![CDATA[Ft_Per_Qty]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 12:29:00 AM")
    AddProperty("243", "Percent_of_Total", <a><![CDATA[Percent_of_Total]]></a>.Value, "This products total Percentage of footage vs the entire projects footage.", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 6:56:05 PM")
    AddProperty("360", "Percent_of_Total_Display", <a><![CDATA[Percent_of_Total_Display]]></a>.Value, "% Formatted Version of  Percent_of_Total Property", "String","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 9:26:37 PM")
    AddProperty("245", "Product_Class", <a><![CDATA[Product_Class]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/27/2025 2:16:00 AM")
    AddProperty("237", "Product_Name", <a><![CDATA[Product_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/20/2025 5:53:12 PM")
    AddProperty("355", "Product_Ship_From_Default", <a><![CDATA[Product_Ship_From_Default]]></a>.Value, "Default Ship From Location for this product", "String","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 11:23:19 AM")
    AddProperty("353", "Ship_From", <a><![CDATA[Ship_From]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/28/2025 3:12:36 AM")
    AddProperty("352", "Weight_In_Lbs", <a><![CDATA[Weight_In_Lbs]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 6:40:58 PM")
    AddProperty("238", "Weight_Lookup_Key", <a><![CDATA[Weight_Lookup_Key]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "3/19/2025 12:29:00 AM")
    AddProperty("357", "Weight_Per_Ft", <a><![CDATA[Weight_Per_Ft]]></a>.Value, "Weight Per Ft", "Double","","General","FD", 9999, "", 0,0, "Trailer Freight Calc Spreadsheet (Freight Calc)", "", "GLOBAL\H601424", "5/2/2025 12:42:30 PM")
    AddProperty("236", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/19/2025 12:29:00 AM")
    
      AddValidValue("Product_Class")
    
      AddValidValue("Product_Name")
    
      AddValidValue("Ship_From")
    
      AddDBConstraint(1, "dbFreightProductData", <a><![CDATA[db Freight Product Data]]></a>.Value,"General", 9999)
    
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
          InitProperty("Debug", "438", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 10:30:32 PM", "", "In Development",  0,589)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Escalated", "221", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 2:08:10 PM", "", "In Development",  0,230)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Per_UOM", "218", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 3:47:46 PM", "", "In Development",  0,227)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cost_Standard", "220", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 2:08:01 PM", "", "In Development",  0,229)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ft_Per_Qty", "219", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 12:29:00 AM", "", "In Development",  0,228)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Percent_of_Total", "222", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 6:56:05 PM", "", "In Development",  0,377)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Percent_of_Total_Display", "332", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 9:01:17 PM", "", "In Development",  0,383)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Class", "224", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 2:15:28 AM", "", "In Development",  0,1215)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Name", "216", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 5:53:12 PM", "", "In Development",  0,225)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Ship_From_Default", "327", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 11:23:19 AM", "", "In Development",  0,338)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_From", "325", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 3:12:36 AM", "", "In Development",  0,341)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_In_Lbs", "324", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 6:40:58 PM", "", "In Development",  0,374)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_Lookup_Key", "217", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/19/2025 12:29:00 AM", "", "In Development",  0,226)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_Per_Ft", "329", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "5/2/2025 12:42:30 PM", "Weight Per Ft", "In Development",  0,343)
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
          
        InitValidValue("Product_Class_ValidValues", "224", "-1", 591)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Product_Name_ValidValues", "216", "-1", 340)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ship_From_ValidValues", "325", "-1", 1236)
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("dbFreightProductData", 1,"", "Y","", "", "vw_Freight_Product_Generic_List")
        
          InitDBproperty("dbFreightProductData", "Product_Ship_From_Default",1, "Default_Ship_Location_Code", "vw_Freight_Product_Generic_List")
        
          InitDBproperty("dbFreightProductData", "Weight_Per_Ft",1, "Lbs_Per_UOM", "vw_Freight_Product_Generic_List")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Debug() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Debug").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:438; TYPE:PF
      Result = Me.Name.Split(":")(0).Replace("Product_Details_","")
Select Case Result
	Case = "ASRS"
		Result = "AS/RS"
	Case = "Non-Std"
		Result = "Non-Standard"
	Case Else
		Result = Result
	End Select
      '   END FORMULA; PROP ID:438; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Debug", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Escalated() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Escalated").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:221; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:221; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Cost_Escalated", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Per_UOM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Per_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:218; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:218; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Cost_Per_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cost_Standard() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cost_Standard").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:220; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:220; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Cost_Standard", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ft_Per_Qty() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ft_Per_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:219; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:219; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Ft_Per_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Percent_of_Total() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Percent_of_Total").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:222; TYPE:PF
      Result = Me.Ft_Per_Qty / Me.Parent.Sum_Products_Ft_Total
      '   END FORMULA; PROP ID:222; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Percent_of_Total", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Percent_of_Total_Display() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Percent_of_Total_Display").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:332; TYPE:PF
      Result = Me.Percent_of_Total.ToString("P1")
      '   END FORMULA; PROP ID:332; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Percent_of_Total_Display", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Class() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Class").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:224; TYPE:PF
      Result = Me.Name.Split(":")(0).Replace("Product_Details_","")

Select Case Result
	Case = "ASRS"
		Result = "AS/RS"
	Case = "NonStd"
		Result = "Non-Standard"
	Case Else
		Result = Result
End Select
      '   END FORMULA; PROP ID:224; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Product_Class", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:216; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:216; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Product_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Ship_From_Default() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Ship_From_Default").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:327; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:327; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Product_Ship_From_Default", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ship_From() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ship_From").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:325; TYPE:PF
      Result = Me.Product_Ship_From_Default
      '   END FORMULA; PROP ID:325; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Ship_From", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_In_Lbs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_In_Lbs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:324; TYPE:PF
      Result = 0

Select Case Product_Class
	Case = "HCAD"
		'From Spreadsheet Formula
		' (UnitWeightPerFootLookup) * E17+(E17/10*60)+(E17*5)
		' UnitWeightPerFoot * UnitFeet +(UnitFeet/10*60)+(UnitFeet*5)
		
		Result = Me.Weight_Per_Ft * Me.Ft_Per_Qty + (Me.Ft_Per_Qty/10*60) + (Me.Ft_Per_Qty*5)
	Case Else
		'=VLOOKUP(C41,$M$40:$N$45,2,FALSE)*E41
		'=(FT_QTY) * (Product Weight Per Foot)
		Result = Me.Weight_Per_Ft * Me.Ft_Per_Qty
		
End Select
      '   END FORMULA; PROP ID:324; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Weight_In_Lbs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_Lookup_Key() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_Lookup_Key").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:217; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:217; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Weight_Lookup_Key", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_Per_Ft() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_Per_Ft").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:329; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:329; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Weight_Per_Ft", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Escalated_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Per_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Standard_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ft_Per_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Percent_of_Total_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Percent_of_Total_Display_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Class_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Ship_From_Default_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_From_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_In_Lbs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Lookup_Key_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Per_Ft_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Escalated_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Per_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cost_Standard_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ft_Per_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Percent_of_Total_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Percent_of_Total_Display_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Class_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Ship_From_Default_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_From_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_In_Lbs_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Lookup_Key_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Per_Ft_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Class_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Class").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:224; TYPE:VV
      'Result = MakeValidKeyValues(Array("Select Option","AS/RS", "Electrical", "HCAD", "Non-Standard"), Array("","AS/RS", "Electrical", "HCAD", "Non-Standard"))
Result = Nothing
      '   END FORMULA; PROP ID:224; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Product_Class_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Name_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:216; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Product_Name]", "[Product_Name]", "WHERE [Lookup_Type] = " & FormatCriteria(Me.Product_Class) & " ORDER BY [Product_Name]")
      '   END FORMULA; PROP ID:216; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Product_Name_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_From_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ship_From").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:325; TYPE:VV
      Result = MakeValidKeyValues(Array("Select Option","CHIHUAHUA","DAN", "EL PASO", "LON", "OMM", "STL", "WC"), 
							Array("","Chihuahua","Danville (DAN)", "El Paso", "London (LON)", "Owings Mills (OMM)", "St. Louis (STL)", "West Chester (WC)"))
      '   END FORMULA; PROP ID:325; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.Formula_Ship_From_ValidValues", ex.Message)
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
      
        Case 1
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Default_Ship_Location_Code" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Lbs_Per_UOM" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.Product_Name
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Product_Name]", "=", varPropSpecVal, "")
            
                  varPropSpecVal = me.Product_Class
              BuildWhereClause(strWhereClause, "0", "0", " AND ", "[Lookup_Type]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("vw_Freight_Product_Generic_List"), strWhereClause, leftDelimiter & "Product_Name" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " Freight_Estimate_Item.GetRecordset", strError)
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

  