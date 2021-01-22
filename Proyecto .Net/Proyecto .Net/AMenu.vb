Public Class AMenu
    Private Sub AMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub emp_Click(sender As Object, e As EventArgs) Handles emp.Click
        Me.Hide()
        Empleados.Show()
        Empleados.Refresh()

    End Sub

    Private Sub prov_Click(sender As Object, e As EventArgs) Handles prov.Click
        Me.Hide()
        Proveedores.Show()
        Proveedores.Refresh()
    End Sub

    Private Sub prod_Click(sender As Object, e As EventArgs) Handles prod.Click
        Me.Hide()
        Productos.Show()
        Productos.Refresh()
    End Sub

    Private Sub eve_Click(sender As Object, e As EventArgs) Handles eve.Click
        Me.Hide()
        Evento.Show()
        Evento.Refresh()
    End Sub

    Private Sub pve_Click(sender As Object, e As EventArgs) Handles pve.Click
        Me.Hide()
        PuntoV.Show()
        PuntoV.Refresh()
    End Sub

    Private Sub ven_Click(sender As Object, e As EventArgs) Handles ven.Click
        Me.Hide()
        Ventas.Show()
        Ventas.Refresh()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Login.Show()
        Login.Refresh()
    End Sub
End Class