Public Class Form4
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Button2.Enabled = True
        End If
        If ListBoxFin.Items.Count = 0 Then
            Me.Button2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ListBox1.Items.Clear()
        Form3.ListBox2.Items.Clear()
        For Each item As Object In Me.ListBoxFin.Items
            Form2.ListBox1.Items.Add(item)
            Form3.ListBox2.Items.Add(item)
        Next
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBoxFin.Items.Clear()
        Label1.Visible = True
        Button3.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Button2.Enabled = True
        End If
        If ListBoxFin.Items.Count = 0 Then
            Me.Button2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ListBoxFin.Items.Count = 0 Then
            Me.Button2.Enabled = False
        End If
    End Sub

    Private Sub ListBoxFin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFin.SelectedIndexChanged

    End Sub
End Class