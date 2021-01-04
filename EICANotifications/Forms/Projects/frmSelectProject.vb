Public Class frmSelectProject
    Public SelectedProjects As New Collection
    Public SelectedProjectsNumbers As New Collection
    Private Pro As New Projects
    Private Sub frmSelectProject_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetData()
    End Sub

    Private Sub GetData()
        grd.DataSource = Pro.GetAllProjects
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        SelectedProjects = New Collection
        Me.Close()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        If gv.RowCount = 0 Then
            MsgBox("Please Select Project.", MsgBoxStyle.Exclamation, "Select Project")
            Exit Sub
        End If
        If gv.GetSelectedRows.Count = 0 Then
            MsgBox("Please Select Project.", MsgBoxStyle.Exclamation, "Select Project")
            Exit Sub
        End If
        SelectedProjects = New Collection
        SelectedProjectsNumbers = New Collection
        For Each row_handle As Integer In gv.GetSelectedRows
            SelectedProjects.Add(gv.GetDataRow(row_handle).Item("Name").ToString)
            SelectedProjectsNumbers.Add(gv.GetDataRow(row_handle).Item("Number").ToString)
        Next
        Me.Close()
    End Sub
End Class