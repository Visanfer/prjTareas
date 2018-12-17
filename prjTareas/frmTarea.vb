Option Explicit On

Imports prjControl

Public Class frmTarea

    Public moTarea As clsTarea

    Private moBusTareas As New clsBusTareas
    Private mbPrimeraVez As Boolean = True

    Public Sub mrCargar()
        Me.ShowDialog()
    End Sub

    Private Sub frmTarea_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Enter
                If Not txtDescripcion.Focused Then SendKeys.Send("{TAB}")
            Case Keys.F9
                mrBuscaUsuario
            Case Keys.F5
                mrGrabar()
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub mrBuscaUsuario()

        prjUsuarios.goUsuario = goUsuario
        Dim loBusUsuario As New prjUsuarios.clsBusUsuarios
        loBusUsuario.msActivos = "S"
        loBusUsuario.mrBuscaUsuarios()

        Dim loBusUsuarios As New prjUsuarios.frmBusUsuarios
        loBusUsuarios.mbSeleccionaUsuario = True
        loBusUsuarios.mrCargar(loBusUsuario)
        If loBusUsuarios.mnUsuarioSeleccionado > 0 Then
            Dim loResponsable As New clsUsuario
            loResponsable.mnCodigo = loBusUsuarios.mnUsuarioSeleccionado
            loResponsable.mrRecuperaDatos()

            lblNombreEncargado.Tag = loBusUsuarios.mnUsuarioSeleccionado
            lblNombreEncargado.Text = loResponsable.msNombre
        End If

    End Sub

    Private Sub mrCargaLog()

        moTarea.mrRecuperaLog()

        For Each loTareaLog As clsTareaLog In moTarea.mcolLog
            Dim loItem As New ListViewItem
            loItem.Text = loTareaLog.mdFecha
            loItem.SubItems.Add(loTareaLog.mnId_Usuario)
            loItem.SubItems.Add(loTareaLog.msDescripcion)
            lstLog.Items.Add(loItem)
        Next

    End Sub

    Private Sub mrCargaEstados()
        cboEstado.Items.Clear()
        For Each loEstado As clsTareaEstado In goBusEstados.mcolEstados
            cboEstado.Items.Add(loEstado.msNombre)
        Next
    End Sub

    Private Sub mrCargarDatos()

        mrCargaEstados()
        mrCargaLog()

        lblNombreSolicitador.Tag = moTarea.mnId_Solicitante
        lblNombreSolicitador.Text = mfsUsuarioNombre(moTarea.mnId_Solicitante)

        dtpFechaFinPrevisto.Value = moTarea.mdFecha_Fin_Prevista
        lblFechaCreacion.Text = Format(moTarea.mdFecha_Creacion, "dd/MM/yyyy")
        txtTitulo.Text = moTarea.msTitulo
        txtDescripcion.Text = moTarea.msDescripcion.Replace("<br>", vbCrLf)

        If moTarea.mbEsNuevo Then
            cboEstado.SelectedIndex = 0
        Else
            cboEstado.Text = goBusEstados.mcolEstados(moTarea.mnId_Estado).msNombre
            lblNombreEncargado.Text = mfsUsuarioNombre(moTarea.mnId_Responsable)
        End If

    End Sub

    Private Sub mrGrabar()

        ' primero reviso que esten todos los campos rellenos
        lblNombreEncargado.BackColor = Color.White
        If lblNombreEncargado.Text.Length = 0 Then
            lblNombreEncargado.BackColor = Color.LightPink
            MsgBox("Debes indicar que usuario será el encargado de la tarea", MsgBoxStyle.Critical, "Visanfer.Net")
            Exit Sub
        End If

        txtTitulo.BackColor = Color.White
        If txtTitulo.Text.Length = 0 Then
            txtTitulo.BackColor = Color.LightPink
            MsgBox("Debes poner algún titulo a la tarea", MsgBoxStyle.Critical, "Visanfer.Net")
            txtTitulo.Focus()
            Exit Sub
        End If

        txtDescripcion.BackColor = Color.White
        If txtDescripcion.Text.Length = 0 Then
            txtDescripcion.BackColor = Color.LightPink
            MsgBox("Debes poner alguna descripcion a la tarea", MsgBoxStyle.Critical, "Visanfer.Net")
            txtDescripcion.Focus()
            Exit Sub
        End If

        ' analisis de los cambios de estado ************
        Dim lbPrimeraGrabacion As Boolean = moTarea.mbEsNuevo

        If Not moTarea.mbEsNuevo Then

            Dim lnEstadoActual As Integer = cboEstado.SelectedIndex + 1
            If lnEstadoActual <> moTarea.mnId_Estado Then

                ' GRABO UN COMENTARIO SOBRE LOS CAMBIOS EN LA TAREA
                Dim loTareaLog As New clsTareaLog
                loTareaLog.mnId_Tarea = moTarea.mnId_Tarea
                loTareaLog.mdFecha = Now
                loTareaLog.mnId_Usuario = goUsuario.mnCodigo
                loTareaLog.msDescripcion = "CAMBIO DE ESTADO [" & goBusEstados.mcolEstados(moTarea.mnId_Estado).msNombre &
                    " -> " & moBusTareas.mcolEstados(lnEstadoActual).msNombre & "]"
                loTareaLog.mrGrabaDatos()

            End If

        End If

        moTarea.mnId_Solicitante = Val(lblNombreSolicitador.Tag)
        moTarea.mnId_Responsable = Val(lblNombreEncargado.Tag)
        moTarea.mnId_Estado = cboEstado.SelectedIndex + 1
        moTarea.msTitulo = txtTitulo.Text
        moTarea.msDescripcion = txtDescripcion.Text.Replace(vbCrLf, "<br>")
        moTarea.mrGrabaDatos()

        ' en la primera grabacion, grabo el log de la creacion
        If lbPrimeraGrabacion Then
            Dim loTareaLog As New clsTareaLog
            loTareaLog.mnId_Tarea = moTarea.mnId_Tarea
            loTareaLog.mdFecha = Now
            loTareaLog.mnId_Usuario = goUsuario.mnCodigo
            loTareaLog.msDescripcion = "CREACION DE LA TAREA"
            loTareaLog.mrGrabaDatos()

            ' CREO UN VIMAIL AVISANDO SOBRE EL TEMA

        End If

        Me.Close()

    End Sub

    Private Sub frmTarea_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If goUsuario Is Nothing Then goUsuario = New clsUsuario
        If goUsuario.mbEsNuevo Then goUsuario.mrBloquear(gnLlave)
        Me.Text = goUsuario.msNombre

        If mbPrimeraVez Then
            mbPrimeraVez = False
            mrCargarDatos()
        End If

    End Sub

End Class