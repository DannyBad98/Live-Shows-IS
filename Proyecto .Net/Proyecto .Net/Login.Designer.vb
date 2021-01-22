<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(75, 143)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(187, 24)
        Me.txt_user.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(127, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(107, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CONTRASEÑA"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(75, 202)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(187, 24)
        Me.txt_pass.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(42, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Acceder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(192, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.Net.My.Resources.Resources.Lgo12
        Me.PictureBox1.Location = New System.Drawing.Point(-144, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(840, 99)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(345, 306)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_user)
        Me.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Name = "Login"
        Me.Text = "LIVE SHOWS GROUP - LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
