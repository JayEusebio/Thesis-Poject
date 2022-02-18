<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaff
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCheckIN = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewReservation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckInListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResevedListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOutListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RoomListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolbarCheckIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarCheckOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarReserve = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolbarAddGuest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolbarExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.status = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.status.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MonitoringToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCheckIN, Me.NewReservation, Me.ToolStripMenuItem1, Me.FileLogOut, Me.FileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewCheckIN
        '
        Me.NewCheckIN.Name = "NewCheckIN"
        Me.NewCheckIN.Size = New System.Drawing.Size(162, 22)
        Me.NewCheckIN.Text = "New Check In"
        '
        'NewReservation
        '
        Me.NewReservation.Name = "NewReservation"
        Me.NewReservation.Size = New System.Drawing.Size(162, 22)
        Me.NewReservation.Text = "New Reservation"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 6)
        '
        'FileLogOut
        '
        Me.FileLogOut.Name = "FileLogOut"
        Me.FileLogOut.Size = New System.Drawing.Size(162, 22)
        Me.FileLogOut.Text = "Log Out"
        '
        'FileExit
        '
        Me.FileExit.Name = "FileExit"
        Me.FileExit.Size = New System.Drawing.Size(162, 22)
        Me.FileExit.Text = "Exit"
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckInListToolStripMenuItem, Me.ResevedListToolStripMenuItem, Me.CheckOutListToolStripMenuItem, Me.ToolStripMenuItem2, Me.RoomListToolStripMenuItem})
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.MonitoringToolStripMenuItem.Text = "&Monitoring"
        '
        'CheckInListToolStripMenuItem
        '
        Me.CheckInListToolStripMenuItem.Name = "CheckInListToolStripMenuItem"
        Me.CheckInListToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CheckInListToolStripMenuItem.Text = "&Check In List"
        '
        'ResevedListToolStripMenuItem
        '
        Me.ResevedListToolStripMenuItem.Name = "ResevedListToolStripMenuItem"
        Me.ResevedListToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ResevedListToolStripMenuItem.Text = "&Reseved List"
        '
        'CheckOutListToolStripMenuItem
        '
        Me.CheckOutListToolStripMenuItem.Name = "CheckOutListToolStripMenuItem"
        Me.CheckOutListToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CheckOutListToolStripMenuItem.Text = "&Check Out List"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(148, 6)
        '
        'RoomListToolStripMenuItem
        '
        Me.RoomListToolStripMenuItem.Name = "RoomListToolStripMenuItem"
        Me.RoomListToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RoomListToolStripMenuItem.Text = "&Room Status"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolbarCheckIn, Me.ToolStripButton11, Me.toolbarCheckOut, Me.ToolStripSeparator6, Me.toolbarReserve, Me.ToolStripSeparator8, Me.ToolbarAddGuest, Me.ToolStripSeparator12, Me.ToolbarExit, Me.ToolStripSeparator10})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 39)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolbarCheckIn
        '
        Me.toolbarCheckIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolbarCheckIn.Image = CType(resources.GetObject("toolbarCheckIn.Image"), System.Drawing.Image)
        Me.toolbarCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarCheckIn.Name = "toolbarCheckIn"
        Me.toolbarCheckIn.Size = New System.Drawing.Size(36, 36)
        Me.toolbarCheckIn.Text = "ToolStripCheckIN"
        Me.toolbarCheckIn.ToolTipText = "Checkin"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarCheckOut
        '
        Me.toolbarCheckOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolbarCheckOut.Image = CType(resources.GetObject("toolbarCheckOut.Image"), System.Drawing.Image)
        Me.toolbarCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarCheckOut.Name = "toolbarCheckOut"
        Me.toolbarCheckOut.Size = New System.Drawing.Size(36, 36)
        Me.toolbarCheckOut.Text = "ToolStripButton12"
        Me.toolbarCheckOut.ToolTipText = "Checkout"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarReserve
        '
        Me.toolbarReserve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolbarReserve.Image = CType(resources.GetObject("toolbarReserve.Image"), System.Drawing.Image)
        Me.toolbarReserve.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarReserve.Name = "toolbarReserve"
        Me.toolbarReserve.Size = New System.Drawing.Size(36, 36)
        Me.toolbarReserve.Text = "ToolStripButton13"
        Me.toolbarReserve.ToolTipText = "New Reservation"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'ToolbarAddGuest
        '
        Me.ToolbarAddGuest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolbarAddGuest.Image = CType(resources.GetObject("ToolbarAddGuest.Image"), System.Drawing.Image)
        Me.ToolbarAddGuest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolbarAddGuest.Name = "ToolbarAddGuest"
        Me.ToolbarAddGuest.Size = New System.Drawing.Size(36, 36)
        Me.ToolbarAddGuest.Text = "ToolStripButton10"
        Me.ToolbarAddGuest.ToolTipText = "Add Guest"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 39)
        '
        'ToolbarExit
        '
        Me.ToolbarExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolbarExit.Image = CType(resources.GetObject("ToolbarExit.Image"), System.Drawing.Image)
        Me.ToolbarExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolbarExit.Name = "ToolbarExit"
        Me.ToolbarExit.Size = New System.Drawing.Size(36, 36)
        Me.ToolbarExit.Text = "ToolStripButton12"
        Me.ToolbarExit.ToolTipText = "Logout"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'status
        '
        Me.status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6})
        Me.status.Location = New System.Drawing.Point(0, 618)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(1008, 22)
        Me.status.TabIndex = 16
        Me.status.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.AutoSize = False
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(331, 17)
        Me.ToolStripStatusLabel4.Spring = True
        Me.ToolStripStatusLabel4.Text = "Login as :"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.AutoSize = False
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(331, 17)
        Me.ToolStripStatusLabel5.Spring = True
        Me.ToolStripStatusLabel5.Text = "SEBIONGCO Hotel Reservation System"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.AutoSize = False
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel6.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(331, 17)
        Me.ToolStripStatusLabel6.Spring = True
        Me.ToolStripStatusLabel6.Text = "Date and Time :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 593)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 25)
        Me.Panel1.TabIndex = 17
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripLabel2, Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripSeparator11})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Auto Slide On"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel2.Text = "Auto Slide On"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Auto Slide Off"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripLabel1.Text = "Auto Slide Off"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 530)
        Me.Panel2.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.HBRS.My.Resources.Resources.Image1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1008, 530)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStaff"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCheckIN As ToolStripMenuItem
    Friend WithEvents NewReservation As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents FileLogOut As ToolStripMenuItem
    Friend WithEvents FileExit As ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckInListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResevedListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckOutListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents RoomListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolbarCheckIn As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripSeparator
    Friend WithEvents toolbarCheckOut As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents toolbarReserve As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolbarAddGuest As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolbarExit As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents status As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
