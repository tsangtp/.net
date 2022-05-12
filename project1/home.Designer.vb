<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.pn = New System.Windows.Forms.Panel()
        Me.lbllogout = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnbooking = New System.Windows.Forms.Button()
        Me.btnpersonal = New System.Windows.Forms.Button()
        Me.btnrecord = New System.Windows.Forms.Button()
        Me.pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft JhengHei UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitle.Location = New System.Drawing.Point(180, 20)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(466, 43)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Welcome to My Application"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblname.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblname.Location = New System.Drawing.Point(10, 6)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(65, 25)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "name"
        '
        'pn
        '
        Me.pn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pn.Controls.Add(Me.lbllogout)
        Me.pn.Controls.Add(Me.lblname)
        Me.pn.Location = New System.Drawing.Point(710, 30)
        Me.pn.Name = "pn"
        Me.pn.Size = New System.Drawing.Size(78, 35)
        Me.pn.TabIndex = 2
        '
        'lbllogout
        '
        Me.lbllogout.AutoSize = True
        Me.lbllogout.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbllogout.Location = New System.Drawing.Point(0, 41)
        Me.lbllogout.Name = "lbllogout"
        Me.lbllogout.Size = New System.Drawing.Size(80, 25)
        Me.lbllogout.TabIndex = 3
        Me.lbllogout.Text = "Logout"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'btnbooking
        '
        Me.btnbooking.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnbooking.Location = New System.Drawing.Point(158, 95)
        Me.btnbooking.Name = "btnbooking"
        Me.btnbooking.Size = New System.Drawing.Size(500, 100)
        Me.btnbooking.TabIndex = 3
        Me.btnbooking.Text = "Booking"
        Me.btnbooking.UseVisualStyleBackColor = True
        '
        'btnpersonal
        '
        Me.btnpersonal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnpersonal.Location = New System.Drawing.Point(158, 189)
        Me.btnpersonal.Name = "btnpersonal"
        Me.btnpersonal.Size = New System.Drawing.Size(500, 100)
        Me.btnpersonal.TabIndex = 4
        Me.btnpersonal.Text = "Personal"
        Me.btnpersonal.UseVisualStyleBackColor = True
        '
        'btnrecord
        '
        Me.btnrecord.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnrecord.Location = New System.Drawing.Point(158, 283)
        Me.btnrecord.Name = "btnrecord"
        Me.btnrecord.Size = New System.Drawing.Size(500, 100)
        Me.btnrecord.TabIndex = 5
        Me.btnrecord.Text = "Record"
        Me.btnrecord.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pn)
        Me.Controls.Add(Me.btnrecord)
        Me.Controls.Add(Me.btnpersonal)
        Me.Controls.Add(Me.btnbooking)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "home"
        Me.Text = "Home Page"
        Me.pn.ResumeLayout(False)
        Me.pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents lblname As Label
    Friend WithEvents pn As Panel
    Friend WithEvents lbllogout As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnbooking As Button
    Friend WithEvents btnpersonal As Button
    Friend WithEvents btnrecord As Button
End Class
