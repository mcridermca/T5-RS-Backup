Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Math
Imports System.ComponentModel
Imports RuleStream.Kernel
Imports System.Runtime.Remoting.Lifetime
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports Aspose.Cells
Imports System.Reflection
Imports RuleStream
Imports Microsoft.Data.SqlClient

Module Common
    '*************************************************************************
    '*                                                                       *
    '*   This source code, together with any object or execution files       *
    '*   generated herefrom (whether by compiling, translating, or linking   *
    '*   this source file to any header files, resource files, library       *
    '*   files, other source files or object files) are confidential and     *
    '*   proprietary to Siemems PLM Software.  No person may sell,           *
    '*   offer for sale, copy, use, compile, translate or link this source   *
    '*   file without the written prior approval of Siemems PLM Software.    *
    '*                                                                       *
    '*   Copyright 2005 - 2010, All Rights Reserved                          *
    '*                                                                       *
    '*************************************************************************

    'Variables
    'Public gClientMgr As Object
    <ThreadStatic()> Friend g_ObjectManager As RuleStream.Kernel.ObjectManager
    <ThreadStatic()> Friend g_DocAccess As RuleStream.DocumentManager.IRsDocumentManagerRunTime 'RuleStream.IDocumentAccess
    <ThreadStatic()> Friend g_rsUser As RuleStream.UserProfile.RuleStreamUser
    <ThreadStatic()> Friend g_ComponentData As RuleStream.DataService.ComponentData
    <ThreadStatic()> Friend g_ProjectData As RuleStream.DataService.ProjectData
    <ThreadStatic()> Friend g_RulesData As RuleStream.DataService.RulesData
    <ThreadStatic()> Friend g_DontTrackDependencies As Boolean
    <ThreadStatic()> Friend g_RsEngineer As IRsEngineer

    'Constants
    Public Enum swMateType_e
        swMateCOINCIDENT = 0
        swMateCONCENTRIC = 1
        swMatePERPENDICULAR = 2
        swMatePARALLEL = 3
        swMateTANGENT = 4
        swMateDISTANCE = 5
        swMateANGLE = 6
        swMateUNKNOWN = 7
        swMateSYMMETRIC = 8
        swMateCAMFOLLOWER = 9
    End Enum

    Public Enum swMateAlign_e
        ' Use the three corrected enum's below
        swMateAlignALIGNED = 0
        swMateAlignANTI_ALIGNED = 1
        swMateAlignCLOSEST = 2
        ' Old incorrect enum's retained for backwards compatability
        ' Avoid using the three incorrect enum's below if possible
        swAlignNONE = 0
        swAlignSAME = 1
        swAlignAGAINST = 2
    End Enum

    Public Enum severity
        VIA_ERROR = 160
        VIA_WARNING = 170
    End Enum

    Public Const PI As Double = 3.14159265358979
    Public Const MaxExcelFileLength As Integer = 100000

    'Basic 16 colors used to color the parts in SolidWorks
    Public Const swColorNone As String = "-1, -1, -1"
    Public Const swColorBlack As String = "0, 0, 0"
    Public Const swColorWhite As String = "1, 1, 1"
    Public Const swColorDarkGray As String = ".5, .5, .5"
    Public Const swColorLightGray As String = ".75, .75, .75"
    Public Const swColorRed As String = "1, 0, 0"
    Public Const swColorDarkRed As String = ".5, 0, 0"
    Public Const swColorYellow As String = "1, 1, 0"
    Public Const swColorDarkYellow As String = ".5, .5, 0"
    Public Const swColorGreen As String = "0, 1, 0"
    Public Const swColorDarkGreen As String = "0, .5, 0"
    Public Const swColorCyan As String = "0, .5, .5"
    Public Const swColorBlue As String = "0, 0, 1"
    Public Const swColorDarkBlue As String = "0, 0, .5"
    Public Const swColorMagenta As String = "1, 0, 1"
    Public Const swColorDarkMagenta As String = ".5, 0, .5"

    'Constants for Process Step Status
    Public Const STATUS_ENABLED As Short = 0
    Public Const STATUS_READONLY As Short = 1
    Public Const STATUS_COMPLETED As Short = 2
    Public Const STATUS_ATTENTION As Short = 3
    Public Const STATUS_HIDDEN As Short = 4
    Public Const STATUS_DISABLED As Short = 5

    ' Status Formula Result Constants
    ' -------------------------------
    Public Const VIA_HIDDEN As Long = 100
    Public Const VIA_DISABLED As Long = 110
    Public Const VIA_CLOAKED As Long = 115
    Public Const VIA_READONLY As Long = 120
    Public Const VIA_ENABLED As Long = 130
    Public Const VIA_COMPLETED As Long = 140
    Public Const VIA_INFO As Long = 150
    Public Const VIA_WARNING As Long = 160
    Public Const VIA_ERROR As Long = 170
    Public Const VIA_FATAL As Long = 180

    'Constants for Disable Visisblity of Property.
    Public Const VIA_VISIBLE As Integer = 0
    Public Const VIA_VALUEHIDDEN As Integer = 1
    Public Const VIA_CONTROLHIDDEN As Integer = 2

    'Constants for Custom Check.
    'Public Const VIA_ERROR As Integer = 160
    'Public Const VIA_WARNING As Integer = 170

    Public Function SWMgr() As Object
        Return g_ObjectManager.SystemManager("SolidWorks")
    End Function
    Public Function NXMgr() As Object
        Return g_ObjectManager.SystemManager("NX")
    End Function
    Public Function DWGMgr() As Object
        Return g_ObjectManager.SystemManager("DWG")
    End Function
    Public Function ProEMgr() As Object
        Return g_ObjectManager.SystemManager("Creo")
    End Function
    Public Function SEMgr() As Object
        'B-04146 : "Solid Edge" systemname name corrected to ensure consistency
        Return g_ObjectManager.SystemManager("Solid Edge")
    End Function

    <Browsable(False)> Public Function SWAddMate(ByVal oPart1 As Object, ByVal strFeatureType1 As String, ByVal strFeatureName1 As String, ByVal oPart2 As Object, ByVal strFeatureType2 As String, ByVal strFeatureName2 As String, ByVal lngMateType As Integer, ByVal lngAlignType As Integer, ByVal blnFlip As Boolean, ByVal dblDist As Double, ByVal dblAngle As Double) As String
        'SLATED FOR OBSOLESCENCE IN 6.3

        If SWMgr() Is Nothing Then
            Return ""
        Else
            Return SWMgr.AddMate(oPart1, strFeatureType1, strFeatureName1, oPart2, strFeatureType2, strFeatureName2, lngMateType, lngAlignType, blnFlip, dblDist, dblAngle)
        End If

    End Function

    <Browsable(False)> Public Function SWSelectRef(ByVal oPart As RuleStream.Kernel.Part, ByVal strFeatureType As String, ByVal strFeatureName As String, ByVal intMark As Short) As String
        'SLATED FOR OBSOLESCENCE IN 6.3

        If SWMgr() Is Nothing Then
            Return ""
        Else
            Return SWMgr.SelectRef(oPart, strFeatureType, strFeatureName, intMark)
        End If

    End Function

    <Browsable(False)> Public Function SWPosition(ByVal oPart As RuleStream.Kernel.Part, ByVal x As Double, ByVal Y As Double, ByVal z As Double) As String
        'SLATED FOR OBSOLESCENCE IN 6.3

        If SWMgr() Is Nothing Then
            Return ""
        Else
            Return SWMgr.Position(oPart, x, Y, z)
        End If

    End Function

    <Browsable(False)> Public Function AddGenericTable(ByVal SystemManagerName As String, ByVal ParamArray args As Object()) As String

        If Not NXMgr() Is Nothing Then
            Return NXMgr.AddGenericTable(args)
        ElseIf Not DWGMgr() Is Nothing Then
            Return DWGMgr.AddGenericTable(args)
        ElseIf Not ProEMgr() Is Nothing Then
            Return ProEMgr.AddGenericTable(args)
        Else
            Return Nothing
        End If


    End Function

    <Browsable(False)> Public Function RS_CAD_Position(ByVal SystemManagerName As String, ByVal ParamArray args As Object()) As Object

        Dim mgr As Object = g_ObjectManager.SystemManager(SystemManagerName)
        If Not mgr Is Nothing Then
            Return mgr.ApplyFixposition(args)
        Else
            If NXMgr() Is Nothing Then
                If SWMgr() Is Nothing Then
                    If Not SEMgr() Is Nothing Then
                        Return (SEMgr.ApplyFixposition(args))
                    Else
                        Return Nothing
                    End If
                Else
                    Return SWMgr.ApplyFixposition(args)
                End If
            Else
                Return NXMgr.ApplyFixposition(args)
            End If
        End If
    End Function
    'Change added as per communication with Hemant.This is required as new approach 
    'is followed to get geom value.
    <Browsable(False)> Public Function SWGetValue(ByRef oPart As RuleStream.Kernel.Part, ByVal name As String) As Object
        'OBSOLETE - NEW FORMULAS DO NOT USE THIS

        'If SWMgr() Is Nothing Then
        '    Return Nothing
        'Else
        '    Return SWMgr.GetValue(oPart, name)
        'End If
        Return Nothing
    End Function


    'This is intended to return the manager object from the ObjectManager using its name (ex. "Pro/ENGINEER").
    Public Function Manager(ByVal SystemManagerName As String) As Object ' RuleStream.Kernel.IRSRuntimeManager
        Return g_ObjectManager.SystemManager(SystemManagerName)
    End Function

    'Adding two following functions for new shortcuts implementation
    Public Function RsGetInputSubpartOrConnection(ByRef PF As Part, ByVal SubPartOrConnectionName As String) As Object
        If PF.Properties.ContainsKey("_rsTestMode") Then
            g_ObjectManager.logger.DebugFormat("RsGetInputSubpartOrConnection:_rsTestMode exists.")
            If Not PF.Properties("_rsTestMode").Value Then
                g_ObjectManager.logger.DebugFormat("RsGetInputSubpartOrConnection:_rsTestMode set to False.")
                If PF.Parent IsNot Nothing Then
                    g_ObjectManager.logger.DebugFormat(String.Format("RsGetInputSubpartOrConnection:""{0}"" exists as parent to PF:""{1}"".", PF.Parent.Name, PF.Name))
                    If PF.Parent.SubParts.ContainsKey(SubPartOrConnectionName) Then
                        g_ObjectManager.logger.DebugFormat(String.Format("RsGetInputSubpartOrConnection:Subpart ""{0}"" exists on PF parent, returning the same subpart.", SubPartOrConnectionName))
                        RsGetInputSubpartOrConnection = PF.Parent.SubParts(1)
                    ElseIf PF.Parent.Connections.Containskey(SubPartOrConnectionName) Then
                        g_ObjectManager.logger.DebugFormat(String.Format("RsGetInputSubpartOrConnection:Connection exists, returning connection with name ""{0}"".", SubPartOrConnectionName))
                        RsGetInputSubpartOrConnection = PF.Parent.Connections(SubPartOrConnectionName)
                    Else
                        g_ObjectManager.LogError("RsGetInputSubpartOrConnection", String.Format("No subpart or connection with name ""{0}"" exists, returning nothing.", SubPartOrConnectionName))
                        RsGetInputSubpartOrConnection = Nothing
                    End If
                Else
                    g_ObjectManager.LogError("RsGetInputSubpartOrConnection", String.Format("No parent exists on property Part ""{0}"", returning nothing.", PF.Name))
                    RsGetInputSubpartOrConnection = Nothing
                End If
            Else
                g_ObjectManager.logger.DebugFormat("RsGetInputSubpartOrConnection:'_rsTestMode' property set to True, returning nothing.")
                RsGetInputSubpartOrConnection = Nothing
            End If
        Else
            g_ObjectManager.LogError("RsGetInputSubpartOrConnection", String.Format("'_rsTestMode' property doesn't exist, returning nothing."))
            RsGetInputSubpartOrConnection = Nothing
        End If
    End Function

    Public Function RsGetInputProperty(ByRef PF As Part, ByRef PropName As String, ByRef OneToOneConnectionName As String, ByRef TestValue As Object) As Object
        If PF.Properties.ContainsKey("_rsTestMode") Then
            g_ObjectManager.logger.DebugFormat("RsGetInputProperty: _rsTestMode exists.")
            If Not PF.Properties("_rsTestMode").Value Then
                g_ObjectManager.logger.DebugFormat("RsGetInputProperty: _rsTestMode set to False.")
                If PF.Parent IsNot Nothing Then
                    g_ObjectManager.logger.DebugFormat(String.Format("RsGetInputProperty: ""{0}"" exists as parent on property to Part:""{1}"".", PF.Parent.Name, PF.Name))
                    If PF.Parent.Connections.Containskey(OneToOneConnectionName) Then
                        g_ObjectManager.logger.DebugFormat(String.Format("RsGetInputProperty: ""{0}"" exists as connection to parent Part:""{1}"" on property part: ""{2}"".", OneToOneConnectionName, PF.Parent.Name, PF.Name))
                        If IsConnected(PF.Parent.Connections(OneToOneConnectionName)) Then
                            If PF.Parent.Connections(OneToOneConnectionName)(1).Properties(PropName) IsNot Nothing Then
                                RsGetInputProperty = PF.Parent.Connections(OneToOneConnectionName)(1).Properties(PropName).Value
                            Else
                                g_ObjectManager.LogError("RsGetInputProperty", String.Format("PF - ""{0}""No property with name ""{1}"" exists on the connection - ""{2}"", returning Nothing.", PF.Name, PropName, OneToOneConnectionName))
                                RsGetInputProperty = Nothing
                            End If
                        Else
                            g_ObjectManager.LogError("RsGetInputProperty", String.Format("Connection with name ""{0}"" exists but is not connected, returning Nothing.", OneToOneConnectionName))
                            RsGetInputProperty = Nothing
                        End If
                    Else
                        g_ObjectManager.LogError("RsGetInputProperty", String.Format("No Connection with name ""{0}"" exists, returning Nothing.", OneToOneConnectionName))
                        RsGetInputProperty = Nothing
                    End If
                Else
                    g_ObjectManager.LogError("RsGetInputProperty", String.Format("No parent exists on property Part ""{0}"", returning nothing.", PF.Name))
                    RsGetInputProperty = Nothing
                End If
            Else
                g_ObjectManager.logger.DebugFormat("RsGetInputConnection:'_rsTestMode' property set to True, returning the TestValue.")
                RsGetInputProperty = TestValue
            End If
        Else
            g_ObjectManager.LogError("RsGetInputConnection", String.Format("'_rsTestMode' property doesn't exist, returning Nothing."))
            RsGetInputProperty = Nothing
        End If
    End Function

    ''' <summary>
    ''' This function finds the runtime system manager with the given name and calls the .apply(args) method
    ''' for that object.  
    ''' </summary>
    ''' <remarks> The args is passed to the manager as an array to the apply method that can be
    ''' parsed by the manager for deciding how to handle the call.
    ''' example: ApplyManager("Pro/ENGINEER", "Align", me, "Plane", "Front", me.parent, "Plane", "Front", 0)
    ''' </remarks>
    <Browsable(False)> Public Function ApplyManager(ByVal SystemManagerName As String, ByVal ParamArray args As Object()) As Object
        'TODO: Provide a method name in the argument list and call that function instead "Apply".

        Dim mgr As Object = g_ObjectManager.SystemManager(SystemManagerName)
        Dim result As Object = Nothing

        If (mgr IsNot Nothing) Then
            Try
                'Check for the method's existance before calling to avoid MissingMemberException.
                result = mgr.Apply(args)
            Catch exception As MissingMemberException
                'If the method is not found swallow the exception.
                result = String.Empty
            End Try
        End If

        Return result
    End Function


    '''This function is used by Solidworks integration to insert library feature.
    '''arguments passed are array like shown below,
    '''InsertLibFeature("Solidworks",me.Parent,"ref1","Plane","Front Plane","ref2","Plane","Front Plane","ref3","Plane","Front Plane")

    <Browsable(False)> Public Function InsertLibFeature(ByVal SystemManagerName As String, ByVal ParamArray args As Object()) As Object
        'TODO: Provide a method name in the argument list and call that function.

        Dim mgr As Object = g_ObjectManager.SystemManager(SystemManagerName)
        Dim result As Object = Nothing

        If (mgr IsNot Nothing) Then
            Try
                'Check for the method's existance before calling to avoid MissingMemberException.
                result = mgr.InsertLibFeature(args)
            Catch exception As MissingMemberException
                'If the method is not found swallow the exception.
                result = String.Empty
            End Try
        End If

        Return result
    End Function

    ''' <summary>
    ''' This function returns the current client Name
    ''' </summary>
    Public Function ClientName() As String
        Return g_ObjectManager.RSEngineer.RsDesigner.ClientName
    End Function

    ''' <summary>
    ''' This function returns the current client Type
    ''' </summary>
    Public Function ClientType() As String
        Return g_ObjectManager.RSEngineer.RsDesigner.ClientType
    End Function

    ''' <summary>
    ''' This function finds the runtime system manager with the given name and calls the .InsertUDF(args) method
    ''' for that object.  
    ''' </summary>
    ''' <remarks> The args is passed to the manager as an array to the InsertUDF method that can be
    ''' parsed by the manager for deciding how to handle the call.
    ''' example: InsertUDF("NX",me,me.Parent,"SingleUDFDef","OriginPoint","Point","POINT(5)")
    ''' </remarks>
    <Browsable(False)> Public Function InsertUDF(ByVal SystemManagerName As String, ByVal ParamArray args As Object()) As Object
        Dim mgr As Object = g_ObjectManager.SystemManager(SystemManagerName)
        Dim result As Object = Nothing

        If (mgr IsNot Nothing) Then
            Try
                'Check for the method's existance before calling to avoid MissingMemberException.
                result = mgr.InsertUDF(args)
            Catch exception As MissingMemberException
                'If the method is not found swallow the exception.
                result = String.Empty
            End Try
        End If

        Return result
    End Function

    Public Function Selected2DParts() As Rulestream.Kernel.rscollection
        Dim ocol As New Rulestream.Kernel.rscollection
        Dim mgr As Object = g_ObjectManager.SystemManager(RuleStream.Specification.enuSpecSystem.DIAGRAM2D)

        If Not mgr Is Nothing Then
            ocol = mgr.SelectedParts
        End If

        Return ocol

    End Function


    Public Function ConvertToCollection(ByVal obj As Object) As Rulestream.Kernel.rsCollection
        Dim oCol As New Rulestream.Kernel.rsCollection
        Dim oPart As Object

        If Not obj Is Nothing Then
            If TypeOf obj Is RuleStream.Kernel.Part Then
                oCol.Add(obj, obj.ObjId)
                Return oCol

            ElseIf TypeOf obj Is Collection _
                      Or TypeOf obj Is RuleStream.Kernel.Subpart _
                      Or TypeOf obj Is RuleStream.Kernel.Connection _
                      Or TypeOf obj Is ArrayList Then

                For Each oPart In obj
                    If Not oCol.ContainsKey(oPart.ObjId) Then
                        oCol.Add(oPart, oPart.ObjId)
                    End If
                Next

                Return oCol

            Else
                Return obj

            End If

        Else
            Return oCol

        End If
    End Function

    Public Function ConvertToValidValues(ByVal obj As Object) As Rulestream.Kernel.ValidValues
        Dim oCol As New Rulestream.Kernel.ValidValues
        Dim oPart As Object

        If Not obj Is Nothing Then

            If TypeOf obj Is RuleStream.Kernel.Part Then
                oCol.Add(obj, obj.ObjId)
                Return oCol
            ElseIf TypeOf obj Is Collection _
                      Or TypeOf obj Is RuleStream.Kernel.rsCollection _
                      Or TypeOf obj Is RuleStream.Kernel.Subpart _
                      Or TypeOf obj Is RuleStream.Kernel.Connection _
                      Or TypeOf obj Is ArrayList Then

                For Each oPart In obj
                    If Not oCol.ContainsValue(oPart.ObjId) Then
                        oCol.Add(oPart)
                    End If
                Next

                Return oCol
            Else
                Return obj
            End If
        Else
            Return oCol
        End If
    End Function

    Public Function GetPatternNameByID(ByRef objPart As Object, ByVal strName As String, ByVal lngInstance As Integer) As String
        GetPatternNameByID = objPart.GeomMgr.GetPatternNameByID(objPart, strName, lngInstance)
    End Function

    '	Public Function ClientMgr() As Object
    '		Dim rulestream As Object

    '#If Compiled Then
    '		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression Compiled did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
    '		Set ClientMgr = gClientMgr
    '#Else
    '		'UPGRADE_WARNING: Couldn't resolve default property of object rulestream.application. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
    '        ClientMgr = rulestream.application
    '#End If

    '	End Function
    Public Function UnionCollections(ByVal col1 As Collection, ByVal col2 As Rulestream.Kernel.rsCollection) As Collection
        'Purpose:       Union two collections.  Combines two collections without regard for the keys.
        '               Assumes their are not identical elements in the two collections
        'Parameters:    col1 - First collection.
        '               col2 - Second collection.
        'Returns:       New unioned collection.

        Dim colNew As Collection
        Dim varItem As Object

        colNew = New Collection

        If col1.Count() > 0 Then
            For Each varItem In col1
                colNew.Add(varItem)
            Next varItem
        End If

        If col2.Count() > 0 Then
            For Each varItem In col2
                colNew.Add(varItem)
            Next varItem
        End If

        UnionCollections = colNew
    End Function
    Public Function BaseValue(ByVal dblValue As Double, ByVal strUnits As String) As Double
        'Purpose:       Converts the input value from the unit specified to the systems base unit system.
        'Parameters:    dblValue - a numeric value of type double. ex "75.987"
        '               strUnits - a string specifying the unit type of this value. ex "ft"
        'Returns:       a numeric value in the system base units.

        Dim dr As DataRow

        Try
            dr = g_RulesData.GetBaseValue(strUnits).Tables(0).Rows(0)

            If Not IsNothing(dr) Then
                If g_ObjectManager.Units = "M" Then
                    Return (dblValue + CDbl(dr.Item("Metric_Offset"))) * CDbl(dr.Item("Metric_Multiplier"))
                ElseIf g_ObjectManager.Units = "E" Then
                    Return (dblValue + CDbl(dr.Item("Standard_Offset"))) * CDbl(dr.Item("Standard_Multiplier"))
                Else
                    Return dblValue
                End If
            Else
                g_ObjectManager.LogError("BaseValue", String.Format("Unit abbreviation ""{0}"" not found.", strUnits), MsgBoxStyle.Critical)
                Return dblValue
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("BaseValue", String.Format("Unit abbreviation ""{0}"" not found.", strUnits), MsgBoxStyle.Critical)
            Return dblValue
        End Try
    End Function

    Public Function GlobalMax(ByVal strPropName As String, ByVal ParamArray varPartFamilies() As String) As Object
        Dim arrPartFamilies() As Object = Nothing
        Dim i As Integer

        If UBound(varPartFamilies) > -1 Then
            ReDim arrPartFamilies(UBound(varPartFamilies))
            For i = LBound(varPartFamilies) To UBound(varPartFamilies)
                arrPartFamilies(i) = varPartFamilies(i)
            Next
        End If

        GlobalMax = g_ObjectManager.GlobalMax(strPropName, arrPartFamilies)
    End Function

    Public Function GlobalMin(ByVal strPropName As String, ByVal ParamArray varPartFamilies() As String) As Object
        Dim arrPartFamilies() As Object = Nothing
        Dim i As Integer

        If UBound(varPartFamilies) > -1 Then
            ReDim arrPartFamilies(UBound(varPartFamilies))
            For i = LBound(varPartFamilies) To UBound(varPartFamilies)
                arrPartFamilies(i) = varPartFamilies(i)
            Next
        End If

        GlobalMin = g_ObjectManager.GlobalMin(strPropName, arrPartFamilies)
    End Function

    Public Function GlobalSum(ByVal strPropName As String, ByVal ParamArray varPartFamilies() As String) As Double

        Dim arrPartFamilies() As Object = Nothing
        Dim i As Integer

        If UBound(varPartFamilies) > -1 Then
            ReDim arrPartFamilies(UBound(varPartFamilies))
            For i = LBound(varPartFamilies) To UBound(varPartFamilies)
                arrPartFamilies(i) = varPartFamilies(i)
            Next
        End If

        GlobalSum = g_ObjectManager.GlobalSum(strPropName, arrPartFamilies)
    End Function

    Public Function GlobalCount(ByVal strPropName As String) As Integer
        GlobalCount = g_ObjectManager.GlobalCount(strPropName)
    End Function

    Public Function GlobalPartCount(ByVal strPartFamily As String) As Integer
        GlobalPartCount = g_ObjectManager.GlobalPartCount(strPartFamily)
    End Function

    Public Function GlobalPartNumberCount(ByVal strPartFamily As String, ByVal strPartNumber As String) As Integer
        GlobalPartNumberCount = g_ObjectManager.GlobalPartNumberCount(strPartFamily, strPartNumber)
    End Function

    ''' <summary>
    ''' Support a array of 2 types 
    ''' 1) If array containing values(objects) is inputed, its returned.
    ''' 2) If array containing list of Objects is inputed then - the lists the array contains are processed:
    '''    each list has format as (display value, tooltip, enabled flag, EnabledImage, DisplayOrder, AnotherColumn.
    '''    The display values from lists are collected whose Enabled flag is 'True' and returned as array.
    ''' </summary>
    ''' <param name="Values">array containing objects  or array containing list of Objects</param>
    ''' <returns>array</returns>
    Public Function Array(ByVal ParamArray Values As Object()) As Array
        Dim myList As New List(Of String)()

        For Each element As Object In Values
            If element.GetType() Is GetType(System.Collections.Generic.List(Of Object)) Then
                If element(2) Then 'if Enable flag is true, then only display the element. Enabled will be at 2nd index in list always
                    myList.Add(element(0)) '0th index has the display value
                End If
            Else
                Return Values
            End If
        Next

        'create array from list myList and return array
        Dim arrVals As String() = myList.ToArray()
        Return arrVals
    End Function


    ''' <summary>
    ''' Create a ValidValues object that has the actual values in it, not transformed into strings
    ''' </summary>
    ''' <param name="Values">An enumeration of the actual values that are valid</param>
    ''' <returns></returns>
    Public Function MakeValidValuesFromValues(ByVal Values As Object()) As RuleStream.Kernel.ValidValues
        Dim ValidVals As New RuleStream.Kernel.ValidValues

        For Each val As Object In Values
            ValidVals.Add(val)
        Next

        Return ValidVals
    End Function

    Public Function MakeValidValues(ByVal DisplayValue As Object()) As Rulestream.Kernel.ValidValues 'Hashtable
        'Purpose:       Returns a ValidValues object containing Rulestream.Kernel.ValidValues.
        'Parameters:    DisplayValue - An array of values. Array("red", "green", "blue")
        'Returns:       ValidValues object

        Dim ValidVals As New RuleStream.Kernel.ValidValues 'Hashtable
        Dim Value As String

        For i As Int32 = DisplayValue.GetLowerBound(0) To DisplayValue.GetUpperBound(0)
            Value = DisplayValue(i).ToString.Trim
            If Not ValidVals.ContainsValue(Value) Then
                ValidVals.Add(Value, Value)
            End If
        Next

        Return ValidVals

    End Function

    ''' <summary>
    ''' MakeValidValues that takes anything that implements IEnumerable
    ''' </summary>
    ''' <param name="Values">The list to be turned into VVs (that implements IEnumerable)</param>
    ''' <param name="sortOrder">The sort order [Optional] -1=Descending, 0=Given order [Default], 1=Ascending</param>
    ''' <param name="defaultValue">A value that should be put in either first or last in the list (like "PLEASE SELECT" [Optional]</param>
    ''' <param name="defaultPosition">The position of the default Value [Optional] "First" [Default] or "Last"</param>
    ''' <returns>ValidValues object containing Rulestream.Kernel.ValidValues.</returns>
    ''' <remarks></remarks>
    Public Function MakeValidValues(ByVal Values As Object, ByVal sortOrder As Integer, Optional ByVal defaultValue As String = Nothing, Optional ByVal defaultPosition As String = "First") As RuleStream.Kernel.ValidValues

        If Not TypeOf Values Is IEnumerable Then
            Throw New Exception("Common.vb:MakeValidValues(): You need to pass in an Object that implements IEnumerable")
        End If

        Dim ValidVals As New RuleStream.Kernel.ValidValues
        Dim ValueString As String = String.Empty
        Dim hasKeys As Boolean = False

        If defaultValue IsNot Nothing AndAlso defaultPosition.ToUpper = "FIRST" Then
            ValidVals.Add(defaultValue, defaultValue)
        End If

        If Not (sortOrder = 0) Then
            Dim sl As New SortedList
            Dim startIndex As Integer
            Dim endIndex As Integer
            Dim stepDir As Integer

            For Each Value As Object In Values
                If TypeOf Value Is String Then
                    ValueString = Value.Value.Trim
                Else
                    ValueString = Value.Value.ToString.Trim
                End If
                If Not sl.ContainsValue(ValueString) Then
                    sl.Add(ValueString, ValueString)
                End If
            Next

            If sortOrder < 0 Then
                startIndex = sl.Count - 1
                endIndex = 0
                stepDir = -1
            Else
                startIndex = 0
                endIndex = sl.Count - 1
                stepDir = 1
            End If

            For i As Integer = startIndex To endIndex Step stepDir
                ValidVals.Add(sl.GetByIndex(i), sl.GetByIndex(i))
            Next i
        Else    'no sorting required
            For Each Value As Object In Values
                If TypeOf Value Is String Then
                    ValueString = Value.Value.Trim
                Else
                    ValueString = Value.Value.ToString.Trim
                End If

                If Not ValidVals.ContainsValue(ValueString) Then
                    ValidVals.Add(ValueString, ValueString)
                End If
            Next
        End If

        If defaultValue IsNot Nothing AndAlso defaultPosition.ToUpper <> "FIRST" Then
            ValidVals.Add(defaultValue, defaultValue)
        End If

        Return ValidVals

    End Function

    Public Function MakeValidKeyValues(ByRef KeyValues As Object(), ByRef DisplayValues As Object()) As Rulestream.Kernel.ValidValues 'Hashtable
        'Purpose:       Returns a ValidValues object containing key values and display values.
        'Parameters:    KeyValues - An array of key values used by the system. Array(1, 2, 3)
        '               DisplayValues - An array of display values used by the user interface. Array("red", "green", "blue")
        'Returns:       ValidValues object (Nothing if the array lengths do not match)


        'First check that the arrays passed in are of equal size
        Dim KeyLength As Int32 = KeyValues.GetLength(0)
        Dim DisplayLength As Int32 = DisplayValues.GetLength(0)

        If KeyLength <> DisplayLength Then
            Throw New Exception("Common.vb:MakeValidKeyValues(): Number of Keys provided MUST MATCH the Number of Values provided")

        Else
            Dim ValidVals As New RuleStream.Kernel.ValidValues ' Hashtable

            For i As Int32 = KeyValues.GetLowerBound(0) To KeyValues.GetUpperBound(0)
                If Not ValidVals.ContainsValue(KeyValues(i).ToString) Then
                    ValidVals.Add(KeyValues(i).ToString, DisplayValues(i))
                End If
            Next i

            Return ValidVals

        End If
    End Function

    Public Function MakeValidValues(ByVal key As Object, ByVal Values As List(Of Object)) As RuleStream.Kernel.ValidValues
        Dim ValidVals As New RuleStream.Kernel.ValidValues
        ValidVals.Add(key, Values)
        Return ValidVals
    End Function
    Public Function MakeValidValues(ByVal Values As List(Of Object)) As RuleStream.Kernel.ValidValues
        Dim ValidVals As New RuleStream.Kernel.ValidValues
        ValidVals.Add(Values(0), Values)
        Return ValidVals
    End Function

    ''' <summary>
    ''' A chooser function that routes the MakeValidValuesFromExcel to the correct version, based upon the setting of the Extended parameter.
    ''' Loads the ValidValues For a Property from an Excel file located In MasterDocs.
    ''' </summary>
    ''' <param name="fileName">Excel File name (which is in MDocs)</param>
    ''' <param name="Extended">True - For thin client. False - For legacy workflow(RSE)</param>
    ''' <returns>Valid values collection</returns>
    Public Function MakeValidValuesFromExcel(ByVal fileName As String, ByVal Optional Extended As Boolean = True) As RuleStream.Kernel.ValidValues
        Dim ValidVals As New RuleStream.Kernel.ValidValues

        If (Extended = False) Then
            ValidVals = MakeValidValuesFromExcel_Legacy(fileName)
        Else
            ValidVals = MakeValidValuesFromExcel_Extended(fileName)
        End If

        Return ValidVals
    End Function

    ''' <summary>
    ''' Valid Values can be listed in an Excel file  having data in columns as Key, Value, Enabled, Display Index
    ''' If Enabled flag is 1, pick that DisplayValue else ignore. 
    ''' This is a legacy functionality for the RSE.
    ''' </summary>
    ''' <param name="fileName">Excel filename from Master Docs</param>
    ''' <returns>Valid Values</returns>
    Public Function MakeValidValuesFromExcel_Legacy(ByVal fileName As String) As RuleStream.Kernel.ValidValues

        Dim ValidVals As New RuleStream.Kernel.ValidValues
        Dim docManager As RuleStream.DocumentManager.IRsDocumentManager
        Dim docAttributes As RuleStream.Specification.RsDocumentAttributes
        Dim WipFile As String = Nothing
        Dim ExcelFile As FileInfo

        docManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)
        docAttributes = New RuleStream.Specification.RsDocumentAttributes(fileName)

        If docManager.GetMasterDocument(docAttributes, True) Then

            WipFile = Path.Combine(docManager.WorkingFolder, fileName)
            Dim exists As Boolean = docManager.DocumentExists(fileName, RuleStream.RuleStreamFolder.enuWorkingFolder)

            If (Not exists) Then
                ExcelFile = docManager.CurrentDocument.File.CopyTo(WipFile, True)
            Else
                ExcelFile = New FileInfo(WipFile)
            End If
            If ExcelFile.Length > MaxExcelFileLength Then
                g_ObjectManager.LogInfo("MakeValidValuesFromExcel_Legacy", "File Size is larger than 100K", Nothing, True)
            End If
        Else
            g_ObjectManager.LogInfo("MakeValidValuesFromExcel_Legacy", "File not found. File Name: " + fileName)
        End If

        Dim valueTuple As Tuple(Of String, String, Integer)
        Dim valueList As List(Of Tuple(Of String, String, Integer)) = New List(Of Tuple(Of String, String, Integer))

        Try
            Dim License As Aspose.Cells.License = New Aspose.Cells.License()
            License.SetLicense("Aspose.Cells.lic")
            Dim _workbook As Aspose.Cells.Workbook = Nothing
            _workbook = New Aspose.Cells.Workbook(WipFile)
            Dim _worksheet As Aspose.Cells.Worksheet = Nothing
            _worksheet = _workbook.Worksheets("RS VV")
            If _worksheet IsNot Nothing Then
                Dim cells As Aspose.Cells.Cells = _worksheet.Cells
                Dim rows As Aspose.Cells.RowCollection = cells.Rows()

                For Each row As Aspose.Cells.Row In rows
                    If (row.Index > 0 AndAlso row(1).Value <> Nothing) Then

                        Dim EnableStatus As Boolean = False
                        If row(2).Value IsNot Nothing Then
                            Boolean.TryParse(row(2).Value, EnableStatus)
                        End If
                        If EnableStatus Then
                            Dim key As String = String.Empty
                            If row(0).Value IsNot Nothing Then
                                key = row(0).Value.ToString()
                            End If
                            Dim DispalyValue As String = String.Empty
                            If row(1).Value IsNot Nothing Then
                                DispalyValue = row(1).Value
                            End If
                            If (row(3).Value <> Nothing) Then
                                Dim iVal As Integer = -1
                                Int32.TryParse(row(3).Value.ToString(), iVal)
                                valueTuple = New Tuple(Of String, String, Integer)(key, DispalyValue, iVal)
                            Else
                                valueTuple = New Tuple(Of String, String, Integer)(key, DispalyValue, 0)
                            End If
                            valueList.Add(valueTuple)
                        End If
                    End If
                Next

                'sort data in displayListSorted
                Dim displayListSorted As List(Of Tuple(Of String, String, Integer)) = valueList.OrderBy(Function(X) X.Item3).ToList()

                For Each vv As Tuple(Of String, String, Integer) In displayListSorted
                    If Not ValidVals.Contains(vv.Item1) Then
                        ValidVals.Add(vv.Item1, vv.Item2)
                    End If
                Next
            Else
                g_ObjectManager.LogInfo("MakeValidValuesFromExcel_Legacy", "Worksheets : RS VV is not found. File Name: " + fileName)
            End If

            ' Cleanup
            '_worksheet.Dispose()
            '_workbook.Dispose()

        Catch ex As Exception
            Throw New Exception("Common.vb:MakeValidValuesFromExcel(): Caught exception: " + ex.Message)
        End Try

        Return ValidVals
    End Function


    ''' <summary>
    ''' Valid Values can be listed in an Excel file having data in columns as Key, Value, Enabled, Display Index, Tooltip, Image,...AnotherColumn,FinalColumn
    ''' Pass all data along with all attributes(to thin client)
    ''' </summary>
    ''' <param name="fileName">Excel filename from Master Docs</param>
    ''' <returns>Valid Values</returns>
    Public Function MakeValidValuesFromExcel_Extended(ByVal fileName As String) As RuleStream.Kernel.ValidValues
        Dim ValidVals As New RuleStream.Kernel.ValidValues
        Dim docManager As RuleStream.DocumentManager.IRsDocumentManager
        Dim docAttributes As RuleStream.Specification.RsDocumentAttributes
        Dim WipFile As String = Nothing

        docManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)
        docAttributes = New RuleStream.Specification.RsDocumentAttributes(fileName)

        If docManager.GetMasterDocument(docAttributes, True) Then

            WipFile = Path.Combine(docManager.WorkingFolder, fileName)
            Dim exists As Boolean = docManager.DocumentExists(fileName, RuleStream.RuleStreamFolder.enuWorkingFolder)
            Dim ExcelFile As FileInfo
            If (Not exists) Then
                ExcelFile = docManager.CurrentDocument.File.CopyTo(WipFile, True)
            Else
                ExcelFile = New FileInfo(WipFile)
            End If
            If ExcelFile.Length > MaxExcelFileLength Then
                g_ObjectManager.LogInfo("MakeValidValuesFromExcel_Extended", "Excel File Size is larger than 100K", Nothing, True)
            End If
        Else
            g_ObjectManager.LogInfo("MakeValidValuesFromExcel_Extended", "File not found. File Name: " + fileName)
        End If

        Dim valueTuple As Tuple(Of String, String, Integer, String, String, String)
        Dim valueList As List(Of Tuple(Of String, String, Integer, String, String, String)) = New List(Of Tuple(Of String, String, Integer, String, String, String))

        Try
            Dim License As Aspose.Cells.License = New Aspose.Cells.License()
            License.SetLicense("Aspose.Cells.lic")
            Dim _workbook As Aspose.Cells.Workbook = Nothing
            _workbook = New Aspose.Cells.Workbook(WipFile)
            Dim _worksheet As Aspose.Cells.Worksheet = Nothing
            _worksheet = _workbook.Worksheets("RS VV")
            If _worksheet IsNot Nothing Then
                Dim cells As Aspose.Cells.Cells = _worksheet.Cells
                Dim rows As Aspose.Cells.RowCollection = cells.Rows()

                For Each row As Aspose.Cells.Row In rows
                    If row.Index > 0 Then
                        If (Not row(0).Value Is Nothing AndAlso Not row(0).Value.Equals(String.Empty)) Then
                            Dim iVal As Integer = -1
                            Int32.TryParse(row(3).Value.ToString(), iVal)
                            Dim toolTipValue As String = String.Empty
                            If row(4).Value IsNot Nothing Then
                                toolTipValue = row(4).Value.ToString()
                            End If
                            Dim enableStatus As String = "FALSE"
                            If row(2).Value IsNot Nothing Then
                                Boolean.TryParse(row(2).Value.ToString(), enableStatus)
                            End If

                            Dim ImagePath As String = String.Empty
                            If row(5).Value IsNot Nothing Then
                                ImagePath = row(5).Value.ToString()
                            End If
                            Dim DisplapValue As String = String.Empty
                            If row(1).Value IsNot Nothing Then
                                DisplapValue = row(1).Value.ToString()
                            End If
                            valueTuple = New Tuple(Of String, String, Integer, String, String, String)(row(0).Value.ToString(), DisplapValue, IIF(iVal = -1, 0, iVal), enableStatus, toolTipValue, ImagePath)
                            valueList.Add(valueTuple)
                        End If

                    End If
                Next
                'sort data in displayListSorted
                Dim displayListSorted As List(Of Tuple(Of String, String, Integer, String, String, String)) = valueList.OrderBy(Function(X) X.Item3).ToList()

                For Each vv As Tuple(Of String, String, Integer, String, String, String) In displayListSorted
                    If Not ValidVals.Contains(vv.Item1) Then
                        ValidVals.Add(vv.Item1, vv.Item2)
                        ValidVals.Add(vv.Item1 + "$Enabled", vv.Item4)
                        ValidVals.Add(vv.Item1 + "$Tooltip", vv.Item5)
                        ValidVals.Add(vv.Item1 + "$Image", vv.Item6)
                    End If
                Next
            Else
                g_ObjectManager.LogInfo("MakeValidValuesFromExcel_Extended", "File not found. File Name: " + fileName)
            End If


            ' Cleanup
            '_worksheet.Dispose()
            '_workbook.Dispose()

        Catch ex As Exception
            Throw New Exception("Common.vb:MakeValidValuesFromExcel(): Caught exception: " + ex.Message)
        End Try

        Return ValidVals
    End Function

    <Browsable(False)> Public Function InContext(ByVal strContextCheck As String, ByVal strCurrentContext As String) As Boolean
        'Purpose:       Checks to see if a string ends with the supplied sub string.
        'Parameters:    String - Sub string to check for.
        '               String - String to check if the it ends with the sub string.
        'Returns:       true if the main string ends in the sub string.
        '               false otherwise

        'if not overridden, return true
        If strContextCheck = "-1" Then
            InContext = True
            Exit Function
        End If

        Dim pos As Integer
        If strContextCheck = strCurrentContext Then
            InContext = True
        Else
            pos = InStr(1, strCurrentContext, "," & strContextCheck)
            If pos = 0 Then
                InContext = False
            Else
                If pos = Len(strCurrentContext) - Len(strContextCheck) Then
                    InContext = True
                Else
                    InContext = False
                End If
            End If
        End If
    End Function

    Public Function MakeValidValuesFromRecordSet(ByRef recRecords As Object) As Rulestream.Kernel.ValidValues 'Hashtable
        'Purpose:       Creates a Collection object (Key/Item pairs) from an ADO Recordset
        'Parameters:    recRecords - An open ADO Recordset object
        'Returns:       Collection object
        'Notes:         If the Recordset has 1 column, that value is used for both the
        '               the key and the item.  If the Recordset has 2 or more columns,
        '               the first column is used as the key and the second column is used
        '               as the item.  Duplicate keys are skipped.

        On Error GoTo Err_Handler

        Dim dic As Rulestream.Kernel.ValidValues 'Hashtable
        Dim numOfFields As Integer
        Dim fieldIndex As Integer
        Dim vKey As Object
        Dim vItem As Object
        Dim rs As SqlDataReader

        dic = New Rulestream.Kernel.ValidValues 'Hashtable

        'Make sure that recRecords is a Recordset object
        'If Not TypeOf recRecords Is Recordset Then
        If Not TypeOf recRecords Is SqlDataReader Then
            Err.Raise(513, , "Object passed to MakeValidValuesFromRecordSet is not a SqlDataReader object.")
        End If

        rs = CType(recRecords, SqlDataReader)

        'Make sure the Recordset has at least one column
        'numOfFields = recRecords.Fields.Count
        numOfFields = rs.FieldCount
        If numOfFields < 1 Then
            Err.Raise(513, , "SqlDataReader does not contain any fields.")
        End If

        'Loop through the Recordset
        'Do While Not recRecords.EOF
        Do While rs.Read
            Select Case numOfFields
                Case 1
                    'One column - use for both the key and item
                    vKey = rs.Item(0).ToString
                    vItem = rs.Item(0).ToString
                Case Else
                    'Two or more columns - use first column for key, second for item
                    vKey = rs.Item(0).ToString
                    vItem = rs.Item(1).ToString
            End Select
            'Add the item to the Collection
            dic.Add(vKey, vItem)
