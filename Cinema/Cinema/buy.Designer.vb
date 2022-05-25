<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buy
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.rdchild = New System.Windows.Forms.RadioButton()
        Me.rdstudent = New System.Windows.Forms.RadioButton()
        Me.rdover60 = New System.Windows.Forms.RadioButton()
        Me.rdadult = New System.Windows.Forms.RadioButton()
        Me.title = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.moviename = New System.Windows.Forms.Label()
        Me.dates = New System.Windows.Forms.Label()
        Me.operatorname = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.location = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnbuy = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdchild
        '
        Me.rdchild.AutoSize = True
        Me.rdchild.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdchild.Location = New System.Drawing.Point(383, 283)
        Me.rdchild.Name = "rdchild"
        Me.rdchild.Size = New System.Drawing.Size(316, 29)
        Me.rdchild.TabIndex = 4
        Me.rdchild.TabStop = True
        Me.rdchild.Text = "Children(below 13) Minus 50%"
        Me.rdchild.UseVisualStyleBackColor = True
        '
        'rdstudent
        '
        Me.rdstudent.AutoSize = True
        Me.rdstudent.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdstudent.Location = New System.Drawing.Point(200, 283)
        Me.rdstudent.Name = "rdstudent"
        Me.rdstudent.Size = New System.Drawing.Size(160, 29)
        Me.rdstudent.TabIndex = 2
        Me.rdstudent.TabStop = True
        Me.rdstudent.Text = "student (50%)"
        Me.rdstudent.UseVisualStyleBackColor = True
        '
        'rdover60
        '
        Me.rdover60.AutoSize = True
        Me.rdover60.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdover60.Location = New System.Drawing.Point(383, 238)
        Me.rdover60.Name = "rdover60"
        Me.rdover60.Size = New System.Drawing.Size(162, 29)
        Me.rdover60.TabIndex = 3
        Me.rdover60.TabStop = True
        Me.rdover60.Text = "Over 60 (50%)"
        Me.rdover60.UseVisualStyleBackColor = True
        '
        'rdadult
        '
        Me.rdadult.AutoSize = True
        Me.rdadult.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdadult.Location = New System.Drawing.Point(200, 238)
        Me.rdadult.Name = "rdadult"
        Me.rdadult.Size = New System.Drawing.Size(81, 29)
        Me.rdadult.TabIndex = 1
        Me.rdadult.TabStop = True
        Me.rdadult.Text = "Adult"
        Me.rdadult.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(310, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(160, 35)
        Me.title.TabIndex = 5
        Me.title.Text = "Buy System"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl1.Location = New System.Drawing.Point(280, 197)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(190, 25)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "Please choose one:"
        '
        'moviename
        '
        Me.moviename.AutoSize = True
        Me.moviename.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.moviename.ForeColor = System.Drawing.Color.Red
        Me.moviename.Location = New System.Drawing.Point(155, 94)
        Me.moviename.Name = "moviename"
        Me.moviename.Size = New System.Drawing.Size(132, 25)
        Me.moviename.TabIndex = 7
        Me.moviename.Text = "Movie Name"
        '
        'dates
        '
        Me.dates.AutoSize = True
        Me.dates.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dates.ForeColor = System.Drawing.Color.Red
        Me.dates.Location = New System.Drawing.Point(66, 156)
        Me.dates.Name = "dates"
        Me.dates.Size = New System.Drawing.Size(56, 25)
        Me.dates.TabIndex = 8
        Me.dates.Text = "Date"
        '
        'operatorname
        '
        Me.operatorname.AutoSize = True
        Me.operatorname.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.operatorname.ForeColor = System.Drawing.Color.Red
        Me.operatorname.Location = New System.Drawing.Point(622, 94)
        Me.operatorname.Name = "operatorname"
        Me.operatorname.Size = New System.Drawing.Size(159, 25)
        Me.operatorname.TabIndex = 10
        Me.operatorname.Text = "Operator Name"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.time.ForeColor = System.Drawing.Color.Red
        Me.time.Location = New System.Drawing.Point(260, 156)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(58, 25)
        Me.time.TabIndex = 9
        Me.time.Text = "Time"
        '
        'location
        '
        Me.location.AutoSize = True
        Me.location.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.location.ForeColor = System.Drawing.Color.Red
        Me.location.Location = New System.Drawing.Point(552, 156)
        Me.location.Name = "location"
        Me.location.Size = New System.Drawing.Size(93, 25)
        Me.location.TabIndex = 11
        Me.location.Text = "Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(461, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(461, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Operator Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(200, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Movie Name:"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(280, 379)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 30)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnbuy
        '
        Me.btnbuy.Location = New System.Drawing.Point(412, 379)
        Me.btnbuy.Name = "btnbuy"
        Me.btnbuy.Size = New System.Drawing.Size(90, 30)
        Me.btnbuy.TabIndex = 18
        Me.btnbuy.Text = "Buy"
        Me.btnbuy.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltotal.Location = New System.Drawing.Point(292, 328)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(114, 25)
        Me.lbltotal.TabIndex = 19
        Me.lbltotal.Text = "Total Price:"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.total.Location = New System.Drawing.Point(427, 328)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(59, 25)
        Me.total.TabIndex = 20
        Me.total.Text = "Total"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl3.Location = New System.Drawing.Point(404, 328)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(24, 25)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "$"
        '
        'buy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.btnbuy)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.location)
        Me.Controls.Add(Me.operatorname)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.dates)
        Me.Controls.Add(Me.moviename)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.rdadult)
        Me.Controls.Add(Me.rdover60)
        Me.Controls.Add(Me.rdstudent)
        Me.Controls.Add(Me.rdchild)
        Me.Name = "buy"
        Me.Text = "Buy System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents rdchild As RadioButton
    Friend WithEvents rdstudent As RadioButton
    Friend WithEvents rdover60 As RadioButton
    Friend WithEvents rdadult As RadioButton
    Friend WithEvents title As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents moviename As Label
    Friend WithEvents dates As Label
    Friend WithEvents operatorname As Label
    Friend WithEvents time As Label
    Friend WithEvents location As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnbuy As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents total As Label
    Friend WithEvents lbl3 As Label
End Class
