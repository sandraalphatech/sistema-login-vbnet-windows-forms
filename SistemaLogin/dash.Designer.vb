<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dash
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlLogin = New SistemaLogin.RoundPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalc = New SistemaLogin.RoundButton()
        Me.RoundPictureBox1 = New SistemaLogin.RoundPictureBox()
        Me.RoundButton1 = New SistemaLogin.RoundButton()
        Me.btn = New SistemaLogin.RoundButton()
        Me.pnlLogin.SuspendLayout()
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLogin.AutoScroll = True
        Me.pnlLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.pnlLogin.BorderColor = System.Drawing.Color.White
        Me.pnlLogin.BorderRadius = 40
        Me.pnlLogin.BorderSize = 1
        Me.pnlLogin.Controls.Add(Me.Label4)
        Me.pnlLogin.Controls.Add(Me.Label3)
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Controls.Add(Me.lblCargo)
        Me.pnlLogin.Controls.Add(Me.lblNome)
        Me.pnlLogin.Controls.Add(Me.Panel2)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Controls.Add(Me.btnCalc)
        Me.pnlLogin.Controls.Add(Me.RoundPictureBox1)
        Me.pnlLogin.Controls.Add(Me.RoundButton1)
        Me.pnlLogin.Controls.Add(Me.btn)
        Me.pnlLogin.Inset = False
        Me.pnlLogin.Location = New System.Drawing.Point(29, 27)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.ShowShadow = True
        Me.pnlLogin.Size = New System.Drawing.Size(446, 691)
        Me.pnlLogin.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(104, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Estudante"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(104, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "João Silva"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(178, 628)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Versão 1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sandra© - 2026"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblCargo.Location = New System.Drawing.Point(165, 197)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(0, 21)
        Me.lblCargo.TabIndex = 15
        Me.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblNome.Location = New System.Drawing.Point(176, 173)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(0, 25)
        Me.lblNome.TabIndex = 14
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(104, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 2)
        Me.Panel2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(158, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(102, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "O que deseja fazer hoje?"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnCalc.BorderRadius = 22
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.White
        Me.btnCalc.Location = New System.Drawing.Point(105, 301)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(230, 65)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "CALCULADORA"
        '
        'RoundPictureBox1
        '
        Me.RoundPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.RoundPictureBox1.BorderColor = System.Drawing.Color.White
        Me.RoundPictureBox1.BorderRadius = 100
        Me.RoundPictureBox1.BorderSize = 3
        Me.RoundPictureBox1.EnableGradient = False
        Me.RoundPictureBox1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.RoundPictureBox1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.RoundPictureBox1.Image = Global.SistemaLogin.My.Resources.Resources.ftadmin
        Me.RoundPictureBox1.Location = New System.Drawing.Point(176, 62)
        Me.RoundPictureBox1.Name = "RoundPictureBox1"
        Me.RoundPictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.RoundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RoundPictureBox1.TabIndex = 2
        Me.RoundPictureBox1.TabStop = False
        '
        'RoundButton1
        '
        Me.RoundButton1.AllowDrop = True
        Me.RoundButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.RoundButton1.BorderRadius = 22
        Me.RoundButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RoundButton1.ForeColor = System.Drawing.Color.White
        Me.RoundButton1.Location = New System.Drawing.Point(104, 493)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(230, 65)
        Me.RoundButton1.TabIndex = 12
        Me.RoundButton1.Text = "SAIR"
        '
        'btn
        '
        Me.btn.AllowDrop = True
        Me.btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btn.BorderRadius = 22
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn.ForeColor = System.Drawing.Color.White
        Me.btn.Location = New System.Drawing.Point(104, 385)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(230, 65)
        Me.btn.TabIndex = 10
        Me.btn.Text = "CONVERSOR"
        '
        'Dash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 741)
        Me.Controls.Add(Me.pnlLogin)
        Me.Name = "Dash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dash"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLogin As RoundPanel
    Friend WithEvents btnCalc As RoundButton
    Friend WithEvents RoundPictureBox1 As RoundPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn As RoundButton
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNome As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
