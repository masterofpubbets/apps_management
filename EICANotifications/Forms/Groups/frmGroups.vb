Public Class frmGroups
    Private g As New Groups
    Private Sub GetGroups()
        grdPos.DataSource = g.GetAllGroups
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GetGroups()
    End Sub

    Private Sub frmGroups_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetGroups()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As New frmAddGroup
        frm.ShowDialog(Me)
        If frm.IsSaved Then
            GetGroups()
        End If
        frm = Nothing
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If GridView1.RowCount = 0 Then Exit Sub
        Dim rh As Integer = GridView1.GetSelectedRows(0)
        If rh < 0 Then Exit Sub
        Dim frm As New frmEditGroup() With {.GroupID = GridView1.GetDataRow(rh).Item("Group_ID")}
        frm.lblOldGroupName.Text = GridView1.GetDataRow(rh).Item("Group_Name")
        frm.txtName.Text = GridView1.GetDataRow(rh).Item("Group_Name")
        frm.txtDescription.Text = GridView1.GetDataRow(rh).Item("Group_Description")
        frm.ShowDialog(Me)
        If frm.IsSaved Then
            GetGroups()
        End If
        frm = Nothing
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If GridView1.RowCount = 0 Then Exit Sub
        Dim rh As Integer = GridView1.GetSelectedRows(0)
        If rh < 0 Then Exit Sub
        Dim msgR As MsgBoxResult = MsgBox(String.Format("Do You Want To Delete Group{0}{1}?", vbCrLf, GridView1.GetDataRow(rh).Item("Group_Name")), MsgBoxStyle.YesNo, "Group Management")
        If msgR = MsgBoxResult.No Then Exit Sub
        If g.DeleteGroup(GridView1.GetDataRow(rh).Item("Group_ID")) Then
            GetGroups()
        Else
            MsgBox("Unable To Delete Selected Group!", MsgBoxStyle.Exclamation, Me.Text)
        End If
    End Sub
End Class