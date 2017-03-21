Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyInfoToolStripMenuItem.Visible = False
        ReportToolStripMenuItem.Visible = False
        ListToolStripMenuItem.Visible = False
        ViewToolStripMenuItem.Visible = False
        RegisterToolStripMenuItem.Visible = False
        NewToolStripMenuItem1.Visible = False

    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        Try

            Dim v As Visitor
            v = New Visitor()
            v.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub

    Private Sub OccuranceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OccuranceToolStripMenuItem.Click
        Try

            Dim v As Searching
            v = New Searching
            v.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Try

            Dim v As Visitor
            v = New Visitor()
            v.btnUpdate.Visible = False
            v.btnDelete.Visible = False
            v.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub

    Private Sub DetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem1.Click
        Try

            Dim v As Searching
            v = New Searching
            v.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub

  

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim v As dbVisitor
            v = New dbVisitor()

            Dim dtF As DateTime = dtFrom.Value
            Dim dtt As DateTime = dtTo.Value

            If dtF > dtt Then
                MessageBox.Show("Invalid date selection")
                Return

            End If

            Dim dt As DataTable = v.GetSearchList(dtF, dtt)

            dgSearch.DataSource = Nothing

            dgSearch.DataSource = dt






        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If btnLogin.Text = "Login" Then
            Dim v As Login
            v = New Login()

            AddHandler v.OnLoginButtonClick, AddressOf login_Click
            v.Show()
        Else
            'logout hide
            Dim u As User = New User()
            u.UserName = GlobalV.Username

            Dim v As dbVisitor = New dbVisitor()

            Dim newU As User = v.LogOut(u)
            btnForget.Visible = True
           
            MyInfoToolStripMenuItem.Visible = False
            ReportToolStripMenuItem.Visible = False
            ListToolStripMenuItem.Visible = False
            ViewToolStripMenuItem.Visible = False
            RegisterToolStripMenuItem.Visible = False
            NewToolStripMenuItem1.Visible = False

            GlobalV.Username = Nothing
            GlobalV.IsAdmin = Nothing
            GlobalV.IsLogin = Nothing

            btnLogin.Text = "Login"


        End If

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

        Dim v As rptVisits
        v = New rptVisits()
        v.Show()

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs)
        Try
            Dim u As User = sender

            If u.Validate Then
                btnLogin.Text = "Logout"

                GlobalV.Username = u.UserName
                GlobalV.IsAdmin = u.Admin
                GlobalV.IsLogin = u.Validate
                btnForget.Visible = False
                MyInfoToolStripMenuItem.Visible = True
                RegisterToolStripMenuItem.Visible = True
                NewToolStripMenuItem1.Visible = True

                If u.Admin Then
                    ReportToolStripMenuItem.Visible = True
                    ListToolStripMenuItem.Visible = True
                    ViewToolStripMenuItem.Visible = True
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try

    End Sub

    Private Sub btnForget_Click(sender As Object, e As EventArgs) Handles btnForget.Click
        Dim v As Password
        v = New Password()
        v.Show()
    End Sub

    Private Sub MyInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyInfoToolStripMenuItem.Click
        Dim v As UserDetails
        v = New UserDetails()
        v.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim v As ComplainList
        v = New ComplainList()
        v.Show()
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Dim v As BlockVisitorList
        v = New BlockVisitorList()
        v.Show()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Dim v As BlockVisitor
        v = New BlockVisitor()
        v.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Dim v As Complain
        v = New Complain()
        v.Show()
    End Sub
End Class