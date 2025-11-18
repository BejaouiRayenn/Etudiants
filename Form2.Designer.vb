<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgvListEtudiant = New DataGridView()
        Nom = New DataGridViewTextBoxColumn()
        Prènom = New DataGridViewTextBoxColumn()
        Note = New DataGridViewTextBoxColumn()
        LblListeEtudiantt = New Label()
        CType(DgvListEtudiant, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        DgvListEtudiant.Location = New Point(243, 150)
        DgvListEtudiant.Name = "DgvListEtudiant"
        DgvListEtudiant.RowHeadersWidth = 51
        DgvListEtudiant.Size = New Size(426, 156)
        DgvListEtudiant.TabIndex = 10
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
        ' LblListeEtudiantt
        ' 
        LblListeEtudiantt.AutoSize = True
        LblListeEtudiantt.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        LblListeEtudiantt.Location = New Point(307, 73)
        LblListeEtudiantt.Name = "LblListeEtudiantt"
        LblListeEtudiantt.Size = New Size(287, 41)
        LblListeEtudiantt.TabIndex = 11
        LblListeEtudiantt.Text = "Liste des Etudiants "
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Capture_d_écran_2025_11_18_184014
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(879, 450)
        Controls.Add(LblListeEtudiantt)
        Controls.Add(DgvListEtudiant)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        CType(DgvListEtudiant, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvListEtudiant As DataGridView
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prènom As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents LblListeEtudiantt As Label
End Class
