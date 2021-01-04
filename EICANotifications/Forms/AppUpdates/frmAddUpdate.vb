Public Class frmAddUpdate
    Public IsAdded As Boolean = False
    Private AppUp As New AppUpdates
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        IsAdded = False
        Me.Close()
    End Sub

    Private Sub ClearTexts()
        lblUpdateFile.Text = ""
        SimpleButton3.Focus()
    End Sub
    Private Function IsValidate() As Boolean
        If cmbApp.SelectedIndex = -1 Then
            MsgBox("Please Select Application's Name", MsgBoxStyle.Exclamation, "Application Updates")
            cmbApp.Focus()
            Return False
        End If
        If cmbType.SelectedIndex = -1 Then
            MsgBox("Please Select Update's Type", MsgBoxStyle.Exclamation, "Application Updates")
            cmbType.Focus()
            Return False
        End If
        If Trim(txtName.Text) = "" Then
            MsgBox("Please Enter Update's Name", MsgBoxStyle.Exclamation, "Application Updates")
            txtName.Focus()
            Return False
        End If
        If Trim(lblUpdateFile.Text) = "" Then
            MsgBox("Please Select The Update File", MsgBoxStyle.Exclamation, "Application Updates")
            SimpleButton3.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IsValidate() Then
            If AppUp.AddNewUpdate(cmbType.SelectedIndex, txtName.Text, cmbApp.SelectedItem.ToString, Replace(txtLocalPath.Text, "\", "\\",,, CompareMethod.Text), lblUpdateFile.Text) Then
                MsgBox("New Update Has Been Added.", MsgBoxStyle.Information, "Application Updates")
                Dim msgR As MsgBoxResult = MsgBox("Do You Want To Add Another Update?", MsgBoxStyle.YesNo, "Application Updates")
                If msgR = MsgBoxResult.No Then
                    IsAdded = True
                    Me.Close()
                Else
                    ClearTexts()
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        opnFle.FileName = ""
        opnFle.ShowDialog()
        If opnFle.FileName = "" Then Exit Sub
        lblUpdateFile.Text = opnFle.FileName
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.SelectedIndex = 0 Then
            txtLocalPath.Text = ""
        Else
            txtLocalPath.Text = "None"
        End If
    End Sub
End Class