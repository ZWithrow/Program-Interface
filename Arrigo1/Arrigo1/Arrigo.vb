Public Class Arrigo
    ' variable for keeping track of button clicks
    Dim pageCounter As Integer = 1
    Dim heatPageCounter As Integer = 1

    '  FolderBrowserDialog1.ShowDialog()
    '  FileLocation = FolderBrowserDialog1.SelectedPath
    '  If Write = True Then

    ' Dim FileName As String = ""
    'FileName = FileLocation + "\" + CurrentDateAndTime.Year.ToString _
    '        + "_" + CurrentDateAndTime.Month.ToString _
    '        + "_" + CurrentDateAndTime.Day.ToString _
    '        + "_" + CurrentDateAndTime.Hour.ToString _
    '        + "_" + CurrentDateAndTime.Minute.ToString _
    '       + "_" + CurrentDateAndTime.Second.ToString + "_PIDTest.csv"
    ' Dim RowsLeft As Integer = DaqData.Rows.Count
    '  TextBoxX2.Text = "Rows left to Write: " + RowsLeft.ToString
    '  TextBoxX2.Update()
    ' My.Computer.FileSystem.WriteAllText(FileName, "Time (s), Outside Temp (C), Inside Temp (C)" + vbCrLf, False)
    ' Dim i As Integer = 0
    ' While i < DaqData.Rows.Count - 1
    ' My.Computer.FileSystem.WriteAllText(FileName, Time(i).ToString + "," + PIDArray1(i).ToString + "," + DaqArray1(i).ToString + vbCrLf, True)
    ' i += 1
    ' RowsLeft -= 1
    '  TextBoxX2.Text = "Rows left to Write: " + RowsLeft.ToString
    'TextBoxX2.Update()

    ' End While
    'End If


    Private Sub Arrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set the colors of the labels
        newSpecimenLabel.BackColor = Color.LightGray
        dimensionsLabel.BackColor = Color.LightGray
        materialLabel.BackColor = Color.LightGray
        externalDesignLabel.BackColor = Color.LightGray
        weightLabel.BackColor = Color.LightGray
        priorTestNotesLabel.BackColor = Color.LightGray
        priorTestLabel.BackColor = Color.Bisque
        roomAirLabel.BackColor = Color.Bisque
        postTestObserveLabel.BackColor = Color.LightGray
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
        postDimLabel.BackColor = Color.LightGray



        ' set what can and cannot be seen upon initialization
        backNexSpecButton.Hide()
        submitNewSpecButton.Hide()
        priorTestNotesTextBox.Hide()
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
                externalDesignLabel.Show()
                externalDesignationIntegerInput2.Show()
                externalDesignationIntegerInput1.Show()
                Label6.Show()
                Label5.Show()
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
                cylinderLabel.Show()
                cylLengthLabel.Show()
                cylLengthDoubleInput.Show()
                Label7.Show()
                cylDiameterLabel.Show()
                cylDiameterDoubleInput.Show()
                Label9.Show()
                compoundShapeLabel.Show()
                parallelLabel.Show()
                parallelSwitchButton1.Show()
                weightLabel.Show()
                weightIntegerInput2.Show()
                pretestWeightLabel.Show()
                crossSectionLabel.Show()
                crossSectionSwitchButton.Show()

                roomAirLabel.Show()
                dryAirLabel.Show()
                priorTestLabel.Show()
                postTestObserveLabel.Show()
                priorTestNotesLabel.Show()

                'hidden on page 1
                backNexSpecButton.Hide()
                submitNewSpecButton.Hide()
                priorTestNotesTextBox.Hide()
                postTestObserveLabel.Hide()
                observeLabel.Hide()
                otherTextBox.Hide()
                observeTextBoxX.Hide()
                saveLabel.Hide()
                saveAddLabel.Hide()


            Case 2

                'shown page2
                backNexSpecButton.Show()
                priorTestNotesTextBox.Show()
                priorTestNotesLabel.Show()
                postTestObserveLabel.Show()
                postTestObserveLabel.Show()
                priorTestLabel.Show()
                roomAirLabel.Show()
                observeLabel.Show()
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
                parallelLabel.Hide()
                parallelSwitchButton1.Hide()
                crossSectionLabel.Hide()
                crossSectionSwitchButton.Hide()
                weightIntegerInput2.Hide()

                submitNewSpecButton.Hide()
                specimenNameIntegerInput.Hide()
                pretestWeightLabel.Hide()
                saveLabel.Hide()
                saveAddLabel.Hide()
                submitNewSpecButton.Hide()
                externalDesignLabel.Hide()
                externalDesignationIntegerInput2.Hide()
                externalDesignationIntegerInput1.Hide()
                Label6.Hide()
                Label5.Hide()
                dryAirLabel.Hide()
                otherLabel.Hide()





            Case 3
                'Shown on page 3
                submitNewSpecButton.Show()
                backNexSpecButton.Show()
                saveLabel.Show()
                saveAddLabel.Show()

                'Hidden on page 3

                priorTestNotesLabel.Hide()
                priorTestNotesTextBox.Hide()
                postTestObserveLabel.Hide()

                postTestObserveLabel.Hide()
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

                parallelLabel.Hide()
                parallelSwitchButton1.Hide()
                crossSectionLabel.Hide()
                crossSectionSwitchButton.Hide()
                weightIntegerInput2.Hide()

                specimenNameIntegerInput.Hide()
                pretestWeightLabel.Hide()
                observeLabel.Hide()
                observeTextBoxX.Hide()

                roomAirLabel.Hide()

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