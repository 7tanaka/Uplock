Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices


Public Class Form1
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Constructor
    Public Sub New()

        'This call is required by the Designer
        InitializeComponent()

        'Add any initalization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 45)
        leftPanel.Controls.Add(leftBorderBtn)
        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    'Methods
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisabledButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(74, 74, 76)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'CurrentForm
            iconForm.IconChar = currentBtn.IconChar
            iconForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(255, 255, 128)
            currentBtn.ForeColor = Color.FromArgb(74, 74, 76)
            currentBtn.IconColor = Color.FromArgb(74, 74, 76)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainDesk.Controls.Add(childForm)
        mainDesk.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblHome.Text = childForm.Text
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New Google)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New Twitter)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New Instagram)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New Youtube)
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New Steam)
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New Garena)
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New Riot)
    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles IconButton10.Click
        ActivateButton(sender, Color.FromArgb(214, 214, 0))
        OpenChildForm(New PhoneNum)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.jarvis, AudioPlayMode.Background)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        DisabledButton()
        leftBorderBtn.Visible = False
        iconForm.IconChar = IconChar.Home
        iconForm.IconColor = Color.FromArgb(214, 214, 0)
        lblHome.Text = "Home"
    End Sub
    'Dragging
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized

    End Sub
End Class