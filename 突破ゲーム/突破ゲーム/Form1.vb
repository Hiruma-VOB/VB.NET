Public Class Form1

    Dim Cpos As Point
    Dim shotFlg As Boolean
    Dim hitFlg As Boolean

    ' プレイヤーの上移動
    Private Sub Player_move()

        If hitFlg Then
            Exit Sub    ' プレイヤーの動きを止める
        End If

        Player.Top -= 20
        If Player.Top < (0 - Player.Height) Then
            score.Text += 10   ' すき間をすり抜けて上まで来たのでスコア加算
            Sukima.Width -= 3  ' すき間を少し狭くする
            Player_init()
        End If

        Dim pH As Long = Player.Height
        Dim pW As Long = Player.Width
        Dim sH As Long = Sukima.Height
        Dim sW As Long = Sukima.Width
        Dim aH As Long = aida.Height
        Dim aW As Long = aida.Width


        If (Player.Top < Sukima.Top + sH) And (Player.Top + pH > Sukima.Top) Then
            If (Player.Left < Sukima.Left) Or (Player.Left + pW > Sukima.Left + sW) Then

                hitFlg = True
                Button1.Enabled = True   ' 開始ボタンの表示
                Gameover.Show()      ' ゲームオーバーの表示

            End If
        End If

        If (Player.Top < aida.Top + aH) And (Player.Top + pH > aida.Top + aH) Then
            If (Player.Left < aida.Left) Or (Player.Left + pW > aida.Left + aW) Then

                hitFlg = True
                Button1.Enabled = True   ' 開始ボタンの表示
                Gameover.Show()      ' ゲームオーバーの表示

            End If
        End If

    End Sub

    Private Sub Sukima_move()

        If hitFlg Then
            Exit Sub
        End If

        Sukima.Left += 3
        If Sukima.Left > Width Then
            Sukima.Left = -Sukima.Width

        End If
    End Sub

    Private Sub aida_move()

        If hitFlg Then
            Exit Sub
        End If

        aida.Left += 1
        If aida.Left > Width Then
            aida.Left = -aida.Width

        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Cpos = PointToClient(Cursor.Position)
        Sukima_move()
        aida_move()


        If shotFlg Then
            Player_move() ' プレイヤーの上移動
            Exit Sub
        End If


        If Cpos.X < 0 Then
            Cpos.X = 0
        End If

        If Cpos.X > Width - Player.Width Then
            Cpos.X = Width - Player.Width
        End If

        Player.Left = Cpos.X
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Game_init()
    End Sub

    ' ゲームの初期化
    Private Sub Game_init()
        Button1.Enabled = False    ' 開始ボタンを無効にする
        hitFlg = False    ' False：当たっていない
        Gameover.Hide()　 ' ゲームオーバーを隠す
        score.Text = 0    ' スコアのクリア
        Sukima.Width = 80 ' すき間の幅
        Player_init()

    End Sub
    ' プレイヤーの初期化
    Private Sub Player_init()
        Player.Top = Height - (Player.Height * 3)
        Player.Left = Cpos.X
        shotFlg = False
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        shotFlg = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Game_init()
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        System.Windows.Forms.Cursor.Hide()
    End Sub
    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        System.Windows.Forms.Cursor.Show()
    End Sub


End Class
