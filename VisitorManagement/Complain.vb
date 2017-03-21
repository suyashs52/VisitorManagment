Public Class Complain

    Private Sub Complain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim v As dbVisitor = New dbVisitor()
            Dim dt As System.Data.DataTable = v.FillBuilding()

            cboBuildingNo.DataSource = Nothing
             
            cboBuildingNo.DisplayMember = "Description"
            cboBuildingNo.ValueMember = "id"
            cboBuildingNo.DataSource = dt

            dt = v.FillFlats(cboBuildingNo.SelectedValue)

            cboFlatNo.DataSource = Nothing
            cboFlatNo.DisplayMember = "Flat"
            cboFlatNo.ValueMember = "id"
            cboFlatNo.DataSource = dt

            If Not GlobalV.IsAdmin Then
                Label2.Visible = False
                txtResolution.Visible = False
                btnUpdate.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub

    Private Sub cboBuildingNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBuildingNo.SelectedIndexChanged
        Try

            Dim v As dbVisitor = New dbVisitor()
            Dim dt As System.Data.DataTable = v.FillFlats(cboBuildingNo.SelectedValue)

            cboFlatNo.DataSource = Nothing
            cboFlatNo.DisplayMember = "Flat"
            cboFlatNo.ValueMember = "id"
            cboFlatNo.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try


    End Sub

    Private Sub txtSubmit_Click(sender As Object, e As EventArgs) Handles txtSubmit.Click
        Dim v As dbVisitor = New dbVisitor()
        Dim c As vComplain = New vComplain()
        c.fk_flats = cboFlatNo.SelectedValue
        c.complain = txtComplain.Text
        c.solution = txtResolution.Text
        c.isissueresolved = chkIssue.Checked
        c.fk_user = GlobalV.Username


        v.complainsave("insert", c)
        Me.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim v As dbVisitor = New dbVisitor()
        Dim c As vComplain = New vComplain()
        c.fk_flats = cboFlatNo.SelectedValue
        c.complain = txtComplain.Text
        c.solution = txtResolution.Text
        c.isissueresolved = chkIssue.Checked
        c.fk_user = GlobalV.Username
        c.Id = lblId.Text

        If Not c.Id = Nothing Then
            v.complainsave("update", c)
        End If


        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class