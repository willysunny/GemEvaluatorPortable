Imports System.Threading
Imports System.Globalization

Public Class GemForm

    Const RPD As Double = 1587
    Const RMD As Double = 1587
    Const RPMH As Double = 57%
    Const RMH As Double = 5667
    Const RHR As Double = 3967
    Const RCH As Double = 0.023
    Const RCD As Double = 0.227
    Const SPD As Double = 2800
    Const SMD As Double = 2800
    Const SPMH As Double = 1
    Const SMH As Double = 10000
    Const SHR As Double = 7000
    Const SCH As Double = 0.04
    Const SCD As Double = 0.4
    Public resMan As New Resources.ResourceManager("GemEvaulatorPortable.Locale", System.Reflection.Assembly.GetExecutingAssembly())

    Public Sub New()

        ' 此為設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
        updateUIControls()
    End Sub

    Private Sub updateUIControls()
        Try
            If Not IsNothing(resMan) Then
                Me.Text = resMan.GetString("formName")
                If resMan.GetObject("bold") Then
                    Me.Font = New Font(resMan.GetString("fontFace"), 12, FontStyle.Bold)
                Else
                    Me.Font = New Font(resMan.GetString("fontFace"), 12)
                End If
                Me.Width = resMan.GetString("formWidth")
                Me.Height = resMan.GetString("formHeight")

                Me.GemMenu.Font = Me.Font
                Me.menuSettings.Text = resMan.GetString("Settings")
                Me.menuLanguage.Text = resMan.GetString("Language")
                Me.menuEnglish.Text = resMan.GetString("English")
                Me.menuTraditionalChinese.Text = resMan.GetString("TraditionalChinese")
                'Me.menuSimplifiedChinese.Text = resMan.GetString("simplifiedChinese")
                Me.menuAlwaysOnTop.Text = resMan.GetString("AlwaysOnTop")
                Me.menuExit.Text = resMan.GetString("menuExit")
                Me.menuAbout.Text = resMan.GetString("AboutMenu")

                Me.evalTab.Text = resMan.GetString("SGE")
                Me.initTab.Text = resMan.GetString("EGI")

                Me.calculateButton.Text = resMan.GetString("calculate")
                Me.restartButton.Text = resMan.GetString("restart")

                Me.getInfo1.Text = resMan.GetString("getInfo1")
                Me.getInfo2.Text = resMan.GetString("getInfo2")
                Me.getInfo3.Text = resMan.GetString("getInfo3")
                Me.initInfo1.Text = resMan.GetString("initInfo1")
                Me.initInfo2.Text = resMan.GetString("initInfo2")
                Me.initInfo3.Text = resMan.GetString("initInfo3")
                Me.inputInfo1.Text = resMan.GetString("inputInfo1")
                Me.inputInfo2.Text = resMan.GetString("inputInfo2")
                Me.inputInfo3.Text = resMan.GetString("inputInfo3")
                Me.result.Text = resMan.GetString("result")
                Me.score.Text = resMan.GetString("score")
                Me.individual.Text = resMan.GetString("individual")
                Me.total.Text = resMan.GetString("total")
                Me.stellar.Text = resMan.GetString("stellar")
                Me.radiant.Text = resMan.GetString("radiant")

                Me.stat1.Items.Clear()
                Me.stat1.Items.Add(resMan.GetString("PD"))
                Me.stat1.Items.Add(resMan.GetString("MD"))
                Me.stat1.Items.Add(resMan.GetString("PMH"))
                Me.stat1.Items.Add(resMan.GetString("MH"))
                Me.stat1.Items.Add(resMan.GetString("HR"))
                Me.stat1.Items.Add(resMan.GetString("CH"))
                Me.stat1.Items.Add(resMan.GetString("CD"))
                Me.stat2.Items.Clear()
                Me.stat2.Items.Add(resMan.GetString("PD"))
                Me.stat2.Items.Add(resMan.GetString("MD"))
                Me.stat2.Items.Add(resMan.GetString("PMH"))
                Me.stat2.Items.Add(resMan.GetString("MH"))
                Me.stat2.Items.Add(resMan.GetString("HR"))
                Me.stat2.Items.Add(resMan.GetString("CH"))
                Me.stat2.Items.Add(resMan.GetString("CD"))
                Me.stat3.Items.Clear()
                Me.stat3.Items.Add(resMan.GetString("PD"))
                Me.stat3.Items.Add(resMan.GetString("MD"))
                Me.stat3.Items.Add(resMan.GetString("PMH"))
                Me.stat3.Items.Add(resMan.GetString("MH"))
                Me.stat3.Items.Add(resMan.GetString("HR"))
                Me.stat3.Items.Add(resMan.GetString("CH"))
                Me.stat3.Items.Add(resMan.GetString("CD"))

                Me.evalBanner.Image = CType(resMan.GetObject("TroveSig"), Bitmap)
                Me.initBanner.Image = CType(resMan.GetObject("TroveSig"), Bitmap)

                Me.BugLabel.Text = resMan.GetString("bugText")
                Me.reportLabel.Text = resMan.GetString("reportText")
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub restartButton_Click(sender As Object, e As EventArgs) Handles restartButton.Click
        ' Resets Result Section
        score1.Text = ""
        score2.Text = ""
        score3.Text = ""
        finalScore.Text = ""
        suggestion.Text = ""
        result.Visible = False
        score.Visible = False
        individual.Visible = False
        total.Visible = False
        score1.Visible = False
        score2.Visible = False
        score3.Visible = False
        finalScore.Visible = False
        suggestion.Visible = False

        ' Resets Input Section
        input1.Text = ""
        input2.Text = ""
        input3.Text = ""
        stat1.SelectedIndex = -1
        stat2.SelectedIndex = -1
        stat3.SelectedIndex = -1
        input2.Visible = False
        input3.Visible = False
        stat2.Visible = False
        stat3.Visible = False
        calculateButton.Enabled = False
    End Sub

    Private Sub input1_TextChanged(sender As Object, e As EventArgs) Handles input1.Validated
        If checkInput(sender, stat1) Then
            input2.Visible = True
            stat2.Visible = True
        End If
    End Sub

    Private Sub input2_TextChanged(sender As Object, e As EventArgs) Handles input2.Validated
        If checkInput(sender, stat2) Then
            input3.Visible = True
            stat3.Visible = True
        End If
    End Sub

    Private Sub input3_TextChanged(sender As Object, e As EventArgs) Handles input3.Validated
        checkInput(sender, stat3)
    End Sub

    Private Sub stat1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stat1.SelectedIndexChanged, stat1.TextChanged
        If checkInput(input1, sender) Then
            input2.Visible = True
            stat2.Visible = True
        End If
    End Sub

    Private Sub stat2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stat2.SelectedIndexChanged, stat2.TextChanged
        If checkInput(input2, sender) Then
            input3.Visible = True
            stat3.Visible = True
        End If
    End Sub

    Private Sub stat3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stat3.SelectedIndexChanged, stat3.TextChanged
        checkInput(input3, sender)
    End Sub

    Private Sub stat1_Validated(sender As Object, e As EventArgs) Handles stat1.Validated
        stat1.SelectedIndex = selectByInput(sender.text)
    End Sub

    Private Sub stat2_Validated(sender As Object, e As EventArgs) Handles stat2.Validated
        stat2.SelectedIndex = selectByInput(sender.text)
    End Sub

    Private Sub stat3_Validated(sender As Object, e As EventArgs) Handles stat3.Validated
        stat3.SelectedIndex = selectByInput(sender.text)
    End Sub

    Private Function selectByInput(ByVal input As String) As Integer
        Select Case input.ToUpper
            Case "PD"
                Return 0
            Case resMan.GetString("PD").ToUpper
                Return 0
            Case "MD"
                Return 1
            Case resMan.GetString("MD").ToUpper
                Return 1
            Case "%MHP"
                Return 2
            Case "%MH"
                Return 2
            Case resMan.GetString("PMH").ToUpper
                Return 2
            Case "%MAX HEALTH"
                Return 2
            Case "%MAXHP"
                Return 2
            Case "MH"
                Return 3
            Case "MHP"
                Return 3
            Case resMan.GetString("MH").ToUpper
                Return 3
            Case "HR"
                Return 4
            Case "HEALTH REGEN"
                Return 4
            Case resMan.GetString("HR").ToUpper
                Return 4
            Case "CH"
                Return 5
            Case resMan.GetString("CH").ToUpper
                Return 5
            Case "CD"
                Return 6
            Case resMan.GetString("CD").ToUpper
                Return 6
        End Select
        Return -1
    End Function

    Private Function checkInput(ByRef tb As TextBox, ByRef cb As ComboBox) As Boolean
        Dim value As Double = 0
        Dim percentage As Boolean = False

        calculateButton.BackColor = Color.FromArgb(190, 0, 0)
        calculateButton.Enabled = False

        If tb.Text = "" Then Return False
        If cb.SelectedIndex = -1 Then Return False

        Try
            tb.Text = StrConv(tb.Text.Trim, VbStrConv.Narrow)
        Catch ex As Exception
            tb.Text = tb.Text.Trim
        End Try
        Try
            If tb.Text.EndsWith("%") Then
                percentage = True
                tb.Text = Mid(tb.Text, 1, Len(tb.Text) - 1)
            End If
            value = CDbl(tb.Text)
            If Not percentage And value < 1 Then
                value = value * 100
                tb.Text = value & "%"
            ElseIf percentage Then
                tb.Text = value & "%"
            Else
                tb.Text = value
            End If

        Catch ex As Exception
            MsgBox(resMan.GetString("invalidInput"), vbOKOnly + vbCritical, resMan.GetString("titleError"))
            tb.Text = ""
            tb.Focus()
            Return False
        End Try
        Select Case cb.SelectedIndex
            Case 0
                'Physical Damage
                tb.Text = value
            Case 1
                'Magic Damage
                tb.Text = value
            Case 2
                '% Max Health
                tb.Text = value & "%"
            Case 3
                'Max Health
                tb.Text = value
            Case 4
                'Health Regeneration
                tb.Text = value
            Case 5
                'Critical Hit
                tb.Text = value & "%"
            Case 6
                'Critical Damage
                tb.Text = value & "%"
            Case Else
                Return False
        End Select
        calculateButton.BackColor = Color.Green
        calculateButton.Enabled = True
        Return True
    End Function

    Private Function getMax(ByVal stat As Integer) As Double
        If stat = -1 Then Return -9999
        If stellar.Checked Then
            Select Case stat
                Case 0
                    Return SPD
                Case 1
                    Return SMD
                Case 2
                    Return SPMH
                Case 3
                    Return SMH
                Case 4
                    Return SHR
                Case 5
                    Return SCH
                Case 6
                    Return SCD
            End Select
        Else
            Select Case stat
                Case 0
                    Return RPD
                Case 1
                    Return RMD
                Case 2
                    Return RPMH
                Case 3
                    Return RMH
                Case 4
                    Return RHR
                Case 5
                    Return RCH
                Case 6
                    Return RCD
            End Select
        End If
        Return -9999
    End Function

    Private Function getValue(ByVal input As String) As Double
        Dim value As Double = 0
        If input.EndsWith("%") Then
            value = CDbl(Mid(input, 1, Len(input) - 1)) / 100
        Else
            value = CDbl(input)
        End If
        Return value
    End Function

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim stat1max, stat2max, stat3max As Double
        Dim stat1score, stat2score, stat3score As Double
        Dim finalResult As Double

        stat1max = getMax(stat1.SelectedIndex) / 2
        stat1score = (getValue(input1.Text) - stat1max) / stat1max
        score1.Text = Math.Round(stat1score * 100, 1) & "%"
        If Not getMax(stat2.SelectedIndex) = -9999 Then
            stat2max = getMax(stat2.SelectedIndex) / 2
            stat2score = (getValue(input2.Text) - stat2max) / stat2max
            score2.Text = Math.Round(stat2score * 100, 1) & "%"
        End If
        If Not getMax(stat3.SelectedIndex) = -9999 Then
            stat3max = getMax(stat3.SelectedIndex) / 2
            stat3score = (getValue(input3.Text) - stat3max) / stat3max
            score3.Text = Math.Round(stat3score * 100, 1) & "%"
        End If

        finalResult = Math.Round((stat1score + stat2score + stat3score) / 3, 2)
        finalScore.Text = finalResult.ToString("#.00 %")


        If stat1score > 1 Or stat2score > 1 Or stat3score > 1 Then
            finalScore.Text = resMan.GetString("notLevel1Short")
            suggestion.Text = My.Resources.Locale.NotLevel1
        ElseIf stat1score < 0 Or stat2score < 0 Or stat3score < 0 Then
            finalScore.Text = resMan.GetString("outOfBoundShort")
            suggestion.Text = My.Resources.Locale.BadType
        ElseIf finalResult < 0.05 Then
            suggestion.Text = My.Resources.Locale.Score1
        ElseIf finalResult < 0.35 Then
            suggestion.Text = My.Resources.Locale.Score35
        ElseIf finalResult < 0.45 Then
            suggestion.Text = My.Resources.Locale.Score45
        ElseIf finalResult < 0.55 Then
            suggestion.Text = My.Resources.Locale.Score55
        ElseIf finalResult < 0.75 Then
            suggestion.Text = My.Resources.Locale.Score75
        ElseIf finalResult < 0.86 Then
            suggestion.Text = My.Resources.Locale.Score86
        ElseIf finalResult < 0.95 Then
            suggestion.Text = My.Resources.Locale.Score95
        ElseIf finalResult > 0.99 Then
            suggestion.Text = My.Resources.Locale.Score100
        End If

        result.Visible = True
        score.Visible = True
        individual.Visible = True
        total.Visible = True
        score1.Visible = True
        score2.Visible = True
        score3.Visible = True
        finalScore.Visible = True
        suggestion.Visible = True
    End Sub

    Private Sub findInit(sender As Object, e As EventArgs) Handles curPR.Validated, curLevel.Validated
        If Not curPR.Text = "" Then

            Try
                curPR.Text = CInt(curPR.Text)
                If Not curLevel.Text = "" Then
                    findGemInfo()
                End If
                If CInt(curPR.Text) < 0 Then
                    MsgBox(resMan.GetString("invalidPRInput"), vbCritical + vbOKOnly, resMan.GetString("titleError"))
                    curPR.Text = ""
                    curPR.Focus()
                End If
            Catch ex As Exception
                MsgBox(resMan.GetString("invalidPRInput"), vbCritical + vbOKOnly, resMan.GetString("titleError"))
                curPR.Text = ""
                curPR.Focus()
            End Try
        End If
        If Not curLevel.Text = "" Then
            Try
                curLevel.Text = CInt(curLevel.Text)
                If CInt(curLevel.Text) >= 1 And CInt(curLevel.Text) <= 25 Then
                    If Not curPR.Text = "" Then
                        findGemInfo()
                    End If
                Else
                    MsgBox(resMan.GetString("invalidLevelInput"), vbCritical + vbOKOnly, resMan.GetString("titleError"))
                    curLevel.Text = ""
                    curLevel.Focus()
                End If
            Catch ex As Exception
                MsgBox(resMan.GetString("invalidLevelInput"), vbCritical + vbOKOnly, resMan.GetString("titleError"))
                curLevel.Text = ""
                curLevel.Focus()
            End Try
        End If
    End Sub

    Private Sub findGemInfo()
        For checkType As Integer = 0 To 1
            Dim powerRank As Integer = 100
            Dim rankUp As Integer = 3
            Dim prDifference As Integer = 113
            If checkType = 0 Then
                rankUp = 5
                prDifference = 200
            End If
            For stat As Integer = 1 To 3
                Dim curPowerRank As Integer = powerRank + prDifference * stat - rankUp * stat
                Dim newStat As Integer = stat
                For level As Integer = 1 To CInt(curLevel.Text)
                    If level = 5 Or level = 10 Or level = 15 Then
                        curPowerRank = curPowerRank + prDifference
                        newStat += 1
                        If newStat >= 3 Then newStat = 3
                    ElseIf level = 20 Or level = 25 Then
                        curPowerRank = curPowerRank + rankUp * 15
                    ElseIf level > 15 Then
                        curPowerRank = curPowerRank + rankUp * 6
                    Else
                        curPowerRank = curPowerRank + rankUp * newStat
                    End If
                    If CInt(curPR.Text) < curPowerRank Then
                        'Debug.WriteLine("Gem Type: " & checkType & " | Level : " & level & " | Stat : " & newStat & " | Power Rank: " & curPowerRank)
                        Exit For
                    ElseIf CInt(curPR.Text) = curPowerRank Then
                        If checkType = 0 Then
                            gemType.Text = resMan.GetString("stellar")
                            initCount.Text = stat
                            Exit Sub
                        ElseIf checkType = 1 Then
                            gemType.Text = resMan.GetString("radiant")
                            initCount.Text = stat
                            Exit Sub
                        Else
                            gemType.Text = resMan.GetString("unknown")
                            initCount.Text = resMan.GetString("unknown")
                        End If
                    End If
                    'Debug.WriteLine("Gem Type: " & checkType & " | Level : " & level & " | Stat : " & newStat & " | Power Rank: " & curPowerRank)
                    If checkType = 1 And level > 23 Then
                        Exit For
                    End If
                Next
            Next
        Next
        gemType.Text = resMan.GetString("unknown")
        initCount.Text = resMan.GetString("unknown")

    End Sub

    Private Sub menuEnglish_Click(sender As Object, e As EventArgs) Handles menuEnglish.Click
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en")
        Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en")
        updateUIControls()
    End Sub

    Private Sub menuTraditionalChinese_Click(sender As Object, e As EventArgs) Handles menuTraditionalChinese.Click
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("zh-TW")
        Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("zh-TW")
        updateUIControls()
    End Sub

    Private Sub reportLabel_Click(sender As Object, e As EventArgs) Handles reportLabel.Click
        System.Diagnostics.Process.Start(resMan.GetString("reportURL"))
    End Sub

    Private Sub menuAbout_Click(sender As Object, e As EventArgs) Handles menuAbout.Click
        Dim aboutDlg As New About
        aboutDlg.ShowDialog()
    End Sub

    Private Sub menuAlwaysOnTop_Click(sender As Object, e As EventArgs) Handles menuAlwaysOnTop.Click
        Me.TopMost = True
    End Sub
End Class
