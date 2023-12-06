Public Class frm_AjoutPatient
    Function teststr(ch As String)
        For Each caractere As Char In ch
            If Not Char.IsLetter(caractere) Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As patient
        If (txt_nom.Text = "" Or txt_prenom.Text = "" Or teststr(txt_nom.Text) = False Or teststr(txt_prenom.Text) = False) Then
            MsgBox("error nom ou prenom")
            txt_prenom.Clear()
            txt_nom.Clear()
        Else
            num_code.Value = (num() + 1) + 1
            p.Code = num() + 1
            p.Nom = txt_nom.Text
            p.Prenom = txt_prenom.Text
            If (ajoutPatient(p) = True) Then
                MsgBox("ajout valide")
            Else
                MsgBox("ajout invalide")
            End If
            txt_nom.Clear()
            txt_prenom.Clear()
        End If
    End Sub

    Private Sub frm_AjoutPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num_code.Value = (num() + 1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub
End Class