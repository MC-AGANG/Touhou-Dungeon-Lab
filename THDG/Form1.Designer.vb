<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GB_Game = New System.Windows.Forms.GroupBox()
        Me.PB_Game = New System.Windows.Forms.PictureBox()
        Me.CB_Game = New System.Windows.Forms.ComboBox()
        Me.GB_Address = New System.Windows.Forms.GroupBox()
        Me.BT_Detect = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Port = New System.Windows.Forms.TextBox()
        Me.TB_Address = New System.Windows.Forms.TextBox()
        Me.BT_Start = New System.Windows.Forms.Button()
        Me.GB_Process = New System.Windows.Forms.GroupBox()
        Me.BT_Refresh = New System.Windows.Forms.Button()
        Me.LB_Process = New System.Windows.Forms.ListBox()
        Me.PB_QR = New System.Windows.Forms.PictureBox()
        Me.LB_QR = New System.Windows.Forms.Label()
        Me.LB_Running = New System.Windows.Forms.Label()
        Me.BT_Stop = New System.Windows.Forms.Button()
        Me.GB_Strength = New System.Windows.Forms.GroupBox()
        Me.LB_StrengthB = New System.Windows.Forms.Label()
        Me.LB_StrengthA = New System.Windows.Forms.Label()
        Me.GB_Game.SuspendLayout()
        CType(Me.PB_Game, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Address.SuspendLayout()
        Me.GB_Process.SuspendLayout()
        CType(Me.PB_QR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Strength.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'GB_Game
        '
        Me.GB_Game.Controls.Add(Me.PB_Game)
        Me.GB_Game.Controls.Add(Me.CB_Game)
        Me.GB_Game.Location = New System.Drawing.Point(288, 15)
        Me.GB_Game.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Game.Name = "GB_Game"
        Me.GB_Game.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Game.Size = New System.Drawing.Size(232, 238)
        Me.GB_Game.TabIndex = 0
        Me.GB_Game.TabStop = False
        Me.GB_Game.Text = "选择游戏"
        '
        'PB_Game
        '
        Me.PB_Game.Location = New System.Drawing.Point(27, 61)
        Me.PB_Game.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB_Game.Name = "PB_Game"
        Me.PB_Game.Size = New System.Drawing.Size(171, 160)
        Me.PB_Game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_Game.TabIndex = 1
        Me.PB_Game.TabStop = False
        '
        'CB_Game
        '
        Me.CB_Game.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Game.FormattingEnabled = True
        Me.CB_Game.Items.AddRange(New Object() {"东方红魔乡", "东方绯想天", "东方锦上京"})
        Me.CB_Game.Location = New System.Drawing.Point(8, 25)
        Me.CB_Game.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_Game.Name = "CB_Game"
        Me.CB_Game.Size = New System.Drawing.Size(209, 23)
        Me.CB_Game.TabIndex = 0
        '
        'GB_Address
        '
        Me.GB_Address.Controls.Add(Me.BT_Detect)
        Me.GB_Address.Controls.Add(Me.Label2)
        Me.GB_Address.Controls.Add(Me.Label1)
        Me.GB_Address.Controls.Add(Me.TB_Port)
        Me.GB_Address.Controls.Add(Me.TB_Address)
        Me.GB_Address.Location = New System.Drawing.Point(288, 260)
        Me.GB_Address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Address.Name = "GB_Address"
        Me.GB_Address.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Address.Size = New System.Drawing.Size(232, 154)
        Me.GB_Address.TabIndex = 1
        Me.GB_Address.TabStop = False
        Me.GB_Address.Text = "设置地址"
        '
        'BT_Detect
        '
        Me.BT_Detect.Location = New System.Drawing.Point(8, 95)
        Me.BT_Detect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_Detect.Name = "BT_Detect"
        Me.BT_Detect.Size = New System.Drawing.Size(211, 45)
        Me.BT_Detect.TabIndex = 4
        Me.BT_Detect.Text = "自动识别"
        Me.BT_Detect.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "端口"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "地址"
        '
        'TB_Port
        '
        Me.TB_Port.Location = New System.Drawing.Point(55, 61)
        Me.TB_Port.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_Port.Name = "TB_Port"
        Me.TB_Port.Size = New System.Drawing.Size(163, 25)
        Me.TB_Port.TabIndex = 1
        Me.TB_Port.Text = "9000"
        '
        'TB_Address
        '
        Me.TB_Address.Location = New System.Drawing.Point(55, 24)
        Me.TB_Address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_Address.Name = "TB_Address"
        Me.TB_Address.Size = New System.Drawing.Size(163, 25)
        Me.TB_Address.TabIndex = 0
        Me.TB_Address.Text = "127.0.0.1"
        '
        'BT_Start
        '
        Me.BT_Start.Location = New System.Drawing.Point(288, 421)
        Me.BT_Start.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_Start.Name = "BT_Start"
        Me.BT_Start.Size = New System.Drawing.Size(232, 60)
        Me.BT_Start.TabIndex = 2
        Me.BT_Start.Text = "开始使用"
        Me.BT_Start.UseVisualStyleBackColor = True
        '
        'GB_Process
        '
        Me.GB_Process.Controls.Add(Me.BT_Refresh)
        Me.GB_Process.Controls.Add(Me.LB_Process)
        Me.GB_Process.Location = New System.Drawing.Point(16, 15)
        Me.GB_Process.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Process.Name = "GB_Process"
        Me.GB_Process.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Process.Size = New System.Drawing.Size(264, 466)
        Me.GB_Process.TabIndex = 3
        Me.GB_Process.TabStop = False
        Me.GB_Process.Text = "选择游戏进程"
        '
        'BT_Refresh
        '
        Me.BT_Refresh.Location = New System.Drawing.Point(8, 395)
        Me.BT_Refresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_Refresh.Name = "BT_Refresh"
        Me.BT_Refresh.Size = New System.Drawing.Size(247, 64)
        Me.BT_Refresh.TabIndex = 1
        Me.BT_Refresh.Text = "刷新"
        Me.BT_Refresh.UseVisualStyleBackColor = True
        '
        'LB_Process
        '
        Me.LB_Process.FormattingEnabled = True
        Me.LB_Process.ItemHeight = 15
        Me.LB_Process.Location = New System.Drawing.Point(8, 25)
        Me.LB_Process.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LB_Process.Name = "LB_Process"
        Me.LB_Process.Size = New System.Drawing.Size(247, 364)
        Me.LB_Process.TabIndex = 0
        '
        'PB_QR
        '
        Me.PB_QR.Location = New System.Drawing.Point(105, 110)
        Me.PB_QR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB_QR.Name = "PB_QR"
        Me.PB_QR.Size = New System.Drawing.Size(341, 320)
        Me.PB_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_QR.TabIndex = 4
        Me.PB_QR.TabStop = False
        Me.PB_QR.Visible = False
        '
        'LB_QR
        '
        Me.LB_QR.AutoSize = True
        Me.LB_QR.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_QR.Location = New System.Drawing.Point(52, 54)
        Me.LB_QR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_QR.Name = "LB_QR"
        Me.LB_QR.Size = New System.Drawing.Size(413, 32)
        Me.LB_QR.TabIndex = 4
        Me.LB_QR.Text = "请使用DG-LAB app扫描下方二维码"
        Me.LB_QR.Visible = False
        '
        'LB_Running
        '
        Me.LB_Running.AutoSize = True
        Me.LB_Running.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_Running.Location = New System.Drawing.Point(156, 25)
        Me.LB_Running.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_Running.Name = "LB_Running"
        Me.LB_Running.Size = New System.Drawing.Size(222, 52)
        Me.LB_Running.TabIndex = 5
        Me.LB_Running.Text = "进程已连接"
        Me.LB_Running.Visible = False
        '
        'BT_Stop
        '
        Me.BT_Stop.Location = New System.Drawing.Point(140, 385)
        Me.BT_Stop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_Stop.Name = "BT_Stop"
        Me.BT_Stop.Size = New System.Drawing.Size(276, 74)
        Me.BT_Stop.TabIndex = 6
        Me.BT_Stop.Text = "断开连接"
        Me.BT_Stop.UseVisualStyleBackColor = True
        Me.BT_Stop.Visible = False
        '
        'GB_Strength
        '
        Me.GB_Strength.Controls.Add(Me.LB_StrengthB)
        Me.GB_Strength.Controls.Add(Me.LB_StrengthA)
        Me.GB_Strength.Location = New System.Drawing.Point(145, 139)
        Me.GB_Strength.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Strength.Name = "GB_Strength"
        Me.GB_Strength.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Strength.Size = New System.Drawing.Size(269, 186)
        Me.GB_Strength.TabIndex = 7
        Me.GB_Strength.TabStop = False
        Me.GB_Strength.Text = "强度"
        Me.GB_Strength.Visible = False
        '
        'LB_StrengthB
        '
        Me.LB_StrengthB.AutoSize = True
        Me.LB_StrengthB.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_StrengthB.Location = New System.Drawing.Point(27, 89)
        Me.LB_StrengthB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_StrengthB.Name = "LB_StrengthB"
        Me.LB_StrengthB.Size = New System.Drawing.Size(51, 25)
        Me.LB_StrengthB.TabIndex = 1
        Me.LB_StrengthB.Text = "B:0"
        '
        'LB_StrengthA
        '
        Me.LB_StrengthA.AutoSize = True
        Me.LB_StrengthA.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_StrengthA.Location = New System.Drawing.Point(27, 39)
        Me.LB_StrengthA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_StrengthA.Name = "LB_StrengthA"
        Me.LB_StrengthA.Size = New System.Drawing.Size(51, 25)
        Me.LB_StrengthA.TabIndex = 0
        Me.LB_StrengthA.Text = "A:0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 491)
        Me.Controls.Add(Me.GB_Strength)
        Me.Controls.Add(Me.LB_Running)
        Me.Controls.Add(Me.BT_Stop)
        Me.Controls.Add(Me.LB_QR)
        Me.Controls.Add(Me.PB_QR)
        Me.Controls.Add(Me.GB_Process)
        Me.Controls.Add(Me.BT_Start)
        Me.Controls.Add(Me.GB_Address)
        Me.Controls.Add(Me.GB_Game)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Touhou Dungeon Lab"
        Me.GB_Game.ResumeLayout(False)
        CType(Me.PB_Game, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Address.ResumeLayout(False)
        Me.GB_Address.PerformLayout()
        Me.GB_Process.ResumeLayout(False)
        CType(Me.PB_QR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Strength.ResumeLayout(False)
        Me.GB_Strength.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GB_Game As GroupBox
    Friend WithEvents CB_Game As ComboBox
    Friend WithEvents GB_Address As GroupBox
    Friend WithEvents PB_Game As PictureBox
    Friend WithEvents TB_Port As TextBox
    Friend WithEvents TB_Address As TextBox
    Friend WithEvents BT_Detect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_Start As Button
    Friend WithEvents GB_Process As GroupBox
    Friend WithEvents LB_Process As ListBox
    Friend WithEvents BT_Refresh As Button
    Friend WithEvents LB_QR As Label
    Friend WithEvents PB_QR As PictureBox
    Friend WithEvents BT_Stop As Button
    Friend WithEvents LB_Running As Label
    Friend WithEvents GB_Strength As GroupBox
    Friend WithEvents LB_StrengthB As Label
    Friend WithEvents LB_StrengthA As Label
End Class
