<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LIVESHOWSGROUPDataSet1 = New Proyecto.Net.LIVESHOWSGROUPDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.IDEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APEEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURPEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREOEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADMEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLEADOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet11 = New Proyecto.Net.LIVESHOWSGROUPDataSet11()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOSTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet1TableAdapters.EMPLEADOSTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_NOM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_APE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_TEL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_CURP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_CORREO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_AE = New System.Windows.Forms.TextBox()
        Me.BUS = New System.Windows.Forms.TextBox()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Consultar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.b_B = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EMPLEADOSTableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet11TableAdapters.EMPLEADOSTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.LIVESHOWSGROUPDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(658, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "EMPLEADOS"
        '
        'LIVESHOWSGROUPDataSet1
        '
        Me.LIVESHOWSGROUPDataSet1.DataSetName = "LIVESHOWSGROUPDataSet1"
        Me.LIVESHOWSGROUPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(466, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BIENVENIDO, ADMINISTRADOR"
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEMPDataGridViewTextBoxColumn, Me.NOMEMPDataGridViewTextBoxColumn, Me.APEEMPDataGridViewTextBoxColumn, Me.TELEMPDataGridViewTextBoxColumn, Me.CURPEMPDataGridViewTextBoxColumn, Me.CORREOEMPDataGridViewTextBoxColumn, Me.ADMEMPDataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.EMPLEADOSBindingSource1
        Me.Datos.Location = New System.Drawing.Point(34, 393)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(743, 175)
        Me.Datos.TabIndex = 7
        '
        'IDEMPDataGridViewTextBoxColumn
        '
        Me.IDEMPDataGridViewTextBoxColumn.DataPropertyName = "ID_EMP"
        Me.IDEMPDataGridViewTextBoxColumn.HeaderText = "ID_EMP"
        Me.IDEMPDataGridViewTextBoxColumn.Name = "IDEMPDataGridViewTextBoxColumn"
        '
        'NOMEMPDataGridViewTextBoxColumn
        '
        Me.NOMEMPDataGridViewTextBoxColumn.DataPropertyName = "NOM_EMP"
        Me.NOMEMPDataGridViewTextBoxColumn.HeaderText = "NOMBRE (S)"
        Me.NOMEMPDataGridViewTextBoxColumn.Name = "NOMEMPDataGridViewTextBoxColumn"
        '
        'APEEMPDataGridViewTextBoxColumn
        '
        Me.APEEMPDataGridViewTextBoxColumn.DataPropertyName = "APE_EMP"
        Me.APEEMPDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APEEMPDataGridViewTextBoxColumn.Name = "APEEMPDataGridViewTextBoxColumn"
        '
        'TELEMPDataGridViewTextBoxColumn
        '
        Me.TELEMPDataGridViewTextBoxColumn.DataPropertyName = "TEL_EMP"
        Me.TELEMPDataGridViewTextBoxColumn.HeaderText = "TELEFONO"
        Me.TELEMPDataGridViewTextBoxColumn.Name = "TELEMPDataGridViewTextBoxColumn"
        '
        'CURPEMPDataGridViewTextBoxColumn
        '
        Me.CURPEMPDataGridViewTextBoxColumn.DataPropertyName = "CURP_EMP"
        Me.CURPEMPDataGridViewTextBoxColumn.HeaderText = "CURP"
        Me.CURPEMPDataGridViewTextBoxColumn.Name = "CURPEMPDataGridViewTextBoxColumn"
        '
        'CORREOEMPDataGridViewTextBoxColumn
        '
        Me.CORREOEMPDataGridViewTextBoxColumn.DataPropertyName = "CORREO_EMP"
        Me.CORREOEMPDataGridViewTextBoxColumn.HeaderText = "CORREO"
        Me.CORREOEMPDataGridViewTextBoxColumn.Name = "CORREOEMPDataGridViewTextBoxColumn"
        '
        'ADMEMPDataGridViewTextBoxColumn
        '
        Me.ADMEMPDataGridViewTextBoxColumn.DataPropertyName = "ADM_EMP"
        Me.ADMEMPDataGridViewTextBoxColumn.HeaderText = "ADM_EMP"
        Me.ADMEMPDataGridViewTextBoxColumn.Name = "ADMEMPDataGridViewTextBoxColumn"
        '
        'EMPLEADOSBindingSource1
        '
        Me.EMPLEADOSBindingSource1.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet11
        '
        'LIVESHOWSGROUPDataSet11
        '
        Me.LIVESHOWSGROUPDataSet11.DataSetName = "LIVESHOWSGROUPDataSet11"
        Me.LIVESHOWSGROUPDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet1
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DATOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ID_EMP :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NOMBRE :"
        '
        'txt_ID
        '
        Me.txt_ID.Enabled = False
        Me.txt_ID.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(189, 199)
        Me.txt_ID.MaxLength = 6
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 23)
        Me.txt_ID.TabIndex = 11
        '
        'txt_NOM
        '
        Me.txt_NOM.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM.Location = New System.Drawing.Point(342, 199)
        Me.txt_NOM.MaxLength = 60
        Me.txt_NOM.Name = "txt_NOM"
        Me.txt_NOM.Size = New System.Drawing.Size(178, 23)
        Me.txt_NOM.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "APELLIDO :"
        '
        'txt_APE
        '
        Me.txt_APE.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_APE.Location = New System.Drawing.Point(568, 199)
        Me.txt_APE.MaxLength = 60
        Me.txt_APE.Name = "txt_APE"
        Me.txt_APE.Size = New System.Drawing.Size(178, 23)
        Me.txt_APE.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "TELEFONO :"
        '
        'txt_TEL
        '
        Me.txt_TEL.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TEL.Location = New System.Drawing.Point(51, 260)
        Me.txt_TEL.MaxLength = 10
        Me.txt_TEL.Name = "txt_TEL"
        Me.txt_TEL.Size = New System.Drawing.Size(118, 23)
        Me.txt_TEL.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(217, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "CURP :"
        '
        'txt_CURP
        '
        Me.txt_CURP.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CURP.Location = New System.Drawing.Point(220, 260)
        Me.txt_CURP.MaxLength = 25
        Me.txt_CURP.Name = "txt_CURP"
        Me.txt_CURP.Size = New System.Drawing.Size(161, 23)
        Me.txt_CURP.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(423, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "CORREO :"
        '
        'txt_CORREO
        '
        Me.txt_CORREO.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CORREO.Location = New System.Drawing.Point(426, 260)
        Me.txt_CORREO.MaxLength = 70
        Me.txt_CORREO.Name = "txt_CORREO"
        Me.txt_CORREO.Size = New System.Drawing.Size(175, 23)
        Me.txt_CORREO.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(644, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "ADM_EMP :"
        '
        'txt_AE
        '
        Me.txt_AE.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AE.Location = New System.Drawing.Point(647, 260)
        Me.txt_AE.MaxLength = 1
        Me.txt_AE.Name = "txt_AE"
        Me.txt_AE.Size = New System.Drawing.Size(99, 23)
        Me.txt_AE.TabIndex = 23
        '
        'BUS
        '
        Me.BUS.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUS.Location = New System.Drawing.Point(619, 125)
        Me.BUS.MaxLength = 6
        Me.BUS.Name = "BUS"
        Me.BUS.Size = New System.Drawing.Size(100, 23)
        Me.BUS.TabIndex = 24
        '
        'Agregar
        '
        Me.Agregar.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.Location = New System.Drawing.Point(83, 318)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 26
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Consultar
        '
        Me.Consultar.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultar.Location = New System.Drawing.Point(236, 318)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(75, 23)
        Me.Consultar.TabIndex = 27
        Me.Consultar.Text = "Consultar"
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(529, 318)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 28
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.Location = New System.Drawing.Point(381, 318)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Modificar.TabIndex = 29
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button1.Location = New System.Drawing.Point(675, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 33)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'b_B
        '
        Me.b_B.Image = Global.Proyecto.Net.My.Resources.Resources.busa
        Me.b_B.Location = New System.Drawing.Point(725, 118)
        Me.b_B.Name = "b_B"
        Me.b_B.Size = New System.Drawing.Size(35, 36)
        Me.b_B.TabIndex = 25
        Me.b_B.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto.Net.My.Resources.Resources.empleados
        Me.PictureBox3.Location = New System.Drawing.Point(52, 125)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(105, 95)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(117, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 31)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-204, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1047, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'EMPLEADOSTableAdapter1
        '
        Me.EMPLEADOSTableAdapter1.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(592, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(809, 590)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.b_B)
        Me.Controls.Add(Me.BUS)
        Me.Controls.Add(Me.txt_AE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_CORREO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_CURP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_TEL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_APE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txt_NOM)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.LIVESHOWSGROUPDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LIVESHOWSGROUPDataSet1 As LIVESHOWSGROUPDataSet1
    Friend WithEvents Label1 As Label
    Friend WithEvents Datos As DataGridView
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As LIVESHOWSGROUPDataSet1TableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents txt_NOM As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_APE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_TEL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_CURP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_CORREO As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_AE As TextBox
    Friend WithEvents BUS As TextBox
    Friend WithEvents b_B As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Consultar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LIVESHOWSGROUPDataSet11 As LIVESHOWSGROUPDataSet11
    Friend WithEvents EMPLEADOSBindingSource1 As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter1 As LIVESHOWSGROUPDataSet11TableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents IDEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APEEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CURPEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CORREOEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADMEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
