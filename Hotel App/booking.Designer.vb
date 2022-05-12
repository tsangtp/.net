<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booking
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
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.enddate = New System.Windows.Forms.DateTimePicker()
        Me.lblroom1 = New System.Windows.Forms.Label()
        Me.lblroom2 = New System.Windows.Forms.Label()
        Me.lblroom3 = New System.Windows.Forms.Label()
        Me.lblroom4 = New System.Windows.Forms.Label()
        Me.txtrm1 = New System.Windows.Forms.TextBox()
        Me.txtrm2 = New System.Windows.Forms.TextBox()
        Me.txtrm3 = New System.Windows.Forms.TextBox()
        Me.txtrm4 = New System.Windows.Forms.TextBox()
        Me.lblday = New System.Windows.Forms.Label()
        Me.e1 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.lblrm1 = New System.Windows.Forms.Label()
        Me.lblrm2 = New System.Windows.Forms.Label()
        Me.lblrm3 = New System.Windows.Forms.Label()
        Me.lblrm4 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.txtday = New System.Windows.Forms.TextBox()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbldays = New System.Windows.Forms.Label()
        Me.lblroom = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'startdate
        '
        Me.startdate.Location = New System.Drawing.Point(138, 125)
        Me.startdate.Name = "startdate"
        Me.startdate.Size = New System.Drawing.Size(200, 23)
        Me.startdate.TabIndex = 0
        '
        'enddate
        '
        Me.enddate.Location = New System.Drawing.Point(476, 125)
        Me.enddate.Name = "enddate"
        Me.enddate.Size = New System.Drawing.Size(200, 23)
        Me.enddate.TabIndex = 1
        '
        'lblroom1
        '
        Me.lblroom1.AutoSize = True
        Me.lblroom1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblroom1.Location = New System.Drawing.Point(106, 217)
        Me.lblroom1.Name = "lblroom1"
        Me.lblroom1.Size = New System.Drawing.Size(182, 20)
        Me.lblroom1.TabIndex = 6
        Me.lblroom1.Text = "Single Bedrooms($500)"
        '
        'lblroom2
        '
        Me.lblroom2.AutoSize = True
        Me.lblroom2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblroom2.Location = New System.Drawing.Point(106, 252)
        Me.lblroom2.Name = "lblroom2"
        Me.lblroom2.Size = New System.Drawing.Size(191, 20)
        Me.lblroom2.TabIndex = 7
        Me.lblroom2.Text = "Double Bedrooms($800)"
        '
        'lblroom3
        '
        Me.lblroom3.AutoSize = True
        Me.lblroom3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblroom3.Location = New System.Drawing.Point(106, 286)
        Me.lblroom3.Name = "lblroom3"
        Me.lblroom3.Size = New System.Drawing.Size(191, 20)
        Me.lblroom3.TabIndex = 8
        Me.lblroom3.Text = "Executive Rooms($1500)"
        '
        'lblroom4
        '
        Me.lblroom4.AutoSize = True
        Me.lblroom4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblroom4.Location = New System.Drawing.Point(106, 322)
        Me.lblroom4.Name = "lblroom4"
        Me.lblroom4.Size = New System.Drawing.Size(177, 20)
        Me.lblroom4.TabIndex = 9
        Me.lblroom4.Text = "President Suite($5000)"
        '
        'txtrm1
        '
        Me.txtrm1.Location = New System.Drawing.Point(294, 218)
        Me.txtrm1.Name = "txtrm1"
        Me.txtrm1.Size = New System.Drawing.Size(100, 23)
        Me.txtrm1.TabIndex = 10
        '
        'txtrm2
        '
        Me.txtrm2.Location = New System.Drawing.Point(294, 248)
        Me.txtrm2.Name = "txtrm2"
        Me.txtrm2.Size = New System.Drawing.Size(100, 23)
        Me.txtrm2.TabIndex = 11
        '
        'txtrm3
        '
        Me.txtrm3.Location = New System.Drawing.Point(294, 282)
        Me.txtrm3.Name = "txtrm3"
        Me.txtrm3.Size = New System.Drawing.Size(100, 23)
        Me.txtrm3.TabIndex = 12
        '
        'txtrm4
        '
        Me.txtrm4.Location = New System.Drawing.Point(294, 318)
        Me.txtrm4.Name = "txtrm4"
        Me.txtrm4.Size = New System.Drawing.Size(100, 23)
        Me.txtrm4.TabIndex = 13
        '
        'lblday
        '
        Me.lblday.AutoSize = True
        Me.lblday.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblday.Location = New System.Drawing.Point(425, 128)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(45, 20)
        Me.lblday.TabIndex = 16
        Me.lblday.Text = "Days"
        '
        'e1
        '
        Me.e1.AutoSize = True
        Me.e1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.e1.Location = New System.Drawing.Point(532, 326)
        Me.e1.Name = "e1"
        Me.e1.Size = New System.Drawing.Size(38, 20)
        Me.e1.TabIndex = 17
        Me.e1.Text = "=  $"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(350, 15)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(120, 35)
        Me.title.TabIndex = 18
        Me.title.Text = "Booking"
        '
        'lblrm1
        '
        Me.lblrm1.AutoSize = True
        Me.lblrm1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblrm1.Location = New System.Drawing.Point(400, 221)
        Me.lblrm1.Name = "lblrm1"
        Me.lblrm1.Size = New System.Drawing.Size(61, 20)
        Me.lblrm1.TabIndex = 19
        Me.lblrm1.Text = "Rooms"
        '
        'lblrm2
        '
        Me.lblrm2.AutoSize = True
        Me.lblrm2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblrm2.Location = New System.Drawing.Point(400, 251)
        Me.lblrm2.Name = "lblrm2"
        Me.lblrm2.Size = New System.Drawing.Size(61, 20)
        Me.lblrm2.TabIndex = 20
        Me.lblrm2.Text = "Rooms"
        '
        'lblrm3
        '
        Me.lblrm3.AutoSize = True
        Me.lblrm3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblrm3.Location = New System.Drawing.Point(400, 285)
        Me.lblrm3.Name = "lblrm3"
        Me.lblrm3.Size = New System.Drawing.Size(61, 20)
        Me.lblrm3.TabIndex = 21
        Me.lblrm3.Text = "Rooms"
        '
        'lblrm4
        '
        Me.lblrm4.AutoSize = True
        Me.lblrm4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblrm4.Location = New System.Drawing.Point(400, 321)
        Me.lblrm4.Name = "lblrm4"
        Me.lblrm4.Size = New System.Drawing.Size(61, 20)
        Me.lblrm4.TabIndex = 22
        Me.lblrm4.Text = "Rooms"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.total.Location = New System.Drawing.Point(589, 326)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(18, 20)
        Me.total.TabIndex = 23
        Me.total.Text = "0"
        '
        'txtday
        '
        Me.txtday.Location = New System.Drawing.Point(360, 125)
        Me.txtday.Name = "txtday"
        Me.txtday.Size = New System.Drawing.Size(66, 23)
        Me.txtday.TabIndex = 24
        '
        'btnminus
        '
        Me.btnminus.Location = New System.Drawing.Point(360, 160)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(15, 23)
        Me.btnminus.TabIndex = 25
        Me.btnminus.Text = "<"
        Me.btnminus.UseVisualStyleBackColor = True
        '
        'btnplus
        '
        Me.btnplus.Location = New System.Drawing.Point(411, 160)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(15, 23)
        Me.btnplus.TabIndex = 26
        Me.btnplus.Text = ">"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl1.Location = New System.Drawing.Point(337, 92)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(129, 20)
        Me.lbl1.TabIndex = 27
        Me.lbl1.Text = "At least one day"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl2.Location = New System.Drawing.Point(589, 226)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(61, 20)
        Me.lbl2.TabIndex = 28
        Me.lbl2.Text = "Rooms"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl3.Location = New System.Drawing.Point(589, 256)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(45, 20)
        Me.lbl3.TabIndex = 29
        Me.lbl3.Text = "Days"
        '
        'lbldays
        '
        Me.lbldays.AutoSize = True
        Me.lbldays.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbldays.Location = New System.Drawing.Point(532, 256)
        Me.lbldays.Name = "lbldays"
        Me.lbldays.Size = New System.Drawing.Size(18, 20)
        Me.lbldays.TabIndex = 30
        Me.lbldays.Text = "0"
        '
        'lblroom
        '
        Me.lblroom.AutoSize = True
        Me.lblroom.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblroom.Location = New System.Drawing.Point(532, 226)
        Me.lblroom.Name = "lblroom"
        Me.lblroom.Size = New System.Drawing.Size(18, 20)
        Me.lblroom.TabIndex = 31
        Me.lblroom.Text = "0"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblprice.Location = New System.Drawing.Point(532, 287)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(18, 20)
        Me.lblprice.TabIndex = 32
        Me.lblprice.Text = "0"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl4.Location = New System.Drawing.Point(589, 287)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(53, 20)
        Me.lbl4.TabIndex = 33
        Me.lbl4.Text = "Prices"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl5.Location = New System.Drawing.Point(467, 269)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(51, 20)
        Me.lbl5.TabIndex = 34
        Me.lbl5.Text = "Totel:"
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(675, 375)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(92, 35)
        Me.btnsubmit.TabIndex = 35
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(550, 375)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(92, 35)
        Me.btncancel.TabIndex = 36
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl6.Location = New System.Drawing.Point(237, 186)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(290, 20)
        Me.lbl6.TabIndex = 37
        Me.lbl6.Text = "Please input number.(Input other =0)"
        '
        'booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblroom)
        Me.Controls.Add(Me.lbldays)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btnminus)
        Me.Controls.Add(Me.txtday)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.lblrm4)
        Me.Controls.Add(Me.lblrm3)
        Me.Controls.Add(Me.lblrm2)
        Me.Controls.Add(Me.lblrm1)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.e1)
        Me.Controls.Add(Me.lblday)
        Me.Controls.Add(Me.txtrm4)
        Me.Controls.Add(Me.txtrm3)
        Me.Controls.Add(Me.txtrm2)
        Me.Controls.Add(Me.txtrm1)
        Me.Controls.Add(Me.lblroom4)
        Me.Controls.Add(Me.lblroom3)
        Me.Controls.Add(Me.lblroom2)
        Me.Controls.Add(Me.lblroom1)
        Me.Controls.Add(Me.enddate)
        Me.Controls.Add(Me.startdate)
        Me.Name = "booking"
        Me.Text = "booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startdate As DateTimePicker
    Friend WithEvents enddate As DateTimePicker
    Friend WithEvents lblroom1 As Label
    Friend WithEvents lblroom2 As Label
    Friend WithEvents lblroom3 As Label
    Friend WithEvents lblroom4 As Label
    Friend WithEvents txtrm1 As TextBox
    Friend WithEvents txtrm2 As TextBox
    Friend WithEvents txtrm3 As TextBox
    Friend WithEvents txtrm4 As TextBox
    Friend WithEvents lblday As Label
    Friend WithEvents e1 As Label
    Friend WithEvents title As Label
    Friend WithEvents lblrm1 As Label
    Friend WithEvents lblrm2 As Label
    Friend WithEvents lblrm3 As Label
    Friend WithEvents lblrm4 As Label
    Friend WithEvents total As Label
    Friend WithEvents txtday As TextBox
    Friend WithEvents btnminus As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbldays As Label
    Friend WithEvents lblroom As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents lbl6 As Label
End Class
