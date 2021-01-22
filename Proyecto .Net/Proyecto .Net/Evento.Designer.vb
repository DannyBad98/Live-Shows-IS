<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evento
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.b = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NOM = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.IDEVEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEVEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EVENTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet10 = New Proyecto.Net.LIVESHOWSGROUPDataSet10()
        Me.LIVESHOWSGROUPDataSet8 = New Proyecto.Net.LIVESHOWSGROUPDataSet8()
        Me.EVENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTOTableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet8TableAdapters.EVENTOTableAdapter()
        Me.EVENTOTableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet10TableAdapters.EVENTOTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(131, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 43)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-192, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1015, 99)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(471, 19)
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
        Me.Label2.Location = New System.Drawing.Point(710, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EVENTO"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto.Net.My.Resources.Resources.eve
        Me.PictureBox3.Location = New System.Drawing.Point(54, 134)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(98, 101)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'b
        '
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(624, 128)
        Me.b.MaxLength = 6
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(100, 22)
        Me.b.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto.Net.My.Resources.Resources.busa
        Me.Button1.Location = New System.Drawing.Point(730, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID_EVENTO :"
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(182, 213)
        Me.txt_ID.MaxLength = 6
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 22)
        Me.txt_ID.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NOMBRE EVENTO :"
        '
        'txt_NOM
        '
        Me.txt_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM.Location = New System.Drawing.Point(330, 213)
        Me.txt_NOM.MaxLength = 100
        Me.txt_NOM.Name = "txt_NOM"
        Me.txt_NOM.Size = New System.Drawing.Size(417, 22)
        Me.txt_NOM.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(79, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(235, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(528, 259)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(379, 259)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Modificar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button6.Location = New System.Drawing.Point(677, 252)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 36)
        Me.Button6.TabIndex = 15
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEVEDataGridViewTextBoxColumn, Me.NOMEVEDataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.EVENTOBindingSource1
        Me.Datos.Location = New System.Drawing.Point(39, 336)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(741, 181)
        Me.Datos.TabIndex = 16
        '
        'IDEVEDataGridViewTextBoxColumn
        '
        Me.IDEVEDataGridViewTextBoxColumn.DataPropertyName = "ID_EVE"
        Me.IDEVEDataGridViewTextBoxColumn.HeaderText = "ID_EVE"
        Me.IDEVEDataGridViewTextBoxColumn.Name = "IDEVEDataGridViewTextBoxColumn"
        Me.IDEVEDataGridViewTextBoxColumn.Width = 347
        '
        'NOMEVEDataGridViewTextBoxColumn
        '
        Me.NOMEVEDataGridViewTextBoxColumn.DataPropertyName = "NOM_EVE"
        Me.NOMEVEDataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL EVENTO"
        Me.NOMEVEDataGridViewTextBoxColumn.Name = "NOMEVEDataGridViewTextBoxColumn"
        Me.NOMEVEDataGridViewTextBoxColumn.Width = 350
        '
        'EVENTOBindingSource1
        '
        Me.EVENTOBindingSource1.DataMember = "EVENTO"
        Me.EVENTOBindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet10
        '
        'LIVESHOWSGROUPDataSet10
        '
        Me.LIVESHOWSGROUPDataSet10.DataSetName = "LIVESHOWSGROUPDataSet10"
        Me.LIVESHOWSGROUPDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIVESHOWSGROUPDataSet8
        '
        Me.LIVESHOWSGROUPDataSet8.DataSetName = "LIVESHOWSGROUPDataSet8"
        Me.LIVESHOWSGROUPDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENTOBindingSource
        '
        Me.EVENTOBindingSource.DataMember = "EVENTO"
        Me.EVENTOBindingSource.DataSource = Me.LIVESHOWSGROUPDataSet8
        '
        'EVENTOTableAdapter
        '
        Me.EVENTOTableAdapter.ClearBeforeFill = True
        '
        'EVENTOTableAdapter1
        '
        Me.EVENTOTableAdapter1.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "DATOS"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(598, 128)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(20, 23)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "+"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Evento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(815, 533)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_NOM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Evento"
        Me.Text = "Eventos"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents b As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_NOM As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Datos As DataGridView
    Friend WithEvents LIVESHOWSGROUPDataSet8 As LIVESHOWSGROUPDataSet8
    Friend WithEvents EVENTOBindingSource As BindingSource
    Friend WithEvents EVENTOTableAdapter As LIVESHOWSGROUPDataSet8TableAdapters.EVENTOTableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet10 As LIVESHOWSGROUPDataSet10
    Friend WithEvents EVENTOBindingSource1 As BindingSource
    Friend WithEvents EVENTOTableAdapter1 As LIVESHOWSGROUPDataSet10TableAdapters.EVENTOTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents IDEVEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEVEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button7 As Button
End Class
