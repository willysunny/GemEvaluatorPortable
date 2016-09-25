Imports System.Threading
Imports System.Globalization

Public NotInheritable Class About

    Public resMan As Resources.ResourceManager = GemForm.resMan

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 設定表單的標題。
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = resMan.GetObject("About")
        ' 初始化 [關於] 對話方塊中顯示的所有文字。
        ' TODO: 在專案屬性對話方塊 (位於 [專案] 功能表下) 的 [應用程式] 窗格中，
        '    自訂應用程式的組件資訊。
        Me.LabelProductName.Text = resMan.GetObject("formName")
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LogoPictureBox.Image = My.Resources.About
        Me.ContactLabel.Text = resMan.GetString("Contact")
        Me.forum.Image = CType(resMan.GetObject("forumIcon"), Bitmap)
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub facebook_Click(sender As Object, e As EventArgs) Handles facebook.Click
        Process.Start("https://www.facebook.com/lin.sunny.willy")
    End Sub

    Private Sub twitter_Click(sender As Object, e As EventArgs) Handles twitter.Click
        Process.Start("http://www.twitter.com/willy_sunny")
    End Sub

    Private Sub youtube_Click(sender As Object, e As EventArgs) Handles youtube.Click
        Process.Start("https://www.youtube.com/channel/UCh7rgFKd3nDZ0r0RZKBpozQ")
    End Sub


    Private Sub skype_Click(sender As Object, e As EventArgs) Handles skype.Click
        Process.Start("skype:willy_sunny?call")
    End Sub

    Private Sub forum_Click(sender As Object, e As EventArgs) Handles forum.Click
        Process.Start(resMan.GetString("forumLink"))
    End Sub
End Class
