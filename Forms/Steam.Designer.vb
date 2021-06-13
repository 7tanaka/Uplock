<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Steam
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Backup_emailLabel As System.Windows.Forms.Label
        Dim Phone_numberLabel As System.Windows.Forms.Label
        Dim Email_passwordLabel As System.Windows.Forms.Label
        Dim Backup_email_passwordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Steam))
        Me.btnDel = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSave = New FontAwesome.Sharp.IconPictureBox()
        Me.btnNext = New FontAwesome.Sharp.IconPictureBox()
        Me.btnPrev = New FontAwesome.Sharp.IconPictureBox()
        Me.btnAdd = New FontAwesome.Sharp.IconPictureBox()
        Me.SteamDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SteamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SteamDataSet = New Uplock.SteamDataSet()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Backup_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Email_passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Backup_email_passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_numberTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SteamTableAdapter = New Uplock.SteamDataSetTableAdapters.steamTableAdapter()
        Me.TableAdapterManager = New Uplock.SteamDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Backup_emailLabel = New System.Windows.Forms.Label()
        Phone_numberLabel = New System.Windows.Forms.Label()
        Email_passwordLabel = New System.Windows.Forms.Label()
        Backup_email_passwordLabel = New System.Windows.Forms.Label()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SteamDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SteamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SteamDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        IDLabel.Location = New System.Drawing.Point(4, 11)
        IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(32, 19)
        IDLabel.TabIndex = 53
        IDLabel.Text = "ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        UsernameLabel.Location = New System.Drawing.Point(4, 36)
        UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(86, 19)
        UsernameLabel.TabIndex = 54
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        PasswordLabel.Location = New System.Drawing.Point(4, 61)
        PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(82, 19)
        PasswordLabel.TabIndex = 55
        PasswordLabel.Text = "Password:"
        '
        'EmailLabel
        '
        EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        EmailLabel.Location = New System.Drawing.Point(4, 86)
        EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(54, 19)
        EmailLabel.TabIndex = 56
        EmailLabel.Text = "Email:"
        '
        'Backup_emailLabel
        '
        Backup_emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Backup_emailLabel.AutoSize = True
        Backup_emailLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Backup_emailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Backup_emailLabel.Location = New System.Drawing.Point(4, 111)
        Backup_emailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Backup_emailLabel.Name = "Backup_emailLabel"
        Backup_emailLabel.Size = New System.Drawing.Size(108, 19)
        Backup_emailLabel.TabIndex = 57
        Backup_emailLabel.Text = "Backup email:"
        '
        'Phone_numberLabel
        '
        Phone_numberLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Phone_numberLabel.AutoSize = True
        Phone_numberLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_numberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Phone_numberLabel.Location = New System.Drawing.Point(4, 187)
        Phone_numberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Phone_numberLabel.Name = "Phone_numberLabel"
        Phone_numberLabel.Size = New System.Drawing.Size(119, 19)
        Phone_numberLabel.TabIndex = 58
        Phone_numberLabel.Text = "Phone number:"
        '
        'Email_passwordLabel
        '
        Email_passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Email_passwordLabel.AutoSize = True
        Email_passwordLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_passwordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Email_passwordLabel.Location = New System.Drawing.Point(4, 136)
        Email_passwordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Email_passwordLabel.Name = "Email_passwordLabel"
        Email_passwordLabel.Size = New System.Drawing.Size(126, 19)
        Email_passwordLabel.TabIndex = 59
        Email_passwordLabel.Text = "Email password:"
        '
        'Backup_email_passwordLabel
        '
        Backup_email_passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Backup_email_passwordLabel.AutoSize = True
        Backup_email_passwordLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Backup_email_passwordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Backup_email_passwordLabel.Location = New System.Drawing.Point(4, 162)
        Backup_email_passwordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Backup_email_passwordLabel.Name = "Backup_email_passwordLabel"
        Backup_email_passwordLabel.Size = New System.Drawing.Size(180, 19)
        Backup_email_passwordLabel.TabIndex = 60
        Backup_email_passwordLabel.Text = "Backup email password:"
        '
        'btnDel
        '
        Me.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDel.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDel.IconSize = 34
        Me.btnDel.Location = New System.Drawing.Point(394, 396)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Padding = New System.Windows.Forms.Padding(1, 4, 1, 1)
        Me.btnDel.Size = New System.Drawing.Size(34, 37)
        Me.btnDel.TabIndex = 28
        Me.btnDel.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 34
        Me.btnSave.Location = New System.Drawing.Point(355, 396)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(1, 4, 1, 1)
        Me.btnSave.Size = New System.Drawing.Size(34, 37)
        Me.btnSave.TabIndex = 27
        Me.btnSave.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.btnNext.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNext.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNext.IconSize = 34
        Me.btnNext.Location = New System.Drawing.Point(315, 396)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Padding = New System.Windows.Forms.Padding(1, 4, 1, 1)
        Me.btnNext.Size = New System.Drawing.Size(34, 37)
        Me.btnNext.TabIndex = 26
        Me.btnNext.TabStop = False
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrev.IconChar = FontAwesome.Sharp.IconChar.Backward
        Me.btnPrev.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrev.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrev.IconSize = 34
        Me.btnPrev.Location = New System.Drawing.Point(275, 396)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Padding = New System.Windows.Forms.Padding(1, 4, 1, 1)
        Me.btnPrev.Size = New System.Drawing.Size(34, 37)
        Me.btnPrev.TabIndex = 25
        Me.btnPrev.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAdd.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdd.IconSize = 34
        Me.btnAdd.Location = New System.Drawing.Point(236, 396)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(1, 4, 1, 1)
        Me.btnAdd.Size = New System.Drawing.Size(34, 37)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.TabStop = False
        '
        'SteamDataGridView
        '
        Me.SteamDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SteamDataGridView.AutoGenerateColumns = False
        Me.SteamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SteamDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.SteamDataGridView.DataSource = Me.SteamBindingSource
        Me.SteamDataGridView.Location = New System.Drawing.Point(6, 212)
        Me.SteamDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.SteamDataGridView.Name = "SteamDataGridView"
        Me.SteamDataGridView.RowHeadersWidth = 51
        Me.SteamDataGridView.RowTemplate.Height = 24
        Me.SteamDataGridView.Size = New System.Drawing.Size(651, 179)
        Me.SteamDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "email"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "backup email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "backup email"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email password"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email password"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "backup email password"
        Me.DataGridViewTextBoxColumn7.HeaderText = "backup email password"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "phone number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "phone number"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'SteamBindingSource
        '
        Me.SteamBindingSource.DataMember = "steam"
        Me.SteamBindingSource.DataSource = Me.SteamDataSet
        '
        'SteamDataSet
        '
        Me.SteamDataSet.DataSetName = "SteamDataSet"
        Me.SteamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(236, 10)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(267, 21)
        Me.IDTextBox.TabIndex = 30
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(236, 35)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(267, 21)
        Me.UsernameTextBox.TabIndex = 32
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(236, 60)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(267, 21)
        Me.PasswordTextBox.TabIndex = 34
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(236, 85)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(267, 21)
        Me.EmailTextBox.TabIndex = 36
        '
        'Backup_emailTextBox
        '
        Me.Backup_emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Backup_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "backup email", True))
        Me.Backup_emailTextBox.Location = New System.Drawing.Point(236, 110)
        Me.Backup_emailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Backup_emailTextBox.Multiline = True
        Me.Backup_emailTextBox.Name = "Backup_emailTextBox"
        Me.Backup_emailTextBox.Size = New System.Drawing.Size(267, 21)
        Me.Backup_emailTextBox.TabIndex = 38
        '
        'Email_passwordTextBox
        '
        Me.Email_passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Email_passwordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "email password", True))
        Me.Email_passwordTextBox.Location = New System.Drawing.Point(236, 136)
        Me.Email_passwordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Email_passwordTextBox.Multiline = True
        Me.Email_passwordTextBox.Name = "Email_passwordTextBox"
        Me.Email_passwordTextBox.Size = New System.Drawing.Size(267, 21)
        Me.Email_passwordTextBox.TabIndex = 40
        '
        'Backup_email_passwordTextBox
        '
        Me.Backup_email_passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Backup_email_passwordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "backup email password", True))
        Me.Backup_email_passwordTextBox.Location = New System.Drawing.Point(236, 161)
        Me.Backup_email_passwordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Backup_email_passwordTextBox.Multiline = True
        Me.Backup_email_passwordTextBox.Name = "Backup_email_passwordTextBox"
        Me.Backup_email_passwordTextBox.Size = New System.Drawing.Size(267, 21)
        Me.Backup_email_passwordTextBox.TabIndex = 42
        '
        'Phone_numberTextBox
        '
        Me.Phone_numberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Phone_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SteamBindingSource, "phone number", True))
        Me.Phone_numberTextBox.Location = New System.Drawing.Point(236, 186)
        Me.Phone_numberTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_numberTextBox.Multiline = True
        Me.Phone_numberTextBox.Name = "Phone_numberTextBox"
        Me.Phone_numberTextBox.Size = New System.Drawing.Size(267, 21)
        Me.Phone_numberTextBox.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(661, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(682, 475)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(260, 155)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox1.Size = New System.Drawing.Size(151, 27)
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Button12.Location = New System.Drawing.Point(352, 327)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(46, 25)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Ent"
        Me.Button12.UseVisualStyleBackColor = False
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
        Me.Button11.Location = New System.Drawing.Point(272, 327)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2)
        Me.Button11.Name = "Button11"
        Me.Button11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button11.Size = New System.Drawing.Size(34, 25)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "D"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(319, 327)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(35, 25)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(363, 280)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(47, 41)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(311, 280)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 41)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(260, 280)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(47, 41)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(363, 234)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(47, 41)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(311, 234)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 41)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(260, 234)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 41)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(363, 188)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 41)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(311, 188)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 41)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(260, 188)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 41)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 406)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'SteamTableAdapter
        '
        Me.SteamTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.steamTableAdapter = Me.SteamTableAdapter
        Me.TableAdapterManager.UpdateOrder = Uplock.SteamDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Steam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Backup_emailLabel)
        Me.Controls.Add(Phone_numberLabel)
        Me.Controls.Add(Email_passwordLabel)
        Me.Controls.Add(Backup_email_passwordLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Backup_emailTextBox)
        Me.Controls.Add(Me.Email_passwordTextBox)
        Me.Controls.Add(Me.Backup_email_passwordTextBox)
        Me.Controls.Add(Me.Phone_numberTextBox)
        Me.Controls.Add(Me.SteamDataGridView)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnAdd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Steam"
        Me.Text = "Steam"
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SteamDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SteamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SteamDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDel As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnSave As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnNext As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnPrev As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SteamDataSet As SteamDataSet
    Friend WithEvents SteamBindingSource As BindingSource
    Friend WithEvents SteamTableAdapter As SteamDataSetTableAdapters.steamTableAdapter
    Friend WithEvents TableAdapterManager As SteamDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SteamDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Backup_emailTextBox As TextBox
    Friend WithEvents Email_passwordTextBox As TextBox
    Friend WithEvents Backup_email_passwordTextBox As TextBox
    Friend WithEvents Phone_numberTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
