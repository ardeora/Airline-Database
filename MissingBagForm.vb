Public Class MissingBagForm
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MissingBagReport.Show()
        Me.Hide()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        DashBoard.Show()
        MBTripID.Text = ""
        Me.Hide()
    End Sub
End Class