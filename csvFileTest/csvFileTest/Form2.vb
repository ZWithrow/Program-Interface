
Imports System.IO
    Imports System.String
    Imports System.Net
    Imports System.Data.OleDb
    Public Class Form2
        Public CustomerInfo = New DataTable("CustomerInfo")
        Private Sub Read_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CustomerInfo = GetCsvData(Application.StartupPath, "CustomerRecords.csv")
            Bind_Grid_CustomerInfo(CustomerInfo)
        End Sub
        Public Sub Bind_Grid_CustomerInfo(ByVal DT As DataTable)
        Try

            CustomerInfo.DataSource = DT
            CustomerInfo.Refresh()
        Catch ex As Exception
        End Try
        End Sub

        Public Function GetCsvData(ByVal strFolderPath As String, ByVal strFileName As String) As DataTable
        Try
            'CharacterSet=65001 will needed for UTF-8 settings
            Dim strConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strFolderPath & ";Extended Properties='text;HDR=Yes;FMT=Delimited;CharacterSet=65001;'"
            Dim conn As New OleDbConnection(strConnString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT * FROM [" & strFileName & "]", conn)
                Dim da As New OleDbDataAdapter()

                da.SelectCommand = cmd
                Dim ds As New DataSet()

                da.Fill(ds)
                da.Dispose()
                Return ds.Tables(0)
            Catch ex As Exception

            Finally
                conn.Close()
            End Try
        Catch ex As Exception
        End Try
        Return Nothing
    End Function


    Private Sub closeButton1_Click(sender As Object, e As EventArgs) Handles closeButton1.Click
        Me.Close()
        Me.Dispose()
        Form1.Show()
    End Sub
End Class
