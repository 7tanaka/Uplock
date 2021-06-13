<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.ProgressBar1.AnimationSpeed = 500
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.InnerMargin = 2
        Me.ProgressBar1.InnerWidth = -1
        Me.ProgressBar1.Location = New System.Drawing.Point(46, 40)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.MarqueeAnimationSpeed = 2000
        Me.ProgressBar1.Maximum = 90
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.OuterColor = System.Drawing.Color.White
        Me.ProgressBar1.OuterMargin = -25
        Me.ProgressBar1.OuterWidth = 26
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.ProgressWidth = 25
        Me.ProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.ProgressBar1.Size = New System.Drawing.Size(240, 260)
        Me.ProgressBar1.StartAngle = 270
        Me.ProgressBar1.Step = 5
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.ProgressBar1.SubscriptText = ".23"
        Me.ProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.ProgressBar1.SuperscriptText = "°C"
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.ProgressBar1.Value = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(106, 98)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(326, 334)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(342, 373)
        Me.Name = "Loading"
        Me.Text = "Loading"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox1 As PictureBox
End Class
