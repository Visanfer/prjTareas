<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarea
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
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblTeclas = New System.Windows.Forms.Label()
        Me.lstEntrada = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblHistorial = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblEncargado = New System.Windows.Forms.Label()
        Me.LblFechaCreacion = New System.Windows.Forms.Label()
        Me.LblFechaPrevistaFinal = New System.Windows.Forms.Label()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.LblFechaFinal = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.BtnF9 = New System.Windows.Forms.Button()
        Me.BtnAsignarOtro = New System.Windows.Forms.Button()
        Me.BtnAñadirComentario = New System.Windows.Forms.Button()
        Me.BtnCrearSubtarea = New System.Windows.Forms.Button()
        Me.LblSolicitador = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(12, 9)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(997, 32)
        Me.lblMensaje.TabIndex = 42
        Me.lblMensaje.Text = "MANTENIMIENTO DE TAREAS"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeclas
        '
        Me.lblTeclas.BackColor = System.Drawing.Color.Silver
        Me.lblTeclas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeclas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeclas.Location = New System.Drawing.Point(12, 765)
        Me.lblTeclas.Name = "lblTeclas"
        Me.lblTeclas.Size = New System.Drawing.Size(997, 28)
        Me.lblTeclas.TabIndex = 43
        Me.lblTeclas.Text = "F5 - GRABAR CAMBIOS                      ESC - SALIR"
        Me.lblTeclas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstEntrada
        '
        Me.lstEntrada.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstEntrada.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader12, Me.ColumnHeader14})
        Me.lstEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEntrada.HideSelection = False
        Me.lstEntrada.Location = New System.Drawing.Point(12, 455)
        Me.lstEntrada.MultiSelect = False
        Me.lstEntrada.Name = "lstEntrada"
        Me.lstEntrada.Size = New System.Drawing.Size(997, 307)
        Me.lstEntrada.TabIndex = 44
        Me.lstEntrada.UseCompatibleStateImageBehavior = False
        Me.lstEntrada.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "UR"
        Me.ColumnHeader11.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "FECHA"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "HORA"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ORIGEN"
        Me.ColumnHeader9.Width = 250
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ASUNTO"
        Me.ColumnHeader10.Width = 350
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "LEI"
        Me.ColumnHeader12.Width = 40
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "CON"
        Me.ColumnHeader14.Width = 40
        '
        'LblHistorial
        '
        Me.LblHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHistorial.Location = New System.Drawing.Point(12, 428)
        Me.LblHistorial.Name = "LblHistorial"
        Me.LblHistorial.Size = New System.Drawing.Size(997, 34)
        Me.LblHistorial.TabIndex = 45
        Me.LblHistorial.Text = "HISTORIAL"
        Me.LblHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Location = New System.Drawing.Point(12, 218)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(46, 13)
        Me.LblTitulo.TabIndex = 46
        Me.LblTitulo.Text = "TITULO"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(64, 214)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(945, 20)
        Me.TxtTitulo.TabIndex = 47
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(12, 253)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(80, 13)
        Me.LblDescripcion.TabIndex = 48
        Me.LblDescripcion.Text = "DESCRIPCION"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(12, 269)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(997, 156)
        Me.TxtDescripcion.TabIndex = 49
        '
        'LblEncargado
        '
        Me.LblEncargado.AutoSize = True
        Me.LblEncargado.Location = New System.Drawing.Point(12, 78)
        Me.LblEncargado.Name = "LblEncargado"
        Me.LblEncargado.Size = New System.Drawing.Size(75, 13)
        Me.LblEncargado.TabIndex = 50
        Me.LblEncargado.Text = "ENCARGADO"
        '
        'LblFechaCreacion
        '
        Me.LblFechaCreacion.AutoSize = True
        Me.LblFechaCreacion.Location = New System.Drawing.Point(12, 104)
        Me.LblFechaCreacion.Name = "LblFechaCreacion"
        Me.LblFechaCreacion.Size = New System.Drawing.Size(100, 13)
        Me.LblFechaCreacion.TabIndex = 52
        Me.LblFechaCreacion.Text = "FECHA CREACION"
        '
        'LblFechaPrevistaFinal
        '
        Me.LblFechaPrevistaFinal.AutoSize = True
        Me.LblFechaPrevistaFinal.Location = New System.Drawing.Point(12, 130)
        Me.LblFechaPrevistaFinal.Name = "LblFechaPrevistaFinal"
        Me.LblFechaPrevistaFinal.Size = New System.Drawing.Size(131, 13)
        Me.LblFechaPrevistaFinal.TabIndex = 54
        Me.LblFechaPrevistaFinal.Text = "FECHA PREVISTA FINAL"
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Location = New System.Drawing.Point(12, 156)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(77, 13)
        Me.LblFechaInicio.TabIndex = 56
        Me.LblFechaInicio.Text = "FECHA INICIO"
        '
        'LblFechaFinal
        '
        Me.LblFechaFinal.AutoSize = True
        Me.LblFechaFinal.Location = New System.Drawing.Point(12, 182)
        Me.LblFechaFinal.Name = "LblFechaFinal"
        Me.LblFechaFinal.Size = New System.Drawing.Size(75, 13)
        Me.LblFechaFinal.TabIndex = 58
        Me.LblFechaFinal.Text = "FECHA FINAL"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(649, 52)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(51, 13)
        Me.LblEstado.TabIndex = 60
        Me.LblEstado.Text = "ESTADO"
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Items.AddRange(New Object() {"PENDIENTE DE ACEPTAR", "ACEPTADA", "COMENZADA", "TERMINADA", "RECHAZADA"})
        Me.CboEstado.Location = New System.Drawing.Point(706, 48)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(303, 21)
        Me.CboEstado.TabIndex = 61
        '
        'BtnF9
        '
        Me.BtnF9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnF9.Location = New System.Drawing.Point(477, 74)
        Me.BtnF9.Name = "BtnF9"
        Me.BtnF9.Size = New System.Drawing.Size(27, 20)
        Me.BtnF9.TabIndex = 62
        Me.BtnF9.Text = "F9"
        Me.BtnF9.UseVisualStyleBackColor = True
        '
        'BtnAsignarOtro
        '
        Me.BtnAsignarOtro.Location = New System.Drawing.Point(828, 128)
        Me.BtnAsignarOtro.Name = "BtnAsignarOtro"
        Me.BtnAsignarOtro.Size = New System.Drawing.Size(181, 23)
        Me.BtnAsignarOtro.TabIndex = 63
        Me.BtnAsignarOtro.Text = "ASIGNAR TAREA A OTRO USUARIO"
        Me.BtnAsignarOtro.UseVisualStyleBackColor = True
        '
        'BtnAñadirComentario
        '
        Me.BtnAñadirComentario.Location = New System.Drawing.Point(828, 155)
        Me.BtnAñadirComentario.Name = "BtnAñadirComentario"
        Me.BtnAñadirComentario.Size = New System.Drawing.Size(181, 23)
        Me.BtnAñadirComentario.TabIndex = 64
        Me.BtnAñadirComentario.Text = "AÑADIR COMENTARIO"
        Me.BtnAñadirComentario.UseVisualStyleBackColor = True
        '
        'BtnCrearSubtarea
        '
        Me.BtnCrearSubtarea.Location = New System.Drawing.Point(828, 101)
        Me.BtnCrearSubtarea.Name = "BtnCrearSubtarea"
        Me.BtnCrearSubtarea.Size = New System.Drawing.Size(181, 23)
        Me.BtnCrearSubtarea.TabIndex = 65
        Me.BtnCrearSubtarea.Text = "CREAR SUBTAREA"
        Me.BtnCrearSubtarea.UseVisualStyleBackColor = True
        '
        'LblSolicitador
        '
        Me.LblSolicitador.AutoSize = True
        Me.LblSolicitador.Location = New System.Drawing.Point(12, 52)
        Me.LblSolicitador.Name = "LblSolicitador"
        Me.LblSolicitador.Size = New System.Drawing.Size(79, 13)
        Me.LblSolicitador.TabIndex = 66
        Me.LblSolicitador.Text = "SOLICITADOR"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 127)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(166, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 20)
        Me.Label11.TabIndex = 69
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(166, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 70
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(166, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 20)
        Me.Label13.TabIndex = 71
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(166, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(311, 20)
        Me.Label14.TabIndex = 72
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(166, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(311, 20)
        Me.Label15.TabIndex = 73
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 802)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LblSolicitador)
        Me.Controls.Add(Me.BtnCrearSubtarea)
        Me.Controls.Add(Me.BtnAñadirComentario)
        Me.Controls.Add(Me.BtnAsignarOtro)
        Me.Controls.Add(Me.BtnF9)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblFechaFinal)
        Me.Controls.Add(Me.LblFechaInicio)
        Me.Controls.Add(Me.LblFechaPrevistaFinal)
        Me.Controls.Add(Me.LblFechaCreacion)
        Me.Controls.Add(Me.LblEncargado)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.TxtTitulo)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.lstEntrada)
        Me.Controls.Add(Me.lblTeclas)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.LblHistorial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmTarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTarea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMensaje As Label
    Friend WithEvents lblTeclas As Label
    Friend WithEvents lstEntrada As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents LblHistorial As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LblEncargado As Label
    Friend WithEvents LblFechaCreacion As Label
    Friend WithEvents LblFechaPrevistaFinal As Label
    Friend WithEvents LblFechaInicio As Label
    Friend WithEvents LblFechaFinal As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents CboEstado As ComboBox
    Friend WithEvents BtnF9 As Button
    Friend WithEvents BtnAsignarOtro As Button
    Friend WithEvents BtnAñadirComentario As Button
    Friend WithEvents BtnCrearSubtarea As Button
    Friend WithEvents LblSolicitador As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
