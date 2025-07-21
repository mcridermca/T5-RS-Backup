
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
Imports Excel = Microsoft.Office.Interop.Excel
Imports Svg
Imports System.Drawing.Imaging
Imports ClosedXML
Imports ClosedXML.Excel
Imports ClosedXML.Report
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
	
#End Region '"Global Parameters"

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

	Public Function IsInputNumeric(input As String) As Boolean
		If String.IsNullOrWhiteSpace(input) Then Return False
		If IsNumeric(input) Then Return True
		Dim parts() As String = input.Split("/"c)
		If parts.Length <> 2 Then Return False
		Return IsNumeric(parts(0)) AndAlso IsNumeric(parts(1))
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

    Public Sub SendEmail(address, subject, body)
        Process.Start("mailto:" & address & "?subject=" & subject & "&body=" & body)
    End Sub


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


    ''' <summary>
    ''' Gets a Comma-delimited list of Component Part_Numbers for a given Model_Tag.
    ''' </summary>
    ''' <param name="Model_Tag">Plant Library Model_Tag to .</param>
    ''' <returns>Dictionary containing a list of Part_Number and Part_Qty for this Model_Tag.</returns>
    Public Function get_ComponentPartsList(Model_Tag As String) As Dictionary(Of String, String)
        Dim m_rsEngineer As RuleStream.IRsEngineer = g_ObjectManager.RSEngineer
        Dim _module As String = "Custom.get_ComponentPartsList()"
        Dim _logstr As String = String.Empty
        Dim _componentPartsList As String = String.Empty
        Dim dict As New Dictionary(Of String, String)
        Dim _partNumber As String = String.Empty
        Dim _partQty As String = String.Empty

        Dim sqlStr As String = String.Format($"SELECT Part_Number, Part_Qty From [Plant_Library_Vest_ModelTakeOffs] WHERE Model_Tag = N'{Model_Tag}' AND Part_Number <> 'BY OTHERS' AND Part_Number <> 'INTERNAL' ")

        Try
            _logstr = String.Format($"Entry - For Model_Tag: <{Model_Tag}>")
            g_ObjectManager.LogInfo(_module, _logstr, , True)

            Dim ds As DataSet = g_ComponentData.ExecuteSQL(sqlStr)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows

                    _partNumber = dr.Item("Part_Number")
                    _partQty = dr.Item("Part_Qty")

                    _logstr = String.Format($"Returned PartNumber List: <{_partNumber}, {_partQty}>")
                    g_ObjectManager.LogInfo(_module, _logstr, , True)

                    dict.add(_partNumber, _partQty)

                    _logstr = String.Format($"Successfully Added: <{_partNumber}, {_partQty}>")
                    g_ObjectManager.LogInfo(_module, _logstr, , True)


                Next
            End If
        Catch ex As Exception
            Dim errString As String = String.Format($"Error trying to get _partNumber: <{_partNumber}>, _partQty: <{_partQty}> for Model_Tag: <{Model_Tag}>.")
            g_ObjectManager.LogError(_module, errString & "   Exception: " & ex.Message, True, errString & "   Exception: " & ex.ToString)

        End Try

        Return dict

    End Function



#End Region '"Custom.VB Improvements"

#Region "Event Handlers"

    'Custom VB Module:  Event Handlers
    'Developer/Maintainer:  Shared Module
    'Purpose:
    'Client: Honeywell
    'Dependencies: (Reference items that must be in AdditonalDLL.txt)
    'Notes/Change Log:
    ' 20221002 MPC Converted This Module from Original Custom.VB

    ' =====================================================================================================================
    ' ================================================= T O P   L E V E L =================================================
    ' ============================================ E V E N T   H A N D L E R S ============================================
    ' =====================================================================================================================

    ' =========================================================================
    ' MODEL LOAD
    ' =========================================================================
    'Dim _GlobalStopWatch As New Stopwatch()

    Public Sub g_RsEngineer_RsAfterLoad(ByVal sender As Object, ByVal e As EventArgs)
        Dim _sealItem As New Object
        Dim _module As String = "Custom.g_RsEngineer_RsAfterLoad"
        Dim _logstr As String = String.Format($"Entry from <{RootPart.Name}>.")
        Dim _DatapointSubpart As Integer = 0
        Dim _DataPoint As New Object
        Dim CurrentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim _DataReturnedDate As String = "2009/12/01 00:00:00"
        g_ObjectManager.LogInfo(_module, _logstr, , True)

        Try
            If RootPart.PartFamily = "_RS_PLIB_Top" Then

                RS_PLIInitialize(RootPart.UserInfo(1).TheUserID, RootPart.UserInfo(1).IsAdminUser)

            End If
            '_GlobalStopWatch.Start()
            If (RootPart.Name = "JCComApp") Then
                g_NACharToDisplay = RootPart.ComGUI(1).NACharToDisplay

            ElseIf (RootPart.Name = "JCApp_ITO") Then

                _sealItem = RootPart.OrderItems(1)
                _DatapointSubpart = (RootPart.ReleaseIndex_Datapoints)
                _DataPoint = RootPart.DataPoints(_DatapointSubpart)

                g_NACharToDisplay = RootPart.GUI(1).NACharToDisplay

                'We need to get the Datasheet file from the JCComApp's Save folder (usually .0001.0000)
                'and copy it into our Working folder so that the Document Current Documents Table can find it:
                If ((RootPart.Name = "JCApp_ITO") AndAlso (RootPart.CurrentProcess.Contains("RouteJCApp_ITO"))) Then
                    Dim _fileToCopy As String = String.Empty
                    Dim _ComSaveFolder As String = RootPart.RFQSaveFolder & "\"

                    _sealItem!C4C_Current_Documents_Show_All.InputValue = True 'Let it see the unfiltered list
                    g_ObjectManager.RSEngineer.RefreshModelViews(-1)

                    For Each _Doc As Object In RootPart.MyCurrentDocuments 'Connection that contains all the current document as determined by commerical.
                        Try
                            _fileToCopy = _ComSaveFolder & _Doc.FileName_RS

                            If (_fileToCopy <> String.Empty) AndAlso (File.Exists(_fileToCopy)) Then
                                _logstr = String.Format($"Copy _fileToCopy: <{_fileToCopy}> to <{g_DocAccess.WorkingFolder & _Doc.FileName_RS}>")
                                g_ObjectManager.LogInfo(_module, _logstr, , True)
                                'Keep the file name the same but move from COM Save to Local Working
                                File.Copy(_fileToCopy, g_DocAccess.WorkingFolder & _Doc.FileName_RS, True)

                            End If

                        Catch exFile As Exception
                            _logstr = String.Format($"{exFile.Message}{vbCrLf}{vbCrLf}Could not access all the required files on loading!{vbCrLf}Do The following:{vbCrLf}1. Close all files relating to this Line Item.{vbCrLf}2. Close and Check In the line item without saving.{vbCrLf}3. Re-launch the Line Item.")
                            g_ObjectManager.LogError(_module, _logstr, False)
                        End Try
                    Next

                    _sealItem!C4C_Current_Documents_Show_All.InputValue = False 'Filter the list now all the files have moved.
                    g_ObjectManager.RSEngineer.RefreshModelViews(-1)

                    If (_DataPoint.ApplicationReviewStart = String.Empty) AndAlso Not (RootPart.ServerAccount) AndAlso Not (_sealItem.SealSubmitted) Then
                        _DataPoint!ApplicationReviewStart.InputValue = CurrentDateTime
                        _DataPoint!C4C_EnquiryType.InputValue = RootPart.C4C_EnquiryType
                        ' RootPart!MyStatus.InputValue = "10 - AE Not Started"
                        _logstr = String.Format($"Application Review Start: <{CurrentDateTime}> Added, C4C_EnquiryType: <{RootPart.C4C_EnquiryType}>, Reset JCApp_ITO.MyStatus.")
                        g_ObjectManager.LogInfo(_module, _logstr, , True)
                    End If


                    If Not (RootPart.ServerAccount) And Not (_sealItem.SealStarted) Then
                        If Not (RootPart.ServerAccount) And Not (_sealItem.SealStarted) Then
                            _sealItem!SealStarted.InputValue = True
                            _logstr = String.Format($"Application Review Start: Setting Seal Started.")
                            g_ObjectManager.LogInfo(_module, _logstr, , True)
                        End If

                        If (RootPart.ServerAccount) Then
                            If (_sealItem.SealSubmitted) Then
                                _sealItem!SealSubmitted.InputValue = False
                            End If
                            If (_sealItem.SealStarted) Then
                                _sealItem!SealStarted.InputValue = False
                                _logstr = String.Format($"SealStarted Resetting to False.")
                                g_ObjectManager.LogInfo(_module, _logstr, , True)
                            End If
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            _logstr = ex.ToString & If(ex.InnerException IsNot Nothing, " - " & ex.InnerException.ToString, String.Empty)
            g_ObjectManager.LogError(_module, _logstr, False)
        Finally

        End Try
    End Sub


    Public Sub RsEngineer_BeforeUnload()
        'If g_interactor IsNot Nothing Then g_interactor.Dispose()
        'If g_interactorCustom IsNot Nothing Then g_interactor.Dispose()
        'Dim _rp As Object = RootPart()
        'Dim _sealItem As Object = _rp.OrderItems(1)
        'Dim _DataPoint As Object = _rp.DataPoints(1)

        '_GlobalStopWatch.Stop()
        'Dim ts As TimeSpan = _GlobalStopWatch.Elapsed

        'Dim _CurrentStopwatch As TimeSpan = _DataPoint.StopwatchData

        '_DataPoint!StopwatchData = ts + _CurrentStopwatch
        'g_ObjectManager.RSEngineer.RefreshModelViews(-1)
        'g_ObjectManager.RSEngineer.SaveModel()

        GC.Collect()
    End Sub

    ' =========================================================================
    ' STEP CHANGE
    ' =========================================================================

    Public Sub g_RsEngineer_RsBeforeProcessStepChange(sender As Object, ByVal e As RsBeforeProcessStepChangeEventArgs) 'Handles g_RsEngineer.RsBeforeProcessStepChange

        If RootPart.Partfamily = "_RS_PLIB_Top" Then
            Select Case e.ProcessStep.Name

                Case "Project Search"
                    RootPart.SearchByProject(1).Criteria(1).Properties("MessageAdvanceSearch").RevertToCalc
                    RootPart.SearchByProject(1).Criteria(1).Properties("MessageBasicSearch").RevertToCalc

                Case "Line Item Search"
                    RootPart.SearchByLineItem(1).Criteria(1).Properties("MessageAdvanceSearch").RevertToCalc
                    RootPart.SearchByLineItem(1).Criteria(1).Properties("MessageBasicSearch").RevertToCalc

                Case "Project Line Items"
                    RootPart.SearchByProject(1).Properties("MessageLineItemSearch").RevertToCalc

                Case "New Project"
                    ResetPart(RootPart.SearchByProject(1).NewProject(1))

                Case "New Line Item"
                    ResetPart(RootPart.SearchByProject(1).NewLineItem(1))

                Case "Line Item Details"
                    ResetPart(RootPart.SearchByProject(1).SelectedLineItem(1))
                    ResetPart(RootPart.SearchByLineItem(1).SelectedLineItem(1))

            End Select
        End If
    End Sub

    Public Sub RsEngineer_AfterProcessStepChange(ByVal sender As Object, ByVal e As RsAfterProcessStepChangeEventArgs)

    End Sub

    Private Sub g_RsEngineer_AfterProcessStepChange(processStep As IRsProcessStep)

    End Sub

    ' =========================================================================
    ' RELEASE
    ' =========================================================================

    '   Public Sub g_rsEngineer_RsUserRelease(ByVal sender As Object, ByVal e As CancelEventArgs)
    '       Dim returnValue As Boolean
    '       Dim filePathThatFailed As String = String.Empty
    '       returnValue = ITO_AreThereOpenDocs(filePathThatFailed)
    '       If returnValue = True Then
    '           g_ObjectManager.LogInfo("g_rsEngineer_RsUserRelease", String.Format($"Submit cancelled, please close this file and try again: <{filePathThatFailed}>."), , True)
    '           e.Cancel = True
    '
    '        End If
    '    End Sub

    Public Sub g_RsEngineer_AfterRelease(ByVal sender As Object, ByVal e As EventArgs)

        '         Dim _rp As Object = RootPart()
        '        Dim _Subject As String = String.Format($"Rulestream Update For Project: {_rp.ProjectName} C4C{_rp.C4CInquiryNumber} (RSID:{_rp.MyProjectID} L/I:{_rp.LineItem}) Technical Review Has Been Completed")
        '        Dim _body As String = String.Format($"Please check the commercial line item (1) for the latest information.{vbCrLf}Project {_rp.MyProjectID} was last updated by {_rp.EngineerInitials}. {vbCrLf}Note: This update can only be viewed in Rulestream and has not yet been pushed to C4C. {vbCrLf}{vbCrLf}Best Regards{vbCrLf}Rulestream{vbCrLf}{vbCrLf}----- THIS IS AN AUTOMATED EMAIL WRITTEN BY RULESTREAM -----")
        '        Dim _ComUserEmail As String = _rp.CommercialUserEmail
        '        Dim _ComMgrEmail As String = _rp.CommercialManagerEmail
        '
        '        g_ObjectManager.LogInfo("Custom.g_RsEngineer_AfterRelease()", String.Format($"In After Release Event, ReleaseID: <{RootPart.Release.ToString}>."), , True)
        '        ITO_ReleaseDocs()
        '
        '        g_ObjectManager.LogInfo("Custom.RsActionButtonClick", "Entering: ITO_SendEmail", , True)
        '
        '        If (_ComUserEmail = _ComMgrEmail) Then
        '            _ComMgrEmail = String.Empty
        '        End If
        '
        '        SendEmail_WithOutlook(_ComUserEmail, _ComMgrEmail, _Subject, _body, "")
        '
        '        g_ObjectManager.RSEngineer.SaveModel()
        '        'Everything was successful we want to check in and close
        '        'CloseRulestream()
        '        ' End If
    End Sub



    ' =====================================================================================================================
    ' ======================================= BEFORE SAVE E V E N T =======================================
    ' =====================================================================================================================

    Public Sub g_RsEngineer_BeforeSave(ByVal sender as Object, ByVal e as CancelEventArgs)

        Dim _module As String = String.Format($"g_RsEngineer_BeforeSave() Called FunctionName: <{sender}>")
        Dim _logstr As String = "Entry"
        Dim _rp As Object = RootPart()
        Dim CurrentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Try

            g_ObjectManager.LogInfo(_module, _logstr, , True)

            If sender.TopLevelPart.Name.Trim().ToLower().StartsWith("adm_") AndAlso sender.TopLevelPart.Name.Trim().ToLower().EndsWith("_master_app") Then
                'Generically reset anyting ADM_XXXXXXX_Master Part Familys on close
                g_ObjectManager.LogInfo(_module, $"Resetting Part Family {sender.TopLevelPart.Name} To Empty Prior to Save", , True)
                For Each sp As Subpart In Rootpart.Subparts
                    sp(1).Subparts("Rows").Removeall()
                    sp(1).Subparts("Rows").RevertToCalc()
                Next sp

                g_ObjectManager.RevertCalculatedValues()
            End If
            Select Case sender.TopLevelPart.Name.ToLower()
                'Sample:
                Case "ADM_Data_Master_App".ToLower() 
					e.Cancel = false
 
                Case "ADM_Voltage_Master".ToLower() 
                   ' Do Something 
                   ' Rootpart.Subparts("Rows").Removeall()
                   ' Rootpart.Subparts("Rows").RevertToCalc()
                   ' g_ObjectManager.RevertCalculatedValues() 
                   ' Rootpart.RefreshModel()

                e.Cancel = false
                Case Else
                    g_ObjectManager.LogInfo(_module, "Event NOT MAPPED in Custom.vb in g_rsEngineer_RsActionButtonClick()", , False)

            End Select

        Catch ex As Exception

            g_ObjectManager.LogError(_module, ex.ToString & If(ex.InnerException IsNot Nothing, " - " & ex.InnerException.ToString, String.Empty), False)
        Finally

        End Try         
    End Sub




    ' =====================================================================================================================
    ' ======================================= A C T I O N   B U T T O N   E V E N T =======================================
    ' =====================================================================================================================


    ''' <summary>
    ''' Handles the RsActionButtonClick event of the g_rsEngineer control.
    ''' Routes all button click events for ITO_ENG.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RuleStream.RsActionButtonClickEventArgs"/> instance containing the event data.</param>
    Public Sub g_rsEngineer_RsActionButtonClick(ByVal sender As Object, ByVal e As RuleStream.RsActionButtonClickEventArgs)

        Dim _module As String = String.Format($"Custom.g_rsEngineer_RsActionButtonClick() Called FunctionName: <{e.FunctionName}>")
        Dim _logstr As String = $"Entry with sender.SelectedPart: <{sender.SelectedPart.Name}>"
        Dim _rp As Object = RootPart()
        Dim CurrentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Try
			
			g_ObjectManager.LogInfo(_module, _logstr, , True)
			
			Select Case e.FunctionName
				
				'Sample:
				'Case "HBS_GroupSystemPlant_AddPlant"
				'   g_ObjectManager.LogInfo(_module, _logstr, , True)
				
				Case "HBS_CORAInfo_SaveModel"
					_logstr = "Executing SaveModel"
					g_ObjectManager.LogInfo(_module, _logstr, , True)
					
					_logstr = "Executing DoComponentDBInserts(True, ""RSXLI_PLI_Search_Data"")"
					g_ObjectManager.LogInfo(_module, _logstr, , True)
					g_ObjectManager.DoComponentDBInserts(True, "RSXLI_PLI_Search_Data")

					g_ObjectManager.RSEngineer.SaveModel()
					
				Case "Adm_Master_LoadFromDB"
					
					Dim TableName As String = sender.SelectedPart.Name.Split(":")(0).Trim()
					g_ObjectManager.LogInfo(e.FunctionName, $"TableName: <{TableName}>", , True)
					
					Dim PFName As String = "ADM_" & TableName
					'Dim RealTableName As String = TableName.Replace("Adm_","")
					g_ObjectManager.LogInfo(e.FunctionName, $"PFName: <{PFName}>", , True)
					
					Dim SubpartName As String = $"{PFName}_Row"
					g_ObjectManager.LogInfo(e.FunctionName, $"SubpartName: <{SubpartName}", , True)
					
					'Dim PK_Name_old As String = "Signal_Type_Master_ID"
					Dim PK_Name As String = $"{TableName}_ID"
					g_ObjectManager.LogInfo(e.FunctionName, $"PK_Name: <{PK_Name}", , True)
					
					Dim SubpartColName As String = "Rows"
					Dim PF As Part = sender.SelectedPart
					g_ObjectManager.LogInfo(e.FunctionName, $"PF.Name: <{PF.Name}", , True)
					
					'Refresh the UI from the DB:
					PF.Properties("Row_DBKeys_ValidValues").ForceDecache()
					PF.Subparts(SubpartColName).RemoveAll()
					
					For Each s As String In PF.ValidValues("Row_DBKeys").Keys
						Dim i As Integer = CInt(s)
						Dim Item As Part = PF.Subparts(SubpartColName).AddPart(SubpartName)
						'g_ObjectManager.LogInfo(e.FunctionName, $"Item.Name: <{Item.Name}", , True)
						Item.Properties(PK_Name).InputValue = i
					Next s
					
					g_ObjectManager.RSEngineer.RefreshModelViews(-1)
					g_ObjectManager.LogInfo(e.FunctionName, $"{TableName} Data Refreshed", , True)
					
					
				Case "Adm_Master_Row_Add"
					
					Dim TableName As String = sender.SelectedPart.Name.Split(":")(0).Trim()
					g_ObjectManager.LogInfo(e.FunctionName, $"TableName: <{TableName}>", , True)
					
					Dim SubpartName As String = $"ADM_{TableName}_Row"
					g_ObjectManager.LogInfo(e.FunctionName, $"SubpartName: <{SubpartName}", , True)
					
					Dim Item As Part = sender.SelectedPart.Subparts("Rows").AddPart(SubpartName)
					
					If Item Is Nothing Then
						g_ObjectManager.LogError(e.FunctionName, String.Format($"Error then trying to add new {SubpartName}"), False,)
					Else
						g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Adding Row for Part: <{Item.Name}>"), , True)
						
						g_ObjectManager.DecacheCalculatedValuesPart(sender.SelectedPart)
						sender.Refresh()
						g_ObjectManager.RSEngineer.RefreshModelViews(-1)
					End If
					
				Case "Adm_Master_Row_Delete"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered with sender.SelectedPart: <{sender.SelectedPart.Name}>", , True)
					
					Dim Item As Part = sender.SelectedPart.Subparts("Rows")(sender.SelectedPart.Properties("Selected_Row").Value)
					If Item Is Nothing Then
						g_ObjectManager.LogError(e.FunctionName, String.Format($"Error attempting to Delete : <{sender.SelectedPart.Subparts("Rows")(sender.SelectedPart.Properties("Selected_Row").Value)}>"), False,)
					Else
						g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Deleting Row for Part: <{Item.Name}>"), , True)
						Item.Properties("Deleted").SetInputValue(True)
						g_ObjectManager.DecacheCalculatedValuesPart(sender.SelectedPart)
						sender.Refresh()
						g_ObjectManager.RSEngineer.RefreshModelViews(-1)
					End If
				
				
				Case "ADM_Pole_Master_Save_Changed"
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Pole_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Pole_Name").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Pole Name is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												Using command As New SqlCommand("sp_adm_Pole_Master", connection)
													_sb.AppendLine("Calling sp_adm_Pole_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Pole_Master_Id", OriginalPK)
													_sb.AppendLine($"Adding @Pole_Master_Id = <{OriginalPK.ToString}>")
													
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													_sb.AppendLine($"Adding @Sort_Order = <{PF.Properties("Sort_Order").Value.ToString}>")
													command.Parameters.AddWithValue("@Pole_Name", Item_Name_Value)
													_sb.AppendLine($"Adding @Pole_Name = <{Item_Name_Value}>")
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													_sb.AppendLine($"Adding @Is_Active = <{PF.Properties("Is_Active").Value.ToString}>")
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													_sb.AppendLine($"Adding @Created_By = <{PF.Properties("Created_By").Value}>")
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													_sb.AppendLine($"Adding @Created_On = <{PF.Properties("Created_On").Value.ToString}>")
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													_sb.AppendLine($"Adding @Modified_By = <{g_RSUser.Name} [{g_RSUser.UserName}]>")
													command.Parameters.AddWithValue("@Modified_On", DateTime.now)
													_sb.AppendLine($"Adding @Modified_On = <{DateTime.now.ToString}>")
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													_sb.AppendLine($"Adding @Deleted = <{PF.Properties("Deleted").Value.ToString}>")
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													g_ObjectManager.LogInfo(e.FunctionName, _sb.ToString(), , True)
													_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Voltage_Master_Save_Changed"
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()

							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator

							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim Item_Name_Value As String = String.Empty
								Dim MyResult As Integer = 0
								Dim MyErrMsg As String = String.Empty

								Dim _sb As New Text.StringBuilder

								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										OriginalPK = PF.Properties("Voltage_Master_Id").Value
										Item_Name_Value = PF.Properties("Voltage").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Voltage Name is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Voltage_Master", connection)
													_sb.AppendLine("Calling sp_adm_Voltage_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Voltage_Master_ID", PF.Properties("Voltage_Master_ID").Value)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Voltage", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													MyResult = CInt(command.Parameters("@OutputPK").Value)
													If Not (ISDBNull(command.Parameters("@OutputErrMsg"))) Then MyErrMsg = CStr(command.Parameters("@OutputErrMsg").Value)
													
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}>, MyErrMsg: <{MyErrMsg}>", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error:{errText}"), False,)
														
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting new PKID: <{MyResult.ToString}>"), , True)
														PF.Properties("Voltage_Master_ID").InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.Subparts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using 'SQLcommand
												
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Signal_Type_Master_Save_Changed"
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Signal_Type_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Signal_Type").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Signal Type is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												Using command As New SqlCommand("sp_adm_Signal_Type_Master", connection)
													_sb.AppendLine("Calling sp_adm_Signal_Type_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Signal_Type_Master_ID", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Signal_Type", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Controller_Protocol_Master_Save_Changed"
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Controller_Protocol_Master_ID"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Protocol_Type").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Protocol Type is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												Using command As New SqlCommand("sp_adm_Controller_Protocol_Master", connection)
													_sb.AppendLine("Calling sp_adm_Controller_Protocol_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Controller_Protocol_Master_ID", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Protocol_Type", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Controller_Family_Master_Save_Changed"
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Controller_Family_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Controller_Family_Name").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Controller Family Name is Null, Empty, or otherwise invalid, please correct."), False,)

											Else
												errorCaught = False
												Using command As New SqlCommand("sp_adm_Controller_Family_Master", connection)
													_sb.AppendLine("Calling sp_adm_Controller_Family_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Controller_Family_Master_Id", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Controller_Family_Name", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Obsolete", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Controller_Spl_Feature_Master_Save_Changed"
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Controller_Spl_Feature_Master_ID"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Special_Feature").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Special Feature is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Controller_Spl_Feature_Master", connection)
													_sb.AppendLine("Calling sp_adm_Controller_Spl_Feature_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Controller_Spl_Feature_Master_ID", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Special_Feature", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_CPU_IO_Master_Save_Changed"
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "CPU_IO_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("CPU_IO_Type").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: CPU IO Type is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_CPU_IO_Master", connection)
													_sb.AppendLine("Calling sp_adm_CPU_IO_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@CPU_IO_Master_Id", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Type", Item_Name_Value)
													command.Parameters.AddWithValue("@Description", PF.Properties("CPU_IO_Description").Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Parts_Accessory_Mapping_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Parts_Accessory_Mapping_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Accessory").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Accessory Name is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Parts_Accessory_Mapping_Master", connection)
													_sb.AppendLine("Calling sp_adm_Parts_Accessory_Mapping_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Parts_Accessory_Mapping_Master_Id", OriginalPK)
													command.Parameters.AddWithValue("@Parts_Master_ID_Ref", PF.Properties("Parts_Master_ID_Ref").Value)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Accessory", PF.Properties("Accessory").Value)
													command.Parameters.AddWithValue("@Accessory_Qty", PF.Properties("Accessory_Qty").Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}>, MyErrMsg: <{MyErrMsg}>", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}{vbCrLf}Error:{vbCrLf}{errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties("Parts_Accessory_Mapping_Master_Id").InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.Subparts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using 'SQLcommand
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Engg_Units_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Engg_Units_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Unit_of_Measure").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Unit of Measure is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Engg_Units_Master", connection)
													_sb.AppendLine("Calling sp_adm_Engg_Units_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Engg_Units_Master_ID", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Unit_Of_Measure", Item_Name_Value)
													command.Parameters.AddWithValue("@Base_Unit_Name", PF.Properties("Base_Unit_Name").Value)
													command.Parameters.AddWithValue("@Base_Unit_Symbol", PF.Properties("Base_Unit_Symbol").Value)
													command.Parameters.AddWithValue("@Engg_Units_Standard_Ref", PF.Properties("Engg_Units_Standard_Ref").Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Point_Type_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Point_Type_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Point_Type").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Point Type is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Point_Type_Master", connection)
													_sb.AppendLine("Calling sp_adm_Point_Type_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Point_Type_Master_ID", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Point_Type", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Process_Variable_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Process_Variable_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Process_Variable").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Process Variable Name is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Process_Variable_Master", connection)
													_sb.AppendLine("Calling sp_adm_Process_Variable_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Process_Variable_Master_Id", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Process_Variable", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", DateTime.now)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													
													
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Std_Wiring_Detail_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current

									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)

									Else
										PKID_Property_Name = "Std_Wiring_Detail_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Wiring_Std_Detail_Description").Value

										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Wiring Std Detail Description is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Std_Wiring_Detail_Master", connection)
													_sb.AppendLine("Calling sp_adm_Std_Wiring_Detail_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Std_Wiring_Detail_Master_Id", OriginalPK)
													command.Parameters.AddWithValue("@Std_Wiring_Detail_Master_Id_String", PF.Properties("Std_Wiring_Detail_Master_Id_String").Value)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Wiring_Std_Detail_Description", Item_Name_Value)
													command.Parameters.AddWithValue("@Point_Type", PF.Properties("Point_Type").Value)
													command.Parameters.AddWithValue("@Do_Type", PF.Properties("Do_Type").Value)
													command.Parameters.AddWithValue("@Wiring_Type", PF.Properties("Wiring_Type").Value)
													command.Parameters.AddWithValue("@No_Of_Terminals", PF.Properties("No_Of_Terminals").Value)
													command.Parameters.AddWithValue("@Power_Supply", PF.Properties("Power_Supply").Value)
													command.Parameters.AddWithValue("@Wiring_Std_Detail_Dwg", PF.Properties("Wiring_Std_Detail_Dwg").Value)
													command.Parameters.AddWithValue("@Resistor_Required", PF.Properties("Resistor_Required").Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", DateTime.now)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
														
													'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
													
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "ADM_Application_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum As IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim PKID_Property_Name As String = String.Empty
								Dim Item_Name_Value As String = String.Empty
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										PKID_Property_Name = "Application_Master_Id"
										OriginalPK = PF.Properties(PKID_Property_Name).Value
										Item_Name_Value = PF.Properties("Application_Name").Value
										
										'Only process changed rows
										If PF.Properties("Is_Dirty").Value = True Then
											
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}>, Item_Name_Value: <{Item_Name_Value}> "), , True)
											
											'Don't save if there isn't a valid Item_Value_Name
											If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
												g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Application Name is Null, Empty, or otherwise invalid, please correct."), False,)
											
											Else
												errorCaught = False
												
												Using command As New SqlCommand("sp_adm_Application_Master", connection)
													_sb.AppendLine("Calling sp_adm_Application_Master")
													
													command.CommandType = CommandType.StoredProcedure
													command.Parameters.AddWithValue("@Application_Master_Id", OriginalPK)
													command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
													command.Parameters.AddWithValue("@Application", Item_Name_Value)
													command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
													command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
													command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
													command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
													command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
													command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
													command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
													command.Parameters.Add("@OutputErrMsg", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output
													'_sb.Clear()
													command.ExecuteNonQuery()
													
													Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
													Dim MyErrMsg As String = CStr(command.Parameters("@OutputErrMsg").Value)
													g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
													
													'Test For Error Condition
													If MyResult <= 0 Then
														'Error Condition Exists, and MyResult contains -(SQLErrorCode)
														'-2601 = Foreign Key Violation
														errorCaught = True
														Dim errText As String = $"Error code = <{MyResult.ToString}>"
														If MyResult = -3 Then
															errText = "Duplicate Data detected"
														Else
															errText = MyErrMsg
														End If
														g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
														
														'If OriginalPK was -1, then save the new PKID
													ElseIf OriginalPK < 0 Then
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
														PF.Properties(PKID_Property_Name).InputValue = MyResult
														
													Else 'Update of existing Row was successful
														g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
													
													End If
													
													If Not errorCaught Then
														
														PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
														g_ObjectManager.RSEngineer.RefreshModelViews(-1)
														g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
													
													End If
												
												End Using
											
											End If 'Item_Name_Value <> String.Empty
										End If  'Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				' Case "ADM_Device_Type_Master_Save"
					' g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					' Dim PF As Part = sender.SelectedPart.Subparts("Rows")(sender.SelectedPart.Properties("Selected_Row").Value)
					' g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>"), , True)
					
					' Dim errorCaught As Boolean = False
					' Dim OriginalPK As Long = PF.Properties("Device_Type_Master_Id").Value
					' Dim Item_Name_Value as String = PF.Properties("Device_Type").Value
					
					' 'Don't save if there isn't a valid Item_Name
					' If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
						' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Device Type is Null or Empty, please correct."), False,)
					
					' ElseIf PF.Properties("Is_Dirty").Value = True Then
						
						' Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						' Using connection As New SqlConnection(CompDBConnString)
							' connection.Open()
							' Using command As New SqlCommand($"sp_adm_Device_Type_Master", connection)
								' command.CommandType = CommandType.StoredProcedure
								' command.Parameters.AddWithValue("@Device_Type_Master_Id", PF.Properties("Device_Type_Master_Id").Value)
								' command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
								' command.Parameters.AddWithValue("@Device_Type", Item_Name_Value)
								' command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
								' command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
								' command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
								' command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
								' command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
								' command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
								' command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
								' command.ExecuteNonQuery()
								' 'If returned value (OriginalPF) is negative, this is a new record
								' If OriginalPK < 0 Then 
									
									' Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
									' g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
									
									' 'Test For Error Condition
									' If MyResult <= 0 Then
										' 'Error Condition Exists
										' '-2603 = Foreign Key Violation
										' errorCaught = True
										' Dim errText As String = $"Error code = <{MyResult.ToString}>"
										' If MyResult = -3 Then
											' errText = "Duplicate Data detected"
										' End if
										' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter new Device_Type_Master Row: {errText}"), False,)
										
									' Else
										' PF.Properties("Device_Type_Master_Id").InputValue = MyResult
									' End If
								' End If
								
								' If Not errorCaught
									' PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
									' g_ObjectManager.RSEngineer.RefreshModelViews(-1)
									' g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
								' End If
							
							' End Using
						' End Using
					' End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
				
				Case "ADM_Device_Type_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum as IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim Item_Name_Value as String = String.Empty
								
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}> "), , True)
										
										OriginalPK = PF.Properties("Device_Type_Master_Id").Value
										Item_Name_Value = PF.Properties("Device_Type").Value
										
										'Don't save if there isn't a valid Device_Type
										If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
											g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Device Type is Null or Empty, please correct."), False,)
											
										ElseIf PF.Properties("Is_Dirty").Value = True Then
											
											errorCaught = False
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"OriginalPK: <{OriginalPK.ToString}>"), , True)
											
											Using command As New SqlCommand("sp_adm_Device_Type_Master", connection)
												_sb.AppendLine("Calling sp_adm_Device_Type_Master")
												
												command.CommandType = CommandType.StoredProcedure
												command.Parameters.AddWithValue("@Device_Type_Master_Id", PF.Properties("Device_Type_Master_Id").Value)
												command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
												command.Parameters.AddWithValue("@Device_Type", Item_Name_Value)
												command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
												command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
												command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
												command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
												command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
												command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
												command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
												
												'_sb.Clear()
												command.ExecuteNonQuery()
												
												Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
												g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
												
												'Test For Error Condition
												If MyResult <= 0 Then
													'Error Condition Exists, and MyResult contains -(SQLErrorCode)
													'-2601 = Foreign Key Violation
													errorCaught = True
													Dim errText As String = $"Error code = <{MyResult.ToString}>"
													If MyResult = -3 Then
														errText = "Duplicate Data detected"
													End if
													g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
												
												'If OriginalPK was -1, then save the new PKID
												Else If OriginalPK < 0 Then
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
													PF.Properties("Device_Type_Master_Id").InputValue = MyResult
												
												Else 'Update of existing Row was successful
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
												
												End If
												
												If Not errorCaught
													
													PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
													g_ObjectManager.RSEngineer.RefreshModelViews(-1)
													g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
												
												End If
											
											End Using
										
										End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
					
					
				' Case "ADM_Parameter_Name_Master_Save"
					' g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					' Dim PF As Part = sender.SelectedPart.Subparts("Rows")(sender.SelectedPart.Properties("Selected_Row").Value)
					' g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>"), , True)
					
					' Dim errorCaught As Boolean = False
					' Dim OriginalPK As Long = PF.Properties("Parameter_Name_Master_Id").Value
					' Dim Item_Name_Value as String = PF.Properties("Parameter_Name_Master").Value
					
					' 'Don't save if there isn't a valid Item_Name
					' If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
						' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Parameter Name is Null or Empty, please correct."), False,)
						
					' ElseIf PF.Properties("Is_Dirty").Value = True Then
						
						' Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						' Using connection As New SqlConnection(CompDBConnString)
							' connection.Open()
							' Using command As New SqlCommand($"sp_adm_Parameter_Name_Master", connection)
								' command.CommandType = CommandType.StoredProcedure
								' command.Parameters.AddWithValue("@Parameter_Name_Master_ID", PF.Properties("Parameter_Name_Master_Id").Value)
								' command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
								' command.Parameters.AddWithValue("@Parameter_Name_Master", Item_Name_Value)
								' command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
								' command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
								' command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
								' command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
								' command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
								' command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
								' command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
								' command.ExecuteNonQuery()
								' 'If returned value (OriginalPF) is negative, this is a new record
								' If OriginalPK < 0 Then 
									
									' Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
									' g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
									
									' 'Test For Error Condition
									' If MyResult <= 0 Then
										 ' 'Error Condition Exists
										 ' '-2603 = Foreign Key Violation
										 ' errorCaught = True
										 ' Dim errText As String = $"Error code = <{MyResult.ToString}>"
										 ' If MyResult = -3 Then
											' errText = "Duplicate Data detected"
										 ' End if
										 ' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter new Parameter_Name_Master Row: {errText}"), False,)
										 
									' Else
										' PF.Properties("Parameter_Name_Master_Id").InputValue = MyResult
									' End If
								' End If
								
								' If Not errorCaught
									' PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
									' g_ObjectManager.RSEngineer.RefreshModelViews(-1)
									' g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
								' End If
							
							' End Using
						' End Using
					' End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
					
				Case "ADM_Parameter_Name_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum as IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim Item_Name_Value as String = String.Empty
								
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}> "), , True)
										
										OriginalPK = PF.Properties("Parameter_Name_Master_Id").Value
										Item_Name_Value = PF.Properties("Parameter_Name_Master").Value
										
										'Don't save if there isn't a valid Parameter_Name_Master
										If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
											g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Parameter Name is Null or Empty, please correct."), False,)
											
										ElseIf PF.Properties("Is_Dirty").Value = True Then
											
											errorCaught = False
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"OriginalPK: <{OriginalPK.ToString}>"), , True)
											
											Using command As New SqlCommand("sp_adm_Parameter_Name_Master", connection)
												_sb.AppendLine("Calling sp_adm_Parameter_Name_Master")
												
												command.CommandType = CommandType.StoredProcedure
												command.Parameters.AddWithValue("@Parameter_Name_Master_ID", PF.Properties("Parameter_Name_Master_Id").Value)
												command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
												command.Parameters.AddWithValue("@Parameter_Name_Master", Item_Name_Value)
												command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
												command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
												command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
												command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
												command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
												command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
												command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
												
												'_sb.Clear()
												command.ExecuteNonQuery()
												
												Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
												g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
												
												'Test For Error Condition
												If MyResult <= 0 Then
													 'Error Condition Exists, and MyResult contains -(SQLErrorCode)
													 '-2601 = Foreign Key Violation
													 errorCaught = True
													 Dim errText As String = $"Error code = <{MyResult.ToString}>"
													 If MyResult = -3 Then
														errText = "Duplicate Data detected"
													 End if
													 g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													 
												'If OriginalPK was -1, then save the new PKID
												Else If OriginalPK < 0 Then
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
													PF.Properties("Parameter_Name_Master_Id").InputValue = MyResult
												
												Else 'Update of existing Row was successful
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
												
												End If
												
												If Not errorCaught
													
													PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
													g_ObjectManager.RSEngineer.RefreshModelViews(-1)
													g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
												
												End If
											
											End Using
										
										End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
					
					
				' Case "ADM_Part_Type_Master_Save"
					' g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					' Dim PF As Part = sender.SelectedPart.Subparts("Rows")(sender.SelectedPart.Properties("Selected_Row").Value)
					' g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>"), , True)
					
					' Dim errorCaught As Boolean = False
					' Dim OriginalPK As Long = PF.Properties("Part_Type_Master_Id").Value
					' Dim Item_Name_Value as String = PF.Properties("Part_Type").Value
					
					' 'Don't save if there isn't a valid Item_Name
					' If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
						' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Part Type is Null or Empty, please correct."), False,)
						
					' ElseIf PF.Properties("Is_Dirty").Value = True Then
						
						' Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						' Using connection As New SqlConnection(CompDBConnString)
							' connection.Open()
							' Using command As New SqlCommand($"sp_adm_Part_Type_Master", connection)
								' command.CommandType = CommandType.StoredProcedure
								' command.Parameters.AddWithValue("@Part_Type_Master_Id", PF.Properties("Part_Type_Master_Id").Value)
								' command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
								' command.Parameters.AddWithValue("@Part_Type", Item_Name_Value)
								' command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
								' command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
								' command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
								' command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
								' command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
								' command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
								' command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
								' command.ExecuteNonQuery()
								' 'If returned value (OriginalPF) is negative, this is a new record
								' If OriginalPK < 0 Then 
									
									' Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
									' g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
									
									' 'Test For Error Condition
									' If MyResult <= 0 Then
										 ' 'Error Condition Exists
										 ' '-2603 = Foreign Key Violation
										 ' errorCaught = True
										 ' Dim errText As String = $"Error code = <{MyResult.ToString}>"
										 ' If MyResult = -3 Then
											' errText = "Duplicate Data detected"
										 ' End if
										 ' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter new Part_Type_Master Row: {errText}"), False,)
										 
									' Else
										' PF.Properties("Part_Type_Master_Id").InputValue = MyResult
									' End If
								' End If
								
								' If Not errorCaught
									' PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
									' g_ObjectManager.RSEngineer.RefreshModelViews(-1)
									' g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
								' End If
							
							' End Using
						' End Using
					' End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
					
				Case "ADM_Part_Type_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum as IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim Item_Name_Value as String = String.Empty
								
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}> "), , True)
										
										OriginalPK = PF.Properties("Part_Type_Master_Id").Value
										Item_Name_Value = PF.Properties("Part_Type").Value
										
										'Don't save if there isn't a valid Part_Type
										If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
											g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Part Type is Null or Empty, please correct."), False,)
											
										ElseIf PF.Properties("Is_Dirty").Value = True Then
											
											errorCaught = False
											g_ObjectManager.LogInfo(e.FunctionName, String.Format($"OriginalPK: <{OriginalPK.ToString}>"), , True)
												
											Using command As New SqlCommand("sp_adm_Part_Type_Master", connection)
												_sb.AppendLine("Calling sp_adm_Part_Type_Master")
												
												command.CommandType = CommandType.StoredProcedure
												command.Parameters.AddWithValue("@Part_Type_Master_Id", PF.Properties("Part_Type_Master_Id").Value)
												command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
												command.Parameters.AddWithValue("@Part_Type", Item_Name_Value)
												command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
												command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
												command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
												command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
												command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
												command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
												command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output											
												'_sb.Clear()
												command.ExecuteNonQuery()
												
												Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
												g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
												
												'Test For Error Condition
												If MyResult <= 0 Then
													 'Error Condition Exists, and MyResult contains -(SQLErrorCode)
													 '-2601 = Foreign Key Violation
													 errorCaught = True
													 Dim errText As String = $"Error code = <{MyResult.ToString}>"
													 If MyResult = -3 Then
														errText = "Duplicate Data detected"
													 End if
													 g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													 
												'If OriginalPK was -1, then save the new PKID
												Else If OriginalPK < 0 Then
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
													PF.Properties("Part_Type_Master_Id").InputValue = MyResult
												
												Else 'Update of existing Row was successful
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
												
												End If
												
												If Not errorCaught
													
													PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
													g_ObjectManager.RSEngineer.RefreshModelViews(-1)
													g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
												
												End If
												
											End Using
										
										End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
					
					
				' Case "ADM_Standards_Master_Save"
					' g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					' Dim PF As Part = sender.SelectedPart.Subparts("Rows")(sender.SelectedPart.Properties("Selected_Row").Value)
					' g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>"), , True)
					
					' Dim errorCaught As Boolean = False
					' Dim OriginalPK As Long = PF.Properties("Standards_Master_Id").Value
					' Dim Item_Name_Value as String = PF.Properties("Standards").Value
					
					' 'Don't save if there isn't a valid Item_Name
					' If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
						' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Standards is Null or Empty, please correct."), False,)
						
					' ElseIf PF.Properties("Is_Dirty").Value = True Then
						
						' Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						' Using connection As New SqlConnection(CompDBConnString)
							' connection.Open()
							' Using command As New SqlCommand($"sp_adm_Standards_Master", connection)
								' command.CommandType = CommandType.StoredProcedure
								' command.Parameters.AddWithValue("@Standards_Master_ID", PF.Properties("Standards_Master_Id").Value)
								' command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
								' command.Parameters.AddWithValue("@Standards", Item_Name_Value)
								' command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
								' command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
								' command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
								' command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
								' command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
								' command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
								' command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
								' command.ExecuteNonQuery()
								' 'If returned value (OriginalPF) is negative, this is a new record
								' If OriginalPK < 0 Then 
									
									' Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
									' g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
									
									' 'Test For Error Condition
									' If MyResult <= 0 Then
										 ' 'Error Condition Exists
										 ' '-2603 = Foreign Key Violation
										 ' errorCaught = True
										 ' Dim errText As String = $"Error code = <{MyResult.ToString}>"
										 ' If MyResult = -3 Then
											' errText = "Duplicate Data detected"
										 ' End if
										 ' g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter new Standards_Master Row: {errText}"), False,)
										 
									' Else
										' PF.Properties("Standards_Master_Id").InputValue = MyResult
									' End If
								' End If
								
								' If Not errorCaught
									' PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
									' g_ObjectManager.RSEngineer.RefreshModelViews(-1)
									' g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
								' End If
							
							' End Using
						' End Using
					' End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
					
					
				Case "ADM_Standards_Master_Save_Changed"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim OwnerSubpartCollection As Subpart = sender.SelectedPart.Rows
					g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Subpart: <{OwnerSubpartCollection.Name}>"), , True)
					
					If sender.SelectedPart.Properties("Is_Dirty").Value = True Then
						'only open a connection if we have changes
						Dim CompDBConnString As String = g_rsUser.UserSettings.ActiveProfile.ComponentsConnectionString
						Using connection As New SqlConnection(CompDBConnString)
							connection.Open()
							
							Dim PartEnum as IEnumerator = OwnerSubpartCollection.GetEnumerator
							
							' Make sure you have an enumerator
							If Not PartEnum Is Nothing Then
								Dim PF As Part = Nothing
								Dim errorCaught As Boolean = False
								Dim OriginalPK As Long = -1
								Dim Item_Name_Value as String = String.Empty
								
								Dim _sb As New Text.StringBuilder
								
								' loop the collection
								While PartEnum.MoveNext
									
									' get the part, add it if it's not destroyed
									PF = PartEnum.Current
									
									If PF Is Nothing Then
										g_ObjectManager.LogError(e.FunctionName, "PF Is Nothing", False,)
									
									Else
										OriginalPK = PF.Properties("Standards_Master_Id").Value
										
										g_ObjectManager.LogInfo(e.FunctionName, String.Format($"PF: <{PF.Name}>, OriginalPK: <{OriginalPK.ToString}>, IsDirty: <{PF.Properties("Is_Dirty").Value.ToString}> "), , True)
										
										Item_Name_Value = PF.Properties("Standards").Value
										
										'Don't save if there isn't a valid Standards
										If String.IsNullOrEmpty(Item_Name_Value.Trim()) Then
											g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: Standards is Null or Empty, please correct."), False,)
											
										ElseIf PF.Properties("Is_Dirty").Value = True Then
										
											errorCaught = False
											'OriginalPK = PF.Properties("Standards_Master_Id").Value
											'g_ObjectManager.LogInfo(e.FunctionName, String.Format($"OriginalPK: <{OriginalPK.ToString}>"), , True)
											
											Using command As New SqlCommand("sp_adm_Standards_Master", connection)
												_sb.AppendLine("Calling sp_adm_Standards_Master")
												
												command.CommandType = CommandType.StoredProcedure
												command.Parameters.AddWithValue("@Standards_Master_ID", OriginalPK)
												command.Parameters.AddWithValue("@Sort_Order", PF.Properties("Sort_Order").Value)
												command.Parameters.AddWithValue("@Standards", Item_Name_Value)
												command.Parameters.AddWithValue("@Created_By", PF.Properties("Created_By").Value)
												command.Parameters.AddWithValue("@Created_On", PF.Properties("Created_On").Value)
												command.Parameters.AddWithValue("@Modified_By", String.Format($"{g_RSUser.Name} [{g_RSUser.UserName}]"))
												command.Parameters.AddWithValue("@Modified_On", PF.Properties("Modified_On").Value)
												command.Parameters.AddWithValue("@Is_Active", PF.Properties("Is_Active").Value)
												command.Parameters.AddWithValue("@Deleted", PF.Properties("Deleted").Value)
												command.Parameters.Add("@OutputPK", SqlDbType.Int).Direction = ParameterDirection.Output
												command.ExecuteNonQuery()
												
												
												Dim MyResult As Integer = CInt(command.Parameters("@OutputPK").Value)
												g_ObjectManager.LogInfo(e.FunctionName, $"OriginalPK: <{OriginalPK.ToString}>, Returned MyResult: <{MyResult.ToString}> ", , True)
												
												'Test For Error Condition
												If MyResult <= 0 Then
													 'Error Condition Exists, and MyResult contains -(SQLErrorCode)
													 '-2601 = Foreign Key Violation
													 errorCaught = True
													 Dim errText As String = $"Error code = <{MyResult.ToString}>"
													 If MyResult = -3 Then
														errText = "Duplicate Data detected"
													 End if
													 g_ObjectManager.LogError(e.FunctionName, String.Format($"Error when trying to enter/update Row for PKID: <{OriginalPK}>.{vbCrLf}Error: {errText}"), False,)
													 
												'If OriginalPK was -1, then save the new PKID
												Else If OriginalPK < 0 Then
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Setting PKID: <{MyResult.ToString}>"), , True)
													PF.Properties("Standards_Master_Id").InputValue = MyResult
												
												Else 'Update of existing Row was successful
													g_ObjectManager.LogInfo(e.FunctionName, String.Format($"Successful Update of Row for PKID: <{MyResult.ToString}>"), , True)
												
												End If
												
												If Not errorCaught
													
													PF.SubParts("DbInfo")(1).RefreshDatabaseValues()
													g_ObjectManager.RSEngineer.RefreshModelViews(-1)
													g_ObjectManager.LogInfo(e.FunctionName, $"Saved New Item: {PF.Name} ", , True)
												
												End If
											
											End Using
										
										End If 'Item_Name_Value <> String.Empty AND Is_Dirty = True
									End If 'PF Is Nothing
								
								End While
							End If
						End Using ' close the Connection
					End If 'Any Rows have Is_Dirty = True
				
				
				Case "Adm_RSXLI_PLI_Search_Data_LoadFromDB"
					g_ObjectManager.LogInfo(e.FunctionName, $"Entry", , True)
					
					'Dim TableName As String = "RSXLI_PLI_Search_Data"
					Dim SubpartName As String = "RSXLI_PLI_Search_Data_Row"
					Dim PK_Name As String = "RSXLI_PLI_Search_Data_ID"
					
					Dim SubpartColName As String = "Rows"
					Dim PF As Part = RootPart.RSXLI_PLI_Search_Data(1)
					PF.RefreshDatabaseValues()
					PF.Properties("Row_DBKeys").RevertToCalc()
					PF.Subparts(SubpartColName).RevertToCalc()
					PF.Subparts(SubpartColName).RemoveAll()
					PF.Subparts(SubpartColName).RevertToCalc()
					PF.RefreshDatabaseValues()
					
					Dim i As Integer = 0
					For Each s As String In PF.ValidValues("Row_DBKeys").Keys
						'Dim i As Integer = CInt(s)
						i += 1
						
						Dim Item As Part = PF.Subparts(SubpartColName).AddPart(SubpartName)
						g_ObjectManager.LogInfo(e.FunctionName, $"Item.Name: <{Item.Name}, setting {PK_Name}: <{s}>.", , True)
						
						Item.Properties(PK_Name).InputValue = s
					Next s
					
					g_ObjectManager.RSEngineer.RefreshModelViews(-1)
					g_ObjectManager.LogInfo(e.FunctionName, $"RSXLI_PLI_Search_Data Refreshed", , True)
				
				
				Case "ADM_RSXLI_PLI_Search_Data_Launch"
					
					g_ObjectManager.LogInfo(e.FunctionName, $"Entered Save Action Button Click", , True)
					Dim PF As Part = sender.SelectedPart.Subparts("Rows")(sender.SelectedPart.Properties("Selected_Row").Value)
					g_ObjectManager.LogInfo("Search", String.Format($"Launching Project #: <{PF.Properties("Project_Number").Value}>,{vbCrLf}Project Name: <{PF.Properties("Project_Name").Value}>,{vbCrLf}Project Name: <{PF.Properties("SFDC_Opportunity_ID").Value}> "), , False)
				
				
