<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arrigo
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SideNav1 = New DevComponents.DotNetBar.Controls.SideNav()
        Me.SideNavPanel2 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.FarenDegreeCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.IntegerInput1 = New DevComponents.Editors.IntegerInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DimensionsLabel = New System.Windows.Forms.Label()
        Me.MaxTempLabel = New System.Windows.Forms.Label()
        Me.materialLabel = New System.Windows.Forms.Label()
        Me.newSpecimenLabel = New System.Windows.Forms.Label()
        Me.SideNavPanel3 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel4 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel5 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel6 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavPanel1 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.SideNavItem1 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator1 = New DevComponents.DotNetBar.Separator()
        Me.SideNavItem2 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.NewSpecimensiSideNav = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.NewHeatingSchedule = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Retest = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem3 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem4 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.CelsiusDegreeCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.KelvinDegreeCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SideNav1.SuspendLayout()
        Me.SideNavPanel2.SuspendLayout()
        CType(Me.IntegerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SideNav1.Controls.Add(Me.SideNavPanel4)
        Me.SideNav1.Controls.Add(Me.SideNavPanel5)
        Me.SideNav1.Controls.Add(Me.SideNavPanel6)
        Me.SideNav1.Controls.Add(Me.SideNavPanel1)
        Me.SideNav1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideNav1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideNavItem1, Me.Separator1, Me.SideNavItem2, Me.NewSpecimensiSideNav, Me.NewHeatingSchedule, Me.Retest, Me.SideNavItem3, Me.SideNavItem4})
        Me.SideNav1.Location = New System.Drawing.Point(0, 0)
        Me.SideNav1.Name = "SideNav1"
        Me.SideNav1.Padding = New System.Windows.Forms.Padding(1)
        Me.SideNav1.Size = New System.Drawing.Size(1457, 764)
        Me.SideNav1.TabIndex = 0
        Me.SideNav1.Text = "SideNav1"
        '
        'SideNavPanel2
        '
        Me.SideNavPanel2.Controls.Add(Me.KelvinDegreeCheck)
        Me.SideNavPanel2.Controls.Add(Me.CelsiusDegreeCheck)
        Me.SideNavPanel2.Controls.Add(Me.FarenDegreeCheck)
        Me.SideNavPanel2.Controls.Add(Me.IntegerInput1)
        Me.SideNavPanel2.Controls.Add(Me.Label1)
        Me.SideNavPanel2.Controls.Add(Me.DimensionsLabel)
        Me.SideNavPanel2.Controls.Add(Me.MaxTempLabel)
        Me.SideNavPanel2.Controls.Add(Me.materialLabel)
        Me.SideNavPanel2.Controls.Add(Me.newSpecimenLabel)
        Me.SideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel2.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel2.Name = "SideNavPanel2"
        Me.SideNavPanel2.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel2.TabIndex = 6
        '
        'FarenDegreeCheck
        '
        '
        '
        '
        Me.FarenDegreeCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FarenDegreeCheck.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.FarenDegreeCheck.Location = New System.Drawing.Point(353, 179)
        Me.FarenDegreeCheck.Name = "FarenDegreeCheck"
        Me.FarenDegreeCheck.Size = New System.Drawing.Size(100, 23)
        Me.FarenDegreeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FarenDegreeCheck.TabIndex = 6
        Me.FarenDegreeCheck.Text = "F°"
        '
        'IntegerInput1
        '
        '
        '
        '
        Me.IntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IntegerInput1.Location = New System.Drawing.Point(235, 179)
        Me.IntegerInput1.Name = "IntegerInput1"
        Me.IntegerInput1.ShowUpDown = True
        Me.IntegerInput1.Size = New System.Drawing.Size(90, 22)
        Me.IntegerInput1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(35, 299)
        Me.Label1.MinimumSize = New System.Drawing.Size(150, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dimensions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DimensionsLabel
        '
        Me.DimensionsLabel.AutoSize = True
        Me.DimensionsLabel.BackColor = System.Drawing.Color.LightGray
        Me.DimensionsLabel.Location = New System.Drawing.Point(35, 233)
        Me.DimensionsLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.DimensionsLabel.Name = "DimensionsLabel"
        Me.DimensionsLabel.Size = New System.Drawing.Size(150, 30)
        Me.DimensionsLabel.TabIndex = 3
        Me.DimensionsLabel.Text = "Dimensions"
        Me.DimensionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxTempLabel
        '
        Me.MaxTempLabel.AutoSize = True
        Me.MaxTempLabel.BackColor = System.Drawing.Color.LightGray
        Me.MaxTempLabel.Location = New System.Drawing.Point(35, 171)
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
        Me.materialLabel.Location = New System.Drawing.Point(35, 108)
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
        Me.newSpecimenLabel.Location = New System.Drawing.Point(35, 44)
        Me.newSpecimenLabel.MinimumSize = New System.Drawing.Size(150, 30)
        Me.newSpecimenLabel.Name = "newSpecimenLabel"
        Me.newSpecimenLabel.Size = New System.Drawing.Size(150, 30)
        Me.newSpecimenLabel.TabIndex = 0
        Me.newSpecimenLabel.Text = "New Specimen"
        Me.newSpecimenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.SideNavPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel5.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel5.Name = "SideNavPanel5"
        Me.SideNavPanel5.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel5.TabIndex = 18
        Me.SideNavPanel5.Visible = False
        '
        'SideNavPanel6
        '
        Me.SideNavPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel6.Location = New System.Drawing.Point(135, 36)
        Me.SideNavPanel6.Name = "SideNavPanel6"
        Me.SideNavPanel6.Size = New System.Drawing.Size(1317, 727)
        Me.SideNavPanel6.TabIndex = 22
        Me.SideNavPanel6.Visible = False
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
        'CelsiusDegreeCheck
        '
        '
        '
        '
        Me.CelsiusDegreeCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CelsiusDegreeCheck.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CelsiusDegreeCheck.Location = New System.Drawing.Point(405, 179)
        Me.CelsiusDegreeCheck.Name = "CelsiusDegreeCheck"
        Me.CelsiusDegreeCheck.Size = New System.Drawing.Size(100, 23)
        Me.CelsiusDegreeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CelsiusDegreeCheck.TabIndex = 7
        Me.CelsiusDegreeCheck.Text = "C°"
        '
        'KelvinDegreeCheck
        '
        '
        '
        '
        Me.KelvinDegreeCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.KelvinDegreeCheck.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.KelvinDegreeCheck.Location = New System.Drawing.Point(459, 178)
        Me.KelvinDegreeCheck.Name = "KelvinDegreeCheck"
        Me.KelvinDegreeCheck.Size = New System.Drawing.Size(100, 23)
        Me.KelvinDegreeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.KelvinDegreeCheck.TabIndex = 8
        Me.KelvinDegreeCheck.Text = "K"
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
        CType(Me.IntegerInput1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IntegerInput1 As DevComponents.Editors.IntegerInput
    Friend WithEvents Label1 As Label
    Friend WithEvents DimensionsLabel As Label
    Friend WithEvents KelvinDegreeCheck As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CelsiusDegreeCheck As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
