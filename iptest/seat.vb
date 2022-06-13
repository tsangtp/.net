Public Class seat
    Private Sub seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        title.Text = menu.name
        seat()
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
End Class