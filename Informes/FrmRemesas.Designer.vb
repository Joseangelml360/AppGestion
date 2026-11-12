<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemesas
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
        Me.remesas1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TsCajaTransf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsRemesaselect = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.remesas1TableAdapter = New AppGestion.ReportsDataSetTableAdapters.remesas1TableAdapter()
        Me.RemesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemesasTableAdapter = New AppGestion.ReportsDataSetTableAdapters.remesasTableAdapter()
        Me.TableAdapterManager = New AppGestion.ReportsDataSetTableAdapters.TableAdapterManager()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TsTodas = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.remesas1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'remesas1BindingSource
        '
        Me.remesas1BindingSource.DataMember = "remesas1"
        Me.remesas1BindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsCajaTransf, Me.ToolStripMenuItem1, Me.TsRemesaselect, Me.TsTodas, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1086, 32)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TsCajaTransf
        '
        Me.TsCajaTransf.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TsCajaTransf.Name = "TsCajaTransf"
        Me.TsCajaTransf.Size = New System.Drawing.Size(170, 28)
        Me.TsCajaTransf.Text = "Ver Caja/Transferencia"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.AppGestion.My.Resources.Resources.arrow_right
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 28)
        Me.ToolStripMenuItem1.Text = "Selecciona Nº de remesa"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TsRemesaselect
        '
        Me.TsRemesaselect.Margin = New System.Windows.Forms.Padding(1, 0, 40, 0)
        Me.TsRemesaselect.Name = "TsRemesaselect"
        Me.TsRemesaselect.Size = New System.Drawing.Size(160, 28)
        Me.TsRemesaselect.Text = "SeleccionaRemesa"
        Me.TsRemesaselect.ToolTipText = "Selecciona Remes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.ToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(153, 28)
        Me.ToolStripMenuItem2.Text = "Salir del Informe"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.remesas1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptRemesas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 32)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1086, 541)
        Me.ReportViewer1.TabIndex = 3
        '
        'remesas1TableAdapter
        '
        Me.remesas1TableAdapter.ClearBeforeFill = True
        '
        'RemesasBindingSource
        '
        Me.RemesasBindingSource.DataMember = "remesas"
        Me.RemesasBindingSource.DataSource = Me.ReportsDataSet
        '
        'RemesasTableAdapter
        '
        Me.RemesasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACTUALIZAREJERCICIOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DevolucionesTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.falleroSinBancoTableAdapter = Nothing
        Me.TableAdapterManager.falleroTableAdapter = Nothing
        Me.TableAdapterManager.InfantilPaseJuvenilTableAdapter = Nothing
        Me.TableAdapterManager.remesas1TableAdapter = Me.remesas1TableAdapter
        Me.TableAdapterManager.remesasTableAdapter = Me.RemesasTableAdapter
        Me.TableAdapterManager.RemesasTodasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.ReportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TsTodas
        '
        Me.TsTodas.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.TsTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TsTodas.Name = "TsTodas"
        Me.TsTodas.Size = New System.Drawing.Size(105, 28)
        Me.TsTodas.Text = "Ver todas"
        Me.TsTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmRemesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 573)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "17")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmRemesas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "FrmRemesas"
        CType(Me.remesas1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TsCajaTransf As ToolStripMenuItem
    Friend WithEvents TsRemesaselect As ToolStripComboBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents remesas1BindingSource As BindingSource
    Friend WithEvents remesas1TableAdapter As ReportsDataSetTableAdapters.remesas1TableAdapter
    Friend WithEvents RemesasBindingSource As BindingSource
    Friend WithEvents RemesasTableAdapter As ReportsDataSetTableAdapters.remesasTableAdapter
    Friend WithEvents TableAdapterManager As ReportsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TsTodas As ToolStripMenuItem
End Class
