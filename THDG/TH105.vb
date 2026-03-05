Imports DGLabFramework
Public Class TH105
    Inherits Game
    Private Memory As New Memory.Mem
    Private ProcessName As String
    Const Add_Life = &H2E6248
    Const Off_Life = &H4A4
    Private Started As Boolean = False
    Public Sub New(name As String)
        Memory.OpenProcess(name)
        ProcessName = name
    End Sub
    Public Overrides Sub Main()
        Static Life As Integer = 0
        Dim pointer1 As Integer = Memory.ReadInt(ProcessName + ".exe+" + Add_Life.ToString("X6"))
        Dim tlife As Integer = Memory.ReadInt((pointer1 + Off_Life).ToString("X8"))
        If Started Then
            If tlife = 0 Then
                Started = False
                SetStrength(100)
                Shock()
                Life = tlife
            ElseIf tlife > 10000 Then
                Started = False
                SetStrength(0)
                Life = 0
            End If
            If tlife <> Life Then
                SetStrength(100 - (tlife \ 100))
                If tlife < Life Then
                    Dim voltage As Integer = (Life - tlife) \ 4
                    If voltage > 200 Then
                        voltage = 200
                    End If
                    Shock(New Wave() With {
                        .Pulses = New List(Of Pulse) From {
                            New Pulse(10, voltage), New Pulse(10, voltage), New Pulse(10, voltage), New Pulse(10, voltage)
                        }
                    })
                End If
                Life = tlife
            End If
        Else
            If tlife = 10000 Then
                Started = True
            End If
        End If

    End Sub
End Class
