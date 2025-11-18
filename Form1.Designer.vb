<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        LblNom = New Label()
        LblPrènom = New Label()
        LblNote = New Label()
        TxtNom = New TextBox()
        TxtPrenom = New TextBox()
        TxtNote = New TextBox()
        BtnAjout = New Button()
        BtnAfficher = New Button()
        BtnAnnuler = New Button()
        DgvListEtudiant = New DataGridView()
        Nom = New DataGridViewTextBoxColumn()
        Prènom = New DataGridViewTextBoxColumn()
        Note = New DataGridViewTextBoxColumn()
        BtnListeEtud = New Button()
        BtnMeilleur = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(DgvListEtudiant, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblNom
        ' 
        LblNom.AutoSize = True
        LblNom.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        LblNom.Location = New Point(33, 59)
        LblNom.Name = "LblNom"
        LblNom.Size = New Size(98, 46)
        LblNom.TabIndex = 0
        LblNom.Text = "Nom"
        ' 
        ' LblPrènom
        ' 
        LblPrènom.AutoSize = True
        LblPrènom.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        LblPrènom.Location = New Point(33, 135)
        LblPrènom.Name = "LblPrènom"
        LblPrènom.Size = New Size(144, 46)
        LblPrènom.TabIndex = 1
        LblPrènom.Text = "Prènom"
        ' 
        ' LblNote
        ' 
        LblNote.AutoSize = True
        LblNote.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        LblNote.Location = New Point(43, 203)
        LblNote.Name = "LblNote"
        LblNote.Size = New Size(98, 46)
        LblNote.TabIndex = 2
        LblNote.Text = "Note"
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(194, 76)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(160, 27)
        TxtNom.TabIndex = 3
        ' 
        ' TxtPrenom
        ' 
        TxtPrenom.Location = New Point(194, 152)
        TxtPrenom.Name = "TxtPrenom"
        TxtPrenom.Size = New Size(160, 27)
        TxtPrenom.TabIndex = 4
        ' 
        ' TxtNote
        ' 
        TxtNote.Location = New Point(194, 220)
        TxtNote.Name = "TxtNote"
        TxtNote.Size = New Size(160, 27)
        TxtNote.TabIndex = 5
        ' 
        ' BtnAjout
        ' 
        BtnAjout.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic)
        BtnAjout.Location = New Point(43, 295)
        BtnAjout.Name = "BtnAjout"
        BtnAjout.Size = New Size(117, 56)
        BtnAjout.TabIndex = 6
        BtnAjout.Text = "Ajouter"
        BtnAjout.UseVisualStyleBackColor = True
        ' 
        ' BtnAfficher
        ' 
        BtnAfficher.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic)
        BtnAfficher.Location = New Point(194, 295)
        BtnAfficher.Name = "BtnAfficher"
        BtnAfficher.Size = New Size(136, 60)
        BtnAfficher.TabIndex = 7
        BtnAfficher.Text = "Afficher"
        BtnAfficher.UseVisualStyleBackColor = True
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic)
        BtnAnnuler.Location = New Point(381, 295)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(137, 60)
        BtnAnnuler.TabIndex = 8
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = True
        ' 
        ' DgvListEtudiant
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgvListEtudiant.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgvListEtudiant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvListEtudiant.Columns.AddRange(New DataGridViewColumn() {Nom, Prènom, Note})
        DgvListEtudiant.Location = New Point(436, 111)
        DgvListEtudiant.Name = "DgvListEtudiant"
        DgvListEtudiant.RowHeadersWidth = 51
        DgvListEtudiant.Size = New Size(426, 39)
        DgvListEtudiant.TabIndex = 9
        ' 
        ' Nom
        ' 
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Nom.DefaultCellStyle = DataGridViewCellStyle2
        Nom.HeaderText = "Nom"
        Nom.MinimumWidth = 6
        Nom.Name = "Nom"
        Nom.Width = 125
        ' 
        ' Prènom
        ' 
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Prènom.DefaultCellStyle = DataGridViewCellStyle3
        Prènom.HeaderText = "Prènom"
        Prènom.MinimumWidth = 6
        Prènom.Name = "Prènom"
        Prènom.Width = 125
        ' 
        ' Note
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Note.DefaultCellStyle = DataGridViewCellStyle4
        Note.HeaderText = "Note"
        Note.MinimumWidth = 6
        Note.Name = "Note"
        Note.Width = 125
        ' 
        ' BtnListeEtud
        ' 
        BtnListeEtud.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic)
        BtnListeEtud.Location = New Point(436, 178)
        BtnListeEtud.Name = "BtnListeEtud"
        BtnListeEtud.Size = New Size(426, 85)
        BtnListeEtud.TabIndex = 10
        BtnListeEtud.Text = "Cliquez ici pour afficher la Liste Des Etudiantes"
        BtnListeEtud.UseVisualStyleBackColor = True
        ' 
        ' BtnMeilleur
        ' 
        BtnMeilleur.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic)
        BtnMeilleur.Location = New Point(147, 379)
        BtnMeilleur.Name = "BtnMeilleur"
        BtnMeilleur.Size = New Size(308, 59)
        BtnMeilleur.TabIndex = 11
        BtnMeilleur.Text = "MeilleurEtud"
        BtnMeilleur.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Capture_d_écran_2025_11_18_184253
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(999, 450)
        Controls.Add(BtnMeilleur)
        Controls.Add(BtnListeEtud)
        Controls.Add(DgvListEtudiant)
        Controls.Add(BtnAnnuler)
        Controls.Add(BtnAfficher)
        Controls.Add(BtnAjout)
        Controls.Add(TxtNote)
        Controls.Add(TxtPrenom)
        Controls.Add(TxtNom)
        Controls.Add(LblNote)
        Controls.Add(LblPrènom)
        Controls.Add(LblNom)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(DgvListEtudiant, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNom As Label
    Friend WithEvents LblPrènom As Label
    Friend WithEvents LblNote As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents BtnAjout As Button
    Friend WithEvents BtnAfficher As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents DgvListEtudiant As DataGridView
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prènom As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents BtnListeEtud As Button
    Friend WithEvents BtnMeilleur As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
