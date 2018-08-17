Public Class FrmMain
    Dim KSCRLF() As String
    Public BackGroundColor As Color
    Public FontColor As Color
    Public AllFont As Font = New Font("新宋体", 16)
    Public LinPutLin As New List(Of String) '文件内容
    Public LinPutLinNow As Integer '当前行
    Public MyPath As String '文件地址
    Public FileVerizon As Single = -1 '文件版本
    Public FileVerizonDate As Date '文件储存时间
    Dim IsAutoRun As Boolean = False '是否自动运行
    Public ReadOnly Verizon As Single = My.Resources.Verizon
    Public ReadOnly VerizonTime As Date = My.Resources.VerizonTime

    '这里是Lineput的上一页功能
    Public HistoryID As Integer = 0 '记录当前历史记录到的id
    Public History As New List(Of String) '通过lps记录当前页面

#Region "LPSTool"
    'Public Line As New List(Of ClsLine)
    Public Function MakeText(RTB As RichTextBox, LineSet As ClsLineSet) As String
        Dim ID As Integer = 0
        Dim tmp As ClsLine
        Dim Line As New List(Of ClsLine)
        MakeText = "//以下代码由LPSTool生成:|Verizon#" & Verizon & ":|" & vbCrLf
        If RTB.Text.Length = 0 Then
            Exit Function
        End If
        If LineSet.Mode = ClsLineSet.OutPutMod.LPS Then
            If Not LineSet.BackColor = Nothing Then
                MakeText &= "BackColor#" & ColorTOHTML(LineSet.BackColor) & ":|"
            End If
            If Not LineSet.FontColor = Nothing Then
                MakeText &= "AllFontColor#" & ColorTOHTML(LineSet.FontColor) & ":|"
            End If
            If Not LineSet.FontSize = Nothing Then
                MakeText &= "AllFontSize#" & LineSet.FontSize & ":|"
            End If
            If Not LineSet.FontFamily = Nothing Then
                MakeText &= "AllFont#" & LineSet.FontFamily & ":|"
            End If
            MakeText &= vbCrLf
        End If
        Line.Add(New ClsLine(LineSet))
        RTB.Select(0, 1)
        Line(ID).Text = RTB.SelectedText
        Line(ID).FontColor = RTB.SelectionColor
        Line(ID).FontSize = Int(RTB.SelectionFont.Size * 20) * 0.1
        Line(ID).FontFamily = RTB.SelectionFont.FontFamily
        Line(ID).SetFontStyle(RTB.SelectionFont.Style)
        For i = 1 To RTB.Text.Length - 1
            RTB.Select(i, 1)
            tmp = New ClsLine(LineSet) With {
                .Text = RTB.SelectedText,
                .FontColor = RTB.SelectionColor,
                .FontSize = Int(RTB.SelectionFont.Size * 20) * 0.1,
                .FontFamily = RTB.SelectionFont.FontFamily
            }
            tmp.SetFontStyle(RTB.SelectionFont.Style)
            If tmp.IsSameLine(Line(ID)) Then
                Line(ID).Text &= tmp.Text
            Else
                Line.Add(tmp)
                ID += 1
            End If
        Next
        For i = 0 To Line.Count - 1
            MakeText &= Line(i).GetLPTText() & vbCrLf
        Next
    End Function
    Public Sub LPSOpen(LPS As String, RTB As RichTextBox, LineSet As ClsLineSet)
        LineSet.Width = RTB.Width
        LineSet.BackColor = RTB.BackColor
        Dim LPSLine() As String
        LPSLine = Split(LPS, vbLf)
        Dim tmp As ClsLine
        For i = 0 To LPSLine.Length - 1
            tmp = New ClsLine(LPSLine(i), LineSet)
            If LineSet.Mode = ClsLineSet.OutPutMod.Maker Then
                If FrmMaker.RadioButtonPX.Checked Then
                    Output(RTB, tmp.Text, tmp.ToColor, New Font(tmp.ToFont.FontFamily, tmp.ToFont.Size / 2, tmp.ToFont.Style))
                Else
                    Output(RTB, tmp.Text, tmp.ToColor, tmp.ToFont)
                End If
                'Output(RTB, tmp.Text, tmp.ToColor, New Font(tmp.ToFont.FontFamily, tmp.ToFont.Size / 16, tmp.ToFont.Style))
            Else
                Output(RTB, tmp.Text, tmp.ToColor, tmp.ToFont)
            End If
        Next
        RTB.BackColor = LineSet.BackColor

    End Sub
    Public Sub Output(RTB As RichTextBox, text As String, Color As Color, MYFont As Font)
        Dim SelectionStart, SelectionLength As Integer
        SelectionStart = RTB.TextLength
        SelectionLength = text.Length

        RTB.AppendText(text)
        RTB.Select(SelectionStart, SelectionLength)
        RTB.SelectionColor = Color
        RTB.SelectionFont = MYFont
        RTB.SelectionStart = RTB.TextLength
    End Sub
    Public Function MakeHTML(RTB As RichTextBox, LineSet As ClsLineSet) As String
        Dim ID As Integer = 0
        Dim tmp As ClsLine
        Dim Line As New List(Of ClsLine)
        MakeHTML = "<!--以下HTML代码由LPTMaker生成 Verizon#" & Verizon & "-->" & vbCrLf '& "<style>p{padding:0px; margin:0px;}</style>" & vbCrLf
        If RTB.Text.Length = 0 Then
            Exit Function
        End If
        Line.Add(New ClsLine(LineSet))
        RTB.Select(0, 1)
        Line(ID).Text = RTB.SelectedText
        Line(ID).FontColor = RTB.SelectionColor
        Line(ID).FontSize = Int(RTB.SelectionFont.Size * 20) * 0.1
        Line(ID).FontFamily = RTB.SelectionFont.FontFamily
        Line(ID).SetFontStyle(RTB.SelectionFont.Style)
        For i = 1 To RTB.Text.Length - 1
            RTB.Select(i, 1)
            tmp = New ClsLine(LineSet) With {
                .Text = RTB.SelectedText,
                .FontColor = RTB.SelectionColor,
                .FontSize = Int(RTB.SelectionFont.Size * 20) * 0.1,
                .FontFamily = RTB.SelectionFont.FontFamily
            }
            tmp.SetFontStyle(RTB.SelectionFont.Style)

            If tmp.IsSameLine(Line(ID)) Then
                Line(ID).Text &= tmp.Text
            Else
                Line.Add(tmp)
                ID += 1
            End If
        Next
        For i = 0 To Line.Count - 1
            MakeHTML &= Line(i).GetHTMLText() & vbCrLf
        Next
    End Function
#End Region
#Region "STR加密2"
    '这里可以自定义你的自己的加密代码
    Friend Function STR2Code(CodeThing As String, Optional rnds As Integer = Nothing) As String
        Return CodeThing
    End Function
    Friend Function STR2DeCode(CodeThing As String) As String
        Return CodeThing
    End Function
