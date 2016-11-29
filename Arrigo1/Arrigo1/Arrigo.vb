Public Class Arrigo
    ' variable for keeping track of button clicks
    Dim pageCounter As Integer = 1
    Dim heatPageCounter As Integer = 1


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
        uniformTempIntervalsLabel.BackColor = Color.LightGray
        autofillSchedLabel.BackColor = Color.LightGreen
        newHeatSchedLabel.BackColor = Color.LightGray
        newSpecProgressBar.BackColor = Color.LightGray
        newSpecHomeButton.BackColor = Color.LightGray
        NewHeatHomeButton.BackColor = Color.LightGray
        retestHomeButton.BackColor = Color.LightGray
        savedTestHomeButton.BackColor = Color.LightGray
        savedSpecHomeButton.BackColor = Color.LightGray
        notesLabel.BackColor = Color.LightGray
        newSpecNextButton.BackColor = Color.LightGray
        backNexSpecButton.BackColor = Color.LightGray
        submitNewSpecButton.BackColor = Color.LightGray
        savedTestListlabel.BackColor = Color.LightGray
        createNewTestLabel.BackColor = Color.LightGray
        createNewSpecLabel.BackColor = Color.LightGray
        savedSpecListLabel.BackColor = Color.LightGray
        selectSpecLabel.BackColor = Color.LightGray
        createHeatTestLabel.BackColor = Color.LightGray
        selectheatTestLabel.BackColor = Color.LightGray
        createNewSpec_retestLabel.BackColor = Color.LightGray








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
        newpageTestLabel.Hide()
        newHeatBackLabel.Hide()



    End Sub
    Private Sub HeatShowPage() 'this case switch is for the New Heating Schedule Tab
        Select Case heatPageCounter
            Case 1
                ' what should appear on page 1
                heatingScheduleLabel.Show()
                heatScheduleDefaultNameNum.Show()
                optHeatingScheduleNameLabel.Show()
                optHeatingScheduleTextBox.Show()
                elevatedTempTestLabel.Show()
                maxElevTempLabel.Show()
                TextBox2.Show()
                ' what should be hidden on page 1
                newpageTestLabel.Hide()
                newHeatBackLabel.Hide()
                newHeatSchedTestLabel.Show()

            Case 2
                heatingScheduleLabel.Hide()
                heatScheduleDefaultNameNum.Hide()
                optHeatingScheduleNameLabel.Hide()
                optHeatingScheduleTextBox.Hide()
                elevatedTempTestLabel.Hide()
                maxElevTempLabel.Hide()
                TextBox2.Hide()

                newpageTestLabel.Show()
                newHeatSchedTestLabel.Hide()
                newHeatBackLabel.Show()

            Case Else
                heatPageCounter = 3

        End Select
    End Sub
    Private Sub ShowPage() 'this case switch is for the New Specimen Tab
        Select Case pageCounter
            Case 1
                ' what a appears on page 1
                newSpecimenLabel.Show()
                specimenNameLabel.Show()
                materialLabel.Show()
                materialTextBox.Show()
                MaxTempIntegerInput1.Show()
                MaxTempLabel.Show()
                specimenNameIntegerInput.Show()
                dimensionsLabel.Show()
                lengthLabel.Show()
                lengthDoubleInput1.Show()
                mmLabel.Show()
                widthLabel.Show()
                widthDoubleInput2.Show()
                Label1.Show()
                heightLabel1.Show()
                heightDoubleInput1.Show()
                Label2.Show()
                compoundShapeLabel.Show()
                compoundShapeDoubleInput1.Show()
                parallelLabel.Show()
                parallelSwitchButton1.Show()
                weightLabel.Show()
                weightIntegerInput2.Show()
                pretestWeightLabel.Show()
                gramsLabel.Show()
                notesLabel.Show()
                roomTempLabel.Show()
                roomTempIntegerInput.Show()
                crossSectionLabel.Show()
                crossSectionSwitchButton.Show()

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
                saveLabel.Hide()
                saveAddLabel.Hide()
                submitNewSpecButton.Hide()




            Case 3
                'Shown on page 3
                submitNewSpecButton.Show()
                backNexSpecButton.Show()
                saveLabel.Show()
                saveAddLabel.Show()

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
                pageCounter = 3
                ShowPage()

        End Select

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles newSpecNextButton.Click
        pageCounter += 1
        ShowPage()
        newSpecProgressBar.PerformStep()

    End Sub

    Private Sub backNexSpecButton_Click(sender As Object, e As EventArgs) Handles backNexSpecButton.Click
        pageCounter -= 1
        ShowPage()
        newSpecProgressBar.Value -= 10

    End Sub

    Private Sub submitNewSpecButton_Click(sender As Object, e As EventArgs) Handles submitNewSpecButton.Click
        NewHeatingScheduleSideNav.Select()


    End Sub

    Private Sub newHeatSchedTestLabel_Click(sender As Object, e As EventArgs) Handles newHeatSchedTestLabel.Click
        heatPageCounter += 1
        HeatShowPage()

    End Sub

    Private Sub newHeatBackLabel_Click(sender As Object, e As EventArgs) Handles newHeatBackLabel.Click
        heatPageCounter -= 1
        HeatShowPage()

    End Sub

    Private Sub SideNavItem2_Click(sender As Object, e As EventArgs) Handles SideNavItem2.Click
        NewHeatHomeButton.Show()
        newSpecHomeButton.Show()

    End Sub

    Private Sub newSpecHomeButton_Click(sender As Object, e As EventArgs) Handles newSpecHomeButton.Click
        NewSpecimensiSideNav.Select()

    End Sub

    Private Sub NewHeatHomeButton_Click(sender As Object, e As EventArgs) Handles NewHeatHomeButton.Click
        NewHeatingScheduleSideNav.Select()

    End Sub

    Private Sub retestHomeButton_Click(sender As Object, e As EventArgs) Handles retestHomeButton.Click
        RetestSideNav.Select()
    End Sub

    Private Sub savedTestHomeButton_Click(sender As Object, e As EventArgs) Handles savedTestHomeButton.Click
        savedTestSideNav.Select()

    End Sub

    Private Sub savedSpecHomeButton_Click(sender As Object, e As EventArgs) Handles savedSpecHomeButton.Click
        savedSpecSideNav.Select()

    End Sub

    Private Sub createNewTestLabel_Click(sender As Object, e As EventArgs) Handles createNewTestLabel.Click
        NewHeatingScheduleSideNav.Select()

    End Sub

    Private Sub createNewSpecLabel_Click(sender As Object, e As EventArgs) Handles createNewSpecLabel.Click
        NewSpecimensiSideNav.Select()

    End Sub

    Private Sub createNewSpec_retestLabel_Click(sender As Object, e As EventArgs) Handles createNewSpec_retestLabel.Click
        NewSpecimensiSideNav.Select()

    End Sub

    Private Sub createHeatTestLabel_Click(sender As Object, e As EventArgs) Handles createHeatTestLabel.Click
        NewHeatingScheduleSideNav.Select()

    End Sub
End Class