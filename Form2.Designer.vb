<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Button7 As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim Button6 As System.Windows.Forms.Button
        Dim Button5 As System.Windows.Forms.Button
        Dim Button3 As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim Button2 As System.Windows.Forms.Button
        Dim Button4 As System.Windows.Forms.Button
        Dim SERIAL_NOLabel As System.Windows.Forms.Label
        Dim NAME_Label As System.Windows.Forms.Label
        Dim QUANTITY_IN_STOCKLabel As System.Windows.Forms.Label
        Dim PRICE_Label As System.Windows.Forms.Label
        Dim DATE_UPDATEDLabel As System.Windows.Forms.Label
        Dim CATEGORYLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SERIAL_NOTextBox = New System.Windows.Forms.TextBox()
        Me.MEDICINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New NANCY_inventory__management_sysytem.Database1DataSet()
        Me.NAME_TextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITY_IN_STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.PRICE_TextBox = New System.Windows.Forms.TextBox()
        Me.DATE_UPDATEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CATEGORYTextBox = New System.Windows.Forms.TextBox()
        Me.MEDICINEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDICINETableAdapter = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.MEDICINETableAdapter()
        Me.TableAdapterManager = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager()
        Me.MEDICINEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MEDICINEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Button7 = New System.Windows.Forms.Button()
        Button6 = New System.Windows.Forms.Button()
        Button5 = New System.Windows.Forms.Button()
        Button3 = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        Button2 = New System.Windows.Forms.Button()
        Button4 = New System.Windows.Forms.Button()
        SERIAL_NOLabel = New System.Windows.Forms.Label()
        NAME_Label = New System.Windows.Forms.Label()
        QUANTITY_IN_STOCKLabel = New System.Windows.Forms.Label()
        PRICE_Label = New System.Windows.Forms.Label()
        DATE_UPDATEDLabel = New System.Windows.Forms.Label()
        CATEGORYLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICINEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICINEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MEDICINEBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button7
        '
        Button7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Button7.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button7.ForeColor = System.Drawing.Color.DarkGreen
        Button7.Location = New System.Drawing.Point(37, 387)
        Button7.Name = "Button7"
        Button7.Size = New System.Drawing.Size(173, 57)
        Button7.TabIndex = 10
        Button7.Text = "LAB EQUIPMENTS"
        Button7.UseVisualStyleBackColor = False
        AddHandler Button7.Click, AddressOf Me.Button7_Click_1
        '
        'Button6
        '
        Button6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Button6.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button6.ForeColor = System.Drawing.Color.DarkGreen
        Button6.Location = New System.Drawing.Point(37, 297)
        Button6.Name = "Button6"
        Button6.Size = New System.Drawing.Size(173, 57)
        Button6.TabIndex = 9
        Button6.Text = "PURCHASES"
        Button6.UseVisualStyleBackColor = False
        AddHandler Button6.Click, AddressOf Me.Button6_Click
        '
        'Button5
        '
        Button5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Button5.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button5.ForeColor = System.Drawing.Color.DarkGreen
        Button5.Location = New System.Drawing.Point(37, 203)
        Button5.Name = "Button5"
        Button5.Size = New System.Drawing.Size(173, 57)
        Button5.TabIndex = 8
        Button5.Text = "SALES"
        Button5.UseVisualStyleBackColor = False
        AddHandler Button5.Click, AddressOf Me.Button5_Click
        '
        'Button3
        '
        Button3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Button3.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button3.ForeColor = System.Drawing.Color.DarkGreen
        Button3.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__162_
        Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button3.Location = New System.Drawing.Point(37, 112)
        Button3.Name = "Button3"
        Button3.Size = New System.Drawing.Size(173, 57)
        Button3.TabIndex = 7
        Button3.Text = "STAFF TOOLS"
        Button3.UseVisualStyleBackColor = False
        AddHandler Button3.Click, AddressOf Me.Button3_Click
        '
        'Button1
        '
        Button1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Button1.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button1.ForeColor = System.Drawing.Color.DarkGreen
        Button1.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__162_
        Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button1.Location = New System.Drawing.Point(37, 33)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(173, 57)
        Button1.TabIndex = 11
        Button1.Text = "MEDICINE"
        Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Button2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Button2.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button2.ForeColor = System.Drawing.Color.DarkGreen
        Button2.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__162_
        Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button2.Location = New System.Drawing.Point(37, 470)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(173, 61)
        Button2.TabIndex = 12
        Button2.Text = "HOSPITAL EQUIPMENTS"
        Button2.UseVisualStyleBackColor = False
        AddHandler Button2.Click, AddressOf Me.Button2_Click
        '
        'Button4
        '
        Button4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Button4.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button4.ForeColor = System.Drawing.Color.White
        Button4.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__146_
        Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button4.Location = New System.Drawing.Point(63, 554)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(110, 42)
        Button4.TabIndex = 13
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'SERIAL_NOLabel
        '
        SERIAL_NOLabel.AutoSize = True
        SERIAL_NOLabel.Location = New System.Drawing.Point(16, 313)
        SERIAL_NOLabel.Name = "SERIAL_NOLabel"
        SERIAL_NOLabel.Size = New System.Drawing.Size(67, 13)
        SERIAL_NOLabel.TabIndex = 1
        SERIAL_NOLabel.Text = "SERIAL NO:"
        '
        'NAME_Label
        '
        NAME_Label.AutoSize = True
        NAME_Label.Location = New System.Drawing.Point(16, 339)
        NAME_Label.Name = "NAME_Label"
        NAME_Label.Size = New System.Drawing.Size(44, 13)
        NAME_Label.TabIndex = 3
        NAME_Label.Text = "NAME :"
        '
        'QUANTITY_IN_STOCKLabel
        '
        QUANTITY_IN_STOCKLabel.AutoSize = True
        QUANTITY_IN_STOCKLabel.Location = New System.Drawing.Point(16, 365)
        QUANTITY_IN_STOCKLabel.Name = "QUANTITY_IN_STOCKLabel"
        QUANTITY_IN_STOCKLabel.Size = New System.Drawing.Size(118, 13)
        QUANTITY_IN_STOCKLabel.TabIndex = 5
        QUANTITY_IN_STOCKLabel.Text = "QUANTITY IN STOCK:"
        '
        'PRICE_Label
        '
        PRICE_Label.AutoSize = True
        PRICE_Label.Location = New System.Drawing.Point(16, 391)
        PRICE_Label.Name = "PRICE_Label"
        PRICE_Label.Size = New System.Drawing.Size(45, 13)
        PRICE_Label.TabIndex = 7
        PRICE_Label.Text = "PRICE :"
        '
        'DATE_UPDATEDLabel
        '
        DATE_UPDATEDLabel.AutoSize = True
        DATE_UPDATEDLabel.Location = New System.Drawing.Point(16, 418)
        DATE_UPDATEDLabel.Name = "DATE_UPDATEDLabel"
        DATE_UPDATEDLabel.Size = New System.Drawing.Size(94, 13)
        DATE_UPDATEDLabel.TabIndex = 9
        DATE_UPDATEDLabel.Text = "DATE UPDATED:"
        '
        'CATEGORYLabel
        '
        CATEGORYLabel.AutoSize = True
        CATEGORYLabel.Location = New System.Drawing.Point(16, 443)
        CATEGORYLabel.Name = "CATEGORYLabel"
        CATEGORYLabel.Size = New System.Drawing.Size(69, 13)
        CATEGORYLabel.TabIndex = 11
        CATEGORYLabel.Text = "CATEGORY:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__162_
        Me.Panel1.Controls.Add(Button4)
        Me.Panel1.Controls.Add(Button2)
        Me.Panel1.Controls.Add(Button1)
        Me.Panel1.Controls.Add(Button7)
        Me.Panel1.Controls.Add(Button6)
        Me.Panel1.Controls.Add(Button5)
        Me.Panel1.Controls.Add(Button3)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 610)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__162_
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(SERIAL_NOLabel)
        Me.Panel2.Controls.Add(Me.SERIAL_NOTextBox)
        Me.Panel2.Controls.Add(NAME_Label)
        Me.Panel2.Controls.Add(Me.NAME_TextBox)
        Me.Panel2.Controls.Add(QUANTITY_IN_STOCKLabel)
        Me.Panel2.Controls.Add(Me.QUANTITY_IN_STOCKTextBox)
        Me.Panel2.Controls.Add(PRICE_Label)
        Me.Panel2.Controls.Add(Me.PRICE_TextBox)
        Me.Panel2.Controls.Add(DATE_UPDATEDLabel)
        Me.Panel2.Controls.Add(Me.DATE_UPDATEDDateTimePicker)
        Me.Panel2.Controls.Add(CATEGORYLabel)
        Me.Panel2.Controls.Add(Me.CATEGORYTextBox)
        Me.Panel2.Controls.Add(Me.MEDICINEDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(228, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(878, 610)
        Me.Panel2.TabIndex = 1
        '
        'SERIAL_NOTextBox
        '
        Me.SERIAL_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "SERIAL NO", True))
        Me.SERIAL_NOTextBox.Location = New System.Drawing.Point(140, 310)
        Me.SERIAL_NOTextBox.Name = "SERIAL_NOTextBox"
        Me.SERIAL_NOTextBox.Size = New System.Drawing.Size(249, 20)
        Me.SERIAL_NOTextBox.TabIndex = 2
        '
        'MEDICINEBindingSource
        '
        Me.MEDICINEBindingSource.DataMember = "MEDICINE"
        Me.MEDICINEBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NAME_TextBox
        '
        Me.NAME_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "NAME ", True))
        Me.NAME_TextBox.Location = New System.Drawing.Point(140, 336)
        Me.NAME_TextBox.Name = "NAME_TextBox"
        Me.NAME_TextBox.Size = New System.Drawing.Size(249, 20)
        Me.NAME_TextBox.TabIndex = 4
        '
        'QUANTITY_IN_STOCKTextBox
        '
        Me.QUANTITY_IN_STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "QUANTITY IN STOCK", True))
        Me.QUANTITY_IN_STOCKTextBox.Location = New System.Drawing.Point(140, 362)
        Me.QUANTITY_IN_STOCKTextBox.Name = "QUANTITY_IN_STOCKTextBox"
        Me.QUANTITY_IN_STOCKTextBox.Size = New System.Drawing.Size(249, 20)
        Me.QUANTITY_IN_STOCKTextBox.TabIndex = 6
        '
        'PRICE_TextBox
        '
        Me.PRICE_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "PRICE ", True))
        Me.PRICE_TextBox.Location = New System.Drawing.Point(140, 388)
        Me.PRICE_TextBox.Name = "PRICE_TextBox"
        Me.PRICE_TextBox.Size = New System.Drawing.Size(249, 20)
        Me.PRICE_TextBox.TabIndex = 8
        '
        'DATE_UPDATEDDateTimePicker
        '
        Me.DATE_UPDATEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICINEBindingSource, "DATE UPDATED", True))
        Me.DATE_UPDATEDDateTimePicker.Location = New System.Drawing.Point(140, 414)
        Me.DATE_UPDATEDDateTimePicker.Name = "DATE_UPDATEDDateTimePicker"
        Me.DATE_UPDATEDDateTimePicker.Size = New System.Drawing.Size(249, 20)
        Me.DATE_UPDATEDDateTimePicker.TabIndex = 10
        '
        'CATEGORYTextBox
        '
        Me.CATEGORYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "CATEGORY", True))
        Me.CATEGORYTextBox.Location = New System.Drawing.Point(140, 440)
        Me.CATEGORYTextBox.Name = "CATEGORYTextBox"
        Me.CATEGORYTextBox.Size = New System.Drawing.Size(249, 20)
        Me.CATEGORYTextBox.TabIndex = 12
        '
        'MEDICINEDataGridView
        '
        Me.MEDICINEDataGridView.AutoGenerateColumns = False
        Me.MEDICINEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MEDICINEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MEDICINEDataGridView.DataSource = Me.MEDICINEBindingSource
        Me.MEDICINEDataGridView.Location = New System.Drawing.Point(3, 26)
        Me.MEDICINEDataGridView.Name = "MEDICINEDataGridView"
        Me.MEDICINEDataGridView.Size = New System.Drawing.Size(645, 253)
        Me.MEDICINEDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SERIAL NO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SERIAL NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAME "
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAME "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QUANTITY IN STOCK"
        Me.DataGridViewTextBoxColumn3.HeaderText = "QUANTITY IN STOCK"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PRICE "
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRICE "
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DATE UPDATED"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DATE UPDATED"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CATEGORY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'MEDICINETableAdapter
        '
        Me.MEDICINETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HOSPITAL_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.LAB_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Me.MEDICINETableAdapter
        Me.TableAdapterManager.PURCHASESTableAdapter = Nothing
        Me.TableAdapterManager.SALESTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_TOOLSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICINEBindingNavigator
        '
        Me.MEDICINEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MEDICINEBindingNavigator.BindingSource = Me.MEDICINEBindingSource
        Me.MEDICINEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MEDICINEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MEDICINEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MEDICINEBindingNavigatorSaveItem})
        Me.MEDICINEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MEDICINEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MEDICINEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MEDICINEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MEDICINEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MEDICINEBindingNavigator.Name = "MEDICINEBindingNavigator"
        Me.MEDICINEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MEDICINEBindingNavigator.Size = New System.Drawing.Size(1108, 25)
        Me.MEDICINEBindingNavigator.TabIndex = 2
        Me.MEDICINEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MEDICINEBindingNavigatorSaveItem
        '
        Me.MEDICINEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MEDICINEBindingNavigatorSaveItem.Image = CType(resources.GetObject("MEDICINEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MEDICINEBindingNavigatorSaveItem.Name = "MEDICINEBindingNavigatorSaveItem"
        Me.MEDICINEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MEDICINEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 612)
        Me.Controls.Add(Me.MEDICINEBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEDICINE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICINEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICINEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MEDICINEBindingNavigator.ResumeLayout(False)
        Me.MEDICINEBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Database1DataSet As NANCY_inventory__management_sysytem.Database1DataSet
    Friend WithEvents MEDICINEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICINETableAdapter As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.MEDICINETableAdapter
    Friend WithEvents TableAdapterManager As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MEDICINEBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MEDICINEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SERIAL_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAME_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITY_IN_STOCKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRICE_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_UPDATEDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CATEGORYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MEDICINEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
