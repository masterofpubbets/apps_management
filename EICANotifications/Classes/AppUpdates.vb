Public Class AppUpdates
    Private p As New PHPService
    Public Function GetAllUpdates() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(hSSl & "://trprojectssolutions.com/eicapro/servs/appupdate-getx.php")
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Function AddNewUpdate(ByVal updatetype As String, ByVal updatename As String, ByVal appname As String, ByVal localpath As String, ByVal FilePath As String) As Boolean
        Try
            Dim temp() As String = Split(FilePath, "\")
            'Dim file_name As String = String.Format("{0}{4}{1}{2}.{3}", appname, Replace(My.User.Name, "\", "", , , CompareMethod.Text), Format(Now, "yyyyMMddhhmm"), temp(temp.Count - 1), updatename)
            Dim file_name As String = temp(temp.Count - 1)
            If UploadUpdateFile(FilePath) Then
                If InStr(p.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/appupdate-add.php?updatetype={1}&updatename={2}&file_name={3}&appname={4}&localpath={5}", hSSl, updatetype, updatename, file_name, appname, localpath)), "successfully", CompareMethod.Text) > 0 Then
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function DeleteUpdate(ByVal UpdateID As String, ByVal FileName As String) As Boolean
        Try
            If InStr(p.PHPGet(String.Format("{1}://trprojectssolutions.com/eicapro/servs/appupdate-del.php?id={0}", UpdateID, hSSl)), "successfully", CompareMethod.Text) > 0 Then
                p.DeleteFTPFile("ftp://ftp.trprojectssolutions.com", FileName, "u502625302.appupdates", "doFqef-qymzaj-1bipsa")
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Private Function UploadUpdateFile(ByVal FilePath As String) As Boolean
        Try
            Return p.UploadToFTP(FilePath, "ftp://ftp.trprojectssolutions.com/", "u502625302.appupdates", "doFqef-qymzaj-1bipsa")
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
End Class
