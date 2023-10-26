Public Class Form5

    Private Sub SALESBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SALESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SALESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.SALES' table. You can move, or remove it, as needed.
        Me.SALESTableAdapter.Fill(Me.Database1DataSet.SALES)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Close()

    End Sub
End Class