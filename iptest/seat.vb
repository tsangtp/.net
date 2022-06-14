Public Class seat
    Private Sub seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        title.Text = menu.localname
        seat()
        setting()
    End Sub
    Private Sub seat()
        Dim rows As Integer = 100
        Dim n As String = title.Text
        For Each item As KeyValuePair(Of String, List(Of menu.customer)) In menu.local
            Dim customerlist As List(Of menu.customer) = item.Value
            For Each i In customerlist
                If i.location.Contains(title.Text) Then ' display the same location seat
                    Dim lb As New Label
                    Dim btn As New Button
                    lb.Name = i.seat
                    lb.Location = New Point(150, rows)
                    lb.Size = New Size(200, 20)
                    lb.Text = i.seat
                    lb.AutoSize = True
                    btn.Name = i.seat
                    btn.Location = New Point(400, rows)
                    btn.Size = New Size(20, 20)
                    If i.pinok Then ' seat ping
                        btn.BackColor = Color.Green
                    Else
                        btn.BackColor = Color.Red
                    End If
                    btn.Enabled = False
                    Controls.Add(btn)
                    Controls.Add(lb)
                    rows += 30
                End If
            Next
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
        success.Cursor = Cursors.Hand
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
        fail.Cursor = Cursors.Hand
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
End Class
