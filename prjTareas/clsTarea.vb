Option Explicit On

Imports prjControl

Public Class clsTarea

    Public mnId_Tarea As Integer = 0
    Public mdFecha_Creacion As Date = Now
    Public msTitulo As String = ""
    Public mdFecha_Inicio_Prevista As Date = CDate("01/01/2000 00:00:00")
    ' poner el resto de campos en el orden correspondiente

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
        msTitulo = Trim(loRecord("titulo") & "")
        ' poner el resto de campos en el orden correspondiente
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loBaseDatos As New clsBaseDatos

        If mbEsNuevo Then
            ' poner el resto de campos en el orden correspondiente
            lsSql = "insert into tareas(campos,...) values ('" &
                        Format(mdFecha_Creacion, formatoFechahora) & "','" &
                        msTitulo & "'," &
                        mnId_Tarea & "); SELECT LAST_INSERT_ID();"
            mnId_Tarea = loBaseDatos.mrEjecutaComandoAI(False, lsSql)
        Else
            ' poner el resto de campos en el orden correspondiente
            lsSql = "update tareas set titulo = '" & msTitulo &
                    "', fecha_inicio_prevista = '" & Format(mdFecha_Inicio_Prevista, formatoFechahora) &
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

End Class
