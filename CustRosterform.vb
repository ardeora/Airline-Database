Public Class CustRosterform
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Cutomer_Roster_Report.Show()
        Me.Hide()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        DashBoard.Show()
        Me.Hide()
        CRReserveID.Text = ""
    End Sub
End Class