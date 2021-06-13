<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhoneNum
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Service_providerLabel As System.Windows.Forms.Label
        Dim _9_digit_numberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhoneNum))
        Me.btnDel = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSave = New FontAwesome.Sharp.IconPictureBox()
        Me.btnNext = New FontAwesome.Sharp.IconPictureBox()
        Me.btnPrev = New FontAwesome.Sharp.IconPictureBox()
        Me.btnAdd = New FontAwesome.Sharp.IconPictureBox()
        Me.PhoneNumbersDataSet = New Uplock.PhoneNumbersDataSet()
        Me.NumbersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumbersTableAdapter = New Uplock.PhoneNumbersDataSetTableAdapters.numbersTableAdapter()
        Me.TableAdapterManager = New Uplock.PhoneNumbersDataSetTableAdapters.TableAdapterManager()
        Me.NumbersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Service_providerTextBox = New System.Windows.Forms.TextBox()
        Me._9_digit_numberTextBox = New System.Windows.Forms.TextBox()
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
        IDLabel = New System.Windows.Forms.Label()
        Service_providerLabel = New System.Windows.Forms.Label()
        _9_digit_numberLabel = New System.Windows.Forms.Label()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumbersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumbersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumbersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        IDLabel.Location = New System.Drawing.Point(102, 95)
        IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(32, 19)
        IDLabel.TabIndex = 29
        IDLabel.Text = "ID:"
        '
        'Service_providerLabel
        '
        Service_providerLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Service_providerLabel.AutoSize = True
        Service_providerLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Service_providerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Service_providerLabel.Location = New System.Drawing.Point(102, 120)
        Service_providerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Service_providerLabel.Name = "Service_providerLabel"
        Service_providerLabel.Size = New System.Drawing.Size(129, 19)
        Service_providerLabel.TabIndex = 31
        Service_providerLabel.Text = "Service provider:"
        '
        '_9_digit_numberLabel
        '
        _9_digit_numberLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        _9_digit_numberLabel.AutoSize = True
        _9_digit_numberLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _9_digit_numberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        _9_digit_numberLabel.Location = New System.Drawing.Point(102, 145)
        _9_digit_numberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        _9_digit_numberLabel.Name = "_9_digit_numberLabel"
        _9_digit_numberLabel.Size = New System.Drawing.Size(121, 19)
        _9_digit_numberLabel.TabIndex = 33
        _9_digit_numberLabel.Text = "9-digit number:"
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
        Me.btnDel.Location = New System.Drawing.Point(379, 392)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btnSave.Location = New System.Drawing.Point(339, 392)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btnNext.Location = New System.Drawing.Point(299, 392)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btnPrev.Location = New System.Drawing.Point(260, 392)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btnAdd.Location = New System.Drawing.Point(220, 392)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(1, 4, 1, 1)
        Me.btnAdd.Size = New System.Drawing.Size(34, 37)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.TabStop = False
        '
        'PhoneNumbersDataSet
        '
        Me.PhoneNumbersDataSet.DataSetName = "PhoneNumbersDataSet"
        Me.PhoneNumbersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumbersBindingSource
        '
        Me.NumbersBindingSource.DataMember = "numbers"
        Me.NumbersBindingSource.DataSource = Me.PhoneNumbersDataSet
        '
        'NumbersTableAdapter
        '
        Me.NumbersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.numbersTableAdapter = Me.NumbersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Uplock.PhoneNumbersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NumbersDataGridView
        '
        Me.NumbersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumbersDataGridView.AutoGenerateColumns = False
        Me.NumbersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NumbersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.NumbersDataGridView.DataSource = Me.NumbersBindingSource
        Me.NumbersDataGridView.Location = New System.Drawing.Point(164, 206)
        Me.NumbersDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumbersDataGridView.Name = "NumbersDataGridView"
        Me.NumbersDataGridView.RowHeadersWidth = 51
        Me.NumbersDataGridView.RowTemplate.Height = 24
        Me.NumbersDataGridView.Size = New System.Drawing.Size(318, 179)
        Me.NumbersDataGridView.TabIndex = 29
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "service provider"
        Me.DataGridViewTextBoxColumn2.HeaderText = "service provider"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "9 digit number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "9 digit number"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumbersBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(299, 94)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(267, 21)
        Me.IDTextBox.TabIndex = 30
        '
        'Service_providerTextBox
        '
        Me.Service_providerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Service_providerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumbersBindingSource, "service provider", True))
        Me.Service_providerTextBox.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Service_providerTextBox.Location = New System.Drawing.Point(299, 119)
        Me.Service_providerTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Service_providerTextBox.Multiline = True
        Me.Service_providerTextBox.Name = "Service_providerTextBox"
        Me.Service_providerTextBox.Size = New System.Drawing.Size(267, 21)
        Me.Service_providerTextBox.TabIndex = 32
        '
        '_9_digit_numberTextBox
        '
        Me._9_digit_numberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me._9_digit_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumbersBindingSource, "9 digit number", True))
        Me._9_digit_numberTextBox.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._9_digit_numberTextBox.Location = New System.Drawing.Point(299, 145)
        Me._9_digit_numberTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me._9_digit_numberTextBox.Multiline = True
        Me._9_digit_numberTextBox.Name = "_9_digit_numberTextBox"
        Me._9_digit_numberTextBox.Size = New System.Drawing.Size(267, 21)
        Me._9_digit_numberTextBox.TabIndex = 34
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
        Me.GroupBox1.Location = New System.Drawing.Point(-8, -27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(682, 475)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(256, 165)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button12.Location = New System.Drawing.Point(349, 336)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button11.Location = New System.Drawing.Point(268, 336)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button11.Name = "Button11"
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
        Me.Button10.Location = New System.Drawing.Point(315, 336)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button9.Location = New System.Drawing.Point(359, 290)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button8.Location = New System.Drawing.Point(308, 290)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button7.Location = New System.Drawing.Point(256, 290)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button6.Location = New System.Drawing.Point(359, 244)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button5.Location = New System.Drawing.Point(308, 244)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button4.Location = New System.Drawing.Point(256, 244)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button3.Location = New System.Drawing.Point(359, 198)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button2.Location = New System.Drawing.Point(308, 197)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Button1.Location = New System.Drawing.Point(256, 197)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 406)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'PhoneNum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Service_providerLabel)
        Me.Controls.Add(Me.Service_providerTextBox)
        Me.Controls.Add(_9_digit_numberLabel)
        Me.Controls.Add(Me._9_digit_numberTextBox)
        Me.Controls.Add(Me.NumbersDataGridView)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnAdd)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PhoneNum"
        Me.Text = "PhoneNum"
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumbersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumbersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumbersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PhoneNumbersDataSet As PhoneNumbersDataSet
    Friend WithEvents NumbersBindingSource As BindingSource
    Friend WithEvents NumbersTableAdapter As PhoneNumbersDataSetTableAdapters.numbersTableAdapter
    Friend WithEvents TableAdapterManager As PhoneNumbersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumbersBindingNavigator As BindingNavigator
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
    Friend WithEvents NumbersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NumbersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Service_providerTextBox As TextBox
    Friend WithEvents _9_digit_numberTextBox As TextBox
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
