<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaker))
        Me.TabControlHTML = New System.Windows.Forms.TabControl()
        Me.TabPageDesign = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.字体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字体颜色DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.撤消UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonNM = New System.Windows.Forms.Button()
        Me.ButtonI = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.ButtonU = New System.Windows.Forms.Button()
        Me.TextBoxFontName = New System.Windows.Forms.TextBox()
        Me.NumericUpDownH = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownW = New System.Windows.Forms.NumericUpDown()
        Me.RadioButtonPX = New System.Windows.Forms.RadioButton()
        Me.NumericUpDownFS = New System.Windows.Forms.NumericUpDown()
        Me.RadioButtonEM = New System.Windows.Forms.RadioButton()
        Me.PictureBoxFC = New System.Windows.Forms.PictureBox()
        Me.ButtonH4 = New System.Windows.Forms.Button()
        Me.PictureBoxBC = New System.Windows.Forms.PictureBox()
        Me.ButtonH3 = New System.Windows.Forms.Button()
        Me.TextBoxFC = New System.Windows.Forms.TextBox()
        Me.ButtonH2 = New System.Windows.Forms.Button()
        Me.TextBoxBC = New System.Windows.Forms.TextBox()
        Me.ButtonH1 = New System.Windows.Forms.Button()
        Me.ButtonFSB = New System.Windows.Forms.Button()
        Me.ButtonFS16 = New System.Windows.Forms.Button()
        Me.ButtonFSS = New System.Windows.Forms.Button()
        Me.ButtonFS12 = New System.Windows.Forms.Button()
        Me.ButtonCG = New System.Windows.Forms.Button()
        Me.ButtonPK = New System.Windows.Forms.Button()
        Me.ButtonCR = New System.Windows.Forms.Button()
        Me.ButtonDG = New System.Windows.Forms.Button()
        Me.ButtonCB = New System.Windows.Forms.Button()
        Me.ButtonOR = New System.Windows.Forms.Button()
        Me.ButtonCW = New System.Windows.Forms.Button()
        Me.ButtonDB = New System.Windows.Forms.Button()
        Me.LabelT1 = New System.Windows.Forms.Label()
        Me.TabPageCode = New System.Windows.Forms.TabPage()
        Me.TextBoxCode = New System.Windows.Forms.RichTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabPageHTML = New System.Windows.Forms.TabPage()
        Me.TextBoxHTML = New System.Windows.Forms.RichTextBox()
        Me.TabControlHTML.SuspendLayout()
        Me.TabPageDesign.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDownH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCode.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPageHTML.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlHTML
        '
        Me.TabControlHTML.Controls.Add(Me.TabPageDesign)
        Me.TabControlHTML.Controls.Add(Me.TabPageCode)
        Me.TabControlHTML.Controls.Add(Me.TabPageHTML)
        Me.TabControlHTML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlHTML.Location = New System.Drawing.Point(0, 0)
        Me.TabControlHTML.Name = "TabControlHTML"
        Me.TabControlHTML.SelectedIndex = 0
        Me.TabControlHTML.Size = New System.Drawing.Size(824, 516)
        Me.TabControlHTML.TabIndex = 0
        '
        'TabPageDesign
        '
        Me.TabPageDesign.Controls.Add(Me.TextBox1)
        Me.TabPageDesign.Controls.Add(Me.Panel1)
        Me.TabPageDesign.Location = New System.Drawing.Point(4, 26)
        Me.TabPageDesign.Name = "TabPageDesign"
        Me.TabPageDesign.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDesign.Size = New System.Drawing.Size(816, 486)
        Me.TabPageDesign.TabIndex = 0
        Me.TabPageDesign.Text = "设计"
        Me.TabPageDesign.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.EnableAutoDragDrop = True
        Me.TextBox1.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(640, 480)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "在此处设计LPT显示页面，将会在代码页面生成出源代码"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字体ToolStripMenuItem, Me.字体颜色DToolStripMenuItem, Me.ToolStripSeparator1, Me.撤消UToolStripMenuItem, Me.重复RToolStripMenuItem, Me.toolStripSeparator3, Me.剪切TToolStripMenuItem, Me.复制CToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.ToolStripSeparator2, Me.全选AToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(196, 262)
        '
        '字体ToolStripMenuItem
        '
        Me.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem"
        Me.字体ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.字体ToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.字体ToolStripMenuItem.Text = "字体(&W)"
        '
        '字体颜色DToolStripMenuItem
        '
        Me.字体颜色DToolStripMenuItem.Name = "字体颜色DToolStripMenuItem"
        Me.字体颜色DToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.字体颜色DToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.字体颜色DToolStripMenuItem.Text = "字体颜色(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        '撤消UToolStripMenuItem
        '
        Me.撤消UToolStripMenuItem.Image = CType(resources.GetObject("撤消UToolStripMenuItem.Image"), System.Drawing.Image)
        Me.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem"
        Me.撤消UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.撤消UToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.撤消UToolStripMenuItem.Text = "撤消(&U)"
        '
        '重复RToolStripMenuItem
        '
        Me.重复RToolStripMenuItem.Image = CType(resources.GetObject("重复RToolStripMenuItem.Image"), System.Drawing.Image)
        Me.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem"
        Me.重复RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.重复RToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.重复RToolStripMenuItem.Text = "重复(&R)"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Image = CType(resources.GetObject("剪切TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.剪切TToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Image = CType(resources.GetObject("复制CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Image = CType(resources.GetObject("粘贴PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&P)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        '全选AToolStripMenuItem
        '
        Me.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem"
        Me.全选AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.全选AToolStripMenuItem.Size = New System.Drawing.Size(195, 30)
        Me.全选AToolStripMenuItem.Text = "全选(&A)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonNM)
        Me.Panel1.Controls.Add(Me.ButtonI)
        Me.Panel1.Controls.Add(Me.ButtonB)
        Me.Panel1.Controls.Add(Me.ButtonU)
        Me.Panel1.Controls.Add(Me.TextBoxFontName)
        Me.Panel1.Controls.Add(Me.NumericUpDownH)
        Me.Panel1.Controls.Add(Me.NumericUpDownW)
        Me.Panel1.Controls.Add(Me.RadioButtonPX)
        Me.Panel1.Controls.Add(Me.NumericUpDownFS)
        Me.Panel1.Controls.Add(Me.RadioButtonEM)
        Me.Panel1.Controls.Add(Me.PictureBoxFC)
        Me.Panel1.Controls.Add(Me.ButtonH4)
        Me.Panel1.Controls.Add(Me.PictureBoxBC)
        Me.Panel1.Controls.Add(Me.ButtonH3)
        Me.Panel1.Controls.Add(Me.TextBoxFC)
        Me.Panel1.Controls.Add(Me.ButtonH2)
        Me.Panel1.Controls.Add(Me.TextBoxBC)
        Me.Panel1.Controls.Add(Me.ButtonH1)
        Me.Panel1.Controls.Add(Me.ButtonFSB)
        Me.Panel1.Controls.Add(Me.ButtonFS16)
        Me.Panel1.Controls.Add(Me.ButtonFSS)
        Me.Panel1.Controls.Add(Me.ButtonFS12)
        Me.Panel1.Controls.Add(Me.ButtonCG)
        Me.Panel1.Controls.Add(Me.ButtonPK)
        Me.Panel1.Controls.Add(Me.ButtonCR)
        Me.Panel1.Controls.Add(Me.ButtonDG)
        Me.Panel1.Controls.Add(Me.ButtonCB)
        Me.Panel1.Controls.Add(Me.ButtonOR)
        Me.Panel1.Controls.Add(Me.ButtonCW)
        Me.Panel1.Controls.Add(Me.ButtonDB)
        Me.Panel1.Controls.Add(Me.LabelT1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(643, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 480)
        Me.Panel1.TabIndex = 8
        '
        'ButtonNM
        '
        Me.ButtonNM.BackgroundImage = CType(resources.GetObject("ButtonNM.BackgroundImage"), System.Drawing.Image)
        Me.ButtonNM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonNM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNM.Location = New System.Drawing.Point(10, 284)
        Me.ButtonNM.Name = "ButtonNM"
        Me.ButtonNM.Size = New System.Drawing.Size(33, 43)
        Me.ButtonNM.TabIndex = 28
        Me.ButtonNM.UseVisualStyleBackColor = True
        '
        'ButtonI
        '
        Me.ButtonI.BackgroundImage = CType(resources.GetObject("ButtonI.BackgroundImage"), System.Drawing.Image)
        Me.ButtonI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonI.Location = New System.Drawing.Point(88, 284)
        Me.ButtonI.Name = "ButtonI"
        Me.ButtonI.Size = New System.Drawing.Size(33, 43)
        Me.ButtonI.TabIndex = 30
        Me.ButtonI.UseVisualStyleBackColor = True
        '
        'ButtonB
        '
        Me.ButtonB.BackgroundImage = CType(resources.GetObject("ButtonB.BackgroundImage"), System.Drawing.Image)
        Me.ButtonB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonB.Location = New System.Drawing.Point(49, 284)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(33, 43)
        Me.ButtonB.TabIndex = 29
        Me.ButtonB.UseVisualStyleBackColor = True
        '
        'ButtonU
        '
        Me.ButtonU.BackgroundImage = CType(resources.GetObject("ButtonU.BackgroundImage"), System.Drawing.Image)
        Me.ButtonU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonU.Location = New System.Drawing.Point(128, 284)
        Me.ButtonU.Name = "ButtonU"
        Me.ButtonU.Size = New System.Drawing.Size(33, 43)
        Me.ButtonU.TabIndex = 31
        Me.ButtonU.UseVisualStyleBackColor = True
        '
        'TextBoxFontName
        '
        Me.TextBoxFontName.Location = New System.Drawing.Point(81, 125)
        Me.TextBoxFontName.MaxLength = 6
        Me.TextBoxFontName.Name = "TextBoxFontName"
        Me.TextBoxFontName.Size = New System.Drawing.Size(84, 26)
        Me.TextBoxFontName.TabIndex = 27
        Me.TextBoxFontName.Text = "新宋体"
        '
        'NumericUpDownH
        '
        Me.NumericUpDownH.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDownH.Location = New System.Drawing.Point(109, 252)
        Me.NumericUpDownH.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDownH.Name = "NumericUpDownH"
        Me.NumericUpDownH.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDownH.TabIndex = 26
        Me.NumericUpDownH.Value = New Decimal(New Integer() {960, 0, 0, 0})
        '
        'NumericUpDownW
        '
        Me.NumericUpDownW.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDownW.Location = New System.Drawing.Point(109, 220)
        Me.NumericUpDownW.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDownW.Name = "NumericUpDownW"
        Me.NumericUpDownW.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDownW.TabIndex = 25
        Me.NumericUpDownW.Value = New Decimal(New Integer() {1280, 0, 0, 0})
        '
        'RadioButtonPX
        '
        Me.RadioButtonPX.AutoSize = True
        Me.RadioButtonPX.Location = New System.Drawing.Point(123, 160)
        Me.RadioButtonPX.Name = "RadioButtonPX"
        Me.RadioButtonPX.Size = New System.Drawing.Size(42, 20)
        Me.RadioButtonPX.TabIndex = 24
        Me.RadioButtonPX.Text = "px"
        Me.RadioButtonPX.UseVisualStyleBackColor = True
        '
        'NumericUpDownFS
        '
        Me.NumericUpDownFS.DecimalPlaces = 1
        Me.NumericUpDownFS.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.NumericUpDownFS.Location = New System.Drawing.Point(81, 93)
        Me.NumericUpDownFS.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownFS.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumericUpDownFS.Name = "NumericUpDownFS"
        Me.NumericUpDownFS.Size = New System.Drawing.Size(84, 26)
        Me.NumericUpDownFS.TabIndex = 1
        Me.NumericUpDownFS.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'RadioButtonEM
        '
        Me.RadioButtonEM.AutoSize = True
        Me.RadioButtonEM.Checked = True
        Me.RadioButtonEM.Location = New System.Drawing.Point(81, 160)
        Me.RadioButtonEM.Name = "RadioButtonEM"
        Me.RadioButtonEM.Size = New System.Drawing.Size(42, 20)
        Me.RadioButtonEM.TabIndex = 23
        Me.RadioButtonEM.TabStop = True
        Me.RadioButtonEM.Text = "em"
        Me.RadioButtonEM.UseVisualStyleBackColor = True
        '
        'PictureBoxFC
        '
        Me.PictureBoxFC.BackColor = System.Drawing.Color.White
        Me.PictureBoxFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxFC.Location = New System.Drawing.Point(81, 60)
        Me.PictureBoxFC.Name = "PictureBoxFC"
        Me.PictureBoxFC.Size = New System.Drawing.Size(22, 22)
        Me.PictureBoxFC.TabIndex = 2
        Me.PictureBoxFC.TabStop = False
        '
        'ButtonH4
        '
        Me.ButtonH4.BackgroundImage = CType(resources.GetObject("ButtonH4.BackgroundImage"), System.Drawing.Image)
        Me.ButtonH4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonH4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonH4.Location = New System.Drawing.Point(128, 430)
        Me.ButtonH4.Name = "ButtonH4"
        Me.ButtonH4.Size = New System.Drawing.Size(33, 43)
        Me.ButtonH4.TabIndex = 21
        Me.ButtonH4.UseVisualStyleBackColor = True
        '
        'PictureBoxBC
        '
        Me.PictureBoxBC.BackColor = System.Drawing.Color.Black
        Me.PictureBoxBC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxBC.Location = New System.Drawing.Point(81, 28)
        Me.PictureBoxBC.Name = "PictureBoxBC"
        Me.PictureBoxBC.Size = New System.Drawing.Size(22, 22)
        Me.PictureBoxBC.TabIndex = 3
        Me.PictureBoxBC.TabStop = False
        '
        'ButtonH3
        '
        Me.ButtonH3.BackgroundImage = CType(resources.GetObject("ButtonH3.BackgroundImage"), System.Drawing.Image)
        Me.ButtonH3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonH3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonH3.Location = New System.Drawing.Point(89, 430)
        Me.ButtonH3.Name = "ButtonH3"
        Me.ButtonH3.Size = New System.Drawing.Size(33, 43)
        Me.ButtonH3.TabIndex = 22
        Me.ButtonH3.UseVisualStyleBackColor = True
        '
        'TextBoxFC
        '
        Me.TextBoxFC.Location = New System.Drawing.Point(109, 60)
        Me.TextBoxFC.MaxLength = 6
        Me.TextBoxFC.Name = "TextBoxFC"
        Me.TextBoxFC.Size = New System.Drawing.Size(56, 26)
        Me.TextBoxFC.TabIndex = 4
        Me.TextBoxFC.Text = "FFFFFF"
        '
        'ButtonH2
        '
        Me.ButtonH2.BackgroundImage = CType(resources.GetObject("ButtonH2.BackgroundImage"), System.Drawing.Image)
        Me.ButtonH2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonH2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonH2.Location = New System.Drawing.Point(50, 430)
        Me.ButtonH2.Name = "ButtonH2"
        Me.ButtonH2.Size = New System.Drawing.Size(33, 43)
        Me.ButtonH2.TabIndex = 20
        Me.ButtonH2.UseVisualStyleBackColor = True
        '
        'TextBoxBC
        '
        Me.TextBoxBC.Location = New System.Drawing.Point(109, 27)
        Me.TextBoxBC.MaxLength = 6
        Me.TextBoxBC.Name = "TextBoxBC"
        Me.TextBoxBC.Size = New System.Drawing.Size(56, 26)
        Me.TextBoxBC.TabIndex = 5
        Me.TextBoxBC.Text = "000000"
        '
        'ButtonH1
        '
        Me.ButtonH1.BackgroundImage = CType(resources.GetObject("ButtonH1.BackgroundImage"), System.Drawing.Image)
        Me.ButtonH1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonH1.Location = New System.Drawing.Point(11, 430)
        Me.ButtonH1.Name = "ButtonH1"
        Me.ButtonH1.Size = New System.Drawing.Size(33, 43)
        Me.ButtonH1.TabIndex = 19
        Me.ButtonH1.UseVisualStyleBackColor = True
        '
        'ButtonFSB
        '
        Me.ButtonFSB.BackgroundImage = CType(resources.GetObject("ButtonFSB.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFSB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFSB.Location = New System.Drawing.Point(11, 332)
        Me.ButtonFSB.Name = "ButtonFSB"
        Me.ButtonFSB.Size = New System.Drawing.Size(33, 43)
        Me.ButtonFSB.TabIndex = 8
        Me.ButtonFSB.UseVisualStyleBackColor = True
        '
        'ButtonFS16
        '
        Me.ButtonFS16.BackgroundImage = CType(resources.GetObject("ButtonFS16.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFS16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFS16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFS16.Location = New System.Drawing.Point(128, 332)
        Me.ButtonFS16.Name = "ButtonFS16"
        Me.ButtonFS16.Size = New System.Drawing.Size(33, 43)
        Me.ButtonFS16.TabIndex = 10
        Me.ButtonFS16.UseVisualStyleBackColor = True
        '
        'ButtonFSS
        '
        Me.ButtonFSS.BackgroundImage = CType(resources.GetObject("ButtonFSS.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFSS.Location = New System.Drawing.Point(50, 332)
        Me.ButtonFSS.Name = "ButtonFSS"
        Me.ButtonFSS.Size = New System.Drawing.Size(33, 43)
        Me.ButtonFSS.TabIndex = 9
        Me.ButtonFSS.UseVisualStyleBackColor = True
        '
        'ButtonFS12
        '
        Me.ButtonFS12.BackgroundImage = CType(resources.GetObject("ButtonFS12.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFS12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFS12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFS12.Location = New System.Drawing.Point(89, 332)
        Me.ButtonFS12.Name = "ButtonFS12"
        Me.ButtonFS12.Size = New System.Drawing.Size(33, 43)
        Me.ButtonFS12.TabIndex = 18
        Me.ButtonFS12.UseVisualStyleBackColor = True
        '
        'ButtonCG
        '
        Me.ButtonCG.BackColor = System.Drawing.Color.LimeGreen
        Me.ButtonCG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCG.Location = New System.Drawing.Point(11, 381)
        Me.ButtonCG.Name = "ButtonCG"
        Me.ButtonCG.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCG.TabIndex = 10
        Me.ButtonCG.UseVisualStyleBackColor = False
        '
        'ButtonPK
        '
        Me.ButtonPK.BackColor = System.Drawing.Color.Pink
        Me.ButtonPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPK.Location = New System.Drawing.Point(89, 402)
        Me.ButtonPK.Name = "ButtonPK"
        Me.ButtonPK.Size = New System.Drawing.Size(33, 22)
        Me.ButtonPK.TabIndex = 17
        Me.ButtonPK.UseVisualStyleBackColor = False
        '
        'ButtonCR
        '
        Me.ButtonCR.BackColor = System.Drawing.Color.Red
        Me.ButtonCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCR.Location = New System.Drawing.Point(11, 402)
        Me.ButtonCR.Name = "ButtonCR"
        Me.ButtonCR.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCR.TabIndex = 11
        Me.ButtonCR.UseVisualStyleBackColor = False
        '
        'ButtonDG
        '
        Me.ButtonDG.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDG.Location = New System.Drawing.Point(89, 381)
        Me.ButtonDG.Name = "ButtonDG"
        Me.ButtonDG.Size = New System.Drawing.Size(33, 22)
        Me.ButtonDG.TabIndex = 16
        Me.ButtonDG.UseVisualStyleBackColor = False
        '
        'ButtonCB
        '
        Me.ButtonCB.BackColor = System.Drawing.Color.Black
        Me.ButtonCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCB.Location = New System.Drawing.Point(128, 381)
        Me.ButtonCB.Name = "ButtonCB"
        Me.ButtonCB.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCB.TabIndex = 12
        Me.ButtonCB.UseVisualStyleBackColor = False
        '
        'ButtonOR
        '
        Me.ButtonOR.BackColor = System.Drawing.Color.Orange
        Me.ButtonOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOR.Location = New System.Drawing.Point(50, 402)
        Me.ButtonOR.Name = "ButtonOR"
        Me.ButtonOR.Size = New System.Drawing.Size(33, 22)
        Me.ButtonOR.TabIndex = 15
        Me.ButtonOR.UseVisualStyleBackColor = False
        '
        'ButtonCW
        '
        Me.ButtonCW.BackColor = System.Drawing.Color.White
        Me.ButtonCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCW.Location = New System.Drawing.Point(128, 402)
        Me.ButtonCW.Name = "ButtonCW"
        Me.ButtonCW.Size = New System.Drawing.Size(33, 22)
        Me.ButtonCW.TabIndex = 13
        Me.ButtonCW.UseVisualStyleBackColor = False
        '
        'ButtonDB
        '
        Me.ButtonDB.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDB.Location = New System.Drawing.Point(50, 381)
        Me.ButtonDB.Name = "ButtonDB"
        Me.ButtonDB.Size = New System.Drawing.Size(33, 22)
        Me.ButtonDB.TabIndex = 14
        Me.ButtonDB.UseVisualStyleBackColor = False
        '
        'LabelT1
        '
        Me.LabelT1.AutoSize = True
        Me.LabelT1.Location = New System.Drawing.Point(3, 0)
        Me.LabelT1.Name = "LabelT1"
        Me.LabelT1.Size = New System.Drawing.Size(128, 272)
        Me.LabelT1.TabIndex = 0
        Me.LabelT1.Text = "全局变量" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "背景颜色" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "字体颜色" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "字体大小" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "字体名称" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "生成模式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "缩放比例    50%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "屏幕大小  宽" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       " &
    "   高"
        '
        'TabPageCode
        '
        Me.TabPageCode.Controls.Add(Me.TextBoxCode)
        Me.TabPageCode.Location = New System.Drawing.Point(4, 26)
        Me.TabPageCode.Name = "TabPageCode"
        Me.TabPageCode.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCode.Size = New System.Drawing.Size(816, 486)
        Me.TabPageCode.TabIndex = 1
        Me.TabPageCode.Text = "代码"
        Me.TabPageCode.UseVisualStyleBackColor = True
        '
        'TextBoxCode
        '
        Me.TextBoxCode.AcceptsTab = True
        Me.TextBoxCode.BackColor = System.Drawing.Color.White
        Me.TextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCode.EnableAutoDragDrop = True
        Me.TextBoxCode.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxCode.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCode.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(810, 480)
        Me.TextBoxCode.TabIndex = 7
        Me.TextBoxCode.Text = "//以下代码由LPTMaker生成"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControlHTML)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 516)
        Me.SplitContainer1.SplitterDistance = 824
        Me.SplitContainer1.TabIndex = 1
        '
        'TabPageHTML
        '
        Me.TabPageHTML.Controls.Add(Me.TextBoxHTML)
        Me.TabPageHTML.Location = New System.Drawing.Point(4, 26)
        Me.TabPageHTML.Name = "TabPageHTML"
        Me.TabPageHTML.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageHTML.Size = New System.Drawing.Size(816, 486)
        Me.TabPageHTML.TabIndex = 2
        Me.TabPageHTML.Text = "HTML"
        Me.TabPageHTML.UseVisualStyleBackColor = True
        '
        'TextBoxHTML
        '
        Me.TextBoxHTML.AcceptsTab = True
        Me.TextBoxHTML.BackColor = System.Drawing.Color.White
        Me.TextBoxHTML.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxHTML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxHTML.EnableAutoDragDrop = True
        Me.TextBoxHTML.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxHTML.ForeColor = System.Drawing.Color.Black
        Me.TextBoxHTML.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxHTML.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxHTML.Name = "TextBoxHTML"
        Me.TextBoxHTML.Size = New System.Drawing.Size(810, 480)
        Me.TextBoxHTML.TabIndex = 8
        Me.TextBoxHTML.Text = "<!--以下HTML代码由LPTMaker生成-->"
        '
        'FrmMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 516)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMaker"
        Me.Text = "LPT Maker"
        Me.TabControlHTML.ResumeLayout(False)
        Me.TabPageDesign.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDownH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCode.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPageHTML.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlHTML As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDesign As System.Windows.Forms.TabPage
    Friend WithEvents TabPageCode As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxBC As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFC As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxBC As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxFC As System.Windows.Forms.PictureBox
    Friend WithEvents NumericUpDownFS As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelT1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCode As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonPK As System.Windows.Forms.Button
    Friend WithEvents ButtonDG As System.Windows.Forms.Button
    Friend WithEvents ButtonOR As System.Windows.Forms.Button
    Friend WithEvents ButtonDB As System.Windows.Forms.Button
    Friend WithEvents ButtonCW As System.Windows.Forms.Button
    Friend WithEvents ButtonCB As System.Windows.Forms.Button
    Friend WithEvents ButtonCR As System.Windows.Forms.Button
    Friend WithEvents ButtonCG As System.Windows.Forms.Button
    Friend WithEvents ButtonFSS As System.Windows.Forms.Button
    Friend WithEvents ButtonFSB As System.Windows.Forms.Button
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
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonFS16 As System.Windows.Forms.Button
    Friend WithEvents ButtonFS12 As System.Windows.Forms.Button
    Friend WithEvents ButtonH4 As System.Windows.Forms.Button
    Friend WithEvents ButtonH3 As System.Windows.Forms.Button
    Friend WithEvents ButtonH2 As System.Windows.Forms.Button
    Friend WithEvents ButtonH1 As System.Windows.Forms.Button
    Friend WithEvents RadioButtonPX As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonEM As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDownH As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownW As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxFontName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNM As System.Windows.Forms.Button
    Friend WithEvents ButtonI As System.Windows.Forms.Button
    Friend WithEvents ButtonB As System.Windows.Forms.Button
    Friend WithEvents ButtonU As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabPageHTML As TabPage
    Friend WithEvents TextBoxHTML As RichTextBox
End Class
