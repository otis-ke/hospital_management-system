﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim CATEGORY_Label As System.Windows.Forms.Label
        Dim AMOUNT_IN_STOCKLabel As System.Windows.Forms.Label
        Dim STAFF_INCHARGELabel As System.Windows.Forms.Label
        Dim DATE_UPDATEDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim Button4 As System.Windows.Forms.Button
        Me.Database1DataSet = New NANCY_inventory__management_sysytem.Database1DataSet()
        Me.STAFF_TOOLSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFF_TOOLSTableAdapter = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.STAFF_TOOLSTableAdapter()
        Me.TableAdapterManager = New NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager()
        Me.STAFF_TOOLSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.STAFF_TOOLSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.STAFF_TOOLSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIALTextBox = New System.Windows.Forms.TextBox()
        Me.NAME_TextBox = New System.Windows.Forms.TextBox()
        Me.CATEGORY_TextBox = New System.Windows.Forms.TextBox()
        Me.AMOUNT_IN_STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.STAFF_INCHARGETextBox = New System.Windows.Forms.TextBox()
        Me.DATE_UPDATEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        SERIALLabel = New System.Windows.Forms.Label()
        NAME_Label = New System.Windows.Forms.Label()
        CATEGORY_Label = New System.Windows.Forms.Label()
        AMOUNT_IN_STOCKLabel = New System.Windows.Forms.Label()
        STAFF_INCHARGELabel = New System.Windows.Forms.Label()
        DATE_UPDATEDLabel = New System.Windows.Forms.Label()
        Button4 = New System.Windows.Forms.Button()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFF_TOOLSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFF_TOOLSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STAFF_TOOLSBindingNavigator.SuspendLayout()
        CType(Me.STAFF_TOOLSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SERIALLabel
        '
        SERIALLabel.AutoSize = True
        SERIALLabel.Location = New System.Drawing.Point(8, 274)
        SERIALLabel.Name = "SERIALLabel"
        SERIALLabel.Size = New System.Drawing.Size(48, 13)
        SERIALLabel.TabIndex = 2
        SERIALLabel.Text = "SERIAL:"
        '
        'NAME_Label
        '
        NAME_Label.AutoSize = True
        NAME_Label.Location = New System.Drawing.Point(8, 300)
        NAME_Label.Name = "NAME_Label"
        NAME_Label.Size = New System.Drawing.Size(44, 13)
        NAME_Label.TabIndex = 4
        NAME_Label.Text = "NAME :"
        '
        'CATEGORY_Label
        '
        CATEGORY_Label.AutoSize = True
        CATEGORY_Label.Location = New System.Drawing.Point(8, 326)
        CATEGORY_Label.Name = "CATEGORY_Label"
        CATEGORY_Label.Size = New System.Drawing.Size(72, 13)
        CATEGORY_Label.TabIndex = 6
        CATEGORY_Label.Text = "CATEGORY :"
        '
        'AMOUNT_IN_STOCKLabel
        '
        AMOUNT_IN_STOCKLabel.AutoSize = True
        AMOUNT_IN_STOCKLabel.Location = New System.Drawing.Point(8, 352)
        AMOUNT_IN_STOCKLabel.Name = "AMOUNT_IN_STOCKLabel"
        AMOUNT_IN_STOCKLabel.Size = New System.Drawing.Size(110, 13)
        AMOUNT_IN_STOCKLabel.TabIndex = 8
        AMOUNT_IN_STOCKLabel.Text = "AMOUNT IN STOCK:"
        '
        'STAFF_INCHARGELabel
        '
        STAFF_INCHARGELabel.AutoSize = True
        STAFF_INCHARGELabel.Location = New System.Drawing.Point(8, 378)
        STAFF_INCHARGELabel.Name = "STAFF_INCHARGELabel"
        STAFF_INCHARGELabel.Size = New System.Drawing.Size(102, 13)
        STAFF_INCHARGELabel.TabIndex = 10
        STAFF_INCHARGELabel.Text = "STAFF INCHARGE:"
        '
        'DATE_UPDATEDLabel
        '
        DATE_UPDATEDLabel.AutoSize = True
        DATE_UPDATEDLabel.Location = New System.Drawing.Point(8, 405)
        DATE_UPDATEDLabel.Name = "DATE_UPDATEDLabel"
        DATE_UPDATEDLabel.Size = New System.Drawing.Size(94, 13)
        DATE_UPDATEDLabel.TabIndex = 12
        DATE_UPDATEDLabel.Text = "DATE UPDATED:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STAFF_TOOLSBindingSource
        '
        Me.STAFF_TOOLSBindingSource.DataMember = "STAFF TOOLS"
        Me.STAFF_TOOLSBindingSource.DataSource = Me.Database1DataSet
        '
        'STAFF_TOOLSTableAdapter
        '
        Me.STAFF_TOOLSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HOSPITAL_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.LAB_EQUIPMENTSTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PURCHASESTableAdapter = Nothing
        Me.TableAdapterManager.SALESTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_TOOLSTableAdapter = Me.STAFF_TOOLSTableAdapter
        Me.TableAdapterManager.UpdateOrder = NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STAFF_TOOLSBindingNavigator
        '
        Me.STAFF_TOOLSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.STAFF_TOOLSBindingNavigator.BindingSource = Me.STAFF_TOOLSBindingSource
        Me.STAFF_TOOLSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.STAFF_TOOLSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.STAFF_TOOLSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.STAFF_TOOLSBindingNavigatorSaveItem})
        Me.STAFF_TOOLSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.STAFF_TOOLSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.STAFF_TOOLSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.STAFF_TOOLSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.STAFF_TOOLSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.STAFF_TOOLSBindingNavigator.Name = "STAFF_TOOLSBindingNavigator"
        Me.STAFF_TOOLSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.STAFF_TOOLSBindingNavigator.Size = New System.Drawing.Size(1118, 25)
        Me.STAFF_TOOLSBindingNavigator.TabIndex = 0
        Me.STAFF_TOOLSBindingNavigator.Text = "BindingNavigator1"
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
        'STAFF_TOOLSBindingNavigatorSaveItem
        '
        Me.STAFF_TOOLSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.STAFF_TOOLSBindingNavigatorSaveItem.Image = CType(resources.GetObject("STAFF_TOOLSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.STAFF_TOOLSBindingNavigatorSaveItem.Name = "STAFF_TOOLSBindingNavigatorSaveItem"
        Me.STAFF_TOOLSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.STAFF_TOOLSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'STAFF_TOOLSDataGridView
        '
        Me.STAFF_TOOLSDataGridView.AutoGenerateColumns = False
        Me.STAFF_TOOLSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STAFF_TOOLSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.STAFF_TOOLSDataGridView.DataSource = Me.STAFF_TOOLSBindingSource
        Me.STAFF_TOOLSDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.STAFF_TOOLSDataGridView.Name = "STAFF_TOOLSDataGridView"
        Me.STAFF_TOOLSDataGridView.Size = New System.Drawing.Size(647, 220)
        Me.STAFF_TOOLSDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CATEGORY "
        Me.DataGridViewTextBoxColumn3.HeaderText = "CATEGORY "
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "STAFF INCHARGE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "STAFF INCHARGE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DATE UPDATED"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DATE UPDATED"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'SERIALTextBox
        '
        Me.SERIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_TOOLSBindingSource, "SERIAL", True))
        Me.SERIALTextBox.Location = New System.Drawing.Point(124, 271)
        Me.SERIALTextBox.Name = "SERIALTextBox"
        Me.SERIALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SERIALTextBox.TabIndex = 3
        '
        'NAME_TextBox
        '
        Me.NAME_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_TOOLSBindingSource, "NAME ", True))
        Me.NAME_TextBox.Location = New System.Drawing.Point(124, 297)
        Me.NAME_TextBox.Name = "NAME_TextBox"
        Me.NAME_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NAME_TextBox.TabIndex = 5
        '
        'CATEGORY_TextBox
        '
        Me.CATEGORY_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_TOOLSBindingSource, "CATEGORY ", True))
        Me.CATEGORY_TextBox.Location = New System.Drawing.Point(124, 323)
        Me.CATEGORY_TextBox.Name = "CATEGORY_TextBox"
        Me.CATEGORY_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.CATEGORY_TextBox.TabIndex = 7
        '
        'AMOUNT_IN_STOCKTextBox
        '
        Me.AMOUNT_IN_STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_TOOLSBindingSource, "AMOUNT IN STOCK", True))
        Me.AMOUNT_IN_STOCKTextBox.Location = New System.Drawing.Point(124, 349)
        Me.AMOUNT_IN_STOCKTextBox.Name = "AMOUNT_IN_STOCKTextBox"
        Me.AMOUNT_IN_STOCKTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AMOUNT_IN_STOCKTextBox.TabIndex = 9
        '
        'STAFF_INCHARGETextBox
        '
        Me.STAFF_INCHARGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_TOOLSBindingSource, "STAFF INCHARGE", True))
        Me.STAFF_INCHARGETextBox.Location = New System.Drawing.Point(124, 375)
        Me.STAFF_INCHARGETextBox.Name = "STAFF_INCHARGETextBox"
        Me.STAFF_INCHARGETextBox.Size = New System.Drawing.Size(200, 20)
        Me.STAFF_INCHARGETextBox.TabIndex = 11
        '
        'DATE_UPDATEDDateTimePicker
        '
        Me.DATE_UPDATEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.STAFF_TOOLSBindingSource, "DATE UPDATED", True))
        Me.DATE_UPDATEDDateTimePicker.Location = New System.Drawing.Point(124, 401)
        Me.DATE_UPDATEDDateTimePicker.Name = "DATE_UPDATEDDateTimePicker"
        Me.DATE_UPDATEDDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATE_UPDATEDDateTimePicker.TabIndex = 13
        '
        'Button4
        '
        Button4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Button4.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button4.ForeColor = System.Drawing.Color.White
        Button4.Image = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__146_
        Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Button4.Location = New System.Drawing.Point(124, 487)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(110, 42)
        Button4.TabIndex = 14
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NANCY_inventory__management_sysytem.My.Resources.Resources.Screenshot__164_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1118, 620)
        Me.Controls.Add(Button4)
        Me.Controls.Add(SERIALLabel)
        Me.Controls.Add(Me.SERIALTextBox)
        Me.Controls.Add(NAME_Label)
        Me.Controls.Add(Me.NAME_TextBox)
        Me.Controls.Add(CATEGORY_Label)
        Me.Controls.Add(Me.CATEGORY_TextBox)
        Me.Controls.Add(AMOUNT_IN_STOCKLabel)
        Me.Controls.Add(Me.AMOUNT_IN_STOCKTextBox)
        Me.Controls.Add(STAFF_INCHARGELabel)
        Me.Controls.Add(Me.STAFF_INCHARGETextBox)
        Me.Controls.Add(DATE_UPDATEDLabel)
        Me.Controls.Add(Me.DATE_UPDATEDDateTimePicker)
        Me.Controls.Add(Me.STAFF_TOOLSDataGridView)
        Me.Controls.Add(Me.STAFF_TOOLSBindingNavigator)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STAFF TOOLS"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFF_TOOLSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFF_TOOLSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STAFF_TOOLSBindingNavigator.ResumeLayout(False)
        Me.STAFF_TOOLSBindingNavigator.PerformLayout()
        CType(Me.STAFF_TOOLSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As NANCY_inventory__management_sysytem.Database1DataSet
    Friend WithEvents STAFF_TOOLSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STAFF_TOOLSTableAdapter As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.STAFF_TOOLSTableAdapter
    Friend WithEvents TableAdapterManager As NANCY_inventory__management_sysytem.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents STAFF_TOOLSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents STAFF_TOOLSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents STAFF_TOOLSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAME_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CATEGORY_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_IN_STOCKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STAFF_INCHARGETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_UPDATEDDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
