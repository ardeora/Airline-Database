Public Class FlightScheduleForm
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        FSDay.Text = ""
        FSMonth.Text = ""
        FSYear.Text = ""
        FSFlight.Text = ""
        DashBoard.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FSReport.Show()
        Me.Hide()
    End Sub
End Class