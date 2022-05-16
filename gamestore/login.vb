Imports System.Data.SqlClient
Public Class login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project2;")
        Dim cmd As SqlCommand = New SqlCommand($"select count(*) from dbo.users where name =N'{txtname.Text}' and password =N'{txtpwd.Text}'", con)
        Try
            con.Open()
            If cmd.ExecuteScalar() > 0 Then
                Me.Hide()
                home.Show()
            Else
                MsgBox($"Input Error!{vbLf}Please input again.")
                txtname.Text = ""
                txtpwd.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub lblregister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblregister.LinkClicked
        register.Show()
        Me.Hide()
    End Sub

    Private Sub lblfindpwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblfindpwd.LinkClicked
        findpassword.Show()
        Me.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
