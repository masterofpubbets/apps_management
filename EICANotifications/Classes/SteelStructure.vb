Public Class SteelStructure
    Private p As New PHPService
    Public Function GetAllMaterial() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = p.PHPGet(String.Format("{0}://trprojectssolutions.com/outerjoin/ssmaterial-getx.php", hSSl))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
End Class
