Public Class frmAppUpdates
    Private AppUp As New AppUpdates

    Private Sub frmAppUpdates_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetUpdates()
    End Sub

    Private Sub GetUpdates()
        grdUpdate.DataSource = AppUp.GetAllUpdates
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GetUpdates()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If gvUpdate.RowCount = 0 Then Exit Sub
        Dim rh As Integer = gvUpdate.GetSelectedRows(0)
        If rh < 0 Then Exit Sub
        Dim msgR As MsgBoxResult = MsgBox("Do You Want To Delete Selected Update?", MsgBoxStyle.YesNo, "Employee Management")
        If msgR = MsgBoxResult.No Then Exit Sub
        If AppUp.DeleteUpdate(gvUpdate.GetDataRow(rh).Item("ID"), gvUpdate.GetDataRow(rh).Item("file_name")) Then
            GetUpdates()
            MsgBox("Update Has Been Deleted.", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As New frmAddUpdate
        frm.ShowDialog(Me)
        If frm.IsAdded Then
            GetUpdates()
        End If
        frm = Nothing
    End Sub
End Class