Imports System.IO

Public Class Object_Demo
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the selected file path
                Dim imagePath As String = openFileDialog.FileName

                ' Check if the file exists
                If File.Exists(imagePath) Then
                    ' Load the image into the PictureBox
                    PictureBox1.Image = Image.FromFile(imagePath)
                Else
                    MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form1 As New Welcoming_form()

        form1.Show()

        Me.Close()


    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox1.Font = New Font("Garamond", TextBox1.Font.Size, TextBox1.Font.Style)
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox1.Font = New Font("Magneto", TextBox1.Font.Size, TextBox1.Font.Style)
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.Font = New Font("Tahoma", TextBox1.Font.Size, TextBox1.Font.Style)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold And FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Italic Or FontStyle.Bold)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox1.ForeColor = Color.Green
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox1.ForeColor = Color.Red
        End If
    End Sub
End Class