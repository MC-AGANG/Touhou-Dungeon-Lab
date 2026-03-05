Imports DGLabFramework
''' <summary>
''' 表示一个要被绑定的游戏
''' </summary>
Public MustInherit Class Game
    Public Shared ReadOnly Property Wave_Short As New Wave With {
        .Pulses = New List(Of Pulse) From {
            New Pulse(40, 6), New Pulse(40, 12), New Pulse(40, 18), New Pulse(40, 24)
        }
    }
    Public Shared ReadOnly Property Wave_ShortStrong As New Wave With {
        .Pulses = New List(Of Pulse) From {
            New Pulse(10, 16), New Pulse(10, 32), New Pulse(10, 48), New Pulse(10, 64)
        }
    }
    Public MustOverride Sub Main()

    Public Sub SetStrength(value As Integer)
        Form1.DGSV.SetStrength(DGServer.Channel.A, value, 0)
        Form1.DGSV.SetStrength(DGServer.Channel.B, value, 0)
    End Sub
    Public Sub Shock()
        Form1.DGSV.SendWave(DGServer.Channel.A, Waves.Breathe, 0)
        Form1.DGSV.SendWave(DGServer.Channel.B, Waves.Breathe, 0)
    End Sub
    Public Sub Shock(w As Wave)
        Form1.DGSV.SendWave(DGServer.Channel.A, w, 0)
        Form1.DGSV.SendWave(DGServer.Channel.B, w, 0)
    End Sub
End Class
