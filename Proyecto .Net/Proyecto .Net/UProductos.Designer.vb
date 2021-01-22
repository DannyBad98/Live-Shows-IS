<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UProductos
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
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet23 = New Proyecto.Net.LIVESHOWSGROUPDataSet23()
        Me.PRODUCTOSTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet23TableAdapters.PRODUCTOSTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TALLAPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-191, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1140, 105)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(141, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 20)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPRODDataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn, Me.TALLAPRODDataGridViewTextBoxColumn, Me.DESCRPRODDataGridViewTextBoxColumn, Me.IDPROVDataGridViewTextBoxColumn, Me.CANTPRODDataGridViewTextBoxColumn, Me.COSTODataGridViewTextBoxColumn, Me.PRECIODataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.PRODUCTOSBindingSource
        Me.Datos.Location = New System.Drawing.Point(1, 106)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(934, 257)
        Me.Datos.TabIndex = 2
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet23
        '
        'LIVESHOWSGROUPDataSet23
        '
        Me.LIVESHOWSGROUPDataSet23.DataSetName = "LIVESHOWSGROUPDataSet23"
        Me.LIVESHOWSGROUPDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(710, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(405, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PRODUCTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(755, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BIENVENIDO"
        '
        'Button2
        '
        Me.Button2.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button2.Location = New System.Drawing.Point(861, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 42)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.Width = 50
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.Width = 200
        '
        'TALLAPRODDataGridViewTextBoxColumn
        '
        Me.TALLAPRODDataGridViewTextBoxColumn.DataPropertyName = "TALLA_PROD"
        Me.TALLAPRODDataGridViewTextBoxColumn.HeaderText = "TALLA"
        Me.TALLAPRODDataGridViewTextBoxColumn.Name = "TALLAPRODDataGridViewTextBoxColumn"
        Me.TALLAPRODDataGridViewTextBoxColumn.Width = 50
        '
        'DESCRPRODDataGridViewTextBoxColumn
        '
        Me.DESCRPRODDataGridViewTextBoxColumn.DataPropertyName = "DESCR_PROD"
        Me.DESCRPRODDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRPRODDataGridViewTextBoxColumn.Name = "DESCRPRODDataGridViewTextBoxColumn"
        Me.DESCRPRODDataGridViewTextBoxColumn.Width = 205
        '
        'IDPROVDataGridViewTextBoxColumn
        '
        Me.IDPROVDataGridViewTextBoxColumn.DataPropertyName = "ID_PROV"
        Me.IDPROVDataGridViewTextBoxColumn.HeaderText = "NOMBRE PROVEEDOR"
        Me.IDPROVDataGridViewTextBoxColumn.Name = "IDPROVDataGridViewTextBoxColumn"
        Me.IDPROVDataGridViewTextBoxColumn.Width = 80
        '
        'CANTPRODDataGridViewTextBoxColumn
        '
        Me.CANTPRODDataGridViewTextBoxColumn.DataPropertyName = "CANT_PROD"
        Me.CANTPRODDataGridViewTextBoxColumn.HeaderText = "CANTIDAD DISPONIBLE"
        Me.CANTPRODDataGridViewTextBoxColumn.Name = "CANTPRODDataGridViewTextBoxColumn"
        '
        'COSTODataGridViewTextBoxColumn
        '
        Me.COSTODataGridViewTextBoxColumn.DataPropertyName = "COSTO"
        Me.COSTODataGridViewTextBoxColumn.HeaderText = "COSTO"
        Me.COSTODataGridViewTextBoxColumn.Name = "COSTODataGridViewTextBoxColumn"
        '
        'PRECIODataGridViewTextBoxColumn
        '
        Me.PRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.Name = "PRECIODataGridViewTextBoxColumn"
        '
        'UProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(935, 363)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UProductos"
        Me.Text = "UProductos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Datos As DataGridView
    Friend WithEvents LIVESHOWSGROUPDataSet23 As LIVESHOWSGROUPDataSet23
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As LIVESHOWSGROUPDataSet23TableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TALLAPRODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRPRODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CANTPRODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COSTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
