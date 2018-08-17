<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditor))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.撤消UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.设计ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.颜色输入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.全局字体颜色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字体颜色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景颜色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.全局字号ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字号ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H148ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H236ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H324ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H416ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H512ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H69ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.指令ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选择文件地址ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.换行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.当前时间ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.自动播放ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.前往指针ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清屏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.暂停播放ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.结束播放ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooleanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoubleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.数据操作ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文本框ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.视频窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.图片窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.倒计时器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBoxOutPut = New System.Windows.Forms.TextBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.ButtonDeletePage = New System.Windows.Forms.Button()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonNewPage = New System.Windows.Forms.Button()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.PanelCenter = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ButtonNextLen = New System.Windows.Forms.Button()
        Me.ButtonRun = New System.Windows.Forms.Button()
        Me.LabelT1 = New System.Windows.Forms.Label()
        Me.ListBoxList = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelCenter.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxCode)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxOutPut)
        Me.SplitContainer1.Size = New System.Drawing.Size(680, 349)
        Me.SplitContainer1.SplitterDistance = 325
        Me.SplitContainer1.TabIndex = 1
        '
        'TextBoxCode
        '
        Me.TextBoxCode.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCode.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.TextBoxCode.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxCode.Multiline = True
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(325, 349)
        Me.TextBoxCode.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.剪切TToolStripMenuItem, Me.复制CToolStripMenuItem, Me.ToolStripSeparator1, Me.粘贴PToolStripMenuItem, Me.撤消UToolStripMenuItem, Me.重复RToolStripMenuItem, Me.toolStripSeparator3, Me.设计ToolStripMenuItem, Me.指令ToolStripMenuItem, Me.工具ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 256)
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Image = CType(resources.GetObject("剪切TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.剪切TToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Image = CType(resources.GetObject("复制CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Image = CType(resources.GetObject("粘贴PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&P)"
        '
        '撤消UToolStripMenuItem
        '
        Me.撤消UToolStripMenuItem.Image = CType(resources.GetObject("撤消UToolStripMenuItem.Image"), System.Drawing.Image)
        Me.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem"
        Me.撤消UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.撤消UToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.撤消UToolStripMenuItem.Text = "撤消(&U)"
        '
        '重复RToolStripMenuItem
        '
        Me.重复RToolStripMenuItem.Image = CType(resources.GetObject("重复RToolStripMenuItem.Image"), System.Drawing.Image)
        Me.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem"
        Me.重复RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.重复RToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.重复RToolStripMenuItem.Text = "重复(&R)"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(166, 6)
        '
        '设计ToolStripMenuItem
        '
        Me.设计ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.颜色输入ToolStripMenuItem, Me.全局字体颜色ToolStripMenuItem, Me.字体颜色ToolStripMenuItem, Me.背景颜色ToolStripMenuItem, Me.ToolStripSeparator2, Me.全局字号ToolStripMenuItem, Me.字号ToolStripMenuItem, Me.H148ToolStripMenuItem, Me.H236ToolStripMenuItem, Me.H324ToolStripMenuItem, Me.H416ToolStripMenuItem, Me.H512ToolStripMenuItem, Me.H69ToolStripMenuItem})
        Me.设计ToolStripMenuItem.Image = CType(resources.GetObject("设计ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.设计ToolStripMenuItem.Name = "设计ToolStripMenuItem"
        Me.设计ToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.设计ToolStripMenuItem.Text = "设计"
        '
        '颜色输入ToolStripMenuItem
        '
        Me.颜色输入ToolStripMenuItem.Name = "颜色输入ToolStripMenuItem"
        Me.颜色输入ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.颜色输入ToolStripMenuItem.Text = "颜色输入"
        '
        '全局字体颜色ToolStripMenuItem
        '
        Me.全局字体颜色ToolStripMenuItem.Name = "全局字体颜色ToolStripMenuItem"
        Me.全局字体颜色ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.全局字体颜色ToolStripMenuItem.Text = "全局字体颜色"
        Me.全局字体颜色ToolStripMenuItem.ToolTipText = "设置字体颜色，这里设置的字体将会应用到全部默认输出"
        '
        '字体颜色ToolStripMenuItem
        '
        Me.字体颜色ToolStripMenuItem.Name = "字体颜色ToolStripMenuItem"
        Me.字体颜色ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.字体颜色ToolStripMenuItem.Text = "字体颜色"
        Me.字体颜色ToolStripMenuItem.ToolTipText = "设置字体颜色"
        '
        '背景颜色ToolStripMenuItem
        '
        Me.背景颜色ToolStripMenuItem.Name = "背景颜色ToolStripMenuItem"
        Me.背景颜色ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.背景颜色ToolStripMenuItem.Text = "背景颜色"
        Me.背景颜色ToolStripMenuItem.ToolTipText = "设置背景颜色"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(145, 6)
        '
        '全局字号ToolStripMenuItem
        '
        Me.全局字号ToolStripMenuItem.Name = "全局字号ToolStripMenuItem"
        Me.全局字号ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.全局字号ToolStripMenuItem.Text = "全局字号"
        Me.全局字号ToolStripMenuItem.ToolTipText = "设定全局字号"
        '
        '字号ToolStripMenuItem
        '
        Me.字号ToolStripMenuItem.Name = "字号ToolStripMenuItem"
        Me.字号ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.字号ToolStripMenuItem.Text = "字号"
        Me.字号ToolStripMenuItem.ToolTipText = "设定字号"
        '
        'H148ToolStripMenuItem
        '
        Me.H148ToolStripMenuItem.Name = "H148ToolStripMenuItem"
        Me.H148ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.H148ToolStripMenuItem.Text = "H1 48"
        Me.H148ToolStripMenuItem.ToolTipText = "字号设定为48"
        '
        'H236ToolStripMenuItem
        '
        Me.H236ToolStripMenuItem.Name = "H236ToolStripMenuItem"
        Me.H236ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.H236ToolStripMenuItem.Text = "H2 36"
        Me.H236ToolStripMenuItem.ToolTipText = "字号设定为36"
        '
        'H324ToolStripMenuItem
        '
        Me.H324ToolStripMenuItem.Name = "H324ToolStripMenuItem"
        Me.H324ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.H324ToolStripMenuItem.Text = "H3 24"
        Me.H324ToolStripMenuItem.ToolTipText = "字号设定为24"
        '
        'H416ToolStripMenuItem
        '
        Me.H416ToolStripMenuItem.Name = "H416ToolStripMenuItem"
        Me.H416ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.H416ToolStripMenuItem.Text = "H4 16"
        Me.H416ToolStripMenuItem.ToolTipText = "字号设定为16"
        '
        'H512ToolStripMenuItem
        '
        Me.H512ToolStripMenuItem.Name = "H512ToolStripMenuItem"
        Me.H512ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.H512ToolStripMenuItem.Text = "H5 12"
        Me.H512ToolStripMenuItem.ToolTipText = "字号设定为12"
        '
        'H69ToolStripMenuItem
        '
        Me.H69ToolStripMenuItem.Name = "H69ToolStripMenuItem"
        Me.H69ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.H69ToolStripMenuItem.Text = "H6 9"
        Me.H69ToolStripMenuItem.ToolTipText = "字号设定为9"
        '
        '指令ToolStripMenuItem
        '
        Me.指令ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选择文件地址ToolStripMenuItem, Me.ToolStripSeparator4, Me.TabToolStripMenuItem, Me.换行ToolStripMenuItem, Me.当前时间ToolStripMenuItem, Me.ToolStripSeparator5, Me.自动播放ToolStripMenuItem, Me.前往指针ToolStripMenuItem, Me.ShellToolStripMenuItem, Me.清屏ToolStripMenuItem, Me.暂停播放ToolStripMenuItem, Me.结束播放ToolStripMenuItem, Me.数据ToolStripMenuItem, Me.数据操作ToolStripMenuItem})
        Me.指令ToolStripMenuItem.Image = CType(resources.GetObject("指令ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.指令ToolStripMenuItem.Name = "指令ToolStripMenuItem"
        Me.指令ToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.指令ToolStripMenuItem.Text = "指令"
        '
        '选择文件地址ToolStripMenuItem
        '
        Me.选择文件地址ToolStripMenuItem.Name = "选择文件地址ToolStripMenuItem"
        Me.选择文件地址ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.选择文件地址ToolStripMenuItem.Text = "选择文件地址"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(145, 6)
        '
        'TabToolStripMenuItem
        '
        Me.TabToolStripMenuItem.Name = "TabToolStripMenuItem"
        Me.TabToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TabToolStripMenuItem.Text = "Tab"
        '
        '换行ToolStripMenuItem
        '
        Me.换行ToolStripMenuItem.Name = "换行ToolStripMenuItem"
        Me.换行ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.换行ToolStripMenuItem.Text = "换行"
        '
        '当前时间ToolStripMenuItem
        '
        Me.当前时间ToolStripMenuItem.Name = "当前时间ToolStripMenuItem"
        Me.当前时间ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.当前时间ToolStripMenuItem.Text = "当前时间"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(145, 6)
        '
        '自动播放ToolStripMenuItem
        '
        Me.自动播放ToolStripMenuItem.Name = "自动播放ToolStripMenuItem"
        Me.自动播放ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.自动播放ToolStripMenuItem.Text = "自动播放"
        '
        '前往指针ToolStripMenuItem
        '
        Me.前往指针ToolStripMenuItem.Name = "前往指针ToolStripMenuItem"
        Me.前往指针ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.前往指针ToolStripMenuItem.Text = "前往指针"
        '
        'ShellToolStripMenuItem
        '
        Me.ShellToolStripMenuItem.Name = "ShellToolStripMenuItem"
        Me.ShellToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ShellToolStripMenuItem.Text = "Shell"
        '
        '清屏ToolStripMenuItem
        '
        Me.清屏ToolStripMenuItem.Name = "清屏ToolStripMenuItem"
        Me.清屏ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.清屏ToolStripMenuItem.Text = "清屏"
        '
        '暂停播放ToolStripMenuItem
        '
        Me.暂停播放ToolStripMenuItem.Name = "暂停播放ToolStripMenuItem"
        Me.暂停播放ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.暂停播放ToolStripMenuItem.Text = "暂停播放"
        '
        '结束播放ToolStripMenuItem
        '
        Me.结束播放ToolStripMenuItem.Name = "结束播放ToolStripMenuItem"
        Me.结束播放ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.结束播放ToolStripMenuItem.Text = "结束播放"
        '
        '数据ToolStripMenuItem
        '
        Me.数据ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StringToolStripMenuItem, Me.IntegerToolStripMenuItem, Me.BooleanToolStripMenuItem, Me.DoubleToolStripMenuItem})
        Me.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem"
        Me.数据ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.数据ToolStripMenuItem.Text = "数据"
        '
        'StringToolStripMenuItem
        '
        Me.StringToolStripMenuItem.Name = "StringToolStripMenuItem"
        Me.StringToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.StringToolStripMenuItem.Text = "String"
        '
        'IntegerToolStripMenuItem
        '
        Me.IntegerToolStripMenuItem.Name = "IntegerToolStripMenuItem"
        Me.IntegerToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.IntegerToolStripMenuItem.Text = "Integer"
        '
        'BooleanToolStripMenuItem
        '
        Me.BooleanToolStripMenuItem.Name = "BooleanToolStripMenuItem"
        Me.BooleanToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BooleanToolStripMenuItem.Text = "Boolean"
        '
        'DoubleToolStripMenuItem
        '
        Me.DoubleToolStripMenuItem.Name = "DoubleToolStripMenuItem"
        Me.DoubleToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.DoubleToolStripMenuItem.Text = "Double"
        '
        '数据操作ToolStripMenuItem
        '
        Me.数据操作ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetToolStripMenuItem})
        Me.数据操作ToolStripMenuItem.Name = "数据操作ToolStripMenuItem"
        Me.数据操作ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.数据操作ToolStripMenuItem.Text = "数据操作"
        '
        'SetToolStripMenuItem
        '
        Me.SetToolStripMenuItem.Name = "SetToolStripMenuItem"
        Me.SetToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SetToolStripMenuItem.Text = "设置数据"
        '
        '工具ToolStripMenuItem
        '
        Me.工具ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文本框ToolStripMenuItem, Me.视频窗口ToolStripMenuItem, Me.图片窗口ToolStripMenuItem, Me.倒计时器ToolStripMenuItem})
        Me.工具ToolStripMenuItem.Image = CType(resources.GetObject("工具ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem"
        Me.工具ToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.工具ToolStripMenuItem.Text = "工具"
        '
        '文本框ToolStripMenuItem
        '
        Me.文本框ToolStripMenuItem.Name = "文本框ToolStripMenuItem"
        Me.文本框ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.文本框ToolStripMenuItem.Text = "文本框"
        '
        '视频窗口ToolStripMenuItem
        '
        Me.视频窗口ToolStripMenuItem.Name = "视频窗口ToolStripMenuItem"
        Me.视频窗口ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.视频窗口ToolStripMenuItem.Text = "视频窗口"
        '
        '图片窗口ToolStripMenuItem
        '
        Me.图片窗口ToolStripMenuItem.Name = "图片窗口ToolStripMenuItem"
        Me.图片窗口ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.图片窗口ToolStripMenuItem.Text = "图片窗口"
        '
        '倒计时器ToolStripMenuItem
        '
        Me.倒计时器ToolStripMenuItem.Name = "倒计时器ToolStripMenuItem"
        Me.倒计时器ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.倒计时器ToolStripMenuItem.Text = "倒计时器"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.DetectUrls = False
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("新宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(351, 291)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBoxOutPut
        '
        Me.TextBoxOutPut.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxOutPut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxOutPut.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.TextBoxOutPut.Location = New System.Drawing.Point(0, 291)
        Me.TextBoxOutPut.Multiline = True
        Me.TextBoxOutPut.Name = "TextBoxOutPut"
        Me.TextBoxOutPut.ReadOnly = True
        Me.TextBoxOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxOutPut.Size = New System.Drawing.Size(351, 58)
        Me.TextBoxOutPut.TabIndex = 1
        Me.TextBoxOutPut.Text = "输出" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.ButtonDeletePage)
        Me.PanelTop.Controls.Add(Me.ButtonOpen)
        Me.PanelTop.Controls.Add(Me.ButtonSave)
        Me.PanelTop.Controls.Add(Me.ButtonNewPage)
        Me.PanelTop.Controls.Add(Me.ButtonHelp)
        Me.PanelTop.Controls.Add(Me.PanelCenter)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(812, 27)
        Me.PanelTop.TabIndex = 2
        '
        'ButtonDeletePage
        '
        Me.ButtonDeletePage.Location = New System.Drawing.Point(163, 0)
        Me.ButtonDeletePage.Name = "ButtonDeletePage"
        Me.ButtonDeletePage.Size = New System.Drawing.Size(66, 26)
        Me.ButtonDeletePage.TabIndex = 9
        Me.ButtonDeletePage.Text = "删除页"
        Me.ButtonDeletePage.UseVisualStyleBackColor = True
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Location = New System.Drawing.Point(3, 0)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(48, 26)
        Me.ButtonOpen.TabIndex = 6
        Me.ButtonOpen.Text = "打开"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(49, 0)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(50, 26)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "保存"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonNewPage
        '
        Me.ButtonNewPage.Location = New System.Drawing.Point(98, 0)
        Me.ButtonNewPage.Name = "ButtonNewPage"
        Me.ButtonNewPage.Size = New System.Drawing.Size(66, 26)
        Me.ButtonNewPage.TabIndex = 4
        Me.ButtonNewPage.Text = "新建页"
        Me.ButtonNewPage.UseVisualStyleBackColor = True
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHelp.Location = New System.Drawing.Point(764, 0)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(48, 26)
        Me.ButtonHelp.TabIndex = 3
        Me.ButtonHelp.Text = "帮助"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.NumericUpDown1)
        Me.PanelCenter.Controls.Add(Me.ButtonNextLen)
        Me.PanelCenter.Controls.Add(Me.ButtonRun)
        Me.PanelCenter.Controls.Add(Me.LabelT1)
        Me.PanelCenter.Location = New System.Drawing.Point(328, 0)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(260, 27)
        Me.PanelCenter.TabIndex = 8
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(198, 1)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 26)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {33, 0, 0, 0})
        '
        'ButtonNextLen
        '
        Me.ButtonNextLen.Location = New System.Drawing.Point(56, 0)
        Me.ButtonNextLen.Name = "ButtonNextLen"
        Me.ButtonNextLen.Size = New System.Drawing.Size(71, 26)
        Me.ButtonNextLen.TabIndex = 7
        Me.ButtonNextLen.Text = "下一行"
        Me.ButtonNextLen.UseVisualStyleBackColor = True
        '
        'ButtonRun
        '
        Me.ButtonRun.Location = New System.Drawing.Point(1, 0)
        Me.ButtonRun.Name = "ButtonRun"
        Me.ButtonRun.Size = New System.Drawing.Size(55, 26)
        Me.ButtonRun.TabIndex = 1
        Me.ButtonRun.Text = "运行"
        Me.ButtonRun.UseVisualStyleBackColor = True
        '
        'LabelT1
        '
        Me.LabelT1.AutoSize = True
        Me.LabelT1.Location = New System.Drawing.Point(130, 5)
        Me.LabelT1.Name = "LabelT1"
        Me.LabelT1.Size = New System.Drawing.Size(128, 16)
        Me.LabelT1.TabIndex = 0
        Me.LabelT1.Text = "缩放比例      %"
        '
        'ListBoxList
        '
        Me.ListBoxList.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxList.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.ListBoxList.FormattingEnabled = True
        Me.ListBoxList.Items.AddRange(New Object() {"FirstLine"})
        Me.ListBoxList.Location = New System.Drawing.Point(680, 27)
        Me.ListBoxList.Name = "ListBoxList"
        Me.ListBoxList.Size = New System.Drawing.Size(132, 349)
        Me.ListBoxList.TabIndex = 2
        '
        'FrmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 376)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ListBoxList)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEditor"
        Me.Text = "LinePut编辑器"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelCenter.ResumeLayout(False)
        Me.PanelCenter.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxOutPut As System.Windows.Forms.TextBox
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents ButtonRun As System.Windows.Forms.Button
    Friend WithEvents LabelT1 As System.Windows.Forms.Label
    Friend WithEvents ListBoxList As System.Windows.Forms.ListBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents ButtonNewPage As System.Windows.Forms.Button
    Friend WithEvents ButtonOpen As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 剪切TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 粘贴PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 撤消UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重复RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 指令ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设计ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 工具ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 颜色输入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 字体颜色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 背景颜色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 字号ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H148ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H236ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H324ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H416ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H512ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H69ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全局字体颜色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 自动播放ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents 全局字号ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 前往指针ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清屏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 结束播放ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 暂停播放ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 数据操作ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntegerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooleanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoubleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 文本框ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 视频窗口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 图片窗口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 倒计时器ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonNextLen As System.Windows.Forms.Button
    Friend WithEvents PanelCenter As System.Windows.Forms.Panel
    Friend WithEvents ButtonDeletePage As System.Windows.Forms.Button
    Friend WithEvents 选择文件地址ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 换行ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 当前时间ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
