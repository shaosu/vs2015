<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCT
    Inherits System.Windows.Forms.UserControl

    'UserControl1 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Lx = New System.Windows.Forms.Label()
        Me.Ly = New System.Windows.Forms.Label()
        Me.Lydw = New System.Windows.Forms.Label()
        Me.Lxdw = New System.Windows.Forms.Label()
        Me.Ld = New System.Windows.Forms.Label()
        Me.Lt = New System.Windows.Forms.Label()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pic.Location = New System.Drawing.Point(135, 67)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(369, 178)
        Me.Pic.TabIndex = 0
        Me.Pic.TabStop = False
        '
        'Lx
        '
        Me.Lx.AutoSize = True
        Me.Lx.Location = New System.Drawing.Point(154, 248)
        Me.Lx.Name = "Lx"
        Me.Lx.Size = New System.Drawing.Size(17, 12)
        Me.Lx.TabIndex = 1
        Me.Lx.Text = "Lx"
        '
        'Ly
        '
        Me.Ly.AutoSize = True
        Me.Ly.Location = New System.Drawing.Point(79, 210)
        Me.Ly.Name = "Ly"
        Me.Ly.Size = New System.Drawing.Size(17, 12)
        Me.Ly.TabIndex = 2
        Me.Ly.Text = "Ly"
        '
        'Lydw
        '
        Me.Lydw.AutoSize = True
        Me.Lydw.Location = New System.Drawing.Point(57, 49)
        Me.Lydw.Name = "Lydw"
        Me.Lydw.Size = New System.Drawing.Size(29, 12)
        Me.Lydw.TabIndex = 3
        Me.Lydw.Text = "Lydw"
        '
        'Lxdw
        '
        Me.Lxdw.AutoSize = True
        Me.Lxdw.Location = New System.Drawing.Point(525, 233)
        Me.Lxdw.Name = "Lxdw"
        Me.Lxdw.Size = New System.Drawing.Size(29, 12)
        Me.Lxdw.TabIndex = 4
        Me.Lxdw.Text = "Lxdw"
        '
        'Ld
        '
        Me.Ld.AutoSize = True
        Me.Ld.Location = New System.Drawing.Point(517, 49)
        Me.Ld.Name = "Ld"
        Me.Ld.Size = New System.Drawing.Size(17, 12)
        Me.Ld.TabIndex = 5
        Me.Ld.Text = "Ld"
        '
        'Lt
        '
        Me.Lt.AutoSize = True
        Me.Lt.Location = New System.Drawing.Point(263, 33)
        Me.Lt.Name = "Lt"
        Me.Lt.Size = New System.Drawing.Size(17, 12)
        Me.Lt.TabIndex = 6
        Me.Lt.Text = "Lt"
        '
        'UCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Lt)
        Me.Controls.Add(Me.Ld)
        Me.Controls.Add(Me.Lxdw)
        Me.Controls.Add(Me.Lydw)
        Me.Controls.Add(Me.Ly)
        Me.Controls.Add(Me.Lx)
        Me.Controls.Add(Me.Pic)
        Me.Name = "UCT"
        Me.Size = New System.Drawing.Size(647, 322)
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic As PictureBox
    Friend WithEvents Lx As Label
    Friend WithEvents Ly As Label
    Friend WithEvents Lydw As Label
    Friend WithEvents Lxdw As Label
    Friend WithEvents Ld As Label
    Friend WithEvents Lt As Label
End Class
