Module Module_Patient
    Public Structure patient
        Dim Code As Integer
        Dim Nom As String
        Dim Prenom As String
    End Structure
    Dim Patients(99) As patient
    Dim NbPatients As Integer = 0
    Function ajoutPatient(nouveauPatient As patient) As Boolean
        If NbPatients >= Patients.Length Then
            Return False
        End If
        For i As Integer = 0 To NbPatients - 1
            If Patients(i).Code = nouveauPatient.Code Then
                Return False
            End If
        Next
        Patients(NbPatients) = nouveauPatient
        NbPatients += 1
        Return True
    End Function
    Function num()
        Return NbPatients
    End Function
    Public Sub Remplircmb(comboBox As ComboBox)
        For i As Integer = 0 To NbPatients - 1
            comboBox.Items.Add(Patients(i).Code)
        Next
    End Sub
    Public Sub afficherPatient(dgv As DataGridView)
        For i As Integer = 0 To NbPatients - 1
            Dim p As patient = Patients(i)
            dgv.Rows.Add(p.Code, p.Nom, p.Prenom)
            dgv.Show()
        Next
    End Sub
    Public Sub rechercherPatient(codePatient As Integer, dataGridView As DataGridView)
        For i As Integer = 0 To NbPatients - 1
            If (codePatient = 0 OrElse Patients(i).Code = codePatient) Then
                dataGridView.Rows.Add(Patients(i).Code, Patients(i).Nom, Patients(i).Prenom)
            End If
        Next
    End Sub
    Public Sub supprimerPatient(codePatient As Integer)
        For i As Integer = 0 To NbPatients - 1
            If Patients(i).Code = codePatient Then
                For j As Integer = i To NbPatients - 2
                    Patients(j) = Patients(j + 1)
                Next
                NbPatients -= 1
                Exit For
            End If
        Next
    End Sub
End Module
