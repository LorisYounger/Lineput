Public Class FrmEditor
    Public EdText As ArrayList
    Public EdTextName As ArrayList
    Public NowEdID As Integer = 0
    Dim IsEding As Boolean = False
    Public Sub SetNomalText(Text As String)
        While Text.Contains(vbCrLf & vbCrLf)
            Text = Text.Replace(vbCrLf & vbCrLf, vbCrLf)
        End While
        EdText.Clear()
        EdTextName.Clear()
        Dim NewEDText(1000) As String
        NewEDText = Split(Text, vbCrLf)
        EdText.Add(NewEDText(0))
        EdText.Add("")
        EdTextName.Add("FirstLine")
        Dim NowID As Integer = 1
        For i = 1 To UBound(NewEDText)
            EdText.Item(NowID) &= NewEDText(i) & vbCrLf
            If (LCase(NewEDText(i)).Contains("pageend:|") And UBound(NewEDText) > i) Then
                If LCase(NewEDText(i + 1)).Contains("cls:|") Then
                    EdText.Item(NowID) &= vbCrLf & "EditorSplit#NoName" & NowID & ":|"
                    NowID += 1
                    EdText.Add("")
                    EdTextName.Add("NoName" & NowID - 1)
                End If
            Else
                Dim SP(10) As String
                SP = Split(NewEDText(i), ":|")
                For b = 0 To UBound(SP)
                    If LCase(Split(SP(b), "#")(0)) = "editorsplit" Then
                        If UBound(Split(SP(b), "#")) > 0 Then
                            NowID += 1
                            EdText.Add("")
                            EdTextName.Add(Split(SP(b), "#")(1))
                        End If
                    End If
                Next
            End If
        Next
        Dim HaveEdspl As Boolean = False
        For i = 0 To 1
            If LCase(NewEDText(UBound(NewEDText) - i)).Contains("editorsplit") Then
                HaveEdspl = True
                Exit For
            End If
        Next
        If Not HaveEdspl Then
            EdText.Item(NowID) &= vbCrLf & "EditorSplit#NoName" & NowID & ":|"
            EdTextName.Add("NoName" & NowID)
        End If
        NowEdID = 0
        TextBoxCode.Text = EdText(0)
    End Sub
    Public Function GetEdText() As String
        GetEdText = ""
        For i = 0 To EdText.Count - 1
            GetEdText &= EdText.Item(i) & vbCrLf
        Next
        While GetEdText.Contains(vbCrLf & vbCrLf)
            GetEdText = GetEdText.Replace(vbCrLf & vbCrLf, vbCrLf)
        End While
    End Function

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        PanelCenter.Left = SplitContainer1.SplitterDistance + 3
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        If IsEding Then
            Dim MS = MsgBox("是否保存正在编辑的文件", vbYesNoCancel)
            If MS = vbYes Then
                If Not SaveFile() Then
                    Exit Sub
                End If
            ElseIf MS = vbCancel Then
                Exit Sub
            End If
        End If
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "LinePut文件|*.lpt|所有文件|*.*"
        If vbOK = OpenFileDialog.ShowDialog() Then
            SetNomalText(My.Computer.FileSystem.ReadAllText(OpenFileDialog.FileName))
            TextBoxOutPut.AppendText("成功打开文件" & OpenFileDialog.FileName & vbCrLf)
            Rels()
            IsEding = False
        End If
    End Sub
    Public Sub Rels()
        ListBoxList.Items.Clear()
        For i = 0 To EdTextName.Count - 1
            ListBoxList.Items.Add(EdTextName.Item(i))
        Next
    End Sub
    Private Sub FrmEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case MsgBox("LPT Editor 不再进行更新维护" & "制作LPT文件请使用LPT Maker", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "停止维护")
            Case MsgBoxResult.No
                Me.Close()
            Case MsgBoxResult.Yes
                MsgBox("在Lineput主页面输入 'Maker' 打开LPTMaker")
        End Select
        EdText = New ArrayList
        EdTextName = New ArrayList
        EdText.Add(My.Resources.EdNewFile)
        EdTextName.Add("FirstLine")
        TextBoxCode.Text = EdText(NowEdID)
        Rels()
    End Sub

    Private Sub ListBoxList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxList.SelectedIndexChanged
        If ListBoxList.SelectedIndex = NowEdID Or ListBoxList.SelectedIndex = -1 Then
            Exit Sub
        End If

        EdText(NowEdID) = TextBoxCode.Text

        NowEdID = ListBoxList.SelectedIndex
        Dim Edtxt As String = EdText(NowEdID)
        While Edtxt.Contains(vbCrLf & vbCrLf)
            Edtxt = Edtxt.Replace(vbCrLf & vbCrLf, vbCrLf)
        End While
        EdText(NowEdID) = Edtxt
        TextBoxCode.Text = EdText(NowEdID)
        ButtonNextLen.Enabled = False
    End Sub

    Private Sub ButtonRun_Click(sender As Object, e As EventArgs) Handles ButtonRun.Click
        EdText(NowEdID) = TextBoxCode.Text
        If NowEdID = 0 Then
            Exit Sub
        End If
        Dim NNid As Integer = NowEdID
        SetNomalText(GetEdText)
        NowEdID = NNid
        TextBoxCode.Text = EdText(NowEdID)
        LinPutLin = Split(TextBoxCode.Text, vbCrLf)
        LinPutLinln = UBound(LinPutLin) + 1
        LinPutLinNow = 0
        TextBox1.ResetText()
        ReadLine()
        ButtonNextLen.Enabled = True
        Rels()
    End Sub

    'from ButtonRun_Click
    '        Dim GetEditorSplit As Boolean = False
    '        LinPutLinNow = 0
    '        Dim DoNotUsed As Integer = UBound(LinPutLin)
    '        LinPutLin = Split(TextBoxCode.Text, vbCrLf)
    '        For i = 0 To UBound(LinPutLin)
    '            Dim NowLine(10) As String
    '            NowLine = Split(LinPutLin(i), ":|")
    '            For b = 0 To UBound(NowLine) - 1
    '                If NowLine(b) <> "" Then
    '                    Dim Input(1) As String
    '                    Input = Split(NowLine(b), "#")
    '                    If Input(0) = "editorsplit" Then
    '                        If Not GetEditorSplit Then
    '                            '如果遇到结束当前页，就退出jump到判断是否是最后一行
    '                            If UBound(Input) = 1 Then
    '                                EdTextName(NowEdID) = Input(0)
    '                            Else
    '                                EdTextName(NowEdID) = "NoName" & NowEdID
    '                            End If
    '                            GetEditorSplit = True
    '                            DoNotUsed = i + 1
    '                            GoTo JumpFor
    '                        Else
    '                            '
    '                            If UBound(Input) = 1 Then
    '                                EdTextName.Insert(NowEdID + 1, Input(1))
    '                            Else
    '                                EdTextName.Insert(NowEdID + 1, "NoName" & NowEdID + 1)
    '                            End If
    '                            DoNotUsed = i + 1

    '                        End If
    '                    End If
    '                End If
    '            Next
    '        Next
    'JumpFor: If Not GetEditorSplit Then
    '            '如果没有找到结束符，把这个文件向上合并/向下合并
    '            If NowEdID = 1 Then
    '                If EdText.Count = 1 Then '如果是没有上面和下面的文件，就自动生成一个结尾

    '                Else
    '                    EdText(1) &= vbCrLf & EdText(2)
    '                    EdText.RemoveAt(2)
    '                    EdTextName.RemoveAt(1)
    '                End If
    '            Else
    '                EdText(NowEdID - 1) &= vbCrLf & EdText(NowEdID)
    '                EdText.RemoveAt(NowEdID)
    '                EdTextName.RemoveAt(NowEdID)
    '            End If

    '            Dim Edtxt As String = EdText(NowEdID)
    '            While Edtxt.Contains(vbCrLf & vbCrLf)
    '                Edtxt = Edtxt.Replace(vbCrLf & vbCrLf, vbCrLf)
    '            End While
    '            EdText(NowEdID) = Edtxt
    '            TextBoxCode.Text = EdText(NowEdID)
    '            'ButtonRun_Click(sender, e)
    '            Exit Sub
    '        Else

    '            '判断结束是不是最后一行
    '            If DoNotUsed < UBound(LinPutLin) Then
    '                '这里会将文件分为2半，
    '                '判断如果没有下一个文件就新建一个
    '            End If
    '        End If



    '        LinPutLinln = UBound(LinPutLin) + 1
    '        ReadLine()
    '        ButtonNextLen.Enabled = True

    Public LinPutLin(1000) As String
    Public LinPutLinln As Integer
    Public LinPutLinNow As Integer
    Public Sub ReadLine()
        If LinPutLinln <= LinPutLinNow Then
            Output("文件播放完毕 感谢您使用Lineput" & vbCrLf)
            Exit Sub
        ElseIf LinPutLin(LinPutLinNow) = "" Then
            LinPutLinNow += 1
            ReadLine()
            Exit Sub
        End If
        Dim NowLine(10) As String

        'For i = 0 To 9
        '    LinPutLin(LinPutLinNow) = LinPutLin(LinPutLinNow).Replace("/str" & i, UserString(i))
        '    LinPutLin(LinPutLinNow) = LinPutLin(LinPutLinNow).Replace("/int" & i, UserInteger(i))
        '    LinPutLin(LinPutLinNow) = LinPutLin(LinPutLinNow).Replace("/bool" & i, UserBoolean(i))
        '    LinPutLin(LinPutLinNow) = LinPutLin(LinPutLinNow).Replace("/dbl" & i, UserDouble(i))
        'Next

        NowLine = Split(LinPutLin(LinPutLinNow), ":|")
        Dim MyFontsize As Integer = Fontsize, MyFontColor As Color = FontColor, GoToNext As Boolean = True, GoToMSG As Boolean = False
        Dim Input(1) As String
        For i = 0 To UBound(NowLine) - 1
            If NowLine(i) <> "" Then
                Input = Split(NowLine(i), "#")
                Select Case LCase(Input(0))
                    Case "fontcolor"
                        On Error Resume Next
                        If UBound(Input) = 0 Then
                        ElseIf Input(1).Length = 6 Then
                            Dim Rv, Gv, Bv As Integer
                            Rv = CLng("&H" & Input(1)(0) & Input(1)(1))
                            Gv = CLng("&H" & Input(1)(2) & Input(1)(3))
                            Bv = CLng("&H" & Input(1)(4) & Input(1)(5))
                            MyFontColor = Color.FromArgb(Rv, Gv, Bv)
                        ElseIf Input(1).Length = 3 Then
                            Dim Rv, Gv, Bv As Integer
                            Rv = CLng("&H" & Input(1)(0)) * 16
                            Gv = CLng("&H" & Input(1)(1)) * 16
                            Bv = CLng("&H" & Input(1)(2)) * 16
                            MyFontColor = Color.FromArgb(Rv, Gv, Bv)
                        Else
                            Output("颜色(HTMLColor)格式错误" & vbCrLf, Color.Red)
                        End If
                    Case "allfontcolor"
                        On Error Resume Next
                        If UBound(Input) = 0 Then

                        ElseIf Input(1).Length = 6 Then
                            Dim Rv, Gv, Bv As Integer
                            Rv = CLng("&H" & Input(1)(0) & Input(1)(1))
                            Gv = CLng("&H" & Input(1)(2) & Input(1)(3))
                            Bv = CLng("&H" & Input(1)(4) & Input(1)(5))
                            FontColor = Color.FromArgb(Rv, Gv, Bv)
                            MyFontColor = FontColor
                        ElseIf Input(1).Length = 3 Then
                            Dim Rv, Gv, Bv As Integer
                            Rv = CLng("&H" & Input(1)(0)) * 16
                            Gv = CLng("&H" & Input(1)(1)) * 16
                            Bv = CLng("&H" & Input(1)(2)) * 16
                            FontColor = Color.FromArgb(Rv, Gv, Bv)
                            MyFontColor = FontColor
                        Else
                            Output("颜色(HTMLColor)格式错误" & vbCrLf, Color.Red)
                        End If
                    Case "fontsize"
                        If UBound(Input) = 0 Then
                        ElseIf IsNumeric(Input(1)) Then
                            MyFontsize = Input(1)
                        Else
                            Output("字体设置错误" & vbCrLf, Color.Red)
                        End If
                    Case "allfontsize"
                        If UBound(Input) = 0 Then
                        ElseIf IsNumeric(Input(1)) Then
                            MyFontsize = Input(1)
                            Fontsize = MyFontsize
                        Else
                            Output("字体设置错误" & vbCrLf, Color.Red)
                        End If
                    Case "backcolor"
                        On Error Resume Next
                        If UBound(Input) = 0 Then
                        ElseIf Input(1).Length = 6 Then
                            Dim Rv, Gv, Bv As Integer
                            Rv = CLng("&H" & Input(1)(0) & Input(1)(1))
                            Gv = CLng("&H" & Input(1)(2) & Input(1)(3))
                            Bv = CLng("&H" & Input(1)(4) & Input(1)(5))
                            TextBox1.BackColor = Color.FromArgb(Rv, Gv, Bv)
                        ElseIf Input(1).Length = 3 Then
                            Dim Rv, Gv, Bv As Integer
                            Rv = CLng("&H" & Input(1)(0)) * 16
                            Gv = CLng("&H" & Input(1)(1)) * 16
                            Bv = CLng("&H" & Input(1)(2)) * 16
                            TextBox1.BackColor = Color.FromArgb(Rv, Gv, Bv)
                        Else
                            Output("颜色(HTMLColor)格式错误" & vbCrLf, Color.Red)
                        End If
                    Case "goto"
                        If UBound(Input) = 0 Then
                        ElseIf IsNumeric(Input(1)) Then
                            If Input(1) <= LinPutLinln Then
                                TextBoxOutPut.AppendText("指针指令无法在模拟器使用，当前指针前往" & Input(1) & vbCrLf)
                            Else
                                Output("指针错误" & vbCrLf, Color.Red)
                            End If
                        Else
                            Output("指针错误-输入有误" & vbCrLf, Color.Red)
                        End If
                    Case "shell"
                        TextBoxOutPut.AppendText("Shell指令无法在模拟器使用，Shell：" & NowLine(UBound(NowLine)) & vbCrLf)
                        GoTo GoNext
                    Case "cls"
                        TextBox1.SelectAll()
                        TextBox1.SelectedText = ""
                    Case "timer"
                        If UBound(Input) = 0 Then
                            TextBoxOutPut.AppendText("倒计时启动" & vbCrLf)
                        ElseIf UBound(Input) = 1 Then
                            Dim times(1) As String
                            times = Split(Input(1), ",")
                            If UBound(times) = 0 And IsNumeric(times(0)) Then
                                TextBoxOutPut.AppendText("倒计时启动 倒计时：" & times(0) & "s" & vbCrLf)
                            ElseIf UBound(times) = 1 And IsNumeric(times(0)) And IsNumeric(times(1)) Then
                                TextBoxOutPut.AppendText("倒计时启动 倒计时：" & times(0) & "s 最终倒计时：" & times(1) & vbCrLf)
                            Else
                                TextBoxOutPut.AppendText("倒计时启动 参数设置错误" & vbCrLf)
                            End If
                            FrmTimer.Show()
                        End If
                    Case "img"
                        On Error GoTo GoNext
                        If UBound(Input) = 0 Then
                            TextBoxOutPut.AppendText("图片打开" & NowLine(UBound(NowLine)) & vbCrLf)
                        Else
                            Dim Size(1) As String
                            Size = Split(Input(1), ",")
                            TextBoxOutPut.AppendText("图片打开" & NowLine(UBound(NowLine)) & "  大小：(" & Size(0) & "," & Size(1) & ")" & vbCrLf)
                        End If
                        GoTo GoNext
                    Case "txt"
                        NowLine(UBound(NowLine)) = "文本文档 " & NowLine(UBound(NowLine)) & "将会打开" & vbCrLf
                    Case "mov", "movauto"
                        On Error GoTo GoNext
                        If UBound(Input) = 0 Then
                            Dim AutoPlay As Boolean = False
                            AutoPlay = (Input(0) = "movauto")
                            TextBoxOutPut.AppendText("视频打开" & NowLine(UBound(NowLine)) & "自动运行" & AutoPlay & vbCrLf)
                        Else
                            Dim Size(1) As String
                            Dim AutoPlay As Boolean = False
                            AutoPlay = (Input(0) = "movauto")
                            Size = Split(Input(1), ",")
                            TextBoxOutPut.AppendText("视频打开" & NowLine(UBound(NowLine)) & " 大小:(" & Size(0) & "," & Size(1) & ") 自动运行" & AutoPlay & vbCrLf)
                        End If
                        GoTo GoNext
                    Case "msg"
                        'MsgBox(NowLine(UBound(NowLine)))
                        'GoTo GoNext
                        GoToMSG = True
                    Case "h1"
                        MyFontsize = 48
                    Case "h2"
                        MyFontsize = 36
                    Case "h3"
                        MyFontsize = 24
                    Case "h4"
                        MyFontsize = 16
                    Case "h5"
                        MyFontsize = 12
                    Case "h6"
                        MyFontsize = 9
                    Case "pageend"
                        GoToNext = False
                    Case "end"
                        LinPutLinNow = LinPutLinln
                        Exit Sub
                End Select
            End If
        Next
        Dim tmp = New ClsLine(New ClsLineSet)
        NowLine(UBound(NowLine)) = tmp.TextReplace(NowLine(UBound(NowLine)))

        If GoToMSG Then
            TextBoxOutPut.AppendText("用MSG打开:" & NowLine(UBound(NowLine)) & vbCrLf)
        Else
            Output(NowLine(UBound(NowLine)), MyFontColor, MyFontsize)
        End If


        '增加并循环使用ReadLine直到结束为止
