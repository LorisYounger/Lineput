<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ButtonShowTool = New System.Windows.Forms.Button()
        Me.PanelTool = New System.Windows.Forms.Panel()
        Me.ButtonCW = New System.Windows.Forms.Button()
        Me.ButtonCB = New System.Windows.Forms.Button()
        Me.ButtonCR = New System.Windows.Forms.Button()
        Me.ButtonCG = New System.Windows.Forms.Button()
        Me.ButtonFS = New System.Windows.Forms.Button()
        Me.ButtonFB = New System.Windows.Forms.Button()
        Me.ButtonN = New System.Windows.Forms.Button()
        Me.ButtonF = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.字体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字体颜色DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.上一行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下一行NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.撤消UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.导入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.暂停运行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.只读ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.移动ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.审查元素ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.置于顶层TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示工具栏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景颜色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于LinePutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timerllcc = New System.Windows.Forms.Timer(Me.components)
        Me.TimerInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerNext = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPrinter = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonCloseElement = New System.Windows.Forms.Button()
        Me.ButtonGoSet = New System.Windows.Forms.Button()
        Me.ButtonRels = New System.Windows.Forms.Button()
        Me.TextBoxElement = New System.Windows.Forms.TextBox()
        Me.PanelTool.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonShowTool
        '
        Me.ButtonShowTool.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonShowTool.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonShowTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowTool.Location = New System.Drawing.Point(469, 371)
        Me.ButtonShowTool.Name = "ButtonShowTool"
        Me.ButtonShowTool.Size = New System.Drawing.Size(23, 23)
        Me.ButtonShowTool.TabIndex = 2
        Me.ButtonShowTool.UseVisualStyleBackColor = False
        '
        'PanelTool
        '
        Me.PanelTool.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTool.Controls.Add(Me.ButtonCW)
        Me.PanelTool.Controls.Add(Me.ButtonCB)
        Me.PanelTool.Controls.Add(Me.ButtonCR)
        Me.PanelTool.Controls.Add(Me.ButtonCG)
        Me.PanelTool.Controls.Add(Me.ButtonFS)
        Me.PanelTool.Controls.Add(Me.ButtonFB)
        Me.PanelTool.Controls.Add(Me.ButtonN)
        Me.PanelTool.Controls.Add(Me.ButtonF)
        Me.PanelTool.Location = New System.Drawing.Point(372, 271)
        Me.PanelTool.Name = "PanelTool"
        Me.PanelTool.Size = New System.Drawing.Size(120, 100)
        Me.PanelTool.TabIndex = 3
        Me.PanelTool.Visible = False
        '
        'ButtonCW
        '
        Me.ButtonCW.BackColor = System.Drawing.Color.White
        Me.ButtonCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCW.Location = New System.Drawing.Point(83, 73)
        Me.ButtonCW.Name = "ButtonCW"
        Me.ButtonCW.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCW.TabIndex = 7
        Me.ButtonCW.UseVisualStyleBackColor = False
        '
        'ButtonCB
        '
        Me.ButtonCB.BackColor = System.Drawing.Color.Black
        Me.ButtonCB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCB.Location = New System.Drawing.Point(83, 52)
        Me.ButtonCB.Name = "ButtonCB"
        Me.ButtonCB.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCB.TabIndex = 6
        Me.ButtonCB.UseVisualStyleBackColor = False
        '
        'ButtonCR
        '
        Me.ButtonCR.BackColor = System.Drawing.Color.Red
        Me.ButtonCR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCR.Location = New System.Drawing.Point(5, 73)
        Me.ButtonCR.Name = "ButtonCR"
        Me.ButtonCR.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCR.TabIndex = 5
        Me.ButtonCR.UseVisualStyleBackColor = False
        '
        'ButtonCG
        '
        Me.ButtonCG.BackColor = System.Drawing.Color.LimeGreen
        Me.ButtonCG.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCG.Location = New System.Drawing.Point(5, 52)
        Me.ButtonCG.Name = "ButtonCG"
        Me.ButtonCG.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCG.TabIndex = 4
        Me.ButtonCG.UseVisualStyleBackColor = False
        '
        'ButtonFS
        '
        Me.ButtonFS.BackgroundImage = CType(resources.GetObject("ButtonFS.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFS.Location = New System.Drawing.Point(44, 52)
        Me.ButtonFS.Name = "ButtonFS"
        Me.ButtonFS.Size = New System.Drawing.Size(33, 43)
        Me.ButtonFS.TabIndex = 3
        Me.ButtonFS.UseVisualStyleBackColor = True
        '
        'ButtonFB
        '
        Me.ButtonFB.BackgroundImage = CType(resources.GetObject("ButtonFB.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFB.Location = New System.Drawing.Point(44, 3)
        Me.ButtonFB.Name = "ButtonFB"
        Me.ButtonFB.Size = New System.Drawing.Size(33, 43)
        Me.ButtonFB.TabIndex = 2
        Me.ButtonFB.UseVisualStyleBackColor = True
        '
        'ButtonN
        '
        Me.ButtonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonN.Location = New System.Drawing.Point(84, 3)
        Me.ButtonN.Name = "ButtonN"
        Me.ButtonN.Size = New System.Drawing.Size(33, 43)
        Me.ButtonN.TabIndex = 1
        Me.ButtonN.Text = "▶"
        Me.ButtonN.UseVisualStyleBackColor = True
        '
        'ButtonF
        '
        Me.ButtonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonF.Location = New System.Drawing.Point(3, 3)
        Me.ButtonF.Name = "ButtonF"
        Me.ButtonF.Size = New System.Drawing.Size(33, 43)
        Me.ButtonF.TabIndex = 0
        Me.ButtonF.Text = "◀"
        Me.ButtonF.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.EnableAutoDragDrop = True
        Me.TextBox1.Font = New System.Drawing.Font("新宋体", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(492, 298)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "欢迎使用Lineput 当前版本"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字体ToolStripMenuItem, Me.字体颜色DToolStripMenuItem, Me.ToolStripSeparator1, Me.上一行ToolStripMenuItem, Me.下一行NToolStripMenuItem, Me.撤消UToolStripMenuItem, Me.重复RToolStripMenuItem, Me.toolStripSeparator3, Me.剪切TToolStripMenuItem, Me.复制CToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.ToolStripMenuItem1, Me.toolStripSeparator4, Me.导入ToolStripMenuItem, Me.暂停运行ToolStripMenuItem, Me.保存SToolStripMenuItem, Me.只读ToolStripMenuItem, Me.移动ToolStripMenuItem, Me.审查元素ToolStripMenuItem, Me.设置SToolStripMenuItem, Me.ToolStripSeparator2, Me.全选AToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(207, 568)
        '
        '字体ToolStripMenuItem
        '
        Me.字体ToolStripMenuItem.Image = CType(resources.GetObject("字体ToolStripMenuItem.Image"), System.Drawing.Image)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        '上一行ToolStripMenuItem
        '
        Me.上一行ToolStripMenuItem.Image = CType(resources.GetObject("上一行ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.上一行ToolStripMenuItem.Name = "上一行ToolStripMenuItem"
        Me.上一行ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.上一行ToolStripMenuItem.Text = "上一行"
        '
        '下一行NToolStripMenuItem
        '
        Me.下一行NToolStripMenuItem.Image = CType(resources.GetObject("下一行NToolStripMenuItem.Image"), System.Drawing.Image)
        Me.下一行NToolStripMenuItem.Name = "下一行NToolStripMenuItem"
        Me.下一行NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.下一行NToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.下一行NToolStripMenuItem.Text = "下一行(&N)"
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
        Me.剪切TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.剪切TToolStripMenuItem.Text = "剪切(&X)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Image = CType(resources.GetObject("复制CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Image = CType(resources.GetObject("粘贴PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
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
        '导入ToolStripMenuItem
        '
        Me.导入ToolStripMenuItem.Image = CType(resources.GetObject("导入ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem"
        Me.导入ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.导入ToolStripMenuItem.Text = "运行"
        '
        '暂停运行ToolStripMenuItem
        '
        Me.暂停运行ToolStripMenuItem.Image = CType(resources.GetObject("暂停运行ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.暂停运行ToolStripMenuItem.Name = "暂停运行ToolStripMenuItem"
        Me.暂停运行ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.暂停运行ToolStripMenuItem.Text = "暂停运行"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Image = CType(resources.GetObject("保存SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.保存SToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.保存SToolStripMenuItem.MergeIndex = 3
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '只读ToolStripMenuItem
        '
        Me.只读ToolStripMenuItem.Name = "只读ToolStripMenuItem"
        Me.只读ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.只读ToolStripMenuItem.Text = "只读"
        '
        '移动ToolStripMenuItem
        '
        Me.移动ToolStripMenuItem.Image = CType(resources.GetObject("移动ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.移动ToolStripMenuItem.Name = "移动ToolStripMenuItem"
        Me.移动ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.移动ToolStripMenuItem.Text = "固定"
        '
        '审查元素ToolStripMenuItem
        '
        Me.审查元素ToolStripMenuItem.Name = "审查元素ToolStripMenuItem"
        Me.审查元素ToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.审查元素ToolStripMenuItem.Text = "审查元素"
        '
        '设置SToolStripMenuItem
        '
        Me.设置SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.置于顶层TToolStripMenuItem, Me.显示工具栏ToolStripMenuItem, Me.背景颜色ToolStripMenuItem, Me.关于LinePutToolStripMenuItem})
        Me.设置SToolStripMenuItem.Image = CType(resources.GetObject("设置SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem"
        Me.设置SToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.设置SToolStripMenuItem.Text = "设置"
        '
        '置于顶层TToolStripMenuItem
        '
        Me.置于顶层TToolStripMenuItem.Name = "置于顶层TToolStripMenuItem"
        Me.置于顶层TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.置于顶层TToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.置于顶层TToolStripMenuItem.Text = "置于顶层(&T)"
        '
        '显示工具栏ToolStripMenuItem
        '
        Me.显示工具栏ToolStripMenuItem.Checked = True
        Me.显示工具栏ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.显示工具栏ToolStripMenuItem.Name = "显示工具栏ToolStripMenuItem"
        Me.显示工具栏ToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.显示工具栏ToolStripMenuItem.Text = "显示工具栏"
        '
        '背景颜色ToolStripMenuItem
        '
        Me.背景颜色ToolStripMenuItem.Name = "背景颜色ToolStripMenuItem"
        Me.背景颜色ToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.背景颜色ToolStripMenuItem.Text = "背景颜色"
        '
        '关于LinePutToolStripMenuItem
        '
        Me.关于LinePutToolStripMenuItem.Name = "关于LinePutToolStripMenuItem"
        Me.关于LinePutToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.关于LinePutToolStripMenuItem.Text = "关于Lineput"
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
        'Timerllcc
        '
        Me.Timerllcc.Interval = 500
        '
        'TimerInTimer
        '
        '
        'TimerNext
        '
        '
        'TimerPrinter
        '
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonCloseElement)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonGoSet)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonRels)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxElement)
        Me.SplitContainer1.Size = New System.Drawing.Size(494, 447)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 6
        '
        'ButtonCloseElement
        '
        Me.ButtonCloseElement.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCloseElement.BackColor = System.Drawing.Color.White
        Me.ButtonCloseElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCloseElement.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.ButtonCloseElement.Location = New System.Drawing.Point(352, 3)
        Me.ButtonCloseElement.Name = "ButtonCloseElement"
        Me.ButtonCloseElement.Size = New System.Drawing.Size(23, 23)
        Me.ButtonCloseElement.TabIndex = 3
        Me.ButtonCloseElement.Text = "X"
        Me.ButtonCloseElement.UseVisualStyleBackColor = False
        '
        'ButtonGoSet
        '
        Me.ButtonGoSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGoSet.BackColor = System.Drawing.Color.White
        Me.ButtonGoSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGoSet.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.ButtonGoSet.Location = New System.Drawing.Point(296, 3)
        Me.ButtonGoSet.Name = "ButtonGoSet"
        Me.ButtonGoSet.Size = New System.Drawing.Size(50, 23)
        Me.ButtonGoSet.TabIndex = 2
        Me.ButtonGoSet.Text = "应用"
        Me.ButtonGoSet.UseVisualStyleBackColor = False
        '
        'ButtonRels
        '
        Me.ButtonRels.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRels.BackColor = System.Drawing.Color.White
        Me.ButtonRels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRels.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.ButtonRels.Location = New System.Drawing.Point(240, 3)
        Me.ButtonRels.Name = "ButtonRels"
        Me.ButtonRels.Size = New System.Drawing.Size(50, 23)
        Me.ButtonRels.TabIndex = 1
        Me.ButtonRels.Text = "刷新"
        Me.ButtonRels.UseVisualStyleBackColor = False
        '
        'TextBoxElement
        '
        Me.TextBoxElement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxElement.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.TextBoxElement.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxElement.Multiline = True
        Me.TextBoxElement.Name = "TextBoxElement"
        Me.TextBoxElement.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxElement.Size = New System.Drawing.Size(492, 141)
        Me.TextBoxElement.TabIndex = 0
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 447)
        Me.Controls.Add(Me.PanelTool)
        Me.Controls.Add(Me.ButtonShowTool)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lineput"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTool.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonShowTool As System.Windows.Forms.Button
    Friend WithEvents PanelTool As System.Windows.Forms.Panel
    Friend WithEvents ButtonN As System.Windows.Forms.Button
    Friend WithEvents ButtonF As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 字体ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 字体颜色DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 下一行NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 撤消UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重复RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 剪切TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 导入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 移动ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 置于顶层TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示工具栏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 背景颜色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于LinePutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timerllcc As System.Windows.Forms.Timer
    Friend WithEvents TimerInTimer As System.Windows.Forms.Timer
    Friend WithEvents 只读ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerNext As System.Windows.Forms.Timer
    Friend WithEvents TimerPrinter As System.Windows.Forms.Timer
    Friend WithEvents ButtonCW As System.Windows.Forms.Button
    Friend WithEvents ButtonCB As System.Windows.Forms.Button
    Friend WithEvents ButtonCR As System.Windows.Forms.Button
    Friend WithEvents ButtonCG As System.Windows.Forms.Button
    Friend WithEvents ButtonFS As System.Windows.Forms.Button
    Friend WithEvents ButtonFB As System.Windows.Forms.Button
    Friend WithEvents 暂停运行ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 上一行ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxElement As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRels As System.Windows.Forms.Button
    Friend WithEvents 审查元素ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonCloseElement As System.Windows.Forms.Button
    Friend WithEvents ButtonGoSet As System.Windows.Forms.Button

End Class
