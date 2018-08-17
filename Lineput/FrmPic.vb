Public Class FrmPic
    Private Sub 移动ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 移动ToolStripMenuItem.Click
        移动ToolStripMenuItem.Checked = Not 移动ToolStripMenuItem.Checked
        If 移动ToolStripMenuItem.Checked Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub
    Private Sub 背景透明ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 背景透明ToolStripMenuItem.Click
        背景透明ToolStripMenuItem.Checked = Not 背景透明ToolStripMenuItem.Checked
        If 背景透明ToolStripMenuItem.Checked Then
            Me.TransparencyKey = Color.Transparent
        Else
            Me.TransparencyKey = Nothing
        End If
    End Sub

    Private Sub 关闭ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 关闭并继续ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭并继续ToolStripMenuItem.Click
        Frmmain.ReadLine()
        Me.Close()
    End Sub
End Class