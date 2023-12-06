Public Class frm_AfficherPatient
    Private Sub afficherP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherPatient(dgv_patient)
        Remplircmb(ComboBox1)
        dgv_patient.ReadOnly = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("selectionner un code svp")
        Else
            dgv_patient.Rows.Clear()
            rechercherPatient(CInt(ComboBox1.SelectedItem), dgv_patient)
            ComboBox1.SelectedIndex = -1
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("selectionner un code svp")
        Else
            supprimerPatient(CInt(ComboBox1.SelectedItem))
            dgv_patient.Rows.Clear()
            afficherPatient(dgv_patient)
            MsgBox("supprimer avec succee")
            ComboBox1.SelectedIndex = -1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dgv_patient.Rows.Clear()
        afficherPatient(dgv_patient)
    End Sub
End Class