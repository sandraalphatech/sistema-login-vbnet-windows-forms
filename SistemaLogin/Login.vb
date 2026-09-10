Public Class login
    Inherits Form

    Private Sub picUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RoundPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUser.Text = "Utilizador"
        txtUser.ForeColor = Color.Gray

        txtPassword.UseSystemPasswordChar = False
        txtPassword.Text = "Palavra-passe"
        txtPassword.ForeColor = Color.Gray

    End Sub

    Private Sub RoundPictureBox1_Click_1(sender As Object, e As EventArgs) Handles RoundPictureBox1.Click

    End Sub

    Private Sub RoundPictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUser.Text = "" Or txtUser.Text = "Utilizador" Then
            MessageBox.Show("Introduza seu nome de utilizador.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtUser.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Or txtPassword.Text = "Palavra-passe" Then
            MessageBox.Show("Introduza a palavra-passe.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        'Credenciais
        If txtUser.Text = "admin" And txtPassword.Text = "12345" Then

            Dim dashboard As New dash()

            dashboard.Nome = "João Silva"
            dashboard.Cargo = "Administrador"
            dashboard.Foto = My.Resources.ftadmin

            Me.Hide()
            dashboard.ShowDialog()


        ElseIf txtUser.Text = "sandra" And txtPassword.Text = "123456" Then

            Dim dashboard As New Dash()

            dashboard.Nome = "Sandra Silva"
            dashboard.Cargo = "Estudante"
            dashboard.Foto = My.Resources.ftstudent

            Me.Hide()
            dashboard.ShowDialog()


        ElseIf txtUser.Text <> "admin" And txtUser.Text <> "sandra" Then

            MessageBox.Show("Utilizador não registado.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            txtUser.Clear()
            txtPassword.Clear()
            txtUser.Focus()

        Else

            MessageBox.Show("Palavra-passe incorreta.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

            txtPassword.Clear()
            txtPassword.Focus()

        End If

    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter

        If txtUser.Text = "Utilizador" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.FromArgb(82, 74, 99)
        End If

    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave

        If txtUser.Text = "" Then
            txtUser.Text = "Utilizador"
            txtUser.ForeColor = Color.Gray
        End If

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter

        If txtPassword.Text = "Palavra-passe" Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.Clear()
            txtPassword.ForeColor = Color.FromArgb(82, 74, 99)
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

        If txtPassword.Text = "" Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.Text = "Palavra-passe"
            txtPassword.ForeColor = Color.Gray
        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub

    Private Sub txtPassword_TextChanged_1(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        Me.Close()
    End Sub

End Class