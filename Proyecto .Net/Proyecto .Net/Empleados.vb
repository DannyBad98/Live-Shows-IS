
Imports System.Data.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SqlClient
Imports System.Windows

Public Class Empleados
    Public Sub ConsEMP()
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim cmd As New SqlCommand("SELECT * FROM EMPLEADOS", cn)
        cn.Open()
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        Datos.DataSource = dt
        cn.Close()
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet11.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet11.EMPLEADOS)
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_APE.Text = ""
        txt_TEL.Text = ""
        txt_CURP.Text = ""
        txt_CORREO.Text = ""
        txt_AE.Text = ""
        ConsEMP()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Try
            Dim adaptador As New SqlCommand("INSERT INTO EMPLEADOS VALUES (" & txt_ID.Text & ",'" & txt_NOM.Text & "','" & txt_APE.Text & "', '" & txt_TEL.Text & "',
                                            '" & txt_CURP.Text & "', '" & txt_CORREO.Text & "', " & txt_AE.Text & ")", cn)
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
        txt_APE.Text = ""
        txt_TEL.Text = ""
        txt_CURP.Text = ""
        txt_CORREO.Text = ""
        txt_AE.Text = ""



    End Sub

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged

    End Sub

    Private Sub txt_APE_TextChanged(sender As Object, e As EventArgs) Handles txt_APE.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        Try
            ConsEMP()
            Exit Try
        Catch
            Exit Try
        End Try


    End Sub

    Private Sub b_B_Click(sender As Object, e As EventArgs) Handles b_B.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador As New SqlDataAdapter("Select * from EMPLEADOS where ID_EMP = " & BUS.Text & "", cn)

            Dim ds As New DataSet
            adaptador.Fill(ds, "EMPLEADOS")

            If ds.Tables("EMPLEADOS").Rows.Count > 0 Then
                txt_ID.Text = ds.Tables("EMPLEADOS").Rows(0).Item(0).ToString
                txt_NOM.Text = ds.Tables("EMPLEADOS").Rows(0).Item(1).ToString
                txt_APE.Text = ds.Tables("EMPLEADOS").Rows(0).Item(2).ToString
                txt_TEL.Text = ds.Tables("EMPLEADOS").Rows(0).Item(3).ToString
                txt_CURP.Text = ds.Tables("EMPLEADOS").Rows(0).Item(4).ToString
                txt_CORREO.Text = ds.Tables("EMPLEADOS").Rows(0).Item(5).ToString
                txt_AE.Text = ds.Tables("EMPLEADOS").Rows(0).Item(6).ToString
            Else
                MsgBox("Usuario no encontrado")
            End If
            Exit Try
        Catch
            MsgBox("Error al buscar")
            Exit Try
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AMenu.Show()

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador As New SqlCommand("UPDATE EMPLEADOS SET NOM_EMP ='" & txt_NOM.Text & "',APE_EMP = '" & txt_APE.Text & "',TEL_EMP = '" & txt_TEL.Text & "',CURP_EMP = '" & txt_CURP.Text & "', CORREO_EMP = '" & txt_CORREO.Text & "',ADM_EMP = " & txt_AE.Text & " WHERE ID_EMP= " & txt_ID.Text & "", cn)
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
        txt_APE.Text = ""
        txt_TEL.Text = ""
        txt_CURP.Text = ""
        txt_CORREO.Text = ""
        txt_AE.Text = ""

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        Try
            Dim adaptador As New SqlCommand("DELETE FROM EMPLEADOS WHERE ID_EMP =" & txt_ID.Text & "", cn)
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
        txt_APE.Text = ""
        txt_TEL.Text = ""
        txt_CURP.Text = ""
        txt_CORREO.Text = ""
        txt_AE.Text = ""
        ConsEMP()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub txt_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ID.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Caracter no valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_NOM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NOM.KeyPress
        If Char.IsLetter(e.KeyChar) Then
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

    Private Sub txt_APE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_APE.KeyPress
        If Char.IsLetter(e.KeyChar) Then
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

    Private Sub txt_AE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_AE.KeyPress
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

    Private Sub txt_TEL_TextChanged(sender As Object, e As EventArgs) Handles txt_TEL.TextChanged

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

    Private Sub Datos_SelectionChanged(sender As Object, e As EventArgs) Handles Datos.SelectionChanged
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_APE.Text = ""
        txt_TEL.Text = ""
        txt_CURP.Text = ""
        txt_CORREO.Text = ""
        txt_AE.Text = ""
        Dim Fila As Integer
        Fila = Datos.CurrentRow.Index
        txt_ID.Text = Datos.Rows(Fila).Cells(0).Value.ToString
        txt_NOM.Text = Datos.Rows(Fila).Cells(1).Value.ToString
        txt_APE.Text = Datos.Rows(Fila).Cells(2).Value.ToString
        txt_TEL.Text = Datos.Rows(Fila).Cells(3).Value.ToString
        txt_CURP.Text = Datos.Rows(Fila).Cells(4).Value.ToString
        txt_CORREO.Text = Datos.Rows(Fila).Cells(5).Value.ToString
        txt_AE.Text = Datos.Rows(Fila).Cells(6).Value.ToString
    End Sub

    Private Sub BUS_TextChanged(sender As Object, e As EventArgs) Handles BUS.TextChanged

    End Sub

    Private Sub BUS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BUS.KeyPress
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 999999)
        txt_ID.Text = System.Convert.ToString(valorAleatorio)
        txt_NOM.Text = ""
        txt_APE.Text = ""
        txt_TEL.Text = ""
        txt_CURP.Text = ""
        txt_CORREO.Text = ""
        txt_AE.Text = ""
    End Sub
End Class