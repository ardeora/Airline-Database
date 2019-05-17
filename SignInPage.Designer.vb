<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignInPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignInPage))
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.SystemColors.Window
        Me.Username.Location = New System.Drawing.Point(544, 319)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(200, 31)
        Me.Username.TabIndex = 0
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.SystemColors.Window
        Me.Password.Location = New System.Drawing.Point(544, 385)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(200, 31)
        Me.Password.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.SignIn
        Me.PictureBox1.Location = New System.Drawing.Point(383, 508)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(314, 74)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(314, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 74)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Image = Global.WindowsApp2.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(14, 17)
        Me.BackButton.MaximumSize = New System.Drawing.Size(32, 32)
        Me.BackButton.MinimumSize = New System.Drawing.Size(32, 32)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(32, 32)
        Me.BackButton.TabIndex = 4
        Me.BackButton.TabStop = False
        '
        'SignInPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.SignInPage
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "SignInPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirAmerica Airlines"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackButton As PictureBox
End Class
