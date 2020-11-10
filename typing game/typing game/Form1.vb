Imports System.Data.OleDb
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class Form1

    Dim n As Integer 'データベースの変数
    Dim ransuu As Integer
    Dim yoso As Integer '配列の要素を決定する
    Dim TypeWord(500000) As String

    Dim K As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = FreeFile()
        FileOpen(n, "Word.txt", OpenMode.Input)
        Do While Not EOF(n) 'ファイルエンドまでファイルをリードする
            yoso = yoso + 1 '配列の要素（１）～（最後）まで格納できる
            Input(n, TypeWord(yoso))
        Loop
        FileClose(n)
        tangohyouji()
        TextBox1.Text = Nothing
    End Sub

    Sub tangohyouji()

        ransuu = Math.Floor(Rnd() * yoso) + 1 '配列の要素数を乱数に使用

        '整数変数ransuuを直接配列の要素に使用
        If ransuu Mod 2 = 0 Then 'ransuuが偶数の時
            romaji_Label.Text = TypeWord(ransuu) 'ローマ字表示
            nihonngo_Label.Text = TypeWord(ransuu - 1) '日本語表示
        Else
            romaji_Label.Text = TypeWord(ransuu + 1) 'ローマ字表示
            nihonngo_Label.Text = TypeWord(ransuu) '日本語表示
        End If

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, TextBox1.KeyPress
        Dim w_Str As String = romaji_Label.Text

        If w_Str.Length = 0 Then
            '次の単語をLabel1にセットする処理
        Else
            If w_Str(0) = e.KeyChar Then
                'Label1.Textの先頭文字と同一のキーが押されたら１字削除
                romaji_Label.Text = w_Str.Remove(0, 1)
            Else
                e.Handled = True
            End If
        End If

    End Sub
    'textbox1でEnterキーを押すとButton1を押した時の処理
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If

    End Sub
End Class





