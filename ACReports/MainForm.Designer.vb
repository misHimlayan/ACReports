<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DambanaButton = New System.Windows.Forms.Button()
        Me.PugadLawinButton = New System.Windows.Forms.Button()
        Me.MemorialButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FilePathText = New System.Windows.Forms.TextBox()
        Me.OpenFileButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 38)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACTUAL COLLECTION REPORTS"
        '
        'DambanaButton
        '
        Me.DambanaButton.BackColor = System.Drawing.Color.SteelBlue
        Me.DambanaButton.FlatAppearance.BorderSize = 0
        Me.DambanaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DambanaButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DambanaButton.ForeColor = System.Drawing.Color.White
        Me.DambanaButton.Location = New System.Drawing.Point(127, 95)
        Me.DambanaButton.Name = "DambanaButton"
        Me.DambanaButton.Size = New System.Drawing.Size(96, 46)
        Me.DambanaButton.TabIndex = 3
        Me.DambanaButton.Text = "DAMBANA"
        Me.DambanaButton.UseVisualStyleBackColor = False
        '
        'PugadLawinButton
        '
        Me.PugadLawinButton.BackColor = System.Drawing.Color.SteelBlue
        Me.PugadLawinButton.FlatAppearance.BorderSize = 0
        Me.PugadLawinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PugadLawinButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PugadLawinButton.ForeColor = System.Drawing.Color.White
        Me.PugadLawinButton.Location = New System.Drawing.Point(357, 95)
        Me.PugadLawinButton.Name = "PugadLawinButton"
        Me.PugadLawinButton.Size = New System.Drawing.Size(96, 46)
        Me.PugadLawinButton.TabIndex = 4
        Me.PugadLawinButton.Text = "PUGAD LAWIN"
        Me.PugadLawinButton.UseVisualStyleBackColor = False
        '
        'MemorialButton
        '
        Me.MemorialButton.BackColor = System.Drawing.Color.SteelBlue
        Me.MemorialButton.FlatAppearance.BorderSize = 0
        Me.MemorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MemorialButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemorialButton.ForeColor = System.Drawing.Color.White
        Me.MemorialButton.Location = New System.Drawing.Point(242, 95)
        Me.MemorialButton.Name = "MemorialButton"
        Me.MemorialButton.Size = New System.Drawing.Size(96, 46)
        Me.MemorialButton.TabIndex = 5
        Me.MemorialButton.Text = "MEMORIAL"
        Me.MemorialButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Excel File"
        '
        'FilePathText
        '
        Me.FilePathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilePathText.Enabled = False
        Me.FilePathText.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilePathText.Location = New System.Drawing.Point(70, 50)
        Me.FilePathText.Name = "FilePathText"
        Me.FilePathText.Size = New System.Drawing.Size(329, 26)
        Me.FilePathText.TabIndex = 7
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Location = New System.Drawing.Point(405, 48)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(48, 30)
        Me.OpenFileButton.TabIndex = 8
        Me.OpenFileButton.Text = "..."
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SummaryButton.FlatAppearance.BorderSize = 0
        Me.SummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SummaryButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryButton.ForeColor = System.Drawing.Color.White
        Me.SummaryButton.Location = New System.Drawing.Point(12, 95)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(96, 46)
        Me.SummaryButton.TabIndex = 9
        Me.SummaryButton.Text = "SUMMARY"
        Me.SummaryButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 163)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.OpenFileButton)
        Me.Controls.Add(Me.FilePathText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MemorialButton)
        Me.Controls.Add(Me.PugadLawinButton)
        Me.Controls.Add(Me.DambanaButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DambanaButton As System.Windows.Forms.Button
    Friend WithEvents PugadLawinButton As System.Windows.Forms.Button
    Friend WithEvents MemorialButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FilePathText As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileButton As System.Windows.Forms.Button
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
End Class
