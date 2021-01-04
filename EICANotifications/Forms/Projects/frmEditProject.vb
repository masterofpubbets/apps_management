Public Class frmEditProject
    Private pro As New Projects
    Public isUpdated As Boolean = False
    Public ProID As String = ""

    Public Function IsValidated() As Boolean
        If Trim(txtName.Text) = "" Then
            MsgBox("Please Type Project Name", MsgBoxStyle.Exclamation, "Edit Project")
            txtName.Focus()
            Return False
        End If
        If Trim(txtNumber.Text) = "" Then
            MsgBox("Please Type Project Number", MsgBoxStyle.Exclamation, "Edit Project")
            txtNumber.Focus()
            Return False
        End If
        If Trim(txtLocation.Text) = "" Then
            MsgBox("Please Type Project Location", MsgBoxStyle.Exclamation, "Edit Project")
            txtLocation.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        isUpdated = False
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IsValidated() Then

            If pro.Edit(txtName.Text, txtLocation.Text, txtNumber.Text, ProID) Then
                isUpdated = True
                MsgBox("Project Has Been Updated Successfully", MsgBoxStyle.Information, "Edit Project")
                Me.Close()
            Else
                MsgBox("Something Is Wrong!", MsgBoxStyle.Critical, "Add New Project")
            End If
        End If
    End Sub
End Class