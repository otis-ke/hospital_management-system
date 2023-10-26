<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim SERIALLabel As System.Windows.Forms.Label
        Dim NAME_Label As System.Windows.Forms.Label
        Dim CATEGORYLabel As System.Windows.Forms.Label
        Dim AMOUNT_IN_STOCKLabel As System.Windows.Forms.Label
        Dim DATE_UPDATEDLabel As System.Windows.Forms.Label
        Dim PRICELabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim Button4 As System.Windows.Forms.Button
        Me.Database1DataSet = New NANCY_inventory__management_sysytem.Database1DataSet()
        Me.HOSPITAL_EQUIPMENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HOSPITAL_EQUIPMENTSTableAdapter = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.HOSPITAL_EQUIPMENTSTableAdapter()
        Me.TableAdapterManager = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager()
        Me.HOSPITAL_EQUIPMENTSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.HOSPITAL_EQUIPMENTSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIALTextBox = New System.Windows.Forms.TextBox()
        Me.NAME_TextBox = New System.Windows.Forms.TextBox()
        Me.CATEGORYTextBox = New System.Windows.Forms.TextBox()
        Me.AMOUNT_IN_STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_UPDATEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PRICETextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        SERIALLabel = New System.Windows.Forms.Label()
        NAME_Label = New System.Windows.Forms.Label()
        CATEGORYLabel = New System.Windows.Forms.Label()
        AMOUNT_IN_STOCKLabel = New System.Windows.Forms.Label()
        DATE_UPDATEDLabel = New System.Windows.Forms.Label()
        PRICELabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        Button4 = New System.Windows.Forms.Button()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOSPITAL_EQUIPMENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOSPITAL_EQUIPMENTSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.SuspendLayout()
        CType(Me.HOSPITAL_EQUIPMENTSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SERIALLabel
        '
        SERIALLabel.AutoSize = True
        SERIALLabel.Location = New System.Drawing.Point(28, 379)
        SERIALLabel.Name = "SERIALLabel"
        SERIALLabel.Size = New System.Drawing.Size(48, 13)
        SERIALLabel.TabIndex = 2
        SERIALLabel.Text = "SERIAL:"
        '
        'NAME_Label
        '
        NAME_Label.AutoSize = True
        NAME_Label.Location = New System.Drawing.Point(28, 405)
        NAME_Label.Name = "NAME_Label"
        NAME_Label.Size = New System.Drawing.Size(44, 13)
        NAME_Label.TabIndex = 4
        NAME_Label.Text = "NAME :"
        '
        'CATEGORYLabel
        '
        CATEGORYLabel.AutoSize = True
        CATEGORYLabel.Location = New System.Drawing.Point(28, 431)
        CATEGORYLabel.Name = "CATEGORYLabel"
        CATEGORYLabel.Size = New System.Drawing.Size(69, 13)
        CATEGORYLabel.TabIndex = 6
        CATEGORYLabel.Text = "CATEGORY:"
        '
        'AMOUNT_IN_STOCKLabel
        '
        AMOUNT_IN_STOCKLabel.AutoSize = True
        AMOUNT_IN_STOCKLabel.Location = New System.Drawing.Point(28, 457)
        AMOUNT_IN_STOCKLabel.Name = "AMOUNT_IN_STOCKLabel"
        AMOUNT_IN_STOCKLabel.Size = New System.Drawing.Size(110, 13)
        AMOUNT_IN_STOCKLabel.TabIndex = 8
        AMOUNT_IN_STOCKLabel.Text = "AMOUNT IN STOCK:"
        '
        'DATE_UPDATEDLabel
        '
        DATE_UPDATEDLabel.AutoSize = True
        DATE_UPDATEDLabel.Location = New System.Drawing.Point(28, 484)
        DATE_UPDATEDLabel.Name = "DATE_UPDATEDLabel"
        DATE_UPDATEDLabel.Size = New System.Drawing.Size(94, 13)
        DATE_UPDATEDLabel.TabIndex = 10
        DATE_UPDATEDLabel.Text = "DATE UPDATED:"
        '
        'PRICELabel
        '
        PRICELabel.AutoSize = True
        PRICELabel.Location = New System.Drawing.Point(28, 509)
        PRICELabel.Name = "PRICELabel"
        PRICELabel.Size = New System.Drawing.Size(42, 13)
        PRICELabel.TabIndex = 12
        PRICELabel.Text = "PRICE:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(28, 535)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 14
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HOSPITAL_EQUIPMENTSBindingSource
        '
        Me.HOSPITAL_EQUIPMENTSBindingSource.DataMember = "HOSPITAL EQUIPMENTS"
        Me.HOSPITAL_EQUIPMENTSBindingSource.DataSource = Me.Database1DataSet
        '
        'HOSPITAL_EQUIPMENTSTableAdapter
        '
        Me.HOSPITAL_EQUIPMENTSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HOSPITAL_EQUIPMENTSTableAdapter = Me.HOSPITAL_EQUIPMENTSTableAdapter
        Me.TableAdapterManager.LAB_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PURCHASESTableAdapter = Nothing
        Me.TableAdapterManager.SALESTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_TOOLSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HOSPITAL_EQUIPMENTSBindingNavigator
        '
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.BindingSource = Me.HOSPITAL_EQUIPMENTSBindingSource
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem})
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.Name = "HOSPITAL_EQUIPMENTSBindingNavigator"
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.Size = New System.Drawing.Size(1118, 25)
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.TabIndex = 0
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.Text = "BindingNavigator1"
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
        'HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem
        '
        Me.HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem.Image = CType(resources.GetObject("HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem.Name = "HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem"
        Me.HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'HOSPITAL_EQUIPMENTSDataGridView
        '
        Me.HOSPITAL_EQUIPMENTSDataGridView.AutoGenerateColumns = False
        Me.HOSPITAL_EQUIPMENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HOSPITAL_EQUIPMENTSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.HOSPITAL_EQUIPMENTSDataGridView.DataSource = Me.HOSPITAL_EQUIPMENTSBindingSource
        Me.HOSPITAL_EQUIPMENTSDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.HOSPITAL_EQUIPMENTSDataGridView.Name = "HOSPITAL_EQUIPMENTSDataGridView"
        Me.HOSPITAL_EQUIPMENTSDataGridView.Size = New System.Drawing.Size(745, 320)
        Me.HOSPITAL_EQUIPMENTSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SERIAL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SERIAL"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CATEGORY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AMOUNT IN STOCK"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AMOUNT IN STOCK"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn7.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'SERIALTextBox
        '
        Me.SERIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOSPITAL_EQUIPMENTSBindingSource, "SERIAL", True))
        Me.SERIALTextBox.Location = New System.Drawing.Point(144, 376)
        Me.SERIALTextBox.Name = "SERIALTextBox"
        Me.SERIALTextBox.Size = New System.Drawing.Size(237, 20)
        Me.SERIALTextBox.TabIndex = 3
        '
        'NAME_TextBox
        '
        Me.NAME_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOSPITAL_EQUIPMENTSBindingSource, "NAME ", True))
        Me.NAME_TextBox.Location = New System.Drawing.Point(144, 402)
        Me.NAME_TextBox.Name = "NAME_TextBox"
        Me.NAME_TextBox.Size = New System.Drawing.Size(237, 20)
        Me.NAME_TextBox.TabIndex = 5
        '
        'CATEGORYTextBox
        '
        Me.CATEGORYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOSPITAL_EQUIPMENTSBindingSource, "CATEGORY", True))
        Me.CATEGORYTextBox.Location = New System.Drawing.Point(144, 428)
        Me.CATEGORYTextBox.Name = "CATEGORYTextBox"
        Me.CATEGORYTextBox.Size = New System.Drawing.Size(237, 20)
        Me.CATEGORYTextBox.TabIndex = 7
        '
        'AMOUNT_IN_STOCKTextBox
        '
        Me.AMOUNT_IN_STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOSPITAL_EQUIPMENTSBindingSource, "AMOUNT IN STOCK", True))
        Me.AMOUNT_IN_STOCKTextBox.Location = New System.Drawing.Point(144, 454)
        Me.AMOUNT_IN_STOCKTextBox.Name = "AMOUNT_IN_STOCKTextBox"
        Me.AMOUNT_IN_STOCKTextBox.Size = New System.Drawing.Size(237, 20)
        Me.AMOUNT_IN_STOCKTextBox.TabIndex = 9
        '
        'DATE_UPDATEDDateTimePicker
        '
        Me.DATE_UPDATEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HOSPITAL_EQUIPMENTSBindingSource, "DATE UPDATED", True))
        Me.DATE_UPDATEDDateTimePicker.Location = New System.Drawing.Point(144, 480)
        Me.DATE_UPDATEDDateTimePicker.Name = "DATE_UPDATEDDateTimePicker"
        Me.DATE_UPDATEDDateTimePicker.Size = New System.Drawing.Size(237, 20)
        Me.DATE_UPDATEDDateTimePicker.TabIndex = 11
        '
        'PRICETextBox
        '
        Me.PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOSPITAL_EQUIPMENTSBindingSource, "PRICE", True))
        Me.PRICETextBox.Location = New System.Drawing.Point(144, 506)
        Me.PRICETextBox.Name = "PRICETextBox"
        Me.PRICETextBox.Size = New System.Drawing.Size(237, 20)
        Me.PRICETextBox.TabIndex = 13
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOSPITAL_EQUIPMENTSBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(144, 532)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(237, 20)
        Me.QUANTITYTextBox.TabIndex = 15
        '
        'Button4
        '
        Button4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Button4.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button4.ForeColor = System.Drawing.Color.White
        Button4.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__146_
        Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button4.Location = New System.Drawing.Point(475, 509)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(110, 42)
        Button4.TabIndex = 16
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__163_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1118, 620)
        Me.Controls.Add(Button4)
        Me.Controls.Add(SERIALLabel)
        Me.Controls.Add(Me.SERIALTextBox)
        Me.Controls.Add(NAME_Label)
        Me.Controls.Add(Me.NAME_TextBox)
        Me.Controls.Add(CATEGORYLabel)
        Me.Controls.Add(Me.CATEGORYTextBox)
        Me.Controls.Add(AMOUNT_IN_STOCKLabel)
        Me.Controls.Add(Me.AMOUNT_IN_STOCKTextBox)
        Me.Controls.Add(DATE_UPDATEDLabel)
        Me.Controls.Add(Me.DATE_UPDATEDDateTimePicker)
        Me.Controls.Add(PRICELabel)
        Me.Controls.Add(Me.PRICETextBox)
        Me.Controls.Add(QUANTITYLabel)
        Me.Controls.Add(Me.QUANTITYTextBox)
        Me.Controls.Add(Me.HOSPITAL_EQUIPMENTSDataGridView)
        Me.Controls.Add(Me.HOSPITAL_EQUIPMENTSBindingNavigator)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOSPITAL EQUIPMENTS"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOSPITAL_EQUIPMENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOSPITAL_EQUIPMENTSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.ResumeLayout(False)
        Me.HOSPITAL_EQUIPMENTSBindingNavigator.PerformLayout()
        CType(Me.HOSPITAL_EQUIPMENTSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As NANCY_inventory__management_sysytem.Database1DataSet
    Friend WithEvents HOSPITAL_EQUIPMENTSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HOSPITAL_EQUIPMENTSTableAdapter As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.HOSPITAL_EQUIPMENTSTableAdapter
    Friend WithEvents TableAdapterManager As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents HOSPITAL_EQUIPMENTSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HOSPITAL_EQUIPMENTSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAME_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CATEGORYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_IN_STOCKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_UPDATEDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITYTextBox As System.Windows.Forms.TextBox
End Class
