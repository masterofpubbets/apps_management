Public Class frmPositions
    Private Pos As New Positions

    Private Sub frmPositions_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetData()
    End Sub

    Private Sub GetData()
        grd.DataSource = Pos.GetAllPositions
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GetData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As New frmAddPosition
        frm.ShowDialog(Me)
        If frm.IsSaved Then
            GetData()
        End If
        frm = Nothing
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If gv.RowCount = 0 Then Exit Sub
        Dim msgR As MsgBoxResult = MsgBox("Do You Want To Delete Selected Position?", MsgBoxStyle.YesNo, Me.Text)
        If msgR = MsgBoxResult.No Then Exit Sub
        Dim row_handle As Integer = gv.GetSelectedRows(0)
        If Pos.Delete(gv.GetDataRow(row_handle).Item("PosID").ToString) Then
            MsgBox("Position Has Been Delete.", MsgBoxStyle.Information, Me.Text)
            GetData()
        End If
    End Sub
End Class