#End Region
#Region "用户数据"
    Public UserString(9) As String
    Public UserInteger(9) As Integer
    Public UserBoolean(9) As Boolean
    Public UserDouble(9) As Double
    Public Function ReadUserDatatype(UserInput As String) As String
        Dim Input As String, Datatype As String
        If UserInput.Contains("str") Then
            Input = UserInput.Replace("str", "")
            Datatype = "str"
        ElseIf UserInput.Contains("dbl") Then
            Input = UserInput.Replace("dbl", "")
            Datatype = "dbl"
        ElseIf UserInput.Contains("int") Then
            Input = UserInput.Replace("int", "")
            Datatype = "int"
        ElseIf UserInput.Contains("bool") Then
            Input = UserInput.Replace("bool", "")
            Datatype = "bool"
        Else
            Return "err"
        End If
        If IsNumeric(Input) Then
            If Input < 0 Or Input > 9 Then
                Return "err"
            End If
            Return Datatype
        End If
        Return "err"
    End Function
    Public Function ReadUserDataid(UserInput As String) As Integer
        Dim Input As String
        If UserInput.Contains("str") Then
            Input = UserInput.Replace("str", "")
        ElseIf UserInput.Contains("dbl") Then
            Input = UserInput.Replace("dbl", "")
        ElseIf UserInput.Contains("int") Then
            Input = UserInput.Replace("int", "")
        ElseIf UserInput.Contains("bool") Then
            Input = UserInput.Replace("bool", "")
        Else
            Return -1
        End If
        If IsNumeric(Input) Then
            If Input < 0 Or Input > 9 Then
                Return "err"
            End If
            Return Input
        End If
        Return -1
    End Function
    Public Function ReadUserData(UserInput As String)
        Dim Input As String, Datatype As String, Userid As Integer
        If UserInput.Contains("str") Then
            Input = UserInput.Replace("str", "")
            Datatype = "str"
        ElseIf UserInput.Contains("dbl") Then
            Input = UserInput.Replace("dbl", "")
            Datatype = "dbl"
        ElseIf UserInput.Contains("int") Then
            Input = UserInput.Replace("int", "")
            Datatype = "int"
        ElseIf UserInput.Contains("bool") Then
            Input = UserInput.Replace("bool", "")
            Datatype = "bool"
        Else
            Return "err"
        End If
        If IsNumeric(Input) Then
            If Input < 0 Or Input > 9 Then
                Return "err"
            End If
        End If
        Userid = Input
        Select Case Datatype
            Case "str"
                Return UserString(Userid)
            Case "dbl"
                Return UserDouble(Userid)
            Case "bool"
                Return UserBoolean(Userid)
            Case "int"
                Return UserInteger(Userid)
        End Select
        Return "err"
    End Function
    'Public Function ReadUserData(Usertype As String, Userid As Integer)
    '    If Userid < 0 Or Userid > 9 Then
    '        Return "err"
    '    End If
    '    Select Case Usertype
    '        Case "str"
    '            Return UserString(Userid)
    '        Case "dbl"
    '            Return UserDouble(Userid)
    '        Case "bool"
    '            Return UserBoolean(Userid)
    '        Case "int"
    '            Return UserInteger(Userid)
    '    End Select
    '    Return "err"
    'End Function
    Public Sub SetUserData(UserInput As String, SetThing As String)
        Dim Input As String, Datatype As String, Userid As Integer
        If UserInput.Contains("str") Then
            Input = UserInput.Replace("str", "")
            Datatype = "str"
        ElseIf UserInput.Contains("dbl") Then
            Input = UserInput.Replace("dbl", "")
            Datatype = "dbl"
        ElseIf UserInput.Contains("int") Then
            Input = UserInput.Replace("int", "")
            Datatype = "int"
        ElseIf UserInput.Contains("bool") Then
            Input = UserInput.Replace("bool", "")
            Datatype = "bool"
        Else
            Output("SetUserData Err:Can't find Datatype" & vbCrLf, Color.Red)
            Exit Sub
        End If
        If IsNumeric(Input) Then
            If Input < 0 Or Input > 9 Then
                Output("SetUserData Err:Can't find Userid" & vbCrLf, Color.Red)
                Exit Sub
            End If
        End If
        Userid = Input
        Select Case Datatype
            Case "str"
                UserString(Userid) = SetThing
            Case "dbl"
                If Not IsNumeric(SetThing) Then
                    Exit Sub
                End If
                UserDouble(Userid) = SetThing
            Case "bool"
                Select Case LCase(SetThing)
                    Case "1", "t", "true", "2"
                        UserBoolean(Userid) = True
                    Case Else
                        UserBoolean(Userid) = False
                End Select
            Case "int"
                If Not IsNumeric(SetThing) Then
                    Exit Sub
                End If
                UserInteger(Userid) = SetThing
        End Select
        'Output("SetUserData Err:Can't find Datatype" & vbCrLf, Color.Red)
    End Sub

    'Public Sub SetUserData(Usertype As String, Userid As Integer, SetThing As String)
    '    If Userid < 0 Or Userid > 9 Then
    '        Exit Sub
    '    End If
    '    Select Case Usertype
    '        Case "str"
    '            UserString(Userid) = SetThing
    '        Case "dbl"
    '            If Not IsNumeric(SetThing) Then
    '                Exit Sub
    '            End If
    '            UserDouble(Userid) = SetThing
    '        Case "bool"
    '            Select Case LCase(SetThing)
    '                Case "1", "t", "true", "2"
    '                    UserBoolean(Userid) = True
    '                Case Else
    '                    UserBoolean(Userid) = False
    '            End Select
    '        Case "int"
    '            If Not IsNumeric(SetThing) Then
    '                Exit Sub
    '            End If
    '            UserInteger(Userid) = SetThing
    '    End Select
    'End Sub

#End Region
#Region "按键" '

    Private Sub 上一行ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上一行ToolStripMenuItem.Click, ButtonF.Click
        If HistoryID > 1 Then
            If HistoryID = History.Count Then
                '    History.Add(TextBox1.Text)
                '    'History.Add(ColorTOHTML(TextBox1.BackColor) & TextBox1.Rtf)
                HistoryID -= 1
            End If
            '增加记录功能



            HistoryID -= 1
            TextBox1.SelectAll()
            TextBox1.Text = ""
            TextBox1.BackColor = HTMLTOColor(Microsoft.VisualBasic.Left(History(HistoryID), 6))
            TextBox1.Rtf = Microsoft.VisualBasic.Right(History(HistoryID), History(HistoryID).Length - 6)
            'TextBox1.Text = History(HistoryID)
        End If
    End Sub
    Private Sub 下一行NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 下一行NToolStripMenuItem.Click, ButtonN.Click
        If History.Count > HistoryID + 1 Then
            TextBox1.SelectAll()
            TextBox1.Text = ""
            HistoryID += 1
            TextBox1.BackColor = HTMLTOColor(Microsoft.VisualBasic.Left(History(HistoryID), 6))
            TextBox1.Rtf = Microsoft.VisualBasic.Right(History(HistoryID), History(HistoryID).Length - 6)
            'TextBox1.Text = History(HistoryID)
            Exit Sub
        ElseIf History.Count > HistoryID Then
            HistoryID += 1
        End If
        GoNext()
    End Sub

    Private Sub 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click
        Savefile()
    End Sub
    Private Sub 导入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导入ToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub 显示工具栏ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示工具栏ToolStripMenuItem.Click
        PanelTool.Visible = False
        显示工具栏ToolStripMenuItem.Checked = Not 显示工具栏ToolStripMenuItem.Checked
        ButtonShowTool.Visible = 显示工具栏ToolStripMenuItem.Checked

    End Sub
    Private Sub 剪切TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切TToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub
    Private Sub 复制CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制CToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub
    Private Sub 粘贴PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴PToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub
    Private Sub 撤消UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤消UToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub
    Private Sub 置于顶层TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 置于顶层TToolStripMenuItem.Click
        TopMost = Not TopMost
        置于顶层TToolStripMenuItem.Checked = TopMost
    End Sub
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        重复RToolStripMenuItem.Enabled = TextBox1.CanRedo
        撤消UToolStripMenuItem.Enabled = TextBox1.CanUndo
    End Sub
    Private Sub 背景颜色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 背景颜色ToolStripMenuItem.Click
        Dim ColorDialog As New ColorDialog
        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.BackColor = ColorDialog.Color
        End If
    End Sub
    Private Sub 重复RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重复RToolStripMenuItem.Click
        TextBox1.Redo()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox1.SelectAll()
        TextBox1.SelectedText = ""
    End Sub
    Private Sub 全选AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选AToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub
    Private Sub 字体ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体ToolStripMenuItem.Click
        Dim FontDialog As New FontDialog With {
            .Font = TextBox1.SelectionFont
        }

        If FontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.SelectionFont = FontDialog.Font
        End If
    End Sub
    Private Sub 字体颜色DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体颜色DToolStripMenuItem.Click
        Dim ColorDialog As New ColorDialog With {
            .Color = TextBox1.SelectionColor
        }

        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.SelectionColor = ColorDialog.Color
        End If
    End Sub

    Private Sub ButtonFB_click(sender As Object, e As EventArgs) Handles ButtonFB.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim size As Single = TextBox1.SelectionFont.Size * 1.1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, size, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub ButtonFS_Click(sender As Object, e As EventArgs) Handles ButtonFS.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim size As Single = TextBox1.SelectionFont.Size * 0.9
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, size, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub Buttoncg_click(sender As Object, e As EventArgs) Handles ButtonCG.Click
        TextBox1.SelectionColor = Color.LimeGreen
    End Sub
    Private Sub Buttoncr_click(sender As Object, e As EventArgs) Handles ButtonCR.Click
        TextBox1.SelectionColor = Color.Red
    End Sub
    Private Sub Buttoncb_click(sender As Object, e As EventArgs) Handles ButtonCB.Click
        TextBox1.SelectionColor = Color.Black
    End Sub
    Private Sub Buttoncw_click(sender As Object, e As EventArgs) Handles ButtonCW.Click
        TextBox1.SelectionColor = Color.White
    End Sub
