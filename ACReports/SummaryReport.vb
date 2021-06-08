Public Class SummaryReport

    Private Sub SummaryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
        ExcelMonth.Text = System.DateTime.Now.ToString("MMMM yyyy")
        ReadFirstFile(MainForm.FilePathText.Text.ToString)
        LoadFileToLV(Me.SummaryLV)
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        ReportToExcel(Me.SummaryLV, Me.ExcelMonth.Text.ToString, "SUMMARY".ToUpper)
    End Sub
End Class