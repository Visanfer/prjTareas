Option Explicit On

Public Class frmBusTareas

    Private Sub frmBusTareas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Escape
                Me.Close()
            Case Keys.F1
                mrNuevaTarea()
        End Select

    End Sub

    Private Sub mrNuevaTarea()
        Dim loTarea As New frmTarea
        loTarea.ShowDialog()
    End Sub

    Private Sub frmBusTareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class