GoNext: LinPutLinNow += 1
        If GoToNext Then
            ReadLine()
        End If
    End Sub
    Public FontColor As Color = Color.White
    Public Fontsize As Integer = 16
    Public Sub Output(Optional Outputthing As String = Nothing, Optional Color As Color = Nothing, Optional FSize As Integer = -1, Optional FontStyle As FontStyle = FontStyle.Regular)
        FSize *= NumericUpDown1.Value / 100
        If FSize < 1 Then
            FSize = Fontsize * NumericUpDown1.Value / 100
        End If
        If FSize < 1 Then
            FSize = 1
        End If
        If Color = Nothing Then
            Color = FontColor
        End If
        Dim SelectionStart, SelectionLength As Integer
        SelectionStart = TextBox1.SelectionStart
        SelectionLength = Outputthing.Length
        TextBox1.AppendText(Outputthing)
        TextBox1.Select(SelectionStart, SelectionLength)
        TextBox1.SelectionColor = Color
        TextBox1.SelectionFont = New Font("Microsoft Sans Serif", FSize, FontStyle)
        TextBox1.SelectionStart = TextBox1.TextLength
    End Sub

    Private Sub ButtonNextLen_Click(sender As Object, e As EventArgs) Handles ButtonNextLen.Click
        ReadLine()
    End Sub

    Private Sub ButtonNewPage_Click(sender As Object, e As EventArgs) Handles ButtonNewPage.Click
        EdText(NowEdID) = TextBoxCode.Text
        NowEdID += 1
        EdText.Insert(NowEdID, My.Resources.EdNewPage)
        EdTextName.Insert(NowEdID, "NoName")
        TextBoxCode.Text = EdText(NowEdID)
        Rels()
    End Sub

    Private Sub ButtonDeletePage_Click(sender As Object, e As EventArgs) Handles ButtonDeletePage.Click
        If NowEdID = 0 Then
            MsgBox("FirstLine不能被删除", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Not (MsgBox("确认删除该页？此操作无法恢复", vbYesNo + MsgBoxStyle.Exclamation) = vbYes) Then
            Exit Sub
        End If
        EdText.RemoveAt(NowEdID)
        EdTextName.RemoveAt(NowEdID)
        NowEdID -= 1
        TextBoxCode.Text = EdText(NowEdID)
        Rels()
    End Sub

    'Private Sub TextBoxCode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCode.TextChanged
    '    Dim spl(1) As String
    '    Split(LCase(TextBoxCode.Text), "")
    'End Sub

    Private Sub TextBoxCode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCode.TextChanged
        If NowEdID = 0 Then
            TextBoxCode.Text = TextBoxCode.Text.Replace(vbCrLf, "")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        EdText(NowEdID) = TextBoxCode.Text
        SaveFile()
    End Sub

    Public Function SaveFile() As Boolean
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.Filter = "LinePut文件|*.lpt|所有文件|*.*"
        If vbOK = SaveFileDialog.ShowDialog() Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, GetEdText, False)
            TextBoxOutPut.AppendText("保存成功，保存到" & SaveFileDialog.FileName & vbCrLf)
            IsEding = False
            Return True
        End If
        Return False
    End Function
    Private Sub TextBoxCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCode.KeyDown
        IsEding = True
    End Sub

