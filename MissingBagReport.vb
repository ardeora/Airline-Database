Public Class MissingBagReport

    Private Access As New DBControl
    Private Sub MissingBagReport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim tripID As String
        Dim Queries As String

        tripID = MissingBagForm.MBTripID.Text

        If tripID = "" Then
            Queries = ""
        Else
            Queries = "SELECT Customers.First_Name AS [First Name], Customers.Last_Name AS [Last Name], [Missing Baggage].Status, [Missing Baggage].Description AS [Details]
                      From Customers INNER Join [Missing Baggage] On Customers.Customer_ID = [Missing Baggage].Customer_ID
                      Where ((([Missing Baggage].TripID)=""" & tripID & """));"
        End If

        Access.ExecQuery(Queries)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvMB.DataSource = Access.DBDT
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MissingBagForm.Show()
        Me.Close()

    End Sub
End Class