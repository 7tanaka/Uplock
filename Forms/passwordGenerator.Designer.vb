<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class passwordGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwordGenerator))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnMax = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMin = New FontAwesome.Sharp.IconPictureBox()
        Me.btnClose = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.NosePasDataSet = New Uplock.nosePasDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Uplock.nosePasDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New Uplock.nosePasDataSetTableAdapters.TableAdapterManager()
        Me.Table1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bitCount = New System.Windows.Forms.TextBox()
        Me.Account_SavedTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NosePasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(42, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "16-bit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(124, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "32-bit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(203, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 38)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "64-bit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(280, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 38)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "128-bit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(203, 278)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 56)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "COPY AND SAVE"
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.btnMax.Location = New System.Drawing.Point(352, 8)
        Me.btnMax.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(19, 20)
        Me.btnMax.TabIndex = 9
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
        Me.btnMin.Location = New System.Drawing.Point(329, 8)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(19, 20)
        Me.btnMin.TabIndex = 8
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
        Me.btnClose.Location = New System.Drawing.Point(375, 8)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 20)
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btnMax)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 43)
        Me.Panel1.TabIndex = 10
        '
        'Button18
        '
        Me.Button18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button18.Location = New System.Drawing.Point(151, 93)
        Me.Button18.Margin = New System.Windows.Forms.Padding(2)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(47, 41)
        Me.Button18.TabIndex = 14
        Me.Button18.Text = "1"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button17.Location = New System.Drawing.Point(202, 93)
        Me.Button17.Margin = New System.Windows.Forms.Padding(2)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(47, 41)
        Me.Button17.TabIndex = 15
        Me.Button17.Text = "2"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button16.Location = New System.Drawing.Point(254, 93)
        Me.Button16.Margin = New System.Windows.Forms.Padding(2)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(47, 41)
        Me.Button16.TabIndex = 16
        Me.Button16.Text = "3"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button15.Location = New System.Drawing.Point(151, 139)
        Me.Button15.Margin = New System.Windows.Forms.Padding(2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(47, 41)
        Me.Button15.TabIndex = 17
        Me.Button15.Text = "4"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button14.Location = New System.Drawing.Point(202, 139)
        Me.Button14.Margin = New System.Windows.Forms.Padding(2)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(47, 41)
        Me.Button14.TabIndex = 18
        Me.Button14.Text = "5"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button13.Location = New System.Drawing.Point(254, 139)
        Me.Button13.Margin = New System.Windows.Forms.Padding(2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(47, 41)
        Me.Button13.TabIndex = 19
        Me.Button13.Text = "6"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(151, 185)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(47, 41)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(202, 185)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 41)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(254, 185)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(47, 41)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(210, 232)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(35, 25)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(163, 232)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2)
        Me.Button11.Name = "Button11"
        Me.Button11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button11.Size = New System.Drawing.Size(34, 25)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "D"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(243, 232)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(46, 25)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Ent"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(151, 59)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox2.Size = New System.Drawing.Size(151, 27)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.Button18)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-23, 360)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(468, 342)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, -33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 392)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Button19
        '
        Me.Button19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button19.Location = New System.Drawing.Point(80, 278)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(118, 56)
        Me.Button19.TabIndex = 66
        Me.Button19.Text = "ADD NEW PASSWORD"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'NosePasDataSet
        '
        Me.NosePasDataSet.DataSetName = "nosePasDataSet"
        Me.NosePasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.NosePasDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Uplock.nosePasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table1DataGridView
        '
        Me.Table1DataGridView.AutoGenerateColumns = False
        Me.Table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Table1DataGridView.DataSource = Me.Table1BindingSource
        Me.Table1DataGridView.Location = New System.Drawing.Point(21, 415)
        Me.Table1DataGridView.Name = "Table1DataGridView"
        Me.Table1DataGridView.Size = New System.Drawing.Size(373, 246)
        Me.Table1DataGridView.TabIndex = 67
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bit-Count"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bit-Count"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Account Saved"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Account Saved"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'bitCount
        '
        Me.bitCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bitCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.bitCount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Bit-Count", True))
        Me.bitCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bitCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bitCount.Location = New System.Drawing.Point(148, 155)
        Me.bitCount.Name = "bitCount"
        Me.bitCount.ReadOnly = True
        Me.bitCount.Size = New System.Drawing.Size(100, 23)
        Me.bitCount.TabIndex = 68
        '
        'Account_SavedTextBox
        '
        Me.Account_SavedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Account_SavedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Account_SavedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Account Saved", True))
        Me.Account_SavedTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_SavedTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Account_SavedTextBox.Location = New System.Drawing.Point(148, 198)
        Me.Account_SavedTextBox.Name = "Account_SavedTextBox"
        Me.Account_SavedTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Account_SavedTextBox.TabIndex = 69
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Password", True))
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(42, 49)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(321, 100)
        Me.TextBox1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Platform :"
        '
        'passwordGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(400, 717)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Account_SavedTextBox)
        Me.Controls.Add(Me.bitCount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Table1DataGridView)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(342, 373)
        Me.Name = "passwordGenerator"
        Me.Text = "Password Generator"
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NosePasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnMax As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnMin As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Table1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Table1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button19 As Button
    Friend WithEvents NosePasDataSet As nosePasDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As nosePasDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As nosePasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents bitCount As TextBox
    Friend WithEvents Account_SavedTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