#Region "快捷按键"
    Private Sub 颜色输入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 颜色输入ToolStripMenuItem.Click
        Dim ColorDialog As New ColorDialog
        If vbOK = ColorDialog.ShowDialog Then
            TextBoxCode.SelectedText = Hex(ColorDialog.Color.R * 65536 + ColorDialog.Color.G * 256 + ColorDialog.Color.B)
        End If
    End Sub

    Private Sub 全局字体颜色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全局字体颜色ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "AllFontColor#{HTMLColorCode}:|"
    End Sub

    Private Sub 字体颜色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体颜色ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "FontColor#{HTMLColorCode}:|"
    End Sub

    Private Sub 背景颜色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 背景颜色ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "BackColor#{HTMLColorCode}:|"
    End Sub

    Private Sub 全局字号ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全局字号ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "AllFontSize#{FontSize}:|"
    End Sub

    Private Sub 字号ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字号ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "FontSize#{FontSize}:|"
    End Sub

    Private Sub H148ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H148ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "H1:|"
    End Sub

    Private Sub H236ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H236ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "H2:|"
    End Sub

    Private Sub H324ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H324ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "H3:|"
    End Sub

    Private Sub H416ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H416ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "H4:|"
    End Sub

    Private Sub H512ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H512ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "H5:|"
    End Sub

    Private Sub H69ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H69ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "H6:|"
    End Sub

    Private Sub 选择文件地址ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选择文件地址ToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "全部文件|*.*|文本文档(*.txt)|*.txt|图片文件|*.jpg;*.jpeg;*.png|可播放文件|*.mov;*.mp4;*.mp3;*.mpge;*.wav;*.avi"
        If vbOK = OpenFileDialog.ShowDialog Then
            TextBoxCode.SelectedText = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub 自动播放ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 自动播放ToolStripMenuItem.Click
        If NowEdID <> 0 Then
            MsgBox("自动播放只能被用于FirstLine")
            Exit Sub
        End If
        TextBoxCode.SelectedText = ":|AutoPlay:|"
    End Sub

    Private Sub 前往指针ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 前往指针ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "GoTo#{point}:|"
    End Sub

    Private Sub ShellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShellToolStripMenuItem.Click
        TextBoxCode.SelectedText = "Shell:|"
    End Sub

    Private Sub 清屏ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清屏ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "Cls:|"
    End Sub

    Private Sub 暂停播放ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 暂停播放ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "PageEnd:|"
    End Sub

    Private Sub 结束播放ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 结束播放ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "End:|"
    End Sub

    Private Sub 文本框ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 文本框ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "Msg:|"
    End Sub

    Private Sub 视频窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 视频窗口ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "mov#{size}:|"
    End Sub

    Private Sub 图片窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 图片窗口ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "img#{size}:|"
    End Sub

    Private Sub 倒计时器ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 倒计时器ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "Timer#{time}:|"
    End Sub

    Private Sub StringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringToolStripMenuItem.Click
        TextBoxCode.SelectedText = "/str{id}"
    End Sub

    Private Sub IntegerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegerToolStripMenuItem.Click
        TextBoxCode.SelectedText = "/int{id}"
    End Sub

    Private Sub BooleanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooleanToolStripMenuItem.Click
        TextBoxCode.SelectedText = "/bool{id}"
    End Sub

    Private Sub DoubleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoubleToolStripMenuItem.Click
        TextBoxCode.SelectedText = "/dbl{id}"
    End Sub

    Private Sub SetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetToolStripMenuItem.Click
        TextBoxCode.SelectedText = "Set#{obj+id},newobj:|"
    End Sub

    Private Sub TabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabToolStripMenuItem.Click
        TextBoxCode.SelectedText = "/tab"
    End Sub

    Private Sub 换行ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 换行ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "/n"
    End Sub

    Private Sub 当前时间ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 当前时间ToolStripMenuItem.Click
        TextBoxCode.SelectedText = "/now"
    End Sub
#End Region

    Private Sub FrmEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsEding Then
            Dim m = MsgBox("关闭前是否保存文件", vbYesNoCancel)
            If m = MsgBoxResult.Yes Then
                e.Cancel = Not SaveFile()
            ElseIf m = MsgBoxResult.No Then

            End If
        End If
        If e.Cancel = False Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub
End Class