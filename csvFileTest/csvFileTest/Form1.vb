
Imports Microsoft.VisualBasic.FileIO
Public Class Form1
    Private Sub CreateCSVfile(ByVal _strCustomerCSVPath As String, ByVal nameTextBox1 As String, ByVal IDTextBox1 As String, ByVal msgTextBox1 As String)
        Try
            Dim stLine As String = ""
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(_strCustomerCSVPath)
            If IO.File.Exists(_strCustomerCSVPath) Then
                objWriter.Write(nameTextBox1 & ",")
                objWriter.Write(IDTextBox1 & ",")
                objWriter.Write(msgTextBox1 & ",")

                'If value contains comma in the value then you have to perform this opertions
                Dim append = If(msgTextBox1.Contains(","), String.Format("""{0}""", msgTextBox1), msgTextBox1)
                stLine = String.Format("{0}{1},", stLine, append)
                objWriter.Write(stLine)
                objWriter.Write(Environment.NewLine)
            End If
            objWriter.Close()
            ClearTextbox()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub ClearTextbox()
        nameTextBox1.Text = ""
        IDTextBox1.Text = ""
        msgTextBox1.Text = ""

    End Sub

    Dim lPath = IO.Path.GetFullPath(String.Format("{0}\..\..", Application.StartupPath))



    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        CreateCSVfile(lPath & "/Data" & "/" & "CustomerRecords.csv", nameTextBox1.Text.ToString(), IDTextBox1.Text.ToString(), msgTextBox1.Text.ToString())

    End Sub


    Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
        Form2.Show()
    End Sub
End Class
