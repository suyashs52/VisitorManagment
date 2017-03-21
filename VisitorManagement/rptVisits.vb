Imports Microsoft.Reporting.WinForms

Public Class rptVisits

    Private Sub rptVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
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
            Dim datasource As New ReportDataSource("dtVisitor", dt)

            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
            Me.ReportViewer1.RefreshReport()


        Catch ex As Exception
            MessageBox.Show(ex.Message().ToString())

        End Try
    End Sub

     
End Class