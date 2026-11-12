<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcreedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcreedores))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.DeudoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeudoresTableAdapter = New AppGestion.ReportsDataSetTableAdapters.DeudoresTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeudoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DeudoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptAcreedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 66)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1067, 487)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeudoresBindingSource
        '
        Me.DeudoresBindingSource.DataMember = "Deudores"
        Me.DeudoresBindingSource.DataSource = Me.ReportsDataSet
        '
        'DeudoresTableAdapter
        '
        Me.DeudoresTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(951, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Listado de falleros con saldo a favor"
        '
        'FrmAcreedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAcreedores"
        Me.Text = "FrmAcreedores"
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeudoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DeudoresBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents DeudoresTableAdapter As ReportsDataSetTableAdapters.DeudoresTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
