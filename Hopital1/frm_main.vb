Public Class Gestion_hopital
    Private Sub AjoutpatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutpatientToolStripMenuItem.Click
        frm_AjoutPatient.Show()
    End Sub
    Private Sub AfficherpatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherpatientToolStripMenuItem.Click
        frm_AfficherPatient.Show()
    End Sub
    Private Sub AfficherRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherRDVToolStripMenuItem.Click
        frm_RDVJour.Show()
    End Sub
    Private Sub PrenderRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrenderRDVToolStripMenuItem.Click
        frm_PriseRDV.Show()
    End Sub
End Class