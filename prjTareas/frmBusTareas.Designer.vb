<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusTareas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusTareas))
        Me.tmrAvisos = New System.Windows.Forms.Timer(Me.components)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblEncargadas = New System.Windows.Forms.Label()
        Me.LblAsignadas = New System.Windows.Forms.Label()
        Me.lstSalida = New System.Windows.Forms.ListView()
        Me.imgIconos16 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.panCampos = New System.Windows.Forms.Panel()
        Me.lblTeclas = New System.Windows.Forms.Label()
        Me.lstEntrada = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrAvisos
        '
        Me.tmrAvisos.Enabled = True
        Me.tmrAvisos.Interval = 500
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ESTADO"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TITULO"
        Me.ColumnHeader5.Width = 350
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "USUARIO"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FECHA"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'LblEncargadas
        '
        Me.LblEncargadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblEncargadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEncargadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEncargadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblEncargadas.Location = New System.Drawing.Point(8, 336)
        Me.LblEncargadas.Name = "LblEncargadas"
        Me.LblEncargadas.Size = New System.Drawing.Size(34, 320)
        Me.LblEncargadas.TabIndex = 19
        Me.LblEncargadas.Text = "ENCARGADAS"
        Me.LblEncargadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAsignadas
        '
        Me.LblAsignadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblAsignadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAsignadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsignadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblAsignadas.Location = New System.Drawing.Point(8, 3)
        Me.LblAsignadas.Name = "LblAsignadas"
        Me.LblAsignadas.Size = New System.Drawing.Size(34, 327)
        Me.LblAsignadas.TabIndex = 18
        Me.LblAsignadas.Text = "ASIGNADAS"
        Me.LblAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSalida
        '
        Me.lstSalida.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSalida.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader1})
        Me.lstSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSalida.FullRowSelect = True
        Me.lstSalida.HideSelection = False
        Me.lstSalida.Location = New System.Drawing.Point(42, 336)
        Me.lstSalida.MultiSelect = False
        Me.lstSalida.Name = "lstSalida"
        Me.lstSalida.Size = New System.Drawing.Size(950, 320)
        Me.lstSalida.SmallImageList = Me.imgIconos16
        Me.lstSalida.TabIndex = 17
        Me.lstSalida.UseCompatibleStateImageBehavior = False
        Me.lstSalida.View = System.Windows.Forms.View.Details
        '
        'imgIconos16
        '
        Me.imgIconos16.ImageStream = CType(resources.GetObject("imgIconos16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos16.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos16.Images.SetKeyName(0, "")
        Me.imgIconos16.Images.SetKeyName(1, "")
        Me.imgIconos16.Images.SetKeyName(2, "")
        Me.imgIconos16.Images.SetKeyName(3, "")
        Me.imgIconos16.Images.SetKeyName(4, "")
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(12, 9)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(997, 32)
        Me.lblMensaje.TabIndex = 41
        Me.lblMensaje.Text = "BUSQUEDA DE TAREAS"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panCampos
        '
        Me.panCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panCampos.Controls.Add(Me.lstEntrada)
        Me.panCampos.Controls.Add(Me.LblEncargadas)
        Me.panCampos.Controls.Add(Me.LblAsignadas)
        Me.panCampos.Controls.Add(Me.lstSalida)
        Me.panCampos.Location = New System.Drawing.Point(12, 42)
        Me.panCampos.Name = "panCampos"
        Me.panCampos.Size = New System.Drawing.Size(997, 668)
        Me.panCampos.TabIndex = 42
        '
        'lblTeclas
        '
        Me.lblTeclas.BackColor = System.Drawing.Color.Silver
        Me.lblTeclas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeclas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeclas.Location = New System.Drawing.Point(12, 710)
        Me.lblTeclas.Name = "lblTeclas"
        Me.lblTeclas.Size = New System.Drawing.Size(997, 28)
        Me.lblTeclas.TabIndex = 40
        Me.lblTeclas.Text = "F1 - NUEVA TAREA                      ESC - SALIR"
        Me.lblTeclas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstEntrada
        '
        Me.lstEntrada.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstEntrada.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEntrada.FullRowSelect = True
        Me.lstEntrada.HideSelection = False
        Me.lstEntrada.Location = New System.Drawing.Point(42, 3)
        Me.lstEntrada.MultiSelect = False
        Me.lstEntrada.Name = "lstEntrada"
        Me.lstEntrada.Size = New System.Drawing.Size(950, 327)
        Me.lstEntrada.SmallImageList = Me.imgIconos16
        Me.lstEntrada.TabIndex = 20
        Me.lstEntrada.UseCompatibleStateImageBehavior = False
        Me.lstEntrada.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FECHA"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "USUARIO"
        Me.ColumnHeader6.Width = 250
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TITULO"
        Me.ColumnHeader7.Width = 350
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ESTADO"
        Me.ColumnHeader8.Width = 150
        '
        'frmBusTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.panCampos)
        Me.Controls.Add(Me.lblTeclas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmBusTareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBusTareas"
        Me.panCampos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrAvisos As Timer
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents LblEncargadas As Label
    Friend WithEvents LblAsignadas As Label
    Friend WithEvents lstSalida As ListView
    Friend WithEvents imgIconos16 As ImageList
    Friend WithEvents lblMensaje As Label
    Friend WithEvents panCampos As Panel
    Friend WithEvents lblTeclas As Label
    Friend WithEvents lstEntrada As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
