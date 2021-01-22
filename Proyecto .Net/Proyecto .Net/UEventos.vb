Imports System.Data.SqlClient
Public Class UEventos
    Private Sub UEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet25.EVENTO' Puede moverla o quitarla según sea necesario.
        Me.EVENTOTableAdapter.Fill(Me.LIVESHOWSGROUPDataSet25.EVENTO)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim cmd As New SqlCommand("SELECT * FROM EVENTO", cn)
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Datos.DataSource = dt
            cn.Close()
            Exit Try
        Catch
            Exit Try
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UMenu.Show()
    End Sub
End Class