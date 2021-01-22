Imports System.Data.SqlClient
Public Class Ventas
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub ConsEMP()
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim cmd As New SqlCommand("SELECT        VENTAS.FOLIO, EVENTO.NOM_EVE, PUNTO_VENTA.NOM_PUNTOV, PRODUCTOS.NOM_PROD, EMPLEADOS.NOM_EMP, VENTAS.CANTIDAD, VENTAS.SUBTOTAL, VENTAS.IVA, VENTAS.TOTAL
	FROM          VENTAS INNER JOIN
                  EMPLEADOS ON VENTAS.ID_EMP = EMPLEADOS.ID_EMP INNER JOIN
                  EVENTO ON VENTAS.ID_EVE = EVENTO.ID_EVE INNER JOIN
                  PRODUCTOS ON VENTAS.ID_PROD = PRODUCTOS.ID_PROD INNER JOIN
                  PUNTO_VENTA ON VENTAS.ID_PUNTOV = PUNTO_VENTA.ID_PUNTOV", cn)
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
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet47.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet47.EMPLEADOS)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet46.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet46.PRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet45.PUNTO_VENTA' Puede moverla o quitarla según sea necesario.
        Me.PUNTO_VENTATableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet45.PUNTO_VENTA)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet44.EVENTO' Puede moverla o quitarla según sea necesario.
        Me.EVENTOTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet44.EVENTO)

        ConsEMP()
        txt_FOL.Text = ""
        txt_EVE.Text = ""
        txt_CAN.Text = ""
        txt_EMP.Text = ""
        txt_PRO.Text = ""
        txt_SUB.Text = ""
        txt_TOT.Text = ""
        txt_PUN.Text = ""
        txt_IVA.Text = ""
        b.Text = ""
    End Sub
    Public Sub UpdateCANTI()
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador As New SqlCommand("UPDATE PRODUCTOS SET CANT_PROD = ((CANT_PROD) - (" & txt_CAN.Text & ")) FROM PRODUCTOS INNER JOIN VENTAS ON PRODUCTOS.ID_PROD = VENTAS.ID_PROD WHERE FOLIO = '" & txt_FOL.Text & "' ", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Datos actualizados correctamente")
            ConsEMP()

            Exit Try
        Catch
            MsgBox("Error al actualizar")
            Exit Try
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try

            Dim adaptador As New SqlCommand("INSERT INTO VENTAS VALUES ('" & txt_FOL.Text & "'," & txt_EVE.SelectedValue & "," & txt_PUN.SelectedValue & ", " & txt_PRO.SelectedValue & ", " & txt_EMP.SelectedValue & ", " & txt_CAN.Text & ", " & txt_SUB.Text & "," & txt_IVA.Text & "," & txt_TOT.Text & ")", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Datos registrados correctamente")
            ConsEMP()
            UpdateCANTI()
            Exit Try
        Catch
            MsgBox("Error al agregar")
            Exit Try
        End Try
        txt_FOL.Text = ""
        txt_EVE.Text = ""
        txt_CAN.Text = ""
        txt_EMP.Text = ""
        txt_PRO.Text = ""
        txt_SUB.Text = ""
        txt_TOT.Text = ""
        txt_PUN.Text = ""
        txt_IVA.Text = ""


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

    Private Sub txt_PRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_PRO.SelectedIndexChanged
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador1 As New SqlCommand("SELECT PRECIO FROM PRODUCTOS  WHERE ID_PROD = " & txt_PRO.SelectedValue & "", cn)
            cn.Open()
            Dim valor = CInt(adaptador1.ExecuteScalar())
            Dim subtotal = valor * Val(txt_CAN.Text)
            txt_SUB.Text = valor * Val(txt_CAN.Text)
            txt_IVA.Text = Val(txt_SUB.Text) * 0.16
            txt_TOT.Text = Val(txt_SUB.Text) + Val(txt_IVA.Text)
            Exit Try
        Catch

            Exit Try
        End Try

    End Sub

    Private Sub txt_CAN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_CAN.SelectedIndexChanged
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador1 As New SqlCommand("SELECT PRECIO FROM PRODUCTOS  WHERE ID_PROD = " & txt_PRO.SelectedValue & "", cn)
            cn.Open()
            Dim valor = CInt(adaptador1.ExecuteScalar())
            Dim subtotal = valor * Val(txt_CAN.Text)
            txt_SUB.Text = valor * Val(txt_CAN.Text)
            txt_IVA.Text = Val(txt_SUB.Text) * 0.16
            txt_TOT.Text = Val(txt_SUB.Text) + Val(txt_IVA.Text)
            Exit Try
        Catch

            Exit Try
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Try
            Dim adaptador As New SqlCommand("UPDATE VENTAS SET ID_EVE ='" & txt_EVE.SelectedValue & "',ID_PUNTOV = '" & txt_PUN.SelectedValue & "',ID_PROD = '" & txt_PRO.SelectedValue & "',ID_EMP = " & txt_EMP.SelectedValue & ", CANTIDAD = " & txt_CAN.Text & ", SUBTOTAL = " & txt_SUB.Text & ", IVA = " & txt_SUB.Text & ", TOTAL = " & txt_TOT.Text & " WHERE FOLIO ='" & txt_FOL.Text & "'", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Datos actualizados correctamente")
            ConsEMP()
            Exit Try
        Catch
            MsgBox("Error al actualizar")
            Exit Try
        End Try
        txt_FOL.Text = ""
        txt_EVE.Text = ""
        txt_CAN.Text = ""
        txt_EMP.Text = ""
        txt_PRO.Text = ""
        txt_SUB.Text = ""
        txt_TOT.Text = ""
        txt_PUN.Text = ""
        txt_IVA.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()
        Try
            Dim adaptador As New SqlCommand("DELETE FROM VENTAS WHERE FOLIO ='" & txt_FOL.Text & "'", cn)
            adaptador.ExecuteNonQuery()
            MsgBox("Datos eliminados correctamente")
            cn.Close()
            Exit Try
        Catch
            MsgBox("Error al eliminar")
            Exit Try
        End Try
        txt_FOL.Text = ""
        txt_EVE.Text = ""
        txt_CAN.Text = ""
        txt_EMP.Text = ""
        txt_PRO.Text = ""
        txt_SUB.Text = ""
        txt_TOT.Text = ""
        txt_PUN.Text = ""
        txt_IVA.Text = ""
        ConsEMP()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-SUM2GF0H;Initial Catalog=LIVESHOWSGROUP;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("SELECT VENTAS.FOLIO, EVENTO.NOM_EVE, PUNTO_VENTA.NOM_PUNTOV, PRODUCTOS.NOM_PROD, EMPLEADOS.NOM_EMP, VENTAS.CANTIDAD, VENTAS.SUBTOTAL, VENTAS.IVA, VENTAS.TOTAL FROM PUNTO_VENTA INNER JOIN
         VENTAS ON PUNTO_VENTA.ID_PUNTOV = VENTAS.ID_PUNTOV INNER JOIN
         EMPLEADOS ON VENTAS.ID_EMP = EMPLEADOS.ID_EMP INNER JOIN
         PRODUCTOS ON VENTAS.ID_PROD = PRODUCTOS.ID_PROD INNER JOIN
         EVENTO ON VENTAS.ID_EVE = EVENTO.ID_EVE where FOLIO = '" & b.Text & "'", cn)

        Dim ds As New DataSet
        adaptador.Fill(ds, "VENTAS")

        If ds.Tables("VENTAS").Rows.Count > 0 Then
            txt_FOL.Text = ds.Tables("VENTAS").Rows(0).Item(0).ToString
            txt_EVE.Text = ds.Tables("VENTAS").Rows(0).Item(1).ToString
            txt_PUN.Text = ds.Tables("VENTAS").Rows(0).Item(2).ToString
            txt_PRO.Text = ds.Tables("VENTAS").Rows(0).Item(3).ToString
            txt_EMP.Text = ds.Tables("VENTAS").Rows(0).Item(4).ToString
            txt_CAN.Text = ds.Tables("VENTAS").Rows(0).Item(5).ToString
            txt_SUB.Text = ds.Tables("VENTAS").Rows(0).Item(6).ToString
            txt_IVA.Text = ds.Tables("VENTAS").Rows(0).Item(6).ToString
            txt_TOT.Text = ds.Tables("VENTAS").Rows(0).Item(7).ToString
        Else
            MsgBox("Usuario no encontrado")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        AMenu.Show()

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

    Private Sub txt_EMP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_EMP.KeyPress
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

    Private Sub b_KeyPress(sender As Object, e As KeyPressEventArgs) Handles b.KeyPress

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 999999)
        txt_FOL.Text = "VE" + System.Convert.ToString(valorAleatorio)
        txt_EVE.Text = ""
        txt_CAN.Text = ""
        txt_EMP.Text = ""
        txt_PRO.Text = ""
        txt_SUB.Text = ""
        txt_TOT.Text = ""
        txt_PUN.Text = ""
        txt_IVA.Text = ""
    End Sub
End Class