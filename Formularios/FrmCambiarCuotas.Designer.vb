<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarCuotas
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
        Dim LblCuotaActual As System.Windows.Forms.Label
        Me.AñoejeTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.TxtNumRegistros = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.NumcuotasmesTextBox = New System.Windows.Forms.TextBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.AsignarValoresFalleroCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.FalleroDataGridView = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIP_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCUENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_CUOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_PAGOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REC_DEV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENEFICIOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEV_BENEFI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEUDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCuotas = New AppGestion.DataSetCuotas()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TxtNumCuotasActual = New System.Windows.Forms.TextBox()
        Me.EjercicioTableAdapter = New AppGestion.DataSet1TableAdapters.ejercicioTableAdapter()
        Me.FalleroTableAdapter = New AppGestion.DataSetCuotasTableAdapters.falleroTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        NumcuotasmesLabel = New System.Windows.Forms.Label()
        LblCuotaActual = New System.Windows.Forms.Label()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumcuotasmesLabel
        '
        NumcuotasmesLabel.AutoSize = True
        NumcuotasmesLabel.Location = New System.Drawing.Point(600, 81)
        NumcuotasmesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumcuotasmesLabel.Name = "NumcuotasmesLabel"
        NumcuotasmesLabel.Size = New System.Drawing.Size(177, 17)
        NumcuotasmesLabel.TabIndex = 27
        NumcuotasmesLabel.Text = "Cuotas mensuales (nuevo)"
        '
        'LblCuotaActual
        '
        LblCuotaActual.AutoSize = True
        LblCuotaActual.Location = New System.Drawing.Point(600, 54)
        LblCuotaActual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LblCuotaActual.Name = "LblCuotaActual"
        LblCuotaActual.Size = New System.Drawing.Size(176, 17)
        LblCuotaActual.TabIndex = 33
        LblCuotaActual.Text = "Cuotas mensuales (actual)"
        '
        'AñoejeTextBox
        '
        Me.AñoejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.AñoejeTextBox.Location = New System.Drawing.Point(405, 26)
        Me.AñoejeTextBox.Name = "AñoejeTextBox"
        Me.AñoejeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AñoejeTextBox.TabIndex = 31
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtNumRegistros
        '
        Me.TxtNumRegistros.Location = New System.Drawing.Point(456, 531)
        Me.TxtNumRegistros.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumRegistros.Name = "TxtNumRegistros"
        Me.TxtNumRegistros.Size = New System.Drawing.Size(260, 22)
        Me.TxtNumRegistros.TabIndex = 30
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(92, 531)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(356, 25)
        Me.ProgressBar1.TabIndex = 29
        '
        'NumcuotasmesTextBox
        '
        Me.NumcuotasmesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.NumcuotasmesTextBox.Location = New System.Drawing.Point(785, 78)
        Me.NumcuotasmesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumcuotasmesTextBox.Name = "NumcuotasmesTextBox"
        Me.NumcuotasmesTextBox.Size = New System.Drawing.Size(49, 22)
        Me.NumcuotasmesTextBox.TabIndex = 28
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(348, 86)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(100, 28)
        Me.BtnActualizar.TabIndex = 25
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'AsignarValoresFalleroCheckBox
        '
        Me.AsignarValoresFalleroCheckBox.Location = New System.Drawing.Point(201, 86)
        Me.AsignarValoresFalleroCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarValoresFalleroCheckBox.Name = "AsignarValoresFalleroCheckBox"
        Me.AsignarValoresFalleroCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.AsignarValoresFalleroCheckBox.TabIndex = 24
        Me.AsignarValoresFalleroCheckBox.Text = "Sin Asignar"
        Me.AsignarValoresFalleroCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Actualizar cuotas a nuevos valores"
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(898, 69)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 26
        Me.BtnSalir.Text = "Cancelar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FalleroDataGridView
        '
        Me.FalleroDataGridView.AutoGenerateColumns = False
        Me.FalleroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FalleroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.APELLIDOS, Me.TIPFAL, Me.DESCRIP_CUOTA, Me.VALOR_CUOTA, Me.DESCUENTO, Me.PAGO, Me.NUM_CUOTAS, Me.NUM_PAGOS, Me.REC_DEV, Me.BENEFICIOS, Me.CP, Me.DEV_BENEFI, Me.EntregasAcuenta, Me.OtrosCargos, Me.TOTAL_CUOTA, Me.DEUDA, Me.CUOTA, Me.ValorDto, Me.A_CUENTA, Me.TIPO_CUOTA})
        Me.FalleroDataGridView.DataSource = Me.FalleroBindingSource
        Me.FalleroDataGridView.Location = New System.Drawing.Point(25, 123)
        Me.FalleroDataGridView.Name = "FalleroDataGridView"
        Me.FalleroDataGridView.RowHeadersWidth = 51
        Me.FalleroDataGridView.RowTemplate.Height = 24
        Me.FalleroDataGridView.Size = New System.Drawing.Size(1030, 400)
        Me.FalleroDataGridView.TabIndex = 32
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "FALLERO_CODIGO"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.MinimumWidth = 6
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Width = 125
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Width = 125
        '
        'APELLIDOS
        '
        Me.APELLIDOS.DataPropertyName = "APELLIDOS"
        Me.APELLIDOS.HeaderText = "APELLIDOS"
        Me.APELLIDOS.MinimumWidth = 6
        Me.APELLIDOS.Name = "APELLIDOS"
        Me.APELLIDOS.Width = 125
        '
        'TIPFAL
        '
        Me.TIPFAL.DataPropertyName = "TIPFAL"
        Me.TIPFAL.HeaderText = "TIPFAL"
        Me.TIPFAL.MinimumWidth = 6
        Me.TIPFAL.Name = "TIPFAL"
        Me.TIPFAL.Width = 125
        '
        'DESCRIP_CUOTA
        '
        Me.DESCRIP_CUOTA.DataPropertyName = "DESCRIP_CUOTA"
        Me.DESCRIP_CUOTA.HeaderText = "DESCRIP_CUOTA"
        Me.DESCRIP_CUOTA.MinimumWidth = 6
        Me.DESCRIP_CUOTA.Name = "DESCRIP_CUOTA"
        Me.DESCRIP_CUOTA.Width = 125
        '
        'VALOR_CUOTA
        '
        Me.VALOR_CUOTA.DataPropertyName = "VALOR_CUOTA"
        Me.VALOR_CUOTA.HeaderText = "VALOR_CUOTA"
        Me.VALOR_CUOTA.MinimumWidth = 6
        Me.VALOR_CUOTA.Name = "VALOR_CUOTA"
        Me.VALOR_CUOTA.Width = 125
        '
        'DESCUENTO
        '
        Me.DESCUENTO.DataPropertyName = "DESCUENTO"
        Me.DESCUENTO.HeaderText = "DESCUENTO"
        Me.DESCUENTO.MinimumWidth = 6
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Width = 125
        '
        'PAGO
        '
        Me.PAGO.DataPropertyName = "PAGO"
        Me.PAGO.HeaderText = "PAGO"
        Me.PAGO.MinimumWidth = 6
        Me.PAGO.Name = "PAGO"
        Me.PAGO.Width = 125
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
        Me.NUM_PAGOS.HeaderText = "PAGOS Pdtes"
        Me.NUM_PAGOS.MinimumWidth = 6
        Me.NUM_PAGOS.Name = "NUM_PAGOS"
        Me.NUM_PAGOS.Width = 125
        '
        'REC_DEV
        '
        Me.REC_DEV.DataPropertyName = "RECDEV"
        Me.REC_DEV.HeaderText = "RECDEV"
        Me.REC_DEV.MinimumWidth = 6
        Me.REC_DEV.Name = "REC_DEV"
        Me.REC_DEV.Width = 125
        '
        'BENEFICIOS
        '
        Me.BENEFICIOS.DataPropertyName = "BENEFICIOS"
        Me.BENEFICIOS.HeaderText = "BENEFICIOS"
        Me.BENEFICIOS.MinimumWidth = 6
        Me.BENEFICIOS.Name = "BENEFICIOS"
        Me.BENEFICIOS.Width = 125
        '
        'CP
        '
        Me.CP.DataPropertyName = "CP"
        Me.CP.HeaderText = "Cuotas Pagadas"
        Me.CP.MinimumWidth = 6
        Me.CP.Name = "CP"
        Me.CP.Width = 125
        '
        'DEV_BENEFI
        '
        Me.DEV_BENEFI.DataPropertyName = "DEV_BENEFI"
        Me.DEV_BENEFI.HeaderText = "DEV_BENEFI"
        Me.DEV_BENEFI.MinimumWidth = 6
        Me.DEV_BENEFI.Name = "DEV_BENEFI"
        Me.DEV_BENEFI.Width = 125
        '
        'EntregasAcuenta
        '
        Me.EntregasAcuenta.DataPropertyName = "EntregasAcuenta"
        Me.EntregasAcuenta.HeaderText = "EntregasAcuenta"
        Me.EntregasAcuenta.MinimumWidth = 6
        Me.EntregasAcuenta.Name = "EntregasAcuenta"
        Me.EntregasAcuenta.Width = 125
        '
        'OtrosCargos
        '
        Me.OtrosCargos.DataPropertyName = "OtrosCargos"
        Me.OtrosCargos.HeaderText = "OtrosCargos"
        Me.OtrosCargos.MinimumWidth = 6
        Me.OtrosCargos.Name = "OtrosCargos"
        Me.OtrosCargos.Width = 125
        '
        'TOTAL_CUOTA
        '
        Me.TOTAL_CUOTA.DataPropertyName = "TOTAL_CUOTA"
        Me.TOTAL_CUOTA.HeaderText = "TOTAL_CUOTA"
        Me.TOTAL_CUOTA.MinimumWidth = 6
        Me.TOTAL_CUOTA.Name = "TOTAL_CUOTA"
        Me.TOTAL_CUOTA.Width = 125
        '
        'DEUDA
        '
        Me.DEUDA.DataPropertyName = "DEUDA"
        Me.DEUDA.HeaderText = "DEUDA"
        Me.DEUDA.MinimumWidth = 6
        Me.DEUDA.Name = "DEUDA"
        Me.DEUDA.Width = 125
        '
        'CUOTA
        '
        Me.CUOTA.DataPropertyName = "CUOTA"
        Me.CUOTA.HeaderText = "N_CUOTA"
        Me.CUOTA.MinimumWidth = 6
        Me.CUOTA.Name = "CUOTA"
        Me.CUOTA.Width = 125
        '
        'ValorDto
        '
        Me.ValorDto.DataPropertyName = "ValorDto"
        Me.ValorDto.HeaderText = "N_Dto"
        Me.ValorDto.MinimumWidth = 6
        Me.ValorDto.Name = "ValorDto"
        Me.ValorDto.Width = 125
        '
        'A_CUENTA
        '
        Me.A_CUENTA.DataPropertyName = "A_CUENTA"
        Me.A_CUENTA.HeaderText = "A_CUENTA"
        Me.A_CUENTA.MinimumWidth = 6
        Me.A_CUENTA.Name = "A_CUENTA"
        Me.A_CUENTA.Width = 125
        '
        'TIPO_CUOTA
        '
        Me.TIPO_CUOTA.DataPropertyName = "TIPO_CUOTA"
        Me.TIPO_CUOTA.HeaderText = "TIPO_CUOTA"
        Me.TIPO_CUOTA.MinimumWidth = 6
        Me.TIPO_CUOTA.Name = "TIPO_CUOTA"
        Me.TIPO_CUOTA.Width = 125
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DataSetCuotas
        '
        'DataSetCuotas
        '
        Me.DataSetCuotas.DataSetName = "DataSetCuotas"
        Me.DataSetCuotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtNumCuotasActual
        '
        Me.TxtNumCuotasActual.Location = New System.Drawing.Point(785, 54)
        Me.TxtNumCuotasActual.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumCuotasActual.Name = "TxtNumCuotasActual"
        Me.TxtNumCuotasActual.Size = New System.Drawing.Size(49, 22)
        Me.TxtNumCuotasActual.TabIndex = 34
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(599, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Label2"
        '
        'FrmCambiarCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 583)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNumCuotasActual)
        Me.Controls.Add(LblCuotaActual)
        Me.Controls.Add(Me.FalleroDataGridView)
        Me.Controls.Add(Me.AñoejeTextBox)
        Me.Controls.Add(Me.TxtNumRegistros)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(NumcuotasmesLabel)
        Me.Controls.Add(Me.NumcuotasmesTextBox)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.AsignarValoresFalleroCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCambiarCuotas"
        Me.Text = "Cambiar Cuotas"
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AñoejeTextBox As TextBox
    Friend WithEvents TxtNumRegistros As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents NumcuotasmesTextBox As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents AsignarValoresFalleroCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DataSet1TableAdapters.ejercicioTableAdapter
    Friend WithEvents DataSetCuotas As DataSetCuotas
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DataSetCuotasTableAdapters.falleroTableAdapter
    Friend WithEvents FalleroDataGridView As DataGridView
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TxtNumCuotasActual As TextBox
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As DataGridViewTextBoxColumn
    Friend WithEvents TIPFAL As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIP_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents VALOR_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents DESCUENTO As DataGridViewTextBoxColumn
    Friend WithEvents PAGO As DataGridViewTextBoxColumn
    Friend WithEvents NUM_CUOTAS As DataGridViewTextBoxColumn
    Friend WithEvents NUM_PAGOS As DataGridViewTextBoxColumn
    Friend WithEvents REC_DEV As DataGridViewTextBoxColumn
    Friend WithEvents BENEFICIOS As DataGridViewTextBoxColumn
    Friend WithEvents CP As DataGridViewTextBoxColumn
    Friend WithEvents DEV_BENEFI As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuenta As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargos As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents DEUDA As DataGridViewTextBoxColumn
    Friend WithEvents CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents ValorDto As DataGridViewTextBoxColumn
    Friend WithEvents A_CUENTA As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
