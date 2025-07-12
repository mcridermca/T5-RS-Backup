
Option Strict Off
Option Explicit On

Imports Aspose.Cells
Imports System
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Math
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Text
Imports System.Runtime.Remoting.Lifetime
Imports System.Runtime.InteropServices
Imports System.Linq
Imports System.Xml
Imports System.Xml.Linq
Imports RuleStream
Imports RuleStream.Kernel
Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Reflection
Imports Microsoft.Win32
Imports TeamcenterDriver
Imports System.Environment
Imports System.Net.Mail
Imports System.Net
'Imports RSGenericWebClient
'Imports Newtonsoft
'Imports Newtonsoft.Json.Linq
'Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions
Imports ClosedXML
Imports ClosedXML.Excel

Module Custom

#Region "Global Parameters"

    'Custom VB Module:  Global Parameters
    'Developer/Maintainer:  Shared Module
    'Purpose:
    'Client: Honeywell
    'Dependencies: (Reference items that must be in AdditonalDLL.txt)
    'Notes/Change Log:
    ' 20221002 MPC Converted This Module from Original Custom.VB

	'NOTE: g_RsEngineer is now set in Common.vb, so not required here
    'Public WithEvents g_RsEngineer As IRsEngineer
    Friend g_MSSqlServerConnection As System.Data.SqlClient.SqlConnection

    Public g_NACharToDisplay As String = String.Empty
    Public g_OutputsInvalidCharacterToDisplay As String = String.Empty

    Public Const gc_ExcludePropsFromXMLJSON As String = "JSONObjectName;JSONObjectType;JSONObjectValue;XMLObjectName;XMLObjectType;XMLObjectValue;Debug_Mode;PartNumber;"

#End Region '"Global Parameters"

    Public Function GetPFXMLRepresentation(ByRef MyProperty As PropertySF, Optional IngorePartNumber As Boolean = True) As String

        Dim MyProps As New System.Text.Stringbuilder()
        Dim MyPF As Part = MyProperty.Context
        Dim MyName As String = MyProperty.Name
        Dim Debug_Mode As Boolean = False
        Dim PropertyExcludeFilter = gc_ExcludePropsFromXMLJSON
        Dim XMLObjectName As String = ""
        Dim Result As String = ""

        If IngorePartNumber Then
            PropertyExcludeFilter = PropertyExcludeFilter & "PartNumber;"
        End If

        If MyPF.Properties.ContainsKey("Debug_Mode") Then
            Debug_Mode = (MyPF.Properties("Debug_Mode").DisplayValue = True)
        End If
        If MyPF.Properties.ContainsKey("XMLObjectName") Then
            XMLObjectName = (MyPF.Properties("XMLObjectName").DisplayValue)
            For Each p As PropertySF In MyPF.Properties
                If p.Name.ToUpper() <> MyName.ToUpper() AndAlso Not gc_ExcludePropsFromXMLJSON.ToUpper().Contains(String.Concat(p.Name, ";").ToUpper()) Then
                    MyProps.Append(String.Concat($"<{p.Name}>", p.DisplayValue, $"</{p.Name}>"))
                    If Debug_Mode Then
                        Console.WriteLine($"{p.Name} : {p.DisplayValue}")
                    End If
                End If
            Next p
            For Each s As Subpart In MyPF.SubParts
                For Each pf As Part In s.Parts()
                    If pf.Properties.ContainsKey(MyProperty.Name) Then
                        MyProps.Append(GetPFXMLRepresentation(pf.Properties(MyProperty.Name)))
                    End If
                Next pf
            Next
            Result = String.Concat($"<{XMLObjectName}>", MyProps.ToString(), $"</{XMLObjectName}>")
        End If

        Return Result

    End Function


