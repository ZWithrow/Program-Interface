<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arrigo
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SideNav1 = New DevComponents.DotNetBar.Controls.SideNav()
        Me.SideNavPanel2 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.ButtonClickCounter = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.submitNewSpecButton = New System.Windows.Forms.Button()
        Me.backNexSpecButton = New System.Windows.Forms.Button()
        Me.newSpecNextButton = New System.Windows.Forms.Button()
        Me.roomTempKCheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.roomTempCCheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.roomTempFCheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.roomTempIntegerInput = New DevComponents.Editors.IntegerInput()
        Me.roomTempLabel = New System.Windows.Forms.Label()
        Me.specimenNameIntegerInput = New DevComponents.Editors.IntegerInput()
        Me.specimenNameLabel = New System.Windows.Forms.TextBox()
        Me.materialTextBox = New System.Windows.Forms.TextBox()
        Me.notesLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mmLabel = New System.Windows.Forms.Label()
        Me.gramsLabel = New System.Windows.Forms.Label()
        Me.weightIntegerInput2 = New DevComponents.Editors.IntegerInput()
        Me.weightLabel = New System.Windows.Forms.Label()
        Me.crossSectionSwitchButton = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.crossSectionLabel = New System.Windows.Forms.Label()
        Me.parallelSwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.parallelLabel = New System.Windows.Forms.Label()
        Me.compoundShapeDoubleInput1 = New DevComponents.Editors.DoubleInput()
        Me.compoundShapeLabel = New System.Windows.Forms.Label()
        Me.heightDoubleInput1 = New DevComponents.Editors.DoubleInput()
        Me.heightLabel1 = New System.Windows.Forms.Label()
        Me.widthDoubleInput2 = New DevComponents.Editors.DoubleInput()
        Me.widthLabel = New System.Windows.Forms.Label()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.lengthDoubleInput1 = New DevComponents.Editors.DoubleInput()
        Me.KelvinDegreeCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CelsiusDegreeCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.FarenDegreeCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.MaxTempIntegerInput1 = New DevComponents.Editors.IntegerInput()
        Me.dimensionsLabel = New System.Windows.Forms.Label()
        Me.MaxTempLabel = New System.Windows.Forms.Label()
        Me.materialLabel = New System.Windows.Forms.Label()
        Me.newSpecimenLabel = New System.Windows.Forms.Label()
        Me.SideNavPanel1 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel3 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel6 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel4 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel5 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavItem1 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator1 = New DevComponents.DotNetBar.Separator()
        Me.SideNavItem2 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.NewSpecimensiSideNav = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.NewHeatingSchedule = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Retest = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem3 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem4 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator2 = New DevComponents.DotNetBar.Separator()
        Me.priorTestNotesLabel = New System.Windows.Forms.Label()
        Me.priorTestNotesTextBox = New System.Windows.Forms.TextBox()
        Me.testlabel = New System.Windows.Forms.Label()
        Me.SideNav1.SuspendLayout()
        Me.SideNavPanel2.SuspendLayout()
        CType(Me.roomTempIntegerInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.specimenNameIntegerInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weightIntegerInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compoundShapeDoubleInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heightDoubleInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.widthDoubleInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lengthDoubleInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxTempIntegerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideNavPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer)))
        '
        'SideNav1
        '
        Me.SideNav1.Controls.Add(Me.SideNavPanel2)
        Me.SideNav1.Controls.Add(Me.SideNavPanel3)
        Me.SideNav1.Controls.Add(Me.SideNavPanel5)
        Me.SideNav1.Controls.Add(Me.SideNavPanel1)
        Me.SideNav1.Controls.Add(Me.SideNavPanel6)
        Me.SideNav1.Controls.Add(Me.SideNavPanel4)
        Me.SideNav1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideNav1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideNavItem1, Me.Separator1, Me.SideNavItem2, Me.NewSpecimensiSideNav, Me.NewHeatingSchedule, Me.Retest, Me.SideNavItem3, Me.SideNavItem4, Me.Separator2})
        Me.SideNav1.Location = New System.Drawing.Point(0, 0)
        Me.SideNav1.Name = "SideNav1"
        Me.SideNav1.Padding = New System.Windows.Forms.Padding(1)
        Me.SideNav1.Size = New System.Drawing.Size(1457, 764)
        Me.SideNav1.TabIndex = 0
        Me.SideNav1.Text = "SideNav1"
        '
        'SideNavPanel2
        '
        Me.SideNavPanel2.Controls.Add(Me.priorTestNotesTextBox)
        Me.SideNavPanel2.Controls.Add(Me.priorTestNotesLabel)
        Me.SideNavPanel2.Controls.Add(Me.ButtonClickCounter)
        Me.SideNavPanel2.Controls.Add(Me.Label18)
        Me.SideNavPanel2.Controls.Add(Me.submitNewSpecButton)
        Me.SideNavPanel2.Controls.Add(Me.backNexSpecButton)
        Me.SideNavPanel2.Controls.Add(Me.newSpecNextButton)
        Me.SideNavPanel2.Controls.Add(Me.roomTempKCheckBox)
        Me.SideNavPanel2.Controls.Add(Me.roomTempCCheckBox)
        Me.SideNavPanel2.Controls.Add(Me.roomTempFCheckBox)
        Me.SideNavPanel2.Controls.Add(Me.roomTempIntegerInput)
        Me.SideNavPanel2.Controls.Add(Me.roomTempLabel)
        Me.SideNavPanel2.Controls.Add(Me.specimenNameIntegerInput)
        Me.SideNavPanel2.Controls.Add(Me.specimenNameLabel)
        Me.SideNavPanel2.Controls.Add(Me.materialTextBox)
        Me.SideNavPanel2.Controls.Add(Me.notesLabel)
        Me.SideNavPanel2.Controls.Add(Me.Label2)
        Me.SideNavPanel2.Controls.Add(Me.Label1)
        Me.SideNavPanel2.Controls.Add(Me.mmLabel)
        Me.SideNavPanel2.Controls.Add(Me.gramsLabel)
        Me.SideNavPanel2.Controls.Add(Me.weightIntegerInput2)
        Me.SideNavPanel2.Controls.Add(Me.weightLabel)
        Me.SideNavPanel2.Controls.Add(Me.crossSectionSwitchButton)
        Me.SideNavPanel2.Controls.Add(Me.crossSectionLabel)
        Me.SideNavPanel2.Controls.Add(Me.parallelSwitchButton1)
        Me.SideNavPanel2.Controls.Add(Me.parallelLabel)
        Me.SideNavPanel2.Controls.Add(Me.compoundShapeDoubleInput1)
        Me.SideNavPanel2.Controls.Add(Me.compoundShapeLabel)
        Me.SideNavPanel2.Controls.Add(Me.heightDoubleInput1)
        Me.SideNavPanel2.Controls.Add(Me.heightLabel1)
        Me.SideNavPanel2.Controls.Add(Me.widthDoubleInput2)
        Me.SideNavPanel2.Controls.Add(Me.widthLabel)
        Me.SideNavPanel2.Controls.Add(Me.lengthLabel)
        Me.SideNavPanel2.Controls.Add(Me.lengthDoubleInput1)
        Me.SideNavPanel2.Controls.Add(Me.KelvinDegreeCheck)
        Me.SideNavPanel2.Controls.Add(Me.CelsiusDegreeCheck)
        Me.SideNavPanel2.Controls.Add(Me.FarenDegreeCheck)
        Me.SideNavPanel2.Controls.Add(Me.MaxTempIntegerInput1)
        Me.SideNavPanel2.Controls.Add(Me.dimensionsLabel)
        Me.SideNavPanel2.Controls.Add(Me.MaxTempLabel)
        Me.SideNavPanel2.Controls.Add(Me.materialLabel)
        Me.SideNavPanel2.Controls.Add(Me.newSpecimenLabel)
        Me.SideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel2.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel2.Name = "SideNavPanel2"
        Me.SideNavPanel2.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel2.TabIndex = 6
        '
        'ButtonClickCounter
        '
        Me.ButtonClickCounter.AutoSize = True
        Me.ButtonClickCounter.Location = New System.Drawing.Point(1178, 34)
        Me.ButtonClickCounter.Name = "ButtonClickCounter"
        Me.ButtonClickCounter.Size = New System.Drawing.Size(0, 13)
        Me.ButtonClickCounter.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(120, 37)
        Me.Label18.MinimumSize = New System.Drawing.Size(150, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 30)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Notes Continued"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'submitNewSpecButton
        '
        Me.submitNewSpecButton.Location = New System.Drawing.Point(1214, 668)
        Me.submitNewSpecButton.Name = "submitNewSpecButton"
        Me.submitNewSpecButton.Size = New System.Drawing.Size(64, 31)
        Me.submitNewSpecButton.TabIndex = 39
        Me.submitNewSpecButton.Text = "SUBMIT"
        Me.submitNewSpecButton.UseVisualStyleBackColor = True
        '
        'backNexSpecButton
        '
        Me.backNexSpecButton.Location = New System.Drawing.Point(46, 668)
        Me.backNexSpecButton.Name = "backNexSpecButton"
        Me.backNexSpecButton.Size = New System.Drawing.Size(64, 31)
        Me.backNexSpecButton.TabIndex = 38
        Me.backNexSpecButton.Text = "BACK"
        Me.backNexSpecButton.UseVisualStyleBackColor = True
        '
        'newSpecNextButton
        '
        Me.newSpecNextButton.Location = New System.Drawing.Point(1101, 668)
        Me.newSpecNextButton.Name = "newSpecNextButton"
        Me.newSpecNextButton.Size = New System.Drawing.Size(64, 31)
        Me.newSpecNextButton.TabIndex = 36
        Me.newSpecNextButton.Text = "NEXT"
        Me.newSpecNextButton.UseVisualStyleBackColor = True
        '
        'roomTempKCheckBox
        '
        '
        '
        '
        Me.roomTempKCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.roomTempKCheckBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.roomTempKCheckBox.Location = New System.Drawing.Point(633, 529)
        Me.roomTempKCheckBox.Name = "roomTempKCheckBox"
        Me.roomTempKCheckBox.Size = New System.Drawing.Size(100, 23)
        Me.roomTempKCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.roomTempKCheckBox.TabIndex = 35
        Me.roomTempKCheckBox.Text = "K"
        '
        'roomTempCCheckBox
        '
        '
        '
        '
        Me.roomTempCCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.roomTempCCheckBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.roomTempCCheckBox.Location = New System.Drawing.Point(579, 529)
        Me.roomTempCCheckBox.Name = "roomTempCCheckBox"
        Me.roomTempCCheckBox.Size = New System.Drawing.Size(100, 23)
        Me.roomTempCCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.roomTempCCheckBox.TabIndex = 34
        Me.roomTempCCheckBox.Text = "C°"
        '
        'roomTempFCheckBox
        '
        '
        '
        '
        Me.roomTempFCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.roomTempFCheckBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.roomTempFCheckBox.Location = New System.Drawing.Point(527, 529)
        Me.roomTempFCheckBox.Name = "roomTempFCheckBox"
        Me.roomTempFCheckBox.Size = New System.Drawing.Size(100, 23)
        Me.roomTempFCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.roomTempFCheckBox.TabIndex = 33
        Me.roomTempFCheckBox.Text = "F°"
        '
        'roomTempIntegerInput
        '
        '
        '
        '
        Me.roomTempIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.roomTempIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.roomTempIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.roomTempIntegerInput.Location = New System.Drawing.Point(416, 529)
        Me.roomTempIntegerInput.Name = "roomTempIntegerInput"
        Me.roomTempIntegerInput.ShowUpDown = True
        Me.roomTempIntegerInput.Size = New System.Drawing.Size(90, 22)
        Me.roomTempIntegerInput.TabIndex = 32
        '
        'roomTempLabel
        '
        Me.roomTempLabel.AutoSize = True
        Me.roomTempLabel.Location = New System.Drawing.Point(317, 538)
        Me.roomTempLabel.Name = "roomTempLabel"
        Me.roomTempLabel.Size = New System.Drawing.Size(75, 13)
        Me.roomTempLabel.TabIndex = 31
        Me.roomTempLabel.Text = "ROOM TEMP:"
        '
        'specimenNameIntegerInput
        '
        '
        '
        '
        Me.specimenNameIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.specimenNameIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.specimenNameIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.specimenNameIntegerInput.Location = New System.Drawing.Point(675, 43)
        Me.specimenNameIntegerInput.Name = "specimenNameIntegerInput"
        Me.specimenNameIntegerInput.ShowUpDown = True
        Me.specimenNameIntegerInput.Size = New System.Drawing.Size(90, 22)
        Me.specimenNameIntegerInput.TabIndex = 30
        '
        'specimenNameLabel
        '
        Me.specimenNameLabel.Location = New System.Drawing.Point(320, 43)
        Me.specimenNameLabel.Name = "specimenNameLabel"
        Me.specimenNameLabel.Size = New System.Drawing.Size(314, 22)
        Me.specimenNameLabel.TabIndex = 29
        '
        'materialTextBox
        '
        Me.materialTextBox.Location = New System.Drawing.Point(320, 107)
        Me.materialTextBox.Name = "materialTextBox"
        Me.materialTextBox.Size = New System.Drawing.Size(314, 22)
        Me.materialTextBox.TabIndex = 28
        '
        'notesLabel
        '
        Me.notesLabel.AutoSize = True
        Me.notesLabel.BackColor = System.Drawing.Color.LightGray
        Me.notesLabel.Location = New System.Drawing.Point(120, 521)
        Me.notesLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.notesLabel.Name = "notesLabel"
        Me.notesLabel.Size = New System.Drawing.Size(150, 30)
        Me.notesLabel.TabIndex = 27
        Me.notesLabel.Text = "Notes"
        Me.notesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(555, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "mm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(555, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "mm"
        '
        'mmLabel
        '
        Me.mmLabel.AutoSize = True
        Me.mmLabel.Location = New System.Drawing.Point(555, 241)
        Me.mmLabel.Name = "mmLabel"
        Me.mmLabel.Size = New System.Drawing.Size(25, 13)
        Me.mmLabel.TabIndex = 24
        Me.mmLabel.Text = "mm"
        '
        'gramsLabel
        '
        Me.gramsLabel.AutoSize = True
        Me.gramsLabel.Location = New System.Drawing.Point(413, 475)
        Me.gramsLabel.Name = "gramsLabel"
        Me.gramsLabel.Size = New System.Drawing.Size(14, 13)
        Me.gramsLabel.TabIndex = 23
        Me.gramsLabel.Text = "g"
        '
        'weightIntegerInput2
        '
        '
        '
        '
        Me.weightIntegerInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.weightIntegerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.weightIntegerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.weightIntegerInput2.Location = New System.Drawing.Point(320, 466)
        Me.weightIntegerInput2.Name = "weightIntegerInput2"
        Me.weightIntegerInput2.ShowUpDown = True
        Me.weightIntegerInput2.Size = New System.Drawing.Size(90, 22)
        Me.weightIntegerInput2.TabIndex = 22
        '
        'weightLabel
        '
        Me.weightLabel.AutoSize = True
        Me.weightLabel.BackColor = System.Drawing.Color.LightGray
        Me.weightLabel.Location = New System.Drawing.Point(120, 458)
        Me.weightLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.weightLabel.Name = "weightLabel"
        Me.weightLabel.Size = New System.Drawing.Size(150, 30)
        Me.weightLabel.TabIndex = 21
        Me.weightLabel.Text = "Weight"
        Me.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'crossSectionSwitchButton
        '
        '
        '
        '
        Me.crossSectionSwitchButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.crossSectionSwitchButton.Location = New System.Drawing.Point(490, 419)
        Me.crossSectionSwitchButton.Name = "crossSectionSwitchButton"
        Me.crossSectionSwitchButton.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.crossSectionSwitchButton.OffText = "Yes"
        Me.crossSectionSwitchButton.OffTextColor = System.Drawing.Color.Black
        Me.crossSectionSwitchButton.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.crossSectionSwitchButton.OnText = "No"
        Me.crossSectionSwitchButton.OnTextColor = System.Drawing.Color.Black
        Me.crossSectionSwitchButton.Size = New System.Drawing.Size(66, 13)
        Me.crossSectionSwitchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.crossSectionSwitchButton.TabIndex = 20
        '
        'crossSectionLabel
        '
        Me.crossSectionLabel.AutoSize = True
        Me.crossSectionLabel.Location = New System.Drawing.Point(317, 419)
        Me.crossSectionLabel.Name = "crossSectionLabel"
        Me.crossSectionLabel.Size = New System.Drawing.Size(146, 13)
        Me.crossSectionLabel.TabIndex = 19
        Me.crossSectionLabel.Text = "CROSS SECTION UNIFORM:"
        '
        'parallelSwitchButton1
        '
        '
        '
        '
        Me.parallelSwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.parallelSwitchButton1.Location = New System.Drawing.Point(449, 390)
        Me.parallelSwitchButton1.Name = "parallelSwitchButton1"
        Me.parallelSwitchButton1.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.parallelSwitchButton1.OffText = "Yes"
        Me.parallelSwitchButton1.OffTextColor = System.Drawing.Color.Black
        Me.parallelSwitchButton1.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.parallelSwitchButton1.OnText = "No"
        Me.parallelSwitchButton1.OnTextColor = System.Drawing.Color.Black
        Me.parallelSwitchButton1.Size = New System.Drawing.Size(66, 13)
        Me.parallelSwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.parallelSwitchButton1.TabIndex = 18
        '
        'parallelLabel
        '
        Me.parallelLabel.AutoSize = True
        Me.parallelLabel.Location = New System.Drawing.Point(317, 390)
        Me.parallelLabel.Name = "parallelLabel"
        Me.parallelLabel.Size = New System.Drawing.Size(88, 13)
        Me.parallelLabel.TabIndex = 17
        Me.parallelLabel.Text = "ENDS PARALLEL:"
        '
        'compoundShapeDoubleInput1
        '
        '
        '
        '
        Me.compoundShapeDoubleInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.compoundShapeDoubleInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.compoundShapeDoubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.compoundShapeDoubleInput1.Increment = 1.0R
        Me.compoundShapeDoubleInput1.Location = New System.Drawing.Point(449, 347)
        Me.compoundShapeDoubleInput1.Name = "compoundShapeDoubleInput1"
        Me.compoundShapeDoubleInput1.ShowUpDown = True
        Me.compoundShapeDoubleInput1.Size = New System.Drawing.Size(131, 22)
        Me.compoundShapeDoubleInput1.TabIndex = 16
        '
        'compoundShapeLabel
        '
        Me.compoundShapeLabel.AutoSize = True
        Me.compoundShapeLabel.Location = New System.Drawing.Point(317, 356)
        Me.compoundShapeLabel.Name = "compoundShapeLabel"
        Me.compoundShapeLabel.Size = New System.Drawing.Size(111, 13)
        Me.compoundShapeLabel.TabIndex = 15
        Me.compoundShapeLabel.Text = "COMPOUND SHAPE:"
        '
        'heightDoubleInput1
        '
        '
        '
        '
        Me.heightDoubleInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.heightDoubleInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.heightDoubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.heightDoubleInput1.Increment = 1.0R
        Me.heightDoubleInput1.Location = New System.Drawing.Point(407, 306)
        Me.heightDoubleInput1.Name = "heightDoubleInput1"
        Me.heightDoubleInput1.ShowUpDown = True
        Me.heightDoubleInput1.Size = New System.Drawing.Size(131, 22)
        Me.heightDoubleInput1.TabIndex = 14
        '
        'heightLabel1
        '
        Me.heightLabel1.AutoSize = True
        Me.heightLabel1.Location = New System.Drawing.Point(317, 315)
        Me.heightLabel1.Name = "heightLabel1"
        Me.heightLabel1.Size = New System.Drawing.Size(48, 13)
        Me.heightLabel1.TabIndex = 13
        Me.heightLabel1.Text = "HEIGHT:"
        '
        'widthDoubleInput2
        '
        '
        '
        '
        Me.widthDoubleInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.widthDoubleInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.widthDoubleInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.widthDoubleInput2.Increment = 1.0R
        Me.widthDoubleInput2.Location = New System.Drawing.Point(407, 271)
        Me.widthDoubleInput2.Name = "widthDoubleInput2"
        Me.widthDoubleInput2.ShowUpDown = True
        Me.widthDoubleInput2.Size = New System.Drawing.Size(131, 22)
        Me.widthDoubleInput2.TabIndex = 12
        '
        'widthLabel
        '
        Me.widthLabel.AutoSize = True
        Me.widthLabel.Location = New System.Drawing.Point(317, 280)
        Me.widthLabel.Name = "widthLabel"
        Me.widthLabel.Size = New System.Drawing.Size(45, 13)
        Me.widthLabel.TabIndex = 11
        Me.widthLabel.Text = "WIDTH:"
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(317, 241)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(50, 13)
        Me.lengthLabel.TabIndex = 10
        Me.lengthLabel.Text = "LENGTH:"
        '
        'lengthDoubleInput1
        '
        '
        '
        '
        Me.lengthDoubleInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.lengthDoubleInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lengthDoubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.lengthDoubleInput1.Increment = 1.0R
        Me.lengthDoubleInput1.Location = New System.Drawing.Point(407, 232)
        Me.lengthDoubleInput1.Name = "lengthDoubleInput1"
        Me.lengthDoubleInput1.ShowUpDown = True
        Me.lengthDoubleInput1.Size = New System.Drawing.Size(131, 22)
        Me.lengthDoubleInput1.TabIndex = 9
        '
        'KelvinDegreeCheck
        '
        '
        '
        '
        Me.KelvinDegreeCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.KelvinDegreeCheck.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.KelvinDegreeCheck.Location = New System.Drawing.Point(544, 169)
        Me.KelvinDegreeCheck.Name = "KelvinDegreeCheck"
        Me.KelvinDegreeCheck.Size = New System.Drawing.Size(100, 23)
        Me.KelvinDegreeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.KelvinDegreeCheck.TabIndex = 8
        Me.KelvinDegreeCheck.Text = "K"
        '
        'CelsiusDegreeCheck
        '
        '
        '
        '
        Me.CelsiusDegreeCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CelsiusDegreeCheck.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CelsiusDegreeCheck.Location = New System.Drawing.Point(490, 170)
        Me.CelsiusDegreeCheck.Name = "CelsiusDegreeCheck"
        Me.CelsiusDegreeCheck.Size = New System.Drawing.Size(100, 23)
        Me.CelsiusDegreeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CelsiusDegreeCheck.TabIndex = 7
        Me.CelsiusDegreeCheck.Text = "C°"
        '
        'FarenDegreeCheck
        '
        '
        '
        '
        Me.FarenDegreeCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FarenDegreeCheck.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.FarenDegreeCheck.Location = New System.Drawing.Point(438, 170)
        Me.FarenDegreeCheck.Name = "FarenDegreeCheck"
        Me.FarenDegreeCheck.Size = New System.Drawing.Size(100, 23)
        Me.FarenDegreeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FarenDegreeCheck.TabIndex = 6
        Me.FarenDegreeCheck.Text = "F°"
        '
        'MaxTempIntegerInput1
        '
        '
        '
        '
        Me.MaxTempIntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.MaxTempIntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaxTempIntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.MaxTempIntegerInput1.Location = New System.Drawing.Point(320, 170)
        Me.MaxTempIntegerInput1.Name = "MaxTempIntegerInput1"
        Me.MaxTempIntegerInput1.ShowUpDown = True
        Me.MaxTempIntegerInput1.Size = New System.Drawing.Size(90, 22)
        Me.MaxTempIntegerInput1.TabIndex = 5
        '
        'dimensionsLabel
        '
        Me.dimensionsLabel.AutoSize = True
        Me.dimensionsLabel.BackColor = System.Drawing.Color.LightGray
        Me.dimensionsLabel.Location = New System.Drawing.Point(120, 224)
        Me.dimensionsLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.dimensionsLabel.Name = "dimensionsLabel"
        Me.dimensionsLabel.Size = New System.Drawing.Size(150, 30)
        Me.dimensionsLabel.TabIndex = 3
        Me.dimensionsLabel.Text = "Dimensions"
        Me.dimensionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxTempLabel
        '
        Me.MaxTempLabel.AutoSize = True
        Me.MaxTempLabel.BackColor = System.Drawing.Color.LightGray
        Me.MaxTempLabel.Location = New System.Drawing.Point(120, 162)
        Me.MaxTempLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.MaxTempLabel.Name = "MaxTempLabel"
        Me.MaxTempLabel.Size = New System.Drawing.Size(150, 30)
        Me.MaxTempLabel.TabIndex = 2
        Me.MaxTempLabel.Text = "Max Temperature"
        Me.MaxTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'materialLabel
        '
        Me.materialLabel.AutoSize = True
        Me.materialLabel.BackColor = System.Drawing.Color.LightGray
        Me.materialLabel.Location = New System.Drawing.Point(120, 99)
        Me.materialLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.materialLabel.Name = "materialLabel"
        Me.materialLabel.Size = New System.Drawing.Size(150, 30)
        Me.materialLabel.TabIndex = 1
        Me.materialLabel.Text = "Material"
        Me.materialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'newSpecimenLabel
        '
        Me.newSpecimenLabel.AutoSize = True
        Me.newSpecimenLabel.BackColor = System.Drawing.Color.LightGray
        Me.newSpecimenLabel.Location = New System.Drawing.Point(120, 35)
        Me.newSpecimenLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.newSpecimenLabel.Name = "newSpecimenLabel"
        Me.newSpecimenLabel.Size = New System.Drawing.Size(150, 30)
        Me.newSpecimenLabel.TabIndex = 0
        Me.newSpecimenLabel.Text = "New Specimen"
        Me.newSpecimenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SideNavPanel1
        '
        Me.SideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel1.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel1.Name = "SideNavPanel1"
        Me.SideNavPanel1.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel1.TabIndex = 2
        Me.SideNavPanel1.Visible = False
        '
        'SideNavPanel3
        '
        Me.SideNavPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel3.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel3.Name = "SideNavPanel3"
        Me.SideNavPanel3.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel3.TabIndex = 10
        Me.SideNavPanel3.Visible = False
        '
        'SideNavPanel6
        '
        Me.SideNavPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel6.Location = New System.Drawing.Point(1, 1)
        Me.SideNavPanel6.Name = "SideNavPanel6"
        Me.SideNavPanel6.Size = New System.Drawing.Size(1455, 762)
        Me.SideNavPanel6.TabIndex = 22
        Me.SideNavPanel6.Visible = False
        '
        'SideNavPanel4
        '
        Me.SideNavPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel4.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel4.Name = "SideNavPanel4"
        Me.SideNavPanel4.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel4.TabIndex = 14
        Me.SideNavPanel4.Visible = False
        '
        'SideNavPanel5
        '
        Me.SideNavPanel5.Controls.Add(Me.testlabel)
        Me.SideNavPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel5.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel5.Name = "SideNavPanel5"
        Me.SideNavPanel5.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel5.TabIndex = 18
        Me.SideNavPanel5.Visible = False
        '
        'SideNavItem1
        '
        Me.SideNavItem1.IsSystemMenu = True
        Me.SideNavItem1.Name = "SideNavItem1"
        Me.SideNavItem1.Symbol = ""
        Me.SideNavItem1.Text = "Menu"
        '
        'Separator1
        '
        Me.Separator1.FixedSize = New System.Drawing.Size(3, 1)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Padding.Bottom = 2
        Me.Separator1.Padding.Left = 6
        Me.Separator1.Padding.Right = 6
        Me.Separator1.Padding.Top = 2
        Me.Separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical
        '
        'SideNavItem2
        '
        Me.SideNavItem2.Name = "SideNavItem2"
        Me.SideNavItem2.Panel = Me.SideNavPanel1
        Me.SideNavItem2.Symbol = ""
        Me.SideNavItem2.Text = "Home"
        '
        'NewSpecimensiSideNav
        '
        Me.NewSpecimensiSideNav.Checked = True
        Me.NewSpecimensiSideNav.Name = "NewSpecimensiSideNav"
        Me.NewSpecimensiSideNav.Panel = Me.SideNavPanel2
        Me.NewSpecimensiSideNav.Symbol = ""
        Me.NewSpecimensiSideNav.Text = "New Specimen"
        '
        'NewHeatingSchedule
        '
        Me.NewHeatingSchedule.Name = "NewHeatingSchedule"
        Me.NewHeatingSchedule.Panel = Me.SideNavPanel3
        Me.NewHeatingSchedule.Symbol = ""
        Me.NewHeatingSchedule.Text = "New Heating Test"
        '
        'Retest
        '
        Me.Retest.Name = "Retest"
        Me.Retest.Panel = Me.SideNavPanel4
        Me.Retest.Symbol = ""
        Me.Retest.Text = "Retest"
        '
        'SideNavItem3
        '
        Me.SideNavItem3.Name = "SideNavItem3"
        Me.SideNavItem3.Panel = Me.SideNavPanel5
        Me.SideNavItem3.Symbol = ""
        Me.SideNavItem3.Text = "Saved Tests"
        '
        'SideNavItem4
        '
        Me.SideNavItem4.Name = "SideNavItem4"
        Me.SideNavItem4.Panel = Me.SideNavPanel6
        Me.SideNavItem4.Symbol = ""
        Me.SideNavItem4.Text = "Saved Specimen"
        '
        'Separator2
        '
        Me.Separator2.FixedSize = New System.Drawing.Size(3, 1)
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Padding.Bottom = 2
        Me.Separator2.Padding.Left = 6
        Me.Separator2.Padding.Right = 6
        Me.Separator2.Padding.Top = 2
        Me.Separator2.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical
        '
        'priorTestNotesLabel
        '
        Me.priorTestNotesLabel.AutoSize = True
        Me.priorTestNotesLabel.BackColor = System.Drawing.Color.LightGray
        Me.priorTestNotesLabel.Location = New System.Drawing.Point(120, 99)
        Me.priorTestNotesLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.priorTestNotesLabel.Name = "priorTestNotesLabel"
        Me.priorTestNotesLabel.Size = New System.Drawing.Size(150, 30)
        Me.priorTestNotesLabel.TabIndex = 42
        Me.priorTestNotesLabel.Text = "Prior Test Notes"
        Me.priorTestNotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priorTestNotesTextBox
        '
        Me.priorTestNotesTextBox.Location = New System.Drawing.Point(320, 107)
        Me.priorTestNotesTextBox.Name = "priorTestNotesTextBox"
        Me.priorTestNotesTextBox.Size = New System.Drawing.Size(314, 22)
        Me.priorTestNotesTextBox.TabIndex = 43
        '
        'testlabel
        '
        Me.testlabel.AutoSize = True
        Me.testlabel.Location = New System.Drawing.Point(249, 54)
        Me.testlabel.Name = "testlabel"
        Me.testlabel.Size = New System.Drawing.Size(43, 13)
        Me.testlabel.TabIndex = 0
        Me.testlabel.Text = "testing"
        '
        'Arrigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 764)
        Me.Controls.Add(Me.SideNav1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Arrigo"
        Me.Text = "Arrigo"
        Me.SideNav1.ResumeLayout(False)
        Me.SideNav1.PerformLayout()
        Me.SideNavPanel2.ResumeLayout(False)
        Me.SideNavPanel2.PerformLayout()
        CType(Me.roomTempIntegerInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.specimenNameIntegerInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weightIntegerInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compoundShapeDoubleInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heightDoubleInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.widthDoubleInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lengthDoubleInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxTempIntegerInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideNavPanel5.ResumeLayout(False)
        Me.SideNavPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SideNav1 As DevComponents.DotNetBar.Controls.SideNav
    Friend WithEvents SideNavPanel1 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents SideNavItem1 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Separator1 As DevComponents.DotNetBar.Separator
    Friend WithEvents SideNavItem2 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents SideNavPanel2 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents NewSpecimensiSideNav As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents SideNavPanel6 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents SideNavPanel4 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents SideNavPanel5 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents SideNavPanel3 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents NewHeatingSchedule As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Retest As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents SideNavItem3 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents SideNavItem4 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents newSpecimenLabel As Label
    Friend WithEvents materialLabel As Label
    Friend WithEvents MaxTempLabel As Label
    Friend WithEvents FarenDegreeCheck As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents MaxTempIntegerInput1 As DevComponents.Editors.IntegerInput
    Friend WithEvents dimensionsLabel As Label
    Friend WithEvents KelvinDegreeCheck As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CelsiusDegreeCheck As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lengthLabel As Label
    Friend WithEvents lengthDoubleInput1 As DevComponents.Editors.DoubleInput
    Friend WithEvents widthLabel As Label
    Friend WithEvents widthDoubleInput2 As DevComponents.Editors.DoubleInput
    Friend WithEvents heightDoubleInput1 As DevComponents.Editors.DoubleInput
    Friend WithEvents heightLabel1 As Label
    Friend WithEvents compoundShapeLabel As Label
    Friend WithEvents compoundShapeDoubleInput1 As DevComponents.Editors.DoubleInput
    Friend WithEvents parallelSwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents parallelLabel As Label
    Friend WithEvents crossSectionSwitchButton As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents crossSectionLabel As Label
    Friend WithEvents weightLabel As Label
    Friend WithEvents gramsLabel As Label
    Friend WithEvents weightIntegerInput2 As DevComponents.Editors.IntegerInput
    Friend WithEvents mmLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents notesLabel As Label
    Friend WithEvents specimenNameIntegerInput As DevComponents.Editors.IntegerInput
    Friend WithEvents specimenNameLabel As TextBox
    Friend WithEvents materialTextBox As TextBox
    Friend WithEvents roomTempLabel As Label
    Friend WithEvents roomTempKCheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents roomTempCCheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents roomTempFCheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents roomTempIntegerInput As DevComponents.Editors.IntegerInput
    Friend WithEvents Separator2 As DevComponents.DotNetBar.Separator
    Friend WithEvents newSpecNextButton As Button
    Friend WithEvents backNexSpecButton As Button
    Friend WithEvents submitNewSpecButton As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents ButtonClickCounter As Label
    Friend WithEvents priorTestNotesTextBox As TextBox
    Friend WithEvents priorTestNotesLabel As Label
    Friend WithEvents testlabel As Label
End Class
