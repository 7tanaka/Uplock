<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginPhase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginPhase))
        Me.pass1 = New System.Windows.Forms.TextBox()
        Me.user1 = New System.Windows.Forms.TextBox()
        Me.logBar1 = New CircularProgressBar.CircularProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMax = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMin = New FontAwesome.Sharp.IconPictureBox()
        Me.btnClose = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pass1
        '
        Me.pass1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pass1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pass1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.pass1.Location = New System.Drawing.Point(33, 233)
        Me.pass1.Margin = New System.Windows.Forms.Padding(2)
        Me.pass1.Multiline = True
        Me.pass1.Name = "pass1"
        Me.pass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass1.Size = New System.Drawing.Size(267, 37)
        Me.pass1.TabIndex = 3
        Me.pass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'user1
        '
        Me.user1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.user1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.user1.Location = New System.Drawing.Point(33, 188)
        Me.user1.Margin = New System.Windows.Forms.Padding(2)
        Me.user1.Multiline = True
        Me.user1.Name = "user1"
        Me.user1.Size = New System.Drawing.Size(267, 37)
        Me.user1.TabIndex = 2
        Me.user1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'logBar1
        '
        Me.logBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseOut
        Me.logBar1.AnimationSpeed = 500
        Me.logBar1.BackColor = System.Drawing.Color.Transparent
        Me.logBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.logBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.logBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logBar1.InnerMargin = 2
        Me.logBar1.InnerWidth = -1
        Me.logBar1.Location = New System.Drawing.Point(140, 281)
        Me.logBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.logBar1.MarqueeAnimationSpeed = 2000
        Me.logBar1.Name = "logBar1"
        Me.logBar1.OuterColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logBar1.OuterMargin = -25
        Me.logBar1.OuterWidth = 26
        Me.logBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.logBar1.ProgressWidth = 25
        Me.logBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.logBar1.Size = New System.Drawing.Size(39, 41)
        Me.logBar1.StartAngle = 270
        Me.logBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.logBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.logBar1.SubscriptText = ".23"
        Me.logBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.logBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.logBar1.SuperscriptText = "°C"
        Me.logBar1.TabIndex = 5
        Me.logBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.logBar1.Value = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(90, 30)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 136)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMax.IconColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnMax.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMax.IconSize = 19
        Me.btnMax.Location = New System.Drawing.Point(282, 1)
        Me.btnMax.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(19, 20)
        Me.btnMax.TabIndex = 32
        Me.btnMax.TabStop = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMin.IconColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 19
        Me.btnMin.Location = New System.Drawing.Point(259, 1)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(19, 20)
        Me.btnMin.TabIndex = 31
        Me.btnMin.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnClose.IconColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 19
        Me.btnClose.Location = New System.Drawing.Point(305, 1)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 20)
        Me.btnClose.TabIndex = 30
        Me.btnClose.TabStop = False
        '
        'loginPhase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(326, 334)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.user1)
        Me.Controls.Add(Me.pass1)
        Me.Controls.Add(Me.logBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(342, 373)
        Me.Name = "loginPhase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pass1 As TextBox
    Friend WithEvents user1 As TextBox
    Friend WithEvents logBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMax As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnMin As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnClose As FontAwesome.Sharp.IconPictureBox
End Class
