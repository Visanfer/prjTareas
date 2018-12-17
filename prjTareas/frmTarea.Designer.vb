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
        Me.lstLog = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblHistorial = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblEncargado = New System.Windows.Forms.Label()
        Me.LblFechaCreacion1 = New System.Windows.Forms.Label()
        Me.LblFechaPrevistaFinal = New System.Windows.Forms.Label()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.LblFechaFinal = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.BtnF9 = New System.Windows.Forms.Button()
        Me.BtnAsignarOtro = New System.Windows.Forms.Button()
        Me.BtnAñadirComentario = New System.Windows.Forms.Button()
        Me.BtnCrearSubtarea = New System.Windows.Forms.Button()
        Me.LblSolicitador = New System.Windows.Forms.Label()
        Me.dtpFechaFinPrevisto = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.lblNombreEncargado = New System.Windows.Forms.Label()
        Me.lblNombreSolicitador = New System.Windows.Forms.Label()
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
        'lstLog
        '
        Me.lstLog.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader12, Me.ColumnHeader14})
        Me.lstLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLog.FullRowSelect = True
        Me.lstLog.HideSelection = False
        Me.lstLog.Location = New System.Drawing.Point(12, 455)
        Me.lstLog.MultiSelect = False
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(997, 307)
        Me.lstLog.TabIndex = 44
        Me.lstLog.UseCompatibleStateImageBehavior = False
        Me.lstLog.View = System.Windows.Forms.View.Details
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
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(64, 214)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(945, 20)
        Me.txtTitulo.TabIndex = 47
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
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 269)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(997, 156)
        Me.txtDescripcion.TabIndex = 49
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
        'LblFechaCreacion1
        '
        Me.LblFechaCreacion1.AutoSize = True
        Me.LblFechaCreacion1.Location = New System.Drawing.Point(12, 104)
        Me.LblFechaCreacion1.Name = "LblFechaCreacion1"
        Me.LblFechaCreacion1.Size = New System.Drawing.Size(100, 13)
        Me.LblFechaCreacion1.TabIndex = 52
        Me.LblFechaCreacion1.Text = "FECHA CREACION"
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
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"PENDIENTE DE ACEPTAR", "ACEPTADA", "COMENZADA", "TERMINADA", "RECHAZADA"})
        Me.cboEstado.Location = New System.Drawing.Point(706, 48)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(303, 21)
        Me.cboEstado.TabIndex = 61
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
        Me.BtnAsignarOtro.Location = New System.Drawing.Point(765, 128)
        Me.BtnAsignarOtro.Name = "BtnAsignarOtro"
        Me.BtnAsignarOtro.Size = New System.Drawing.Size(244, 23)
        Me.BtnAsignarOtro.TabIndex = 63
        Me.BtnAsignarOtro.Text = "ASIGNAR TAREA A OTRO USUARIO"
        Me.BtnAsignarOtro.UseVisualStyleBackColor = True
        '
        'BtnAñadirComentario
        '
        Me.BtnAñadirComentario.Location = New System.Drawing.Point(765, 155)
        Me.BtnAñadirComentario.Name = "BtnAñadirComentario"
        Me.BtnAñadirComentario.Size = New System.Drawing.Size(244, 23)
        Me.BtnAñadirComentario.TabIndex = 64
        Me.BtnAñadirComentario.Text = "AÑADIR COMENTARIO"
        Me.BtnAñadirComentario.UseVisualStyleBackColor = True
        '
        'BtnCrearSubtarea
        '
        Me.BtnCrearSubtarea.Location = New System.Drawing.Point(765, 101)
        Me.BtnCrearSubtarea.Name = "BtnCrearSubtarea"
        Me.BtnCrearSubtarea.Size = New System.Drawing.Size(244, 23)
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
        'dtpFechaFinPrevisto
        '
        Me.dtpFechaFinPrevisto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinPrevisto.Location = New System.Drawing.Point(166, 127)
        Me.dtpFechaFinPrevisto.Name = "dtpFechaFinPrevisto"
        Me.dtpFechaFinPrevisto.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFinPrevisto.TabIndex = 68
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
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.BackColor = System.Drawing.Color.White
        Me.lblFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaCreacion.Location = New System.Drawing.Point(166, 100)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(100, 20)
        Me.lblFechaCreacion.TabIndex = 71
        Me.lblFechaCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombreEncargado
        '
        Me.lblNombreEncargado.BackColor = System.Drawing.Color.White
        Me.lblNombreEncargado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreEncargado.Location = New System.Drawing.Point(166, 74)
        Me.lblNombreEncargado.Name = "lblNombreEncargado"
        Me.lblNombreEncargado.Size = New System.Drawing.Size(311, 20)
        Me.lblNombreEncargado.TabIndex = 72
        Me.lblNombreEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombreSolicitador
        '
        Me.lblNombreSolicitador.BackColor = System.Drawing.Color.White
        Me.lblNombreSolicitador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreSolicitador.Location = New System.Drawing.Point(166, 48)
        Me.lblNombreSolicitador.Name = "lblNombreSolicitador"
        Me.lblNombreSolicitador.Size = New System.Drawing.Size(311, 20)
        Me.lblNombreSolicitador.TabIndex = 73
        Me.lblNombreSolicitador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 802)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNombreSolicitador)
        Me.Controls.Add(Me.lblNombreEncargado)
        Me.Controls.Add(Me.lblFechaCreacion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpFechaFinPrevisto)
        Me.Controls.Add(Me.LblSolicitador)
        Me.Controls.Add(Me.BtnCrearSubtarea)
        Me.Controls.Add(Me.BtnAñadirComentario)
        Me.Controls.Add(Me.BtnAsignarOtro)
        Me.Controls.Add(Me.BtnF9)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblFechaFinal)
        Me.Controls.Add(Me.LblFechaInicio)
        Me.Controls.Add(Me.LblFechaPrevistaFinal)
        Me.Controls.Add(Me.LblFechaCreacion1)
        Me.Controls.Add(Me.LblEncargado)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.lstLog)
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
    Friend WithEvents lstLog As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents LblHistorial As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents LblEncargado As Label
    Friend WithEvents LblFechaCreacion1 As Label
    Friend WithEvents LblFechaPrevistaFinal As Label
    Friend WithEvents LblFechaInicio As Label
    Friend WithEvents LblFechaFinal As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents BtnF9 As Button
    Friend WithEvents BtnAsignarOtro As Button
    Friend WithEvents BtnAñadirComentario As Button
    Friend WithEvents BtnCrearSubtarea As Button
    Friend WithEvents LblSolicitador As Label
    Friend WithEvents dtpFechaFinPrevisto As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblFechaCreacion As Label
    Friend WithEvents lblNombreEncargado As Label
    Friend WithEvents lblNombreSolicitador As Label
End Class
