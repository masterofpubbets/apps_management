Public Class frmAddGroup
    Public IsSaved As Boolean = False
    Private g As New Groups

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
    Private Sub txtDescription_Validated(sender As Object, e As EventArgs) Handles txtDescription.Validated
        If Trim(txtDescription.Text) = "" Then
            txtDescription.Text = "None"
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IsValidate() Then
            If g.AddNewGroup(txtName.Text, txtDescription.Text) Then
                Dim msgR As MsgBoxResult = MsgBox("Group Has Been Added" & vbCrLf & "Do You Want To Add Another Group?", MsgBoxStyle.YesNo, "Group Management")
                If msgR = MsgBoxResult.No Then
                    IsSaved = True
                    Me.Close()
                Else
                    txtDescription.Text = "None"
                    txtName.Text = ""
                    txtName.Focus()
                End If
            Else
                MsgBox("Unable to Add Group!", MsgBoxStyle.Exclamation, "Group Management")
            End If
        End If
    End Sub
End Class