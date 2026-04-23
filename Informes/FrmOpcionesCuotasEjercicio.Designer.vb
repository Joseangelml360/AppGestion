<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcionesCuotasEjercicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpcionesCuotasEjercicio))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSetCuotas = New AppGestion.DataSetCuotas()
        Me.ejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ejercicioTableAdapter = New AppGestion.DataSetCuotasTableAdapters.ejercicioTableAdapter()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ejercicioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptCuotasEjercicio.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 100)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1231, 527)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(1063, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 46)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 32)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Opciones Cuotas del ejercicio"
        '
        'DataSetCuotas
        '
        Me.DataSetCuotas.DataSetName = "DataSetCuotas"
        Me.DataSetCuotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ejercicioBindingSource
        '
        Me.ejercicioBindingSource.DataMember = "ejercicio"
        Me.ejercicioBindingSource.DataSource = Me.DataSetCuotas
        '
        'ejercicioTableAdapter
        '
        Me.ejercicioTableAdapter.ClearBeforeFill = True
        '
        'FrmOpcionesCuotasEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 627)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmOpcionesCuotasEjercicio"
        Me.Text = "FrmListadoCuotasEjercicio"
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button3 As Button
    Friend WithEvents ejercicioBindingSource As BindingSource
    Friend WithEvents DataSetCuotas As DataSetCuotas
    Friend WithEvents Label1 As Label
    Friend WithEvents ejercicioTableAdapter As DataSetCuotasTableAdapters.ejercicioTableAdapter
End Class
