Public Class frm_RDVJour
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv_rdv.Rows.Clear()
        afficherRDVsDuJour(dgv_rdv)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgv_rdv.Rows.Clear()
        afficherTousRDVs(dgv_rdv)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("selectionner un code svp")
        Else
            dgv_rdv.Rows.Clear()
            rechercherRDV(CInt(ComboBox1.SelectedItem), dgv_rdv)
            ComboBox1.SelectedIndex = -1
        End If
    End Sub
    Private Sub frm_RDVJour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplircmb(ComboBox1)
        dgv_rdv.ReadOnly = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("selectionner un code svp")
        Else
            supprimerRDV(CInt(ComboBox1.SelectedItem))
            dgv_rdv.Rows.Clear()
            afficherTousRDVs(dgv_rdv)
            MsgBox("supprimer avec succee")
            ComboBox1.SelectedIndex = -1
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class