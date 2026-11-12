<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportarRemesas
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
        Me.RemesasTodasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExportRemesasCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RemesasTodasTableAdapter = New AppGestion.ReportsDataSetTableAdapters.RemesasTodasTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.RemesasTodasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RemesasTodasBindingSource
        '
        Me.RemesasTodasBindingSource.DataMember = "RemesasTodas"
        Me.RemesasTodasBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Exportar Tabla remesas a excel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(641, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sin exportar"
        '
        'ExportRemesasCheckBox
        '
        Me.ExportRemesasCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "ExportRemesas", True))
        Me.ExportRemesasCheckBox.Location = New System.Drawing.Point(609, 91)
        Me.ExportRemesasCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportRemesasCheckBox.Name = "ExportRemesasCheckBox"
        Me.ExportRemesasCheckBox.Size = New System.Drawing.Size(24, 30)
        Me.ExportRemesasCheckBox.TabIndex = 13
        Me.ExportRemesasCheckBox.Text = "CheckBox1"
        Me.ExportRemesasCheckBox.UseVisualStyleBackColor = True
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(501, 91)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Click"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(908, 73)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Exporta el informe a Excel y haz click cuando esté exportado"
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RemesasTodasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptExportarRemesas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(14, 138)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1050, 412)
        Me.ReportViewer1.TabIndex = 16
        '
        'RemesasTodasTableAdapter
        '
        Me.RemesasTodasTableAdapter.ClearBeforeFill = True
        '
        'FrmExportarRemesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 574)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExportRemesasCheckBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "58")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmExportarRemesas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "FrmExportarRemesas"
        CType(Me.RemesasTodasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExportRemesasCheckBox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RemesasTodasBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents RemesasTodasTableAdapter As ReportsDataSetTableAdapters.RemesasTodasTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
