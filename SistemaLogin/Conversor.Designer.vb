<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlLogin = New SistemaLogin.RoundPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RoundButton1 = New SistemaLogin.RoundButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoundPanel1 = New SistemaLogin.RoundPanel()
        Me.pnlF = New SistemaLogin.RoundPanel()
        Me.lblTituloF = New System.Windows.Forms.Label()
        Me.lblValorF = New System.Windows.Forms.Label()
        Me.lblUnidadeF = New System.Windows.Forms.Label()
        Me.pnlK = New SistemaLogin.RoundPanel()
        Me.lblUnidadeK = New System.Windows.Forms.Label()
        Me.lblValorK = New System.Windows.Forms.Label()
        Me.lblTituloK = New System.Windows.Forms.Label()
        Me.btnClean = New SistemaLogin.RoundButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTemperatura = New System.Windows.Forms.ComboBox()
        Me.btnConverter = New SistemaLogin.RoundButton()
        Me.Display = New SistemaLogin.RoundPanel()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New SistemaLogin.RoundButton()
        Me.pnlC = New SistemaLogin.RoundPanel()
        Me.lblUnidadeC = New System.Windows.Forms.Label()
        Me.lblValorC = New System.Windows.Forms.Label()
        Me.lblTituloC = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlLogin.SuspendLayout()
        Me.RoundPanel1.SuspendLayout()
        Me.pnlF.SuspendLayout()
        Me.pnlK.SuspendLayout()
        Me.Display.SuspendLayout()
        Me.pnlC.SuspendLayout()
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
        Me.pnlLogin.Controls.Add(Me.RoundButton1)
        Me.pnlLogin.Controls.Add(Me.lblTitulo)
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Controls.Add(Me.RoundPanel1)
        Me.pnlLogin.Controls.Add(Me.lblCargo)
        Me.pnlLogin.Controls.Add(Me.lblNome)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Inset = False
        Me.pnlLogin.Location = New System.Drawing.Point(29, 25)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.ShowShadow = True
        Me.pnlLogin.Size = New System.Drawing.Size(446, 691)
        Me.pnlLogin.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(178, 628)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Versão 1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sandra© - 2026"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundButton1
        '
        Me.RoundButton1.AllowDrop = True
        Me.RoundButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.RoundButton1.BorderRadius = 22
        Me.RoundButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RoundButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.RoundButton1.Location = New System.Drawing.Point(29, 33)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(76, 32)
        Me.RoundButton1.TabIndex = 38
        Me.RoundButton1.Text = "Voltar"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(153, 45)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(124, 32)
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "Conversor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(175, 642)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundPanel1
        '
        Me.RoundPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.RoundPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RoundPanel1.BorderRadius = 28
        Me.RoundPanel1.BorderSize = 2
        Me.RoundPanel1.Controls.Add(Me.pnlF)
        Me.RoundPanel1.Controls.Add(Me.pnlK)
        Me.RoundPanel1.Controls.Add(Me.btnClean)
        Me.RoundPanel1.Controls.Add(Me.Label3)
        Me.RoundPanel1.Controls.Add(Me.Label1)
        Me.RoundPanel1.Controls.Add(Me.cmbTemperatura)
        Me.RoundPanel1.Controls.Add(Me.btnConverter)
        Me.RoundPanel1.Controls.Add(Me.Display)
        Me.RoundPanel1.Controls.Add(Me.btnVoltar)
        Me.RoundPanel1.Controls.Add(Me.pnlC)
        Me.RoundPanel1.Inset = False
        Me.RoundPanel1.Location = New System.Drawing.Point(46, 100)
        Me.RoundPanel1.Name = "RoundPanel1"
        Me.RoundPanel1.ShowShadow = True
        Me.RoundPanel1.Size = New System.Drawing.Size(341, 500)
        Me.RoundPanel1.TabIndex = 3
        '
        'pnlF
        '
        Me.pnlF.BackColor = System.Drawing.Color.White
        Me.pnlF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlF.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.pnlF.BorderRadius = 10
        Me.pnlF.BorderSize = 3
        Me.pnlF.Controls.Add(Me.lblTituloF)
        Me.pnlF.Controls.Add(Me.lblValorF)
        Me.pnlF.Controls.Add(Me.lblUnidadeF)
        Me.pnlF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pnlF.Inset = True
        Me.pnlF.Location = New System.Drawing.Point(126, 276)
        Me.pnlF.Name = "pnlF"
        Me.pnlF.ShowShadow = False
        Me.pnlF.Size = New System.Drawing.Size(90, 120)
        Me.pnlF.TabIndex = 33
        '
        'lblTituloF
        '
        Me.lblTituloF.AutoSize = True
        Me.lblTituloF.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblTituloF.Location = New System.Drawing.Point(24, 11)
        Me.lblTituloF.Name = "lblTituloF"
        Me.lblTituloF.Size = New System.Drawing.Size(40, 17)
        Me.lblTituloF.TabIndex = 1
        Me.lblTituloF.Text = "🌡️ºF"
        '
        'lblValorF
        '
        Me.lblValorF.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblValorF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblValorF.Location = New System.Drawing.Point(4, 38)
        Me.lblValorF.Name = "lblValorF"
        Me.lblValorF.Size = New System.Drawing.Size(83, 40)
        Me.lblValorF.TabIndex = 2
        Me.lblValorF.Text = "0"
        Me.lblValorF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnidadeF
        '
        Me.lblUnidadeF.AutoSize = True
        Me.lblUnidadeF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadeF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblUnidadeF.Location = New System.Drawing.Point(31, 78)
        Me.lblUnidadeF.Name = "lblUnidadeF"
        Me.lblUnidadeF.Size = New System.Drawing.Size(25, 21)
        Me.lblUnidadeF.TabIndex = 3
        Me.lblUnidadeF.Text = "ºF"
        Me.lblUnidadeF.UseMnemonic = False
        '
        'pnlK
        '
        Me.pnlK.BackColor = System.Drawing.Color.White
        Me.pnlK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlK.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.pnlK.BorderRadius = 10
        Me.pnlK.BorderSize = 3
        Me.pnlK.Controls.Add(Me.lblUnidadeK)
        Me.pnlK.Controls.Add(Me.lblValorK)
        Me.pnlK.Controls.Add(Me.lblTituloK)
        Me.pnlK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pnlK.Inset = True
        Me.pnlK.Location = New System.Drawing.Point(222, 276)
        Me.pnlK.Name = "pnlK"
        Me.pnlK.ShowShadow = False
        Me.pnlK.Size = New System.Drawing.Size(90, 120)
        Me.pnlK.TabIndex = 33
        '
        'lblUnidadeK
        '
        Me.lblUnidadeK.AutoSize = True
        Me.lblUnidadeK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadeK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblUnidadeK.Location = New System.Drawing.Point(34, 78)
        Me.lblUnidadeK.Name = "lblUnidadeK"
        Me.lblUnidadeK.Size = New System.Drawing.Size(19, 21)
        Me.lblUnidadeK.TabIndex = 4
        Me.lblUnidadeK.Text = "K"
        Me.lblUnidadeK.UseMnemonic = False
        '
        'lblValorK
        '
        Me.lblValorK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorK.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblValorK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblValorK.Location = New System.Drawing.Point(4, 38)
        Me.lblValorK.Name = "lblValorK"
        Me.lblValorK.Size = New System.Drawing.Size(84, 40)
        Me.lblValorK.TabIndex = 3
        Me.lblValorK.Text = "0"
        Me.lblValorK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTituloK
        '
        Me.lblTituloK.AutoSize = True
        Me.lblTituloK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblTituloK.Location = New System.Drawing.Point(25, 12)
        Me.lblTituloK.Name = "lblTituloK"
        Me.lblTituloK.Size = New System.Drawing.Size(39, 17)
        Me.lblTituloK.TabIndex = 2
        Me.lblTituloK.Text = "🔬 K"
        '
        'btnClean
        '
        Me.btnClean.AllowDrop = True
        Me.btnClean.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnClean.BorderRadius = 22
        Me.btnClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClean.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClean.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnClean.Location = New System.Drawing.Point(62, 421)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(201, 46)
        Me.btnClean.TabIndex = 37
        Me.btnClean.Text = "Limpar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(64, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Unidade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Temperatura"
        '
        'cmbTemperatura
        '
        Me.cmbTemperatura.BackColor = System.Drawing.Color.White
        Me.cmbTemperatura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTemperatura.DisplayMember = "Celsius"
        Me.cmbTemperatura.DropDownHeight = 160
        Me.cmbTemperatura.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbTemperatura.FormattingEnabled = True
        Me.cmbTemperatura.IntegralHeight = False
        Me.cmbTemperatura.ItemHeight = 21
        Me.cmbTemperatura.Items.AddRange(New Object() {"Celsius", " - ºC", "Fahrenheit - ºF", "Kelvin"})
        Me.cmbTemperatura.Location = New System.Drawing.Point(150, 117)
        Me.cmbTemperatura.MaxDropDownItems = 20
        Me.cmbTemperatura.MaxLength = 200
        Me.cmbTemperatura.Name = "cmbTemperatura"
        Me.cmbTemperatura.Size = New System.Drawing.Size(126, 29)
        Me.cmbTemperatura.TabIndex = 32
        '
        'btnConverter
        '
        Me.btnConverter.AllowDrop = True
        Me.btnConverter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConverter.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnConverter.BorderRadius = 20
        Me.btnConverter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConverter.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.btnConverter.ForeColor = System.Drawing.Color.White
        Me.btnConverter.Location = New System.Drawing.Point(44, 184)
        Me.btnConverter.Name = "btnConverter"
        Me.btnConverter.Size = New System.Drawing.Size(242, 51)
        Me.btnConverter.TabIndex = 14
        Me.btnConverter.Text = "Converter"
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.White
        Me.Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Display.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Display.BorderRadius = 10
        Me.Display.BorderSize = 3
        Me.Display.Controls.Add(Me.txtTemperatura)
        Me.Display.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Display.Inset = True
        Me.Display.Location = New System.Drawing.Point(152, 59)
        Me.Display.Name = "Display"
        Me.Display.ShowShadow = False
        Me.Display.Size = New System.Drawing.Size(124, 30)
        Me.Display.TabIndex = 31
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTemperatura.BackColor = System.Drawing.Color.White
        Me.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTemperatura.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTemperatura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtTemperatura.Location = New System.Drawing.Point(9, 4)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(102, 22)
        Me.txtTemperatura.TabIndex = 0
        Me.txtTemperatura.Text = "ex: 24"
        Me.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnVoltar.BorderRadius = 20
        Me.btnVoltar.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnVoltar.Location = New System.Drawing.Point(126, 546)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(100, 40)
        Me.btnVoltar.TabIndex = 13
        Me.btnVoltar.Text = "Voltar"
        '
        'pnlC
        '
        Me.pnlC.BackColor = System.Drawing.Color.White
        Me.pnlC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlC.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.pnlC.BorderRadius = 10
        Me.pnlC.BorderSize = 3
        Me.pnlC.Controls.Add(Me.lblUnidadeC)
        Me.pnlC.Controls.Add(Me.lblValorC)
        Me.pnlC.Controls.Add(Me.lblTituloC)
        Me.pnlC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pnlC.Inset = True
        Me.pnlC.Location = New System.Drawing.Point(30, 276)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.ShowShadow = False
        Me.pnlC.Size = New System.Drawing.Size(90, 120)
        Me.pnlC.TabIndex = 32
        '
        'lblUnidadeC
        '
        Me.lblUnidadeC.AutoSize = True
        Me.lblUnidadeC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadeC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblUnidadeC.Location = New System.Drawing.Point(30, 78)
        Me.lblUnidadeC.Name = "lblUnidadeC"
        Me.lblUnidadeC.Size = New System.Drawing.Size(27, 21)
        Me.lblUnidadeC.TabIndex = 2
        Me.lblUnidadeC.Text = "ºC"
        '
        'lblValorC
        '
        Me.lblValorC.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblValorC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblValorC.Location = New System.Drawing.Point(5, 38)
        Me.lblValorC.Name = "lblValorC"
        Me.lblValorC.Size = New System.Drawing.Size(82, 40)
        Me.lblValorC.TabIndex = 1
        Me.lblValorC.Text = "0"
        Me.lblValorC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTituloC
        '
        Me.lblTituloC.AutoSize = True
        Me.lblTituloC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblTituloC.Location = New System.Drawing.Point(21, 12)
        Me.lblTituloC.Name = "lblTituloC"
        Me.lblTituloC.Size = New System.Drawing.Size(45, 17)
        Me.lblTituloC.TabIndex = 0
        Me.lblTituloC.Text = "🌡️ ºC"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblCargo.Location = New System.Drawing.Point(117, 217)
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
        Me.lblNome.Location = New System.Drawing.Point(128, 193)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(0, 25)
        Me.lblNome.TabIndex = 14
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Conversor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 741)
        Me.Controls.Add(Me.pnlLogin)
        Me.Name = "Conversor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Converso"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.RoundPanel1.ResumeLayout(False)
        Me.RoundPanel1.PerformLayout()
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlK.ResumeLayout(False)
        Me.pnlK.PerformLayout()
        Me.Display.ResumeLayout(False)
        Me.Display.PerformLayout()
        Me.pnlC.ResumeLayout(False)
        Me.pnlC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLogin As RoundPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundPanel1 As RoundPanel
    Friend WithEvents btnVoltar As RoundButton
    Friend WithEvents btnConverter As RoundButton
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Display As RoundPanel
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents cmbTemperatura As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTituloF As Label
    Friend WithEvents lblTituloK As Label
    Friend WithEvents lblUnidadeF As Label
    Friend WithEvents lblValorF As Label
    Friend WithEvents lblUnidadeK As Label
    Friend WithEvents lblValorK As Label
    Friend WithEvents btnClean As RoundButton
    Friend WithEvents pnlC As RoundPanel
    Friend WithEvents lblUnidadeC As Label
    Friend WithEvents lblValorC As Label
    Friend WithEvents lblTituloC As Label
    Friend WithEvents pnlF As RoundPanel
    Friend WithEvents pnlK As RoundPanel
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Label4 As Label
End Class
