<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Touroku
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textbox_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_Touroku = New System.Windows.Forms.Button()
        Me.textbox_Juusyo = New System.Windows.Forms.TextBox()
        Me.jusho = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textbox_Adoresu = New System.Windows.Forms.TextBox()
        Me.textbox_Tel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.button_Close = New System.Windows.Forms.Button()
        Me.combo_Syozoku = New System.Windows.Forms.ComboBox()
        Me.radioBtn_mens = New System.Windows.Forms.RadioButton()
        Me.radioBtn_Woman = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.radio_Sex = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.radio_Sex.SuspendLayout()
        Me.SuspendLayout()
        '
        'textbox_Name
        '
        Me.textbox_Name.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textbox_Name.Location = New System.Drawing.Point(108, 26)
        Me.textbox_Name.Name = "textbox_Name"
        Me.textbox_Name.Size = New System.Drawing.Size(262, 26)
        Me.textbox_Name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "名前"
        '
        'button_Touroku
        '
        Me.button_Touroku.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.button_Touroku.Location = New System.Drawing.Point(22, 320)
        Me.button_Touroku.Name = "button_Touroku"
        Me.button_Touroku.Size = New System.Drawing.Size(211, 34)
        Me.button_Touroku.TabIndex = 2
        Me.button_Touroku.Text = "登録"
        Me.button_Touroku.UseVisualStyleBackColor = True
        '
        'textbox_Juusyo
        '
        Me.textbox_Juusyo.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textbox_Juusyo.Location = New System.Drawing.Point(108, 62)
        Me.textbox_Juusyo.Name = "textbox_Juusyo"
        Me.textbox_Juusyo.Size = New System.Drawing.Size(262, 26)
        Me.textbox_Juusyo.TabIndex = 3
        '
        'jusho
        '
        Me.jusho.AutoSize = True
        Me.jusho.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.jusho.Location = New System.Drawing.Point(18, 62)
        Me.jusho.Name = "jusho"
        Me.jusho.Size = New System.Drawing.Size(47, 19)
        Me.jusho.TabIndex = 4
        Me.jusho.Text = "住所"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "アドレス"
        '
        'textbox_Adoresu
        '
        Me.textbox_Adoresu.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textbox_Adoresu.Location = New System.Drawing.Point(108, 100)
        Me.textbox_Adoresu.Name = "textbox_Adoresu"
        Me.textbox_Adoresu.Size = New System.Drawing.Size(262, 26)
        Me.textbox_Adoresu.TabIndex = 6
        '
        'textbox_Tel
        '
        Me.textbox_Tel.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textbox_Tel.Location = New System.Drawing.Point(108, 137)
        Me.textbox_Tel.Name = "textbox_Tel"
        Me.textbox_Tel.Size = New System.Drawing.Size(262, 26)
        Me.textbox_Tel.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "電話番号"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(411, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "必須"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(411, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "必須"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "必須"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(411, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "必須"
        '
        'button_Close
        '
        Me.button_Close.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.button_Close.Location = New System.Drawing.Point(398, 320)
        Me.button_Close.Name = "button_Close"
        Me.button_Close.Size = New System.Drawing.Size(75, 34)
        Me.button_Close.TabIndex = 14
        Me.button_Close.Text = "閉じる"
        Me.button_Close.UseVisualStyleBackColor = True
        '
        'combo_Syozoku
        '
        Me.combo_Syozoku.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.combo_Syozoku.FormattingEnabled = True
        Me.combo_Syozoku.Location = New System.Drawing.Point(108, 197)
        Me.combo_Syozoku.Name = "combo_Syozoku"
        Me.combo_Syozoku.Size = New System.Drawing.Size(262, 27)
        Me.combo_Syozoku.TabIndex = 15
        '
        'radioBtn_mens
        '
        Me.radioBtn_mens.AutoSize = True
        Me.radioBtn_mens.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.radioBtn_mens.Location = New System.Drawing.Point(107, 240)
        Me.radioBtn_mens.Name = "radioBtn_mens"
        Me.radioBtn_mens.Size = New System.Drawing.Size(65, 23)
        Me.radioBtn_mens.TabIndex = 16
        Me.radioBtn_mens.TabStop = True
        Me.radioBtn_mens.Text = "男性"
        Me.radioBtn_mens.UseVisualStyleBackColor = True
        '
        'radioBtn_Woman
        '
        Me.radioBtn_Woman.AutoSize = True
        Me.radioBtn_Woman.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.radioBtn_Woman.Location = New System.Drawing.Point(205, 240)
        Me.radioBtn_Woman.Name = "radioBtn_Woman"
        Me.radioBtn_Woman.Size = New System.Drawing.Size(65, 23)
        Me.radioBtn_Woman.TabIndex = 17
        Me.radioBtn_Woman.TabStop = True
        Me.radioBtn_Woman.Text = "女性"
        Me.radioBtn_Woman.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(112, 281)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 23)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "同意します。"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "所属"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "性別"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "利用規約"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(411, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 19)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "必須"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(411, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 19)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "必須"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(411, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 19)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "必須"
        '
        'btn_Clear
        '
        Me.btn_Clear.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(259, 320)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(111, 34)
        Me.btn_Clear.TabIndex = 25
        Me.btn_Clear.Text = "クリア"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'radio_Sex
        '
        Me.radio_Sex.Controls.Add(Me.Label14)
        Me.radio_Sex.Controls.Add(Me.Label1)
        Me.radio_Sex.Controls.Add(Me.btn_Clear)
        Me.radio_Sex.Controls.Add(Me.textbox_Name)
        Me.radio_Sex.Controls.Add(Me.Label13)
        Me.radio_Sex.Controls.Add(Me.button_Touroku)
        Me.radio_Sex.Controls.Add(Me.Label12)
        Me.radio_Sex.Controls.Add(Me.textbox_Juusyo)
        Me.radio_Sex.Controls.Add(Me.Label11)
        Me.radio_Sex.Controls.Add(Me.jusho)
        Me.radio_Sex.Controls.Add(Me.Label10)
        Me.radio_Sex.Controls.Add(Me.Label3)
        Me.radio_Sex.Controls.Add(Me.Label9)
        Me.radio_Sex.Controls.Add(Me.textbox_Adoresu)
        Me.radio_Sex.Controls.Add(Me.Label8)
        Me.radio_Sex.Controls.Add(Me.textbox_Tel)
        Me.radio_Sex.Controls.Add(Me.CheckBox1)
        Me.radio_Sex.Controls.Add(Me.Label2)
        Me.radio_Sex.Controls.Add(Me.radioBtn_Woman)
        Me.radio_Sex.Controls.Add(Me.Label4)
        Me.radio_Sex.Controls.Add(Me.radioBtn_mens)
        Me.radio_Sex.Controls.Add(Me.Label5)
        Me.radio_Sex.Controls.Add(Me.combo_Syozoku)
        Me.radio_Sex.Controls.Add(Me.Label6)
        Me.radio_Sex.Controls.Add(Me.button_Close)
        Me.radio_Sex.Controls.Add(Me.Label7)
        Me.radio_Sex.Location = New System.Drawing.Point(29, 24)
        Me.radio_Sex.Name = "radio_Sex"
        Me.radio_Sex.Size = New System.Drawing.Size(504, 500)
        Me.radio_Sex.TabIndex = 26
        Me.radio_Sex.TabStop = False
        Me.radio_Sex.Text = "GroupBox1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(219, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "数字のみで記載下さい。"
        '
        'form_Touroku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 564)
        Me.Controls.Add(Me.radio_Sex)
        Me.Name = "form_Touroku"
        Me.Text = "Form1"
        Me.radio_Sex.ResumeLayout(False)
        Me.radio_Sex.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents textbox_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents button_Touroku As Button
    Friend WithEvents textbox_Juusyo As TextBox
    Friend WithEvents jusho As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_Adoresu As TextBox
    Friend WithEvents textbox_Tel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents button_Close As Button
    Friend WithEvents combo_Syozoku As ComboBox
    Friend WithEvents radioBtn_mens As RadioButton
    Friend WithEvents radioBtn_Woman As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_Clear As Button
    Friend WithEvents radio_Sex As GroupBox
    Friend WithEvents Label14 As Label
End Class
