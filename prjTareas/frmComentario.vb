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
        loTareaLog.msDescripcion = "COMENTARIO [" & TxtComentario.Text & "]"
        loTareaLog.mrGrabaDatos()

        Me.Close()

    End Sub

End Class