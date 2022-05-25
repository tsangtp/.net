Imports System.Data.SqlClient
Imports CinemaSystem.BLL
Imports CinemaSystem.Models

Public Class mainmenu
    Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project3;")
    Dim movieManager As MovieManager = New MovieManager()
    Dim releaseManager As ReleaseManager = New ReleaseManager()
    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp.MinDate = DateTime.Now ' set today is minimum
        BindMovieTree() 'run treeview
        setsit() ' set the sit number 

    End Sub
    Dim btns As New List(Of Button) 'save all btn
    Dim operatorid As Integer ' save operatorid
    Dim checkvisible(50) As Boolean ' save operator sit visible
    Dim releaseid As Integer 'save releaseid
    Public btn As New Button 'save btn infomation
    Dim sitid As Integer 'save sitid

    Public ReadOnly Property getdata As template
        Get
            Dim objTemplate = New template(sitid, releaseid, operatorid)
            Return objTemplate
        End Get
    End Property
    Private Sub sittable()
        con.Open()
        Dim release As New SqlCommand($"select * from release where playtime = N'{tvmovies.SelectedNode.ToString.Replace("TreeNode:", "").Trim}' and 
        playdate = N'{dtp.Value.ToString("yyyyMMdd")}' and 
        movieid = (select movieid from movie where moviename = N'{tvmovies.SelectedNode.Parent.ToString.Replace("TreeNode:", "").Trim}')", con)
        Dim dr As SqlDataReader
        dr = release.ExecuteReader
        dr.Read()
        releaseid = dr.GetInt32(0) ' save releaseid
        operatorid = dr.GetInt32(2) ' save operatorid
        dr.Close()
        Dim checksit As New SqlCommand($"select sit.sitid, sit.operatorid, sit.sitname,sit.visible,sit.row,sit.col,
        isnull(ticket.ticketid,0) as ticketid,ticket.releaseid,ticket.price,ticket.discount
        from (select * from sit where operatorid ={operatorid} ) as sit left join 
		(Select * from ticket where releaseid={releaseid}) AS TICKET on sit.Sitid = ticket.sitid;", con)
        Dim o As Integer = 0
        dr = checksit.ExecuteReader
        While dr.Read()
            checkvisible(o) = (dr.GetBoolean(3))
            If checkvisible(o) = False Then
                btns(o).Visible = False
            Else
                btns(o).Visible = True
                btns(o).Enabled = True
            End If
            seat.Controls.Add(btns(o))

            If dr.IsDBNull(9) = False Then
                btns(o).Enabled = False
                btns(o).BackColor = Color.Red
            Else
                btns(o).Enabled = True
                btns(o).BackColor = Color.Gray
            End If
            o += 1
            If o > 49 Then
                Exit While
            End If
        End While
        con.Close()
    End Sub
    Private Sub btntime_Click(sender As Object, e As EventArgs) Handles btntime.Click
        tvmovies.Nodes.Clear()
        BindMovieTree()
    End Sub
    Private Sub BindMovieTree()
        Dim movieList As List(Of Movie) = New List(Of Movie)
        Dim releaseList As List(Of Release) = New List(Of Release)
        releaseList = releaseManager.GetReleaseList()
        movieList = movieManager.GetMovieList()

        For Each movie In movieList
            Dim tn_Movie As TreeNode = New TreeNode(movie.moviename)
            tn_Movie.Tag = movie
            Dim list As List(Of Release) = New List(Of Release)
            list = releaseList.Where(Function(x) x.movieid = movie.movieid And x.playdate.ToString("yyyyMMdd") = dtp.Value.ToString("yyyyMMdd")).ToList()
            For Each item In list
                Dim tn_release As TreeNode = New TreeNode(item.playtime)
                tn_release.Tag = item
                tn_Movie.Nodes.Add(tn_release)
            Next
            Me.tvmovies.Nodes.Add(tn_Movie)
            tvmovies.ExpandAll()
        Next
    End Sub

    Public Sub Initvmovies()
        If tvmovies.SelectedNode.Level = 1 Then
            showinfo(1)
        ElseIf tvmovies.SelectedNode.Level = 0 Then
            Showinfo()
        End If
    End Sub

    Private Sub tvmovies_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvmovies.AfterSelect
        Initvmovies()
    End Sub
    Delegate Sub DelShowInfo(i As Integer)

    Public Sub Showinfo(ByVal Optional i As Integer = 0)
        If InvokeRequired Then
            Invoke(New DelShowInfo(AddressOf Showinfo), i)
        Else
            Dim movie As Movie
            If i = 1 Then
                movie = tvmovies.SelectedNode.Parent.Tag
                sittable()
                discount_persent()
            Else
                movie = tvmovies.SelectedNode.Tag
            End If
            moviename.Text = movie.moviename
            director.Text = movie.director
            actor.Text = movie.actor.Replace(vbCrLf, " ")
            type.Text = movie.type
            time.Text = movie.duration
            poster.ImageLocation = movie.poster
        End If
    End Sub
    Private Sub sell(ByVal btn As Button)
        con.Open()
        Dim check As New SqlCommand($"select * from dbo.sit where sitname = N'{btn.Name}' and operatorid = {operatorid}", con)
        Dim dr As SqlDataReader
        If check.ExecuteScalar() Then
            dr = check.ExecuteReader
            dr.Read()
            sitid = (dr.GetInt32(0))
            dr.Close()
        End If
        con.Close()
        buy.Show()
    End Sub
    Private Sub discount_persent()
        Dim discount As New SqlCommand($"select * from dbo.discount where
        begintime <= {Convert.ToInt32(tvmovies.SelectedNode.ToString.Replace("TreeNode:", "").Replace(":00", "").Trim)} 
        And endtime >= {Convert.ToInt32(tvmovies.SelectedNode.ToString.Replace("TreeNode:", "").Replace(":00", "").Trim)}", con)
        con.Open()
        Dim dr As SqlDataReader
        dr = discount.ExecuteReader()
        If dr.Read() Then
            price.Text = dr.GetDouble(2) * 150
        Else
            price.Text = 150
        End If
        con.Close()
    End Sub
    Private Sub setsit(Optional num As Integer = 0)
        seat.Controls.Clear()
        Dim a As Integer = 1
        Dim j As Integer = 1
        Dim x As Integer = 50
        Dim y As Integer = 70
        Dim Screen As New Button
        Screen.Location = New Point(x + 150, y - 40)
        Screen.Size = New Size(430, 20)
        Screen.Enabled = False
        Screen.BackColor = Color.Black
        seat.Controls.Add(Screen)
        con.Open()
        For i As Integer = 1 To 50
            Dim btn As New Button
            btn.Name = (j).ToString + "-" + (a).ToString
            btn.Text = (j).ToString + "-" + (a).ToString
            btn.BackColor = Color.Gray
            btn.Location = New Point(x, y)
            btn.Size = New Size(50, 25)
            btn.Enabled = False
            AddHandler btn.Click, Sub(sender, EventArgs) sell(btn)
            btns.Add(btn)
            seat.Controls.Add(btn)
            x += 75
            a += 1
            If i Mod 10 = 0 Then
                y += 50
                x = 50
                j += 1
                a = 1
            End If
        Next
        con.Close()
        Dim empty As New Button
        empty.Name = "empty"
        empty.Location = New Point(570, 0)
        empty.Size = New Size(40, 20)
        empty.Enabled = False
        empty.BackColor = Color.Gray
        description.Controls.Add(empty)
        Dim selled As New Button
        selled.Name = "selled"
        selled.Location = New Point(670, 0)
        selled.Size = New Size(40, 20)
        selled.Enabled = False
        selled.BackColor = Color.Red
        description.Controls.Add(selled)
        Dim mon As New Button
        mon.Name = "mon"
        mon.Location = New Point(470, 0)
        mon.Size = New Size(40, 20)
        mon.Enabled = False
        mon.BackColor = Color.Black
        description.Controls.Add(mon)
        Dim lblemtpy As New Label
        lblemtpy.Text = "Empty"
        lblemtpy.Location = New Point(570, 20)
        description.Controls.Add(lblemtpy)
        Dim lblselled As New Label
        lblselled.Text = "Selled"
        lblselled.Location = New Point(670, 20)
        description.Controls.Add(lblselled)
        Dim lblscreen As New Label
        lblscreen.Text = "Screen"
        lblscreen.Location = New Point(470, 20)
        description.Controls.Add(lblscreen)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As String = "      sd  sd         "
        MsgBox(d.Trim)
    End Sub
End Class
