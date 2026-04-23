<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaseAJuveniles
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
        Dim AsignarCambioComisiónInfLabel As System.Windows.Forms.Label
        Dim PasemayorLabel As System.Windows.Forms.Label
        Dim PasejuvenilLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaseAJuveniles))
        Me.BtnCambios = New System.Windows.Forms.Button()
        Me.AsignarCambioComisionJuvCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.AsignarCambioComisiónInfCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasemayorTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasejuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InfantilPaseJuvenilDataGridView = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHANACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAJADataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InfantilPaseJuvenilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.FillPaseJuvenilToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FECHA_NACToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FECHA_NACToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillPaseJuvenilToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BtnPaseMayor = New System.Windows.Forms.ToolStripButton()
        Me.BtnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.InfantilPaseJuvenilTableAdapter = New AppGestion.ReportsDataSetTableAdapters.InfantilPaseJuvenilTableAdapter()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.EjercicioTableAdapter = New AppGestion.DataSet1TableAdapters.ejercicioTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        AsignarCambioComisiónInfLabel = New System.Windows.Forms.Label()
        PasemayorLabel = New System.Windows.Forms.Label()
        PasejuvenilLabel = New System.Windows.Forms.Label()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfantilPaseJuvenilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfantilPaseJuvenilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillPaseJuvenilToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AsignarCambioComisiónInfLabel
        '
        AsignarCambioComisiónInfLabel.AutoSize = True
        AsignarCambioComisiónInfLabel.Location = New System.Drawing.Point(23, 109)
        AsignarCambioComisiónInfLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AsignarCambioComisiónInfLabel.Name = "AsignarCambioComisiónInfLabel"
        AsignarCambioComisiónInfLabel.Size = New System.Drawing.Size(107, 17)
        AsignarCambioComisiónInfLabel.TabIndex = 25
        AsignarCambioComisiónInfLabel.Text = "Aplicar cambios"
        '
        'PasemayorLabel
        '
        PasemayorLabel.AutoSize = True
        PasemayorLabel.Location = New System.Drawing.Point(600, 109)
        PasemayorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasemayorLabel.Name = "PasemayorLabel"
        PasemayorLabel.Size = New System.Drawing.Size(157, 17)
        PasemayorLabel.TabIndex = 22
        PasemayorLabel.Text = "Fecha Pase a mayores:"
        '
        'PasejuvenilLabel
        '
        PasejuvenilLabel.AutoSize = True
        PasejuvenilLabel.Location = New System.Drawing.Point(597, 77)
        PasejuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasejuvenilLabel.Name = "PasejuvenilLabel"
        PasejuvenilLabel.Size = New System.Drawing.Size(157, 17)
        PasejuvenilLabel.TabIndex = 19
        PasejuvenilLabel.Text = "Fecha pase a juveniles:"
        '
        'BtnCambios
        '
        Me.BtnCambios.Location = New System.Drawing.Point(138, 103)
        Me.BtnCambios.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCambios.Name = "BtnCambios"
        Me.BtnCambios.Size = New System.Drawing.Size(100, 28)
        Me.BtnCambios.TabIndex = 28
        Me.BtnCambios.Text = "Cambios"
        Me.BtnCambios.UseVisualStyleBackColor = True
        '
        'AsignarCambioComisionJuvCheckBox
        '
        Me.AsignarCambioComisionJuvCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarCambioComisionJuv", True))
        Me.AsignarCambioComisionJuvCheckBox.Location = New System.Drawing.Point(403, 103)
        Me.AsignarCambioComisionJuvCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarCambioComisionJuvCheckBox.Name = "AsignarCambioComisionJuvCheckBox"
        Me.AsignarCambioComisionJuvCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.AsignarCambioComisionJuvCheckBox.TabIndex = 27
        Me.AsignarCambioComisionJuvCheckBox.Text = "Juveniles"
        Me.AsignarCambioComisionJuvCheckBox.UseVisualStyleBackColor = True
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
        'AsignarCambioComisiónInfCheckBox
        '
        Me.AsignarCambioComisiónInfCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarCambioComisionInf", True))
        Me.AsignarCambioComisiónInfCheckBox.Location = New System.Drawing.Point(309, 103)
        Me.AsignarCambioComisiónInfCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarCambioComisiónInfCheckBox.Name = "AsignarCambioComisiónInfCheckBox"
        Me.AsignarCambioComisiónInfCheckBox.Size = New System.Drawing.Size(86, 30)
        Me.AsignarCambioComisiónInfCheckBox.TabIndex = 26
        Me.AsignarCambioComisiónInfCheckBox.Text = "Infantiles"
        Me.AsignarCambioComisiónInfCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 476)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Guardar o imprimir el informe"
        '
        'PasemayorTextBox
        '
        Me.PasemayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasemayor", True))
        Me.PasemayorTextBox.Location = New System.Drawing.Point(765, 105)
        Me.PasemayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasemayorTextBox.Name = "PasemayorTextBox"
        Me.PasemayorTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PasemayorTextBox.TabIndex = 23
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSet1
        '
        'PasejuvenilTextBox
        '
        Me.PasejuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasejuvenil", True))
        Me.PasejuvenilTextBox.Location = New System.Drawing.Point(765, 73)
        Me.PasejuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasejuvenilTextBox.Name = "PasejuvenilTextBox"
        Me.PasejuvenilTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PasejuvenilTextBox.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Pase de Infantil a Juvenil"
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.report
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(16, 499)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Ver informe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(741, 499)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InfantilPaseJuvenilDataGridView
        '
        Me.InfantilPaseJuvenilDataGridView.AutoGenerateColumns = False
        Me.InfantilPaseJuvenilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InfantilPaseJuvenilDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.TIPFALDataGridViewTextBoxColumn, Me.FECHANACDataGridViewTextBoxColumn, Me.BAJADataGridViewCheckBoxColumn})
        Me.InfantilPaseJuvenilDataGridView.DataSource = Me.InfantilPaseJuvenilBindingSource
        Me.InfantilPaseJuvenilDataGridView.Location = New System.Drawing.Point(16, 145)
        Me.InfantilPaseJuvenilDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.InfantilPaseJuvenilDataGridView.Name = "InfantilPaseJuvenilDataGridView"
        Me.InfantilPaseJuvenilDataGridView.RowHeadersWidth = 51
        Me.InfantilPaseJuvenilDataGridView.Size = New System.Drawing.Size(883, 313)
        Me.InfantilPaseJuvenilDataGridView.TabIndex = 16
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 125
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.Width = 125
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 125
        '
        'TIPFALDataGridViewTextBoxColumn
        '
        Me.TIPFALDataGridViewTextBoxColumn.DataPropertyName = "TIPFAL"
        Me.TIPFALDataGridViewTextBoxColumn.HeaderText = "TIPFAL"
        Me.TIPFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPFALDataGridViewTextBoxColumn.Name = "TIPFALDataGridViewTextBoxColumn"
        Me.TIPFALDataGridViewTextBoxColumn.Width = 125
        '
        'FECHANACDataGridViewTextBoxColumn
        '
        Me.FECHANACDataGridViewTextBoxColumn.DataPropertyName = "FECHA_NAC"
        Me.FECHANACDataGridViewTextBoxColumn.HeaderText = "FECHA_NAC"
        Me.FECHANACDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FECHANACDataGridViewTextBoxColumn.Name = "FECHANACDataGridViewTextBoxColumn"
        Me.FECHANACDataGridViewTextBoxColumn.Width = 125
        '
        'BAJADataGridViewCheckBoxColumn
        '
        Me.BAJADataGridViewCheckBoxColumn.DataPropertyName = "BAJA"
        Me.BAJADataGridViewCheckBoxColumn.HeaderText = "BAJA"
        Me.BAJADataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.BAJADataGridViewCheckBoxColumn.Name = "BAJADataGridViewCheckBoxColumn"
        Me.BAJADataGridViewCheckBoxColumn.Width = 125
        '
        'InfantilPaseJuvenilBindingSource
        '
        Me.InfantilPaseJuvenilBindingSource.DataMember = "InfantilPaseJuvenil"
        Me.InfantilPaseJuvenilBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FillPaseJuvenilToolStrip
        '
        Me.FillPaseJuvenilToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillPaseJuvenilToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FECHA_NACToolStripLabel, Me.FECHA_NACToolStripTextBox, Me.FillPaseJuvenilToolStripButton, Me.BtnPaseMayor, Me.BtnCerrar})
        Me.FillPaseJuvenilToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillPaseJuvenilToolStrip.Name = "FillPaseJuvenilToolStrip"
        Me.FillPaseJuvenilToolStrip.Size = New System.Drawing.Size(927, 27)
        Me.FillPaseJuvenilToolStrip.TabIndex = 15
        Me.FillPaseJuvenilToolStrip.Text = "FillPaseJuvenilToolStrip"
        '
        'FECHA_NACToolStripLabel
        '
        Me.FECHA_NACToolStripLabel.Name = "FECHA_NACToolStripLabel"
        Me.FECHA_NACToolStripLabel.Size = New System.Drawing.Size(85, 24)
        Me.FECHA_NACToolStripLabel.Text = "Fecha pase:"
        '
        'FECHA_NACToolStripTextBox
        '
        Me.FECHA_NACToolStripTextBox.Name = "FECHA_NACToolStripTextBox"
        Me.FECHA_NACToolStripTextBox.Size = New System.Drawing.Size(132, 27)
        '
        'FillPaseJuvenilToolStripButton
        '
        Me.FillPaseJuvenilToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillPaseJuvenilToolStripButton.Name = "FillPaseJuvenilToolStripButton"
        Me.FillPaseJuvenilToolStripButton.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.FillPaseJuvenilToolStripButton.Size = New System.Drawing.Size(122, 24)
        Me.FillPaseJuvenilToolStripButton.Text = "Pase a Juvenil"
        '
        'BtnPaseMayor
        '
        Me.BtnPaseMayor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnPaseMayor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPaseMayor.Margin = New System.Windows.Forms.Padding(0, 1, 20, 2)
        Me.BtnPaseMayor.Name = "BtnPaseMayor"
        Me.BtnPaseMayor.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnPaseMayor.Size = New System.Drawing.Size(120, 24)
        Me.BtnPaseMayor.Text = "Pase a Mayor"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnCerrar.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(87, 24)
        Me.BtnCerrar.Text = "Cerrar "
        '
        'InfantilPaseJuvenilTableAdapter
        '
        Me.InfantilPaseJuvenilTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'FrmPaseAJuveniles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(927, 553)
        Me.Controls.Add(Me.BtnCambios)
        Me.Controls.Add(Me.AsignarCambioComisionJuvCheckBox)
        Me.Controls.Add(AsignarCambioComisiónInfLabel)
        Me.Controls.Add(Me.AsignarCambioComisiónInfCheckBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(PasemayorLabel)
        Me.Controls.Add(Me.PasemayorTextBox)
        Me.Controls.Add(PasejuvenilLabel)
        Me.Controls.Add(Me.PasejuvenilTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InfantilPaseJuvenilDataGridView)
        Me.Controls.Add(Me.FillPaseJuvenilToolStrip)
        Me.HelpProvider1.SetHelpKeyword(Me, "62")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPaseAJuveniles"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Comisión"
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfantilPaseJuvenilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfantilPaseJuvenilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillPaseJuvenilToolStrip.ResumeLayout(False)
        Me.FillPaseJuvenilToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCambios As Button
    Friend WithEvents AsignarCambioComisionJuvCheckBox As CheckBox
    Friend WithEvents AsignarCambioComisiónInfCheckBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasemayorTextBox As TextBox
    Friend WithEvents PasejuvenilTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents InfantilPaseJuvenilDataGridView As DataGridView
    Friend WithEvents FillPaseJuvenilToolStrip As ToolStrip
    Friend WithEvents FECHA_NACToolStripLabel As ToolStripLabel
    Friend WithEvents FECHA_NACToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillPaseJuvenilToolStripButton As ToolStripButton
    Friend WithEvents BtnPaseMayor As ToolStripButton
    Friend WithEvents BtnCerrar As ToolStripButton
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHANACDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BAJADataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents InfantilPaseJuvenilBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents InfantilPaseJuvenilTableAdapter As ReportsDataSetTableAdapters.InfantilPaseJuvenilTableAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DataSet1TableAdapters.ejercicioTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
