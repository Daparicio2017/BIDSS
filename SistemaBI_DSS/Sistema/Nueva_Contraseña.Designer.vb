<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_Contraseña))
        Me.TxtContanterior = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCambiarcontra = New System.Windows.Forms.Button()
        Me.TxtConfirmar = New System.Windows.Forms.TextBox()
        Me.TxtNuevacontra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtContanterior
        '
        Me.TxtContanterior.Location = New System.Drawing.Point(211, 51)
        Me.TxtContanterior.Name = "TxtContanterior"
        Me.TxtContanterior.Size = New System.Drawing.Size(139, 20)
        Me.TxtContanterior.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(43, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Contraseña anterior"
        '
        'BtnCambiarcontra
        '
        Me.BtnCambiarcontra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCambiarcontra.Location = New System.Drawing.Point(140, 189)
        Me.BtnCambiarcontra.Name = "BtnCambiarcontra"
        Me.BtnCambiarcontra.Size = New System.Drawing.Size(85, 42)
        Me.BtnCambiarcontra.TabIndex = 11
        Me.BtnCambiarcontra.Text = "Cambiar Contraseña"
        Me.BtnCambiarcontra.UseVisualStyleBackColor = True
        '
        'TxtConfirmar
        '
        Me.TxtConfirmar.Location = New System.Drawing.Point(211, 140)
        Me.TxtConfirmar.Name = "TxtConfirmar"
        Me.TxtConfirmar.Size = New System.Drawing.Size(139, 20)
        Me.TxtConfirmar.TabIndex = 10
        '
        'TxtNuevacontra
        '
        Me.TxtNuevacontra.Location = New System.Drawing.Point(211, 93)
        Me.TxtNuevacontra.Name = "TxtNuevacontra"
        Me.TxtNuevacontra.Size = New System.Drawing.Size(139, 20)
        Me.TxtNuevacontra.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(43, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Confirmar contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(43, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Contraseña nueva"
        '
        'Nueva_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(397, 250)
        Me.Controls.Add(Me.TxtContanterior)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCambiarcontra)
        Me.Controls.Add(Me.TxtConfirmar)
        Me.Controls.Add(Me.TxtNuevacontra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Nueva_Contraseña"
        Me.Text = "Nueva_Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtContanterior As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCambiarcontra As Button
    Friend WithEvents TxtConfirmar As TextBox
    Friend WithEvents TxtNuevacontra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
