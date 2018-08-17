Public Class FrmMaker
    Public PartSplic As New List(Of String)

#Region "按键"
    Private Sub 重复RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重复RToolStripMenuItem.Click
        TextBox1.Redo()
    End Sub
    Private Sub 字体ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体ToolStripMenuItem.Click
        Dim FontDialog As New FontDialog With {
            .Font = TextBox1.SelectionFont
        }
        FontDialog.Font = New Font(FontDialog.Font.FontFamily, FontDialog.Font.Size * 2)
        If FontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            FontDialog.Font = New Font(FontDialog.Font.FontFamily, FontDialog.Font.Size * 0.5)
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
    Private Sub 剪切TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切TToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub
    Private Sub 复制CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制CToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub
    Private Sub 粘贴PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴PToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub
    Private Sub 全选AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选AToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub
    Private Sub 撤消UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤消UToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub
    Public Function FindFontStyle(Number As FontStyle, Find As FontStyle) As FontStyle
        If FindNum(Number, Find) Then
            Return Number - Find
        Else
            Return Number + Find
        End If
    End Function
    Private Sub ButtonNM_Click(sender As Object, e As EventArgs) Handles ButtonNM.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, FontStyle.Regular)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub ButtonU_Click(sender As Object, e As EventArgs) Handles ButtonU.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        Dim oldStar As Integer = TextBox1.SelectionStart
        TextBox1.SelectionLength = 1
        Dim allsty As FontStyle = FindFontStyle(TextBox1.SelectionFont.Style, FontStyle.Underline)

        For i = 0 To oldlen - 1
            TextBox1.SelectionStart = oldStar + i
            TextBox1.SelectionFont = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, allsty)
        Next
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionStart = oldStar
    End Sub
    Private Sub ButtonI_Click(sender As Object, e As EventArgs) Handles ButtonI.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        Dim oldStar As Integer = TextBox1.SelectionStart
        TextBox1.SelectionLength = 1
        Dim allsty As FontStyle = FindFontStyle(TextBox1.SelectionFont.Style, FontStyle.Italic)

        For i = 0 To oldlen - 1
            TextBox1.SelectionStart = oldStar + i
            TextBox1.SelectionFont = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, allsty)
        Next
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionStart = oldStar
    End Sub
    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        Dim oldStar As Integer = TextBox1.SelectionStart
        TextBox1.SelectionLength = 1
        Dim allsty As FontStyle = FindFontStyle(TextBox1.SelectionFont.Style, FontStyle.Bold)

        For i = 0 To oldlen - 1
            TextBox1.SelectionStart = oldStar + i
            TextBox1.SelectionFont = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, allsty)
        Next
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionStart = oldStar
    End Sub
    Private Sub ButtonFSB_Click(sender As Object, e As EventArgs) Handles ButtonFSB.Click
        Dim size As Single
        Dim oldlen As Integer = TextBox1.SelectionLength
        Dim oldStar As Integer = TextBox1.SelectionStart
        TextBox1.SelectionLength = 1
         For i = 0 To oldlen - 1
            TextBox1.SelectionStart = oldStar + i
            size = TextBox1.SelectionFont.Size * 1.1
            TextBox1.SelectionFont = New Font(TextBox1.SelectionFont.FontFamily, size, TextBox1.SelectionFont.Style)
        Next
        TextBox1.SelectionStart = oldStar
        TextBox1.SelectionLength = oldlen
    End Sub
    Private Sub ButtonFS16_Click(sender As Object, e As EventArgs) Handles ButtonFS16.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, 8, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub ButtonFS12_Click(sender As Object, e As EventArgs) Handles ButtonFS12.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, 6, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub ButtonFSS_Click(sender As Object, e As EventArgs) Handles ButtonFSS.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim size As Single = TextBox1.SelectionFont.Size * 0.9
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, size, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub

    Private Sub ButtonH4_Click(sender As Object, e As EventArgs) Handles ButtonH4.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, 8, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub ButtonH3_Click(sender As Object, e As EventArgs) Handles ButtonH3.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, 12, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub ButtonH2_Click(sender As Object, e As EventArgs) Handles ButtonH2.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, 18, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    Private Sub ButtonH1_Click(sender As Object, e As EventArgs) Handles ButtonH1.Click
        Dim oldlen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim newfont As Font = New Font(TextBox1.SelectionFont.FontFamily, 24, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = oldlen
        TextBox1.SelectionFont = newfont
    End Sub
    'Case "h1"
    'MyFontsize = 48
    'Case "h2"
    'MyFontsize = 36
    'Case "h3"
    'MyFontsize = 24
    'Case "h4"
    'MyFontsize = 16
#End Region

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlHTML.SelectedIndexChanged
        If TabControlHTML.SelectedIndex = 0 Then
            MakeStyle()
        ElseIf TabControlHTML.SelectedIndex = 1 Then
            MakeText()
            ColorCode()
        ElseIf TabControlHTML.SelectedIndex = 2 Then
            MakeHTML()
        End If
    End Sub

    'Public Function IsSameLine(Line1 As ClsLine, Line2 As ClsLine) As Boolean
    '    IsSameLine = True
    '    If Line1.FontColor <> Line2.FontColor Then
    '        Return False
    '    End If
    '    If Line1.FontSize <> Line2.FontSize Then
    '        Return False
    '    End If
    '    If Line1.FontFamily.ToString <> Line2.FontFamily.ToString Then
    '        Return False
    '    End If
    '    If Line1.FontStyle <> Line2.FontStyle Then
    '        Return False
    '    End If
    'End Function
    Private Sub MakeStyle()
        'With FrmMain.LineSet
        '    .BackColor = PictureBoxBC.BackColor
        '    .FontColor = PictureBoxFC.BackColor
        '    .FontFamily = TextBoxFontName.Text
        '    .FontSize = NumericUpDownFS.Value
        '    .Mode = ClsLineSet.OutPutMod.Maker
        '    .Width = NumericUpDownW.Value / 2
        'End With
        TextBox1.Text = ""
        Dim NewLSFM As ClsLineSet = LineSetForMaker()
        NewLSFM.Mode = ClsLineSet.OutPutMod.Maker
        FrmMain.LPSOpen(TextBoxCode.Text, TextBox1, NewLSFM)
    End Sub


    Private Sub ButtonColor_Click(sender As Object, e As EventArgs) Handles ButtonPK.Click, ButtonCR.Click, ButtonCB.Click, ButtonCW.Click, ButtonDB.Click, ButtonOR.Click, ButtonDG.Click, ButtonCG.Click
        TextBox1.SelectionColor = sender.BackColor()
    End Sub
    Public FontColor As Color = Color.White

    Private Sub TextBoxBC_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBC.TextChanged
        If TextBoxBC.Text.Length = 6 Then
            If FrmMain.HTMLTOColor(TextBoxBC.Text) = Nothing Then Exit Sub
            PictureBoxBC.BackColor = FrmMain.HTMLTOColor(TextBoxBC.Text)
            TextBox1.BackColor = PictureBoxBC.BackColor
        End If
    End Sub

    Private Sub TextBoxFC_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFC.TextChanged
        If TextBoxFC.Text.Length = 6 Then
            If FrmMain.HTMLTOColor(TextBoxFC.Text) = Nothing Then Exit Sub
            PictureBoxFC.BackColor = FrmMain.HTMLTOColor(TextBoxFC.Text)
            FontColor = PictureBoxFC.BackColor
        End If
    End Sub

    Private Sub PictureBoxBC_Click(sender As Object, e As EventArgs) Handles PictureBoxBC.Click
        Dim ColorDialog As New ColorDialog With {
            .Color = PictureBoxBC.BackColor
        }

        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxBC.BackColor = ColorDialog.Color
            TextBox1.BackColor = PictureBoxBC.BackColor
            TextBoxBC.Text = Frmmain.ColorTOHTML(PictureBoxBC.BackColor)
        End If
    End Sub

   
    Private Sub PictureBoxFC_Click(sender As Object, e As EventArgs) Handles PictureBoxFC.Click
        Dim ColorDialog As New ColorDialog With {
            .Color = PictureBoxFC.BackColor
        }

        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxFC.BackColor = ColorDialog.Color
            TextBoxFC.Text = Frmmain.ColorTOHTML(PictureBoxFC.BackColor)
        End If
    End Sub
    Public FontSize As Integer = 16
    Private Sub NumericUpDownFS_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownFS.ValueChanged
        FontSize = NumericUpDownFS.Value
    End Sub
    Dim NumUDCon As Boolean = False

    Private Sub FrmMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDownH.Maximum = SystemInformation.PrimaryMonitorSize.Height * 2
        NumericUpDownW.Maximum = SystemInformation.PrimaryMonitorSize.Width * 2
    End Sub

    Private Sub NumericUpDownW_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownW.ValueChanged
        If NumUDCon Then
            Me.Width = NumericUpDownW.Value * 0.5 + 200
        End If
    End Sub

    Private Sub NumericUpDownH_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownH.ValueChanged
        If NumUDCon Then
            Me.Height = NumericUpDownH.Value * 0.5 + 75
        End If
    End Sub
    Public Sub ColorCode()
        Dim Lines() As String = Split(TextBoxCode.Text, vbLf)
        Dim Tmps() As String
        Dim Tmpss() As String
        TextBoxCode.SelectAll()
        '2B91AF Color.FromArgb(2855343)
        TextBoxCode.SelectionColor = Color.FromArgb(2855343)
        Dim SelectionStart As Integer
        Dim TotalLineLength As Integer = Lines(0).Length + 1
        TextBoxCode.Select(0, TotalLineLength)
        TextBoxCode.SelectionColor = Color.Green
        For i = 1 To Lines.Length - 1
            Tmps = Split(Lines(i), ":|")

            SelectionStart = TotalLineLength
            If Tmps(0).Contains("#") Then
                Tmpss = Split(Tmps(0), "#")
                TextBoxCode.Select(SelectionStart + Tmpss(0).Length, 1)
                TextBoxCode.SelectionColor = Color.Blue
                TextBoxCode.Select(SelectionStart + Tmpss(0).Length + 1, Tmpss(1).Length)

                TextBoxCode.SelectionColor = Color.Chocolate
            End If
            SelectionStart += Tmps(0).Length

            For b = 1 To Tmps.Length - 1

                TextBoxCode.Select(SelectionStart, 2)
                TextBoxCode.SelectionColor = Color.RoyalBlue
                If Tmps(b).Contains("#") Then
                    Tmpss = Split(Tmps(b), "#")
                    TextBoxCode.Select(SelectionStart + 2 + Tmpss(0).Length, 1)
                    TextBoxCode.SelectionColor = Color.Blue
                    TextBoxCode.Select(SelectionStart + 2 + Tmpss(0).Length + 1, Tmpss(1).Length)
                    TextBoxCode.SelectionColor = Color.Chocolate
                End If
                SelectionStart += 2 + Tmps(b).Length

            Next
            TextBoxCode.Select(SelectionStart - Tmps(Tmps.Length - 1).Length, Tmps(Tmps.Length - 1).Length)
            TextBoxCode.SelectionColor = Color.Black
            TotalLineLength += Lines(i).Length + 1
        Next
    End Sub

    Private Sub TextBox1_SizeChanged(sender As Object, e As EventArgs) Handles TextBox1.SizeChanged
        NumUDCon = False
        NumericUpDownH.Value = TextBox1.Height * 2
        NumericUpDownW.Value = TextBox1.Width * 2
        NumUDCon = True
    End Sub
    Public Function FindNum(Number As Integer, Find As Integer) As Boolean
        If Number = 0 Then
            Return False
        ElseIf Number = Find Then
            Return True
        End If
        Dim i As Integer = 0
        Do
            If Number < 2 ^ i Then
                i -= 1
            ElseIf Number = 2 ^ 1 Then
                Return False
            End If
            i += 1
        Loop
        Return FindNum(Number - 2 ^ i, Find)
    End Function
    Public Function LineSetForMaker() As ClsLineSet
        Dim Mode As ClsLineSet.OutPutMod
        Dim Width As Single = NumericUpDownW.Value
        If RadioButtonEM.Checked Then
            Mode = ClsLineSet.OutPutMod.EM
        Else
            Mode = ClsLineSet.OutPutMod.PX
            Width /= 2
        End If

        'With LineSetForMaker
        '    .BackColor = PictureBoxBC.BackColor
        '    .FontColor = PictureBoxFC.BackColor
        '    .FontFamily = TextBoxFontName.Text
        '    .FontSize = NumericUpDownFS.Value

        '    .Width = NumericUpDownW.Value
        'End With
        Return New ClsLineSet(NumericUpDownFS.Value, PictureBoxFC.BackColor, Mode, Width, TextBoxFontName.Text, PictureBoxBC.BackColor)
    End Function
    Public Sub MakeText()
        TextBoxCode.Text = FrmMain.MakeText(TextBox1, LineSetForMaker)
    End Sub
    Public Sub MakeHTML()
        TextBoxHTML.Text = FrmMain.MakeHTML(TextBox1, LineSetForMaker)
    End Sub

    Private Sub FrmMaker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class