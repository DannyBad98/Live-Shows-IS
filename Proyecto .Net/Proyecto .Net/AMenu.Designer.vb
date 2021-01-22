<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ven = New System.Windows.Forms.Button()
        Me.pve = New System.Windows.Forms.Button()
        Me.eve = New System.Windows.Forms.Button()
        Me.prod = New System.Windows.Forms.Button()
        Me.prov = New System.Windows.Forms.Button()
        Me.emp = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(389, 18)
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
        Me.Label2.Location = New System.Drawing.Point(649, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MENÚ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Empleados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Proveedores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(503, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Productos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(179, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Eventos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(323, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Punto de Venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(515, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Ventas"
        '
        'ven
        '
        Me.ven.Image = Global.Proyecto.Net.My.Resources.Resources.ven
        Me.ven.Location = New System.Drawing.Point(489, 268)
        Me.ven.Name = "ven"
        Me.ven.Size = New System.Drawing.Size(95, 92)
        Me.ven.TabIndex = 16
        Me.ven.UseVisualStyleBackColor = True
        '
        'pve
        '
        Me.pve.Image = Global.Proyecto.Net.My.Resources.Resources.pve
        Me.pve.Location = New System.Drawing.Point(322, 268)
        Me.pve.Name = "pve"
        Me.pve.Size = New System.Drawing.Size(95, 92)
        Me.pve.TabIndex = 14
        Me.pve.UseVisualStyleBackColor = True
        '
        'eve
        '
        Me.eve.Image = Global.Proyecto.Net.My.Resources.Resources.eve
        Me.eve.Location = New System.Drawing.Point(155, 268)
        Me.eve.Name = "eve"
        Me.eve.Size = New System.Drawing.Size(95, 92)
        Me.eve.TabIndex = 12
        Me.eve.UseVisualStyleBackColor = True
        '
        'prod
        '
        Me.prod.Image = Global.Proyecto.Net.My.Resources.Resources.prod
        Me.prod.Location = New System.Drawing.Point(487, 120)
        Me.prod.Name = "prod"
        Me.prod.Size = New System.Drawing.Size(95, 92)
        Me.prod.TabIndex = 10
        Me.prod.UseVisualStyleBackColor = True
        '
        'prov
        '
        Me.prov.Image = Global.Proyecto.Net.My.Resources.Resources.prov
        Me.prov.Location = New System.Drawing.Point(321, 120)
        Me.prov.Name = "prov"
        Me.prov.Size = New System.Drawing.Size(95, 92)
        Me.prov.TabIndex = 6
        Me.prov.UseVisualStyleBackColor = True
        '
        'emp
        '
        Me.emp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp.Image = Global.Proyecto.Net.My.Resources.Resources.empleados1
        Me.emp.Location = New System.Drawing.Point(154, 120)
        Me.emp.Name = "emp"
        Me.emp.Size = New System.Drawing.Size(95, 92)
        Me.emp.TabIndex = 4
        Me.emp.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox2.Location = New System.Drawing.Point(111, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 39)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-205, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1048, 94)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(645, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cerrar Sesión"
        '
        'AMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(740, 410)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ven)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pve)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.eve)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.prov)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.emp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AMenu"
        Me.Text = "AMenu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents emp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents prov As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents prod As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents eve As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents pve As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ven As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
End Class
