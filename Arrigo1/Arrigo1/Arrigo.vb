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
                ' what a appears on page 1
                newSpecimenLabel.Show()
                specimenNameLabel.Show()
                dimensionsLabel.Show()
                materialLabel.Show()
                materialTextBox.Show()
                MaxTempIntegerInput1.Show()
                MaxTempLabel.Show()
                weightLabel.Show()
                FarenDegreeCheck.Show()
                CelsiusDegreeCheck.Show()
                KelvinDegreeCheck.Show()
                lengthLabel.Show()
                lengthDoubleInput1.Show()
                heightDoubleInput1.Show()
                heightLabel1.Show()
                widthLabel.Show()
                widthDoubleInput2.Show()
                mmLabel.Show()
                Label1.Show()
                Label2.Show()
                compoundShapeLabel.Show()
                compoundShapeDoubleInput1.Show()
                parallelLabel.Show()
                parallelSwitchButton1.Show()
                crossSectionLabel.Show()
                crossSectionSwitchButton.Show()
                weightIntegerInput2.Show()
                gramsLabel.Show()
                notesLabel.Show()
                roomTempLabel.Show()
                roomTempIntegerInput.Show()
                roomTempFCheckBox.Show()
                roomTempCCheckBox.Show()
                roomTempKCheckBox.Show()
                newSpecNextButton.Show()

                'hidden on page 1
                Label18.Hide()
                backNexSpecButton.Hide()
                submitNewSpecButton.Hide()
                priorTestNotesLabel.Hide()
                priorTestNotesTextBox.Hide()

            Case 2
                'shown page2

                Label18.Show()
                backNexSpecButton.Show()
                newSpecNextButton.Show()
                priorTestNotesTextBox.Show()
                priorTestNotesLabel.Show()





                'hidden page 2
                newSpecimenLabel.Hide()
                specimenNameLabel.Hide()
                dimensionsLabel.Hide()
                materialLabel.Hide()
                materialTextBox.Hide()
                MaxTempIntegerInput1.Hide()
                MaxTempLabel.Hide()
                weightLabel.Hide()
                FarenDegreeCheck.Hide()
                CelsiusDegreeCheck.Hide()
                KelvinDegreeCheck.Hide()
                lengthLabel.Hide()
                lengthDoubleInput1.Hide()
                heightLabel1.Hide()
                heightDoubleInput1.Hide()
                widthLabel.Hide()
                widthDoubleInput2.Hide()
                mmLabel.Hide()
                Label1.Hide()
                Label2.Hide()
                compoundShapeLabel.Hide()
                compoundShapeDoubleInput1.Hide()
                parallelLabel.Hide()
                parallelSwitchButton1.Hide()
                crossSectionLabel.Hide()
                crossSectionSwitchButton.Hide()
                weightIntegerInput2.Hide()
                gramsLabel.Hide()
                notesLabel.Hide()
                roomTempLabel.Hide()
                roomTempIntegerInput.Hide()
                roomTempFCheckBox.Hide()
                roomTempCCheckBox.Hide()
                roomTempKCheckBox.Hide()
                submitNewSpecButton.Hide()
                specimenNameIntegerInput.Hide()



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