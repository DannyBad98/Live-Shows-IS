<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_FOL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_EVE = New System.Windows.Forms.ComboBox()
        Me.EVENTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet40 = New Proyecto.Net.LIVESHOWSGROUPDataSet40()
        Me.EVENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet27 = New Proyecto.Net.LIVESHOWSGROUPDataSet27()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_PUN = New System.Windows.Forms.ComboBox()
        Me.PUNTOVENTABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet41 = New Proyecto.Net.LIVESHOWSGROUPDataSet41()
        Me.PUNTOVENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet28 = New Proyecto.Net.LIVESHOWSGROUPDataSet28()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_PRO = New System.Windows.Forms.ComboBox()
        Me.PRODUCTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet48 = New Proyecto.Net.LIVESHOWSGROUPDataSet48()
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet29 = New Proyecto.Net.LIVESHOWSGROUPDataSet29()
        Me.txt_EMP = New System.Windows.Forms.ComboBox()
        Me.EMPLEADOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet39 = New Proyecto.Net.LIVESHOWSGROUPDataSet39()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet26 = New Proyecto.Net.LIVESHOWSGROUPDataSet26()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EMPLEADOSTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet26TableAdapters.EMPLEADOSTableAdapter()
        Me.EVENTOTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet27TableAdapters.EVENTOTableAdapter()
        Me.PUNTO_VENTATableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet28TableAdapters.PUNTO_VENTATableAdapter()
        Me.PRODUCTOSTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet29TableAdapters.PRODUCTOSTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_CAN = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_SUB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_TOT = New System.Windows.Forms.TextBox()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.FOLIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_EVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_PUNTOV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_PROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_EMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultarVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet31 = New Proyecto.Net.LIVESHOWSGROUPDataSet31()
        Me.LIVESHOWSGROUPDataSet30 = New Proyecto.Net.LIVESHOWSGROUPDataSet30()
        Me.VENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENTASTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet30TableAdapters.VENTASTableAdapter()
        Me.ConsultarVentasTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet31TableAdapters.ConsultarVentasTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EMPLEADOSTableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet39TableAdapters.EMPLEADOSTableAdapter()
        Me.EVENTOTableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet40TableAdapters.EVENTOTableAdapter()
        Me.PUNTO_VENTATableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet41TableAdapters.PUNTO_VENTATableAdapter()
        Me.LIVESHOWSGROUPDataSet42 = New Proyecto.Net.LIVESHOWSGROUPDataSet42()
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet42TableAdapters.PROVEEDORESTableAdapter()
        Me.PRODUCTOSTableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet48TableAdapters.PRODUCTOSTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUNTOVENTABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUNTOVENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultarVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-187, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1421, 101)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox2.Location = New System.Drawing.Point(139, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 45)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto.Net.My.Resources.Resources.ven
        Me.PictureBox3.Location = New System.Drawing.Point(35, 164)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(98, 89)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FOLIO :"
        '
        'txt_FOL
        '
        Me.txt_FOL.Enabled = False
        Me.txt_FOL.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FOL.Location = New System.Drawing.Point(162, 205)
        Me.txt_FOL.MaxLength = 6
        Me.txt_FOL.Name = "txt_FOL"
        Me.txt_FOL.Size = New System.Drawing.Size(65, 23)
        Me.txt_FOL.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "EVENTO :"
        '
        'txt_EVE
        '
        Me.txt_EVE.DataSource = Me.EVENTOBindingSource1
        Me.txt_EVE.DisplayMember = "NOM_EVE"
        Me.txt_EVE.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EVE.FormattingEnabled = True
        Me.txt_EVE.Location = New System.Drawing.Point(246, 205)
        Me.txt_EVE.Name = "txt_EVE"
        Me.txt_EVE.Size = New System.Drawing.Size(309, 23)
        Me.txt_EVE.TabIndex = 6
        Me.txt_EVE.ValueMember = "ID_EVE"
        '
        'EVENTOBindingSource1
        '
        Me.EVENTOBindingSource1.DataMember = "EVENTO"
        Me.EVENTOBindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet40
        '
        'LIVESHOWSGROUPDataSet40
        '
        Me.LIVESHOWSGROUPDataSet40.DataSetName = "LIVESHOWSGROUPDataSet40"
        Me.LIVESHOWSGROUPDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENTOBindingSource
        '
        Me.EVENTOBindingSource.DataMember = "EVENTO"
        Me.EVENTOBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet27
        '
        'LIVESHOWSGROUPDataSet27
        '
        Me.LIVESHOWSGROUPDataSet27.DataSetName = "LIVESHOWSGROUPDataSet27"
        Me.LIVESHOWSGROUPDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(579, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PUNTO DE VENTA :"
        '
        'txt_PUN
        '
        Me.txt_PUN.DataSource = Me.PUNTOVENTABindingSource1
        Me.txt_PUN.DisplayMember = "NOM_PUNTOV"
        Me.txt_PUN.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PUN.FormattingEnabled = True
        Me.txt_PUN.Location = New System.Drawing.Point(583, 205)
        Me.txt_PUN.Name = "txt_PUN"
        Me.txt_PUN.Size = New System.Drawing.Size(309, 23)
        Me.txt_PUN.TabIndex = 8
        Me.txt_PUN.ValueMember = "ID_PUNTOV"
        '
        'PUNTOVENTABindingSource1
        '
        Me.PUNTOVENTABindingSource1.DataMember = "PUNTO_VENTA"
        Me.PUNTOVENTABindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet41
        '
        'LIVESHOWSGROUPDataSet41
        '
        Me.LIVESHOWSGROUPDataSet41.DataSetName = "LIVESHOWSGROUPDataSet41"
        Me.LIVESHOWSGROUPDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUNTOVENTABindingSource
        '
        Me.PUNTOVENTABindingSource.DataMember = "PUNTO_VENTA"
        Me.PUNTOVENTABindingSource.DataSource = Me.LIVESHOWSGROUPDataSet28
        '
        'LIVESHOWSGROUPDataSet28
        '
        Me.LIVESHOWSGROUPDataSet28.DataSetName = "LIVESHOWSGROUPDataSet28"
        Me.LIVESHOWSGROUPDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(916, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PRODUCTO :"
        '
        'txt_PRO
        '
        Me.txt_PRO.DataSource = Me.PRODUCTOSBindingSource1
        Me.txt_PRO.DisplayMember = "NOM_PROD"
        Me.txt_PRO.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PRO.FormattingEnabled = True
        Me.txt_PRO.Location = New System.Drawing.Point(920, 205)
        Me.txt_PRO.Name = "txt_PRO"
        Me.txt_PRO.Size = New System.Drawing.Size(271, 23)
        Me.txt_PRO.TabIndex = 10
        Me.txt_PRO.ValueMember = "ID_PROD"
        '
        'PRODUCTOSBindingSource1
        '
        Me.PRODUCTOSBindingSource1.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet48
        '
        'LIVESHOWSGROUPDataSet48
        '
        Me.LIVESHOWSGROUPDataSet48.DataSetName = "LIVESHOWSGROUPDataSet48"
        Me.LIVESHOWSGROUPDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet29
        '
        'LIVESHOWSGROUPDataSet29
        '
        Me.LIVESHOWSGROUPDataSet29.DataSetName = "LIVESHOWSGROUPDataSet29"
        Me.LIVESHOWSGROUPDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_EMP
        '
        Me.txt_EMP.DataSource = Me.EMPLEADOSBindingSource1
        Me.txt_EMP.DisplayMember = "NOM_EMP"
        Me.txt_EMP.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EMP.FormattingEnabled = True
        Me.txt_EMP.Location = New System.Drawing.Point(162, 139)
        Me.txt_EMP.Name = "txt_EMP"
        Me.txt_EMP.Size = New System.Drawing.Size(180, 23)
        Me.txt_EMP.TabIndex = 11
        Me.txt_EMP.ValueMember = "ID_EMP"
        '
        'EMPLEADOSBindingSource1
        '
        Me.EMPLEADOSBindingSource1.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet39
        '
        'LIVESHOWSGROUPDataSet39
        '
        Me.LIVESHOWSGROUPDataSet39.DataSetName = "LIVESHOWSGROUPDataSet39"
        Me.LIVESHOWSGROUPDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet26
        '
        'LIVESHOWSGROUPDataSet26
        '
        Me.LIVESHOWSGROUPDataSet26.DataSetName = "LIVESHOWSGROUPDataSet26"
        Me.LIVESHOWSGROUPDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "EMPLEADO :"
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'EVENTOTableAdapter
        '
        Me.EVENTOTableAdapter.ClearBeforeFill = True
        '
        'PUNTO_VENTATableAdapter
        '
        Me.PUNTO_VENTATableAdapter.ClearBeforeFill = True
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(158, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CANTIDAD :"
        '
        'txt_CAN
        '
        Me.txt_CAN.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CAN.FormattingEnabled = True
        Me.txt_CAN.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.txt_CAN.Location = New System.Drawing.Point(162, 273)
        Me.txt_CAN.Name = "txt_CAN"
        Me.txt_CAN.Size = New System.Drawing.Size(91, 23)
        Me.txt_CAN.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(386, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "SUBTOTAL : $"
        '
        'txt_SUB
        '
        Me.txt_SUB.Enabled = False
        Me.txt_SUB.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SUB.Location = New System.Drawing.Point(343, 265)
        Me.txt_SUB.Name = "txt_SUB"
        Me.txt_SUB.Size = New System.Drawing.Size(182, 33)
        Me.txt_SUB.TabIndex = 16
        Me.txt_SUB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(681, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "IVA : $"
        '
        'txt_IVA
        '
        Me.txt_IVA.Enabled = False
        Me.txt_IVA.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.Location = New System.Drawing.Point(617, 263)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.Size = New System.Drawing.Size(182, 33)
        Me.txt_IVA.TabIndex = 18
        Me.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(946, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "TOTAL : $"
        '
        'txt_TOT
        '
        Me.txt_TOT.Enabled = False
        Me.txt_TOT.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOT.Location = New System.Drawing.Point(891, 263)
        Me.txt_TOT.Name = "txt_TOT"
        Me.txt_TOT.Size = New System.Drawing.Size(182, 33)
        Me.txt_TOT.TabIndex = 20
        Me.txt_TOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FOLIODataGridViewTextBoxColumn, Me.NOM_EVE, Me.NOM_PUNTOV, Me.NOM_PROD, Me.NOM_EMP, Me.CANTIDADDataGridViewTextBoxColumn, Me.SUBTOTALDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.ConsultarVentasBindingSource
        Me.Datos.Location = New System.Drawing.Point(0, 318)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(1234, 293)
        Me.Datos.TabIndex = 21
        '
        'FOLIODataGridViewTextBoxColumn
        '
        Me.FOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.Name = "FOLIODataGridViewTextBoxColumn"
        Me.FOLIODataGridViewTextBoxColumn.Width = 50
        '
        'NOM_EVE
        '
        Me.NOM_EVE.DataPropertyName = "NOM_EVE"
        Me.NOM_EVE.HeaderText = "EVENTO"
        Me.NOM_EVE.Name = "NOM_EVE"
        Me.NOM_EVE.Width = 170
        '
        'NOM_PUNTOV
        '
        Me.NOM_PUNTOV.DataPropertyName = "NOM_PUNTOV"
        Me.NOM_PUNTOV.HeaderText = "PUNTO DE VENTA"
        Me.NOM_PUNTOV.Name = "NOM_PUNTOV"
        Me.NOM_PUNTOV.Width = 200
        '
        'NOM_PROD
        '
        Me.NOM_PROD.DataPropertyName = "NOM_PROD"
        Me.NOM_PROD.HeaderText = "PRODUCTO"
        Me.NOM_PROD.Name = "NOM_PROD"
        Me.NOM_PROD.Width = 200
        '
        'NOM_EMP
        '
        Me.NOM_EMP.DataPropertyName = "NOM_EMP"
        Me.NOM_EMP.HeaderText = "EMPLEADO"
        Me.NOM_EMP.Name = "NOM_EMP"
        Me.NOM_EMP.Width = 150
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        '
        'SUBTOTALDataGridViewTextBoxColumn
        '
        Me.SUBTOTALDataGridViewTextBoxColumn.DataPropertyName = "SUBTOTAL"
        Me.SUBTOTALDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL"
        Me.SUBTOTALDataGridViewTextBoxColumn.Name = "SUBTOTALDataGridViewTextBoxColumn"
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        '
        'ConsultarVentasBindingSource
        '
        Me.ConsultarVentasBindingSource.DataMember = "ConsultarVentas"
        Me.ConsultarVentasBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet31
        '
        'LIVESHOWSGROUPDataSet31
        '
        Me.LIVESHOWSGROUPDataSet31.DataSetName = "LIVESHOWSGROUPDataSet31"
        Me.LIVESHOWSGROUPDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIVESHOWSGROUPDataSet30
        '
        Me.LIVESHOWSGROUPDataSet30.DataSetName = "LIVESHOWSGROUPDataSet30"
        Me.LIVESHOWSGROUPDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENTASBindingSource
        '
        Me.VENTASBindingSource.DataMember = "VENTAS"
        Me.VENTASBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet30
        '
        'VENTASTableAdapter
        '
        Me.VENTASTableAdapter.ClearBeforeFill = True
        '
        'ConsultarVentasTableAdapter
        '
        Me.ConsultarVentasTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(953, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 42)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "GENERAR VENTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button2.Location = New System.Drawing.Point(1136, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 41)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(561, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 29)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "VENTAS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(1080, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 29)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "BIENVENIDO"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(920, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EMPLEADOSTableAdapter1
        '
        Me.EMPLEADOSTableAdapter1.ClearBeforeFill = True
        '
        'EVENTOTableAdapter1
        '
        Me.EVENTOTableAdapter1.ClearBeforeFill = True
        '
        'PUNTO_VENTATableAdapter1
        '
        Me.PUNTO_VENTATableAdapter1.ClearBeforeFill = True
        '
        'LIVESHOWSGROUPDataSet42
        '
        Me.LIVESHOWSGROUPDataSet42.DataSetName = "LIVESHOWSGROUPDataSet42"
        Me.LIVESHOWSGROUPDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet42
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTOSTableAdapter1
        '
        Me.PRODUCTOSTableAdapter1.ClearBeforeFill = True
        '
        'UVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1234, 611)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.txt_TOT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_IVA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_SUB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_CAN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_EMP)
        Me.Controls.Add(Me.txt_PRO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_PUN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_EVE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_FOL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UVentas"
        Me.Text = "11"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUNTOVENTABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUNTOVENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultarVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_FOL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_EVE As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_PUN As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_PRO As ComboBox
    Friend WithEvents txt_EMP As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LIVESHOWSGROUPDataSet26 As LIVESHOWSGROUPDataSet26
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As LIVESHOWSGROUPDataSet26TableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet27 As LIVESHOWSGROUPDataSet27
    Friend WithEvents EVENTOBindingSource As BindingSource
    Friend WithEvents EVENTOTableAdapter As LIVESHOWSGROUPDataSet27TableAdapters.EVENTOTableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet28 As LIVESHOWSGROUPDataSet28
    Friend WithEvents PUNTOVENTABindingSource As BindingSource
    Friend WithEvents PUNTO_VENTATableAdapter As LIVESHOWSGROUPDataSet28TableAdapters.PUNTO_VENTATableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet29 As LIVESHOWSGROUPDataSet29
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As LIVESHOWSGROUPDataSet29TableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_CAN As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_SUB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_IVA As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_TOT As TextBox
    Friend WithEvents Datos As DataGridView
    Friend WithEvents LIVESHOWSGROUPDataSet30 As LIVESHOWSGROUPDataSet30
    Friend WithEvents VENTASBindingSource As BindingSource
    Friend WithEvents VENTASTableAdapter As LIVESHOWSGROUPDataSet30TableAdapters.VENTASTableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet31 As LIVESHOWSGROUPDataSet31
    Friend WithEvents ConsultarVentasBindingSource As BindingSource
    Friend WithEvents ConsultarVentasTableAdapter As LIVESHOWSGROUPDataSet31TableAdapters.ConsultarVentasTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FOLIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOM_EVE As DataGridViewTextBoxColumn
    Friend WithEvents NOM_PUNTOV As DataGridViewTextBoxColumn
    Friend WithEvents NOM_PROD As DataGridViewTextBoxColumn
    Friend WithEvents NOM_EMP As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents LIVESHOWSGROUPDataSet39 As LIVESHOWSGROUPDataSet39
    Friend WithEvents EMPLEADOSBindingSource1 As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter1 As LIVESHOWSGROUPDataSet39TableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet40 As LIVESHOWSGROUPDataSet40
    Friend WithEvents EVENTOBindingSource1 As BindingSource
    Friend WithEvents EVENTOTableAdapter1 As LIVESHOWSGROUPDataSet40TableAdapters.EVENTOTableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet41 As LIVESHOWSGROUPDataSet41
    Friend WithEvents PUNTOVENTABindingSource1 As BindingSource
    Friend WithEvents PUNTO_VENTATableAdapter1 As LIVESHOWSGROUPDataSet41TableAdapters.PUNTO_VENTATableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet42 As LIVESHOWSGROUPDataSet42
    Friend WithEvents PROVEEDORESBindingSource As BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As LIVESHOWSGROUPDataSet42TableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet48 As LIVESHOWSGROUPDataSet48
    Friend WithEvents PRODUCTOSBindingSource1 As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter1 As LIVESHOWSGROUPDataSet48TableAdapters.PRODUCTOSTableAdapter
End Class
