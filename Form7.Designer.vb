<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Dim SERIALLabel As System.Windows.Forms.Label
        Dim NAME_Label As System.Windows.Forms.Label
        Dim QUANTITY_IN_STOCKLabel As System.Windows.Forms.Label
        Dim DATE_UPDATEDLabel As System.Windows.Forms.Label
        Dim PERSONEL_INCHARGELabel As System.Windows.Forms.Label
        Dim CATEGORYLabel As System.Windows.Forms.Label
        Dim Button4 As System.Windows.Forms.Button
        Me.LAB_EQUIPMENTSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.LAB_EQUIPMENTSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LAB_EQUIPMENTSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SERIALTextBox = New System.Windows.Forms.TextBox()
        Me.NAME_TextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITY_IN_STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_UPDATEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PERSONEL_INCHARGETextBox = New System.Windows.Forms.TextBox()
        Me.CATEGORYTextBox = New System.Windows.Forms.TextBox()
        Me.LAB_EQUIPMENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New NANCY_inventory__management_sysytem.Database1DataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAB_EQUIPMENTSTableAdapter = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.LAB_EQUIPMENTSTableAdapter()
        Me.TableAdapterManager = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager()
        SERIALLabel = New System.Windows.Forms.Label()
        NAME_Label = New System.Windows.Forms.Label()
        QUANTITY_IN_STOCKLabel = New System.Windows.Forms.Label()
        DATE_UPDATEDLabel = New System.Windows.Forms.Label()
        PERSONEL_INCHARGELabel = New System.Windows.Forms.Label()
        CATEGORYLabel = New System.Windows.Forms.Label()
        Button4 = New System.Windows.Forms.Button()
        CType(Me.LAB_EQUIPMENTSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LAB_EQUIPMENTSBindingNavigator.SuspendLayout()
        CType(Me.LAB_EQUIPMENTSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAB_EQUIPMENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LAB_EQUIPMENTSBindingNavigator
        '
        Me.LAB_EQUIPMENTSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LAB_EQUIPMENTSBindingNavigator.BindingSource = Me.LAB_EQUIPMENTSBindingSource
        Me.LAB_EQUIPMENTSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LAB_EQUIPMENTSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LAB_EQUIPMENTSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LAB_EQUIPMENTSBindingNavigatorSaveItem})
        Me.LAB_EQUIPMENTSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LAB_EQUIPMENTSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LAB_EQUIPMENTSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LAB_EQUIPMENTSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LAB_EQUIPMENTSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LAB_EQUIPMENTSBindingNavigator.Name = "LAB_EQUIPMENTSBindingNavigator"
        Me.LAB_EQUIPMENTSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LAB_EQUIPMENTSBindingNavigator.Size = New System.Drawing.Size(1118, 25)
        Me.LAB_EQUIPMENTSBindingNavigator.TabIndex = 0
        Me.LAB_EQUIPMENTSBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'LAB_EQUIPMENTSBindingNavigatorSaveItem
        '
        Me.LAB_EQUIPMENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LAB_EQUIPMENTSBindingNavigatorSaveItem.Image = CType(resources.GetObject("LAB_EQUIPMENTSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LAB_EQUIPMENTSBindingNavigatorSaveItem.Name = "LAB_EQUIPMENTSBindingNavigatorSaveItem"
        Me.LAB_EQUIPMENTSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LAB_EQUIPMENTSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LAB_EQUIPMENTSDataGridView
        '
        Me.LAB_EQUIPMENTSDataGridView.AutoGenerateColumns = False
        Me.LAB_EQUIPMENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LAB_EQUIPMENTSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.LAB_EQUIPMENTSDataGridView.DataSource = Me.LAB_EQUIPMENTSBindingSource
        Me.LAB_EQUIPMENTSDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.LAB_EQUIPMENTSDataGridView.Name = "LAB_EQUIPMENTSDataGridView"
        Me.LAB_EQUIPMENTSDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.LAB_EQUIPMENTSDataGridView.TabIndex = 1
        '
        'SERIALLabel
        '
        SERIALLabel.AutoSize = True
        SERIALLabel.Location = New System.Drawing.Point(24, 287)
        SERIALLabel.Name = "SERIALLabel"
        SERIALLabel.Size = New System.Drawing.Size(48, 13)
        SERIALLabel.TabIndex = 2
        SERIALLabel.Text = "SERIAL:"
        '
        'SERIALTextBox
        '
        Me.SERIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAB_EQUIPMENTSBindingSource, "SERIAL", True))
        Me.SERIALTextBox.Location = New System.Drawing.Point(157, 284)
        Me.SERIALTextBox.Name = "SERIALTextBox"
        Me.SERIALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SERIALTextBox.TabIndex = 3
        '
        'NAME_Label
        '
        NAME_Label.AutoSize = True
        NAME_Label.Location = New System.Drawing.Point(24, 313)
        NAME_Label.Name = "NAME_Label"
        NAME_Label.Size = New System.Drawing.Size(44, 13)
        NAME_Label.TabIndex = 4
        NAME_Label.Text = "NAME :"
        '
        'NAME_TextBox
        '
        Me.NAME_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAB_EQUIPMENTSBindingSource, "NAME ", True))
        Me.NAME_TextBox.Location = New System.Drawing.Point(157, 310)
        Me.NAME_TextBox.Name = "NAME_TextBox"
        Me.NAME_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NAME_TextBox.TabIndex = 5
        '
        'QUANTITY_IN_STOCKLabel
        '
        QUANTITY_IN_STOCKLabel.AutoSize = True
        QUANTITY_IN_STOCKLabel.Location = New System.Drawing.Point(24, 339)
        QUANTITY_IN_STOCKLabel.Name = "QUANTITY_IN_STOCKLabel"
        QUANTITY_IN_STOCKLabel.Size = New System.Drawing.Size(118, 13)
        QUANTITY_IN_STOCKLabel.TabIndex = 6
        QUANTITY_IN_STOCKLabel.Text = "QUANTITY IN STOCK:"
        '
        'QUANTITY_IN_STOCKTextBox
        '
        Me.QUANTITY_IN_STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAB_EQUIPMENTSBindingSource, "QUANTITY IN STOCK", True))
        Me.QUANTITY_IN_STOCKTextBox.Location = New System.Drawing.Point(157, 336)
        Me.QUANTITY_IN_STOCKTextBox.Name = "QUANTITY_IN_STOCKTextBox"
        Me.QUANTITY_IN_STOCKTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QUANTITY_IN_STOCKTextBox.TabIndex = 7
        '
        'DATE_UPDATEDLabel
        '
        DATE_UPDATEDLabel.AutoSize = True
        DATE_UPDATEDLabel.Location = New System.Drawing.Point(24, 366)
        DATE_UPDATEDLabel.Name = "DATE_UPDATEDLabel"
        DATE_UPDATEDLabel.Size = New System.Drawing.Size(94, 13)
        DATE_UPDATEDLabel.TabIndex = 8
        DATE_UPDATEDLabel.Text = "DATE UPDATED:"
        '
        'DATE_UPDATEDDateTimePicker
        '
        Me.DATE_UPDATEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LAB_EQUIPMENTSBindingSource, "DATE UPDATED", True))
        Me.DATE_UPDATEDDateTimePicker.Location = New System.Drawing.Point(157, 362)
        Me.DATE_UPDATEDDateTimePicker.Name = "DATE_UPDATEDDateTimePicker"
        Me.DATE_UPDATEDDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATE_UPDATEDDateTimePicker.TabIndex = 9
        '
        'PERSONEL_INCHARGELabel
        '
        PERSONEL_INCHARGELabel.AutoSize = True
        PERSONEL_INCHARGELabel.Location = New System.Drawing.Point(24, 391)
        PERSONEL_INCHARGELabel.Name = "PERSONEL_INCHARGELabel"
        PERSONEL_INCHARGELabel.Size = New System.Drawing.Size(127, 13)
        PERSONEL_INCHARGELabel.TabIndex = 10
        PERSONEL_INCHARGELabel.Text = "PERSONEL INCHARGE:"
        '
        'PERSONEL_INCHARGETextBox
        '
        Me.PERSONEL_INCHARGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAB_EQUIPMENTSBindingSource, "PERSONEL INCHARGE", True))
        Me.PERSONEL_INCHARGETextBox.Location = New System.Drawing.Point(157, 388)
        Me.PERSONEL_INCHARGETextBox.Name = "PERSONEL_INCHARGETextBox"
        Me.PERSONEL_INCHARGETextBox.Size = New System.Drawing.Size(200, 20)
        Me.PERSONEL_INCHARGETextBox.TabIndex = 11
        '
        'CATEGORYLabel
        '
        CATEGORYLabel.AutoSize = True
        CATEGORYLabel.Location = New System.Drawing.Point(24, 417)
        CATEGORYLabel.Name = "CATEGORYLabel"
        CATEGORYLabel.Size = New System.Drawing.Size(69, 13)
        CATEGORYLabel.TabIndex = 12
        CATEGORYLabel.Text = "CATEGORY:"
        '
        'CATEGORYTextBox
        '
        Me.CATEGORYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAB_EQUIPMENTSBindingSource, "CATEGORY", True))
        Me.CATEGORYTextBox.Location = New System.Drawing.Point(157, 414)
        Me.CATEGORYTextBox.Name = "CATEGORYTextBox"
        Me.CATEGORYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CATEGORYTextBox.TabIndex = 13
        '
        'LAB_EQUIPMENTSBindingSource
        '
        Me.LAB_EQUIPMENTSBindingSource.DataMember = "LAB EQUIPMENTS"
        Me.LAB_EQUIPMENTSBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QUANTITY IN STOCK"
        Me.DataGridViewTextBoxColumn3.HeaderText = "QUANTITY IN STOCK"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DATE UPDATED"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DATE UPDATED"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PERSONEL INCHARGE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PERSONEL INCHARGE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CATEGORY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'LAB_EQUIPMENTSTableAdapter
        '
        Me.LAB_EQUIPMENTSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HOSPITAL_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.LAB_EQUIPMENTSTableAdapter = Me.LAB_EQUIPMENTSTableAdapter
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PURCHASESTableAdapter = Nothing
        Me.TableAdapterManager.SALESTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_TOOLSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button4
        '
        Button4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Button4.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button4.ForeColor = System.Drawing.Color.White
        Button4.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__146_
        Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button4.Location = New System.Drawing.Point(157, 497)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(110, 42)
        Button4.TabIndex = 14
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__144_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1118, 620)
        Me.Controls.Add(Button4)
        Me.Controls.Add(SERIALLabel)
        Me.Controls.Add(Me.SERIALTextBox)
        Me.Controls.Add(NAME_Label)
        Me.Controls.Add(Me.NAME_TextBox)
        Me.Controls.Add(QUANTITY_IN_STOCKLabel)
        Me.Controls.Add(Me.QUANTITY_IN_STOCKTextBox)
        Me.Controls.Add(DATE_UPDATEDLabel)
        Me.Controls.Add(Me.DATE_UPDATEDDateTimePicker)
        Me.Controls.Add(PERSONEL_INCHARGELabel)
        Me.Controls.Add(Me.PERSONEL_INCHARGETextBox)
        Me.Controls.Add(CATEGORYLabel)
        Me.Controls.Add(Me.CATEGORYTextBox)
        Me.Controls.Add(Me.LAB_EQUIPMENTSDataGridView)
        Me.Controls.Add(Me.LAB_EQUIPMENTSBindingNavigator)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAB EQUIPMENTS"
        CType(Me.LAB_EQUIPMENTSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LAB_EQUIPMENTSBindingNavigator.ResumeLayout(False)
        Me.LAB_EQUIPMENTSBindingNavigator.PerformLayout()
        CType(Me.LAB_EQUIPMENTSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAB_EQUIPMENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As NANCY_inventory__management_sysytem.Database1DataSet
    Friend WithEvents LAB_EQUIPMENTSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAB_EQUIPMENTSTableAdapter As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.LAB_EQUIPMENTSTableAdapter
    Friend WithEvents TableAdapterManager As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LAB_EQUIPMENTSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LAB_EQUIPMENTSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LAB_EQUIPMENTSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAME_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITY_IN_STOCKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_UPDATEDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PERSONEL_INCHARGETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CATEGORYTextBox As System.Windows.Forms.TextBox
End Class