#Region "Custom.VB Improvements"

    'Custom VB Module:  Custom.VB Improvements
    'Developer/Maintainer:  Vendor Module
    'Purpose:
    'Client: Honeywell
    'Dependencies: (Reference items that must be in AdditonalDLL.txt)
    'Notes/Change Log:
    ' 20221002 MPC Converted This Module from Original Custom.VB


    ' =====================================================================================================================
    ' =====================================================================================================================
    ' ================================== C O M M O N . V B   I M P R O V E M E N T S ======================================
    ' =====================================================================================================================
    ' =====================================================================================================================
    '

    ' =========================================================================
    ' Read file as Collection
    ' =========================================================================

    Public Function readFileAsCollection(filename As String) As Collection
        Dim lines As New Collection()
        Dim line As String = Nothing
        Try
            Dim reader = File.OpenText(filename)
            While (reader.Peek() <> -1)
                line = reader.ReadLine()
                lines.Add(line)
            End While
        Catch ex As Exception
            lines = Nothing
            Console.WriteLine("readFileAsCollection({0}) = ", filename, ex.Message)
        End Try

        Return lines
    End Function

    ' =========================================================================
    ' RsMessage
    ' =========================================================================

    Public Function RsMessage(ByRef source As String,
                          ByRef msg As String,
                          Optional ByVal severity As String = "Error",
                          Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK,
                          Optional ByVal defaultbutton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) _
                      As DialogResult

        'Arguments:
        'source: typically the part family and property from which this function is called
        'msg: the message for the log and/or dialog box
        'severity: Error, Info, Question
        'suppress: suppresses the message box if true
        'caption: the title of the dialog box
        'buttons: OK, OKCancel (default), YesNoCancel, YesNo
        'icon: None, Hand, Question, Exclamation, Asterisk, Stop, Error (default), Warning, Information
        'defaultbutton: Button1 (default), Button2, Button3

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

    Public Sub GoToStep(MyProcessStep As String)
        Dim MyStep As ProcessStep = Nothing
        Dim MyStepName As String = String.Empty
        g_ObjectManager.LogInfo("Custom.GoToStep()", String.Format($"Entry For <{MyProcessStep}>."),, True)
        Try
            For Each oProcessStep As ProcessStep In RootPart.ProcessSteps
                MyStepName = oProcessStep.Name
                g_ObjectManager.LogInfo("Custom.GoToStep()", String.Format($"Searching Process Steps, oProcessStep: <{MyStepName}>."),, True)
                If oProcessStep.Name = MyProcessStep Then
                    MyStep = oProcessStep
                    Exit For
                End If
            Next
        Catch InnerEX As Exception
            g_ObjectManager.LogError("Custom.GoToStep()", String.Format($"Error When Looping Through Process Steps: <{MyStepName}>: {InnerEX.Message}"), False, InnerEX.ToString)
        End Try
        If MyStep IsNot Nothing Then
            g_ObjectManager.LogInfo("Custom.GoToStep()", String.Format($"Calling SelectProcessStep On <{MyProcessStep}>."),, True)
            Try
                g_ObjectManager.RSEngineer.SelectProcessStep(MyStep, MyStep.Parts(1), -1, 0)
            Catch ex As Exception
                g_ObjectManager.LogError("Custom.GoToStep()", String.Format($"Error When Trying To Go To Step: <{MyProcessStep}>: {ex.Message}"), False, ex.ToString)
            End Try
        Else
            g_ObjectManager.LogInfo("Custom.GoToStep()", String.Format($"For <{MyProcessStep}>, No Step Was Found."),, True)
        End If
    End Sub


    Public Sub RecalculatePartFamily(PF As Part, Optional recursive As Boolean = False)
        PF.DemandAll(recursive)
        For Each op As Object In PF.Properties
            op.ForceDeCache()
        Next
        g_ObjectManager.RSEngineer.RefreshModelViews(-1)
    End Sub

    ''' <summary>
    ''' Filters the part family by the given property value.
    ''' </summary>
    ''' <param name="SearchParts">The search parts list/collection.</param>
    ''' <param name="PropertyName">Name of the property to search for.</param>
    ''' <param name="PropertyValue">The property value.</param>
    ''' <param name="UseNot">if set to <c>true</c> then search the PartFamilies Collection for for Parts that do NOT have the given property.</param>
    ''' <returns>Collection of Parts with (or without) the given Property.</returns>
    Public Function FilterPartFamilyByPropertyValue(ByRef SearchParts As Object, ByVal PropertyName As String, ByVal PropertyValue As Object, Optional ByVal UseNot As Boolean = False) As Collection
        Dim part As Object
        Dim Parts As Collection

        Parts = New Collection

        For Each part In SearchParts
            If UseNot Then
                If Not part.GetPropertyValue(PropertyName) = PropertyValue Then
                    Parts.Add(part)
                End If
            Else
                If part.GetPropertyValue(PropertyName) = PropertyValue Then
                    Parts.Add(part)
                End If
            End If
        Next

        FilterPartFamilyByPropertyValue = Parts
    End Function

    Private Function FormatWhereClause(ByVal whereClause As String) As String
        Dim formattedWhereClause As String = whereClause.Trim.Replace(Chr(9), " ")

        If formattedWhereClause <> String.Empty AndAlso Not formattedWhereClause.ToUpper.StartsWith("WHERE") AndAlso Not formattedWhereClause.ToUpper.StartsWith("ORDER BY") Then
            formattedWhereClause = String.Format("WHERE {0}", formattedWhereClause)
        End If

        Return formattedWhereClause
    End Function
    Public Function MakeValidValuesFromDatabase2(ByVal tableName As String, ByVal columnName As String, ByVal whereClause As String, Optional ByVal orderBy As String = "") As RuleStream.Kernel.ValidValues
        'Purpose:       Returns a Collection object containing valid values.
        'Parameters:    tableName - A table name from the components database.
        '               columnName - The column to select from the table
        '               whereClause - The SQL "where" clause to query the database
        '               orderBy - Column(s) to sort by.
        'Returns:       ValidValues object

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
                    'g_ObjectManager.LogError("Common.MakeValidValuesFromDatabase", String.Format("Duplicate values were found while creating a valid values list from the component database table ""{0}"".  The duplicates were ignored.", tableName))
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


    Public Function RemoveCommaStringDuplicates(txt As String, Optional delim As String = ",") As String
        'Purpose:		Return a string of comma values without duplicates  string = "a,a,b,b,c"
        'Parameters:	comma String optional delimitator = ","
        'Returns: 		string = "a,b,c"
        Dim x
        'Updateby20140924
        With CreateObject("Scripting.Dictionary")
            .CompareMode = vbTextCompare
            For Each x In Split(txt, delim)
                If Trim(x) <> "" And Not .exists(Trim(x)) Then .Add(Trim(x), Nothing)
            Next
            If .Count > 0 Then RemoveCommaStringDuplicates = Join(.keys, delim)
        End With
    End Function

    Public Function MakeUniqueValidValuesFromDatabase(ByVal TableName As String, ByVal ColumnName As String, ByVal WhereClause As String, Optional ByVal OrderBy As String = "") As RuleStream.Kernel.ValidValues 'Hashtable
        'Purpose:       Returns a Collection object containing valid values.
        'Parameters:    TableName - A table name from the components database.
        '               ColumnName - The column to select from the table
        '               WhereClause - The SQL "where" clause to query the database
        '               OrderBy - Column(s) to sort by.
        'Returns:       Collection object

        Dim objCollection As RuleStream.Kernel.ValidValues 'Hashtable
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strColumnValue As String
        Dim strSort As String = String.Empty
        Dim blnDuplicates As Boolean

        objCollection = New RuleStream.Kernel.ValidValues 'Hashtable

        'Check the TableName parameter
        TableName = Replace(Trim(TableName), Chr(9), " ", , , CompareMethod.Text)
        If Left(TableName, 1) <> "[" Then TableName = "[" & TableName
        If Right(TableName, 1) <> "]" Then TableName = TableName & "]"

        'Check the ColumnName parameter
        ColumnName = Replace(Trim(ColumnName), Chr(9), " ", , , CompareMethod.Text)
        If Left(ColumnName, 1) <> "[" Then ColumnName = "[" & ColumnName
        If Right(ColumnName, 1) <> "]" Then ColumnName = ColumnName & "]"

        'Check the WhereClause parameter
        WhereClause = Replace(Trim(WhereClause), Chr(9), " ", , , CompareMethod.Text)
        If WhereClause <> "" And UCase(Left(WhereClause, 5)) <> "WHERE" And UCase(Left(WhereClause, 9)) <> "ORDER BY " Then
            WhereClause = "where " & WhereClause
        End If

        'Check the OrderBy parameter
        OrderBy = Replace(Trim(OrderBy), Chr(9), " ", , , CompareMethod.Text)
        OrderBy = Trim(Replace(OrderBy, "order by", "", , , CompareMethod.Text))

        If OrderBy <> "" Then
            If LCase(Right(OrderBy, 3)) = "asc" Then
                OrderBy = Trim(Left(OrderBy, Len(OrderBy) - 3))
            ElseIf LCase(Right(OrderBy, 9)) = "ascending" Then
                OrderBy = Trim(Left(OrderBy, Len(OrderBy) - 9))
            ElseIf LCase(Right(OrderBy, 4)) = "desc" Then
                OrderBy = Trim(Left(OrderBy, Len(OrderBy) - 4))
                strSort = "desc"
            ElseIf LCase(Right(OrderBy, 10)) = "descending" Then
                OrderBy = Trim(Left(OrderBy, Len(OrderBy) - 10))
                strSort = "desc"
            End If

            'ORDER BY items must appear in the select list if SELECT DISTINCT is specified
            If InStr(1, ColumnName, OrderBy, CompareMethod.Text) = 0 Then
                ColumnName = ColumnName & ", " & OrderBy
            End If
            OrderBy = "order by " & OrderBy & " " & strSort
        End If

        'Execute the query
        ds = g_ComponentData.MakeValidValuesFromDatabase(ColumnName, TableName, WhereClause, OrderBy)

        'Loop through the recordset and create items in the Collection
        Try
            If Not IsNothing(ds) Then
                If Not IsNothing(ds.Tables(0)) Then
                    For Each dr In ds.Tables(0).Rows
                        If IsDBNull(dr.Item(0)) Then
                            strColumnValue = ""
                        Else
                            strColumnValue = dr.Item(0).ToString.Trim
                        End If
                        If Not objCollection.Contains(strColumnValue) Then
                            objCollection.Add(strColumnValue, strColumnValue)
                        Else
                            blnDuplicates = True
                        End If
                    Next

                    '           If blnDuplicates Then
                    '                        g_ObjectManager.LogError("Valid Values", String.Format("Duplicate values were found while creating a valid values list from the component database table ""{0}"".  The duplicates were ignored.", TableName))
                    '                End If

                    Return objCollection
                Else
                    Throw New Exception("Unable to create valid values - no data found.")
                End If
            Else
                Throw New Exception("Unable to create valid values.")
            End If
        Catch ex As Exception
            g_ObjectManager.LogError("Valid Values", ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function MakeValidValueKeyFromDatabase2(ByVal tableName As String, ByVal keyColumnName As String, ByVal displayColumnName As String, ByVal whereClause As String) As RuleStream.Kernel.ValidValues
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
        Dim hasDuplicates As Boolean

        validValuesCollection = New RuleStream.Kernel.ValidValues 'Hashtable

        'Check the TableName parameter
        tableName = DelimitTableName(tableName)

        'Check the KeyColumnName parameter
        keyColumnName = DelimitColumnName(keyColumnName)

        'Check the DisplayColumnName parameter
        displayColumnName = DelimitColumnName(displayColumnName)

        'Check the WhereClause parameter
        whereClause = FormatWhereClause(whereClause)

        'Check for an Order By
        intOrderBy = InStr(1, whereClause, "order by", CompareMethod.Text)
        If intOrderBy > 0 Then
            'strOrderCols = ", " & Mid(whereClause, intOrderBy + 9) & " "
            strOrderCols = Mid(whereClause, intOrderBy + 9).Trim()


            ' Strip out the sort order keyword
            If strOrderCols.ToLower.EndsWith(" desc ") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 5)
            End If

            If strOrderCols.ToLower.EndsWith(" descending ") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 11)
            End If

            If strOrderCols.ToLower.EndsWith(" asc ") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 4)
            End If

            If strOrderCols.ToLower.EndsWith(" ascending ") Then
                strOrderCols = strOrderCols.Substring(0, strOrderCols.Length - 10)
            End If

        End If

        'Execute the query
        ds = g_ComponentData.MakeValidValueKeyFromDatabase(keyColumnName, displayColumnName, strOrderCols, tableName, whereClause)

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
                    'g_ObjectManager.LogError("Common.MakeValidValueKeyFromDatabase", String.Format("Duplicate values were found while creating a valid values list from the component database table ""{0}"".  The duplicates were ignored.", tableName))
                End If

            Else
                Throw New Exception("[Common.MakeValidValueKeyFromDatabase] Unable to create valid values; no data was returned.")
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Common.MakeValidValueKeyFromDatabase", ex.ToString)
        End Try

        Return validValuesCollection

    End Function


    Public Function MakeValidValueIntersectFromSQL(ByVal SelectStatementTwoFields As String, ByVal whereField As String, ByVal WhereValuesCommaDelimited As String, Optional ByVal AdditionalWhereANDClause As String = "", Optional ByVal OrderBy As String = "") As ValidValues
        'Create a  series of select statements based on comma delimited where clauses
        Dim WhereClauseItems() As String = WhereValuesCommaDelimited.Split(",")
        Dim SQLToExecute As String = ""
        Dim LastRecord As Integer = WhereClauseItems.Length - 1

        For x As Integer = 0 To LastRecord
            Dim WhereValue As String = WhereClauseItems(x).Trim
            SQLToExecute = SQLToExecute & SelectStatementTwoFields & " Where [" & whereField & "] = " & WhereValue
            If AdditionalWhereANDClause.Trim.Length > 0 Then
                SQLToExecute = SQLToExecute & " AND " & AdditionalWhereANDClause.Trim
            End If
            If Not (x = LastRecord) Then
                SQLToExecute = SQLToExecute & " Intersect "
            End If
        Next x

        If OrderBy.Trim.Length > 0 Then
            SQLToExecute = SQLToExecute & " Order By " & OrderBy.Trim
        End If

        Dim ds As DataSet = g_ComponentData.ExecuteSQL(SQLToExecute)
        Dim keyValue, displayValue As String
        Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
        Dim hasDuplicates As Boolean = False

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
                    'g_ObjectManager.LogError("Custom.MakeValidValueIntersectFromSQL", "Duplicate values were found while creating a valid values list from the component database table.  The duplicates were ignored.")
                End If

            Else
                Throw New Exception("[Custom.MakeValidValueIntersectFromSQL] Unable to create valid values; no data was returned.")
            End If

        Catch ex As Exception
            g_ObjectManager.LogError("Custom.MakeValidValueIntersectFromSQL", ex.ToString)
        End Try

        Return validValuesCollection

    End Function

    Public Function UnixToDateTime(ByVal strUnixTime As String) As DateTime

        Dim nTimestamp As Double = strUnixTime
        Dim nDateTime As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)
        nDateTime = nDateTime.AddSeconds(nTimestamp)

        Return nDateTime

    End Function

    Public Function DbNullOrStringNullToLong(ByVal Data As Object) As Long
        If (IsDBNull(Data) OrElse (Data = "null")) Then
            Return 0
        Else
            Return CType(Data, Long)
        End If
    End Function


    ''' <summary>
    ''' Sets the Project UDF for the given UDFName string to the given UDFValue.
    ''' </summary>
    ''' <param name="UDFName">Name of the UDF.</param>
    ''' <param name="UDFValue">The UDF value.</param>
    Public Sub setProjectUDF(UDFName As String, UDFValue As String)
        Dim UDFID As Integer = getProjectUDF_ID(UDFName)
        If UDFID <= 0 Then
            Return
        End If
        Dim m_rsEngineer As RuleStream.IRsEngineer = g_ObjectManager.RSEngineer
        Dim sqlStr As String = "update " + DelimitTableName("ProjectUDF") + " set " + DelimitTableName("Value") + "='" + UDFValue + "'"
        sqlStr = sqlStr + " where " + DelimitColumnName("Project_ID") + " = '" + m_rsEngineer.CurrentModel.ProjectID.ToString() + "'"
        sqlStr = sqlStr + " and " + DelimitColumnName("UDF_ID") + " = " + UDFID.ToString()
        Try
            g_MSSqlServerConnection = New SqlClient.SqlConnection(g_ProjectData.ConnectionString)
            g_MSSqlServerConnection.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = New SqlClient.SqlCommand()
            cmd.Connection = g_MSSqlServerConnection
            cmd.CommandText = sqlStr
            g_ObjectManager.LogInfo("Custom.setProjectUDF", "1) Executing SQL = <" & sqlStr & "> for PropertyName = <" & UDFName & ">", , True)

            If cmd.ExecuteNonQuery() = 0 And UDFValue <> "" Then
                sqlStr = "insert into " + DelimitTableName("ProjectUDF") + " ([Project_ID], [UDF_ID], [Value]) VALUES('"
                sqlStr = sqlStr + m_rsEngineer.CurrentModel.ProjectID.ToString() + "', " + UDFID.ToString() + ", '" + UDFValue + "')"
                g_ObjectManager.LogInfo("Custom.setProjectUDF", "2) Executing SQL = <" & sqlStr & "> for PropertyName = <" & UDFName & ">", , True)

                cmd.CommandText = sqlStr
                cmd.ExecuteNonQuery()
            End If

            g_MSSqlServerConnection.Close()
        Catch ex As Exception
            Dim errString As String = String.Format($"Error trying to set UDFName: <{UDFName}> to Value: <{UDFValue}>.")
            g_ObjectManager.LogError("Custom.setProjectUDF", errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        Finally
            g_MSSqlServerConnection.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Gets the Project UDF identifier for the given UDFName String.
    ''' </summary>
    ''' <param name="UDFName">Name of the UDF.</param>
    ''' <returns>System.Int32.</returns>
    Public Function getProjectUDF_ID(UDFName As String) As Integer
        Dim m_rsEngineer As RuleStream.IRsEngineer = g_ObjectManager.RSEngineer
        Dim sqlStr As String = "select * from " + DelimitTableName("UserDefinedFields") + " where " + DelimitColumnName("PropertyName") + " = '" + UDFName + "'"
        sqlStr = sqlStr + " and " + DelimitColumnName("Type") + " = 'PROJECT'"
        Try
            g_ObjectManager.LogInfo("Custom.getProjectUDF_ID", "Looking for UDF_ID for PropertyName = <" & UDFName & ">", , True)

            Dim ds As DataSet = g_ProjectData.ExecuteSQL(sqlStr)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    g_ObjectManager.LogInfo("Custom.getProjectUDF_ID", "Found UDF_ID = <" & dr.Item("UDF_ID") & "> for PropertyName = <" & UDFName & ">", , True)

                    Return dr.Item("UDF_ID").ToString()
                Next
            End If
        Catch ex As Exception
            Dim errString As String = String.Format($"Error trying to get Project UDF_ID for UDFName: <{UDFName}>.")
            g_ObjectManager.LogError("Custom.getProjectUDF_ID", errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        End Try

        Return -1

    End Function

    ''' <summary>
    ''' Gets the Project UDF value for the given Project_ID and UDF_ID.
    ''' </summary>
    ''' <param name="Project_ID">The project identifier.</param>
    ''' <param name="UDF_ID">The UDF identifier.</param>
    ''' <returns>String - The UDF Value</returns>
    Public Function getProjectUDF_Value(Project_ID As String, UDF_ID As Integer) As String
        Dim m_rsEngineer As RuleStream.IRsEngineer = g_ObjectManager.RSEngineer
        Dim _Module As String = "Custom.getProjectUDF_Value"
        Dim retValue As String = String.Empty

        Dim sqlStr As String = String.Format($"SELECT * FROM {DelimitTableName("ProjectUDF")} WHERE {DelimitColumnName("Project_ID")} = '{Project_ID}' AND {DelimitColumnName("UDF_ID")} = {UDF_ID.ToString}")
        Try
            g_ObjectManager.LogInfo(_Module, String.Format($"Calling ExecuteSQL for sqlStr: <{sqlStr}>."), , True)

            Dim ds As DataSet = g_ProjectData.ExecuteSQL(sqlStr)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    retValue = dr.Item("Value")
                    g_ObjectManager.LogInfo(_Module, String.Format($"Found Value = <{retValue}>"), , True)

                    Return retValue
                Next
            End If
        Catch ex As Exception
            Dim errString As String = String.Format($"Error trying to get Value for Project_ID: <{Project_ID}> and UDF_ID: <{UDF_ID}>.")
            g_ObjectManager.LogError(_Module, errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        End Try

        Return retValue

    End Function

    ''' <summary>
    ''' Gets the LineItem UDF identifier for the given UDFName String.
    ''' </summary>
    ''' <param name="UDFName">Name of the UDF.</param>
    ''' <returns>System.Int32.</returns>
    Public Function getLineItemUDF_ID(UDFName As String) As Integer
        Dim sqlStr As String = "select * from " + DelimitTableName("[UserDefinedFields]") + " where " + DelimitColumnName("PropertyName") + " = '" + UDFName + "'"
        sqlStr = sqlStr + " and " + DelimitColumnName("Type") + " = 'LINEITEM'"
        Try
            Dim ds As DataSet = g_ProjectData.ExecuteSQL(sqlStr)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    Return dr.Item("UDF_ID")
                Next
            End If
        Catch ex As Exception
            Dim errString As String = String.Format($"Error trying to get LineItem UDF_ID for UDFName: <{UDFName}>.")
            g_ObjectManager.LogError("Custom.getLineItemUDF_ID", errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        End Try

        Return -1

    End Function


    ''' <summary>
    ''' Sets the values for the RSXLI_Project_Status Table for the given Project_ID and LineItem_ID.
    ''' </summary>
    ''' <param name="Project_ID">String - Project_ID to modify.</param>
    ''' <param name="LineItem_ID">Integer - LineItem_ID to modify.</param>
    ''' <param name="C4C_LineItem_Number">Integer - C4C_Line_Item_Number.</param>
    ''' <param name="Status_LineItem">String - Status for this LineItem_ID.</param>
    ''' <param name="TypeOfLineItem">Integer - Type of this LineItem_ID.</param>
    ''' <returns>Boolean - Status. True = Success, False = Failure.</returns>
    Public Function set_RSXLI_Project_Status(Project_ID As String, LineItem_ID As Integer, C4C_LineItem_Number As Integer, Status_LineItem As String, TypeOfLineItem As Integer) As Boolean

        Dim _returnStatus As Boolean = False
        Dim _module As String = "Custom.set_RSXLI_Project_Status()"
        Dim _logstr As String = String.Empty
        Dim _count As Integer = -1
        Dim constring As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
        Dim countStr As String = String.Format($"SELECT COUNT(LineItem_ID) FROM [dbo].[RSXLI_Project_Status] WHERE [Project_ID] = '{Project_ID}' AND [LineItem_ID] = {LineItem_ID}")
        Dim updateStr As String = String.Format($"UPDATE [dbo].[RSXLI_Project_Status] SET [Status_LineItem] = '{Status_LineItem}', [TypeOfLineItem] = {TypeOfLineItem} WHERE [Project_ID] = '{Project_ID}' AND [LineItem_ID] = {LineItem_ID}")
        Dim insertStr As String = String.Format($"INSERT INTO [dbo].[RSXLI_Project_Status] ([Project_ID], [LineItem_ID], [C4C_Line_Item_Number], [Status_LineItem], [TypeOfLineItem]) VALUES('{Project_ID}', {LineItem_ID}, '{C4C_LineItem_Number}', '{Status_LineItem}', {TypeOfLineItem})")

        Dim conn As SqlClient.SqlConnection = Nothing
        Dim trans As SqlClient.SqlTransaction = Nothing
        Try
            _logstr = String.Format($"Entry - For Project_ID: <{Project_ID}> AND LineItem_ID: <{LineItem_ID}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            conn = New SqlClient.SqlConnection(constring)
            conn.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = New SqlClient.SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = countStr

            _logstr = String.Format($"1) Get Count: Executing SQL = <{countStr}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            _count = cmd.ExecuteNonQuery()

            If _count = 1 Then
                _logstr = String.Format($"2) UPDATE: Executing SQL = <{updateStr}>")
                g_ObjectManager.LogInfo(_module, _logstr, , True)

                cmd.CommandText = updateStr
                cmd.ExecuteNonQuery()
                _returnStatus = True

            ElseIf _count = 0 Then
                _logstr = String.Format($"2) INSERT: Executing SQL = <{insertStr}>")
                g_ObjectManager.LogInfo(_module, _logstr, , True)

                cmd.CommandText = updateStr
                cmd.ExecuteNonQuery()
                _returnStatus = True

            Else
                _logstr = String.Format($"2) WARN: Count returned <{_count}> when executing SQL = <{countStr}>. Check for duplicate entries for this Project_ID, LineItem_ID.")
                g_ObjectManager.LogInfo(_module, _logstr, , True)
            End If

        Catch ex As Exception
            Dim errString As String = String.Format($"Error trying to Execute: {_logstr}.")
            g_ObjectManager.LogError(_module, errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        Finally
            conn.Close()
        End Try

        'Catch ex As Exception

        '    g_ObjectManager.LogError(_module, String.Format($"Exception caught: {ex.Message}, check Rulestream.log for details."), False, String.Format($"Exception caught: {ex.ToString}"))

        'Finally
        '    trans.Dispose()
        '    conn.Close()
        '    conn.Dispose()

        'End Try

        Return _returnStatus
    End Function

    ''' <summary>
    ''' Gets a value for a given RSXLI_* Table for the given Project_ID and LineItem_ID.
    ''' </summary>
    ''' <param name="RSXLI_Table_Name">Table Name to read from.</param>
    ''' <param name="Project_ID">String - Project_ID to read.</param>
    ''' <param name="LineItem_ID">Integer - LineItem_ID to modify.</param>
    ''' <returns>Dictionary of Key/Value pairs (ColumnName, Value).</returns>
    Public Function get_RSXLI_Table_Values(RSXLI_Table_Name As String, Project_ID As String, LineItem_ID As Integer) As Dictionary(Of String, String)
        Dim m_rsEngineer As RuleStream.IRsEngineer = g_ObjectManager.RSEngineer
        Dim _module As String = "Custom.get_RSXLI_Table_Values()"
        Dim _logstr As String = String.Empty
        Dim dict As New Dictionary(Of String, String)

        Dim sqlStr As String = "select * from " + DelimitTableName(RSXLI_Table_Name) + " where " + DelimitColumnName("PropertyName") + " = '" + "42" + "'"
        sqlStr = sqlStr + " and " + DelimitColumnName("Type") + " = 'PROJECT'"
        Try
            _logstr = String.Format($"Entry - For Project_ID: <{Project_ID}> AND LineItem_ID: <{LineItem_ID}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            Dim ds As DataSet = g_ProjectData.ExecuteSQL(sqlStr)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    _logstr = String.Format($"Entry - For Project_ID: <{Project_ID}> AND LineItem_ID: <{LineItem_ID}>")
                    g_ObjectManager.LogInfo(_module, _logstr, , True)


                Next
            End If
        Catch ex As Exception
            'Dim errString As String = String.Format($"Error trying to get Project UDF_ID for UDFName: <{UDFName}>.")
            'g_ObjectManager.LogError("Custom.getProjectUDF_ID", errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        End Try

        Return dict

    End Function

    ''' <summary>
    ''' Sets the Description for the given Project_ID and LineItem_ID.
    ''' </summary>
    ''' <param name="Project_ID">String - Project_ID to modify.</param>
    ''' <param name="LineItem_ID">Integer - LineItem_ID to modify.</param>
    ''' <param name="Description">String - Project_ID to modify.</param>
    ''' <returns>Integer - Status, 0 = Success, -1 = Error</returns>
    Public Function setLineItemDescription(Project_ID As String, LineItem_ID As Integer, Description As String) As Integer
        Dim returnStatus As Integer = 0
        Dim _module As String = "Custom.setLineItemDescription()"
        Dim _logstr As String = String.Empty
        Dim sqlStr As String = String.Format($"UPDATE {DelimitTableName("LineItem")} SET {DelimitColumnName("Description")} = '{Description}' WHERE {DelimitColumnName("Project_ID")} = '{Project_ID}' AND {DelimitColumnName("LineItem_ID")} = {LineItem_ID.ToString}")

        Try
            _logstr = String.Format($"Entry - For Project_ID: <{Project_ID}> AND LineItem_ID: <{LineItem_ID}>, Description: <{Description}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            g_MSSqlServerConnection = New SqlClient.SqlConnection(g_ProjectData.ConnectionString)
            g_MSSqlServerConnection.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = New SqlClient.SqlCommand()
            cmd.Connection = g_MSSqlServerConnection
            cmd.CommandText = sqlStr
            _logstr = String.Format($"Executing SQL = <{sqlStr}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            If cmd.ExecuteNonQuery() = 0 Then
                returnStatus = -1
                _logstr = String.Format($"Error returned when Executing SQL = <{sqlStr}>")
                g_ObjectManager.LogError(_module, _logstr, True)
            End If

            ''If we didn't find an entry
            'If cmd.ExecuteNonQuery() = 0 Then
            '    sqlStr = String.Format($"INSERT INTO {DelimitTableName("LineItem")} ({DelimitColumnName("Project_ID")}, {DelimitColumnName("LineItem_ID")}, {DelimitTableName("Description")}) VALUES ('{Project_ID}', {LineItem_ID.ToString}, '{Description}')")
            '    cmd.CommandText = sqlStr
            '    cmd.ExecuteNonQuery()

        Catch ex As Exception
            returnStatus = -1
            Dim errString As String = String.Format($"Exception caught at stage: {_logstr}.")
            g_ObjectManager.LogError(_module, errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        Finally
            g_MSSqlServerConnection.Close()
        End Try
        Return returnStatus
    End Function

    ''' <summary>
    ''' Gets the Description for the given Project_ID and LineItem_ID.
    ''' </summary>
    ''' <param name="Project_ID">String - Project_ID to modify.</param>
    ''' <param name="LineItem_ID">Integer - LineItem_ID to modify.</param>
    ''' <param name="Description">String - Project_ID to modify.</param>
    ''' <returns>Integer - Status, 0 = Success, -1 = Error</returns>
    Public Function getLineItemDescription(Project_ID As String, LineItem_ID As Integer, ByRef Description As String) As Integer
        Dim returnStatus As Integer = 0
        Dim _module As String = "Custom.getLineItemDescription()"
        Dim _logstr As String = String.Empty
        Dim sqlStr As String = String.Format($"SELECT {DelimitColumnName("Description")} FROM {DelimitTableName("LineItem")} WHERE {DelimitColumnName("Project_ID")} = '{Project_ID}' AND {DelimitColumnName("LineItem_ID")} = {LineItem_ID.ToString}")

        Try
            _logstr = String.Format($"Entry - For Project_ID: <{Project_ID}> AND LineItem_ID: <{LineItem_ID}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            _logstr = String.Format($"Executing SQL = <{sqlStr}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            Dim ds As DataSet = g_ProjectData.ExecuteSQL(sqlStr)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    Description = dr.Item("Description")
                    returnStatus = 0
                    Exit For
                Next
            End If

            _logstr = String.Format($"Description Returned = <{Description}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

        Catch ex As Exception
            returnStatus = -1
            Dim errString As String = String.Format($"Error trying to get Description For Project_ID <{Project_ID}>, LineItem_ID: <{LineItem_ID}>.")
            g_ObjectManager.LogError(_module, errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        Finally

        End Try
        Return returnStatus

    End Function
#End Region '"Custom.VB Improvements"


    Public Sub g_rsEngineer_RsActionButtonClick(ByVal sender As Object, ByVal e As RuleStream.RsActionButtonClickEventArgs)
       Dim _module As String = "Custom.g_rsEngineer_RsActionButtonClick"
       Select Case e.FunctionName

            'ITO Events
            Case "FRT_Import_Items" 

                Dim Target_Product_Part_Name as string = "Freight_Estimate_Item"
                'Todo: This will change depending on application this is called from. 
                '       Make it Dynamic,by reasarching top_part name or application name

                'Dim StartPart As RuleStream.Kernel.Part = RootPart.PRD_Document(1) ' Old Freight Calc Specific Version
                'Stop
                
                Dim StartPart As RuleStream.Kernel.Part = RootPart.GEN_Connection_Paths(1).Salesforce_PRD(1).PRD_Document(1)

                g_ObjectManager.LogInfo(_module, "Calling: FRT_Import_Itemstput", , True)
               ' StartPart.Properties("Debug_1").InputValue = e.FunctionName
                dim x as integer = 0
                for each sb as Part in StartPart.Subparts("PRD_Product_Lines")
                    x = x + 1
                    dim prd_class as string = sb.Properties("Product_Class").Value
                    Dim Target_SubPart_Collection_Name = ""
                    select Case prd_class
                        Case = "HCAD"
                            Target_SubPart_Collection_Name = "Product_Details_HCAD"
                        Case = "AS/RS"
                            Target_SubPart_Collection_Name = "Product_Details_ASRS"
                            
                        case = "Electrical"
                            Target_SubPart_Collection_Name = "Product_Details_Electrical"
                        Case = "Non-Standard"
                            Target_SubPart_Collection_Name = "Product_Details_NonStd"
                    End select
                    'RootPart.GEN_Connection_Paths(1).Freight_Estimate_Head(1)
                    ' Dim Freight_Product As Part = RootPart.Freight_Calculator(1).Subparts(Target_SubPart_Collection_Name).AddPart("Freight_Estimate_Item") ' Old FreightCalc Version
                    Dim Freight_Product As Part = RootPart.GEN_Connection_Paths(1).Freight_Estimate_Head(1).Subparts(Target_SubPart_Collection_Name).AddPart("Freight_Estimate_Item")
                    'stop
                    Dim ProdID As String = "MyTempProduct"
                    
                    if sb.Properties.ContainsKey("Product_Indentifier") then
                        ProdID =   sb.Properties("Product_Indentifier").Value
                    end if
                    Freight_Product.Properties("Product_Name").InputValue = ProdID.Trim() 'sb.Properties("Product_Identifier").CalculatedValue
                    Freight_Product.Properties("Cost_Standard").InputValue = sb.Properties("Cost_Standard").Value
                    Freight_Product.Properties("Cost_Escalated").InputValue = sb.Properties("Cost_Escalated").Value
                    Freight_Product.Properties("Cost_Standard").InputValue = sb.Properties("Cost_Standard").Value
                    Freight_Product.Properties("Ft_Per_Qty").InputValue = sb.Properties("Product_FT").Value 
                    Freight_Product.Properties("Cost_Per_UOM").InputValue = sb.Properties("USD_Per_OUM").Value 

                next sb
                
                Messagebox.Show($"Import Complete : {x} Item(s) Imported")

            Case "ITO_DoTGSSelect"
                Dim StartPart As RuleStream.Kernel.Part = RootPart.OrderItems(1)

            Case "ImportEQSData"
                Dim propFileName As PropertySF = RootPart().Properties("EQS_FileNameAndPath")
                Dim propEQS_Raw_Data As PropertySF = RootPart().Properties("EQS_RawData")
                Dim strFileNameAndPath As String = path.Combine(g_DocAccess.WorkingFolder, propFileName.Value)

                Dim strEQS As String = ElecInstall_GetEQSValues(strFileNameAndPath)
                propEQS_Raw_Data.InputValue = strEQS

                Dim _PF As Rulestream.Kernel.Part = RootPart()

                rebuildElecInstallApp(_PF)

                populateEQSProps(_PF)

                g_ObjectManager.RSEngineer.RefreshModelViews(-1)
            Case Else

        End select

    End Sub
    'Do not Change or Delete The Line Below (End Module) --- [DELETEONCOMPILE]

#Region "Utilities"

    Public Function ElecInstall_GetEQSValues(excelFileNameAndPath As String) As String

        Dim result As String
        Dim wbXL As XLWorkbook = New XLWorkbook(excelFileNameAndPath)

        For Each wsXL As IXLWorksheet In wbXL.Worksheets

            If (wsXL.Name Like "CP*" OrElse wsXL.Name Like "Power Panel & MCBL") AndAlso wsXL.Name <> "CP Totals" AndAlso wsXL.Cell(4, 4).CachedValue.ToString().ToUpper() = "TRUE" Then

                result &= wsXL.Name & ":"

                Dim rCnt As Integer = 17

                While rCnt <= 222
                    result &= rCnt.ToString() & "^" & wsXL.Cell(rCnt, 2).CachedValue.ToString() & "^" & wsXL.Cell(rCnt, 1).CachedValue.ToString() & ","
                    rCnt += 1
                End While

                rCnt = 246

                While rCnt < 260
                    result &= rCnt.ToString() & "^" & wsXL.Cell(rCnt, 2).CachedValue.ToString() & "^" & wsXL.Cell(rCnt, 3).CachedValue.ToString() & ","
                    rCnt += 1
                End While

                result &= rCnt.ToString() & "^" & wsXL.Cell(rCnt, 2).CachedValue.ToString() & "^" & wsXL.Cell(rCnt, 3).CachedValue.ToString()

                result &= "~"

            End If

        Next

        Return result

    End Function

    Public Sub rebuildElecInstallApp(PF As Rulestream.Kernel.Part)
        Dim propQTYCP As PropertySF = PF.Properties("EQS_QuantityOfCPs")
        propQTYCP.RevertToCalc()
        For Each _Sub As Rulestream.Kernel.Subpart In PF.Subparts
            If _Sub.Name.ToUpper() = "CONTROL_PANELS" Then
                _Sub.RemoveAll()
                Dim i As Integer = 1
                While i <= propQTYCP.Value
                    _Sub.AddPart("CAE_Elec_Install_CP_Comps")
                    i += 1
                End While
            End If
        Next
    End Sub

    Public Sub populateEQSProps(PF As Rulestream.Kernel.Part)
        For Each _sub As Rulestream.Kernel.SubPart In PF.SubParts
            If _sub.Name.ToUpper() = "CONTROL_PANELS" Then
                For Each _part As Rulestream.Kernel.Part In _sub.Parts
                    Dim propEQSRawData As PropertySF = _part.Properties("DATA_EQS_PropertyValues")
                    For Each vals As String In propEQSRawData.Value.Split(",")
                        For Each _prop As PropertySF In _part.Properties
                            If _prop.Name Like "EQS_*" AndAlso _prop.CategoryName = "EQS Import" Then
                                Dim propDescr As String() = _prop.Description.Split("B")
                                Dim val As String() = vals.Split("^")
                                If val(0).ToString() = propDescr(1) Then
                                    If val.Length < 3 Then
                                        _prop.InputValue = "0"
                                    ElseIf val(2) <> "" Then
                                        _prop.InputValue = val(2)
                                    Else
                                        _prop.InputValue = "0"
                                    End If
                                    Exit For
                                End If
                            End If
                        Next
                    Next
                Next
            End If
        Next
    End Sub

#End Region

End Module