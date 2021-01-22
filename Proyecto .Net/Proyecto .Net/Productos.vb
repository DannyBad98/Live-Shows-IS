Imports System.Data.SqlClient
Imports System.Windows
Public Class Productos
    Private Sub Form_Activate()
        Me.Refresh()
    End Sub
    Public Sub ConsEMP()
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim cmd As New SqlCommand("SELECT * FROM PRODUCTOS", cn)
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

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet13.PROVEEDORES' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORESTableAdapter2.Fill(Me.LIVESHOWSGROUPDataSet13.PROVEEDORES)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet12.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet12.PRODUCTOS)
        Me.Refresh()
        txt_ID.Text = ""
        txt_NOM.Text = ""
        txt_TA.Text = ""
        txt_DES.Text = ""
        cb_PRO.Text = ""
        txt_CAN.Text = ""
        txt_COS.Text = ""
        txt_PRE.Text = ""
        ConsEMP()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        AMenu.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("SELECT PRODUCTOS.ID_PROD, PRODUCTOS.NOM_PROD, PRODUCTOS.TALLA_PROD, PRODUCTOS.DESCR_PROD, PROVEEDORES.NOM_PROV, PRODUCTOS.COSTO, PRODUCTOS.CANT_PROD, PRODUCTOS.PRECIO FROM PROVEEDORES INNER JOIN PRODUCTOS ON PROVEEDORES.ID_PROV = PRODUCTOS.ID_PROV where ID_PROD = " & b.Text & "", cn)

        Dim ds As New DataSet
        adaptador.Fill(ds, "PRODUCTOS")

        If ds.Tables("PRODUCTOS").Rows.Count > 0 Then
            txt_ID.Text = ds.Tables("PRODUCTOS").Rows(0).Item(0).ToString
            txt_NOM.Text = ds.Tables("PRODUCTOS").Rows(0).Item(1).ToString
            txt_TA.Text = ds.Tables("PRODUCTOS").Rows(0).Item(2).ToString
            txt_DES.Text = ds.Tables("PRODUCTOS").Rows(0).Item(3).ToString
            cb_PRO.Text = ds.Tables("PRODUCTOS").Rows(0).Item(4).ToString
            txt_CAN.Text = ds.Tables("PRODUCTOS").Rows(0).Item(5).ToString
            txt_COS.Text = ds.Tables("PRODUCTOS").Rows(0).Item(6).ToString
            txt_PRE.Text = ds.Tables("PRODUCTOS").Rows(0).Item(6).ToString
        Else
            MsgBox("Usuario no encontrado")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Try
            cb_PRO.ValueMember = "ID_PROV"
            Dim adaptador As New SqlCommand("INSERT INTO PRODUCTOS VALUES (" & txt_ID.Text & ",'" & txt_NOM.Text & "','" & txt_TA.Text & "', '" & txt_DES.Text & "', " & cb_PRO.SelectedValue & ", " & txt_CAN.Text & ", " & txt_COS.Text & "," & txt_PRE.Text & ")", cn)
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
        txt_TA.Text = ""
        txt_DES.Text = ""
        cb_PRO.Text = ""
        txt_CAN.Text = ""
        txt_COS.Text = ""
        txt_PRE.Text = ""
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador As New SqlCommand("UPDATE PRODUCTOS SET NOM_PROD ='" & txt_NOM.Text & "',TALLA_PROD = '" & txt_TA.Text & "',DESCR_PROD = '" & txt_DES.Text & "',ID_PROV = " & cb_PRO.SelectedValue & ", CANT_PROD = " & txt_CAN.Text & ", COSTO = " & txt_COS.Text & ", PRECIO = " & txt_PRE.Text & " WHERE ID_PROD= " & txt_ID.Text & "", cn)
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
        txt_TA.Text = ""
        txt_DES.Text = ""
        cb_PRO.Text = ""
        txt_CAN.Text = ""
        txt_COS.Text = ""
        txt_PRE.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()
        Try
            Dim adaptador As New SqlCommand("DELETE FROM PRODUCTOS WHERE ID_PROD =" & txt_ID.Text & "", cn)
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
        txt_TA.Text = ""
        txt_DES.Text = ""
        cb_PRO.Text = ""
        txt_CAN.Text = ""
        txt_COS.Text = ""
        txt_PRE.Text = ""
        ConsEMP()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PROVEEDORESTableAdapter1.FillBy(Me.LIVESHOWSGROUPDataSet4.PROVEEDORES)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cb_PRO_VisibleChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ConsEMP()
            Exit Try
        Catch
            Exit Try
        End Try
    End Sub

    Private Sub cb_PRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_PRO.SelectedIndexChanged

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

    Private Sub txt_TA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TA.KeyPress
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

    Private Sub cb_PRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_PRO.KeyPress

    End Sub

    Private Sub txt_CAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CAN.KeyPress
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

    Private Sub txt_COS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_COS.KeyPress
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

    Private Sub txt_PRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PRE.KeyPress
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
        txt_TA.Text = ""
        txt_DES.Text = ""
        cb_PRO.Text = ""
        txt_CAN.Text = ""
        txt_COS.Text = ""
        txt_PRE.Text = ""
        Dim Fila As Integer
        Fila = Datos.CurrentRow.Index
        txt_ID.Text = Datos.Rows(Fila).Cells(0).Value.ToString
        txt_NOM.Text = Datos.Rows(Fila).Cells(1).Value.ToString
        txt_TA.Text = Datos.Rows(Fila).Cells(2).Value.ToString
        txt_DES.Text = Datos.Rows(Fila).Cells(3).Value.ToString
        cb_PRO.Text = Datos.Rows(Fila).Cells(4).Value.ToString
        txt_CAN.Text = Datos.Rows(Fila).Cells(5).Value.ToString
        txt_COS.Text = Datos.Rows(Fila).Cells(6).Value.ToString
        txt_PRE.Text = Datos.Rows(Fila).Cells(7).Value.ToString
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

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 999999)
        txt_ID.Text = System.Convert.ToString(valorAleatorio)
        txt_NOM.Text = ""
        txt_TA.Text = ""
        txt_DES.Text = ""
        cb_PRO.Text = ""
        txt_CAN.Text = ""
        txt_COS.Text = ""
        txt_PRE.Text = ""
    End Sub
End Class