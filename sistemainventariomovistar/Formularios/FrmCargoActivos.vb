Imports System.Data.SqlClient


Public Class FrmCargoActivos


    Sub desactivarcontroles()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = False
        BtnBorrar.Enabled = False
        Btncodigo.Enabled = False
        BtnCurp.Enabled = False

        txtNombreArt.Enabled = False
        TxtCodigo.Enabled = False
        TxtNserie.Enabled = False
        TxtCodigoInv.Enabled = False
        TxtDescripcion.Enabled = False
        TxtCurp.Enabled = False
        TxtDepartamento.Enabled = False
        TxtNombreE.Enabled = False
        CboEstado.Enabled = False
        DTPFechaEntrega.Enabled = False
        BtnNuevo.Enabled = True
    End Sub
    Sub activarcontroles()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = True
        BtnBorrar.Enabled = False
        Btncodigo.Enabled = True
        BtnCurp.Enabled = True

        txtNombreArt.Enabled = True
        TxtCodigo.Enabled = True
        TxtNserie.Enabled = True
        TxtCodigoInv.Enabled = True
        TxtDescripcion.Enabled = True
        TxtCurp.Enabled = True
        TxtDepartamento.Enabled = True
        TxtNombreE.Enabled = True
        CboEstado.Enabled = True
        DTPFechaEntrega.Enabled = True


        BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        txtNombreArt.Clear()
        TxtCodigo.Clear()
        TxtNserie.Clear()
        TxtCodigoInv.Clear()
        TxtDescripcion.Clear()
        TxtCurp.Clear()
        TxtDepartamento.Clear()
        TxtNombreE.Clear()
        CboEstado.Text = ""
        DTPFechaEntrega.Text = ""
    End Sub
    Private Function obtenercodigos() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT CodigoA FROM Articulo WHERE EstadoArticulo='PENDIENTE'", obtenerconexion)
        Dim dt As New DataTable("Articulo")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function
    Private Function obtenerIdentidades() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT Curp FROM Empleados", obtenerconexion)
        Dim dt As New DataTable("Empleados")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM CargoActivos Where CodigoInventario = '" & TxtCodigoInv.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            TxtCodigoInv.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If TxtIdArticulo.Text = "" Or TxtIdEmpleado.Text = "" Or TxtCodigoInv.Text = "" Or DTPFechaEntrega.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO CargoActivos(CodigoInventario,fechaAsignacion,EstadoArticulo,Descripcion,IdArticulo,IdEmpleado) VALUES
           ('" & TxtCodigoInv.Text & "','" & DTPFechaEntrega.Text & "','" & CboEstado.Text & "','" & TxtDescripcion.Text & "',
           '" & TxtIdArticulo.Text & "','" & TxtIdEmpleado.Text & "')"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            modificararticulos()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

    End Sub
    Sub modificararticuloPendiente()

        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulo SET EstadoArticulo ='PENDIENTE' WHERE IdArticulo= '" & TxtIdArticulo.Text & "'"
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()
    End Sub
    Sub modificararticulos()

        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulo SET EstadoArticulo ='ENTREGADO' WHERE IdArticulo= '" & TxtIdArticulo.Text & "'"
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()
    End Sub
    Sub Editar()
        Dim id As Integer
        If TxtId.Text = "" Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE CargoActivos SET CodigoInventario ='" & TxtCodigoInv.Text & "',
            fechaAsignacion= '" & DTPFechaEntrega.Text & "', EstadoArticulo='" & CboEstado.Text & "', 
            Descripcion ='" & TxtDescripcion.Text & "',IdArticulo ='" & TxtIdArticulo.Text & "', 
            IdEmpleado ='" & TxtIdEmpleado.Text & "' WHERE IdCargo= '" & TxtId.Text & "'"
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

    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo,CargoActivos.CodigoInventario,CargoActivos.FechaAsignacion,
              CargoActivos.EstadoArticulo,CargoActivos.Descripcion,
              Articulo.NombreA,Articulo.IdArticulo,Articulo.NumeroSerie,Articulo.CodigoA,
              Empleados.Nombre,Empleados.Curp,Empleados.IdEmpleado,Departamentos.NombreD FROM Articulo
              INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
              INNER JOIN Departamentos ON Empleados.IdDepartamento = departamentos.IdDepartamento"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            DgbCargoActivos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub
    Sub buscardatos()
        If rbNombreA.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion,
              CargoActivos.Descripcion,
              Articulo.NombreA, Articulo.IdArticulo, Articulo.NumeroSerie,
              Empleados.Nombre, Empleados.Curp, Empleados.IdEmpleado, Departamentos.NombreD FROM Articulo
              INNER Join CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER Join Empleados ON Empleados.IdEmpleado = Empleados.IdEmpleado
              INNER Join Departamentos On Empleados.IdDepartamento = departamentos.IdDepartamento WHERE Empleados.Nombre LIKE '%" & TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbCargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbCargoActivos.DataSource = ""
            End If

        End If
        If Rbfecha.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion,
              CargoActivos.Descripcion,
              Articulo.NombreA, Articulo.IdArticulo, Articulo.NumeroSerie,Articulo.CodigoA
              Empleados.Nombre, Empleados.Curp, Empleados.IdEmpleado, Departamentos.NombreD FROM Articulo
              INNER Join CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER Join Empleados ON Empleados.IdEmpleado = Empleados.IdEmpleado
              INNER Join Departamentos On Empleados.IdDepartamento = departamentos.IdDepartamento WHERE CargoActivos.FechaAsignacion LIKE '%" & TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbCargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbCargoActivos.DataSource = ""
            End If
        End If
        If RbCodigoA.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion,
              CargoActivos.Descripcion,
              Articulo.NombreA, Articulo.IdArticulo, Articulo.NumeroSerie,
              Empleados.Nombre, Empleados.Curp, Empleados.IdEmpleado, Departamentos.NombreD FROM Articulo
              INNER Join CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER Join Empleados ON Empleados.IdEmpleado = Empleados.IdEmpleado
              INNER Join Departamentos On Empleados.IdDepartamento = departamentos.IdDepartamento WHERE Articulo.CodigoA LIKE '%" & TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbCargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbCargoActivos.DataSource = ""
            End If
        End If


    End Sub
    Sub Eliminar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            If MsgBox("¿seguro de eliminar al activo" + Trim(txtNombreArt.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else


                Dim sql As String
                sql = "DELETE FROM CargoActivos WHERE IdCargo = " & Trim(TxtId.Text)
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                modificararticuloPendiente()
                MsgBox("Registro Eliminado correctamente", vbInformation, "Sistema inventario")
                limpiarcontroles()
            End If
        End If
    End Sub

    Private Sub FrmCargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        limpiarcontroles()
        Llenardatos()

        TxtCodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtCodigo.AutoCompleteCustomSource = obtenercodigos()

        TxtCurp.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtCurp.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtCurp.AutoCompleteCustomSource = obtenerIdentidades()

        DgbCargoActivos.AutoGenerateColumns = False





    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtNserie.TextChanged

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        activarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged
        If TxtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT IdArticulo,NombreA,NumeroSerie FROM Articulo WHERE CodigoA='" & TxtCodigo.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreArt.Text = fila("NombreA").ToString
                TxtNserie.Text = fila("NumeroSerie").ToString
                TxtIdArticulo.Text = fila("idArticulo").ToString
            Else
                txtNombreArt.Clear()
                TxtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TxtCurp_TextChanged(sender As Object, e As EventArgs) Handles TxtCurp.TextChanged
        If TxtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado,Empleados.Nombre,Departamentos.NombreD FROM Departamentos INNER JOIN Empleados ON departamentos.IdDepartamento = Empleados.IdDepartamento WHERE Curp='" & TxtCurp.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                TxtNombreE.Text = fila("Nombre").ToString
                TxtDepartamento.Text = fila("NombreD").ToString
                TxtIdEmpleado.Text = fila("idEmpleado").ToString
            Else
                TxtDepartamento.Clear()
                TxtNombreE.Clear()
                TxtCurp.Focus()
            End If
        End If
    End Sub
    Private Sub Btncodigo_Click(sender As Object, e As EventArgs) Handles Btncodigo.Click
        Dim frmbusquedaarticulos As New FrmBuscarArticulos
        frmbusquedaarticulos.ShowDialog()


    End Sub
    Dim FrmBusquedaEmpleado As New FrmBusquedaEmpleado

    Private Sub BtnCurp_Click(sender As Object, e As EventArgs) Handles BtnCurp.Click

        FrmBusquedaEmpleado.ShowDialog()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscardatos()

    End Sub

    Private Sub rbNombreA_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreA.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub Rbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles Rbfecha.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub RbCodigoA_CheckedChanged(sender As Object, e As EventArgs) Handles RbCodigoA.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub DgbCargoActivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbCargoActivos.CellDoubleClick
        On Error Resume Next

        TxtIdArticulo.Text = CStr(DgbCargoActivos.Item("IdArticulo", DgbCargoActivos.CurrentCell.RowIndex).Value)
        txtNombreArt.Text = CStr(DgbCargoActivos.Item("NombreA", DgbCargoActivos.CurrentCell.RowIndex).Value)
        TxtCodigo.Text = CStr(DgbCargoActivos.Item("CodigoA", DgbCargoActivos.CurrentCell.RowIndex).Value)
        TxtNserie.Text = CStr(DgbCargoActivos.Item("NumeroSerie", DgbCargoActivos.CurrentCell.RowIndex).Value)

        TxtIdEmpleado.Text = CStr(DgbCargoActivos.Item("IdEmpleado", DgbCargoActivos.CurrentCell.RowIndex).Value)
        TxtCurp.Text = CStr(DgbCargoActivos.Item("Curp", DgbCargoActivos.CurrentCell.RowIndex).Value)
        TxtNombreE.Text = CStr(DgbCargoActivos.Item("Nombre", DgbCargoActivos.CurrentCell.RowIndex).Value)
        TxtDepartamento.Text = CStr(DgbCargoActivos.Item("NombreD", DgbCargoActivos.CurrentCell.RowIndex).Value)


        TxtId.Text = CStr(DgbCargoActivos.Item("IdCargo", DgbCargoActivos.CurrentCell.RowIndex).Value)
        TxtCodigoInv.Text = CStr(DgbCargoActivos.Item("CodigoInventario", DgbCargoActivos.CurrentCell.RowIndex).Value)
        CboEstado.Text = CStr(DgbCargoActivos.Item("EstadoArticulo", DgbCargoActivos.CurrentCell.RowIndex).Value)
        TxtDescripcion.Text = CStr(DgbCargoActivos.Item("Descripcion", DgbCargoActivos.CurrentCell.RowIndex).Value)
        DTPFechaEntrega.Text = CStr(DgbCargoActivos.Item("FechaAsignacion", DgbCargoActivos.CurrentCell.RowIndex).Value)
        BtnCancelar.Enabled = True
        Btncodigo.Enabled = True
        BtnCurp.Enabled = True
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True

        txtNombreArt.Enabled = True
        TxtIdArticulo.Enabled = True
        TxtNserie.Enabled = True
        TxtCodigo.Enabled = True

        TxtNombreE.Enabled = True
        TxtCurp.Enabled = True
        TxtNombreE.Enabled = True
        TxtDepartamento.Enabled = True

        TxtDescripcion.Enabled = True
        DTPFechaEntrega.Enabled = True
        CboEstado.Enabled = True
        TxtCodigoInv.Enabled = True
        'TxtCodigo.Focus()
        BtnBuscar.Enabled = False
        BtnNuevo.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Editar()
            desactivarcontroles()
            Llenardatos()

        Else
            MsgBox("NO TIENE LOS PRIVILEGIOS PARA ACCEDER A ESTE MODULO", vbInformation, "OPERACION CANCELADA")

        End If

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Eliminar()

            desactivarcontroles()
            Llenardatos()

        Else
            MsgBox("NO TIENE LOS PRIVILEGIOS PARA ACCEDER A ESTE MODULO", vbInformation, "OPERACION CANCELADA")

        End If

    End Sub
End Class