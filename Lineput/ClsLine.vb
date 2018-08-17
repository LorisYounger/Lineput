Public Class ClsLine
    Public Text As String
    Public FontColor As Color
    Public FontSize As Single
    'Public FontStyle As FontStyle
    Public FontFamily As FontFamily
    'Public Functions As New List(Of String)
    Public LineSet As ClsLineSet
    Public Function ColorTOHTML(Color As Color) As String
        ColorTOHTML = Hex(Color.R * 256 ^ 2 + Color.G * 256 + Color.B)
        Dim b = 5 - ColorTOHTML.Length
        For i = 0 To b
            ColorTOHTML = "0" & ColorTOHTML
        Next
    End Function
    Public Function GetHTMLText() As String
        Dim Front As String
        Front = "<span style="""
        'Back = "</font>"
        If ColorTOHTML(FontColor) <> ColorTOHTML(LineSet.FontColor) Then
            Front &= "Color:#" & ColorTOHTML(FontColor) & ";"
        End If
        If LineSet.Mode <> ClsLineSet.OutPutMod.EM Then
            Front &= "Font-Size:" & FontSize & "px;"
        Else
            Front &= "Font-Size:" & Int(FontSize / 16 * 100) * 0.01 & "em;"
        End If
        If LineSet.FontFamily <> FontFamily.Name Then
            Front &= "font-family:" & FontFamily.Name & ";"
        End If
        'For i = 0 To Functions.Count - 1
        '    GetLPTText &= Functions(i) & ":|"
        'Next
        If Bsty Then
            Front &= "font-weight:bold;"
        End If
        If Isty Then
            Front &= "font-style:italic;"
        End If
        If Usty Then
            Front &= "text-decoration:underline;"
        End If
        If Delsty Then
            Front &= "text-decoration:line-through;"
        End If
        Return Front & """>" & HtmlDeReplace(Text) & "</span>"
    End Function
    Public Function HtmlDeReplace(Text As String) As String
        Text = Text.Replace(vbLf, "<br>")
        Text = Text.Replace("&amp;", "&")
        Text = Text.Replace("&quot;", "““")
        Text = Text.Replace(" & lt;", "<")
        Text = Text.Replace("&gt;", ">")
        Text = Text.Replace("&nbsp;", " ")
        Text = Text.Replace("&laquo;", "«")
        Text = Text.Replace("&raquo;", "»")
        Text = Text.Replace("&lsquo;", "'")
        Text = Text.Replace("&rsquo;", "’")
        Text = Text.Replace("&ldquo;", "““")
        Text = Text.Replace(" & rdquo;", "””")
        Text = Text.Replace("&sect;", "§")
        Text = Text.Replace("&copy;", "©")
        Text = Text.Replace("&hellip;", "…")
        Text = Text.Replace("&oplus;", "⊕")
        Text = Text.Replace("&nabla;", "∇")
        Text = Text.Replace("&times;", "×")
        Text = Text.Replace("&divide;", "÷")
        Text = Text.Replace("&plusmn;", "±")
        Text = Text.Replace("&radic;", "√")
        Text = Text.Replace("&infin;", "∞")
        Text = Text.Replace("&ang;", "∠")
        Text = Text.Replace("&int;", "∫")
        Text = Text.Replace("&deg;", "°")
        Text = Text.Replace("&ne;", "≠")
        Text = Text.Replace("&equiv;", "≡")
        Text = Text.Replace("&le;", "≤")
        Text = Text.Replace("&ge;", "≥")
        Text = Text.Replace("&perp;", "⊥")
        Text = Text.Replace("&there4;", "∴")
        Text = Text.Replace("&pi;", "π")
        Text = Text.Replace("&sup1;", "¹")
        Text = Text.Replace("&sup2;", "²")
        Text = Text.Replace("&sup3;", "³")
        Text = Text.Replace("&crarr;", "↵")
        Text = Text.Replace("&larr;", "←")
        Text = Text.Replace("&uarr;", "↑")
        Text = Text.Replace("&rarr;", "→")
        Text = Text.Replace("&darr;", "↓")
        Text = Text.Replace("&lArr;", "⇐")
        Text = Text.Replace("&uArr;", "⇑")
        Text = Text.Replace("&rArr;", "⇒")
        Text = Text.Replace("&dArr;", "⇓")
        Text = Text.Replace("&alpha;", "α")
        Text = Text.Replace("&beta;", "β")
        Text = Text.Replace("&gamma;", "γ")
        Text = Text.Replace("&Delta;", "Δ")
        Text = Text.Replace("&theta;", "θ")
        Text = Text.Replace("&lambda;", "λ")
        Text = Text.Replace("&Sigma;", "Σ")
        Text = Text.Replace("&tau;", "τ")
        Text = Text.Replace("&omega;", "ω")
        Text = Text.Replace("&Omega;", "Ω")
        Text = Text.Replace("&bull;", "•")
        Return Text
    End Function

    Public Function GetLPTText() As String
        GetLPTText = ""
        'If LineSet.Mode = ClsLineSet.OutPutMod.LPS Then
        '    GetLPTText = ""    '这个为全局设置，不能再getline设置
        'End If
        If ColorTOHTML(FontColor) <> ColorTOHTML(LineSet.FontColor) Then
            GetLPTText &= "FontColor#" & ColorTOHTML(FontColor) & ":|"
        End If
        If FontSize <> LineSet.FontSize And LineSet.Mode <> ClsLineSet.OutPutMod.EM Then
            Select Case Int(FontSize)
                Case 48
                    GetLPTText &= "h1"
                Case 36
                    GetLPTText &= "h2"
                Case 24
                    GetLPTText &= "h3"
                Case 16
                    GetLPTText &= "h4"
                Case 12
                    GetLPTText &= "h5"
                Case 9
                    GetLPTText &= "h6"
                Case Else
                    GetLPTText &= "FontSize#" & FontSize
            End Select
            GetLPTText &= ":|"
        End If
        If LineSet.Mode = ClsLineSet.OutPutMod.EM Then
            'FontSizea = Int(FontSizeb / LineSet.Width * 500) * 0.1
            'MyFontsizeb = LineSet.Width * MyFontsizea * 0.01
            'MyFontsizea = MyFontsizeb*100 / LineSet.Width
            FontSize = Int((FontSize * 1000) / LineSet.Width + 0.5) * 0.1
            Select Case FontSize
                Case 8
                    GetLPTText &= "e1"
                Case 5
                    GetLPTText &= "e2"
                Case 3
                    GetLPTText &= "e3"
                Case 2
                    GetLPTText &= "e4"
                Case 1.3
                    GetLPTText &= "e5"
                Case 1
                    GetLPTText &= "e6"
                Case 0.7
                    GetLPTText &= "e7"
                Case 0.5
                    GetLPTText &= "e8"
                Case 0.3
                    GetLPTText &= "e9"
                Case Else
                    GetLPTText &= "em#" & FontSize
            End Select
            GetLPTText &= ":|"
        End If
        If LineSet.FontFamily <> FontFamily.Name Then
            GetLPTText &= "Font#" & FontFamily.Name & ":|"
        End If

        If Bsty Then
            GetLPTText &= "b:|"
        End If
        If Isty Then
            GetLPTText &= "i:|"
        End If
        If Usty Then
            GetLPTText &= "u:|"
        End If
        If Delsty Then
            GetLPTText &= "d:|"
        End If
        'For i = 0 To Functions.Count - 1
        '    GetLPTText &= Functions(i) & ":|"
        'Next
        GetLPTText &= TextDeReplace(Text)
    End Function

    Public Function FontStyle() As FontStyle
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
        Return sty
    End Function
    Public Sub SetFontStyle(FontStyle As FontStyle)
        Bsty = False
        Delsty = False
        Usty = False
        Isty = False
        Dim tmp As Integer = FontStyle
        If tmp >= 8 Then
            tmp -= 8
            Delsty = True
        End If
        If tmp >= 4 Then
            tmp -= 4
            Usty = True
        End If
        If tmp >= 2 Then
            tmp -= 2
            Isty = True
        End If
        If tmp = 1 Then
            Bsty = True
        End If
    End Sub

    'Public Function GetHTML() As String
    '    Dim left As String = ""
    '    Dim right As String = ""
    '    If ColorTOHTML(FontColor) <> ColorTOHTML(LineSet.FontColor) Then
    '        left &= "<font color='" & ColorTOHTML(FontColor) & "'>"
    '        right = "</font>" & right
    '    End If
    'End Function

    Public Function IsSameLine(Line As ClsLine) As Boolean
        IsSameLine = True
        If Line.FontColor <> FontColor Then
            Return False
        End If
        If Line.FontSize <> FontSize Then
            Return False
        End If
        If Line.FontFamily.Name <> FontFamily.Name Then
            Return False
        End If
        If Line.FontStyle <> FontStyle Then
            Return False
        End If
    End Function

    Dim Bsty As Boolean = False         '是否加粗
    Dim Isty As Boolean = False         '是否斜体
    Dim Usty As Boolean = False         '是否下划线
    Dim Delsty As Boolean = False       '是否删除

    Sub New(LineSet As ClsLineSet)
        Me.LineSet = LineSet
    End Sub
    Sub New(Line As String, LineSet As ClsLineSet)
        Me.LineSet = LineSet
        Line = Split(Line, "//")(0)
        Dim NowLine() As String
        NowLine = Split(Line, ":|")
        '缓存变量：
        '采用最新的 LPS2.1规范
        '新增加密

        Dim Input(1) As String
        Dim MaxLen As Integer = UBound(NowLine) - 1
        For i = 0 To MaxLen
            If NowLine(i) <> "" Then
                Input = Split(NowLine(i), "#", 2)
                Select Case LCase(Input(0))
                    Case "fontcolor", "allfontcolor"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                        Else
                            FontColor = HTMLTOColor(Input(1))
                            If Input(0) = "allfontcolor" Then
                                LineSet.FontColor = FontColor
                            End If
                        End If
                    Case "fontsize", "allfontsize"
                        If UBound(Input) = 0 Then
                            'Output("请输入字体大小(1-999)" & vbCrLf, Color.Red)
                        ElseIf IsNumeric(Input(1)) Then
                            FontSize = Input(1)
                            If Input(0) = "allfontsize" Then
                                LineSet.FontSize = FontSize
                            End If
                        Else
                            'Output("字体大小设置错误" & vbCrLf, Color.Red)
                        End If
                    Case "em"
                        If UBound(Input) = 0 Then
                        ElseIf IsNumeric(Input(1)) Then
                            FontSize = Int(LineSet.Width * Input(1) * 0.1 + 0.5) * 0.1
                        Else
                            'Output("EM字体设置错误" & vbCrLf, Color.Red)
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
                            'Output("请输入字体名称 例如 宋体,Arial" & vbCrLf, Color.Red)
                        Else
                            FontFamily = New FontFamily(Input(1))
                            If Input(0) = "allfont" Then
                                LineSet.FontFamily = Input(1)
                            End If
                        End If
                    Case "backcolor"
                        'On error Resume Next
                        If UBound(Input) = 0 Then
                            'Dim ColorDialog As New ColorDialog
                            'If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                            '    BackGroundColor = ColorDialog.Color
                            '    TextBox1.BackColor = BackGroundColor
                            '    Output("背景色设置完成" & vbCrLf)
                            'End If
                        Else
                            LineSet.BackColor = HTMLTOColor(Input(1))
                        End If
                    Case "h1"
                        FontSize = 48
                    Case "h2"
                        FontSize = 36
                    Case "h3"
                        FontSize = 24
                    Case "h4"
                        FontSize = 16
                    Case "h5"
                        FontSize = 12
                    Case "h6"
                        FontSize = 9
                    Case "e1"
                        FontSize = Int(LineSet.Width * 0.8) * 0.1
                    Case "e2"
                        FontSize = Int(LineSet.Width * 0.5) * 0.1
                    Case "e3"
                        FontSize = Int(LineSet.Width * 0.3) * 0.1
                    Case "e4"
                        FontSize = Int(LineSet.Width * 0.2) * 0.1
                    Case "e5"
                        FontSize = Int(LineSet.Width * 0.13) * 0.1
                    Case "e6"
                        FontSize = Int(LineSet.Width * 0.1) * 0.1
                    Case "e7"
                        FontSize = Int(LineSet.Width * 0.7) * 0.1
                    Case "e8"
                        FontSize = Int(LineSet.Width * 0.5) * 0.1
                    Case "e9"
                        FontSize = Int(LineSet.Width * 0.3) * 0.1
                End Select
            End If
        Next
        NowLine(UBound(NowLine)) = TextReplace(NowLine(UBound(NowLine)))

        Text = NowLine(UBound(NowLine))
    End Sub
    Public Function ToFont() As Font
        If IsNothing(FontFamily) Then
            If IsNothing(LineSet.FontFamily) Then
                FontFamily = New FontFamily("新宋体")
            Else
                FontFamily = New FontFamily(LineSet.FontFamily)
            End If
        End If
        If FontSize <= 2 Then
            If LineSet.FontSize <= 2 Then
                FontSize = 16
            Else
                FontSize = LineSet.FontSize
            End If
        End If
        If IsNothing(FontStyle) Then
            SetFontStyle(Drawing.FontStyle.Regular)
        End If
        Return New Font(FontFamily, FontSize, FontStyle)
    End Function
    Public Function ToColor() As Color
        If FontColor = Nothing Then
            FontColor = LineSet.FontColor
        End If
        Return FontColor
    End Function
    Public Function HTMLTOColor(HTMLColor As String) As Color
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
            Return Color.White
            Exit Function
        End If
        HTMLTOColor = Color.FromArgb(Rv, Gv, Bv)
    End Function
    Public Function TextReplace(Input As String) As String
        Input = Input.Replace("/|", ":|")
        Input = Input.Replace("/tab", vbTab)
        Input = Input.Replace("/now", Now)
        Input = Input.Replace("/n", vbCrLf)
        Input = Input.Replace("/id", "#")
        Input = Input.Replace("/?", "//")
        Input = Input.Replace("/!", "/")
        Input = Input.Replace("/path", My.Application.Info.DirectoryPath)
        '在这里如果有进行任何修稿，需要进入CLSLINE重新更改 function TEXTDEREPLACE
        Return Input
    End Function
    Public Function TextDeReplace(Input As String) As String
        Input = Input.Replace("/", "/!")
        Input = Input.Replace("//", "/?")
        Input = Input.Replace(":|", "/|")
        Input = Input.Replace(vbTab, "/tab")
        Input = Input.Replace(vbLf, "/n")
        '    Input = Input.Replace("/now", LinPutLinNow)
        '    Input = Input.Replace("/len", LinPutLinln)
        Input = Input.Replace("#", "/id")
        '    Input = Input.Replace("/path", My.Application.Info.DirectoryPath)
        Return Input
    End Function
End Class
