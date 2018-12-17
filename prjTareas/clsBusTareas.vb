Option Explicit On

Imports prjControl

Public Class clsBusTareas

    Public mnId_Solicitante As Integer = 0
    Public mnId_Responsable As Integer = 0

    Public msDesde As String = ""
    Public msHasta As String = ""
    Public mnId_Estado As Integer = 0

    Public mcolSolicitadas As Collection
    Public mcolEncargadas As Collection
    Public mcolEstados As List(Of clsTareaEstado)

    Public Sub mrRecuperaEstados()

        mcolEstados = New List(Of clsTareaEstado)

        Dim lsSql As String = "select * from tareas_estados order by id_estado"

        Dim loBaseDatos As New clsBaseDatos
        Dim loDatos As DataTable = loBaseDatos.mfoRecuperaDatos(False, lsSql, "tarea_estados")

        For Each loRow As DataRow In loDatos.Rows
            Dim loTareaEstado As New clsTareaEstado
            loTareaEstado.mrCargaDatos(loRow)
            loTareaEstado.mbEsNuevo = False
            mcolEstados.Add(loTareaEstado)
        Next

    End Sub

    Public Sub mrRecuperaTareasSolicitadas()

        mcolSolicitadas = New Collection

        Dim lsSql As String = "select * from tareas where id_solicitante = " & mnId_Solicitante
        If msDesde.Length > 0 Then
            lsSql = lsSql & " and fecha_creacion between '" & msDesde &
                "' and '" & msHasta & "'"
        End If
        If mnId_Estado > 0 Then lsSql = lsSql & " and id_estado = " & mnId_Estado

        Dim loBaseDatos As New clsBaseDatos
        Dim loDatos As DataTable = loBaseDatos.mfoRecuperaDatos(False, lsSql, "tarea")

        For Each loRow As DataRow In loDatos.Rows
            Dim loTarea As New clsTarea
            loTarea.mrCargaDatos(loRow)
            loTarea.mbEsNuevo = False
            mcolSolicitadas.Add(loTarea, loTarea.mpsCodigo)
        Next

    End Sub

    Public Sub mrRecuperaTareasEncargadas()

        mcolEncargadas = New Collection

        Dim lsSql As String = "select * from tareas where id_responsable = " & mnId_Responsable
        If msDesde.Length > 0 Then
            lsSql = lsSql & " and fecha_creacion between '" & msDesde &
                "' and '" & msHasta & "'"
        End If
        If mnId_Estado > 0 Then lsSql = lsSql & " and id_estado = " & mnId_Estado

        Dim loBaseDatos As New clsBaseDatos
        Dim loDatos As DataTable = loBaseDatos.mfoRecuperaDatos(False, lsSql, "tarea")

        For Each loRow As DataRow In loDatos.Rows
            Dim loTarea As New clsTarea
            loTarea.mrCargaDatos(loRow)
            loTarea.mbEsNuevo = False
            mcolEncargadas.Add(loTarea, loTarea.mpsCodigo)
        Next



    End Sub

End Class
