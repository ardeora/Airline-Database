<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cutomer_Roster_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cutomer_Roster_Report))
        Me.dgvCR = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        CType(Me.dgvCR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCR
        '
        Me.dgvCR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCR.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCR.Location = New System.Drawing.Point(140, 143)
        Me.dgvCR.Name = "dgvCR"
        Me.dgvCR.Size = New System.Drawing.Size(800, 507)
        Me.dgvCR.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("League Spartan", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(325, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 44)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Customer Roster Report"
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
        Me.BackButton.TabIndex = 24
        Me.BackButton.TabStop = False
        '
        'Cutomer_Roster_Report
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.CustomerRosterFrm1
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "Cutomer_Roster_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirAmerica Airlines"
        CType(Me.dgvCR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCR As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As PictureBox
End Class
