Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsTarea

    Public mnId_Tarea As Integer = 0
    Public mdFecha_Creacion As Date = Now
    Public msTitulo As String = ""
    Public mdFecha_Inicio_Prevista As Date = CDate("01/01/2000 00:00:00")

    Public mbEsNuevo As Boolean = True

    Public Function mpsCodigo() As String
        mpsCodigo = "clsTarea-" & mnId_Tarea
    End Function

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from tareas where id_tarea = " & mnId_Tarea
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "posicion")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnId_Tarea = CInt(loRecord("id_tarea") & "")
        mdFecha_Creacion = CDate(loRecord("fecha_creacion") & "")
        msTitulo = Trim(loRecord("titulo") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into tareas(campos,...) values ('" &
                        Format(mdFecha_Creacion, formatoFecha) & "','" &
                        msTitulo & "'," &
                        mnId_Tarea & "); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnId_Tarea = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update tareas set titulo = '" & msTitulo &
                    "', fecha_inicio_prevista = '" & Format(mdFecha_Inicio_Prevista, formatoFecha) &
                    "' where id_tarea = " & mnId_Tarea
            loComando = New MySqlCommand(lsSql, lconConexion)
            loComando.ExecuteNonQuery()
        End If
        lconConexion.Close()

        mbEsNuevo = False

    End Sub

    Public Sub mrBorraDatos()

        Dim lconConexion As MySqlConnection = prjControl.mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        Dim lsSql As String
        Dim loComando As New MySqlCommand()

        lsSql = "delete from tareas where id_tarea = " & mnId_Tarea

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

End Class
