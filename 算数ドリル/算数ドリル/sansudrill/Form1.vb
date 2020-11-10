Public Class Form1
    Dim rand As New Random
    Dim noA As Long
    Dim noB As Long
    Dim noC As Long
    Dim mondaiCnt As Long   ' 出題数カウント
    Dim mondaiMax As Long   ' 最大問題数
    Dim seikaiCnt As Long   ' 正解数
    Dim type As Long        ' 1:足し算 2:引き算
    Dim typeStr As String   ' 演算記号

    '答え合わせ
    Sub kotaeawase()
        If noC = InBox.Text Then
            outBox.AppendText("○ ")
            seikaiCnt += 1
        Else
            outBox.AppendText("× ")
        End If
        outBox.AppendText(mondaiLbl.Text & InBox.Text & vbCrLf)
    End Sub

    '問題作成
    Sub Mondaisakusei()
        noA = rand.Next(1, 10)
        noB = rand.Next(1, 10)
        mondaiLbl.Text = noA & typeStr & noB & " = "
        If type = 1 Then
            noC = noA + noB
        Else
            noC = noA - noB
        End If
        mondaiCnt += 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InBox.Enabled = False
    End Sub
    Private Sub InBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InBox.KeyPress
        '数値およびバックスペースのみ受け付ける
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            If Not (e.KeyChar = "-"c And InBox.TextLength = 0) Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(Keys.Enter) And InBox.Text <> "" Then
            Console.WriteLine(InBox.Text)
            'outBox.AppendText(InBox.Text & vbCrLf)
            kotaeawase()
            InBox.Text = ""
            If mondaiCnt < mondaiMax Then
                Mondaisakusei()
            Else
                Seiseki()
            End If
        End If
    End Sub

    '成績
    Sub Seiseki()
        InBox.Enabled = False
        mondaiLbl.Text = "" '問題表示クリア
        outBox.AppendText("正解数は" & seikaiCnt & "です")

    End Sub
    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        '出題する問題数を変更する
        Select Case True
            Case RB10.Checked
                mondaiMax = 5
            Case RB20.Checked
                mondaiMax = 10
            Case RB30.Checked
                mondaiMax = 15
        End Select

        ' 計算タイプを変更する
        Select Case True
            Case RBtasu.Checked
                type = 1
                typeStr = " + "
            Case RBhiku.Checked
                type = 2
                typeStr = " - "
        End Select

        mondaiCnt = 0
        seikaiCnt = 0
        Mondaisakusei()
        InBox.Enabled = True
        InBox.Focus()
    End Sub

    Private Sub outBox_TextChanged(sender As Object, e As EventArgs) Handles outBox.TextChanged

    End Sub
End Class
