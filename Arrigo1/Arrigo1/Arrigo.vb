Public Class Arrigo
    ' variable for keeping track of button clicks
    Dim pageCounter As Integer = 1

    Private Sub Arrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set the colors of the labels
        newSpecimenLabel.BackColor = Color.LightGray
        dimensionsLabel.BackColor = Color.LightGray
        materialLabel.BackColor = Color.LightGray
        MaxTempLabel.BackColor = Color.LightGray
        weightLabel.BackColor = Color.LightGray
        priorTestNotesLabel.BackColor = Color.LightGray
        priorTestLabel.BackColor = Color.Bisque
        roomAirLabel.BackColor = Color.Bisque
        postTestMaxTempLabel.BackColor = Color.LightGray
        saveLabel.BackColor = Color.LightGreen
        saveAddLabel.BackColor = Color.LightGreen
        heatingScheduleLabel.BackColor = Color.LightGray
        optHeatingScheduleNameLabel.BackColor = Color.LightGray


        ' set what can and cannot be seen upon initialization
        backNexSpecButton.Hide()
        submitNewSpecButton.Hide()
        priorTestNotesLabel.Hide()
        priorTestNotesTextBox.Hide()
        postMaxTempIntegerInput.Hide()
        postTestMaxTempLabel.Hide()
        priorTestLabel.Hide()
        roomAirLabel.Hide()
        dryAirLabel.Hide()
        otherLabel.Hide()
        observeLabel.Hide()
        roomAirTextBox.Hide()
        dryAirTextBox.Hide()
        otherTextBox.Hide()
        observeTextBoxX.Hide()
        saveLabel.Hide()
        saveAddLabel.Hide()

    End Sub

    Private Sub ShowPage()
        Select Case pageCounter
            Case 1
                ' what a appears on page 1


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
                dryAirLabel.Hide()
                otherLabel.Hide()
                observeLabel.Hide()
                roomAirTextBox.Hide()
                dryAirTextBox.Hide()
                otherTextBox.Hide()
                observeTextBoxX.Hide()
                saveLabel.Hide()
                saveAddLabel.Hide()






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
                dryAirLabel.Show()
                otherLabel.Show()
                observeLabel.Show()
                roomAirTextBox.Show()
                dryAirTextBox.Show()
                otherTextBox.Show()
                observeTextBoxX.Show()
                saveLabel.Show()
                saveAddLabel.Show()





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
                pretestWeightLabel.Hide()



            Case 3
                'Shown on page 3
                submitNewSpecButton.Show()
                backNexSpecButton.Show()
                'Hidden on page 3

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
                specimenNameIntegerInput.Hide()
                pretestWeightLabel.Hide()
                observeLabel.Hide()
                observeTextBoxX.Hide()
                roomAirTextBox.Hide()
                roomAirLabel.Hide()
                dryAirTextBox.Hide()
                dryAirLabel.Hide()
                otherTextBox.Hide()
                otherLabel.Hide()
                priorTestLabel.Hide()


            Case Else

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
                specimenNameIntegerInput.Hide()
                pretestWeightLabel.Hide()
                observeLabel.Hide()
                observeTextBoxX.Hide()
                roomAirTextBox.Hide()
                roomAirLabel.Hide()
                dryAirTextBox.Hide()
                dryAirLabel.Hide()
                otherTextBox.Hide()
                otherLabel.Hide()
                priorTestLabel.Hide()



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

    Private Sub submitNewSpecButton_Click(sender As Object, e As EventArgs) Handles submitNewSpecButton.Click






    End Sub
End Class