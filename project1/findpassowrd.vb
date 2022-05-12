Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class findpassowrd
    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        Try
            Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project1;")
            Dim cmd As SqlCommand = New SqlCommand($"select count(*) from dbo.login where username  =N'{txtname.Text}'", con)
            con.Open()
            Dim smtp As New SmtpClient
            Dim mail As MailMessage = New MailMessage()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New Net.NetworkCredential("Mymail", "Password")
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            mail.From = New MailAddress("Mymail")
            mail.To.Add(txtmail.Text)
            mail.Subject = "find password"
            mail.Body = $"Your password is {dr.GetString(1)}"

            If cmd.ExecuteScalar > 0 Then

                dr.Close()
                smtp.Send(mail)
                MsgBox("Please check your email.")
                Me.Hide()
                login.Show()
            Else
                If (dr!username! = txtname.Text) Then
                    MsgBox("Input error!Please enter again.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub findpassowrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmail.Text = ""
        txtname.Text = ""
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        login.Show()
    End Sub
End Class