Imports System.Net
Imports System.IO

Public Class PHPService

#Region "Internal"
    Private Function GetFileShortName(ByVal FilePath As String) As String
        Dim temp() As String = Split(FilePath, "\")
        If temp.Count > 0 Then
            Return temp(temp.Count - 1)
        End If
        Return ""
    End Function
#End Region
#Region "Methods"
    Public Sub RenameFTPFile(ByVal FTPPath As String, ByVal CurrentFileName As String, ByVal NewFileName As String, FTPUser As String, FTPPassword As String)
        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(String.Format("{0}/{1}", FTPPath, CurrentFileName)), System.Net.FtpWebRequest)
            request.Credentials = New System.Net.NetworkCredential(FTPUser, FTPPassword)
            request.Method = System.Net.WebRequestMethods.Ftp.Rename
            request.RenameTo = NewFileName
            request.GetResponse()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub DeleteFTPFile(ByVal FTPPath As String, ByVal FileName As String, FTPUser As String, FTPPassword As String)
        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(String.Format("{0}/{1}", FTPPath, FileName)), System.Net.FtpWebRequest)
            request.Credentials = New System.Net.NetworkCredential(FTPUser, FTPPassword)
            request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
            request.GetResponse()
        Catch ex As Exception
        End Try
    End Sub
    Public Function UploadToFTP(ByVal FilePath As String, ByVal FTPPath As String, FTPUser As String, FTPPassword As String) As Boolean
        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(String.Format("{0}/{1}", FTPPath, GetFileShortName(FilePath))), System.Net.FtpWebRequest)
            request.Credentials = New System.Net.NetworkCredential(FTPUser, FTPPassword)
            request.Method = System.Net.WebRequestMethods.Ftp.UploadFile
            Dim file() As Byte = System.IO.File.ReadAllBytes(FilePath)
            Dim strz As System.IO.Stream = request.GetRequestStream()
            strz.Write(file, 0, file.Length)
            strz.Close()
            strz.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function DownloadFromFTP(ByVal Downloadpath As String, ByVal FTPPath As String, ByVal FTPUser As String, ByVal FTPPassword As String) As Boolean
        Dim request As New WebClient() With {.Credentials = New NetworkCredential(FTPUser, FTPPassword)}
        Dim bytes() As Byte = request.DownloadData(FTPPath)
        Try
            Dim DownloadStream As FileStream = IO.File.Create(Downloadpath)
            DownloadStream.Write(bytes, 0, bytes.Length)
            DownloadStream.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function PHPGet(ByVal URL As String) As String
        Try
            Dim strData As String
            Dim dataStream As Stream
            Dim reader As StreamReader
            Dim request As WebRequest
            Dim response As WebResponse
            request = WebRequest.Create(URL)
            response = request.GetResponse()
            dataStream = response.GetResponseStream()
            reader = New StreamReader(dataStream)
            strData = reader.ReadToEnd()
            Return strData
            reader.Close()
            response.Close()
        Catch ex As Exception
            Return ""
        End Try
        Return ""
    End Function
    Public Function GetImageFromURL(ByVal url As String) As Image
        Dim retVal As Image = Nothing
        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(url.Trim)

                Using request As System.Net.WebResponse = req.GetResponse
                    Using stream As System.IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(System.Drawing.Image.FromStream(stream))
                    End Using
                End Using
            End If
        Catch ex As Exception
            '' MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
            '                               vbCrLf, ex.Message),
            '                               "Exception Thrown",
            '                               MessageBoxButtons.OK,
            '                               MessageBoxIcon.Warning)
        End Try
        Return retVal

    End Function
#End Region


End Class
