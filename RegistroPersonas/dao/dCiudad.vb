Imports System.Data.SqlClient
Public Class dCiudad
    Dim strConexion As String = My.Settings.DBPrueba26ConnectionString.ToString()
    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "Select id as N'Código', nombre as N'Ciudad' from Ciudad"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

            MsgBox("Ocurrio un error al obtener registros" & ex.Message, MsgBoxStyle.Critical, "Error")


        End Try
        Return ds
    End Function

    Public Function GuardarRegistros(ByVal ciudad As tbl_Ciudades) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim cmd As New SqlCommand()
            Dim tsql = "insert into Ciudad(nombre) values (@nombre)"
            cmd.Parameters.AddWithValue("@nombre", ciudad.NombreCiudad)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro ", MsgBoxStyle.Critical, "Ciudades")
        End Try

        Return resultado
    End Function

    Public Function editarRegistro(ByVal ciudad As tbl_Ciudades)
        Dim flag = False
        Try
            Dim tsql = "UPDATE Ciudad SET nombre=@nombre, estado=@estado where id = @id"
            Dim conn As New SqlConnection(My.Settings.DBPrueba26ConnectionString)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", ciudad.NombreCiudad)
            cmd.Parameters.AddWithValue("@estado", ciudad.Estado)
            cmd.Parameters.AddWithValue("@id", ciudad.IdCiudad)
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                flag = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Error al intentar actualizar el registro ", MsgBoxStyle.Critical, "Ciudades")
        End Try
        Return flag
    End Function

    Public Function BuscarRegistro(ByVal id As Integer) As tbl_Ciudades
        Dim ciudad As New tbl_Ciudades
        Try
            Dim tsql As String = "select * from Ciudad where id = @id"
            Dim conn As New SqlConnection(strConexion)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id", id)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                ciudad.IdCiudad = tbl.Rows(0).Item("id")
                ciudad.NombreCiudad = tbl.Rows(0).Item("nombre")
                ciudad.Estado = tbl.Rows(0).Item("estado")
            End If
        Catch ex As Exception


        End Try
        Return ciudad
    End Function

    Public Function EliminarRegistro(ByVal id As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "delete from Ciudad where id = @id"
            Dim conn As New SqlConnection(strConexion)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Error al intentar eliminar el registro ", MsgBoxStyle.Critical, "Ciudades")
            resp = False
        End Try
        Return resp
    End Function

End Class
