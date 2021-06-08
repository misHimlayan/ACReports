Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop

Module ReportModule
    Public ExcelConnection As OLEDBConnection
    Public DataSet As DataSet
    Public ExcelCommand As OleDbCommand
    Public ExcelAdapter As OleDbDataAdapter
    Public ExcelSheet As String
    Public TotalReceipt, TotalCount, TotalDPCCount, TotalDPC, TotalDPRCount, TotalDPR, TotalICRCount, TotalICR, TotalCashSaleCount, TotalCashSale As Double
    Public CountDPC, CountDPR, CountICR, CountCashSale As Integer
    Public DPCValue, DPRValue, ICRValue, CashSaleValue, DPCTotal, DPRTotal, ICRTotal, CashSaleTotal As Double
    Public ExcelApp As New Excel.Application
    Public xWorkbook As Excel.Workbook
    Public xWorksheet As Excel.Worksheet
    Public xRange, xRange1 As Excel.Range
    Public ExcelRows As Integer
    Public DataTable As DataTable

    Public Sub ReadFirstFile(FilePath)
        Try
            ExcelConnection = New OLEDBConnection()
            With ExcelConnection
                .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + FilePath + "; Extended Properties='Excel 8.0; HDR=Yes; IMEX=1;';"
                .Open()
            End With
            'Formats the filename into Excel sheetname
            ExcelSheet = System.IO.Path.GetFileName(FilePath)
            ExcelSheet = ExcelSheet.Substring(0, ExcelSheet.IndexOf("."))
            ExcelSheet = ExcelSheet + "$"
            ExcelCommand = New OleDbCommand
            CommandReports()
            DataSet.Tables.Add(DataTable)

        Catch ex As Exception
            MessageBox.Show("Incorrect Excel file!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub LoadFileToLV(ListView)
        ClearVariables()
        Dim lv As New ListViewItem
        Dim i As Integer
        Dim j As Integer = 0

        ListView.Items.Clear()
        Try
            For i = 0 To DataSet.Tables(0).Rows.Count - 1
                ClearValues()
                For j = 0 To DataSet.Tables(1).Rows.Count - 1
                    If DataSet.Tables(0).Rows(i)("ISYEAR") = DataSet.Tables(1).Rows(j)("ISYEAR") Then
                        'CHECKS IF THE VALUE OF UPDPC IS ZERO IF NOT THEN UPINT WILL BE ADDED TO IT
                        If DataSet.Tables(1).Rows(j)("UPDPC") = 0 Then
                            CountDPC = CountDPC
                            DPCValue = 0
                        Else
                            CountDPC += 1
                            DPCValue = DataSet.Tables(1).Rows(j)("UPDPC") + DataSet.Tables(1).Rows(j)("UPINT")
                        End If
                        'CHECKS IF THE VALUE OF UPDPR IS ZERO IF NOT THEN UPINT WILL BE ADDED TO IT
                        If DataSet.Tables(1).Rows(j)("UPDPR") = 0 Then
                            CountDPR = CountDPR
                            DPRValue = 0
                        Else
                            CountDPR += 1
                            DPRValue = DataSet.Tables(1).Rows(j)("UPDPR") + DataSet.Tables(1).Rows(j)("UPINT")
                        End If
                        'CHECKS IF THE VALUE OF UPICR IS ZERO IF NOT THEN UPINT WILL BE ADDED TO IT
                        If DataSet.Tables(1).Rows(j)("UPICR") = 0 Then
                            CountICR = CountICR
                            ICRValue = 0
                        Else
                            CountICR += 1
                            ICRValue = DataSet.Tables(1).Rows(j)("UPICR") + DataSet.Tables(1).Rows(j)("UPINT")
                        End If
                        'CHECKS IF THE VALUE OF UPCASH IS ZERO IF NOT THEN UPINT WILL BE ADDED TO IT
                        If DataSet.Tables(1).Rows(j)("UPCASH") = 0 Then
                            CountCashSale = CountCashSale
                            CashSaleValue = 0
                        Else
                            CountCashSale += 1
                            CashSaleValue = DataSet.Tables(1).Rows(j)("UPCASH") + DataSet.Tables(1).Rows(j)("UPINT")
                        End If

                        DPCTotal += DPCValue
                        DPRTotal += DPRValue
                        ICRTotal += ICRValue
                        CashSaleTotal += CashSaleValue
                    End If
                Next
                lv = ListView.Items.Add(DataSet.Tables(0).Rows(i)("ISYEAR"))
                lv.SubItems.Add(DataSet.Tables(0).Rows(i)("TOTAL_COUNT"))
                lv.SubItems.Add(String.Format("{0:N2}", DPCTotal + DPRTotal + ICRTotal + CashSaleTotal))
                lv.SubItems.Add(DoubleToString(CountDPC))
                lv.SubItems.Add(String.Format("{0:N2}", DoubleToString(DPCTotal)))
                lv.SubItems.Add(DoubleToString(CountDPR))
                lv.SubItems.Add(String.Format("{0:N2}", DoubleToString(DPRTotal)))
                lv.SubItems.Add(DoubleToString(CountICR))
                lv.SubItems.Add(String.Format("{0:N2}", DoubleToString(ICRTotal)))
                lv.SubItems.Add(DoubleToString(CountCashSale))
                lv.SubItems.Add(String.Format("{0:N2}", DoubleToString(CashSaleTotal)))

            Next

            'Gets the sum of row per column
            For Each LVItem As ListViewItem In ListView.Items
                TotalCount += StringToDouble(LVItem.SubItems(1).Text)
                TotalReceipt += StringToDouble(LVItem.SubItems(2).Text)
                TotalDPCCount += StringToDouble(LVItem.SubItems(3).Text)
                TotalDPC += StringToDouble(LVItem.SubItems(4).Text)
                TotalDPRCount += StringToDouble(LVItem.SubItems(5).Text)
                TotalDPR += StringToDouble(LVItem.SubItems(6).Text)
                TotalICRCount += StringToDouble(LVItem.SubItems(7).Text)
                TotalICR += StringToDouble(LVItem.SubItems(8).Text)
                TotalCashSaleCount += StringToDouble(LVItem.SubItems(9).Text)
                TotalCashSale += StringToDouble(LVItem.SubItems(10).Text)
            Next

            lv = ListView.Items.Add("TOTALS =")
            lv.SubItems.Add(TotalCount)
            lv.SubItems.Add(String.Format("{0:N2}", TotalReceipt))
            lv.SubItems.Add(TotalDPCCount)
            lv.SubItems.Add(String.Format("{0:N2}", TotalDPC))
            lv.SubItems.Add(TotalDPRCount)
            lv.SubItems.Add(String.Format("{0:N2}", TotalDPR))
            lv.SubItems.Add(TotalICRCount)
            lv.SubItems.Add(String.Format("{0:N2}", TotalICR))
            lv.SubItems.Add(TotalCashSaleCount)
            lv.SubItems.Add(String.Format("{0:N2}", TotalCashSale))

            ListView.Items.Item(ListView.Items.Count - 1).Font = New System.Drawing.Font("Century Gothic", 10.5, FontStyle.Bold)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Function DoubleToString(value)
        If value = 0 Then
            value = String.Empty
        Else
            value = Convert.ToDouble(value)
        End If
        Return value
    End Function

    Private Function StringToDouble(value)
        If value = String.Empty Then
            value = 0
        Else
            value = Convert.ToDouble(value)
        End If
        Return value
    End Function

    Public Sub ClearVariables()
        TotalReceipt = 0
        TotalCount = 0
        TotalDPCCount = 0
        TotalDPC = 0
        TotalDPRCount = 0
        TotalDPR = 0
        TotalICRCount = 0
        TotalICR = 0
        TotalCashSaleCount = 0
        TotalCashSale = 0
    End Sub

    Public Sub ClearValues()
        CountDPC = 0
        CountDPR = 0
        CountICR = 0
        CountCashSale = 0
        DPCTotal = 0
        DPRTotal = 0
        ICRTotal = 0
        CashSaleTotal = 0
    End Sub

    Public Sub ReportToExcel(ListView, MonthText, ReportName)
        Try
            Dim i As Integer
            Dim j As Integer
            ExcelApp = New Excel.Application
            xWorkbook = ExcelApp.Workbooks.Add
            xWorksheet = xWorkbook.ActiveSheet
            For i = 0 To ListView.Columns.Count - 1
                xWorksheet.Cells(3, i + 1) = ListView.Columns(i).Text
            Next
            For i = 0 To ListView.Items.Count - 1
                For j = 0 To ListView.Items(i).SubItems.Count - 1
                    xWorksheet.Cells(i + 4, j + 1) = ListView.Items(i).SubItems(j).Text
                Next
            Next

            With xWorksheet.Range("A3", "M3")
                .Font.Bold = True
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .EntireColumn.AutoFit()
            End With

            ExcelRows = ListView.Items.Count + 3

            If ReportName = "SUMMARY" Then
                ExcelFormat(MonthText.ToString, ReportName.ToString)
                xWorksheet.SaveAs("C:\ACReports\Generated Reports\" + ReportName + " OF ACTUAL COLLECTION.xlsx")
                If MessageBox.Show("Reports are located at C:\ACReports\Generated Reports", "EXPORT TO EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                    For Each Process In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                        Process.Kill()
                        Process.WaitForExit()
                    Next
                End If
            Else
                ExcelFormat(MonthText.ToString, ReportName.ToString)
                xWorksheet.SaveAs("C:\ACReports\Generated Reports\ACTUAL COLLECTION OF " + ReportName + ".xlsx")
                If MessageBox.Show("Reports are located at C:\ACReports\Generated Reports", "EXPORT TO EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                    For Each Process In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                        Process.Kill()
                        Process.WaitForExit()
                    Next
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExcelFormat(MonthText, ReportName)
        xWorksheet.Range(ExcelRows.ToString + ":" + ExcelRows.ToString).Font.Bold = True
        xWorksheet.Range("A1:C1").Merge()
        xWorksheet.Range("A2:K2").Merge()
        xWorksheet.Cells(1, 1) = "HIMLAYANG PILIPINO INC."
        If ReportName = "SUMMARY" Then
            xWorksheet.Cells(2, 1) = "SUMMARY OF ACTUAL COLLECTIONS FOR THE MONTH OF " & MonthText.ToUpper
        Else
            xWorksheet.Cells(2, 1) = "SUMMARY OF ACTUAL COLLECTIONS FOR THE MONTH OF " & MonthText.ToUpper & " - " & ReportName.ToUpper
        End If

        xWorksheet.Range("A1:A2").Font.Bold = True
        xWorksheet.Range("3:3").EntireRow.Insert()
        xWorksheet.Range("B4").ColumnWidth = 8
        xWorksheet.Range("B4:K4").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xWorksheet.Range("C4").ColumnWidth = 16
        xWorksheet.Range("D4").ColumnWidth = 4
        xWorksheet.Range("E4").ColumnWidth = 16
        xWorksheet.Range("F4").ColumnWidth = 4
        xWorksheet.Range("G4").ColumnWidth = 16
        xWorksheet.Range("H4").ColumnWidth = 4
        xWorksheet.Range("I4").ColumnWidth = 16
        xWorksheet.Range("J4").ColumnWidth = 4
        xWorksheet.Range("K4").ColumnWidth = 16
    End Sub

    Public Sub CommandReports()
        With ExcelCommand
            .Connection = ExcelConnection
            .CommandType = CommandType.Text
            If MainForm.ButtonClicked = "DAMBANA" Then
                .CommandText = "SELECT ISYEAR, COUNT(*) AS TOTAL_COUNT FROM [" + ExcelSheet + "] WHERE AGRTNO LIKE '%D%' GROUP BY ISYEAR"
            ElseIf MainForm.ButtonClicked = "MEMORIAL" Then
                .CommandText = "SELECT ISYEAR, COUNT(*) AS TOTAL_COUNT FROM [" + ExcelSheet + "] WHERE AGRTNO NOT LIKE '%D%'" _
                        & " AND AGRTNO NOT LIKE '%P%' GROUP BY ISYEAR"
            ElseIf MainForm.ButtonClicked = "PUGAD LAWIN" Then
                .CommandText = "SELECT ISYEAR, COUNT(*) AS TOTAL_COUNT FROM [" + ExcelSheet + "] WHERE AGRTNO LIKE '%P%' GROUP BY ISYEAR"
            Else
                .CommandText = "SELECT ISYEAR, COUNT(*) AS TOTAL_COUNT FROM [" + ExcelSheet + "] GROUP BY ISYEAR"
            End If
        End With

        ExcelAdapter = New OleDbDataAdapter(ExcelCommand)
        DataSet = New DataSet
        ExcelAdapter.Fill(DataSet)

        With ExcelCommand
            .Connection = ExcelConnection
            .CommandType = CommandType.Text
            If MainForm.ButtonClicked = "DAMBANA" Then
                .CommandText = "SELECT ISYEAR, UPDPC, UPDPR, UPICR, UPCASH, UPINT FROM [" + ExcelSheet + "] WHERE AGRTNO LIKE '%D%'"
            ElseIf MainForm.ButtonClicked = "MEMORIAL" Then
                .CommandText = "SELECT ISYEAR, UPDPC, UPDPR, UPICR, UPCASH, UPINT FROM [" + ExcelSheet + "] WHERE AGRTNO NOT LIKE '%D%'" _
                       & " AND AGRTNO NOT LIKE '%P%'"
            ElseIf MainForm.ButtonClicked = "PUGAD LAWIN" Then
                .CommandText = "SELECT ISYEAR, UPDPC, UPDPR, UPICR, UPCASH, UPINT FROM [" + ExcelSheet + "] WHERE AGRTNO LIKE '%P%'"
            Else
                .CommandText = "SELECT ISYEAR, UPDPC, UPDPR, UPICR, UPCASH, UPINT FROM [" + ExcelSheet + "]"
            End If
        End With

        ExcelAdapter = New OleDbDataAdapter(ExcelCommand)
        DataTable = New DataTable
        ExcelAdapter.Fill(DataTable)
    End Sub
End Module
