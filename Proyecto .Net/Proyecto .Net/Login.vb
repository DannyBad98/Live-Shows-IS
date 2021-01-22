Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TALLERMECANICODataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String
        Dim pass As String
        usuario = txt_user.Text
        pass = txt_pass.Text
        If (usuario = "Administrador") And (pass = "Admin123") Then
            Me.Hide()
            AMenu.Show()
            AMenu.Refresh()
            txt_user.Text = ""
            txt_pass.Text = ""
        End If
        If (usuario = "Usuario") And (pass = "User123") Then
            Me.Hide()
            UMenu.Show()
            UMenu.Refresh()
            txt_user.Text = ""
            txt_pass.Text = ""
        End If
        If Not ((usuario = "Usuario" Or usuario = "Administrador") And (pass = "User123" Or pass = "Admin123")) Then
            MsgBox("Usuario y/o contraseña invalido")
            txt_user.Text = ""
            txt_pass.Text = ""
        End If



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("Desea salir de la aplicacion", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
