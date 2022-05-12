Imports System.Data.SqlClient
Public Class booking
    Private Sub count()
        lblprice.Text = $"{Val(txtrm1.Text) * 500 + Val(txtrm2.Text) * 800 + Val(txtrm3.Text) * 1500 + Val(txtrm4.Text) * 5000}"
        lblroom.Text = Val(txtrm1.Text) + Val(txtrm2.Text) + Val(txtrm3.Text) + Val(txtrm4.Text)
        lbldays.Text = txtday.Text
        total.Text = $"{Val(lblprice.Text) * Val(lbldays.Text)}"
    End Sub
    Private Sub dates(Optional value As Integer = 0)
        Dim sd As DateTime = Convert.ToDateTime(startdate.Text)
        Dim ed As DateTime = Convert.ToDateTime(enddate.Text)
        Dim countdate As TimeSpan = ed.Subtract(sd)
        Dim td = Convert.ToInt32(countdate.Days)
        Dim plus As Integer = 1
        Dim minus As Integer = -1
        Try
            txtday.Text = td
            lbldays.Text = txtday.Text
            total.Text = $"{Val(lblprice.Text) * Val(lbldays.Text)}"
            If value = 3 Then
                If sd >= ed Then
                    enddate.Text = sd.AddDays(1)
                End If
            ElseIf value = 1 Then

                ed = ed.AddDays(plus)
                enddate.Text = ed
            ElseIf value = -1 Then
                enddate.MinDate = startdate.MinDate
                ed = ed.AddDays(minus)
                If enddate.Text <> enddate.MinDate Then
                    enddate.Text = ed
                Else
                    enddate.Text = enddate.MinDate
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtrm1_TextChanged(sender As Object, e As EventArgs) Handles txtrm1.TextChanged
        count()
    End Sub

    Private Sub txtrm2_TextChanged(sender As Object, e As EventArgs) Handles txtrm2.TextChanged
        count()
    End Sub

    Private Sub txtrm3_TextChanged(sender As Object, e As EventArgs) Handles txtrm3.TextChanged
        count()
    End Sub

    Private Sub txtrm4_TextChanged(sender As Object, e As EventArgs) Handles txtrm4.TextChanged
        count()
    End Sub
    Private Sub txtday_TextChanged(sender As Object, e As EventArgs)
        txtday.Text = 0
    End Sub

    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startdate.MinDate = DateTime.Now
        enddate.MinDate = startdate.MinDate.AddDays(1)

    End Sub

    Private Sub startdate_ValueChanged(sender As Object, e As EventArgs) Handles startdate.ValueChanged
        dates(3)

    End Sub
    Private Sub enddate_ValueChanged(sender As Object, e As EventArgs) Handles enddate.ValueChanged
        dates(3)
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        dates(-1)
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        dates(1)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim detail As String
        If Val(txtrm1.Text) > 0 Then
            detail += $"{lblroom1.Text}: {txtrm1.Text}"
        End If
        If Val(txtrm2.Text) > 0 Then
            detail += $"{lblroom2.Text}: {txtrm2.Text}"
        End If
        If Val(txtrm3.Text) > 0 Then
            detail += $"{lblroom3.Text}: {txtrm3.Text}"
        End If
        If Val(txtrm4.Text) > 0 Then
            detail += $"{lblroom4.Text}: {txtrm4.Text}"
        End If
        Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project1;")
        Dim cmd As SqlCommand = New SqlCommand($"insert into dbo.hotel (userid,startdate,enddate,price,room,details) 
        values((select id from dbo.login where username = N'{login.txtname.Text}' and password = N'{login.txtpwd.Text}')
        ,N'{ startdate.Text }',N'{ enddate.Text }',{ total.Text },{ lblroom.Text},N'{detail}')", con)

        Try
            con.Open()
            If txtrm1.Text = "" And txtrm2.Text = "" And txtrm3.Text = "" And txtrm4.Text = "" Then
                MsgBox("You have choose the room.")
            Else
                MsgBox("booking success")
                cmd.ExecuteNonQuery()
                Me.Close()
            End If

            con.Close()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub
End Class