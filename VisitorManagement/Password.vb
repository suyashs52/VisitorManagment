Public Class Password

    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Enabled = False
        btnSubmit.Visible = False

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If Trim(txtKey.Text) = String.Empty Then
            MessageBox.Show("Key required")
            Return

        End If

        Dim u As User = New User()
        u.Password = txtKey.Text
        u.UserName = String.Empty
        Dim v As dbVisitor = New dbVisitor()
        Dim nw As User = v.isloginValid(u)
        If (nw.Validate) Then
            txtKey.Enabled = False
            txtPassword.Enabled = True
            btnSubmit.Visible = True
        Else
            MessageBox.Show("Invalid Key! Contact Admin")
        End If


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Trim(txtPassword.Text) = String.Empty Then
            MessageBox.Show("Password required")
            Return

        End If
        If Trim(txtKey.Text) = String.Empty Then
            MessageBox.Show("Key required")
            Return

        End If
        Dim u As User = New User()
        u.Password = txtPassword.Text
        u.UserName = txtKey.Text
        Dim v As dbVisitor = New dbVisitor()
        Dim nw As User = v.SavePassword(u)

        MessageBox.Show("saved successfully")
 

    End Sub
End Class