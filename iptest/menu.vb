Imports System.IO
Imports System.Data.SqlClient
Imports System.Threading
Public Class menu
    Dim reader = File.OpenText("..\ip.txt") ' open the txt file
    Dim line As New ArrayList() ' save the txt file each line
    Public localname As String 'return the location name to seat form
    Dim btns As New List(Of Button) 'save the button
    Public local As New Dictionary(Of String, List(Of customer)) 'save values, location is key, other infomation is values
    Dim initbool = True ' check the first time boolean
    Dim ConnectSuccess As Boolean = True 'save server connection situation
    Dim ConnectIp As String 'save server ip
    Public Class customer ' create a class to package information
        Public location As String
        Public pinok As Boolean
        Public time As String
        Public seat As String
        Public ip As String
        Public Sub New(ByVal location As String, ByVal pinok As Boolean, ByVal time As String, ByVal seat As String, ByVal ip As String) ' ping information
            Me.location = location
            Me.pinok = pinok
            Me.time = time
            Me.seat = seat
            Me.ip = ip
        End Sub
        Public Sub New(ByVal location As String, ByVal pinok As Boolean, ByVal time As String, ByVal ip As String) ' server infomation
            Me.location = location
            Me.pinok = pinok
            Me.time = time
            Me.ip = ip
        End Sub
    End Class
    Private Sub threading()
        While True
            pin()
            Thread.Sleep(60000) ' every 1 minute to run
        End While
    End Sub
    Private Sub pin() ' pin the ip address
        Dim print As New List(Of customer) ' save the different data
        Dim len As Integer = 0 ' button number
        For Each item As KeyValuePair(Of String, List(Of customer)) In local 'each item key and value of local
            Dim customerlist As List(Of customer) = item.Value
            Dim data As customer
            Dim bool As Boolean = True ' check ping
            For Each value In customerlist
                If value.ip = ConnectIp Then
                    Try
                        Dim con As New SqlConnection($"server={ConnectIp};uid=sa;pwd=sa;database=test;")
                        con.Open()
                        con.Close()
                        If ConnectSuccess = False Then
                            ConnectSuccess = True
                            data = New customer(value.location, ConnectSuccess, value.time, value.ip)
                        Else
                            ConnectSuccess = True
                        End If
                    Catch ex As Exception
                        If ConnectSuccess = True Then
                            ConnectSuccess = False
                            data = New customer(value.location, ConnectSuccess, value.time, value.ip)
                        Else
                            ConnectSuccess = False
                        End If
                        bool = False
                    End Try
                    If ConnectSuccess = True Then
                        btns(len).BackColor = Color.Green
                    Else
                        btns(len).BackColor = Color.Red
                    End If
                Else
                    If My.Computer.Network.Ping(value.ip, 500) Then
                        If Not value.pinok = True And Not initbool Then
                            value.pinok = True
                            data = New customer(value.location, value.pinok, value.time, value.seat, value.ip)
                            print.Add(data)
                        Else
                            value.pinok = True
                        End If
                    Else
                        If value.pinok = True And Not initbool Then
                            value.pinok = False
                            data = New customer(value.location, value.pinok, value.time, value.seat, value.ip)
                            print.Add(data)
                        Else
                            value.pinok = False
                        End If
                        bool = False
                    End If
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
        createtxt(print) ' create a log file or write in log file
    End Sub
    Private Sub info() 'create button and local label
        Dim rows As Integer = 100
        For Each i In local.Keys
            Dim lb As New Label
            Dim btn As New Button
            lb.Name = i
            lb.Location = New Point(150, rows)
            lb.Size = New Size(300, 20)
            lb.Text = i
            lb.AutoSize = True
            lb.Cursor = Cursors.Hand
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
            If i Like "*Server" Then 'check the name, if name have server, just can not click
                lb.Enabled = False
            End If
            AddHandler lb.Click, Sub() sub_show(lb) ' if label chick, run form
        Next
    End Sub
    Private Sub setting()
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
        Dim th As Thread = New Thread(New ThreadStart(AddressOf threading))
        th.Start() ' start the loop
        setting()
    End Sub
    Private Sub sub_show(ByVal lb As Label)
        localname = lb.Text ' pass name to seat form
        seat.Show()
    End Sub
    Private Sub customer_data()
        Dim s() As String
        Dim i As Integer = 0
        Dim check As Integer
        Dim first As Boolean = True
        While reader.peek() > -1 ' watch all data in txt file until the last word
            Dim data As customer
            line.Add(reader.ReadLine()) ' read each line
            If i > 0 Then
                s = line(i).split(",") ' each line use commera to assign
                If first Then 'first time, just one time
                    check = s.Length ' save last s.length to compare
                    first = False
                End If
                If Not local.ContainsKey(s(1)) Then 'if each line location is not equal local key, just add other local
                    local.Add(s(1), New List(Of customer))
                End If
                If s.Length < check Then 'if true,it is server
                    data = New customer(s(1), ConnectSuccess, Today.ToString("D"), s(0))
                    local.Item(s(1)).Add(data) 'save the information of server
                    ConnectIp = s(0) 'save the server ip to check connection
                Else
                    data = New customer(s(1), False, Today.ToString("D"), s(2), s(0))
                    local.Item(s(1)).Add(data) ' save the information of same location
                End If
                check = s.Length
            End If
            i += 1
        End While
    End Sub
    Private Sub createtxt(print As List(Of customer)) 'create a txt file and write in txt file
        Dim filename As String = Today.ToString("D")
        Dim sw As StreamWriter
        Dim path As String = $"..\{filename}.txt" ' path and file name
        If File.Exists(path) Then ' if path exist just write, if no just create txt
            sw = File.AppendText(path) 'write in
            If print.Count > 0 Then 'if printcustomer query bigger than 0
                sw.WriteLine("-----------------------------------------------------------------------------------------------------")
            End If
            For Each i In print
                sw.WriteLine($"{Today.Now.ToString("G")},{i.location},{i.seat},{i.pinok}")
            Next
        Else
            sw = File.CreateText(path) 'create txt file
            sw.WriteLine("Date             location                                                                      pin/ok")
            sw.WriteLine("-----------------------------------------------------------------------------------------------------")
            For Each item As KeyValuePair(Of String, List(Of customer)) In local
                Dim customerlist As List(Of customer) = item.Value
                For Each a In customerlist
                    sw.WriteLine($"{Today.Now.ToString("G")},{a.location},{a.seat},{a.pinok}")
                Next
            Next
        End If
        sw.Flush()
        sw.Close()
    End Sub
End Class
