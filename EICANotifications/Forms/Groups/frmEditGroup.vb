Public Class frmEditGroup
    Public IsSaved As Boolean = False
    Private g As New Groups
    Public GroupID As Integer = 0

    Public Function IsValidate() As Boolean
        If Trim(txtName.Text) = "" Then
            MsgBox("Please Type Group Name", MsgBoxStyle.Exclamation, "Group Management")
            txtName.Focus()
            Return False
        End If
        Return True
        Return False
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        IsSaved = False
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IsValidate() Then
            If g.EditGroup(txtName.Text, txtDescription.Text, GroupID) Then
                MsgBox("Group Has Been Saved", MsgBoxStyle.Information, "Group Management")
                IsSaved = True
                Me.Close()
            Else
                MsgBox("Unable to Edit Group!", MsgBoxStyle.Exclamation, "Group Management")
            End If
        End If
    End Sub

End Class