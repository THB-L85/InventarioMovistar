Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class frmUsuarios
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblEstado.Click

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()
    End Sub

    Private Sub lblcontraseña_Click(sender As Object, e As EventArgs) Handles lblcontraseña.Click

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call desactivarcontroles()
        Llenardatos()
        DgbUsuarios.AutoGenerateColumns = False

    End Sub
    Sub desactivarcontroles()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = False
        BtnBorrar.Enabled = False

        txtUsuario.Enabled = False
        txtNombrecompleto.Enabled = False
        txtcontraseña.Enabled = False
        cboestado.Enabled = False
        cbotipousuario.Enabled = False

        BtnNuevo.Enabled = True
    End Sub
    Sub activarcontroles()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = True
        BtnBorrar.Enabled = False

        txtUsuario.Enabled = True
        txtNombrecompleto.Enabled = True
        txtcontraseña.Enabled = True
        cboestado.Enabled = True
        cbotipousuario.Enabled = True

        BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        txtNombrecompleto.Text = ""
        txtcontraseña.Text = ""
        txtUsuario.Text = ""
        cboestado.Text = ""
        cbotipousuario.Text = ""
        TxtId.Text = ""
        TxtBuscar.Text = ""

    End Sub
    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT * FROM Usuarios"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            DgbUsuarios.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub
    Sub Editar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE Usuarios SET NombreCompleto ='" & txtNombrecompleto.Text & "',Usuario= '" & txtUsuario.Text & "',Password='" & txtcontraseña.Text & "',TipoUsuario ='" & cbotipousuario.Text & "',Estado='" & cboestado.Text & "' WHERE IdUsuarios= '" & TxtId.Text & "'"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro Editado correctamente", vbInformation, "Sistema inventario")
            limpiarcontroles()

        End If
    End Sub
    Sub Eliminar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            If MsgBox("¿seguro de eliminar a" + Trim(txtNombrecompleto.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else


                Dim sql As String
                sql = "DELETE FROM Usuarios WHERE IdUsuarios = " & Trim(TxtId.Text)
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                MsgBox("Registro Eliminado correctamente", vbInformation, "Sistema inventario")
                limpiarcontroles()
            End If
        End If
    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Usuarios Where Usuario = '" & txtUsuario.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            txtUsuario.Text = tabla.Rows(0).Item("Usuario")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If txtNombrecompleto.Text = "" Or txtUsuario.Text = "" Or txtcontraseña.Text = "" Or cboestado.Text = "" Or cbotipousuario.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Usuarios(NombreCompleto,Usuario,Password,TipoUsuario,Estado)VALUES ('" & txtNombrecompleto.Text & "','" & txtUsuario.Text & "','" & txtcontraseña.Text & "','" & cbotipousuario.Text & "','" & cboestado.Text & "') " ' consulta de insercion
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        activarcontroles()
    End Sub

    Private Sub DgbUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbUsuarios.CellContentClick

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = " " Then
            Llenardatos()

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE NombreCompleto LIKE '%" & TxtBuscar.Text & "%'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            DgbUsuarios.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count
        Else
            DgbUsuarios.DataSource = ""
        End If

    End Sub

    Private Sub DgbUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbUsuarios.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        TxtId.Text = CStr(DgbUsuarios.Item("IdUsuarios", DgbUsuarios.CurrentCell.RowIndex).Value)
        txtNombrecompleto.Text = CStr(DgbUsuarios.Item("NombreCompleto", DgbUsuarios.CurrentCell.RowIndex).Value)
        txtUsuario.Text = CStr(DgbUsuarios.Item("Usuario", DgbUsuarios.CurrentCell.RowIndex).Value)
        txtcontraseña.Text = CStr(DgbUsuarios.Item("Password", DgbUsuarios.CurrentCell.RowIndex).Value)
        cbotipousuario.Text = CStr(DgbUsuarios.Item("TipoUsuario", DgbUsuarios.CurrentCell.RowIndex).Value)
        cboestado.Text = CStr(DgbUsuarios.Item("Estado", DgbUsuarios.CurrentCell.RowIndex).Value)
        BtnCancelar.Enabled = True
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True

        txtUsuario.Enabled = True
        txtNombrecompleto.Enabled = True
        txtcontraseña.Enabled = True
        cboestado.Enabled = True
        cbotipousuario.Enabled = True
        txtNombrecompleto.Focus()

        BtnNuevo.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()
        desactivarcontroles()
        Llenardatos()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Eliminar()
        desactivarcontroles()
        Llenardatos()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class