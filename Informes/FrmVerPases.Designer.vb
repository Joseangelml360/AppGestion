<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerPases
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
        Dim PasemayorLabel As System.Windows.Forms.Label
        Dim PasejuvenilLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerPases))
        Me.PasemayorTextBox = New System.Windows.Forms.TextBox()
        Me.PasejuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSTxtFecha = New System.Windows.Forms.ToolStripTextBox()
        Me.TSAJuveniles = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSAMayores = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSA03 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnEjercicioSiguiente = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Pase03Textbox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.InfantilPaseJuvenilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfantilPaseJuvenilTableAdapter = New AppGestion.ReportsDataSetTableAdapters.InfantilPaseJuvenilTableAdapter()
        Me.EjercicioTableAdapter = New AppGestion.ReportsDataSetTableAdapters.ejercicioTableAdapter()
        PasemayorLabel = New System.Windows.Forms.Label()
        PasejuvenilLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfantilPaseJuvenilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasemayorLabel
        '
        PasemayorLabel.AutoSize = True
        PasemayorLabel.Location = New System.Drawing.Point(626, 48)
        PasemayorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasemayorLabel.Name = "PasemayorLabel"
        PasemayorLabel.Size = New System.Drawing.Size(82, 17)
        PasemayorLabel.TabIndex = 9
        PasemayorLabel.Text = "pasemayor:"
        '
        'PasejuvenilLabel
        '
        PasejuvenilLabel.AutoSize = True
        PasejuvenilLabel.Location = New System.Drawing.Point(856, 48)
        PasejuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasejuvenilLabel.Name = "PasejuvenilLabel"
        PasejuvenilLabel.Size = New System.Drawing.Size(83, 17)
        PasejuvenilLabel.TabIndex = 7
        PasejuvenilLabel.Text = "pasejuvenil:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(343, 48)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(103, 17)
        Label1.TabIndex = 13
        Label1.Text = "pase 0-3 años:"
        '
        'PasemayorTextBox
        '
        Me.PasemayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasemayor", True))
        Me.PasemayorTextBox.Enabled = False
        Me.PasemayorTextBox.Location = New System.Drawing.Point(715, 44)
        Me.PasemayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasemayorTextBox.Name = "PasemayorTextBox"
        Me.PasemayorTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PasemayorTextBox.TabIndex = 10
        '
        'PasejuvenilTextBox
        '
        Me.PasejuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasejuvenil", True))
        Me.PasejuvenilTextBox.Enabled = False
        Me.PasejuvenilTextBox.Location = New System.Drawing.Point(948, 44)
        Me.PasejuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasejuvenilTextBox.Name = "PasejuvenilTextBox"
        Me.PasejuvenilTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PasejuvenilTextBox.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.TSTxtFecha, Me.TSAJuveniles, Me.TSAMayores, Me.TSCerrar, Me.TSA03})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1093, 31)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(132, 27)
        Me.ToolStripTextBox1.Text = "Fecha pase:"
        '
        'TSTxtFecha
        '
        Me.TSTxtFecha.Name = "TSTxtFecha"
        Me.TSTxtFecha.Size = New System.Drawing.Size(132, 27)
        '
        'TSAJuveniles
        '
        Me.TSAJuveniles.Name = "TSAJuveniles"
        Me.TSAJuveniles.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.TSAJuveniles.Size = New System.Drawing.Size(139, 27)
        Me.TSAJuveniles.Text = "Infantil a Juvenil"
        '
        'TSAMayores
        '
        Me.TSAMayores.Name = "TSAMayores"
        Me.TSAMayores.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.TSAMayores.Size = New System.Drawing.Size(135, 27)
        Me.TSAMayores.Text = "Juvenil a Mayor"
        '
        'TSCerrar
        '
        Me.TSCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSCerrar.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.TSCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TSCerrar.Name = "TSCerrar"
        Me.TSCerrar.Size = New System.Drawing.Size(95, 27)
        Me.TSCerrar.Text = "   Cerrar"
        '
        'TSA03
        '
        Me.TSA03.Name = "TSA03"
        Me.TSA03.Size = New System.Drawing.Size(146, 27)
        Me.TSA03.Text = "0-3 años superado"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.InfantilPaseJuvenilBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptVerPases.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 82)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1093, 494)
        Me.ReportViewer1.TabIndex = 11
        '
        'BtnEjercicioSiguiente
        '
        Me.BtnEjercicioSiguiente.Location = New System.Drawing.Point(91, 42)
        Me.BtnEjercicioSiguiente.Name = "BtnEjercicioSiguiente"
        Me.BtnEjercicioSiguiente.Size = New System.Drawing.Size(167, 28)
        Me.BtnEjercicioSiguiente.TabIndex = 12
        Me.BtnEjercicioSiguiente.Text = "Ejercicio siguiente"
        Me.BtnEjercicioSiguiente.UseVisualStyleBackColor = True
        '
        'Pase03Textbox
        '
        Me.Pase03Textbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pase0_3", True))
        Me.Pase03Textbox.Enabled = False
        Me.Pase03Textbox.Location = New System.Drawing.Point(454, 45)
        Me.Pase03Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Pase03Textbox.Name = "Pase03Textbox"
        Me.Pase03Textbox.Size = New System.Drawing.Size(132, 22)
        Me.Pase03Textbox.TabIndex = 14
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InfantilPaseJuvenilBindingSource
        '
        Me.InfantilPaseJuvenilBindingSource.DataMember = "InfantilPaseJuvenil"
        Me.InfantilPaseJuvenilBindingSource.DataSource = Me.ReportsDataSet
        '
        'InfantilPaseJuvenilTableAdapter
        '
        Me.InfantilPaseJuvenilTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'FrmVerPases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 578)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Pase03Textbox)
        Me.Controls.Add(Me.BtnEjercicioSiguiente)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(PasemayorLabel)
        Me.Controls.Add(Me.PasemayorTextBox)
        Me.Controls.Add(PasejuvenilLabel)
        Me.Controls.Add(Me.PasejuvenilTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "36")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVerPases"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Listado Cambio de Comisión"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfantilPaseJuvenilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasemayorTextBox As TextBox
    Friend WithEvents PasejuvenilTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents TSTxtFecha As ToolStripTextBox
    Friend WithEvents TSAJuveniles As ToolStripMenuItem
    Friend WithEvents TSAMayores As ToolStripMenuItem
    Friend WithEvents TSCerrar As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InfantilPaseJuvenilBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents InfantilPaseJuvenilTableAdapter As ReportsDataSetTableAdapters.InfantilPaseJuvenilTableAdapter
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As ReportsDataSetTableAdapters.ejercicioTableAdapter
    Friend WithEvents BtnEjercicioSiguiente As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TSA03 As ToolStripMenuItem
    Friend WithEvents Pase03Textbox As TextBox
End Class
