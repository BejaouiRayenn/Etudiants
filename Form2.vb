Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub ChargerEtudiants()
        DgvListEtudiant.Rows.Clear()
        If listEtudiants.Count = 0 Then
            MessageBox.Show("Aucun étudiant enregistré à afficher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        For Each et As Etud In listEtudiants
            DgvListEtudiant.Rows.Add(et.nom, et.prenom, et.note.ToString("N2"))
        Next

    End Sub


End Class