Imports System.Data.SqlClient
Imports System.IO

Public Class buy
    Dim con As New SqlConnection("server=.;uid=sa;pwd=sa;database=project3;")
    Dim discount As String
    Dim getdata = mainmenu.getdata
    Private Sub buy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim opt As New SqlCommand($"select * from operator where operatorid = {getdata.getoperatorid}", con)
        Dim operator_name As String
        Dim operator_location As String
        con.Open()
        Dim dr As SqlDataReader
        dr = opt.ExecuteReader
        If dr.Read() Then
            operator_name = dr.GetString(1)
            operator_location = dr.GetString(2)
        End If

        con.Close()
        moviename.Text = mainmenu.moviename.Text
        dates.Text = mainmenu.dtp.Value
        time.Text = mainmenu.tvmovies.SelectedNode.ToString.Replace("TreeNode:", "")
        operatorname.Text = operator_name
        location.Text = operator_location
        total.Text = mainmenu.price.Text

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub rdadult_CheckedChanged(sender As Object, e As EventArgs) Handles rdadult.CheckedChanged
        total.Text = mainmenu.price.Text
    End Sub

    Private Sub rdchild_CheckedChanged(sender As Object, e As EventArgs) Handles rdchild.CheckedChanged
        total.Text = mainmenu.price.Text * 0.5
    End Sub

    Private Sub rdstudent_CheckedChanged(sender As Object, e As EventArgs) Handles rdstudent.CheckedChanged
        total.Text = mainmenu.price.Text * 0.5
    End Sub
    Private Sub rdover60_CheckedChanged(sender As Object, e As EventArgs) Handles rdover60.CheckedChanged
        total.Text = mainmenu.price.Text * 0.5
    End Sub

    Private Sub btnbuy_Click(sender As Object, e As EventArgs) Handles btnbuy.Click
        If rdadult.Checked Then
            discount = "Adult No Discount"
        ElseIf rdstudent.Checked Then
            discount = "Student Minus 50%"
        ElseIf rdover60.Checked Then
            discount = "Over60 Minus 50%"
        ElseIf rdchild.Checked Then
            discount = "Children(below 13) Minus 50%"
        End If
        con.Open()
        Dim sql As String = $"insert into ticket (releaseid, sitid, price, discount, location, buydate, buytime)
                values({getdata.getreleaseid},{getdata.getsitid},N'{total.Text}',
                N'{discount}',N'{location.Text}',N'{DateTime.Now.ToString("D")}',N'{DateTime.Now.ToString("T")}')"
        Dim buy As New SqlCommand(sql, con)
        buy.ExecuteNonQuery()
        MsgBox("buy success")
        mainmenu.btn.BackColor = Color.Red
        mainmenu.btn.Enabled = False
        con.Close()
        prints()
        mainmenu.Showinfo(1)
        Me.Close()

    End Sub

    Private Sub prints()
        Dim filename As String = $"{DateTime.Now.ToString("D")}{time.Text.Replace(":00", "")}點{moviename.Text}{getdata.getsitid}"
        Dim sw As StreamWriter
        sw = File.CreateText($"C:\Users\PUI\source\repos\Cinema\Cinema\bin\Debug\{filename}.txt")
        sw.WriteLine("*************************************")
        sw.WriteLine("            Cinema System            ")
        sw.WriteLine("-------------------------------------")
        sw.WriteLine($"Movie Name: {moviename.Text}")
        sw.WriteLine($"Date: {dates.Text}")
        sw.WriteLine($"Time: {time.Text}")
        sw.WriteLine($"Operator Name: {operatorname.Text}")
        sw.WriteLine($"Operator No: {getdata.getoperatorid}")
        sw.WriteLine($"Location: {location.Text}")
        sw.WriteLine($"Discount: {discount}")
        sw.WriteLine($"Total price: ${total.Text}")
        sw.WriteLine("*************************************")
        sw.Flush()
        sw.Close()
    End Sub
End Class