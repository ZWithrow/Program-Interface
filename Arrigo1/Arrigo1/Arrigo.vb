Public Class Arrigo

    Private Sub Arrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newSpecimenLabel.BackColor = Color.LightGray
        dimensionsLabel.BackColor = Color.LightGray
        materialLabel.BackColor = Color.LightGray
        MaxTempLabel.BackColor = Color.LightGray
        weightLabel.BackColor = Color.LightGray


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles newSpecNextButton.Click
        newSpecimenLabel.Hide()
    End Sub
End Class