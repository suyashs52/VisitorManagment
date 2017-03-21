Public Class UserDetails


    Private Sub UserDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then

            Me.Close()

        End If

    End Sub

    Private Sub UserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim v As dbVisitor = New dbVisitor()
        v.UserInfo(GlobalV.Username)
        txtName.Text = GlobalV.VName
        txtPhoneNo.Text = GlobalV.VPhone
        txtAddress.Text = GlobalV.VAddress
        txtPassword.Text = GlobalV.Password

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtName.Text) = String.Empty Then
            MessageBox.Show("Name id required")
            Return

        End If

        If Trim(txtPhoneNo.Text) = String.Empty Then
            MessageBox.Show("Name id required")
            Return

        End If

        If Trim(txtAddress.Text) = String.Empty Then
            MessageBox.Show("Name id required")
            Return

        End If

        If Trim(txtPassword.Text) = String.Empty Then
            MessageBox.Show("Name id required")
            Return

        End If

        Dim v As dbVisitor = New dbVisitor()

        GlobalV.VName = txtName.Text
        GlobalV.VPhone = txtPhoneNo.Text
        GlobalV.VAddress = txtAddress.Text
        GlobalV.Password = txtPassword.Text

        v.UserInfoSave()

        Me.Close()

       
    End Sub
End Class