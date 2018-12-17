Public Class frmEstados

    Private Sub frmEstados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData

            Case Keys.F1
               ' mrNuevaTarea()
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub frmEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class