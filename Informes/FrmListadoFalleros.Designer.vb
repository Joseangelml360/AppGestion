<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoFalleros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoFalleros))
        Me.FalleroComisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFallero = New AppGestion.DataSetFallero()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FalleroComisionTableAdapter = New AppGestion.DataSetFalleroTableAdapters.FalleroComisionTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMayores = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSInfantiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMujeres = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSNiñas = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSHombres = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSNiños = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSJuveniles = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FalleroComisionBindingSource
        '
        Me.FalleroComisionBindingSource.DataMember = "FalleroComision"
        Me.FalleroComisionBindingSource.DataSource = Me.DataSetFallero
        '
        'DataSetFallero
        '
        Me.DataSetFallero.DataSetName = "DataSetFallero"
        Me.DataSetFallero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.FalleroComisionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptListadoFalleros simple.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1370, 773)
        Me.ReportViewer1.TabIndex = 0
        '
        'FalleroComisionTableAdapter
        '
        Me.FalleroComisionTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSTodos, Me.TSMayores, Me.TSInfantiles, Me.TSMujeres, Me.TSNiñas, Me.TSHombres, Me.TSNiños, Me.TSJuveniles, Me.TSCerrar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1371, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSTodos
        '
        Me.TSTodos.Name = "TSTodos"
        Me.TSTodos.Size = New System.Drawing.Size(63, 24)
        Me.TSTodos.Text = "Todos"
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
        'TSMujeres
        '
        Me.TSMujeres.Name = "TSMujeres"
        Me.TSMujeres.Size = New System.Drawing.Size(75, 24)
        Me.TSMujeres.Text = "Mujeres"
        '
        'TSNiñas
        '
        Me.TSNiñas.Name = "TSNiñas"
        Me.TSNiñas.Size = New System.Drawing.Size(60, 24)
        Me.TSNiñas.Text = "Niñas"
        '
        'TSHombres
        '
        Me.TSHombres.Name = "TSHombres"
        Me.TSHombres.Size = New System.Drawing.Size(84, 24)
        Me.TSHombres.Text = "Hombres"
        '
        'TSNiños
        '
        Me.TSNiños.Name = "TSNiños"
        Me.TSNiños.Size = New System.Drawing.Size(61, 24)
        Me.TSNiños.Text = "Niños"
        '
        'TSJuveniles
        '
        Me.TSJuveniles.Name = "TSJuveniles"
        Me.TSJuveniles.Size = New System.Drawing.Size(81, 24)
        Me.TSJuveniles.Text = "Juveniles"
        '
        'TSCerrar
        '
        Me.TSCerrar.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.TSCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TSCerrar.Name = "TSCerrar"
        Me.TSCerrar.Size = New System.Drawing.Size(141, 24)
        Me.TSCerrar.Text = "Cerrar Listados"
        '
        'FrmListadoFalleros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 814)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.HelpProvider1.SetHelpKeyword(Me, "32")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListadoFalleros"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Falleros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FalleroComisionBindingSource As BindingSource
    Friend WithEvents DataSetFallero As DataSetFallero
    Friend WithEvents FalleroComisionTableAdapter As DataSetFalleroTableAdapters.FalleroComisionTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSTodos As ToolStripMenuItem
    Friend WithEvents TSMayores As ToolStripMenuItem
    Friend WithEvents TSInfantiles As ToolStripMenuItem
    Friend WithEvents TSMujeres As ToolStripMenuItem
    Friend WithEvents TSNiñas As ToolStripMenuItem
    Friend WithEvents TSHombres As ToolStripMenuItem
    Friend WithEvents TSNiños As ToolStripMenuItem
    Friend WithEvents TSJuveniles As ToolStripMenuItem
    Friend WithEvents TSCerrar As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
