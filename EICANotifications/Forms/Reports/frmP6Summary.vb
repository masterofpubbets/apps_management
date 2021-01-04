Public Class frmP6Summary
    Private php As New PHPService
    Private Sub GetData()
        Dim dt As New DataTable
        Try
            Dim buffer As String = php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/actids-getx.php", hSSl))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            grd.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            sveFle.FileName = ""
            sveFle.Filter = "XLSX Files|*.xlsx"
            sveFle.ShowDialog()
            If sveFle.FileName = "" Then Exit Sub
            grd.ExportToXlsx(sveFle.FileName)
            Process.Start(sveFle.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmP6Summary_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetData()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GetData()
    End Sub
End Class