Public Class FrmCiudad

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro " & ex.Message, MsgBoxStyle.Critical, "Ciudades")
        End Try

    End Sub

    Private Sub DvGRegistros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DvGRegistros.CellDoubleClick
        Dim fila As Integer = DvGRegistros.CurrentRow.Index
        txt_id.Text = DvGRegistros.Rows(fila).Cells(0).Value
        txtNombre.Text = DvGRegistros.Rows(fila).Cells(1).Value

    End Sub
End Class