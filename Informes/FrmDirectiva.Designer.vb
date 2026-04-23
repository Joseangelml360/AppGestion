<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDirectiva
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.JuntaDirectivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFallero = New AppGestion.DataSetFallero()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSMayores = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSInfantiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.JuntaDirectivaTableAdapter = New AppGestion.DataSetFalleroTableAdapters.JuntaDirectivaTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.JuntaDirectivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'JuntaDirectivaBindingSource
        '
        Me.JuntaDirectivaBindingSource.DataMember = "JuntaDirectiva"
        Me.JuntaDirectivaBindingSource.DataSource = Me.DataSetFallero
        '
        'DataSetFallero
        '
        Me.DataSetFallero.DataSetName = "DataSetFallero"
        Me.DataSetFallero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMayores, Me.TSInfantiles, Me.TSCerrar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSMayores
        '
        Me.TSMayores.Name = "TSMayores"
        Me.TSMayores.Size = New System.Drawing.Size(79, 24)
        Me.TSMayores.Text = "Mayores"
        '
        'TSInfantiles
        '
        Me.TSInfantiles.Name = "TSInfantiles"
        Me.TSInfantiles.Size = New System.Drawing.Size(83, 24)
        Me.TSInfantiles.Text = "Infantiles"
        '
        'TSCerrar
        '
        Me.TSCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSCerrar.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.TSCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TSCerrar.Name = "TSCerrar"
        Me.TSCerrar.Padding = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.TSCerrar.Size = New System.Drawing.Size(87, 24)
        Me.TSCerrar.Text = "Cerrar"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.JuntaDirectivaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptDirectiva.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 31)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1067, 518)
        Me.ReportViewer1.TabIndex = 3
        '
        'JuntaDirectivaTableAdapter
        '
        Me.JuntaDirectivaTableAdapter.ClearBeforeFill = True
        '
        'FrmDirectiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 553)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "35")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmDirectiva"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDirectiva"
        CType(Me.JuntaDirectivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSMayores As ToolStripMenuItem
    Friend WithEvents TSInfantiles As ToolStripMenuItem
    Friend WithEvents TSCerrar As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents JuntaDirectivaBindingSource As BindingSource
    Friend WithEvents DataSetFallero As DataSetFallero
    Friend WithEvents JuntaDirectivaTableAdapter As DataSetFalleroTableAdapters.JuntaDirectivaTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
