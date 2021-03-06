Public Class Steam


    Private Sub Steam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SteamDataSet.steam' table. You can move, or remove it, as needed.
        Me.SteamTableAdapter.Fill(Me.SteamDataSet.steam)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SteamBindingSource.AddNew()
        btnAdd.IconColor = Color.FromArgb(74, 74, 76)
        btnAdd.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        SteamBindingSource.MovePrevious()
        btnPrev.IconColor = Color.FromArgb(74, 74, 76)
        btnPrev.BackColor = Color.FromArgb(214, 214, 0)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        SteamBindingSource.MoveNext()
        btnNext.IconColor = Color.FromArgb(74, 74, 76)
        btnNext.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnSave.IconColor = Color.FromArgb(74, 74, 76)
        btnSave.BackColor = Color.FromArgb(214, 214, 0)
        On Error GoTo Feedback
        Me.Validate()
        Me.SteamBindingSource.EndEdit()
        Me.SteamTableAdapter.Update(Me.SteamDataSet)

Feedback:
        MsgBox("Check Your Record", vbInformation)

        Exit Sub
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        SteamBindingSource.RemoveCurrent()
        btnDel.IconColor = Color.FromArgb(74, 74, 76)
        btnDel.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text += "1"



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text += "2"



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text += "3"



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Text += "4"



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox1.Text += "5"



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox1.Text += "6"



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox1.Text += "7"


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text += "8"



    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox1.Text += "9"



    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox1.Text += "0"



    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim label1 As String
        label1 = TextBox1.Text
        If (label1.Equals("021313")) Then
            My.Computer.Audio.Play(My.Resources.verified1a, AudioPlayMode.Background)
            GroupBox1.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.errorD, AudioPlayMode.Background)
            MessageBox.Show("Unauthorized Access Detected! Closing the Application!", "UPLOCK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        My.Computer.Audio.Play(My.Resources.phoneBeep, AudioPlayMode.Background)
    End Sub
    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.IconColor = Color.FromArgb(214, 214, 0)
        btnAdd.BackColor = Color.White

    End Sub

    Private Sub btnAdd_MouseHover(sender As Object, e As EventArgs) Handles btnAdd.MouseHover
        btnAdd.IconColor = Color.FromArgb(74, 74, 76)
        btnAdd.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub btnPrev_MouseHover(sender As Object, e As EventArgs) Handles btnPrev.MouseHover
        btnPrev.IconColor = Color.FromArgb(74, 74, 76)
        btnPrev.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub btnPrev_MouseLeave(sender As Object, e As EventArgs) Handles btnPrev.MouseLeave
        btnPrev.IconColor = Color.FromArgb(214, 214, 0)
        btnPrev.BackColor = Color.White

    End Sub

    Private Sub btnNext_MouseHover(sender As Object, e As EventArgs) Handles btnNext.MouseHover
        btnNext.IconColor = Color.FromArgb(74, 74, 76)
        btnNext.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        btnNext.IconColor = Color.FromArgb(214, 214, 0)
        btnNext.BackColor = Color.White
    End Sub

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        btnSave.IconColor = Color.FromArgb(74, 74, 76)
        btnSave.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.IconColor = Color.FromArgb(214, 214, 0)
        btnSave.BackColor = Color.White
    End Sub

    Private Sub btnDel_MouseHover(sender As Object, e As EventArgs) Handles btnDel.MouseHover
        btnDel.IconColor = Color.FromArgb(74, 74, 76)
        btnDel.BackColor = Color.FromArgb(214, 214, 0)
    End Sub

    Private Sub btnDel_MouseLeave(sender As Object, e As EventArgs) Handles btnDel.MouseLeave
        btnDel.IconColor = Color.FromArgb(214, 214, 0)
        btnDel.BackColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class