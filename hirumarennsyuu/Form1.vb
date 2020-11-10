Imports System.Data.OleDb

Public Class form_Touroku

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_Touroku.Click
        MessageBox.Show(textbox_Name.Text)

        If textbox_Juusyo.Text = "" Then
            MessageBox.Show("住所未入力です。")

        ElseIf textbox_Adoresu.Text = "" Then
            MessageBox.Show("アドレス未入力です。")

        ElseIf textbox_Tel.Text = "" Then
            MessageBox.Show("電話番号未入力です。")

        ElseIf combo_Syozoku.Text = "" Then
            MessageBox.Show("所属会社を選択してください。")

        ElseIf radioBtn_Woman.Checked = False AndAlso radioBtn_mens.Checked = False Then
            MessageBox.Show("性別を選択してください。")

        ElseIf CheckBox1.Checked = False Then
            MessageBox.Show("利用規約に同意してください。")

        End If

        'textbox_Tel に数字のみ受け付ける判定
        Dim innum As String
        innum = textbox_Tel.Text()

        If IsNumeric(innum) = True Then
            ' TextBox3.Text = ("エラー")
        Else
            MessageBox.Show("電話番号を入力してください。")

        End If

        Try
            Dim csvPath As String = "C:\Users\hirum\Desktop\直紀.csv" '保存先のCSVファイルのパス
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            Dim sr As New System.IO.StreamWriter(csvPath, False, enc) '開く

            sr.Write(textbox_Name.Text) '名前
            sr.Write(","c)
            sr.Write(textbox_Juusyo.Text) '住所
            sr.Write(","c)
            sr.Write(textbox_Adoresu.Text)　'アドレス
            sr.Write(","c)
            sr.Write(textbox_Tel.Text) '電話番号
            sr.Write(","c)
            sr.Write(combo_Syozoku.Text) '所属
            sr.Write(","c)

            sr.Close() '閉じる
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button_Close.Click

        Me.Owner.Show()
        Me.Close()

    End Sub

    'クリアボタンクリック処理
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()
    End Sub
    Private Sub ClearForm()

        textbox_Name.Text = Nothing
        textbox_Juusyo.Text = Nothing
        textbox_Adoresu.Text = Nothing
        textbox_Tel.Text = Nothing
        combo_Syozoku.Text = Nothing
        CheckBox1.Checked = Nothing

    End Sub

    Private Sub form_Touroku_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Combobox 内の項目
        combo_Syozoku.Items.Add("オブジェクティブコード")
        combo_Syozoku.Items.Add("Vオブジェクティブ")
        combo_Syozoku.Items.Add("オブジェクティブサイバー")
        combo_Syozoku.Items.Add("オブジェクティブコア")
        combo_Syozoku.Items.Add("オブジェクティブカルク")
        combo_Syozoku.Items.Add("オブジェクティブコンセプト")
        combo_Syozoku.Items.Add("オブジェクティブフリント")

        'ComboBox のスタイルを指定
        combo_Syozoku.DropDownStyle = ComboBoxStyle.DropDownList
        '先頭のアイテムを表示させる
        combo_Syozoku.Text = combo_Syozoku.GetItemText(combo_Syozoku.Items(0))

    End Sub
End Class
