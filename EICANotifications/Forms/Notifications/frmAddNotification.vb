Public Class frmAddNotification
    Private Image01 As String = ""
    Private Image02 As String = ""
    Private Image03 As String = ""
    Public IsAdded As Boolean = False
    Private SelectedProjectsNumbers As New Collection
    Private noti As New Notifications

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Image01 = ""
        Pic01.Image = Nothing
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Image02 = ""
        Pic02.Image = Nothing
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Image03 = ""
        Pic03.Image = Nothing
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            opnFle.FileName = ""
            opnFle.ShowDialog()
            If opnFle.FileName = "" Then Exit Sub
            Pic01.Image = Image.FromFile(opnFle.FileName)
            Image01 = opnFle.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Try
            opnFle.FileName = ""
            opnFle.ShowDialog()
            If opnFle.FileName = "" Then Exit Sub
            Pic02.Image = Image.FromFile(opnFle.FileName)
            Image02 = opnFle.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Try
            opnFle.FileName = ""
            opnFle.ShowDialog()
            If opnFle.FileName = "" Then Exit Sub
            Pic03.Image = Image.FromFile(opnFle.FileName)
            Image03 = opnFle.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        IsAdded = False
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
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

    Private Sub subRemovePro()
        If lstPro.SelectedIndices.Count <> 0 Then
            lstPro.Items.RemoveAt(lstPro.SelectedIndices.Item(0))
            subRemovePro()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        lstPro.Items.Clear()
        SelectedProjectsNumbers = New Collection
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        If Trim(txtHeader.Text) = "" Then
            MsgBox("Please Enter The Header", MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End If
        If Trim(txtNoti.Text) = "" Then
            MsgBox("Please Enter The Header", MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End If
        If lstPro.Items.Count = 0 Then
            MsgBox("Please Select Project", MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End If
        Dim f As Boolean = True
        For inx As Integer = 1 To SelectedProjectsNumbers.Count
            If Not noti.Add(txtHeader.Text, txtNoti.Text, Image01, Image02, Image03, SelectedProjectsNumbers.Item(inx)) Then
                f = False
            End If
        Next
        If f Then
            MsgBox("Notification Has Been Added", MsgBoxStyle.Information, Me.Text)

            Dim msgR As MsgBoxResult = MsgBox("Do You Want To Add Another One?", vbYesNo, Me.Text)
            If msgR = MsgBoxResult.No Then
                IsAdded = True
                Me.Close()
            Else
                txtHeader.Text = ""
                txtNoti.Text = ""
                Image01 = ""
                Image02 = ""
                Image03 = ""
                Pic01.Image = Nothing
                Pic02.Image = Nothing
                Pic03.Image = Nothing
                txtHeader.Focus()
            End If
        End If
    End Sub

End Class