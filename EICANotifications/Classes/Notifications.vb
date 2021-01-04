Public Class Notifications
    Private php As New PHPService

    Private Sub LoadNotImageFileName(ByVal NotID As String, ByRef Image01 As String, ByRef image02 As String, ByRef image03 As String)
        Try
            Dim dt As New DataTable
            Dim buffer As String = php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/not-getx.php?notid={1}", hSSl, NotID))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item("Pic01")) Then
                    Image01 = dt.Rows(0).Item("Pic01")
                End If
                If Not IsDBNull(dt.Rows(0).Item("Pic02")) Then
                    image02 = dt.Rows(0).Item("Pic02")
                End If
                If Not IsDBNull(dt.Rows(0).Item("Pic03")) Then
                    image03 = dt.Rows(0).Item("Pic03")
                End If
            Else
                Image01 = "None"
                image02 = "None"
                image03 = "None"
            End If
        Catch ex As Exception
            Image01 = "None"
            image02 = "None"
            image03 = "None"
        End Try
    End Sub

    Private Function AddProNumberToFileShortName(ByVal ProNumber As String, ByVal FilePath As String) As String
        Dim temp() As String = Split(FilePath, "\")
        Dim fPath As String = ""
        If temp.Count > 0 Then
            For inx As Integer = 0 To temp.Count - 2
                fPath &= temp(inx) & "\"
            Next
            Return fPath & ProNumber & temp(temp.Count - 1)
        End If
        Return ""
    End Function
    Private Function GetFileShortName(ByVal FilePath As String) As String
        Dim temp() As String = Split(FilePath, "\")
        If temp.Count > 0 Then
            Return temp(temp.Count - 1)
        End If
        Return ""
    End Function
    Public Function GetAllNotifications() As DataTable
        Dim dt As New DataTable
        Try
            Dim buffer As String = php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/notiall-getx.php", hSSl))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            dt.Columns.Remove("Pic01")
            dt.Columns.Remove("Pic02")
            dt.Columns.Remove("Pic03")
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
    Public Sub LoadNotImage(ByVal NotID As String, ByRef Image01 As Image, ByRef image02 As Image, ByRef image03 As Image)
        Try
            Image01 = Nothing
            image02 = Nothing
            image03 = Nothing
            Dim dt As New DataTable
            Dim buffer As String = php.PHPGet(String.Format("{0}://trprojectssolutions.com/eicapro/servs/not-getx.php?notid={1}", hSSl, NotID))
            Dim sr As New System.IO.StringReader(buffer)
            dt.ReadXml(sr)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item("Pic01")) Then
                    If dt.Rows(0).Item("Pic01") <> "None" Then
                        Image01 = php.GetImageFromURL("https://trprojectssolutions.com/eicapro/assets/notificationsimages/" & dt.Rows(0).Item("Pic01"))
                    End If
                End If
                If Not IsDBNull(dt.Rows(0).Item("Pic02")) Then
                    If dt.Rows(0).Item("Pic02") <> "None" Then
                        image02 = php.GetImageFromURL("https://trprojectssolutions.com/eicapro/assets/notificationsimages/" & dt.Rows(0).Item("Pic02"))
                    End If
                End If
                If Not IsDBNull(dt.Rows(0).Item("Pic03")) Then
                    If dt.Rows(0).Item("Pic03") <> "None" Then
                        image03 = php.GetImageFromURL("https://trprojectssolutions.com/eicapro/assets/notificationsimages/" & dt.Rows(0).Item("Pic03"))
                    End If
                End If
            Else
                Image01 = Nothing
                image02 = Nothing
                image03 = Nothing
            End If
        Catch ex As Exception
            Image01 = Nothing
            image02 = Nothing
            image03 = Nothing
        End Try
    End Sub
    Public Function Add(ByVal Header As String, ByVal Notification As String, ByVal pic01Path As String, ByVal pic02Path As String, ByVal pic03Path As String, ByVal ProNumber As String) As Boolean
        Try
            Dim pic01value As String = "None"
            Dim pic02value As String = "None"
            Dim pic03value As String = "None"
            If pic01Path <> "" Then
                pic01value = pic01Path
                php.UploadToFTP(pic01Path, "ftp://ftp.trprojectssolutions.com/", "u502625302.eicapronoti", "tikwe3-curzev-dumveR")
            End If
            If pic02Path <> "" Then
                pic02value = pic02Path
                php.UploadToFTP(pic02Path, "ftp://ftp.trprojectssolutions.com/", "u502625302.eicapronoti", "tikwe3-curzev-dumveR")
            End If
            If pic03Path <> "" Then
                pic03value = pic03Path
                php.UploadToFTP(pic03Path, "ftp://ftp.trprojectssolutions.com/", "u502625302.eicapronoti", "tikwe3-curzev-dumveR")
            End If
            If InStr(php.PHPGet(String.Format("{6}://trprojectssolutions.com/eicapro/servs/not-add.php?pronumber={0}&notification={1}&header={2}&pic01={3}&pic02={4}&pic03={5}", ProNumber, Notification, Header, GetFileShortName(pic01value), GetFileShortName(pic02value), GetFileShortName(pic03value), hSSl)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function Delete(ByVal NotID As Integer) As Boolean
        Dim pic01 As String = ""
        Dim pic02 As String = ""
        Dim pic03 As String = ""
        LoadNotImageFileName(NotID, pic01, pic02, pic03)
        Try
            If pic01 <> "None" Then
                php.DeleteFTPFile("ftp://ftp.trprojectssolutions.com/", pic01, "u502625302.eicapronoti", "tikwe3-curzev-dumveR")
            End If
            If pic02 <> "None" Then
                php.DeleteFTPFile("ftp://ftp.trprojectssolutions.com/", pic02, "u502625302.eicapronoti", "tikwe3-curzev-dumveR")
            End If
            If pic03 <> "None" Then
                php.DeleteFTPFile("ftp://ftp.trprojectssolutions.com/", pic03, "u502625302.eicapronoti", "tikwe3-curzev-dumveR")
            End If
            If InStr(php.PHPGet(String.Format("{1}://trprojectssolutions.com/eicapro/servs/not-del.php?notid={0}", NotID, hSSl)), "successfully", CompareMethod.Text) > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
End Class
