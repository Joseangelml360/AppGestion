<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFallerosDescuentoFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFallerosDescuentoFamilia))
        Me.falleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbcensosDataSet1 = New AppGestion.dbcensosDataSet1()
        Me.BajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BajasTableAdapter = New AppGestion.dbcensosDataSet1TableAdapters.BajasTableAdapter()
        Me.falleroTableAdapter = New AppGestion.ReportsDataSetTableAdapters.falleroTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcensosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'falleroBindingSource
        '
        Me.falleroBindingSource.DataMember = "fallero"
        Me.falleroBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.falleroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptFallerosDescuentoFamilia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 49)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1200, 490)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbcensosDataSet1
        '
        Me.dbcensosDataSet1.DataSetName = "dbcensosDataSet1"
        Me.dbcensosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BajasBindingSource
        '
        Me.BajasBindingSource.DataMember = "Bajas"
        Me.BajasBindingSource.DataSource = Me.dbcensosDataSet1
        '
        'BajasTableAdapter
        '
        Me.BajasTableAdapter.ClearBeforeFill = True
        '
        'falleroTableAdapter
        '
        Me.falleroTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Falleros con descuento por familia"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1090, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmFallerosDescuentoFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 539)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFallerosDescuentoFamilia"
        Me.Text = "Falleros con Descuento por Familia"
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcensosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BajasBindingSource As BindingSource
    Friend WithEvents dbcensosDataSet1 As dbcensosDataSet1
    Friend WithEvents BajasTableAdapter As dbcensosDataSet1TableAdapters.BajasTableAdapter
    Friend WithEvents falleroBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents falleroTableAdapter As ReportsDataSetTableAdapters.falleroTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
