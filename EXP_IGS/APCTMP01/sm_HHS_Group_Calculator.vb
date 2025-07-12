Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: sm_HHS_Group_Calculator
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

    Public Class [sm_HHS_Group_Calculator]
    
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

    Private this as sm_HHS_Group_Calculator = me

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
    
          Public Property [Component_Item_Keys]() As Long
      Get
      Return Properties("Component_Item_Keys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Component_Item_Keys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Group_Key]() As String
      Get
      Return Properties("Group_Key").Value
      End Get
      Set(ByVal Value As String)
      Properties("Group_Key").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Hanger_Item_Keys]() As Long
      Get
      Return Properties("Hanger_Item_Keys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Hanger_Item_Keys").CalculatedValue = Value
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
    
          Public Property [Seismic_Requirement]() As String
      Get
      Return Properties("Seismic_Requirement").Value
      End Get
      Set(ByVal Value As String)
      Properties("Seismic_Requirement").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Steel_Type_Code]() As String
      Get
      Return Properties("Steel_Type_Code").Value
      End Get
      Set(ByVal Value As String)
      Properties("Steel_Type_Code").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Total_Hanger_QTY]() As Long
      Get
      Return Properties("Total_Hanger_QTY").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Total_Hanger_QTY").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Valid]() As Boolean
      Get
      Return Properties("Valid").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Valid").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Valid_Count]() As Long
      Get
      Return Properties("Valid_Count").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Valid_Count").CalculatedValue = Value
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
    
      Public ReadOnly Property [Component_Items]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Component_Items")
      End Get
      End Property
    
      Public ReadOnly Property [Hanger_Items]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Hanger_Items")
      End Get
      End Property
    
      Public ReadOnly Property [All_HHS_Items]() As Rulestream.Kernel.Connection
      Get
      Return Connections("All_HHS_Items")
      End Get
      End Property
    
      Public ReadOnly Property [My_HHS_Items]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_HHS_Items")
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
    InitPart("sm_HHS_Group_Calculator", <a><![CDATA[sm HHS Group Calculator]]></a>.Value, 340, "APCTMP01",  "N", "N", False, False, "In Development", "", "Individual Header Hanger Calculator Subscription Master", "", "", "",  "GLOBAL\H601424", "04/30/2025 20:25:14")
    AddProperty("2389", "Component_Item_Keys", <a><![CDATA[Component Item Keys]]></a>.Value, "DBLookup Keys for SubPart Components", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/29/2025 5:08:07 PM")
    AddProperty("2241", "Group_Key", <a><![CDATA[Group Key]]></a>.Value, "Steel Type Code Coming from ACAD / Excel Export", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 12:34:07 PM")
    AddProperty("2424", "Hanger_Item_Keys", <a><![CDATA[Hanger Item Keys]]></a>.Value, "DBLookup Keys for SubPart Hangers", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/30/2025 8:25:14 PM")
    AddProperty("2353", "Hanger_Spacing", <a><![CDATA[Hanger Spacing]]></a>.Value, "Hanger Spacing in Feet", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 5:37:26 PM")
    AddProperty("2324", "Is_Seismic", <a><![CDATA[Is Seismic]]></a>.Value, "Does this application require siesmic standards", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 6:21:50 PM")
    AddProperty("2337", "Seismic_Requirement", <a><![CDATA[Seismic Requirement]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 6:21:50 PM")
    AddProperty("2238", "Steel_Type_Code", <a><![CDATA[Steel Type Code]]></a>.Value, "Steel Type Code Coming from ACAD / Excel Export", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 12:35:15 PM")
    AddProperty("2303", "Total_Hanger_QTY", <a><![CDATA[Total Hanger QTY]]></a>.Value, "Total Hangers in this group", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 5:10:32 PM")
    AddProperty("2240", "Valid", <a><![CDATA[Valid]]></a>.Value, "Is this a valid Group Calculator", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 12:14:49 PM")
    AddProperty("2242", "Valid_Count", <a><![CDATA[Valid Count]]></a>.Value, "Count of Valid Items", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/23/2025 12:14:49 PM")
    AddProperty("2237", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/22/2025 5:24:27 PM")
    
      AddValidValue("Component_Item_Keys")
    
      AddValidValue("Hanger_Item_Keys")
    
      AddValidValue("Seismic_Requirement")
    
      oSubpart = AddSubpart(205,"Component_Items", <a><![CDATA[Component Items]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM")
      
        oSubpart.AddVPF (353, "HHS_Component_Item", "HHS Component Item")
      
      oSubpart = AddSubpart(219,"Hanger_Items", <a><![CDATA[Hanger Items]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "4/28/2025 4:40:16 PM")
      
        oSubpart.AddVPF (356, "HHS_Hanger_Item", "HHS_Hanger_Item")
      
      oConnection = AddConnection("All_HHS_Items", <a><![CDATA[All HHS Items]]></a>.Value, "ALL HHS Items", "60", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "4/23/2025 5:10:32 PM")
      
        oConnection.AddVPF(335, "HHS_DWGXLSX_Import_Line")
      
      oConnection = AddConnection("My_HHS_Items", <a><![CDATA[My HHS Items]]></a>.Value, "HHS Items Specific To Me", "89", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "4/28/2025 4:40:16 PM")
      
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
          InitProperty("Component_Item_Keys", "2035", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/29/2025 5:08:07 PM", "DBLookup Keys for SubPart Components", "In Development",  0,3344)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Group_Key", "1901", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 12:34:07 PM", "Steel Type Code Coming from ACAD / Excel Export", "In Development",  0,2658)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hanger_Item_Keys", "2069", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/30/2025 8:25:14 PM", "DBLookup Keys for SubPart Hangers", "In Development",  0,3215)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Hanger_Spacing", "2001", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 5:37:26 PM", "Hanger Spacing in Feet", "In Development",  0,2780)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Seismic", "1972", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 6:21:50 PM", "Does this application require siesmic standards", "In Development",  0,2738)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Seismic_Requirement", "1985", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 6:21:50 PM", "", "In Development",  0,2751)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Steel_Type_Code", "1898", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 12:33:55 PM", "Steel Type Code Coming from ACAD / Excel Export", "In Development",  0,2645)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Total_Hanger_QTY", "1951", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 5:10:32 PM", "Total Hangers in this group", "In Development",  0,2710)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid", "1900", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 12:14:49 PM", "Is this a valid Group Calculator", "In Development",  0,2551)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid_Count", "1902", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/23/2025 12:14:49 PM", "Count of Valid Items", "In Development",  0,2555)
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
          
        InitValidValue("Component_Item_Keys_ValidValues", "2035", "-1", 3357)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Hanger_Item_Keys_ValidValues", "2069", "-1", 3426)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Seismic_Requirement_ValidValues", "1985", "-1", 2764)
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
          
        InitSubpart("Component_Items", 143, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/25/2025 11:46:14 AM", "", "In Development", "Y",0,365,419)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Hanger_Items", 157, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/28/2025 4:40:16 PM", "", "In Development", "Y",0,432,460)
        
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
          
        InitConnection("All_HHS_Items", "40", "N","N", "N", 0, "-1", "", "GLOBAL\H601424", "4/23/2025 5:10:32 PM", "ALL HHS Items", "In Development", "Y",63)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_HHS_Items", "69", "N","N", "N", 0, "-1", "", "GLOBAL\H601424", "4/28/2025 4:40:16 PM", "HHS Items Specific To Me", "In Development", "Y",103)
        
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
      Public Function Formula_All_HHS_Items_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:40; TYPE:PF
        Result = Me.Parent.My_HHS_Items
        '   END FORMULA; CON ID:40; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_All_HHS_Items_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_HHS_Items_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:69; TYPE:PF
        Result = New RSCollection()

Const InputBlockType As String = "Block_Type"
'Const InputDropLength As String = "Drop_Length"
For Each p As part In Me.Parent.My_HHS_Items
	If p.properties(InputBlockType).DisplayValue = Me.Steel_Type_Code  Then
		Result.add(p)	
	End If
Next P
        '   END FORMULA; CON ID:69; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_My_HHS_Items_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Component_Item_Keys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Component_Item_Keys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2035; TYPE:PF
      Result = 0
If Me.Valid Then
	Result = Me.ValidValues("Component_Item_Keys").Count
End If
      '   END FORMULA; PROP ID:2035; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Component_Item_Keys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Group_Key() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Group_Key").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1901; TYPE:PF
      Result = Trim(Me.Parent.ValidValues("Group_Keys")(Me.subpartid-1))
      '   END FORMULA; PROP ID:1901; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Group_Key", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Hanger_Item_Keys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hanger_Item_Keys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2069; TYPE:PF
      Result = 0
If Me.Valid Then
	Result = Me.ValidValues("Hanger_Item_Keys").Count
End If
      '   END FORMULA; PROP ID:2069; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Hanger_Item_Keys", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2001; TYPE:PF
      result = Me.Parent.Hanger_Spacing
      '   END FORMULA; PROP ID:2001; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Hanger_Spacing", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1972; TYPE:PF
      result = Not (Me.Seismic_Requirement="No")
      '   END FORMULA; PROP ID:1972; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Is_Seismic", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1985; TYPE:PF
      Result = Me.Parent.Seismic_Requirement
      '   END FORMULA; PROP ID:1985; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Seismic_Requirement", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Steel_Type_Code() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Steel_Type_Code").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1898; TYPE:PF
      Result = Trim(Me.Group_Key)
      '   END FORMULA; PROP ID:1898; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Steel_Type_Code", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Total_Hanger_QTY() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Total_Hanger_QTY").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1951; TYPE:PF
      Result = 0
For Each p As part In My_HHS_Items.Parts
	Result = Result + p.Properties("Qty").Value
Next p
      '   END FORMULA; PROP ID:1951; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Total_Hanger_QTY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Valid() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valid").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1900; TYPE:PF
      result = (Me.Valid_Count > 0)
      '   END FORMULA; PROP ID:1900; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Valid", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Valid_Count() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valid_Count").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1902; TYPE:PF
      result = me.My_HHS_Items.Quantity
      '   END FORMULA; PROP ID:1902; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Valid_Count", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Item_Keys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Group_Key_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Item_Keys_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Seismic_Requirement_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Steel_Type_Code_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Total_Hanger_QTY_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_Count_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Item_Keys_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Group_Key_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Item_Keys_USERCHANGE() as Boolean
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
      Public Function Formula_Seismic_Requirement_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Steel_Type_Code_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Total_Hanger_QTY_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_Count_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Item_Keys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Component_Item_Keys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2035; TYPE:VV
      Result = Nothing
If Me.Valid Then
	If Me.Is_Seismic = False Then
		Result = MakeValidValueKeyFromDatabase("[vw_HHS_Component_Items]", "[DBID]", "[DBID]", "WHERE [Hanger_Type] = " & FormatCriteria(Me.Steel_Type_Code) & _
    	" AND [Section] NOT LIKE (" & FormatCriteria("SH%" , False) & ") AND [Section] Not in ('SDD','SSA') Order By [Sort_Order_1]")
	Else
		Result = MakeValidValueKeyFromDatabase("[vw_HHS_Component_Items]", "[DBID]", "[DBID]", "WHERE [Hanger_Type] = " & FormatCriteria(Me.Steel_Type_Code) & _
    	" AND [Section] NOT LIKE (" & FormatCriteria("SH%" , False) & ") Order By [Sort_Order_1]")
	End If
End If
      '   END FORMULA; PROP ID:2035; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Component_Item_Keys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Item_Keys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Hanger_Item_Keys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2069; TYPE:VV
      Result = Nothing

Dim DropLens As String = ""
For Each p As part In Me.My_HHS_Items.Parts
	If Droplens.Length > 0  Then DropLens = DropLens & ","
		
	Droplens = Droplens & P.Properties("Drop_Length").Value
Next p	

If Me.Valid Then
	Result = MakeValidValueKeyFromDatabase("[vw_HHS_Component_Items]", "[DBID]", "[DBID]", "WHERE [Hanger_Type] = " & FormatCriteria(Me.Steel_Type_Code) & " AND [Section] LIKE (" & FormatCriteria("SH%" , False) &  ") AND [Drop_Length] in (" & DropLens & ")  ORDER BY [Sort_Order_1]")
End If
      '   END FORMULA; PROP ID:2069; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Hanger_Item_Keys_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1985; TYPE:VV
      result = MakeValidValues(Array("(0.0-0.5)","(0.5-1.0)","(1.0-1.9)","No"))
      '   END FORMULA; PROP ID:1985; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Seismic_Requirement_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Items_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:143; TYPE:PN
      
      '   END FORMULA; SUB ID:143; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Component_Items_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Items_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Component_Items").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:143; TYPE:QF
      Result = Me.Component_Item_Keys
      '   END FORMULA; SUB ID:143; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Component_Items_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Component_Items_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Component_Items").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:143; TYPE:OP
      result = "HHS_Component_Item"
      '   END FORMULA; SUB ID:143; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Component_Items_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Items_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:157; TYPE:PN
      
      '   END FORMULA; SUB ID:157; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Hanger_Items_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Items_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Hanger_Items").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:157; TYPE:QF
      Result = My_HHS_Items.Count
      '   END FORMULA; SUB ID:157; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Hanger_Items_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Hanger_Items_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Hanger_Items").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:157; TYPE:OP
      result = "HHS_Hanger_Item"
      '   END FORMULA; SUB ID:157; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " sm_HHS_Group_Calculator.Formula_Hanger_Items_OPTIMALPARTFAMILY", ex.Message)
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

  