<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCensoHistorico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCensoHistorico))
        Me.CensoHistoricoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataSet11 = New AppGestion.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CensoHistoricoTableAdapter = New AppGestion.DataSet1TableAdapters.CensoHistoricoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.CensoHistoricoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CensoHistoricoBindingSource
        '
        Me.CensoHistoricoBindingSource.DataMember = "CensoHistorico"
        Me.CensoHistoricoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(865, 72)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Introduce un año " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a partir de 1947"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Infantiles", "Mayores"})
        Me.ComboBox1.Location = New System.Drawing.Point(187, 93)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 93)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 6
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CensoHistoricoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.ReportCensoHistorico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(28, 129)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1036, 351)
        Me.ReportViewer1.TabIndex = 11
        '
        'CensoHistoricoTableAdapter
        '
        Me.CensoHistoricoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Censo Histórico"
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.table_add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(385, 72)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 46)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cargar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCensoHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 492)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.HelpProvider1.SetHelpKeyword(Me, "30")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCensoHistorico"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Censo Histórico"
        CType(Me.CensoHistoricoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CensoHistoricoBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CensoHistoricoTableAdapter As DataSet1TableAdapters.CensoHistoricoTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
