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
                crosssecLabel.Show()
                priorTestNotesLabel.Show()
                roomAirLabel.Show()
                roomAirCheckBox.Show()
                dryAirLabel.Show()
                dryAirCheckbox.Show()
                otherLabel.Show()
                otherTextBox.Show()
                priorTestLabel.Show()
                observeLabel.Show()
                observeTextBoxX.Show()

                'Post test observation section
                postTestObserveLabel.Show()
                postTestmsgLabel.Show()
                postDimLabel.Show()
                postLengthDoubleInput.Show()
                postLengthLabel.Show()
                postWidthLabel.Show()
                postWidthDoubleInput.Show()
                postHeightDoubleInput.Show()
                postHeightLabel.Show()
                'mm labels for len,wid,height
                Label17.Show()
                Label16.Show()
                Label15.Show()
                Label12.Show()
                Label10.Show()
                postCylinderLabel.Show()
                postCylLengthLabel.Show()
                postCylLengthDoubleInput.Show()
                postCylDiameterLabel.Show()
                postCylDiameterDoubleInput.Show()
                postCompoundShapeLabel.Show()
                postCompoundShapeSwitchButton.Show()
                postParallelLabel.Show()
                postParallelSwitchButton.Show()
                postCrossSectionLabel.Show()
                postCrossSectionSwitchButton.Show()
                postWeightLabel.Show()
                postTestWeightLabel.Show()
                postWeightIntegerInput.Show()
                postGainLossLabel.Show()
                postDiffWeightLabel.Show()

                'hidden on page 1
                backNexSpecButton.Hide()
                submitNewSpecButton.Hide()
                saveLabel.Hide()
                saveAddLabel.Hide()






            Case 2
                'Shown on page 2
                submitNewSpecButton.Show()
                backNexSpecButton.Show()
                saveLabel.Show()
                saveAddLabel.Show()

                'Hidden on page 2

                newSpecimenLabel.Hide()
                specimenNameLabel.Hide()
                materialLabel.Hide()
                materialTextBox.Hide()
                MaxTempIntegerInput1.Hide()
                MaxTempLabel.Hide()
                externalDesignLabel.Hide()
                externalDesignationIntegerInput2.Hide()
                externalDesignationIntegerInput1.Hide()
                Label6.Hide()
                Label5.Hide()
                specimenNameIntegerInput.Hide()
                dimensionsLabel.Hide()
                lengthLabel.Hide()
                lengthDoubleInput1.Hide()
                mmLabel.Hide()
                widthLabel.Hide()
                widthDoubleInput2.Hide()
                Label1.Hide()
                heightLabel1.Hide()
                heightDoubleInput1.Hide()
                Label2.Hide()
                cylinderLabel.Hide()
                cylLengthLabel.Hide()
                cylLengthDoubleInput.Hide()
                Label7.Hide()
                cylDiameterLabel.Hide()
                cylDiameterDoubleInput.Hide()
                Label9.Hide()
                compoundShapeLabel.Hide()
                compoundShapeSwitchButton1.Hide()
                parallelLabel.Hide()
                parallelSwitchButton1.Hide()
                weightLabel.Hide()
                weightIntegerInput2.Hide()
                pretestWeightLabel.Hide()
                crossSectionLabel.Hide()
                crossSectionSwitchButton.Hide()
                crosssecLabel.Hide()
                priorTestNotesLabel.Hide()
                roomAirLabel.Hide()
                roomAirCheckBox.Hide()
                dryAirLabel.Hide()
                dryAirCheckbox.Hide()
                otherLabel.Hide()
                otherTextBox.Hide()
                priorTestLabel.Hide()
                observeLabel.Hide()
                observeTextBoxX.Hide()

                'Post test observation section
                postTestObserveLabel.Hide()
                postTestmsgLabel.Hide()
                postDimLabel.Hide()
                postLengthDoubleInput.Hide()
                postLengthLabel.Hide()
                postWidthLabel.Hide()
                postWidthDoubleInput.Hide()
                postHeightDoubleInput.Hide()
                postHeightLabel.Hide()
                'mm labels for len,wid,height
                Label17.Hide()
                Label16.Hide()
                Label15.Hide()
                Label12.Hide()
                Label10.Hide()

                postCylinderLabel.Hide()
                postCylLengthLabel.Hide()
                postCylLengthDoubleInput.Hide()
                postCylDiameterLabel.Hide()
                postCylDiameterDoubleInput.Hide()
                postCompoundShapeLabel.Hide()
                postCompoundShapeSwitchButton.Hide()
                postParallelLabel.Hide()
                postParallelSwitchButton.Hide()
                postCrossSectionLabel.Hide()
                postCrossSectionSwitchButton.Hide()
                postWeightLabel.Hide()
                postTestWeightLabel.Hide()
                postWeightIntegerInput.Hide()
                postGainLossLabel.Hide()
                postDiffWeightLabel.Hide()
            Case Else
                pageCounter = 2
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