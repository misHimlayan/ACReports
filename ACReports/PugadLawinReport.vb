Public Class PugadLawinReport

    Private Sub PugadLawinReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
        ExcelMonth.Text = System.DateTime.Now.ToString("MMMM yyyy")
        ReadFirstFile(MainForm.FilePathText.Text.ToString)
        LoadFileToLV(Me.PugadLawinLV)
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        ReportToExcel(Me.PugadLawinLV, Me.ExcelMonth.Text.ToString, " Pugad Lawin".ToUpper)
    End Sub
End Class