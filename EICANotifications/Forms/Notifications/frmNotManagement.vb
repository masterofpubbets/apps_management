Public Class frmNotManagement
    Private nots As New Notifications

    Private sub GetData()
        grd.DataSource=nots.GetAllNotifications 
    End sub

    Private Sub frmNotManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GetData()
    End Sub

    Private Sub grd_Click(sender As Object, e As EventArgs) Handles grd.Click
        If gv.RowCount = 0 Then Exit Sub
        Dim row_handle As Integer = gv.GetSelectedRows(0)
        If row_handle < 0 Then Exit Sub
        nots.LoadNotImage(gv.GetDataRow(row_handle).Item("ID").ToString, Pic01.Image, Pic02.Image, Pic03.Image)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As New frmAddNotification
        frm.ShowDialog(Me)
        If frm.IsAdded Then
            GetData()
        End If
        frm = Nothing
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim msgR As MsgBoxResult = MsgBox("Do You Want To Delete Selected Notification?", MsgBoxStyle.YesNo, Me.Text)
        If msgR = MsgBoxResult.No Then Exit Sub
        If gv.RowCount = 0 Then Exit Sub
        Dim row_handle As Integer = gv.GetSelectedRows(0)
        If row_handle < 0 Then Exit Sub
        If nots.Delete(gv.GetDataRow(row_handle).Item("ID").ToString) Then
            MsgBox("Notification Has Been Deleted", MsgBoxStyle.Information, Me.Text)
            GetData()
        End If
    End Sub
End Class