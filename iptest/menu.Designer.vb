<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu
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
        Me.title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(343, 37)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(69, 35)
        Me.title.TabIndex = 0
        Me.title.Text = "Title"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.title)
        Me.name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
End Class
