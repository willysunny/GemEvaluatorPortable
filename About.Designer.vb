<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ContactLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.forum = New System.Windows.Forms.PictureBox()
        Me.skype = New System.Windows.Forms.PictureBox()
        Me.youtube = New System.Windows.Forms.PictureBox()
        Me.twitter = New System.Windows.Forms.PictureBox()
        Me.facebook = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.forum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.youtube, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.twitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.facebook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        resources.ApplyResources(Me.TableLayoutPanel, "TableLayoutPanel")
        Me.TableLayoutPanel.Controls.Add(Me.ContactLabel, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.TableLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 1, 4)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        '
        'ContactLabel
        '
        resources.ApplyResources(Me.ContactLabel, "ContactLabel")
        Me.ContactLabel.Name = "ContactLabel"
        '
        'LogoPictureBox
        '
        resources.ApplyResources(Me.LogoPictureBox, "LogoPictureBox")
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
        Me.LogoPictureBox.TabStop = False
        '
        'LabelProductName
        '
        resources.ApplyResources(Me.LabelProductName, "LabelProductName")
        Me.LabelProductName.Name = "LabelProductName"
        '
        'LabelVersion
        '
        resources.ApplyResources(Me.LabelVersion, "LabelVersion")
        Me.LabelVersion.Name = "LabelVersion"
        '
        'LabelCopyright
        '
        resources.ApplyResources(Me.LabelCopyright, "LabelCopyright")
        Me.LabelCopyright.Name = "LabelCopyright"
        '
        'OKButton
        '
        resources.ApplyResources(Me.OKButton, "OKButton")
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Name = "OKButton"
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.forum, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.skype, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.youtube, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.twitter, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.facebook, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'forum
        '
        resources.ApplyResources(Me.forum, "forum")
        Me.forum.Name = "forum"
        Me.forum.TabStop = False
        '
        'skype
        '
        resources.ApplyResources(Me.skype, "skype")
        Me.skype.Image = Global.GemEvaulatorPortable.My.Resources.Resources.skype1
        Me.skype.Name = "skype"
        Me.skype.TabStop = False
        '
        'youtube
        '
        resources.ApplyResources(Me.youtube, "youtube")
        Me.youtube.Image = Global.GemEvaulatorPortable.My.Resources.Resources.YT
        Me.youtube.Name = "youtube"
        Me.youtube.TabStop = False
        '
        'twitter
        '
        resources.ApplyResources(Me.twitter, "twitter")
        Me.twitter.Image = Global.GemEvaulatorPortable.My.Resources.Resources.twitter
        Me.twitter.Name = "twitter"
        Me.twitter.TabStop = False
        '
        'facebook
        '
        resources.ApplyResources(Me.facebook, "facebook")
        Me.facebook.Image = Global.GemEvaulatorPortable.My.Resources.Resources.fb
        Me.facebook.Name = "facebook"
        Me.facebook.TabStop = False
        '
        'About
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.TableLayoutPanel.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.forum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.youtube, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.twitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.facebook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents skype As System.Windows.Forms.PictureBox
    Friend WithEvents youtube As System.Windows.Forms.PictureBox
    Friend WithEvents twitter As System.Windows.Forms.PictureBox
    Friend WithEvents facebook As System.Windows.Forms.PictureBox
    Friend WithEvents ContactLabel As System.Windows.Forms.Label
    Friend WithEvents forum As System.Windows.Forms.PictureBox

End Class
