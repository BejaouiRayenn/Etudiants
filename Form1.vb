Public Class Form1
    Private Sub BtnAjout_Click(sender As Object, e As EventArgs) Handles BtnAjout.Click
        Dim nom As String
        Dim note As String
        Dim etu As Etud
        Dim prenom As String
        nom = TxtNom.Text
        prenom = TxtPrenom.Text
        note = CDbl(TxtNote.Text)
        If nom = "" Then
            ErrorProvider1.SetError(TxtNom, "veuillez entreer le nom ")

            Return
        End If
        If prenom = "" Then
            ErrorProvider1.SetError(TxtPrenom, "veuillez entreer le nom ")

            Return
        End If
        If (note < 0 Or note > 20) Then
            ErrorProvider1.SetError(TxtNote, "introduire une note entre 0 et 20  ")

            Return
        End If
        etu.nom = nom
        etu.prenom = prenom
        etu.note = note
        ajouter(etu)

    End Sub
    Private Sub TxtNote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNote.KeyPress
        MessageBox.Show("vous avez cliquez " & e.KeyChar)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub

    Private Sub BtnAfficher_Click(sender As Object, e As EventArgs) Handles BtnAfficher.Click
        DgvListEtudiant.Rows.Clear()
        If listEtudiants.Count = 0 Then
            MessageBox.Show("aucun étudiant enregistré .", "information ")
            Exit Sub
        End If
        For Each et As Etud In listEtudiants
            DgvListEtudiant.Rows.Add(et.nom, et.prenom, et.note)

        Next

    End Sub

    Private Sub BtnMeilleur_Click(sender As Object, e As EventArgs) Handles BtnMeilleur.Click
        If listEtudiants.Count = 0 Then
            MessageBox.Show("Aucun étudiant enregistré.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim meilleurEtudiant As Etud = listEtudiants(0)
        For Each etudiantActuel As Etud In listEtudiants
            If etudiantActuel.note > meilleurEtudiant.note Then
                meilleurEtudiant = etudiantActuel
            End If
        Next
        Dim messageResultat As String = "🎉 Meilleur Étudiant : " & meilleurEtudiant.nom & " " & meilleurEtudiant.prenom & Environment.NewLine &
                                    "   Note : " & meilleurEtudiant.note.ToString("N2") & " / 20"
        MessageBox.Show(messageResultat, "Meilleur Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        TxtNote.Clear()
        TxtPrenom.Clear()
        TxtNom.Clear()
    End Sub

    Private Sub BtnListeEtud_Click(sender As Object, e As EventArgs) Handles BtnListeEtud.Click
        Dim formAffichage As New Form2()
        formAffichage.ChargerEtudiants()
        formAffichage.Show()
    End Sub
End Class
