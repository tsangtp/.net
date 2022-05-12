Imports System.Data.SqlClient
Public Class home
    Dim p1 As Integer = 40
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblname.Text = login.txtname.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If p1 > 80 Then
            Timer1.Stop()
        Else
            Me.pn.Size = New Size(Me.pn.Size.Width, p1)
            p1 += 10
        End If
    End Sub

    Private Sub lblname_MouseHover(sender As Object, e As EventArgs) Handles lblname.MouseHover
        Timer1.Start()
    End Sub

    Private Sub lblname_MouseLeave(sender As Object, e As EventArgs) Handles lblname.MouseLeave
        Timer1.Stop()
        p1 = 40
    End Sub


    Private Sub lblsetting_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub lbllogout_Click(sender As Object, e As EventArgs) Handles lbllogout.Click
        Me.Close()
        login.Show()
    End Sub


    Private Sub btnpersonal_Click(sender As Object, e As EventArgs) Handles btnpersonal.Click
        updates.Show()
    End Sub

    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        booking.Show()
    End Sub

    Private Sub btnrecord_Click(sender As Object, e As EventArgs) Handles btnrecord.Click
        record.Show()
    End Sub
End Class