Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class findpassword
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project2;")
        Dim cmd As SqlCommand = New SqlCommand($"select * from dbo.users where name = N'{txtname.Text}' and mail = N'{txtmail.Text}'", con)
        Dim smtp As New SmtpClient
        Dim mail As MailMessage = New MailMessage()
        Try
            con.Open()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()

            mail.From = New MailAddress("mymail")
            mail.To.Add(txtmail.Text)
            mail.Subject = "Find Password"
            mail.Body = $"Your password is {dr.GetString(2)}"
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New Net.NetworkCredential("mymail", "mailpassword")
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            dr.Close()
            If cmd.ExecuteScalar() Then
                smtp.Send(mail)
                MsgBox("mail sended.Please check mail")

            Else
                MsgBox("Input error!Please check again.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub findpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class