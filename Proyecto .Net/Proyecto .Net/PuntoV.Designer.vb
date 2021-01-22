<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuntoV
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.b = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NOM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_UBI = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.IDPUNTOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPUNTOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICACIÓNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUNTOVENTABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet14 = New Proyecto.Net.LIVESHOWSGROUPDataSet14()
        Me.PUNTOVENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESHOWSGROUPDataSet7 = New Proyecto.Net.LIVESHOWSGROUPDataSet7()
        Me.PUNTO_VENTATableAdapter = New Proyecto.Net.LIVESHOWSGROUPDataSet7TableAdapters.PUNTO_VENTATableAdapter()
        Me.PUNTO_VENTATableAdapter1 = New Proyecto.Net.LIVESHOWSGROUPDataSet14TableAdapters.PUNTO_VENTATableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUNTOVENTABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUNTOVENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESHOWSGROUPDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-196, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1005, 98)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox2.Location = New System.Drawing.Point(130, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 43)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(463, 18)
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
        Me.Label2.Location = New System.Drawing.Point(604, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PUNTO DE VENTA"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto.Net.My.Resources.Resources.pve
        Me.PictureBox3.Location = New System.Drawing.Point(49, 128)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(97, 92)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto.Net.My.Resources.Resources.busa
        Me.Button1.Location = New System.Drawing.Point(724, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'b
        '
        Me.b.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(618, 128)
        Me.b.MaxLength = 6
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(100, 23)
        Me.b.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID_PUNTOV :"
        '
        'txt_
        '
        Me.txt_.Enabled = False
        Me.txt_.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_.Location = New System.Drawing.Point(174, 197)
        Me.txt_.MaxLength = 6
        Me.txt_.Name = "txt_"
        Me.txt_.Size = New System.Drawing.Size(100, 23)
        Me.txt_.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(315, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NOMBRE PV :"
        '
        'txt_NOM
        '
        Me.txt_NOM.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM.Location = New System.Drawing.Point(318, 197)
        Me.txt_NOM.MaxLength = 50
        Me.txt_NOM.Name = "txt_NOM"
        Me.txt_NOM.Size = New System.Drawing.Size(100, 23)
        Me.txt_NOM.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "UBICACION :"
        '
        'txt_UBI
        '
        Me.txt_UBI.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UBI.Location = New System.Drawing.Point(458, 197)
        Me.txt_UBI.MaxLength = 50
        Me.txt_UBI.Name = "txt_UBI"
        Me.txt_UBI.Size = New System.Drawing.Size(301, 23)
        Me.txt_UBI.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(81, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(235, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(379, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(531, 248)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.Proyecto.Net.My.Resources.Resources.Menu
        Me.Button6.Location = New System.Drawing.Point(678, 239)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 17
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Datos
        '
        Me.Datos.AutoGenerateColumns = False
        Me.Datos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPUNTOVDataGridViewTextBoxColumn, Me.NOMPUNTOVDataGridViewTextBoxColumn, Me.UBICACIÓNDataGridViewTextBoxColumn})
        Me.Datos.DataSource = Me.PUNTOVENTABindingSource1
        Me.Datos.Location = New System.Drawing.Point(26, 331)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(747, 171)
        Me.Datos.TabIndex = 18
        '
        'IDPUNTOVDataGridViewTextBoxColumn
        '
        Me.IDPUNTOVDataGridViewTextBoxColumn.DataPropertyName = "ID_PUNTOV"
        Me.IDPUNTOVDataGridViewTextBoxColumn.HeaderText = "ID_PUNTOV"
        Me.IDPUNTOVDataGridViewTextBoxColumn.Name = "IDPUNTOVDataGridViewTextBoxColumn"
        Me.IDPUNTOVDataGridViewTextBoxColumn.Width = 150
        '
        'NOMPUNTOVDataGridViewTextBoxColumn
        '
        Me.NOMPUNTOVDataGridViewTextBoxColumn.DataPropertyName = "NOM_PUNTOV"
        Me.NOMPUNTOVDataGridViewTextBoxColumn.HeaderText = "NOMBRE DE PUNTO DE VENTA"
        Me.NOMPUNTOVDataGridViewTextBoxColumn.Name = "NOMPUNTOVDataGridViewTextBoxColumn"
        Me.NOMPUNTOVDataGridViewTextBoxColumn.Width = 250
        '
        'UBICACIÓNDataGridViewTextBoxColumn
        '
        Me.UBICACIÓNDataGridViewTextBoxColumn.DataPropertyName = "UBICACIÓN"
        Me.UBICACIÓNDataGridViewTextBoxColumn.HeaderText = "UBICACIÓN"
        Me.UBICACIÓNDataGridViewTextBoxColumn.Name = "UBICACIÓNDataGridViewTextBoxColumn"
        Me.UBICACIÓNDataGridViewTextBoxColumn.Width = 300
        '
        'PUNTOVENTABindingSource1
        '
        Me.PUNTOVENTABindingSource1.DataMember = "PUNTO_VENTA"
        Me.PUNTOVENTABindingSource1.DataSource = Me.LIVESHOWSGROUPDataSet14
        '
        'LIVESHOWSGROUPDataSet14
        '
        Me.LIVESHOWSGROUPDataSet14.DataSetName = "LIVESHOWSGROUPDataSet14"
        Me.LIVESHOWSGROUPDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUNTOVENTABindingSource
        '
        Me.PUNTOVENTABindingSource.DataMember = "PUNTO_VENTA"
        Me.PUNTOVENTABindingSource.DataSource = Me.LIVESHOWSGROUPDataSet7
        '
        'LIVESHOWSGROUPDataSet7
        '
        Me.LIVESHOWSGROUPDataSet7.DataSetName = "LIVESHOWSGROUPDataSet7"
        Me.LIVESHOWSGROUPDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUNTO_VENTATableAdapter
        '
        Me.PUNTO_VENTATableAdapter.ClearBeforeFill = True
        '
        'PUNTO_VENTATableAdapter1
        '
        Me.PUNTO_VENTATableAdapter1.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "DATOS"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(593, 128)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(19, 23)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "+"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PuntoV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(808, 514)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_UBI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_NOM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PuntoV"
        Me.Text = "Punto de Venta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUNTOVENTABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUNTOVENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESHOWSGROUPDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents b As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_NOM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_UBI As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Datos As DataGridView
    Friend WithEvents LIVESHOWSGROUPDataSet7 As LIVESHOWSGROUPDataSet7
    Friend WithEvents PUNTOVENTABindingSource As BindingSource
    Friend WithEvents PUNTO_VENTATableAdapter As LIVESHOWSGROUPDataSet7TableAdapters.PUNTO_VENTATableAdapter
    Friend WithEvents LIVESHOWSGROUPDataSet14 As LIVESHOWSGROUPDataSet14
    Friend WithEvents PUNTOVENTABindingSource1 As BindingSource
    Friend WithEvents PUNTO_VENTATableAdapter1 As LIVESHOWSGROUPDataSet14TableAdapters.PUNTO_VENTATableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents IDPUNTOVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMPUNTOVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UBICACIÓNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button7 As Button
End Class
