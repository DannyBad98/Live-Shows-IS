<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPuntoV
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
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.PUNTOVENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet24 = New Proyecto.Net.LIVESHOWSGROUPDataSet24()
        Me.PUNTO_VENTATableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet24TableAdapters.PUNTO_VENTATableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDPUNTOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPUNTOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICACIÓNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUNTOVENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-196, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1144, 105)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.Color.White
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPUNTOVDataGridViewTextBoxColumn, Me.NOMPUNTOVDataGridViewTextBoxColumn, Me.UBICACIÓNDataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.PUNTOVENTABindingSource
        Me.Datos.Location = New System.Drawing.Point(0, 102)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(935, 261)
        Me.Datos.TabIndex = 1
        '
        'PUNTOVENTABindingSource
        '
        Me.PUNTOVENTABindingSource.DataMember = "PUNTO_VENTA"
        Me.PUNTOVENTABindingSource.DataSource = Me.LIVESHOWSGROUPDataSet24
        '
        'LIVESHOWSGROUPDataSet24
        '
        Me.LIVESHOWSGROUPDataSet24.DataSetName = "LIVESHOWSGROUPDataSet24"
        Me.LIVESHOWSGROUPDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUNTO_VENTATableAdapter
        '
        Me.PUNTO_VENTATableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox2.Location = New System.Drawing.Point(119, -18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 60)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(374, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PUNTO DE VENTA"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(711, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button2.Location = New System.Drawing.Point(864, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(755, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BIENVENIDOS"
        '
        'IDPUNTOVDataGridViewTextBoxColumn
        '
        Me.IDPUNTOVDataGridViewTextBoxColumn.DataPropertyName = "ID_PUNTOV"
        Me.IDPUNTOVDataGridViewTextBoxColumn.HeaderText = "ID_PUNTOV"
        Me.IDPUNTOVDataGridViewTextBoxColumn.Name = "IDPUNTOVDataGridViewTextBoxColumn"
        '
        'NOMPUNTOVDataGridViewTextBoxColumn
        '
        Me.NOMPUNTOVDataGridViewTextBoxColumn.DataPropertyName = "NOM_PUNTOV"
        Me.NOMPUNTOVDataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL PUNTO DE VENTA"
        Me.NOMPUNTOVDataGridViewTextBoxColumn.Name = "NOMPUNTOVDataGridViewTextBoxColumn"
        Me.NOMPUNTOVDataGridViewTextBoxColumn.Width = 350
        '
        'UBICACIÓNDataGridViewTextBoxColumn
        '
        Me.UBICACIÓNDataGridViewTextBoxColumn.DataPropertyName = "UBICACIÓN"
        Me.UBICACIÓNDataGridViewTextBoxColumn.HeaderText = "UBICACIÓN "
        Me.UBICACIÓNDataGridViewTextBoxColumn.Name = "UBICACIÓNDataGridViewTextBoxColumn"
        Me.UBICACIÓNDataGridViewTextBoxColumn.Width = 420
        '
        'UPuntoV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(935, 363)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UPuntoV"
        Me.Text = "UPunto de Venta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUNTOVENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Datos As DataGridView
    Friend WithEvents LIVESHOWSGROUPDataSet24 As LIVESHOWSGROUPDataSet24
    Friend WithEvents PUNTOVENTABindingSource As BindingSource
    Friend WithEvents PUNTO_VENTATableAdapter As LIVESHOWSGROUPDataSet24TableAdapters.PUNTO_VENTATableAdapter
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IDPUNTOVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMPUNTOVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UBICACIÓNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
