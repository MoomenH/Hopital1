Public Class frm_PriseRDV
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As RendezVous
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("selectionner un code svp")
        Else
            r.Code = CInt(ComboBox1.SelectedItem)
            r.DateTimeR = dtprdv.Value
            If (ajoutRDV(r) = True) Then
                MsgBox("ajout valide")
            Else
                MsgBox("ajout invalide")
            End If
            ComboBox1.SelectedIndex = -1
            dtprdv.Value = DateTime.Now

        End If
    End Sub
    Private Sub frm_PriseRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtprdv.Format = DateTimePickerFormat.Custom
        dtprdv.CustomFormat = "MM/dd/yyyy hh:mm:ss"
        Remplircmb(ComboBox1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.SelectedIndex = -1
        dtprdv.Value = DateTime.Now
    End Sub
End Class