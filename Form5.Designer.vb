<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim DAY_OF_SALELabel As System.Windows.Forms.Label
        Dim AMOUNT_OF_SALE_MADELabel As System.Windows.Forms.Label
        Dim SALES_BALANCELabel As System.Windows.Forms.Label
        Dim SOLD_TO_Label As System.Windows.Forms.Label
        Dim NAME_Label As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim ITEM_NAME_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim Button4 As System.Windows.Forms.Button
        Me.Database1DataSet = New NANCY_inventory__management_sysytem.Database1DataSet()
        Me.SALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALESTableAdapter = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.SALESTableAdapter()
        Me.TableAdapterManager = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager()
        Me.SALESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SALESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SALESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIALTextBox = New System.Windows.Forms.TextBox()
        Me.DAY_OF_SALEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AMOUNT_OF_SALE_MADETextBox = New System.Windows.Forms.TextBox()
        Me.SALES_BALANCETextBox = New System.Windows.Forms.TextBox()
        Me.SOLD_TO_TextBox = New System.Windows.Forms.TextBox()
        Me.NAME_TextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        Me.ITEM_NAME_TextBox = New System.Windows.Forms.TextBox()
        SERIALLabel = New System.Windows.Forms.Label()
        DAY_OF_SALELabel = New System.Windows.Forms.Label()
        AMOUNT_OF_SALE_MADELabel = New System.Windows.Forms.Label()
        SALES_BALANCELabel = New System.Windows.Forms.Label()
        SOLD_TO_Label = New System.Windows.Forms.Label()
        NAME_Label = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        ITEM_NAME_Label = New System.Windows.Forms.Label()
        Button4 = New System.Windows.Forms.Button()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SALESBindingNavigator.SuspendLayout()
        CType(Me.SALESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SERIALLabel
        '
        SERIALLabel.AutoSize = True
        SERIALLabel.Location = New System.Drawing.Point(33, 337)
        SERIALLabel.Name = "SERIALLabel"
        SERIALLabel.Size = New System.Drawing.Size(48, 13)
        SERIALLabel.TabIndex = 2
        SERIALLabel.Text = "SERIAL:"
        '
        'DAY_OF_SALELabel
        '
        DAY_OF_SALELabel.AutoSize = True
        DAY_OF_SALELabel.Location = New System.Drawing.Point(33, 364)
        DAY_OF_SALELabel.Name = "DAY_OF_SALELabel"
        DAY_OF_SALELabel.Size = New System.Drawing.Size(79, 13)
        DAY_OF_SALELabel.TabIndex = 4
        DAY_OF_SALELabel.Text = "DAY OF SALE:"
        '
        'AMOUNT_OF_SALE_MADELabel
        '
        AMOUNT_OF_SALE_MADELabel.AutoSize = True
        AMOUNT_OF_SALE_MADELabel.Location = New System.Drawing.Point(33, 389)
        AMOUNT_OF_SALE_MADELabel.Name = "AMOUNT_OF_SALE_MADELabel"
        AMOUNT_OF_SALE_MADELabel.Size = New System.Drawing.Size(138, 13)
        AMOUNT_OF_SALE_MADELabel.TabIndex = 6
        AMOUNT_OF_SALE_MADELabel.Text = "AMOUNT OF SALE MADE:"
        '
        'SALES_BALANCELabel
        '
        SALES_BALANCELabel.AutoSize = True
        SALES_BALANCELabel.Location = New System.Drawing.Point(33, 415)
        SALES_BALANCELabel.Name = "SALES_BALANCELabel"
        SALES_BALANCELabel.Size = New System.Drawing.Size(96, 13)
        SALES_BALANCELabel.TabIndex = 8
        SALES_BALANCELabel.Text = "SALES BALANCE:"
        '
        'SOLD_TO_Label
        '
        SOLD_TO_Label.AutoSize = True
        SOLD_TO_Label.Location = New System.Drawing.Point(33, 441)
        SOLD_TO_Label.Name = "SOLD_TO_Label"
        SOLD_TO_Label.Size = New System.Drawing.Size(60, 13)
        SOLD_TO_Label.TabIndex = 10
        SOLD_TO_Label.Text = "SOLD TO :"
        '
        'NAME_Label
        '
        NAME_Label.AutoSize = True
        NAME_Label.Location = New System.Drawing.Point(33, 467)
        NAME_Label.Name = "NAME_Label"
        NAME_Label.Size = New System.Drawing.Size(44, 13)
        NAME_Label.TabIndex = 12
        NAME_Label.Text = "NAME :"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(33, 493)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(48, 13)
        PHONELabel.TabIndex = 14
        PHONELabel.Text = "PHONE:"
        '
        'ITEM_NAME_Label
        '
        ITEM_NAME_Label.AutoSize = True
        ITEM_NAME_Label.Location = New System.Drawing.Point(33, 519)
        ITEM_NAME_Label.Name = "ITEM_NAME_Label"
        ITEM_NAME_Label.Size = New System.Drawing.Size(73, 13)
        ITEM_NAME_Label.TabIndex = 16
        ITEM_NAME_Label.Text = "ITEM NAME :"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SALESBindingSource
        '
        Me.SALESBindingSource.DataMember = "SALES"
        Me.SALESBindingSource.DataSource = Me.Database1DataSet
        '
        'SALESTableAdapter
        '
        Me.SALESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HOSPITAL_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.LAB_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PURCHASESTableAdapter = Nothing
        Me.TableAdapterManager.SALESTableAdapter = Me.SALESTableAdapter
        Me.TableAdapterManager.STAFF_TOOLSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SALESBindingNavigator
        '
        Me.SALESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SALESBindingNavigator.BindingSource = Me.SALESBindingSource
        Me.SALESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SALESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SALESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SALESBindingNavigatorSaveItem})
        Me.SALESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SALESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SALESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SALESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SALESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SALESBindingNavigator.Name = "SALESBindingNavigator"
        Me.SALESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SALESBindingNavigator.Size = New System.Drawing.Size(1118, 25)
        Me.SALESBindingNavigator.TabIndex = 0
        Me.SALESBindingNavigator.Text = "BindingNavigator1"
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
        'SALESBindingNavigatorSaveItem
        '
        Me.SALESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SALESBindingNavigatorSaveItem.Image = CType(resources.GetObject("SALESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SALESBindingNavigatorSaveItem.Name = "SALESBindingNavigatorSaveItem"
        Me.SALESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SALESBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SALESDataGridView
        '
        Me.SALESDataGridView.AutoGenerateColumns = False
        Me.SALESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SALESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.SALESDataGridView.DataSource = Me.SALESBindingSource
        Me.SALESDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.SALESDataGridView.Name = "SALESDataGridView"
        Me.SALESDataGridView.Size = New System.Drawing.Size(842, 270)
        Me.SALESDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SERIAL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SERIAL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DAY OF SALE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DAY OF SALE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AMOUNT OF SALE MADE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AMOUNT OF SALE MADE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SALES BALANCE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SALES BALANCE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SOLD TO "
        Me.DataGridViewTextBoxColumn5.HeaderText = "SOLD TO "
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NAME "
        Me.DataGridViewTextBoxColumn6.HeaderText = "NAME "
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PHONE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PHONE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ITEM NAME "
        Me.DataGridViewTextBoxColumn8.HeaderText = "ITEM NAME "
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'SERIALTextBox
        '
        Me.SERIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESBindingSource, "SERIAL", True))
        Me.SERIALTextBox.Location = New System.Drawing.Point(177, 334)
        Me.SERIALTextBox.Name = "SERIALTextBox"
        Me.SERIALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SERIALTextBox.TabIndex = 3
        '
        'DAY_OF_SALEDateTimePicker
        '
        Me.DAY_OF_SALEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SALESBindingSource, "DAY OF SALE", True))
        Me.DAY_OF_SALEDateTimePicker.Location = New System.Drawing.Point(177, 360)
        Me.DAY_OF_SALEDateTimePicker.Name = "DAY_OF_SALEDateTimePicker"
        Me.DAY_OF_SALEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DAY_OF_SALEDateTimePicker.TabIndex = 5
        '
        'AMOUNT_OF_SALE_MADETextBox
        '
        Me.AMOUNT_OF_SALE_MADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESBindingSource, "AMOUNT OF SALE MADE", True))
        Me.AMOUNT_OF_SALE_MADETextBox.Location = New System.Drawing.Point(177, 386)
        Me.AMOUNT_OF_SALE_MADETextBox.Name = "AMOUNT_OF_SALE_MADETextBox"
        Me.AMOUNT_OF_SALE_MADETextBox.Size = New System.Drawing.Size(200, 20)
        Me.AMOUNT_OF_SALE_MADETextBox.TabIndex = 7
        '
        'SALES_BALANCETextBox
        '
        Me.SALES_BALANCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESBindingSource, "SALES BALANCE", True))
        Me.SALES_BALANCETextBox.Location = New System.Drawing.Point(177, 412)
        Me.SALES_BALANCETextBox.Name = "SALES_BALANCETextBox"
        Me.SALES_BALANCETextBox.Size = New System.Drawing.Size(200, 20)
        Me.SALES_BALANCETextBox.TabIndex = 9
        '
        'SOLD_TO_TextBox
        '
        Me.SOLD_TO_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESBindingSource, "SOLD TO ", True))
        Me.SOLD_TO_TextBox.Location = New System.Drawing.Point(177, 438)
        Me.SOLD_TO_TextBox.Name = "SOLD_TO_TextBox"
        Me.SOLD_TO_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.SOLD_TO_TextBox.TabIndex = 11
        '
        'NAME_TextBox
        '
        Me.NAME_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESBindingSource, "NAME ", True))
        Me.NAME_TextBox.Location = New System.Drawing.Point(177, 464)
        Me.NAME_TextBox.Name = "NAME_TextBox"
        Me.NAME_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NAME_TextBox.TabIndex = 13
        '
        'PHONETextBox
        '
        Me.PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESBindingSource, "PHONE", True))
        Me.PHONETextBox.Location = New System.Drawing.Point(177, 490)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(200, 20)
        Me.PHONETextBox.TabIndex = 15
        '
        'ITEM_NAME_TextBox
        '
        Me.ITEM_NAME_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESBindingSource, "ITEM NAME ", True))
        Me.ITEM_NAME_TextBox.Location = New System.Drawing.Point(177, 516)
        Me.ITEM_NAME_TextBox.Name = "ITEM_NAME_TextBox"
        Me.ITEM_NAME_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITEM_NAME_TextBox.TabIndex = 17
        '
        'Button4
        '
        Button4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Button4.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button4.ForeColor = System.Drawing.Color.White
        Button4.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__146_
        Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button4.Location = New System.Drawing.Point(177, 555)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(110, 42)
        Button4.TabIndex = 18
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__165_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1118, 620)
        Me.Controls.Add(Button4)
        Me.Controls.Add(SERIALLabel)
        Me.Controls.Add(Me.SERIALTextBox)
        Me.Controls.Add(DAY_OF_SALELabel)
        Me.Controls.Add(Me.DAY_OF_SALEDateTimePicker)
        Me.Controls.Add(AMOUNT_OF_SALE_MADELabel)
        Me.Controls.Add(Me.AMOUNT_OF_SALE_MADETextBox)
        Me.Controls.Add(SALES_BALANCELabel)
        Me.Controls.Add(Me.SALES_BALANCETextBox)
        Me.Controls.Add(SOLD_TO_Label)
        Me.Controls.Add(Me.SOLD_TO_TextBox)
        Me.Controls.Add(NAME_Label)
        Me.Controls.Add(Me.NAME_TextBox)
        Me.Controls.Add(PHONELabel)
        Me.Controls.Add(Me.PHONETextBox)
        Me.Controls.Add(ITEM_NAME_Label)
        Me.Controls.Add(Me.ITEM_NAME_TextBox)
        Me.Controls.Add(Me.SALESDataGridView)
        Me.Controls.Add(Me.SALESBindingNavigator)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SALESBindingNavigator.ResumeLayout(False)
        Me.SALESBindingNavigator.PerformLayout()
        CType(Me.SALESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As NANCY_inventory__management_sysytem.Database1DataSet
    Friend WithEvents SALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SALESTableAdapter As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.SALESTableAdapter
    Friend WithEvents TableAdapterManager As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SALESBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SALESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SALESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAY_OF_SALEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AMOUNT_OF_SALE_MADETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SALES_BALANCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SOLD_TO_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAME_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PHONETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEM_NAME_TextBox As System.Windows.Forms.TextBox
End Class
