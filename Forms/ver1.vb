
Public Class ver1

    Private Sub verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        logBar2.Enabled = False
        PictureBox1.Enabled = False


        My.Computer.Audio.Play(My.Resources.veriReq, AudioPlayMode.Background)
        Me.CenterToScreen()
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loginPhase.Hide()
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        My.Computer.Audio.Play(My.Resources.ans1, AudioPlayMode.Background)
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        My.Computer.Audio.Play(My.Resources.ans1, AudioPlayMode.Background)
    End Sub
    Private Sub TextBox3_MouseHover(sender As Object, e As EventArgs) Handles TextBox3.MouseHover
        My.Computer.Audio.Play(My.Resources.ans1, AudioPlayMode.Background)
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
            logBar2.InnerColor = Color.White
            logBar2.ProgressColor = Color.FromArgb(74, 74, 76)
            logBar2.OuterColor = Color.White
            logBar2.Enabled = True

        Else
            logBar2.Value = 25
            logBar2.InnerColor = Color.White
            logBar2.ProgressColor = Color.Red
            logBar2.OuterColor = Color.FromArgb(74, 74, 76)
        End If
    End Sub

    Private Sub logBar2_Click(sender As Object, e As EventArgs) Handles logBar2.Click
        If logBar2.Value = 100 Then
            Me.Hide()
            Form1.Visible = True
        Else
            My.Computer.Audio.Play(My.Resources.errorD, AudioPlayMode.Background)
            MessageBox.Show("Unauthorized Access Detected! Closing Application", "UPLOCK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If

    End Sub

    Private Sub logBar2_MouseHover(sender As Object, e As EventArgs) Handles logBar2.MouseHover
        My.Computer.Audio.Play(My.Resources.welcomeV, AudioPlayMode.Background)
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






End Class