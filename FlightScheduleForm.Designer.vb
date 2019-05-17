<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlightScheduleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlightScheduleForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FSDay = New System.Windows.Forms.TextBox()
        Me.FSMonth = New System.Windows.Forms.TextBox()
        Me.FSYear = New System.Windows.Forms.TextBox()
        Me.FSFlight = New System.Windows.Forms.TextBox()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("League Spartan", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(340, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flight Schedule Form"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(952, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("League Spartan", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(427, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Day :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("League Spartan", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(415, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 34)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("League Spartan", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(391, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 34)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Month :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("League Spartan", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(364, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 34)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Flight No."
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.Submit
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(440, 523)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(200, 47)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(200, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 47)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'FSDay
        '
        Me.FSDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.FSDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSDay.ForeColor = System.Drawing.SystemColors.Window
        Me.FSDay.Location = New System.Drawing.Point(519, 205)
        Me.FSDay.Name = "FSDay"
        Me.FSDay.Size = New System.Drawing.Size(186, 38)
        Me.FSDay.TabIndex = 7
        '
        'FSMonth
        '
        Me.FSMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.FSMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSMonth.ForeColor = System.Drawing.SystemColors.Window
        Me.FSMonth.Location = New System.Drawing.Point(519, 265)
        Me.FSMonth.Name = "FSMonth"
        Me.FSMonth.Size = New System.Drawing.Size(186, 38)
        Me.FSMonth.TabIndex = 8
        '
        'FSYear
        '
        Me.FSYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.FSYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSYear.ForeColor = System.Drawing.SystemColors.Window
        Me.FSYear.Location = New System.Drawing.Point(519, 321)
        Me.FSYear.Name = "FSYear"
        Me.FSYear.Size = New System.Drawing.Size(186, 38)
        Me.FSYear.TabIndex = 9
        '
        'FSFlight
        '
        Me.FSFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.FSFlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSFlight.ForeColor = System.Drawing.SystemColors.Window
        Me.FSFlight.Location = New System.Drawing.Point(519, 377)
        Me.FSFlight.Name = "FSFlight"
        Me.FSFlight.Size = New System.Drawing.Size(186, 38)
        Me.FSFlight.TabIndex = 10
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Image = Global.WindowsApp2.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(12, 31)
        Me.BackButton.MaximumSize = New System.Drawing.Size(32, 32)
        Me.BackButton.MinimumSize = New System.Drawing.Size(32, 32)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(32, 32)
        Me.BackButton.TabIndex = 11
        Me.BackButton.TabStop = False
        '
        'FlightScheduleForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.FlightScheduleForm
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.FSFlight)
        Me.Controls.Add(Me.FSYear)
        Me.Controls.Add(Me.FSMonth)
        Me.Controls.Add(Me.FSDay)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "FlightScheduleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirAmerican Airlines"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FSDay As TextBox
    Friend WithEvents FSMonth As TextBox
    Friend WithEvents FSYear As TextBox
    Friend WithEvents FSFlight As TextBox
    Friend WithEvents BackButton As PictureBox
End Class
