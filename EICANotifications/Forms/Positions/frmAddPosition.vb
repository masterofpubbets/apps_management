Public Class frmAddPosition
    Public IsSaved As Boolean = False
    Private SelectedProjectsNumbers As New Collection
    Private Pos As New Positions

    Private Function IsValidate() As Boolean
        If Trim(txtName.Text) = "" Then
            MsgBox("Please Enter Position Name!", MsgBoxStyle.Exclamation, "Position")
            Return False
        End If
        If lstPro.Items.Count = 0 Then
            MsgBox("Please Select Project", MsgBoxStyle.Exclamation, "Position")
            Return False
        End If
        Return True
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        IsSaved = False
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim frm As New frmSelectProject
        frm.ShowDialog(Me)
        If frm.SelectedProjects.Count > 0 Then
            SelectedProjectsNumbers = New Collection
            lstPro.Items.Clear()
            For inx As Integer = 1 To frm.SelectedProjects.Count
                lstPro.Items.Add(frm.SelectedProjects(inx))
            Next
            SelectedProjectsNumbers = frm.SelectedProjectsNumbers
        End If
        frm = Nothing
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        lstPro.Items.Clear()
        SelectedProjectsNumbers = New Collection
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IsValidate() Then
            Dim f As Boolean = True
            For inx As Integer = 1 To SelectedProjectsNumbers.Count
                If Not Pos.Add(txtName.Text, SelectedProjectsNumbers.Item(inx)) Then
                    f = False
                End If
            Next
            If f Then
                MsgBox("Position Has Been Added", MsgBoxStyle.Information, Me.Text)

                Dim msgR As MsgBoxResult = MsgBox("Do You Want To Add Another One?", vbYesNo, Me.Text)
                If msgR = MsgBoxResult.No Then
                    IsSaved = True
                    Me.Close()
                Else
                    txtName.Text = ""
                    txtName.Focus()
                End If
            End If
        End If
    End Sub
End Class