Imports System.Data.SqlClient
Public Class UVentas
    Dim folio
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
    Private Sub UVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet48.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet48.PRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet42.PROVEEDORES' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORESTableAdapter.Fill(Me.LIVESHOWSGROUPDataSet42.PROVEEDORES)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet41.PUNTO_VENTA' Puede moverla o quitarla según sea necesario.
        Me.PUNTO_VENTATableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet41.PUNTO_VENTA)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet40.EVENTO' Puede moverla o quitarla según sea necesario.
        Me.EVENTOTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet40.EVENTO)
        'TODO: esta línea de código carga datos en la tabla 'LIVESHOWSGROUPDataSet39.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter1.Fill(Me.LIVESHOWSGROUPDataSet39.EMPLEADOS)

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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UMenu.Show()
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
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub

    Private Sub ConsultarVentasBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ConsultarVentasBindingSource.CurrentChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 999999)
        txt_FOL.Text = "VE" + System.Convert.ToString(valorAleatorio)
    End Sub
End Class