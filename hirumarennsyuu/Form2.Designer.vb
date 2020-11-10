<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Menu
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
        Me.button_Touroku = New System.Windows.Forms.Button()
        Me.button_Close = New System.Windows.Forms.Button()
        Me.button_Form3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_Touroku
        '
        Me.button_Touroku.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.button_Touroku.Location = New System.Drawing.Point(467, 95)
        Me.button_Touroku.Name = "button_Touroku"
        Me.button_Touroku.Size = New System.Drawing.Size(111, 38)
        Me.button_Touroku.TabIndex = 0
        Me.button_Touroku.Text = "会員登録"
        Me.button_Touroku.UseVisualStyleBackColor = True
        '
        'button_Close
        '
        Me.button_Close.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.button_Close.Location = New System.Drawing.Point(467, 362)
        Me.button_Close.Name = "button_Close"
        Me.button_Close.Size = New System.Drawing.Size(111, 38)
        Me.button_Close.TabIndex = 1
        Me.button_Close.Text = "閉じる"
        Me.button_Close.UseVisualStyleBackColor = True
        '
        'button_Form3
        '
        Me.button_Form3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.button_Form3.Location = New System.Drawing.Point(467, 171)
        Me.button_Form3.Name = "button_Form3"
        Me.button_Form3.Size = New System.Drawing.Size(111, 38)
        Me.button_Form3.TabIndex = 3
        Me.button_Form3.Text = "ログイン"
        Me.button_Form3.UseVisualStyleBackColor = True
        '
        'form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 450)
        Me.Controls.Add(Me.button_Form3)
        Me.Controls.Add(Me.button_Close)
        Me.Controls.Add(Me.button_Touroku)
        Me.Name = "form_Menu"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_Touroku As Button
    Friend WithEvents button_Close As Button
    Friend WithEvents button_Form3 As Button
End Class
