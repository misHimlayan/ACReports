﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemorialReport
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExcelMonth = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MemorialLV = New System.Windows.Forms.ListView()
        Me.Year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalReceipt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CountDPC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DPC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CountDPR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DPR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CountICR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ICR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CountCashSale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CashSale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 525)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "HIMLAYANG PILIPINO INC."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 550)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "JANUARY 17, 2020"
        '
        'ExcelMonth
        '
        Me.ExcelMonth.AutoSize = True
        Me.ExcelMonth.ForeColor = System.Drawing.Color.Black
        Me.ExcelMonth.Location = New System.Drawing.Point(239, 525)
        Me.ExcelMonth.Name = "ExcelMonth"
        Me.ExcelMonth.Size = New System.Drawing.Size(0, 17)
        Me.ExcelMonth.TabIndex = 13
        Me.ExcelMonth.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.SplitContainer1.Panel1.Controls.Add(Me.GenerateButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MemorialLV)
        Me.SplitContainer1.Size = New System.Drawing.Size(1279, 579)
        Me.SplitContainer1.SplitterDistance = 40
        Me.SplitContainer1.TabIndex = 14
        '
        'GenerateButton
        '
        Me.GenerateButton.BackColor = System.Drawing.Color.DarkGreen
        Me.GenerateButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.GenerateButton.FlatAppearance.BorderSize = 0
        Me.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateButton.ForeColor = System.Drawing.Color.White
        Me.GenerateButton.Location = New System.Drawing.Point(1133, 0)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(146, 40)
        Me.GenerateButton.TabIndex = 6
        Me.GenerateButton.Text = "Export to Excel"
        Me.GenerateButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SUMMARY OF ACTUAL COLLECTIONS - MEMORIAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MemorialLV
        '
        Me.MemorialLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Year, Me.Count, Me.TotalReceipt, Me.CountDPC, Me.DPC, Me.CountDPR, Me.DPR, Me.CountICR, Me.ICR, Me.CountCashSale, Me.CashSale})
        Me.MemorialLV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MemorialLV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemorialLV.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemorialLV.FullRowSelect = True
        Me.MemorialLV.GridLines = True
        Me.MemorialLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MemorialLV.Location = New System.Drawing.Point(0, 0)
        Me.MemorialLV.Name = "MemorialLV"
        Me.MemorialLV.ShowItemToolTips = True
        Me.MemorialLV.Size = New System.Drawing.Size(1279, 535)
        Me.MemorialLV.TabIndex = 5
        Me.MemorialLV.UseCompatibleStateImageBehavior = False
        Me.MemorialLV.View = System.Windows.Forms.View.Details
        '
        'Year
        '
        Me.Year.Text = "YEAR"
        Me.Year.Width = 74
        '
        'Count
        '
        Me.Count.Text = "COUNT"
        Me.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Count.Width = 84
        '
        'TotalReceipt
        '
        Me.TotalReceipt.Text = "TOTAL RECEIPT"
        Me.TotalReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalReceipt.Width = 160
        '
        'CountDPC
        '
        Me.CountDPC.Text = "CNT"
        Me.CountDPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DPC
        '
        Me.DPC.Text = "D.P.C"
        Me.DPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DPC.Width = 150
        '
        'CountDPR
        '
        Me.CountDPR.Text = "CNT"
        Me.CountDPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CountDPR.Width = 84
        '
        'DPR
        '
        Me.DPR.Text = "D.P.R"
        Me.DPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DPR.Width = 150
        '
        'CountICR
        '
        Me.CountICR.Text = "CNT"
        Me.CountICR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CountICR.Width = 84
        '
        'ICR
        '
        Me.ICR.Text = "I.C.R"
        Me.ICR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ICR.Width = 150
        '
        'CountCashSale
        '
        Me.CountCashSale.Text = "CNT"
        Me.CountCashSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CountCashSale.Width = 84
        '
        'CashSale
        '
        Me.CashSale.Text = "CASH SALE"
        Me.CashSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CashSale.Width = 150
        '
        'MemorialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1279, 579)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ExcelMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MemorialReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExcelMonth As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MemorialLV As System.Windows.Forms.ListView
    Friend WithEvents Year As System.Windows.Forms.ColumnHeader
    Friend WithEvents Count As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalReceipt As System.Windows.Forms.ColumnHeader
    Friend WithEvents CountDPC As System.Windows.Forms.ColumnHeader
    Friend WithEvents DPC As System.Windows.Forms.ColumnHeader
    Friend WithEvents CountDPR As System.Windows.Forms.ColumnHeader
    Friend WithEvents DPR As System.Windows.Forms.ColumnHeader
    Friend WithEvents CountICR As System.Windows.Forms.ColumnHeader
    Friend WithEvents ICR As System.Windows.Forms.ColumnHeader
    Friend WithEvents CountCashSale As System.Windows.Forms.ColumnHeader
    Friend WithEvents CashSale As System.Windows.Forms.ColumnHeader
End Class
