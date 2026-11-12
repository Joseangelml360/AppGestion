<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarRemesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarRemesa))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EliminarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.RemesasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdRemesaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FijarDatosDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TITULARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOCUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesesAdeudoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENEFICIOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEVBENEFIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCuotaAnualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoBeneficioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosPdtesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecdevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValordevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonobenefiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumaOtrosCargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalreciboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DevolucionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BloqueadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RemesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.RemesasTableAdapter = New AppGestion.DataSet1TableAdapters.remesasTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(890, 32)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(18, 94)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EliminarRemesaCheckBox
        '
        Me.EliminarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "EliminarRemesa", True))
        Me.EliminarRemesaCheckBox.Location = New System.Drawing.Point(221, 99)
        Me.EliminarRemesaCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EliminarRemesaCheckBox.Name = "EliminarRemesaCheckBox"
        Me.EliminarRemesaCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.EliminarRemesaCheckBox.TabIndex = 9
        Me.EliminarRemesaCheckBox.Text = "No eliminada"
        Me.EliminarRemesaCheckBox.UseVisualStyleBackColor = True
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
        'RemesasDataGridView
        '
        Me.RemesasDataGridView.AllowUserToAddRows = False
        Me.RemesasDataGridView.AllowUserToDeleteRows = False
        Me.RemesasDataGridView.AutoGenerateColumns = False
        Me.RemesasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemesasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRemesaDataGridViewTextBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn, Me.FechaCargoDataGridViewTextBoxColumn, Me.FijarDatosDataGridViewCheckBoxColumn, Me.TITULARDataGridViewTextBoxColumn, Me.CODIGODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.TIPOCUOTADataGridViewTextBoxColumn, Me.ImporteCuotaDataGridViewTextBoxColumn, Me.MesesAdeudoDataGridViewTextBoxColumn, Me.BENEFICIOSDataGridViewTextBoxColumn, Me.DEVBENEFIDataGridViewTextBoxColumn, Me.TotalCuotaAnualDataGridViewTextBoxColumn, Me.OtrosCargosDataGridViewTextBoxColumn, Me.EntregasAcuentaDataGridViewTextBoxColumn, Me.CtaBancoDataGridViewTextBoxColumn, Me.RestoBeneficioDataGridViewTextBoxColumn, Me.PagosPdtesDataGridViewTextBoxColumn, Me.RecdevDataGridViewTextBoxColumn, Me.ValordevDataGridViewTextBoxColumn, Me.TotalCuotaDataGridViewTextBoxColumn, Me.TotalCargoDataGridViewTextBoxColumn, Me.AbonobenefiDataGridViewTextBoxColumn, Me.SumaOtrosCargosDataGridViewTextBoxColumn, Me.TotalreciboDataGridViewTextBoxColumn, Me.DevolucionDataGridViewCheckBoxColumn, Me.BloqueadoDataGridViewCheckBoxColumn})
        Me.RemesasDataGridView.DataSource = Me.RemesasBindingSource
        Me.RemesasDataGridView.Location = New System.Drawing.Point(13, 158)
        Me.RemesasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.RemesasDataGridView.Name = "RemesasDataGridView"
        Me.RemesasDataGridView.ReadOnly = True
        Me.RemesasDataGridView.RowHeadersWidth = 51
        Me.RemesasDataGridView.Size = New System.Drawing.Size(1035, 382)
        Me.RemesasDataGridView.TabIndex = 8
        '
        'IdRemesaDataGridViewTextBoxColumn
        '
        Me.IdRemesaDataGridViewTextBoxColumn.DataPropertyName = "IdRemesa"
        Me.IdRemesaDataGridViewTextBoxColumn.HeaderText = "IdRemesa"
        Me.IdRemesaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdRemesaDataGridViewTextBoxColumn.Name = "IdRemesaDataGridViewTextBoxColumn"
        Me.IdRemesaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRemesaDataGridViewTextBoxColumn.Width = 125
        '
        'FechaCreacionDataGridViewTextBoxColumn
        '
        Me.FechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaCreacionDataGridViewTextBoxColumn.Name = "FechaCreacionDataGridViewTextBoxColumn"
        Me.FechaCreacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCreacionDataGridViewTextBoxColumn.Width = 125
        '
        'FechaCargoDataGridViewTextBoxColumn
        '
        Me.FechaCargoDataGridViewTextBoxColumn.DataPropertyName = "FechaCargo"
        Me.FechaCargoDataGridViewTextBoxColumn.HeaderText = "FechaCargo"
        Me.FechaCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaCargoDataGridViewTextBoxColumn.Name = "FechaCargoDataGridViewTextBoxColumn"
        Me.FechaCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCargoDataGridViewTextBoxColumn.Width = 125
        '
        'FijarDatosDataGridViewCheckBoxColumn
        '
        Me.FijarDatosDataGridViewCheckBoxColumn.DataPropertyName = "FijarDatos"
        Me.FijarDatosDataGridViewCheckBoxColumn.HeaderText = "FijarDatos"
        Me.FijarDatosDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.FijarDatosDataGridViewCheckBoxColumn.Name = "FijarDatosDataGridViewCheckBoxColumn"
        Me.FijarDatosDataGridViewCheckBoxColumn.ReadOnly = True
        Me.FijarDatosDataGridViewCheckBoxColumn.Width = 125
        '
        'TITULARDataGridViewTextBoxColumn
        '
        Me.TITULARDataGridViewTextBoxColumn.DataPropertyName = "TITULAR"
        Me.TITULARDataGridViewTextBoxColumn.HeaderText = "TITULAR"
        Me.TITULARDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TITULARDataGridViewTextBoxColumn.Name = "TITULARDataGridViewTextBoxColumn"
        Me.TITULARDataGridViewTextBoxColumn.ReadOnly = True
        Me.TITULARDataGridViewTextBoxColumn.Width = 125
        '
        'CODIGODataGridViewTextBoxColumn
        '
        Me.CODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODIGODataGridViewTextBoxColumn.Name = "CODIGODataGridViewTextBoxColumn"
        Me.CODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGODataGridViewTextBoxColumn.Width = 125
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 125
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 125
        '
        'TIPOCUOTADataGridViewTextBoxColumn
        '
        Me.TIPOCUOTADataGridViewTextBoxColumn.DataPropertyName = "TIPO_CUOTA"
        Me.TIPOCUOTADataGridViewTextBoxColumn.HeaderText = "TIPO_CUOTA"
        Me.TIPOCUOTADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPOCUOTADataGridViewTextBoxColumn.Name = "TIPOCUOTADataGridViewTextBoxColumn"
        Me.TIPOCUOTADataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPOCUOTADataGridViewTextBoxColumn.Width = 125
        '
        'ImporteCuotaDataGridViewTextBoxColumn
        '
        Me.ImporteCuotaDataGridViewTextBoxColumn.DataPropertyName = "ImporteCuota"
        Me.ImporteCuotaDataGridViewTextBoxColumn.HeaderText = "ImporteCuota"
        Me.ImporteCuotaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImporteCuotaDataGridViewTextBoxColumn.Name = "ImporteCuotaDataGridViewTextBoxColumn"
        Me.ImporteCuotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteCuotaDataGridViewTextBoxColumn.Width = 125
        '
        'MesesAdeudoDataGridViewTextBoxColumn
        '
        Me.MesesAdeudoDataGridViewTextBoxColumn.DataPropertyName = "MesesAdeudo"
        Me.MesesAdeudoDataGridViewTextBoxColumn.HeaderText = "MesesAdeudo"
        Me.MesesAdeudoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MesesAdeudoDataGridViewTextBoxColumn.Name = "MesesAdeudoDataGridViewTextBoxColumn"
        Me.MesesAdeudoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MesesAdeudoDataGridViewTextBoxColumn.Width = 125
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
        'TotalCuotaAnualDataGridViewTextBoxColumn
        '
        Me.TotalCuotaAnualDataGridViewTextBoxColumn.DataPropertyName = "TotalCuotaAnual"
        Me.TotalCuotaAnualDataGridViewTextBoxColumn.HeaderText = "TotalCuotaAnual"
        Me.TotalCuotaAnualDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCuotaAnualDataGridViewTextBoxColumn.Name = "TotalCuotaAnualDataGridViewTextBoxColumn"
        Me.TotalCuotaAnualDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCuotaAnualDataGridViewTextBoxColumn.Width = 125
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
        'CtaBancoDataGridViewTextBoxColumn
        '
        Me.CtaBancoDataGridViewTextBoxColumn.DataPropertyName = "CtaBanco"
        Me.CtaBancoDataGridViewTextBoxColumn.HeaderText = "CtaBanco"
        Me.CtaBancoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CtaBancoDataGridViewTextBoxColumn.Name = "CtaBancoDataGridViewTextBoxColumn"
        Me.CtaBancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaBancoDataGridViewTextBoxColumn.Width = 125
        '
        'RestoBeneficioDataGridViewTextBoxColumn
        '
        Me.RestoBeneficioDataGridViewTextBoxColumn.DataPropertyName = "RestoBeneficio"
        Me.RestoBeneficioDataGridViewTextBoxColumn.HeaderText = "RestoBeneficio"
        Me.RestoBeneficioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RestoBeneficioDataGridViewTextBoxColumn.Name = "RestoBeneficioDataGridViewTextBoxColumn"
        Me.RestoBeneficioDataGridViewTextBoxColumn.ReadOnly = True
        Me.RestoBeneficioDataGridViewTextBoxColumn.Width = 125
        '
        'PagosPdtesDataGridViewTextBoxColumn
        '
        Me.PagosPdtesDataGridViewTextBoxColumn.DataPropertyName = "PagosPdtes"
        Me.PagosPdtesDataGridViewTextBoxColumn.HeaderText = "PagosPdtes"
        Me.PagosPdtesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PagosPdtesDataGridViewTextBoxColumn.Name = "PagosPdtesDataGridViewTextBoxColumn"
        Me.PagosPdtesDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagosPdtesDataGridViewTextBoxColumn.Width = 125
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
        'ValordevDataGridViewTextBoxColumn
        '
        Me.ValordevDataGridViewTextBoxColumn.DataPropertyName = "valordev"
        Me.ValordevDataGridViewTextBoxColumn.HeaderText = "valordev"
        Me.ValordevDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValordevDataGridViewTextBoxColumn.Name = "ValordevDataGridViewTextBoxColumn"
        Me.ValordevDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValordevDataGridViewTextBoxColumn.Width = 125
        '
        'TotalCuotaDataGridViewTextBoxColumn
        '
        Me.TotalCuotaDataGridViewTextBoxColumn.DataPropertyName = "totalCuota"
        Me.TotalCuotaDataGridViewTextBoxColumn.HeaderText = "totalCuota"
        Me.TotalCuotaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCuotaDataGridViewTextBoxColumn.Name = "TotalCuotaDataGridViewTextBoxColumn"
        Me.TotalCuotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCuotaDataGridViewTextBoxColumn.Width = 125
        '
        'TotalCargoDataGridViewTextBoxColumn
        '
        Me.TotalCargoDataGridViewTextBoxColumn.DataPropertyName = "totalCargo"
        Me.TotalCargoDataGridViewTextBoxColumn.HeaderText = "totalCargo"
        Me.TotalCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCargoDataGridViewTextBoxColumn.Name = "TotalCargoDataGridViewTextBoxColumn"
        Me.TotalCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCargoDataGridViewTextBoxColumn.Width = 125
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
        'SumaOtrosCargosDataGridViewTextBoxColumn
        '
        Me.SumaOtrosCargosDataGridViewTextBoxColumn.DataPropertyName = "SumaOtrosCargos"
        Me.SumaOtrosCargosDataGridViewTextBoxColumn.HeaderText = "SumaOtrosCargos"
        Me.SumaOtrosCargosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SumaOtrosCargosDataGridViewTextBoxColumn.Name = "SumaOtrosCargosDataGridViewTextBoxColumn"
        Me.SumaOtrosCargosDataGridViewTextBoxColumn.ReadOnly = True
        Me.SumaOtrosCargosDataGridViewTextBoxColumn.Width = 125
        '
        'TotalreciboDataGridViewTextBoxColumn
        '
        Me.TotalreciboDataGridViewTextBoxColumn.DataPropertyName = "totalrecibo"
        Me.TotalreciboDataGridViewTextBoxColumn.HeaderText = "totalrecibo"
        Me.TotalreciboDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalreciboDataGridViewTextBoxColumn.Name = "TotalreciboDataGridViewTextBoxColumn"
        Me.TotalreciboDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalreciboDataGridViewTextBoxColumn.Width = 125
        '
        'DevolucionDataGridViewCheckBoxColumn
        '
        Me.DevolucionDataGridViewCheckBoxColumn.DataPropertyName = "devolucion"
        Me.DevolucionDataGridViewCheckBoxColumn.HeaderText = "devolucion"
        Me.DevolucionDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.DevolucionDataGridViewCheckBoxColumn.Name = "DevolucionDataGridViewCheckBoxColumn"
        Me.DevolucionDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DevolucionDataGridViewCheckBoxColumn.Width = 125
        '
        'BloqueadoDataGridViewCheckBoxColumn
        '
        Me.BloqueadoDataGridViewCheckBoxColumn.DataPropertyName = "bloqueado"
        Me.BloqueadoDataGridViewCheckBoxColumn.HeaderText = "bloqueado"
        Me.BloqueadoDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.BloqueadoDataGridViewCheckBoxColumn.Name = "BloqueadoDataGridViewCheckBoxColumn"
        Me.BloqueadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.BloqueadoDataGridViewCheckBoxColumn.Width = 125
        '
        'RemesasBindingSource
        '
        Me.RemesasBindingSource.DataMember = "remesas"
        Me.RemesasBindingSource.DataSource = Me.DataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Eliminar todos los registros de Remesas"
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'RemesasTableAdapter
        '
        Me.RemesasTableAdapter.ClearBeforeFill = True
        '
        'FrmEliminarRemesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1062, 553)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EliminarRemesaCheckBox)
        Me.Controls.Add(Me.RemesasDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "59")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEliminarRemesa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Remesa"
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents EliminarRemesaCheckBox As CheckBox
    Friend WithEvents RemesasDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents RemesasBindingSource As BindingSource
    Friend WithEvents RemesasTableAdapter As DataSet1TableAdapters.remesasTableAdapter
    Friend WithEvents IdRemesaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FijarDatosDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TITULARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOCUOTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteCuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesesAdeudoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BENEFICIOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEVBENEFIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCuotaAnualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CtaBancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestoBeneficioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagosPdtesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecdevDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValordevDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbonobenefiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SumaOtrosCargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalreciboDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DevolucionDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BloqueadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
