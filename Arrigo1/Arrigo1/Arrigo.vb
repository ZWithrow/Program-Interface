Public Class Arrigo
    Dim pageCounter As Integer = 1

    Private Sub Arrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set the colors of the labels
        newSpecimenLabel.BackColor = Color.LightGray
        dimensionsLabel.BackColor = Color.LightGray
        materialLabel.BackColor = Color.LightGray
        MaxTempLabel.BackColor = Color.LightGray
        weightLabel.BackColor = Color.LightGray

        ' set what can and cannot be seen upon initialization
        backNexSpecButton.Hide()
        submitNewSpecButton.Hide()
        priorTestNotesLabel.Hide()
        priorTestNotesTextBox.Hide()
        postMaxTempIntegerInput.Hide()
        postTestMaxTempLabel.Hide()
        priorTestLabel.Hide()
        roomAirLabel.Hide()







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
                newSpecNextButton.Show()

                'hidden on page 1
                backNexSpecButton.Hide()
                submitNewSpecButton.Hide()
                priorTestNotesLabel.Hide()
                priorTestNotesTextBox.Hide()
                postTestMaxTempLabel.Hide()
                postMaxTempIntegerInput.Hide()
                postTestMaxTempLabel.Hide()
                priorTestLabel.Hide()
                roomAirLabel.Hide()







            Case 2
                'shown page2

                backNexSpecButton.Show()
                newSpecNextButton.Show()
                priorTestNotesTextBox.Show()
                priorTestNotesLabel.Show()
                postTestMaxTempLabel.Show()
                postMaxTempIntegerInput.Show()
                postTestMaxTempLabel.Show()
                priorTestLabel.Show()
                roomAirLabel.Show()





                'hidden page 2
                newSpecimenLabel.Hide()
                specimenNameLabel.Hide()
                dimensionsLabel.Hide()
                materialLabel.Hide()
                materialTextBox.Hide()
                MaxTempIntegerInput1.Hide()
                MaxTempLabel.Hide()
                weightLabel.Hide()
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
                submitNewSpecButton.Hide()
                specimenNameIntegerInput.Hide()



            Case 3
                'Shown on page 3
                submitNewSpecButton.Show()
                backNexSpecButton.Show()
                'Hidden on page 3
                submitNewSpecButton.Hide()
                priorTestNotesLabel.Hide()
                priorTestNotesTextBox.Hide()
                postTestMaxTempLabel.Hide()
                postMaxTempIntegerInput.Hide()
                postTestMaxTempLabel.Hide()
                newSpecimenLabel.Hide()
                specimenNameLabel.Hide()
                dimensionsLabel.Hide()
                materialLabel.Hide()
                materialTextBox.Hide()
                MaxTempIntegerInput1.Hide()
                MaxTempLabel.Hide()
                weightLabel.Hide()
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
                submitNewSpecButton.Hide()
                specimenNameIntegerInput.Hide()

            Case Else




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