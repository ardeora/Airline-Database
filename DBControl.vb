Imports System.Data.OleDb
Public Class DBControl
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=DummyData.accdb;")
    Private DBCmd As OleDbCommand

    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    Public Params As New List(Of OleDbParameter)
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()
            DBCmd = New OleDbCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))


            Params.Clear()

            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class
