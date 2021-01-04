Public Class Employee
    Private p As New PHPService

    Public Function GetEmpAssignedPosition(ByVal EmpID As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/empselectedpos.php?empid={1}", hSSl, EmpID))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Function GetAllEmps() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(hSSl & "://trprojectssolutions.com/eicapro/servs/empall-getx.php")
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function EmpImage(ByVal UserName As String) As Image
        UserName = Replace(UserName, "\", "",,, CompareMethod.Text)
        UserName = UserName.ToLower
        Dim t As Image = p.GetImageFromURL(String.Format("{0}://trprojectssolutions.com/eicapro/assets/emps/images/{1}.JPG", hSSl, UserName))
        If IsNothing(t) Then
            t = p.GetImageFromURL(String.Format("{0}://trprojectssolutions.com/eicapro/assets/emps/images/{1}.png", hSSl, "userinfo_bw"))
        End If
        Return t
        Return Nothing
    End Function
    Public Function Delete(ByVal EmpIID As String, ByVal UserName As String) As Boolean
        Try
            If InStr(p.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/emp-del.php?empid={1}", hSSl, EmpIID)), "successfully", CompareMethod.Text) > 0 Then
                DelEmpPhoto(UserName)
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function AssignGroup(ByVal EmpIID As String, ByVal GroupID As String) As Boolean
        Try
            If InStr(p.PHPGet(String.Format("{2}://trprojectssolutions.com/eicapro/servs/empassigngroup.php?empid={0}&groupid={1}", EmpIID, GroupID, hSSl)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Overloads Function CheckEmpName(ByVal EmpName As String) As String
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/empname-getx.php?empname={1}", hSSl, EmpName))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Employee")
            End If
            Return ""
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Overloads Function CheckEmpPassport(ByVal Passport As String) As String
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/emppassport-getx.php?passport={1}", hSSl, Passport))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Employee")
            End If
            Return ""
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Function AddNew(ByVal appasign As String, ByVal workexp As Integer, ByVal sqlexp As Integer, ByVal username As String, ByVal group_id As Integer, ByVal edu_degree As String, ByVal phone_number As String, ByVal emp_name As String, ByVal exp_join_date As String, ByVal posid As Integer, ByVal current_country_id As Integer, ByVal status_id As Integer, ByVal nat_id As Integer, ByVal empmail As String) As Boolean
        Try
            username = Replace(username, "\", "\\",,, CompareMethod.Text)
            If InStr(p.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/emp-add.php?appasign={2}&workexp={3}&sqlexp={4}&username={5}&group_id={6}&edu_degree={7}&phone_number={8}&emp_name={9}&exp_join_date={10}&posid={11}&current_country_id={12}&status_id={13}&nat_id={14}&empmail={15}", hSSl, 0, appasign, workexp, sqlexp, username, group_id, edu_degree, phone_number, emp_name, exp_join_date, posid, current_country_id, status_id, nat_id, empmail)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function UpdateEmp(ByVal EmpID As Integer,byval appasign As String,byval workexp As Integer ,byval sqlexp As Integer,byval username As String,byval group_id As Integer,byval edu_degree As String,byval phone_number as string,byval emp_name As String,byval exp_join_date As String,byval posid As Integer,byval current_country_id As Integer,byval status_id As Integer,byval nat_id As Integer,byval empmail As String ) As Boolean
        Try
            username = Replace(username, "\", "\\",,, CompareMethod.Text)
            If InStr(p.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/emp-edit.php?empid={1}&appasign={2}&workexp={3}&sqlexp={4}&username={5}&group_id={6}&edu_degree={7}&phone_number={8}&emp_name={9}&exp_join_date={10}&posid={11}&current_country_id={12}&status_id={13}&nat_id={14}&empmail={15}", hSSl, EmpID, appasign, workexp, sqlexp, username, group_id, edu_degree, phone_number, emp_name, exp_join_date, posid, current_country_id, status_id, nat_id, empmail)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function AddEmpPhoto(ByVal ImagePath As String, ByVal UserName As String) As Boolean
        Try
            UserName = Replace(UserName, "\", "",,, CompareMethod.Text)
            UserName = UserName.ToLower
            FileIO.FileSystem.CopyFile(ImagePath, String.Format("{0}\temp\emp\images\{1}.JPG", Application.StartupPath, UserName), True)
            If FileIO.FileSystem.FileExists(String.Format("{0}\temp\emp\images\{1}.JPG", Application.StartupPath, UserName)) Then
                If p.UploadToFTP(String.Format("{0}\temp\emp\images\{1}.JPG", Application.StartupPath, UserName), "ftp://ftp.trprojectssolutions.com/", "u502625302.eicaemps", "tunbup-jocnyj-dawJe6") Then
                    FileIO.FileSystem.DeleteFile(String.Format("{0}\temp\emp\images\{1}.JPG", Application.StartupPath, UserName))
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function DelEmpPhoto(ByVal UserName As String) As Boolean
        Try
            UserName = Replace(UserName, "\", "",,, CompareMethod.Text)
            UserName = UserName.ToLower
            p.DeleteFTPFile("ftp://ftp.trprojectssolutions.com", UserName & ".JPG", "u502625302.eicaemps", "tunbup-jocnyj-dawJe6")
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
End Class
