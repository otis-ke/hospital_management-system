Public Class Form4

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.STAFF_TOOLS' table. You can move, or remove it, as needed.
        Me.STAFF_TOOLSTableAdapter.Fill(Me.Database1DataSet.STAFF_TOOLS)

    End Sub

    Private Sub STAFF_TOOLSBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles STAFF_TOOLSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.STAFF_TOOLSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Close()

    End Sub
End Class