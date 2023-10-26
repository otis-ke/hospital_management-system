Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.HOSPITAL_EQUIPMENTS' table. You can move, or remove it, as needed.
        Me.HOSPITAL_EQUIPMENTSTableAdapter.Fill(Me.Database1DataSet.HOSPITAL_EQUIPMENTS)

    End Sub

    Private Sub HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles HOSPITAL_EQUIPMENTSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HOSPITAL_EQUIPMENTSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Close()

    End Sub
End Class