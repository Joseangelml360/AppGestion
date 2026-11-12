<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemesaGenerada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.detalles_de_remesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Detalles_de_remesaTableAdapter = New AppGestion.DataSet1TableAdapters.detalles_de_remesaTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarInformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.detalles_de_remesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'detalles_de_remesaBindingSource
        '
        Me.detalles_de_remesaBindingSource.DataMember = "detalles de remesa"
        Me.detalles_de_remesaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalles_de_remesaTableAdapter
        '
        Me.Detalles_de_remesaTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarInformeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1085, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarInformeToolStripMenuItem
        '
        Me.CerrarInformeToolStripMenuItem.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.CerrarInformeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CerrarInformeToolStripMenuItem.Name = "CerrarInformeToolStripMenuItem"
        Me.CerrarInformeToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.CerrarInformeToolStripMenuItem.Text = "Cerrar Informe"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.detalles_de_remesaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptRemesaGenerada.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1085, 422)
        Me.ReportViewer1.TabIndex = 1
        '
        'FrmRemesaGenerada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "19")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmRemesaGenerada"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "FrmRemesaGenerada"
        CType(Me.detalles_de_remesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Detalles_de_remesaTableAdapter As DataSet1TableAdapters.detalles_de_remesaTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CerrarInformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detalles_de_remesaBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
