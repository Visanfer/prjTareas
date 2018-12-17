Option Explicit On

Imports prjControl

Public Class clsTareaLog

    Public mnId_Tarealog As Integer = 0
    Public mnId_Tarea As Integer = 0
    Public mnId_Usuario As Integer = 0
    Public mdFecha As Date = CDate("01/01/2000 00:00:00")
    Public msDescripcion As String = ""

    Public mbEsNuevo As Boolean = True

    Public Function mpsCodigo() As String
        mpsCodigo = "clsTareaLog-" & mnId_Tarealog
    End Function

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from tareas_log where id_tarea_log = " & mnId_Tarealog

        Dim loBaseDatos As New clsBaseDatos
        Dim loDatos As DataTable = loBaseDatos.mfoRecuperaDatos(False, lsSql, "tarea")

        mbEsNuevo = True
        For Each loRow As DataRow In loDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnId_Tarealog = CInt(loRecord("id_tarea_log") & "")
        mnId_Tarea = CInt(loRecord("id_tarea") & "")
        mnId_Usuario = CInt(loRecord("id_usuario") & "")
        mdFecha = CDate(loRecord("fecha") & "")
        msDescripcion = Trim(loRecord("descripcion") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loBaseDatos As New clsBaseDatos

        If mbEsNuevo Then
            ' poner el resto de campos en el orden correspondiente (HECHO)
            lsSql = "insert into tareas_log(id_tarea,id_usuario,fecha,descripcion) values ('" &
                        mnId_Tarea & "','" &
                        mnId_Usuario & "','" &
                        Format(mdFecha, formatoFechahora) & "','" &
                        msDescripcion & "'); SELECT LAST_INSERT_ID();"
            mnId_Tarealog = loBaseDatos.mrEjecutaComandoAI(False, lsSql)
        Else
            ' poner el resto de campos en el orden correspondiente (HECHO)
            lsSql = "update tareas set descripcion = '" & msDescripcion &
                    "' where id_tarea_log = " & mnId_Tarealog
            loBaseDatos.mrEjecutaComando(False, lsSql)
        End If

        mbEsNuevo = False

    End Sub

End Class
