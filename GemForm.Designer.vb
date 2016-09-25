<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GemForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GemForm))
        Me.GemMenu = New System.Windows.Forms.MenuStrip()
        Me.menuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTraditionalChinese = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAlwaysOnTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GemStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.BugLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.reportLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GemTab = New System.Windows.Forms.TabControl()
        Me.evalTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.input2 = New System.Windows.Forms.TextBox()
        Me.stat1 = New System.Windows.Forms.ComboBox()
        Me.stat2 = New System.Windows.Forms.ComboBox()
        Me.stat3 = New System.Windows.Forms.ComboBox()
        Me.input3 = New System.Windows.Forms.TextBox()
        Me.inputInfo2 = New System.Windows.Forms.Label()
        Me.inputInfo3 = New System.Windows.Forms.Label()
        Me.inputInfo1 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.individual = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.score1 = New System.Windows.Forms.Label()
        Me.finalScore = New System.Windows.Forms.Label()
        Me.score2 = New System.Windows.Forms.Label()
        Me.score3 = New System.Windows.Forms.Label()
        Me.suggestion = New System.Windows.Forms.Label()
        Me.restartButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.radiant = New System.Windows.Forms.RadioButton()
        Me.stellar = New System.Windows.Forms.RadioButton()
        Me.evalBanner = New System.Windows.Forms.PictureBox()
        Me.initTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.initBanner = New System.Windows.Forms.PictureBox()
        Me.initCount = New System.Windows.Forms.Label()
        Me.gemType = New System.Windows.Forms.Label()
        Me.initInfo2 = New System.Windows.Forms.Label()
        Me.initInfo3 = New System.Windows.Forms.Label()
        Me.initInfo1 = New System.Windows.Forms.Label()
        Me.curLevel = New System.Windows.Forms.TextBox()
        Me.curPR = New System.Windows.Forms.TextBox()
        Me.getInfo3 = New System.Windows.Forms.Label()
        Me.getInfo2 = New System.Windows.Forms.Label()
        Me.getInfo1 = New System.Windows.Forms.Label()
        Me.GemMenu.SuspendLayout()
        Me.GemStatusStrip.SuspendLayout()
        Me.GemTab.SuspendLayout()
        Me.evalTab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.evalBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.initTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.initBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GemMenu
        '
        Me.GemMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSettings, Me.menuAbout})
        Me.GemMenu.Location = New System.Drawing.Point(0, 0)
        Me.GemMenu.Name = "GemMenu"
        Me.GemMenu.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.GemMenu.Size = New System.Drawing.Size(674, 26)
        Me.GemMenu.TabIndex = 1
        Me.GemMenu.Text = "MenuStrip1"
        '
        'menuSettings
        '
        Me.menuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLanguage, Me.menuAlwaysOnTop, Me.ToolStripMenuItem1, Me.menuExit})
        Me.menuSettings.Name = "menuSettings"
        Me.menuSettings.Padding = New System.Windows.Forms.Padding(0)
        Me.menuSettings.Size = New System.Drawing.Size(75, 20)
        Me.menuSettings.Text = "Settings (&S)"
        '
        'menuLanguage
        '
        Me.menuLanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEnglish, Me.menuTraditionalChinese})
        Me.menuLanguage.Name = "menuLanguage"
        Me.menuLanguage.Size = New System.Drawing.Size(173, 22)
        Me.menuLanguage.Text = "Language (&L)"
        '
        'menuEnglish
        '
        Me.menuEnglish.Name = "menuEnglish"
        Me.menuEnglish.Size = New System.Drawing.Size(142, 22)
        Me.menuEnglish.Text = "English (&E)"
        '
        'menuTraditionalChinese
        '
        Me.menuTraditionalChinese.Name = "menuTraditionalChinese"
        Me.menuTraditionalChinese.Size = New System.Drawing.Size(142, 22)
        Me.menuTraditionalChinese.Text = "繁體中文 (&T)"
        '
        'menuAlwaysOnTop
        '
        Me.menuAlwaysOnTop.CheckOnClick = True
        Me.menuAlwaysOnTop.Name = "menuAlwaysOnTop"
        Me.menuAlwaysOnTop.Size = New System.Drawing.Size(173, 22)
        Me.menuAlwaysOnTop.Text = "Always on top (&T)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 6)
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(173, 22)
        Me.menuExit.Text = "Exit (&X)"
        '
        'menuAbout
        '
        Me.menuAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(74, 20)
        Me.menuAbout.Text = "About (&A)"
        '
        'GemStatusStrip
        '
        Me.GemStatusStrip.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GemStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BugLabel, Me.reportLabel})
        Me.GemStatusStrip.Location = New System.Drawing.Point(0, 399)
        Me.GemStatusStrip.Name = "GemStatusStrip"
        Me.GemStatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.GemStatusStrip.Size = New System.Drawing.Size(674, 23)
        Me.GemStatusStrip.TabIndex = 2
        Me.GemStatusStrip.Text = "StatusStrip1"
        '
        'BugLabel
        '
        Me.BugLabel.Name = "BugLabel"
        Me.BugLabel.Size = New System.Drawing.Size(553, 18)
        Me.BugLabel.Spring = True
        Me.BugLabel.Text = "Got Bugs?"
        Me.BugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'reportLabel
        '
        Me.reportLabel.IsLink = True
        Me.reportLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.reportLabel.Name = "reportLabel"
        Me.reportLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.reportLabel.Size = New System.Drawing.Size(98, 18)
        Me.reportLabel.Text = "Report Here!"
        '
        'GemTab
        '
        Me.GemTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.GemTab.Controls.Add(Me.evalTab)
        Me.GemTab.Controls.Add(Me.initTab)
        Me.GemTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GemTab.Location = New System.Drawing.Point(0, 26)
        Me.GemTab.Margin = New System.Windows.Forms.Padding(0)
        Me.GemTab.Name = "GemTab"
        Me.GemTab.SelectedIndex = 0
        Me.GemTab.Size = New System.Drawing.Size(674, 373)
        Me.GemTab.TabIndex = 3
        '
        'evalTab
        '
        Me.evalTab.Controls.Add(Me.TableLayoutPanel1)
        Me.evalTab.Location = New System.Drawing.Point(4, 30)
        Me.evalTab.Name = "evalTab"
        Me.evalTab.Padding = New System.Windows.Forms.Padding(3)
        Me.evalTab.Size = New System.Drawing.Size(666, 339)
        Me.evalTab.TabIndex = 0
        Me.evalTab.Text = "Small Gem Evaluator"
        Me.evalTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.input1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.input2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.stat1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.stat2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.stat3, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.input3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.inputInfo2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.inputInfo3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.inputInfo1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.result, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.score, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.individual, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.total, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.score1, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.finalScore, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.score2, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.score3, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.suggestion, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.restartButton, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.calculateButton, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.radiant, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.stellar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.evalBanner, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(660, 333)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'input1
        '
        Me.input1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.input1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.input1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.input1.Location = New System.Drawing.Point(0, 78)
        Me.input1.Margin = New System.Windows.Forms.Padding(0)
        Me.input1.MaxLength = 10
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(165, 26)
        Me.input1.TabIndex = 3
        Me.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'input2
        '
        Me.input2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.input2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.input2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.input2.Location = New System.Drawing.Point(0, 104)
        Me.input2.Margin = New System.Windows.Forms.Padding(0)
        Me.input2.MaxLength = 10
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(165, 26)
        Me.input2.TabIndex = 5
        Me.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.input2.Visible = False
        '
        'stat1
        '
        Me.stat1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.stat1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stat1.FormattingEnabled = True
        Me.stat1.Items.AddRange(New Object() {"Physical Damage", "Magic Damage", "% Max Health", "Max Health", "Health Regeneration", "Critical Hit", "Critical Damage"})
        Me.stat1.Location = New System.Drawing.Point(165, 78)
        Me.stat1.Margin = New System.Windows.Forms.Padding(0)
        Me.stat1.Name = "stat1"
        Me.stat1.Size = New System.Drawing.Size(165, 26)
        Me.stat1.TabIndex = 4
        '
        'stat2
        '
        Me.stat2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.stat2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stat2.FormattingEnabled = True
        Me.stat2.Items.AddRange(New Object() {"Physical Damage", "Magic Damage", "% Max Health", "Max Health", "Health Regeneration", "Critical Hit", "Critical Damage"})
        Me.stat2.Location = New System.Drawing.Point(165, 104)
        Me.stat2.Margin = New System.Windows.Forms.Padding(0)
        Me.stat2.Name = "stat2"
        Me.stat2.Size = New System.Drawing.Size(165, 26)
        Me.stat2.TabIndex = 6
        Me.stat2.Visible = False
        '
        'stat3
        '
        Me.stat3.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.stat3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stat3.FormattingEnabled = True
        Me.stat3.Items.AddRange(New Object() {"Physical Damage", "Magic Damage", "% Max Health", "Max Health", "Health Regeneration", "Critical Hit", "Critical Damage"})
        Me.stat3.Location = New System.Drawing.Point(165, 130)
        Me.stat3.Margin = New System.Windows.Forms.Padding(0)
        Me.stat3.Name = "stat3"
        Me.stat3.Size = New System.Drawing.Size(165, 26)
        Me.stat3.TabIndex = 8
        Me.stat3.Visible = False
        '
        'input3
        '
        Me.input3.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.input3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.input3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.input3.Location = New System.Drawing.Point(0, 130)
        Me.input3.Margin = New System.Windows.Forms.Padding(0)
        Me.input3.MaxLength = 10
        Me.input3.Name = "input3"
        Me.input3.Size = New System.Drawing.Size(165, 26)
        Me.input3.TabIndex = 7
        Me.input3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.input3.Visible = False
        '
        'inputInfo2
        '
        Me.inputInfo2.AutoSize = True
        Me.inputInfo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputInfo2.ForeColor = System.Drawing.Color.White
        Me.inputInfo2.Location = New System.Drawing.Point(0, 52)
        Me.inputInfo2.Margin = New System.Windows.Forms.Padding(0)
        Me.inputInfo2.Name = "inputInfo2"
        Me.inputInfo2.Size = New System.Drawing.Size(165, 26)
        Me.inputInfo2.TabIndex = 0
        Me.inputInfo2.Text = "Stat Value"
        Me.inputInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inputInfo3
        '
        Me.inputInfo3.AutoSize = True
        Me.inputInfo3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputInfo3.ForeColor = System.Drawing.Color.White
        Me.inputInfo3.Location = New System.Drawing.Point(165, 52)
        Me.inputInfo3.Margin = New System.Windows.Forms.Padding(0)
        Me.inputInfo3.Name = "inputInfo3"
        Me.inputInfo3.Size = New System.Drawing.Size(165, 26)
        Me.inputInfo3.TabIndex = 0
        Me.inputInfo3.Text = "Stat Name"
        Me.inputInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inputInfo1
        '
        Me.inputInfo1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.inputInfo1, 2)
        Me.inputInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputInfo1.ForeColor = System.Drawing.Color.White
        Me.inputInfo1.Location = New System.Drawing.Point(0, 26)
        Me.inputInfo1.Margin = New System.Windows.Forms.Padding(0)
        Me.inputInfo1.Name = "inputInfo1"
        Me.inputInfo1.Size = New System.Drawing.Size(330, 26)
        Me.inputInfo1.TabIndex = 0
        Me.inputInfo1.Text = "Please enter level 1 gem's stats"
        Me.inputInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.result, 2)
        Me.result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.result.ForeColor = System.Drawing.Color.White
        Me.result.Location = New System.Drawing.Point(330, 0)
        Me.result.Margin = New System.Windows.Forms.Padding(0)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(330, 26)
        Me.result.TabIndex = 0
        Me.result.Text = "Result"
        Me.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.result.Visible = False
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.score, 2)
        Me.score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.score.ForeColor = System.Drawing.Color.White
        Me.score.Location = New System.Drawing.Point(330, 26)
        Me.score.Margin = New System.Windows.Forms.Padding(0)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(330, 26)
        Me.score.TabIndex = 0
        Me.score.Text = "Score"
        Me.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.score.Visible = False
        '
        'individual
        '
        Me.individual.AutoSize = True
        Me.individual.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.individual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.individual.ForeColor = System.Drawing.Color.White
        Me.individual.Location = New System.Drawing.Point(330, 52)
        Me.individual.Margin = New System.Windows.Forms.Padding(0)
        Me.individual.Name = "individual"
        Me.individual.Size = New System.Drawing.Size(165, 26)
        Me.individual.TabIndex = 0
        Me.individual.Text = "Individual Stat"
        Me.individual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.individual.Visible = False
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.total.ForeColor = System.Drawing.Color.White
        Me.total.Location = New System.Drawing.Point(495, 52)
        Me.total.Margin = New System.Windows.Forms.Padding(0)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(165, 26)
        Me.total.TabIndex = 0
        Me.total.Text = "Total"
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.total.Visible = False
        '
        'score1
        '
        Me.score1.AutoSize = True
        Me.score1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.score1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.score1.ForeColor = System.Drawing.Color.Black
        Me.score1.Location = New System.Drawing.Point(330, 78)
        Me.score1.Margin = New System.Windows.Forms.Padding(0)
        Me.score1.Name = "score1"
        Me.score1.Size = New System.Drawing.Size(165, 26)
        Me.score1.TabIndex = 0
        Me.score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.score1.Visible = False
        '
        'finalScore
        '
        Me.finalScore.AutoSize = True
        Me.finalScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.finalScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.finalScore.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalScore.ForeColor = System.Drawing.Color.White
        Me.finalScore.Location = New System.Drawing.Point(495, 78)
        Me.finalScore.Margin = New System.Windows.Forms.Padding(0)
        Me.finalScore.Name = "finalScore"
        Me.TableLayoutPanel1.SetRowSpan(Me.finalScore, 3)
        Me.finalScore.Size = New System.Drawing.Size(165, 78)
        Me.finalScore.TabIndex = 0
        Me.finalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.finalScore.Visible = False
        '
        'score2
        '
        Me.score2.AutoSize = True
        Me.score2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.score2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.score2.ForeColor = System.Drawing.Color.Black
        Me.score2.Location = New System.Drawing.Point(330, 104)
        Me.score2.Margin = New System.Windows.Forms.Padding(0)
        Me.score2.Name = "score2"
        Me.score2.Size = New System.Drawing.Size(165, 26)
        Me.score2.TabIndex = 0
        Me.score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.score2.Visible = False
        '
        'score3
        '
        Me.score3.AutoSize = True
        Me.score3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.score3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.score3.ForeColor = System.Drawing.Color.Black
        Me.score3.Location = New System.Drawing.Point(330, 130)
        Me.score3.Margin = New System.Windows.Forms.Padding(0)
        Me.score3.Name = "score3"
        Me.score3.Size = New System.Drawing.Size(165, 26)
        Me.score3.TabIndex = 0
        Me.score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.score3.Visible = False
        '
        'suggestion
        '
        Me.suggestion.AutoSize = True
        Me.suggestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.suggestion, 2)
        Me.suggestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.suggestion.ForeColor = System.Drawing.Color.White
        Me.suggestion.Location = New System.Drawing.Point(330, 156)
        Me.suggestion.Margin = New System.Windows.Forms.Padding(0)
        Me.suggestion.Name = "suggestion"
        Me.suggestion.Padding = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.suggestion.Size = New System.Drawing.Size(330, 52)
        Me.suggestion.TabIndex = 0
        Me.suggestion.Visible = False
        '
        'restartButton
        '
        Me.restartButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.restartButton.FlatAppearance.BorderSize = 2
        Me.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.restartButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restartButton.ForeColor = System.Drawing.Color.Transparent
        Me.restartButton.Location = New System.Drawing.Point(3, 159)
        Me.restartButton.Name = "restartButton"
        Me.restartButton.Size = New System.Drawing.Size(159, 46)
        Me.restartButton.TabIndex = 10
        Me.restartButton.Text = "Restart"
        Me.restartButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.calculateButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.calculateButton.FlatAppearance.BorderSize = 2
        Me.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculateButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.ForeColor = System.Drawing.Color.White
        Me.calculateButton.Location = New System.Drawing.Point(168, 159)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(159, 46)
        Me.calculateButton.TabIndex = 9
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = False
        '
        'radiant
        '
        Me.radiant.AutoSize = True
        Me.radiant.Checked = True
        Me.radiant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radiant.ForeColor = System.Drawing.Color.White
        Me.radiant.Location = New System.Drawing.Point(3, 3)
        Me.radiant.Name = "radiant"
        Me.radiant.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.radiant.Size = New System.Drawing.Size(159, 20)
        Me.radiant.TabIndex = 1
        Me.radiant.TabStop = True
        Me.radiant.Text = "Radiant"
        Me.radiant.UseVisualStyleBackColor = True
        '
        'stellar
        '
        Me.stellar.AutoSize = True
        Me.stellar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stellar.ForeColor = System.Drawing.Color.White
        Me.stellar.Location = New System.Drawing.Point(168, 3)
        Me.stellar.Name = "stellar"
        Me.stellar.Size = New System.Drawing.Size(159, 20)
        Me.stellar.TabIndex = 2
        Me.stellar.Text = "Stellar"
        Me.stellar.UseVisualStyleBackColor = True
        '
        'evalBanner
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.evalBanner, 4)
        Me.evalBanner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.evalBanner.Image = Global.GemEvaulatorPortable.My.Resources.Locale.TroveSig
        Me.evalBanner.Location = New System.Drawing.Point(0, 208)
        Me.evalBanner.Margin = New System.Windows.Forms.Padding(0)
        Me.evalBanner.Name = "evalBanner"
        Me.evalBanner.Size = New System.Drawing.Size(660, 125)
        Me.evalBanner.TabIndex = 5
        Me.evalBanner.TabStop = False
        '
        'initTab
        '
        Me.initTab.Controls.Add(Me.TableLayoutPanel2)
        Me.initTab.Location = New System.Drawing.Point(4, 30)
        Me.initTab.Margin = New System.Windows.Forms.Padding(0)
        Me.initTab.Name = "initTab"
        Me.initTab.Padding = New System.Windows.Forms.Padding(3)
        Me.initTab.Size = New System.Drawing.Size(666, 339)
        Me.initTab.TabIndex = 1
        Me.initTab.Text = "Empowered Gem Initial Stat"
        Me.initTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.initBanner, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.initCount, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.gemType, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.initInfo2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.initInfo3, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.initInfo1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.curLevel, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.curPR, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.getInfo3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.getInfo2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.getInfo1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(660, 333)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label11, 2)
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(330, 104)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(330, 104)
        Me.Label11.TabIndex = 13
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label10, 2)
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 104)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(330, 104)
        Me.Label10.TabIndex = 12
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'initBanner
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.initBanner, 4)
        Me.initBanner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.initBanner.Image = CType(resources.GetObject("initBanner.Image"), System.Drawing.Image)
        Me.initBanner.Location = New System.Drawing.Point(0, 208)
        Me.initBanner.Margin = New System.Windows.Forms.Padding(0)
        Me.initBanner.Name = "initBanner"
        Me.initBanner.Size = New System.Drawing.Size(660, 125)
        Me.initBanner.TabIndex = 11
        Me.initBanner.TabStop = False
        '
        'initCount
        '
        Me.initCount.AutoSize = True
        Me.initCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.initCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.initCount.ForeColor = System.Drawing.Color.Black
        Me.initCount.Location = New System.Drawing.Point(495, 78)
        Me.initCount.Margin = New System.Windows.Forms.Padding(0)
        Me.initCount.Name = "initCount"
        Me.initCount.Size = New System.Drawing.Size(165, 26)
        Me.initCount.TabIndex = 10
        Me.initCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gemType
        '
        Me.gemType.AutoSize = True
        Me.gemType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gemType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gemType.ForeColor = System.Drawing.Color.Black
        Me.gemType.Location = New System.Drawing.Point(330, 78)
        Me.gemType.Margin = New System.Windows.Forms.Padding(0)
        Me.gemType.Name = "gemType"
        Me.gemType.Size = New System.Drawing.Size(165, 26)
        Me.gemType.TabIndex = 9
        Me.gemType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'initInfo2
        '
        Me.initInfo2.AutoSize = True
        Me.initInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.initInfo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.initInfo2.ForeColor = System.Drawing.Color.White
        Me.initInfo2.Location = New System.Drawing.Point(330, 52)
        Me.initInfo2.Margin = New System.Windows.Forms.Padding(0)
        Me.initInfo2.Name = "initInfo2"
        Me.initInfo2.Size = New System.Drawing.Size(165, 26)
        Me.initInfo2.TabIndex = 8
        Me.initInfo2.Text = "Gem Type"
        Me.initInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'initInfo3
        '
        Me.initInfo3.AutoSize = True
        Me.initInfo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.initInfo3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.initInfo3.ForeColor = System.Drawing.Color.White
        Me.initInfo3.Location = New System.Drawing.Point(495, 52)
        Me.initInfo3.Margin = New System.Windows.Forms.Padding(0)
        Me.initInfo3.Name = "initInfo3"
        Me.initInfo3.Size = New System.Drawing.Size(165, 26)
        Me.initInfo3.TabIndex = 7
        Me.initInfo3.Text = "Initial Stat Count"
        Me.initInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'initInfo1
        '
        Me.initInfo1.AutoSize = True
        Me.initInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel2.SetColumnSpan(Me.initInfo1, 2)
        Me.initInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.initInfo1.ForeColor = System.Drawing.Color.White
        Me.initInfo1.Location = New System.Drawing.Point(330, 0)
        Me.initInfo1.Margin = New System.Windows.Forms.Padding(0)
        Me.initInfo1.Name = "initInfo1"
        Me.initInfo1.Size = New System.Drawing.Size(330, 52)
        Me.initInfo1.TabIndex = 6
        Me.initInfo1.Text = "Gem's Initial Info"
        Me.initInfo1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'curLevel
        '
        Me.curLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.curLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.curLevel.Location = New System.Drawing.Point(165, 78)
        Me.curLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.curLevel.Name = "curLevel"
        Me.curLevel.Size = New System.Drawing.Size(165, 26)
        Me.curLevel.TabIndex = 5
        Me.curLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'curPR
        '
        Me.curPR.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.curPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.curPR.Location = New System.Drawing.Point(0, 78)
        Me.curPR.Margin = New System.Windows.Forms.Padding(0)
        Me.curPR.Name = "curPR"
        Me.curPR.Size = New System.Drawing.Size(165, 26)
        Me.curPR.TabIndex = 4
        Me.curPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'getInfo3
        '
        Me.getInfo3.AutoSize = True
        Me.getInfo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.getInfo3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.getInfo3.ForeColor = System.Drawing.Color.White
        Me.getInfo3.Location = New System.Drawing.Point(165, 52)
        Me.getInfo3.Margin = New System.Windows.Forms.Padding(0)
        Me.getInfo3.Name = "getInfo3"
        Me.getInfo3.Size = New System.Drawing.Size(165, 26)
        Me.getInfo3.TabIndex = 3
        Me.getInfo3.Text = "Level"
        Me.getInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'getInfo2
        '
        Me.getInfo2.AutoSize = True
        Me.getInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.getInfo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.getInfo2.ForeColor = System.Drawing.Color.White
        Me.getInfo2.Location = New System.Drawing.Point(0, 52)
        Me.getInfo2.Margin = New System.Windows.Forms.Padding(0)
        Me.getInfo2.Name = "getInfo2"
        Me.getInfo2.Size = New System.Drawing.Size(165, 26)
        Me.getInfo2.TabIndex = 1
        Me.getInfo2.Text = "Power Rank"
        Me.getInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'getInfo1
        '
        Me.getInfo1.AutoSize = True
        Me.getInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.TableLayoutPanel2.SetColumnSpan(Me.getInfo1, 2)
        Me.getInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.getInfo1.ForeColor = System.Drawing.Color.White
        Me.getInfo1.Location = New System.Drawing.Point(0, 0)
        Me.getInfo1.Margin = New System.Windows.Forms.Padding(0)
        Me.getInfo1.Name = "getInfo1"
        Me.getInfo1.Size = New System.Drawing.Size(330, 52)
        Me.getInfo1.TabIndex = 2
        Me.getInfo1.Text = "Current Gem Info"
        Me.getInfo1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 422)
        Me.Controls.Add(Me.GemTab)
        Me.Controls.Add(Me.GemStatusStrip)
        Me.Controls.Add(Me.GemMenu)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.GemMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GemForm"
        Me.Text = " Trove Gem Evaulator Portable"
        Me.GemMenu.ResumeLayout(False)
        Me.GemMenu.PerformLayout()
        Me.GemStatusStrip.ResumeLayout(False)
        Me.GemStatusStrip.PerformLayout()
        Me.GemTab.ResumeLayout(False)
        Me.evalTab.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.evalBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.initTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.initBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GemMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents menuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLanguage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnglish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTraditionalChinese As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAlwaysOnTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GemStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents GemTab As System.Windows.Forms.TabControl
    Friend WithEvents evalTab As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents input1 As System.Windows.Forms.TextBox
    Friend WithEvents input2 As System.Windows.Forms.TextBox
    Friend WithEvents stat1 As System.Windows.Forms.ComboBox
    Friend WithEvents stat2 As System.Windows.Forms.ComboBox
    Friend WithEvents stat3 As System.Windows.Forms.ComboBox
    Friend WithEvents inputInfo2 As System.Windows.Forms.Label
    Friend WithEvents inputInfo3 As System.Windows.Forms.Label
    Friend WithEvents inputInfo1 As System.Windows.Forms.Label
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents score As System.Windows.Forms.Label
    Friend WithEvents individual As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents score1 As System.Windows.Forms.Label
    Friend WithEvents finalScore As System.Windows.Forms.Label
    Friend WithEvents score2 As System.Windows.Forms.Label
    Friend WithEvents score3 As System.Windows.Forms.Label
    Friend WithEvents suggestion As System.Windows.Forms.Label
    Friend WithEvents restartButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents radiant As System.Windows.Forms.RadioButton
    Friend WithEvents stellar As System.Windows.Forms.RadioButton
    Friend WithEvents initTab As System.Windows.Forms.TabPage
    Friend WithEvents evalBanner As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents initCount As System.Windows.Forms.Label
    Friend WithEvents gemType As System.Windows.Forms.Label
    Friend WithEvents initInfo2 As System.Windows.Forms.Label
    Friend WithEvents initInfo3 As System.Windows.Forms.Label
    Friend WithEvents initInfo1 As System.Windows.Forms.Label
    Friend WithEvents curLevel As System.Windows.Forms.TextBox
    Friend WithEvents curPR As System.Windows.Forms.TextBox
    Friend WithEvents getInfo3 As System.Windows.Forms.Label
    Friend WithEvents getInfo2 As System.Windows.Forms.Label
    Friend WithEvents getInfo1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents initBanner As System.Windows.Forms.PictureBox
    Private WithEvents input3 As System.Windows.Forms.TextBox
    Friend WithEvents BugLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents reportLabel As System.Windows.Forms.ToolStripStatusLabel

End Class
