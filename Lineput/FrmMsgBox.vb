Public Class FrmMsgBox
    Private Sub 移动ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 移动ToolStripMenuItem.Click
        移动ToolStripMenuItem.Checked = Not 移动ToolStripMenuItem.Checked
        If 移动ToolStripMenuItem.Checked Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub 关闭ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭ToolStripMenuItem.Click
        Me.Close()
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
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox1.SelectAll()
        TextBox1.SelectedText = ""
    End Sub
    Private Sub 打开OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开OToolStripMenuItem.Click
        If MsgBox("注意！打开新文档将会覆盖旧文档,是否继续？", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "警告") <> MsgBoxResult.Yes Then Exit Sub
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.FilterIndex = 3 Then
                TextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Else
                TextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
            End If
        End If
    End Sub

    Private Function 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click
        保存SToolStripMenuItem_Click = False
        If TextBox1.Text = "" Then
            Exit Function
        End If
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FilterIndex = 3 Then
                TextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Else
                TextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
            End If
            保存SToolStripMenuItem_Click = True
        End If
    End Function
    Private Sub 显示工具栏ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示工具栏ToolStripMenuItem.Click
        ToolStrip1.Visible = 显示工具栏ToolStripMenuItem.Checked
    End Sub
    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        ToolStrip1.Dock += 1
        If ToolStrip1.Dock = 5 Then
            ToolStrip1.Dock = 1
        End If
    End Sub

    Private Sub ToolStripButtonRed_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRed.Click
        TextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TextBox1.SelectionColor = Color.Red
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        TextBox1.SelectionColor = Color.Yellow
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        TextBox1.SelectionColor = Color.DeepSkyBlue
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        TextBox1.SelectionColor = Color.Green
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        TextBox1.SelectionColor = TextBox1.SelectionColor
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size + 2, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        If TextBox1.SelectionFont.Size <= 2 Then
            Exit Sub
        End If
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size - 2, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, 9, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, 12, TextBox1.SelectionFont.Style)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, FontStyle.Bold)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, FontStyle.Italic)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim OldLen As Integer = TextBox1.SelectionLength
        TextBox1.SelectionLength = 1
        Dim NEWFONT As Font = New Font(TextBox1.SelectionFont.FontFamily, TextBox1.SelectionFont.Size, FontStyle.Underline)
        TextBox1.SelectionLength = OldLen
        TextBox1.SelectionFont = NEWFONT
    End Sub

    Private Sub 另存为并清空ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存为并清空ToolStripMenuItem.Click
        If 保存SToolStripMenuItem_Click(sender, e) Then
            ToolStripMenuItem1_Click(sender, e)
        End If
    End Sub

    Private Sub 另存为并导入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存为并导入ToolStripMenuItem.Click
        If 保存SToolStripMenuItem_Click(sender, e) Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If OpenFileDialog1.FilterIndex = 3 Then
                    TextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                Else
                    TextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
                End If
            End If
        End If
    End Sub
    Private Sub 记录板分身ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 记录板分身ToolStripMenuItem.Click
        Dim FrmMsgBox As New FrmMsgBox
        FrmMsgBox.Show()
    End Sub

    Private Sub 重复RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重复RToolStripMenuItem.Click
        TextBox1.Redo()
    End Sub
    Private Sub 背景颜色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 背景颜色ToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub 字体ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体ToolStripMenuItem.Click
        FontDialog1.Font = TextBox1.SelectionFont
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub 字体颜色DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体颜色DToolStripMenuItem.Click
        ColorDialog1.Color = TextBox1.SelectionColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub 背景颜色ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 背景颜色ToolStripMenuItem1.Click
        ColorDialog1.Color = TextBox1.SelectionColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class