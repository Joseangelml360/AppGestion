<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichaEnBlanco
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
        Me.falleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.falleroTableAdapter = New AppGestion.ReportsDataSetTableAdapters.falleroTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.falleroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptFichaEnBlanco.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1130, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'falleroTableAdapter
        '
        Me.falleroTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1006, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FichaEnBlanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FichaEnBlanco"
        Me.Text = "FichaEnBlanco"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents falleroBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents falleroTableAdapter As ReportsDataSetTableAdapters.falleroTableAdapter
    Friend WithEvents Button1 As Button
End Class
