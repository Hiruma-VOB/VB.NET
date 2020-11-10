<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InBox = New System.Windows.Forms.TextBox()
        Me.outBox = New System.Windows.Forms.TextBox()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.mondaiLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBhiku = New System.Windows.Forms.RadioButton()
        Me.RBtasu = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB30 = New System.Windows.Forms.RadioButton()
        Me.RB20 = New System.Windows.Forms.RadioButton()
        Me.RB10 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "答え"
        '
        'InBox
        '
        Me.InBox.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InBox.Location = New System.Drawing.Point(117, 336)
        Me.InBox.Name = "InBox"
        Me.InBox.Size = New System.Drawing.Size(131, 26)
        Me.InBox.TabIndex = 1
        Me.InBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'outBox
        '
        Me.outBox.BackColor = System.Drawing.Color.White
        Me.outBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.outBox.Location = New System.Drawing.Point(272, 129)
        Me.outBox.Multiline = True
        Me.outBox.Name = "outBox"
        Me.outBox.ReadOnly = True
        Me.outBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.outBox.Size = New System.Drawing.Size(187, 233)
        Me.outBox.TabIndex = 2
        '
        'startBtn
        '
        Me.startBtn.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.startBtn.Location = New System.Drawing.Point(69, 178)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(179, 40)
        Me.startBtn.TabIndex = 3
        Me.startBtn.Text = "開始"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'mondaiLbl
        '
        Me.mondaiLbl.BackColor = System.Drawing.Color.White
        Me.mondaiLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mondaiLbl.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.mondaiLbl.Location = New System.Drawing.Point(44, 277)
        Me.mondaiLbl.Name = "mondaiLbl"
        Me.mondaiLbl.Size = New System.Drawing.Size(222, 36)
        Me.mondaiLbl.TabIndex = 4
        Me.mondaiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBhiku)
        Me.GroupBox1.Controls.Add(Me.RBtasu)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 53)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "タイプ"
        '
        'RBhiku
        '
        Me.RBhiku.AutoSize = True
        Me.RBhiku.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RBhiku.Location = New System.Drawing.Point(133, 18)
        Me.RBhiku.Name = "RBhiku"
        Me.RBhiku.Size = New System.Drawing.Size(79, 23)
        Me.RBhiku.TabIndex = 1
        Me.RBhiku.Text = "引き算"
        Me.RBhiku.UseVisualStyleBackColor = True
        '
        'RBtasu
        '
        Me.RBtasu.AutoSize = True
        Me.RBtasu.Checked = True
        Me.RBtasu.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RBtasu.Location = New System.Drawing.Point(42, 17)
        Me.RBtasu.Name = "RBtasu"
        Me.RBtasu.Size = New System.Drawing.Size(79, 23)
        Me.RBtasu.TabIndex = 0
        Me.RBtasu.TabStop = True
        Me.RBtasu.Text = "足し算"
        Me.RBtasu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB30)
        Me.GroupBox2.Controls.Add(Me.RB20)
        Me.GroupBox2.Controls.Add(Me.RB10)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 43)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "問題数"
        '
        'RB30
        '
        Me.RB30.AutoSize = True
        Me.RB30.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RB30.Location = New System.Drawing.Point(245, 12)
        Me.RB30.Name = "RB30"
        Me.RB30.Size = New System.Drawing.Size(72, 23)
        Me.RB30.TabIndex = 2
        Me.RB30.Text = "15 問"
        Me.RB30.UseVisualStyleBackColor = True
        '
        'RB20
        '
        Me.RB20.AutoSize = True
        Me.RB20.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RB20.Location = New System.Drawing.Point(133, 12)
        Me.RB20.Name = "RB20"
        Me.RB20.Size = New System.Drawing.Size(72, 23)
        Me.RB20.TabIndex = 1
        Me.RB20.Text = "10 問"
        Me.RB20.UseVisualStyleBackColor = True
        '
        'RB10
        '
        Me.RB10.AutoSize = True
        Me.RB10.Checked = True
        Me.RB10.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RB10.Location = New System.Drawing.Point(42, 12)
        Me.RB10.Name = "RB10"
        Me.RB10.Size = New System.Drawing.Size(62, 23)
        Me.RB10.TabIndex = 0
        Me.RB10.TabStop = True
        Me.RB10.Text = "5 問"
        Me.RB10.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 388)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mondaiLbl)
        Me.Controls.Add(Me.startBtn)
        Me.Controls.Add(Me.outBox)
        Me.Controls.Add(Me.InBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "算数ドリル"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InBox As TextBox
    Friend WithEvents outBox As TextBox
    Friend WithEvents startBtn As Button
    Friend WithEvents mondaiLbl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBhiku As RadioButton
    Friend WithEvents RBtasu As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RB30 As RadioButton
    Friend WithEvents RB20 As RadioButton
    Friend WithEvents RB10 As RadioButton
End Class
