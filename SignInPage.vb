Public Class SignInPage
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim uname As String
        Dim pword As String

        uname = Username.Text
        pword = Password.Text

        If uname = "Admin" And pword = "abcde" Then
            DashBoard.Show()
            Me.Hide()
            Username.Text = ""
            Password.Text = ""
        Else
            MsgBox("Incorrect Login Credentials!", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        LandingPage.Show()
        Me.Hide()
    End Sub
End Class