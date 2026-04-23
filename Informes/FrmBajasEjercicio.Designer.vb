<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajasEjercicio
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
        Me.BajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcensosDataSet11 = New AppGestion.dbcensosDataSet1()
        Me.Bajas_ejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbcensosDataSet1 = New AppGestion.dbcensosDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Bajas_ejercicioTableAdapter = New AppGestion.dbcensosDataSet1TableAdapters.Bajas_ejercicioTableAdapter()
        Me.BajasTableAdapter = New AppGestion.dbcensosDataSet1TableAdapters.BajasTableAdapter()
        CType(Me.BajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcensosDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bajas_ejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcensosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BajasBindingSource
        '
        Me.BajasBindingSource.DataMember = "Bajas"
        Me.BajasBindingSource.DataSource = Me.DbcensosDataSet11
        '
        'DbcensosDataSet11
        '
        Me.DbcensosDataSet11.DataSetName = "dbcensosDataSet1"
        Me.DbcensosDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bajas_ejercicioBindingSource
        '
        Me.Bajas_ejercicioBindingSource.DataMember = "Bajas_ejercicio"
        Me.Bajas_ejercicioBindingSource.DataSource = Me.dbcensosDataSet1
        '
        'dbcensosDataSet1
        '
        Me.dbcensosDataSet1.DataSetName = "dbcensosDataSet1"
        Me.dbcensosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado Bajas del ejercicio"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(811, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BajasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptBajas1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(28, 83)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(927, 509)
        Me.ReportViewer1.TabIndex = 4
        '
        'Bajas_ejercicioTableAdapter
        '
        Me.Bajas_ejercicioTableAdapter.ClearBeforeFill = True
        '
        'BajasTableAdapter
        '
        Me.BajasTableAdapter.ClearBeforeFill = True
        '
        'FrmBajasEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 604)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBajasEjercicio"
        Me.Text = "FrmBajasEjercicio"
        CType(Me.BajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcensosDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bajas_ejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcensosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Bajas_ejercicioBindingSource As BindingSource
    Friend WithEvents dbcensosDataSet1 As dbcensosDataSet1
    Friend WithEvents Bajas_ejercicioTableAdapter As dbcensosDataSet1TableAdapters.Bajas_ejercicioTableAdapter
    Friend WithEvents DbcensosDataSet11 As dbcensosDataSet1
    Friend WithEvents BajasBindingSource As BindingSource
    Friend WithEvents BajasTableAdapter As dbcensosDataSet1TableAdapters.BajasTableAdapter
End Class
