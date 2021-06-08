Public Class DambanaReport

    Private Sub DambanaReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
        ExcelMonth.Text = System.DateTime.Now.ToString("MMMM yyyy")
        ReadFirstFile(MainForm.FilePathText.Text.ToString)
        LoadFileToLV(Me.DambanaLV)
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        ReportToExcel(Me.DambanaLV, Me.ExcelMonth.Text.ToString, "Dambana".ToUpper)
    End Sub
End Class
