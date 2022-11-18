Public Class Form2
    Dim contador As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox.Items.Remove(ListBox.SelectedItem)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox.Items.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        If ListBox.Items.Count = 0 Then
            Form1.Button3.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox.Items.Add(ComboBox1.Text)
        contador = ComboBox1.Items.IndexOf(ComboBox1.SelectedItem)
        If contador = 0 Then

        ElseIf contador = 1 Then

        ElseIf contador = 2 Then

        ElseIf contador = 3 Then

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        For i As Integer = 0 To ListBox1.SelectedItems.Count - 1
            ListBox.Items.Add(ListBox1.SelectedItems(i))
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ListBox.Items.Add(CheckBox1.Text)
        Else
            ListBox.Items.Remove(CheckBox1.Text)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ListBox.Items.Add(CheckBox2.Text)
        Else
            ListBox.Items.Remove(CheckBox2.Text)

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ListBox.Items.Add(CheckBox3.Text)
        Else
            ListBox.Items.Remove(CheckBox3.Text)

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ListBox.Items.Add(CheckBox4.Text)

        Else
            ListBox.Items.Remove(CheckBox4.Text)

        End If
    End Sub
End Class
