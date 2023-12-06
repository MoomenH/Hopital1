<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_hopital
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutpatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherpatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrenderRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.YellowGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.RDVToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutpatientToolStripMenuItem, Me.AfficherpatientToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(82, 27)
        Me.PatientToolStripMenuItem.Text = "patient"
        '
        'AjoutpatientToolStripMenuItem
        '
        Me.AjoutpatientToolStripMenuItem.Name = "AjoutpatientToolStripMenuItem"
        Me.AjoutpatientToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.AjoutpatientToolStripMenuItem.Text = "ajout_patient"
        '
        'AfficherpatientToolStripMenuItem
        '
        Me.AfficherpatientToolStripMenuItem.Name = "AfficherpatientToolStripMenuItem"
        Me.AfficherpatientToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.AfficherpatientToolStripMenuItem.Text = "afficher_patient"
        '
        'RDVToolStripMenuItem
        '
        Me.RDVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherRDVToolStripMenuItem, Me.PrenderRDVToolStripMenuItem})
        Me.RDVToolStripMenuItem.Name = "RDVToolStripMenuItem"
        Me.RDVToolStripMenuItem.Size = New System.Drawing.Size(59, 27)
        Me.RDVToolStripMenuItem.Text = "RDV"
        '
        'AfficherRDVToolStripMenuItem
        '
        Me.AfficherRDVToolStripMenuItem.Name = "AfficherRDVToolStripMenuItem"
        Me.AfficherRDVToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.AfficherRDVToolStripMenuItem.Text = "afficher_RDV"
        '
        'PrenderRDVToolStripMenuItem
        '
        Me.PrenderRDVToolStripMenuItem.Name = "PrenderRDVToolStripMenuItem"
        Me.PrenderRDVToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.PrenderRDVToolStripMenuItem.Text = "prender_RDV"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Gestion_hopital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Gestion_hopital"
        Me.Text = "frm_main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutpatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherpatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrenderRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
