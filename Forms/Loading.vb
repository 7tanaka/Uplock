Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 85 Then
            loginPhase.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.welcomeJarv, AudioPlayMode.Background)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        BackColor = Color.White
        TransparencyKey = BackColor
    End Sub

    Private Sub Loading_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = False Then
            My.Computer.Audio.Play(My.Resources.logVal, AudioPlayMode.Background)
        End If
    End Sub
End Class