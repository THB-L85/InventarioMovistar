Imports System.Data.SqlClient
Public Class FrmLogin
    Dim formConfiguracion As New FrmConfiguracion
    Dim formPrincipal As New frmPrincipal
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Existen datos vacios", vbExclamation, "Operacion Cancelada")
        Else
            Try
                conexion.Open()
                adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE Usuario= '" & UsernameTextBox.Text & "' AND Password= '" & PasswordTextBox.Text & "' ", conexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count = 1 Then
                    Dim fila As DataRow = tabla.Rows(0)
                    Nombre = Trim(fila("NombreCompleto").ToString)
                    tipousuario = Trim(fila("TipoUsuario").ToString)
                    formPrincipal.ToolStripStatusLabel2.Text = Nombre
                    formPrincipal.ToolStripStatusLabel4.Text = tipousuario

                    MsgBox("Datos verificados", vbInformation, "Operacion completada")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Hide()
                    formPrincipal.Show()
                Else
                    MsgBox("Nombre de Usuario o contraseña no valido", vbExclamation, "Operacion Cancelada")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                End If
                conexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

        formConfiguracion.Show()


    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        establecerconexion()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
