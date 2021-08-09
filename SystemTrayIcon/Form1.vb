Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NotifyIcon1.Icon = Icon
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = Not CheckBox2.Checked
            NotifyIcon1.Visible = CheckBox1.Checked OrElse CheckBox2.Checked
        ElseIf WindowState = FormWindowState.Normal Then
            ShowInTaskbar = True
            NotifyIcon1.Visible = CheckBox1.Checked
        End If
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        If WindowState = FormWindowState.Minimized Then
            WindowState = FormWindowState.Normal
        ElseIf WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        NotifyIcon1.Visible = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
    End Sub
End Class