#End Region
    Private Sub GoBack()
        If TextBox1.CanUndo Then
            TextBox1.Undo()
        End If
    End Sub
    Public Sub GoNext()
        If TextBox1.CanRedo Then
            TextBox1.Redo()
        Else
            ReadLine()
        End If
    End Sub

    Dim DeLoop As Integer = 0
    Public Function LineSetForMain() As ClsLineSet
        Return New ClsLineSet(AllFont.Size, FontColor, ClsLineSet.OutPutMod.LPS, TextBox1.Width, AllFont.FontFamily.Name, BackGroundColor)
    End Function

    Public Function SaveLPSFile() As String
        'With LineSet
        '    .BackColor = BackGroundColor
        '    .FontColor = FontColor
        '    .FontFamily = AllFont.FontFamily.Name
        '    .FontSize = AllFont.Size
        '    .Mode = ClsLineSet.OutPutMod.LPS
        '    .Width = TextBox1.Width
        'End With
        Return MakeText(TextBox1, LineSetForMain)
    End Function
    Public Sub ReadLine()

        If LinPutLin.Count <= LinPutLinNow Then
            Output("文件播放完毕 感谢您使用Lineput" & vbCrLf)
            Exit Sub
        ElseIf LinPutLinNow = 0 Then
            '这里只检查是否继续运行，HsCode或者Verizon在打开文件中Check
            If IsAutoRun Then
                LinPutLinNow += 1
                ReadLine()
            Else
                LinPutLinNow += 1
                IsAutoRun = True '运行过一次后之后都是自动运行了
            End If
            Exit Sub
        ElseIf LinPutLin(LinPutLinNow) = "" Then
            LinPutLinNow += 1
            ReadLine()
            Exit Sub
        End If

        If DeLoop = 100 Then
            MsgBox("死循环警告" & vbCrLf & "当重复运行125次时将会强制结束循环" & vbCrLf & "输入Loop清空循环计数", MsgBoxStyle.Exclamation, "Endless loop warning")
            Output("Endless loop warning死循环警告" & vbCrLf & "当重复运行125次时将会强制结束循环" & vbCrLf & "输入Loop清空循环计数" & vbCrLf, Color.Orange, , FontStyle.Bold)
        ElseIf DeLoop = 125 Then
            MsgBox("死循环错误" & vbCrLf & "强制结束循环并退出LPT文件" & vbCrLf & "错误语句：  " & LinPutLinNow & "#  " & LinPutLin(LinPutLinNow), MsgBoxStyle.Critical, "Endless loop Error")
            Output("Endless loop Error死循环错误" & vbCrLf & "强制结束循环并退出LPT文件" & vbCrLf & "错误语句：  " & LinPutLinNow & "#  " & LinPutLin(LinPutLinNow) & vbCrLf & vbCrLf, Color.Red, , FontStyle.Bold)
            LinPutLin.Clear()
            DeLoop = 0
            LinPutLinNow = 0
            Exit Sub
        End If
        DeLoop += 1
        LPTCoder(Split(LinPutLin(LinPutLinNow), "//")(0), ReadMod.File)
        '历史记录只记录readline
        '历史记录开始
        If History.Count = HistoryID Then
            History.Add(ColorTOHTML(TextBox1.BackColor) & TextBox1.Rtf)
            'History.Add(TextBox1.Text)
            HistoryID += 1
        End If
        '历史记录结束
    End Sub
    Dim StopReadLine As Boolean = False
    Public Function HTMLTOColor(HTMLColor As String) As Color
        On Error GoTo Ero
        Dim Rv As Integer = 0
        Dim Gv As Integer = 0
        Dim Bv As Integer = 0
        If HTMLColor.Length = 6 Then
            Rv = CLng("&H" & HTMLColor(0) & HTMLColor(1))
            Gv = CLng("&H" & HTMLColor(2) & HTMLColor(3))
            Bv = CLng("&H" & HTMLColor(4) & HTMLColor(5))
        ElseIf HTMLColor.Length = 3 Then
            Rv = CLng("&H" & HTMLColor(0)) * 16
            Gv = CLng("&H" & HTMLColor(1)) * 16
            Bv = CLng("&H" & HTMLColor(2)) * 16
        Else
            'Output("颜色(HTMLColor)格式错误" & vbCrLf, Color.Red)
