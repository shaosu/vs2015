<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Tout = New System.Windows.Forms.TextBox()
        Me.ComboxCom = New System.Windows.Forms.ComboBox()
        Me.Spt1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Spt2 = New System.IO.Ports.SerialPort(Me.components)
        Me.CbxRate = New System.Windows.Forms.ComboBox()
        Me.BtOpen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtSend = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.UcT11 = New WUDGC.UCT1()
        Me.SuspendLayout()
        '
        'Tout
        '
        Me.Tout.Location = New System.Drawing.Point(12, 12)
        Me.Tout.Multiline = True
        Me.Tout.Name = "Tout"
        Me.Tout.Size = New System.Drawing.Size(338, 237)
        Me.Tout.TabIndex = 0
        '
        'ComboxCom
        '
        Me.ComboxCom.FormattingEnabled = True
        Me.ComboxCom.Location = New System.Drawing.Point(356, 12)
        Me.ComboxCom.Name = "ComboxCom"
        Me.ComboxCom.Size = New System.Drawing.Size(134, 20)
        Me.ComboxCom.TabIndex = 1
        '
        'Spt2
        '
        '
        'CbxRate
        '
        Me.CbxRate.FormattingEnabled = True
        Me.CbxRate.Location = New System.Drawing.Point(508, 12)
        Me.CbxRate.Name = "CbxRate"
        Me.CbxRate.Size = New System.Drawing.Size(129, 20)
        Me.CbxRate.TabIndex = 2
        '
        'BtOpen
        '
        Me.BtOpen.Location = New System.Drawing.Point(66, 282)
        Me.BtOpen.Name = "BtOpen"
        Me.BtOpen.Size = New System.Drawing.Size(109, 46)
        Me.BtOpen.TabIndex = 3
        Me.BtOpen.Text = "open"
        Me.BtOpen.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(308, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 42)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtSend
        '
        Me.TxtSend.Location = New System.Drawing.Point(12, 255)
        Me.TxtSend.Name = "TxtSend"
        Me.TxtSend.Size = New System.Drawing.Size(260, 21)
        Me.TxtSend.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(417, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 42)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'UcT11
        '
        Me.UcT11.Location = New System.Drawing.Point(394, 63)
        Me.UcT11.Name = "UcT11"
        Me.UcT11.Size = New System.Drawing.Size(406, 212)
        Me.UcT11.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 462)
        Me.Controls.Add(Me.UcT11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TxtSend)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtOpen)
        Me.Controls.Add(Me.CbxRate)
        Me.Controls.Add(Me.ComboxCom)
        Me.Controls.Add(Me.Tout)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tout As TextBox
    Friend WithEvents ComboxCom As ComboBox
    Friend WithEvents Spt1 As IO.Ports.SerialPort
    Friend WithEvents Spt2 As IO.Ports.SerialPort
    Friend WithEvents CbxRate As ComboBox
    Friend WithEvents BtOpen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtSend As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents UcT11 As WUDGC.UCT1
End Class
