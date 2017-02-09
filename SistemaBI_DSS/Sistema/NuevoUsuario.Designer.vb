<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.cbrol = New System.Windows.Forms.ComboBox()
        Me.msjuser = New System.Windows.Forms.Label()
        Me.msj = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(41, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(44, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(44, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(44, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(41, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(126, 42)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 5
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(126, 82)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 6
        '
        'txtcontra
        '
        Me.txtcontra.Location = New System.Drawing.Point(126, 116)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(100, 20)
        Me.txtcontra.TabIndex = 7
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(126, 199)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(141, 20)
        Me.txtcorreo.TabIndex = 9
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(106, 256)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(96, 47)
        Me.btnagregar.TabIndex = 10
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'cbrol
        '
        Me.cbrol.FormattingEnabled = True
        Me.cbrol.Location = New System.Drawing.Point(126, 156)
        Me.cbrol.Name = "cbrol"
        Me.cbrol.Size = New System.Drawing.Size(121, 21)
        Me.cbrol.TabIndex = 11
        '
        'msjuser
        '
        Me.msjuser.AutoSize = True
        Me.msjuser.BackColor = System.Drawing.Color.Transparent
        Me.msjuser.ForeColor = System.Drawing.Color.Yellow
        Me.msjuser.Location = New System.Drawing.Point(126, 63)
        Me.msjuser.Name = "msjuser"
        Me.msjuser.Size = New System.Drawing.Size(10, 13)
        Me.msjuser.TabIndex = 12
        Me.msjuser.Text = "."
        '
        'msj
        '
        Me.msj.AutoSize = True
        Me.msj.BackColor = System.Drawing.Color.Transparent
        Me.msj.ForeColor = System.Drawing.Color.Yellow
        Me.msj.Location = New System.Drawing.Point(126, 134)
        Me.msj.Name = "msj"
        Me.msj.Size = New System.Drawing.Size(10, 13)
        Me.msj.TabIndex = 13
        Me.msj.Text = "."
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 332)
        Me.Controls.Add(Me.msj)
        Me.Controls.Add(Me.msjuser)
        Me.Controls.Add(Me.cbrol)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevoUsuario"
        Me.Text = "Nuevo Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents cbrol As ComboBox
    Friend WithEvents msjuser As Label
    Friend WithEvents msj As Label
End Class
