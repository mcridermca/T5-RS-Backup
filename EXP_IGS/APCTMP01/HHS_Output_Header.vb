Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: HHS_Output_Header
'$ GenerateDate: 06/12/2025 19:28:00

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
    
          Public Property [Seismic_Requirement]() As String
      Get
      Return Properties("Seismic_Requirement").Value
      End Get
      Set(ByVal Value As String)
      Properties("Seismic_Requirement").CalculatedValue = Value
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
    InitPart("HHS_Output_Header", <a><![CDATA[HHS Output Header]]></a>.Value, 336, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "05/29/2025 14:58:32")
    AddProperty("2480", "BOM_PartNo_Unique_Keys", <a><![CDATA[BOM PartNo Unique Keys]]></a>.Value, "Count / VV List of Unique Part Numbers in Solution", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/30/2025 9:09:19 PM")
    AddProperty("2465", "Display_Zero_Qty_Items", <a><![CDATA[Display Zero Qty Items]]></a>.Value, "Include Non-Zero Items in Connections / Grids", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/29/2025 5:08:07 PM")
    AddProperty("2350", "Hanger_Spacing", <a><![CDATA[Hanger Spacing]]></a>.Value, "Hanger Spacing in Feet", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
    AddProperty("2320", "Is_Seismic", <a><![CDATA[Is Seismic]]></a>.Value, "Does this application require siesmic standards", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
    AddProperty("2219", "Output_Lines_DBKeys", <a><![CDATA[Output Lines DBKeys]]></a>.Value, "DataBase Extract of Key Values for Lines", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/22/2025 12:58:52 AM")
    AddProperty("2321", "Seismic_Requirement", <a><![CDATA[Seismic Requirement]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
    AddProperty("2217", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/22/2025 12:12:08 AM")
    
      AddValidValue("BOM_PartNo_Unique_Keys")
    
      AddValidValue("Output_Lines_DBKeys")
    
      AddValidValue("Seismic_Requirement")
    
      oSubpart = AddSubpart(233,"Bom_Items_Flat", <a><![CDATA[Bom Items Flat]]></a>.Value, "FD", "SubPart Collection of Unique Bom Items/w Total Qty Each", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 2:58:32 PM")
      
        oSubpart.AddVPF (358, "HHS_BOM_Item", "HHS BOM Item")
      
        oSubpart.AddVPF (357, "sm_Generic_BOM_Item", "sm Generic BOM Item")
      
      oSubpart = AddSubpart(203,"Grouping_Matrix_Controller", <a><![CDATA[Grouping Matrix Controller]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "4/23/2025 4:55:24 PM")
      
        oSubpart.AddVPF (339, "HHS_Grouping_Matrix_Controller", "HHS Grouping Matrix Controller")
      
      oSubpart = AddSubpart(199,"Output_Lines", <a><![CDATA[Output Lines]]></a>.Value, "FD", "HHS Output Lines Collection", "General", 9999, "", "GLOBAL\H601424", "4/22/2025 12:45:36 AM")
      
        oSubpart.AddVPF (337, "HHS_Output_Line", "HHS Output Line")
      
      oConnection = AddConnection("Bom_Items_Flat_Sorted", <a><![CDATA[Bom Items Flat Sorted]]></a>.Value, "", "106", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "5/29/2025 2:58:32 PM")
      
        oConnection.AddVPF(357, "sm_Generic_BOM_Item")
      
        oConnection.AddVPF(358, "HHS_BOM_Item")
      
      oConnection = AddConnection("Calculated_Items", <a><![CDATA[Calculated Items]]></a>.Value, "Connection to All Component and Hanger Items", "102", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "4/30/2025 9:06:32 PM")
      
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
          InitProperty("BOM_PartNo_Unique_Keys", "2122", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/30/2025 9:09:19 PM", "Count / VV List of Unique Part Numbers in Solution", "In Development",  0,3382)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Display_Zero_Qty_Items", "2109", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/29/2025 5:08:07 PM", "Include Non-Zero Items in Connections / Grids", "In Development",  0,3278)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hanger_Spacing", "1998", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "Hanger Spacing in Feet", "In Development",  0,2795)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Seismic", "1968", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "Does this application require siesmic standards", "In Development",  0,2731)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Output_Lines_DBKeys", "1882", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "4/22/2025 12:58:52 AM", "DataBase Extract of Key Values for Lines", "In Development",  0,2515)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Seismic_Requirement", "1969", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "", "In Development",  0,2734)
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
          
        InitValidValue("BOM_PartNo_Unique_Keys_ValidValues", "2122", "-1", 3441)
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
          
        InitSubpart("Bom_Items_Flat", 171, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 2:58:32 PM", "SubPart Collection of Unique Bom Items/w Total Qty Each", "In Development", "Y",0,483,482)
        
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
          
        InitConnection("Bom_Items_Flat_Sorted", "86", "N","N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 2:58:32 PM", "", "In Development", "Y",148)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Calculated_Items", "82", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "4/30/2025 9:06:32 PM", "Connection to All Component and Hanger Items", "In Development", "N",149)
        
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
        Result = SortObjectsByProperty(Me.Bom_Items_Flat.Parts,"Sort_Order_1", False)
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
'Sort

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
      Public Function Formula_BOM_PartNo_Unique_Keys_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Seismic_Requirement_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Seismic_Requirement_USERCHANGE() as Boolean
      Return True
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

  