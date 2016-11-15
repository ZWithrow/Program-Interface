Public Class Arrigo
    Dim pageCounter As Integer = 1

    Private Sub Arrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set the colors of the labels
        newSpecimenLabel.BackColor = Color.LightGray
        dimensionsLabel.BackColor = Color.LightGray
        materialLabel.BackColor = Color.LightGray
        MaxTempLabel.BackColor = Color.LightGray
        weightLabel.BackColor = Color.LightGray
        Label18.BackColor = Color.Aqua

        ' set what can and cannot be seen upon initialization
        Label18.Hide()
        backNexSpecButton.Hide()
        submitNewSpecButton.Hide()

        ' variable for keeping track of button clicks





    End Sub

    Private Sub ShowPage()
        Select Case pageCounter
            Case 1
                newSpecimenLabel.Show()
                dimensionsLabel.Show()
                materialLabel.Show()
                MaxTempLabel.Show()
                weightLabel.Show()
                Label18.Hide()
                backNexSpecButton.Hide()
                submitNewSpecButton.Hide()
                newSpecNextButton.Show()
            Case 2
                newSpecimenLabel.Hide()
                Label18.Show()
                backNexSpecButton.Show()
                newSpecNextButton.Show()
                submitNewSpecButton.Hide()
            Case 3
                submitNewSpecButton.Show()
        End Select

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles newSpecNextButton.Click
        pageCounter += 1


        ShowPage()





    End Sub

    Private Sub backNexSpecButton_Click(sender As Object, e As EventArgs) Handles backNexSpecButton.Click
        pageCounter -= 1
        ShowPage()

    End Sub




End Class