Public Class Cutomer_Roster_Report

    Private Access As New DBControl
    Private Sub Cutomer_Roster_Report_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim ReservationID As String
        Dim Queries As String

        ReservationID = CustRosterform.CRReserveID.Text

        If ReservationID = "" Then
            Queries = ""
        Else
            Queries = "SELECT Customers.First_Name AS [First Name], Customers.Last_Name AS [Last Name], FlightSchedule.Flight_Number AS [Flight Number], FlightSchedule.Flight_Reservation_ID AS [Reservation ID]
                       FROM Customers INNER JOIN (FlightSchedule INNER JOIN Bookings ON FlightSchedule.Flight_Reservation_ID = Bookings.Flight_Reservation_ID) ON Customers.Customer_ID = Bookings.Customer_ID 
                       WHERE (((FlightSchedule.Flight_Reservation_ID)=" & ReservationID & "));"
        End If

        Access.ExecQuery(Queries)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvCR.DataSource = Access.DBDT
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CustRosterform.Show()
        Me.Close()

    End Sub

    Private Sub Cutomer_Roster_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class