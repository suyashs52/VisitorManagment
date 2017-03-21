Public Class BlockVisitor

   
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
            v.SearchABlockVisitor(txtGovtIdName.Text, txtGovtNo.Text)
            If v.VisitorName <> String.Empty Then
                txtName.Text = v.VisitorName
                txtPoneNo.Text = v.PhoneNo
                rdoMGender.Checked = Not v.Gender
                rdoFGender.Checked = v.Gender
                lblMsg.Text = v.id

            Else
                lblMsg.Text = "No Data Found"
                lblMsg.ForeColor = Color.Red

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())
        End Try
    End Sub

    Private Sub BlockVisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim v As dbVisitor = New dbVisitor()
        Dim b As vBlockVisitor = New vBlockVisitor()

        b.Id = lblMsg.Text
        b.Isblock = chkBlock.Checked
        b.reason = Formatting.ConvertNullToString(txtReason.Text)
        b.actiontaken = Formatting.ConvertNullToString(txtAction.Text)

        b.fk_user = GlobalV.Username

        v.bcedit("insert", b)
        Me.Close()

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v As dbVisitor = New dbVisitor()
        Dim b As vBlockVisitor = New vBlockVisitor()

        b.Id = lblMsg.Text
        b.Isblock = chkBlock.Checked
        b.reason = txtReason.Text
        b.actiontaken = txtAction.Text
        b.fk_user = GlobalV.Username

        v.bcedit("update", b)
        Me.Close()
         
    End Sub
End Class