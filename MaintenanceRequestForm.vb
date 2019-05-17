Public Class MRForm
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        MREmp.Text = ""
        MRTail.Text = ""
        MRSev.Text = ""
        MRDesc.Text = ""
        SuccessAlert.Show()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        DashBoard.Show()
        Me.Hide()
    End Sub
End Class