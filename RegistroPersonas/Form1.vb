﻿Public Class Form1
    Private Sub CiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadToolStripMenuItem.Click
        Dim frm As New FrmCiudad
        frm.MdiParent = Me
        frm.Show()



    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        Dim frm As New FrmEmpleado
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
