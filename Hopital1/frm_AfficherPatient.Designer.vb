<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AfficherPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_patient = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_patient
        '
        Me.dgv_patient.BackgroundColor = System.Drawing.Color.YellowGreen
        Me.dgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_patient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.nom, Me.prenom})
        Me.dgv_patient.GridColor = System.Drawing.Color.YellowGreen
        Me.dgv_patient.Location = New System.Drawing.Point(70, 84)
        Me.dgv_patient.Name = "dgv_patient"
        Me.dgv_patient.RowHeadersWidth = 51
        Me.dgv_patient.RowTemplate.Height = 24
        Me.dgv_patient.Size = New System.Drawing.Size(570, 150)
        Me.dgv_patient.TabIndex = 0
        '
        'code
        '
        Me.code.HeaderText = "code"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.Width = 125
        '
        'nom
        '
        Me.nom.HeaderText = "nom"
        Me.nom.MinimumWidth = 6
        Me.nom.Name = "nom"
        Me.nom.Width = 125
        '
        'prenom
        '
        Me.prenom.HeaderText = "prenom"
        Me.prenom.MinimumWidth = 6
        Me.prenom.Name = "prenom"
        Me.prenom.Width = 125
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(371, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "rechercher"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.YellowGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(371, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "supprimer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "selectionner un code svp"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(83, 273)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.YellowGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(371, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 47)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "afficher"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_AfficherPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_patient)
        Me.Name = "frm_AfficherPatient"
        Me.Text = "frm_AfficherPatient"
        CType(Me.dgv_patient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_patient As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
End Class
