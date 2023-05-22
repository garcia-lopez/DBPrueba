Public Class FrmEmpleado
    Dim ciudad As New dCiudad

    Sub LlenarCiudades()
        Dim ds As New DataSet
        ds = ciudad.MostrarRegistros()
        CmBCiudad.DataSource = ds.Tables(0)
        CmBCiudad.DisplayMember = "Ciudad"
        CmBCiudad.ValueMember = "Código"

    End Sub

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCiudades()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        DireccionTextBox.Text = CmBCiudad.SelectedValue.ToString()
    End Sub
End Class