Public Class Positions
    Private php As New PHPService

    Public Function Add(ByVal Name As String, ByVal ProNumber As String) As Boolean
        Try
            If InStr(php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/pos-add.php?posname={1}&pronumber={2}", hSSl, Name, ProNumber)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function Delete(ByVal PosID As String) As Boolean
        Try
            If InStr(php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/pos-del.php?posid={1}", hSSl, PosID)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function GetAllPositions() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/posall-getx.php", hSSl))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
End Class
