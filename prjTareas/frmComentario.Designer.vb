<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComentario
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
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.lblTeclas = New System.Windows.Forms.Label()
        Me.chkVimail = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(12, 9)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(584, 32)
        Me.lblMensaje.TabIndex = 43
        Me.lblMensaje.Text = "AÑADIR COMENTARIO"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtComentario
        '
        Me.TxtComentario.Location = New System.Drawing.Point(12, 44)
        Me.TxtComentario.MaxLength = 300
        Me.TxtComentario.Multiline = True
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(584, 156)
        Me.TxtComentario.TabIndex = 50
        '
        'lblTeclas
        '
        Me.lblTeclas.BackColor = System.Drawing.Color.Silver
        Me.lblTeclas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeclas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeclas.Location = New System.Drawing.Point(12, 230)
        Me.lblTeclas.Name = "lblTeclas"
        Me.lblTeclas.Size = New System.Drawing.Size(584, 28)
        Me.lblTeclas.TabIndex = 51
        Me.lblTeclas.Text = "F5 - GRABAR                      ESC - SALIR"
        Me.lblTeclas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkVimail
        '
        Me.chkVimail.AutoSize = True
        Me.chkVimail.Location = New System.Drawing.Point(13, 207)
        Me.chkVimail.Name = "chkVimail"
        Me.chkVimail.Size = New System.Drawing.Size(288, 17)
        Me.chkVimail.TabIndex = 52
        Me.chkVimail.Text = "INFORMAR MEDIANTE UN VIMAIL AL SOLICITANTE"
        Me.chkVimail.UseVisualStyleBackColor = True
        '
        'frmComentario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkVimail)
        Me.Controls.Add(Me.lblTeclas)
        Me.Controls.Add(Me.TxtComentario)
        Me.Controls.Add(Me.lblMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(624, 306)
        Me.MinimumSize = New System.Drawing.Size(624, 306)
        Me.Name = "frmComentario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmComentario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMensaje As Label
    Friend WithEvents TxtComentario As TextBox
    Friend WithEvents lblTeclas As Label
    Friend WithEvents chkVimail As CheckBox
End Class
