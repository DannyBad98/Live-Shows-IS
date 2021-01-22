<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UEventos
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
        Me.EVENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet25 = New Proyecto.Net.LIVESHOWSGROUPDataSet25()
        Me.EVENTOTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet25TableAdapters.EVENTOTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDEVEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEVEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-190, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1134, 101)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox2.Location = New System.Drawing.Point(124, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 38)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEVEDataGridViewTextBoxColumn, Me.NOMEVEDataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.EVENTOBindingSource
        Me.Datos.Location = New System.Drawing.Point(0, 101)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(931, 262)
        Me.Datos.TabIndex = 2
        '
        'EVENTOBindingSource
        '
        Me.EVENTOBindingSource.DataMember = "EVENTO"
        Me.EVENTOBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet25
        '
        'LIVESHOWSGROUPDataSet25
        '
        Me.LIVESHOWSGROUPDataSet25.DataSetName = "LIVESHOWSGROUPDataSet25"
        Me.LIVESHOWSGROUPDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENTOTableAdapter
        '
        Me.EVENTOTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(411, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EVENTOS"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(716, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button2.Location = New System.Drawing.Point(867, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(753, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BIENVENIDOS"
        '
        'IDEVEDataGridViewTextBoxColumn
        '
        Me.IDEVEDataGridViewTextBoxColumn.DataPropertyName = "ID_EVE"
        Me.IDEVEDataGridViewTextBoxColumn.HeaderText = "ID_EVE"
        Me.IDEVEDataGridViewTextBoxColumn.Name = "IDEVEDataGridViewTextBoxColumn"
        Me.IDEVEDataGridViewTextBoxColumn.Width = 150
        '
        'NOMEVEDataGridViewTextBoxColumn
        '
        Me.NOMEVEDataGridViewTextBoxColumn.DataPropertyName = "NOM_EVE"
        Me.NOMEVEDataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL EVENTO"
        Me.NOMEVEDataGridViewTextBoxColumn.Name = "NOMEVEDataGridViewTextBoxColumn"
        Me.NOMEVEDataGridViewTextBoxColumn.Width = 730
        '
        'UEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(935, 380)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UEventos"
        Me.Text = "UEventos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Datos As DataGridView
    Friend WithEvents LIVESHOWSGROUPDataSet25 As LIVESHOWSGROUPDataSet25
    Friend WithEvents EVENTOBindingSource As BindingSource
    Friend WithEvents EVENTOTableAdapter As LIVESHOWSGROUPDataSet25TableAdapters.EVENTOTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IDEVEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEVEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
