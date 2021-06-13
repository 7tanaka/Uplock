
Public Class verification

    Private Sub verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        logBar2.Enabled = False
        PictureBox1.Enabled = False


        My.Computer.Audio.Play(My.Resources.veriReq, AudioPlayMode.Background)
        Me.CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "batman" And ComboBox1.SelectedItem = "Who was your childhood hero?" Then
            logBar2.Value = 25
            logBar2.InnerColor = Color.White
            logBar2.ProgressColor = Color.FromArgb(74, 74, 76)
            logBar2.OuterColor = Color.White
            ComboBox2.Visible = True
            TextBox3.Visible = True
            logBar2.Enabled = False
        Else
            logBar2.Value = 25
            logBar2.InnerColor = Color.White
            logBar2.ProgressColor = Color.Red
            logBar2.OuterColor = Color.FromArgb(74, 74, 76)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "engineer" And ComboBox2.SelectedItem = "what did you want to be when you grew up?" Then
            logBar2.Value = 50
            logBar2.InnerColor = Color.White
            logBar2.ProgressColor = Color.FromArgb(74, 74, 76)
            logBar2.OuterColor = Color.White
            ComboBox3.Visible = True
            TextBox2.Visible = True
            logBar2.Enabled = False
        Else
            logBar2.Value = 25
            logBar2.InnerColor = Color.White
            logBar2.ProgressColor = Color.Red
            logBar2.OuterColor = Color.FromArgb(74, 74, 76)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "coca-cola" And ComboBox3.SelectedItem = "What is your favorite drinks?" Then
            logBar2.Value = 100
            logBar2.InnerColor = Color.FromArgb(214, 214, 0)
            logBar2.ProgressColor = Color.FromArgb(214, 214, 0)
            logBar2.OuterColor = Color.White
            logBar2.Enabled = True
            Me.Hide()
            Form1.Show()
        Else
            logBar2.Value = 25
            logBar2.InnerColor = Color.White
            logBar2.ProgressColor = Color.Red
            logBar2.OuterColor = Color.FromArgb(74, 74, 76)
        End If
    End Sub
    Private Sub logBar2_MouseHover(sender As Object, e As EventArgs) Handles logBar2.MouseHover
        
        PictureBox1.Enabled = True
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox2.Enabled = False
        logBar2.InnerColor = Color.FromArgb(214, 214, 0)
        logBar2.ProgressColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub logBar2_MouseLeave(sender As Object, e As EventArgs) Handles logBar2.MouseLeave
        logBar2.InnerColor = Color.White
        logBar2.ProgressColor = Color.FromArgb(74, 74, 76)
        PictureBox1.Visible = False
        PictureBox1.Enabled = False
        PictureBox2.Visible = True
        PictureBox2.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

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



End Class