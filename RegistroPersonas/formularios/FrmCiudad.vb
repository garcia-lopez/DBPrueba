Public Class FrmCiudad
    Dim ciudadAct As New tbl_Ciudades
    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Focus()
        LlenarRegistros()

    End Sub

    Sub LlenarRegistros()
        Dim dCiudad As New dCiudad
        DvGRegistros.DataSource = dCiudad.MostrarRegistros.Tables(0)
        DvGRegistros.Refresh()
        GbRegistros.Text = "Registros almacenados: " & DvGRegistros.Rows.Count
    End Sub


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            Dim ciudad As New tbl_Ciudades()
            ciudad.NombreCiudad = txtNombre.Text.Trim
            Dim dciudad As New dCiudad
            If (dciudad.GuardarRegistros(ciudad)) Then
                MsgBox("Registro guardado satisfactoriamente... ", MsgBoxStyle.Information, "Ciudad")
            Else
                MsgBox("No se pudo guardar el registro... ", MsgBoxStyle.Information, "Ciudades")
            End If
            LlenarRegistros()
            txtNombre.Clear()
            txtNombre.Focus()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro " & ex.Message, MsgBoxStyle.Critical, "Ciudades")
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            Dim ciudad As New tbl_Ciudades(CInt(txt_id.Text), txtNombre.Text, True)
            Dim dao As New dCiudad
            If (dao.editarRegistro(ciudad)) Then
                MsgBox("Registro editado correctamente :D", MsgBoxStyle.Information, "Hurra!")
            End If
            LlenarRegistros()
            txtNombre.Clear()
            txt_id.Clear()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro " & ex.Message, MsgBoxStyle.Critical, "Ciudades")
        End Try

    End Sub

    Private Sub DvGRegistros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DvGRegistros.CellDoubleClick
        Dim fila As Integer = DvGRegistros.CurrentRow.Index
        txt_id.Text = DvGRegistros.Rows(fila).Cells(0).Value
        txtNombre.Text = DvGRegistros.Rows(fila).Cells(1).Value
        txtNombre.Focus()

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_id.Clear()
        txtNombre.Clear()
        txtNombre.Focus()
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim codigo As Integer = txt_id.Text
        Dim ciudadDao As New dCiudad()
        Dim ciudad As New tbl_Ciudades
        ciudad = ciudadDao.BuscarRegistro(codigo)
        If (ciudad.IdCiudad = 0) Then
            MsgBox("Registro no existe. ", MsgBoxStyle.Exclamation, "Monitores UCA")
            Exit Sub
        End If
        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar el registro número: " & ciudad.IdCiudad, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Monitores UCA "))
        If (resp = vbNo) Then
            MsgBox("Operación cancelada", MsgBoxStyle.Information, "Monitores UCA")
            Exit Sub
        End If

        Dim eliminado = ciudadDao.EliminarRegistro(ciudad.IdCiudad)
        If (eliminado) Then
            MsgBox("Registro eliminado :O", MsgBoxStyle.Information, "Monitores UCA")
        Else
            MsgBox("Error al eliminar el registro O: ", MsgBoxStyle.Critical, "Monitores UCA")
        End If
        LlenarRegistros()
        txtNombre.Clear()
        txt_id.Clear()

    End Sub
End Class