Public Class FrmPassword
    Dim OpenFileDialog As New OpenFileDialog


    Private Sub Buttonpath_Click(sender As Object, e As EventArgs) Handles Buttonpath.Click
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxpath.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub FrmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog.Filter = "lpt文件|*.lpt|全部文件|*.*"
    End Sub

    Private Sub Buttoncode_Click(sender As Object, e As EventArgs) Handles Buttoncode.Click
        If Not My.Computer.FileSystem.FileExists(TextBoxpath.Text) Then
            MsgBox("找不到指定文件", MsgBoxStyle.Information)
            Exit Sub
        End If
        If vbYes = MsgBox("加密前请备份原先文档，加密后不可恢复不可编辑", MsgBoxStyle.YesNo, "确认加密？") Then
            Dim tmp As String
            tmp = Frmmain.STR2Code(Frmmain.STR2Code(My.Computer.FileSystem.ReadAllText(TextBoxpath.Text)), TextBoxpassword.Text)
            My.Computer.FileSystem.WriteAllText(Split(TextBoxpath.Text, ".")(0) & ".str.lpt", "password#" & TextBoxpassword.Text & ":|" & vbCrLf & Microsoft.VisualBasic.Right(tmp, Len(tmp) - 2), False)
            MsgBox("文件加密完成" & vbCrLf & "文件保存在 " & TextBoxpath.Text.Split(vbCrLf)(0) & ".str.lpt" & vbCrLf & "如果需要每次打开时输入密码，请将第一行更改为 ""password:|""", , "文件加密完成")
        End If

    End Sub

    Private Sub TextBoxpassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpassword.TextChanged
        If Not IsNumeric(TextBoxpassword.Text) Then
            TextBoxpassword.Undo()
        End If
    End Sub
End Class