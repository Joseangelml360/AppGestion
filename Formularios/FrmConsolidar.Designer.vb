<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsolidar
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
        Me.Detalles_de_remesaDataGridView = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPagosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecdevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonobenefiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallesDeRemesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEjecutar = New System.Windows.Forms.Button()
        Me.ConsolidarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FALLERO1DataGridView = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENEFICIOSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEV_BENEFI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECDEVDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuentaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMPAGOSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEUDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fallero1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.Fallero1TableAdapter = New AppGestion.DataSet1TableAdapters.Fallero1TableAdapter()
        Me.Detalles_de_remesaTableAdapter = New AppGestion.DataSet1TableAdapters.detalles_de_remesaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        ConsolidarRemesaLabel = New System.Windows.Forms.Label()
        CType(Me.Detalles_de_remesaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FALLERO1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsolidarRemesaLabel
        '
        ConsolidarRemesaLabel.AutoSize = True
        ConsolidarRemesaLabel.Location = New System.Drawing.Point(15, 76)
        ConsolidarRemesaLabel.Name = "ConsolidarRemesaLabel"
        ConsolidarRemesaLabel.Size = New System.Drawing.Size(52, 17)
        ConsolidarRemesaLabel.TabIndex = 10
        ConsolidarRemesaLabel.Text = "Estado"
        '
        'Detalles_de_remesaDataGridView
        '
        Me.Detalles_de_remesaDataGridView.AllowUserToAddRows = False
        Me.Detalles_de_remesaDataGridView.AllowUserToDeleteRows = False
        Me.Detalles_de_remesaDataGridView.AutoGenerateColumns = False
        Me.Detalles_de_remesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalles_de_remesaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.NumPagosDataGridViewTextBoxColumn, Me.OtrosCargosDataGridViewTextBoxColumn, Me.EntregasAcuentaDataGridViewTextBoxColumn, Me.RecdevDataGridViewTextBoxColumn, Me.AbonobenefiDataGridViewTextBoxColumn})
        Me.Detalles_de_remesaDataGridView.DataSource = Me.DetallesDeRemesaBindingSource
        Me.Detalles_de_remesaDataGridView.Location = New System.Drawing.Point(491, 115)
        Me.Detalles_de_remesaDataGridView.Name = "Detalles_de_remesaDataGridView"
        Me.Detalles_de_remesaDataGridView.ReadOnly = True
        Me.Detalles_de_remesaDataGridView.RowHeadersWidth = 51
        Me.Detalles_de_remesaDataGridView.RowTemplate.Height = 24
        Me.Detalles_de_remesaDataGridView.Size = New System.Drawing.Size(300, 33)
        Me.Detalles_de_remesaDataGridView.TabIndex = 14
        Me.Detalles_de_remesaDataGridView.Visible = False
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
        'NumPagosDataGridViewTextBoxColumn
        '
        Me.NumPagosDataGridViewTextBoxColumn.DataPropertyName = "NumPagos"
        Me.NumPagosDataGridViewTextBoxColumn.HeaderText = "NumPagos"
        Me.NumPagosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumPagosDataGridViewTextBoxColumn.Name = "NumPagosDataGridViewTextBoxColumn"
        Me.NumPagosDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumPagosDataGridViewTextBoxColumn.Width = 125
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
        'RecdevDataGridViewTextBoxColumn
        '
        Me.RecdevDataGridViewTextBoxColumn.DataPropertyName = "Recdev"
        Me.RecdevDataGridViewTextBoxColumn.HeaderText = "Recdev"
        Me.RecdevDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RecdevDataGridViewTextBoxColumn.Name = "RecdevDataGridViewTextBoxColumn"
        Me.RecdevDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecdevDataGridViewTextBoxColumn.Width = 125
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
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Consolidar Remesa"
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(699, 20)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(118, 37)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Cancelar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(162, 73)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 12
        Me.BtnEjecutar.Text = "Ejecutar"
        Me.BtnEjecutar.UseVisualStyleBackColor = True
        '
        'ConsolidarRemesaCheckBox
        '
        Me.ConsolidarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "ConsolidarRemesa", True))
        Me.ConsolidarRemesaCheckBox.Location = New System.Drawing.Point(73, 75)
        Me.ConsolidarRemesaCheckBox.Name = "ConsolidarRemesaCheckBox"
        Me.ConsolidarRemesaCheckBox.Size = New System.Drawing.Size(31, 24)
        Me.ConsolidarRemesaCheckBox.TabIndex = 11
        Me.ConsolidarRemesaCheckBox.UseVisualStyleBackColor = True
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(265, 73)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(552, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'FALLERO1DataGridView
        '
        Me.FALLERO1DataGridView.AllowUserToAddRows = False
        Me.FALLERO1DataGridView.AllowUserToDeleteRows = False
        Me.FALLERO1DataGridView.AutoGenerateColumns = False
        Me.FALLERO1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FALLERO1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn1, Me.BENEFICIOSDataGridViewTextBoxColumn1, Me.DEV_BENEFI, Me.RECDEVDataGridViewTextBoxColumn1, Me.OtrosCargosDataGridViewTextBoxColumn1, Me.EntregasAcuentaDataGridViewTextBoxColumn1, Me.PAGODataGridViewTextBoxColumn1, Me.NUMPAGOSDataGridViewTextBoxColumn1, Me.DEUDADataGridViewTextBoxColumn})
        Me.FALLERO1DataGridView.DataSource = Me.Fallero1BindingSource
        Me.FALLERO1DataGridView.Location = New System.Drawing.Point(12, 115)
        Me.FALLERO1DataGridView.Name = "FALLERO1DataGridView"
        Me.FALLERO1DataGridView.ReadOnly = True
        Me.FALLERO1DataGridView.RowHeadersWidth = 51
        Me.FALLERO1DataGridView.RowTemplate.Height = 24
        Me.FALLERO1DataGridView.Size = New System.Drawing.Size(409, 33)
        Me.FALLERO1DataGridView.TabIndex = 8
        Me.FALLERO1DataGridView.Visible = False
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
        'BENEFICIOSDataGridViewTextBoxColumn1
        '
        Me.BENEFICIOSDataGridViewTextBoxColumn1.DataPropertyName = "BENEFICIOS"
        Me.BENEFICIOSDataGridViewTextBoxColumn1.HeaderText = "BENEFICIOS"
        Me.BENEFICIOSDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.BENEFICIOSDataGridViewTextBoxColumn1.Name = "BENEFICIOSDataGridViewTextBoxColumn1"
        Me.BENEFICIOSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.BENEFICIOSDataGridViewTextBoxColumn1.Width = 125
        '
        'DEV_BENEFI
        '
        Me.DEV_BENEFI.DataPropertyName = "DEV_BENEFI"
        Me.DEV_BENEFI.HeaderText = "DEV_BENEFI"
        Me.DEV_BENEFI.MinimumWidth = 6
        Me.DEV_BENEFI.Name = "DEV_BENEFI"
        Me.DEV_BENEFI.ReadOnly = True
        Me.DEV_BENEFI.Width = 125
        '
        'RECDEVDataGridViewTextBoxColumn1
        '
        Me.RECDEVDataGridViewTextBoxColumn1.DataPropertyName = "RECDEV"
        Me.RECDEVDataGridViewTextBoxColumn1.HeaderText = "RECDEV"
        Me.RECDEVDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.RECDEVDataGridViewTextBoxColumn1.Name = "RECDEVDataGridViewTextBoxColumn1"
        Me.RECDEVDataGridViewTextBoxColumn1.ReadOnly = True
        Me.RECDEVDataGridViewTextBoxColumn1.Width = 125
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
        'PAGODataGridViewTextBoxColumn1
        '
        Me.PAGODataGridViewTextBoxColumn1.DataPropertyName = "PAGO"
        Me.PAGODataGridViewTextBoxColumn1.HeaderText = "PAGO"
        Me.PAGODataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.PAGODataGridViewTextBoxColumn1.Name = "PAGODataGridViewTextBoxColumn1"
        Me.PAGODataGridViewTextBoxColumn1.ReadOnly = True
        Me.PAGODataGridViewTextBoxColumn1.Width = 125
        '
        'NUMPAGOSDataGridViewTextBoxColumn1
        '
        Me.NUMPAGOSDataGridViewTextBoxColumn1.DataPropertyName = "NUM_PAGOS"
        Me.NUMPAGOSDataGridViewTextBoxColumn1.HeaderText = "NUM_PAGOS"
        Me.NUMPAGOSDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NUMPAGOSDataGridViewTextBoxColumn1.Name = "NUMPAGOSDataGridViewTextBoxColumn1"
        Me.NUMPAGOSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NUMPAGOSDataGridViewTextBoxColumn1.Width = 125
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Me.Detalles_de_remesaTableAdapter
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Me.EstadoTableAdapter
        Me.TableAdapterManager.Fallero1TableAdapter = Me.Fallero1TableAdapter
        Me.TableAdapterManager.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager.historfaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmConsolidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(837, 168)
        Me.Controls.Add(Me.Detalles_de_remesaDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEjecutar)
        Me.Controls.Add(ConsolidarRemesaLabel)
        Me.Controls.Add(Me.ConsolidarRemesaCheckBox)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.FALLERO1DataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "18")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmConsolidar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsolidar"
        CType(Me.Detalles_de_remesaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FALLERO1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Detalles_de_remesaDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnEjecutar As Button
    Friend WithEvents ConsolidarRemesaCheckBox As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents FALLERO1DataGridView As DataGridView
    Friend WithEvents DetallesDeRemesaBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents Fallero1BindingSource As BindingSource
    Friend WithEvents Fallero1TableAdapter As DataSet1TableAdapters.Fallero1TableAdapter
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumPagosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecdevDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbonobenefiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Detalles_de_remesaTableAdapter As DataSet1TableAdapters.detalles_de_remesaTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BENEFICIOSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DEV_BENEFI As DataGridViewTextBoxColumn
    Friend WithEvents RECDEVDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuentaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PAGODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NUMPAGOSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DEUDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
