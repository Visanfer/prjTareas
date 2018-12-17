Option Explicit On

Imports prjControl

Public Class frmBusTareas

    Private mbPrimeraVez As Boolean = True
    Private moBuscaTareas As clsBusTareas

    Public Sub mrCargar(ByVal loUsuario As clsUsuario)

        goUsuario = loUsuario
        ' **** recupero los datos del profile **************
        modTareas.goProfile.mrRecuperaDatos()
        ' **************************************************

        Me.ShowDialog()

    End Sub

    Private Sub mrCargaDatos()

        moBuscaTareas = New clsBusTareas
        moBuscaTareas.mnId_Responsable = goUsuario.mnCodigo
        moBuscaTareas.msDesde = Format(DateAdd(DateInterval.Day, -180, Now), formatoFecha)
        moBuscaTareas.msHasta = Format(DateAdd(DateInterval.Day, +1, Now), formatoFecha)
        moBuscaTareas.mrRecuperaTareasEncargadas()

        ' ahora cargo los datos en el grid
        For Each loTarea As clsTarea In moBuscaTareas.mcolEncargadas
            Dim loItem As New ListViewItem
            loItem.Tag = loTarea.mpsCodigo
            loItem.Text = loTarea.mdFecha_Creacion
            loItem.SubItems.Add(mfsUsuarioNombre(loTarea.mnId_Responsable))
            loItem.SubItems.Add(loTarea.msTitulo)
            loItem.SubItems.Add(goBusEstados.mcolEstados(loTarea.mnId_Estado).msNombre)
            lstEntrada.Items.Add(loItem)
        Next

        moBuscaTareas.mnId_Solicitante = goUsuario.mnCodigo
        moBuscaTareas.mrRecuperaTareasSolicitadas()
        ' ahora cargo los datos en el grid
        For Each loTarea As clsTarea In moBuscaTareas.mcolSolicitadas
            Dim loItem As New ListViewItem
            loItem.Tag = loTarea.mpsCodigo
            loItem.Text = loTarea.mdFecha_Creacion
            loItem.SubItems.Add(mfsUsuarioNombre(loTarea.mnId_Solicitante))
            loItem.SubItems.Add(loTarea.msTitulo)
            loItem.SubItems.Add(goBusEstados.mcolEstados(loTarea.mnId_Estado).msNombre)
            lstSalida.Items.Add(loItem)
        Next


    End Sub

    Private Sub frmBusTareas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Enter
                mrEditaTarea
            Case Keys.Escape
                Me.Close()
            Case Keys.F1
                mrNuevaTarea()
        End Select

    End Sub

    Private Sub mrEditaTarea()

        Dim loFormularioTarea As New frmTarea

        If lstEntrada.Focused Then
            Dim loItem As ListViewItem = lstEntrada.SelectedItems(0)
            loFormularioTarea.moTarea = moBuscaTareas.mcolEncargadas(loItem.Tag)
        Else
            Dim loItem As ListViewItem = lstSalida.SelectedItems(0)
            loFormularioTarea.moTarea = moBuscaTareas.mcolSolicitadas(loItem.Tag)
        End If

        loFormularioTarea.mrCargar()

    End Sub

    Private Sub mrNuevaTarea()

        Dim loTarea As New clsTarea
        loTarea.mnId_Solicitante = goUsuario.mnCodigo
        loTarea.mdFecha_Fin_Prevista = DateAdd(DateInterval.Day, 30, Now)

        Dim loFormularioTarea As New frmTarea
        loFormularioTarea.moTarea = loTarea
        loFormularioTarea.mrCargar()

    End Sub

    Private Sub frmBusTareas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If goUsuario Is Nothing Then goUsuario = New clsUsuario
        If goUsuario.mbEsNuevo Then goUsuario.mrBloquear(gnLlave)
        Me.Text = goUsuario.msNombre

        If mbPrimeraVez Then
            mbPrimeraVez = False
            mrCargaDatos()
        End If

    End Sub

End Class