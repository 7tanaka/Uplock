<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ver1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ver1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.logBar2 = New CircularProgressBar.CircularProgressBar()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(435, 284)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(211, 167)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'logBar2
        '
        Me.logBar2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.logBar2.AnimationSpeed = 500
        Me.logBar2.BackColor = System.Drawing.Color.Transparent
        Me.logBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.logBar2.ForeColor = System.Drawing.Color.White
        Me.logBar2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.logBar2.InnerColor = System.Drawing.Color.White
        Me.logBar2.InnerMargin = 2
        Me.logBar2.InnerWidth = -1
        Me.logBar2.Location = New System.Drawing.Point(356, 199)
        Me.logBar2.MarqueeAnimationSpeed = 2000
        Me.logBar2.Name = "logBar2"
        Me.logBar2.OuterColor = System.Drawing.Color.White
        Me.logBar2.OuterMargin = -25
        Me.logBar2.OuterWidth = 26
        Me.logBar2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.logBar2.ProgressWidth = 25
        Me.logBar2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.logBar2.Size = New System.Drawing.Size(366, 336)
        Me.logBar2.StartAngle = 270
        Me.logBar2.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.logBar2.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.logBar2.SubscriptText = ".23"
        Me.logBar2.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.logBar2.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.logBar2.SuperscriptText = "°C"
        Me.logBar2.TabIndex = 36
        Me.logBar2.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.logBar2.Value = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(49, -114)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(970, 307)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(754, 401)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(315, 35)
        Me.TextBox3.TabIndex = 34
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(356, 623)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(366, 35)
        Me.TextBox2.TabIndex = 33
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(11, 401)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(315, 35)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"When you were young, what did you want to be when you grew up?", "Who was your childhood hero?", "Where was your best family vacation as a kid?", "What is your maiden name?", "What is the name of your first pet?", "What was your first car?", "What elementary school did you attent?", "What is the name of the town where you were born?", "What is the name of you favorite pet?", "What is the first name of the you person you first kissed?", "What is your favorite drinks?", "What was the name of your elementary school?", "In what city or town does your nearest sibling live?"})
        Me.ComboBox3.Location = New System.Drawing.Point(356, 588)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(366, 29)
        Me.ComboBox3.TabIndex = 31
        Me.ComboBox3.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"what did you want to be when you grew up?", "Who was your childhood hero?", "Where was your best family vacation as a kid?", "What is your maiden name?", "What is the name of your first pet?", "What was your first car?", "What elementary school did you attent?", "What is the name of the town where you were born?", "What is the name of you favorite pet?", "What is the first name of the you person you first kissed?", "What is your favorite drinks?", "What was the name of your elementary school?", "In what city or town does your nearest sibling live?"})
        Me.ComboBox2.Location = New System.Drawing.Point(754, 366)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(315, 29)
        Me.ComboBox2.TabIndex = 30
        Me.ComboBox2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"When you were young, what did you want to be when you grew up?", "Who was your childhood hero?", "Where was your best family vacation as a kid?", "What is your maiden name?", "What is the name of your first pet?", "What was your first car?", "What elementary school did you attent?", "What is the name of the town where you were born?", "What is the name of you favorite pet?", "What is the first name of the you person you first kissed?", "What is your favorite drinks?", "What was the name of your elementary school?", "In what city or town does your nearest sibling live?"})
        Me.ComboBox1.Location = New System.Drawing.Point(11, 366)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(315, 29)
        Me.ComboBox1.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(435, 284)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ver1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1082, 703)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.logBar2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.MinimumSize = New System.Drawing.Size(1100, 750)
        Me.Name = "ver1"
        Me.Text = "ver1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logBar2 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
