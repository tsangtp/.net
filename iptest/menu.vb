Imports System.IO
Imports System.Timers
Imports System.Net.NetworkInformation
Public Class menu
    Dim reader = File.OpenText("C:\Users\PUI\source\repos\iptest\bin\Debug\ip.txt") ' open the txt file
    Dim line As New ArrayList() ' save the txt file each line
    Public name As String 'return the location name to seat form
    Dim btns As New List(Of Button) 'save the button
    Dim gif As New PictureBox 'save the gif
    Public local As New Dictionary(Of String, List(Of customer)) 'save values, location is key, other infomation is values
    Dim printcustomer As New List(Of customer) ' save the different values
    Dim initbool = True ' check the first time boolean
    Public Class customer ' create a class to package information
        Public location As String
        Public pinok As Boolean
        Public time As String
        Public seat As String
        Public ip As String
        Public Sub New(ByVal location As String, ByVal pinok As Boolean, ByVal time As String, ByVal seat As String, ByVal ip As String)
            Me.location = location
            Me.pinok = pinok
            Me.time = time
            Me.seat = seat
            Me.ip = ip
        End Sub
    End Class
    Private Sub t_Tick(sender As Object, e As EventArgs)
        Threading.Thread.Sleep(200)
        pin()
    End Sub
    Private Sub timer()
        Dim t As Timer = New Timer()
        t.Interval = 15000 'each time to run
        AddHandler t.Elapsed, AddressOf t_Tick
        t.Start() ' timers start
    End Sub
    Private Sub pin() ' pin the ip address
        Dim len As Integer = 0
        Dim checkpin As New ArrayList()
        'array for insert log
        gifVisible(True) ' gif visible = Ture 
        For Each item As KeyValuePair(Of String, List(Of customer)) In local
            Dim bool As Boolean = True
            Dim customerlist As List(Of customer) = item.Value ' loop the local dictionary to get each value 
            Dim customerlocation As String = item.Key ' loop the local dictionary to get each key 
            Dim data As customer ' create a new class to store the information
            For Each j In customerlist
                If My.Computer.Network.Ping(j.ip, 50) Then ' ping ip address
                    If Not j.pinok And Not initbool Then ' if ping is ok but the txt file is different just store the information
                        j.pinok = True
                        data = New customer(j.location, j.pinok, j.time, j.seat, j.ip)
                        printcustomer.Add(data)
                    Else
                        j.pinok = True
                    End If
                Else
                    If j.pinok And Not initbool Then ' if ping is not ok but the txt file is different just store the information
                        j.pinok = False
                        data = New customer(j.location, j.pinok, j.time, j.seat, j.ip)
                        printcustomer.Add(data)
                    Else
                        j.pinok = False
                    End If
                    bool = False
                End If
            Next
            If bool Then 'check each customer, if has one customer just the local button background = red
                btns(len).BackColor = Color.Green
            Else
                btns(len).BackColor = Color.Red
            End If
            len += 1
        Next
        initbool = False
        gifVisible(False) ' gif visible = False is not display
        createtxt() ' create a log file or write in log file
    End Sub
    Delegate Sub delGifVisible(ByVal visible As Boolean) ' UI modify
    Private Sub gifVisible(ByVal visible As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New delGifVisible(AddressOf gifVisible), visible)
        Else
            gif.Visible = visible
        End If
    End Sub
    Private Sub info() 'create button and local label
        Dim rows As Integer = 100
        For Each i In local.Keys
            Dim lb As New LinkLabel
            Dim btn As New Button
            lb.Name = i
            lb.Location = New Point(150, rows)
            lb.Size = New Size(200, 20)
            lb.Text = i
            lb.AutoSize = True
            btn.Name = i
            btn.Location = New Point(400, rows)
            btn.Size = New Size(20, 20)
            btn.Enabled = False
            btn.BackColor = Color.Green
            btns.Add(btn)
            Controls.Add(btn)
            Controls.Add(lb)
            rows += 30
            AddHandler lb.Click, Sub() sub_show(lb) ' if label chick, run form
        Next
    End Sub
    Private Sub loading() ' create a loading gif
        gif.Size = New Size(250, 250)
        gif.Location = New Point(450, 150)
        gif.SizeMode = PictureBoxSizeMode.StretchImage
        gif.Image = New Bitmap("C:\Users\PUI\source\repos\iptest\bin\Debug\image\loading.gif")
        Controls.Add(gif)
    End Sub
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer_data()
        info()
        timer()
        loading()
    End Sub
    Private Sub sub_show(ByVal lb As LinkLabel)
        name = lb.Text
        seat.Show()
    End Sub
    Private Sub customer_data()
        Dim data As customer
        Dim s() As String
        Dim i As Integer = 0
        While (reader.peek() > -1) ' watch all data in txt file until the last word
            line.Add(reader.ReadLine()) ' read each line
            If i > 0 Then
                s = line(i).split(",") ' each line use commera to assign
                If Not local.ContainsKey(s(1)) Then 'if each line location is not equal local key, just add other local
                    local.Add(s(1), New List(Of customer))
                End If
                data = New customer(s(1), False, Today.ToString("D"), s(2), s(0))
                local.Item(s(1)).Add(data) ' save the information of same location
            End If
            i += 1
        End While
    End Sub
    Private Sub createtxt() 'create a txt file and write in txt file
        Dim filename As String = Today.ToString("D")
        Dim sw As StreamWriter
    Dim path As String = $"C:\Users\PUI\source\repos\iptest\bin\Debug\{filename}.txt" ' path and file name
        If File.Exists(path) Then ' if path exist just write, if no just create txt
            sw = File.AppendText(path) 'write in
            If printcustomer.Count > 0 Then 'if printcustomer query bigger than 0
                sw.WriteLine("-----------------------------------------------------------------------------------------------------")
            End If
            For Each i In printcustomer
                sw.WriteLine($"{Today.Now.ToString("G")},{i.location},{i.seat},{i.pinok}")
            Next
            printcustomer.Clear() 'remove the array all data
        Else
            sw = File.CreateText(path) 'create txt file
            sw.WriteLine("Date             location                                                                      pin/ok")
            sw.WriteLine("-----------------------------------------------------------------------------------------------------")
            For Each item As KeyValuePair(Of String, List(Of customer)) In local
                Dim customerlist As List(Of customer) = item.Value
                For Each i In customerlist
                    sw.WriteLine($"{Today.Now.ToString("G")},{i.location},{i.seat},{i.pinok}")
                Next
            Next
        End If
        sw.Flush()
        sw.Close()
    End Sub
End Class
