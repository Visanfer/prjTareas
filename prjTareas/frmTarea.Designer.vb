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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(997, 34)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "HISTORIAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "TITULO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 214)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(945, 20)
        Me.TextBox1.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "DESCRIPCION"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 269)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(997, 156)
        Me.TextBox2.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "ENCARGADO"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(166, 75)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(311, 20)
        Me.TextBox3.TabIndex = 51
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(166, 101)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "FECHA CREACION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "FECHA PREVISTA FINAL"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(166, 153)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "FECHA INICIO"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(166, 179)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "FECHA FINAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(649, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "ESTADO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PENDIENTE DE ACEPTAR", "ACEPTADA", "COMENZADA", "TERMINADA", "RECHAZADA"})
        Me.ComboBox1.Location = New System.Drawing.Point(706, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(303, 21)
        Me.ComboBox1.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(477, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 20)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "F9"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(828, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 23)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "ASIGNAR TAREA A OTRO USUARIO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(828, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "AÑADIR COMENTARIO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(828, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 23)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "CREAR SUBTAREA"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(166, 49)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(311, 20)
        Me.TextBox8.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "SOLICITADOR"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 127)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 68
        '
        'frmTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 802)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstEntrada)
        Me.Controls.Add(Me.lblTeclas)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTarea"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
