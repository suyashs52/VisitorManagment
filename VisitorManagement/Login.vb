Public Class Login


    Public Event OnLoginButtonClick As EventHandler

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If Control.IsKeyLocked(Keys.CapsLock) Then
            MessageBox.Show("The Caps Lock key is ON.")
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Trim(txtUserName.Text) = String.Empty Then
            MessageBox.Show("Usename required")
            Return

        End If
        If Trim(txtPassword.Text) = String.Empty Then
            MessageBox.Show("Password required")
            Return

        End If
        Dim u As User = New User()
        u.UserName = txtUserName.Text
        u.Password = txtPassword.Text

        Dim v As dbVisitor = New dbVisitor()

        Dim newU As User = v.ValidateLogin(u)
        newU.UserName = u.UserName
        newU.Password = u.Password

        If (newU.Validate = True) Then
            Me.Close()
            RaiseEvent OnLoginButtonClick(newU, Nothing)
        Else
            MessageBox.Show("Invalid Login")
        End If




    End Sub
End Class