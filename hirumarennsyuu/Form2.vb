Public Class form_Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_Touroku.Click
        Dim fm As New form_Touroku
        fm.Show(Me)
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button_Close.Click

        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles button_Form3.Click
        Dim fm As New Form3
        fm.ShowDialog()

    End Sub


End Class