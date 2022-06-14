Imports System.IO
Imports System.Timers
Imports System.Net.NetworkInformation
Imports System.Data.SqlClient
Imports System.Data
Public Class menu
    Dim reader = File.OpenText("C:\Users\PUI\source\repos\iptest\bin\Debug\ip.txt") ' open the txt file
    Dim line As New ArrayList() ' save the txt file each line
    Public localname As String 'return the location name to seat form
    Dim btns As New List(Of Button) 'save the button
    Dim gif As New PictureBox 'save the gif
    Public local As New Dictionary(Of String, List(Of customer)) 'save values, location is key, other infomation is values
    Dim initbool = True ' check the first time boolean
    Dim ConnectSuccess As Boolean = true
    Dim ConnectIp As String
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
        Dim time = File.OpenText("C:\Users\PUI\source\repos\iptest\bin\Debug\time.txt")
        Dim t As Timer = New Timer()
        t.Interval = time.ReadLine() 'each time to run
        AddHandler t.Elapsed, AddressOf t_Tick
        t.Start() ' timers start
    End Sub
    Private Sub pin() ' pin the ip address
        Dim len As Integer = 0
        Dim printcustomer As New List(Of customer) ' save the different values
        'array for insert log
        gifVisible(True) ' gif visible = Ture 
        Dim itemquery As Integer = 1
        For Each item As KeyValuePair(Of String, List(Of customer)) In local
            Dim bool As Boolean = True
            Dim customerlist As List(Of customer) = item.Value ' loop the local dictionary to get each value 
            Dim customerlocation As String = item.Key ' loop the local dictionary to get each key 
            Dim data As customer ' create a new class to store the information
            If itemquery = local.Count Then
                Try
                    Dim con As New SqlConnection($"server={ConnectIp};uid=sa;pwd=77229943;database=HKU")
                    con.Open()
                    con.Close()
                    If ConnectSuccess = False Then
                        ConnectSuccess = True
                        data = New customer(item.Key, ConnectSuccess, Today.Now.ToString("G"), "", ConnectIp)
                        printcustomer.Add(data)
                    Else
                        ConnectSuccess = True
                    End If
                Catch
                    If ConnectSuccess = True Then
                        ConnectSuccess = False
                        data = New customer(item.Key, ConnectSuccess, Today.Now.ToString("G"), "", ConnectIp)
                        printcustomer.Add(data)
                    Else
                        ConnectSuccess = False
                    End If
                End Try
                If ConnectSuccess = True Then
                    btns(len).BackColor = Color.Green
                Else
                    btns(len).BackColor = Color.Red
                End If
            Else
                For Each j In customerlist
                    If My.Computer.Network.Ping(j.ip, 50) Then ' ping ip address
                        If Not j.pinok = True And Not initbool Then ' if ping is ok but the txt file is different just store the information
                            j.pinok = True
                            data = New customer(j.location, j.pinok, j.time, j.seat, j.ip)
                            printcustomer.Add(data)
                        Else
                            j.pinok = True
                        End If
                    Else
                        If j.pinok = True And Not initbool Then ' if ping is not ok but the txt file is different just store the information
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
            End If
            itemquery += 1
        Next
        initbool = False
        gifVisible(False) ' gif visible = False is not display
        createtxt(printcustomer) ' create a log file or write in log file
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
        Dim itemquery As Integer = 0
        For Each i In local.Keys
            Dim lb As New Label
            Dim btn As New Button
            lb.Name = i
            lb.Location = New Point(150, rows)
            lb.Size = New Size(300, 20)
            lb.Text = i
            lb.AutoSize = True
            lb.Cursor = System.Windows.Forms.Cursors.Hand
            lb.ForeColor = Color.Blue
            btn.Name = i
            btn.Location = New Point(400, rows)
            btn.Size = New Size(20, 20)
            btn.Enabled = False
            btn.BackColor = Color.Green
            btns.Add(btn)
            Controls.Add(btn)
            Controls.Add(lb)
            rows += 30
            itemquery += 1
            If itemquery = local.Count Then '''
                lb.Enabled = False
            End If
            AddHandler lb.Click, Sub() sub_show(lb) ' if label chick, run form
        Next
    End Sub
    Private Sub setting() ' create a loading gif
        gif.Size = New Size(250, 250)
        gif.Location = New Point(450, 150)
        gif.SizeMode = PictureBoxSizeMode.StretchImage
        gif.Image = New Bitmap("C:\Users\PUI\source\repos\iptest\bin\Debug\image\loading.gif")
        Controls.Add(gif)
        Dim success As New Label
        Dim btnsuccess As New Button
        success.Name = "Success"
        success.Location = New Point(600, 75)
        success.Size = New Size(20, 20)
        success.Text = "Success"
        success.AutoSize = True
        btnsuccess.Name = "Success"
        btnsuccess.Location = New Point(615, 50)
        btnsuccess.Size = New Size(25, 25)
        btnsuccess.Enabled = False
        btnsuccess.BackColor = Color.Green
        Dim fail As New Label
        Dim btnfail As New Button
        fail.Name = "Fail"
        fail.Location = New Point(675, 75)
        fail.Size = New Size(20, 20)
        fail.Text = "Fail"
        fail.AutoSize = True
        btnfail.Name = "Fail"
        btnfail.Location = New Point(675, 50)
        btnfail.Size = New Size(25, 25)
        btnfail.Enabled = False
        btnfail.BackColor = Color.Red
        Controls.Add(success)
        Controls.Add(btnsuccess)
        Controls.Add(fail)
        Controls.Add(btnfail)
    End Sub
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer_data()
        info()
        timer()
        setting()
    End Sub
    Private Sub sub_show(ByVal lb As Label)
        localname = lb.Text
        seat.Show()
    End Sub
    Private Sub customer_data()
        Dim data As customer
        Dim s() As String
        Dim i As Integer = 0
        Dim item As Integer = 0
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
            s = line(line.Count - 1).split(",")
            ConnectIp = s(0)
        End While
    End Sub
    Private Sub createtxt(printcustomer As List(Of customer)) 'create a txt file and write in txt file
        Dim filename As String = Today.ToString("D")
        Dim sw As StreamWriter
        Dim path As String = $"C:\Users\PUI\source\repos\iptest\bin\Debug\{filename}.txt" ' path and file name
        Dim itemquery As Integer = 1
        If File.Exists(path) Then ' if path exist just write, if no just create txt
            sw = File.AppendText(path) 'write in
            If printcustomer.Count > 0 Then 'if printcustomer query bigger than 0
                sw.WriteLine("-----------------------------------------------------------------------------------------------------")
            End If
            For Each i In printcustomer
                sw.WriteLine($"{Today.Now.ToString("G")},{i.location},{i.seat},{i.pinok}")
            Next
        Else
            sw = File.CreateText(path) 'create txt file
            sw.WriteLine("Date             location                                                                      pin/ok")
            sw.WriteLine("-----------------------------------------------------------------------------------------------------")
            For Each item As KeyValuePair(Of String, List(Of customer)) In local
                Dim customerlist As List(Of customer) = item.Value
                If itemquery = local.Count Then
                    sw.WriteLine($"{Today.Now.ToString("G")},{item.Key},{ConnectSuccess}")
                Else
                    For Each i In customerlist
                        sw.WriteLine($"{Today.Now.ToString("G")},{i.location},{i.seat},{i.pinok}")
                    Next
                End If
                itemquery += 1
            Next
        End If
        sw.Flush()
        sw.Close()
    End Sub
End Class
