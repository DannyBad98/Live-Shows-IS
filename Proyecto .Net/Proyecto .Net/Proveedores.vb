Imports System.Data.SqlClient
Imports System.Windows
Public Class Proveedores

    Public Sub ConsEMP()
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim cmd As New SqlCommand("SELECT * FROM PROVEEDORES", cn)
        cn.Open()
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        Datos.DataSource = dt
        cn.Close()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

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
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet43.PROVEEDORES' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORESTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet43.PROVEEDORES)
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_DIR.Text = ""
        txt_TEL.Text = ""
        ConsEMP()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        AMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Try
            Dim adaptador As New SqlCommand("INSERT INTO PROVEEDORES VALUES (" & txt_ID.Text & ",'" & txt_NOM.Text & "','" & txt_TEL.Text & "', '" & txt_DIR.Text & "')", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Datos registrados correctamente")
            ConsEMP()
            Exit Try
        Catch
            MsgBox("Error al agregar")
            Exit Try
        End Try
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_DIR.Text = ""
        txt_TEL.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador As New SqlCommand("UPDATE PROVEEDORES SET NOM_PROV ='" & txt_NOM.Text & "',TEL_PROV = '" & txt_TEL.Text & "',DIR_PROV = '" & txt_DIR.Text & "' WHERE ID_PROV= " & txt_ID.Text & "", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Datos actualizados correctamente")
            ConsEMP()
            Exit Try
        Catch
            MsgBox("Error al actualizar")
            Exit Try
        End Try
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_TEL.Text = ""
        txt_DIR.Text = ""

    End Sub

    Private Sub bus_Click(sender As Object, e As EventArgs) Handles bus.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("Select * from PROVEEDORES where ID_PROV = " & b.Text & "", cn)

        Dim ds As New DataSet
        adaptador.Fill(ds, "PROVEEDORES")

        If ds.Tables("PROVEEDORES").Rows.Count > 0 Then
            txt_ID.Text = ds.Tables("PROVEEDORES").Rows(0).Item(0).ToString
            txt_NOM.Text = ds.Tables("PROVEEDORES").Rows(0).Item(1).ToString
            txt_TEL.Text = ds.Tables("PROVEEDORES").Rows(0).Item(2).ToString
            txt_DIR.Text = ds.Tables("PROVEEDORES").Rows(0).Item(3).ToString
        Else
            MsgBox("Usuario no encontrado")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()
        Try
            Dim adaptador As New SqlCommand("DELETE FROM PROVEEDORES WHERE ID_PROV =" & txt_ID.Text & "", cn)
            adaptador.ExecuteNonQuery()
            MsgBox("Datos eliminados correctamente")
            cn.Close()
            Exit Try
        Catch
            MsgBox("Error al eliminar")
            Exit Try
        End Try
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_TEL.Text = ""
        txt_DIR.Text = ""
        ConsEMP()
    End Sub

    Private Sub b_TextChanged(sender As Object, e As EventArgs) Handles b.TextChanged
        ConsEMP()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ConsEMP()
            Exit Try
        Catch
            Exit Try
        End Try
    End Sub

    Private Sub txt_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ID.KeyPress
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

    Private Sub txt_TEL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TEL.KeyPress
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
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_TEL.Text = ""
        txt_DIR.Text = ""
        Dim Fila As Integer
        Fila = Datos.CurrentRow.Index
        txt_ID.Text = Datos.Rows(Fila).Cells(0).Value.ToString
        txt_NOM.Text = Datos.Rows(Fila).Cells(1).Value.ToString
        txt_TEL.Text = Datos.Rows(Fila).Cells(2).Value.ToString
        txt_DIR.Text = Datos.Rows(Fila).Cells(3).Value.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 999999)
        txt_ID.Text = System.Convert.ToString(valorAleatorio)
        txt_NOM.Text = ""
        txt_TEL.Text = ""
        txt_DIR.Text = ""
    End Sub
End Class