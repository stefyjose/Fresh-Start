Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class Connection
    Public myconnection As SqlConnection
    Public cmd As SqlCommand
    Public ad As New SqlDataAdapter
    Public Sub New()
        myconnection = New SqlConnection
        ' myconnection.ConnectionString = servers()
        'myconnection.ConnectionString = "Database=NIMGT; server=NCIT-SERVER; uid=sa;pwd=chaked"
        myconnection.ConnectionString = "Data Source=DESKTOP-VVJM4OG;Initial Catalog=db_reminder;Integrated Security=True"

    End Sub
    Public Sub Connect()
        If myconnection.State = ConnectionState.Open Then myconnection.Close()
        myconnection.Open()
    End Sub
    Public Sub Disconnect()
        myconnection.Close()
    End Sub
    Public Function GetConnectionObject() As SqlClient.SqlConnection
        Return myconnection
    End Function
    Private Function servers() As String
        'Get the requested registry value. 
        Dim Reg As RegistryKey
        Dim con As String = ""
        Try
            'Open the registry key. 
            Reg = Registry.CurrentUser.OpenSubKey("Software\WindowsHost")

            'Get the requested value. 
            con = "Database=" + Reg.GetValue("DtabaseName").ToString + ";" + "server=" + Reg.GetValue("ServerName").ToString + ";" + "uid=" + Reg.GetValue("UserName").ToString + ";" + "pwd=" + Reg.GetValue("PassWord").ToString
            ' MsgBox(con)

            'Close the key. 
            Reg.Close()
        Catch ex As Exception
            'Add your error handling here. 
            MsgBox("Error: " & """" & ex.Message & """", MsgBoxStyle.Critical, "RegistryClient")
        End Try
        Return con
    End Function
    Public Function CreateConnString(ByVal str As String) As String
        Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + str + ";Extended Properties=""Excel 8.0;HDR=YES;"""
    End Function
End Class
