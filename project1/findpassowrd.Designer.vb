<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class findpassowrd
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
        Me.lblmail = New System.Windows.Forms.Label()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblfindpassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblname.Location = New System.Drawing.Point(209, 145)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(90, 20)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Username:"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblmail.Location = New System.Drawing.Point(238, 237)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(61, 20)
        Me.lblmail.TabIndex = 1
        Me.lblmail.Text = "E-mail:"
        '
        'btnfind
        '
        Me.btnfind.Location = New System.Drawing.Point(675, 375)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(92, 35)
        Me.btnfind.TabIndex = 2
        Me.btnfind.Text = "Submit"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(333, 142)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(256, 23)
        Me.txtname.TabIndex = 3
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(333, 234)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(256, 23)
        Me.txtmail.TabIndex = 4
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(550, 375)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(92, 35)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblfindpassword
        '
        Me.lblfindpassword.AutoSize = True
        Me.lblfindpassword.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblfindpassword.Location = New System.Drawing.Point(310, 15)
        Me.lblfindpassword.Name = "lblfindpassword"
        Me.lblfindpassword.Size = New System.Drawing.Size(196, 35)
        Me.lblfindpassword.TabIndex = 6
        Me.lblfindpassword.Text = "Find Password"
        '
        'findpassowrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblfindpassword)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.lblmail)
        Me.Controls.Add(Me.lblname)
        Me.Name = "findpassowrd"
        Me.Text = "Find Password Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents lblmail As Label
    Friend WithEvents btnfind As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtmail As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents lblfindpassword As Label
End Class
