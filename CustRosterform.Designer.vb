<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustRosterform
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
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.CRReserveID = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BackButton.TabIndex = 23
        Me.BackButton.TabStop = False
        '
        'CRReserveID
        '
        Me.CRReserveID.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.CRReserveID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRReserveID.ForeColor = System.Drawing.SystemColors.Window
        Me.CRReserveID.Location = New System.Drawing.Point(538, 279)
        Me.CRReserveID.Name = "CRReserveID"
        Me.CRReserveID.Size = New System.Drawing.Size(303, 38)
        Me.CRReserveID.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.Submit
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(440, 572)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(200, 47)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(200, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 47)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("League Spartan", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(214, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(318, 34)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Flight Reservation ID :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(952, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("League Spartan", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(325, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 44)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Customer Roster Form"
        '
        'CustRosterform
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.CustomerRosterFrm
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CRReserveID)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "CustRosterform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirAmerican Airlines"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As PictureBox
    Friend WithEvents CRReserveID As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
