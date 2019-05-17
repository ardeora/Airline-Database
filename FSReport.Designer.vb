<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSReport
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvFS = New System.Windows.Forms.DataGridView()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        CType(Me.dgvFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("League Spartan", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(326, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flight Schedule Report"
        '
        'dgvFS
        '
        Me.dgvFS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvFS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFS.Location = New System.Drawing.Point(140, 143)
        Me.dgvFS.Name = "dgvFS"
        Me.dgvFS.Size = New System.Drawing.Size(800, 507)
        Me.dgvFS.TabIndex = 2
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.Image = Global.WindowsApp2.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(29, 51)
        Me.BackButton.MaximumSize = New System.Drawing.Size(32, 32)
        Me.BackButton.MinimumSize = New System.Drawing.Size(32, 32)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(32, 32)
        Me.BackButton.TabIndex = 5
        Me.BackButton.TabStop = False
        '
        'FSReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.FlightScheduleForm
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.dgvFS)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "FSReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirAmerican Airlines"
        CType(Me.dgvFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvFS As DataGridView
    Friend WithEvents BackButton As PictureBox
End Class
