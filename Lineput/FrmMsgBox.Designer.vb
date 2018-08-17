<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMsgBox
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMsgBox))
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.字体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字体颜色DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景颜色ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.撤消UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.设置SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.移动ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示工具栏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景颜色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.记录板分身ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关闭ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文本操作ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.导入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为并清空ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为并导入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonRed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.EnableAutoDragDrop = True
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 55)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字体ToolStripMenuItem, Me.字体颜色DToolStripMenuItem, Me.背景颜色ToolStripMenuItem1, Me.ToolStripSeparator1, Me.撤消UToolStripMenuItem, Me.重复RToolStripMenuItem, Me.toolStripSeparator3, Me.剪切TToolStripMenuItem, Me.复制CToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.ToolStripMenuItem1, Me.toolStripSeparator4, Me.设置SToolStripMenuItem, Me.文本操作ToolStripMenuItem, Me.ToolStripSeparator2, Me.全选AToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(207, 388)
        '
        '字体ToolStripMenuItem
        '
        Me.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem"
        Me.字体ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.字体ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.字体ToolStripMenuItem.Text = "字体(&W)"
        '
        '字体颜色DToolStripMenuItem
        '
        Me.字体颜色DToolStripMenuItem.Name = "字体颜色DToolStripMenuItem"
        Me.字体颜色DToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.字体颜色DToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.字体颜色DToolStripMenuItem.Text = "字体颜色(&D)"
        '
        '背景颜色ToolStripMenuItem1
        '
        Me.背景颜色ToolStripMenuItem1.Name = "背景颜色ToolStripMenuItem1"
        Me.背景颜色ToolStripMenuItem1.Size = New System.Drawing.Size(206, 30)
        Me.背景颜色ToolStripMenuItem1.Text = "背景颜色"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        '撤消UToolStripMenuItem
        '
        Me.撤消UToolStripMenuItem.Image = CType(resources.GetObject("撤消UToolStripMenuItem.Image"), System.Drawing.Image)
        Me.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem"
        Me.撤消UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.撤消UToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.撤消UToolStripMenuItem.Text = "撤消(&U)"
        '
        '重复RToolStripMenuItem
        '
        Me.重复RToolStripMenuItem.Image = CType(resources.GetObject("重复RToolStripMenuItem.Image"), System.Drawing.Image)
        Me.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem"
        Me.重复RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.重复RToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.重复RToolStripMenuItem.Text = "重复(&R)"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(203, 6)
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Image = CType(resources.GetObject("剪切TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.剪切TToolStripMenuItem.Text = "剪切(&X)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Image = CType(resources.GetObject("复制CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Image = CType(resources.GetObject("粘贴PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&V)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(206, 30)
        Me.ToolStripMenuItem1.Text = "清空文本"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(203, 6)
        '
        '设置SToolStripMenuItem
        '
        Me.设置SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.移动ToolStripMenuItem, Me.显示工具栏ToolStripMenuItem, Me.背景颜色ToolStripMenuItem, Me.记录板分身ToolStripMenuItem, Me.关闭ToolStripMenuItem})
        Me.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem"
        Me.设置SToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.设置SToolStripMenuItem.Text = "设置"
        '
        '移动ToolStripMenuItem
        '
        Me.移动ToolStripMenuItem.Checked = True
        Me.移动ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.移动ToolStripMenuItem.Name = "移动ToolStripMenuItem"
        Me.移动ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.移动ToolStripMenuItem.Text = "可移动"
        '
        '显示工具栏ToolStripMenuItem
        '
        Me.显示工具栏ToolStripMenuItem.CheckOnClick = True
        Me.显示工具栏ToolStripMenuItem.Name = "显示工具栏ToolStripMenuItem"
        Me.显示工具栏ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.显示工具栏ToolStripMenuItem.Text = "显示工具栏"
        '
        '背景颜色ToolStripMenuItem
        '
        Me.背景颜色ToolStripMenuItem.Name = "背景颜色ToolStripMenuItem"
        Me.背景颜色ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.背景颜色ToolStripMenuItem.Text = "背景颜色"
        '
        '记录板分身ToolStripMenuItem
        '
        Me.记录板分身ToolStripMenuItem.Name = "记录板分身ToolStripMenuItem"
        Me.记录板分身ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.记录板分身ToolStripMenuItem.Text = "新文本框"
        '
        '关闭ToolStripMenuItem
        '
        Me.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem"
        Me.关闭ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.关闭ToolStripMenuItem.Text = "关闭"
        '
        '文本操作ToolStripMenuItem
        '
        Me.文本操作ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开OToolStripMenuItem, Me.保存SToolStripMenuItem, Me.导入ToolStripMenuItem, Me.另存为并清空ToolStripMenuItem, Me.另存为并导入ToolStripMenuItem})
        Me.文本操作ToolStripMenuItem.Name = "文本操作ToolStripMenuItem"
        Me.文本操作ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.文本操作ToolStripMenuItem.Text = "文本操作"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Image = CType(resources.GetObject("打开OToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.打开OToolStripMenuItem.Text = "打开"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Image = CType(resources.GetObject("保存SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.保存SToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.保存SToolStripMenuItem.MergeIndex = 3
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '导入ToolStripMenuItem
        '
        Me.导入ToolStripMenuItem.Image = CType(resources.GetObject("导入ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem"
        Me.导入ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.导入ToolStripMenuItem.Text = "导入"
        Me.导入ToolStripMenuItem.Visible = False
        '
        '另存为并清空ToolStripMenuItem
        '
        Me.另存为并清空ToolStripMenuItem.Image = CType(resources.GetObject("另存为并清空ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.另存为并清空ToolStripMenuItem.Name = "另存为并清空ToolStripMenuItem"
        Me.另存为并清空ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.另存为并清空ToolStripMenuItem.Text = "另存为并清空"
        '
        '另存为并导入ToolStripMenuItem
        '
        Me.另存为并导入ToolStripMenuItem.Image = CType(resources.GetObject("另存为并导入ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.另存为并导入ToolStripMenuItem.Name = "另存为并导入ToolStripMenuItem"
        Me.另存为并导入ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.另存为并导入ToolStripMenuItem.Text = "另存为并导入"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(203, 6)
        '
        '全选AToolStripMenuItem
        '
        Me.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem"
        Me.全选AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.全选AToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.全选AToolStripMenuItem.Text = "全选(&A)"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonRed, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.ToolStripButton12, Me.ToolStripSeparator8, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripButton11, Me.ToolStripButton10, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSeparator7, Me.ToolStripButton13})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(185, 21)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'ToolStripButtonRed
        '
        Me.ToolStripButtonRed.BackColor = System.Drawing.Color.Black
        Me.ToolStripButtonRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRed.Name = "ToolStripButtonRed"
        Me.ToolStripButtonRed.Size = New System.Drawing.Size(23, 18)
        Me.ToolStripButtonRed.Text = "Black"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Red
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 18)
        Me.ToolStripButton1.Text = "Red"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Green
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 18)
        Me.ToolStripButton2.Text = "Green"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 18)
        Me.ToolStripButton3.Text = "Yellow"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 18)
        Me.ToolStripButton4.Text = "DeepSkyBlue"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 21)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(28, 18)
        Me.ToolStripButton12.Text = "还原格式"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 21)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton8.Text = "字体加"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton9.Text = "字体减"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton11.Text = "字号12"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton10.Text = "字号9"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton5.Text = "加粗"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton6.Text = "斜体"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton7.Text = "下划线"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton13.Text = "切换"
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.FontDialog1.FontMustExist = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "rtf"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "RTF文件(*.rtf)|*.rtf|记录板格式(*.rb)|*.rb|文本文档(*.txt)|*.txt"
        Me.OpenFileDialog1.FilterIndex = 2
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "rtf"
        Me.SaveFileDialog1.Filter = "RTF文件(*.rtf)|*.rtf|记录板格式(*.rb)|*.rb|文本文档(*.txt)|*.txt"
        Me.SaveFileDialog1.FilterIndex = 2
        '
        'FrmMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(185, 55)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文本框"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonRed As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 字体ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 字体颜色DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 撤消UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重复RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 剪切TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 设置SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示工具栏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 背景颜色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 记录板分身ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 文本操作ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 导入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另存为并清空ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另存为并导入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 移动ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关闭ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents 背景颜色ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
