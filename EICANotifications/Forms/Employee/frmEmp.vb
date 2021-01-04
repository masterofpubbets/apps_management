Imports DevExpress.Data

Public Class frmEmp
    Private Emp As New Employee
    Private Sub GetEmp()
        picEmp.Image = Nothing
        grdEmp.DataSource = Emp.GetAllEmps
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GetEmp()
    End Sub

    Private Sub frmEmp_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetEmp()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If gvEmp.RowCount = 0 Then Exit Sub
        Dim rh As Integer = gvEmp.GetSelectedRows(0)
        If rh < 0 Then Exit Sub
        picEmp.Image = Emp.EmpImage(gvEmp.GetDataRow(rh).Item("User_Name"))
        Dim frm As New frmEditEmp() With {.CurrentUserName = gvEmp.GetDataRow(rh).Item("User_Name"), .EmpID = gvEmp.GetDataRow(rh).Item("Emp_ID")}
        frm.txtName.Text = gvEmp.GetDataRow(rh).Item("Full_Name")
        frm.Nationality = gvEmp.GetDataRow(rh).Item("Nationality")
        frm.Status = gvEmp.GetDataRow(rh).Item("Status")
        frm.Country = gvEmp.GetDataRow(rh).Item("Current_Country")
        frm.dteExJoinDate.Value = ReformatDate(gvEmp.GetDataRow(rh).Item("Expected_Join_Date"))
        frm.txtPhone.Text = gvEmp.GetDataRow(rh).Item("Phone")
        frm.txtEduDegree.Text = gvEmp.GetDataRow(rh).Item("Education_Degree")
        frm.PosID = Val(gvEmp.GetDataRow(rh).Item("PosID"))
        frm.lblPos.Text = gvEmp.GetDataRow(rh).Item("Position")
        frm.Group = gvEmp.GetDataRow(rh).Item("Group_Name")
        frm.txtAppAssigned.Text = gvEmp.GetDataRow(rh).Item("App_Assign")
        frm.txtUserName.Text = gvEmp.GetDataRow(rh).Item("User_Name")
        frm.txtUserMail.Text = gvEmp.GetDataRow(rh).Item("EMail")
        frm.tbSqlExp.EditValue = Val(gvEmp.GetDataRow(rh).Item("SQL_Experience"))
        frm.lblSqlExpValue.Text = Val(gvEmp.GetDataRow(rh).Item("SQL_Experience"))
        frm.tbWorkExp.EditValue = Val(gvEmp.GetDataRow(rh).Item("Work_Experience"))
        frm.lblWorkExpValue.Text = Val(gvEmp.GetDataRow(rh).Item("Work_Experience"))
        frm.picEmpImg.Image = picEmp.Image
        frm.ShowDialog(Me)
        If frm.IsSaved Then
            GetEmp()
        End If
        frm = Nothing
    End Sub
    Private Function ReformatDate(ByVal exp As String) As Date
        Return DateTime.ParseExact(exp, "yyyy-MM-dd", Globalization.CultureInfo.InvariantCulture)
    End Function

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As New frmAddEmp
        frm.ShowDialog(Me)
        If frm.IsSaved Then
            GetEmp()
        End If
        frm = Nothing
    End Sub

    Private Sub gvEmp_Click(sender As Object, e As EventArgs) Handles gvEmp.Click
        If gvEmp.RowCount = 0 Then Exit Sub
        Dim rh As Integer = gvEmp.GetSelectedRows(0)
        If rh < 0 Then Exit Sub
        picEmp.Image = Emp.EmpImage(gvEmp.GetDataRow(rh).Item("User_Name"))
        Dim php As New PHPService
        'php.DownloadFromFTP(Application.StartupPath & "\temp\userinfo_bw.png", String.Format("ftp://ftp.trprojectssolutions.com/{1}.png", hSSl, "userinfo_bw"), "u502625302.eicaemps", "tunbup-jocnyj-dawJe6")
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If gvEmp.RowCount = 0 Then Exit Sub
        Dim rh As Integer = gvEmp.GetSelectedRows(0)
        If rh < 0 Then Exit Sub
        Dim msgR As MsgBoxResult = MsgBox("Do You Want To Delete Selected Employee?", MsgBoxStyle.YesNo, "Employee Management")
        If msgR = MsgBoxResult.No Then Exit Sub
        If Emp.Delete(gvEmp.GetDataRow(rh).Item("Emp_ID"), gvEmp.GetDataRow(rh).Item("User_Name")) Then
            GetEmp()
            MsgBox("Employee Has Been Deleted.", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
End Class