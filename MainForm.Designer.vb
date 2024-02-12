<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GameStartButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.QuestionPicture7 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture6 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture8 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture4 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture9 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture5 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture11 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture10 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture3 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture2 = New System.Windows.Forms.PictureBox()
        Me.QuestionPicture1 = New System.Windows.Forms.PictureBox()
        Me.CountPicture = New System.Windows.Forms.PictureBox()
        Me.TimeOverPicture = New System.Windows.Forms.PictureBox()
        Me.PerfectPicture = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumLabel = New System.Windows.Forms.Label()
        Me.TimeProgressBar = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeLimitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel.SuspendLayout()
        CType(Me.QuestionPicture7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOverPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerfectPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameStartButton
        '
        Me.GameStartButton.Location = New System.Drawing.Point(548, 35)
        Me.GameStartButton.Margin = New System.Windows.Forms.Padding(2)
        Me.GameStartButton.Name = "GameStartButton"
        Me.GameStartButton.Size = New System.Drawing.Size(143, 23)
        Me.GameStartButton.TabIndex = 0
        Me.GameStartButton.Text = "GameStart"
        Me.GameStartButton.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.Controls.Add(Me.QuestionPicture7)
        Me.MainPanel.Controls.Add(Me.QuestionPicture6)
        Me.MainPanel.Controls.Add(Me.QuestionPicture8)
        Me.MainPanel.Controls.Add(Me.QuestionPicture4)
        Me.MainPanel.Controls.Add(Me.QuestionPicture12)
        Me.MainPanel.Controls.Add(Me.PictureBox8)
        Me.MainPanel.Controls.Add(Me.QuestionPicture9)
        Me.MainPanel.Controls.Add(Me.QuestionPicture5)
        Me.MainPanel.Controls.Add(Me.QuestionPicture11)
        Me.MainPanel.Controls.Add(Me.QuestionPicture10)
        Me.MainPanel.Controls.Add(Me.QuestionPicture3)
        Me.MainPanel.Controls.Add(Me.QuestionPicture2)
        Me.MainPanel.Controls.Add(Me.QuestionPicture1)
        Me.MainPanel.Location = New System.Drawing.Point(12, 33)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(530, 402)
        Me.MainPanel.TabIndex = 1
        '
        'QuestionPicture7
        '
        Me.QuestionPicture7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture7.Location = New System.Drawing.Point(268, 134)
        Me.QuestionPicture7.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture7.Name = "QuestionPicture7"
        Me.QuestionPicture7.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture7.TabIndex = 13
        Me.QuestionPicture7.TabStop = False
        '
        'QuestionPicture6
        '
        Me.QuestionPicture6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture6.Location = New System.Drawing.Point(134, 134)
        Me.QuestionPicture6.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture6.Name = "QuestionPicture6"
        Me.QuestionPicture6.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture6.TabIndex = 11
        Me.QuestionPicture6.TabStop = False
        '
        'QuestionPicture8
        '
        Me.QuestionPicture8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture8.Location = New System.Drawing.Point(402, 134)
        Me.QuestionPicture8.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture8.Name = "QuestionPicture8"
        Me.QuestionPicture8.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture8.TabIndex = 12
        Me.QuestionPicture8.TabStop = False
        '
        'QuestionPicture4
        '
        Me.QuestionPicture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture4.Location = New System.Drawing.Point(402, 0)
        Me.QuestionPicture4.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture4.Name = "QuestionPicture4"
        Me.QuestionPicture4.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture4.TabIndex = 10
        Me.QuestionPicture4.TabStop = False
        '
        'QuestionPicture12
        '
        Me.QuestionPicture12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture12.Location = New System.Drawing.Point(402, 268)
        Me.QuestionPicture12.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture12.Name = "QuestionPicture12"
        Me.QuestionPicture12.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture12.TabIndex = 9
        Me.QuestionPicture12.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(980, 320)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(96, 102)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'QuestionPicture9
        '
        Me.QuestionPicture9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture9.Location = New System.Drawing.Point(0, 268)
        Me.QuestionPicture9.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture9.Name = "QuestionPicture9"
        Me.QuestionPicture9.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture9.TabIndex = 6
        Me.QuestionPicture9.TabStop = False
        '
        'QuestionPicture5
        '
        Me.QuestionPicture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture5.Location = New System.Drawing.Point(0, 134)
        Me.QuestionPicture5.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture5.Name = "QuestionPicture5"
        Me.QuestionPicture5.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture5.TabIndex = 5
        Me.QuestionPicture5.TabStop = False
        '
        'QuestionPicture11
        '
        Me.QuestionPicture11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture11.Location = New System.Drawing.Point(268, 268)
        Me.QuestionPicture11.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture11.Name = "QuestionPicture11"
        Me.QuestionPicture11.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture11.TabIndex = 4
        Me.QuestionPicture11.TabStop = False
        '
        'QuestionPicture10
        '
        Me.QuestionPicture10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture10.Location = New System.Drawing.Point(134, 268)
        Me.QuestionPicture10.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture10.Name = "QuestionPicture10"
        Me.QuestionPicture10.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture10.TabIndex = 3
        Me.QuestionPicture10.TabStop = False
        '
        'QuestionPicture3
        '
        Me.QuestionPicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture3.Location = New System.Drawing.Point(268, 0)
        Me.QuestionPicture3.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture3.Name = "QuestionPicture3"
        Me.QuestionPicture3.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture3.TabIndex = 2
        Me.QuestionPicture3.TabStop = False
        '
        'QuestionPicture2
        '
        Me.QuestionPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture2.Location = New System.Drawing.Point(134, 0)
        Me.QuestionPicture2.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture2.Name = "QuestionPicture2"
        Me.QuestionPicture2.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture2.TabIndex = 1
        Me.QuestionPicture2.TabStop = False
        '
        'QuestionPicture1
        '
        Me.QuestionPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestionPicture1.Location = New System.Drawing.Point(0, 0)
        Me.QuestionPicture1.Margin = New System.Windows.Forms.Padding(2)
        Me.QuestionPicture1.Name = "QuestionPicture1"
        Me.QuestionPicture1.Size = New System.Drawing.Size(128, 128)
        Me.QuestionPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPicture1.TabIndex = 0
        Me.QuestionPicture1.TabStop = False
        '
        'CountPicture
        '
        Me.CountPicture.BackColor = System.Drawing.Color.Transparent
        Me.CountPicture.Image = CType(resources.GetObject("CountPicture.Image"), System.Drawing.Image)
        Me.CountPicture.Location = New System.Drawing.Point(548, 341)
        Me.CountPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.CountPicture.Name = "CountPicture"
        Me.CountPicture.Size = New System.Drawing.Size(88, 88)
        Me.CountPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CountPicture.TabIndex = 2
        Me.CountPicture.TabStop = False
        '
        'TimeOverPicture
        '
        Me.TimeOverPicture.BackColor = System.Drawing.Color.Transparent
        Me.TimeOverPicture.Image = CType(resources.GetObject("TimeOverPicture.Image"), System.Drawing.Image)
        Me.TimeOverPicture.Location = New System.Drawing.Point(185, 203)
        Me.TimeOverPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.TimeOverPicture.Name = "TimeOverPicture"
        Me.TimeOverPicture.Size = New System.Drawing.Size(330, 60)
        Me.TimeOverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.TimeOverPicture.TabIndex = 3
        Me.TimeOverPicture.TabStop = False
        '
        'PerfectPicture
        '
        Me.PerfectPicture.BackColor = System.Drawing.Color.Transparent
        Me.PerfectPicture.Image = CType(resources.GetObject("PerfectPicture.Image"), System.Drawing.Image)
        Me.PerfectPicture.Location = New System.Drawing.Point(215, 203)
        Me.PerfectPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.PerfectPicture.Name = "PerfectPicture"
        Me.PerfectPicture.Size = New System.Drawing.Size(270, 60)
        Me.PerfectPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PerfectPicture.TabIndex = 4
        Me.PerfectPicture.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(558, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 49)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "中身が同じハンバーガーをみつけよう"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(558, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "得点:"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScoreLabel.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(622, 147)
        Me.ScoreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(69, 19)
        Me.ScoreLabel.TabIndex = 7
        Me.ScoreLabel.Text = "0"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(638, 400)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "×"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumLabel
        '
        Me.NumLabel.AutoSize = True
        Me.NumLabel.BackColor = System.Drawing.Color.Transparent
        Me.NumLabel.Font = New System.Drawing.Font("ＭＳ ゴシック", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NumLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumLabel.Location = New System.Drawing.Point(669, 400)
        Me.NumLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumLabel.Name = "NumLabel"
        Me.NumLabel.Size = New System.Drawing.Size(27, 27)
        Me.NumLabel.TabIndex = 9
        Me.NumLabel.Text = "0"
        Me.NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeProgressBar
        '
        Me.TimeProgressBar.Location = New System.Drawing.Point(12, 441)
        Me.TimeProgressBar.Margin = New System.Windows.Forms.Padding(2)
        Me.TimeProgressBar.Maximum = 60
        Me.TimeProgressBar.Name = "TimeProgressBar"
        Me.TimeProgressBar.Size = New System.Drawing.Size(530, 23)
        Me.TimeProgressBar.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameMenu, Me.ScoreMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameMenu
        '
        Me.GameMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartMenuItem, Me.QuitMenuItem})
        Me.GameMenu.Name = "GameMenu"
        Me.GameMenu.Size = New System.Drawing.Size(62, 20)
        Me.GameMenu.Text = "ゲーム(&G)"
        '
        'StartMenuItem
        '
        Me.StartMenuItem.Name = "StartMenuItem"
        Me.StartMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StartMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.StartMenuItem.Text = "ゲーム開始(&S)"
        '
        'QuitMenuItem
        '
        Me.QuitMenuItem.Name = "QuitMenuItem"
        Me.QuitMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.QuitMenuItem.Text = "HamburgerPartyの終了(&Q)"
        '
        'ScoreMenu
        '
        Me.ScoreMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScoreMenuItem, Me.ResetMenuItem})
        Me.ScoreMenu.Name = "ScoreMenu"
        Me.ScoreMenu.Size = New System.Drawing.Size(57, 20)
        Me.ScoreMenu.Text = "成績(&S)"
        '
        'ScoreMenuItem
        '
        Me.ScoreMenuItem.Name = "ScoreMenuItem"
        Me.ScoreMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ScoreMenuItem.Text = "成績...(&T)"
        '
        'ResetMenuItem
        '
        Me.ResetMenuItem.Name = "ResetMenuItem"
        Me.ResetMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ResetMenuItem.Text = "成績表のリセット(&R)"
        '
        'TimeLimitTimer
        '
        Me.TimeLimitTimer.Interval = 500
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(700, 467)
        Me.Controls.Add(Me.TimeProgressBar)
        Me.Controls.Add(Me.NumLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PerfectPicture)
        Me.Controls.Add(Me.TimeOverPicture)
        Me.Controls.Add(Me.CountPicture)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.GameStartButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HamburgerParty!"
        Me.MainPanel.ResumeLayout(False)
        CType(Me.QuestionPicture7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOverPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerfectPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameStartButton As System.Windows.Forms.Button
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents QuestionPicture8 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture6 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture4 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture9 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture5 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture11 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture10 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture3 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture2 As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionPicture1 As System.Windows.Forms.PictureBox
    Friend WithEvents CountPicture As System.Windows.Forms.PictureBox
    Friend WithEvents TimeOverPicture As System.Windows.Forms.PictureBox
    Friend WithEvents PerfectPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumLabel As System.Windows.Forms.Label
    Friend WithEvents TimeProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScoreMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScoreMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeLimitTimer As System.Windows.Forms.Timer
    Friend WithEvents QuestionPicture7 As System.Windows.Forms.PictureBox

End Class
