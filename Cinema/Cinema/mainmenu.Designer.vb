<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainmenu
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
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.MovieManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovieManagerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimePlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl1 = New System.Windows.Forms.GroupBox()
        Me.tvmovies = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btntime = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.description = New System.Windows.Forms.Panel()
        Me.seat = New System.Windows.Forms.GroupBox()
        Me.md = New System.Windows.Forms.GroupBox()
        Me.time = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.actor = New System.Windows.Forms.Label()
        Me.poster = New System.Windows.Forms.PictureBox()
        Me.moviename = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.type = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.lblactor = New System.Windows.Forms.Label()
        Me.director = New System.Windows.Forms.Label()
        Me.lbldirector = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.menu.SuspendLayout()
        Me.lbl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.md.SuspendLayout()
        CType(Me.poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovieManagerToolStripMenuItem, Me.SystemToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(1016, 24)
        Me.menu.TabIndex = 0
        Me.menu.Text = "MenuStrip1"
        '
        'MovieManagerToolStripMenuItem
        '
        Me.MovieManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovieManagerToolStripMenuItem1, Me.TimePlanToolStripMenuItem})
        Me.MovieManagerToolStripMenuItem.Name = "MovieManagerToolStripMenuItem"
        Me.MovieManagerToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.MovieManagerToolStripMenuItem.Text = "movie manager"
        '
        'MovieManagerToolStripMenuItem1
        '
        Me.MovieManagerToolStripMenuItem1.Name = "MovieManagerToolStripMenuItem1"
        Me.MovieManagerToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.MovieManagerToolStripMenuItem1.Text = "Movie Manager"
        '
        'TimePlanToolStripMenuItem
        '
        Me.TimePlanToolStripMenuItem.Name = "TimePlanToolStripMenuItem"
        Me.TimePlanToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TimePlanToolStripMenuItem.Text = "Time Plan"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'lbl1
        '
        Me.lbl1.Controls.Add(Me.tvmovies)
        Me.lbl1.Controls.Add(Me.Panel2)
        Me.lbl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl1.Location = New System.Drawing.Point(0, 24)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(200, 573)
        Me.lbl1.TabIndex = 1
        Me.lbl1.TabStop = False
        Me.lbl1.Text = "Time List"
        '
        'tvmovies
        '
        Me.tvmovies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvmovies.Location = New System.Drawing.Point(3, 50)
        Me.tvmovies.Name = "tvmovies"
        Me.tvmovies.Size = New System.Drawing.Size(194, 520)
        Me.tvmovies.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btntime)
        Me.Panel2.Controls.Add(Me.dtp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 31)
        Me.Panel2.TabIndex = 0
        '
        'btntime
        '
        Me.btntime.Location = New System.Drawing.Point(139, 5)
        Me.btntime.Name = "btntime"
        Me.btntime.Size = New System.Drawing.Size(55, 23)
        Me.btntime.TabIndex = 1
        Me.btntime.Text = "Select"
        Me.btntime.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(3, 5)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(130, 23)
        Me.dtp.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.description)
        Me.Panel1.Controls.Add(Me.seat)
        Me.Panel1.Controls.Add(Me.md)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(200, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 573)
        Me.Panel1.TabIndex = 2
        '
        'description
        '
        Me.description.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.description.Location = New System.Drawing.Point(0, 523)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(816, 50)
        Me.description.TabIndex = 0
        '
        'seat
        '
        Me.seat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seat.Location = New System.Drawing.Point(0, 210)
        Me.seat.Name = "seat"
        Me.seat.Size = New System.Drawing.Size(816, 363)
        Me.seat.TabIndex = 1
        Me.seat.TabStop = False
        Me.seat.Text = "Seat"
        '
        'md
        '
        Me.md.Controls.Add(Me.Button1)
        Me.md.Controls.Add(Me.time)
        Me.md.Controls.Add(Me.lbl3)
        Me.md.Controls.Add(Me.lbl2)
        Me.md.Controls.Add(Me.actor)
        Me.md.Controls.Add(Me.poster)
        Me.md.Controls.Add(Me.moviename)
        Me.md.Controls.Add(Me.lblname)
        Me.md.Controls.Add(Me.price)
        Me.md.Controls.Add(Me.lblprice)
        Me.md.Controls.Add(Me.lbltime)
        Me.md.Controls.Add(Me.type)
        Me.md.Controls.Add(Me.lbltype)
        Me.md.Controls.Add(Me.lblactor)
        Me.md.Controls.Add(Me.director)
        Me.md.Controls.Add(Me.lbldirector)
        Me.md.Dock = System.Windows.Forms.DockStyle.Top
        Me.md.Location = New System.Drawing.Point(0, 0)
        Me.md.Name = "md"
        Me.md.Size = New System.Drawing.Size(816, 210)
        Me.md.TabIndex = 0
        Me.md.TabStop = False
        Me.md.Text = "Movie Detail"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Location = New System.Drawing.Point(212, 148)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(35, 15)
        Me.time.TabIndex = 7
        Me.time.Text = "Time"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(245, 148)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(46, 15)
        Me.lbl3.TabIndex = 16
        Me.lbl3.Text = "minute"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(197, 178)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(14, 15)
        Me.lbl2.TabIndex = 15
        Me.lbl2.Text = "$"
        '
        'actor
        '
        Me.actor.Location = New System.Drawing.Point(212, 81)
        Me.actor.Name = "actor"
        Me.actor.Size = New System.Drawing.Size(486, 37)
        Me.actor.TabIndex = 3
        Me.actor.Text = "Name"
        '
        'poster
        '
        Me.poster.Location = New System.Drawing.Point(17, 48)
        Me.poster.Name = "poster"
        Me.poster.Size = New System.Drawing.Size(128, 145)
        Me.poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.poster.TabIndex = 14
        Me.poster.TabStop = False
        '
        'moviename
        '
        Me.moviename.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.moviename.AutoSize = True
        Me.moviename.Location = New System.Drawing.Point(107, 28)
        Me.moviename.Name = "moviename"
        Me.moviename.Size = New System.Drawing.Size(42, 15)
        Me.moviename.TabIndex = 13
        Me.moviename.Text = "Name"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(17, 28)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(84, 15)
        Me.lblname.TabIndex = 12
        Me.lblname.Text = "Movie Name:"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Location = New System.Drawing.Point(213, 178)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(34, 15)
        Me.price.TabIndex = 9
        Me.price.Text = "Price"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(152, 178)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(37, 15)
        Me.lblprice.TabIndex = 8
        Me.lblprice.Text = "Price:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(151, 148)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(38, 15)
        Me.lbltime.TabIndex = 6
        Me.lbltime.Text = "Time:"
        '
        'type
        '
        Me.type.AutoSize = True
        Me.type.Location = New System.Drawing.Point(212, 118)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(35, 15)
        Me.type.TabIndex = 5
        Me.type.Text = "Type"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(151, 118)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(38, 15)
        Me.lbltype.TabIndex = 4
        Me.lbltype.Text = "Type:"
        '
        'lblactor
        '
        Me.lblactor.AutoSize = True
        Me.lblactor.Location = New System.Drawing.Point(152, 81)
        Me.lblactor.Name = "lblactor"
        Me.lblactor.Size = New System.Drawing.Size(40, 15)
        Me.lblactor.TabIndex = 2
        Me.lblactor.Text = "Actor:"
        '
        'director
        '
        Me.director.AutoSize = True
        Me.director.Location = New System.Drawing.Point(212, 50)
        Me.director.Name = "director"
        Me.director.Size = New System.Drawing.Size(42, 15)
        Me.director.TabIndex = 1
        Me.director.Text = "Name"
        '
        'lbldirector
        '
        Me.lbldirector.AutoSize = True
        Me.lbldirector.Location = New System.Drawing.Point(151, 50)
        Me.lbldirector.Name = "lbldirector"
        Me.lbldirector.Size = New System.Drawing.Size(55, 15)
        Me.lbldirector.TabIndex = 0
        Me.lbldirector.Text = "Director:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(518, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 597)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.menu)
        Me.MainMenuStrip = Me.menu
        Me.Name = "mainmenu"
        Me.Text = "Form1"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.lbl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.md.ResumeLayout(False)
        Me.md.PerformLayout()
        CType(Me.poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu As MenuStrip
    Friend WithEvents MovieManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovieManagerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimePlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btntime As Button
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents seat As GroupBox
    Friend WithEvents tvmovies As TreeView
    Friend WithEvents description As Panel
    Friend WithEvents md As GroupBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents actor As Label
    Friend WithEvents poster As PictureBox
    Friend WithEvents moviename As Label
    Friend WithEvents lblname As Label
    Friend WithEvents price As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents time As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents type As Label
    Friend WithEvents lbltype As Label
    Friend WithEvents lblactor As Label
    Friend WithEvents director As Label
    Friend WithEvents lbldirector As Label
    Friend WithEvents Button1 As Button
End Class
