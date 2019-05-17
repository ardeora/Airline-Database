Public Class FSReport
    Private Access As New DBControl
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim flightNo As String
        Dim enteredDate As String
        Dim Queries As String

        enteredDate = FlightScheduleForm.FSMonth.Text & "/" & FlightScheduleForm.FSDay.Text & "/" & FlightScheduleForm.FSYear.Text
        flightNo = FlightScheduleForm.FSFlight.Text

        If enteredDate.Length() = 10 And flightNo.Length() <> 6 Then
            Queries = "SELECT FlightSchedule.Flight_Number AS [Flight No], FlightSchedule.Start_Date AS [Departure Date & Time], Airports.AirportName AS Origin, Airports_1.AirportName AS Destination
                   FROM ((FlightSchedule INNER JOIN Routes ON FlightSchedule.Route_Number = Routes.Route_Number) INNER JOIN Airports ON Routes.Origin_ID = Airports.Airport_ID) INNER JOIN Airports AS Airports_1 ON Routes.Destination_ID = Airports_1.Airport_ID
                   WHERE ((FlightSchedule.Start_Date)>=#" & enteredDate & "# And (FlightSchedule.Start_Date)<#" & enteredDate & "#+1);"
        ElseIf enteredDate.Length() <> 10 And flightNo.Length() = 6 Then
            Queries = "SELECT FlightSchedule.Flight_Number AS [Flight No], FlightSchedule.Start_Date AS [Departure Date & Time], Airports.AirportName AS Origin, Airports_1.AirportName AS Destination
                   FROM ((FlightSchedule INNER JOIN Routes ON FlightSchedule.Route_Number = Routes.Route_Number) INNER JOIN Airports ON Routes.Origin_ID = Airports.Airport_ID) INNER JOIN Airports AS Airports_1 ON Routes.Destination_ID = Airports_1.Airport_ID
                   WHERE ((FlightSchedule.Flight_Number)=""" & flightNo & """)"
        ElseIf enteredDate.Length() = 10 And flightNo.Length() = 6 Then
            Queries = "SELECT FlightSchedule.Flight_Number AS [Flight No], FlightSchedule.Start_Date AS [Departure Date & Time], Airports.AirportName AS Origin, Airports_1.AirportName AS Destination
                       FROM((FlightSchedule INNER JOIN Routes ON FlightSchedule.Route_Number = Routes.Route_Number) INNER JOIN Airports On Routes.Origin_ID = Airports.Airport_ID) INNER JOIN Airports As Airports_1 On Routes.Destination_ID = Airports_1.Airport_ID
                       WHERE(((FlightSchedule.Flight_Number) =""" & flightNo & """) And ((FlightSchedule.Start_Date) >= #" & enteredDate & "# And (FlightSchedule.Start_Date) < #" & enteredDate & "#+1))"
        Else
            Queries = "SELECT FlightSchedule.Flight_Number AS [Flight No], FlightSchedule.Start_Date AS [Departure Date & Time], Airports.AirportName AS Origin, Airports_1.AirportName AS Destination
                       FROM((FlightSchedule INNER JOIN Routes ON FlightSchedule.Route_Number = Routes.Route_Number) INNER JOIN Airports On Routes.Origin_ID = Airports.Airport_ID) INNER JOIN Airports As Airports_1 On Routes.Destination_ID = Airports_1.Airport_ID"

        End If

        Access.ExecQuery(Queries)

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvFS.DataSource = Access.DBDT
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        FlightScheduleForm.Show()
        Me.Close()
    End Sub

    Private Sub FSReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class