#Region "Unused"
				
				
				'ITO Events
                Case "ITO_BudgetSpec_Generate_Report"
                    g_ObjectManager.LogInfo(_module, "Calling: Aspose_DoBudgetSpecOutput", , True)
					'Aspose_DoBudgetSpecOutput()
					
					'DoBudgetSpecOutput()
				
				Case "ITO_BudgetSpec_OutputToTable"
					g_ObjectManager.LogInfo(_module, "Calling: ITO_BudgetSpec_OutputToTable Called with DoXLIUpdates = True", , True)
					g_ObjectManager.DoComponentDBInserts(True)
					g_ObjectManager.RSEngineer.RefreshModelViews(-1)
				
 '               Case "ITO_View_Changelog"
 '                   'MessageBox.Show(RootPart.OrderItems(1).ITOChangeLog, "Changelog For Version: " & RootPart.OrderItems(1).ITOBuildNumber.ToString)
 '                   g_ObjectManager.LogInfo(_module, "Calling: DoITO_OpenURL (ITO_View_Changelog)", , True)
 '                   Dim URL As String = https://smithsonline.sharepoint.com/sites/ADAMSupport/_layouts/15/Doc.aspx?sourcedoc={18b28635-fb5c-43fc-8117-04a7689fe65a}&action=edit&wd=target%28Change%20Log.one%7Cec1730f6-ce59-4448-a3bb-7dbb744fad60%2FEngineering%20Changelog%7C1f3cba02-2f34-49d9-a2cd-f4bcf9d6edaa%2F%29&wdorigin=703
  '                  DoITO_OpenURL(URL)

