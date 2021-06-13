Imports System.Runtime.InteropServices
Public Class passwordGenerator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        bitCount.Text = "16-bit"
        Dim Letters As New List(Of Integer)
        'add ASCII codes for numbers
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        'lowercase letters
        For i As Integer = 97 To 122
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        For i As Integer = 33 To 46
            Letters.Add(i)
        Next
        'select 8 random integers from number of items in Letters
        'then convert those random integers to characters and
        'add each to a string and display in Textbox
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 16
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
            TextBox1.Text = SB.ToString
        Next
    End Sub
    'Dragging
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        bitCount.Text = "32-bit"
        Dim Letters As New List(Of Integer)
        'add ASCII codes for numbers
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        'lowercase letters
        For i As Integer = 97 To 122
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        For i As Integer = 33 To 46
            Letters.Add(i)
        Next
        'select 8 random integers from number of items in Letters
        'then convert those random integers to characters and
        'add each to a string and display in Textbox
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 32
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
            TextBox1.Text = SB.ToString
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        bitCount.Text = "64-bit"
        Dim Letters As New List(Of Integer)
        'add ASCII codes for numbers
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        'lowercase letters
        For i As Integer = 97 To 122
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        For i As Integer = 33 To 46
            Letters.Add(i)
        Next
        'select 8 random integers from number of items in Letters
        'then convert those random integers to characters and
        'add each to a string and display in Textbox
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 64
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
            TextBox1.Text = SB.ToString
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        bitCount.Text = "128-bit"
        Dim Letters As New List(Of Integer)
        'add ASCII codes for numbers
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        'lowercase letters
        For i As Integer = 97 To 122
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        For i As Integer = 33 To 46
            Letters.Add(i)
        Next
        'select 8 random integers from number of items in Letters
        'then convert those random integers to characters and
        'add each to a string and display in Textbox
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 128
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
            TextBox1.Text = SB.ToString
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Clipboard.SetText(Me.TextBox1.Text, TextDataFormat.Text)
        My.Computer.Audio.Play(My.Resources.copT, AudioPlayMode.Background)


        On Error GoTo Feedback
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.Table1TableAdapter.Update(Me.NosePasDataSet)

Feedback:
        MsgBox("Check Your Record", vbInformation)

        Exit Sub
    End Sub



    Private Sub passwordGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NosePasDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.NosePasDataSet.Table1)


        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        My.Computer.Audio.Play(My.Resources.passGen1, AudioPlayMode.Background)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Hide()
        GroupBox1.Show()
        TextBox2.Clear()
        Button5.Enabled = False



    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
        GroupBox1.Show()
        TextBox2.Clear()
        Button5.Enabled = False
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        My.Computer.Audio.Play(My.Resources.phoneBeep, AudioPlayMode.Background)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox2.Text += "1"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox2.Text += "2"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox2.Text += "3"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox2.Text += "4"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox2.Text += "5"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox2.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Text += "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox2.Text += "0"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim label1 As String
        label1 = TextBox2.Text
        If (label1.Equals("021313")) Then
            My.Computer.Audio.Play(My.Resources.verified1a, AudioPlayMode.Background)
            GroupBox1.Visible = False
            Button5.Enabled = True
        Else

            MessageBox.Show("Access Denied!", "UPLOCK", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
    End Sub

    Private Sub UsedPasswordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NosePasDataSet)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Table1BindingSource.AddNew()
    End Sub

End Class