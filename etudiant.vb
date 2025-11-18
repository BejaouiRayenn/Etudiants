Module etudiant
    Public Structure Etud
        Dim nom As String
        Dim note As Double
        Dim prenom As String
    End Structure

    Public listEtudiants As New List(Of Etud)
    Sub ajouter(E As Etud)
        If Not existe(E.nom) Then
            listEtudiants.Add(E)
            MessageBox.Show("Ajoit aec succees ")
        Else
            MessageBox.Show("existe deja  ")
        End If
    End Sub
    Function existe(ch As String)
        Dim test As Boolean = False
        For Each et As Etud In listEtudiants
            If et.nom = ch Then
                test = True
            End If
        Next
        Return test
    End Function


End Module
