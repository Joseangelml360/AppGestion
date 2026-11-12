<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuotasError
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
        Me.falleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCuotas = New AppGestion.DataSetCuotas()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TsError = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsCero = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cuota03AñosVencidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.falleroTableAdapter = New AppGestion.DataSetCuotasTableAdapters.falleroTableAdapter()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EjercicioTableAdapter = New AppGestion.DataSetCuotasTableAdapters.ejercicioTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSetCuotasTableAdapters.TableAdapterManager()
        Me.Pase0_3DateTimePicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'falleroBindingSource
        '
        Me.falleroBindingSource.DataMember = "fallero"
        Me.falleroBindingSource.DataSource = Me.DataSetCuotas
        '
        'DataSetCuotas
        '
        Me.DataSetCuotas.DataSetName = "DataSetCuotas"
        Me.DataSetCuotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsError, Me.TsCero, Me.TsCerrar, Me.Cuota03AñosVencidaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1108, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TsError
        '
        Me.TsError.Name = "TsError"
        Me.TsError.Size = New System.Drawing.Size(132, 26)
        Me.TsError.Text = "Cuotas con error"
        '
        'TsCero
        '
        Me.TsCero.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TsCero.Name = "TsCero"
        Me.TsCero.Size = New System.Drawing.Size(107, 26)
        Me.TsCero.Text = "Cuota a cero"
        '
        'TsCerrar
        '
        Me.TsCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TsCerrar.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.TsCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TsCerrar.Name = "TsCerrar"
        Me.TsCerrar.Size = New System.Drawing.Size(141, 26)
        Me.TsCerrar.Text = "Cerrar Listados"
        '
        'Cuota03AñosVencidaToolStripMenuItem
        '
        Me.Cuota03AñosVencidaToolStripMenuItem.Name = "Cuota03AñosVencidaToolStripMenuItem"
        Me.Cuota03AñosVencidaToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.Cuota03AñosVencidaToolStripMenuItem.Text = "Cuota 0-3 años vencida"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.falleroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptCuotasError.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 31)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1108, 473)
        Me.ReportViewer1.TabIndex = 3
        '
        'falleroTableAdapter
        '
        Me.falleroTableAdapter.ClearBeforeFill = True
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSetCuotas
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Me.EjercicioTableAdapter
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSetCuotasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Pase0_3DateTimePicker
        '
        Me.Pase0_3DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EjercicioBindingSource, "pase0_3", True))
        Me.Pase0_3DateTimePicker.Location = New System.Drawing.Point(831, 31)
        Me.Pase0_3DateTimePicker.Name = "Pase0_3DateTimePicker"
        Me.Pase0_3DateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.Pase0_3DateTimePicker.TabIndex = 4
        Me.Pase0_3DateTimePicker.Visible = False
        '
        'FrmCuotasError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1108, 516)
        Me.Controls.Add(Me.Pase0_3DateTimePicker)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "37")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmCuotasError"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCuotasError"
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TsError As ToolStripMenuItem
    Friend WithEvents TsCero As ToolStripMenuItem
    Friend WithEvents TsCerrar As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents falleroBindingSource As BindingSource
    Friend WithEvents DataSetCuotas As DataSetCuotas
    Friend WithEvents falleroTableAdapter As DataSetCuotasTableAdapters.falleroTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Cuota03AñosVencidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DataSetCuotasTableAdapters.ejercicioTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCuotasTableAdapters.TableAdapterManager
    Friend WithEvents Pase0_3DateTimePicker As DateTimePicker
End Class
