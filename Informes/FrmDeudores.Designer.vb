<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deudores
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DeudoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.DeudoresTableAdapter = New AppGestion.ReportsDataSetTableAdapters.DeudoresTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DeudoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 31)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(132, 27)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.AppGestion.My.Resources.Resources.arrow_left
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(64, 27)
        Me.ToolStripMenuItem1.Text = "Ver"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Introducir nº de pagos Pdtes y hacer click en Ver"
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(951, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DeudoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptDeudores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 31)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1067, 523)
        Me.ReportViewer1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(980, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 8)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DeudoresBindingSource
        '
        Me.DeudoresBindingSource.DataMember = "Deudores"
        Me.DeudoresBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeudoresTableAdapter
        '
        Me.DeudoresTableAdapter.ClearBeforeFill = True
        '
        'Deudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "24")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "Deudores"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Listado Deudores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DeudoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DeudoresBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents DeudoresTableAdapter As ReportsDataSetTableAdapters.DeudoresTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button2 As Button
End Class
