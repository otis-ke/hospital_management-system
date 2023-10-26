Public Class Form6

    Private Sub PURCHASESBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PURCHASESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PURCHASESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.PURCHASES' table. You can move, or remove it, as needed.
        Me.PURCHASESTableAdapter.Fill(Me.Database1DataSet.PURCHASES)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Close()

    End Sub
End Class