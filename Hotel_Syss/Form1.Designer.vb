<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.btnMaximize = New FontAwesome.Sharp.IconPictureBox()
        Me.btnExit = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMinimize = New FontAwesome.Sharp.IconPictureBox()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnRoom = New FontAwesome.Sharp.IconButton()
        Me.btnBook = New FontAwesome.Sharp.IconButton()
        Me.btnReservation = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnCustomers)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.btnRoom)
        Me.panelMenu.Controls.Add(Me.btnBook)
        Me.panelMenu.Controls.Add(Me.btnReservation)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 630)
        Me.panelMenu.TabIndex = 0
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.PictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(220, 190)
        Me.panelLogo.TabIndex = 0
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.btnMaximize)
        Me.panelTitleBar.Controls.Add(Me.btnExit)
        Me.panelTitleBar.Controls.Add(Me.btnMinimize)
        Me.panelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.panelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(914, 74)
        Me.panelTitleBar.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(54, 35)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(54, 18)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "HOME"
        '
        'panelDesktop
        '
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(220, 74)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(914, 556)
        Me.panelDesktop.TabIndex = 2
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Me.btnMaximize.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.Location = New System.Drawing.Point(843, 3)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(32, 32)
        Me.btnMaximize.TabIndex = 4
        Me.btnMaximize.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnExit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExit.IconColor = System.Drawing.Color.Gainsboro
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.Location = New System.Drawing.Point(879, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(32, 32)
        Me.btnExit.TabIndex = 3
        Me.btnExit.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btnMinimize.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.Location = New System.Drawing.Point(805, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 32)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TabStop = False
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(16, 27)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnCustomers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.IconSize = 32
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 430)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(220, 60)
        Me.btnCustomers.TabIndex = 6
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorClosed
        Me.btnLogout.IconColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 32
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 570)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogout.Size = New System.Drawing.Size(220, 60)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRoom.FlatAppearance.BorderSize = 0
        Me.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoom.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRoom.IconChar = FontAwesome.Sharp.IconChar.Bed
        Me.btnRoom.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRoom.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRoom.IconSize = 32
        Me.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoom.Location = New System.Drawing.Point(0, 370)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRoom.Size = New System.Drawing.Size(220, 60)
        Me.btnRoom.TabIndex = 4
        Me.btnRoom.Text = "Room"
        Me.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBook.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnBook.IconColor = System.Drawing.Color.Gainsboro
        Me.btnBook.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBook.IconSize = 32
        Me.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBook.Location = New System.Drawing.Point(0, 310)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBook.Size = New System.Drawing.Size(220, 60)
        Me.btnBook.TabIndex = 3
        Me.btnBook.Text = "Book"
        Me.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnReservation
        '
        Me.btnReservation.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReservation.FlatAppearance.BorderSize = 0
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservation.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReservation.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.btnReservation.IconColor = System.Drawing.Color.Gainsboro
        Me.btnReservation.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReservation.IconSize = 32
        Me.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservation.Location = New System.Drawing.Point(0, 250)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnReservation.Size = New System.Drawing.Size(220, 60)
        Me.btnReservation.TabIndex = 2
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn
        Me.btnDashboard.IconColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 190)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hotel_Syss.My.Resources.Resources._414206214_1063179354735896_8408327191629594648_n
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 630)
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.panelMenu)
        Me.MinimumSize = New System.Drawing.Size(1150, 669)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRoom As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBook As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReservation As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents panelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnExit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconPictureBox
End Class
