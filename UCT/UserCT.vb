Public Class UCT
    Private LABW As Integer = 40
    Private LABH As Integer = 15
    Private BDGC As Color = Color.Green
    Public XLnum As Integer = 10
    Public YLnum As Integer = 10
    Public XLab(XLnum - 1) As Label
    Public YLab(XLnum - 1) As Label
    Dim bmp As Bitmap
    Private Sub UCT1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicInit()
        LabBaseInit()
        BDGInit()
        Init(True)

    End Sub
    Private Sub UCT1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PicInit()
        LabBaseInit()
        BDGInit()
        Init(False)

    End Sub
    Private Sub PicInit()
        Pic.Width = Me.Width - 2 * LABW
        Pic.Height = Me.Height - 3 * LABH
        Pic.Left = LABW
        Pic.Top = LABH * 2
    End Sub
    Private Sub LabBaseInit()

        Lx.AutoSize = Ly.AutoSize = Lxdw.AutoSize = Lydw.AutoSize = Lt.AutoSize = Ld.AutoSize = False
        Lx.Width = Ly.Width = Lxdw.Width = Lydw.Width = Ld.Width = Lt.Width = LABW
        Lx.Height = Ly.Height = Lxdw.Height = Lydw.Height = Ld.Height = Lt.Height = LABH
        Ly.Top = Pic.Top + Pic.Height - LABH
        Ly.Left = 0
        Lydw.Left = 0
        Lydw.Top = Pic.Top - LABH * 1.5

        Lx.Left = Pic.Left
        Lx.Top = Pic.Top + Pic.Height
        Lx.TextAlign = ContentAlignment.BottomRight
        Lxdw.Left = Pic.Left + Pic.Width + LABW / 2
        Lxdw.Top = Pic.Top + Pic.Height
        Lxdw.TextAlign = ContentAlignment.BottomRight

        Ld.Left = Pic.Left + Pic.Width
        Ld.Top = Pic.Top - LABH

        Lt.Left = Pic.Left + Pic.Width / 2
        Lt.Top = Pic.Top - LABH

    End Sub
    Private Sub BDGInit()
        Dim grap As Graphics

        bmp = New Bitmap(Pic.Width, Pic.Height)

        Pic.Image = bmp
        grap = Graphics.FromImage(Pic.Image)
        Dim pen As New Pen(BDGC)
        '水平线
        Dim picW As Long = Pic.Width
        Dim picH As Long = Pic.Height
        Dim p1, p2 As Point
        For i = 0 To YLnum
            p1.X = 0
            p1.Y = i * picH / YLnum
            p2.X = picW
            p2.Y = i * picH / YLnum
            grap.DrawLine(pen, p1, p2)
        Next
        '画竖直线
        For i = 0 To XLnum - 1
            p1.X = i * picW / XLnum
            p1.Y = 0
            p2.X = i * picW / XLnum
            p2.Y = picH
            grap.DrawLine(pen, p1, p2)
        Next
        grap.Dispose()
        pen.Dispose()

        Pic.Refresh()
    End Sub
    Private Sub Init(ByVal LNewL As Boolean)
        'X坐标标签

        For i = 0 To XLnum - 1
            If IsNothing(XLab(i)) Then
                XLab(i) = New Label
                Me.Controls.Add(XLab(i))
            End If
            XLab(i).Height = LABH
            XLab(i).Width = LABW
            XLab(i).Top = Lx.Top
            XLab(i).Left = Lx.Left + (i + 1) * Pic.Width / XLnum - LABW / 2
            XLab(i).Text = (i + 1) * 10
            XLab(i).Visible = True
            XLab(i).TextAlign = ContentAlignment.BottomCenter
        Next
        'Y坐标标签

        For i = 0 To YLnum - 1
            If IsNothing(YLab(i)) Then
                YLab(i) = New Label
                Me.Controls.Add(YLab(i))
            End If
            YLab(i).Height = LABH
            YLab(i).Width = LABW
            YLab(i).Left = Ly.Left
            YLab(i).Top = Ly.Top - (i + 1) * Pic.Height / YLnum + LABH / 2
            YLab(i).Text = (i + 1) * 10
            YLab(i).Visible = True
            YLab(i).TextAlign = ContentAlignment.BottomRight
        Next


    End Sub
    Public Sub DGL(ByVal pen As Pen, ByVal p1 As Point, ByVal p2 As Point)
        Dim grap As Graphics
        If IsNothing(bmp) Then
            bmp = New Bitmap(Pic.Width, Pic.Height)
        End If


        grap = Graphics.FromImage(Pic.Image)
        'pen.Color = Color.Red

        grap.DrawLine(pen, p1, p2）
        grap.Dispose()
        bmp = Pic.Image
        Pic.Refresh()



    End Sub
End Class
