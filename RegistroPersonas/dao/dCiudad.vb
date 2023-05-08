Imports System.Data.SqlClient
Public Class dCiudad
    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "Select id as N'CODIGO', nombre as N'Ciudad' from Ciudad"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

            MsgBox("Ocurrio un error al obtener registros" & ex.Message, MsgBoxStyle.Critical, "Error")


        End Try
        Return ds
    End Function


End Class
