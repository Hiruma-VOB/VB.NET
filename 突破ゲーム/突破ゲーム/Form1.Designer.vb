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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Sukima = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Gameover = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.aida = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sukima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Orange
        Me.PictureBox1.Location = New System.Drawing.Point(-12, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(624, 42)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Sukima
        '
        Me.Sukima.BackColor = System.Drawing.SystemColors.Control
        Me.Sukima.Location = New System.Drawing.Point(201, 118)
        Me.Sukima.Name = "Sukima"
        Me.Sukima.Size = New System.Drawing.Size(233, 42)
        Me.Sukima.TabIndex = 1
        Me.Sukima.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 33
        '
        'Gameover
        '
        Me.Gameover.AutoSize = True
        Me.Gameover.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Gameover.ForeColor = System.Drawing.Color.Red
        Me.Gameover.Location = New System.Drawing.Point(180, 265)
        Me.Gameover.Name = "Gameover"
        Me.Gameover.Size = New System.Drawing.Size(244, 40)
        Me.Gameover.TabIndex = 3
        Me.Gameover.Text = "GAME OVER"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "開始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SCORE:"
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.score.Location = New System.Drawing.Point(103, 45)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(32, 16)
        Me.score.TabIndex = 6
        Me.score.Text = "999"
        '
        'aida
        '
        Me.aida.BackColor = System.Drawing.SystemColors.Control
        Me.aida.Location = New System.Drawing.Point(67, 189)
        Me.aida.Name = "aida"
        Me.aida.Size = New System.Drawing.Size(426, 42)
        Me.aida.TabIndex = 10
        Me.aida.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Orange
        Me.PictureBox3.Location = New System.Drawing.Point(-12, 189)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(624, 42)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.LimeGreen
        Me.Player.Location = New System.Drawing.Point(216, 455)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(20, 30)
        Me.Player.TabIndex = 11
        Me.Player.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 549)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.aida)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Gameover)
        Me.Controls.Add(Me.Sukima)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "突破"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sukima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Sukima As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Gameover As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents score As Label
    Friend WithEvents aida As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Player As PictureBox
End Class
