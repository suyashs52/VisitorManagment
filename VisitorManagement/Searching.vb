Public Class Searching


    Private Sub Searching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim v As dbVisitor = New dbVisitor()
            Dim dt As System.Data.DataTable = v.FillBuilding()



            Dim dtv As DataTable = New DataTable()

            dtv.Columns.Add("id", Type.GetType("System.Int32"))
            dtv.Columns.Add("Name", Type.GetType("System.String"))

            Dim newCustomersRow As DataRow = dtv.NewRow()

            newCustomersRow("id") = 1
            newCustomersRow("Name") = "Name"
            dtv.Rows.Add(newCustomersRow)

            newCustomersRow = dtv.NewRow()
            newCustomersRow("id") = 2
            newCustomersRow("Name") = "PhoneNo"
            dtv.Rows.Add(newCustomersRow)

            newCustomersRow = dtv.NewRow()
            newCustomersRow("id") = 3
            newCustomersRow("Name") = "GovtNo"
            dtv.Rows.Add(newCustomersRow)

            cboVisitor.DataSource = Nothing
            cboVisitor.DisplayMember = "Name"
            cboVisitor.ValueMember = "id"
            cboVisitor.DataSource = dtv


            cboBuildingNo.DataSource = Nothing
            cboBuildingNo.DisplayMember = "Description"
            cboBuildingNo.ValueMember = "id"
            cboBuildingNo.DataSource = dt

            dt = Nothing

            dt = v.FillFlats(cboBuildingNo.SelectedValue)
            Dim nwrow As DataRow = dt.NewRow()
            nwrow("id") = 0
            nwrow("Flat") = "Select"
            dt.Rows.InsertAt(nwrow, 0)

            cboFlatNo.DataSource = Nothing
            cboFlatNo.DisplayMember = "Flat"
            cboFlatNo.ValueMember = "id"
            cboFlatNo.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try

    End Sub

    Private Sub cboBuildingNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBuildingNo.SelectedIndexChanged
        Try

            Dim v As dbVisitor = New dbVisitor()
            Dim dt As System.Data.DataTable = v.FillFlats(cboBuildingNo.SelectedValue)

            Dim nwrow As DataRow = dt.NewRow()
            nwrow("id") = 0
            nwrow("Flat") = "Select"
            dt.Rows.InsertAt(nwrow, 0)

            cboFlatNo.DataSource = Nothing
            cboFlatNo.DisplayMember = "Flat"
            cboFlatNo.ValueMember = "id"
            cboFlatNo.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim v As dbVisitor
            v = New dbVisitor()

            Dim vc As Integer = cboVisitor.SelectedValue
            Dim vq As String = txtVisitor.Text
            Dim Fid As Integer = cboFlatNo.SelectedValue


            Dim dt As DataTable = v.GetSearchRecord(vc, vq, Fid)

            dgSearch.DataSource = Nothing

            dgSearch.DataSource = dt






        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub
End Class