#End Region '"Unused"
				
				Case "ITO_SendEmail" 'TODO:Needs rework in VIA
					g_ObjectManager.LogInfo(_module, "Entering: ITO_SendEmail", , True)
					Dim _Subject As String = String.Format($"Rulestream Update For Project: {_rp.ProjectName} C4C{_rp.C4CInquiryNumber} (RSID:{_rp.MyProjectID} L/I:{_rp.LineItem}) Has Been Updated")
					Dim _body As String = String.Format($"Please check the commercial line item (1) for the latest information.{vbCrLf}Project {_rp.MyProjectID} was last updated by {_rp.EngineerInitials}. {vbCrLf}Note: This update can only be viewed in Rulestream and has not yet been pushed to C4C. {vbCrLf}{vbCrLf}Best Regards{vbCrLf}Rulestream{vbCrLf}{vbCrLf}----- THIS IS AN AUTOMATED EMAIL WRITTEN BY RULESTREAM -----")
					Dim _ComUserEmail As String = _rp.CommercialUserEmail
					Dim _ComMgremail As String = _rp.CommercialManagerEmail
					
					If (_ComUserEmail = _ComMgremail) Then
						_ComMgremail = String.Empty
					End If
					
					'SendEmail_WithOutlook(_ComUserEmail, _ComMgremail, _Subject, _body, "")
					'SendEmail(address, subject, body)
					
				Case "CreateExcelBOM"
					CreateExcelBOM()
					
				Case "CreateExcelPlantBlocks"
					CreateExcelPlantBlocks()
                Case "CreateSchedules"
                    CreateSchedules()
				Case "CreateSteamSchedules"
					CreateSteamSchedules()
				Case Else
					g_ObjectManager.LogInfo(_module, "Event NOT MAPPED in Custom.vb in g_rsEngineer_RsActionButtonClick()", , False)
					
				
			End Select
			
		Catch ex As Exception
			
			g_ObjectManager.LogError(_module, ex.ToString & If(ex.InnerException IsNot Nothing, " - " & ex.InnerException.ToString, String.Empty), False)
		Finally
		
		End Try
	End Sub
	
	''' <summary>
	''' Handles the RsAfterSave event of the g_rsEngineer control.
	''' </summary>
	''' <param name="sender">The source of the event.</param>
	''' <param name="e">The <see cref="RuleStream.RsAferSaveEventArgs"/> instance containing the event data.</param>
	Public Sub g_RsEngineer_AfterSave(ByVal sender As Object, ByVal e As EventArgs)

        If (Not (RootPart.CORA_Info(1).Project_ID = 0) AndAlso (Not (RootPart.CORAInfoSaved))) Then

            Dim _module As String = "Custom.g_RsEngineer_AfterSave()"
            Dim _logstr As String = String.Format($" Model Saved for Project_ID: <{RootPart.CORA_Info(1).Project_ID}>, setting CORAInfoSaved to: <{RootPart.CORAInfoSaved.ToString()}>")
            RootPart!CORAInfoSaved.InputValue = True
            g_ObjectManager.RSEngineer.RefreshModelViews(-1)

        End If
        GC.Collect()
    End Sub

#End Region '"Event Handlers"

#Region "Utilities"

    Public Sub ConvertSVG(filenamePath As String)

        If Not file.Exists(filenamePath) Then
            Dim process As New processStartInfo("\\HIC044413\RSShared\HBS\MasterDocs\ConvertSVG.exe")
            process.UseShellExecute = False
            process.Arguments = filenamePath
            process.CreateNoWindow = True
            Dim p As New Process()
            p.StartInfo = process
            p.Start()
            p.WaitForExit()
        End If

    End Sub



	'Public Sub ConvertSVG(filenamePath As String)
	'    Dim pngFile As String = filenamePath.Replace(".svg", ".png")

	'    If File.Exists(filenamePath) Then

	'        Dim svgDoc = Svg.SvgDocument.Open(filenamePath)
	'        Dim bitmap = svgDoc.Draw()

	'        Using bitmap
	'            Dim width = bitmap.Width
	'            Dim height = bitmap.Height
	'            Dim size = 100

	'            If width <> size Then
	'                width = size
	'                height = size / bitmap.Width * height
	'            End If

	'            Dim bitmap2 = svgDoc.Draw(width, height)

	'            Using bitmap2
	'                bitmap2.Save(pngFile, System.Drawing.Imaging.ImageFormat.Png)
	'            End Using

	'        End Using

	'    End If
	'End Sub
	Public Function SqrtV_Calc(SteamPressure As String) As String

		Dim SteamTable As DataTable = New DataTable("SteamTableData")
		Dim X1, Y1, X2, Y2 As Double

		SteamTable.Columns.Add("Pressure")
		SteamTable.Columns.Add("SqrtV")
		SteamTable.Rows.Add("-14.21", "26.57")
		SteamTable.Rows.Add("-12.25", "12.04")
		SteamTable.Rows.Add("-9.8", "8.672")
		SteamTable.Rows.Add("-7.35", "7.162")
		SteamTable.Rows.Add("-6.86", "6.95")
		SteamTable.Rows.Add("-5.88", "6.576")
		SteamTable.Rows.Add("-4.9", "6.257")
		SteamTable.Rows.Add("-3.92", "5.984")
		SteamTable.Rows.Add("-2.94", "5.744")
		SteamTable.Rows.Add("-1.96", "5.533")
		SteamTable.Rows.Add("-0.98", "5.345")
		SteamTable.Rows.Add("0", "5.175")
		SteamTable.Rows.Add("1", "5.02")
		SteamTable.Rows.Add("2", "4.876")
		SteamTable.Rows.Add("3", "4.751")
		SteamTable.Rows.Add("4", "4.626")
		SteamTable.Rows.Add("5", "4.518")
		SteamTable.Rows.Add("6", "4.41")
		SteamTable.Rows.Add("7", "4.317")
		SteamTable.Rows.Add("8", "4.225")
		SteamTable.Rows.Add("9", "4.142")
		SteamTable.Rows.Add("10", "4.061")
		SteamTable.Rows.Add("11", "3.987")
		SteamTable.Rows.Add("12", "3.918")
		SteamTable.Rows.Add("15", "3.724")
		SteamTable.Rows.Add("20", "3.464")
		SteamTable.Rows.Add("25", "3.251")
		SteamTable.Rows.Add("30", "3.076")
		SteamTable.Rows.Add("40", "2.797")
		SteamTable.Rows.Add("50", "2.585")
		SteamTable.Rows.Add("60", "2.416")
		SteamTable.Rows.Add("70", "2.276")
		SteamTable.Rows.Add("80", "2.159")
		SteamTable.Rows.Add("90", "2.059")
		SteamTable.Rows.Add("100", "1.972")
		SteamTable.Rows.Add("120", "1.827")
		SteamTable.Rows.Add("140", "1.71")
		SteamTable.Rows.Add("160", "1.613")
		SteamTable.Rows.Add("180", "1.531")
		SteamTable.Rows.Add("200", "1.461")
		SteamTable.Rows.Add("250", "1.32")
		SteamTable.Rows.Add("300", "1.213")
		SteamTable.Rows.Add("350", "1.128")
		SteamTable.Rows.Add("400", "1.058")
		SteamTable.Rows.Add("450", "0.999")
		SteamTable.Rows.Add("500", "0.949")
		SteamTable.Rows.Add("550", "0.904")
		SteamTable.Rows.Add("600", "0.865")
		SteamTable.Rows.Add("650", "0.831")
		SteamTable.Rows.Add("700", "0.799")
		SteamTable.Rows.Add("800", "0.744")
		SteamTable.Rows.Add("900", "0.699")
		SteamTable.Rows.Add("1000", "0.659")


		Dim count As Integer = 1
		For Each row As DataRow In SteamTable.Rows
			If Double.Parse(row.Item("Pressure")) >= Double.Parse(SteamPressure) Then
				X2 = Double.Parse(row.Item("Pressure"))
				Y2 = Double.Parse(row.Item("SqrtV"))
				If count > 1 Then
					X1 = Double.Parse(SteamTable.Rows(count - 2)(0))
					Y1 = Double.Parse(SteamTable.Rows(count - 2)(1))
				End If
				Exit For
			End If
			count += 1
		Next row


		Return (Y1 + (Double.Parse(SteamPressure) - X1) * (Y2 - Y1) / (X2 - X1))
	End Function

	Public Sub CreateSteamSchedules()
		Dim iRow As Integer = 7

		Dim TemplateFile As String = Path.Combine(g_DocAccess.MasterDocumentsFolder, "Templates", "Steam_Schedules.xlsx.xlsx")
		Dim OutputFile As String = Path.Combine(g_DocAccess.WorkingFolder, "Steam_Schedules_Report.xlsx")

		Dim wbook = New XLWorkbook(TemplateFile)
		Dim ws = wbook.Worksheet(1)

		For Each _valve As Object In RootPart().Schedules(1).Steam_Valves
			ws.Cell("B" & iRow).Value = _valve.ValveTag.ToString()
			ws.Cell("C" & iRow).Value = _valve.EquipmentLocation.ToString()
			ws.Cell("D" & iRow).Value = _valve.Service_Application.ToString()
			ws.Cell("E" & iRow).Value = _valve.ControlType.ToString()
			ws.Cell("F" & iRow).Value = _valve.LineSize.ToString()
			ws.Cell("G" & iRow).Value = _valve.SteamSupplyPressPSI.ToString()
			ws.Cell("H" & iRow).Value = _valve.SteamSupplyPresskPa.ToString()
			ws.Cell("I" & iRow).Value = _valve.DesignFlowLbs_Hr.ToString()
			ws.Cell("J" & iRow).Value = _valve.DesignFlow_KgHr.ToString()
			ws.Cell("K" & iRow).Value = _valve.DesignPressureDropPSI.ToString()
			ws.Cell("L" & iRow).Value = _valve.DesignPressureDropkPa.ToString()
			ws.Cell("M" & iRow).Value = _valve.ValveDropAtDesignFlowPSI.ToString()
			ws.Cell("N" & iRow).Value = _valve.ValveDropAtDesignFlowkPa.ToString()
			ws.Cell("O" & iRow).Value = _valve.SizeIn.ToString()
			ws.Cell("P" & iRow).Value = _valve.Cv.ToString()
			ws.Cell("Q" & iRow).Value = _valve.Conn.ToString()
			ws.Cell("R" & iRow).Value = _valve.BodyRating.ToString()
			ws.Cell("S" & iRow).Value = _valve.FlowCharacterstics.ToString()
			ws.Cell("T" & iRow).Value = _valve.ManufacturerType.ToString()
			ws.Cell("U" & iRow).Value = _valve.ValvePartNumber.ToString()
			ws.Cell("V" & iRow).Value = _valve.ActuatorPartNumber.ToString()
			ws.Cell("W" & iRow).Value = _valve.LinkagePartNumber.ToString()
			ws.Cell("X" & iRow).Value = _valve.ActuatorType.ToString()
			ws.Cell("Y" & iRow).Value = _valve.Signal.ToString()
			ws.Cell("Z" & iRow).Value = _valve.FailPos.ToString()
			ws.Cell("AA" & iRow).Value = _valve.CloseOff.ToString()
			ws.Cell("AB" & iRow).Value = _valve.Remarks.ToString()
			iRow += 1
		Next
		wbook.SaveAs(OutputFile)
		MessageBox.Show("Steam Schedules have been successfully saved!", "Schedules")

	End Sub

	Public Sub CreateSchedules()
		Dim iRow As Integer = 7

		Dim TemplateFile As String = Path.Combine(g_DocAccess.MasterDocumentsFolder, "Templates", "Valve_Schedules.xlsx")
		Dim OutputFile As String = Path.Combine(g_DocAccess.WorkingFolder, "Water_Schedules_Report.xlsx")

		Dim wbook = New XLWorkbook(TemplateFile)
		Dim ws = wbook.Worksheet(1)

		For Each _valve As Object In RootPart().Schedules(1).Water_Valves
			ws.Cell("B" & iRow).Value = _valve.ValveTag.ToString()
			ws.Cell("C" & iRow).Value = _valve.EquipmentLocation.ToString()
			ws.Cell("D" & iRow).Value = _valve.Service_Application.ToString()
			ws.Cell("E" & iRow).Value = _valve.ControlType.ToString()
			ws.Cell("F" & iRow).Value = _valve.LineSize.ToString()
			ws.Cell("G" & iRow).Value = _valve.DesignFlowGPM.ToString()





			ws.Cell("M" & iRow).Value = _valve.DesignPressureDropPSI.ToString()


			ws.Cell("Q" & iRow).Value = _valve.SizeIn.ToString()
			ws.Cell("R" & iRow).Value = _valve.Cv.ToString()
			ws.Cell("S" & iRow).Value = _valve.Pattern.ToString()
			ws.Cell("T" & iRow).Value = _valve.Conn.ToString()
			ws.Cell("U" & iRow).Value = _valve.BodyRating.ToString()
			ws.Cell("V" & iRow).Value = _valve.FlowCharacterstics.ToString()
			ws.Cell("W" & iRow).Value = _valve.ManufacturerType.ToString()
			ws.Cell("X" & iRow).Value = _valve.ValvePartNumber.ToString()
			ws.Cell("Y" & iRow).Value = _valve.ActuatorPartNumber.ToString()
			ws.Cell("Z" & iRow).Value = _valve.LinkagePartNumber.ToString()
			ws.Cell("AA" & iRow).Value = _valve.ActuatorType.ToString()
			ws.Cell("AB" & iRow).Value = _valve.Signal.ToString()
			ws.Cell("AC" & iRow).Value = _valve.FailPos.ToString()
			ws.Cell("AD" & iRow).Value = _valve.CloseOff.ToString()
			ws.Cell("AE" & iRow).Value = _valve.Remarks.ToString()

			iRow += 1
		Next
		wbook.SaveAs(OutputFile)
		'RootPart().Schedules(1).Properties("EnableExport").InputValue = True
		MessageBox.Show("Schedules have been successfully saved!", "Schedules")

	End Sub

	Public Function Schedule_Size_List(ManufacturerType As String, Pattern As String) As ArrayList
		Dim SQLToExecute As String = ""
		Dim ds As DataSet
		Dim arr As ArrayList = New ArrayList()
		Dim displayValue As String = ""

		SQLToExecute = "Select size  from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & ManufacturerType & "' AND Valve_Type_Ref = " & "'" & Pattern & "' Order By Valve_Data_Master_ID DESC"

		ds = g_ComponentData.ExecuteSQL(SQLToExecute)

		Try
			If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
				For Each dr As DataRow In ds.Tables(0).Rows
					If IsDBNull(dr.Item(0)) Then
						arr.Add(String.Empty)
					Else
						If dr.Item(0).ToString.Trim = "0.5" Then
							displayValue = "1/2"
						ElseIf dr.Item(0).ToString.Trim = "0.75" Then
							displayValue = "3/4"
						ElseIf dr.Item(0).ToString.Trim = "1.25" Then
							displayValue = "1 1/4"
						ElseIf dr.Item(0).ToString.Trim = "1.5" Then
							displayValue = "1 1/2"
						ElseIf dr.Item(0).ToString.Trim = "2.5" Then
							displayValue = "2 1/2"
						Else
							displayValue = dr.Item(0).ToString.Trim
						End If

						If Not arr.contains(displayValue) Then arr.Add(displayValue)
					End If
				Next
			Else
				Throw New Exception("[BodyRating] Unable to create valid values; no data was returned.")
			End If

		Catch ex As Exception
			g_ObjectManager.LogError("BodyRating", ex.ToString)
		End Try

		Return arr

	End Function

	Public Sub CreateExcelBOM()

        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim sh1XL, sh2XL, sh3XL As Excel.Worksheet
        Dim raXL As Excel.Range
        Dim iRow, moduleNo As Long
        Dim Plant_AI_AO_DI_DO As Integer = 0
        Dim Prev_Plant_AI_AO_DI_DO As Integer = 0
        Dim Group_Name As String = ""

        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True

        ' Add a new workbook.
        wbXl = appXL.Workbooks.Add
        sh1XL = wbXl.ActiveSheet

#Region "Plant Hierarchy sheet"
        ' Add a new worksheet.
        sh1XL = CType(wbXl.Sheets(1), Excel.Worksheet)
        sh1XL.name = "Plant Hierarchy"

        ' Add table headers going cell by cell.
        sh1XL.Cells(1, 1).Value = "Group"
        sh1XL.Cells(1, 2).Value = "Description"

        ' Format A1:D1 as bold, vertical alignment = center.
        With sh1XL.Range("A1", "B1")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .EntireColumn.AutoFit()
            .Borders.Weight = 2.0R
        End With

        iRow = 2
        For Each _plantView As Object In RootPart().PlantView
            For Each group As RuleStream.Kernel.Part In _plantView.Groups()
                Dim propGroupDisplayName As PropertySF = group.Properties("DisplayName")
                Dim propGroupDescription As PropertySF = group.Properties("ItemDescription")

                sh1XL.Cells(iRow, 1).Value = propGroupDisplayName.Value
                sh1XL.Cells(iRow, 2).Value = propGroupDescription.Value

                With sh1XL.Range("A" & iRow.ToString & ":B" & iRow.ToString)
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .EntireColumn.AutoFit()
                    .Borders.Weight = 2.0R
                End With

                iRow += 1
                For Each _connection As RuleStream.Kernel.Connection In group.Connections
                    If _connection.Name.ToUpper = "SYSTEMS" Then
                        For Each system As RuleStream.Kernel.Part In _connection.Parts
                            Dim propSystemDisplayName As PropertySF = system.Properties("SystemName")
                            Dim propSystemDescription As PropertySF = system.Properties("ItemDescription")

                            sh1XL.Cells(iRow, 1).Value = propSystemDisplayName.Value
                            sh1XL.Cells(iRow, 2).Value = propSystemDescription.Value

                            With sh1XL.Range("A" & iRow.ToString & ":B" & iRow.ToString)
                                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                .EntireColumn.AutoFit()
                                .Borders.Weight = 2.0R
                            End With

                            iRow += 1
                            For Each subPlant As RuleStream.Kernel.Subpart In system.Subparts
                                For Each plant As RuleStream.Kernel.Part In subPlant.Parts
                                    Dim propPlantDisplayName As PropertySF = plant.Properties("PlantName")
                                    Dim propPlantDescription As PropertySF = plant.Properties("ItemDescription")

                                    sh1XL.Cells(iRow, 1).Value = propPlantDisplayName.Value
                                    sh1XL.Cells(iRow, 2).Value = propPlantDescription.Value

                                    With sh1XL.Range("A" & iRow.ToString & ":B" & iRow.ToString)
                                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                        .EntireColumn.AutoFit()
                                        .Borders.Weight = 2.0R
                                    End With

                                    iRow += 1

                                Next
                            Next
                        Next
                    End If
                Next
            Next
        Next


#End Region '"Plant Hierarchy sheet"

#Region "Plant IO Point Summary sheet"
        sh2XL = CType(wbXl.Sheets.Add(), Excel.Worksheet)
        sh2XL.name = "Plant IO Point Summary"

        iRow = 1
        moduleNo = 1

        If iRow = 1 Then
            sh2XL.Cells(1, 9).Value = "BOM"
            sh2XL.Cells(2, 9).Value = "PART-NUMBER"
            sh2XL.Cells(2, 10).Value = "DEVICE TYPE"
            sh2XL.Cells(2, 11).Value = "PART SHAPE"
            sh2XL.Cells(2, 12).Value = "PART TYPE"


            With sh2XL.Range("I1:L1")
                .MergeCells = True
                .Font.Bold = True
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .EntireColumn.AutoFit()
                .Borders.Weight = 2.0R
            End With

            With sh2XL.Range("I2:L2")
                .Font.Bold = True
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .EntireColumn.AutoFit()
                .Borders.Weight = 2.0R
            End With
        End If

        For Each _plantView As Object In RootPart().PlantView
            For Each _group As RuleStream.Kernel.Part In _plantView.Groups()
                If _group.DisplayName <> "Group" Then
                    For Each _connection As RuleStream.Kernel.Connection In _group.Connections
                        If _connection.Name.ToUpper() = "ALLCONTROLLERS" Then
                            For Each _controller As RuleStream.Kernel.Part In _connection
                                Dim controllerName As PropertySF = _controller.Properties("PartNumber")
                                sh2XL.Cells(iRow, 1) = controllerName.Value

                                With sh2XL.Range("A" & iRow.ToString & ":G" & iRow.ToString)
                                    .MergeCells = True
                                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                    .EntireColumn.AutoFit()
                                    .Borders.Weight = 2.0R
                                End With

                                iRow += 1

                                sh2XL.Cells(iRow, 1).Value = "Module"
                                sh2XL.Cells(iRow, 2).Value = "IO#"
                                sh2XL.Cells(iRow, 3).Value = "Point Name#"
                                sh2XL.Cells(iRow, 4).Value = "Point Description"
                                sh2XL.Cells(iRow, 5).Value = "Signal Type"
                                sh2XL.Cells(iRow, 6).Value = "Signal Range"
                                sh2XL.Cells(iRow, 7).Value = "Power Supply"


                                With sh2XL.Range("A" & iRow.ToString & ":G" & iRow.ToString)
                                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                    .EntireColumn.AutoFit()
                                    .Borders.Weight = 2.0R
                                End With

                                iRow += 1

                                Dim iRowMergeStart As Long = iRow
                                sh2XL.Cells(iRow, 1) = "Module-1 " & controllerName.Value
                                For Each _deviceConn As RuleStream.Kernel.Connection In _controller.Connections
                                    If _deviceConn.Name.ToUpper() = "DEVICES" Then
                                        For Each _device As RuleStream.Kernel.Part In _deviceConn

                                            Dim propControllerPointNameAI As PropertySF = _device.Properties("ControllerPointNameAI")
                                            Dim propControllerPointNameAO As PropertySF = _device.Properties("ControllerPointNameAO")
                                            Dim propControllerPointNameDI As PropertySF = _device.Properties("ControllerPointNameDI")
                                            Dim propControllerPointNameDO As PropertySF = _device.Properties("ControllerPointNameDO")

                                            Dim propPointDescription As PropertySF = _device.Properties("PartType")
                                            Dim propSignalType As PropertySF = _device.Properties("SignalType")
                                            Dim propPowerSupply As PropertySF = _device.Properties("PowerSupply")

                                            Dim valSignalRange As String = "-40 to 250F"
                                            Dim valPointName As String = "Temp Point Name"

                                            If propControllerPointNameAI.Value <> "" Then
                                                sh2XL.Cells(iRow, 2).Value = propControllerPointNameAI.Value
                                                sh2XL.Cells(iRow, 3).Value = valPointName
                                                sh2XL.Cells(iRow, 4).Value = propPointDescription.Value
                                                sh2XL.Cells(iRow, 5).Value = propSignalType.Value
                                                sh2XL.Cells(iRow, 6).Value = valSignalRange
                                                sh2XL.Cells(iRow, 7).Value = propPowerSupply.Value


                                                With sh2XL.Range("A" & iRow.ToString & ":G" & iRow.ToString)
                                                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                                    .EntireColumn.AutoFit()
                                                    .Borders.Weight = 2.0R
                                                End With

                                                iRow += 1
                                            End If

                                            If propControllerPointNameAO.Value <> "" Then
                                                sh2XL.Cells(iRow, 2).Value = propControllerPointNameAO.Value
                                                sh2XL.Cells(iRow, 3).Value = valPointName
                                                sh2XL.Cells(iRow, 4).Value = propPointDescription.Value
                                                sh2XL.Cells(iRow, 5).Value = propSignalType.Value
                                                sh2XL.Cells(iRow, 6).Value = valSignalRange
                                                sh2XL.Cells(iRow, 7).Value = propPowerSupply.Value


                                                With sh2XL.Range("A" & iRow.ToString & ":G" & iRow.ToString)
                                                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                                    .EntireColumn.AutoFit()
                                                    .Borders.Weight = 2.0R
                                                End With

                                                iRow += 1
                                            End If

                                            If propControllerPointNameDI.Value <> "" Then
                                                sh2XL.Cells(iRow, 2).Value = propControllerPointNameDI.Value
                                                sh2XL.Cells(iRow, 3).Value = valPointName
                                                sh2XL.Cells(iRow, 4).Value = propPointDescription.Value
                                                sh2XL.Cells(iRow, 5).Value = propSignalType.Value
                                                sh2XL.Cells(iRow, 6).Value = valSignalRange
                                                sh2XL.Cells(iRow, 7).Value = propPowerSupply.Value


                                                With sh2XL.Range("A" & iRow.ToString & ":G" & iRow.ToString)
                                                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                                    .EntireColumn.AutoFit()
                                                    .Borders.Weight = 2.0R
                                                End With

                                                iRow += 1
                                            End If

                                            If propControllerPointNameDO.Value <> "" Then
                                                sh2XL.Cells(iRow, 2).Value = propControllerPointNameDO.Value
                                                sh2XL.Cells(iRow, 3).Value = valPointName
                                                sh2XL.Cells(iRow, 4).Value = propPointDescription.Value
                                                sh2XL.Cells(iRow, 5).Value = propSignalType.Value
                                                sh2XL.Cells(iRow, 6).Value = valSignalRange
                                                sh2XL.Cells(iRow, 7).Value = propPowerSupply.Value


                                                With sh2XL.Range("A" & iRow.ToString & ":G" & iRow.ToString)
                                                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                                    .EntireColumn.AutoFit()
                                                    .Borders.Weight = 2.0R
                                                End With

                                                iRow += 1
                                            End If

                                        Next
                                    End If
                                Next

                                With sh2XL.Range("A" & iRowMergeStart.ToString & ":A" & (iRow - 1).ToString)
                                    .MergeCells = True
                                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                    .EntireColumn.AutoFit()
                                    .Borders.Weight = 2.0R
                                End With

                                iRow += 2

                            Next
                        End If
                    Next
                End If

            Next
        Next



        iRow = 3
        For Each _plantView As Object In RootPart().PlantView
            For Each group As RuleStream.Kernel.Part In _plantView.Groups()
                For Each connection As RuleStream.Kernel.Connection In group.Connections
                    If connection.Name.ToUpper() = "ALLPLANTS" Then
                        For Each plant As RuleStream.Kernel.Part In connection
                            For Each subpart As RuleStream.Kernel.Subpart In plant.Subparts
                                If subpart.Name.ToUpper() = "DEVICES" Then
                                    For Each device As RuleStream.Kernel.Part In subpart.Parts
                                        Dim propDeviceParNum As PropertySF = device.Properties("DevicePartNumber")
                                        Dim propDeviceType As PropertySF = device.Properties("DeviceType")
                                        Dim propPartShape As PropertySF = device.Properties("PartShape")
                                        Dim propPartType As PropertySF = device.Properties("PartType")

                                        sh2XL.Cells(iRow, 9).Value = propDeviceParNum.Value
                                        sh2XL.Cells(iRow, 10).Value = propDeviceType.Value
                                        sh2XL.Cells(iRow, 11).Value = propPartShape.Value
                                        sh2XL.Cells(iRow, 12).Value = propPartType.Value

                                        With sh2XL.Range("I" & iRow.ToString & ":L" & iRow.ToString)
                                            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                            .EntireColumn.AutoFit()
                                            .Borders.Weight = 2.0R
                                        End With

                                        iRow += 1
                                    Next
                                End If
                            Next
                        Next
                    End If
                Next
            Next
        Next


#End Region '"Plant IO Point Summary sheet"

#Region "Sequence of Operation sheet"
        ' Add a new worksheet.
        sh3XL = CType(wbXl.Sheets.Add(), Excel.Worksheet)
        sh3XL.name = "Sequence Of Operation"

        ' Add table headers going cell by cell.
        sh3XL.Cells(1, 1).Value = "Sequence of Operation"

        ' Format A1:D1 as bold, vertical alignment = center.
        With sh3XL.Range("A1", "A1")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .EntireColumn.AutoFit()
            .Borders.Weight = 2.0R
        End With

        iRow = 2
        For Each _plantView As Object In RootPart().PlantView
            For Each group As RuleStream.Kernel.Part In _plantView.Groups()
                For Each connection As RuleStream.Kernel.Connection In group.Connections
                    If connection.Name.ToUpper() = "ALLPLANTS" Then
                        For Each plant As RuleStream.Kernel.Part In connection
                            For Each subpart As RuleStream.Kernel.Subpart In plant.Subparts
                                If subpart.Name.ToUpper() = "DEVICES" Then
                                    For Each device As RuleStream.Kernel.Part In subpart.Parts
                                        Dim propSOO As PropertySF = device.Properties("SequenceText")

                                        If propSOO.Value <> "" Then
                                            sh3XL.Cells(iRow, 1).Value = propSOO.Value

                                            With sh3XL.Range("A" & iRow.ToString & ":A" & iRow.ToString)
                                                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                                                .EntireColumn.AutoFit()
                                                .Borders.Weight = 2.0R
                                            End With

                                            iRow += 1
                                        End If

                                    Next
                                End If
                            Next
                        Next
                    End If
                Next
            Next
        Next

#End Region '"Sequence of Operation  sheet"

        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.
        appXL.Visible = True
        appXL.UserControl = True

        ' Release object references.
        raXL = Nothing
        sh1XL = Nothing
        wbXl = Nothing
        appXL.Quit()
        appXL = Nothing
        Exit Sub
Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)

    End Sub


    Public Sub CreateExcelPlantBlocks()

        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim sheet As Excel.Worksheet
        Dim iRow, iCol, plantNum As Long

        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True

        ' Add a new workbook.
        wbXl = appXL.Workbooks.Add

        iRow = 1
        plantNum = 1

        For Each _group As Rulestream.Kernel.Part In RootPart().PlantView(1).Groups()

            For Each _connPlants As Rulestream.Kernel.Connection In _group.Connections

                If _connPlants.Name.ToUpper() = "ALLPLANTS" Then

                    For Each _plant As Rulestream.Kernel.Part In _connPlants

                        iCol = 1

                        If plantNum = 1 Then
                            sheet = wbXl.ActiveSheet
                        Else
                            sheet = CType(wbXl.Sheets.Add(), Excel.Worksheet)
                        End If


                        Dim propPlantName As PropertySF = _plant.Properties("PlantName")
                        sheet.name = propPlantName.Value


                        For Each _devicesSubPart As Rulestream.Kernel.Subpart In _plant.Subparts

                            iRow = 1

                            If _devicesSubPart.Name.ToUpper() = "DEVICES" Then

                                For Each _device As Rulestream.Kernel.Part In _devicesSubPart

                                    iCol = 1

                                    If iRow = 1 Then

                                        For Each _prop As PropertySF In _device.Properties

                                            If Not _prop.Name.ToUpper().Contains("VALIDVALUES") AndAlso Not _prop.Name.ToUpper().Contains("SYMBOLIMAGEPATH") Then
                                                sheet.Cells(iRow, iCol).Value = _prop.Name

                                                If _prop.Value.ToString() <> "" Then
                                                    sheet.Cells(iRow + 1, iCol).Value = _prop.Value.ToString()
                                                End If

                                                iCol += 1
                                            End If

                                        Next

                                        iRow += 2

                                    Else

                                        For Each _prop As PropertySF In _device.Properties

                                            If Not _prop.Name.ToUpper().Contains("VALIDVALUES") AndAlso Not _prop.Name.ToUpper().Contains("SYMBOLIMAGEPATH") Then
                                                If _prop.Value.ToString() <> "" Then
                                                    sheet.Cells(iRow, iCol).Value = _prop.Value.ToString()
                                                End If

                                                iCol += 1
                                            End If

                                        Next

                                        iRow += 1

                                    End If

                                Next

                            End If

                        Next

                        plantNum += 1
                        sheet = Nothing

                    Next

                End If

            Next


        Next

        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.
        appXL.Visible = True
        appXL.UserControl = True

        ' Release object references.
        wbXl = Nothing
        appXL.Quit()
        appXL = Nothing
        Exit Sub
Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)

    End Sub


    Friend Sub CollectTreeItems(_rsObjects As rsCollection, _group As Object, _system As Object)
        If _group IsNot Nothing Then
            _rsObjects.Add(_group)

            If _group.Selected Then
                For Each _subSystem As Object In _group.Systems
                    CollectTreeItems(_rsObjects, Nothing, _subSystem)
                Next

                For Each _child As Object In _group.PlantViewNodes
                    If _child.PartFamily = "Group" Then
                        _rsObjects.Add(_child)

                        If _child.Selected Then CollectTreeItems(_rsObjects, _child, Nothing)
                    End If
                Next
            End If
        ElseIf _system IsNot Nothing Then
            _rsObjects.Add(_system)

            If _system.Selected Then
                For Each _plant As Object In _system.Plants
                    _rsObjects.Add(_plant)
                Next
            End If
        End If
    End Sub

    Friend Sub CollectSystems(_rsObjects As rsCollection, _group As Object)
        If _group IsNot Nothing Then
            For Each _subSystem As Object In _group.Systems
                _rsObjects.Add(_subSystem)
            Next

            For Each _child As Object In _group.PlantViewNodes
                If _child.PartFamily = "Group" Then CollectSystems(_rsObjects, _child)
            Next
        End If
    End Sub

    Friend Sub CollectPlants(_rsObjects As rsCollection, _system As Object)
        If _system IsNot Nothing Then
            For Each _plant As Object In _system.Plants
                _rsObjects.Add(_plant)
            Next
        End If
    End Sub

    Friend Sub DeleteGroup(_group As Object)
        For Each _system As Object In _group.Systems
            _system.Owner.Remove(_system.Name)
        Next

        For Each _child As Object In _group.PlantViewNodes
            If _child.PartFamily = "Group" Then DeleteGroup(_child)
        Next

        _group.Owner.Remove(_group.Name)
    End Sub

#End Region '"Utilities"


    'Do not Change or Delete The Line Below (End Module) --- [DELETEONCOMPILE]
End Module