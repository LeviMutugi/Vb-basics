Public Class Welcoming_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim secondForm As New Object_Demo()
        secondForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub
End Class
