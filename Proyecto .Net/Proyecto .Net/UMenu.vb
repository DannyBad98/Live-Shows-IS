Public Class UMenu
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub UMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        UProductos.Show()
        UProductos.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UPuntoV.Show()
        UPuntoV.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        UEventos.Show()
        UEventos.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        UVentas.Show()
        UVentas.Refresh()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Hide()
        Login.Show()
        Login.Refresh()
    End Sub
End Class