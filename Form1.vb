Imports System.IO.Ports
Imports ChuanKou

Public Class Form1
    Dim D_i As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports As String()
        ports = SerialPort.GetPortNames
        Dim port As String
        For Each port In ports
            ComboxCom.Items.Add(port)
        Next
        CbxRate.Items.Add("115200")
        CbxRate.Items.Add("9600")
        ComboxCom.SelectedIndex = 0
        CbxRate.SelectedIndex = 0
        SptInit(Spt1, ComboxCom.Items(0))
        SptInit(Spt2, ComboxCom.Items(1))

        '’

    End Sub
    Private Sub SptInit(ByVal Spt As SerialPort, ByVal com As String)
        Spt.PortName = com
        Spt.BaudRate = CbxRate.SelectedItem
        Spt.DataBits = 8
        Spt.StopBits = IO.Ports.StopBits.One
        Spt.Parity = IO.Ports.Parity.None
        Spt.ReceivedBytesThreshold = 8

    End Sub

    Private Sub BtOpen_Click(sender As Object, e As EventArgs) Handles BtOpen.Click
        Try
            Spt1.Open()
            Spt2.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Spt1.Close()
            Spt2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'dd
        Send()
    End Sub

    Private Sub Send()

        Try
            If TxtSend.TextLength < 8 Then
                TxtSend.Text = TxtSend.Text.PadRight(8)
                Spt1.WriteLine(TxtSend.Text)
            ElseIf TxtSend.TextLength > 8 Then
                TxtSend.Text = Mid(TxtSend.Text, 1, 8)
                Spt1.WriteLine(TxtSend.Text)
            Else
                Spt1.WriteLine(TxtSend.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Spt_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Spt2.DataReceived
        Me.Invoke(New EventHandler(AddressOf Spt_receiving))
    End Sub

    Private Sub Spt_receiving(ByVal sender As Object, ByVal e As EventArgs)
        'Threading.Thread.Sleep(10)

        Tout.AppendText(Spt2.ReadLine & vbCrLf)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pen As Pen = Pens.Red
        Dim p1, p2, p3 As Point
        p1.X = 33
        p2.X = 55
        p3.X = 77
        p1.Y = 22
        p2.Y = 33
        p3.Y = 44
        D_i += 1
        If D_i = 1 Then
            Uct1.DGL(pen, p1, p2)
        Else
            Uct1.DGL(pen, p2, p3)
        End If

    End Sub
End Class
