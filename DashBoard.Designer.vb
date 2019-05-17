<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlightScheduleButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightScheduleButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.Logout
        Me.PictureBox1.Location = New System.Drawing.Point(1004, 27)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(32, 32)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(32, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FlightScheduleButton
        '
        Me.FlightScheduleButton.BackColor = System.Drawing.Color.Transparent
        Me.FlightScheduleButton.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.FlightSchedule
        Me.FlightScheduleButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlightScheduleButton.Location = New System.Drawing.Point(59, 163)
        Me.FlightScheduleButton.MaximumSize = New System.Drawing.Size(240, 240)
        Me.FlightScheduleButton.MinimumSize = New System.Drawing.Size(240, 240)
        Me.FlightScheduleButton.Name = "FlightScheduleButton"
        Me.FlightScheduleButton.Size = New System.Drawing.Size(240, 240)
        Me.FlightScheduleButton.TabIndex = 1
        Me.FlightScheduleButton.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.PassengerRoster
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(313, 163)
        Me.PictureBox3.MaximumSize = New System.Drawing.Size(443, 240)
        Me.PictureBox3.MinimumSize = New System.Drawing.Size(443, 240)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(443, 240)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.MaintenanceRequest
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(59, 415)
        Me.PictureBox4.MaximumSize = New System.Drawing.Size(697, 211)
        Me.PictureBox4.MinimumSize = New System.Drawing.Size(697, 211)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(697, 211)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.MissingBaggages
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Location = New System.Drawing.Point(770, 163)
        Me.PictureBox5.MaximumSize = New System.Drawing.Size(240, 463)
        Me.PictureBox5.MinimumSize = New System.Drawing.Size(240, 463)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(240, 463)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'DashBoard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.DashBoardBackGround
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.FlightScheduleButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirAmerican Airlines"
        Me.TransparencyKey = System.Drawing.Color.Teal
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightScheduleButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlightScheduleButton As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
