Public Class Conversor
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub Conversor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            cmbTemperatura.Items.Clear()

            cmbTemperatura.Items.Add("Celsius")
            cmbTemperatura.Items.Add("Fahrenheit")
            cmbTemperatura.Items.Add("Kelvin")

            cmbTemperatura.SelectedIndex = 0

            lblValorC.Text = "--"
            lblValorF.Text = "--"
            lblValorK.Text = "--"

        End Sub

        Private Sub cmbConversao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTemperatura.SelectedIndexChanged

    End Sub

    Private Sub btnConverter_Click(sender As Object, e As EventArgs) Handles btnConverter.Click

        Dim temperatura As Double

        If Not Double.TryParse(txtTemperatura.Text.Replace(".", ","), temperatura) Then
            MessageBox.Show("Digite uma temperatura válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTemperatura.Focus()
            Exit Sub
        End If

        Dim celsius As Double
        Dim fahrenheit As Double
        Dim kelvin As Double

        Select Case cmbTemperatura.Text

            Case "Celsius"

                celsius = temperatura
                fahrenheit = (celsius * 9 / 5) + 32
                kelvin = celsius + 273.15

            Case "Fahrenheit"

                fahrenheit = temperatura
                celsius = (fahrenheit - 32) * 5 / 9
                kelvin = celsius + 273.15

            Case "Kelvin"

                kelvin = temperatura
                celsius = kelvin - 273.15
                fahrenheit = (celsius * 9 / 5) + 32

        End Select

        lblValorC.Text = celsius.ToString("0.##")
        lblValorF.Text = fahrenheit.ToString("0.##")
        lblValorK.Text = kelvin.ToString("0.##")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RoundPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundPanel1.Paint

    End Sub

Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

End Sub

    Private Sub lblValorK_Click(sender As Object, e As EventArgs) Handles lblValorK.Click

    End Sub

    Private Sub lblUnidadeK_Click(sender As Object, e As EventArgs) Handles lblUnidadeK.Click

    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click

        txtTemperatura.Clear()

        cmbTemperatura.SelectedIndex = 0

        lblValorC.Text = "--"
        lblValorF.Text = "--"
        lblValorK.Text = "--"

        txtTemperatura.Focus()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub lblValorC_Click(sender As Object, e As EventArgs) Handles lblValorC.Click

    End Sub

    Private Sub txtTemperatura_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTemperatura_Click(sender As Object, e As EventArgs) Handles txtTemperatura.Click

        txtTemperatura.Clear()

    End Sub

    Private Sub txtTemperatura_TextChanged_1(sender As Object, e As EventArgs) Handles txtTemperatura.TextChanged

    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click

        Me.Close()
    End Sub
End Class