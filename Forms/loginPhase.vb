Public Class loginPhase

    Private Sub pass1_MouseHover(sender As Object, e As EventArgs) Handles pass1.MouseHover
        My.Computer.Audio.Play(My.Resources.pass1, AudioPlayMode.Background)
    End Sub

    Private Sub logBar1_MouseHover(sender As Object, e As EventArgs) Handles logBar1.MouseHover
        logBar1.ProgressColor = Color.Green
        logBar1.InnerColor = Color.Green

    End Sub
    Private Sub pass1_Enter(sender As Object, e As EventArgs) Handles pass1.Enter
        My.Computer.Audio.Play(My.Resources.pass1, AudioPlayMode.Background)
    End Sub

    Private Sub user1_Enter(sender As Object, e As EventArgs) Handles user1.Enter
        My.Computer.Audio.Play(My.Resources.user1, AudioPlayMode.Background)
    End Sub

    Private Sub user1_MouseHover(sender As Object, e As EventArgs) Handles user1.MouseHover
        My.Computer.Audio.Play(My.Resources.user1, AudioPlayMode.Background)
    End Sub



    Private Sub user1_TextChanged(sender As Object, e As EventArgs) Handles user1.TextChanged

        If user1.Text = "admin" Then
            logBar1.Value = 50
            logBar1.InnerColor = Color.FromArgb(74, 74, 76)
            logBar1.ProgressColor = Color.FromArgb(74, 74, 76)
        Else
            logBar1.Value = 25
            logBar1.InnerColor = Color.Red
            logBar1.ProgressColor = Color.Red
        End If

    End Sub
    Private Sub pass1_TextChanged(sender As Object, e As EventArgs) Handles pass1.TextChanged
        If user1.Text = "admin" And pass1.Text = "admin" Then
            logBar1.Value = 100
            logBar1.InnerColor = Color.FromArgb(74, 74, 76)
            logBar1.ProgressColor = Color.FromArgb(74, 74, 76)
            Me.Hide()
            verification.Show()
        Else
            logBar1.Value = 25
            logBar1.InnerColor = Color.Red
            logBar1.ProgressColor = Color.Red
        End If
    End Sub

    Private Sub loginPhase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea


    End Sub
    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized

    End Sub


    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        My.Computer.Audio.Play(My.Resources.exit1, AudioPlayMode.Background)
        Me.Hide()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Application.Exit()
        ElseIf result = DialogResult.No Then
            My.Computer.Audio.Play(My.Resources.return1, AudioPlayMode.Background)
            MessageBox.Show("Returning to the Application", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Show()
            My.Computer.Audio.Play(My.Resources.mainSound, AudioPlayMode.Background)

        End If
    End Sub


End Class