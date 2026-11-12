<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoPorFamilias
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
        Me.FalleroComisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFallero = New AppGestion.DataSetFallero()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FalleroComisionTableAdapter = New AppGestion.DataSetFalleroTableAdapters.FalleroComisionTableAdapter()
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.Location = New System.Drawing.Point(920, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cerrar listado"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.FalleroComisionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptListadoFallerosFamila.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 46)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1062, 508)
        Me.ReportViewer1.TabIndex = 1
        '
        'FalleroComisionTableAdapter
        '
        Me.FalleroComisionTableAdapter.ClearBeforeFill = True
        '
        'FrmListadoPorFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 553)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmListadoPorFamilias"
        Me.Text = "Listado Por Familias"
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FalleroComisionBindingSource As BindingSource
    Friend WithEvents DataSetFallero As DataSetFallero
    Friend WithEvents FalleroComisionTableAdapter As DataSetFalleroTableAdapters.FalleroComisionTableAdapter
End Class
