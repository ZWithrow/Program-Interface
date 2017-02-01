Public Class Arrigo


    ' variable for keeping track of button clicks
    Dim pageCounter As Integer = 1
    Dim heatPageCounter As Integer = 1

    'new csv file path
    Dim csvFilePath = IO.Path.GetFullPath(String.Format("{0}\..", Application.StartupPath))


    Public Shared ReadOnly Property StartupPath As String
    Private Sub PrintStartupPath()
        TextBox1.Text = "The path for the executable file that " &
  "started the application is: " &
  Application.StartupPath
    End Sub

    Private Sub CreateSpecimenCSVfile(ByVal _specimenCSVPath As String, ByVal specimenNameTextBox As String, ByVal specimenNameIntegerInput As String,
                                  ByVal MaxTempIntegerInput1 As String, ByVal materialTextBox As String, ByVal externalDesignationIntegerInput1 As String,
                                  ByVal externalDesignationIntegerInput2 As String, ByVal lengthDoubleInput1 As String, ByVal compoundShapeSwitchButton1 As String)
        Try
            Dim stLine As String = ""
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(_specimenCSVPath)
            If IO.File.Exists(_specimenCSVPath) Then
                objWriter.Write(specimenNameTextBox & ",")
                objWriter.Write(specimenNameIntegerInput & ",")
                objWriter.Write(MaxTempIntegerInput1 & ",")
                objWriter.Write(materialTextBox & ",")
                objWriter.Write(externalDesignationIntegerInput1 & ",")
                objWriter.Write(externalDesignationIntegerInput2 & ",")
                objWriter.Write(lengthDoubleInput1 & ",")
                objWriter.Write(compoundShapeSwitchButton1 & ",")

                'If value contains comma in the value then you have to perform this opertions
                'Dim append = If(materialTextBox.Contains(","), String.Format("""{0}"""), materialTextBox)
                'stLine = String.Format("{0}{1},", stLine, append)
                'objWriter.Write(stLine)

                objWriter.Write(Environment.NewLine)
            End If
            objWriter.Close()
            ClearSpecTextbox()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CreateHeatCSVfile(ByVal _heatCSVPath As String, ByVal heatScheduleDefaultNameNum As String, ByVal optHeatingScheduleTextBox As String, ByVal TextBox2 As String)
        Try
            Dim stLine As String = ""
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(_heatCSVPath)
            If IO.File.Exists(_heatCSVPath) Then
                objWriter.Write(heatScheduleDefaultNameNum & ",")
                objWriter.Write(optHeatingScheduleTextBox & ",")
                objWriter.Write(TextBox2 & ",")

                'If value contains comma in the value then you have to perform this opertions
                Dim append = If(TextBox2.Contains(","), String.Format("""{0}"""), TextBox2)
                stLine = String.Format("{0}{1},", stLine, append)
                objWriter.Write(stLine)
                objWriter.Write(Environment.NewLine)
            End If
            objWriter.Close()
            ClearHeatTextbox()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ClearSpecTextbox()
        specimenNameTextbox.Text = ""
        MaxTempIntegerInput1.Text = ""
        specimenNameIntegerInput.Text = ""
        materialTextBox.Text = ""
        externalDesignationIntegerInput1.Text = ""
        externalDesignationIntegerInput2.Text = ""
        lengthDoubleInput1.Text = ""
        compoundShapeSwitchButton1.Value = ""

    End Sub
    Private Sub ClearHeatTextbox()
        specimenNameTextbox.Text = ""
        MaxTempIntegerInput1.Text = ""
        materialTextBox.Text = ""

    End Sub
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
                specimenNameTextbox.Show()
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

                newSpecNextButton.Show()
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
                specimenNameTextbox.Hide()
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

                newSpecNextButton.Hide()

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
        CreateSpecimenCSVfile(csvFilePath & "/SpecimenData" & "\" & "NewSpecimen.csv", specimenNameTextbox.Text.ToString(),
                          specimenNameIntegerInput.Text.ToString(), MaxTempIntegerInput1.Text.ToString(), materialTextBox.Text.ToString(), externalDesignationIntegerInput1.Text.ToString(), externalDesignationIntegerInput2.Text.ToString(),
                          lengthDoubleInput1.Text.ToString(), compoundShapeSwitchButton1.Value.ToString())

        NewHeatingScheduleSideNav.Select()
        pageCounter = 1


    End Sub

    Private Sub newHeatSchedTestLabel_Click(sender As Object, e As EventArgs) Handles newHeatSchedTestLabel.Click
        heatPageCounter += 1
        CreateHeatCSVfile(csvFilePath & "/ScheduleData" & "\" & "HeatSchedules.csv", heatScheduleDefaultNameNum.Text.ToString(), optHeatingScheduleTextBox.Text.ToString(), TextBox2.Text.ToString())

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
        pageCounter = 1
        ShowPage()
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