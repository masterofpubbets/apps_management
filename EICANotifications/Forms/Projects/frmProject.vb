Public Class frmProject
    Private Pro As New Projects


    Private Sub frmProject_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetData()
    End Sub

    Private Sub GetData()
        grd.DataSource = Pro.GetAllProjects
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GetData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As New frmAddProject
        frm.ShowDialog(Me)
        If frm.isAdded Then
            GetData()
        End If
        frm = Nothing
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If gv.RowCount = 0 Then Exit Sub
        Dim row_handle As Integer = gv.GetSelectedRows(0)
        Dim frm As New frmEditProject() With {.ProID = gv.GetDataRow(row_handle).Item("ID").ToString}
        frm.txtLocation.Text = gv.GetDataRow(row_handle).Item("Location").ToString
        frm.txtName.Text = gv.GetDataRow(row_handle).Item("Name").ToString
        frm.txtNumber.Text = gv.GetDataRow(row_handle).Item("Number").ToString
        frm.ShowDialog(Me)
        If frm.isUpdated Then
            GetData()
        End If
        frm = Nothing
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If gv.RowCount = 0 Then Exit Sub
        Dim msgR As MsgBoxResult = MsgBox("Do You Want To Delete Selected Project?", MsgBoxStyle.YesNo, Me.Text)
        If msgR = MsgBoxResult.No Then Exit Sub
        Dim row_handle As Integer = gv.GetSelectedRows(0)
        If Pro.Delete(gv.GetDataRow(row_handle).Item("ID").ToString) Then
            MsgBox("Project Has Been Delete.", MsgBoxStyle.Information, Me.Text)
            GetData()
        End If
    End Sub
End Class