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

End Class