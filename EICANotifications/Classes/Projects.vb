Public Class Projects
    Private php As New PHPService

    Public Function Add(ByVal Name As String, ByVal Location As String, ByVal Number As String) As Boolean
        Try
            If InStr(php.PHPGet(String.Format("{4}://trprojectssolutions.com/eicapro/servs/pro-add.php?name={0}&location={1}&proname={2}&number={3}", Name, Location, Location, Number, hSSl)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function Edit(ByVal Name As String, ByVal Location As String, ByVal Number As String, ByVal ProID As String) As Boolean
        Try
            If InStr(php.PHPGet(String.Format("{4}://trprojectssolutions.com/eicapro/servs/pro-edit.php?name={0}&location={1}&proname={2}&number={3}&proid={5}", Name, Location, Location, Number, hSSl, ProID)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function Delete(ByVal ProID As String) As Boolean
        Try
            If InStr(php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/pro-del.php?proid={1}", hSSl, ProID)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function GetAllProjects() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/proall-getx.php", hSSl))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
End Class
