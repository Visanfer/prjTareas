Option Explicit On

Public Class frmTarea

    Private Sub frmTarea_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.F5
                mrGrabar()
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub mrGrabar()

    End Sub

End Class