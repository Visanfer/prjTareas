Option Explicit On

Imports prjControl

Public Module modTareas

    Public goBusEstados As clsBusTareas

    Public goProfile As New clsProfileLocal
    Public goUsuario As New clsUsuario()

    Public Sub Main()

        ' primero recupero todos los estados que hay en el sistema
        goBusEstados = New clsBusTareas
        goBusEstados.mrRecuperaEstados()

        Dim loBusTareas As New frmBusTareas
        loBusTareas.mrCargar(Nothing)
    End Sub

    Public Function mfsUsuarioNombre(ByVal lnId_Usuario) As String

        Static lcolUsuarios As Collection
        If lcolUsuarios Is Nothing Then lcolUsuarios = New Collection

        Dim loUsuario As New clsUsuario
        loUsuario.mnCodigo = lnId_Usuario

        On Error Resume Next
        loUsuario = lcolUsuarios(loUsuario.mpsCodigo)
        If Err.Number > 0 Then
            loUsuario.mrRecuperaDatos()
            If Not loUsuario.mbEsNuevo Then lcolUsuarios.Add(loUsuario, loUsuario.mpsCodigo)
        End If
        On Error GoTo 0

        Return loUsuario.msNombre

    End Function

    Public Sub mrMandaVimail(ByVal lnDe As Integer, ByVal lnPara As Integer, ByVal lsTituloTarea As String, ByVal lsMensaje As String)

        goProfile.mrRecuperaDatos()

        Dim loVimailCab As New prjComunicacionInterna.clsVimailCab
        loVimailCab.mnEmpresa = 1
        loVimailCab.mrNuevoCodigo()
        loVimailCab.mnUsuario = lnDe
        loVimailCab.mdFecha = Now
        loVimailCab.msHora = Format(Now, "HH:mm:ss")
        loVimailCab.mrGrabaDatos()

        Dim loVimail As New prjComunicacionInterna.clsVimail
        loVimail.mnEmpresa = 1
        loVimail.mnCodigo = loVimailCab.mnCodigo
        loVimail.mnLinea = 1
        loVimail.mnDe = lnDe
        loVimail.mnPara = lnPara
        loVimail.msAsunto = "TAREA (" & lsTituloTarea & ")"
        loVimail.msCuerpo = lsMensaje
        loVimail.mdFecha = Now
        loVimail.mdFechaAviso = Now
        loVimail.msHora = Format(Now, "HH:mm:ss")
        loVimail.msHoraAviso = Format(Now, "HH:mm:ss")
        loVimail.msIP = goProfile.mfsIP
        loVimail.mrGrabaDatos()

    End Sub

End Module
