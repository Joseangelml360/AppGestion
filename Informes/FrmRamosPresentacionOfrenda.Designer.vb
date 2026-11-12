<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRamosPresentacionOfrenda
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FalleroComisionTableAdapter = New AppGestion.DataSetFalleroTableAdapters.FalleroComisionTableAdapter()
        Me.TSCerrar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.FalleroComisionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptRamos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1064, 515)
        Me.ReportViewer1.TabIndex = 0
        '
        'FalleroComisionTableAdapter
        '
        Me.FalleroComisionTableAdapter.ClearBeforeFill = True
        '
        'TSCerrar
        '
        Me.TSCerrar.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.TSCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TSCerrar.Location = New System.Drawing.Point(215, -2)
        Me.TSCerrar.Name = "TSCerrar"
        Me.TSCerrar.Size = New System.Drawing.Size(130, 29)
        Me.TSCerrar.TabIndex = 1
        Me.TSCerrar.Text = "Cerrar Listado"
        Me.TSCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSCerrar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripTextBox2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1067, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox1.Text = "Mujeres"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox2.Text = "Niñas"
        '
        'FrmRamosPresentacionOfrenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.TSCerrar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmRamosPresentacionOfrenda"
        Me.Text = "FrmRamosPresentacionOfrenda"
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FalleroComisionBindingSource As BindingSource
    Friend WithEvents DataSetFallero As DataSetFallero
    Friend WithEvents FalleroComisionTableAdapter As DataSetFalleroTableAdapters.FalleroComisionTableAdapter
    Friend WithEvents TSCerrar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
End Class
