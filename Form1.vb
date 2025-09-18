Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxCourse.Items.AddRange(New String() {
            "BSIT", "BSHRM", "BSA", "BEED", "BSED", "BSBA", "BSMT", "BSCE"
        })
    End Sub

    ' Show Result Button
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        ' Name
        Dim studentName As String = If(txtName.Text.Trim() <> "", txtName.Text, "No name entered")

        ' Gender
        Dim gender As String
        If radioButtonMale.Checked Then
            gender = "Male"
        ElseIf radioButtonFemale.Checked Then
            gender = "Female"
        Else
            gender = "Not selected"
        End If

        ' Course
        Dim course As String = If(comboBoxCourse.SelectedItem IsNot Nothing,
                                  comboBoxCourse.SelectedItem.ToString(),
                                  "Not selected")

        ' Hobbies
        Dim hobbies As New List(Of String)
        If checkBoxReading.Checked Then hobbies.Add("Reading")
        If checkBoxSports.Checked Then hobbies.Add("Sports")
        If checkBoxMusic.Checked Then hobbies.Add("Music")
        If checkBoxDancing.Checked Then hobbies.Add("Dancing")
        Dim hobbiesText As String = If(hobbies.Count > 0, String.Join(", ", hobbies), "None")

        ' Message
        Dim message As String =
            "Student Name: " & studentName & vbCrLf &
            "Gender: " & gender & vbCrLf &
            "Course: " & course & vbCrLf &
            "Hobbies: " & hobbiesText

        MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub checkBoxReading_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxReading.CheckedChanged

    End Sub

    Private Sub checkBoxSports_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxSports.CheckedChanged

    End Sub
End Class
