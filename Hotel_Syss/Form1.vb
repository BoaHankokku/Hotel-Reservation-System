Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices


Public Class Form1

    Inherits Form
    'Fields
    Private currentBtn As IconButton
    Private LeftBorderbtn As Panel
    Private currentChildForm As Form
    Private dgvUsers As DataGridView
    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LeftBorderbtn = New Panel()
        LeftBorderbtn.Size = New Size(7, 60)
        panelMenu.Controls.Add(LeftBorderbtn)
        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    Private Sub ActivateButton(senderbtn As Object, customColor As Color)
        If senderbtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderbtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left border
            LeftBorderbtn.BackColor = customColor
            LeftBorderbtn.Location = New Point(0, currentBtn.Location.Y)
            LeftBorderbtn.Visible = True
            LeftBorderbtn.BringToFront()
            'Current Form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    'open forms

    Private Sub OpenChildForm(childForm As Form)
        'open forms
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelDesktop.Controls.Add(childForm)
        panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text

    End Sub

    'buttons activate

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, Color.AliceBlue)
        OpenChildForm(New Dashboard)
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        ActivateButton(sender, Color.Cyan)
        OpenChildForm(New Reservation(dgvUsers))
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ActivateButton(sender, Color.Pink)
        OpenChildForm(New Book(dgvUsers))
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ActivateButton(sender, Color.Red)

    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        ActivateButton(sender, Color.Violet)
        OpenChildForm(New Rooms)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()

    End Sub
    Private Sub Reset()
        DisableButton()
        LeftBorderbtn.Visible = False
        IconCurrentForm.IconChar = IconChar.House
        IconCurrentForm.IconColor = Color.AliceBlue
        lblFormTitle.Text = "HOME"
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ActivateButton(sender, Color.Blue)
        OpenChildForm(New Customers)
    End Sub
    'Drag form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)
    End Sub
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles panelDesktop.Paint

    End Sub
End Class
