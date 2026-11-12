<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGenerarRemesa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NumcuotasmesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerarRemesa))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblConsolidar = New System.Windows.Forms.Label()
        Me.ConsolidarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblEnviar = New System.Windows.Forms.Label()
        Me.Chkestado = New System.Windows.Forms.CheckBox()
        Me.EnviarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtRecEmitidos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNPagos = New System.Windows.Forms.TextBox()
        Me.NumCuotasAñoTextBox = New System.Windows.Forms.TextBox()
        Me.TxtNombreRemesa = New System.Windows.Forms.TextBox()
        Me.TxtTipoRemesa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtValdev = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFechaCgo = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaCrea = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalRemesa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtAbonos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCargos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNumRecibos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnAddFallero = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnAddRegistros = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Detalles_de_remesaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallesDeRemesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FalleroDetalleRemesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.Detalles_de_remesaTableAdapter = New AppGestion.DataSet1TableAdapters.detalles_de_remesaTableAdapter()
        Me.FalleroDetalleRemesaTableAdapter = New AppGestion.DataSet1TableAdapters.FalleroDetalleRemesaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.EjercicioTableAdapter = New AppGestion.DataSet1TableAdapters.ejercicioTableAdapter()
        Me.TITULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FALLERO_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abonobenefi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumaAbonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recdev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valordev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumaCargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalrecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENEFICIOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEV_BENEFI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoBeneficio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parcial1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCuotas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NumcuotasmesLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Detalles_de_remesaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroDetalleRemesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumcuotasmesLabel
        '
        NumcuotasmesLabel.AutoSize = True
        NumcuotasmesLabel.Location = New System.Drawing.Point(916, 18)
        NumcuotasmesLabel.Name = "NumcuotasmesLabel"
        NumcuotasmesLabel.Size = New System.Drawing.Size(147, 17)
        NumcuotasmesLabel.TabIndex = 68
        NumcuotasmesLabel.Text = "Nº total cuotas al año:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.CausesValidation = False
        Me.Label12.Location = New System.Drawing.Point(407, 627)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Calculando..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(506, 621)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(450, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 65
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblConsolidar)
        Me.GroupBox3.Controls.Add(Me.ConsolidarRemesaCheckBox)
        Me.GroupBox3.Controls.Add(Me.LblEstado)
        Me.GroupBox3.Controls.Add(Me.LblEnviar)
        Me.GroupBox3.Controls.Add(Me.Chkestado)
        Me.GroupBox3.Controls.Add(Me.EnviarRemesaCheckBox)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1174, 41)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado de la remesa"
        '
        'LblConsolidar
        '
        Me.LblConsolidar.AutoSize = True
        Me.LblConsolidar.Location = New System.Drawing.Point(486, 18)
        Me.LblConsolidar.Name = "LblConsolidar"
        Me.LblConsolidar.Size = New System.Drawing.Size(97, 17)
        Me.LblConsolidar.TabIndex = 55
        Me.LblConsolidar.Text = "Sin consolidar"
        '
        'ConsolidarRemesaCheckBox
        '
        Me.ConsolidarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "ConsolidarRemesa", True))
        Me.ConsolidarRemesaCheckBox.Location = New System.Drawing.Point(463, 15)
        Me.ConsolidarRemesaCheckBox.Name = "ConsolidarRemesaCheckBox"
        Me.ConsolidarRemesaCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.ConsolidarRemesaCheckBox.TabIndex = 51
        Me.ConsolidarRemesaCheckBox.UseVisualStyleBackColor = True
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(230, 18)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(85, 17)
        Me.LblEstado.TabIndex = 42
        Me.LblEstado.Text = "Sin Generar"
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEnviar
        '
        Me.LblEnviar.AutoSize = True
        Me.LblEnviar.Location = New System.Drawing.Point(761, 18)
        Me.LblEnviar.Name = "LblEnviar"
        Me.LblEnviar.Size = New System.Drawing.Size(111, 17)
        Me.LblEnviar.TabIndex = 50
        Me.LblEnviar.Text = "Pendiente Envío"
        Me.LblEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chkestado
        '
        Me.Chkestado.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "GenerarRemesaNueva", True))
        Me.Chkestado.Enabled = False
        Me.Chkestado.Location = New System.Drawing.Point(213, 12)
        Me.Chkestado.Margin = New System.Windows.Forms.Padding(4)
        Me.Chkestado.Name = "Chkestado"
        Me.Chkestado.Size = New System.Drawing.Size(24, 30)
        Me.Chkestado.TabIndex = 30
        Me.Chkestado.UseVisualStyleBackColor = True
        '
        'EnviarRemesaCheckBox
        '
        Me.EnviarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "EnviarRemesa", True))
        Me.EnviarRemesaCheckBox.Enabled = False
        Me.EnviarRemesaCheckBox.Location = New System.Drawing.Point(742, 15)
        Me.EnviarRemesaCheckBox.Name = "EnviarRemesaCheckBox"
        Me.EnviarRemesaCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.EnviarRemesaCheckBox.TabIndex = 49
        Me.EnviarRemesaCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtRecEmitidos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(NumcuotasmesLabel)
        Me.GroupBox2.Controls.Add(Me.TxtNPagos)
        Me.GroupBox2.Controls.Add(Me.NumCuotasAñoTextBox)
        Me.GroupBox2.Controls.Add(Me.TxtNombreRemesa)
        Me.GroupBox2.Controls.Add(Me.TxtTipoRemesa)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtValdev)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DtpFechaCgo)
        Me.GroupBox2.Controls.Add(Me.DtpFechaCrea)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtId)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1172, 85)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores fijos"
        '
        'TxtRecEmitidos
        '
        Me.TxtRecEmitidos.Location = New System.Drawing.Point(1066, 48)
        Me.TxtRecEmitidos.Name = "TxtRecEmitidos"
        Me.TxtRecEmitidos.Size = New System.Drawing.Size(81, 22)
        Me.TxtRecEmitidos.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(439, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Número de Pagos:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(944, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 17)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Recibos emitidos:"
        '
        'TxtNPagos
        '
        Me.TxtNPagos.Location = New System.Drawing.Point(574, 17)
        Me.TxtNPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNPagos.Name = "TxtNPagos"
        Me.TxtNPagos.Size = New System.Drawing.Size(45, 22)
        Me.TxtNPagos.TabIndex = 1
        '
        'NumCuotasAñoTextBox
        '
        Me.NumCuotasAñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.NumCuotasAñoTextBox.Location = New System.Drawing.Point(1066, 15)
        Me.NumCuotasAñoTextBox.Name = "NumCuotasAñoTextBox"
        Me.NumCuotasAñoTextBox.ReadOnly = True
        Me.NumCuotasAñoTextBox.Size = New System.Drawing.Size(81, 22)
        Me.NumCuotasAñoTextBox.TabIndex = 69
        '
        'TxtNombreRemesa
        '
        Me.TxtNombreRemesa.Location = New System.Drawing.Point(277, 17)
        Me.TxtNombreRemesa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombreRemesa.Name = "TxtNombreRemesa"
        Me.TxtNombreRemesa.ReadOnly = True
        Me.TxtNombreRemesa.Size = New System.Drawing.Size(132, 22)
        Me.TxtNombreRemesa.TabIndex = 28
        '
        'TxtTipoRemesa
        '
        Me.TxtTipoRemesa.Location = New System.Drawing.Point(214, 17)
        Me.TxtTipoRemesa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTipoRemesa.Name = "TxtTipoRemesa"
        Me.TxtTipoRemesa.ReadOnly = True
        Me.TxtTipoRemesa.Size = New System.Drawing.Size(53, 22)
        Me.TxtTipoRemesa.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tipo de Remesa:"
        '
        'TxtValdev
        '
        Me.TxtValdev.Location = New System.Drawing.Point(804, 17)
        Me.TxtValdev.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValdev.Name = "TxtValdev"
        Me.TxtValdev.Size = New System.Drawing.Size(56, 22)
        Me.TxtValdev.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Valor Recibo devuelto:"
        '
        'DtpFechaCgo
        '
        Me.DtpFechaCgo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCgo.Location = New System.Drawing.Point(705, 54)
        Me.DtpFechaCgo.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpFechaCgo.Name = "DtpFechaCgo"
        Me.DtpFechaCgo.Size = New System.Drawing.Size(155, 22)
        Me.DtpFechaCgo.TabIndex = 4
        '
        'DtpFechaCrea
        '
        Me.DtpFechaCrea.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCrea.Location = New System.Drawing.Point(415, 54)
        Me.DtpFechaCrea.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpFechaCrea.Name = "DtpFechaCrea"
        Me.DtpFechaCrea.Size = New System.Drawing.Size(150, 22)
        Me.DtpFechaCrea.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(602, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha Cargo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha Creación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Id Remesa:"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(187, 54)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(80, 22)
        Me.TxtId.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTotalRemesa)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtAbonos)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtCargos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtNumRecibos)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1172, 53)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'TxtTotalRemesa
        '
        Me.TxtTotalRemesa.Location = New System.Drawing.Point(881, 16)
        Me.TxtTotalRemesa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalRemesa.Name = "TxtTotalRemesa"
        Me.TxtTotalRemesa.ReadOnly = True
        Me.TxtTotalRemesa.Size = New System.Drawing.Size(88, 22)
        Me.TxtTotalRemesa.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(759, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 17)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Total Remesa:"
        '
        'TxtAbonos
        '
        Me.TxtAbonos.Location = New System.Drawing.Point(615, 16)
        Me.TxtAbonos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAbonos.Name = "TxtAbonos"
        Me.TxtAbonos.ReadOnly = True
        Me.TxtAbonos.Size = New System.Drawing.Size(88, 22)
        Me.TxtAbonos.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(546, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Abonos:"
        '
        'TxtCargos
        '
        Me.TxtCargos.Location = New System.Drawing.Point(390, 16)
        Me.TxtCargos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCargos.Name = "TxtCargos"
        Me.TxtCargos.ReadOnly = True
        Me.TxtCargos.Size = New System.Drawing.Size(88, 22)
        Me.TxtCargos.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Cargos:"
        '
        'TxtNumRecibos
        '
        Me.TxtNumRecibos.Location = New System.Drawing.Point(190, 16)
        Me.TxtNumRecibos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumRecibos.Name = "TxtNumRecibos"
        Me.TxtNumRecibos.ReadOnly = True
        Me.TxtNumRecibos.Size = New System.Drawing.Size(67, 22)
        Me.TxtNumRecibos.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Nº recibos:"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.Location = New System.Drawing.Point(1322, 260)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 61
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnAddFallero
        '
        Me.BtnAddFallero.Location = New System.Drawing.Point(742, 257)
        Me.BtnAddFallero.Name = "BtnAddFallero"
        Me.BtnAddFallero.Size = New System.Drawing.Size(160, 28)
        Me.BtnAddFallero.TabIndex = 60
        Me.BtnAddFallero.Text = "Añadir fallero"
        Me.BtnAddFallero.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(561, 257)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(160, 28)
        Me.BtnBorrar.TabIndex = 59
        Me.BtnBorrar.Text = "Borrar línea"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(375, 257)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(160, 28)
        Me.BtnEditar.TabIndex = 58
        Me.BtnEditar.Text = "Editar línea"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(196, 257)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(160, 28)
        Me.BtnCalcular.TabIndex = 57
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnAddRegistros
        '
        Me.BtnAddRegistros.Location = New System.Drawing.Point(17, 257)
        Me.BtnAddRegistros.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddRegistros.Name = "BtnAddRegistros"
        Me.BtnAddRegistros.Size = New System.Drawing.Size(160, 28)
        Me.BtnAddRegistros.TabIndex = 56
        Me.BtnAddRegistros.Text = "Añadir registros"
        Me.BtnAddRegistros.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Generar Remesa"
        '
        'Detalles_de_remesaDataGridView
        '
        Me.Detalles_de_remesaDataGridView.AllowUserToAddRows = False
        Me.Detalles_de_remesaDataGridView.AllowUserToDeleteRows = False
        Me.Detalles_de_remesaDataGridView.AllowUserToOrderColumns = True
        Me.Detalles_de_remesaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detalles_de_remesaDataGridView.AutoGenerateColumns = False
        Me.Detalles_de_remesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalles_de_remesaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TITULAR, Me.FALLERO_CODIGO, Me.NOMBRE, Me.APELLIDOS, Me.TIPO_CUOTA, Me.NumPagos, Me.PAGO, Me.abonobenefi, Me.EntregasAcuenta, Me.SumaAbonos, Me.OtrosCargos, Me.Recdev, Me.valordev, Me.SumaCargos, Me.totalCargo, Me.totalrecibo, Me.Id, Me.FechaCreacion, Me.FechaCargo, Me.BENEFICIOS, Me.DEV_BENEFI, Me.RestoBeneficio, Me.parcial1, Me.NumCuotas})
        Me.Detalles_de_remesaDataGridView.DataSource = Me.DetallesDeRemesaBindingSource
        Me.Detalles_de_remesaDataGridView.Location = New System.Drawing.Point(13, 293)
        Me.Detalles_de_remesaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Detalles_de_remesaDataGridView.Name = "Detalles_de_remesaDataGridView"
        Me.Detalles_de_remesaDataGridView.ReadOnly = True
        Me.Detalles_de_remesaDataGridView.RowHeadersWidth = 51
        Me.Detalles_de_remesaDataGridView.Size = New System.Drawing.Size(1384, 322)
        Me.Detalles_de_remesaDataGridView.TabIndex = 63
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1242, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
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
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSet1
        '
        'DetallesDeRemesaBindingSource
        '
        Me.DetallesDeRemesaBindingSource.DataMember = "detalles de remesa"
        Me.DetallesDeRemesaBindingSource.DataSource = Me.DataSet1
        '
        'FalleroDetalleRemesaBindingSource
        '
        Me.FalleroDetalleRemesaBindingSource.DataMember = "FalleroDetalleRemesa"
        Me.FalleroDetalleRemesaBindingSource.DataSource = Me.DataSet1
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'Detalles_de_remesaTableAdapter
        '
        Me.Detalles_de_remesaTableAdapter.ClearBeforeFill = True
        '
        'FalleroDetalleRemesaTableAdapter
        '
        Me.FalleroDetalleRemesaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.criteriorecompTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Me.Detalles_de_remesaTableAdapter
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Me.EstadoTableAdapter
        Me.TableAdapterManager.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager.FalleroDetalleRemesaTableAdapter = Me.FalleroDetalleRemesaTableAdapter
        Me.TableAdapterManager.historfaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasejercicioTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'TITULAR
        '
        Me.TITULAR.DataPropertyName = "TITULAR"
        Me.TITULAR.HeaderText = "Titular"
        Me.TITULAR.MinimumWidth = 6
        Me.TITULAR.Name = "TITULAR"
        Me.TITULAR.ReadOnly = True
        Me.TITULAR.Width = 170
        '
        'FALLERO_CODIGO
        '
        Me.FALLERO_CODIGO.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLERO_CODIGO.HeaderText = "Código"
        Me.FALLERO_CODIGO.MinimumWidth = 6
        Me.FALLERO_CODIGO.Name = "FALLERO_CODIGO"
        Me.FALLERO_CODIGO.ReadOnly = True
        Me.FALLERO_CODIGO.Width = 50
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 80
        '
        'APELLIDOS
        '
        Me.APELLIDOS.DataPropertyName = "APELLIDOS"
        Me.APELLIDOS.HeaderText = "Apellidos"
        Me.APELLIDOS.MinimumWidth = 6
        Me.APELLIDOS.Name = "APELLIDOS"
        Me.APELLIDOS.ReadOnly = True
        Me.APELLIDOS.Width = 120
        '
        'TIPO_CUOTA
        '
        Me.TIPO_CUOTA.DataPropertyName = "TIPO_CUOTA"
        Me.TIPO_CUOTA.HeaderText = "Cuota"
        Me.TIPO_CUOTA.MinimumWidth = 6
        Me.TIPO_CUOTA.Name = "TIPO_CUOTA"
        Me.TIPO_CUOTA.ReadOnly = True
        Me.TIPO_CUOTA.Width = 60
        '
        'NumPagos
        '
        Me.NumPagos.DataPropertyName = "NumPagos"
        Me.NumPagos.HeaderText = "Nº Pagos"
        Me.NumPagos.MinimumWidth = 6
        Me.NumPagos.Name = "NumPagos"
        Me.NumPagos.ReadOnly = True
        Me.NumPagos.Width = 60
        '
        'PAGO
        '
        Me.PAGO.DataPropertyName = "PAGO"
        Me.PAGO.HeaderText = "Imp. Cuota"
        Me.PAGO.MinimumWidth = 6
        Me.PAGO.Name = "PAGO"
        Me.PAGO.ReadOnly = True
        Me.PAGO.Width = 60
        '
        'abonobenefi
        '
        Me.abonobenefi.DataPropertyName = "abonobenefi"
        Me.abonobenefi.HeaderText = "Abono Benef."
        Me.abonobenefi.MinimumWidth = 6
        Me.abonobenefi.Name = "abonobenefi"
        Me.abonobenefi.ReadOnly = True
        Me.abonobenefi.Width = 60
        '
        'EntregasAcuenta
        '
        Me.EntregasAcuenta.DataPropertyName = "EntregasAcuenta"
        Me.EntregasAcuenta.HeaderText = "A cuenta"
        Me.EntregasAcuenta.MinimumWidth = 6
        Me.EntregasAcuenta.Name = "EntregasAcuenta"
        Me.EntregasAcuenta.ReadOnly = True
        Me.EntregasAcuenta.Width = 60
        '
        'SumaAbonos
        '
        Me.SumaAbonos.DataPropertyName = "SumaAbonos"
        Me.SumaAbonos.HeaderText = "Suma Abonos"
        Me.SumaAbonos.MinimumWidth = 6
        Me.SumaAbonos.Name = "SumaAbonos"
        Me.SumaAbonos.ReadOnly = True
        Me.SumaAbonos.Width = 60
        '
        'OtrosCargos
        '
        Me.OtrosCargos.DataPropertyName = "OtrosCargos"
        Me.OtrosCargos.HeaderText = "Cargos"
        Me.OtrosCargos.MinimumWidth = 6
        Me.OtrosCargos.Name = "OtrosCargos"
        Me.OtrosCargos.ReadOnly = True
        Me.OtrosCargos.Width = 60
        '
        'Recdev
        '
        Me.Recdev.DataPropertyName = "Recdev"
        Me.Recdev.HeaderText = "Recibo dev."
        Me.Recdev.MinimumWidth = 6
        Me.Recdev.Name = "Recdev"
        Me.Recdev.ReadOnly = True
        Me.Recdev.Width = 60
        '
        'valordev
        '
        Me.valordev.DataPropertyName = "valordev"
        Me.valordev.HeaderText = "Imp. dev."
        Me.valordev.MinimumWidth = 6
        Me.valordev.Name = "valordev"
        Me.valordev.ReadOnly = True
        Me.valordev.Width = 60
        '
        'SumaCargos
        '
        Me.SumaCargos.DataPropertyName = "SumaCargos"
        Me.SumaCargos.HeaderText = "Suma Cargos"
        Me.SumaCargos.MinimumWidth = 6
        Me.SumaCargos.Name = "SumaCargos"
        Me.SumaCargos.ReadOnly = True
        Me.SumaCargos.Width = 60
        '
        'totalCargo
        '
        Me.totalCargo.DataPropertyName = "totalCargo"
        Me.totalCargo.HeaderText = "Total Cargo"
        Me.totalCargo.MinimumWidth = 6
        Me.totalCargo.Name = "totalCargo"
        Me.totalCargo.ReadOnly = True
        Me.totalCargo.Width = 60
        '
        'totalrecibo
        '
        Me.totalrecibo.DataPropertyName = "totalrecibo"
        Me.totalrecibo.HeaderText = "Total Recibo"
        Me.totalrecibo.MinimumWidth = 6
        Me.totalrecibo.Name = "totalrecibo"
        Me.totalrecibo.ReadOnly = True
        Me.totalrecibo.Width = 60
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 60
        '
        'FechaCreacion
        '
        Me.FechaCreacion.DataPropertyName = "FechaCreacion"
        Me.FechaCreacion.HeaderText = "FechaCreacion"
        Me.FechaCreacion.MinimumWidth = 6
        Me.FechaCreacion.Name = "FechaCreacion"
        Me.FechaCreacion.ReadOnly = True
        Me.FechaCreacion.Width = 70
        '
        'FechaCargo
        '
        Me.FechaCargo.DataPropertyName = "FechaCargo"
        Me.FechaCargo.HeaderText = "FechaCargo"
        Me.FechaCargo.MinimumWidth = 6
        Me.FechaCargo.Name = "FechaCargo"
        Me.FechaCargo.ReadOnly = True
        Me.FechaCargo.Width = 70
        '
        'BENEFICIOS
        '
        Me.BENEFICIOS.DataPropertyName = "BENEFICIOS"
        Me.BENEFICIOS.HeaderText = "Beneficios"
        Me.BENEFICIOS.MinimumWidth = 6
        Me.BENEFICIOS.Name = "BENEFICIOS"
        Me.BENEFICIOS.ReadOnly = True
        Me.BENEFICIOS.Width = 60
        '
        'DEV_BENEFI
        '
        Me.DEV_BENEFI.DataPropertyName = "DEV_BENEFI"
        Me.DEV_BENEFI.HeaderText = "Beneficios Abonados"
        Me.DEV_BENEFI.MinimumWidth = 6
        Me.DEV_BENEFI.Name = "DEV_BENEFI"
        Me.DEV_BENEFI.ReadOnly = True
        Me.DEV_BENEFI.Width = 60
        '
        'RestoBeneficio
        '
        Me.RestoBeneficio.DataPropertyName = "RestoBeneficio"
        Me.RestoBeneficio.HeaderText = "Resto Beneficio"
        Me.RestoBeneficio.MinimumWidth = 6
        Me.RestoBeneficio.Name = "RestoBeneficio"
        Me.RestoBeneficio.ReadOnly = True
        Me.RestoBeneficio.Width = 60
        '
        'parcial1
        '
        Me.parcial1.DataPropertyName = "parcial1"
        Me.parcial1.HeaderText = "Deuda"
        Me.parcial1.MinimumWidth = 6
        Me.parcial1.Name = "parcial1"
        Me.parcial1.ReadOnly = True
        Me.parcial1.Width = 60
        '
        'NumCuotas
        '
        Me.NumCuotas.DataPropertyName = "NumCuotas"
        Me.NumCuotas.HeaderText = "NumCuotas"
        Me.NumCuotas.MinimumWidth = 6
        Me.NumCuotas.Name = "NumCuotas"
        Me.NumCuotas.ReadOnly = True
        Me.NumCuotas.Width = 125
        '
        'FrmGenerarRemesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1413, 652)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnAddFallero)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnAddRegistros)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Detalles_de_remesaDataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "16")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGenerarRemesa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Remesa"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Detalles_de_remesaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroDetalleRemesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblConsolidar As Label
    Friend WithEvents ConsolidarRemesaCheckBox As CheckBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblEnviar As Label
    Friend WithEvents Chkestado As CheckBox
    Friend WithEvents EnviarRemesaCheckBox As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNPagos As TextBox
    Friend WithEvents TxtNombreRemesa As TextBox
    Friend WithEvents TxtTipoRemesa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtValdev As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpFechaCgo As DateTimePicker
    Friend WithEvents DtpFechaCrea As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtTotalRemesa As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtAbonos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCargos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNumRecibos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnAddFallero As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnAddRegistros As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Detalles_de_remesaDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents DetallesDeRemesaBindingSource As BindingSource
    Friend WithEvents Detalles_de_remesaTableAdapter As DataSet1TableAdapters.detalles_de_remesaTableAdapter
    Friend WithEvents FalleroDetalleRemesaBindingSource As BindingSource
    Friend WithEvents FalleroDetalleRemesaTableAdapter As DataSet1TableAdapters.FalleroDetalleRemesaTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DataSet1TableAdapters.ejercicioTableAdapter
    Friend WithEvents NumCuotasAñoTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtRecEmitidos As TextBox
    Friend WithEvents TITULAR As DataGridViewTextBoxColumn
    Friend WithEvents FALLERO_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents NumPagos As DataGridViewTextBoxColumn
    Friend WithEvents PAGO As DataGridViewTextBoxColumn
    Friend WithEvents abonobenefi As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuenta As DataGridViewTextBoxColumn
    Friend WithEvents SumaAbonos As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargos As DataGridViewTextBoxColumn
    Friend WithEvents Recdev As DataGridViewTextBoxColumn
    Friend WithEvents valordev As DataGridViewTextBoxColumn
    Friend WithEvents SumaCargos As DataGridViewTextBoxColumn
    Friend WithEvents totalCargo As DataGridViewTextBoxColumn
    Friend WithEvents totalrecibo As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaCargo As DataGridViewTextBoxColumn
    Friend WithEvents BENEFICIOS As DataGridViewTextBoxColumn
    Friend WithEvents DEV_BENEFI As DataGridViewTextBoxColumn
    Friend WithEvents RestoBeneficio As DataGridViewTextBoxColumn
    Friend WithEvents parcial1 As DataGridViewTextBoxColumn
    Friend WithEvents NumCuotas As DataGridViewTextBoxColumn
End Class
