Imports System.Windows.Forms

Public Class FrmMenu



    Private Sub menuItemRegistrarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemRegistrarClientes.Click
        frmCliente.ShowDialog()
    End Sub

    

    Private Sub RegistrarCanchasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarCanchasToolStripMenuItem.Click
        FrmCancha.ShowDialog()
    End Sub

    Private Sub RegistrarReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarReservasToolStripMenuItem.Click
        FrmRegistrarReserva.ShowDialog()
    End Sub

    Private Sub ModificarReservaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarReservaToolStripMenuItem.Click
        FrmModificarReserva.ShowDialog()
    End Sub


    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click

    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        FrmProveedores.ShowDialog()
    End Sub
End Class
