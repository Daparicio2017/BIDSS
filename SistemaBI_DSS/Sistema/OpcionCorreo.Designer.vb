<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcionCorreo
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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_enviar_correo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el Nombre de Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(211, 30)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'btn_enviar_correo
        '
        Me.btn_enviar_correo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_enviar_correo.Location = New System.Drawing.Point(84, 102)
        Me.btn_enviar_correo.Name = "btn_enviar_correo"
        Me.btn_enviar_correo.Size = New System.Drawing.Size(268, 40)
        Me.btn_enviar_correo.TabIndex = 2
        Me.btn_enviar_correo.Text = "Enviar Por Correo Electronico"
        Me.btn_enviar_correo.UseVisualStyleBackColor = False
        '
        'OpcionCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(469, 187)
        Me.Controls.Add(Me.btn_enviar_correo)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OpcionCorreo"
        Me.Text = "OpcionCorreo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents btn_enviar_correo As Button
End Class
