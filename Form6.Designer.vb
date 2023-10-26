<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim ITEM_NAME_Label As System.Windows.Forms.Label
        Dim DATE_OF_PURCHASELabel As System.Windows.Forms.Label
        Dim ITEMS_EXPIRY_DATELabel As System.Windows.Forms.Label
        Dim PRICE_OF_ITEMSLabel As System.Windows.Forms.Label
        Dim AMOUNT_OF_ITEMSLabel As System.Windows.Forms.Label
        Dim RECIEVED_BYLabel As System.Windows.Forms.Label
        Dim SOLD_BYLabel As System.Windows.Forms.Label
        Dim SELLER_COMPANY_NAMELabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim Button4 As System.Windows.Forms.Button
        Me.Database1DataSet = New NANCY_inventory__management_sysytem.Database1DataSet()
        Me.PURCHASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PURCHASESTableAdapter = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.PURCHASESTableAdapter()
        Me.TableAdapterManager = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager()
        Me.PURCHASESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PURCHASESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PURCHASESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIALTextBox = New System.Windows.Forms.TextBox()
        Me.ITEM_NAME_TextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_PURCHASEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ITEMS_EXPIRY_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PRICE_OF_ITEMSTextBox = New System.Windows.Forms.TextBox()
        Me.AMOUNT_OF_ITEMSTextBox = New System.Windows.Forms.TextBox()
        Me.RECIEVED_BYTextBox = New System.Windows.Forms.TextBox()
        Me.SOLD_BYTextBox = New System.Windows.Forms.TextBox()
        Me.SELLER_COMPANY_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        SERIALLabel = New System.Windows.Forms.Label()
        ITEM_NAME_Label = New System.Windows.Forms.Label()
        DATE_OF_PURCHASELabel = New System.Windows.Forms.Label()
        ITEMS_EXPIRY_DATELabel = New System.Windows.Forms.Label()
        PRICE_OF_ITEMSLabel = New System.Windows.Forms.Label()
        AMOUNT_OF_ITEMSLabel = New System.Windows.Forms.Label()
        RECIEVED_BYLabel = New System.Windows.Forms.Label()
        SOLD_BYLabel = New System.Windows.Forms.Label()
        SELLER_COMPANY_NAMELabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        Button4 = New System.Windows.Forms.Button()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PURCHASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PURCHASESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PURCHASESBindingNavigator.SuspendLayout()
        CType(Me.PURCHASESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SERIALLabel
        '
        SERIALLabel.AutoSize = True
        SERIALLabel.Location = New System.Drawing.Point(16, 284)
        SERIALLabel.Name = "SERIALLabel"
        SERIALLabel.Size = New System.Drawing.Size(48, 13)
        SERIALLabel.TabIndex = 2
        SERIALLabel.Text = "SERIAL:"
        '
        'ITEM_NAME_Label
        '
        ITEM_NAME_Label.AutoSize = True
        ITEM_NAME_Label.Location = New System.Drawing.Point(16, 310)
        ITEM_NAME_Label.Name = "ITEM_NAME_Label"
        ITEM_NAME_Label.Size = New System.Drawing.Size(73, 13)
        ITEM_NAME_Label.TabIndex = 4
        ITEM_NAME_Label.Text = "ITEM NAME :"
        '
        'DATE_OF_PURCHASELabel
        '
        DATE_OF_PURCHASELabel.AutoSize = True
        DATE_OF_PURCHASELabel.Location = New System.Drawing.Point(16, 337)
        DATE_OF_PURCHASELabel.Name = "DATE_OF_PURCHASELabel"
        DATE_OF_PURCHASELabel.Size = New System.Drawing.Size(118, 13)
        DATE_OF_PURCHASELabel.TabIndex = 6
        DATE_OF_PURCHASELabel.Text = "DATE OF PURCHASE:"
        '
        'ITEMS_EXPIRY_DATELabel
        '
        ITEMS_EXPIRY_DATELabel.AutoSize = True
        ITEMS_EXPIRY_DATELabel.Location = New System.Drawing.Point(16, 363)
        ITEMS_EXPIRY_DATELabel.Name = "ITEMS_EXPIRY_DATELabel"
        ITEMS_EXPIRY_DATELabel.Size = New System.Drawing.Size(117, 13)
        ITEMS_EXPIRY_DATELabel.TabIndex = 8
        ITEMS_EXPIRY_DATELabel.Text = "ITEMS EXPIRY DATE:"
        '
        'PRICE_OF_ITEMSLabel
        '
        PRICE_OF_ITEMSLabel.AutoSize = True
        PRICE_OF_ITEMSLabel.Location = New System.Drawing.Point(16, 388)
        PRICE_OF_ITEMSLabel.Name = "PRICE_OF_ITEMSLabel"
        PRICE_OF_ITEMSLabel.Size = New System.Drawing.Size(95, 13)
        PRICE_OF_ITEMSLabel.TabIndex = 10
        PRICE_OF_ITEMSLabel.Text = "PRICE OF ITEMS:"
        '
        'AMOUNT_OF_ITEMSLabel
        '
        AMOUNT_OF_ITEMSLabel.AutoSize = True
        AMOUNT_OF_ITEMSLabel.Location = New System.Drawing.Point(16, 414)
        AMOUNT_OF_ITEMSLabel.Name = "AMOUNT_OF_ITEMSLabel"
        AMOUNT_OF_ITEMSLabel.Size = New System.Drawing.Size(110, 13)
        AMOUNT_OF_ITEMSLabel.TabIndex = 12
        AMOUNT_OF_ITEMSLabel.Text = "AMOUNT OF ITEMS:"
        '
        'RECIEVED_BYLabel
        '
        RECIEVED_BYLabel.AutoSize = True
        RECIEVED_BYLabel.Location = New System.Drawing.Point(16, 440)
        RECIEVED_BYLabel.Name = "RECIEVED_BYLabel"
        RECIEVED_BYLabel.Size = New System.Drawing.Size(81, 13)
        RECIEVED_BYLabel.TabIndex = 14
        RECIEVED_BYLabel.Text = "RECIEVED BY:"
        '
        'SOLD_BYLabel
        '
        SOLD_BYLabel.AutoSize = True
        SOLD_BYLabel.Location = New System.Drawing.Point(16, 466)
        SOLD_BYLabel.Name = "SOLD_BYLabel"
        SOLD_BYLabel.Size = New System.Drawing.Size(56, 13)
        SOLD_BYLabel.TabIndex = 16
        SOLD_BYLabel.Text = "SOLD BY:"
        '
        'SELLER_COMPANY_NAMELabel
        '
        SELLER_COMPANY_NAMELabel.AutoSize = True
        SELLER_COMPANY_NAMELabel.Location = New System.Drawing.Point(16, 492)
        SELLER_COMPANY_NAMELabel.Name = "SELLER_COMPANY_NAMELabel"
        SELLER_COMPANY_NAMELabel.Size = New System.Drawing.Size(141, 13)
        SELLER_COMPANY_NAMELabel.TabIndex = 18
        SELLER_COMPANY_NAMELabel.Text = "SELLER COMPANY NAME:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(16, 518)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(42, 13)
        EMAILLabel.TabIndex = 20
        EMAILLabel.Text = "EMAIL:"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(16, 544)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(48, 13)
        PHONELabel.TabIndex = 22
        PHONELabel.Text = "PHONE:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PURCHASESBindingSource
        '
        Me.PURCHASESBindingSource.DataMember = "PURCHASES"
        Me.PURCHASESBindingSource.DataSource = Me.Database1DataSet
        '
        'PURCHASESTableAdapter
        '
        Me.PURCHASESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HOSPITAL_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.LAB_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PURCHASESTableAdapter = Me.PURCHASESTableAdapter
        Me.TableAdapterManager.SALESTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_TOOLSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PURCHASESBindingNavigator
        '
        Me.PURCHASESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PURCHASESBindingNavigator.BindingSource = Me.PURCHASESBindingSource
        Me.PURCHASESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PURCHASESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PURCHASESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PURCHASESBindingNavigatorSaveItem})
        Me.PURCHASESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PURCHASESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PURCHASESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PURCHASESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PURCHASESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PURCHASESBindingNavigator.Name = "PURCHASESBindingNavigator"
        Me.PURCHASESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PURCHASESBindingNavigator.Size = New System.Drawing.Size(1116, 25)
        Me.PURCHASESBindingNavigator.TabIndex = 0
        Me.PURCHASESBindingNavigator.Text = "BindingNavigator1"
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
        'PURCHASESBindingNavigatorSaveItem
        '
        Me.PURCHASESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PURCHASESBindingNavigatorSaveItem.Image = CType(resources.GetObject("PURCHASESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PURCHASESBindingNavigatorSaveItem.Name = "PURCHASESBindingNavigatorSaveItem"
        Me.PURCHASESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PURCHASESBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PURCHASESDataGridView
        '
        Me.PURCHASESDataGridView.AutoGenerateColumns = False
        Me.PURCHASESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PURCHASESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PURCHASESDataGridView.DataSource = Me.PURCHASESBindingSource
        Me.PURCHASESDataGridView.Location = New System.Drawing.Point(-12, 28)
        Me.PURCHASESDataGridView.Name = "PURCHASESDataGridView"
        Me.PURCHASESDataGridView.Size = New System.Drawing.Size(1108, 220)
        Me.PURCHASESDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SERIAL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SERIAL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ITEM NAME "
        Me.DataGridViewTextBoxColumn2.HeaderText = "ITEM NAME "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DATE OF PURCHASE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DATE OF PURCHASE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ITEMS EXPIRY DATE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ITEMS EXPIRY DATE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PRICE OF ITEMS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRICE OF ITEMS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "AMOUNT OF ITEMS"
        Me.DataGridViewTextBoxColumn6.HeaderText = "AMOUNT OF ITEMS"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RECIEVED BY"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RECIEVED BY"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SOLD BY"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SOLD BY"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SELLER COMPANY NAME"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SELLER COMPANY NAME"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PHONE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PHONE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'SERIALTextBox
        '
        Me.SERIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "SERIAL", True))
        Me.SERIALTextBox.Location = New System.Drawing.Point(163, 281)
        Me.SERIALTextBox.Name = "SERIALTextBox"
        Me.SERIALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SERIALTextBox.TabIndex = 3
        '
        'ITEM_NAME_TextBox
        '
        Me.ITEM_NAME_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "ITEM NAME ", True))
        Me.ITEM_NAME_TextBox.Location = New System.Drawing.Point(163, 307)
        Me.ITEM_NAME_TextBox.Name = "ITEM_NAME_TextBox"
        Me.ITEM_NAME_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITEM_NAME_TextBox.TabIndex = 5
        '
        'DATE_OF_PURCHASEDateTimePicker
        '
        Me.DATE_OF_PURCHASEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PURCHASESBindingSource, "DATE OF PURCHASE", True))
        Me.DATE_OF_PURCHASEDateTimePicker.Location = New System.Drawing.Point(163, 333)
        Me.DATE_OF_PURCHASEDateTimePicker.Name = "DATE_OF_PURCHASEDateTimePicker"
        Me.DATE_OF_PURCHASEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATE_OF_PURCHASEDateTimePicker.TabIndex = 7
        '
        'ITEMS_EXPIRY_DATEDateTimePicker
        '
        Me.ITEMS_EXPIRY_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PURCHASESBindingSource, "ITEMS EXPIRY DATE", True))
        Me.ITEMS_EXPIRY_DATEDateTimePicker.Location = New System.Drawing.Point(163, 359)
        Me.ITEMS_EXPIRY_DATEDateTimePicker.Name = "ITEMS_EXPIRY_DATEDateTimePicker"
        Me.ITEMS_EXPIRY_DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ITEMS_EXPIRY_DATEDateTimePicker.TabIndex = 9
        '
        'PRICE_OF_ITEMSTextBox
        '
        Me.PRICE_OF_ITEMSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "PRICE OF ITEMS", True))
        Me.PRICE_OF_ITEMSTextBox.Location = New System.Drawing.Point(163, 385)
        Me.PRICE_OF_ITEMSTextBox.Name = "PRICE_OF_ITEMSTextBox"
        Me.PRICE_OF_ITEMSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRICE_OF_ITEMSTextBox.TabIndex = 11
        '
        'AMOUNT_OF_ITEMSTextBox
        '
        Me.AMOUNT_OF_ITEMSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "AMOUNT OF ITEMS", True))
        Me.AMOUNT_OF_ITEMSTextBox.Location = New System.Drawing.Point(163, 411)
        Me.AMOUNT_OF_ITEMSTextBox.Name = "AMOUNT_OF_ITEMSTextBox"
        Me.AMOUNT_OF_ITEMSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AMOUNT_OF_ITEMSTextBox.TabIndex = 13
        '
        'RECIEVED_BYTextBox
        '
        Me.RECIEVED_BYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "RECIEVED BY", True))
        Me.RECIEVED_BYTextBox.Location = New System.Drawing.Point(163, 437)
        Me.RECIEVED_BYTextBox.Name = "RECIEVED_BYTextBox"
        Me.RECIEVED_BYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RECIEVED_BYTextBox.TabIndex = 15
        '
        'SOLD_BYTextBox
        '
        Me.SOLD_BYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "SOLD BY", True))
        Me.SOLD_BYTextBox.Location = New System.Drawing.Point(163, 463)
        Me.SOLD_BYTextBox.Name = "SOLD_BYTextBox"
        Me.SOLD_BYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SOLD_BYTextBox.TabIndex = 17
        '
        'SELLER_COMPANY_NAMETextBox
        '
        Me.SELLER_COMPANY_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "SELLER COMPANY NAME", True))
        Me.SELLER_COMPANY_NAMETextBox.Location = New System.Drawing.Point(163, 489)
        Me.SELLER_COMPANY_NAMETextBox.Name = "SELLER_COMPANY_NAMETextBox"
        Me.SELLER_COMPANY_NAMETextBox.Size = New System.Drawing.Size(200, 20)
        Me.SELLER_COMPANY_NAMETextBox.TabIndex = 19
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(163, 515)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EMAILTextBox.TabIndex = 21
        '
        'PHONETextBox
        '
        Me.PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASESBindingSource, "PHONE", True))
        Me.PHONETextBox.Location = New System.Drawing.Point(163, 541)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(200, 20)
        Me.PHONETextBox.TabIndex = 23
        '
        'Button4
        '
        Button4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Button4.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button4.ForeColor = System.Drawing.Color.White
        Button4.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__146_
        Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button4.Location = New System.Drawing.Point(530, 515)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(110, 42)
        Button4.TabIndex = 24
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__166_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1116, 610)
        Me.Controls.Add(Button4)
        Me.Controls.Add(SERIALLabel)
        Me.Controls.Add(Me.SERIALTextBox)
        Me.Controls.Add(ITEM_NAME_Label)
        Me.Controls.Add(Me.ITEM_NAME_TextBox)
        Me.Controls.Add(DATE_OF_PURCHASELabel)
        Me.Controls.Add(Me.DATE_OF_PURCHASEDateTimePicker)
        Me.Controls.Add(ITEMS_EXPIRY_DATELabel)
        Me.Controls.Add(Me.ITEMS_EXPIRY_DATEDateTimePicker)
        Me.Controls.Add(PRICE_OF_ITEMSLabel)
        Me.Controls.Add(Me.PRICE_OF_ITEMSTextBox)
        Me.Controls.Add(AMOUNT_OF_ITEMSLabel)
        Me.Controls.Add(Me.AMOUNT_OF_ITEMSTextBox)
        Me.Controls.Add(RECIEVED_BYLabel)
        Me.Controls.Add(Me.RECIEVED_BYTextBox)
        Me.Controls.Add(SOLD_BYLabel)
        Me.Controls.Add(Me.SOLD_BYTextBox)
        Me.Controls.Add(SELLER_COMPANY_NAMELabel)
        Me.Controls.Add(Me.SELLER_COMPANY_NAMETextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(PHONELabel)
        Me.Controls.Add(Me.PHONETextBox)
        Me.Controls.Add(Me.PURCHASESDataGridView)
        Me.Controls.Add(Me.PURCHASESBindingNavigator)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PURCHASES"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PURCHASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PURCHASESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PURCHASESBindingNavigator.ResumeLayout(False)
        Me.PURCHASESBindingNavigator.PerformLayout()
        CType(Me.PURCHASESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As NANCY_inventory__management_sysytem.Database1DataSet
    Friend WithEvents PURCHASESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PURCHASESTableAdapter As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.PURCHASESTableAdapter
    Friend WithEvents TableAdapterManager As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PURCHASESBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PURCHASESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PURCHASESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEM_NAME_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_OF_PURCHASEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ITEMS_EXPIRY_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PRICE_OF_ITEMSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_OF_ITEMSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RECIEVED_BYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SOLD_BYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SELLER_COMPANY_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PHONETextBox As System.Windows.Forms.TextBox
End Class
