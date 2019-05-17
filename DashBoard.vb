Public Class DashBoard
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LandingPage.Show()
        Me.Hide()
    End Sub

    Private Sub FlightScheduleButton_Click(sender As Object, e As EventArgs) Handles FlightScheduleButton.Click
        FlightScheduleForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        CustRosterform.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MissingBagForm.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MRForm.Show()
        Me.Hide()

    End Sub
End Class