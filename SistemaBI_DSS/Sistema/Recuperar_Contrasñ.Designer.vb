<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recuperar_Contrasñ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recuperar_Contrasñ))
        Me.rbcorreo = New System.Windows.Forms.RadioButton()
        Me.rbpreguntas = New System.Windows.Forms.RadioButton()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbcorreo
        '
        Me.rbcorreo.AutoSize = True
        Me.rbcorreo.Location = New System.Drawing.Point(39, 58)
        Me.rbcorreo.Name = "rbcorreo"
        Me.rbcorreo.Size = New System.Drawing.Size(126, 19)
        Me.rbcorreo.TabIndex = 1
        Me.rbcorreo.TabStop = True
        Me.rbcorreo.Text = "Correo Electronico"
        Me.rbcorreo.UseVisualStyleBackColor = True
        '
        'rbpreguntas
        '
        Me.rbpreguntas.AutoSize = True
        Me.rbpreguntas.Location = New System.Drawing.Point(39, 101)
        Me.rbpreguntas.Name = "rbpreguntas"
        Me.rbpreguntas.Size = New System.Drawing.Size(158, 19)
        Me.rbpreguntas.TabIndex = 2
        Me.rbpreguntas.TabStop = True
        Me.rbpreguntas.Text = "Preguntas de Seguridad"
        Me.rbpreguntas.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Red
        Me.btn_aceptar.Location = New System.Drawing.Point(160, 213)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(99, 37)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbcorreo)
        Me.GroupBox1.Controls.Add(Me.rbpreguntas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(38, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 178)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el Metodo de Recuperacion de Contraseña"
        '
        'Recuperar_Contrasñ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(410, 266)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "Recuperar_Contrasñ"
        Me.Text = "Recuperar Contraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rbcorreo As RadioButton
    Friend WithEvents rbpreguntas As RadioButton
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
