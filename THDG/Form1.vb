Imports DGLabFramework

Public Class Form1
    Public WithEvents DGSV As New DGServer
    Public GameProcess As Game

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_Game.SelectedIndex = 0
        TB_Address.Text = DGServer.GetLocalIPv4Address
        For Each p In Process.GetProcesses
            If p.MainWindowHandle <> IntPtr.Zero Then
                LB_Process.Items.Add(p.ProcessName)
            End If
        Next
        If LB_Process.Items.Count > 0 Then
            LB_Process.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GameProcess = New TH105("th105c")
        AddHandler Timer1.Tick, AddressOf GameProcess.Main
        Timer1.Start()
    End Sub
    Private Sub BT_Detect_Click(sender As Object, e As EventArgs) Handles BT_Detect.Click
        TB_Address.Text = DGServer.GetLocalIPv4Address
    End Sub

    Private Sub BT_Start_Click(sender As Object, e As EventArgs) Handles BT_Start.Click
        If MsgBox("本软件的使用以自愿为原则，
对可能造成的身体与精神伤害概不负责。", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            DGSV.Address = TB_Address.Text
            DGSV.Port = Val(TB_Port.Text)
            DGSV.Start()
            PB_QR.Image = DGSV.GetQRCode
            ShowPage(1)
        End If
    End Sub

    Private Sub BT_Refresh_Click(sender As Object, e As EventArgs) Handles BT_Refresh.Click
        LB_Process.Items.Clear()

        For Each p In Process.GetProcesses
            If p.MainWindowHandle <> IntPtr.Zero Then
                LB_Process.Items.Add(p.ProcessName)
            End If
        Next
        If LB_Process.Items.Count > 0 Then
            LB_Process.SelectedIndex = 0
        End If
    End Sub

    Private Sub CB_Game_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Game.SelectedIndexChanged
        If CB_Game.SelectedIndex = 0 Then
            PB_Game.Image = New Bitmap("images\th06.png")
        ElseIf CB_Game.SelectedIndex = 1 Then
            MsgBox("因技术问题，目前东方绯想天仅支持
来自莉莉云的汉化版(th105c.exe)")
            PB_Game.Image = New Bitmap("images\th105.jpg")
        ElseIf CB_Game.SelectedIndex = 2 Then
            PB_Game.Image = New Bitmap("images\th20.jpg")
        End If
    End Sub
    Private Sub ShowPage(id As Integer)
        Select Case id
            Case 0
                GB_Address.Visible = True
                GB_Game.Visible = True
                GB_Process.Visible = True
                BT_Start.Visible = True

                PB_QR.Visible = False
                LB_QR.Visible = False

                LB_Running.Visible = False
                GB_Strength.Visible = False
                BT_Stop.Visible = False
            Case 1
                GB_Address.Visible = False
                GB_Game.Visible = False
                GB_Process.Visible = False
                BT_Start.Visible = False

                PB_QR.Visible = True
                LB_QR.Visible = True

                LB_Running.Visible = False
                GB_Strength.Visible = False
                BT_Stop.Visible = False
            Case 2
                GB_Address.Visible = False
                GB_Game.Visible = False
                GB_Process.Visible = False
                BT_Start.Visible = False

                PB_QR.Visible = False
                LB_QR.Visible = False

                LB_Running.Visible = True
                GB_Strength.Visible = True
                BT_Stop.Visible = True
        End Select
    End Sub
    Private Sub DGSV_Connected(deviceId As String) Handles DGSV.Connected
        Invoke(Sub()
                   If CB_Game.SelectedIndex = 0 Then
                       GameProcess = New TH06(LB_Process.SelectedItem)
                   ElseIf CB_Game.SelectedIndex = 1 Then
                       GameProcess = New TH105(LB_Process.SelectedItem)
                   ElseIf CB_Game.SelectedIndex = 2 Then
                       GameProcess = New TH20(LB_Process.SelectedItem)
                   End If
                   AddHandler Timer1.Tick, AddressOf GameProcess.Main
                   Timer1.Start()
                   ShowPage(2)
               End Sub)
    End Sub

    Private Sub DGSV_Disconnected(deviceId As String) Handles DGSV.Disconnected
        Invoke(Sub()
                   If Timer1.Enabled Then
                       ShowPage(0)
                       Dim handler As EventHandler = AddressOf GameProcess.Main
                       RemoveHandler Timer1.Tick, handler
                       Timer1.Stop()
                       DGSV.Stop()
                   End If
               End Sub)

    End Sub

    Private Sub DGSV_Received(data As DGMessage) Handles DGSV.Received
        If data.Type = "msg" AndAlso data.Message.StartsWith("strength") Then
            Dim values() As String = Mid(data.Message, 10).Split("+")
            Invoke(Sub()
                       LB_StrengthA.Text = "A:" + values(0)
                       LB_StrengthB.Text = "B:" + values(1)
                   End Sub)
        End If
    End Sub

    Private Sub BT_Stop_Click(sender As Object, e As EventArgs) Handles BT_Stop.Click
        If Timer1.Enabled Then
            ShowPage(0)
            Dim handler As EventHandler = AddressOf GameProcess.Main
            RemoveHandler Timer1.Tick, handler
            Timer1.Stop()
            DGSV.Stop()
        End If
    End Sub

End Class