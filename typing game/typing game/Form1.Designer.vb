<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.romaji_Label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.nihonngo_Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'romaji_Label
        '
        Me.romaji_Label.BackColor = System.Drawing.Color.White
        Me.romaji_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.romaji_Label.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.romaji_Label.Location = New System.Drawing.Point(139, 80)
        Me.romaji_Label.Name = "romaji_Label"
        Me.romaji_Label.Size = New System.Drawing.Size(423, 47)
        Me.romaji_Label.TabIndex = 1
        Me.romaji_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(139, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(423, 66)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "スタート"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(139, 217)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(423, 38)
        Me.TextBox1.TabIndex = 0
        '
        'nihonngo_Label
        '
        Me.nihonngo_Label.BackColor = System.Drawing.Color.White
        Me.nihonngo_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nihonngo_Label.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nihonngo_Label.Location = New System.Drawing.Point(139, 33)
        Me.nihonngo_Label.Name = "nihonngo_Label"
        Me.nihonngo_Label.Size = New System.Drawing.Size(423, 47)
        Me.nihonngo_Label.TabIndex = 4
        Me.nihonngo_Label.Text = "タイピングゲーム"
        Me.nihonngo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enterキーを押してスタート！"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nihonngo_Label)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.romaji_Label)
        Me.Name = "Form1"
        Me.Text = "タイピングゲーム"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents romaji_Label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents nihonngo_Label As Label
    Friend WithEvents Label3 As Label
End Class
