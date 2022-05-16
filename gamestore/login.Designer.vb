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
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.lblpwd = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblregister = New System.Windows.Forms.LinkLabel()
        Me.lblfindpwd = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(360, 350)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(90, 30)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(310, 30)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(164, 35)
        Me.title.TabIndex = 1
        Me.title.Text = "Game Store"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(320, 144)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(216, 23)
        Me.txtname.TabIndex = 2
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(320, 208)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(216, 23)
        Me.txtpwd.TabIndex = 3
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblpwd.Location = New System.Drawing.Point(207, 203)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(107, 25)
        Me.lblpwd.TabIndex = 4
        Me.lblpwd.Text = "Password:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblname.Location = New System.Drawing.Point(202, 139)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(112, 25)
        Me.lblname.TabIndex = 5
        Me.lblname.Text = "Username:"
        '
        'lblregister
        '
        Me.lblregister.AutoSize = True
        Me.lblregister.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblregister.Location = New System.Drawing.Point(91, 289)
        Me.lblregister.Name = "lblregister"
        Me.lblregister.Size = New System.Drawing.Size(88, 25)
        Me.lblregister.TabIndex = 6
        Me.lblregister.TabStop = True
        Me.lblregister.Text = "Register"
        '
        'lblfindpwd
        '
        Me.lblfindpwd.AutoSize = True
        Me.lblfindpwd.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblfindpwd.Location = New System.Drawing.Point(527, 289)
        Me.lblfindpwd.Name = "lblfindpwd"
        Me.lblfindpwd.Size = New System.Drawing.Size(148, 25)
        Me.lblfindpwd.TabIndex = 7
        Me.lblfindpwd.TabStop = True
        Me.lblfindpwd.Text = "Find Password"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblfindpwd)
        Me.Controls.Add(Me.lblregister)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblpwd)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.btnlogin)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents title As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents lblpwd As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblregister As LinkLabel
    Friend WithEvents lblfindpwd As LinkLabel
End Class
