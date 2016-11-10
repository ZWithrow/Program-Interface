Public Class Arrigo

    Private Sub Arrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set the colors of the labels
        newSpecimenLabel.BackColor = Color.LightGray
        dimensionsLabel.BackColor = Color.LightGray
        materialLabel.BackColor = Color.LightGray
        MaxTempLabel.BackColor = Color.LightGray
        weightLabel.BackColor = Color.LightGray
        notesLabel.BackColor = Color.LightGray

        ' set what can be seen upon initialization
        Label18.Hide()
        backNexSpecButton.Hide()
        submitNewSpecButton.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles newSpecNextButton.Click
        newSpecimenLabel.Hide()
        Label18.Show()
        backNexSpecButton.Show()
        submitNewSpecButton.Show()
    End Sub

    Private Sub backNexSpecButton_Click(sender As Object, e As EventArgs) Handles backNexSpecButton.Click
        newSpecimenLabel.Show()
        backNexSpecButton.Hide()
        submitNewSpecButton.Hide()

    End Sub
End Class