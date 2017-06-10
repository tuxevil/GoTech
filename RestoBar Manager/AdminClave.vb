Public Class AdminCortesia

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "rbmana" Then
            If temp = 1 Then
                Dim ec As New C_baradmin
                ec.elimina_consumo()
                Me.TextBox1.Text = ""
                Me.Close()
            ElseIf temp = 2 Then
                Dim pc As New C_baradmin
                pc.cortesia()
                Me.TextBox1.Text = ""
                Me.Close()
            End If
        Else
            MessageBox.Show("Clave Incorrecta")
            Me.TextBox1.Text = ""
            Me.TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                If Me.TextBox1.Text = "rbmana" Then
                    If temp = 1 Then
                        Dim ec As New C_baradmin
                        ec.elimina_consumo()
                        Me.TextBox1.Text = ""
                        Me.Close()
                    ElseIf temp = 2 Then
                        Dim pc As New C_baradmin
                        pc.cortesia()
                        Me.TextBox1.Text = ""
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Clave Incorrecta")
                    Me.TextBox1.Text = ""
                    Me.TextBox1.Focus()
                End If
            End If
        End If
    End Sub
End Class