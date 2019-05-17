<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MissingBagReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MissingBagReport))
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMB = New System.Windows.Forms.DataGridView()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMB, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BackButton.TabIndex = 27
        Me.BackButton.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("League Spartan", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(323, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 44)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Missing Baggage Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMB
        '
        Me.dgvMB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMB.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.dgvMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMB.Location = New System.Drawing.Point(140, 162)
        Me.dgvMB.Name = "dgvMB"
        Me.dgvMB.Size = New System.Drawing.Size(800, 507)
        Me.dgvMB.TabIndex = 25
        '
        'MissingBagReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.MissingBaggageForm
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "MissingBagReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MissingBagReport"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMB As DataGridView
End Class
