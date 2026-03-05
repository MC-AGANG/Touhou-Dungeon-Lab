Public Class TH20
    Inherits Game
    Const Add_Life = &H1BA6A8
    Const Add_Score = &H1BA5F0
    Const Add_Graze = &H1BA6D4
    Private Memory As New Memory.Mem
    Private ProcessName As String
    Private Strength As Integer = 0
    Public Sub New(name As String)
        Memory.OpenProcess(name)
        ProcessName = name
    End Sub
    Public Overrides Sub Main()
        Static score As Integer = 0
        Static life As Integer = 0
        Static graze As Integer = 0
        Dim tscore As Integer = Memory.ReadInt(ProcessName + ".exe+" + Add_Score.ToString("X6"))
        Dim tlife As Integer = Memory.ReadInt(ProcessName + ".exe+" + Add_Life.ToString("X6"))
        Dim tgraze As Integer = Memory.ReadInt(ProcessName + ".exe+" + Add_Graze.ToString("X6"))
        If score > 0 AndAlso tscore = 0 Then
            Strength = 0
            SetStrength(Strength)
        Else
            If tlife < life Then
                If Strength < 100 Then
                    Strength += 5
                    SetStrength(Strength)
                End If
                Shock()
            End If
            If tgraze > graze Then
                Shock(Wave_Short)
            End If
        End If
        score = tscore
        life = tlife
        graze = tgraze
    End Sub

End Class
