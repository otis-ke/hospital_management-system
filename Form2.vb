Public Class Form2

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.MEDICINE' table. You can move, or remove it, as needed.
        Me.MEDICINETableAdapter.Fill(Me.Database1DataSet.MEDICINE)

    End Sub

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Form4.Show()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Form5.Show()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)
        Form6.Show()

    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs)
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Form3.Show()

    End Sub

    Private Sub MEDICINEBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MEDICINEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEDICINEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Close()

    End Sub
End Class