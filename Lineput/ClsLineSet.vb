Public Class ClsLineSet
    Public FontSize As Single
    Public FontColor As Color
    Public Mode As OutPutMod
    Public Width As Integer
    Public FontFamily As String
    Public BackColor As Color

    Enum OutPutMod
        PX
        EM
        LPS
        Maker
    End Enum
    Sub New()

    End Sub
    Sub New(FontSize As Single, FontColor As Color, Mode As OutPutMod, Width As Integer, FontFamily As String, BackColor As Color)
        Me.FontSize = FontSize
        Me.FontColor = FontColor
        Me.Mode = Mode
        Me.Width = Width
        Me.FontFamily = FontFamily
        Me.BackColor = BackColor
    End Sub
End Class
