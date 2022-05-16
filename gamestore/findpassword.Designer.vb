<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class findpassword
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
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(450, 380)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(90, 30)
        Me.btnsubmit.TabIndex = 0
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblname.Location = New System.Drawing.Point(205, 162)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(112, 25)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Username:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(323, 162)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(285, 23)
        Me.txtname.TabIndex = 2
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(323, 207)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(285, 23)
        Me.txtmail.TabIndex = 4
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblmail.Location = New System.Drawing.Point(260, 207)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(57, 25)
        Me.lblmail.TabIndex = 3
        Me.lblmail.Text = "Mail:"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(270, 380)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 30)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(300, 30)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(196, 35)
        Me.title.TabIndex = 6
        Me.title.Text = "Find Password"
        '
        'findpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.lblmail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btnsubmit)
        Me.Name = "findpassword"
        Me.Text = "findpassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsubmit As Button
    Friend WithEvents lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtmail As TextBox
    Friend WithEvents lblmail As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents title As Label
End Class
