Public Class ComplainList


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim cellValue As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim v As dbVisitor
            v = New dbVisitor()

            Dim vbv As vComplain = v.GetAComplainList(DateTime.Today, cellValue)

            Dim c As Complain = New Complain()
            c.Show()
            c.lblId.Text = cellValue
            c.btnUpdate.Enabled = True
            c.cboBuildingNo.SelectedValue = vbv.FK_Buildings
            c.cboFlatNo.SelectedValue = vbv.fk_flats
            c.txtResolution.Text = vbv.solution
            c.txtComplain.Text = vbv.complain


        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim v As dbVisitor
            v = New dbVisitor()

            Dim dtF As DateTime = DateTimePicker1.Value



            Dim dt As DataTable = v.GetComplainList(dtF)

            DataGridView1.DataSource = Nothing

            DataGridView1.DataSource = dt






        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub
End Class