Public Class Form1

    Private Sub txtPass_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub txtUSERNAME_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub txtPASSWORD_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub txtUSER_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btnEXIT_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btnLOGIN_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnEXIT_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEXIT.Click
        Application.Exit()
    End Sub

    Private Sub btnLOGIN_Click_1(sender As System.Object, e As System.EventArgs) Handles btnLOGIN.Click
        Dim Username As String
        Dim Password As String
        Username = txtUSER.Text
        Password = txtPass.Text

        If (Username.Equals("nancy") And Password.Equals("lenantoiye")) Then
            MessageBox.Show("log in succses", " infomation",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form2.Show()

        ElseIf (Username.Equals("otis") And Password.Equals("admin")) Then
            MessageBox.Show("log in succses", " infomation",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form2.Show()
        Else
            MessageBox.Show("wrong login credentials ", " infomation",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)

            Form2.Enabled = True

        End If
    End Sub
End Class
