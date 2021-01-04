Public Class Groups
    Private p As New PHPService
    Public Function GetAllGroups() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(hSSl & "://trprojectssolutions.com/eicapro/servs/groupsall-getx.php")
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Function AddNewGroup(ByVal GroupName As String, ByVal GroupDescription As String) As Boolean
        Try
            If InStr(p.PHPGet(String.Format("{2}://trprojectssolutions.com/eicapro/servs/group-add.php?groupname={0}&desc={1}", GroupName, GroupDescription, hSSl)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function EditGroup(ByVal GroupName As String, ByVal GroupDescription As String, ByVal GroupID As String) As Boolean
        Try
            If InStr(p.PHPGet(String.Format("{2}://trprojectssolutions.com/eicapro/servs/group-edit.php?groupname={0}&desc={1}&groupid={3}", GroupName, GroupDescription, hSSl, GroupID)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function DeleteGroup(ByVal GroupID As String) As Boolean
        Try
            If InStr(p.PHPGet(String.Format("{1}://trprojectssolutions.com/eicapro/servs/group-del.php?groupid={0}", GroupID, hSSl)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
End Class
