Public Class Visitor

    Private Sub Visitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try


    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If Trim(txtGovtIdName.Text) = String.Empty Then
                MessageBox.Show("Govt id required")
                Return

            End If

            If Trim(txtGovtNo.Text) = String.Empty Then
                MessageBox.Show("Govt Number required")
                Return

            End If

            If Trim(txtName.Text) = String.Empty Then
                MessageBox.Show("Visitor required")
                Return

            End If

            If Trim(txtPoneNo.Text) = String.Empty Or txtPoneNo.Text.Length <> 10 Then
                MessageBox.Show("Visitor valid Phone No required")
                Return

            End If

            If Trim(txtFrom.Text) = String.Empty Then
                MessageBox.Show("Visitor coming from place required")
                Return

            End If



            If Trim(txtReason.Text) = String.Empty Then
                MessageBox.Show("reason of visiting required")
                Return

            End If

            Dim v As dbVisitor = New dbVisitor()
            v.FlatNo = cboFlatNo.SelectedValue
            v.GovnIdName = txtGovtIdName.Text
            v.GovnNo = txtGovtNo.Text
            v.VisitorName = txtName.Text
            v.PhoneNo = txtPoneNo.Text
            v.Gender = rdoFGender.Checked
            v.FromPlace = txtFrom.Text
            v.Reason = txtReason.Text
 
            v.SaveAVisitor("Save")


            MessageBox.Show("Saved Successfully!")

            lblMsg.Text = String.Empty
            btnUpdate.Visible = True
            btnDelete.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            If Trim(txtGovtIdName.Text) = String.Empty Then
                MessageBox.Show("Govt id required")
                Return

            End If

            If Trim(txtGovtNo.Text) = String.Empty Then
                MessageBox.Show("Govt Number required")
                Return

            End If

            If Trim(txtName.Text) = String.Empty Then
                MessageBox.Show("Visitor required")
                Return

            End If

            If Trim(txtPoneNo.Text) = String.Empty Or txtPoneNo.Text.Length <> 10 Then
                MessageBox.Show("Visitor valid Phone No required")
                Return

            End If

            If Trim(txtFrom.Text) = String.Empty Then
                MessageBox.Show("Visitor coming from place required")
                Return

            End If



            If Trim(txtReason.Text) = String.Empty Then
                MessageBox.Show("reason of visiting required")
                Return

            End If

            Dim v As dbVisitor = New dbVisitor()

            v.FlatNo = cboFlatNo.SelectedValue
            v.GovnIdName = txtGovtIdName.Text
            v.GovnNo = txtGovtNo.Text
            v.VisitorName = txtName.Text
            v.PhoneNo = txtPoneNo.Text
            v.Gender = rdoFGender.Checked
            v.FromPlace = txtFrom.Text
            v.Reason = txtReason.Text
            v.SaveAVisitor("update")


            MessageBox.Show("Updated Successfully")



        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            If Trim(txtGovtIdName.Text) = String.Empty Then
                MessageBox.Show("Govt id required")
                Return

            End If

            If Trim(txtGovtNo.Text) = String.Empty Then
                MessageBox.Show("Govt Number required")
                Return

            End If

            If Trim(txtName.Text) = String.Empty Then
                MessageBox.Show("Visitor required")
                Return

            End If

            If Trim(txtPoneNo.Text) = String.Empty Or txtPoneNo.Text.Length <> 10 Then
                MessageBox.Show("Visitor valid Phone No required")
                Return

            End If

            If Trim(txtFrom.Text) = String.Empty Then
                MessageBox.Show("Visitor coming from place required")
                Return

            End If



            If Trim(txtReason.Text) = String.Empty Then
                MessageBox.Show("reason of visiting required")
                Return

            End If

            Dim v As dbVisitor = New dbVisitor()

            v.FlatNo = cboFlatNo.SelectedValue
            v.GovnIdName = txtGovtIdName.Text
            v.GovnNo = txtGovtNo.Text
            v.VisitorName = txtName.Text
            v.PhoneNo = txtPoneNo.Text
            v.Gender = rdoFGender.Checked
            v.FromPlace = txtFrom.Text
            v.Reason = txtReason.Text
            v.SaveAVisitor("del")


            MessageBox.Show("Record Deleted Successfully")



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


    Private Sub btnVisitorSearch_Click(sender As Object, e As EventArgs) Handles btnVisitorSearch.Click
        Try
            lblMsg.Text = String.Empty

            If Trim(txtGovtIdName.Text) = String.Empty Then
                MessageBox.Show("Govt id required")
                Return

            End If

            If Trim(txtGovtNo.Text) = String.Empty Then
                MessageBox.Show("Govt Number required")
                Return

            End If

            Dim v As dbVisitor = New dbVisitor()
            v.SearchAVisitor(txtGovtIdName.Text, txtGovtNo.Text)
            If v.VisitorName <> String.Empty Then
                txtName.Text = v.VisitorName
                txtPoneNo.Text = v.PhoneNo
                txtFrom.Text = v.FromPlace
                txtReason.Text = v.Reason
                cboBuildingNo.SelectedValue = v.BuildingNo
                cboFlatNo.SelectedValue = v.FlatNo
                rdoMGender.Checked = Not v.Gender
                rdoFGender.Checked = v.Gender

                If v.BVid > 0 Then
                    lblMsg.Text = "blocked visitor"
                End If

            Else
                lblMsg.Text = "No Data Found"
                lblMsg.ForeColor = Color.Red

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())
        End Try
    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtGovtIdName.Text = String.Empty
        txtGovtNo.Text = String.Empty
        txtName.Text = String.Empty
        txtPoneNo.Text = String.Empty
        txtFrom.Text = String.Empty
        rdoFGender.Checked = False
        rdoMGender.Checked = True
        txtReason.Text = String.Empty
        
    End Sub
End Class
