Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word

Public Class ExportarOffice
    Public Sub ExportarExcel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")

        Dim xlWB As Object = xlApp.workBooks.Add
        Dim xlWS As Object = xlWB.WorkSheets(1)
        Dim ic As Integer
        Dim ir As Integer

        ic = 1
        For Each c As DataGridViewColumn In dgv.Columns
            xlWS.cells(1, ic).value = c.HeaderText
            ic += 1
        Next

        ir = 2
        For Each r As DataGridViewRow In dgv.Rows
            ic = 1
            For Each cell As DataGridViewCell In r.Cells
                xlWS.cells(ir, ic).value = cell.Value
                ic += 1
            Next
            ir += 1
        Next
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing
    End Sub

    Public Sub ExportarWord(ByVal dgv As DataGridView, ByVal Titulo As String)

        Dim Word As Application
        Dim Doc As Document
        Dim table As Table
        Dim prf1 As Paragraph
        Word = CreateObject("Word.Application")
        Word.Visible = False
        Doc = Word.Documents.Add
        prf1 = Doc.Content.Paragraphs.Add
        prf1.Range.Text = Titulo
        prf1.Range.Font.Bold = True
        prf1.Range.Font.Size = 14
        prf1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        prf1.Range.InsertParagraphAfter()

        table = Doc.Tables.Add(Doc.Bookmarks.Item("\endofdoc").Range, dgv.Rows.Count + 1, dgv.Columns.GetColumnCount(Nothing))

        Dim ic As Integer 'indice de columnas
        Dim ir As Integer ' Indice de filas
        ic = 1
        table.Range.Font.Size = 12
        For Each c As DataGridViewColumn In dgv.Columns
            table.Cell(1, ic).Range.Text = c.HeaderText
            ic += 1
        Next
        ir = 2
        For Each r As DataGridViewRow In dgv.Rows
            ic = 1
            For Each cell As DataGridViewCell In r.Cells
                table.Cell(ir, ic).Range.Text = cell.Value
                table.Cell(ir, ic).Range.Font.Bold = False
                ic += 1
            Next
            ir += 1
        Next
        table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleDot
        table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDot
        Word.Visible = True
        Word = Nothing
    End Sub
End Class
