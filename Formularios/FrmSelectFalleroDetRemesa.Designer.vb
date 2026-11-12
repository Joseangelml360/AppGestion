<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectFalleroDetRemesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectFalleroDetRemesa))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaCargo = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaCrea = New System.Windows.Forms.DateTimePicker()
        Me.TxtNumPagos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtValDev = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DbCensos = New AppGestion.DbCensos()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.FalleroDgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAJA = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BANCO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BENEFICIOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEV_BENEFI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECDEV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCUENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_PAGOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEUDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_CUOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Detalles_de_remesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalles_de_remesaTableAdapter = New AppGestion.DataSet1TableAdapters.detalles_de_remesaTableAdapter()
        Me.TableAdapterManager1 = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.FalleroDetalleRemesaTableAdapter = New AppGestion.DataSet1TableAdapters.FalleroDetalleRemesaTableAdapter()
        Me.FalleroDetalleRemesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalles_de_remesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroDetalleRemesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Fecha Cargo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Fecha Creación:"
        '
        'DtpFechaCargo
        '
        Me.DtpFechaCargo.Enabled = False
        Me.DtpFechaCargo.Location = New System.Drawing.Point(463, 95)
        Me.DtpFechaCargo.Name = "DtpFechaCargo"
        Me.DtpFechaCargo.Size = New System.Drawing.Size(128, 22)
        Me.DtpFechaCargo.TabIndex = 28
        '
        'DtpFechaCrea
        '
        Me.DtpFechaCrea.Enabled = False
        Me.DtpFechaCrea.Location = New System.Drawing.Point(156, 92)
        Me.DtpFechaCrea.Name = "DtpFechaCrea"
        Me.DtpFechaCrea.Size = New System.Drawing.Size(128, 22)
        Me.DtpFechaCrea.TabIndex = 27
        '
        'TxtNumPagos
        '
        Me.TxtNumPagos.Location = New System.Drawing.Point(264, 60)
        Me.TxtNumPagos.Name = "TxtNumPagos"
        Me.TxtNumPagos.ReadOnly = True
        Me.TxtNumPagos.Size = New System.Drawing.Size(77, 22)
        Me.TxtNumPagos.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Núm Pagos:"
        '
        'TxtValDev
        '
        Me.TxtValDev.Location = New System.Drawing.Point(514, 62)
        Me.TxtValDev.Name = "TxtValDev"
        Me.TxtValDev.ReadOnly = True
        Me.TxtValDev.Size = New System.Drawing.Size(77, 22)
        Me.TxtValDev.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Valor recibo devuelto:"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(56, 64)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(77, 22)
        Me.TxtId.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Añadir Fallero a Remesa"
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(657, 115)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(118, 37)
        Me.BtnAñadir.TabIndex = 19
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(657, 20)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(118, 37)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Buscar por apellidos:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(171, 132)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(251, 22)
        Me.TxtBuscar.TabIndex = 16
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DbCensos
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adeudosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banco_remesaTableAdapter = Nothing
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.CensoTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.comisionTableAdapter = Nothing
        Me.TableAdapterManager.datos_banco_para_abonosTableAdapter = Nothing
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa1TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa2TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.fallasTableAdapter = Nothing
        Me.TableAdapterManager.falleroTableAdapter = Me.FalleroTableAdapter
        'Me.TableAdapterManager.historfaTableAdapter = Nothing
        Me.TableAdapterManager.letradniTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FalleroDgv
        '
        Me.FalleroDgv.AutoGenerateColumns = False
        Me.FalleroDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FalleroDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn23, Me.BAJA, Me.BANCO, Me.BENEFICIOS, Me.DEV_BENEFI, Me.RECDEV, Me.VALOR_CUOTA, Me.TIPO_CUOTA, Me.DESCUENTO, Me.PAGO, Me.NUM_PAGOS, Me.DEUDA, Me.NUM_CUOTAS, Me.A_CUENTA, Me.OtrosCargos, Me.EntregasAcuenta, Me.TIPFAL, Me.CUENTA, Me.DataGridViewTextBoxColumn2})
        Me.FalleroDgv.DataSource = Me.FalleroBindingSource
        Me.FalleroDgv.Location = New System.Drawing.Point(12, 181)
        Me.FalleroDgv.Name = "FalleroDgv"
        Me.FalleroDgv.RowHeadersWidth = 51
        Me.FalleroDgv.RowTemplate.Height = 24
        Me.FalleroDgv.Size = New System.Drawing.Size(763, 265)
        Me.FalleroDgv.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FALLERO_CODIGO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APELLIDOS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDOS"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TITULAR"
        Me.DataGridViewTextBoxColumn23.HeaderText = "TITULAR"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 300
        '
        'BAJA
        '
        Me.BAJA.DataPropertyName = "BAJA"
        Me.BAJA.HeaderText = "BAJA"
        Me.BAJA.MinimumWidth = 6
        Me.BAJA.Name = "BAJA"
        Me.BAJA.Visible = False
        Me.BAJA.Width = 125
        '
        'BANCO
        '
        Me.BANCO.DataPropertyName = "BANCO"
        Me.BANCO.HeaderText = "BANCO"
        Me.BANCO.MinimumWidth = 6
        Me.BANCO.Name = "BANCO"
        Me.BANCO.Visible = False
        Me.BANCO.Width = 125
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
        'RECDEV
        '
        Me.RECDEV.DataPropertyName = "RECDEV"
        Me.RECDEV.HeaderText = "RECDEV"
        Me.RECDEV.MinimumWidth = 6
        Me.RECDEV.Name = "RECDEV"
        Me.RECDEV.Visible = False
        Me.RECDEV.Width = 125
        '
        'VALOR_CUOTA
        '
        Me.VALOR_CUOTA.DataPropertyName = "VALOR_CUOTA"
        Me.VALOR_CUOTA.HeaderText = "VALOR_CUOTA"
        Me.VALOR_CUOTA.MinimumWidth = 6
        Me.VALOR_CUOTA.Name = "VALOR_CUOTA"
        Me.VALOR_CUOTA.Visible = False
        Me.VALOR_CUOTA.Width = 125
        '
        'TIPO_CUOTA
        '
        Me.TIPO_CUOTA.DataPropertyName = "TIPO_CUOTA"
        Me.TIPO_CUOTA.HeaderText = "TIPO_CUOTA"
        Me.TIPO_CUOTA.MinimumWidth = 6
        Me.TIPO_CUOTA.Name = "TIPO_CUOTA"
        Me.TIPO_CUOTA.Visible = False
        Me.TIPO_CUOTA.Width = 125
        '
        'DESCUENTO
        '
        Me.DESCUENTO.DataPropertyName = "DESCUENTO"
        Me.DESCUENTO.HeaderText = "DESCUENTO"
        Me.DESCUENTO.MinimumWidth = 6
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Visible = False
        Me.DESCUENTO.Width = 125
        '
        'PAGO
        '
        Me.PAGO.DataPropertyName = "PAGO"
        Me.PAGO.HeaderText = "PAGO"
        Me.PAGO.MinimumWidth = 6
        Me.PAGO.Name = "PAGO"
        Me.PAGO.Visible = False
        Me.PAGO.Width = 125
        '
        'NUM_PAGOS
        '
        Me.NUM_PAGOS.DataPropertyName = "NUM_PAGOS"
        Me.NUM_PAGOS.HeaderText = "NUM_PAGOS"
        Me.NUM_PAGOS.MinimumWidth = 6
        Me.NUM_PAGOS.Name = "NUM_PAGOS"
        Me.NUM_PAGOS.Visible = False
        Me.NUM_PAGOS.Width = 125
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
        'NUM_CUOTAS
        '
        Me.NUM_CUOTAS.DataPropertyName = "NUM_CUOTAS"
        Me.NUM_CUOTAS.HeaderText = "NUM_CUOTAS"
        Me.NUM_CUOTAS.MinimumWidth = 6
        Me.NUM_CUOTAS.Name = "NUM_CUOTAS"
        Me.NUM_CUOTAS.Visible = False
        Me.NUM_CUOTAS.Width = 125
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
        'OtrosCargos
        '
        Me.OtrosCargos.DataPropertyName = "OtrosCargos"
        Me.OtrosCargos.HeaderText = "OtrosCargos"
        Me.OtrosCargos.MinimumWidth = 6
        Me.OtrosCargos.Name = "OtrosCargos"
        Me.OtrosCargos.Visible = False
        Me.OtrosCargos.Width = 125
        '
        'EntregasAcuenta
        '
        Me.EntregasAcuenta.DataPropertyName = "EntregasAcuenta"
        Me.EntregasAcuenta.HeaderText = "EntregasAcuenta"
        Me.EntregasAcuenta.MinimumWidth = 6
        Me.EntregasAcuenta.Name = "EntregasAcuenta"
        Me.EntregasAcuenta.Visible = False
        Me.EntregasAcuenta.Width = 125
        '
        'TIPFAL
        '
        Me.TIPFAL.DataPropertyName = "TIPFAL"
        Me.TIPFAL.HeaderText = "TIPFAL"
        Me.TIPFAL.MinimumWidth = 6
        Me.TIPFAL.Name = "TIPFAL"
        Me.TIPFAL.Visible = False
        Me.TIPFAL.Width = 125
        '
        'CUENTA
        '
        Me.CUENTA.DataPropertyName = "CUENTA"
        Me.CUENTA.HeaderText = "CUENTA"
        Me.CUENTA.MinimumWidth = 6
        Me.CUENTA.Name = "CUENTA"
        Me.CUENTA.Visible = False
        Me.CUENTA.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NUM_CUOTAS"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NUM_CUOTAS"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalles_de_remesaBindingSource
        '
        Me.Detalles_de_remesaBindingSource.DataMember = "detalles de remesa"
        Me.Detalles_de_remesaBindingSource.DataSource = Me.DataSet1
        '
        'Detalles_de_remesaTableAdapter
        '
        Me.Detalles_de_remesaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cargoTableAdapter = Nothing
        Me.TableAdapterManager1.detalles_de_remesaTableAdapter = Me.Detalles_de_remesaTableAdapter
        Me.TableAdapterManager1.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager1.estadoTableAdapter = Nothing
        Me.TableAdapterManager1.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager1.FalleroDetalleRemesaTableAdapter = Me.FalleroDetalleRemesaTableAdapter
        Me.TableAdapterManager1.historfaTableAdapter = Nothing
        Me.TableAdapterManager1.recompensasTableAdapter = Nothing
        Me.TableAdapterManager1.remesasTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FalleroDetalleRemesaTableAdapter
        '
        Me.FalleroDetalleRemesaTableAdapter.ClearBeforeFill = True
        '
        'FalleroDetalleRemesaBindingSource
        '
        Me.FalleroDetalleRemesaBindingSource.DataMember = "FalleroDetalleRemesa"
        Me.FalleroDetalleRemesaBindingSource.DataSource = Me.DataSet1
        '
        'FrmSelectFalleroDetRemesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(795, 466)
        Me.Controls.Add(Me.FalleroDgv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpFechaCargo)
        Me.Controls.Add(Me.DtpFechaCrea)
        Me.Controls.Add(Me.TxtNumPagos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtValDev)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.HelpProvider1.SetHelpKeyword(Me, "57")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSelectFalleroDetRemesa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar fallero"
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalles_de_remesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroDetalleRemesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpFechaCargo As DateTimePicker
    Friend WithEvents DtpFechaCrea As DateTimePicker
    Friend WithEvents TxtNumPagos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtValDev As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents FalleroDgv As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Detalles_de_remesaBindingSource As BindingSource
    Friend WithEvents Detalles_de_remesaTableAdapter As DataSet1TableAdapters.detalles_de_remesaTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FalleroDetalleRemesaTableAdapter As DataSet1TableAdapters.FalleroDetalleRemesaTableAdapter
    Friend WithEvents FalleroDetalleRemesaBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents BAJA As DataGridViewCheckBoxColumn
    Friend WithEvents BANCO As DataGridViewCheckBoxColumn
    Friend WithEvents BENEFICIOS As DataGridViewTextBoxColumn
    Friend WithEvents DEV_BENEFI As DataGridViewTextBoxColumn
    Friend WithEvents RECDEV As DataGridViewTextBoxColumn
    Friend WithEvents VALOR_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents DESCUENTO As DataGridViewTextBoxColumn
    Friend WithEvents PAGO As DataGridViewTextBoxColumn
    Friend WithEvents NUM_PAGOS As DataGridViewTextBoxColumn
    Friend WithEvents DEUDA As DataGridViewTextBoxColumn
    Friend WithEvents NUM_CUOTAS As DataGridViewTextBoxColumn
    Friend WithEvents A_CUENTA As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargos As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuenta As DataGridViewTextBoxColumn
    Friend WithEvents TIPFAL As DataGridViewTextBoxColumn
    Friend WithEvents CUENTA As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
