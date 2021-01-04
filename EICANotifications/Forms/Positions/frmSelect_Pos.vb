Public Class frmSelect_Pos
    Private pos As New Positions
    Public SelectedPos As New st_pos

#Region "Structure"
    Public Structure st_pos
        Dim PosID As String
        Dim Name As String
    End Structure
#End Region

    Private Sub frmSelect_Pos_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetPos()
    End Sub

    Private Sub GetPos()
        grdPos.DataSource = pos.GetAllPositions
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Dim rh As Integer = GridView1.GetSelectedRows(0)
        SelectedPos.Name = GridView1.GetDataRow(rh).Item("Position")
        SelectedPos.PosID = GridView1.GetDataRow(rh).Item("PosID")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SelectedPos.Name = ""
        SelectedPos.PosID = 0
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If SelectedPos.PosID = "" Then
            MsgBox("Please Select Position", MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End If
        Me.Close()
    End Sub
End Class