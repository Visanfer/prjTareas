Option Explicit On

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

        Dim lsSql As String = "select * from flota_posicion where idposicion = " & mnIdPosicion
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "posicion")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnIdPosicion = CInt(loRecord("idposicion") & "")
        msImei = Trim(loRecord("imei") & "")
        mdFechaHora = CDate(loRecord("fechahora") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into flota_posicion(imei,idusuario,idvehiculo,fechahora,latitud,longitud,velocidad) values ('" &
                        msImei & "'," &
                        mnIdUsuario & "," &
                        mnIdVehiculo & ",'" &
                        Format(mdFechaHora, "yyyy/MM/dd HH:mm:ss") & "'," &
                        mnLatitud & "," &
                        mnLongitud & "," &
                        mnVelocidad & "); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdPosicion = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update flota_posicion set imei = '" & msImei &
                    "', idusuario = " & mnIdUsuario &
                    ", idvehiculo = " & mnIdVehiculo &
                    ", fechahora = '" & Format(mdFechaHora, "yyyy/MM/dd HH:mm:ss") &
                    "', latitud = " & mnLatitud &
                    ", longitud = " & mnLongitud &
                    ", velocidad = " & mnVelocidad &
                    " where idposicion = " & mnIdPosicion
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

        lsSql = "delete from flota_posiciontemp where idposicion = " & lnIndice

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

End Class
