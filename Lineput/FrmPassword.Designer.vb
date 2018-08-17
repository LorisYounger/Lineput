<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPassword
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPassword))
        Me.LabelT1 = New System.Windows.Forms.Label()
        Me.Buttonpath = New System.Windows.Forms.Button()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.LabelT2 = New System.Windows.Forms.Label()
        Me.TextBoxpath = New System.Windows.Forms.TextBox()
        Me.Buttoncode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelT1
        '
        Me.LabelT1.AutoSize = True
        Me.LabelT1.Font = New System.Drawing.Font("宋体", 25.0!)
        Me.LabelT1.Location = New System.Drawing.Point(6, 0)
        Me.LabelT1.Name = "LabelT1"
        Me.LabelT1.Size = New System.Drawing.Size(270, 34)
        Me.LabelT1.TabIndex = 0
        Me.LabelT1.Text = "LPT文档加密工具" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Buttonpath
        '
        Me.Buttonpath.BackColor = System.Drawing.Color.Gainsboro
        Me.Buttonpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonpath.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Buttonpath.Location = New System.Drawing.Point(6, 37)
        Me.Buttonpath.Name = "Buttonpath"
        Me.Buttonpath.Size = New System.Drawing.Size(264, 41)
        Me.Buttonpath.TabIndex = 1
        Me.Buttonpath.Text = "选择LPT文件位置"
        Me.Buttonpath.UseVisualStyleBackColor = False
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBoxpassword.Location = New System.Drawing.Point(94, 111)
        Me.TextBoxpassword.MaxLength = 6
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.Size = New System.Drawing.Size(55, 26)
        Me.TextBoxpassword.TabIndex = 3
        Me.TextBoxpassword.Text = "1236"
        '
        'LabelT2
        '
        Me.LabelT2.AutoSize = True
        Me.LabelT2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.LabelT2.Location = New System.Drawing.Point(8, 84)
        Me.LabelT2.Name = "LabelT2"
        Me.LabelT2.Size = New System.Drawing.Size(280, 48)
        Me.LabelT2.TabIndex = 4
        Me.LabelT2.Text = "文件位置:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "设置密码:         (最长六位数数字)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBoxpath
        '
        Me.TextBoxpath.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBoxpath.Location = New System.Drawing.Point(94, 80)
        Me.TextBoxpath.MaxLength = 6
        Me.TextBoxpath.Name = "TextBoxpath"
        Me.TextBoxpath.Size = New System.Drawing.Size(176, 26)
        Me.TextBoxpath.TabIndex = 5
        '
        'Buttoncode
        '
        Me.Buttoncode.BackColor = System.Drawing.Color.LightGray
        Me.Buttoncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttoncode.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Buttoncode.Location = New System.Drawing.Point(6, 154)
        Me.Buttoncode.Name = "Buttoncode"
        Me.Buttoncode.Size = New System.Drawing.Size(264, 41)
        Me.Buttoncode.TabIndex = 6
        Me.Buttoncode.Text = "开始加密"
        Me.Buttoncode.UseVisualStyleBackColor = False
        '
        'FrmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 207)
        Me.Controls.Add(Me.Buttoncode)
        Me.Controls.Add(Me.TextBoxpath)
        Me.Controls.Add(Me.TextBoxpassword)
        Me.Controls.Add(Me.Buttonpath)
        Me.Controls.Add(Me.LabelT1)
        Me.Controls.Add(Me.LabelT2)
        Me.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LPT文档加密"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelT1 As System.Windows.Forms.Label
    Friend WithEvents Buttonpath As System.Windows.Forms.Button
    Friend WithEvents TextBoxpassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelT2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxpath As System.Windows.Forms.TextBox
    Friend WithEvents Buttoncode As System.Windows.Forms.Button
End Class
