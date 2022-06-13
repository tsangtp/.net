<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seat
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
        Me.title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(359, 46)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(39, 15)
        Me.title.TabIndex = 1
        Me.title.Text = "name"
        '
        'seat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.title)
        Me.Name = "seat"
        Me.Text = "seat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
End Class
