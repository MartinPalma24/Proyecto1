Public Class Form3
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton1.Text)
            RadioButton1.Checked = False
        End If
        If RadioButton2.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton2.Text)
            RadioButton2.Checked = False
        End If
        If RadioButton3.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton3.Text)
            RadioButton3.Checked = False
        End If
        If RadioButton4.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton4.Text)
            RadioButton4.Checked = False
        End If
        If RadioButton5.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton5.Text)
            RadioButton5.Checked = False
        End If
        If RadioButton6.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton6.Text)
            RadioButton6.Checked = False
        End If
        If RadioButton7.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton7.Text)
            RadioButton7.Checked = False
        End If
        If RadioButton8.Checked = True Then
            Me.ListBox2.Items.Add(RadioButton8.Text)
            RadioButton8.Checked = False
        End If

    End Sub


    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.Items.Count = 0 Then
            Form1.Button3.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Remove(ListBox2.SelectedItem)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class