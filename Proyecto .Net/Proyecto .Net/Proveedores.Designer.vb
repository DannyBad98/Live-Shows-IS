<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proveedores
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.b = New System.Windows.Forms.TextBox()
        Me.bus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_NOM = New System.Windows.Forms.TextBox()
        Me.txt_TEL = New System.Windows.Forms.TextBox()
        Me.txt_DIR = New System.Windows.Forms.TextBox()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.IDPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet2 = New Proyecto.Net.LIVESHOWSGROUPDataSet2()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PROVEEDORESTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet2TableAdapters.PROVEEDORESTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LIVESHOWSGROUPDataSet43 = New Proyecto.Net.LIVESHOWSGROUPDataSet43()
        Me.PROVEEDORESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESTableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet43TableAdapters.PROVEEDORESTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-195, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1031, 99)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(130, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 35)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(459, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BIENVENIDO, ADMINISTRADOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(625, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PROVEEDORES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(463, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(340, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BIENVENIDO, ADMINISTRADOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(629, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PROVEEDORES"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto.Net.My.Resources.Resources.prov
        Me.PictureBox3.Location = New System.Drawing.Point(51, 128)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 100)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'b
        '
        Me.b.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(619, 128)
        Me.b.MaxLength = 6
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(100, 23)
        Me.b.TabIndex = 5
        '
        'bus
        '
        Me.bus.Image = Global.Proyecto.Net.My.Resources.Resources.busa
        Me.bus.Location = New System.Drawing.Point(725, 122)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(33, 32)
        Me.bus.TabIndex = 6
        Me.bus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(234, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ID_PROV :"
        '
        'txt_ID
        '
        Me.txt_ID.Enabled = False
        Me.txt_ID.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(237, 205)
        Me.txt_ID.MaxLength = 6
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 23)
        Me.txt_ID.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(408, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "NOMBRE :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "TELEFONO :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(278, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "DIRECCION :"
        '
        'txt_NOM
        '
        Me.txt_NOM.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM.Location = New System.Drawing.Point(411, 205)
        Me.txt_NOM.MaxLength = 60
        Me.txt_NOM.Name = "txt_NOM"
        Me.txt_NOM.Size = New System.Drawing.Size(322, 23)
        Me.txt_NOM.TabIndex = 13
        '
        'txt_TEL
        '
        Me.txt_TEL.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TEL.Location = New System.Drawing.Point(101, 270)
        Me.txt_TEL.MaxLength = 10
        Me.txt_TEL.Name = "txt_TEL"
        Me.txt_TEL.Size = New System.Drawing.Size(100, 23)
        Me.txt_TEL.TabIndex = 14
        '
        'txt_DIR
        '
        Me.txt_DIR.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DIR.Location = New System.Drawing.Point(281, 270)
        Me.txt_DIR.MaxLength = 60
        Me.txt_DIR.Name = "txt_DIR"
        Me.txt_DIR.Size = New System.Drawing.Size(398, 23)
        Me.txt_DIR.TabIndex = 15
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPROVDataGridViewTextBoxColumn, Me.NOMPROVDataGridViewTextBoxColumn, Me.TELPROVDataGridViewTextBoxColumn, Me.DIRPROVDataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.PROVEEDORESBindingSource1
        Me.Datos.Location = New System.Drawing.Point(37, 390)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(739, 181)
        Me.Datos.TabIndex = 16
        '
        'IDPROVDataGridViewTextBoxColumn
        '
        Me.IDPROVDataGridViewTextBoxColumn.DataPropertyName = "ID_PROV"
        Me.IDPROVDataGridViewTextBoxColumn.HeaderText = "ID_PROV"
        Me.IDPROVDataGridViewTextBoxColumn.Name = "IDPROVDataGridViewTextBoxColumn"
        '
        'NOMPROVDataGridViewTextBoxColumn
        '
        Me.NOMPROVDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROV"
        Me.NOMPROVDataGridViewTextBoxColumn.HeaderText = "NOMBRE DE PROVEEDOR"
        Me.NOMPROVDataGridViewTextBoxColumn.Name = "NOMPROVDataGridViewTextBoxColumn"
        Me.NOMPROVDataGridViewTextBoxColumn.Width = 198
        '
        'TELPROVDataGridViewTextBoxColumn
        '
        Me.TELPROVDataGridViewTextBoxColumn.DataPropertyName = "TEL_PROV"
        Me.TELPROVDataGridViewTextBoxColumn.HeaderText = "TELEFONO PROVEEDOR"
        Me.TELPROVDataGridViewTextBoxColumn.Name = "TELPROVDataGridViewTextBoxColumn"
        Me.TELPROVDataGridViewTextBoxColumn.Width = 198
        '
        'DIRPROVDataGridViewTextBoxColumn
        '
        Me.DIRPROVDataGridViewTextBoxColumn.DataPropertyName = "DIR_PROV"
        Me.DIRPROVDataGridViewTextBoxColumn.HeaderText = "DIRECCION PROVEEDOR"
        Me.DIRPROVDataGridViewTextBoxColumn.Name = "DIRPROVDataGridViewTextBoxColumn"
        Me.DIRPROVDataGridViewTextBoxColumn.Width = 200
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet2
        '
        'LIVESHOWSGROUPDataSet2
        '
        Me.LIVESHOWSGROUPDataSet2.DataSetName = "LIVESHOWSGROUPDataSet2"
        Me.LIVESHOWSGROUPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(84, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 23)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "DATOS"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(237, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(379, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(530, 322)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button5.Location = New System.Drawing.Point(681, 313)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 40)
        Me.Button5.TabIndex = 22
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(592, 127)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(21, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "+"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LIVESHOWSGROUPDataSet43
        '
        Me.LIVESHOWSGROUPDataSet43.DataSetName = "LIVESHOWSGROUPDataSet43"
        Me.LIVESHOWSGROUPDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROVEEDORESBindingSource1
        '
        Me.PROVEEDORESBindingSource1.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet43
        '
        'PROVEEDORESTableAdapter1
        '
        Me.PROVEEDORESTableAdapter1.ClearBeforeFill = True
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(811, 594)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.txt_DIR)
        Me.Controls.Add(Me.txt_TEL)
        Me.Controls.Add(Me.txt_NOM)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bus)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents b As TextBox
    Friend WithEvents bus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_NOM As TextBox
    Friend WithEvents txt_TEL As TextBox
    Friend WithEvents txt_DIR As TextBox
    Friend WithEvents Datos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents LIVESHOWSGROUPDataSet2 As LIVESHOWSGROUPDataSet2
    Friend WithEvents PROVEEDORESBindingSource As BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As LIVESHOWSGROUPDataSet2TableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents IDPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIRPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents LIVESHOWSGROUPDataSet43 As LIVESHOWSGROUPDataSet43
    Friend WithEvents PROVEEDORESBindingSource1 As BindingSource
    Friend WithEvents PROVEEDORESTableAdapter1 As LIVESHOWSGROUPDataSet43TableAdapters.PROVEEDORESTableAdapter
End Class
