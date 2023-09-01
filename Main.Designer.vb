<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        text_date = New DateTimePicker()
        btn_deleteunite = New FontAwesome.Sharp.IconButton()
        btn_addunite = New FontAwesome.Sharp.IconButton()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Text_code = New TextBox()
        Label1 = New Label()
        Text_item = New TextBox()
        GroupBox2 = New GroupBox()
        Label6 = New Label()
        Texttotalin = New TextBox()
        Label8 = New Label()
        Text_pricin = New TextBox()
        Label10 = New Label()
        Text_qtyin = New TextBox()
        GroupBox3 = New GroupBox()
        Label4 = New Label()
        Text_totalout = New TextBox()
        Label7 = New Label()
        Text_priceout = New TextBox()
        Label9 = New Label()
        Text_qtyout = New TextBox()
        GroupBox4 = New GroupBox()
        Text_totalpriceout = New TextBox()
        Label14 = New Label()
        Text_profil = New TextBox()
        Label15 = New Label()
        Label16 = New Label()
        Text_totalpricin = New TextBox()
        Label11 = New Label()
        Text_qtyin_qtyout = New TextBox()
        Label12 = New Label()
        Text_totalqtyout = New TextBox()
        Label13 = New Label()
        Text_totalqtyin = New TextBox()
        DataGridView1 = New DataGridView()
        btn_add = New FontAwesome.Sharp.IconButton()
        btn_search = New FontAwesome.Sharp.IconButton()
        btn_edte = New FontAwesome.Sharp.IconButton()
        btn_delete = New FontAwesome.Sharp.IconButton()
        btn_cleare = New FontAwesome.Sharp.IconButton()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox5 = New GroupBox()
        btn_search_date = New FontAwesome.Sharp.IconButton()
        btn_search_code = New FontAwesome.Sharp.IconButton()
        btn_search_itm = New FontAwesome.Sharp.IconButton()
        Label17 = New Label()
        search_date = New TextBox()
        Label18 = New Label()
        search_code = New TextBox()
        Label19 = New Label()
        search_itm = New TextBox()
        ToolTip1 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(text_date)
        GroupBox1.Controls.Add(btn_deleteunite)
        GroupBox1.Controls.Add(btn_addunite)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Text_code)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Text_item)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(363, 222)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Info"
        ' 
        ' text_date
        ' 
        text_date.CalendarMonthBackground = SystemColors.InactiveCaption
        text_date.CalendarTitleBackColor = SystemColors.InactiveCaption
        text_date.Format = DateTimePickerFormat.Custom
        text_date.Location = New Point(87, 150)
        text_date.Name = "text_date"
        text_date.Size = New Size(123, 29)
        text_date.TabIndex = 30
        ' 
        ' btn_deleteunite
        ' 
        btn_deleteunite.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_deleteunite.FlatStyle = FlatStyle.Flat
        btn_deleteunite.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_deleteunite.ForeColor = SystemColors.ButtonHighlight
        btn_deleteunite.IconChar = FontAwesome.Sharp.IconChar.Backspace
        btn_deleteunite.IconColor = SystemColors.Info
        btn_deleteunite.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_deleteunite.IconSize = 25
        btn_deleteunite.Location = New Point(317, 107)
        btn_deleteunite.Name = "btn_deleteunite"
        btn_deleteunite.Size = New Size(27, 29)
        btn_deleteunite.TabIndex = 29
        btn_deleteunite.UseVisualStyleBackColor = False
        ' 
        ' btn_addunite
        ' 
        btn_addunite.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_addunite.FlatStyle = FlatStyle.Flat
        btn_addunite.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_addunite.ForeColor = SystemColors.ButtonHighlight
        btn_addunite.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        btn_addunite.IconColor = SystemColors.Info
        btn_addunite.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_addunite.IconSize = 25
        btn_addunite.Location = New Point(284, 107)
        btn_addunite.Name = "btn_addunite"
        btn_addunite.Size = New Size(27, 29)
        btn_addunite.TabIndex = 28
        btn_addunite.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.InactiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(88, 107)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(193, 29)
        ComboBox1.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(6, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 19)
        Label5.TabIndex = 14
        Label5.Text = "Date :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(6, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 19)
        Label3.TabIndex = 10
        Label3.Text = "Unite :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 19)
        Label2.TabIndex = 8
        Label2.Text = "Code barre :"
        ' 
        ' Text_code
        ' 
        Text_code.BackColor = SystemColors.InactiveCaption
        Text_code.BorderStyle = BorderStyle.FixedSingle
        Text_code.Location = New Point(147, 70)
        Text_code.Name = "Text_code"
        Text_code.Size = New Size(204, 29)
        Text_code.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 19)
        Label1.TabIndex = 6
        Label1.Text = "Item :"
        ' 
        ' Text_item
        ' 
        Text_item.BackColor = SystemColors.InactiveCaption
        Text_item.BorderStyle = BorderStyle.FixedSingle
        Text_item.Location = New Point(88, 33)
        Text_item.Name = "Text_item"
        Text_item.Size = New Size(263, 29)
        Text_item.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Texttotalin)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Text_pricin)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Text_qtyin)
        GroupBox2.Location = New Point(381, 68)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(367, 166)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        GroupBox2.Text = "In"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(6, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 19)
        Label6.TabIndex = 14
        Label6.Text = "Total :"
        ' 
        ' Texttotalin
        ' 
        Texttotalin.BackColor = SystemColors.InactiveCaption
        Texttotalin.BorderStyle = BorderStyle.FixedSingle
        Texttotalin.Enabled = False
        Texttotalin.Location = New Point(98, 107)
        Texttotalin.Name = "Texttotalin"
        Texttotalin.Size = New Size(248, 29)
        Texttotalin.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(6, 80)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 19)
        Label8.TabIndex = 10
        Label8.Text = "Price :"
        ' 
        ' Text_pricin
        ' 
        Text_pricin.BackColor = SystemColors.InactiveCaption
        Text_pricin.BorderStyle = BorderStyle.FixedSingle
        Text_pricin.Location = New Point(98, 70)
        Text_pricin.Name = "Text_pricin"
        Text_pricin.Size = New Size(248, 29)
        Text_pricin.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(6, 37)
        Label10.Name = "Label10"
        Label10.Size = New Size(119, 19)
        Label10.TabIndex = 6
        Label10.Text = "Quantity :"
        ' 
        ' Text_qtyin
        ' 
        Text_qtyin.BackColor = SystemColors.InactiveCaption
        Text_qtyin.BorderStyle = BorderStyle.FixedSingle
        Text_qtyin.Location = New Point(131, 33)
        Text_qtyin.Name = "Text_qtyin"
        Text_qtyin.Size = New Size(215, 29)
        Text_qtyin.TabIndex = 5
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Text_totalout)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Text_priceout)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Text_qtyout)
        GroupBox3.Location = New Point(755, 68)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(367, 166)
        GroupBox3.TabIndex = 17
        GroupBox3.TabStop = False
        GroupBox3.Text = "Out"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(6, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 19)
        Label4.TabIndex = 14
        Label4.Text = "Total :"
        ' 
        ' Text_totalout
        ' 
        Text_totalout.BackColor = SystemColors.InactiveCaption
        Text_totalout.BorderStyle = BorderStyle.FixedSingle
        Text_totalout.Enabled = False
        Text_totalout.Location = New Point(98, 107)
        Text_totalout.Name = "Text_totalout"
        Text_totalout.Size = New Size(248, 29)
        Text_totalout.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(6, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 19)
        Label7.TabIndex = 10
        Label7.Text = "Price :"
        ' 
        ' Text_priceout
        ' 
        Text_priceout.BackColor = SystemColors.InactiveCaption
        Text_priceout.BorderStyle = BorderStyle.FixedSingle
        Text_priceout.Location = New Point(98, 70)
        Text_priceout.Name = "Text_priceout"
        Text_priceout.Size = New Size(248, 29)
        Text_priceout.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(6, 37)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 19)
        Label9.TabIndex = 6
        Label9.Text = "Quantity :"
        ' 
        ' Text_qtyout
        ' 
        Text_qtyout.BackColor = SystemColors.InactiveCaption
        Text_qtyout.BorderStyle = BorderStyle.FixedSingle
        Text_qtyout.Location = New Point(131, 33)
        Text_qtyout.Name = "Text_qtyout"
        Text_qtyout.Size = New Size(215, 29)
        Text_qtyout.TabIndex = 7
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Text_totalpriceout)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Controls.Add(Text_profil)
        GroupBox4.Controls.Add(Label15)
        GroupBox4.Controls.Add(Label16)
        GroupBox4.Controls.Add(Text_totalpricin)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(Text_qtyin_qtyout)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(Text_totalqtyout)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(Text_totalqtyin)
        GroupBox4.Location = New Point(1129, 12)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(278, 261)
        GroupBox4.TabIndex = 18
        GroupBox4.TabStop = False
        GroupBox4.Text = "Summary"
        ' 
        ' Text_totalpriceout
        ' 
        Text_totalpriceout.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        Text_totalpriceout.BorderStyle = BorderStyle.None
        Text_totalpriceout.Location = New Point(191, 192)
        Text_totalpriceout.Name = "Text_totalpriceout"
        Text_totalpriceout.Size = New Size(72, 22)
        Text_totalpriceout.TabIndex = 29
        Text_totalpriceout.Text = "0.00"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.FlatStyle = FlatStyle.Flat
        Label14.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.Wheat
        Label14.Location = New Point(6, 227)
        Label14.Name = "Label14"
        Label14.Size = New Size(185, 19)
        Label14.TabIndex = 28
        Label14.Text = "Profit and loss:"
        ' 
        ' Text_profil
        ' 
        Text_profil.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        Text_profil.BorderStyle = BorderStyle.None
        Text_profil.Location = New Point(193, 222)
        Text_profil.Name = "Text_profil"
        Text_profil.Size = New Size(70, 22)
        Text_profil.TabIndex = 27
        Text_profil.Text = "0.00"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(6, 195)
        Label15.Name = "Label15"
        Label15.Size = New Size(185, 19)
        Label15.TabIndex = 18
        Label15.Text = "Total Price Out:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(6, 152)
        Label16.Name = "Label16"
        Label16.Size = New Size(185, 19)
        Label16.TabIndex = 16
        Label16.Text = "Total price in :"
        ' 
        ' Text_totalpricin
        ' 
        Text_totalpricin.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        Text_totalpricin.BorderStyle = BorderStyle.None
        Text_totalpricin.Location = New Point(191, 148)
        Text_totalpricin.Name = "Text_totalpricin"
        Text_totalpricin.Size = New Size(72, 22)
        Text_totalpricin.TabIndex = 15
        Text_totalpricin.Text = "0.00"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.FlatStyle = FlatStyle.Flat
        Label11.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.Wheat
        Label11.Location = New Point(6, 111)
        Label11.Name = "Label11"
        Label11.Size = New Size(174, 19)
        Label11.TabIndex = 14
        Label11.Text = "Remaining Qty :"
        ' 
        ' Text_qtyin_qtyout
        ' 
        Text_qtyin_qtyout.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        Text_qtyin_qtyout.BorderStyle = BorderStyle.None
        Text_qtyin_qtyout.Location = New Point(191, 109)
        Text_qtyin_qtyout.Name = "Text_qtyin_qtyout"
        Text_qtyin_qtyout.Size = New Size(72, 22)
        Text_qtyin_qtyout.TabIndex = 13
        Text_qtyin_qtyout.Text = "0.00"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(6, 76)
        Label12.Name = "Label12"
        Label12.Size = New Size(163, 19)
        Label12.TabIndex = 10
        Label12.Text = "Total Qty Out:"
        ' 
        ' Text_totalqtyout
        ' 
        Text_totalqtyout.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        Text_totalqtyout.BorderStyle = BorderStyle.None
        Text_totalqtyout.Location = New Point(191, 72)
        Text_totalqtyout.Name = "Text_totalqtyout"
        Text_totalqtyout.Size = New Size(72, 22)
        Text_totalqtyout.TabIndex = 7
        Text_totalqtyout.Text = "0.00"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(6, 37)
        Label13.Name = "Label13"
        Label13.Size = New Size(152, 19)
        Label13.TabIndex = 6
        Label13.Text = "Total Qty in:"
        ' 
        ' Text_totalqtyin
        ' 
        Text_totalqtyin.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        Text_totalqtyin.BorderStyle = BorderStyle.None
        Text_totalqtyin.Location = New Point(191, 33)
        Text_totalqtyin.Name = "Text_totalqtyin"
        Text_totalqtyin.Size = New Size(72, 22)
        Text_totalqtyin.TabIndex = 5
        Text_totalqtyin.Text = "0.00"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.InactiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 277)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1122, 318)
        DataGridView1.TabIndex = 19
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_add.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_add.ForeColor = SystemColors.ButtonHighlight
        btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        btn_add.IconColor = SystemColors.Info
        btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_add.IconSize = 30
        btn_add.ImageAlign = ContentAlignment.MiddleLeft
        btn_add.Location = New Point(12, 239)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(125, 36)
        btn_add.TabIndex = 20
        btn_add.Text = "Add"
        ToolTip1.SetToolTip(btn_add, "fill in the data and click here to add it to the table")
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' btn_search
        ' 
        btn_search.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_search.Enabled = False
        btn_search.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search.ForeColor = SystemColors.ButtonHighlight
        btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        btn_search.IconColor = SystemColors.Info
        btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_search.IconSize = 30
        btn_search.ImageAlign = ContentAlignment.MiddleLeft
        btn_search.Location = New Point(1129, 300)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(278, 36)
        btn_search.TabIndex = 21
        btn_search.Text = "Search "
        btn_search.UseVisualStyleBackColor = False
        ' 
        ' btn_edte
        ' 
        btn_edte.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_edte.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_edte.ForeColor = SystemColors.ButtonHighlight
        btn_edte.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        btn_edte.IconColor = SystemColors.Info
        btn_edte.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_edte.IconSize = 30
        btn_edte.ImageAlign = ContentAlignment.MiddleLeft
        btn_edte.Location = New Point(141, 239)
        btn_edte.Name = "btn_edte"
        btn_edte.Size = New Size(180, 36)
        btn_edte.TabIndex = 23
        btn_edte.Text = "Save"
        ToolTip1.SetToolTip(btn_edte, "modify on table and click here to save")
        btn_edte.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_delete.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_delete.ForeColor = SystemColors.ButtonHighlight
        btn_delete.IconChar = FontAwesome.Sharp.IconChar.Backspace
        btn_delete.IconColor = SystemColors.Info
        btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_delete.IconSize = 35
        btn_delete.ImageAlign = ContentAlignment.MiddleLeft
        btn_delete.Location = New Point(326, 239)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(180, 36)
        btn_delete.TabIndex = 24
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_cleare
        ' 
        btn_cleare.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_cleare.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cleare.ForeColor = SystemColors.ButtonHighlight
        btn_cleare.IconChar = FontAwesome.Sharp.IconChar.Blackberry
        btn_cleare.IconColor = SystemColors.Info
        btn_cleare.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_cleare.IconSize = 35
        btn_cleare.ImageAlign = ContentAlignment.MiddleLeft
        btn_cleare.Location = New Point(512, 239)
        btn_cleare.Name = "btn_cleare"
        btn_cleare.Size = New Size(180, 36)
        btn_cleare.TabIndex = 25
        btn_cleare.Text = "Clean"
        btn_cleare.UseVisualStyleBackColor = False
        ' 
        ' IconButton6
        ' 
        IconButton6.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        IconButton6.Enabled = False
        IconButton6.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        IconButton6.FlatAppearance.BorderSize = 4
        IconButton6.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton6.ForeColor = SystemColors.ButtonHighlight
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        IconButton6.IconColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.IconSize = 30
        IconButton6.ImageAlign = ContentAlignment.MiddleLeft
        IconButton6.Location = New Point(381, 20)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(367, 50)
        IconButton6.TabIndex = 26
        IconButton6.Text = "Add incoming  items"
        IconButton6.UseVisualStyleBackColor = False
        ' 
        ' IconButton7
        ' 
        IconButton7.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        IconButton7.Enabled = False
        IconButton7.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton7.ForeColor = SystemColors.ButtonHighlight
        IconButton7.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        IconButton7.IconColor = Color.Red
        IconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton7.IconSize = 30
        IconButton7.ImageAlign = ContentAlignment.MiddleLeft
        IconButton7.Location = New Point(753, 20)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(370, 50)
        IconButton7.TabIndex = 27
        IconButton7.Text = "Add outgoing items"
        IconButton7.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(btn_search_date)
        GroupBox5.Controls.Add(btn_search_code)
        GroupBox5.Controls.Add(btn_search_itm)
        GroupBox5.Controls.Add(Label17)
        GroupBox5.Controls.Add(search_date)
        GroupBox5.Controls.Add(Label18)
        GroupBox5.Controls.Add(search_code)
        GroupBox5.Controls.Add(Label19)
        GroupBox5.Controls.Add(search_itm)
        GroupBox5.Location = New Point(1129, 342)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(278, 151)
        GroupBox5.TabIndex = 18
        GroupBox5.TabStop = False
        GroupBox5.Text = "Search"
        ' 
        ' btn_search_date
        ' 
        btn_search_date.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_search_date.FlatStyle = FlatStyle.Flat
        btn_search_date.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search_date.ForeColor = SystemColors.ButtonHighlight
        btn_search_date.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        btn_search_date.IconColor = SystemColors.Info
        btn_search_date.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_search_date.IconSize = 25
        btn_search_date.Location = New Point(236, 107)
        btn_search_date.Name = "btn_search_date"
        btn_search_date.Size = New Size(27, 29)
        btn_search_date.TabIndex = 33
        btn_search_date.UseVisualStyleBackColor = False
        ' 
        ' btn_search_code
        ' 
        btn_search_code.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_search_code.FlatStyle = FlatStyle.Flat
        btn_search_code.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search_code.ForeColor = SystemColors.ButtonHighlight
        btn_search_code.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        btn_search_code.IconColor = SystemColors.Info
        btn_search_code.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_search_code.IconSize = 25
        btn_search_code.Location = New Point(236, 71)
        btn_search_code.Name = "btn_search_code"
        btn_search_code.Size = New Size(27, 29)
        btn_search_code.TabIndex = 32
        btn_search_code.UseVisualStyleBackColor = False
        ' 
        ' btn_search_itm
        ' 
        btn_search_itm.BackColor = Color.FromArgb(CByte(55), CByte(96), CByte(105))
        btn_search_itm.FlatStyle = FlatStyle.Flat
        btn_search_itm.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search_itm.ForeColor = SystemColors.ButtonHighlight
        btn_search_itm.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        btn_search_itm.IconColor = SystemColors.Info
        btn_search_itm.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_search_itm.IconSize = 25
        btn_search_itm.Location = New Point(236, 33)
        btn_search_itm.Name = "btn_search_itm"
        btn_search_itm.Size = New Size(27, 29)
        btn_search_itm.TabIndex = 31
        btn_search_itm.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(6, 111)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 19)
        Label17.TabIndex = 14
        Label17.Text = "Date:"
        ' 
        ' search_date
        ' 
        search_date.BackColor = SystemColors.InactiveCaption
        search_date.BorderStyle = BorderStyle.FixedSingle
        search_date.Location = New Point(76, 107)
        search_date.Name = "search_date"
        search_date.Size = New Size(155, 29)
        search_date.TabIndex = 13
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(6, 80)
        Label18.Name = "Label18"
        Label18.Size = New Size(141, 19)
        Label18.TabIndex = 10
        Label18.Text = "Code barre :"
        ' 
        ' search_code
        ' 
        search_code.BackColor = SystemColors.InactiveCaption
        search_code.BorderStyle = BorderStyle.FixedSingle
        search_code.Location = New Point(153, 70)
        search_code.Name = "search_code"
        search_code.Size = New Size(78, 29)
        search_code.TabIndex = 8
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(6, 37)
        Label19.Name = "Label19"
        Label19.Size = New Size(64, 19)
        Label19.TabIndex = 6
        Label19.Text = "Item:"
        ' 
        ' search_itm
        ' 
        search_itm.BackColor = SystemColors.InactiveCaption
        search_itm.BorderStyle = BorderStyle.FixedSingle
        search_itm.Location = New Point(76, 33)
        search_itm.Name = "search_itm"
        search_itm.Size = New Size(155, 29)
        search_itm.TabIndex = 7
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        ClientSize = New Size(1419, 630)
        Controls.Add(GroupBox5)
        Controls.Add(IconButton7)
        Controls.Add(IconButton6)
        Controls.Add(btn_cleare)
        Controls.Add(btn_delete)
        Controls.Add(btn_edte)
        Controls.Add(btn_search)
        Controls.Add(btn_add)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4)
        Name = "Main"
        Text = "Main"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_item As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Texttotalin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Text_pricin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Text_qtyin As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_totalout As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Text_priceout As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_qtyout As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Text_totalpricin As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Text_qtyin_qtyout As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Text_totalqtyout As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Text_totalqtyin As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Text_profil As TextBox
    Friend WithEvents Text_totalpriceout As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_add As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_edte As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_delete As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_cleare As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_addunite As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_deleteunite As FontAwesome.Sharp.IconButton
    Friend WithEvents text_date As DateTimePicker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents search_date As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents search_code As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents search_itm As TextBox
    Friend WithEvents btn_search_date As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_search_code As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_search_itm As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
