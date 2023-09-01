Public Class Form1
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text_user.Select()


    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Text_user.Text.Trim = "slimaeda" And Text_pass.Text.Trim = "1234" Then
            Main.ShowDialog()
            Me.Hide()
        Else

            MessageBox.Show("incorrect password ", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)




        End If
        Text_user.Text = ""
        Text_pass.Text = ""
    End Sub

    Private Sub check_code_CheckedChanged(sender As Object, e As EventArgs) Handles check_code.CheckedChanged
        Text_pass.UseSystemPasswordChar = False
        Try
            If check_code.Checked = False Then
                Text_pass.UseSystemPasswordChar = True
            End If
        Catch ex As Exception

        End Try

    End Sub


End Class
