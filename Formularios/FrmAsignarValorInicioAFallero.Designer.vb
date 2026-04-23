<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarValorInicioAFallero
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
        Dim NumcuotasmesLabel As System.Windows.Forms.Label
        Dim AsignarValoresFalleroLabel As System.Windows.Forms.Label
        Dim AñoejeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarValorInicioAFallero))
        Me.TxtNumRegistros = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.NumcuotasmesTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCuotas = New AppGestion.DataSetCuotas()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.AsignarValoresFalleroCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FALLERODataGridView = New System.Windows.Forms.DataGridView()
        Me.FALLERO_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORCUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCUENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_CUOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_PAGOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEUDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALCUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENEFICIOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEV_BENEFI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECDEV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEUDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.TableAdapterManager1 = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.AñoejeTextBox = New System.Windows.Forms.TextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.FalleroTableAdapter = New AppGestion.DataSetCuotasTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSetCuotasTableAdapters.TableAdapterManager()
        Me.EjercicioTableAdapter = New AppGestion.DataSetCuotasTableAdapters.ejercicioTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        NumcuotasmesLabel = New System.Windows.Forms.Label()
        AsignarValoresFalleroLabel = New System.Windows.Forms.Label()
        AñoejeLabel = New System.Windows.Forms.Label()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FALLERODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumcuotasmesLabel
        '
        NumcuotasmesLabel.AutoSize = True
        NumcuotasmesLabel.Location = New System.Drawing.Point(669, 81)
        NumcuotasmesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumcuotasmesLabel.Name = "NumcuotasmesLabel"
        NumcuotasmesLabel.Size = New System.Drawing.Size(107, 17)
        NumcuotasmesLabel.TabIndex = 17
        NumcuotasmesLabel.Text = "numcuotasmes:"
        '
        'AsignarValoresFalleroLabel
        '
        AsignarValoresFalleroLabel.AutoSize = True
        AsignarValoresFalleroLabel.Location = New System.Drawing.Point(37, 93)
        AsignarValoresFalleroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AsignarValoresFalleroLabel.Name = "AsignarValoresFalleroLabel"
        AsignarValoresFalleroLabel.Size = New System.Drawing.Size(159, 17)
        AsignarValoresFalleroLabel.TabIndex = 13
        AsignarValoresFalleroLabel.Text = "Asignar Valores Fallero:"
        '
        'AñoejeLabel
        '
        AñoejeLabel.AutoSize = True
        AñoejeLabel.Location = New System.Drawing.Point(328, 29)
        AñoejeLabel.Name = "AñoejeLabel"
        AñoejeLabel.Size = New System.Drawing.Size(65, 17)
        AñoejeLabel.TabIndex = 20
        AñoejeLabel.Text = "Ejercicio:"
        '
        'TxtNumRegistros
        '
        Me.TxtNumRegistros.Location = New System.Drawing.Point(456, 531)
        Me.TxtNumRegistros.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumRegistros.Name = "TxtNumRegistros"
        Me.TxtNumRegistros.ReadOnly = True
        Me.TxtNumRegistros.Size = New System.Drawing.Size(237, 22)
        Me.TxtNumRegistros.TabIndex = 20
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(92, 531)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(356, 25)
        Me.ProgressBar1.TabIndex = 19
        '
        'NumcuotasmesTextBox
        '
        Me.NumcuotasmesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.NumcuotasmesTextBox.Location = New System.Drawing.Point(785, 78)
        Me.NumcuotasmesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumcuotasmesTextBox.Name = "NumcuotasmesTextBox"
        Me.NumcuotasmesTextBox.Size = New System.Drawing.Size(49, 22)
        Me.NumcuotasmesTextBox.TabIndex = 18
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSetCuotas
        '
        'DataSetCuotas
        '
        Me.DataSetCuotas.DataSetName = "DataSetCuotas"
        Me.DataSetCuotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(348, 86)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(100, 28)
        Me.BtnActualizar.TabIndex = 15
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'AsignarValoresFalleroCheckBox
        '
        Me.AsignarValoresFalleroCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarValoresFallero", True))
        Me.AsignarValoresFalleroCheckBox.Location = New System.Drawing.Point(201, 86)
        Me.AsignarValoresFalleroCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarValoresFalleroCheckBox.Name = "AsignarValoresFalleroCheckBox"
        Me.AsignarValoresFalleroCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.AsignarValoresFalleroCheckBox.TabIndex = 14
        Me.AsignarValoresFalleroCheckBox.Text = "Sin Asignar"
        Me.AsignarValoresFalleroCheckBox.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Actualizar cuotas de inicio"
        '
        'FALLERODataGridView
        '
        Me.FALLERODataGridView.AllowUserToAddRows = False
        Me.FALLERODataGridView.AllowUserToDeleteRows = False
        Me.FALLERODataGridView.AutoGenerateColumns = False
        Me.FALLERODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FALLERODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLERO_CODIGO, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.TIPFALDataGridViewTextBoxColumn, Me.VALORCUOTADataGridViewTextBoxColumn, Me.DESCUENTODataGridViewTextBoxColumn, Me.PAGODataGridViewTextBoxColumn, Me.NUM_CUOTAS, Me.NUM_PAGOS, Me.DEUDADataGridViewTextBoxColumn, Me.TOTALCUOTADataGridViewTextBoxColumn, Me.ACUENTA, Me.CUOTA, Me.ValorDto, Me.BENEFICIOS, Me.DEV_BENEFI, Me.OtrosCargos, Me.A_CUENTA, Me.RECDEV, Me.DEUDA})
        Me.FALLERODataGridView.DataSource = Me.FalleroBindingSource
        Me.FALLERODataGridView.Location = New System.Drawing.Point(20, 140)
        Me.FALLERODataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.FALLERODataGridView.Name = "FALLERODataGridView"
        Me.FALLERODataGridView.RowHeadersWidth = 51
        Me.FALLERODataGridView.Size = New System.Drawing.Size(1035, 383)
        Me.FALLERODataGridView.TabIndex = 11
        '
        'FALLERO_CODIGO
        '
        Me.FALLERO_CODIGO.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLERO_CODIGO.HeaderText = "COD."
        Me.FALLERO_CODIGO.MinimumWidth = 6
        Me.FALLERO_CODIGO.Name = "FALLERO_CODIGO"
        Me.FALLERO_CODIGO.Width = 125
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
        'VALORCUOTADataGridViewTextBoxColumn
        '
        Me.VALORCUOTADataGridViewTextBoxColumn.DataPropertyName = "VALOR_CUOTA"
        Me.VALORCUOTADataGridViewTextBoxColumn.HeaderText = "VALOR_CUOTA"
        Me.VALORCUOTADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VALORCUOTADataGridViewTextBoxColumn.Name = "VALORCUOTADataGridViewTextBoxColumn"
        Me.VALORCUOTADataGridViewTextBoxColumn.Width = 125
        '
        'DESCUENTODataGridViewTextBoxColumn
        '
        Me.DESCUENTODataGridViewTextBoxColumn.DataPropertyName = "DESCUENTO"
        Me.DESCUENTODataGridViewTextBoxColumn.HeaderText = "DESCUENTO"
        Me.DESCUENTODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESCUENTODataGridViewTextBoxColumn.Name = "DESCUENTODataGridViewTextBoxColumn"
        Me.DESCUENTODataGridViewTextBoxColumn.Width = 125
        '
        'PAGODataGridViewTextBoxColumn
        '
        Me.PAGODataGridViewTextBoxColumn.DataPropertyName = "PAGO"
        Me.PAGODataGridViewTextBoxColumn.HeaderText = "PAGO"
        Me.PAGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PAGODataGridViewTextBoxColumn.Name = "PAGODataGridViewTextBoxColumn"
        Me.PAGODataGridViewTextBoxColumn.Width = 125
        '
        'NUM_CUOTAS
        '
        Me.NUM_CUOTAS.DataPropertyName = "NUM_CUOTAS"
        Me.NUM_CUOTAS.HeaderText = "NUM_CUOTAS"
        Me.NUM_CUOTAS.MinimumWidth = 6
        Me.NUM_CUOTAS.Name = "NUM_CUOTAS"
        Me.NUM_CUOTAS.Width = 125
        '
        'NUM_PAGOS
        '
        Me.NUM_PAGOS.DataPropertyName = "NUM_PAGOS"
        Me.NUM_PAGOS.HeaderText = "NUM_PAGOS"
        Me.NUM_PAGOS.MinimumWidth = 6
        Me.NUM_PAGOS.Name = "NUM_PAGOS"
        Me.NUM_PAGOS.Width = 125
        '
        'DEUDADataGridViewTextBoxColumn
        '
        Me.DEUDADataGridViewTextBoxColumn.DataPropertyName = "DEUDA"
        Me.DEUDADataGridViewTextBoxColumn.HeaderText = "DEUDA"
        Me.DEUDADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DEUDADataGridViewTextBoxColumn.Name = "DEUDADataGridViewTextBoxColumn"
        Me.DEUDADataGridViewTextBoxColumn.Width = 125
        '
        'TOTALCUOTADataGridViewTextBoxColumn
        '
        Me.TOTALCUOTADataGridViewTextBoxColumn.DataPropertyName = "TOTAL_CUOTA"
        Me.TOTALCUOTADataGridViewTextBoxColumn.HeaderText = "TOTAL_CUOTA"
        Me.TOTALCUOTADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TOTALCUOTADataGridViewTextBoxColumn.Name = "TOTALCUOTADataGridViewTextBoxColumn"
        Me.TOTALCUOTADataGridViewTextBoxColumn.Width = 125
        '
        'ACUENTA
        '
        Me.ACUENTA.DataPropertyName = "A_CUENTA"
        Me.ACUENTA.HeaderText = "A_CUENTA"
        Me.ACUENTA.MinimumWidth = 6
        Me.ACUENTA.Name = "ACUENTA"
        Me.ACUENTA.Width = 125
        '
        'CUOTA
        '
        Me.CUOTA.DataPropertyName = "CUOTA"
        Me.CUOTA.HeaderText = "CUOTA"
        Me.CUOTA.MinimumWidth = 6
        Me.CUOTA.Name = "CUOTA"
        Me.CUOTA.Width = 125
        '
        'ValorDto
        '
        Me.ValorDto.DataPropertyName = "ValorDto"
        Me.ValorDto.HeaderText = "ValorDto"
        Me.ValorDto.MinimumWidth = 6
        Me.ValorDto.Name = "ValorDto"
        Me.ValorDto.Width = 125
        '
        'BENEFICIOS
        '
        Me.BENEFICIOS.DataPropertyName = "BENEFICIOS"
        Me.BENEFICIOS.HeaderText = "BENEFICIOS"
        Me.BENEFICIOS.MinimumWidth = 6
        Me.BENEFICIOS.Name = "BENEFICIOS"
        Me.BENEFICIOS.Visible = False
        Me.BENEFICIOS.Width = 125
        '
        'DEV_BENEFI
        '
        Me.DEV_BENEFI.DataPropertyName = "DEV_BENEFI"
        Me.DEV_BENEFI.HeaderText = "DEV_BENEFI"
        Me.DEV_BENEFI.MinimumWidth = 6
        Me.DEV_BENEFI.Name = "DEV_BENEFI"
        Me.DEV_BENEFI.Visible = False
        Me.DEV_BENEFI.Width = 125
        '
        'OtrosCargos
        '
        Me.OtrosCargos.DataPropertyName = "OtrosCargos"
        Me.OtrosCargos.HeaderText = "OtrosCargos"
        Me.OtrosCargos.MinimumWidth = 6
        Me.OtrosCargos.Name = "OtrosCargos"
        Me.OtrosCargos.Visible = False
        Me.OtrosCargos.Width = 125
        '
        'A_CUENTA
        '
        Me.A_CUENTA.DataPropertyName = "A_CUENTA"
        Me.A_CUENTA.HeaderText = "A_CUENTA"
        Me.A_CUENTA.MinimumWidth = 6
        Me.A_CUENTA.Name = "A_CUENTA"
        Me.A_CUENTA.Visible = False
        Me.A_CUENTA.Width = 125
        '
        'RECDEV
        '
        Me.RECDEV.DataPropertyName = "RECDEV"
        Me.RECDEV.HeaderText = "RECDEV"
        Me.RECDEV.MinimumWidth = 6
        Me.RECDEV.Name = "RECDEV"
        Me.RECDEV.Visible = False
        Me.RECDEV.Width = 125
        '
        'DEUDA
        '
        Me.DEUDA.DataPropertyName = "DEUDA"
        Me.DEUDA.HeaderText = "DEUDA"
        Me.DEUDA.MinimumWidth = 6
        Me.DEUDA.Name = "DEUDA"
        Me.DEUDA.Visible = False
        Me.DEUDA.Width = 125
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DataSetCuotas
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cargoTableAdapter = Nothing
        Me.TableAdapterManager1.criteriorecompTableAdapter = Nothing
        Me.TableAdapterManager1.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager1.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager1.estadoTableAdapter = Me.EstadoTableAdapter
        Me.TableAdapterManager1.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager1.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager1.historfaTableAdapter = Nothing
        Me.TableAdapterManager1.MensajesTableAdapter = Nothing
        Me.TableAdapterManager1.recompensasejercicioTableAdapter = Nothing
        Me.TableAdapterManager1.recompensasTableAdapter = Nothing
        Me.TableAdapterManager1.remesasTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AñoejeTextBox
        '
        Me.AñoejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.AñoejeTextBox.Location = New System.Drawing.Point(405, 26)
        Me.AñoejeTextBox.Name = "AñoejeTextBox"
        Me.AñoejeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AñoejeTextBox.TabIndex = 21
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(898, 69)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Cancelar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Me.EjercicioTableAdapter
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSetCuotasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(604, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Label2"
        '
        'FrmAsignarValorInicioAFallero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1077, 583)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(AñoejeLabel)
        Me.Controls.Add(Me.AñoejeTextBox)
        Me.Controls.Add(Me.TxtNumRegistros)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(NumcuotasmesLabel)
        Me.Controls.Add(Me.NumcuotasmesTextBox)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(AsignarValoresFalleroLabel)
        Me.Controls.Add(Me.AsignarValoresFalleroCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FALLERODataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "65")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAsignarValorInicioAFallero"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Valores de inicio"
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FALLERODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNumRegistros As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents NumcuotasmesTextBox As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents AsignarValoresFalleroCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FALLERODataGridView As DataGridView
    Friend WithEvents DataSetCuotas As DataSetCuotas
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DataSetCuotasTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCuotasTableAdapters.TableAdapterManager
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents EjercicioTableAdapter As DataSetCuotasTableAdapters.ejercicioTableAdapter
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents AñoejeTextBox As TextBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents FALLERO_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VALORCUOTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCUENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUM_CUOTAS As DataGridViewTextBoxColumn
    Friend WithEvents NUM_PAGOS As DataGridViewTextBoxColumn
    Friend WithEvents DEUDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALCUOTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACUENTA As DataGridViewTextBoxColumn
    Friend WithEvents CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents ValorDto As DataGridViewTextBoxColumn
    Friend WithEvents BENEFICIOS As DataGridViewTextBoxColumn
    Friend WithEvents DEV_BENEFI As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargos As DataGridViewTextBoxColumn
    Friend WithEvents A_CUENTA As DataGridViewTextBoxColumn
    Friend WithEvents RECDEV As DataGridViewTextBoxColumn
    Friend WithEvents DEUDA As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
End Class
