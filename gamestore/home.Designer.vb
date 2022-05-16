<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.lblname = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblmoney = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.lblsave = New System.Windows.Forms.LinkLabel()
        Me.lblrecord = New System.Windows.Forms.LinkLabel()
        Me.lblpersonal = New System.Windows.Forms.LinkLabel()
        Me.lbllonout = New System.Windows.Forms.LinkLabel()
        Me.btnbuy = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblname.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblname.Location = New System.Drawing.Point(53, 59)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(0, 25)
        Me.lblname.TabIndex = 1
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(101, 84)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.Size = New System.Drawing.Size(696, 323)
        Me.dgv.TabIndex = 2
        '
        'lblmoney
        '
        Me.lblmoney.AutoSize = True
        Me.lblmoney.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblmoney.Location = New System.Drawing.Point(707, 59)
        Me.lblmoney.Name = "lblmoney"
        Me.lblmoney.Size = New System.Drawing.Size(0, 25)
        Me.lblmoney.TabIndex = 3
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl1.Location = New System.Drawing.Point(677, 59)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(24, 25)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "$"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(360, 30)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(93, 35)
        Me.title.TabIndex = 5
        Me.title.Text = "Home"
        '
        'lblsave
        '
        Me.lblsave.AutoSize = True
        Me.lblsave.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblsave.Location = New System.Drawing.Point(5, 147)
        Me.lblsave.Name = "lblsave"
        Me.lblsave.Size = New System.Drawing.Size(90, 18)
        Me.lblsave.TabIndex = 6
        Me.lblsave.TabStop = True
        Me.lblsave.Text = "Save Money"
        '
        'lblrecord
        '
        Me.lblrecord.AutoSize = True
        Me.lblrecord.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblrecord.Location = New System.Drawing.Point(22, 315)
        Me.lblrecord.Name = "lblrecord"
        Me.lblrecord.Size = New System.Drawing.Size(55, 18)
        Me.lblrecord.TabIndex = 7
        Me.lblrecord.TabStop = True
        Me.lblrecord.Text = "Record"
        '
        'lblpersonal
        '
        Me.lblpersonal.AutoSize = True
        Me.lblpersonal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblpersonal.Location = New System.Drawing.Point(12, 234)
        Me.lblpersonal.Name = "lblpersonal"
        Me.lblpersonal.Size = New System.Drawing.Size(65, 18)
        Me.lblpersonal.TabIndex = 8
        Me.lblpersonal.TabStop = True
        Me.lblpersonal.Text = "Personal"
        '
        'lbllonout
        '
        Me.lbllonout.AutoSize = True
        Me.lbllonout.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbllonout.Location = New System.Drawing.Point(21, 389)
        Me.lbllonout.Name = "lbllonout"
        Me.lbllonout.Size = New System.Drawing.Size(56, 18)
        Me.lbllonout.TabIndex = 9
        Me.lbllonout.TabStop = True
        Me.lbllonout.Text = "Logout"
        '
        'btnbuy
        '
        Me.btnbuy.Location = New System.Drawing.Point(380, 415)
        Me.btnbuy.Name = "btnbuy"
        Me.btnbuy.Size = New System.Drawing.Size(90, 30)
        Me.btnbuy.TabIndex = 10
        Me.btnbuy.Text = "Buy"
        Me.btnbuy.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnbuy)
        Me.Controls.Add(Me.lbllonout)
        Me.Controls.Add(Me.lblpersonal)
        Me.Controls.Add(Me.lblrecord)
        Me.Controls.Add(Me.lblsave)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblmoney)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblname)
        Me.Name = "home"
        Me.Text = "home"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents lblmoney As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents title As Label
    Friend WithEvents lblsave As LinkLabel
    Friend WithEvents lblrecord As LinkLabel
    Friend WithEvents lblpersonal As LinkLabel
    Friend WithEvents lbllonout As LinkLabel
    Friend WithEvents btnbuy As Button
End Class
