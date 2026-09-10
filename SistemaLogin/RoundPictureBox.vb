Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundPictureBox
    Inherits PictureBox

    Private _borderRadius As Integer = 55

    Private _borderColor As Color = Color.White
    Private _borderSize As Integer = 3
    Private _enableGradient As Boolean = True
    Private _gradientColor1 As Color = Color.FromArgb(153, 51, 153)
    Private _gradientColor2 As Color = Color.FromArgb(153, 102, 204)

    <Category("Appearance")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property EnableGradient As Boolean
        Get
            Return _enableGradient
        End Get
        Set(value As Boolean)
            _enableGradient = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property GradientColor1 As Color
        Get
            Return _gradientColor1
        End Get
        Set(value As Color)
            _gradientColor1 = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property GradientColor2 As Color
        Get
            Return _gradientColor2
        End Get
        Set(value As Color)
            _gradientColor2 = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.SizeMode = PictureBoxSizeMode.StretchImage
        Me.BackColor = Color.Transparent
        Me.Width = 150
        Me.Height = 150
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Using gp = CriarBorda(New Rectangle(0, 0, Width - 1, Height - 1), BorderRadius)
            Me.Region = New Region(gp)
        End Using
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality

        Dim rect As New Rectangle(0, 0, Width - 1, Height - 1)

        If _enableGradient Then
            Using brush As New LinearGradientBrush(rect, _gradientColor1, _gradientColor2, 45)
                e.Graphics.FillPath(brush, CriarBorda(rect, BorderRadius))
            End Using
        End If

        If Me.Image IsNot Nothing Then
            Using imageBrush As New TextureBrush(Me.Image)
                e.Graphics.FillPath(imageBrush, CriarBorda(rect, BorderRadius))
            End Using
        End If

        If BorderSize > 0 Then
            Using p As New Pen(BorderColor, BorderSize)
                e.Graphics.DrawPath(p, CriarBorda(rect, BorderRadius))
            End Using
        End If
    End Sub

    Private Function CriarBorda(rect As Rectangle, raio As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        Dim r As Integer = raio

        path.AddArc(rect.X, rect.Y, r, r, 180, 90)
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)

        path.CloseFigure()
        Return path
    End Function

End Class