Imports System.Data.SqlClient


Public Class login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project1;")
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand($"select count(*) from dbo.login where username = N'{txtname.Text}' and password = N'{txtpwd.Text}'", con)

            If cmd.ExecuteScalar() > 0 Then
                Me.Hide()
                home.Show()

            Else
                MsgBox("Input error!Please enter again.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub

    Private Sub lblregister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblregister.LinkClicked
        register.Show()
        Me.Hide()
    End Sub

    Private Sub lblforgetpwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblforgetpwd.LinkClicked
        findpassowrd.Show()
        Me.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        txtname.Text = ""
        txtpwd.Text = ""
    End Sub


End Class
