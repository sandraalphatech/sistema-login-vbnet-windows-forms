Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundPanel
    Inherits Panel

    Private _borderRadius As Integer = 28
    Private _borderColor As Color = Color.FromArgb(245, 238, 245)
    Private _borderSize As Integer = 2
    Private _showShadow As Boolean = True
    Private _inset As Boolean = False

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
    Public Property ShowShadow As Boolean
        Get
            Return _showShadow
        End Get
        Set(value As Boolean)
            _showShadow = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property Inset As Boolean
        Get
            Return _inset
        End Get
        Set(value As Boolean)
            _inset = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or
                 ControlStyles.OptimizedDoubleBuffer, True)
        BackColor = Color.FromArgb(255, 242, 236)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Using gp = CriarBorda(New Rectangle(0, 0, Width - 1, Height - 1), BorderRadius)
            Me.Region = New Region(gp)
        End Using
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.Clear(Parent.BackColor)

        Dim rect As Rectangle
        If _showShadow Then
            rect = New Rectangle(8, 8, Width - 16, Height - 16)
        Else
            rect = New Rectangle(0, 0, Width - 1, Height - 1)
        End If

        If _showShadow AndAlso Not _inset Then
            For i As Integer = 6 To 1 Step -1
                Using sb As New SolidBrush(Color.FromArgb(i * 5, 110, 110, 110))
                    e.Graphics.FillPath(
                        sb,
                        CriarBorda(
                            New Rectangle(rect.X + i, rect.Y + i, rect.Width, rect.Height),
                            BorderRadius))
                End Using
            Next
        End If

        Using sb As New SolidBrush(BackColor)
            e.Graphics.FillPath(sb, CriarBorda(rect, BorderRadius))
        End Using

        If _inset Then
            DesenharInset(e.Graphics, rect)
        Else
            DesenharRelevo(e.Graphics, rect)
        End If

        If BorderSize > 0 Then
            Using p As New Pen(BorderColor, BorderSize)
                e.Graphics.DrawPath(p, CriarBorda(rect, BorderRadius))
            End Using
        End If
    End Sub

    Private Sub DesenharInset(g As Graphics, rect As Rectangle)
        Dim folga As Integer = BorderRadius \ 2

        Using p As New Pen(Color.FromArgb(70, 120, 108, 118), 3)
            g.DrawLine(p, rect.Left + folga, rect.Top + 1, rect.Right - folga, rect.Top + 1)
            g.DrawLine(p, rect.Left + 1, rect.Top + folga, rect.Left + 1, rect.Bottom - folga)
        End Using

        Using p As New Pen(Color.FromArgb(150, Color.White), 2)
            g.DrawLine(p, rect.Left + folga, rect.Bottom - 1, rect.Right - folga, rect.Bottom - 1)
            g.DrawLine(p, rect.Right - 1, rect.Top + folga, rect.Right - 1, rect.Bottom - folga)
        End Using
    End Sub

    Private Sub DesenharRelevo(g As Graphics, rect As Rectangle)
        Using p As New Pen(Color.FromArgb(170, Color.White), 2)
            g.DrawPath(p, CriarBorda(rect, BorderRadius))
        End Using
    End Sub

    Private Function Clarear(cor As Color, quantidade As Integer) As Color
        Dim r As Integer = Math.Max(0, Math.Min(255, cor.R + quantidade))
        Dim g As Integer = Math.Max(0, Math.Min(255, cor.G + quantidade))
        Dim b As Integer = Math.Max(0, Math.Min(255, cor.B + quantidade))
        Return Color.FromArgb(cor.A, r, g, b)
    End Function

    Private Function CriarBorda(rect As Rectangle, raio As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, raio, raio, 180, 90)
        path.AddArc(rect.Right - raio, rect.Y, raio, raio, 270, 90)
        path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90)
        path.AddArc(rect.X, rect.Bottom - raio, raio, raio, 90, 90)
        path.CloseFigure()
        Return path
    End Function

End Class