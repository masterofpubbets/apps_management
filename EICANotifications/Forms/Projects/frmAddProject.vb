Public Class frmAddProject
    Private pro As New Projects
    Public isAdded As Boolean = False

    Public Function IsValidated() As Boolean
        If Trim(txtName.Text) = "" Then
            MsgBox("Please Type Project Name", MsgBoxStyle.Exclamation, "Add New Project")
            txtName.Focus()
            Return False
        End If
        If Trim(txtNumber.Text) = "" Then
            MsgBox("Please Type Project Number", MsgBoxStyle.Exclamation, "Add New Project")
            txtNumber.Focus()
            Return False
        End If
        If Trim(txtLocation.Text) = "" Then
            MsgBox("Please Type Project Location", MsgBoxStyle.Exclamation, "Add New Project")
            txtLocation.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        isAdded = False
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IsValidated() Then

            If pro.Add(txtName.Text, txtLocation.Text, txtNumber.Text) Then
                isAdded = True
                MsgBox("New Project Added Successfully", MsgBoxStyle.Information, "Add New Project")
                Me.Close()
            Else
                MsgBox("Something Is Wrong!", MsgBoxStyle.Critical, "Add New Project")
            End If
        End If
    End Sub
End Class