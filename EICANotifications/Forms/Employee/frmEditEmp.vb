Imports DevExpress.XtraEditors.Controls

Public Class frmEditEmp
    Public Status As String = ""
    Public Country As String = ""
    Public Nationality As String = ""
    Public Group As String = ""
    Public EmpID As Integer = 0
    Public CurrentUserName As String = ""
    Private nat As New Nationality
    Private Emp As New Employee
    Private Gp As New Groups
    Public PosID As Integer = 0
    Public IsSaved As Boolean = False

    Private Function IsValidate() As Boolean
        If Trim(txtName.Text) = "" Then
            MsgBox("Please Enter Employee Name", MsgBoxStyle.Exclamation, "Employee Management")
            txtName.Focus()
            Return False
        End If
        If cmbNat.SelectedIndex = -1 Then
            MsgBox("Please Select Nationality", MsgBoxStyle.Exclamation, "Employee Management")
            cmbNat.Focus()
            Return False
        End If
        If cmbStatus.SelectedIndex = -1 Then
            MsgBox("Please Select Employee's Status", MsgBoxStyle.Exclamation, "Employee Management")
            cmbStatus.Focus()
            Return False
        End If
        If cmbCountry.SelectedIndex = -1 Then
            MsgBox("Please Select Employee's Current Country", MsgBoxStyle.Exclamation, "Employee Management")
            cmbCountry.Focus()
            Return False
        End If
        If Trim(txtPhone.Text) = "" Then
            MsgBox("Please Enter Employee's Phone", MsgBoxStyle.Exclamation, "Employee Management")
            txtPhone.Focus()
            Return False
        End If
        If cmbGroup.SelectedIndex = -1 Then
            MsgBox("Please Select Group", MsgBoxStyle.Exclamation, "Employee Management")
            cmbGroup.Focus()
            Return False
        End If
        If Trim(txtUserMail.Text) = "" Then
            MsgBox("Please Enter User Name", MsgBoxStyle.Exclamation, "Employee Management")
            txtUserMail.Focus()
            Return False
        End If
        If Trim(txtUserName.Text) = "" Then
            MsgBox("Please Enter User's Mail", MsgBoxStyle.Exclamation, "Employee Management")
            txtUserName.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub GetCountriesNat()
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        Dim dt4 As New DataTable
        cmbCountry.Items.Clear()
        cmbNat.Items.Clear()
        cmbStatus.Items.Clear()
        cmbGroup.Items.Clear()
        lstCountID.Items.Clear()
        lstNatID.Items.Clear()
        lstStatusID.Items.Clear()
        lstGroup.Items.Clear()

        dt = nat.GetAllCountries
        dt2 = nat.GetAllNationalities
        dt3 = nat.GetAllStatus
        dt4 = Gp.GetAllGroups
        For inx As Integer = 0 To dt.Rows.Count - 1
            cmbCountry.Items.Add(dt.Rows(inx).Item("Country"))
            lstCountID.Items.Add(dt.Rows(inx).Item("Country_ID"))
        Next
        For iny As Integer = 0 To dt2.Rows.Count - 1
            cmbNat.Items.Add(dt2.Rows(iny).Item("Nationality"))
            lstNatID.Items.Add(dt2.Rows(iny).Item("Nationality_ID"))
        Next
        For iny As Integer = 0 To dt3.Rows.Count - 1
            cmbStatus.Items.Add(dt3.Rows(iny).Item("Status"))
            lstStatusID.Items.Add(dt3.Rows(iny).Item("Status_ID"))
        Next
        For inz As Integer = 0 To dt4.Rows.Count - 1
            cmbGroup.Items.Add(dt4.Rows(inz).Item("Group_Name"))
            lstGroup.Items.Add(dt4.Rows(inz).Item("Group_ID"))
        Next
        cmbCountry.SelectedIndex = cmbCountry.FindStringExact(Country)
        cmbNat.SelectedIndex = cmbNat.FindStringExact(Nationality)
        cmbStatus.SelectedIndex = cmbStatus.FindStringExact(Status)
        cmbGroup.SelectedIndex = cmbGroup.FindStringExact(Group)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        IsSaved = False
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
            opnFle.FileName = ""
            opnFle.ShowDialog()
            If opnFle.FileName = "" Then Exit Sub
            picEmpImg.Image = Image.FromFile(opnFle.FileName)
            Dim msgR As MsgBoxResult = MsgBox("Do You Want To Update Employee Photo?", MsgBoxStyle.YesNo, "Employee Management")
            If msgR = MsgBoxResult.No Then Exit Sub
            Emp.DelEmpPhoto(CurrentUserName)
            If Emp.AddEmpPhoto(opnFle.FileName, CurrentUserName) Then
                MsgBox("Employee's Photo Has Been Updated.", MsgBoxStyle.Information, "Employee Management")
            End If
        Catch ex As Exception
            picEmpImg.Image = Nothing
        End Try
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IsValidate() Then
            If Emp.UpdateEmp(EmpID, txtAppAssigned.Text, tbWorkExp.EditValue, tbSqlExp.EditValue, txtUserName.Text, lstGroup.Items.Item(cmbGroup.SelectedIndex), txtEduDegree.Text, txtPhone.Text, txtName.Text, Format(dteExJoinDate.Value, "yyyy-MM-dd"), PosID, lstCountID.Items.Item(cmbCountry.SelectedIndex), lstStatusID.Items.Item(cmbStatus.SelectedIndex), lstNatID.Items.Item(cmbNat.SelectedIndex), txtUserMail.Text) Then
                MsgBox("Employee Has Been Updated.", MsgBoxStyle.Information, "Employee Management")
                IsSaved = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmEditEmp_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetCountriesNat()
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim pos As New frmSelect_Pos.st_pos
        Dim frm As New frmSelect_Pos
        frm.ShowDialog(Me)
        pos = frm.SelectedPos
        If frm.SelectedPos.PosID = "" Then
            PosID = 0
        Else
            PosID = frm.SelectedPos.PosID
        End If
        lblPos.Text = pos.Name
        frm = Nothing
    End Sub

    Private Sub txtEduDegree_Validated(sender As Object, e As EventArgs) Handles txtEduDegree.Validated
        If Trim(txtEduDegree.Text) = "" Then
            txtEduDegree.Text = "Undefined"
        End If
    End Sub

    Private Sub txtPhone_Validated(sender As Object, e As EventArgs) Handles txtPhone.Validated
        txtPhone.Text = Replace(txtPhone.Text, "+", "00",,, CompareMethod.Text)
    End Sub

    Private Sub txtAppAssigned_Validated(sender As Object, e As EventArgs) Handles txtAppAssigned.Validated
        If Trim(txtAppAssigned.Text) = "" Then
            txtAppAssigned.Text = "None"
        End If
    End Sub

    Private Sub tbSqlExp_ValueChanged(sender As Object, e As EventArgs) Handles tbSqlExp.ValueChanged
        lblSqlExpValue.Text = tbSqlExp.EditValue
    End Sub

    Private Sub tbWorkExp_ValueChanged(sender As Object, e As EventArgs) Handles tbWorkExp.ValueChanged
        lblWorkExpValue.Text = tbWorkExp.EditValue
    End Sub

End Class