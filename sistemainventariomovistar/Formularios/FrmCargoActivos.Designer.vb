﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCargoActivos
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbCodigoA = New System.Windows.Forms.RadioButton()
        Me.Rbfecha = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgbCargoActivos = New System.Windows.Forms.DataGridView()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Guna2TxtCodigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2TxtCurp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDepartamento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNombreArt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNombreE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Btncodigo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnCurp = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DTPFechaEntrega = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TxtNSerie = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtCodigoInv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CboEstado = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BntEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtCodigoInv = New System.Windows.Forms.TextBox()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.TxtNserie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombreE = New System.Windows.Forms.TextBox()
        Me.txtNombreArt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.BtnCurp = New System.Windows.Forms.Button()
        Me.Btncodigo = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DgbCargoActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(51, 256)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(32, 20)
        Me.TxtId.TabIndex = 85
        Me.TxtId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbCodigoA)
        Me.Panel1.Controls.Add(Me.Rbfecha)
        Me.Panel1.Controls.Add(Me.rbNombreA)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.DgbCargoActivos)
        Me.Panel1.Location = New System.Drawing.Point(51, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 250)
        Me.Panel1.TabIndex = 84
        '
        'RbCodigoA
        '
        Me.RbCodigoA.AutoSize = True
        Me.RbCodigoA.Location = New System.Drawing.Point(385, 17)
        Me.RbCodigoA.Name = "RbCodigoA"
        Me.RbCodigoA.Size = New System.Drawing.Size(111, 17)
        Me.RbCodigoA.TabIndex = 22
        Me.RbCodigoA.Text = "Codigo de Articulo"
        Me.RbCodigoA.UseVisualStyleBackColor = True
        '
        'Rbfecha
        '
        Me.Rbfecha.AutoSize = True
        Me.Rbfecha.Location = New System.Drawing.Point(244, 15)
        Me.Rbfecha.Name = "Rbfecha"
        Me.Rbfecha.Size = New System.Drawing.Size(55, 17)
        Me.Rbfecha.TabIndex = 21
        Me.Rbfecha.Text = "Fecha"
        Me.Rbfecha.UseVisualStyleBackColor = True
        '
        'rbNombreA
        '
        Me.rbNombreA.AutoSize = True
        Me.rbNombreA.Checked = True
        Me.rbNombreA.Location = New System.Drawing.Point(18, 15)
        Me.rbNombreA.Name = "rbNombreA"
        Me.rbNombreA.Size = New System.Drawing.Size(127, 17)
        Me.rbNombreA.TabIndex = 20
        Me.rbNombreA.TabStop = True
        Me.rbNombreA.Text = "Nombre de Empleado"
        Me.rbNombreA.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(131, 204)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empleados Registrados"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(569, 14)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(320, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'DgbCargoActivos
        '
        Me.DgbCargoActivos.AllowUserToAddRows = False
        Me.DgbCargoActivos.AllowUserToDeleteRows = False
        Me.DgbCargoActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbCargoActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.CodigoInventario, Me.NombreA, Me.Nombre, Me.fechaAsignacion, Me.NombreD, Me.NumeroSerie, Me.Descripcion})
        Me.DgbCargoActivos.Location = New System.Drawing.Point(3, 52)
        Me.DgbCargoActivos.Name = "DgbCargoActivos"
        Me.DgbCargoActivos.ReadOnly = True
        Me.DgbCargoActivos.RowHeadersVisible = False
        Me.DgbCargoActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgbCargoActivos.Size = New System.Drawing.Size(920, 138)
        Me.DgbCargoActivos.TabIndex = 0
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "ID"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'CodigoInventario
        '
        Me.CodigoInventario.DataPropertyName = "CodigoInventario"
        Me.CodigoInventario.HeaderText = "CODIGO DE INVENTARIO"
        Me.CodigoInventario.Name = "CodigoInventario"
        Me.CodigoInventario.ReadOnly = True
        Me.CodigoInventario.Width = 150
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "NOMBRE ACTIVO"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 200
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE DE EMPLEADO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'fechaAsignacion
        '
        Me.fechaAsignacion.DataPropertyName = "fechaAsignacion"
        Me.fechaAsignacion.HeaderText = "FECHA DE ASIGNACION"
        Me.fechaAsignacion.Name = "fechaAsignacion"
        Me.fechaAsignacion.ReadOnly = True
        Me.fechaAsignacion.Width = 150
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Width = 150
        '
        'NumeroSerie
        '
        Me.NumeroSerie.DataPropertyName = "NumeroSerie"
        Me.NumeroSerie.HeaderText = "NUMERO DE SERIE"
        Me.NumeroSerie.Name = "NumeroSerie"
        Me.NumeroSerie.ReadOnly = True
        Me.NumeroSerie.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(887, 72)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 23)
        Me.BtnCancelar.TabIndex = 83
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(808, 72)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 23)
        Me.BtnNuevo.TabIndex = 79
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.Location = New System.Drawing.Point(96, 256)
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdArticulo.TabIndex = 112
        Me.TxtIdArticulo.Visible = False
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(138, 256)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdEmpleado.TabIndex = 113
        Me.TxtIdEmpleado.Visible = False
        '
        'Guna2TxtCodigo
        '
        Me.Guna2TxtCodigo.Animated = True
        Me.Guna2TxtCodigo.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigo.BorderRadius = 7
        Me.Guna2TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtCodigo.DefaultText = ""
        Me.Guna2TxtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigo.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigo.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtCodigo.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigo.Location = New System.Drawing.Point(51, 75)
        Me.Guna2TxtCodigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCodigo.Name = "Guna2TxtCodigo"
        Me.Guna2TxtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCodigo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCodigo.PlaceholderText = "Código"
        Me.Guna2TxtCodigo.SelectedText = ""
        Me.Guna2TxtCodigo.Size = New System.Drawing.Size(150, 36)
        Me.Guna2TxtCodigo.TabIndex = 114
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2TxtCurp
        '
        Me.Guna2TxtCurp.Animated = True
        Me.Guna2TxtCurp.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtCurp.BorderRadius = 7
        Me.Guna2TxtCurp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtCurp.DefaultText = ""
        Me.Guna2TxtCurp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtCurp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtCurp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCurp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCurp.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtCurp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCurp.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtCurp.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtCurp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCurp.Location = New System.Drawing.Point(51, 121)
        Me.Guna2TxtCurp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCurp.Name = "Guna2TxtCurp"
        Me.Guna2TxtCurp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCurp.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCurp.PlaceholderText = "Curp"
        Me.Guna2TxtCurp.SelectedText = ""
        Me.Guna2TxtCurp.Size = New System.Drawing.Size(150, 36)
        Me.Guna2TxtCurp.TabIndex = 115
        '
        'Guna2TxtDepartamento
        '
        Me.Guna2TxtDepartamento.Animated = True
        Me.Guna2TxtDepartamento.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtDepartamento.BorderRadius = 7
        Me.Guna2TxtDepartamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtDepartamento.DefaultText = ""
        Me.Guna2TxtDepartamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtDepartamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtDepartamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDepartamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDepartamento.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtDepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDepartamento.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtDepartamento.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtDepartamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDepartamento.Location = New System.Drawing.Point(51, 167)
        Me.Guna2TxtDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtDepartamento.Name = "Guna2TxtDepartamento"
        Me.Guna2TxtDepartamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtDepartamento.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtDepartamento.PlaceholderText = "Departamento"
        Me.Guna2TxtDepartamento.SelectedText = ""
        Me.Guna2TxtDepartamento.Size = New System.Drawing.Size(150, 36)
        Me.Guna2TxtDepartamento.TabIndex = 116
        '
        'Guna2TxtDescripcion
        '
        Me.Guna2TxtDescripcion.Animated = True
        Me.Guna2TxtDescripcion.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtDescripcion.BorderRadius = 7
        Me.Guna2TxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtDescripcion.DefaultText = ""
        Me.Guna2TxtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDescripcion.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDescripcion.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDescripcion.Location = New System.Drawing.Point(51, 213)
        Me.Guna2TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtDescripcion.Name = "Guna2TxtDescripcion"
        Me.Guna2TxtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtDescripcion.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtDescripcion.PlaceholderText = "Descripción"
        Me.Guna2TxtDescripcion.SelectedText = ""
        Me.Guna2TxtDescripcion.Size = New System.Drawing.Size(456, 36)
        Me.Guna2TxtDescripcion.TabIndex = 117
        '
        'Guna2TxtNombreArt
        '
        Me.Guna2TxtNombreArt.Animated = True
        Me.Guna2TxtNombreArt.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreArt.BorderRadius = 7
        Me.Guna2TxtNombreArt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNombreArt.DefaultText = ""
        Me.Guna2TxtNombreArt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNombreArt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNombreArt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreArt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreArt.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNombreArt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreArt.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNombreArt.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreArt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreArt.Location = New System.Drawing.Point(282, 75)
        Me.Guna2TxtNombreArt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreArt.Name = "Guna2TxtNombreArt"
        Me.Guna2TxtNombreArt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreArt.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreArt.PlaceholderText = "Nombre del Artículo"
        Me.Guna2TxtNombreArt.ReadOnly = True
        Me.Guna2TxtNombreArt.SelectedText = ""
        Me.Guna2TxtNombreArt.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNombreArt.TabIndex = 118
        '
        'Guna2TxtNombreE
        '
        Me.Guna2TxtNombreE.Animated = True
        Me.Guna2TxtNombreE.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreE.BorderRadius = 7
        Me.Guna2TxtNombreE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNombreE.DefaultText = ""
        Me.Guna2TxtNombreE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNombreE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNombreE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreE.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNombreE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreE.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNombreE.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreE.Location = New System.Drawing.Point(282, 121)
        Me.Guna2TxtNombreE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreE.Name = "Guna2TxtNombreE"
        Me.Guna2TxtNombreE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreE.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreE.PlaceholderText = "Nombre del Empleado"
        Me.Guna2TxtNombreE.ReadOnly = True
        Me.Guna2TxtNombreE.SelectedText = ""
        Me.Guna2TxtNombreE.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNombreE.TabIndex = 119
        '
        'Guna2Btncodigo
        '
        Me.Guna2Btncodigo.Animated = True
        Me.Guna2Btncodigo.BorderRadius = 7
        Me.Guna2Btncodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Btncodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Btncodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Btncodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Btncodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Btncodigo.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Btncodigo.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2Btncodigo.ForeColor = System.Drawing.Color.Black
        Me.Guna2Btncodigo.Location = New System.Drawing.Point(211, 75)
        Me.Guna2Btncodigo.Name = "Guna2Btncodigo"
        Me.Guna2Btncodigo.Size = New System.Drawing.Size(42, 36)
        Me.Guna2Btncodigo.TabIndex = 120
        Me.Guna2Btncodigo.Text = "..."
        '
        'Guna2BtnCurp
        '
        Me.Guna2BtnCurp.Animated = True
        Me.Guna2BtnCurp.BorderRadius = 7
        Me.Guna2BtnCurp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnCurp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCurp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCurp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnCurp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnCurp.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2BtnCurp.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2BtnCurp.ForeColor = System.Drawing.Color.Black
        Me.Guna2BtnCurp.Location = New System.Drawing.Point(211, 121)
        Me.Guna2BtnCurp.Name = "Guna2BtnCurp"
        Me.Guna2BtnCurp.Size = New System.Drawing.Size(42, 36)
        Me.Guna2BtnCurp.TabIndex = 121
        Me.Guna2BtnCurp.Text = "..."
        '
        'Guna2DTPFechaEntrega
        '
        Me.Guna2DTPFechaEntrega.Animated = True
        Me.Guna2DTPFechaEntrega.BorderRadius = 7
        Me.Guna2DTPFechaEntrega.BorderThickness = 1
        Me.Guna2DTPFechaEntrega.Checked = True
        Me.Guna2DTPFechaEntrega.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2DTPFechaEntrega.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Guna2DTPFechaEntrega.Location = New System.Drawing.Point(373, 167)
        Me.Guna2DTPFechaEntrega.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.Name = "Guna2DTPFechaEntrega"
        Me.Guna2DTPFechaEntrega.Size = New System.Drawing.Size(134, 36)
        Me.Guna2DTPFechaEntrega.TabIndex = 122
        Me.Guna2DTPFechaEntrega.Value = New Date(2022, 11, 13, 22, 42, 37, 926)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(283, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "F. Compra:"
        '
        'Guna2TxtNSerie
        '
        Me.Guna2TxtNSerie.Animated = True
        Me.Guna2TxtNSerie.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNSerie.BorderRadius = 7
        Me.Guna2TxtNSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNSerie.DefaultText = ""
        Me.Guna2TxtNSerie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNSerie.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNSerie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNSerie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNSerie.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNSerie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNSerie.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNSerie.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNSerie.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNSerie.Location = New System.Drawing.Point(537, 75)
        Me.Guna2TxtNSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNSerie.Name = "Guna2TxtNSerie"
        Me.Guna2TxtNSerie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNSerie.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNSerie.PlaceholderText = "Número de Serie"
        Me.Guna2TxtNSerie.ReadOnly = True
        Me.Guna2TxtNSerie.SelectedText = ""
        Me.Guna2TxtNSerie.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNSerie.TabIndex = 124
        '
        'Guna2TxtCodigoInv
        '
        Me.Guna2TxtCodigoInv.Animated = True
        Me.Guna2TxtCodigoInv.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigoInv.BorderRadius = 7
        Me.Guna2TxtCodigoInv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtCodigoInv.DefaultText = ""
        Me.Guna2TxtCodigoInv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtCodigoInv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtCodigoInv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigoInv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigoInv.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtCodigoInv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigoInv.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtCodigoInv.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigoInv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigoInv.Location = New System.Drawing.Point(537, 121)
        Me.Guna2TxtCodigoInv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCodigoInv.Name = "Guna2TxtCodigoInv"
        Me.Guna2TxtCodigoInv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCodigoInv.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCodigoInv.PlaceholderText = "Código Inventario"
        Me.Guna2TxtCodigoInv.SelectedText = ""
        Me.Guna2TxtCodigoInv.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtCodigoInv.TabIndex = 125
        '
        'Guna2CboEstado
        '
        Me.Guna2CboEstado.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CboEstado.BorderColor = System.Drawing.Color.Black
        Me.Guna2CboEstado.BorderRadius = 7
        Me.Guna2CboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2CboEstado.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2CboEstado.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2CboEstado.ForeColor = System.Drawing.Color.Black
        Me.Guna2CboEstado.ItemHeight = 30
        Me.Guna2CboEstado.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.Guna2CboEstado.Location = New System.Drawing.Point(628, 169)
        Me.Guna2CboEstado.Name = "Guna2CboEstado"
        Me.Guna2CboEstado.Size = New System.Drawing.Size(134, 36)
        Me.Guna2CboEstado.TabIndex = 126
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(545, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 21)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "E. Activo:"
        '
        'Guna2BtnGuardar
        '
        Me.Guna2BtnGuardar.Animated = True
        Me.Guna2BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnGuardar.BorderRadius = 7
        Me.Guna2BtnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnGuardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnGuardar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnGuardar.Location = New System.Drawing.Point(836, 121)
        Me.Guna2BtnGuardar.Name = "Guna2BtnGuardar"
        Me.Guna2BtnGuardar.Size = New System.Drawing.Size(93, 35)
        Me.Guna2BtnGuardar.TabIndex = 128
        Me.Guna2BtnGuardar.Text = "Guardar"
        '
        'Guna2BntEditar
        '
        Me.Guna2BntEditar.Animated = True
        Me.Guna2BntEditar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BntEditar.BorderRadius = 7
        Me.Guna2BntEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BntEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BntEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BntEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BntEditar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BntEditar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BntEditar.ForeColor = System.Drawing.Color.White
        Me.Guna2BntEditar.Location = New System.Drawing.Point(836, 162)
        Me.Guna2BntEditar.Name = "Guna2BntEditar"
        Me.Guna2BntEditar.Size = New System.Drawing.Size(93, 35)
        Me.Guna2BntEditar.TabIndex = 129
        Me.Guna2BntEditar.Text = "Editar"
        '
        'Guna2BtnBorrar
        '
        Me.Guna2BtnBorrar.Animated = True
        Me.Guna2BtnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnBorrar.BorderRadius = 7
        Me.Guna2BtnBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnBorrar.FillColor = System.Drawing.Color.Brown
        Me.Guna2BtnBorrar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnBorrar.Location = New System.Drawing.Point(836, 205)
        Me.Guna2BtnBorrar.Name = "Guna2BtnBorrar"
        Me.Guna2BtnBorrar.Size = New System.Drawing.Size(93, 35)
        Me.Guna2BtnBorrar.TabIndex = 130
        Me.Guna2BtnBorrar.Text = "Eliminar"
        '
        'Guna2BtnBuscar
        '
        Me.Guna2BtnBuscar.Animated = True
        Me.Guna2BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnBuscar.BorderRadius = 7
        Me.Guna2BtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnBuscar.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2BtnBuscar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnBuscar.Location = New System.Drawing.Point(836, 246)
        Me.Guna2BtnBuscar.Name = "Guna2BtnBuscar"
        Me.Guna2BtnBuscar.Size = New System.Drawing.Size(93, 35)
        Me.Guna2BtnBuscar.TabIndex = 131
        Me.Guna2BtnBuscar.Text = "Buscar"
        '
        'TxtCodigoInv
        '
        Me.TxtCodigoInv.Location = New System.Drawing.Point(856, 638)
        Me.TxtCodigoInv.Name = "TxtCodigoInv"
        Me.TxtCodigoInv.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodigoInv.TabIndex = 102
        '
        'CboEstado
        '
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.CboEstado.Location = New System.Drawing.Point(856, 601)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(121, 21)
        Me.CboEstado.TabIndex = 97
        '
        'TxtNserie
        '
        Me.TxtNserie.Location = New System.Drawing.Point(857, 560)
        Me.TxtNserie.Name = "TxtNserie"
        Me.TxtNserie.ReadOnly = True
        Me.TxtNserie.Size = New System.Drawing.Size(120, 20)
        Me.TxtNserie.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(750, 644)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Codigo Inventario"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(750, 607)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(73, 13)
        Me.lblestado.TabIndex = 98
        Me.lblestado.Text = "Estado Activo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(751, 560)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Numero de serie"
        '
        'DTPFechaEntrega
        '
        Me.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaEntrega.Location = New System.Drawing.Point(424, 622)
        Me.DTPFechaEntrega.Name = "DTPFechaEntrega"
        Me.DTPFechaEntrega.Size = New System.Drawing.Size(247, 20)
        Me.DTPFechaEntrega.TabIndex = 94
        '
        'TxtNombreE
        '
        Me.TxtNombreE.Location = New System.Drawing.Point(424, 593)
        Me.TxtNombreE.Name = "TxtNombreE"
        Me.TxtNombreE.ReadOnly = True
        Me.TxtNombreE.Size = New System.Drawing.Size(247, 20)
        Me.TxtNombreE.TabIndex = 100
        '
        'txtNombreArt
        '
        Me.txtNombreArt.Location = New System.Drawing.Point(424, 567)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.ReadOnly = True
        Me.txtNombreArt.Size = New System.Drawing.Size(247, 20)
        Me.txtNombreArt.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 626)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Fecha de Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 597)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Nombre empleado"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(321, 570)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(85, 13)
        Me.lblnombre.TabIndex = 75
        Me.lblnombre.Text = "Nombre  Articulo"
        '
        'BtnCurp
        '
        Me.BtnCurp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCurp.Location = New System.Drawing.Point(173, 593)
        Me.BtnCurp.Name = "BtnCurp"
        Me.BtnCurp.Size = New System.Drawing.Size(28, 24)
        Me.BtnCurp.TabIndex = 106
        Me.BtnCurp.Text = "..."
        Me.BtnCurp.UseVisualStyleBackColor = True
        '
        'Btncodigo
        '
        Me.Btncodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncodigo.Location = New System.Drawing.Point(173, 560)
        Me.Btncodigo.Name = "Btncodigo"
        Me.Btncodigo.Size = New System.Drawing.Size(28, 27)
        Me.Btncodigo.TabIndex = 105
        Me.Btncodigo.Text = "..."
        Me.Btncodigo.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(30, 638)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(236, 31)
        Me.TxtDescripcion.TabIndex = 111
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(30, 612)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.ReadOnly = True
        Me.TxtDepartamento.Size = New System.Drawing.Size(120, 20)
        Me.TxtDepartamento.TabIndex = 108
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(30, 586)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(121, 20)
        Me.TxtCurp.TabIndex = 104
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(30, 560)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodigo.TabIndex = 78
        '
        'FrmCargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1027, 719)
        Me.Controls.Add(Me.Guna2BtnBuscar)
        Me.Controls.Add(Me.Guna2BtnBorrar)
        Me.Controls.Add(Me.Guna2BntEditar)
        Me.Controls.Add(Me.Guna2BtnGuardar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2CboEstado)
        Me.Controls.Add(Me.Guna2TxtCodigoInv)
        Me.Controls.Add(Me.Guna2TxtNSerie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2DTPFechaEntrega)
        Me.Controls.Add(Me.Guna2BtnCurp)
        Me.Controls.Add(Me.Guna2Btncodigo)
        Me.Controls.Add(Me.Guna2TxtNombreE)
        Me.Controls.Add(Me.Guna2TxtNombreArt)
        Me.Controls.Add(Me.Guna2TxtDescripcion)
        Me.Controls.Add(Me.Guna2TxtDepartamento)
        Me.Controls.Add(Me.Guna2TxtCurp)
        Me.Controls.Add(Me.Guna2TxtCodigo)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Controls.Add(Me.TxtIdArticulo)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtDepartamento)
        Me.Controls.Add(Me.BtnCurp)
        Me.Controls.Add(Me.Btncodigo)
        Me.Controls.Add(Me.TxtCurp)
        Me.Controls.Add(Me.TxtCodigoInv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNombreE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.TxtNserie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPFechaEntrega)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.txtNombreArt)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCargoActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargo de Activos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgbCargoActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbCodigoA As RadioButton
    Friend WithEvents Rbfecha As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgbCargoActivos As DataGridView
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtIdArticulo As TextBox
    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents fechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSerie As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Guna2TxtCodigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BtnCurp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Btncodigo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TxtNombreE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNombreArt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDepartamento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtCurp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2DTPFechaEntrega As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2CboEstado As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TxtCodigoInv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNSerie As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BntEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents BtnCurp As Button
    Friend WithEvents Btncodigo As Button
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents TxtCodigoInv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombreE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents CboEstado As ComboBox
    Friend WithEvents TxtNserie As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTPFechaEntrega As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents txtNombreArt As TextBox
    Friend WithEvents lblnombre As Label
End Class
