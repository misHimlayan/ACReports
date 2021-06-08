
Public Class MainForm
    Public ButtonClicked As String = String.Empty

    Private Sub DambanaButton_Click(sender As Object, e As EventArgs) Handles DambanaButton.Click
        If FilePathText.Text = String.Empty Then
            MessageBox.Show("Select an Excel file (.xls) first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ButtonClicked = DambanaButton.Text
            DambanaReport.Show()
        End If
    End Sub

    Private Sub MemorialButton_Click(sender As Object, e As EventArgs) Handles MemorialButton.Click
        If FilePathText.Text = String.Empty Then
            MessageBox.Show("Select an Excel file (.xls) first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ButtonClicked = MemorialButton.Text
            MemorialReport.Show()
        End If

    End Sub

    Private Sub PugadLawinButton_Click(sender As Object, e As EventArgs) Handles PugadLawinButton.Click
        If FilePathText.Text = String.Empty Then
            MessageBox.Show("Select an Excel file (.xls) first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ButtonClicked = PugadLawinButton.Text
            PugadLawinReport.Show()
        End If
    End Sub

    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton.Click
        Dim BrowseFileDialog As New OpenFileDialog
        With BrowseFileDialog
            .Title = "Please select a file | EXCEL FILES (.XLS)"
            .InitialDirectory = "C:\Users\PC-122\Downloads"
            .Filter = "Excel Files|*.XLS"
            .Multiselect = False
            .CheckFileExists = True
            .CheckPathExists = True
        End With
        If BrowseFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FilePathText.Text = BrowseFileDialog.FileName
        End If
    End Sub

    Private Sub SummaryButton_Click_1(sender As Object, e As EventArgs) Handles SummaryButton.Click
        If FilePathText.Text = String.Empty Then
            MessageBox.Show("Select an Excel file (.xls) first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ButtonClicked = SummaryButton.Text
            SummaryReport.Show()
        End If
    End Sub
End Class