Public Class FrmTimer
    Dim TimerMode As Boolean = False
    Dim TimeS, TimeSRD, TimeSST As Integer
    Dim TimeS2 As Integer = -1
    Dim Timei As Single
    Dim TimeNow As Date
    Dim IsRun As Boolean = False

    Public Sub TimeSet()
        TimeS = TimeSST
        TimeNow = DateAdd(DateInterval.Second, TimeS, Now)
        Label1.ForeColor = Color.FromArgb(0, 0, 0)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = TimeS
        Timei = 0
        'TimerMode = True
    End Sub
    Public Sub TimeSet(Time倒计时 As Integer)
        If Time倒计时 <= 1 Or Time倒计时 > 999 Then
            Time倒计时 = 60
        End If
        TimeSST = Time倒计时
        TimeS = TimeSST
        TimeS2 = Time倒计时 / 2
        TimeNow = DateAdd(DateInterval.Second, TimeS, Now)
        Label1.ForeColor = Color.FromArgb(0, 0, 0)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = TimeS
        Timei = 0
        'TimerMode = True
    End Sub
    Public Sub TimeSet(Time倒计时 As Integer, Time最后警告 As Integer)
        If Time倒计时 <= 1 Or Time倒计时 > 999 Then
            Time倒计时 = 60
        End If
        TimeS2 = Time最后警告
        TimeSST = Time倒计时
        TimeS = TimeSST
        TimeNow = DateAdd(DateInterval.Second, TimeS, Now)
        Label1.ForeColor = Color.FromArgb(0, 0, 0)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = TimeS
        Timei = 0
        'TimerMode = True
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If TimerMode = True Then
            TimerMode = False
        ElseIf TimerMode = False Then
            'TimeS = TimeSST
            TimeNow = DateAdd(DateInterval.Second, TimeS, Now)
            'Label1.ForeColor = Color.FromArgb(0, 0, 0)
            'ProgressBar1.Value = 0
            'ProgressBar1.Maximum = TimeS
            'Timei = 0
            TimerMode = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If TimerMode = True Then
            Timei -= 6.5
            TimeS = DateDiff(DateInterval.Second, Now, TimeNow)
            If TimeS <> TimeSRD Then
                ProgressBar1.Value += 1
                Timei = 99
                Label1.Text = ""
                If TimeS < 100 Then
                    Label1.Text &= 0
                End If
                If TimeS < 10 Then
                    Label1.Text &= 0
                End If
                Label1.Text &= TimeS
                If TimeS < TimeS2 And TimeS > Int(0.5 * TimeS2) Then
                    Label1.ForeColor = Color.FromArgb(Int(Rnd() * 256), Int(Rnd() * 256), Int(Rnd() * 256))
                ElseIf TimeS < Int(0.5 * TimeS2) Then
                    Label1.ForeColor = Color.FromArgb(255, 0, 0)
                End If
            End If
            TimeSRD = TimeS
            Text = TimeS
            If TimeS = 0 Then
                ProgressBar1.Visible = False
                TimerMode = False
                Label2.Text = "00"
                Label1.Text = "TUP"
                Exit Sub
            End If

            Label2.Text = ""
            If Timei < 10 Then
                Label2.Text = 0
                If Timei < 0 Then
                    Timei = 0
                End If
            End If
            Label2.Text &= Int(Timei)
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TimeSST = 120 '总及时
        'TimeS2 = -1  ‘一次提醒
        IsRun = True
    End Sub

    Private Sub FrmTimer_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If IsRun Then
            Label1.Font = New Font("宋体", Me.Size.Height * 0.7)
            Label2.Font = New Font("宋体", Me.Size.Height * 0.35)
        End If
    End Sub

    Private Sub 重新开始ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重新开始ToolStripMenuItem.Click
        TimeSet()
    End Sub

    Private Sub 设置时间ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置时间ToolStripMenuItem.Click
        Dim imput As String = InputBox("输入倒计时间 单位 秒", TimeSST)
        If IsNumeric(imput) Then
            TimeSet(imput)
            MsgBox("设置完成")
        End If
        MsgBox("请输入数字")
    End Sub

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

    Private Sub FrmTimer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TimerMode Then
            If vbYes <> MsgBox("确认关闭计时器吗，您的计时还未结束", MsgBoxStyle.Information + vbYesNo) Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
