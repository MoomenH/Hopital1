Imports System.Windows.Forms
Module Module_RDV
    Structure RendezVous
        Dim Code As String
        Dim DateTimeR As DateTime
    End Structure
    Dim patients(99) As patient
    Dim RDV(99) As RendezVous
    Dim nombreRDVs As Integer = 0
    Function ajoutRDV(nouveauRDV As RendezVous) As Boolean
        If nombreRDVs < 100 Then
            For i As Integer = 0 To nombreRDVs - 1
                If RDV(i).Code = nouveauRDV.Code AndAlso RDV(i).DateTimeR.Date = nouveauRDV.DateTimeR.Date Then
                    Return False
                End If
            Next
            If nouveauRDV.DateTimeR >= DateTime.Now Then
                RDV(nombreRDVs) = nouveauRDV
                nombreRDVs += 1
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Sub afficherRDVsDuJour(dataGridView As DataGridView)
        For i As Integer = 0 To nombreRDVs - 1
            If RDV(i).DateTimeR.Date = DateTime.Now.Date Then
                dataGridView.Rows.Add(RDV(i).Code, RDV(i).DateTimeR)
            End If
        Next
    End Sub
    Public Sub afficherTousRDVs(dataGridView As DataGridView)
        For i As Integer = 0 To nombreRDVs - 1
            dataGridView.Rows.Add(RDV(i).Code, RDV(i).DateTimeR)
        Next
    End Sub
    Public Sub rechercherRDV(codePatient As Integer, dataGridView As DataGridView)
        For i As Integer = 0 To nombreRDVs - 1
            If (codePatient = 0 OrElse RDV(i).Code = codePatient) Then
                dataGridView.Rows.Add(RDV(i).Code, RDV(i).DateTimeR)
            End If
        Next
    End Sub
    Public Sub supprimerRDV(codePatient As Integer)
        For i As Integer = 0 To nombreRDVs - 1
            If RDV(i).Code = codePatient Then
                For j As Integer = i To nombreRDVs - 2
                    RDV(j) = RDV(j + 1)
                Next
                nombreRDVs -= 1
                Exit For
            End If
        Next
    End Sub
End Module