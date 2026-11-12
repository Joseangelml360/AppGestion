<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeshacerRemesa
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
        Dim ConsolidarRemesaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeshacerRemesa))
        Me.FALLERO1DataGridView = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENEFICIOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEVBENEFIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECDEVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMPAGOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEUDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fallero1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Detalles_de_remesaDataGridView = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPagosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuentaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecdevDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonobenefiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallesDeRemesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEjecutar = New System.Windows.Forms.Button()
        Me.ConsolidarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.Fallero1TableAdapter = New AppGestion.DataSet1TableAdapters.Fallero1TableAdapter()
        Me.Detalles_de_remesaTableAdapter = New AppGestion.DataSet1TableAdapters.detalles_de_remesaTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        ConsolidarRemesaLabel = New System.Windows.Forms.Label()
        CType(Me.FALLERO1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalles_de_remesaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsolidarRemesaLabel
        '
        ConsolidarRemesaLabel.AutoSize = True
        ConsolidarRemesaLabel.Location = New System.Drawing.Point(23, 74)
        ConsolidarRemesaLabel.Name = "ConsolidarRemesaLabel"
        ConsolidarRemesaLabel.Size = New System.Drawing.Size(52, 17)
        ConsolidarRemesaLabel.TabIndex = 18
        ConsolidarRemesaLabel.Text = "Estado"
        '
        'FALLERO1DataGridView
        '
        Me.FALLERO1DataGridView.AllowUserToAddRows = False
        Me.FALLERO1DataGridView.AllowUserToDeleteRows = False
        Me.FALLERO1DataGridView.AutoGenerateColumns = False
        Me.FALLERO1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FALLERO1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.BENEFICIOSDataGridViewTextBoxColumn, Me.DEVBENEFIDataGridViewTextBoxColumn, Me.RECDEVDataGridViewTextBoxColumn, Me.OtrosCargosDataGridViewTextBoxColumn, Me.EntregasAcuentaDataGridViewTextBoxColumn, Me.PAGODataGridViewTextBoxColumn, Me.NUMPAGOSDataGridViewTextBoxColumn, Me.DEUDADataGridViewTextBoxColumn})
        Me.FALLERO1DataGridView.DataSource = Me.Fallero1BindingSource
        Me.FALLERO1DataGridView.Location = New System.Drawing.Point(26, 113)
        Me.FALLERO1DataGridView.Name = "FALLERO1DataGridView"
        Me.FALLERO1DataGridView.ReadOnly = True
        Me.FALLERO1DataGridView.RowHeadersWidth = 51
        Me.FALLERO1DataGridView.RowTemplate.Height = 24
        Me.FALLERO1DataGridView.Size = New System.Drawing.Size(396, 33)
        Me.FALLERO1DataGridView.TabIndex = 23
        Me.FALLERO1DataGridView.Visible = False
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 125
        '
        'BENEFICIOSDataGridViewTextBoxColumn
        '
        Me.BENEFICIOSDataGridViewTextBoxColumn.DataPropertyName = "BENEFICIOS"
        Me.BENEFICIOSDataGridViewTextBoxColumn.HeaderText = "BENEFICIOS"
        Me.BENEFICIOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BENEFICIOSDataGridViewTextBoxColumn.Name = "BENEFICIOSDataGridViewTextBoxColumn"
        Me.BENEFICIOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.BENEFICIOSDataGridViewTextBoxColumn.Width = 125
        '
        'DEVBENEFIDataGridViewTextBoxColumn
        '
        Me.DEVBENEFIDataGridViewTextBoxColumn.DataPropertyName = "DEV_BENEFI"
        Me.DEVBENEFIDataGridViewTextBoxColumn.HeaderText = "DEV_BENEFI"
        Me.DEVBENEFIDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DEVBENEFIDataGridViewTextBoxColumn.Name = "DEVBENEFIDataGridViewTextBoxColumn"
        Me.DEVBENEFIDataGridViewTextBoxColumn.ReadOnly = True
        Me.DEVBENEFIDataGridViewTextBoxColumn.Width = 125
        '
        'RECDEVDataGridViewTextBoxColumn
        '
        Me.RECDEVDataGridViewTextBoxColumn.DataPropertyName = "RECDEV"
        Me.RECDEVDataGridViewTextBoxColumn.HeaderText = "RECDEV"
        Me.RECDEVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECDEVDataGridViewTextBoxColumn.Name = "RECDEVDataGridViewTextBoxColumn"
        Me.RECDEVDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECDEVDataGridViewTextBoxColumn.Width = 125
        '
        'OtrosCargosDataGridViewTextBoxColumn
        '
        Me.OtrosCargosDataGridViewTextBoxColumn.DataPropertyName = "OtrosCargos"
        Me.OtrosCargosDataGridViewTextBoxColumn.HeaderText = "OtrosCargos"
        Me.OtrosCargosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OtrosCargosDataGridViewTextBoxColumn.Name = "OtrosCargosDataGridViewTextBoxColumn"
        Me.OtrosCargosDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtrosCargosDataGridViewTextBoxColumn.Width = 125
        '
        'EntregasAcuentaDataGridViewTextBoxColumn
        '
        Me.EntregasAcuentaDataGridViewTextBoxColumn.DataPropertyName = "EntregasAcuenta"
        Me.EntregasAcuentaDataGridViewTextBoxColumn.HeaderText = "EntregasAcuenta"
        Me.EntregasAcuentaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EntregasAcuentaDataGridViewTextBoxColumn.Name = "EntregasAcuentaDataGridViewTextBoxColumn"
        Me.EntregasAcuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntregasAcuentaDataGridViewTextBoxColumn.Width = 125
        '
        'PAGODataGridViewTextBoxColumn
        '
        Me.PAGODataGridViewTextBoxColumn.DataPropertyName = "PAGO"
        Me.PAGODataGridViewTextBoxColumn.HeaderText = "PAGO"
        Me.PAGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PAGODataGridViewTextBoxColumn.Name = "PAGODataGridViewTextBoxColumn"
        Me.PAGODataGridViewTextBoxColumn.ReadOnly = True
        Me.PAGODataGridViewTextBoxColumn.Width = 125
        '
        'NUMPAGOSDataGridViewTextBoxColumn
        '
        Me.NUMPAGOSDataGridViewTextBoxColumn.DataPropertyName = "NUM_PAGOS"
        Me.NUMPAGOSDataGridViewTextBoxColumn.HeaderText = "NUM_PAGOS"
        Me.NUMPAGOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMPAGOSDataGridViewTextBoxColumn.Name = "NUMPAGOSDataGridViewTextBoxColumn"
        Me.NUMPAGOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMPAGOSDataGridViewTextBoxColumn.Width = 125
        '
        'DEUDADataGridViewTextBoxColumn
        '
        Me.DEUDADataGridViewTextBoxColumn.DataPropertyName = "DEUDA"
        Me.DEUDADataGridViewTextBoxColumn.HeaderText = "DEUDA"
        Me.DEUDADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DEUDADataGridViewTextBoxColumn.Name = "DEUDADataGridViewTextBoxColumn"
        Me.DEUDADataGridViewTextBoxColumn.ReadOnly = True
        Me.DEUDADataGridViewTextBoxColumn.Width = 125
        '
        'Fallero1BindingSource
        '
        Me.Fallero1BindingSource.DataMember = "Fallero1"
        Me.Fallero1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalles_de_remesaDataGridView
        '
        Me.Detalles_de_remesaDataGridView.AllowUserToAddRows = False
        Me.Detalles_de_remesaDataGridView.AllowUserToDeleteRows = False
        Me.Detalles_de_remesaDataGridView.AutoGenerateColumns = False
        Me.Detalles_de_remesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalles_de_remesaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn1, Me.NumPagosDataGridViewTextBoxColumn1, Me.OtrosCargosDataGridViewTextBoxColumn1, Me.EntregasAcuentaDataGridViewTextBoxColumn1, Me.RecdevDataGridViewTextBoxColumn1, Me.AbonobenefiDataGridViewTextBoxColumn})
        Me.Detalles_de_remesaDataGridView.DataSource = Me.DetallesDeRemesaBindingSource
        Me.Detalles_de_remesaDataGridView.Location = New System.Drawing.Point(447, 113)
        Me.Detalles_de_remesaDataGridView.Name = "Detalles_de_remesaDataGridView"
        Me.Detalles_de_remesaDataGridView.ReadOnly = True
        Me.Detalles_de_remesaDataGridView.RowHeadersWidth = 51
        Me.Detalles_de_remesaDataGridView.RowTemplate.Height = 24
        Me.Detalles_de_remesaDataGridView.Size = New System.Drawing.Size(378, 33)
        Me.Detalles_de_remesaDataGridView.TabIndex = 24
        Me.Detalles_de_remesaDataGridView.Visible = False
        '
        'FALLEROCODIGODataGridViewTextBoxColumn1
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn1.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn1.HeaderText = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn1.Name = "FALLEROCODIGODataGridViewTextBoxColumn1"
        Me.FALLEROCODIGODataGridViewTextBoxColumn1.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn1.Width = 125
        '
        'NumPagosDataGridViewTextBoxColumn1
        '
        Me.NumPagosDataGridViewTextBoxColumn1.DataPropertyName = "NumPagos"
        Me.NumPagosDataGridViewTextBoxColumn1.HeaderText = "NumPagos"
        Me.NumPagosDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NumPagosDataGridViewTextBoxColumn1.Name = "NumPagosDataGridViewTextBoxColumn1"
        Me.NumPagosDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NumPagosDataGridViewTextBoxColumn1.Width = 125
        '
        'OtrosCargosDataGridViewTextBoxColumn1
        '
        Me.OtrosCargosDataGridViewTextBoxColumn1.DataPropertyName = "OtrosCargos"
        Me.OtrosCargosDataGridViewTextBoxColumn1.HeaderText = "OtrosCargos"
        Me.OtrosCargosDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.OtrosCargosDataGridViewTextBoxColumn1.Name = "OtrosCargosDataGridViewTextBoxColumn1"
        Me.OtrosCargosDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OtrosCargosDataGridViewTextBoxColumn1.Width = 125
        '
        'EntregasAcuentaDataGridViewTextBoxColumn1
        '
        Me.EntregasAcuentaDataGridViewTextBoxColumn1.DataPropertyName = "EntregasAcuenta"
        Me.EntregasAcuentaDataGridViewTextBoxColumn1.HeaderText = "EntregasAcuenta"
        Me.EntregasAcuentaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.EntregasAcuentaDataGridViewTextBoxColumn1.Name = "EntregasAcuentaDataGridViewTextBoxColumn1"
        Me.EntregasAcuentaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EntregasAcuentaDataGridViewTextBoxColumn1.Width = 125
        '
        'RecdevDataGridViewTextBoxColumn1
        '
        Me.RecdevDataGridViewTextBoxColumn1.DataPropertyName = "Recdev"
        Me.RecdevDataGridViewTextBoxColumn1.HeaderText = "Recdev"
        Me.RecdevDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.RecdevDataGridViewTextBoxColumn1.Name = "RecdevDataGridViewTextBoxColumn1"
        Me.RecdevDataGridViewTextBoxColumn1.ReadOnly = True
        Me.RecdevDataGridViewTextBoxColumn1.Width = 125
        '
        'AbonobenefiDataGridViewTextBoxColumn
        '
        Me.AbonobenefiDataGridViewTextBoxColumn.DataPropertyName = "abonobenefi"
        Me.AbonobenefiDataGridViewTextBoxColumn.HeaderText = "abonobenefi"
        Me.AbonobenefiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AbonobenefiDataGridViewTextBoxColumn.Name = "AbonobenefiDataGridViewTextBoxColumn"
        Me.AbonobenefiDataGridViewTextBoxColumn.ReadOnly = True
        Me.AbonobenefiDataGridViewTextBoxColumn.Width = 125
        '
        'DetallesDeRemesaBindingSource
        '
        Me.DetallesDeRemesaBindingSource.DataMember = "detalles de remesa"
        Me.DetallesDeRemesaBindingSource.DataSource = Me.DataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Consolidar Remesa"
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(707, 18)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(118, 37)
        Me.BtnSalir.TabIndex = 21
        Me.BtnSalir.Text = "Cancelar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(170, 71)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 26)
        Me.BtnEjecutar.TabIndex = 20
        Me.BtnEjecutar.Text = "Ejecutar"
        Me.BtnEjecutar.UseVisualStyleBackColor = True
        '
        'ConsolidarRemesaCheckBox
        '
        Me.ConsolidarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "ConsolidarRemesa", True))
        Me.ConsolidarRemesaCheckBox.Location = New System.Drawing.Point(81, 73)
        Me.ConsolidarRemesaCheckBox.Name = "ConsolidarRemesaCheckBox"
        Me.ConsolidarRemesaCheckBox.Size = New System.Drawing.Size(31, 24)
        Me.ConsolidarRemesaCheckBox.TabIndex = 19
        Me.ConsolidarRemesaCheckBox.UseVisualStyleBackColor = True
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(273, 71)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(552, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'Fallero1TableAdapter
        '
        Me.Fallero1TableAdapter.ClearBeforeFill = True
        '
        'Detalles_de_remesaTableAdapter
        '
        Me.Detalles_de_remesaTableAdapter.ClearBeforeFill = True
        '
        'FrmDeshacerRemesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(844, 165)
        Me.Controls.Add(Me.FALLERO1DataGridView)
        Me.Controls.Add(Me.Detalles_de_remesaDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEjecutar)
        Me.Controls.Add(ConsolidarRemesaLabel)
        Me.Controls.Add(Me.ConsolidarRemesaCheckBox)
        Me.Controls.Add(Me.ProgressBar1)
        Me.HelpProvider1.SetHelpKeyword(Me, "18")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDeshacerRemesa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deshacer Remesa"
        CType(Me.FALLERO1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalles_de_remesaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FALLERO1DataGridView As DataGridView
    Friend WithEvents Detalles_de_remesaDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnEjecutar As Button
    Friend WithEvents ConsolidarRemesaCheckBox As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents Fallero1BindingSource As BindingSource
    Friend WithEvents Fallero1TableAdapter As DataSet1TableAdapters.Fallero1TableAdapter
    Friend WithEvents DetallesDeRemesaBindingSource As BindingSource
    Friend WithEvents Detalles_de_remesaTableAdapter As DataSet1TableAdapters.detalles_de_remesaTableAdapter
    Friend WithEvents ComisiónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BENEFICIOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEVBENEFIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECDEVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMPAGOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEUDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NumPagosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuentaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RecdevDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AbonobenefiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
