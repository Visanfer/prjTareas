Option Explicit On

Public Class frmComentario

    Public moTarea As clsTarea
    Public mbComentarioAñadido As Boolean = False

    Public Sub mrCargar()
        Me.Text = moTarea.msTitulo
        Me.ShowDialog()
    End Sub

    Private Sub frmComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Escape
                Me.Close()
            Case Keys.F5
                mrGrabar
        End Select

    End Sub

    Private Sub mrGrabar()

        mbComentarioAñadido = True

        Dim loTareaLog As New clsTareaLog
        loTareaLog.mnId_Tarea = moTarea.mnId_Tarea
        loTareaLog.mdFecha = Now
        loTareaLog.mnId_Usuario = goUsuario.mnCodigo
        loTareaLog.msDescripcion = TxtComentario.Text.Replace(vbCrLf, "<br>")
        loTareaLog.mrGrabaDatos()

        If chkVimail.Checked Then
            ' CREO UN VIMAIL AVISANDO SOBRE cambio de estado
            Dim lnParaQuien As Integer = 0
            If moTarea.mnId_Solicitante = goUsuario.mnCodigo Then
                lnParaQuien = moTarea.mnId_Responsable
            Else
                lnParaQuien = moTarea.mnId_Solicitante
            End If
            mrMandaVimail(goUsuario.mnCodigo, lnParaQuien, moTarea.msTitulo, "COMENTARIO:" & vbCrLf & TxtComentario.Text)
        End If

        Me.Close()

    End Sub

End Class