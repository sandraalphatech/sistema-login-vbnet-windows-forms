Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundButton
    Inherits Control

    Private _borderRadius As Integer = 22
    Private _corNormal As Color = Color.FromArgb(243, 225, 236)
    Private _emClique As Boolean = False

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            If Not _emClique Then
                _corNormal = value
            End If
        End Set
    End Property

    <Category("Appearance")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Invalidate()
        End Set
    End Property

    Public Sub New()

        DoubleBuffered = True

        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)

        BackColor = Color.FromArgb(243, 225, 236)
        ForeColor = Color.FromArgb(70, 70, 70)
        Font = New Font("Segoe UI Semibold", 22, FontStyle.Bold)

        Size = New Size(74, 74)

    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)

        MyBase.OnResize(e)

        Using gp = CriarBorda(New Rectangle(0, 0, Width - 1, Height - 1), BorderRadius)
            Region = New Region(gp)
        End Using

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.Clear(Parent.BackColor)

        Dim sombraOffset As Integer = 3

        Dim rect As New Rectangle(1, 1, Width - 2, Height - 2 - sombraOffset)

        Using sb As New SolidBrush(Color.FromArgb(255, 245, 240, 245))

            e.Graphics.FillPath(
                sb,
                CriarBorda(
                    New Rectangle(0, 0, Width - 1, Height - 1),
                    BorderRadius))

        End Using

        Dim camadas As Integer = 5

        For i As Integer = camadas To 1 Step -1

            Dim alpha As Integer = CInt(10 * (i / camadas))

            Using sb As New SolidBrush(Color.FromArgb(alpha, 226, 218, 226))

                e.Graphics.FillPath(
                    sb,
                    CriarBorda(
                        New Rectangle(0, i, Width - 1, Height - 1),
                        BorderRadius))

            End Using

        Next

        Using sb As New SolidBrush(BackColor)

            e.Graphics.FillPath(
                sb,
                CriarBorda(rect, BorderRadius))

        End Using

        Using p As New Pen(Color.FromArgb(40, 90, 88, 92), 1)

            e.Graphics.DrawPath(
                p,
                CriarBorda(rect, BorderRadius))

        End Using

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            rect,
            ForeColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPadding)

    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        _emClique = True
        BackColor = Escurecer(_corNormal, 18)
        Invalidate()
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        _emClique = False
        BackColor = _corNormal
        Invalidate()
        MyBase.OnMouseUp(e)
    End Sub

    Private Function Escurecer(cor As Color, quantidade As Integer) As Color

        Dim r As Integer = Math.Max(0, cor.R - quantidade)
        Dim g As Integer = Math.Max(0, cor.G - quantidade)
        Dim b As Integer = Math.Max(0, cor.B - quantidade)

        Return Color.FromArgb(cor.A, r, g, b)

    End Function

    Private Function CriarBorda(rect As Rectangle, raio As Integer) As GraphicsPath

        Dim gp As New GraphicsPath()

        gp.AddArc(rect.X, rect.Y, raio, raio, 180, 90)
        gp.AddArc(rect.Right - raio, rect.Y, raio, raio, 270, 90)
        gp.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90)
        gp.AddArc(rect.X, rect.Bottom - raio, raio, raio, 90, 90)

        gp.CloseFigure()

        Return gp

    End Function

End Class