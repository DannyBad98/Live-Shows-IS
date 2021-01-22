Imports System.Data.SqlClient
Imports System.Windows
Public Class PuntoV
    Private Sub PuntoV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet14.PUNTO_VENTA' Puede moverla o quitarla según sea necesario.
        Me.PUNTO_VENTATableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet14.PUNTO_VENTA)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet7.PUNTO_VENTA' Puede moverla o quitarla según sea necesario.
        Me.PUNTO_VENTATableAdapter.Fill(Me.LIVESHOWSGROUPDataSet7.PUNTO_VENTA)
        ConsEMP()
        txt_.Text = ""
        txt_NOM.Text = ""
        txt_UBI.Text = ""
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
    Public Sub ConsEMP()
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim cmd As New SqlCommand("SELECT * FROM PUNTO_VENTA", cn)
        cn.Open()
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        Datos.DataSource = dt
        cn.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        AMenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Try
            Dim adaptador As New SqlCommand("INSERT INTO PUNTO_VENTA VALUES (" & txt_.Text & ",'" & txt_NOM.Text & "','" & txt_UBI.Text & "')", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Datos registrados correctamente")
            ConsEMP()
            Exit Try
        Catch
            MsgBox("Error al agregar")
            Exit Try
        End Try
        txt_.Text = ""
        txt_NOM.Text = ""
        txt_UBI.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("Select * from PUNTO_VENTA where ID_PUNTOV = " & b.Text & "", cn)

        Dim ds As New DataSet
        adaptador.Fill(ds, "PUNTO_VENTA")

        If ds.Tables("PUNTO_VENTA").Rows.Count > 0 Then
            txt_.Text = ds.Tables("PUNTO_VENTA").Rows(0).Item(0).ToString
            txt_NOM.Text = ds.Tables("PUNTO_VENTA").Rows(0).Item(1).ToString
            txt_UBI.Text = ds.Tables("PUNTO_VENTA").Rows(0).Item(2).ToString
        Else
            MsgBox("Usuario no encontrado")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador As New SqlCommand("UPDATE PUNTO_VENTA SET NOM_PUNTOV ='" & txt_NOM.Text & "',UBICACIÓN = '" & txt_UBI.Text & "' WHERE ID_PUNTOV= " & txt_.Text & "", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Datos actualizados correctamente")
            ConsEMP()
            Exit Try
        Catch
            MsgBox("Error al actualizar")
            Exit Try
        End Try
        txt_.Text = ""
        txt_NOM.Text = ""
        txt_UBI.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()
        Try
            Dim adaptador As New SqlCommand("DELETE FROM PUNTO_VENTA WHERE ID_PUNTOV =" & txt_.Text & "", cn)
            adaptador.ExecuteNonQuery()
            MsgBox("Datos eliminados correctamente")
            cn.Close()
            Exit Try
        Catch
            MsgBox("Error al eliminar")
            Exit Try
        End Try
        txt_.Text = ""
        txt_NOM.Text = ""
        txt_UBI.Text = ""
        ConsEMP()
    End Sub

    Private Sub b_TextChanged(sender As Object, e As EventArgs) Handles b.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ConsEMP()
            Exit Try
        Catch
            Exit Try
        End Try
    End Sub

    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub

    Private Sub txt__KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Caracter no valido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub

    Private Sub b_KeyPress(sender As Object, e As KeyPressEventArgs) Handles b.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Caracter no valido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub

    Private Sub Datos_SelectionChanged(sender As Object, e As EventArgs) Handles Datos.SelectionChanged
        txt_.Text = ""
        txt_NOM.Text = ""
        txt_UBI.Text = ""
        Dim Fila As Integer
        Fila = Datos.CurrentRow.Index
        txt_.Text = Datos.Rows(Fila).Cells(0).Value.ToString
        txt_NOM.Text = Datos.Rows(Fila).Cells(1).Value.ToString
        txt_UBI.Text = Datos.Rows(Fila).Cells(2).Value.ToString
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 999999)
        txt_.Text = System.Convert.ToString(valorAleatorio)
        txt_NOM.Text = ""
        txt_UBI.Text = ""
    End Sub
End Class