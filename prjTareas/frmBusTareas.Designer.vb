﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tmrAvisos = New System.Windows.Forms.Timer(Me.components)
        Me.lblTeclas = New System.Windows.Forms.Label()
        Me.lstEntrada = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblEncargadas = New System.Windows.Forms.Label()
        Me.LblAsignadas = New System.Windows.Forms.Label()
        Me.lstSalida = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'tmrAvisos
        '
        Me.tmrAvisos.Enabled = True
        Me.tmrAvisos.Interval = 500
        '
        'lblTeclas
        '
        Me.lblTeclas.BackColor = System.Drawing.Color.Silver
        Me.lblTeclas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeclas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeclas.Location = New System.Drawing.Point(14, 700)
        Me.lblTeclas.Name = "lblTeclas"
        Me.lblTeclas.Size = New System.Drawing.Size(982, 28)
        Me.lblTeclas.TabIndex = 40
        Me.lblTeclas.Text = "F1 - NUEVA TAREA                        INTRO - EDITAR TAREA                     " &
    "     ESC - SALIR"
        Me.lblTeclas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstEntrada
        '
        Me.lstEntrada.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstEntrada.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEntrada.FullRowSelect = True
        Me.lstEntrada.GridLines = True
        Me.lstEntrada.HideSelection = False
        Me.lstEntrada.Location = New System.Drawing.Point(14, 41)
        Me.lstEntrada.MultiSelect = False
        Me.lstEntrada.Name = "lstEntrada"
        Me.lstEntrada.Size = New System.Drawing.Size(982, 307)
        Me.lstEntrada.TabIndex = 45
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
        Me.ColumnHeader8.Width = 200
        '
        'LblEncargadas
        '
        Me.LblEncargadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblEncargadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEncargadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEncargadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblEncargadas.Location = New System.Drawing.Point(14, 348)
        Me.LblEncargadas.Name = "LblEncargadas"
        Me.LblEncargadas.Size = New System.Drawing.Size(982, 32)
        Me.LblEncargadas.TabIndex = 44
        Me.LblEncargadas.Text = "TAREAS QUE HE ENCARGADO A OTRAS PERSONAS"
        Me.LblEncargadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAsignadas
        '
        Me.LblAsignadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblAsignadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAsignadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsignadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblAsignadas.Location = New System.Drawing.Point(14, 9)
        Me.LblAsignadas.Name = "LblAsignadas"
        Me.LblAsignadas.Size = New System.Drawing.Size(982, 32)
        Me.LblAsignadas.TabIndex = 43
        Me.LblAsignadas.Text = "TAREAS QUE TENGO QUE REALIZAR YO"
        Me.LblAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSalida
        '
        Me.lstSalida.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSalida.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader1})
        Me.lstSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSalida.FullRowSelect = True
        Me.lstSalida.GridLines = True
        Me.lstSalida.HideSelection = False
        Me.lstSalida.Location = New System.Drawing.Point(14, 380)
        Me.lstSalida.MultiSelect = False
        Me.lstSalida.Name = "lstSalida"
        Me.lstSalida.Size = New System.Drawing.Size(982, 320)
        Me.lstSalida.TabIndex = 42
        Me.lstSalida.UseCompatibleStateImageBehavior = False
        Me.lstSalida.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FECHA"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "USUARIO"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TITULO"
        Me.ColumnHeader5.Width = 350
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ESTADO"
        Me.ColumnHeader1.Width = 200
        '
        'frmBusTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstEntrada)
        Me.Controls.Add(Me.LblEncargadas)
        Me.Controls.Add(Me.LblAsignadas)
        Me.Controls.Add(Me.lstSalida)
        Me.Controls.Add(Me.lblTeclas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmBusTareas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBusTareas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrAvisos As Timer
    Friend WithEvents lblTeclas As Label
    Friend WithEvents lstEntrada As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents LblEncargadas As Label
    Friend WithEvents LblAsignadas As Label
    Friend WithEvents lstSalida As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
