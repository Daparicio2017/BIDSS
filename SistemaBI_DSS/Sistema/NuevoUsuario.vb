Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Windows.Forms


Public Class NuevoUsuario
    Public conexion As New SqlConnection("Server=ArielAlvarenga\SQLEXPRESSS;Integrated Security=true;database=sistema_bidss")
    Public command As SqlClient.SqlCommand, mytrans As SqlTransaction

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim clasinsert As New insert
        Dim clasvalidaciones As New ClaseValidaciones
        Dim contra_valida As Boolean = ClaseValidaciones.Validarpassword(txtcontra.Text)
        Dim validauser As Boolean = ClaseValidaciones.valdidarmayusculas(txtusuario.Text)
        Dim validausername As Boolean = ClaseValidaciones.valdidarnombreuser(txtnombre.Text)

        ''Valida que no falten datos

        If txtusuario.Text = "" And txtcontra.Text = "" And txtnombre.Text = "" And txtcorreo.Text = "" Then
            MsgBox("Faltan Datos", MsgBoxStyle.Information, "BI-DSS")
            Return
        End If
        '--------------------------------------------------------------------------------------------------------

        If (Not (validauser)) Then
            txtusuario.Text = ""
            msjuser.Visible = True
            msj.Text = ("El usuario debe ingresar en Letras Mayusculas")
            Return
        Else
            msjuser.Visible = False
            msj.Text = ""
        End If
        '--------------------------------------------------------------------
        '-------------------------------------------------------------------
        'Valida uso de caracteres especiales en la contraseña

        If (Not (contra_valida)) Then
            txtcontra.Text = ""
            msj.Visible = True
            msj.Text = ("contraseña no valida,Debe contener maximo 8 Caracteres, incluir caracteres especiales ")
            Return
        Else
            msj.Visible = True
            msj.Text = ""
        End If
        '__________________________________________________________________________________

        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If
        Dim comando As New SqlClient.SqlCommand
        comando.Connection = conexion
        comando.CommandType = "validar_user"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@usuario", txtusuario.Text)

        Dim buscar As SqlClient.SqlDataReader
        buscar = comando.ExecuteReader
        comando = Nothing
        '.............................................................................................
        If buscar.HasRows Then
            buscar.Read()
            If buscar.GetValue(1) = txtusuario.Text Then
                txtusuario.Text = ""
                msjuser.Visible = True
                msjuser.Text = "El usuario ya Existe"
                txtusuario.Focus()
                Return
            End If
        End If
        '...........................................................................................
        clasinsert.insert_usuario(txtusuario.Text, txtcontra.Text, txtnombre.Text, cbrol.SelectedIndex, txtcorreo.Text)

        preguntas()
        limpiar()

    End Sub

    Public Sub limpiar()
        txtusuario.Text = ""
        txtcontra.Text = ""
        txtnombre.Text = ""
        txtcorreo.Text = ""
        msjuser.Text = ""
        msj.Text = ""

    End Sub

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub preguntas()
        Dim confirmar As Integer
        confirmar = MsgBox("Desea completar su informacion contestando las preguntas de seguridad:", MsgBoxStyle.YesNo, "Preguntas de Seguridad")
        If confirmar = vbYes Then
            'preguntas_seguridad.show
        Else
            Exit Sub
        End If
    End Sub


End Class