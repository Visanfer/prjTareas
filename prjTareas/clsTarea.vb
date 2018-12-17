Option Explicit On

Imports prjControl

Public Class clsTarea

    Public mnId_Tarea As Integer = 0
    Public mdFecha_Creacion As Date = Now
    Public mnId_Solicitante As Integer = 0
    Public mnId_Responsable As Integer = 0
    Public msTitulo As String = ""
    Public msDescripcion As String = ""
    Public mnId_Estado As Integer = 0
    Public mdFecha_Inicio_Prevista As Date = CDate("01/01/2000 00:00:00")
    Public mdFecha_Fin_Prevista As Date = CDate("01/01/2000 00:00:00")
    Public mdFecha_Inicio As Date = CDate("01/01/2000 00:00:00")
    Public mdFecha_Fin As Date = CDate("01/01/2000 00:00:00")
    Public mnId_Tarea_Padre As Integer = 0

    Public mcolLog As Collection
    ' poner el resto de campos en el orden correspondiente (HECHO)

    Public mbEsNuevo As Boolean = True

    Public Function mpsCodigo() As String
        mpsCodigo = "clsTarea-" & mnId_Tarea
    End Function

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from tareas where id_tarea = " & mnId_Tarea

        Dim loBaseDatos As New clsBaseDatos
        Dim loDatos As DataTable = loBaseDatos.mfoRecuperaDatos(False, lsSql, "tarea")

        mbEsNuevo = True
        For Each loRow As DataRow In loDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnId_Tarea = CInt(loRecord("id_tarea") & "")
        mdFecha_Creacion = CDate(loRecord("fecha_creacion") & "")
        mnId_Solicitante = CInt(loRecord("id_solicitante") & "")
        mnId_Responsable = CInt(loRecord("id_responsable") & "")
        msTitulo = Trim(loRecord("titulo") & "")
        msDescripcion = Trim(loRecord("descripcion") & "")
        mnId_Estado = Trim(loRecord("id_estado") & "")
        mdFecha_Inicio_Prevista = CDate(loRecord("fecha_inicio_prevista") & "")
        mdFecha_Fin_Prevista = CDate(loRecord("fecha_final_prevista") & "")
        mdFecha_Inicio = CDate(loRecord("fecha_inicio") & "")
        mdFecha_Fin = CDate(loRecord("fecha_final") & "")
        mnId_Tarea_Padre = CInt(loRecord("id_tarea_padre") & "")

        ' poner el resto de campos en el orden correspondiente (HECHO)
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loBaseDatos As New clsBaseDatos

        If mbEsNuevo Then
            ' poner el resto de campos en el orden correspondiente (HECHO)
            lsSql = "insert into tareas(fecha_creacion,id_solicitante,id_responsable,titulo,descripcion,id_estado,fecha_inicio_prevista,fecha_final_prevista,fecha_inicio,fecha_final,id_tarea_padre) values ('" &
                        Format(mdFecha_Creacion, formatoFechahora) & "','" &
                        mnId_Solicitante & "','" &
                        mnId_Responsable & "','" &
                        msTitulo & "','" &
                        msDescripcion & "','" &
                        mnId_Estado & "','" &
                        Format(mdFecha_Inicio_Prevista, formatoFechahora) & "','" &
                        Format(mdFecha_Fin_Prevista, formatoFechahora) & "','" &
                        Format(mdFecha_Inicio, formatoFechahora) & "','" &
                        Format(mdFecha_Fin, formatoFechahora) & "','" &
                        mnId_Tarea_Padre & "'); SELECT LAST_INSERT_ID();"
            mnId_Tarea = loBaseDatos.mrEjecutaComandoAI(False, lsSql)
        Else
            ' poner el resto de campos en el orden correspondiente (HECHO)
            lsSql = "update tareas set fecha_creacion = '" & Format(mdFecha_Creacion, formatoFechahora) &
                    "' id_solicitante = '" & mnId_Solicitante &
                    "' id_responsable = '" & mnId_Responsable &
                    "' titulo = '" & msTitulo &
                    "' descripcion = '" & msDescripcion &
                    "' id_estado = '" & mnId_Estado &
                    "', fecha_inicio_prevista = '" & Format(mdFecha_Inicio_Prevista, formatoFechahora) &
                    "', fecha_fin_prevista = '" & Format(mdFecha_Fin_Prevista, formatoFechahora) &
                    "', fecha_inicio = '" & Format(mdFecha_Inicio, formatoFechahora) &
                    "', fecha_fin = '" & Format(mdFecha_Fin, formatoFechahora) &
                    "' id_tarea_padre = '" & mnId_Tarea_Padre &
                    "' where id_tarea = " & mnId_Tarea
            loBaseDatos.mrEjecutaComando(False, lsSql)
        End If

        mbEsNuevo = False

    End Sub

    Public Sub mrBorraDatos()

        Dim lsSql As String = "delete from tareas where id_tarea = " & mnId_Tarea
        Dim loBaseDatos As New clsBaseDatos
        loBaseDatos.mrEjecutaComando(False, lsSql)

    End Sub

    Public Sub mrRecuperaLog()

        mcolLog = New Collection

        Dim lsSql As String = "select * from tareas_log where id_tarea_log = " & mnId_Tarea &
                                " order by id_tarea_log desc"

        Dim loBaseDatos As New clsBaseDatos
        Dim loDatos As DataTable = loBaseDatos.mfoRecuperaDatos(False, lsSql, "tareas_log")

        For Each loRow As DataRow In loDatos.Rows
            Dim loTareaLog As New clsTareaLog
            loTareaLog.mrCargaDatos(loRow)
            loTareaLog.mbEsNuevo = False
            mcolLog.Add(loTareaLog, loTareaLog.mpsCodigo)
        Next



    End Sub

End Class
