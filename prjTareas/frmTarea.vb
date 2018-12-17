﻿Option Explicit On

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
                If btnF9.Visible Then mrBuscaUsuario()
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

            lblNombreResponsable.Tag = loBusUsuarios.mnUsuarioSeleccionado
            lblNombreResponsable.Text = loResponsable.msNombre
        End If

    End Sub

    Private Sub mrCargaLog()

        moTarea.mrRecuperaLog()

        lstLog.Items.Clear()
        For Each loTareaLog As clsTareaLog In moTarea.mcolLog
            Dim loItem As New ListViewItem
            loItem.Text = loTareaLog.mdFecha
            loItem.SubItems.Add(mfsUsuarioNombre(loTareaLog.mnId_Usuario))
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

        lblNombreSolicitante.Tag = moTarea.mnId_Solicitante
        lblNombreSolicitante.Text = mfsUsuarioNombre(moTarea.mnId_Solicitante)

        lblFechaCreacion.Text = Format(moTarea.mdFecha_Creacion, "dd/MM/yyyy")
        If moTarea.mdFecha_Fin <> "01/01/2000" Then LblFechaFinal.Text = Format(moTarea.mdFecha_Fin, "dd/MM/yyyy")
        If moTarea.mdFecha_Inicio <> "01/01/2000" Then LblFechaInicio.Text = Format(moTarea.mdFecha_Inicio, "dd/MM/yyyy")

        txtTitulo.Text = moTarea.msTitulo
        txtDescripcion.Text = moTarea.msDescripcion.Replace("<br>", vbCrLf)

        If moTarea.mbEsNuevo Then
            cboEstado.SelectedIndex = 0
        Else
            cboEstado.Text = goBusEstados.mcolEstados(moTarea.mnId_Estado - 1).msNombre
            lblNombreResponsable.Tag = moTarea.mnId_Responsable
            lblNombreResponsable.Text = mfsUsuarioNombre(moTarea.mnId_Responsable)
        End If

        ' CONTROL QUE PUEDE HACER CADA UNO
        If goUsuario.mnCodigo = moTarea.mnId_Solicitante Then
            BtnAsignarOtro.Visible = False
            BtnCrearSubtarea.Visible = False
            cboEstado.Enabled = False
            If Not moTarea.mbEsNuevo Then btnF9.Visible = False
        End If

        If moTarea.mbEsNuevo Then
            BtnAsignarOtro.Visible = False
            BtnCrearSubtarea.Visible = False
            BtnAñadirComentario.Visible = False
            cboEstado.Enabled = False
        End If

    End Sub

    Private Sub mrGrabar()

        ' primero reviso que esten todos los campos rellenos
        lblNombreResponsable.BackColor = Color.White
        If lblNombreResponsable.Text.Length = 0 Then
            lblNombreResponsable.BackColor = Color.LightPink
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

                ' si el estado final es comenzada pongo la fecha comienzo
                If lnEstadoActual = 3 Then moTarea.mdFecha_Inicio = Now
                If lnEstadoActual = 4 Then moTarea.mdFecha_Fin = Now

                ' GRABO UN COMENTARIO SOBRE LOS CAMBIOS EN LA TAREA
                Dim loTareaLog As New clsTareaLog
                loTareaLog.mnId_Tarea = moTarea.mnId_Tarea
                loTareaLog.mdFecha = Now
                loTareaLog.mnId_Usuario = goUsuario.mnCodigo
                loTareaLog.msDescripcion = "CAMBIO DE ESTADO [" & goBusEstados.mcolEstados(moTarea.mnId_Estado - 1).msNombre &
                    " -> " & goBusEstados.mcolEstados(lnEstadoActual - 1).msNombre & "]"
                loTareaLog.mrGrabaDatos()

                ' CREO UN VIMAIL AVISANDO SOBRE cambio de estado
                mrMandaVimail(moTarea.mnId_Responsable, moTarea.mnId_Solicitante, moTarea.msTitulo, "CAMBIO DE ESTADO EN TAREA")

            End If

        End If

        moTarea.mnId_Solicitante = Val(lblNombreSolicitante.Tag)
        moTarea.mnId_Responsable = Val(lblNombreResponsable.Tag)
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
            If moTarea.mnId_Tarea_Padre > 0 Then loTareaLog.msDescripcion = "CREACION DE LA SUBTAREA"
            loTareaLog.mrGrabaDatos()

            ' CREO UN VIMAIL AVISANDO SOBRE EL TEMA
            mrMandaVimail(moTarea.mnId_Solicitante, moTarea.mnId_Responsable, moTarea.msTitulo, "TIENES UNA NUEVA TAREA")

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

    Private Sub BtnF9_Click(sender As Object, e As EventArgs) Handles btnF9.Click
        mrBuscaUsuario()
    End Sub

    Private Sub BtnAsignarOtro_Click(sender As Object, e As EventArgs) Handles BtnAsignarOtro.Click

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

            lblNombreResponsable.Tag = loBusUsuarios.mnUsuarioSeleccionado
            lblNombreResponsable.Text = loResponsable.msNombre

            Dim loTareaLog As New clsTareaLog
            loTareaLog.mnId_Tarea = moTarea.mnId_Tarea
            loTareaLog.mdFecha = Now
            loTareaLog.mnId_Usuario = goUsuario.mnCodigo
            loTareaLog.msDescripcion = "CAMBIO DE RESPONSABLE [" & loBusUsuarios.mnUsuarioSeleccionado & " " &
                mfsUsuarioNombre(loBusUsuarios.mnUsuarioSeleccionado) & "]"
            loTareaLog.mrGrabaDatos()

            ' CREO UN VIMAIL AVISANDO SOBRE cambio de USUARIO
            mrMandaVimail(goUsuario.mnCodigo, moTarea.mnId_Solicitante, moTarea.msTitulo, "CAMBIO DE RESPONSABLE EN TAREA")

            moTarea.mnId_Responsable = loBusUsuarios.mnUsuarioSeleccionado
            moTarea.mrGrabaDatos()

            mrCargaLog()

        End If

    End Sub

    Private Sub BtnAñadirComentario_Click(sender As Object, e As EventArgs) Handles BtnAñadirComentario.Click
        Dim loComentario As New frmComentario
        loComentario.moTarea = moTarea
        loComentario.mrCargar()

        If loComentario.mbComentarioAñadido Then mrCargaLog()
    End Sub

    Private Sub BtnCrearSubtarea_Click(sender As Object, e As EventArgs) Handles BtnCrearSubtarea.Click
        mrSubNuevaTarea()
    End Sub

    Private Sub mrSubNuevaTarea()

        Dim loTarea As New clsTarea
        loTarea.mnId_Solicitante = goUsuario.mnCodigo
        loTarea.mnId_Tarea_Padre = moTarea.mnId_Tarea

        Dim loFormularioTarea As New frmTarea
        loFormularioTarea.moTarea = loTarea
        loFormularioTarea.mrCargar()

    End Sub

End Class