Option Explicit On

Imports prjControl

Public Class clsTareaEstado

    Public mnId_Estado As Integer = 0
    Public msNombre As String = ""

    Public mbEsNuevo As Boolean = True

    Public Function mpsCodigo() As String
        mpsCodigo = "clsTareaEstado-" & mnId_Estado
    End Function

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from tareas_estados where id_estado = " & mnId_Estado

        Dim loBaseDatos As New clsBaseDatos
        Dim loDatos As DataTable = loBaseDatos.mfoRecuperaDatos(False, lsSql, "tareas_estados")

        mbEsNuevo = True
        For Each loRow As DataRow In loDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnId_Estado = CInt(loRecord("id_estado") & "")
        msNombre = Trim(loRecord("nombre") & "")
    End Sub

End Class
