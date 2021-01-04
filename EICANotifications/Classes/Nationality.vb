Public Class Nationality
    Private p As New PHPService
    Public Function GetAllNationalities() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(hSSl & "://trprojectssolutions.com/eicapro/servs/nat-getx.php")
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Function GetAllCountries() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(hSSl & "://trprojectssolutions.com/eicapro/servs/count-getx.php")
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Function GetAllStatus() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(hSSl & "://trprojectssolutions.com/eicapro/servs/status-getx.php")
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
End Class
