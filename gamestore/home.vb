Imports System.Data.SqlClient
Public Class home
    Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project2;")
    Dim games As SqlCommand = New SqlCommand("select * from dbo.game", con)
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblname.Text = login.txtname.Text

        Dim dt As DataTable = New DataTable
        Dim da As SqlDataAdapter = New SqlDataAdapter(games)
        da.Fill(dt)
        dgv.DataSource = dt
        Dim money As SqlCommand = New SqlCommand($"select isnull(money,0) as  money from dbo.users where id = (select id from users where name =N'{login.txtname.Text}' and password =N'{login.txtpwd.Text}')", con)
        con.Open()
        Dim dr As SqlDataReader
        dr = money.ExecuteReader()
        dr.Read()
        lblmoney.Text = dr.GetInt32(0)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        con.Close()
    End Sub

    Private Sub lbllonout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbllonout.LinkClicked
        Application.Exit()
    End Sub

    Private Sub lblsave_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblsave.LinkClicked
        Me.Close()
        savemoney.Show()
    End Sub

    Private Sub lblpersonal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblpersonal.LinkClicked
        Me.Close()
        personal.Show()

    End Sub

    Private Sub lblrecord_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblrecord.LinkClicked
        Me.Close()
        record.Show()
    End Sub

    Private Sub btnbuy_Click(sender As Object, e As EventArgs) Handles btnbuy.Click



        Dim gid As Integer = dgv.Rows(dgv.SelectedCells(0).RowIndex).Cells(0).Value
        Dim gquery As Integer = dgv.Rows(dgv.SelectedCells(0).RowIndex).Cells(5).Value
        Dim user As SqlCommand = New SqlCommand($"select isnull(money,0) as money from dbo.users where id = (select id from users where name =N'{login.txtname.Text}')", con)
        Dim game As SqlCommand = New SqlCommand($"select price from dbo.game where gid = {gid}", con)
        Dim cmd As SqlCommand = New SqlCommand($"insert into dbo.record(userid,gid,buydate,price)
        values ((select id from dbo.users where name =N'{login.txtname.Text}')
                ,{gid},'{ DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}',(select price from dbo.game where gid ={gid}))", con)
        Dim item As SqlCommand = New SqlCommand($"update dbo.game set query -= 1 where gid ={gid}", con)
        Dim buy As SqlCommand = New SqlCommand($"update dbo.users set money -= (select price from dbo.game 
        where gid = {gid}) where name = N'{login.txtname.Text}'", con)
        con.Open()
        If gquery > 0 Then
            If Val(user.ExecuteScalar()) > Val(game.ExecuteScalar()) Then

                cmd.ExecuteNonQuery()
                item.ExecuteNonQuery()
                buy.ExecuteNonQuery()
                MsgBox("Buy success")
                lblmoney.Text = user.ExecuteScalar()
                Dim dt As DataTable = New DataTable
                Dim da As SqlDataAdapter = New SqlDataAdapter(games)
                da.Fill(dt)
                dgv.DataSource = dt
            Else
                MsgBox($"You don't have enough money to buy this game.{vbLf}Please save money first.")
            End If
        Else
            Dim gname As SqlCommand = New SqlCommand($"select gname from dbo.game where gid ={gid}", con)
            MsgBox($"Sorry,{gname.ExecuteScalar} is out of stock.")
        End If
        con.Close()
    End Sub
End Class
