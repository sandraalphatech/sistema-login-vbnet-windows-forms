

Public Class Form1
    Private numero1 As Double = 0
    Private numero2 As Double = 0
    Private operacao As String = ""
    Private expressao As String = ""

    Private Sub DigitarNumero(numero As String)

        If expressao = "" Then

            txtDisplay.Text = numero

        Else

            txtDisplay.Text &= numero

        End If
        expressao &= numero

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        txtDisplay.Text = "0"
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DigitarNumero("7")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DigitarNumero("6")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DigitarNumero("9")
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        DigitarNumero("0")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DigitarNumero("8")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DigitarNumero("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DigitarNumero("5")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        DigitarNumero("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DigitarNumero("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DigitarNumero("3")
    End Sub

    Private Sub IniciarOperacao(simbolo As String)
        numero1 = CDbl(txtDisplay.Text)

        If expressao = "" Then
            expressao = txtDisplay.Text
        End If

        operacao = simbolo
        expressao &= simbolo
        txtDisplay.Text = expressao

    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        IniciarOperacao("+")
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        IniciarOperacao("x")
    End Sub

    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        IniciarOperacao("-")
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        IniciarOperacao("÷")
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        Dim posicaoOperador As Integer = expressao.LastIndexOf(operacao)
        numero2 = CDbl(expressao.Substring(posicaoOperador + 1))

        Select Case operacao
            Case "+"
                txtDisplay.Text = (numero1 + numero2).ToString()
                expressao = ""

            Case "-"
                txtDisplay.Text = (numero1 - numero2).ToString()
                expressao = ""

            Case "x"
                txtDisplay.Text = (numero1 * numero2).ToString()
                expressao = ""

            Case "÷"
                If numero2 = 0 Then
                    MessageBox.Show("Não é possivel dividir por zero.")

                Else
                    txtDisplay.Text = (numero1 / numero2).ToString()
                    expressao = ""
                End If

        End Select
    End Sub


    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        txtDisplay.Text = "0"

        numero1 = 0
        numero2 = 0
        operacao = ""
        expressao = ""
    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        Dim posOp As Integer = -1
        For Each s As String In New String() {"+", "-", "x", "÷"}
            Dim p As Integer = expressao.LastIndexOf(s)
            If p > posOp Then posOp = p
        Next

        If posOp = -1 Then
            txtDisplay.Text = "0"
            expressao = ""
            numero1 = 0
        Else
            expressao = expressao.Substring(0, posOp + 1)
            txtDisplay.Text = expressao
        End If

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonArrow.Click
        If expressao.Length > 1 Then
            expressao = expressao.Substring(0, expressao.Length - 1)
            txtDisplay.Text = expressao
            If Not expressao.Contains("+") AndAlso Not expressao.Contains("-") AndAlso
               Not expressao.Contains("x") AndAlso Not expressao.Contains("÷") Then
                operacao = ""
                numero1 = 0
            End If
        Else
            txtDisplay.Text = "0"
            expressao = ""
            operacao = ""
            numero1 = 0
        End If

    End Sub

    Private Function OperandoAtual() As String
        Dim ultimaPosicao As Integer = -1

        For Each simbolo As String In New String() {"+", "-", "x", "÷"}
            Dim posicao As Integer = txtDisplay.Text.LastIndexOf(simbolo)
            If posicao > ultimaPosicao Then
                ultimaPosicao = posicao
            End If
        Next

        Return txtDisplay.Text.Substring(ultimaPosicao + 1)

    End Function

    Private Sub ButtonComma_Click(sender As Object, e As EventArgs) Handles ButtonComma.Click
        If Not OperandoAtual().Contains(",") Then
            txtDisplay.Text &= ","
            expressao &= ","
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub

    Private Sub RoundPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundPanel1.Paint

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
