<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.lblpwd = New System.Windows.Forms.Label()
        Me.lblforgetpwd = New System.Windows.Forms.LinkLabel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.lblregister = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblname.Location = New System.Drawing.Point(297, 171)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(90, 20)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Username:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(389, 168)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 23)
        Me.txtname.TabIndex = 1
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(389, 232)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(100, 23)
        Me.txtpwd.TabIndex = 3
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblpwd.Location = New System.Drawing.Point(297, 235)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(84, 20)
        Me.lblpwd.TabIndex = 2
        Me.lblpwd.Text = "Password:"
        '
        'lblforgetpwd
        '
        Me.lblforgetpwd.AutoSize = True
        Me.lblforgetpwd.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblforgetpwd.Location = New System.Drawing.Point(540, 272)
        Me.lblforgetpwd.Name = "lblforgetpwd"
        Me.lblforgetpwd.Size = New System.Drawing.Size(133, 20)
        Me.lblforgetpwd.TabIndex = 4
        Me.lblforgetpwd.TabStop = True
        Me.lblforgetpwd.Text = "Forget password"
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(346, 343)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(92, 35)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(300, 30)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(213, 85)
        Me.title.TabIndex = 6
        Me.title.Text = "T app"
        '
        'lblregister
        '
        Me.lblregister.AutoSize = True
        Me.lblregister.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblregister.Location = New System.Drawing.Point(167, 272)
        Me.lblregister.Name = "lblregister"
        Me.lblregister.Size = New System.Drawing.Size(70, 20)
        Me.lblregister.TabIndex = 7
        Me.lblregister.TabStop = True
        Me.lblregister.Text = "Register"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblregister)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblforgetpwd)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.lblpwd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblname)
        Me.Name = "login"
        Me.Text = "Login Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents lblpwd As Label
    Friend WithEvents lblforgetpwd As LinkLabel
    Friend WithEvents btnlogin As Button
    Friend WithEvents title As Label
    Friend WithEvents lblregister As LinkLabel
End Class
