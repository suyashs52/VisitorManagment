Public Class BlockVisitorList
    Private Sub btnSearch_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearch.CellDoubleClick
        Try

            Dim cellValue As String = dgSearch.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim v As dbVisitor
            v = New dbVisitor()
            Dim vbv As vBlockVisitor = v.GetABlockList(DateTime.Now, cellValue)

            Dim bv As BlockVisitor = New BlockVisitor()
            bv.Show()
            bv.Button1.Enabled = True
            bv.lblMsg.Text = vbv.Id
            bv.txtGovtIdName.Text = vbv.GovnIdName
            bv.txtGovtNo.Text = vbv.GovnNo
            bv.rdoMGender.Checked = IIf(vbv.Gender, False, True)
            bv.rdoFGender.Checked = vbv.Gender
            bv.chkBlock.Checked = vbv.Isblock
            bv.txtReason.Text = vbv.reason
            bv.txtAction.Text = vbv.actiontaken
            bv.txtPoneNo.Text = vbv.PhoneNo
            bv.txtName.Text = vbv.name


        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim v As dbVisitor
            v = New dbVisitor()

            Dim dtF As DateTime = DateTimePicker1.Value

            Dim dt As DataTable = v.GetBlockList(dtF)

            dgSearch.DataSource = Nothing

            dgSearch.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub
End Class