Ero:        Return Nothing
        End If
        Return Color.FromArgb(Rv, Gv, Bv)
    End Function

    Enum ReadMod
        KeyPress
        File
    End Enum

    Public Sub LPTCoder(Line As String, RMod As ReadMod)
        'LPS中没有动态文本和人物选项 
        Randomize()
        Line = Line.Replace("/rnd", Rnd())
        Line = Line.Replace("/nid", LinPutLinNow)

        For i = 0 To 9
            Line = Line.Replace("/str" & i, UserString(i))
            Line = Line.Replace("/int" & i, UserInteger(i))
            Line = Line.Replace("/bool" & i, UserBoolean(i))
            Line = Line.Replace("/dbl" & i, UserDouble(i))
        Next
        '这里设置非常不妥，建议制作成语言
        If Line.Contains("/input") Then
            Line = Line.Replace("/input", InputBox("请输入值"))
        End If
        If Line.Contains("/msgyesno") Then
            If MsgBox("确认?", vbYesNo) = vbYes Then
                Line = Line.Replace("/msgyesno", "True")
            Else
                Line = Line.Replace("/msgyesno", "False")
            End If
        End If


        Dim NowLine() As String
        NowLine = Split(Line, ":|")
        '缓存变量：
        '采用最新的 LPT+S2.0规范
        '新增加密
        Dim MyFontsize As Single = AllFont.Size  '
        Dim MyFontColor As Color = FontColor '
        Dim MyFontFamily As FontFamily = AllFont.FontFamily
        Dim GoToNext As Boolean = True      '是否跳到下一行’注意KEYPASS无此选项
        Dim GoToMSG As Boolean = False      '
        Dim GoToPrinter As Boolean = False  '
        Dim Bsty As Boolean = False         '是否加粗
        Dim Isty As Boolean = False         '是否斜体
        Dim Usty As Boolean = False         '是否下划线
        Dim Delsty As Boolean = False       '是否删除
        Dim IsEM As Boolean = False         '是否使用最新的EM格式
        Dim FastOutput As Boolean = False   '快速输出

        Dim Input(1) As String
        Dim MaxLen As Integer = UBound(NowLine) - 1
        If RMod = ReadMod.KeyPress Then
            MaxLen += 1
        End If
        For i = 0 To MaxLen
            If NowLine(i) <> "" Then
                Input = Split(NowLine(i), "#", 2)
                Select Case LCase(Input(0))
                    '四则运算：其中 +相当于or *相当于and
                    Case "+", "&"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("+ Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(2) As String
                            times = Split(Input(1), ",")
                            If UBound(times) < 2 Then
                                Output("+ Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                If IsNumeric(times(1)) And IsNumeric(times(2)) And Input(0) <> "&" Then
                                    Dim Times1 As Double = times(1)
                                    SetUserData(times(0), Times1 + times(2))
                                Else
                                    SetUserData(times(0), times(1) & times(2))
                                End If
                            End If
                        End If
                    Case "set"
                        If UBound(Input) = 0 Then
                            Output("Set Nothing err" & vbCrLf, Color.Red)
                        Else
                            Dim times(1) As String
                            times = Split(Input(1), ",")
                            If UBound(times) = 0 Then
                                Output("Set Nothing err" & vbCrLf, Color.Red)
                            Else
                                SetUserData(times(0), times(1))
                            End If
                        End If
                    Case "-"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("- Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(2) As String
                            times = Split(Input(1), ",")
                            If UBound(times) < 2 Then
                                Output("- Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                If IsNumeric(ReadUserData(times(1))) And IsNumeric(ReadUserData(times(2))) Then
                                    Dim Times1 As Double = times(1)
                                    SetUserData(times(0), Times1 - times(2))
                                End If
                            End If
                        End If
                    Case "*"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("* Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(2) As String
                            times = Split(Input(1), ",")
                            If UBound(times) < 2 Then
                                Output("* Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                If IsNumeric(times(1)) And IsNumeric(times(2)) Then
                                    Dim Times1 As Double = times(1)
                                    SetUserData(times(0), Times1 * times(2))
                                End If
                            End If
                        End If
                    Case "/"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("/ Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(2) As String
                            times = Split(Input(1), ",")
                            If UBound(times) < 2 Then
                                Output("/ Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                If IsNumeric(times(1)) And IsNumeric(times(2)) Then
                                    If times(2) <> 0 Then
                                        Dim Times1 As Double = times(1)
                                        SetUserData(times(0), Times1 / times(2))
                                    End If
                                End If
                            End If
                        End If
                    Case "="
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("= Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(2) As String
                            times = Split(Input(1), ",")
                            If UBound(times) < 2 Then
                                Output("= Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                SetUserData(times(0), (times(1) = times(2)))
                            End If
                        End If
                    Case "not"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("not Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(1) As String
                            times = Split(Input(1), ",")
                            If UBound(times) = 0 Then
                                Output("not Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                Select Case LCase(times(1))
                                    Case "1", "t", "true", "2"
                                        SetUserData(times(0), False)
                                    Case Else
                                        SetUserData(times(0), True)
                                End Select
                            End If
                        End If
                    Case "and", "&&"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("and Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(2) As String
                            times = Split(Input(1), ",")
                            If UBound(times) < 2 Then
                                Output("and Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                Dim Bol(1) As Boolean
                                Select Case LCase(times(2))
                                    Case "1", "t", "true", "2"
                                        Bol(0) = True
                                    Case Else
                                        Bol(0) = False
                                End Select
                                Select Case LCase(times(1))
                                    Case "1", "t", "true", "2"
                                        Bol(1) = True
                                    Case Else
                                        Bol(1) = False
                                End Select
                                SetUserData(times(0), (Bol(0) And Bol(1)))
                            End If
                        End If
                    Case "or", "||"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("and Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Dim times(2) As String
                            times = Split(Input(1), ",")
                            If UBound(times) < 2 Then
                                Output("and Nothing err" & vbCrLf, Color.Red)
                            ElseIf ReadUserDatatype(times(0)) <> "err" Then
                                Dim Bol(1) As Boolean
                                Select Case LCase(times(2))
                                    Case "1", "t", "true", "2"
                                        Bol(0) = True
                                    Case Else
                                        Bol(0) = False
                                End Select
                                Select Case LCase(times(1))
                                    Case "1", "t", "true", "2"
                                        Bol(1) = True
                                    Case Else
                                        Bol(1) = False
                                End Select
                                SetUserData(times(0), (Bol(0) Or Bol(1)))
                            End If
                        End If
                    Case "if"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Output("if Nothing Err" & vbCrLf, Color.Red)
                        Else
                            Select Case LCase(Input(1))
                                Case "1", "t", "true", "2"
                                Case Else
                                    If GoToNext Then
                                        LinPutLinNow += 1
                                        ReadLine()
                                    End If
                                    Exit Sub
                            End Select
                        End If





                        'KEYPASS
                    Case "open", "openfile", "fileopen"
                        If UBound(Input) = 0 Then
                            OpenFile()
                        Else
                            OpenFile(Input(1))
                        End If
                        GoTo GoNext
                    Case "save", "savefile"
                        If UBound(Input) = 0 Then
                            Savefile()
                        Else
                            Savefile(Input(1))
                        End If
                        GoTo GoNext
                    Case "editor", "ed"
                        FrmEditor.Show()
                    Case "maker", "mk"
                        FrmMaker.Show()
                    Case "pw", "password"
                        FrmPassword.Show()
                    Case "verizon", "myverizon"
                        Output("当前Lineput版本" & Verizon & " RE:" & VerizonTime.ToShortDateString & vbCrLf)
                    Case "fileverizon"
                        Output("当前文件版本" & FileVerizon & " RE:" & FileVerizonDate.ToShortDateString & vbCrLf)
                        If FileVerizon = -1 Then
                            Output("没有检测到版本信息，可能是旧版本LPT文件，将会产生兼容性问题" & vbCrLf, Color.Red)
                        ElseIf FileVerizon > Verizon Then
                            Output("文件版本高于当前LinePut版本，可能会产生兼容性问题，请前往http://www.exlb.pw 获取Lineput最新版本" & vbCrLf, Color.Red)
                        ElseIf FileVerizon < Verizon Then
                            Output("文件版本低于当前LinePut版本，可能会产生兼容性问题" & vbCrLf, Color.Red)
                        End If
                    Case "exit"
                        Me.Close()
                    Case "next"
                        GoNext()
                    Case "back"
                        GoBack()
                    Case "print"
                        RMod = ReadMod.File
                        GoToNext = False
                        LinPutLinNow -= 1


                        'FILE
                    Case "fontcolor", "allfontcolor"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            If RMod = ReadMod.KeyPress Then
                                Dim ColorDialog As New ColorDialog
                                If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                                    FontColor = ColorDialog.Color
                                    FontColor = MyFontColor
                                    TextBox1.ForeColor = FontColor
                                    Output("前景色设置完成" & vbCrLf, ColorDialog.Color)
                                End If
                            End If
                        Else
                            If Nothing = (HTMLTOColor(Input(1))) Then Output("前景色设置错误")
                            MyFontColor = HTMLTOColor(Input(1))
                            If RMod = ReadMod.KeyPress Or Input(0) = "allfontcolor" Then
                                FontColor = MyFontColor
                                If RMod = ReadMod.KeyPress Then
                                    TextBox1.ForeColor = FontColor
                                    Output("前景色设置完成" & vbCrLf, FontColor)
                                End If
                            End If
                        End If
                    Case "sleep"
                        GoToNext = False
                        If UBound(Input) = 0 Then
                            TimerNext.Interval = 100
                            TimerNext.Enabled = True
                        ElseIf UBound(Input) = 1 Then
                            If IsNumeric(Input(1)) Then
                                If Input(1) > 0 Then
                                    TimerNext.Interval = Input(1)
                                    TimerNext.Enabled = True
                                End If
                            End If
                        End If
                        GoToNext = False
                    Case "shell"
                        'On error Resume Next
                        If UBound(Input) <> 0 Then
                            Shell(Input(1))
                        End If
                    Case "printer", "colorprinter"
                        GoToPrinter = True

                        PrinterColorRND = Not (Input(0) = "printer")
                        If UBound(Input) = 0 Then
                            PrinterTick = 2000
                        ElseIf UBound(Input) = 1 Then
                            If IsNumeric(Input(1)) Then
                                PrinterTick = Input(1) * 1000
                            End If
                        End If
                    Case "readonly"
                        TextBox1.ReadOnly = True
                        只读ToolStripMenuItem.Checked = True
                    Case "readwrite"
                        TextBox1.ReadOnly = False
                        只读ToolStripMenuItem.Checked = False
                    Case "llcc"
                        Timerllcc.Enabled = Not Timerllcc.Enabled
                    Case "llccon"
                        Timerllcc.Enabled = True
                    Case "llccoff"
                        Timerllcc.Enabled = False
                    Case "fontsize", "allfontsize"
                        If UBound(Input) = 0 Then
                            Output("请输入字体大小(1-999)" & vbCrLf, Color.Red)
                        ElseIf IsNumeric(Input(1)) Then
                            IsEM = False
                            MyFontsize = Input(1)
                            If RMod = ReadMod.KeyPress Or Input(0) = "allfontsize" Then
                                AllFont = New Font(AllFont.FontFamily, MyFontsize)
                            End If
                        Else
                            Output("字体大小设置错误" & vbCrLf, Color.Red)
                        End If
                    Case "em"
                        If UBound(Input) = 0 Then
                        ElseIf IsNumeric(Input(1)) Then
                            IsEM = True
                            MyFontsize = Input(1)
                        Else
                            Output("EM字体设置错误" & vbCrLf, Color.Red)
                        End If
                    Case "u"
                        Usty = Not Usty
                    Case "b"
                        Bsty = Not Bsty
                    Case "i"
                        Isty = Not Isty
                    Case "d"
                        Delsty = Not Delsty
                    Case "font", "allfont"
                        If UBound(Input) = 0 Then
                            Output("请输入字体名称 例如 宋体,Arial" & vbCrLf, Color.Red)
                        Else
                            On Error GoTo GoNext
                            MyFontFamily = New FontFamily(Input(1))
                            If RMod = ReadMod.KeyPress Or Input(0) = "allfont" Then
                                AllFont = New Font(AllFont.FontFamily, AllFont.Size)
                            End If

                        End If
                    Case "backcolor"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Dim ColorDialog As New ColorDialog
                            If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                                BackGroundColor = ColorDialog.Color
                                TextBox1.BackColor = BackGroundColor
                                Output("背景色设置完成" & vbCrLf)
                            End If
                        Else
                            If Nothing = (HTMLTOColor(Input(1))) Then Output("背景色设置错误")
                            BackGroundColor = HTMLTOColor(Input(1))
                            TextBox1.BackColor = BackGroundColor
                            If RMod = ReadMod.KeyPress Then
                                Output("背景色设置完成" & vbCrLf)
                            End If
                        End If
                    Case "goto"
                        If UBound(Input) = 0 Then
                            Output("请输入指针" & vbCrLf, Color.Red)
                        ElseIf IsNumeric(Input(1)) Then
                            If Input(1) <= LinPutLin.Count Then
                                LinPutLinNow = Input(1)
                            Else
                                Output("指针错误" & vbCrLf, Color.Red)
                            End If
                        Else
                            Output("指针错误-输入有误" & vbCrLf, Color.Red)
                        End If
                    Case "shell"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            Dim OpenFileDialogShow As New OpenFileDialog With {
                                .FileName = "",
                                .Filter = "可运行文件|*.exe|所有文件|*.*"
                            }

                            If OpenFileDialogShow.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                GoTo GoNext
                            End If
                            Shell(OpenFileDialogShow.FileName)
                        Else
                            Shell(Input(1))
                        End If
                    Case "cls"
                        If FastOutput Then
                            TextBox1.Text = ""
                        Else
                            TextBox1.SelectAll()
                            TextBox1.SelectedText = ""
                        End If
                    Case "fo"
                        FastOutput = True
                    Case "timer"
                        Dim FrmTimer As New FrmTimer
                        If UBound(Input) = 0 Then
                            FrmTimer.TimeSet(60)
                            FrmTimer.Show()
                        ElseIf UBound(Input) = 1 Then
                            Dim times(1) As String
                            times = Split(Input(1), ",")
                            If UBound(times) = 0 Then
                                If IsNumeric(times(0)) Then FrmTimer.TimeSet(times(0))
                            ElseIf UBound(times) = 1 Then
                                If IsNumeric(times(0)) And IsNumeric(times(1)) Then FrmTimer.TimeSet(times(0), times(1))
                            Else
                                FrmTimer.TimeSet(60)
                            End If
                            FrmTimer.Show()
                        End If
                    Case "intimer"
                        If UBound(Input) = 0 Then
                            InTimerSet(60)
                        ElseIf UBound(Input) = 1 Then
                            If IsNumeric(Input(1)) Then
                                InTimerSet(Input(1))
                            ElseIf LCase(Input(1)) = "stop" Then
                                TimerInTimer.Enabled = False
                                Output("InTimer:已停止")
                            End If
                        End If
                    Case "img", "inimg"
                        'On error GoTo GoNext
                        Dim tmp As Boolean = (Input(0) = "inimg")
                        If UBound(Input) = 0 Then
                            If RMod = ReadMod.KeyPress Then
                                SendImage(, , tmp)
                                GoTo GoNext
                            End If
                        Else
                            Dim Size(2) As String
                            Size = Split(Input(1), ",")
                            If Size.Length <> 1 Then
                                SendImage(Size(0), New Size(Size(1), Size(2)), tmp)
                            Else
                                SendImage(Size(0), , tmp)
                            End If
                        End If
                    Case "opentxt", "txt"
                        If RMod = ReadMod.File Then
                            If UBound(Input) <> 0 Then
                                If ReadText(Input(1)) <> "" Then
                                    NowLine(UBound(NowLine)) = ReadText(Input(1))
                                End If
                            Else
                                Output("OPENTXT参数错误")
                            End If
                        Else
                            If UBound(Input) = 0 Then
                                OpenTextFile()
                            Else
                                OpenTextFile(Input(1))
                            End If
                        End If
                        GoTo GoNext

                    Case "loop"
                        DeLoop = 0
                        If RMod = ReadMod.KeyPress Then
                            Output("循环计数已清空")
                        End If
                    Case "mov", "movauto"
                        'On error GoTo GoNext
                        If UBound(Input) = 0 Then
                            SendMov(, , (Input(0) = "movauto"))
                        Else
                            Dim Size(2) As String
                            Size = Split(Input(1), ",")
                            If Size.Length = 1 Then
                                SendMov(Size(0), , (Input(0) = "movauto"))
                            Else
                                SendMov(Size(0), New Size(Size(1), Size(2)), (Input(0) = "movauto"))
                            End If
                        End If
                    Case "msg"
                        'MsgBox(NowLine(UBound(NowLine)))
                        If RMod = ReadMod.KeyPress Then
                            If UBound(Input) = 0 Then
                                Dim FrmMsgBox As New FrmMsgBox
                                FrmMsgBox.TextBox1.Text = InputBox("请输入MSG窗口消息", "MSG")
                                FrmMsgBox.Show()
                            Else
                                Dim FrmMsgBox As New FrmMsgBox
                                FrmMsgBox.TextBox1.Text = Input(1)
                                FrmMsgBox.Show()
                            End If
                        End If
                        GoToMSG = True
                    Case "h1"
                        IsEM = False
                        MyFontsize = 48
                    Case "h2"
                        IsEM = False
                        MyFontsize = 36
                    Case "h3"
                        IsEM = False
                        MyFontsize = 24
                    Case "h4"
                        IsEM = False
                        MyFontsize = 16
                    Case "h5"
                        IsEM = False
                        MyFontsize = 12
                    Case "h6"
                        IsEM = False
                        MyFontsize = 9


                    Case "e1"
                        IsEM = True
                        MyFontsize = 8
                    Case "e2"
                        IsEM = True
                        MyFontsize = 5
                    Case "e3"
                        IsEM = True
                        MyFontsize = 3
                    Case "e4"
                        IsEM = True
                        MyFontsize = 2
                    Case "e5"
                        IsEM = True
                        MyFontsize = 1.3
                    Case "e6"
                        IsEM = True
                        MyFontsize = 1
                    Case "e7"
                        IsEM = True
                        MyFontsize = 0.7
                    Case "e8"
                        IsEM = True
                        MyFontsize = 0.5
                    Case "e9"
                        IsEM = True
                        MyFontsize = 0.3
                    Case "pageend"
                        GoToNext = False
                    Case "end"
                        LinPutLinNow = LinPutLin.Count
                        Exit Sub
                    Case Else
                        If RMod = ReadMod.File Then
                            Output(vbCrLf & "Error: Can't Find the LineKey:""" & Input(0) & """" & vbCrLf, Color.Red)
                        Else
                            If Eggs(Input(0)) <> "" Then
                                Output(Eggs(Input(0)) & vbCrLf)
                            End If
                            Exit Sub
                        End If
                End Select
            End If
        Next
        If RMod = ReadMod.File Then
            NowLine(UBound(NowLine)) = TextReplace(NowLine(UBound(NowLine)))
            If IsEM Then
                MyFontsize = Int(Me.Width * MyFontsize * 0.1) * 0.1
            End If
            Dim sty As FontStyle = FontStyle.Regular
            If Bsty Then
                sty += 1
            End If
            If Delsty Then
                sty += 8
            End If
            If Usty Then
                sty += 4
            End If
            If Isty Then
                sty += 2
            End If
            Dim Tmp As Font
            Tmp = New Font(MyFontFamily, MyFontsize, sty)
            If GoToMSG Then
                Dim FrmMsgBox As New FrmMsgBox
                FrmMsgBox.TextBox1.Text = NowLine(UBound(NowLine))
                FrmMsgBox.TextBox1.ForeColor = MyFontColor
                FrmMsgBox.TextBox1.Font = Tmp
                FrmMsgBox.Show()
            ElseIf GoToPrinter Then
                PrinterGoToNext = GoToNext
                GoToNext = False
                Printer(NowLine(UBound(NowLine)), PrinterTick * 0.001, MyFontColor, MyFontsize)
            ElseIf FastOutput Then
                TextBox1.Font = Tmp
                TextBox1.AppendText(NowLine(UBound(NowLine)))
            Else
                Output(NowLine(UBound(NowLine)), MyFontColor, Tmp)
            End If
        End If
GoNext:
        If RMod = ReadMod.File Then
            '增加并循环使用ReadLine直到结束为止
            LinPutLinNow += 1
            If StopReadLine Then
                GoToNext = False
            End If
            If GoToNext Then
                ReadLine()
                'Else
                '为返回上级做准备
            End If
            DeLoop = 0
        End If
    End Sub


    Public Function ColorTOHTML(Color As Color) As String
        ColorTOHTML = Hex(Color.R * 256 ^ 2 + Color.G * 256 + Color.B)
        For i = 0 To 5 - ColorTOHTML.Length
            ColorTOHTML = "0" & ColorTOHTML
        Next
    End Function
    Public Sub Output(Outputthing As String, Color As Color, MYFont As Font)
        Dim SelectionStart, SelectionLength As Integer
        SelectionStart = TextBox1.TextLength
        SelectionLength = Outputthing.Length

        TextBox1.AppendText(Outputthing)
        TextBox1.Select(SelectionStart, SelectionLength)
        TextBox1.SelectionColor = Color
        TextBox1.SelectionFont = MYFont
        TextBox1.SelectionStart = TextBox1.TextLength
    End Sub
    Public Sub Output(Outputthing As String, Optional Color As Color = Nothing, Optional FSize As Integer = -1, Optional FontStyle As FontStyle = FontStyle.Regular)
        If FSize < 1 Then
            FSize = AllFont.Size
        End If
        If Color = Nothing Then
            Color = FontColor
        End If
        Dim SelectionStart, SelectionLength As Integer
        SelectionStart = TextBox1.TextLength
        SelectionLength = Outputthing.Length

        TextBox1.AppendText(Outputthing)
        TextBox1.Select(SelectionStart, SelectionLength)
        TextBox1.SelectionColor = Color
        TextBox1.SelectionFont = New Font("Microsoft Sans Serif", FSize, FontStyle)
        TextBox1.SelectionStart = TextBox1.TextLength
    End Sub
    Private Sub Frmmain_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\eggs.txt") Then
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\eggs.txt", "Egg" & vbCrLf & "菜单系统/n Egg made by LB  /n你可以修改/path\eggs.txt来修改egg" & vbCrLf & "path" & vbCrLf & "LinePut文件夹：/path", True)
        End If
        'VerizonTime = Now '发布前取消注释

        FontColor = Color.White
        BackGroundColor = Color.Black
        SetTopLevel(True)
        TextBox1.AppendText(Verizon & " RE:" & VerizonTime.ToShortDateString & vbCrLf)
        Text = "LinePut " & Verizon & " RE:" & VerizonTime.ToShortDateString
        Dim Comm As String = Command.Replace("""", "")
        If Comm <> "" Then
            Select Case LCase(My.Computer.FileSystem.GetFileInfo(Comm).Extension)
                Case ".lpt", ".lps"
                    OpenFile(Comm)
                Case ".txt"
                    OpenTextFile(Comm)
                Case ".jpg", ".jpge", ".png"
                    SendImage(Comm, New Size(-1, -1))
                Case ".mov", ".mp4", ".mp3", ".mpge", ".wav", ".avi"
                    SendMov(Comm, New Size(-1, -1), True)
                Case Else
                    Output("无法识别文件 " & Comm & " ,请确认正确的后缀名")
            End Select
        End If
        Eggtext = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "eggs.txt", System.Text.Encoding.Default)
        SplitContainer1.Panel2Collapsed = True

        '给历史增加第一帧
        History.Add(ColorTOHTML(TextBox1.BackColor) & TextBox1.Rtf)
        HistoryID += 1


    End Sub
    Private Sub ButtonShowTool_Click(sender As Object, e As EventArgs) Handles ButtonShowTool.Click
        PanelTool.Visible = Not PanelTool.Visible
    End Sub

    '这里是输入指令
    Public Sub OpenFile(Optional FileName As String = "")
        'On error GoTo errPut
        If FileName <> "" Then
            Dim ReTry As Boolean = False
ReTry:
            If Not My.Computer.FileSystem.FileExists(FileName) Then
                If Not ReTry Then
                    FileName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & FileName
                    ReTry = True
                    GoTo ReTry
                End If
                Output("Error:Can't find file   (OpenFile.System.IO)" & vbCrLf, Color.Red)
                Exit Sub
            End If
            GoTo Read
        End If

        Dim OpenFileDialogShow As New OpenFileDialog With {
            .FileName = "",
            .Filter = "LPT文件(*.lpt)|*.lpt|LPS文件(*.lps)|*.lps|RTF文件(*.rtf)|*.rtf|所有文件|*.*"
        }

        If OpenFileDialogShow.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        FileName = OpenFileDialogShow.FileName

Read:
        Select Case Microsoft.VisualBasic.Right(FileName, 4)
            Case ".lpt"
            Case ".lps"
            Case ".rtf"
                TextBox1.LoadFile(FileName)
                Exit Sub
            Case ".txt"
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(FileName, System.Text.Encoding.Default)
                Exit Sub
        End Select

        MyPath = My.Computer.FileSystem.GetFileInfo(FileName).DirectoryName
        LinPutLinNow = 0
        Dim tmp As String = My.Computer.FileSystem.ReadAllText(FileName, System.Text.Encoding.Default)
        If tmp = "" Then
            Output("文件" & FileName & "内容为空" & vbCrLf, Color.Yellow)
            Exit Sub
        End If
        LinPutLin.Clear()
        Dim tmps() As String = Split(tmp, vbCrLf)
        For i = 0 To tmps.Length - 1
            LinPutLin.Add(tmps(i))
        Next

        Output("文件" & FileName & "已打开" & vbCrLf, Color.Yellow)
        'HashCodeChack
        '版本自检
        '当前版本：Verizeon
Load:
        Dim NowLine(10) As String
        NowLine = Split(LinPutLin(0), ":|")
        FileVerizon = -1
        IsAutoRun = False
        '-1 检测不到版本
        Dim Input(1) As String
        For i = 0 To UBound(NowLine) - 1
            Input = Split(NowLine(i), "#")
            Select Case LCase(Input(0))
                Case "autorun"
                    IsAutoRun = True
                Case "verizon"
                    If UBound(Input) = 1 Then
                        If IsNumeric(Input(1)) Then
                            FileVerizon = Input(1)
                        End If
                    End If
                Case "fullscreen"
                    移动ToolStripMenuItem.Checked = True
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Case "password"
                    If UBound(Input) = 0 Then
                        tmp = InputBox("文件" & FileName & "为加密文件，请输入密码解锁该文件：")
                    Else
                        tmp = Input(1)
                    End If

                    If IsNumeric(tmp) Then
                        If tmp > 62 Then
                            If tmp < 11 Then
                                tmp = -tmp + 75
                            End If
                            tmp = Int(tmp Mod 53 + 10)
                        End If
                        tmp = STR2DeCode(tmp & LinPutLin(1))
                    Else
                        tmp = STR2DeCode(LinPutLin(1))
                    End If
                    tmp = STR2DeCode(tmp)
                    If tmp = "LBSTRDeCodeFail" Then
                        Output("文件" & FileName & " 解密失败" & vbCrLf, Color.Red)
                        GoTo errPut
                    End If
                    LinPutLin.Clear()
                    tmps = Split(tmp, vbCrLf)
                    For b = 0 To tmps.Length - 1
                        LinPutLin.Add(tmps(b))
                    Next
                    Output("文件" & FileName & "已解密" & vbCrLf, Color.GreenYellow)
                    GoTo Load
            End Select
        Next
        FileVerizonDate = My.Computer.FileSystem.GetFileInfo(FileName).LastWriteTime


        If FileVerizon = -1 Then
            MsgBox("没有检测到版本信息，可能是旧版本LPT文件，将会产生兼容性问题", MsgBoxStyle.Exclamation)
            Output("没有检测到版本信息，可能是旧版本LPT文件，将会产生兼容性问题" & vbCrLf, Color.Red)
        ElseIf FileVerizon > Verizon Then
            Output("文件版本高于当前LinePut版本，可能会产生兼容性问题，请前往http://www.exlb.pw 获取Lineput最新版本" & vbCrLf, Color.Red)
        ElseIf FileVerizon < Verizon Then
            Output("文件版本低于当前LinePut版本，可能会产生兼容性问题" & vbCrLf, Color.Red)
        End If

        ReadLine()
        Exit Sub
errPut: Output("Error:OpenFile.System.IO" & vbCrLf, Color.Red)
    End Sub
    Public Sub OpenTextFile(Optional FileName As String = "")
        'On error GoTo errPut
        If FileName <> "" Then
            Dim ReTry As Boolean = False
ReTry:
            If Not My.Computer.FileSystem.FileExists(FileName) Then
                If Not ReTry Then
                    FileName = MyPath & "\" & FileName
                    ReTry = True
                    GoTo ReTry
                End If
                Output("Error:Can't find file   (OpenTextFile.System.IO)" & vbCrLf, Color.Red)
                Exit Sub
            End If
            GoTo Read
        End If

        Dim OpenFileDialogShow As New OpenFileDialog With {
            .FileName = "",
            .Filter = "支持打开的文档(*.txt;*.rtf;*.rb)|*.txt;*.rtf;*.rb|所有文件|*.*"
        }

        If OpenFileDialogShow.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        FileName = OpenFileDialogShow.FileName

Read:
        Select Case LCase(My.Computer.FileSystem.GetFileInfo(FileName).Extension)
            Case ".rtf"
                BackGroundColor = Color.White
                TextBox1.BackColor = BackGroundColor
                FontColor = Color.Black
                TextBox1.LoadFile(FileName)
            Case Else
                Output(My.Computer.FileSystem.ReadAllText(FileName, System.Text.Encoding.Default))
        End Select
        Exit Sub
errPut: Output("Error:OpenTextFile.System.IO" & vbCrLf, Color.Red)
    End Sub
    Public Sub Savefile(Optional FileName As String = "")
        'On error GoTo errPut
        If FileName <> "" Then
            GoTo Save
        End If

        Dim SaveFileDialog As New SaveFileDialog With {
            .FileName = "",
            .Filter = "LPS文件|*.lps|RTF文件(*.rtf)|*.rtf|文本文档(*.txt)|*.txt"
        }

        If SaveFileDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        FileName = SaveFileDialog.FileName

Save:
        If Microsoft.VisualBasic.Right(FileName, 4) = ".rtf" Then
            TextBox1.SaveFile(FileName)
        Else
            Dim tmp As String
            If Microsoft.VisualBasic.Right(FileName, 4) = ".txt" Then
                tmp = TextBox1.Text
            Else
                tmp = MakeText(TextBox1, LineSetForMain)
                '生成LPS格式文档
            End If
            My.Computer.FileSystem.WriteAllText(FileName, tmp, False)
        End If
        Output("文件保存成功" & vbCrLf, Color.Yellow)
        Exit Sub
errPut: Output("Error:SaveFile.System.IO" & vbCrLf, Color.Red)
    End Sub

    Public Sub SendImage(Optional PicFileName As String = Nothing, Optional Size As Size = Nothing, Optional IsIn As Boolean = False)
        'On error GoTo errPut
        If PicFileName <> "" Then
            Dim ReTry As Boolean = False
ReTry:
            If Not My.Computer.FileSystem.FileExists(PicFileName) Then
                If Not ReTry Then
                    ReTry = True
                    PicFileName = MyPath & "\" & PicFileName
                    GoTo ReTry
                End If
                Output("Error:Can't find file " & PicFileName & "  (System.IO)" & vbCrLf, Color.Red)
                Exit Sub
            End If
            GoTo Read
        End If

        Dim OpenFileDialogShow As New OpenFileDialog With {
            .FileName = "",
            .Filter = "图片文件|*.jpg;*.jpeg;*.png|所有文件|*.*"
        }

        If OpenFileDialogShow.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        PicFileName = OpenFileDialogShow.FileName

Read:
        If IsIn Then
            Clipboard.SetImage(Image.FromFile(PicFileName))  '将图形内容拷贝到剪贴板 
            TextBox1.SelectionStart = TextBox1.TextLength
            TextBox1.Paste()
            Exit Sub
        Else
            Dim FrmPic As New FrmPic
            FrmPic.PictureBox1.Image = Image.FromFile(PicFileName)
            Dim MyPaths = Split(PicFileName, "\")
            If Size = Nothing Then
                Dim Sizes(1) As Integer
                Sizes(0) = FrmPic.PictureBox1.Image.Size.Width
                Sizes(1) = FrmPic.PictureBox1.Image.Size.Height
                While Not Sizes(0) <= Me.Width * 0.75
                    Sizes(0) = Int(Sizes(0) * 0.75)
                    Sizes(1) = Int(Sizes(1) * 0.75)
                End While
                While Not Sizes(1) <= Me.Height * 0.75
                    Sizes(0) = Int(Sizes(0) * 0.75)
                    Sizes(1) = Int(Sizes(1) * 0.75)
                End While
                Size = New Size(Sizes(0), Sizes(1))
            ElseIf Size = New Size(-1, -1) Then
                FrmPic.WindowState = FormWindowState.Maximized
            End If
            FrmPic.Text = MyPaths(UBound(MyPaths))
            FrmPic.Width = Size.Width
            FrmPic.Height = Size.Height
            FrmPic.Show()
            Exit Sub
        End If
errPut: Output("Error:OpenPicFile.System.IO" & vbCrLf, Color.Red)
    End Sub
    Public Sub SendMov(Optional MovFileName As String = "", Optional Size As Size = Nothing, Optional AutoStart As Boolean = False)
        'On error GoTo errPut
        If Size = Nothing Then
            Size = New Size(600, 600)
        End If
        If MovFileName <> "" Then
            Dim ReTry As Boolean = False
ReTry:
            If Not My.Computer.FileSystem.FileExists(MovFileName) Then
                If Not ReTry Then
                    ReTry = True
                    MovFileName = MyPath & "\" & MovFileName
                    GoTo ReTry
                End If
                Output("Error:Can't find file   (System.IO)" & vbCrLf, Color.Red)
                Exit Sub
            End If
            GoTo Read
        End If

        Dim OpenFileDialogShow As New OpenFileDialog With {
            .FileName = "",
            .Filter = "可播放文件|*.mov;*.mp4;*.mp3;*.mpge;*.wav;*.avi|所有文件|*.*"
        }

        If OpenFileDialogShow.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        MovFileName = OpenFileDialogShow.FileName

Read:
        Dim FrmMov As New FrmMov

        Dim MyPaths = Split(MovFileName, "\")
        FrmMov.Text = MyPaths(UBound(MyPaths))
        If Size = New Size(-1, -1) Then
            FrmMov.WindowState = FormWindowState.Maximized
        End If
        FrmMov.Width = Size.Width
        FrmMov.Height = Size.Height
        FrmMov.AxWindowsMediaPlayer1.settings.autoStart = AutoStart
        FrmMov.AxWindowsMediaPlayer1.URL = MovFileName
        FrmMov.Show()
        Exit Sub
errPut: Output("Error:OpenMovFile.System.IO" & vbCrLf, Color.Red)
    End Sub
    Private Function ReadText(FileName As String) As String
        'On error GoTo errPut
        If FileName <> "" Then
            Dim ReTry As Boolean = False
ReTry:      If Not My.Computer.FileSystem.FileExists(FileName) Then
                If Not ReTry Then
                    FileName = MyPath & "\" & FileName
                    ReTry = True
                    GoTo ReTry
                End If
                Return "Error:Can't find file " & FileName & "   (OpenTextFile.System.IO)"
            End If
        End If
        If My.Computer.FileSystem.GetFileInfo(FileName).Extension = ".rtf" Or My.Computer.FileSystem.GetFileInfo(FileName).Extension = ".rb" Then
            TextBox1.LoadFile(FileName)
            Return ""
        Else
            Return My.Computer.FileSystem.ReadAllText(FileName, System.Text.Encoding.Default)
        End If
errPut: Output("Error:OpenTextFile.System.IO" & vbCrLf, Color.Red)
    End Function

    '声明：虽然说这个可以插入图片，但是还是操作性不高，将会用到记录板4
    '如果使用内部图片，这个还是可以的，可以作为兼容性插入？
    '现已被安装到INIMG
    '    Private Sub SendImage(Optional PicFileName As String = "")
    '        'On error GoTo errPut
    '        If PicFileName <> "" Then
    '            Dim ReTry As Boolean = False
    'ReTry:
    '            If Dir(PicFileName) = "" Then
    '                If Not ReTry Then
    '                    ReTry = True
    '                    PicFileName = MyPath & "\" & PicFileName
    '                    GoTo ReTry
    '                End If
    '                Output("Error:Can't find file   (System.IO)" & vbCrLf, Color.Red)
    '                Exit Sub
    '            End If
    '            GoTo Read
    '        End If
    '        Dim OpenFileDialogShow As New OpenFileDialog
    '        OpenFileDialogShow.FileName = ""
    '        OpenFileDialogShow.Filter = "图片文件|*.jpg;*.jpeg;*.png|所有文件|*.*"
    '        If OpenFileDialogShow.ShowDialog() <> Windows.Forms.DialogResult.OK Then
    '            Exit Sub
    '        End If
    '        PicFileName = OpenFileDialogShow.FileName

    'Read:
    '        Clipboard.SetImage(Image.FromFile(PicFileName))  '将图形内容拷贝到剪贴板 
    '        Output(vbCrLf)
    '        SendKeys.Send("^v")
    '        Output(vbCrLf)
    '        Exit Sub
    'errPut: Output("Error:OpenPicFile.System.IO" & vbCrLf, Color.Red)
    '    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            KSCRLF = Split(TextBox1.Text, vbLf)
            Dim s As Integer = UBound(KSCRLF) - 1
            If s < 0 Then Exit Sub
            Dim InputThing As String
            'LCase
            'InputThing 才是输入
            InputThing = KSCRLF(s)
            LPTCoder(InputThing, ReadMod.KeyPress)
        ElseIf Convert.ToInt32(e.KeyChar) = 27 Then
            If 移动ToolStripMenuItem.Checked Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            Else
                If TextBox1.Text.Contains("Close??") Then
                    Me.Close()
                ElseIf TextBox1.Text.Contains("Close?") Then
                    Output(vbCrLf & "Close??")
                Else
                    Output(vbCrLf & "Close?")
                End If
            End If

        End If
    End Sub
    Dim Eggtext As String
    Public Function Eggs(Input As String) As String
        'On error Resume Next
        Dim SPL() As String = Split(Eggtext, vbCrLf)
        For i = 0 To UBound(SPL) Step 2
            If LCase(SPL(i)) = LCase(Input) Then
                Return TextReplace(SPL(i + 1))
            End If
        Next
        Return ""
    End Function
    Public Function TextReplace(Input As String) As String
        Input = Input.Replace("/|", ":|")
        Input = Input.Replace("/tab", vbTab)
        Input = Input.Replace("/now", Now)
        Input = Input.Replace("/n", vbCrLf)
        Input = Input.Replace("/lnow", LinPutLinNow)
        Input = Input.Replace("/llen", LinPutLin.Count)
        Input = Input.Replace("/id", "#")
        Input = Input.Replace("/?", "//")
        Input = Input.Replace("/!", "/")
        Input = Input.Replace("/path", My.Application.Info.DirectoryPath)
        '在这里如果有进行任何修稿，需要进入CLSLINE重新更改 function TEXTDEREPLACE
        Return Input
    End Function

    'Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
    '    MsgBox(e.KeyCode)
    'End Sub

    'Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
    '    If LinPutLin.Count > LinPutLinNow Then
    '        GoNext()
    '    End If
    'End Sub

    Public llcc As LlccMod = Rnd() * 6
    '0-Rup 1-Rdw 2-Gup 3-gdw 4-bup
    Enum LlccMod
        RedUP
        RedDown
        GreenUP
        GreenDown
        BlueUP
        BlueDown
    End Enum
    Private Sub Timerllcc_Tick(sender As Object, e As EventArgs) Handles Timerllcc.Tick
        Dim llcccol As Color = TextBox1.BackColor
        Randomize()
        Select Case llcc
            Case LlccMod.RedDown
                If llcccol.R < 50 * Rnd() + 10 Then
                    llcc = 6 * Rnd()
                Else
                    TextBox1.BackColor = Color.FromArgb(llcccol.R - 3, llcccol.G, llcccol.B)
                End If
            Case LlccMod.RedUP
                If llcccol.R > 185 + 50 * Rnd() Then
                    llcc = 6 * Rnd()
                Else
                    TextBox1.BackColor = Color.FromArgb(llcccol.R + 3, llcccol.G, llcccol.B)
                End If
            Case LlccMod.GreenDown
                If llcccol.G < 50 * Rnd() + 10 Then
                    llcc = 6 * Rnd()
                Else
                    TextBox1.BackColor = Color.FromArgb(llcccol.R, llcccol.G - 3, llcccol.B)
                End If
            Case LlccMod.GreenUP
                If llcccol.G > 185 + 50 * Rnd() Then
                    llcc = 6 * Rnd()
                Else
                    TextBox1.BackColor = Color.FromArgb(llcccol.R, llcccol.G + 3, llcccol.B)
                End If
            Case LlccMod.BlueDown
                If llcccol.B < 50 * Rnd() + 10 Then
                    llcc = 6 * Rnd()
                Else
                    TextBox1.BackColor = Color.FromArgb(llcccol.R, llcccol.G, llcccol.B - 3)
                End If
            Case LlccMod.BlueUP
                If llcccol.B > 185 + 50 * Rnd() Then
                    llcc = 6 * Rnd()
                Else
                    TextBox1.BackColor = Color.FromArgb(llcccol.R, llcccol.G, llcccol.B + 3)
                End If
            Case 6
                llcc = 6 * Rnd()
        End Select
    End Sub
    Dim TimerS As Integer
    Dim TimerSN As Integer
    Dim TimerS10 As Integer
    Dim TimerStar As Date
    Public Sub InTimerSet(倒计时 As Integer)
        TimerS = 倒计时
        TimerS10 = Int(TimerS / 10)
        TimerSN = TimerS - TimerSN
        TimerStar = Now
        TimerInTimer.Enabled = True
    End Sub
    Private Sub TimerInTimer_Tick(sender As Object, e As EventArgs) Handles TimerInTimer.Tick
        'Output(TimerS - DateDiff(DateInterval.Second, TimerStar, Now))
        If TimerS - DateDiff(DateInterval.Second, TimerStar, Now) <= TimerSN Then
            If TimerS - DateDiff(DateInterval.Second, TimerStar, Now) <= 0 Then
                Output("InTimer:时间到!! Times UP" & vbCrLf, Color.Red)
                TimerInTimer.Enabled = False
                Exit Sub
            End If
            Output("InTimer:剩余" & TimerS - DateDiff(DateInterval.Second, TimerStar, Now) & "秒" & vbCrLf, )
            TimerSN -= TimerS10
            If TimerSN <= 0 Then
                TimerSN = 0
            End If
        End If
    End Sub

    Private Sub 移动ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 移动ToolStripMenuItem.Click
        移动ToolStripMenuItem.Checked = Not 移动ToolStripMenuItem.Checked
        If Not 移动ToolStripMenuItem.Checked Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub 只读ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 只读ToolStripMenuItem.Click
        只读ToolStripMenuItem.Checked = Not 只读ToolStripMenuItem.Checked
        TextBox1.ReadOnly = 只读ToolStripMenuItem.Checked
    End Sub

    Private Sub TimerNext_Tick(sender As Object, e As EventArgs) Handles TimerNext.Tick
        TimerNext.Enabled = False
        ReadLine()
    End Sub

    Private Sub Printer(Things As String, Seconds As Single, FontColor As Color, FontSize As Single)
        PrinterTick = 0
        If FontSize < 1 Then
            FontSize = AllFont.Size
        End If
        Dim Send As Integer = 1
        Dim Len As Integer = Things.Length
        Dim Tick As Single
        PrinterTick = 0

        If Seconds < 0.1 Then
            Seconds = 2
        End If

        While Not (Tick > 0.01)
            Tick = Seconds / Len * Send
            Send += 1
        End While
        Send -= 1
        TimerPrinter.Interval = Tick * 1000
        PrinterFontColor = FontColor
        PrinterFontSize = FontSize
        PrinterThings.Clear()
        Dim b As Integer = -1
        For i = 0 To Len - 1
            If i Mod Send = 0 Then
                PrinterThings.Add(Things(i))
                b += 1
            Else
                PrinterThings.Item(b) &= Things(i)
            End If
            'Things(i)
        Next
        TimerPrinter.Enabled = True

    End Sub
    Dim PrinterThings As New List(Of String)
    Dim PrinterTick As Integer
    Dim PrinterFontColor As Color
    Dim PrinterColorRND As Boolean
    Dim PrinterFontSize As Single
    Dim PrinterGoToNext As Boolean = False
    Private Sub TimerPrinter_Tick(sender As Object, e As EventArgs) Handles TimerPrinter.Tick
        If PrinterTick >= PrinterThings.Count Then
            TimerPrinter.Enabled = False
            If PrinterGoToNext Then
                ReadLine()
            End If
            Exit Sub
        End If
        If PrinterColorRND Then
            Output(PrinterThings(PrinterTick), GetRNDColor, PrinterFontSize)
        Else
            Output(PrinterThings(PrinterTick), PrinterFontColor, PrinterFontSize)
        End If
        PrinterTick += 1
    End Sub
    Public Function GetRNDColor() As Color
        Randomize()
        Dim R, G, B As Integer
        R = PrinterFontColor.R
        G = PrinterFontColor.G
        B = PrinterFontColor.B
        Dim Rd As Integer
        Rd = Int(Rnd() * 64 - 32)
        R += Rd
        Rd = Int(Rnd() * 64 - 32)
        G += Rd
        Rd = Int(Rnd() * 64 - 32)
        B += Rd
        If R > 255 Then
            R = 255
        End If
        If G > 255 Then
            G = 255
        End If
        If B > 255 Then
            B = 255
        End If
        If R < 0 Then
            R = 0
        End If
        If G < 0 Then
            G = 0
        End If
        If B < 0 Then
            B = 0
        End If
        Return Color.FromArgb(R, G, B)
    End Function

    Private Sub 暂停运行ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 暂停运行ToolStripMenuItem.Click
        StopReadLine = False
        Timerllcc.Enabled = False
        TimerNext.Enabled = False
        TimerInTimer.Enabled = False
        TimerPrinter.Enabled = False
        Output("PageEnd" & vbCrLf)
    End Sub

    Private Sub 关于LinePut4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于LinePutToolStripMenuItem.Click
        Output("关于LinePut" & Verizon & ":" & VerizonTime & vbCrLf & "LinePut 是深圳市L版公司出品的幻灯片播放软件，本软件遵循GNU General Public License 开源协议")
    End Sub

    Private Sub 审查元素ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 审查元素ToolStripMenuItem.Click
        SplitContainer1.Panel2Collapsed = False
        TextBoxElement.Text = MakeText(TextBox1, LineSetForMain)
    End Sub

    Private Sub ButtonCloseSPL_Click(sender As Object, e As EventArgs) Handles ButtonCloseElement.Click
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub ButtonRels_Click(sender As Object, e As EventArgs) Handles ButtonRels.Click
        TextBoxElement.Text = MakeText(TextBox1, LineSetForMain)
    End Sub

    Private Sub ButtonGoSet_Click(sender As Object, e As EventArgs) Handles ButtonGoSet.Click
        LPSOpen(TextBoxElement.Text, TextBox1, LineSetForMain)
    End Sub
End Class
