Public Class Dash

    Public Nome As String
    Public Cargo As String
    Public Foto As Image

    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Text = Nome
        Label4.Text = Cargo
        RoundPictureBox1.Image = Foto

    End Sub

    Private Sub RoundPictureBox1_Click(sender As Object, e As EventArgs) Handles RoundPictureBox1.Click

    End Sub

    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub

    Private Sub RoundButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Hide()

        Dim frm As New Conversor()
        frm.ShowDialog()

        Me.Show()

    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Me.Hide()

        Dim frm As New Form1()
        frm.ShowDialog()

        Me.Show()

    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click

        Dim frm As New login
        frm.Show()
        Me.Close()

    End Sub

End Class