Next_Record:
        Loop

        MakeValidValuesFromRecordSet = dic

        rs = Nothing

Done:
        Exit Function

Err_Handler:
        Select Case Err.Number
            Case 513
                'Custom error.  Display the error and exit the function.
                System.Diagnostics.Debug.WriteLine(Err.Description)
                MakeValidValuesFromRecordSet = Nothing
                Resume Done

            Case 457
                'Attempt to add a duplicate key to the Collection object
                'Display the error, skip current record and continue with next record.
                System.Diagnostics.Debug.WriteLine("The key """ & CStr(vKey) & """ already exists in the Collection.  Record will be skipped.")
                Resume Next_Record

            Case Else
                'Another error.  Log the error and exit the function.
                g_ObjectManager.LogError("MakeValidValuesFromRecordSet", Err.Description)
                MakeValidValuesFromRecordSet = Nothing
                Resume Done
        End Select
    End Function

    Public Function DelimitTableName(ByVal tableName As String) As String
        Dim delimitedName As String

        delimitedName = tableName.Trim.Replace(Chr(9), " ")

        Select Case g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType
            Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.MSAccess, RuleStream.DataService.PublicEnumerations.DatabaseTypes.SQLServer
                If Not delimitedName.StartsWith("[") Then
                    delimitedName = String.Format("[{0}", delimitedName)
                End If
                If Not delimitedName.EndsWith("]") Then
                    delimitedName = String.Format("{0}]", delimitedName)
                End If

            Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.Oracle
                If delimitedName.Contains(" ") Then
                    If Not delimitedName.StartsWith("""") Then
                        delimitedName = String.Format("""{0}", delimitedName)
                    End If
                    If Not delimitedName.EndsWith("""") Then
                        delimitedName = String.Format("{0}""", delimitedName)
                    End If
                End If

        End Select

        Return delimitedName

    End Function

    Public Function DelimitColumnName(ByVal columnName As String) As String
        Dim leftDelimiter As String = String.Empty
        Dim rightDelimiter As String = String.Empty
        Dim delimitedName As String

        delimitedName = columnName.Trim.Replace(Chr(9), " ")

        Select Case g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType
            Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.MSAccess, RuleStream.DataService.PublicEnumerations.DatabaseTypes.SQLServer
                leftDelimiter = "["
                rightDelimiter = "]"

            Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.Oracle
                leftDelimiter = """"
                rightDelimiter = """"

        End Select

        If Not delimitedName.StartsWith(leftDelimiter) Then
            delimitedName = String.Format("{0}{1}", leftDelimiter, delimitedName)
        End If
        If Not delimitedName.EndsWith(rightDelimiter) Then
            delimitedName = String.Format("{0}{1}", delimitedName, rightDelimiter)
        End If

        Return delimitedName

    End Function

    Private Function FormatWhereClause(ByVal whereClause As String) As String
        Dim formattedWhereClause As String = whereClause.Trim.Replace(Chr(9), " ")

        If formattedWhereClause <> String.Empty AndAlso Not formattedWhereClause.ToUpper.StartsWith("WHERE") AndAlso Not formattedWhereClause.ToUpper.StartsWith("ORDER BY") Then
            formattedWhereClause = String.Format("WHERE {0}", formattedWhereClause)
        End If

        Return formattedWhereClause
    End Function

    Public Function MakeValidValueKeyFromDatabase(ByVal tableName As String, ByVal keyColumnName As String, ByVal displayColumnName As String, ByVal whereClause As String) As RuleStream.Kernel.ValidValues
        'Purpose:       Returns a Collection object containing key values and display values.
        'Parameters:    tableName - A table name from the components database.
        '               keyColumnName - The "Key" column name.
        '               displayColumnName - The "Display" column name.
        '               whereClause - The SQL "where" clause to query the database
        'Returns:       ValidValues object

        Dim validValuesCollection As RuleStream.Kernel.ValidValues
        Dim ds As DataSet
        Dim keyValue As String
        Dim displayValue As String
        Dim intOrderBy As Integer
        Dim strOrderCols As String = String.Empty
        Dim neededOrderCols As String = String.Empty
        Dim hasDuplicates As Boolean

        validValuesCollection = New RuleStream.Kernel.ValidValues 'Hashtable

        'Check the TableName parameter
        tableName = DelimitTableName(tableName)

        'Check the KeyColumnName parameter
        keyColumnName = DelimitColumnName(keyColumnName)

        'Check the DisplayColumnName parameter
        displayColumnName = DelimitColumnName(displayColumnName)

        'Check for rule author error in call
        If String.Compare(keyColumnName, displayColumnName, True) = 0 Then
            displayColumnName = displayColumnName & " As xxExtraxx"
        End If

        'Check the WhereClause parameter
        whereClause = FormatWhereClause(whereClause)

        'Check for an Order By
        intOrderBy = InStr(1, whereClause, "order by", CompareMethod.Text)
        If intOrderBy > 0 Then
            strOrderCols = Mid(whereClause, intOrderBy + 9).Trim()

            ' Strip out the sort order keyword
            If strOrderCols.ToLower.EndsWith(" desc") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 4)
            End If

            If strOrderCols.ToLower.EndsWith(" descending") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 10)
            End If

            If strOrderCols.ToLower.EndsWith(" asc") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 3)
            End If

            If strOrderCols.ToLower.EndsWith(" ascending") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 9)
            End If

            'Console.WriteLine("Original order cols: " & strOrderCols)
            Dim orderCols() As String
            Dim addCols As New List(Of String)
            orderCols = strOrderCols.Split(",")
            For Each orderCol As String In orderCols
                Dim cleanCol As String = DelimitColumnName(orderCol.Trim())
                If String.Compare(cleanCol, keyColumnName, True) AndAlso String.Compare(cleanCol, displayColumnName, True) Then
                    'Console.WriteLine("Added column: " & orderCol)
                    addCols.Add(cleanCol)
                End If
            Next

            neededOrderCols = String.Join(", ", addCols)

            'Console.WriteLine("Additional cols: " & neededOrderCols)

        End If

        'Execute the query
        ds = g_ComponentData.MakeValidValueKeyFromDatabase(keyColumnName, displayColumnName, neededOrderCols, tableName, whereClause)

        'Loop through the recordset and create items in the Collection
        Try
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    If IsDBNull(dr.Item(0)) Then
                        keyValue = String.Empty
                    Else
                        keyValue = dr.Item(0).ToString.Trim
                    End If

                    If IsDBNull(dr.Item(1)) Then
                        displayValue = String.Empty
                    Else
                        displayValue = dr.Item(1).ToString.Trim
                    End If

                    If Not validValuesCollection.Contains(keyValue) Then
                        validValuesCollection.Add(keyValue, displayValue)
                    Else
                        hasDuplicates = True
                    End If
                Next

                If hasDuplicates Then
                    g_ObjectManager.LogError("Common.MakeValidValueKeyFromDatabase", String.Format("Duplicate values were found while creating a valid values list from the component database table ""{0}"".  The duplicates were ignored.", tableName))
                End If

            Else
                Dim extext As String = String.Format("[Common.MakeValidValueKeyFromDatabase] Unable to create valid values; no data was returned For tableName: <{0}>, keyColumnName: <{1}>, displayColumnName: <{2}>, whereClause: <{3}>.", tableName, keyColumnName, displayColumnName, whereClause)
                Throw New Exception(extext)
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.MakeValidValueKeyFromDatabase", ex.ToString)
        End Try

        Return validValuesCollection

    End Function

    ''' <summary>
    ''' Returns a Collection object containing valid values from the Components database.
    ''' </summary>
    ''' <param name="tableName">A table name from the components database</param>
    ''' <param name="columnName">The column to select from the table</param>
    ''' <param name="whereClause">The SQL "where" clause to query the database</param>
    ''' <param name="orderBy">[Optional] Column(s) to sort by.</param>
    ''' <param name="logOnly">[Optional] if set to <c>true</c> [log only], don't pop-up a Messagebox.</param>
    ''' <returns>RuleStream.Kernel.ValidValues Object.</returns>
    ''' <exception cref="Exception">[Common.MakeValidValuesFromDatabase] Unable to create valid values; no data was returned.</exception>
    Public Function MakeValidValuesFromDatabase(ByVal tableName As String, ByVal columnName As String, ByVal whereClause As String, Optional ByVal orderBy As String = "", Optional ByVal logOnly As Boolean = False) As RuleStream.Kernel.ValidValues

        Dim validValuesCollection As RuleStream.Kernel.ValidValues
        Dim ds As DataSet
        Dim columnValue As String
        Dim sortOrder As String = String.Empty
        Dim hasDuplicates As Boolean

        validValuesCollection = New RuleStream.Kernel.ValidValues 'Hashtable

        'Check the TableName parameter
        tableName = DelimitTableName(tableName)

        'Check the ColumnName parameter
        columnName = DelimitColumnName(columnName)

        'Check the WhereClause parameter
        whereClause = FormatWhereClause(whereClause)

        'Check the OrderBy parameter
        If orderBy Is Nothing Then orderBy = String.Empty
        orderBy = Replace(orderBy.Trim, Chr(9), " ", , , CompareMethod.Text)

        If orderBy Is Nothing Then orderBy = String.Empty
        orderBy = Replace(orderBy, "order by", "", , , CompareMethod.Text)

        If orderBy Is Nothing Then orderBy = String.Empty
        orderBy = orderBy.Trim

        If orderBy <> String.Empty Then
            If orderBy.ToLower.EndsWith("asc") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 3))
            ElseIf orderBy.ToLower.EndsWith("ascending") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 9))
            ElseIf orderBy.ToLower.EndsWith("desc") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 4))
                sortOrder = "desc"
            ElseIf orderBy.ToLower.EndsWith("descending") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 10))
                sortOrder = "desc"
            End If

            'ORDER BY items must appear in the select list if SELECT DISTINCT is specified
            If InStr(1, columnName, orderBy, CompareMethod.Text) = 0 Then
                columnName = columnName & ", " & orderBy
            End If
            orderBy = "order by " & orderBy & " " & sortOrder
        End If

        'Execute the query
        ds = g_ComponentData.MakeValidValuesFromDatabase(columnName, tableName, whereClause, orderBy)

        'Loop through the recordset and create items in the Collection
        Try
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    If IsDBNull(dr.Item(0)) Then
                        columnValue = String.Empty
                    Else
                        columnValue = dr.Item(0).ToString.Trim
                    End If

                    If Not validValuesCollection.Contains(columnValue) Then
                        validValuesCollection.Add(columnValue, columnValue)
                    Else
                        hasDuplicates = True
                    End If
                Next

                If hasDuplicates Then
                    g_ObjectManager.LogError("Common.MakeValidValuesFromDatabase", String.Format("Duplicate values were found while creating a valid values list from the component database table ""{0}"".  The duplicates were ignored.", tableName), (logOnly))
                End If

            Else
                Throw New Exception("[Common.MakeValidValuesFromDatabase] Unable to create valid values; no data was returned.")
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.MakeValidValuesFromDatabase", ex.ToString)
            Return Nothing
        End Try

        Return validValuesCollection

    End Function

    ''' <summary>
    ''' Making a call to SQL and gets a data for the query created through Valid values Extended option from Valid values tab
    ''' </summary>
    ''' <param name="ColumnArr">Column names</param>
    ''' <param name="ValuesArr">Acutal column name values from DB table</param>
    ''' <param name="whereClause">SQL where clause</param>
    ''' <param name="orderBy">SQL order by clause</param>
    ''' <param name="logOnly">Boolean value which tells - Logging to be done or not</param>
    ''' <returns>Returns data in Valid values collection</returns>
    Public Function MakeValidValuesExtendedFromDatabase(ByRef ColumnArr As Object(),
                                                        ByRef ValuesArr As Object(),
                                                        ByVal Optional whereClause As String = "",
                                                        ByVal Optional orderBy As String = "",
                                                        Optional ByVal logOnly As Boolean = False) As Rulestream.Kernel.ValidValues
        Dim validValuesCollection As RuleStream.Kernel.ValidValues
        Dim ds As DataSet
        Dim columnValue As String
        Dim sortOrder As String = String.Empty
        Dim tableName As String
        Dim hasDuplicates As Boolean = False
        Dim sameKey_sameData As Boolean = False, sameKey_diffData As Boolean = False
        Dim sameKey_sameData_temp As Boolean = False, sameKey_diffData_temp As Boolean = False

        validValuesCollection = New RuleStream.Kernel.ValidValues 'Hashtable

        '0th parameter from ValuesArr is TableName 
        tableName = ValuesArr(0)

        'Check the ColumnName parameter
        'columnName = DelimitColumnName(columnName)

        'Check the WhereClause parameter
        whereClause = FormatWhereClause(whereClause)

        'Check the OrderBy parameter
        If orderBy Is Nothing Then orderBy = String.Empty
        orderBy = Replace(orderBy.Trim, Chr(9), " ", , , CompareMethod.Text)

        If orderBy Is Nothing Then orderBy = String.Empty
        orderBy = Replace(orderBy, "order by", "", , , CompareMethod.Text)

        If orderBy Is Nothing Then orderBy = String.Empty
        orderBy = orderBy.Trim

        If orderBy <> String.Empty Then
            If orderBy.ToLower.EndsWith("asc") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 3))
            ElseIf orderBy.ToLower.EndsWith("ascending") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 9))
            ElseIf orderBy.ToLower.EndsWith("desc") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 4))
                sortOrder = "desc"
            ElseIf orderBy.ToLower.EndsWith("descending") Then
                orderBy = Trim(Left(orderBy, Len(orderBy) - 10))
                sortOrder = "desc"
            End If

            'ORDER BY items must appear in the select list if SELECT DISTINCT is specified
            'If InStr(1, columnName, orderBy, CompareMethod.Text) = 0 Then
            '    columnName = columnName & ", " & orderBy
            'End If
            orderBy = "order by " & orderBy & " " & sortOrder
        End If

        'Execute the query
        ds = g_ComponentData.MakeValidValuesExtendedFromDatabase(ColumnArr, ValuesArr, whereClause, orderBy)

        'Loop through the recordset and create items in the Collection
        Try
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                'Legacy 
                'For Each dr As DataRow In ds.Tables(0).Rows
                '    If IsDBNull(dr.Item(0)) Then
                '        columnValue = String.Empty
                '    Else
                '        columnValue = dr.Item(0).ToString.Trim
                '    End If

                '    If Not validValuesCollection.Contains(columnValue) Then
                '        validValuesCollection.Add(columnValue, columnValue)
                '    Else
                '        hasDuplicates = True
                '    End If
                'Next

                'If hasDuplicates Then
                '    g_ObjectManager.LogError("Common.MakeValidValuesExtendedFromDatabase", String.Format("Duplicate values were found while creating a valid values list from the component database table ""{0}"".  The duplicates were ignored.", tableName))
                'End If

                'Extended
                'Sequence of values is like Key, Display Value, Enabled, Tooltip(OPtional), Image(Optional)
                Dim col As Integer = 0
                Dim colsCount = ds.Tables(0).Columns.Count
                Dim colHeader As String ', dispVal As String
                Dim keyVal As String = String.Empty
                For Each dr As DataRow In ds.Tables(0).Rows
                    col = 0
                    While (col < colsCount)
                        colHeader = ds.Tables(0).Columns(col).ColumnName
                        If IsDBNull(dr.Item(col)) Then
                            columnValue = String.Empty
                        Else
                            columnValue = dr.Item(col).ToString.Trim
                        End If
                        If (hasDuplicates) Then
                            'check data - DisplayValue and Enabled to be compared only
                            'same key same data - Log the error, show pop-up in end but continue
                            'same key diff data - Log the error, show pop-up and used only the first value but continue
                            If (col = 1) Then 'key-DisplayValue pair
                                If validValuesCollection.ContainsKeyValuePair(keyVal, columnValue) Then
                                    sameKey_sameData_temp = True
                                Else
                                    sameKey_diffData_temp = True
                                End If
                            ElseIf (col = 2) Then 'key-DisplayValue pair
                                If validValuesCollection.ContainsKeyValuePair(keyVal + "$" + colHeader, columnValue) Then
                                    sameKey_sameData_temp = True
                                Else
                                    sameKey_diffData_temp = True
                                End If
                            End If
                        End If 'if hasDuplicates ended

                        If Not (hasDuplicates) Then
                            If (col = 0) Then ' first will always be Key, store it temporily
                                keyVal = columnValue
                                If validValuesCollection.Contains(keyVal) Then
                                    'dupliacte key found
                                    hasDuplicates = True
                                End If
                            ElseIf (col = 1) Then 'add key and DisplayValue together
                                validValuesCollection.Add(keyVal, columnValue)
                            Else ' add remaining attributes as Enabled, Tooltip, Image
                                validValuesCollection.Add(keyVal + "$" + colHeader, columnValue)
                            End If
                        End If
                        col = col + 1

                        'Don't check for more attributes than DisplayValue and Enabled and continue thw whilw loop id duplicate key is found.
                        If (col > 2 And hasDuplicates) Then
                            'if data is same and diff for different attribtes for same example then set sameKey_diffData to true only
                            If (sameKey_diffData_temp) Then
                                sameKey_diffData = True
                            ElseIf (sameKey_sameData_temp) Then
                                sameKey_sameData = True
                            End If

                            'reset hasDuplicates value
                            hasDuplicates = False
                            sameKey_diffData_temp = False
                            sameKey_sameData_temp = False
                            col = 0
                            Continue For
                        End If
                    End While
                    'reset hasDuplicates value
                    'hasDuplicates = False ' may not need this
                Next
            Else
                Throw New Exception("[Common.MakeValidValuesExtendedFromDatabase] Unable to create valid values; no data was returned.")
            End If

            'Form a unique error message string for one or more types of errors
            Dim errorMsg As String = ""
            If sameKey_diffData Or sameKey_sameData Then
                If sameKey_diffData Then
                    errorMsg = String.Format("Different data values were found for the same key while creating a valid values list from the component database table ""{0}"". The first value found was used.", tableName)
                End If
                If sameKey_sameData Then
                    If Not errorMsg = "" Then
                        errorMsg = errorMsg + String.Format("{0}", System.Environment.NewLine)
                    End If
                    errorMsg = errorMsg + String.Format("Duplicate data values were found for the same key while creating a valid values list from the component database table ""{0}"". The duplicates were ignored.", tableName)
                End If

                'Log error & also Show error pop-up
                g_ObjectManager.LogError("Common.MakeValidValuesExtendedFromDatabase", errorMsg, Not (logOnly))
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.MakeValidValuesExtendedFromDatabase", ex.ToString)
            Return Nothing
        End Try

        Return validValuesCollection
    End Function


    Public Function MakeValidValuesFromParts(ByVal colParts As Collection, ByVal strPropName As String, Optional ByVal bDescending As Boolean = False) As Rulestream.Kernel.ValidValues 'Hashtable
        'Purpose:       Returns a Collection object containing Rulestream.Kernel.ValidValues.
        'Parameters:    Collection - A collection of parts to look thru.
        '               String - A common property on the parts to get the value.
        '               Boolean - Sort by descending or ascending order.  default is descending
        'Returns:       Collection like:  "red", "green" , "blue"

        Dim dic As Rulestream.Kernel.ValidValues 'Hashtable
        Dim varVal As Object
        Dim npPart As Object
        dic = New Rulestream.Kernel.ValidValues 'Hashtable

        colParts = SortObjectsByProperty(colParts, strPropName, bDescending)

        If colParts.Count() > 0 Then
            For Each npPart In colParts
                varVal = npPart.Properties(strPropName).Value
                dic.Add(varVal, Trim(CStr(varVal)))
            Next npPart
        End If

        MakeValidValuesFromParts = dic
    End Function

    Public Function MakeValidValuesFromParts(ByVal colParts As Rulestream.Kernel.rsCollection, ByVal strPropName As String, Optional ByVal bDescending As Boolean = False) As Rulestream.Kernel.ValidValues 'Hashtable
        'Purpose:       Returns a Collection object containing Rulestream.Kernel.ValidValues.
        'Parameters:    Collection - A collection of parts to look thru.
        '               String - A common property on the parts to get the value.
        '               Boolean - Sort by descending or ascending order.  default is descending
        'Returns:       Collection like:  "red", "green" , "blue"

        Dim dic As Rulestream.Kernel.ValidValues 'Hashtable
        Dim varVal As Object
        Dim npPart As Object
        dic = New Rulestream.Kernel.ValidValues 'Hashtable

        colParts = SortObjectsByProperty(colParts, strPropName, bDescending)

        If colParts.Count() > 0 Then
            For Each npPart In colParts
                varVal = npPart.Properties(strPropName).Value
                dic.Add(varVal, Trim(CStr(varVal)))
            Next npPart
        End If

        MakeValidValuesFromParts = dic
    End Function


    'Used as formula in Valid values
    Public Function LoadTranslations(ByVal currentPart As RuleStream.Kernel.Part) As RuleStream.Kernel.ValidValues
        Dim validValuesCollection As New RuleStream.Kernel.ValidValues
        Dim Scope As String = "Global" ' default
        Dim RsLocale As String = "en-US" ' default is en-US - actual value will be received from Thin client 
        Dim prop As RuleStream.Kernel.PropertySF
        Dim errorMsg As String

        Try
            If RootPart() IsNot Nothing Then
                prop = RootPart.Properties("__RSLocale")

                If prop IsNot Nothing Then
                    RsLocale = prop.DisplayValue()
                Else
                    RsLocale = "en-US" ' default is en-US 
                    ''log error Locale is empty/invalid/incorrect & hence used default value
                    errorMsg = String.Format("Locale value is invalid. Hence, used default value for Locale as ""en-US"".")
                    g_ObjectManager.LogError("Common.LoadTranslations(): ", errorMsg, True)
                End If

                If currentPart IsNot Nothing And Not String.IsNullOrEmpty(currentPart.PartFamily) Then
                    'Here Scope is Part family name
                    Scope = currentPart.PartFamily
                Else
                    Scope = "Global" 'default scope
                    ''log error that part name is empty/invalid/incorrect & hence used default value
                    errorMsg = String.Format("Part family name is empty or invalid. Hence, used default value for scope as ""Global"".")
                    g_ObjectManager.LogError("Common.LoadTranslations(): ", errorMsg, True)
                End If

                'query formation
                validValuesCollection = MakeValidValueKeyFromDatabase("[__Translations]", "[KeyString]", "[LocalizedString]", "WHERE [Scope] = '" & Scope & "' AND [Locale] = '" & RsLocale & "' ORDER BY [KeyString]")
            Else
                ''log error that Rootpart() is nothing
                errorMsg = String.Format("RootPart() is empty or invalid.")
                g_ObjectManager.LogError("Common.LoadTranslations(): ", errorMsg, True)
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.LoadTranslations(): ", ex.ToString)
        End Try

        Return validValuesCollection
    End Function

    'Used as formula in Valid values
    Public Function LoadTranslations(ByVal Scope As String) As RuleStream.Kernel.ValidValues
        Dim validValuesCollection As New RuleStream.Kernel.ValidValues
        Dim RsLocale As String = "en-US" ' default is en-US - actual value will be received from Thin client 
        Dim prop As RuleStream.Kernel.PropertySF
        Dim errorMsg As String = ""

        Try
            If RootPart() IsNot Nothing Then
                prop = RootPart.Properties("__RSLocale")

                If prop IsNot Nothing Then
                    RsLocale = prop.DisplayValue()
                Else
                    RsLocale = "en-US" ' default is en-US  
                    ''log error that part name is empty/invalid/incorrect & hence used default value
                    errorMsg = String.Format("Locale value is invalid. Hence, used default value for Locale as ""en-US"".")
                    g_ObjectManager.LogError("Common.LoadTranslations(): ", errorMsg, True)
                End If
            End If

            If String.IsNullOrEmpty(Scope) Or Scope Is Nothing Then
                Scope = "Global"

                ''log error that scope parameter is incorrect & hence used default value
                errorMsg = String.Format("Value of Scope ""{0}"" is incorrect. Hence, used the default value for Scope as ""Global"".", Scope)
                g_ObjectManager.LogError("Common.LoadTranslations", errorMsg, True)
            End If

            'query formation
            validValuesCollection = MakeValidValueKeyFromDatabase("[__Translations]", "[KeyString]", "[LocalizedString]", "WHERE [Scope] = '" & Scope & "' AND [Locale] = '" & RsLocale & "' ORDER BY [KeyString]")

        Catch ex As Exception
            g_ObjectManager.LogError("Common.LoadTranslations() Caught Exception: ", ex.ToString)
        End Try

        Return validValuesCollection
    End Function


    'Used as formula in Label, Tooltip, Hint
    Public Function LookupTranslation(ByVal currentPart As RuleStream.Kernel.Part, ByVal Key As String) As String
        Dim Value As String = String.Empty
        Dim Scope As String = "Global"
        Dim errorMsg As String = ""
        Dim VVList As RuleStream.Kernel.ValidValues

        Try
            If currentPart IsNot Nothing And Not String.IsNullOrEmpty(currentPart.PartFamily) Then
                'Here Scope is Part family name
                Scope = currentPart.PartFamily
            Else
                Scope = "Global" 'default scope
                ''log error that part name is empty/invalid/incorrect & hence used default value
                errorMsg = String.Format("Part family name is empty or invalid. Hence, used default value for scope as ""Global"".")
                g_ObjectManager.LogError("Common.LoadTranslations(): ", errorMsg, True)
            End If
            'Load valid values for the mentioned scope
            VVList = LoadTranslations(Scope)
            If VVList IsNot Nothing And VVList.Contains(Key) Then
                Value = VVList(Key)
            Else
                Value = Key
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.LookupTranslation() Caught Exception: ", ex.ToString)
        End Try

        Return Value
    End Function

    'Used as formula in Label, Tooltip, Hint
    'Ret() Caurn all global values with inputed Key
    Public Function LookupTranslation(ByVal Key As String) As String
        Dim Value As String = String.Empty

        Try
            If RootPart() IsNot Nothing And RootPart.ValidValues("__TranslationsSeeVV").Contains(Key) Then
                Value = RootPart.ValidValues("__TranslationsSeeVV")(Key)
            Else
                Value = Key
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.LookupTranslation() Caught exception: ", ex.ToString)
        End Try

        Return Value
    End Function

    <Browsable(False)> Public Function GetContextPart(ByVal strContext As String, ByVal obj As Object) As Object
        'Returns the part which is overriding the calling part's formula
        Dim context() As String
        Dim objTemp As Object

        context = Split(strContext, ",")

        On Error GoTo errorHandler
        If TypeName(obj) = "PropertySF" Then
            If obj.ContextSuffix = "" Then
                'Local constraint, return the owner part
                GetContextPart = obj.Owner
                AddToCol(obj.Owner.PropertyConstraints, obj)
                Exit Function
            End If
            objTemp = obj.Owner.Owner
        ElseIf TypeName(obj) = "Connection" Then
            If obj.ContextSuffix = "" Then
                'Local constraint, return the owner part
                GetContextPart = obj.Owner
                AddToCol(obj.Owner.ConnectionConstraints, obj)
                Exit Function
            End If
            objTemp = obj.Owner.Owner
        ElseIf TypeName(obj) = "Subpart" Then
            If obj.ContextSuffix = "" Then
                'Local constraint, return the owner part
                GetContextPart = obj.Owner
                AddToCol(obj.Owner.SubpartConstraints, obj)
                Exit Function
            End If
            objTemp = obj
        Else 'Part
            If obj.ContextSuffix = "" Then
                GetContextPart = obj
                Exit Function
            End If
            objTemp = obj.Owner
        End If

        While context(LBound(context)) <> objTemp.SubpartSpecID
            objTemp = objTemp.Owner.Owner
        End While

        'Get the parent of the found subpart
        objTemp = objTemp.Owner

        'Return the parent of the subpart overriding the obj
        GetContextPart = objTemp

        If TypeName(obj) = "PropertySF" Then
            AddToCol(objTemp.PropertyConstraints, obj)
        ElseIf TypeName(obj) = "Subpart" Then
            AddToCol(objTemp.SubpartConstraints, obj)
        ElseIf TypeName(obj) = "Connection" Then
            AddToCol(objTemp.ConnectionConstraints, obj)
        End If

        Exit Function

errorHandler:
#If nkerneldebug Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression nkerneldebug did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		'Stop
#End If
        GetContextPart = Nothing
    End Function

    Public Function IsConnected(ByVal vObj As RuleStream.Kernel.Connection) As Boolean
        'Purpose:       Checks to see if a Connection is connected to anything.
        'Parameters:    Object - Connection to check.
        'Returns:       True if connected.
        '               False if not connected.

        If (vObj.Quantity > 0) Then
            IsConnected = True
        Else
            IsConnected = False
        End If
    End Function

    Public Function IsConnected(ByVal vObj As Object) As Boolean
        'Purpose:       Checks to see if a Connection is connected to anything.
        'Parameters:    Object - Connection to check.
        'Returns:       True if connected.
        '               False if not connected.
        'Note:          For backward compatibility

        If (vObj.Quantity > 0) Then
            IsConnected = True
        Else
            IsConnected = False
        End If
    End Function

    Public Function HasSubparts(ByVal varobj As RuleStream.Kernel.Subpart) As Boolean
        'Purpose:       Checks to see if a Subpart collection has subparts.
        'Parameters:    Object - Subpart collection to check.
        'Returns:       True if it has subparts.
        '               False if it does not have subparts.

        If (varobj.Quantity > 0) Then
            HasSubparts = True
        Else
            HasSubparts = False
        End If
    End Function

    Public Function HasSubparts(ByVal varobj As Object) As Boolean
        'Purpose:       Checks to see if a Subpart collection has subparts.
        'Parameters:    Object - Subpart collection to check.
        'Returns:       True if it has subparts.
        '               False if it does not have subparts.
        'Note:          For backward compatibility

        If (varobj.Quantity > 0) Then
            HasSubparts = True
        Else
            HasSubparts = False
        End If
    End Function

    Public Function IsType(ByVal varobj As RuleStream.Kernel.Part, ByVal varName As String) As Boolean
        'Purpose:       Checks the type of a object to the supplied type.
        'Parameters:    Object - Object to check.
        '               String - Named type to check the object against.
        'Returns:       True if it is of the type supplied.
        '               False if it is not of the type supplied.

        If (UCase(varobj.PartFamily) = UCase(varName)) Then
            IsType = True
        Else
            IsType = False
        End If
    End Function

    Sub SetNextArrayElement(ByRef arr As Object, ByVal Value As Object)
        'Purpose:       Set the next array element to the supplied value
        'Parameters:    Variant - Array to add to.
        '               Variant - Value to add.
        'Returns:       Array variant.

        'Creates array of parameters
        Dim i As Short

        If IsArray(arr) And Not IsNothing(arr) Then
            i = UBound(arr) + 1
            ReDim Preserve arr(i)
        Else
            i = 0
            ReDim arr(i)
        End If

        arr(i) = Value
    End Sub

    Function MakeSQLSyntax(ByVal Value As Object) As String
        'Purpose:       Gets a string and converts it to suitable SQL syntax
        'Parameters:    Variant - String to convert.
        'Returns:       Converted String.

        'Helper function for component database stuff
        'Gets a string and converts it to suitable SQL syntax
        Select Case VarType(Value)
            Case VariantType.Boolean
                If Value Then
                    Return "True"
                Else
                    Return "False"
                End If

            Case VariantType.String, VariantType.Date
                Return "'" & Value & "'"

            Case VariantType.Single, VariantType.Double, VariantType.Integer, VariantType.Short, VariantType.Decimal, VariantType.Decimal
                Return Value.ToString

            Case Else
                Return String.Empty
        End Select
    End Function

    Function ReplaceQuestionMarks(ByVal strd As String, ByVal arr As Object) As Object
        'Helper function for component database stuff
        'Replace question marks in the SQL query with the parameters
        Dim i As Short
        Dim n As Short

        n = 1

        If Not IsNothing(arr) Then
            For i = LBound(arr) To UBound(arr)
                n = InStr(n, strd, "?")
                If n = 0 Then Exit For
                strd = Left(strd, n - 1) & arr(i) & Mid(strd, n + 1)
                n = n + Len(arr(i))
            Next
        End If

        ReplaceQuestionMarks = strd
    End Function

    Public Function nPosition(ByVal X As Double, ByVal Y As Double, ByVal Z As Double) As Double()
        Dim p(2) As Double
        p(0) = X
        p(1) = Y
        p(2) = Z

        Return p
    End Function

    Public Function KeyExists(ByRef col As Hashtable, ByVal strKey As String) As Object
        Try
            If col.ContainsKey(strKey) Then
                KeyExists = col.Item(strKey)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function KeyExists(ByRef col As Rulestream.Kernel.rsCollection, ByVal strKey As String) As Object
        Try
            If col.ContainsKey(strKey) Then
                KeyExists = col.Item(strKey)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function AddToCol(ByRef col As ArrayList, ByRef obj As Object) As Object
        Try
            If Not col.Contains(obj) Then
                col.Add(obj)
            End If
            Return obj
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function StringToNull(ByVal Data As String) As String
        If Len(Trim(Data)) = 0 Then
            StringToNull = "null"
        Else
            StringToNull = "'" & Replace(Data, "'", "''") & "'"
        End If
    End Function

    Public Function VarToNull(ByVal Data As String) As String
        If IsNothing(Data) Then
            VarToNull = "null"
        Else
            VarToNull = "'" & Data & "'"
        End If
    End Function

    Public Function DblToNull(ByVal Data As Object) As String
        If Len(Trim(Data)) = 0 Then
            DblToNull = "Null"
        Else
            DblToNull = Data
        End If
    End Function

    Public Function BoolToYN(ByVal Data As Boolean) As String
        If Data Then
            BoolToYN = "'Y'"
        Else
            BoolToYN = "'N'"
        End If
    End Function

    Public Function YNToBool(ByVal Data As String) As Boolean
        If UCase(Data) = "Y" Then
            YNToBool = True
        Else
            YNToBool = False
        End If
    End Function

    Public Function NullToString(ByVal Data As Object) As String
        If IsDBNull(Data) Then
            NullToString = ""
        Else
            NullToString = Data.ToString.Trim
        End If
    End Function

#If nkerneldebug Then
	Private Property Get ContextName(obj As Object) As String
	    ContextName = obj.ObjName & obj.ContextSuffix
	End Property
#End If

    Public Function MakeCollectionFromRecord(ByVal strTableName As String, ByVal ColumnNames As String, ByVal strWhereStatement As String) As Rulestream.Kernel.ValidValues  'Hashtable
        'Purpose:       Returns a Collection object containing Rulestream.Kernel.ValidValues.
        'Parameters:    String - A table name from the components database.
        '               String - The sql "where" statement to query the database.
        'Returns:       Collection like:  "red", "green" , "blue"

        Dim dic As Rulestream.Kernel.ValidValues 'Hashtable
        Dim dt As DataTable
        Dim dc As DataColumn
        Dim dr As DataRow

        dic = New RuleStream.Kernel.ValidValues

        Try
            dt = g_ComponentData.MakeCollectionFromRecord(ColumnNames, strTableName, strWhereStatement).Tables(0)

            If Not IsNothing(dt) Then
                dr = dt.Rows(0)
                If Not IsNothing(dr) Then
                    For Each dc In dt.Columns
                        dic.Add(dc.ColumnName, dr.Item(dc.ColumnName))
                    Next
                Else
                    Throw New Exception("Unable to create Valid Values - no data found.")
                End If
            Else
                Throw New Exception("Unable to create Valid Values - no data found.")
            End If

            Return dic
        Catch ex As Exception
            g_ObjectManager.LogError("MakeCollectionFromRecord", ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SortObjectsByProperty(ByRef colToBeSorted As Object, ByVal sProperty As String, Optional ByVal bDescending As Boolean = True) As Collection
        'Purpose:        Sorts a collection of objects by the value of a common property on the objects.
        'Parameters:     Collection - Collection of objects to be sorted.
        '                String - Common property on the objects to sort on.
        '                Boolean - Sort by descending or ascending order.  default is descending
        'Returns:        Sorted collection of objects.

        Dim i As Short

        Dim oObjects() As Object
        Dim vKeys() As Object

        Dim oTempObject As Object
        Dim vTempKey As Object
        Dim bSwapped As Boolean
        Dim np As Object

        Dim colSorted As Collection

        'Define arrays for Objects and their SortKeys in the collection.
        i = colToBeSorted.Count
        If i = 0 Then
            SortObjectsByProperty = New Collection
            Exit Function
        End If

        ReDim oObjects(i)
        ReDim vKeys(i)

        'On Error GoTo DoSortError

        'Create array of Objects and Keys.
        i = 1
        For Each oTempObject In colToBeSorted
            oObjects(i) = colToBeSorted(i)
            np = colToBeSorted(i)
            vKeys(i) = np.Properties(sProperty).Value
            i = i + 1
        Next oTempObject

        'Using Bubble Sort algorithm, sort the objects in the array by the key.
        If bDescending Then
            Do
                bSwapped = False
                For i = 1 To UBound(vKeys) - 1
                    If vKeys(i) < vKeys(i + 1) Then 'descending
                        'Swap keys
                        vTempKey = vKeys(i)
                        vKeys(i) = vKeys(i + 1)
                        vKeys(i + 1) = vTempKey
                        'Swap Objects
                        oTempObject = oObjects(i)
                        oObjects(i) = oObjects(i + 1)
                        oObjects(i + 1) = oTempObject
                        bSwapped = True
                    End If
                Next i
            Loop While bSwapped
        Else
            Do
                bSwapped = False
                For i = 1 To UBound(vKeys) - 1
                    If vKeys(i) > vKeys(i + 1) Then 'ascending
                        'Swap keys
                        vTempKey = vKeys(i)
                        vKeys(i) = vKeys(i + 1)
                        vKeys(i + 1) = vTempKey
                        'Swap Objects
                        oTempObject = oObjects(i)
                        oObjects(i) = oObjects(i + 1)
                        oObjects(i + 1) = oTempObject
                        bSwapped = True
                    End If
                Next i
            Loop While bSwapped
        End If

        'Create a sorted collection from the sorted array.
        colSorted = New Collection
        For i = 1 To UBound(oObjects)
            colSorted.Add(oObjects(i))
        Next i

        SortObjectsByProperty = colSorted
        Exit Function

DoSortError:
        g_ObjectManager.LogError("Common" & ".SortObjectsByProperty", "  Error Number: " & Err.Number & vbCrLf & "  Description: " & Err.Description)
    End Function

    Public Function SortObjectsByProperty(ByRef colToBeSorted As RuleStream.Kernel.rsCollection, ByVal sProperty As String, Optional ByVal bDescending As Boolean = True) As RuleStream.Kernel.rsCollection
        'Purpose:        Sorts a collection of objects by the value of a common property on the objects.
        'Parameters:     Collection - Collection of objects to be sorted.
        '                String - Common property on the objects to sort on.
        '                Boolean - Sort by descending or ascending order.  default is descending
        'Returns:        Sorted collection of objects.

        Dim i As Short

        Dim oObjects() As Object
        Dim vKeys() As Object

        Dim oTempObject As Object
        Dim vTempKey As Object
        Dim bSwapped As Boolean
        Dim np As Object

        Dim colSorted As RuleStream.Kernel.rsCollection

        'Define arrays for Objects and their SortKeys in the collection.
        i = colToBeSorted.Count
        If i = 0 Then
            SortObjectsByProperty = New RuleStream.Kernel.rsCollection
            Exit Function
        End If

        ReDim oObjects(i)
        ReDim vKeys(i)

        'On Error GoTo DoSortError

        'Create array of Objects and Keys.
        i = 1
        For Each oTempObject In colToBeSorted
            oObjects(i) = colToBeSorted(i)
            np = colToBeSorted(i)
            vKeys(i) = np.Properties(sProperty).Value
            i = i + 1
        Next oTempObject

        'Using Bubble Sort algorithm, sort the objects in the array by the key.
        If bDescending Then
            Do
                bSwapped = False
                For i = 1 To UBound(vKeys) - 1
                    If vKeys(i) < vKeys(i + 1) Then 'descending
                        'Swap keys
                        vTempKey = vKeys(i)
                        vKeys(i) = vKeys(i + 1)
                        vKeys(i + 1) = vTempKey
                        'Swap Objects
                        oTempObject = oObjects(i)
                        oObjects(i) = oObjects(i + 1)
                        oObjects(i + 1) = oTempObject
                        bSwapped = True
                    End If
                Next i
            Loop While bSwapped
        Else
            Do
                bSwapped = False
                For i = 1 To UBound(vKeys) - 1
                    If vKeys(i) > vKeys(i + 1) Then 'ascending
                        'Swap keys
                        vTempKey = vKeys(i)
                        vKeys(i) = vKeys(i + 1)
                        vKeys(i + 1) = vTempKey
                        'Swap Objects
                        oTempObject = oObjects(i)
                        oObjects(i) = oObjects(i + 1)
                        oObjects(i + 1) = oTempObject
                        bSwapped = True
                    End If
                Next i
            Loop While bSwapped
        End If

        'Create a sorted collection from the sorted array.
        colSorted = New RuleStream.Kernel.rsCollection
        For i = 1 To UBound(oObjects)
            colSorted.Add(oObjects(i))
        Next i

        SortObjectsByProperty = colSorted
        Exit Function

DoSortError:
        g_ObjectManager.LogError("Common" & ".SortObjectsByProperty", "  Error Number: " & Err.Number & vbCrLf & "  Description: " & Err.Description)

    End Function

    Public Function ReverseArray(ByRef arr As Object) As Object
        'Purpose:        Reverses an Array
        'Parameters:     Variant -   Array to reverse.
        'Returns:        New reversed array.

        Dim lngLBound, lngIndex, lngUBound As Integer
        Dim tempArr() As Object = Nothing

        If IsArray(arr) Then
            lngLBound = LBound(arr)
            lngUBound = UBound(arr)

            ReDim tempArr(lngUBound)

            For lngIndex = lngUBound To lngLBound Step -1
                tempArr(lngLBound) = arr(lngIndex)
                lngLBound = lngLBound + 1
            Next lngIndex
        End If

        Dim outPut As Object()
        ReDim outPut(tempArr.GetLength(0) - 1)

        System.Array.Copy(tempArr, outPut, tempArr.GetLength(0))

        Return outPut

    End Function

    Public Function SubArray(ByRef arr As Object, ByVal lngStart As Integer, ByVal lngEnd As Integer) As Object
        'Purpose:        Creat a sub array of an input array.
        'Parameters:     Variant - Orginial Array
        '                Long - Starting position of the sub array.
        '                Long - Ending position of the sub array.
        'Returns:        New array that is a sub array of the orginal array.

        Dim lngUBound, lngIndex, lngLBound, tmpCount As Integer
        Dim tempArr() As Object = Nothing

        If IsArray(arr) Then
            If lngStart >= LBound(arr) And lngEnd <= UBound(arr) Then
                lngLBound = lngStart
                lngUBound = lngEnd

                ReDim tempArr(lngUBound - lngLBound)

                For lngIndex = lngLBound To lngUBound
                    tempArr(tmpCount) = arr(lngIndex)
                    tmpCount = tmpCount + 1
                Next lngIndex
            End If
        End If

        Dim outPut As Object()
        ReDim outPut(tempArr.GetLength(0) - 1)

        System.Array.Copy(tempArr, outPut, tempArr.GetLength(0))

        Return outPut
    End Function

    Public Function UnionCollections(ByVal col1 As Collection, ByVal col2 As Collection) As Collection
        'Purpose:       Union two collections.  Combines two collections without regard for the keys.
        '               Assumes their are not identical elements in the two collections
        'Parameters:    col1 - First collection.
        '               col2 - Second collection.
        'Returns:       New unioned collection.

        Dim colNew As Collection
        Dim varItem As Object

        colNew = New Collection

        If col1.Count() > 0 Then
            For Each varItem In col1
                colNew.Add(varItem)
            Next varItem
        End If

        If col2.Count() > 0 Then
            For Each varItem In col2
                colNew.Add(varItem)
            Next varItem
        End If



        UnionCollections = colNew
    End Function

    Public Function UnionCollections(ByVal col1 As RuleStream.Kernel.rsCollection, ByVal col2 As RuleStream.Kernel.rsCollection) As RuleStream.Kernel.rsCollection
        'Purpose:       Union two collections.  Combines two collections without regard for the keys.
        '               Assumes their are not identical elements in the two collections
        'Parameters:    col1 - First collection.
        '               col2 - Second collection.
        'Returns:       New unioned collection.

        Dim colNew As RuleStream.Kernel.rsCollection
        Dim varItem As Object

        colNew = New RuleStream.Kernel.rsCollection

        If col1.Count() > 0 Then
            For Each varItem In col1
                colNew.Add(varItem)
            Next varItem
        End If

        If col2.Count() > 0 Then
            For Each varItem In col2
                colNew.Add(varItem)
            Next varItem
        End If



        UnionCollections = colNew
    End Function


    Public Function UnionCollections(ByVal col1 As RuleStream.Kernel.rsCollection, ByVal col2 As Collection) As RuleStream.Kernel.rsCollection
        'Purpose:       Union two collections.  Combines two collections without regard for the keys.
        '               Assumes their are not identical elements in the two collections
        'Parameters:    col1 - First collection.
        '               col2 - Second collection.
        'Returns:       New unioned collection.

        Dim colNew As RuleStream.Kernel.rsCollection
        Dim varItem As Object

        colNew = New RuleStream.Kernel.rsCollection

        If col1.Count() > 0 Then
            For Each varItem In col1
                colNew.Add(varItem)
            Next varItem
        End If

        If col2.Count() > 0 Then
            For Each varItem In col2
                colNew.Add(varItem)
            Next varItem
        End If

        UnionCollections = colNew
    End Function

    Public Function GetPartsOfType(ByRef colParts As Collection, ByVal strTypeName As String) As Object
        'Purpose:        Create a colleciton of commonly typed parts.
        'Parameters:     Collection - Collection of parts to parse
        '                String - Named type to collect
        'Returns:        New Colleciton of commonly typed parts.

        Dim newCol As Collection
        newCol = New Collection
        Dim p As Object

        strTypeName = UCase(strTypeName)

        If colParts.Count() > 0 Then
            For Each p In colParts
                If UCase(p.PartFamily) = strTypeName Then
                    newCol.Add(p, p.ReferenceName)
                End If
            Next p
        End If

        GetPartsOfType = newCol
    End Function

    Public Function GetPartsOfType(ByRef colParts As RuleStream.Kernel.rsCollection, ByVal strTypeName As String) As RuleStream.Kernel.rsCollection
        'Purpose:        Create a colleciton of commonly typed parts.
        'Parameters:     Collection - Collection of parts to parse
        '                String - Named type to collect
        'Returns:        New Colleciton of commonly typed parts.

        Dim newCol As New RuleStream.Kernel.rsCollection
        Dim p As Object

        strTypeName = UCase(strTypeName)

        If colParts.Count() > 0 Then
            For Each p In colParts
                If UCase(p.PartFamily) = strTypeName Then
                    newCol.Add(p, p.ReferenceName)
                End If
            Next p
        End If

        GetPartsOfType = newCol
    End Function

    Public Function GetPartsNotOfType(ByRef colParts As Collection, ByVal strTypeName As String) As Object
        'Purpose:        Create a colleciton of parts not of input type.
        'Parameters:     Collection - Collection of parts to parse
        '                String - Named type NOT to collect
        'Returns:        New Colleciton of parts excluding named type.

        Dim newCol As Collection
        newCol = New Collection
        Dim p As Object

        strTypeName = UCase(strTypeName)

        If colParts.Count() > 0 Then
            For Each p In colParts
                If UCase(p.PartFamily) <> strTypeName Then
                    newCol.Add(p, p.ReferenceName)
                End If
            Next p
        End If

        GetPartsNotOfType = newCol
    End Function

    Public Function GetPartsNotOfType(ByRef colParts As RuleStream.Kernel.rsCollection, ByVal strTypeName As String) As RuleStream.Kernel.rsCollection
        'Purpose:        Create a colleciton of parts not of input type.
        'Parameters:     Collection - Collection of parts to parse
        '                String - Named type NOT to collect
        'Returns:        New Colleciton of parts excluding named type.

        Dim newCol As New RuleStream.Kernel.rsCollection
        Dim p As Object

        strTypeName = UCase(strTypeName)

        If colParts.Count() > 0 Then
            For Each p In colParts
                If UCase(p.PartFamily) <> strTypeName Then
                    newCol.Add(p, p.ReferenceName)
                End If
            Next p
        End If

        GetPartsNotOfType = newCol
    End Function

    Public Function RootPart() As Object
        'Purpose:        Used get to the top part.
        'Parameters:
        'Returns:        The top part.

        RootPart = g_ObjectManager.GlobalObjectTable(1)
    End Function

    Public Function SortCollection(ByRef colToBeSorted As Object, Optional ByVal bDescending As Boolean = True) As Collection
        'Purpose:        Returns a sorted collection by either ascending or descending order.
        'Parameters:     Collection -  Collection to be sorted.
        '                Boolean - Sort order.  Descending is default
        'Returns:        Sorted collection.

        On Error GoTo DoSortError

        Dim i As Short

        Dim vKeys() As Object

        Dim oTemp As Object
        Dim vTempKey As Object
        Dim bSwapped As Boolean

        Dim colSorted As Collection

        'Define arrays for Objects and their SortKeys in the collection.
        i = colToBeSorted.Count
        If i = 0 Then
            SortCollection = New Collection
            Exit Function
        End If
        ReDim vKeys(i)

        'Create array of Objects and Keys.
        i = 1
        For Each oTemp In colToBeSorted
            vKeys(i) = colToBeSorted(i)
            i = i + 1
        Next oTemp

        'Using Bubble Sort algorithm, sort the objects in the array by the key.
        If bDescending Then
            Do
                bSwapped = False
                For i = 1 To UBound(vKeys) - 1
                    If vKeys(i) < vKeys(i + 1) Then 'descending
                        'Swap keys
                        vTempKey = vKeys(i)
                        vKeys(i) = vKeys(i + 1)
                        vKeys(i + 1) = vTempKey
                        bSwapped = True
                    End If
                Next i
            Loop While bSwapped
        Else
            Do
                bSwapped = False
                For i = 1 To UBound(vKeys) - 1
                    If vKeys(i) > vKeys(i + 1) Then 'ascending
                        'Swap keys
                        vTempKey = vKeys(i)
                        vKeys(i) = vKeys(i + 1)
                        vKeys(i + 1) = vTempKey
                        bSwapped = True
                    End If
                Next i
            Loop While bSwapped
        End If

        'Create a sorted collection from the sorted array.
        colSorted = New Collection
        For i = 1 To UBound(vKeys)
            colSorted.Add(vKeys(i))
        Next i

        SortCollection = colSorted
        Exit Function

DoSortError:
        g_ObjectManager.LogError("Common" & ".SortCollection", "  Error Number: " & Err.Number & vbCrLf & "  Description: " & Err.Description)
    End Function

    Public Function SortCollection(ByRef colToBeSorted As RuleStream.Kernel.rsCollection, Optional ByVal bDescending As Boolean = True) As RuleStream.Kernel.rsCollection
        'Purpose:        Returns a sorted collection by either ascending or descending order.
        'Parameters:     Collection -  Collection to be sorted.
        '                Boolean - Sort order.  Descending is default
        'Returns:        Sorted collection.

        On Error GoTo DoSortError

        Dim SortedArray As New ArrayList
        Dim oItem As Object
        Dim ReturnCollection As RuleStream.Kernel.rsCollection

        For Each oItem In colToBeSorted
            SortedArray.Add(oItem)
        Next

        SortedArray.Sort()

        If bDescending Then
            SortedArray.Reverse()
        End If

        ReturnCollection = New RuleStream.Kernel.rsCollection
        For Each oItem In SortedArray
            ReturnCollection.Add(oItem)
        Next

        Return ReturnCollection

DoSortError:
        g_ObjectManager.LogError("Common" & ".SortCollection", "  Error Number: " & Err.Number & vbCrLf & "  Description: " & Err.Description)
    End Function

    Public Function RemoveDuplicatesFromCollection(ByRef colToBeModified As Object) As Collection
        'Purpose:        Removes duplicates from a collection.
        'Parameters:     Collection - Collection to be analyzed.
        'Returns:        Collection of unique items.

        On Error GoTo DoRemoveDupError

        Dim i As Short
        Dim vKeys() As Object

        Dim oTemp As Object

        Dim colModified As Collection

        colModified = New Collection

        'Define arrays for Objects and their SortKeys in the collection.
        i = colToBeModified.Count
        If i = 0 Then
            RemoveDuplicatesFromCollection = New Collection
            Exit Function
        End If

        ReDim vKeys(i - 1)

        'Create array of Objects and Keys.
        i = 1
        For Each oTemp In colToBeModified
            vKeys(i - 1) = colToBeModified(i)
            i = i + 1
        Next oTemp

        'Only collect keys that are different.
        For i = LBound(vKeys) To UBound(vKeys)
            If i = LBound(vKeys) Then
                colModified.Add(vKeys(i))
            ElseIf vKeys(i) <> vKeys(i - 1) Then
                colModified.Add(vKeys(i))
            End If
        Next i

        RemoveDuplicatesFromCollection = colModified
        Exit Function

DoRemoveDupError:
        g_ObjectManager.LogError("Common" & ".RemoveDuplicatesFromCollection", "  Error Number: " & Err.Number & vbCrLf & "  Description: " & Err.Description)
    End Function

    Public Function RemoveDuplicatesFromCollection(ByRef colToBeModified As RuleStream.Kernel.rsCollection) As RuleStream.Kernel.rsCollection
        'Purpose:        Removes duplicates from a collection.
        'Parameters:     Collection - Collection to be analyzed.
        'Returns:        Collection of unique items.

        On Error GoTo DoRemoveDupError

        Dim i As Short
        Dim vKeys() As Object

        Dim oTemp As Object

        Dim colModified As New RuleStream.Kernel.rsCollection

        'Define arrays for Objects and their SortKeys in the collection.
        i = colToBeModified.Count
        If i = 0 Then
            RemoveDuplicatesFromCollection = New RuleStream.Kernel.rsCollection
            Exit Function
        End If

        ReDim vKeys(i - 1)

        'Create array of Objects and Keys.
        i = 1
        For Each oTemp In colToBeModified
            vKeys(i - 1) = colToBeModified(i)
            i = i + 1
        Next oTemp

        'Only collect keys that are different.
        For i = LBound(vKeys) To UBound(vKeys)
            If i = LBound(vKeys) Then
                colModified.Add(vKeys(i))
            ElseIf vKeys(i) <> vKeys(i - 1) Then
                colModified.Add(vKeys(i))
            End If
        Next i

        RemoveDuplicatesFromCollection = colModified
        Exit Function

DoRemoveDupError:
        g_ObjectManager.LogError("Common" & ".RemoveDuplicatesFromCollection", "  Error Number: " & Err.Number & vbCrLf & "  Description: " & Err.Description)
    End Function

    Public Function IntToNull(ByVal strtemp As Object) As String
        If Len(Trim(strtemp)) = 0 Then
            IntToNull = "Null"
        Else
            IntToNull = strtemp
        End If
    End Function

    Public Function ObjToID(ByRef objTemp As Object) As String
        If objTemp Is Nothing Then
            ObjToID = "Null"
        Else
            ObjToID = objTemp.objId
        End If
    End Function

    Public Function ObjToNull(ByRef objTemp As Object) As Object
        If objTemp Is Nothing Then
            ObjToNull = System.DBNull.Value
        Else
            ObjToNull = objTemp.objId
        End If
    End Function

    Public Function ArraysEqual(ByVal firstArray As Object, ByVal secondArray As Object) As Boolean
        'Purpose:        Checks to see if two arrays are equal.
        'Parameters:     Variant - First array
        '                Variant - Second array
        'Returns:        True id arrays are equal, False if not.


        Dim l As Integer

        'If the lengths are not equal return FALSE
        If UBound(firstArray) - LBound(firstArray) <> UBound(secondArray) - LBound(secondArray) Then
            ArraysEqual = False
            Exit Function
        End If

        'For each member of the first array
        For l = LBound(firstArray) To UBound(firstArray)
            'Compare it with the corresponding element of the second array
            'If they are not equal return FALSE
            If firstArray(l) <> secondArray(l) Then
                ArraysEqual = False
                Exit Function
            End If
        Next l

        'If all elements passed equality test and the length are equal then
        'the arrays are equal, return TRUE
        ArraysEqual = True
    End Function

    Public Function UpTreeRef(ByRef obj As Object, ByVal strPropName As String, ByVal varDefaultValue As Object) As Object
        'Purpose:        Reference up the tree automatically.   This function will automatically walk up
        '                the tree looking for the first occurrence of a named property.
        'Parameters:     Object - Starting point of the reference.
        '                String - Property name to search.
        '                Variant -  Default value if the search results in walking the entire tree and
        '                           does not find the named property.
        'Returns:

        Dim oProp As RuleStream.Kernel.PropertySF
        Dim curobj As Object


        'issue 3081
        If obj Is Nothing Then
            UpTreeRef = varDefaultValue
            Exit Function
        End If

        curobj = obj
        oProp = KeyExists(curobj.Properties, strPropName)

        While oProp Is Nothing And Not curobj.Parent Is Nothing
            curobj = curobj.Parent
            oProp = KeyExists(curobj.Properties, strPropName)
        End While

        If oProp Is Nothing Then
            UpTreeRef = varDefaultValue
        Else
            UpTreeRef = oProp.Value
        End If

        curobj = Nothing
        oProp = Nothing

    End Function

    <Browsable(False)> Public Function BuildSQLStatement(ByVal selectList As String, ByVal tableName As String, ByVal whereClause As String, ByVal sortBy As String, ByVal sortOrder As String) As String
        Dim selectStmt As String = String.Empty
        Dim leftDelimiter As String = String.Empty
        Dim rightDelimiter As String = String.Empty

        Select Case g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType
            Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.MSAccess, RuleStream.DataService.PublicEnumerations.DatabaseTypes.SQLServer
                leftDelimiter = "["
                rightDelimiter = "]"

            Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.Oracle
                leftDelimiter = """"
                rightDelimiter = """"

        End Select

        If Not sortBy.StartsWith(leftDelimiter) Then
            sortBy = String.Format("{0}{1}", leftDelimiter, sortBy)
        End If

        If Not sortBy.EndsWith(rightDelimiter) Then
            sortBy = String.Format("{0}{1}", sortBy, rightDelimiter)
        End If

        If sortBy <> String.Format("{0}{1}", leftDelimiter, rightDelimiter) And Not selectList.Contains(sortBy) Then
            selectList = selectList & sortBy
        Else
            selectList = selectList.Substring(0, selectList.Length - 2)
        End If

        If whereClause <> String.Empty Then whereClause = String.Format(" Where {0}", whereClause)

        selectStmt = String.Format("Select Distinct {0} From {1} {2}", selectList, tableName, whereClause)

        If sortBy <> String.Format("{0}{1}", leftDelimiter, rightDelimiter) Then
            selectStmt = String.Format("{0} Order By {1} {2}", selectStmt, sortBy, sortOrder)
        End If

        Return selectStmt

    End Function

    <Browsable(False)> Public Sub BuildWhereClause(ByRef whereClause As String, ByVal beginParensCount As String, ByVal endParensCount As String, ByVal andOR As String, ByVal columnName As String, ByVal stringOperator As String, ByVal propSpecVal As Object, ByVal columnType As String)

        Dim count As Integer
        Dim beginParens As String = String.Empty
        Dim endParens As String = String.Empty
        Dim propertyValue As String = String.Empty
        Dim isAppendN As Boolean = False

        Integer.TryParse(beginParensCount, count)
        If count < 0 Then count = 0
        beginParens = New String("("c, count)

        Integer.TryParse(endParensCount, count)
        If count < 0 Then count = 0
        endParens = New String(")"c, count)

        If Not stringOperator.ToUpper.Contains("NULL") Then
            If TypeOf propSpecVal Is RuleStream.Kernel.PropertySF Then
                propSpecVal = CType(propSpecVal, RuleStream.Kernel.PropertySF).DisplayValue
            End If

            If TypeName(propSpecVal) = "String" Then
                propertyValue = propSpecVal.ToString

                If Not String.IsNullOrEmpty(propertyValue) Then
                    isAppendN = True
                End If

                If stringOperator.ToUpper = "IN" OrElse stringOperator.ToUpper = "NOT IN" Then
                    'assume array of comma delimited strings, numbers or dates
                    Dim strParts() As String
                    strParts = Split(propertyValue, ",")
                    For i As Integer = 0 To strParts.Length - 1
                        'depending if the content is a number or date or string you'll have to add ''
                        Dim adate As Date = Nothing
                        If DateTime.TryParse(strParts(i), System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, adate) Then
                            strParts(i) = String.Format("'{0}'", strParts(i))
                        ElseIf IsNumeric(strParts(i)) Then
                            strParts(i) = String.Format("{0}", strParts(i))
                        Else
                            'strings
                            strParts(i) = String.Format("N'{0}'", Trim(strParts(i)).Replace("'", "''"))
                        End If
                    Next
                    propertyValue = String.Format("({0})", Join(strParts, ","))
                    'when user gives hardcoded list in the "IN/NOT IN" clause like "'Red','Green','Blue'" the appropriate quotes are already there and still the above logic puts the additional quotes which is causing problem. 
                    'But for the cases where user puts variable name, it Is required to put quotes. Hence, below logic to remove extra quotes.
                    propertyValue = Regex.Replace(propertyValue, "'+", "'")

                    isAppendN = False
                ElseIf stringOperator.ToUpper = "LIKE" AndAlso Not propertyValue.Contains("%") Then
                    propertyValue = String.Format("'%{0}%'", propertyValue.Replace("'", "''"))
                Else
                    propertyValue = String.Format("'{0}'", propertyValue.Replace("'", "''"))
                End If
            ElseIf TypeName(propSpecVal) = "Date" Then
                propertyValue = String.Format("'{0}'", CType(propSpecVal, Date).ToString("G", Globalization.CultureInfo.InvariantCulture))

            ElseIf TypeName(propSpecVal) = "Boolean" Then
                If g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType = RuleStream.DataService.DatabaseTypes.MSAccess Then
                    If propSpecVal Then
                        propertyValue = "True"
                    Else
                        propertyValue = "False"
                    End If
                Else
                    propertyValue = System.Math.Abs(CType(propSpecVal, Integer)).ToString
                End If
            ElseIf TypeName(propSpecVal) = "Double" Then
                propertyValue = CType(propSpecVal, Double).ToString("G", Globalization.CultureInfo.InvariantCulture)
            ElseIf TypeName(propSpecVal) = "Decimal" Then
                propertyValue = CType(propSpecVal, Decimal).ToString("G", Globalization.CultureInfo.InvariantCulture)
            Else
                propertyValue = propSpecVal.ToString

            End If

        End If

        If isAppendN Then
            whereClause = String.Format("{0} {1} {2} {3} {4} N{5} {6}", whereClause, andOR, beginParens, DelimitColumnName(columnName), stringOperator, propertyValue, endParens)
        Else
            whereClause = String.Format("{0} {1} {2} {3} {4} {5} {6}", whereClause, andOR, beginParens, DelimitColumnName(columnName), stringOperator, propertyValue, endParens)
        End If

    End Sub


    <Browsable(False)> Public Function FormatCriteria(ByVal varPropSpecVal As Object, Optional ByVal NVarcharForString As Boolean = True) As String
        'NVarcharForString - Pur "N" for string or not
        If TypeName(varPropSpecVal) = "PropertySF" Then
            varPropSpecVal = varPropSpecVal.Value
        End If

        If TypeName(varPropSpecVal) = "String" Then
            If (NVarcharForString = True) Then
                If String.IsNullOrEmpty(varPropSpecVal) Then
                    FormatCriteria = "N''"
                Else
                    FormatCriteria = "N'" & varPropSpecVal & "'"
                    FormatCriteria = Regex.Replace(FormatCriteria, "'+", "'") 'Removing extra quotes which causes problem
                End If
            Else
                FormatCriteria = "'" & varPropSpecVal & "'"
                FormatCriteria = Regex.Replace(FormatCriteria, "'+", "'") 'Removing extra quotes which causes problem
            End If
        ElseIf TypeName(varPropSpecVal) = "Date" Then
            FormatCriteria = "'" & CType(varPropSpecVal, Date).ToString("G", Globalization.CultureInfo.InvariantCulture) & "'"
        ElseIf TypeName(varPropSpecVal) = "Boolean" Then
            If g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType = RuleStream.DataService.DatabaseTypes.MSAccess Then
                If varPropSpecVal Then
                    FormatCriteria = "True"
                Else
                    FormatCriteria = "False"
                End If
            Else
                FormatCriteria = CStr(System.Math.Abs(CShort(varPropSpecVal)))
            End If
        ElseIf IsNothing(varPropSpecVal) Then
            FormatCriteria = "null"
        ElseIf TypeName(varPropSpecVal) = "Double" Then
            FormatCriteria = CType(varPropSpecVal, Double).ToString("G", Globalization.CultureInfo.InvariantCulture)
        ElseIf TypeName(varPropSpecVal) = "Decimal" Then
            FormatCriteria = CType(varPropSpecVal, Decimal).ToString("G", Globalization.CultureInfo.InvariantCulture)
        Else
            FormatCriteria = CStr(varPropSpecVal)
        End If
    End Function

    Public Function Ceiling(ByVal theNumber As Double) As Double
        'Purpose:        Gets the Ceiling of a number.
        'Parameters:     Double - Numeric value
        'Returns:        The next higher integer value of a number
        '                Ex Ceiling (7.25) = 8.0

        If Fix(theNumber) <> theNumber Then
            If theNumber >= 0.0# Then
                Ceiling = Fix(theNumber) + 1.0#
            Else
                Ceiling = Fix(theNumber)
            End If
        Else
            Ceiling = theNumber
        End If
    End Function

    Public Function Floor(ByVal theNumber As Double) As Double
        'Purpose:        Gets the Floor of a number.
        'Parameters:     Double - Numeric value
        'Returns:        The next lower integer value of a number
        '                Ex Floor (7.25) = 7.0

        If Fix(theNumber) <> theNumber Then
            If theNumber >= 0.0# Then
                Floor = Fix(theNumber)
            Else
                Floor = Fix(theNumber - 1)
            End If
        Else
            Floor = theNumber
        End If
    End Function

    Public Function RoundUp(ByVal theIncrement As Double, ByVal theNumber As Double) As Double
        'Purpose:        Rounds a number up to an increment.
        'Parameters:     Double - The increment to round to.
        '                Double - Numeric value to roundup.
        'Returns:        New Rounded up number.
        '                Ex RoundUp (0.125,7.28125 ) = 7.375

        RoundUp = Ceiling(theNumber / theIncrement) * theIncrement
    End Function

    Public Function RoundDown(ByVal theIncrement As Double, ByVal theNumber As Double) As Double
        'Purpose:        Rounds a number down to an increment.
        'Parameters:     Double - The increment to round to.
        '                Double - Numeric value to roundup.
        'Returns:        New Rounded down number.
        '                Ex RoundDown (0.125,7.28125 ) = 7.25

        RoundDown = Floor(theNumber / theIncrement) * theIncrement
    End Function

    Public Function Rounding(ByVal theIncrement As Double, ByVal theNumber As Double) As Double
        'Purpose:        Rounds a number to the closest increment.
        'Parameters:     Double - The increment to round to.
        '                Double - Numeric value to round.
        'Returns:        New Rounded number.
        '                Ex Rounding(0.125, 7.28125) = 7.25

        Rounding = System.Math.Round(theNumber / theIncrement, 0) * theIncrement
    End Function

    Public Function DegreesToRadians(ByVal theDegrees As Double) As Double
        'Purpose:        Converts Degrees to Radians
        'Parameters:     Double - Numeric value
        'Returns:        New value in radians.

        DegreesToRadians = theDegrees * (3.14159265358979 / 180.0#)
    End Function

    Public Function RadiansToDegrees(ByVal theRadians As Double) As Double
        'Purpose:        Converts Radians to Degrees
        'Parameters:     Double - Numeric value.
        'Returns:        New Value in degrees.

        RadiansToDegrees = theRadians * (180.0# / 3.14159265358979)
    End Function

    Public Function Min(ByVal arg1 As Object, ByVal arg2 As Object) As Object
        'Purpose:        Determine the minimum of the two input values.
        'Parameters:     Variant - First Value
        '                Variant - Second Value
        'Returns:        Minimum of the two input values.

        Min = IIf(arg1 < arg2, arg1, arg2)
    End Function

    Public Function Max(ByVal arg1 As Object, ByVal arg2 As Object) As Object
        'Purpose:        Determine the maximum of the two input values.
        'Parameters:     Variant - First Value
        '                Variant - Second Value
        'Returns:        Maximum of the two input values.

        Max = IIf(arg1 > arg2, arg1, arg2)
    End Function

    ''' <summary>
    ''' Returns the Secant of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function Sec(ByVal number As Double) As Double

        Sec = 1.0# / System.Math.Cos(number)
    End Function

    ''' <summary>
    ''' Returns the Cosecant of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function CoSec(ByVal number As Double) As Double

        CoSec = 1.0# / System.Math.Sin(number)
    End Function

    ''' <summary>
    ''' Returns the Cotangent of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function CoTan(ByVal number As Double) As Double

        CoTan = 1.0# / System.Math.Tan(number)
    End Function

    ''' <summary>
    ''' Returns the Arc Sine of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function ASin(ByVal number As Double) As Double

        ASin = System.Math.Atan(number / System.Math.Sqrt(-number * number + 1))
    End Function

    ''' <summary>
    ''' Returns the Arc Cosine of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function ACos(ByVal number As Double) As Double

        ACos = System.Math.Atan(-number / System.Math.Sqrt(-number * number + 1)) + 2 * System.Math.Atan(1)
    End Function

    ''' <summary>
    ''' Returns the Arc Secant of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function ASec(ByVal number As Double) As Double

        ASec = System.Math.Atan(number / System.Math.Sqrt(number * number - 1)) + System.Math.Sign((number) - 1) * (2 * System.Math.Atan(1))
    End Function

    ''' <summary>
    ''' Returns the Arc Cosecant of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function ACoSec(ByVal number As Double) As Double

        ACoSec = System.Math.Atan(number / System.Math.Sqrt(number * number - 1)) + (System.Math.Sign(number) - 1) * (2 * System.Math.Atan(1))
    End Function

    ''' <summary>
    ''' Returns the Arc Cotangent of the number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.Double.</returns>
    Public Function ACoTan(ByVal number As Double) As Double

        ACoTan = System.Math.Atan(number) + 2 * System.Math.Atan(1)
    End Function

    ''' <summary>
    ''' Returns the value of a point 3D as a locale invariant string in the form x,y,z.
    ''' </summary>
    ''' <param name="x">The x value that forms the point3D value as double values, i.e. me.Color_X, me.Color_Y, me.Color_Z where the Color_X etc. are properties of type double.</param>
    ''' <param name="y">The y value that forms the point3D value as double values, i.e. me.Color_X, me.Color_Y, me.Color_Z where the Color_X etc. are properties of type double.</param>
    ''' <param name="z">The z value that forms the point3D value as double values, i.e. me.Color_X, me.Color_Y, me.Color_Z where the Color_X etc. are properties of type double.</param>
    ''' <returns>System.String - the point 3D string parsed in invariant locale: i.e. "123.45,234.56,0".</returns>
    Public Function GetPoint3DString(ByVal x As Double, ByVal y As Double, ByVal z As Double) As String

        On Error Resume Next
        GetPoint3DString = x.ToString("G", System.Globalization.CultureInfo.InvariantCulture) & "," & y.ToString("G", System.Globalization.CultureInfo.InvariantCulture) & "," & z.ToString("G", System.Globalization.CultureInfo.InvariantCulture)
    End Function

    ''' <summary>
    ''' Returns the value of a point 2D as a locale invariant string in the form x,y.
    ''' </summary>
    ''' <param name="x">The x value that forms the point3D value as double values, i.e. me.Color_X, me.Color_Y where the Color_X and Color_Y are properties of type double.</param>
    ''' <param name="y">The y value that forms the point3D value as double values, i.e. me.Color_X, me.Color_Y where the Color_X and Color_Y are properties of type double.</param>
    ''' <returns>System.String - the point 2D string parsed in invariant locale: i.e. "123.45,234.56".</returns>
    Public Function GetPoint2DString(ByVal x As Double, ByVal y As Double) As String

        On Error Resume Next
        GetPoint2DString = x.ToString("G", System.Globalization.CultureInfo.InvariantCulture) & "," & y.ToString("G", System.Globalization.CultureInfo.InvariantCulture)
    End Function


    ''' <summary>
    ''' Returns the value of the X coordinate of a point.
    ''' </summary>
    ''' <param name="Point">The point - a string in the format: x,y or x,y,z.</param>
    ''' <returns>System.Double - The Numeric value of the X coordinate.</returns>
    Public Function GetX(ByVal Point As String) As Double

        On Error Resume Next
        Dim strCoordinates() As String
        strCoordinates = Split(Point, ",")

        GetX = Double.Parse(strCoordinates(0), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture)
    End Function

    ''' <summary>
    ''' Returns the value of the Y coordinate of a point.
    ''' </summary>
    ''' <param name="Point">The point - a string in the format: x,y or x,y,z.</param>
    ''' <returns>System.Double - The Numeric value of the Y coordinate.</returns>
    Public Function GetY(ByVal Point As String) As Double

        On Error Resume Next
        Dim strCoordinates() As String
        strCoordinates = Split(Point, ",")
        GetY = Double.Parse(strCoordinates(1), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture)
    End Function

    ''' <summary>
    ''' Returns the value of the Z coordinate of a point.
    ''' </summary>
    ''' <param name="Point">The point - a string in the format: x,y,z.</param>
    ''' <returns>System.Double - The Numeric value of the Z coordinate.</returns>
    Public Function GetZ(ByVal Point As String) As Double

        On Error Resume Next
        Dim strCoordinates() As String
        strCoordinates = Split(Point, ",")
        GetZ = Double.Parse(strCoordinates(2), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture)
    End Function

    ''' <summary>
    ''' Sets the X coordinate value of a point.
    ''' </summary>
    ''' <param name="Point">The point - a string in the format: x,y or x,y,z.</param>
    ''' <param name="XValue">The new value for x.</param>
    ''' <returns>System.String in the format x,y or x,y,z.</returns>
    Public Function SetX(ByVal Point As String, ByVal XValue As Double) As String

        On Error GoTo Err_Handler

        Dim strCoordinates() As String
        strCoordinates = Split(Point, ",")
        strCoordinates(0) = XValue.ToString("G", System.Globalization.CultureInfo.InvariantCulture)
        SetX = Join(strCoordinates, ",")
        Exit Function

Err_Handler:
        SetX = Point
    End Function

    ''' <summary>
    ''' Sets the Y coordinate value of a point.
    ''' </summary>
    ''' <param name="Point">The point - a string in the format: x,y or x,y,z.</param>
    ''' <param name="YValue">The new value for y.</param>
    ''' <returns>System.String in the format x,y or x,y,z.</returns>
    Public Function SetY(ByVal Point As String, ByVal YValue As Double) As String

        On Error GoTo Err_Handler

        Dim strCoordinates() As String
        strCoordinates = Split(Point, ",")
        strCoordinates(1) = YValue.ToString("G", System.Globalization.CultureInfo.InvariantCulture)
        SetY = Join(strCoordinates, ",")
        Exit Function

Err_Handler:
        SetY = Point
    End Function

    ''' <summary>
    ''' Sets the Z coordinate value of a point.
    ''' </summary>
    ''' <param name="Point">The point - a string in the format: x,y,z.</param>
    ''' <param name="ZValue">The - new value for z.</param>
    ''' <returns>System.String in the format x,y,z.</returns>
    Public Function SetZ(ByVal Point As String, ByVal ZValue As Double) As String


        On Error GoTo Err_Handler

        Dim strCoordinates() As String
        strCoordinates = Split(Point, ",")
        strCoordinates(2) = ZValue.ToString("G", System.Globalization.CultureInfo.InvariantCulture)
        SetZ = Join(strCoordinates, ",")
        Exit Function

Err_Handler:
        SetZ = Point
    End Function

    ''' <summary>
    ''' Converts a VB Collection object to a delimited string.
    ''' </summary>
    ''' <param name="SourceCollection">The source VB Collection.</param>
    ''' <param name="Delimiter">The optional string delimiter (defaults to ",").</param>
    ''' <returns>System.String - The Delimited string.</returns>
    Public Function CollectionToString(ByVal SourceCollection As Collection, Optional ByVal Delimiter As String = ",") As String

        On Error GoTo Err_Handler

        Dim lngItems As Integer
        Dim i As Integer
        Dim strReturn As String = String.Empty

        lngItems = SourceCollection.Count()

        For i = 1 To lngItems
            strReturn &= Delimiter & CStr(SourceCollection.Item(i))
        Next

        CollectionToString = Mid(strReturn, Len(Delimiter) + 1)

        Exit Function

Err_Handler:
        CollectionToString = ""
        g_ObjectManager.LogError("Common.CollectionToString(VB)", Err.Description)
    End Function

    ''' <summary>
    ''' Converts a RuleStream.Kernel.rsCollection object to a delimited string.
    ''' </summary>
    ''' <param name="SourceCollection">The source RuleStream.Kernel.rsCollection.</param>
    ''' <param name="Delimiter">The optional string delimiter (defaults to ",").</param>
    ''' <returns>System.String - Delimited string.</returns>
    Public Function CollectionToString(ByVal SourceCollection As RuleStream.Kernel.rsCollection, Optional ByVal Delimiter As String = ",") As String

        On Error GoTo Err_Handler

        Dim lngItems As Integer
        Dim i As Integer
        Dim strReturn As String = String.Empty

        lngItems = SourceCollection.Count()

        For i = 1 To lngItems
            strReturn &= Delimiter & CStr(SourceCollection.Item(i))
        Next

        CollectionToString = Mid(strReturn, Len(Delimiter) + 1)

        Exit Function

Err_Handler:
        CollectionToString = ""
        g_ObjectManager.LogError("Common.CollectionToString()", Err.Description)
    End Function

    ''' <summary>
    ''' Converts a delimited string to a VB collection object.
    ''' </summary>
    ''' <param name="SourceString">The delimited source string.</param>
    ''' <param name="Delimiter">The optional string delimiter (defaults to ",").</param>
    ''' <returns>Collection object.</returns>
    Public Function StringToCollection(ByVal SourceString As String, Optional ByVal Delimiter As String = ",") As Collection

        On Error GoTo Err_Handler

        Dim strElement As String
        Dim colReturn As New Collection
        Dim arrSource() As String
        Dim i As Integer

        arrSource = Split(SourceString, Delimiter)

        For i = LBound(arrSource) To UBound(arrSource)
            colReturn.Add(arrSource(i))
        Next

        StringToCollection = colReturn
        Exit Function

Err_Handler:
        StringToCollection = Nothing
        g_ObjectManager.LogError("Common.StringToCollection()", Err.Description)
    End Function

    ''' <summary>
    ''' Converts a delimited string to a RuleStream.Kernel.rsCollection object.
    ''' </summary>
    ''' <param name="SourceString">The delimited source string.</param>
    ''' <param name="Delimiter">The optional string delimiter (defaults to ",").</param>
    ''' <returns>RuleStream.Kernel.rsCollection object.</returns>
    Public Function StringToRSCollection(ByVal SourceString As String, Optional ByVal Delimiter As String = ",") As RuleStream.Kernel.rsCollection


        On Error GoTo Err_Handler

        Dim strElement As String
        Dim colReturn As New RuleStream.Kernel.rsCollection
        Dim arrSource() As String
        Dim i As Integer

        arrSource = Split(SourceString, Delimiter)

        For i = LBound(arrSource) To UBound(arrSource)
            colReturn.Add(arrSource(i))
        Next

        StringToRSCollection = colReturn
        Exit Function

Err_Handler:
        StringToRSCollection = Nothing
        g_ObjectManager.LogError("Common.StringToRSCollection()", Err.Description)
    End Function

    ''' <summary>
    ''' Returns the <b>number</b> of elements in a delimited string.
    ''' </summary>
    ''' <param name="SourceString">The a delimited string to search.</param>
    ''' <param name="Delimiter">The optional string delimiter (defaults to ",").</param>
    ''' <returns>System.Int32 - Number of elements.</returns>
    Public Function ElementsInString(ByVal SourceString As String, Optional ByVal Delimiter As String = ",") As Integer

        Try
            If SourceString.Length = 0 Then
                'Mimic the behavior of the Split function in VB6.  If the Source String is empty, return -1.
                Return -1

            Else
                Return SourceString.Split(CChar(Delimiter.Substring(0, 1))).GetUpperBound(0) + 1

            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.ElementsInString()", ex.ToString)
            Return -1

        End Try

    End Function

    ''' <summary>
    ''' Returns a specific element of a delimited string.
    ''' </summary>
    ''' <param name="SourceString">The delimited string to search.</param>
    ''' <param name="ElementIndex">The (zero-based) index number of the desired element.</param>
    ''' <param name="Delimiter">optional string delimiter (defaults to ",").</param>
    ''' <returns>System.String.</returns>
    ''' <exception cref="System.Exception">The specified element index is outside the range of the string array".</exception>
    Public Function ElementInString(ByVal SourceString As String, ByVal ElementIndex As Integer, Optional ByVal Delimiter As String = ",") As String


        Dim arrSource() As String

        Try
            arrSource = Split(SourceString, Delimiter)

            If (ElementIndex >= LBound(arrSource)) And (ElementIndex <= UBound(arrSource)) Then
                Return arrSource(ElementIndex)
            Else
                Throw New Exception("The specified element index (" & CStr(ElementIndex) & ") is outside the range of the string array (" & LBound(arrSource) & " to " & UBound(arrSource) & ").")

            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.ElementInString()", ex.ToString)
            Return String.Empty

        End Try

        Exit Function
    End Function

    ''' <summary>
    ''' Return a collection of RuleStream part objects by stepping though a parent-child 
    ''' tree and returning all instances of a given part family.
    ''' </summary>
    ''' <param name="StartPart">The part instance where the traverse starts.</param>
    ''' <param name="FindPartName">The name of the part family to collect.
    '''                            If a null string is passed then all subparts are returned.</param>
    ''' <param name="IncludeSubparts">Traverse the child relationship [Boolean, defaults to True].</param>
    ''' <param name="IncludeConnections">Traverse the connection relationship [Boolean, defaults to False].</param>
    ''' <remarks><b>WARNING: DO NOT</b> call this from a Part that is on the branch that is to be traversed, as that will cause a 
    ''' Circularity Error if this part is hit during the traversal.</remarks>
    ''' <returns>
    '''   Collection object of the collection.
    ''' </returns>
    Public Function Traverse(ByRef StartPart As RuleStream.Kernel.Part,
                             Optional ByVal FindPartName As String = "",
                             Optional ByVal IncludeSubparts As Boolean = True,
                             Optional ByVal IncludeConnections As Boolean = False) As Collection

        Dim partsCollection As Collection = Nothing

        Try
            TraverseBranchForCollection(StartPart, FindPartName, partsCollection, IncludeSubparts, IncludeConnections)

        Catch ex As Exception
            partsCollection = Nothing
            g_ObjectManager.LogError("Common.Traverse().", ex.ToString)

        End Try

        Return partsCollection

    End Function

    ''' <summary>
    ''' Traverses the branch to create a collection.
    ''' </summary>
    ''' <param name="StartPart">The start part.</param>
    ''' <param name="FindPartName">Name of the part to find, or String.Empty to gather all.</param>
    ''' <param name="PartsCollection">The parts collection generated by the traversal.</param>
    ''' <param name="IncludeSubparts">Traverse the child relationship [Boolean, defaults to True].</param>
    ''' <param name="IncludeConnections">Traverse the connection relationship [Boolean, defaults to False].</param>
    ''' <remarks><b>WARNING: DO NOT</b> call this from a Part that is on the branch that is to be traversed, as that will cause a 
    ''' Circularity Error if this part is hit during the traversal.</remarks>

    Private Sub TraverseBranchForCollection(ByRef StartPart As RuleStream.Kernel.Part,
                                            ByVal FindPartName As String,
                                            ByRef PartsCollection As Collection,
                                            Optional ByVal IncludeSubparts As Boolean = True,
                                            Optional ByVal IncludeConnections As Boolean = False)

        Try
            If PartsCollection Is Nothing Then
                PartsCollection = New Collection
            End If

            If StartPart IsNot Nothing Then
                If IncludeSubparts Then

                    For Each subpartInstance As RuleStream.Kernel.Subpart In StartPart.Subparts
                        If subpartInstance IsNot Nothing Then

                            For Each partInstance As RuleStream.Kernel.Part In subpartInstance.Parts
                                If partInstance IsNot Nothing Then
                                    If FindPartName.Length = 0 Or partInstance.PartFamily = FindPartName Then
                                        PartsCollection.Add(partInstance)
                                    End If
                                    TraverseBranchForCollection(partInstance, FindPartName, PartsCollection, IncludeSubparts, IncludeConnections)
                                End If
                            Next

                        End If
                    Next

                End If

                If IncludeConnections Then
                    For Each connectionInstance As RuleStream.Kernel.Connection In StartPart.Connections
                        If connectionInstance IsNot Nothing Then

                            For Each partInstance As RuleStream.Kernel.Part In connectionInstance.Parts
                                If partInstance IsNot Nothing Then
                                    If partInstance.PartFamily = FindPartName Then
                                        PartsCollection.Add(partInstance)
                                    End If
                                End If
                            Next

                        End If
                    Next

                End If
            End If

        Catch ex As Exception
            Dim message As String = String.Format("StartPart: <{0}>, FindPartName: <{1}>.  Exception:", StartPart.Name, FindPartName)
            g_ObjectManager.LogError("Common.TraverseBranchForCollection()", message + vbcrlf + ex.ToString)

        End Try

    End Sub

    ''' <summary>
    ''' Return an RsCollection of RuleStream part objects by stepping though a parent-child 
    ''' tree and returning all instances of a given part family.
    ''' </summary>
    ''' <param name="StartPart">The part instance where the traverse starts.</param>
    ''' <param name="FindPartName">The name of the part family to collect.
    '''                            If a null string is passed then all subparts are returned.</param>
    ''' <param name="IncludeSubparts">Traverse the child relationship [Boolean, defaults to True].</param>
    ''' <param name="IncludeConnections">Traverse the connection relationship [Boolean, defaults to False].</param>
    ''' <remarks><b>WARNING: DO NOT</b> call this from a Part that is on the branch that is to be traversed, as that will cause a 
    ''' Circularity Error if this part is hit during the traversal.</remarks>
    ''' <returns>
    '''   RsCollection object of the collection.
    ''' </returns>
    Public Function TraverseCollection(ByRef StartPart As RuleStream.Kernel.Part,
                                       Optional ByVal FindPartName As String = "",
                                       Optional ByVal IncludeSubparts As Boolean = True,
                                       Optional ByVal IncludeConnections As Boolean = False) As RuleStream.Kernel.rsCollection

        Dim partsCollection As RuleStream.Kernel.rsCollection = Nothing

        Try
            TraverseBranchForRsCollection(StartPart, FindPartName, partsCollection, IncludeSubparts, IncludeConnections)

        Catch ex As Exception
            partsCollection = Nothing
            g_ObjectManager.LogError("Common.TraverseCollection", ex.ToString)

        End Try

        Return partsCollection

    End Function

    ''' <summary>
    ''' Traverses the branch for RuleStream.Kernel.rsCollection.
    ''' </summary>
    ''' <param name="StartPart">The part instance where the traverse starts.</param>
    ''' <param name="FindPartName">Name of the part to find.</param>
    ''' <param name="PartsCollection">The parts RuleStream.Kernel.rsCollection generated by the traversal.</param>
    ''' <param name="IncludeSubparts">Traverse the child relationship [Boolean, defaults to True].</param>
    ''' <param name="IncludeConnections">Traverse the connection relationship [Boolean, defaults to False].</param>
    ''' <remarks><b>WARNING: DO NOT</b> call this from a Part that is on the branch that is to be traversed, as that will cause a 
    ''' Circularity Error if this part is hit during the traversal.</remarks>
    Private Sub TraverseBranchForRsCollection(ByRef StartPart As RuleStream.Kernel.Part, ByVal FindPartName As String, ByRef PartsCollection As RuleStream.Kernel.rsCollection, Optional ByVal IncludeSubparts As Boolean = True, Optional ByVal IncludeConnections As Boolean = False)

        Try
            If PartsCollection Is Nothing Then
                PartsCollection = New RuleStream.Kernel.rsCollection
            End If

            If StartPart IsNot Nothing Then
                If IncludeSubparts Then

                    For Each subpartInstance As RuleStream.Kernel.Subpart In StartPart.Subparts
                        If subpartInstance IsNot Nothing Then

                            For Each partInstance As RuleStream.Kernel.Part In subpartInstance.Parts
                                If partInstance IsNot Nothing Then
                                    If FindPartName.Length = 0 Or partInstance.PartFamily = FindPartName Then
                                        PartsCollection.Add(partInstance)
                                    End If
                                    TraverseBranchForRsCollection(partInstance, FindPartName, PartsCollection, IncludeSubparts, IncludeConnections)
                                End If
                            Next

                        End If
                    Next

                End If

                If IncludeConnections Then
                    For Each connectionInstance As RuleStream.Kernel.Connection In StartPart.Connections
                        If connectionInstance IsNot Nothing Then

                            For Each partInstance As RuleStream.Kernel.Part In connectionInstance.Parts
                                If partInstance IsNot Nothing Then
                                    If partInstance.PartFamily = FindPartName Then
                                        PartsCollection.Add(partInstance)
                                    End If
                                End If
                            Next

                        End If
                    Next

                End If
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.TraverseBranchForRsCollection", ex.ToString)

        End Try

    End Sub

    ''' <summary>
    ''' Execute Matrix Query Language command to allow access to Matrix PDM data at runtime.
    ''' </summary>
    ''' <param name="strMQLCommand">The command to be executed.</param>
    ''' <param name="strResults">Return data from the query.</param>
    ''' <param name="strErrorMsg">Error message if the query fails.</param>
    ''' <returns><c>true</c> if query was successful, <c>false</c> otherwise.</returns>
    Public Function ExecuteMatrixQuery(ByVal strMQLCommand As String, ByRef strResults As String, ByRef strErrorMsg As String) As Boolean

        Dim result As Boolean = False

        Dim sResults As String = String.Empty

        Dim iMatrix As RuleStream.DocumentManager.IRsMatrixManager

        Try
            iMatrix = CType(g_DocAccess, RuleStream.DocumentManager.IRsMatrixManager)

            If iMatrix.ExecutePassThruMQL(strMQLCommand, sResults) Then
                strResults = sResults
                result = True
            Else
                strErrorMsg = iMatrix.Errors.Item(0).Description
            End If

        Catch ex As Exception
            strErrorMsg = "ExecuteMatrixQuery is only valid with Matrix integration."
        End Try

        Return result

    End Function

    ''' <summary>
    ''' Lookup data from the SmarTeam PDM.
    ''' </summary>
    ''' <param name="strLookupTable">The string lookup table.</param>
    ''' <param name="strErrorMsg">returns any string error message from SmarTeam.</param>
    ''' <returns>Hashtable containing the results of call to SmarTeam.ReturnDataFromPDMLookup(strLookupTable).</returns>
    Public Function smPDMLookupData(ByVal strLookupTable As String, ByRef strErrorMsg As Object) As Hashtable

        Dim iSmarTeam As RuleStream.DocumentManager.IRsSmarTeamManager

        Try
            iSmarTeam = CType(g_DocAccess, RuleStream.DocumentManager.IRsSmarTeamManager)
            smPDMLookupData = iSmarTeam.ReturnDataFromPDMLookup(strLookupTable)

            If smPDMLookupData Is Nothing Then
                strErrorMsg = iSmarTeam.Errors.Item(1).Description
            End If

        Catch ex As Exception
            smPDMLookupData = Nothing
            strErrorMsg = "smPDMLookupData is only valid with the SmarTeam integration."
        End Try

    End Function

    ''' <summary>
    ''' Creates a new Collection object.
    ''' </summary>
    ''' <returns>Collection.</returns>
    Public Function NewCollection() As Collection
        Dim colReturn As New Collection

        NewCollection = colReturn
    End Function

    ''' <summary>
    ''' Creates a new RuleStream.Kernel.rsCollection object.
    ''' </summary>
    ''' <returns>RuleStream.Kernel.rsCollection.</returns>
    Public Function NewRSCollection() As RuleStream.Kernel.rsCollection

        Dim colReturn As New RuleStream.Kernel.rsCollection

        NewRSCollection = colReturn
    End Function

    ''' <summary>
    ''' Intersects two Collections.  Returns only the common elements of the two collections without regard for the keys.
    ''' </summary>
    ''' <param name="col1">The First collection.</param>
    ''' <param name="col2">The Second collection.</param>
    ''' <returns>Collection - Resulting New collection.</returns>
    Public Function IntersectCollections(ByVal col1 As Collection, ByVal col2 As Collection) As Collection

        Dim colNew As Collection
        Dim varItem1 As Object
        Dim varItem2 As Object

        colNew = New Collection

        If col1.Count() > 0 And col2.Count() > 0 Then
            For Each varItem1 In col1
                For Each varItem2 In col2
                    If varItem1 = varItem2 Then
                        colNew.Add(varItem1)
                        Exit For
                    End If
                Next varItem2
            Next varItem1
        End If

        IntersectCollections = colNew
    End Function

    ''' <summary>
    ''' Intersects two RuleStream.Kernel.rsCollections.  Returns only the common elements of the two collections without regard for the keys.
    ''' </summary>
    ''' <param name="col1">The First collection.</param>
    ''' <param name="col2">The Second collection.</param>
    ''' <returns>RuleStream.Kernel.rsCollection - Resulting New collection.</returns>
    Public Function IntersectCollections(ByVal col1 As RuleStream.Kernel.rsCollection, ByVal col2 As RuleStream.Kernel.rsCollection) As RuleStream.Kernel.rsCollection

        Dim colNew As RuleStream.Kernel.rsCollection
        Dim varItem1 As Object
        Dim varItem2 As Object

        colNew = New RuleStream.Kernel.rsCollection

        If col1.Count() > 0 And col2.Count() > 0 Then
            For Each varItem1 In col1
                For Each varItem2 In col2
                    If varItem1 = varItem2 Then
                        colNew.Add(varItem1)
                        Exit For
                    End If
                Next varItem2
            Next varItem1
        End If

        IntersectCollections = colNew
    End Function

    ''' <summary>
    ''' Processes a Mathcad document.  Calls <see cref="ProcessMathcadSheet"/>
    ''' </summary>
    ''' <param name="templateName">Template Name - Name of the MathCAD template to use.  Should be pulled from Master docs folder or PLM.</param>
    ''' <param name="inputParams">Input Variable List - Comma delimited string of variable name and value.  i.e. "Vn1,V1,Vn2,V2,Vn3,V3,…".</param>
    ''' <param name="outputParams">Output Variable List - Comma delimited string of variable names of values to be returned.  i.e. "Vn1,Vn2,Vn3,…".</param>
    ''' <returns>System.String - Comma delimited string of values for the values in the Output Variable List.</returns>
    ''' <remarks> <b>NOTE:</b> Variable names are CASE-SENSITIVE!!<br></br>
    '''       That means that Abc is NOT the same as abc, and if you try to look for a variable of the wrong case
    '''       it won't be found and will return a null string.
    '''   If an Input Variable isn't found, Mathcad doesn't throw an error, so you won't get a warning.</remarks>
    Public Function ProcessMathCadDoc(ByVal templateName As String, ByVal inputParams As String, ByVal outputParams As String) As String

        Dim workingFolder As String = Nothing
        Dim workingFile As String = Nothing
        Dim returnValue As String = String.Empty
        Dim docManager As RuleStream.DocumentManager.IRsDocumentManager
        Dim docAttributes As RuleStream.Specification.RsDocumentAttributes

        Try
            docManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)
            docAttributes = New RuleStream.Specification.RsDocumentAttributes(templateName)

            If docManager.GetMasterDocument(docAttributes, True) Then
                workingFolder = docManager.WorkingFolder
                workingFile = Path.Combine(workingFolder, docManager.CurrentDocument.File.Name)

                If File.Exists(workingFile) Then
                    File.Delete(workingFile)
                End If

                File.Copy(docManager.CurrentDocument.File.FullName, workingFile)
                returnValue = ProcessMathcadSheet(workingFile, inputParams, outputParams)

            End If

        Catch ex As Exception
            g_ObjectManager.LogError("ProcessMathCadDoc", ex.ToString)

            Dim variableValues As New System.Text.StringBuilder

            If templateName IsNot Nothing Then
                variableValues.AppendFormat("Template Name: {0}{1}", templateName, ControlChars.CrLf)
            Else
                variableValues.AppendFormat("Template Name is null.{0}", ControlChars.CrLf)
            End If

            If inputParams IsNot Nothing Then
                variableValues.AppendFormat("Input Params: {0}{1}", inputParams, ControlChars.CrLf)
            Else
                variableValues.AppendFormat("Input Params is null.{0}", ControlChars.CrLf)
            End If

            If outputParams IsNot Nothing Then
                variableValues.AppendFormat("Output Params: {0}{1}", outputParams, ControlChars.CrLf)
            Else
                variableValues.AppendFormat("Output Params is null.{0}", ControlChars.CrLf)
            End If

            If workingFolder IsNot Nothing Then
                variableValues.AppendFormat("Working Folder: {0}{1}", workingFolder, ControlChars.CrLf)
            Else
                variableValues.AppendFormat("Working Folder is null.{0}", ControlChars.CrLf)
            End If

            If workingFile IsNot Nothing Then
                variableValues.AppendFormat("Working File: {0}{1}", workingFile, ControlChars.CrLf)
            Else
                variableValues.AppendFormat("Working File is null.{0}", ControlChars.CrLf)
            End If

            g_ObjectManager.LogError("Common.ProcessMathCadDoc", variableValues.ToString)

        End Try

        Return returnValue

    End Function

    ''' <summary>
    ''' Processes a Mathcad sheet.
    ''' </summary>
    ''' <param name="sTemplate">Template Name - Name of the MathCAD template to use.  Should be pulled from Master docs folder or PLM.</param>
    ''' <param name="sInputParams">Input Variable List - Comma delimited string of variable name and value.  i.e. "Vn1,V1,Vn2,V2,Vn3,V3,…".</param>
    ''' <param name="sOutputParams">Output Variable List - Comma delimited string of variable names of values to be returned.  i.e. "Vn1,Vn2,Vn3,…".</param>
    ''' <returns>System.String - Comma delimited string of values for the values in the Output Variable List.</returns>
    ''' <remarks> <b>NOTE:</b> Variable names are CASE-SENSITIVE!!<br></br>
    '''       That means that Abc is NOT the same as abc, and if you try to look for a variable of the wrong case
    '''       it won't be found and will return a null string.
    '''   If an Input Variable isn't found, Mathcad doesn't throw an error, so you won't get a warning.</remarks>

    Public Function ProcessMathcadSheet(ByVal sTemplate As String, ByVal sInputParams As String, ByVal sOutputParams As String) As String
        On Error GoTo Err_Handler
        Dim sSourceDoc As String 'Template
        Dim oMCadWS As Object = Nothing 'MathCAD worksheet
        Dim oMCadApp As Object 'MathCAD Application
        Dim strReturn As String = String.Empty

        sSourceDoc = sTemplate

        'Check to see if Input File exists
        Call FileLen(sSourceDoc)

        oMCadApp = CreateObject("MathCad.Application")

        If Not oMCadApp Is Nothing Then
            If oMCadApp.Visible Then
                MsgBox("Please close your MathCad session and try again.", MsgBoxStyle.Exclamation, "MathCAD")
                oMCadApp = Nothing
                GoTo Exit_Sub
            End If
        End If

        If Len(sSourceDoc) > 0 Then
            oMCadWS = oMCadApp.Worksheets.Open(sSourceDoc)
        End If

        Dim arrOutputs() As String
        Dim lIdxOutput As Integer
        Dim arrInputs() As String
        Dim lIdxInput As Integer
        Dim sVariable, sValue As String
        Dim dValue As Double
        Dim vValue As Object
        If Not oMCadWS Is Nothing Then

            'Loop thru input variables and push their values into MathCAD
            arrInputs = Split(sInputParams, ",")
            For lIdxInput = LBound(arrInputs) To UBound(arrInputs) Step 2
                sVariable = arrInputs(lIdxInput)
                If InStr(1, arrInputs(lIdxInput + 1), """") = 1 Then
                    sValue = arrInputs(lIdxInput + 1)
                    sValue = Mid(sValue, 2, Len(sValue) - 2)
                    oMCadWS.SetValue(sVariable, sValue)
                Else
                    dValue = CDbl(arrInputs(lIdxInput + 1))
                    oMCadWS.SetValue(sVariable, dValue)
                End If
            Next lIdxInput

            'Force a ReCalc
            oMCadWS.ReCalculate()

            On Error Resume Next

            'Loop thru output variables and return their values
            arrOutputs = Split(sOutputParams, ",")
            For lIdxOutput = LBound(arrOutputs) To UBound(arrOutputs)
                vValue = vbNullString
                sVariable = arrOutputs(lIdxOutput)

                vValue = (oMCadWS.GetValue(sVariable)).real
                strReturn &= "," & CStr(vValue)
            Next lIdxOutput

            If Len(strReturn) > 0 Then strReturn = Mid(strReturn, 2)
        End If

Exit_Sub:
        On Error Resume Next
        'Close MathCad
        oMCadWS.Close(2) 'Close the currently open worksheet. Discard any changes
        oMCadApp.CloseAll(2)
        oMCadApp.Quit(2)
        Return strReturn

        Exit Function

Err_Handler:
        MsgBox(Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxHelp, Err.Source & ": Common.ProcessMathCADSheet " & Erl())
        Resume Exit_Sub
    End Function


    ''' <summary>
    ''' Returns a dictionary object containing Rulestream.Kernel.ValidValues for a drawing view scale.
    ''' </summary>
    ''' <param name="ActualHeight">Height of the part/assembly to put in the view.</param>
    ''' <param name="ActualWidth">Width of the part/assembly to put in the view.</param>
    ''' <param name="ViewHeight">Paper space of the view height.</param>
    ''' <param name="ViewWidth">Paper space of the view width.</param>
    ''' <param name="CalculateScale">if set to <c>true</c> return a scale factor on a scale, if set to <c>false</c> return the closest possible scale, may not be on a scale.</param>
    ''' <returns>System.String Scale: If <c>CalculateScale = true</c> then "12:1", "2:1, "1:1" , "1:12", "1:48". <br></br>
    ''' If <c>CalculateScale = false</c> then "33:1", "9:1", "0.220:1", "0.278:1"</returns>
    Public Function CalculateDrawingViewScale(ByVal ActualHeight As Double, ByVal ActualWidth As Double, ByVal ViewHeight As Double, ByVal ViewWidth As Double, ByVal CalculateScale As Boolean) As String
        Dim sx As Double
        Dim sy As Double
        Dim viewscale As Double
        Dim I As Integer
        Dim sd1() As Object
        Dim sd2() As Object

        On Error GoTo ErrorHandler

        sx = ViewWidth / ActualWidth  'The 3.5 is the desired paper space width on the sheet
        sy = ViewHeight / ActualHeight   'The 5.0 is the desired paper space height on the sheet

        'sd1 = Array(128, 96, 48, 24, 12, 8, 4, 2) ' scale fartors less than 1:1
        sd1 = Array(0.0078125, 0.0104167, 0.02083, 0.04167, 0.0833, 0.09375, 0.125, 0.1875, 0.25, 0.375, 0.5, 0.75) ' scale fartors less than 1:1
        'sd2 = Array(2, 4, 8, 12, 24, 48, 96, 128) ' scale factors larger than 1:1
        sd2 = Array(1.5, 2, 3, 4, 8, 12, 24, 48, 96, 128) ' scale factors larger than 1:1

        'The denominator is the actual width

        viewscale = Min(sx, sy)

        CalculateDrawingViewScale = "1:1"

        If viewscale = 1 Then Exit Function

        If CalculateScale Then
            If viewscale < 1 Then
                For I = 0 To UBound(sd1)  ' 7 is the length of sd1
                    'If (1 / sd1(I)) < viewscale Then
                    If sd1(I) < viewscale Then
                        'CalculateDrawingViewScale = "1/" & CStr(sd1(I))
                        CalculateDrawingViewScale = CStr(sd1(I)) & ":1"
                    Else
                        Exit For
                    End If
                Next
            ElseIf viewscale > 1 Then
                For I = 0 To UBound(sd2)  ' 7 is the length of sd2
                    'If viewscale > (sd2(I) / 1) Then
                    If viewscale > sd2(I) Then
                        CalculateDrawingViewScale = CStr(sd2(I)) & ":1"
                    Else
                        Exit For
                    End If
                Next
            End If
        Else
            If viewscale < 1 Then
                CalculateDrawingViewScale = CStr(RoundDown(0.0001, viewscale)) & ":1"
                'For I = 1 To 1000
                '    If (1 / I) < viewscale Then
                '        CalculateDrawingViewScale = "1/" & CStr(I)
                '        Exit For
                '    End If
                'Next
            Else
                CalculateDrawingViewScale = CStr(RoundUp(0.0001, viewscale)) & ":1"
                'For I = 1 To 1000
                '    If viewscale > (I / 1) Then
                '        CalculateDrawingViewScale = CStr(I) & "/1"
                '    Else
                '        Exit For
                '    End If
                'Next
            End If
        End If

        Exit Function

ErrorHandler:
        Err.Source = "Common: CalculateDrawingViewScale"
        Err.Raise(Err.Number, Err.Source, Err.Description)
    End Function

    ''' <summary>
    ''' Gets the XML value from a given XML document using XPATH.
    ''' </summary>
    ''' <param name="strXML">The string XML.</param>
    ''' <param name="strXPath">The string XPath.</param>
    ''' <param name="strDefault">The string default to Return if no node value found.</param>
    ''' <returns>System.String.</returns>
    Public Function GetXMLValue(ByVal strXML As String, ByVal strXPath As String, Optional ByVal strDefault As String = "") As String
        'Get a value 
        Dim oNode As System.Xml.XmlNode
        Dim oXML As New System.Xml.XmlDocument
        Try

            oXML.Load(strXML)
            oNode = oXML.SelectSingleNode(strXPath)

            If Not oNode Is Nothing Then
                GetXMLValue = oNode.Value
            Else
                GetXMLValue = strDefault
            End If

        Catch
            Return strDefault
        End Try
    End Function


    ''' <summary>
    ''' Executes a program while waiting and returning output
    ''' </summary>
    ''' <param name="ProcessPath">The path to the program to execute.</param>
    ''' <param name="Args">The arguments.</param>
    ''' <returns>System.String containing the contents of StandardOutput from the program.</returns>
    Public Function ShellandWait(ByVal ProcessPath As String, Optional ByVal Args As String = "") As String
        Dim objProcess As System.Diagnostics.Process
        Dim strOutput As String

        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.StartInfo.Arguments = Args
            objProcess.StartInfo.RedirectStandardOutput = True
            objProcess.StartInfo.UseShellExecute = False
            objProcess.Start()
            strOutput = objProcess.StandardOutput.ReadToEnd

            'Wait until the process passes back an exit code 

            objProcess.WaitForExit()
            'Free resources associated with this process
            objProcess.Close()
            Return strOutput

        Catch ex As Exception
            Dim er As String
            er = ex.ToString
            Return er
            'MessageBox.Show("Could not start process " & ProcessPath, "Error")
        End Try
    End Function


    ''' <summary>
    ''' Writes text to a file.
    ''' </summary>
    ''' <param name="filename">The filename (including path) to write to.</param>
    ''' <param name="text">The text to write.</param>
    ''' <param name="append">if set to <c>true</c> [append] to the file, instead of Overwriting it.</param>
    Public Sub WriteTextToFile(ByVal filename As String, ByVal text As String, Optional ByVal append As Boolean = False)

        If Not append AndAlso System.IO.File.Exists(filename) Then
            System.IO.File.Delete(filename)
        End If

        System.IO.File.AppendAllText(filename, text + System.Environment.NewLine)

    End Sub

    ''' <summary>
    ''' Reads text from a file.
    ''' </summary>
    ''' <param name="filename">The filename (including path) to read from.</param>
    ''' <returns>System.String the text contents of the file.</returns>
    Public Function ReadTextFromFile(ByVal filename As String) As String
        'write a string from a file
        Dim sr As System.IO.StreamReader
        Dim strText As String = ""

        If System.IO.File.Exists(filename) Then
            sr = New System.IO.StreamReader(filename)
            strText = sr.ReadToEnd()
            sr.Close()
        End If

        Return strText

    End Function

#Region " Methods for Named Sequence Generator "

    ''' <summary>
    ''' Gets the next sequence number for the named sequence for this session and increments it by 1
    ''' </summary>
    ''' <param name="SequenceName">The name of the sequence for which the next sequence number is sought</param>
    ''' <returns>An integer that is the next sequence number for the given named sequence</returns>
    ''' <remarks>If the named sequence has not yet been seeded, then the named sequence is initialized here
    ''' and is seeded with a value of 1. If there exists a property named 'Next SequenceName' on top level part
    ''' then that property is used to seed the sequence name and is also updated with new sequence value each time
    ''' a new sequence number is asked for that named sequence
    '''</remarks>
    Public Function NextSequenceNumber(ByVal SequenceName As String) As Integer
        Static Sequences As Hashtable  'holds next sequence number for a named sequence
        Dim SequenceNumber As Integer   'will hold the return value
        'If the sequence is not yet initialized then do it now
        If Sequences Is Nothing Then Sequences = New Hashtable
        'and if it has not been seeded yet, seed it to 1
        If Not Sequences.ContainsKey(SequenceName) Then
            Dim Seed As Integer = 1 'default seed for a new sequence
            With CType(g_ObjectManager.RSEngineer.TopLevelPart, RuleStream.Kernel.Part).Properties
                'if there is a property named 'Next<SequenceName>' on top level part, use it as a seed
                'and need to use RawValue because we don't want to create a dependency
                If .ContainsKey("Next" & SequenceName) Then Seed = .Item("Next" & SequenceName).RawValue
            End With
            Sequences.Add(SequenceName, Seed)
        End If
        SequenceNumber = Sequences.Item(SequenceName)   'pull out the next sequence number first
        Sequences.Item(SequenceName) += 1   'update it for the next call
        'also update the property on the top level part so we persist the value
        With CType(g_ObjectManager.RSEngineer.TopLevelPart, RuleStream.Kernel.Part).Properties
            If .ContainsKey("Next" & SequenceName) Then .Item("Next" & SequenceName).SetInputValue(Sequences.Item(SequenceName), True)
        End With
        Return SequenceNumber
    End Function

#End Region

#Region " Methods for Rolling Up parts "
    'holds a named roll up list - used in conjunction with UniquePartsQuantity & ResetUniquePartsList methods below
    Private _UniqueParts As Hashtable

    ''' <summary>
    ''' Retrieves the unique value for a part designated by an index in the roll-up list
    ''' </summary>
    ''' <param name="MatchOn">The name of the Roll-up list. This is also the property name of the part on which the Roll-up is performed</param>
    ''' <param name="PartIndex">The index of the part in the roll-up list</param>
    ''' <returns>The value of the property on which the roll-up was performed for a given part</returns>
    ''' <remarks>This method can be used by each of the computed part instances to look-up the corresponding property value of unique instances</remarks>
    Public ReadOnly Property UniquePartValue(ByVal MatchOn As String, ByVal PartIndex As Integer) As Object
        Get
            If _UniqueParts IsNot Nothing Then
                If MatchOn IsNot Nothing AndAlso _UniqueParts.ContainsKey(MatchOn) Then
                    Dim Index As Integer = 1
                    Dim PartList As IDictionary = _UniqueParts.Item(MatchOn)
                    If PartIndex <= PartList.Count AndAlso PartIndex > 0 Then
                        For Each de As DictionaryEntry In PartList
                            If Index = PartIndex Then Return de.Key
                            Index += 1
                        Next
                    Else
                        g_ObjectManager.LogError("Common.UniquePartValue", "Invalid Part Index: " & PartIndex)
                    End If
                Else
                    g_ObjectManager.LogError("Common.UniquePartValue", "MatchOn argument is invalid")
                End If
            Else
                g_ObjectManager.LogError("Common.UniquePartValue", "Common.UniquePartsQuantity must be called before calling Common.UniquePartValue")
            End If
            Return New Object
        End Get
    End Property

    ''' <summary>
    ''' Retrieves the quantity for a given part designated in the roll-up list
    ''' </summary>
    ''' <param name="MatchOn">The name of the Roll-up list. This is also the property name of the part on which the Roll-up is performed</param>
    ''' <param name="Part">The part instance in the rolled-up list</param>
    ''' <returns>The quantity of given rolled-up part instance</returns>
    ''' <remarks>This method can be used by each of the computed part instances to look-up the quantity of unique instance</remarks>
    Public ReadOnly Property UniquePartQuantity(ByVal MatchOn As String, ByVal Part As RuleStream.Kernel.Part) As Integer
        Get
            If _UniqueParts IsNot Nothing AndAlso Part IsNot Nothing Then
                If MatchOn IsNot Nothing AndAlso _UniqueParts.ContainsKey(MatchOn) Then
                    Dim PartList As IDictionary = _UniqueParts.Item(MatchOn)
                    Dim Value As Object = Nothing
                    With Part.Properties
                        If .ContainsKey(MatchOn) Then
                            Value = .Item(MatchOn).Value
                            If PartList.Contains(Value) Then Return PartList.Item(Value)
                        End If
                    End With
                Else
                    g_ObjectManager.LogError("Common.UniquePartValue", "MatchOn argument is invalid")
                End If
            Else
                g_ObjectManager.LogError("Common.UniquePartValue", "Common.UniquePartsQuantity must be called before calling Common.UniquePartValue and also make sure MatchOn and Part arguments are valid")
            End If
            Return 0
        End Get
    End Property

    ''' <summary>
    ''' UniquePartsQuantity performs a roll-up of part instances based on a property name
    ''' </summary>
    ''' <param name="SearchList">The list of Part instances to be searched (that implements IEnumerable) or the Part instance from where the search begins</param>
    ''' <param name="MatchOn">The property name on the searched part instances based on which the roll-up is performed</param>
    ''' <param name="IncrementBy">Optional Property Name that will return the value to increment the quantity by. If this argument is missing, default increment is 1</param>
    ''' <param name="Sort">A boolean indicating if the rolled-up list needs to be sorted</param>
    ''' <param name="Traverse">A boolean indicating if the search should traverse the tree under each part instance (recursive search)</param>
    ''' <param name="PartFamilyFilter">Comma de-limited list of part family names to filter the search</param>
    ''' <param name="PropertyFilter">Comma de-limited list of property names to filter the search (i.e. the part must have at least one of these properties</param>
    ''' <returns>The unique number of instances based on the roll-up property's value</returns>
    ''' <remarks>This function works by first removing any existing list and calls the GetUniquePartsQuantity which does the actual work of
    ''' populating the readonly 'UniqueParts' global variable as it searches and finds unique parts. This method is meant to be used
    ''' in the quantity formula for a subpart collection and then each of the part instances under the subpart can query the 'UniqueParts([MatchOn])'
    ''' rolled-up list to get the correct value of the property and the quantity of a unique part</remarks>
    Public Function UniquePartsQuantity(ByVal SearchList As Object, ByVal MatchOn As String, Optional ByVal IncrementBy As String = Nothing, Optional ByVal Sort As Boolean = False, Optional ByVal Traverse As Boolean = True, Optional ByVal PartFamilyFilter As String = Nothing, Optional ByVal PropertyFilter As String = Nothing) As Integer
        Try
            If _UniqueParts IsNot Nothing Then
                If _UniqueParts.ContainsKey(MatchOn) Then _UniqueParts.Remove(MatchOn)
            End If
            Return GetUniquePartsQuantity(SearchList, MatchOn, IncrementBy, Sort, Traverse, PartFamilyFilter, PropertyFilter)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' GetUniquePartsQuantity performs a roll-up of part instances based on a property name
    ''' </summary>
    ''' <param name="SearchList">The list of Part instances to be searched (that implements IEnumerable) or the Part instance from where the search begins</param>
    ''' <param name="MatchOn">The property name on the searched part instances based on which the roll-up is performed</param>
    ''' <param name="IncrementBy">Optional Property Name that will return the value to increment the quantity by. If this argument is missing, default increment is 1</param>
    ''' <param name="Sort">A boolean indicating if the rolled-up list needs to be sorted</param>
    ''' <param name="Traverse">A boolean indicating if the search should traverse the tree under each part instance (recursive search)</param>
    ''' <param name="PartFamilyFilter">Comma de-limited list of part family names to filter the search</param>
    ''' <param name="PropertyFilter">Comma de-limited list of property names to filter the search (i.e. the part must have at least one of these properties</param>
    ''' <returns>The unique number of instances based on the roll-up property's value</returns>
    ''' <remarks>This function is called from the user-called UniquePartsQuantity and it populates the readonly 'UniqueParts' global variable
    ''' as it searches and finds unique parts. For example, this method can be used in the quantity formula for a subpart collection
    ''' and then each of the part instances under the subpart can query the 'UniqueParts([MatchOn])' rolled-up list to get the correct
    ''' value of the property and the quantity of a unique part</remarks>
    Private Function GetUniquePartsQuantity(ByVal SearchList As Object, ByVal MatchOn As String, Optional ByVal IncrementBy As String = Nothing, Optional ByVal Sort As Boolean = False, Optional ByVal Traverse As Boolean = True, Optional ByVal PartFamilyFilter As String = Nothing, Optional ByVal PropertyFilter As String = Nothing) As Integer
        Dim Quantity As Integer = 0
        Try
            If SearchList IsNot Nothing AndAlso MatchOn IsNot Nothing AndAlso MatchOn.Trim.Length > 0 Then
                'SearchList must be a collection of Parts or a Part Instance
                If TypeOf SearchList Is IEnumerable OrElse TypeOf SearchList Is RuleStream.Kernel.Part Then
                    'Initialize the UniqueParts named roll-up list. Use a sorted list of sorting
                    'is required. The 'MatchOn' string is also utilized as the name of the named list
                    If _UniqueParts Is Nothing Then _UniqueParts = New Hashtable
                    If Not _UniqueParts.ContainsKey(MatchOn) Then
                        If Sort Then
                            _UniqueParts.Add(MatchOn, New SortedList)
                        Else
                            _UniqueParts.Add(MatchOn, New Hashtable)
                        End If
                    End If
                    If PartFamilyFilter Is Nothing Then PartFamilyFilter = String.Empty
                    If PropertyFilter Is Nothing Then PropertyFilter = String.Empty
                    Dim IncrementValue As Integer
                    If IncrementBy Is Nothing OrElse IncrementBy.Trim.Length = 0 Then IncrementBy = String.Empty
                    Dim PartFamilyFilterList As String() = PartFamilyFilter.Split(",")
                    Dim PropertyFilterList As String() = PropertyFilter.Split(",")
                    If TypeOf SearchList Is IEnumerable Then
                        'both SortedList and HashTable implement the IDictionary
                        Dim UniquePartsList As IDictionary = _UniqueParts.Item(MatchOn)
                        Dim PropertyValue As String = String.Empty
                        Dim FilterMatchSuccess As Boolean = False
                        For Each Part As RuleStream.Kernel.Part In SearchList
                            FilterMatchSuccess = Part.Properties.ContainsKey(MatchOn)
                            If FilterMatchSuccess Then
                                'reset the filter match flag for re-use
                                FilterMatchSuccess = False
                                If PartFamilyFilter.Length > 0 Then FilterMatchSuccess = FilterMatchSuccess And PartFamilyFilter.Contains(Part.PartFamily)
                                If PropertyFilter.Length > 0 Then
                                    'if the part has at least one property from the property filter list, we count the part in
                                    With Part.Properties
                                        For Each PropName As String In PropertyFilterList
                                            FilterMatchSuccess = FilterMatchSuccess Or .ContainsKey(PropName)
                                        Next
                                    End With
                                End If

                                If FilterMatchSuccess Then
                                    'If a match is found, either update the quantity of existing item or add a new
                                    'item to the list and set quantity to 1. Quantity = the value of the dictionary element
                                    'and the 'MatchOn' property value = Key of the dictionary element
                                    PropertyValue = Part.Properties(MatchOn).Value.ToString
                                    'also, we need to figure out the increment value first
                                    If IncrementBy.Length > 0 AndAlso Part.Properties.ContainsKey(IncrementBy) Then
                                        If Not Integer.TryParse(Part.Properties.Item(IncrementBy).Value, IncrementValue) Then IncrementValue = 1
                                    Else
                                        IncrementValue = 1
                                    End If
                                    If UniquePartsList.Contains(PropertyValue) Then
                                        UniquePartsList.Item(PropertyValue) += IncrementValue
                                    Else
                                        UniquePartsList.Add(PropertyValue, IncrementValue)
                                        Quantity += 1
                                    End If
                                End If
                            End If 'FilterMatchSuccess

                            If Traverse Then    'recurse if need to drill inside each Part
                                For Each Subpart As RuleStream.Kernel.Subpart In Part.Subparts
                                    Quantity += GetUniquePartsQuantity(Subpart.Parts, MatchOn, IncrementBy, Sort, Traverse, PartFamilyFilter, PropertyFilter)
                                Next
                            End If
                        Next    'Part
                    ElseIf TypeOf SearchList Is RuleStream.Kernel.Part Then
                        'If SearchList is a part instance, then we begin the search under the part (the given
                        'part is not included in the search)
                        For Each Subpart As RuleStream.Kernel.Subpart In CType(SearchList, RuleStream.Kernel.Part).Subparts
                            Quantity += GetUniquePartsQuantity(Subpart.Parts, MatchOn, IncrementBy, Sort, Traverse, PartFamilyFilter, PropertyFilter)
                        Next
                    End If
                Else
                    g_ObjectManager.LogError("UniquePartsQuantity", "The list to be searched must be a container list (support IEnumerable) or a Part Instance")
                    If _UniqueParts IsNot Nothing AndAlso _UniqueParts.ContainsKey(MatchOn) Then _UniqueParts.Remove(MatchOn)
                    Quantity = 0
                End If
            End If
        Catch ex As Exception
            g_ObjectManager.LogError(ex.Source, ex.ToString)
            If _UniqueParts IsNot Nothing AndAlso _UniqueParts.ContainsKey(MatchOn) Then _UniqueParts.Remove(MatchOn)
            Quantity = 0
        End Try
        Return Quantity
    End Function

#End Region

#Region " Methods for instantiating parts in a subpart from Database Components "

    ''' <summary>
    ''' Holds named sets of component parts looked up from Component DB
    ''' </summary>
    Private _ComponentSets As Hashtable

    ''' <summary>
    ''' Retrieves the database column value for a part designated by an Part Index and column designated by the ComponentAttribute parameters respectively
    ''' </summary>
    ''' <param name="ComponentSetName">The name of the component set. This could be used to look-up multiple component sets from component DB</param>
    ''' <param name="ComponentIndex">The index of the part in the component DB table</param>
    ''' <param name="ComponentAttribute">The column name for which the value is to be retrieved</param>
    ''' <returns>The value of the column for a given component row in the table</returns>
    ''' <remarks>This method can be used by each of the computed part instances to look-up the corresponding property value of unique instances</remarks>
    Public ReadOnly Property ComponentPartValue(ByVal ComponentSetName As String, ByVal ComponentIndex As Integer, ByVal ComponentAttribute As String) As Object
        Get
            If _ComponentSets IsNot Nothing AndAlso ComponentSetName IsNot Nothing AndAlso ComponentAttribute IsNot Nothing Then
                If _ComponentSets.ContainsKey(ComponentSetName) Then
                    With CType(_ComponentSets.Item(ComponentSetName), DataTable)
                        If .Columns.Contains(ComponentAttribute) AndAlso ComponentIndex > 0 AndAlso ComponentIndex <= .Rows.Count Then
                            'ComponentIndex is decremented coz DataRows is 0-based and ComponentIndex is 1 based
                            Return .Rows.Item(ComponentIndex - 1).Item(ComponentAttribute)
                        Else
                            g_ObjectManager.LogError("Common.ComponentPartValue", "Invalid Field: " & ComponentAttribute & " or Invalid Component Index: " & ComponentIndex)
                        End If
                    End With
                Else
                    g_ObjectManager.LogError("Common.ComponentPartValue", "Common.ComponentPartQuantity must be called before calling Common.ComponentPartValue and also make sure ComponentSetName and ComponentAttribute arguments are valid")
                End If
            End If
            Return New Object
        End Get
    End Property

    ''' <summary>
    ''' Evaluates/Looks-up the quantity of components in the component DB based on the given DataSource
    ''' </summary>
    ''' <param name="ComponentSetName">The name of the component set. This could be used to look-up multiple component sets from component DB</param>
    ''' <param name="DataSource">The table/view name or an SQL statement intended to be executed against the component DB table</param>
    ''' <returns>The value of the column for a given component row in the table</returns>
    ''' <remarks>This method can be used by each of the computed part instances to look-up the corresponding column value in the table</remarks>
    Public Function ComponentPartsQuantity(ByVal ComponentSetName As String, ByVal DataSource As String) As Integer
        Dim Quantity As Integer = 0
        Try
            If ComponentSetName IsNot Nothing AndAlso ComponentSetName.Length > 0 AndAlso DataSource IsNot Nothing AndAlso DataSource.Length > 0 Then
                If _ComponentSets Is Nothing Then _ComponentSets = New Hashtable
                If _ComponentSets.ContainsKey(ComponentSetName) Then _ComponentSets.Remove(ComponentSetName)
                'If only a table/view name is provided, convert it into an SQL statement
                If Not DataSource.ToUpper.StartsWith("SELECT ") Then DataSource = "SELECT * FROM " & DataSource
                'hit the component DB to receive back a dataset of component parts and add the first table dataset to our hashtable
                'for look up later. Add the table only if there are rows in it.
                With g_ComponentData.ExecuteSQL(DataSource)
                    If .Tables.Count > 0 AndAlso .Tables(0).Rows.Count > 0 Then
                        _ComponentSets.Add(ComponentSetName, .Tables(0))
                        Quantity = .Tables(0).Rows.Count
                    End If
                End With
            End If
        Catch ex As Exception
        End Try
        Return Quantity
    End Function

#End Region

    ''' <summary>
    ''' Returns the default value for data based upon the type of Property.
    ''' </summary>
    ''' <param name="prop">The property.</param>
    ''' <returns>System.Object.</returns>
    Private Function DefaultValueForDataType(ByVal prop As RuleStream.Kernel.PropertySF) As Object

        Select Case prop.ValueDatatype.ToLower

            Case "string"
                Return String.Empty

            Case "long", "double"
                Return 0

            Case "date"
                Return New Date().ToString

            Case "boolean"
                Return False

            Case "object"
                Return Nothing

            Case "point2d"
                Return "0,0"

            Case "point3d"
                Return "0,0,0"

            Case Else
                Return String.Empty

        End Select


    End Function

    ''' <summary>
    ''' Returns the default valid value for a given PartFamily / Property pair.
    ''' </summary>
    ''' <param name="pf">The PartFamily Name.</param>
    ''' <param name="PropName">Name of the property.</param>
    ''' <param name="Default">The default value to use.</param>
    ''' <returns>System.Object The Default ValidValue, or Nothing if none found.</returns>

    Public Function DefaultValidValue(ByVal pf As RuleStream.Kernel.Part, ByVal PropName As String, ByVal [Default] As Object) As Object
        Dim result As Object = Nothing

        Dim prop As RuleStream.Kernel.PropertySF = pf.Properties.GetItemByKey(PropName)

        If prop Is Nothing Then
            msgbox("Common.DefaultValidValue(): Invalid Property named " & PropName & ".")
            result = Nothing
        Else

            If Not prop.ValidValues Is Nothing AndAlso prop.ValidValues.Count > 0 Then
                If prop.ValidValues.Contains([Default]) Then
                    result = [Default]
                Else
                    result = prop.ValidValues.FirstValue
                End If
            ElseIf prop.ValidValues Is Nothing Then
                result = [Default]
            ElseIf prop.ValidValues.Count > 0 Then
                result = prop.ValidValues.FirstValue
            End If
        End If

        Return result
    End Function

    ''' <summary>
    ''' Returns the First valid value for a given PartFamily / Property pair.
    ''' </summary>
    ''' <param name="pf">The PartFamily Name.</param>
    ''' <param name="PropName">Name of the property.</param>
    ''' <returns>System.Object The First ValidValue, or Nothing if none found.</returns>
    Public Function FirstValidValue(ByVal pf As RuleStream.Kernel.Part, ByVal PropName As String) As Object
        Dim prop As RuleStream.Kernel.PropertySF = pf.Properties.GetItemByKey(PropName)

        If prop Is Nothing Then
            msgbox("Common.FirstValidValue(): Invalid Property named " & PropName & ".")
            Return Nothing
        Else

            If Not prop.ValidValues Is Nothing AndAlso prop.ValidValues.Count > 0 Then
                Return prop.ValidValues.FirstValue
            Else
                Return DefaultValueForDataType(prop)
            End If
        End If
    End Function


    ''' <summary>
    ''' This function is for displaying and logging a message or prompting for user input; it pops up a dialog box, optionally asks for a button press, and logs the error if the user is in Engineer; 
    ''' it suppresses the dialog box using the default button and logs the message if the user is in Unattended (or thin client) mode
    ''' </summary>
    ''' <param name="source">The title of the MessageBox, typically the part family and property from which this function is called.</param>
    ''' <param name="msg">The message text string (the "guts" of the dialog box).</param>
    ''' <param name="severity">The string severity level: Error, Info, Question (Default = Error)</param>
    ''' <param name="buttons">The MessageBoxButtons to present if used as a question dialog: OK (Default), OKCancel, YesNoCancel, YesNo, etc.</param>
    ''' <param name="defaultbutton">The Default Button to be selected (if the user hits return)</param>
    ''' <returns>DialogResult - response from User, if used as a question dialog</returns>
    ''' <remarks>This method is used to display a MessageBox message to a user, logging it as well.  ONLY logs it in Unattended / ThinClient mode.</remarks>
    Public Function RsMessage(ByRef source As String,
                          ByRef msg As String,
                          Optional ByVal severity As String = "Error",
                          Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK,
                          Optional ByVal defaultbutton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) _
                      As DialogResult

        'String for message, caption, suppression, and dialogresult
        Dim displaymsg As String
        Dim caption As String = "Message"
        Dim icon As MessageBoxIcon
        Dim suppress As Boolean = True
        Dim dr As DialogResult

        'Set icon to reference the severity
        Select Case severity
            Case "Error"
                icon = MessageBoxIcon.Error
            Case "Info"
                icon = MessageBoxIcon.Information
            Case "Question"
                icon = MessageBoxIcon.Question
            Case "Warning"
                icon = MessageBoxIcon.Warning
            Case "Exclamation"
                icon = MessageBoxIcon.Exclamation
            Case Else
                icon = MessageBoxIcon.None
        End Select

        'concatenate the severity with the message to display it if not an error; otherwise, just display the msg
        If severity = "Error" Then
            displaymsg = msg
        Else
            displaymsg = severity & ": " & msg
        End If

        'check to see if we are running unattended; if so, suppress the message
        'If g_ObjectManager.Unattended Then suppress = True

        'if unattended, call LogError; else call MessageBox.Show and LogError
        If g_ObjectManager.Unattended Then
            g_ObjectManager.LogError(source, displaymsg, suppress)
            dr = DialogResult.OK
        Else
            dr = MessageBox.Show(displaymsg, caption, buttons, icon, defaultbutton)
            g_ObjectManager.LogError(source, displaymsg & " : User selected " & dr, suppress)
        End If

        Return dr

    End Function


    ''' <summary>
    ''' Gather properties by CategoryName.
    ''' </summary>
    ''' <param name="PartFamilyInstance">The part family instance.</param>
    ''' <param name="PropertyCategoryName">Name of the property category.</param>
    ''' <returns>A pipe ("|") delimited System.String containing the properties of that CategoryName, or String.Empty if there are no matches.</returns>
    Public Function RS_GatherPropertiesForCategory(ByRef PartFamilyInstance As RuleStream.Kernel.Part, ByVal PropertyCategoryName As String) As String

        Dim ReturnString As New System.Text.StringBuilder   ' return value
        Dim NumberOfProperties As Integer = 0     ' Used to decide whether or not to add a message delimiter 

        If (PartFamilyInstance IsNot Nothing) AndAlso (Not String.IsNullOrEmpty(PropertyCategoryName)) Then
            ' Loop through each property on the part family
            For Each Prop As RuleStream.Kernel.PropertySF In PartFamilyInstance.Properties

                If Prop.CategoryName = PropertyCategoryName Then

                    ' Add a leading delimiter if this is not the first message
                    If NumberOfProperties > 0 Then
                        ReturnString.Append("|")
                        NumberOfProperties += 1
                    End If

                    ReturnString.Append(Prop.Name)
                    NumberOfProperties += 1

                End If

            Next Prop
        Else
            RsMessage("RS_GatherPropertiesForCategory()", "PartFamilyInstance is Nothing or PropertyCategoryName is NullOrEmpty")
        End If

        Return ReturnString.ToString()
    End Function


    ''' <summary>
    ''' Calls a command line file.
    ''' </summary>
    ''' <param name="CommandLineFile">The command line file to run.</param>
    ''' <param name="CommandLineFileArgs">The command line file arguments.</param>
    ''' <param name="SecsToWaitForExitTime">The seconds to wait for exit time (defaulted to 5).</param>
    ''' <remarks>NOTE: This is recommended to be called from a handler in Custom.vb</remarks>
    Public Sub CallCommandLineFile(ByVal CommandLineFile As String, ByVal CommandLineFileArgs As String, Optional SecsToWaitForExitTime As Int16 = 5)

        Dim jobID As Integer = 0
        Dim commandlineProcess As System.Diagnostics.Process
        Dim strmsg As String = "No CommandLineFile specified"

        Try
            If (Not (String.IsNullOrEmpty(CommandLineFile))) Then
                Dim p As New ProcessStartInfo
                With p
                    .FileName = CommandLineFile
                    strmsg = "CommandLineFile: <" & CommandLineFile & ">"
                    If Not (String.IsNullOrEmpty(CommandLineFileArgs)) Then
                        .Arguments = CommandLineFileArgs
                        strmsg &= " with Arguments <" & CommandLineFileArgs & ">"
                    End If
                    'attempting to capture output from the process
                    .UseShellExecute = False
                    .RedirectStandardOutput = True
                End With
                g_ObjectManager.LogInfo("Common.CallCommandLineFile()", String.Format("Running {0}", strmsg),, True)
                commandlineProcess = Process.Start(p)
                jobID = commandlineProcess.Id

                Dim myString As String = String.Empty
                Try
                    Dim myStreamReader As StreamReader = commandlineProcess.StandardOutput
                    ' Read the standard output of the spawned process. 
                    myString = myStreamReader.ReadLine()

                Catch soex As InvalidOperationException
                    g_ObjectManager.LogInfo("Common.CallCommandLineFile()", String.Format("Exception getting StandardOutput for {0}: {1}", strmsg, soex.ToString),, True)
                End Try

                commandlineProcess.WaitForExit()
                If Not commandlineProcess.HasExited Then
                    commandlineProcess.Kill()
                    g_ObjectManager.LogInfo("Common.CallCommandLineFile()", String.Format("{0} was killed after {1} sec timeout expired.", strmsg, SecsToWaitForExitTime),, True)
                Else
                    'Dim msg As String = String.Format("The CommandLineFile <{1}> exited, raising the Exited event at: <{2}> with Exit Code: <{3}>, UserProcessorTime: <{4}>, TotalProcessorTime: <{5}>{0}{0}",
                    '                                                               vbCrLf, commandlineProcess.ProcessName, commandlineProcess.ExitTime, commandlineProcess.ExitCode,
                    '                                                               commandlineProcess.UserProcessorTime, commandlineProcess.TotalProcessorTime)
                    'logger.LogEvent(msg)

                    g_ObjectManager.LogInfo("Common.CallCommandLineFile()", String.Format("{0} Completed normally.", strmsg),, True)
                End If
                commandlineProcess.Close()
                commandlineProcess.Dispose()

                If Not String.IsNullOrEmpty(myString) Then
                    g_ObjectManager.LogInfo("Common.CallCommandLineFile()", String.Format("Output from CommandLineFile: <" & myString & ">."),, True)
                End If
            End If

        Catch exPreJob As Exception
            g_ObjectManager.LogError("Common.CallCommandLineFile()", String.Format("ERROR: Exception caught in CommandLineFile Processing: {0}", exPreJob.ToString), True)


        End Try
    End Sub

    ''' <summary>
    ''' Gets a Column value from the LineItem Table, returned as a String.
    ''' </summary>
    ''' <param name="ProjectID">The project identifier.</param>
    ''' <param name="LineItemID">The line item identifier.</param>
    ''' <param name="ColumnToGet">The column to get.</param>
    ''' <returns>System.String.</returns>
    ''' <remarks>Valid Columns are: "Part_Family_ID", "Part_Family_Name", "Process", "Unit_Type", "Quantity",
    ''' "Cost", "Price", "Description", "Comments", "Deleted", "Last_Update_Date", "Last_Update_UserID",
    ''' "Checked_Out_By", "Creation_Date", "Creation_UserID", "Assigned_UserID", "Shareable", "Template" "Checked_Out_From"</remarks>
    ''' <example>In a Property Formula: 
    ''' Dim ProjectID As String = Rootpart.ProjectID 
    ''' Dim LineItemID As String = RootPart.LineItem 
    ''' Result = GetLineItemInformation(ProjectID, LineItemID,"Last_Update_UserID") </example>
    Public Function GetLineItemInformation(ByVal ProjectID As String, LineItemID As Integer, ColumnToGet As String) As String

        Dim returnString As String = String.Empty

        Try
            Dim SQL As String
            SQL = "SELECT [" & ColumnToGet & "] FROM [LineItem] WHERE Project_ID = '" & ProjectID & "' AND LineItem_ID = " & LineItemID
            '-- Execute the SQL against the project database
            Dim ds As DataSet = g_ProjectData.ExecuteSQL(SQL)
            '-- Make sure at least 1 result set was returned
            If ds.Tables.Count > 0 Then
                '-- Loop though each row in the first result set
                For Each dr As DataRow In ds.Tables(0).Rows
                    '-- Access a column value by index
                    returnString = (CStr(dr.Item(0)))
                    Exit For
                Next
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("GetLineItemInfo", String.Format("Error: ""{0}"" .", ex.Message), MsgBoxStyle.Critical)
        End Try
        Return returnString
    End Function

    <Browsable(False)> Public Sub RS_CustomReportError(ByVal Status As severity, ByVal Message As String)
        ' this is the dumy call to resolve syntax check error only
    End Sub

    <Browsable(False)> Public Sub RS_CustomReportError(ByVal part As Part, ByVal PropertyName As String, ByVal Status As severity, ByVal Message As String)
        Dim prop As PropertySF = Nothing

        If part IsNot Nothing Then
            prop = part.Properties(PropertyName)
            If prop IsNot Nothing Then
                prop.AddCustomErrorMessage(Status, Message)
            End If
        End If
    End Sub
    ''' <summary>
    ''' ViewSpecPopup: Set the __ViewSpecPopup property with the ViewSpecName and window attribute Resolution/Percentage
    ''' Also set the object manager popupSpecObj and add the popup to stack, to maintain track of multiple pop-up scenario
    ''' </summary>
    ''' <param name="partobj"></param>
    ''' <param name="ViewSpecName"></param>
    ''' <param name="Reso"></param>
    ''' <param name="Resizable"></param>
    <Browsable(False)> Public Sub ViewSpecPopup(ByVal partobj As Part, ByVal ViewSpecName As String, ByVal Reso As Int32, Optional Resizable As Boolean = True, Optional ShowCloseButton As Boolean = True)
        Dim popupSpec As Spec = Nothing
        Try
            'Get ViewSpec for popup from ViewSpecName and Part object
            popupSpec = g_ObjectManager.GetPopUpSpec("", partobj.ObjId, ViewSpecName)
            If (popupSpec IsNot Nothing) Then
                'Set the _ViewSpecProperty which is used to store pop-up window properties
                g_ObjectManager.SetViewSpecPopUpProperty(popupSpec, True, Reso, "", "", Resizable, ShowCloseButton)
                'Add the ViewSpec in stack and set the popupSpecObj of object manager
                g_ObjectManager.SetPopupSpecObject(partobj, popupSpec)
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.ViewSpecPopup()", "Fail to open pop-up. Detail Exception : " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.ViewSpecPopup() - End get viewSpec and set popupSpec object")
    End Sub
    ''' <summary>
    ''' ViewSpecPopup: Set the __ViewSpecPopup property with the ViewSpecName and window attribute Height and Width
    ''' Also set the object manager popupSpecObj and add the popup to stack, to maintain track of multiple pop-up scenario
    ''' </summary>
    ''' <param name="partobj"></param>
    ''' <param name="ViewSpecName"></param>
    ''' <param name="AbsWidth"></param>
    ''' <param name="AbsHeight"></param>
    ''' <param name="Resizable"></param>
    ''' <param name="ShowCloseButton"></param>
    <Browsable(False)> Public Sub ViewSpecPopup(ByVal partobj As Part, ByVal ViewSpecName As String, ByVal AbsWidth As Int32, ByVal AbsHeight As Int32, Optional Resizable As Boolean = True, Optional ShowCloseButton As Boolean = True)
        Dim popupSpec As Spec = Nothing
        Try
            'Get ViewSpec for popup from ViewSpecName and Part object
            popupSpec = g_ObjectManager.GetPopUpSpec("", partobj.ObjId, ViewSpecName)
            If (popupSpec IsNot Nothing) Then
                'Set the _ViewSpecProperty which is used to store pop-up window properties
                g_ObjectManager.SetViewSpecPopUpProperty(popupSpec, False, "", AbsWidth, AbsHeight, Resizable, ShowCloseButton)
                'Add the ViewSpec in stack and set the popupSpecObj of object manager
                g_ObjectManager.SetPopupSpecObject(partobj, popupSpec)
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.ViewSpecPopup()", "Fail to open pop-up. Detail Exception : " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.ViewSpecPopup() - End get viewSpec and set popupSpec object")
    End Sub

#Region "PLI"
    ' Neha : This will move to documentManager
    <Browsable(False)> Public Function CopyFilesFromFolderToFolder(ByVal SourceFolderPath As String, ByVal DestFolderPath As String) As Integer
        ' Copies all files from one folder with full path name (Source) to another with full path name (Dest)
        ' If the destination folder doesn't exist, it will be created
        ' If an error is encountered, it will throw an exception back up
        ' Used when copying line items

        ' Get the specified folder
        Dim result As Integer = 0
        g_ObjectManager.logger.DebugFormat("Common:CopyFilesFromFolderToFolder - Start copy folder from one location to another. Source Folder : " & SourceFolderPath & ". Destination folder : " & DestFolderPath)
        Try

            Dim SourceFolder As DirectoryInfo = New DirectoryInfo(SourceFolderPath)

            If SourceFolder.Exists Then

                ' If the destination folder doesn't exist, create it.
                If Not Directory.Exists(DestFolderPath) Then
                    Directory.CreateDirectory(DestFolderPath)
                End If

                ' Get the files in the directory and copy them to the new location.
                Dim Files As FileInfo() = SourceFolder.GetFiles()
                Dim Destination As String
                For Each FileToCopy As FileInfo In Files
                    Destination = Path.Combine(DestFolderPath, FileToCopy.Name)
                    FileToCopy.CopyTo(Destination, False)
                Next FileToCopy
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common:CopyFilesFromFolderToFolder - Fail to copy to destination folder: " & DestFolderPath & " . Exception: " & ex.ToString)
            result = -1

        End Try
        g_ObjectManager.logger.DebugFormat("Common:CopyFilesFromFolderToFolder - End copy folder from one location to another. Source Folder : " & SourceFolderPath & ". Destination folder : " & DestFolderPath)

        Return result
    End Function



    '
    ' Functions/subs/globals that are specific to the PLI apps
    ' These will be packaged up for delivery to customers after PLI work Is complete.
    '

    <ThreadStatic()> Public g_ProjectDS As DataSet
    <ThreadStatic()> Public g_ProjectDT As DataTable
    <ThreadStatic()> Public g_LineItemDS As DataSet
    <ThreadStatic()> Public g_LineItemDT As DataTable
    <ThreadStatic()> Public g_ReleasesDS As DataSet
    <ThreadStatic()> Public g_ReleasesDT As DataTable
    <ThreadStatic()> Public g_SelectedLineItemDS As DataSet
    <ThreadStatic()> Public g_SelectedLineItemDT As DataTable
    <ThreadStatic()> Public g_SelectedProjectDS As DataSet
    <ThreadStatic()> Public g_SelectedProjectDT As DataTable
    <ThreadStatic()> Public g_UsersDS As DataSet
    <ThreadStatic()> Public g_UsersDT As DataTable
    <ThreadStatic()> Public g_AppTLPFRouteDS As DataSet
    <ThreadStatic()> Public g_AppTLPFRouteDT As DataTable
    <ThreadStatic()> Public g_ClientServerTimeZoneOffset As TimeSpan = TimeSpan.Zero
    <ThreadStatic()> Public g_ClientTimeZoneOffsetFormatted As String


    Dim assembly As Assembly = System.Reflection.Assembly.GetExecutingAssembly
    Dim versionInfo As Version = assembly.GetName().Version()
    Dim strVersion As String = String.Format("{0}.{1}", versionInfo.Major, versionInfo.Minor.ToString("0000"))

    ''' <summary>
    ''' Initialize the Users, Route and timezone required for PLI application
    ''' </summary>
    <Browsable(False)> Public Sub RS_PLIInitialize(ByRef UserID As String, ByRef AdminUser As Boolean)
        g_ObjectManager.logger.DebugFormat("Common:RS_PLIInitialize - Start initialize the users, route and timezone required.")
        Try
            RS_PLILoadUsers()
            RS_PLILoadAppTLPFRoute(UserID, AdminUser)
            RS_PLIInitializeTimeZoneInfo()
        Catch ex As Exception
            g_ObjectManager.LogError("RS_PLIInitialize", "Fail to initialize components for PLI application")
        End Try
        g_ObjectManager.logger.DebugFormat("Common:RS_PLIInitialize - End initialize the users, route and timezone required.")
    End Sub

    ''' <summary>
    ''' Copies the files in the source release folder to the destination
    ''' Used as part of copying a project or an individual line item
    ''' </summary>
    ''' <param name="SourceProjectID">The source project identifier.</param>
    ''' <param name="SourceLineID">The source line item identifier.</param>
    ''' <param name="DestProjectID">The destination project identifier.</param>
    ''' <param name="DestLineID">The destination line item identifier.</param>
    ''' <returns>returns integer 0 : success, -1 : Failure</returns>
    <Browsable(False)> Public Function RS_PLICopyReleaseFolder(ByVal SourceProjectID As String,
                                          ByVal SourceLineID As Integer,
                                          ByVal DestProjectID As String,
                                          ByVal DestLineID As Integer) As Integer

        Dim result As Integer = 0
        g_ObjectManager.logger.DebugFormat("Common:RS_PLICopyReleaseFolder - Start to copy data for " & SourceProjectID & "  to " & DestProjectID)

        Try
            Dim DocManager As RuleStream.DocumentManager.IRsDocumentManager
            DocManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)

            Dim ReleaseFolderPath As String = DocManager.ReleasesFolder
            Dim SourceFolderName As String = String.Format("{0}{1}.{2:D4}.{3}", ReleaseFolderPath, SourceProjectID, SourceLineID, "0000\")
            Dim DestFolderName As String = String.Format("{0}{1}.{2:D4}.{3}", ReleaseFolderPath, DestProjectID, DestLineID, "0000\")
            result = CopyFilesFromFolderToFolder(SourceFolderName, DestFolderName)
        Catch ex As Exception
            g_ObjectManager.LogError("RS_PLICopyReleaseFolder", "Fail to copy data for " & SourceProjectID & " to " & DestProjectID & ". Detailed Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common:RS_PLICopyReleaseFolder - End to copy data  for " & SourceProjectID & "  to " & DestProjectID)

        Return result
    End Function

    ''' <summary>
    '''  Initializes the threadstatic public timezone variables.
    '''  User need to make sure this is called as part of the afterload event handler and database refresh for the PLI
    ''' </summary>
    <Browsable(False)> Public Sub RS_PLIInitializeTimeZoneInfo()
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIInitializeTimeZoneInfo() - Start to initialize Timezone.")
        Try
            Dim UTCNow As DateTime = DateTime.UtcNow
            Dim ServerNow As DateTime = DateTime.Now
            Dim ServerOffset As TimeSpan = ServerNow - UTCNow


            Dim prop As PropertySF = RootPart.Properties("__TimeZone")
            If prop IsNot Nothing Then
                Dim BrowserOffsetString As String = RootPart.__TimeZone
                Dim BrowserOffsetInt As Integer
                If Not Int32.TryParse(BrowserOffsetString, Nothing) Then
                    BrowserOffsetInt = 0
                Else
                    BrowserOffsetInt = BrowserOffsetString
                End If
                Dim Hours As Long = BrowserOffsetInt / 100
                Dim Minutes As Long = BrowserOffsetInt - Hours * 100
                Dim BrowserOffset As New TimeSpan(Hours, Minutes, 0)

                Dim CombinedOffset As New TimeSpan
                CombinedOffset = ServerOffset - BrowserOffset

                g_ClientServerTimeZoneOffset = CombinedOffset
                g_ClientTimeZoneOffsetFormatted = RS_PLITimeZoneOffsetFormatted(BrowserOffset)
            Else
                g_ObjectManager.LogError("Common.RS_PLIInitializeTimeZoneInfo()", "Unable to configure Timezone offset Formatted as __TimeZone property is Not configured on RootPart")
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIInitializeTimeZoneInfo()", "Fail to initialize Timezone. Detail information : " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIInitializeTimeZoneInfo() - Timezone offset Formatted with value : " & g_ClientTimeZoneOffsetFormatted)
    End Sub

    ''' <summary>
    ''' Convert the server time according to thin client timezone
    ''' </summary>
    ''' <param name="ServerTime">The server time needs to be converted.</param>
    ''' <returns>DateTime according to thin client</returns>
    <Browsable(False)> Public Function RS_PLIConvertServerTimeToClient(ByRef ServerTime As DateTime) As DateTime
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIConvertServerTimeToClient() - Start concerting serverTime.")

        If Not g_ClientServerTimeZoneOffset.Equals(TimeSpan.Zero) Then
            RS_PLIInitializeTimeZoneInfo() ' this will set offset
        End If
        Dim convertedTimespan As DateTime = ServerTime.Subtract(g_ClientServerTimeZoneOffset)
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIConvertServerTimeToClient() - End concerting serverTime.")
        Return convertedTimespan
    End Function

    ''' <summary>
    ''' Convert the thin client timezone according to server timezone
    ''' </summary>
    ''' <param name="ClientTime">The client timezone needs to be converted.</param>
    ''' <returns>DateTime according to server</returns>
    <Browsable(False)> Public Function RS_PLIConvertClientTimeToServer(ByRef ClientTime As DateTime) As DateTime
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIConvertClientTimeToServer() - Start concerting clientTime ")

        If Not g_ClientServerTimeZoneOffset.Equals(TimeSpan.Zero) Then
            RS_PLIInitializeTimeZoneInfo()
        End If
        Dim convertedTimespan As DateTime = ClientTime.Subtract(g_ClientServerTimeZoneOffset)
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIConvertClientTimeToServer() - End concerting clientTime.")
        Return convertedTimespan
    End Function

    ''' <summary>
    ''' Convert the time to provided formatString
    ''' </summary>
    ''' <param name="time">The client timezone needs to be converted.</param>
    ''' <param name="formatString">The client timezone needs to be converted. 
    ''' Supported formatString : "d", "D", "f", "F", "g", "G", "m", "o",
    '''                          "R", "s", "t", "T", "u", "U", "y"
    '''                          "h:mm:ss.ff t", "d MMM yyyy", "HH:mm:ss.f",
    '''                          "dd MMM HH:mm:ss", @"\Mon\t\h\: M", "HH:mm:ss.ffffzzz"</param>
    ''' <returns>the provided time formatted according to provided string
    ''' d: 6/15/2008
    ''' D: Sunday, June 15, 2008
    ''' f: Sunday, June 15, 2008 9:15 PM
    ''' F: Sunday, June 15, 2008 9:15:07 PM
    ''' g: 6/15/2008 9:15 PM
    ''' G: 6/15/2008 9:15:07 PM
    ''' m: June 15
    ''' o: 2008-06-15T21:15:07.0000000
    ''' R: Sun, 15 Jun 2008 21:15:07 GMT
    ''' s: 2008-06-15T21:15:07
    ''' t: 9:15 PM
    ''' T: 9:15:07 PM
    ''' u: 2008-06-15 21:15:07Z
    ''' U: Monday, June 16, 2008 4:15:07 AM
    ''' y: June, 2008
    ''' 'h:mm:ss.ff t': 9:15:07.00 P
    ''' 'd MMM yyyy': 15 Jun 2008
    ''' 'HH:mm:ss.f': 21:15:07.0
    ''' 'dd MMM HH:mm:ss': 15 Jun 21:15:07
    ''' '\Mon\t\h\: M': Month: 6
    ''' 'HH:mm:ss.ffffzzz': 21:15:07.0000-07:00</returns>
    Public Function RS_PLIFormatDateTime(ByRef time As DateTime, ByRef FormatString As String) As String
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIFormatDateTime() - Start Format DateTime ")

        Try
            Return (time.ToString(FormatString))
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIFormatDateTime()", "Fail to format date time. Detail exception " & ex.ToString)

            Return String.Empty
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIFormatDateTime() - End Format DateTime ")

    End Function

    ''' <summary>
    ''' Converts the offset to a formatted offset
    ''' </summary>
    ''' <param name="offset">The offset.</param>
    ''' <returns>Formatted offset as UTC-h\:mm</returns>
    <Browsable(False)> Public Function RS_PLITimeZoneOffsetFormatted(ByRef TheOffset As TimeSpan) As String
        Dim clientTimeZoneOffsetFormatted As String = String.Empty
        g_ObjectManager.logger.DebugFormat("Common.RS_PLITimeZoneOffsetFormatted() - Start Format timezone ")

        Try
            If TheOffset.Ticks < 0 Then
                clientTimeZoneOffsetFormatted = "UTC-" + TheOffset.ToString("h\:mm")
            Else
                clientTimeZoneOffsetFormatted = "UTC+" + TheOffset.ToString("h\:mm")
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLITimeZoneOffsetFormatted()", "Fail to format time zone. Detail exception " & ex.ToString)

            Return String.Empty
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLITimeZoneOffsetFormatted() - End Format timezone ")
        Return clientTimeZoneOffsetFormatted
    End Function

    ''' <summary>
    ''' Execute the provided SQL and populates the Project data set / data table
    ''' </summary>
    ''' <param name="SQL">SQL query to execute</param>
    ''' <returns>The number of projects found for provided SQL query, If failure will return -1</returns>
    <Browsable(False)> Public Function RS_PLISearchProjects(ByRef SQL As String) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchProjects() - Search projects on Project database with SQL : " & SQL)
        Dim searchProjectFound As Integer = 0
        Try

            g_ProjectDS = g_ProjectData.ExecuteSQL(SQL)

            If g_ProjectDS IsNot Nothing AndAlso g_ProjectDS.Tables.Count > 0 Then
                g_ProjectDT = g_ProjectDS.Tables(0)
                searchProjectFound = g_ProjectDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLISearchProjects()", "Fail to perform search on project database with provided SQL. Detail exception " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchProjects() - Total no. of projects found from search SQL : " & searchProjectFound)
        Return searchProjectFound
    End Function

    ''' <summary>
    ''' Execute the provided SQL to return fixed number of records
    ''' </summary>
    ''' <param name="MaxRecords">Maximum numbers of records need to returns from Project Database based on ProjConditions query</param>
    ''' <param name="ProjConditions">SQL query to execute</param>
    ''' <returns>The number of projects found for provided SQL query, If failure will return -1</returns>   
    <Browsable(False)> Public Function RS_PLISearchProjectsBasic(ByRef MaxRecords As Integer,
                                              ByRef ProjConditions As String) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchProjectsBasic() - Start Search projects on Project database with maxRecords : " & MaxRecords & " and projConditions : " & ProjConditions)

        Dim result As Integer = 0
        Try
            g_ProjectDS = g_ProjectData.GetProjectDataView(MaxRecords, ProjConditions)

            If g_ProjectDS IsNot Nothing AndAlso g_ProjectDS.Tables.Count > 0 Then
                g_ProjectDT = g_ProjectDS.Tables(0)
                result = g_ProjectDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLISearchProjectsBasic()", "Fail to perform search on project database with provided SQL. Detail exception " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchProjectsBasic() - End Search projects on Project database with maxRecords :" & MaxRecords & " and projConditions : " & ProjConditions & " rows count of : " & result)
        Return result
    End Function

    ''' <summary>
    ''' TO DO
    ''' </summary>
    ''' <param name="MaxRecords">Maximum numbers of records need to returns from Project Database based on ProjConditions query</param>
    ''' <param name="ProjConditions">SQL query to execute</param>
    ''' <param name="UDFConditions">SQL query to execute for UDF</param>
    ''' <returns>The number of projects found for provided SQL query, If failure will return -1</returns>
    Public Function RS_PLISearchProjectWithUDFs(ByRef MaxRecords As Integer,
                                                  ByRef ProjConditions As String,
                                                  ByRef UDFConditions As String) As Integer

        Return -1
    End Function

    ''' <summary>
    ''' Execute the provided SQL to return Line Items
    ''' </summary>
    ''' <param name="MaxRecords">Maximum numbers of records need to returns from Project Line Item Database based on LineItem condition</param>
    ''' <param name="lineItemConditions">Where condition to execute</param>
    ''' <returns>The number of line items found for provided SQL query, If failure will return -1</returns>
    Public Function RS_PLISearchLineItems(ByRef MaxRecords As Integer, ByRef lineItemConditions As String) As Integer

        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchLineItems() - Start Search LineItems on Project database with maxRecords : " & MaxRecords & " and lineItemConditions : " & lineItemConditions)
        Dim searchLineItemsFound As Integer = 0
        Try
            g_LineItemDS = g_ProjectData.GetLineDataView(MaxRecords, lineItemConditions)

            If g_LineItemDS IsNot Nothing AndAlso g_LineItemDS.Tables.Count > 0 Then
                g_LineItemDT = g_LineItemDS.Tables(0)
                searchLineItemsFound = g_LineItemDT.Rows.Count
            End If
			If searchLineItemsFound = 0 Then g_ObjectManager.LogError("RS_PLISearchLineItems", "No line items can be found that can be opened in the VIA thin client")

        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLISearchLineItems()", "Fail to perform search on project database with provided SQL. Detail exception " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchLineItems() - Total no. of LineItems found from search SQL : " & searchLineItemsFound)
        Return searchLineItemsFound
    End Function

    ''' <summary>
    ''' Execute the provided SQL to return Releases.
    ''' </summary>
    ''' <param name="ProjectID">ProjectID for Releases Search</param>
    ''' <param name="LineItemID">LineItemID for Releases Search</param>
    ''' <returns></returns>
    Public Function RS_PLISearchReleases(ByRef ProjectID As String, ByRef LineItemID As Integer) As Integer

        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchReleases() - Start Search Releases on Project database with ProjectID : " & ProjectID & " and LineItemID : " & LineItemID)
        Dim searchReleasesFound As Integer = 0
        Try
            g_ReleasesDS = g_ProjectData.GetReleaseDataView(ProjectID, LineItemID)

            If g_ReleasesDS IsNot Nothing AndAlso g_ReleasesDS.Tables.Count > 0 Then
                g_ReleasesDT = g_ReleasesDS.Tables(0)
                searchReleasesFound = g_ReleasesDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLISearchReleases()", "Fail to perform search on project database with provided SQL. Detail exception " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISearchReleases() - Total no. of Releases found from search SQL : " & searchReleasesFound)
        Return searchReleasesFound
    End Function

    ''' <summary>
    ''' Load all users in a profile
    ''' </summary>
    ''' <returns>The number of users in a profile, If failure will return -1</returns>
    Public Function RS_PLILoadUsers() As Integer

        g_ObjectManager.logger.DebugFormat("Common.RS_PLILoadUsers() - Start Loading all users. ")
        Dim noOfLoadedUsers As Integer = 0
        Try

            g_UsersDS = g_RulesData.GetUserDetailsView()

            If g_UsersDS IsNot Nothing AndAlso g_UsersDS.Tables.Count > 0 Then
                g_UsersDT = g_UsersDS.Tables(0)
                noOfLoadedUsers = g_UsersDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLILoadUsers()", "Fail to Load users in an application. Detail Exception : " & ex.ToString)
            noOfLoadedUsers = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLILoadUsers() - Total number of users loaded : " & noOfLoadedUsers)
        Return noOfLoadedUsers
    End Function

    ''' <summary>
    ''' Load all routes for active user in global data table
    ''' </summary>
    ''' <returns>The number of routes in an application, If failure will return -1</returns>
    Public Function RS_PLILoadAppTLPFRoute(ByRef UserID As String, ByRef AdminUser As Boolean) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLILoadAppTLPFRoute() - Start Loading all via routes in an application. ")
        Dim noOfLoadAppTLPFRoute As Integer = 0
        Try
            g_AppTLPFRouteDS = g_RulesData.GetTLPFAppInfo(UserID, AdminUser)

            If g_AppTLPFRouteDS IsNot Nothing AndAlso g_AppTLPFRouteDS.Tables.Count > 0 Then
                g_AppTLPFRouteDT = g_AppTLPFRouteDS.Tables(0)

                noOfLoadAppTLPFRoute = g_AppTLPFRouteDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.logger.DebugFormat("Common.RS_PLILoadAppTLPFRoute()", "Fail to Load routes in an application. Detail Exception : " & ex.ToString)
            noOfLoadAppTLPFRoute = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLILoadAppTLPFRoute() - Total number of Via Routes in an application : " & noOfLoadAppTLPFRoute)
        Return noOfLoadAppTLPFRoute

    End Function

    ''' <summary>
    ''' Delete project for provided projectID
    ''' This will internally mark for project for Delete as True
    ''' </summary>
    ''' <param name="ProjectID">The ID of a project which needs to delete</param>
    ''' <returns>Return Integer as 0 For success, -1 as Failure</returns>
    Public Function RS_PLIDeleteProject(ByRef ProjectID As String) As Integer
        ' Still needs logic to optionally clean up folders
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIDeleteProject() - Start deleting project with projectID  " & ProjectID)
        Dim result As Integer = 0
        Try
            g_ProjectData.DeleteProject(ProjectID)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIDeleteProject()", "Fail to delete project information for projectID " & ProjectID & ". Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIDeleteProject() - Finished project deleting process.")
        Return result
    End Function

    ''' <summary>
    ''' Copy the project with provided projectID
    ''' Copies a project to a new project, including both project data and release0000 folder
    ''' Assumes the project has no checked out line items and is not deleted
    ''' Assumes the project being copied has the line items loaded in the global line item data table
    ''' </summary>
    ''' <param name="ProjectID">The ID of a project which needs to copy</param>
    ''' <returns>Return new Project Id, if failure return empty string</returns>
    Public Function RS_PLICopyProject(ByRef OldProjectID As String) As String

        g_ObjectManager.logger.DebugFormat("Common.RS_PLICopyProject() - Start copy project for " & OldProjectID)
        Dim NewProjectID As String = String.Empty
        Try

            NewProjectID = g_ProjectData.CopyProject(OldProjectID, g_rsUser.ProjectPrefix, g_rsUser.UserName)

            g_ObjectManager.logger.DebugFormat("Common.RS_PLICopyProject()", "Copy information to new projectID : " & NewProjectID)

            If Not String.IsNullOrEmpty(NewProjectID) Then
                Dim LineItemID As Long
                Dim DR As DataRow
                For Each DR In g_LineItemDT.Rows
                    LineItemID = DR.Item("LineItem_ID")
                    RS_PLICopyReleaseFolder(OldProjectID, LineItemID, NewProjectID, LineItemID)
                Next DR
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLICopyProject()", "Fail to copy project information for projectID " & OldProjectID & ". Detail Exception : " & ex.ToString)
            NewProjectID = String.Empty
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICopyProject() - Finished project copying process from oldprojectId : " & OldProjectID & " to new ProjectID : " & NewProjectID)
        Return NewProjectID

    End Function
    ''' <summary>
    ''' UnDelete Project
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for UnDelete Project</param>
    ''' <returns>Return an Integer 0 for success, -1 for failure</returns>
    Public Function RS_PLIUndeleteProject(ByRef ProjectID As String) As Integer

        g_ObjectManager.logger.DebugFormat("Common.RS_PLIUndeleteProject() - Start undelete project with projectID  " & ProjectID)
        Dim result As Integer = 0
        Try
            g_ProjectData.UndeleteForProject(ProjectID)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIUndeleteProject()", "Fail to undelete project information for projectID " & ProjectID & ". Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIUndeleteProject() - Finished project undelete process.")
        Return result
    End Function
    ''' <summary>
    ''' UnDelete Line Item
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for UnDelete LineItem</param>
    ''' <param name="LineItemID">LineItemID required for UnDelete</param>
    ''' <returns>Return an Integer 0 for success, -1 for failure</returns>
    Public Function RS_PLIUndeleteLineItem(ByRef ProjectID As String, ByVal LineItemID As Integer) As Integer
        'check used in admin
        'selected projectid is valid
        'enabled and visibility for buttons

        ' Still needs logic to optionally clean up folders
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIUndeleteLineItem() - Start undelete lineItem with projectID  " & ProjectID & " and lineitemId " & LineItemID)
        Dim result As Integer = 0
        Try

            g_ProjectData.UndeleteForLineItem(ProjectID, LineItemID)

        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIUndeleteLineItem()", "Fail to undelete project information for projectID " & ProjectID & "lineitemID" & LineItemID & ". Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIUndeleteLineItem() - Finished lineItem undelete process.")
        Return result
    End Function
    ''' <summary>
    ''' Gets Line Item Properties Information
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for Properties information of  LineItem</param>
    ''' <param name="LineItemID">LineItemID required for Properties information of  LineItem</param>
    ''' <returns>Return successfully line item properties , if Failure returns an empty string</returns>
    Public Function RS_PLIGetLineItemProperties(ByRef ProjectID As String, ByVal LineItemID As Integer) As Integer
        Dim searchLineItemsFound As Integer = 0
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIGetLineItemProperties() - Start get line item properties with projectID  " & ProjectID & " and lineitemId " & LineItemID)
        Try
            g_LineItemDS = g_ProjectData.GetLineInfo(ProjectID, LineItemID)
            If g_LineItemDS IsNot Nothing AndAlso g_LineItemDS.Tables.Count > 0 Then
                g_LineItemDT = g_LineItemDS.Tables(0)
                searchLineItemsFound = g_LineItemDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIGetLineItemProperties()", "Fail to get properties for project information for projectID " & ProjectID & "lineitemID" & LineItemID & ". Detail Exception : " & ex.ToString)
            searchLineItemsFound = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIGetLineItemProperties() - Finished  get line item properties process.")
        Return searchLineItemsFound
    End Function


    ''' <summary>
    ''' Create a new Project
    ''' </summary>
    ''' <returns>Return new created projectID, if Failure returns an empty string</returns>
    Public Function RS_PLINewProject(ByRef CustomerName As String, ByVal Optional AppName As String = "") As String

        g_ObjectManager.logger.DebugFormat("Common.RS_PLINewProject() - Start creating new project.")
        Dim ProjectID As String = String.Empty
        Try
            Dim RSAppVersion As String = strVersion
            Dim ProjectDS As DataSet

            If Not String.IsNullOrEmpty(CustomerName) Then
                ProjectDS = g_ProjectData.Globals_InsertUpdateProject("", CustomerName, AppName, RSAppVersion, g_rsUser.SiteID, g_rsUser.UserName)
                If ProjectDS IsNot Nothing AndAlso ProjectDS.Tables.Count > 0 AndAlso ProjectDS.Tables(0).Rows.Count > 0 Then
                    ProjectID = ProjectDS.Tables(0).Rows(0).Item(0)
                End If

            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLINewProject()", "Fail to Create new project. Detail Exception : " & ex.ToString)
            ProjectID = String.Empty
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLINewProject() - Finished creating new project with Project : " & ProjectID)

        Return ProjectID
    End Function

    ''' <summary>
    ''' Save a selected Project
    ''' </summary>
    ''' <returns>Return successfully saved projectID, if Failure returns an empty string</returns>
    Public Function RS_PLISaveProject(ByRef ProjectID As String, ByRef CustomerName As String, ByVal Optional AppName As String = "") As String
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISaveProject() - Start saving selected Project.")
        Try
            Dim RSAppVersion As String = strVersion
            g_ObjectManager.LogInfo("Common.RS_PLISaveProject()", "Saving Project with project Id : " & ProjectID)

            Dim ProjectDS As DataSet
            If Not String.IsNullOrEmpty(CustomerName) Then
                ProjectDS = g_ProjectData.Globals_InsertUpdateProject(ProjectID, CustomerName, AppName, RSAppVersion, g_rsUser.SiteID, g_rsUser.UserName)
                If ProjectDS IsNot Nothing AndAlso ProjectDS.Tables.Count > 0 AndAlso ProjectDS.Tables(0).Rows.Count > 0 Then
                    ProjectID = ProjectDS.Tables(0).Rows(0).Item(0)
                End If

            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLISaveProject()", "Fail to save selected project. Detail Exception : " & ex.ToString)
            ProjectID = String.Empty
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLISaveProject() - End saving selected Project with Id : " & ProjectID)
        Return ProjectID
    End Function

    ''' <summary>
    ''' Is project line item checked out to someone other than the current user?
    ''' </summary>
    ''' <param name="ProjectID">ProjectID for checkout need to verify</param>
    ''' <param name="LineItemID">LineItemID for checkout need to verify</param>
    ''' <returns>True if checkout is done by current user, otherwise return false</returns>
    Public Function RS_PLIISCheckedOut(ByVal ProjectID As String, ByVal LineItemID As Int32) As Boolean
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICheckedOut() - Start if checkout of projectID : " & ProjectID & " having LineItemID : " & LineItemID)
        Dim result As Boolean = False
        Try
            result = g_ProjectData.Globals_IsProjectLineItemCheckedOut(ProjectID, LineItemID, g_rsUser.UserName)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLICheckedOut()", "Fail to check if checkout of projectID : " & ProjectID & " having LineItemID : " & LineItemID & "Detail Exception : " & ex.ToString)
            result = False
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICheckedOut() - End if checkout is done by current user for projectID : " & ProjectID & " having LineItemID : " & LineItemID)
        Return result
    End Function

    ''' <summary>
    ''' CheckOut line item
    ''' </summary>
    ''' <param name="ProjectID">ProjectID for checkout</param>
    ''' <param name="LineItemID">LineItemID for checkout</param>
    ''' <param name="CurrentUserID">CurrentUserID for performing</param>
    ''' <param name="isAdmin">If Admin, This is optional with default value as False</param>
    ''' <returns>True if checkout is successful, otherwise return false</returns>
    Public Function RS_PLICheckoutLineItem(ByVal ProjectID As String, ByVal LineItemID As Integer, ByVal CurrentUserID As String, Optional ByVal isAdmin As Boolean = False) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICheckoutLineItem() - Start checkout of projectID : " & ProjectID & " having LineItemID :  " & LineItemID)
        Dim result As Integer = 0
        Try
            g_ProjectData.Globals_CheckoutLineItem(ProjectID, LineItemID, CurrentUserID, 1, isAdmin)
            Dim DocManager As RuleStream.DocumentManager.IRsDocumentManager
            DocManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)
            DocManager.PopulateWorkingZeroFolder(ProjectID, LineItemID)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLICheckoutLineItem()", "Fail checkout of projectID : " & ProjectID & " having LineItemID : " & LineItemID & "Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICheckoutLineItem() - End checkout of projectID : " & ProjectID & " having LineItemID :  " & LineItemID)
        Return result
    End Function

    ''' <summary>
    ''' Checkin line item
    ''' </summary>
    ''' <param name="ProjectID">ProjectID for checkin</param>
    ''' <param name="LineItemID">LineItemID for checkin</param>
    ''' <param name="CurrentUserID">CurrentUserID for performing</param>
    ''' <param name="isAdmin">If Admin, This is optional with default value as False</param>
    ''' <returns>Integer 0 as Success, -1 as </returns>
    Public Function RS_PLICheckinLineItem(ByVal ProjectID As String, ByVal LineItemID As Integer, ByVal CurrentUserID As String, Optional ByVal isAdmin As Boolean = False) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICheckinLineItem() - Start check-in of projectID : " & ProjectID & "  having LineItemID : " & LineItemID)
        Dim result As Integer = 0
        Try
            Dim DocManager As RuleStream.DocumentManager.IRsDocumentManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)
            ' We are checking files in.  Selectively copy the contents of the wip folder to the working
            ' zero folder and then from the working zero to the release zero folder
            DocManager.PopulateReleaseZeroFolder(ProjectID, LineItemID)

            g_ProjectData.Globals_CheckoutLineItem(ProjectID, LineItemID, CurrentUserID, 0, isAdmin)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLICheckinLineItem()", "Fail to checkin of projectID : " & ProjectID & " having LineItemID : " & LineItemID & "Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICheckinLineItem() - End check-in of projectID : " & ProjectID & " having LineItemID : " & LineItemID)
        Return result
    End Function

    ''' <summary>
    ''' Rollback Line Item from Releases
    ''' </summary>
    ''' <param name="ProjectID">ProjectID for Rollback Lineitem</param>
    ''' <param name="LineItemID">LineItemID for Rollback Lineitem</param>
    ''' <param name="ReleaseNumber">ReleaseNumber for Rollback Lineitem</param>
    ''' <param name="CurrentUserID">CurrentUserID for Rollback Lineitem</param>
    ''' <param name="isAdmin">If Admin, This is optional with default value as False</param>
    ''' <returns></returns>
    Public Function RS_PLIRollbackReleases(ByVal ProjectID As String, ByVal LineItemID As Integer, ByVal ReleaseNumber As Integer, ByVal CurrentUserID As String, Optional ByVal isAdmin As Boolean = False)
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRollbackReleases() - Start Rollback of ProjectID : " & ProjectID & "  having LineItemID : " & LineItemID & " and ReleaseNumber : " & ReleaseNumber)
        Dim result As Integer = 0
        Try
            Dim docManager As RuleStream.DocumentManager.IRsDocumentManager
            RS_PLICheckinLineItem(ProjectID, LineItemID, CurrentUserID, isAdmin)
            g_ProjectData.UpdateLineItemCheckoutForProjectLineItem(ProjectID, LineItemID, CurrentUserID)

            docManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)
            Dim workingFolder As IO.DirectoryInfo = New IO.DirectoryInfo(docManager.GetReleasePath(ProjectID, LineItemID, 0))
            Dim releaseFolder As IO.DirectoryInfo = New IO.DirectoryInfo(docManager.GetReleasePath(ProjectID, LineItemID, ReleaseNumber))

            workingFolder.Delete(True)
            workingFolder.Create()

            For Each oFile As IO.FileInfo In releaseFolder.GetFiles()
                oFile.CopyTo(workingFolder.ToString & oFile.Name, True)
            Next

            g_ObjectManager.Rollback(ProjectID, LineItemID, ReleaseNumber)
            RS_PLICheckinLineItem(ProjectID, LineItemID, CurrentUserID, isAdmin)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIRollbackReleases()", "Fail to Rollback of ProjectID : " & ProjectID & " having LineItemID : " & LineItemID & " and ReleaseNumber : " & ReleaseNumber & "Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRollbackReleases() - End Rollback of ProjectID : " & ProjectID & " having LineItemID : " & LineItemID & " and ReleaseNumber : " & ReleaseNumber)
        Return result
    End Function

    ''' <summary>
    ''' Get all files of provided doc types in provided lineItem Release
    ''' </summary>
    ''' <param name="DocumetTypes">Comma separated document types</param>
    ''' <param name="ProjectID">ProjectID</param>
    ''' <param name="LineItemID">LineItemID</param>
    ''' <returns>String with comma separated File names matching search otherwise empty string</returns>
    Public Function RS_PLIGetDocuments(ByVal DocumetTypes As String, ByVal ProjectID As String, ByVal LineItemID As String) As String
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIGetDocuments() - Start getting files from documentTypes : " & DocumetTypes)
        Dim result As String = String.Empty
        Try
            Dim DocManager As RuleStream.DocumentManager.IRsDocumentManager
            DocManager = CType(g_DocAccess, RuleStream.DocumentManager.IRsDocumentManager)
            Dim ReleaseFolderPath As String = DocManager.ReleasesFolder
            Dim SourceFolderName As String = String.Format("{0}{1}.{2:D4}.{3}", ReleaseFolderPath, ProjectID, LineItemID, "0000\")
            Dim releaseZeroFolder As DirectoryInfo = New DirectoryInfo(SourceFolderName)
            Dim DocTypes() As String = DocumetTypes.Split(",")
            Dim i As Int32 = 0
            For i = 0 To DocTypes.Length - 1
                Dim docType As String = "." + DocTypes(i).Trim
                For Each releaseFile As FileInfo In releaseZeroFolder.GetFiles
                    If releaseFile.Extension.Equals(docType, StringComparison.CurrentCultureIgnoreCase) Then
                        If String.IsNullOrEmpty(result) Then
                            result = releaseFile.Name
                        Else
                            result = result + "," + releaseFile.Name
                        End If
                    End If
                Next
            Next i
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIGetDocuments()", "Fail to get files from documents of projectID : " & ProjectID & " having LineItemID : " & LineItemID & "Detail Exception : " & ex.ToString)
            result = String.Empty
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIGetDocuments() - End getting files from documentTypes :  " & DocumetTypes)
        Return result
    End Function

    ''' <summary>
    ''' Cancel checkout of line item
    ''' </summary>
    ''' <param name="ProjectID">ProjectID for cancel checkout</param>
    ''' <param name="LineItemID">LineItemID for cancel checkout</param>
    ''' <param name="CurrentUserID">CurrentUserID for performing</param>
    ''' <param name="isAdmin">If Admin, This is optional with default value as False</param>
    ''' <returns>Integer 0 as Success, -1 as </returns>
    Public Function RS_PLICancelCheckout(ByVal ProjectID As String, ByVal LineItemID As Integer, ByVal CurrentUserID As String, Optional ByVal isAdmin As Boolean = False) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICancelCheckout()", "Start cancel of checkout projectID : " & ProjectID & " having LineItemID : " & LineItemID)
        Dim result As Integer = 0
        Try
            g_ProjectData.Globals_CheckoutLineItem(ProjectID, LineItemID, CurrentUserID, 0, isAdmin)

        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLICancelCheckout()", "Fail to cancel checkout of projectID : " & ProjectID & " having LineItemID : " & LineItemID & "Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICancelCheckout() - End cancel checkout with returns value  :  " & result)
        Return result
    End Function

    ''' <summary>
    ''' Insert or Update a Line Item.
    ''' </summary>
    ''' <param name="ProjectID">The project ID.</param>
    ''' <param name="LineItemID">The line item ID. If need to create then pass it as 0 or nothing</param>
    ''' <param name="ProcessID">The process ID.</param>
    ''' <param name="AssignedTo">The UserID this LineItem is assigned to.</param>
    ''' <param name="PartFamilyID">The part family ID.</param>
    ''' <param name="PartFamily">The part family.</param>
    ''' <param name="Units">The units.</param>
    ''' <param name="Qty">The qty.</param>
    ''' <param name="Cost">The cost.</param>
    ''' <param name="Price">The price.</param>
    ''' <param name="Description">The description.</param>
    ''' <param name="Comments">The comments.</param>
    ''' <param name="CheckedOutBy">The UserID that checked out this LineItem.</param>
    ''' <param name="UserName">Name of the user.</param>
    ''' <returns>Integer ad create/update lineItem Id, If failure return -1</returns>
    Public Function RS_PLICreateLineItem(ByVal ProjectID As String,
                                                  ByVal LineItemID As Int32,
                                                  ByVal ProcessID As String,
                                                  ByVal AssignedTo As String,
                                                  ByVal PartFamilyID As Int32,
                                                  ByVal PartFamily As String,
                                                  ByVal Units As String,
                                                  ByVal Qty As String,
                                                  ByVal Cost As String,
                                                  ByVal Price As String,
                                                  ByVal Description As String,
                                                  ByVal Comments As String,
                                                  ByVal CheckedOutBy As String) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICreateLineItem() - Start Creating/updating LineItemID")
        Dim newLineItemID As Integer = -1
        Try
            Dim ds As DataSet = g_ProjectData.Globals_InsertUpdateLinteItem(ProjectID, LineItemID, ProcessID, AssignedTo,
                                                                                       PartFamilyID, PartFamily, Units, Qty, Cost,
                                                                                       Price, Description, Comments, CheckedOutBy,
                                                                                        g_rsUser.UserName)

            If Not IsNothing(ds) Then
                If ds.Tables.Count > 0 Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dim dr As DataRow = ds.Tables(0).Rows(0)
                        newLineItemID = CType(dr.Item(0), Integer)
                    End If
                End If
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLICreateLineItem()", "Fail to create/update LineItemID. " & "Detail Exception : " & ex.ToString)
            newLineItemID = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICreateLineItem() - End create/update LineItemID")
        Return newLineItemID
    End Function

    ''' <summary>
    ''' Copy Line Item
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for copying LineItem</param>
    ''' <param name="LineItemID">LineItemID required for copying</param>
    ''' <param name="UserName">UserName</param>
    ''' <returns>Return an Integer as LineItem for success, -1 for failure</returns>
    Public Function RS_PLICopyLineItem(ByVal ProjectID As String, ByVal LineItemID As Integer, ByVal UserName As String) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICopyLineItem() - Start copy LineItemID : " & LineItemID)
        Dim copiedLineItemID As Integer = 0
        Try
            copiedLineItemID = g_ProjectData.CopyLineItem(ProjectID, LineItemID, UserName)
            If copiedLineItemID = 0 Then ' This is Failure case
                copiedLineItemID = -1
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLICopyLineItem()", "Fail to copy LineItemID : " & LineItemID & "Detail Exception : " & ex.ToString)
            copiedLineItemID = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLICopyLineItem() - End copy LineItemID : " & LineItemID)
        Return copiedLineItemID

    End Function

    ''' <summary>
    ''' Delete Line Item
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for deleting LineItem</param>
    ''' <param name="LineItemID">LineItemID required for deleting</param>
    ''' <returns>Return an Integer 0 for success, -1 for failure</returns>
    Public Function RS_PLIDeleteLineItem(ByVal ProjectID As String, ByVal LineItemID As Integer) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIDeleteLineItem() - Start delete LineItemID : " & LineItemID)
        Dim result As Integer = 0
        Try
            g_ProjectData.DeleteLineItem(ProjectID, LineItemID)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIDeleteLineItem()", "Fail to delete LineItemID : " & LineItemID & "Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIDeleteLineItem() - End delete LineItemID : " & LineItemID)
        Return result
    End Function

    ''' <summary>
    ''' Check If LineItem is sharable
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for performing operation</param>
    ''' <param name="LineItemID">LineItemID required for performing operation</param>
    ''' <returns>Return an True is shareable otherwise false</returns>
    Public Function RS_PLIIsShareable(ByVal ProjectID As String, ByVal LineItem As Int32) As Boolean

        g_ObjectManager.logger.DebugFormat("Common.RS_PLIIsShareable() - Start checking if projectID : " & ProjectID & " having LineItemID : " & LineItem & "  is shareable or not.")
        Dim result As Boolean
        Try
            result = g_ProjectData.IsShareable(ProjectID, LineItem)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIIsShareable()", "Fail to check if projectID : " & ProjectID & " having LineItemID : " & LineItem & " is shareable or not. Detail Exception : " & ex.ToString)

            result = False
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIIsShareable() - End checking if projectID : " & ProjectID & " having LineItemID : " & LineItem & "  is shareable or not.")
        Return result
    End Function
    ''' <summary>
    ''' This is to be run right before making a change to a line item to make certain that nothing has changed in the background since
    ''' the data was last read by the PLI App. If multiple conditions are satisfied, the first order of precedence is taken
    ''' Order of Precedence     Return Code    Condition/Description
    ''' 1                       4              Query failed
    ''' 2                       3              Is Deleted
    ''' 3                       0              Not Checked Out
    ''' 4                       1              Checked Out by specified user
    ''' 5                       2              Checked Out by another user
    ''' </summary>
    Public Function RS_PLIDoubleCheckCheckOutStatus(ByRef ProjectID As String, ByRef LineItem As Integer, ByRef User As String) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLI_DoubleCheckCheckOutStatus() - Start double checking if projectID : " & ProjectID & " having LineItemID : " & LineItem & "  has updated values.")
        Dim DS As DataSet
        Dim DT As DataTable
        Dim CheckedOutUser As String = ""
        Dim AssignedUser As String = ""
        Dim IsDeleted As Boolean = False
        Dim IsShared As Boolean = False
        Dim IsTemplate As Boolean = False
        Try
            DS = g_ProjectData.GetCheckOutByUser(ProjectID, LineItem)
            If DS IsNot Nothing AndAlso DS.Tables.Count = 1 Then
                DT = DS.Tables(0)
                If DT.Rows.Count = 1 Then
                    CheckedOutUser = NullToString(DT.Rows(0).Item("Checked_Out_By"))
                    AssignedUser = NullToString(DT.Rows(0).Item("Assigned_UserID"))
                    IsDeleted = DT.Rows(0).Item("Deleted")
                    IsShared = DT.Rows(0).Item("Shareable")
                    IsTemplate = DT.Rows(0).Item("Template")
                    If IsDeleted Then
                        Return 3
                    ElseIf IsShared Then
                        Return 5
                    ElseIf IsTemplate Then
                        Return 6
                    ElseIf AssignedUser <> User AndAlso AssignedUser <> "" Then
                        Return 7
                    ElseIf AssignedUser = User Then
                        Return 8
                    ElseIf CheckedOutUser = "" Then
                        Return 0
                    ElseIf CheckedOutUser = User Then
                        Return 1
                    Else
                        Return 2
                    End If
                Else
                    Return 4
                End If
            Else
                Return 4
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLI_DoubleCheckCheckOutStatus()", "Fail to check if projectID : " & ProjectID & " having LineItemID : " & LineItem & " has updated values or not. Detail Exception : " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLI_DoubleCheckCheckOutStatus() - End checking if projectID : " & ProjectID & " having LineItemID : " & LineItem & " has updated values or not")
    End Function
    ''' <summary>
    ''' Check If LineItem is sharable
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for performing operation</param>
    ''' <param name="LineItemID">LineItemID required for performing operation</param>
    ''' <returns>Return -1 for exception</returns>
    Public Function RS_PLIMakeLineItemShareable(ByVal shouldMakeShareable As Boolean, ByVal projectID As String, ByVal lineItemID As Integer, ByRef UserID As String) As Integer

        g_ObjectManager.logger.DebugFormat("Common.RS_PLIIsShareable() - Start making projectID : " & projectID & " having LineItemID : " & lineItemID & "  is shareable.")
        Dim result As Integer
        Try
            result = g_ProjectData.MakeLineItemShareable(shouldMakeShareable, projectID, lineItemID, UserID)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIIsShareable()", "Fail to make if projectID : " & projectID & " having LineItemID : " & lineItemID & " is shareable. Detail Exception : " & ex.ToString)

            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIIsShareable() - end making projectID : " & projectID & " having LineItemID : " & lineItemID & "  is shareable.")
        Return result
    End Function
    ''' <summary>
    ''' To make line item create template 
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for performing operation</param>
    ''' <param name="LineItemID">LineItemID required for performing operation</param>
    ''' <returns>Return -1 for exception</returns>
    Public Function RS_PLIMakeLineItemTemplate(ByVal shouldMakeTemplate As Boolean, ByVal projectID As String, ByVal lineItemID As Integer, ByRef UserID As String) As Integer

        g_ObjectManager.logger.DebugFormat("Common.RS_MakeLineItemTemplate() - Start making projectID : " & projectID & " having LineItemID : " & lineItemID & "  is template.")
        Dim result As Integer
        Try
            result = g_ProjectData.MakeLineItemTemplate(shouldMakeTemplate, projectID, lineItemID, UserID)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_MakeLineItemTemplate()", "Fail to make if projectID : " & projectID & " having LineItemID : " & lineItemID & " is template. Detail Exception : " & ex.ToString)

            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_MakeLineItemTemplate() - end making projectID : " & projectID & " having LineItemID : " & lineItemID & "  is template.")
        Return result
    End Function
    ''' <summary>
    ''' This method is used to get updated and refreshed values from LineItem Views
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for performing operation</param>
    ''' <param name="LineItemID">LineItemID required for performing operation</param>
    ''' <returns>Return -1 for exception</returns>
    Public Function RS_PLIRefreshSelectedLineItemSearch(ByRef ProjectID As String, ByRef LineItem As Integer) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRefreshSelectedLineItemSearch() - Start getting refreshed data for projectID : " & ProjectID & " having LineItemID : " & LineItem)
        Dim LineItemsFound As Integer = 0
        Try
            g_SelectedLineItemDS = g_ProjectData.GetRefreshedLineData(ProjectID, LineItem)
            If g_SelectedLineItemDS IsNot Nothing AndAlso g_SelectedLineItemDS.Tables.Count > 0 Then
                g_SelectedLineItemDT = g_SelectedLineItemDS.Tables(0)
                LineItemsFound = g_SelectedLineItemDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("RS_PLIRefreshSelectedLineItemSearch", "Fail To perform search On project database With provided SQL. Detail exception " & ex.ToString)
            LineItemsFound = -1
        End Try
        g_ObjectManager.logger.DebugFormat("RS_PLIRefreshSelectedLineItemSearch - Total no. Of LineItems found from search SQL : " & LineItemsFound)
        Return LineItemsFound
    End Function
    ''' <summary>
    ''' This method is used to get updated and refreshed values from Project Views
    ''' </summary>
    ''' <param name="ProjectID">ProjectId required for performing operation</param>
    ''' <returns>Return -1 for exception</returns>
    Public Function RS_PLIRefreshSelectedProjectSearch(ByRef ProjectID As String) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRefreshSelectedProjectSearch() - Start getting refreshed data for projectID : " & ProjectID)
        Dim ProjectsFound As Integer = 0
        Try
            g_SelectedProjectDS = g_ProjectData.GetRefreshedProjectData(ProjectID)
            If g_SelectedProjectDS IsNot Nothing AndAlso g_SelectedProjectDS.Tables.Count > 0 Then
                g_SelectedProjectDT = g_SelectedProjectDS.Tables(0)
                ProjectsFound = g_SelectedProjectDT.Rows.Count
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("RS_PLIRefreshSelectedProjectSearch", "Fail To perform search On project database With provided SQL. Detail exception " & ex.ToString)
            ProjectsFound = -1
        End Try
        g_ObjectManager.logger.DebugFormat("RS_PLIRefreshSelectedProjectSearch - Total no. Of projects found from search SQL : " & ProjectsFound)
        Return ProjectsFound
    End Function

    ''' <summary>
    ''' Check selected user has provided Role
    ''' </summary>
    ''' <param name="RolesProp">Role that need to verify. The role are provides using comma separated string</param>
    ''' <returns>Return an True has input role otherwise false</returns>
    Public Function RS_PLIRoleCheck(ByVal RolesProp As String, ByVal IsAdmin As Boolean) As Boolean

        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRoleCheck() - Start Checking user with provided role property " & RolesProp)
        Dim result As Boolean = False

        Try

            If String.IsNullOrEmpty(RolesProp) Then
                result = True
            ElseIf IsAdmin Then
                result = True
            Else
                Dim Roles() As String = RolesProp.Split(",")
                Dim i As Int32 = 0
                For i = 0 To Roles.Length - 1
                    If g_rsUser.IsInRole(Roles(i).Trim) Then
                        result = True
                        Exit For
                    End If
                Next i
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIRoleCheck()", "Fail to check Roles prop : " & RolesProp & ". Detail Exception : " & ex.ToString)

            result = False
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRoleCheck() - End Checking user with provided role property " & RolesProp)

        Return result
    End Function

    ''' <summary>
    ''' Refresh the cached route for selected user
    ''' </summary>
    ''' <returns>Return a Integer, 0 for success, -1 for failure</returns>
    Public Function RS_PLIRefreshTables(ByRef UserID As String, ByRef AdminUser As Boolean) As Integer
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRefreshTables() - Start refresh tables")
        Dim result As Integer = 0
        Try
            result = RS_PLILoadAppTLPFRoute(UserID, AdminUser)
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RS_PLIRefreshTables()", "Fail to refresh Table. Detail Exception : " & ex.ToString)
            result = -1
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RS_PLIRefreshTables() - End refresh tables")
        Return result
    End Function

#End Region '"PLI"
    ''' <summary>
    ''' ' Reverts to calculated values all user-entered properties on the specified part and in the specified category name.
    ''' </summary>
    Public Sub RevertPart(ByRef Prt As RuleStream.Kernel.Part, Optional ByRef CategoryName As String = "")
        Try
            g_ObjectManager.logger.DebugFormat("Common.RevertPart() - Start revert part method")
            ' If CategoryName is blank (""), all categories will be processed.
            For Each Prop As RuleStream.Kernel.PropertySF In Prt.Properties
                If CategoryName = "" Or Prop.CategoryName = CategoryName Then
                    If Prop.ValueSource = RuleStream.Kernel.PropertySF.ValueSourceType.SOURCE_USER Then
                        Prop.RevertToCalc()
                    End If
                End If
            Next
        Catch ex As Exception
            g_ObjectManager.LogError("Common.RevertPart()", "Fail to revert part. Detail Exception : " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.RevertPart() - End revert part method")
    End Sub
    ''' <summary>
    '''  Reverts to calculated values all user-entered properties and De caches all properties on the specified part and in the specified category name.
    ''' This combines removing user inputs and decaching calculated values into a single loop for performance reasons.
    ''' The decache operation is used so that properties that have no detected dependencies will update, for example rerun formulas with inputs that are new.
    ''' </summary>
    Public Sub ResetPart(ByRef Prt As RuleStream.Kernel.Part, Optional ByRef CategoryName As String = "")
        Try
            g_ObjectManager.logger.DebugFormat("Common.ResetPart() - Start reset part method")
            ' If CategoryName is blank (""), all categories will be processed.
            For Each Prop As RuleStream.Kernel.PropertySF In Prt.Properties
                If CategoryName = "" Or Prop.CategoryName = CategoryName Then
                    If Prop.ValueSource = RuleStream.Kernel.PropertySF.ValueSourceType.SOURCE_USER Then
                        Prop.RevertToCalc()
                    End If
                    Prop.ForceDecache()
                End If
            Next
        Catch ex As Exception
            g_ObjectManager.LogError("Common.ResetPart()", "Fail to reset part. Detail Exception : " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.ResetPart() - End reset part method")
    End Sub
    ''' <summary>
    ''' This method is used for changing the waypoints (with SystemName first, if not found with SystemName then with DisplayName)
    ''' if not found the with either it will log warning/error
    ''' </summary>
    Public Sub ChangeWaypoint(ByVal Waypoint As String)
        Dim sProcessStep As ProcessStep = Nothing
        Dim colProcessSteps As New Rulestream.Kernel.rscollection
        Try
            g_ObjectManager.logger.DebugFormat("Common.ChangeWaypoint() - Start Change Waypoint")
            'First try to navigate using SystemName of waypoint
            colProcessSteps = RootPart.ProcessSteps
            'get the corresponding processStep/waypoint object for SystemName.
            sProcessStep = colProcessSteps.GetItemByKey(Waypoint)

            'If waypoint not found using System name, check if waypoint exist with DisplayName
            If sProcessStep Is Nothing Then
                For i As Integer = 1 To RootPart.ProcessSteps.Count
                    Dim oProcessStep As ProcessStep = CType(RootPart.ProcessSteps.Item(i), ProcessStep)
                    If oProcessStep.Name = Waypoint Then
                        sProcessStep = oProcessStep
                        'Log information that waypoint configured using DisplayName, is it recommended to use SystemName
                        g_ObjectManager.logger.Warn(String.Format("Common.ChangeWaypoint() - Navigation configured using DisplayName - {0}, it is recommended to use SystemName of Waypoint", Waypoint.ToString))
                        Exit For
                    End If
                Next
            End If
            'If Waypoint not found then log the error information else proceed with change Waypoint
            If Not sProcessStep Is Nothing Then
                g_ObjectManager.RSEngineer.SelectProcessStep(sProcessStep, RootPart, -1, 0)
            Else
                g_ObjectManager.LogInfo("Common.ChangeWaypoint() -", "Waypoint not found by name: " & Waypoint.ToString)
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Common.ChangeWaypoint()", "Fail to change waypoint. Detail Exception : " & ex.ToString)
        End Try
        g_ObjectManager.logger.DebugFormat("Common.ChangeWaypoint() - End Change Waypoint method")
    End Sub
End Module
