<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.SeguridadToolStripMenuItem1, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SeguridadToolStripMenuItem.Text = "Registrar"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrosToolStripMenuItem.Text = "Reportes"
        '
        'SeguridadToolStripMenuItem1
        '
        Me.SeguridadToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem})
        Me.SeguridadToolStripMenuItem1.Name = "SeguridadToolStripMenuItem1"
        Me.SeguridadToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem1.Text = "Seguridad"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(533, 342)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.Text = "SISTEMA BI-DSS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
End Class
