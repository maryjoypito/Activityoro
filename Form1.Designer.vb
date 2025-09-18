<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New Label()
        txtName = New TextBox()
        lblGender = New Label()
        radioButtonMale = New RadioButton()
        radioButtonFemale = New RadioButton()
        lblCourse = New Label()
        comboBoxCourse = New ComboBox()
        lblHobbies = New Label()
        checkBoxReading = New CheckBox()
        checkBoxSports = New CheckBox()
        checkBoxMusic = New CheckBox()
        checkBoxDancing = New CheckBox()
        btnResult = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Georgia", 10.8F, FontStyle.Bold)
        lblName.Location = New Point(85, 82)
        lblName.Name = "lblName"
        lblName.Size = New Size(71, 21)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Georgia", 10.8F, FontStyle.Bold)
        txtName.Location = New Point(164, 79)
        txtName.Name = "txtName"
        txtName.Size = New Size(426, 28)
        txtName.TabIndex = 1
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Georgia", 10.8F, FontStyle.Bold)
        lblGender.Location = New Point(85, 126)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(86, 21)
        lblGender.TabIndex = 2
        lblGender.Text = "Gender:"
        ' 
        ' radioButtonMale
        ' 
        radioButtonMale.AutoSize = True
        radioButtonMale.Font = New Font("Georgia", 10.8F)
        radioButtonMale.Location = New Point(176, 124)
        radioButtonMale.Name = "radioButtonMale"
        radioButtonMale.Size = New Size(71, 25)
        radioButtonMale.TabIndex = 3
        radioButtonMale.TabStop = True
        radioButtonMale.Text = "Male"
        radioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' radioButtonFemale
        ' 
        radioButtonFemale.AutoSize = True
        radioButtonFemale.Font = New Font("Georgia", 10.8F)
        radioButtonFemale.Location = New Point(266, 124)
        radioButtonFemale.Name = "radioButtonFemale"
        radioButtonFemale.Size = New Size(90, 25)
        radioButtonFemale.TabIndex = 4
        radioButtonFemale.TabStop = True
        radioButtonFemale.Text = "Female"
        radioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Georgia", 10.8F, FontStyle.Bold)
        lblCourse.Location = New Point(83, 170)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(82, 21)
        lblCourse.TabIndex = 5
        lblCourse.Text = "Course:"
        ' 
        ' comboBoxCourse
        ' 
        comboBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxCourse.Font = New Font("Georgia", 10.8F)
        comboBoxCourse.FormattingEnabled = True
        comboBoxCourse.Location = New Point(169, 167)
        comboBoxCourse.Name = "comboBoxCourse"
        comboBoxCourse.Size = New Size(419, 29)
        comboBoxCourse.TabIndex = 6
        ' 
        ' lblHobbies
        ' 
        lblHobbies.AutoSize = True
        lblHobbies.Font = New Font("Georgia", 10.8F, FontStyle.Bold)
        lblHobbies.Location = New Point(86, 217)
        lblHobbies.Name = "lblHobbies"
        lblHobbies.Size = New Size(93, 21)
        lblHobbies.TabIndex = 7
        lblHobbies.Text = "Hobbies:"
        ' 
        ' checkBoxReading
        ' 
        checkBoxReading.AutoSize = True
        checkBoxReading.Font = New Font("Georgia", 10.8F)
        checkBoxReading.Location = New Point(362, 216)
        checkBoxReading.Name = "checkBoxReading"
        checkBoxReading.Size = New Size(98, 25)
        checkBoxReading.TabIndex = 8
        checkBoxReading.Text = "Reading"
        checkBoxReading.UseVisualStyleBackColor = True
        ' 
        ' checkBoxSports
        ' 
        checkBoxSports.AutoSize = True
        checkBoxSports.Font = New Font("Georgia", 10.8F)
        checkBoxSports.Location = New Point(270, 217)
        checkBoxSports.Name = "checkBoxSports"
        checkBoxSports.Size = New Size(83, 25)
        checkBoxSports.TabIndex = 9
        checkBoxSports.Text = "Sports"
        checkBoxSports.UseVisualStyleBackColor = True
        ' 
        ' checkBoxMusic
        ' 
        checkBoxMusic.AutoSize = True
        checkBoxMusic.Font = New Font("Georgia", 10.8F)
        checkBoxMusic.Location = New Point(184, 216)
        checkBoxMusic.Name = "checkBoxMusic"
        checkBoxMusic.Size = New Size(81, 25)
        checkBoxMusic.TabIndex = 10
        checkBoxMusic.Text = "Music"
        checkBoxMusic.UseVisualStyleBackColor = True
        ' 
        ' checkBoxDancing
        ' 
        checkBoxDancing.AutoSize = True
        checkBoxDancing.Font = New Font("Georgia", 10.8F)
        checkBoxDancing.Location = New Point(466, 217)
        checkBoxDancing.Name = "checkBoxDancing"
        checkBoxDancing.Size = New Size(98, 25)
        checkBoxDancing.TabIndex = 11
        checkBoxDancing.Text = "Dancing"
        checkBoxDancing.UseVisualStyleBackColor = True
        ' 
        ' btnResult
        ' 
        btnResult.BackColor = SystemColors.ActiveCaption
        btnResult.Font = New Font("Georgia", 10.8F)
        btnResult.Location = New Point(203, 329)
        btnResult.Name = "btnResult"
        btnResult.Size = New Size(300, 49)
        btnResult.TabIndex = 12
        btnResult.Text = "Result"
        btnResult.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        ClientSize = New Size(677, 484)
        Controls.Add(btnResult)
        Controls.Add(checkBoxDancing)
        Controls.Add(checkBoxMusic)
        Controls.Add(checkBoxSports)
        Controls.Add(checkBoxReading)
        Controls.Add(lblHobbies)
        Controls.Add(comboBoxCourse)
        Controls.Add(lblCourse)
        Controls.Add(radioButtonFemale)
        Controls.Add(radioButtonMale)
        Controls.Add(lblGender)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Student Information Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents radioButtonMale As RadioButton
    Friend WithEvents radioButtonFemale As RadioButton
    Friend WithEvents lblCourse As Label
    Friend WithEvents comboBoxCourse As ComboBox
    Friend WithEvents lblHobbies As Label
    Friend WithEvents checkBoxReading As CheckBox
    Friend WithEvents checkBoxSports As CheckBox
    Friend WithEvents checkBoxMusic As CheckBox
    Friend WithEvents checkBoxDancing As CheckBox
    Friend WithEvents btnShowResult As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnResult As Button
End Class
