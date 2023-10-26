Public Class Form7

    Private Sub LAB_EQUIPMENTSBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles LAB_EQUIPMENTSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LAB_EQUIPMENTSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.LAB_EQUIPMENTS' table. You can move, or remove it, as needed.
        Me.LAB_EQUIPMENTSTableAdapter.Fill(Me.Database1DataSet.LAB_EQUIPMENTS)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Close()

    End Sub
End Class