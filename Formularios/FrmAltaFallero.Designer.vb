<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaFallero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAltaFallero))
        Me.PasemayorTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.PasejuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtTitular = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ChkBanco = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.TxtValCuota = New System.Windows.Forms.TextBox()
        Me.ChkLoteria = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CboDescrDto = New System.Windows.Forms.ComboBox()
        Me.DescuentosDeLaCuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboDescCuota = New System.Windows.Forms.ComboBox()
        Me.TipoDeCuotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtDeuda = New System.Windows.Forms.TextBox()
        Me.TxtTotalCuota = New System.Windows.Forms.TextBox()
        Me.TxtNumCuotas = New System.Windows.Forms.TextBox()
        Me.TxtNumPagos = New System.Windows.Forms.TextBox()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.TxtTipoCuota = New System.Windows.Forms.TextBox()
        Me.txtnCuotas = New System.Windows.Forms.TextBox()
        Me.TxtIdCuota = New System.Windows.Forms.TextBox()
        Me.TxtIdDto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtFallaRecJCF = New System.Windows.Forms.TextBox()
        Me.TxtRecJCF = New System.Windows.Forms.TextBox()
        Me.CboFalla = New System.Windows.Forms.ComboBox()
        Me.FallasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboRecompensa = New System.Windows.Forms.ComboBox()
        Me.RecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtAñoRecJCF = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CboCargo = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.CboComision = New System.Windows.Forms.ComboBox()
        Me.ComisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TxtPoblacion = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtAñoCenso = New System.Windows.Forms.TextBox()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.EjercicioTableAdapter = New AppGestion.DbCensosTableAdapters.ejercicioTableAdapter()
        Me.RecompensasTableAdapter = New AppGestion.DbCensosTableAdapters.recompensasTableAdapter()
        Me.FallasTableAdapter = New AppGestion.DbCensosTableAdapters.fallasTableAdapter()
        Me.Tipo_de_cuotasTableAdapter = New AppGestion.DbCensosTableAdapters.tipo_de_cuotasTableAdapter()
        Me.Descuentos_de_la_cuotaTableAdapter = New AppGestion.DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter()
        Me.ComisionTableAdapter = New AppGestion.DbCensosTableAdapters.comisionTableAdapter()
        Me.CargoTableAdapter = New AppGestion.DbCensosTableAdapters.cargoTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TxtNumcuotasMensuales = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LblAnoCen = New System.Windows.Forms.Label()
        PasemayorLabel = New System.Windows.Forms.Label()
        PasejuvenilLabel = New System.Windows.Forms.Label()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasemayorLabel
        '
        PasemayorLabel.AutoSize = True
        PasemayorLabel.Location = New System.Drawing.Point(521, 25)
        PasemayorLabel.Name = "PasemayorLabel"
        PasemayorLabel.Size = New System.Drawing.Size(82, 17)
        PasemayorLabel.TabIndex = 66
        PasemayorLabel.Text = "pasemayor:"
        PasemayorLabel.Visible = False
        '
        'PasejuvenilLabel
        '
        PasejuvenilLabel.AutoSize = True
        PasejuvenilLabel.Location = New System.Drawing.Point(299, 25)
        PasejuvenilLabel.Name = "PasejuvenilLabel"
        PasejuvenilLabel.Size = New System.Drawing.Size(83, 17)
        PasejuvenilLabel.TabIndex = 64
        PasejuvenilLabel.Text = "pasejuvenil:"
        PasejuvenilLabel.Visible = False
        '
        'PasemayorTextBox
        '
        Me.PasemayorTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PasemayorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasemayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasemayor", True))
        Me.PasemayorTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.PasemayorTextBox.Location = New System.Drawing.Point(613, 25)
        Me.PasemayorTextBox.Name = "PasemayorTextBox"
        Me.PasemayorTextBox.Size = New System.Drawing.Size(100, 15)
        Me.PasemayorTextBox.TabIndex = 68
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasejuvenilTextBox
        '
        Me.PasejuvenilTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PasejuvenilTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasejuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasejuvenil", True))
        Me.PasejuvenilTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.PasejuvenilTextBox.Location = New System.Drawing.Point(391, 25)
        Me.PasejuvenilTextBox.Name = "PasejuvenilTextBox"
        Me.PasejuvenilTextBox.Size = New System.Drawing.Size(100, 15)
        Me.PasejuvenilTextBox.TabIndex = 67
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtCuenta)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.TxtTitular)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.ChkBanco)
        Me.GroupBox5.Location = New System.Drawing.Point(507, 308)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(563, 121)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos bancarios"
        '
        'TxtCuenta
        '
        Me.TxtCuenta.Location = New System.Drawing.Point(236, 30)
        Me.TxtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCuenta.Mask = "ES00 0000 0000 0000 0000 0000"
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(305, 22)
        Me.TxtCuenta.TabIndex = 1
        Me.TxtCuenta.ValidatingType = GetType(Integer)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 66)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 17)
        Me.Label27.TabIndex = 72
        Me.Label27.Text = "Titular:"
        '
        'TxtTitular
        '
        Me.TxtTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTitular.Location = New System.Drawing.Point(76, 62)
        Me.TxtTitular.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTitular.Name = "TxtTitular"
        Me.TxtTitular.Size = New System.Drawing.Size(464, 22)
        Me.TxtTitular.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(167, 33)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 17)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Cuenta:"
        '
        'ChkBanco
        '
        Me.ChkBanco.Location = New System.Drawing.Point(20, 30)
        Me.ChkBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkBanco.Name = "ChkBanco"
        Me.ChkBanco.Size = New System.Drawing.Size(139, 30)
        Me.ChkBanco.TabIndex = 0
        Me.ChkBanco.Text = "Banco:"
        Me.ChkBanco.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(521, 531)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 46)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Añadir Registro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(891, 531)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox4.Location = New System.Drawing.Point(513, 435)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(565, 89)
        Me.GroupBox4.TabIndex = 58
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(8, 23)
        Me.TxtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(528, 51)
        Me.TxtObservaciones.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtDescuento)
        Me.GroupBox3.Controls.Add(Me.TxtValCuota)
        Me.GroupBox3.Controls.Add(Me.ChkLoteria)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.CboDescrDto)
        Me.GroupBox3.Controls.Add(Me.CboDescCuota)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TxtDeuda)
        Me.GroupBox3.Controls.Add(Me.TxtTotalCuota)
        Me.GroupBox3.Controls.Add(Me.TxtNumCuotas)
        Me.GroupBox3.Controls.Add(Me.TxtNumPagos)
        Me.GroupBox3.Controls.Add(Me.TxtPago)
        Me.GroupBox3.Controls.Add(Me.TxtTipoCuota)
        Me.GroupBox3.Controls.Add(Me.txtnCuotas)
        Me.GroupBox3.Controls.Add(Me.TxtIdCuota)
        Me.GroupBox3.Controls.Add(Me.TxtIdDto)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 308)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(460, 283)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Cuota"
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Location = New System.Drawing.Point(300, 71)
        Me.TxtDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(85, 22)
        Me.TxtDescuento.TabIndex = 9
        '
        'TxtValCuota
        '
        Me.TxtValCuota.Location = New System.Drawing.Point(300, 39)
        Me.TxtValCuota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValCuota.Name = "TxtValCuota"
        Me.TxtValCuota.ReadOnly = True
        Me.TxtValCuota.Size = New System.Drawing.Size(85, 22)
        Me.TxtValCuota.TabIndex = 30
        '
        'ChkLoteria
        '
        Me.ChkLoteria.Enabled = False
        Me.ChkLoteria.Location = New System.Drawing.Point(301, 106)
        Me.ChkLoteria.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkLoteria.Name = "ChkLoteria"
        Me.ChkLoteria.Size = New System.Drawing.Size(139, 30)
        Me.ChkLoteria.TabIndex = 2
        Me.ChkLoteria.Text = "Lotería"
        Me.ChkLoteria.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(67, 238)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 17)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "Deuda:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(36, 207)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 17)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Total Cuota:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(193, 174)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 17)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Pdtes.:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(25, 174)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 17)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "Nº de Cuotas:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(63, 142)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 17)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Importe:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(40, 106)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 17)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Tipo Cuota:"
        '
        'CboDescrDto
        '
        Me.CboDescrDto.DataSource = Me.DescuentosDeLaCuotaBindingSource
        Me.CboDescrDto.DisplayMember = "DESCRIPCION"
        Me.CboDescrDto.FormattingEnabled = True
        Me.CboDescrDto.Location = New System.Drawing.Point(131, 73)
        Me.CboDescrDto.Margin = New System.Windows.Forms.Padding(4)
        Me.CboDescrDto.Name = "CboDescrDto"
        Me.CboDescrDto.Size = New System.Drawing.Size(160, 24)
        Me.CboDescrDto.TabIndex = 1
        Me.CboDescrDto.ValueMember = "DESCUENTO"
        '
        'DescuentosDeLaCuotaBindingSource
        '
        Me.DescuentosDeLaCuotaBindingSource.DataMember = "descuentos de la cuota"
        Me.DescuentosDeLaCuotaBindingSource.DataSource = Me.DbCensos
        '
        'CboDescCuota
        '
        Me.CboDescCuota.DataSource = Me.TipoDeCuotasBindingSource
        Me.CboDescCuota.DisplayMember = "DESCRIP_CUOTA"
        Me.CboDescCuota.FormattingEnabled = True
        Me.CboDescCuota.Location = New System.Drawing.Point(131, 39)
        Me.CboDescCuota.Margin = New System.Windows.Forms.Padding(4)
        Me.CboDescCuota.Name = "CboDescCuota"
        Me.CboDescCuota.Size = New System.Drawing.Size(160, 24)
        Me.CboDescCuota.TabIndex = 0
        Me.CboDescCuota.ValueMember = "CUOTA"
        '
        'TipoDeCuotasBindingSource
        '
        Me.TipoDeCuotasBindingSource.DataMember = "tipo de cuotas"
        Me.TipoDeCuotasBindingSource.DataSource = Me.DbCensos
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(40, 75)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 17)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "*Descuento:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(72, 43)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 17)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "*Cuota:"
        '
        'TxtDeuda
        '
        Me.TxtDeuda.Location = New System.Drawing.Point(131, 234)
        Me.TxtDeuda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDeuda.Name = "TxtDeuda"
        Me.TxtDeuda.ReadOnly = True
        Me.TxtDeuda.Size = New System.Drawing.Size(132, 22)
        Me.TxtDeuda.TabIndex = 28
        '
        'TxtTotalCuota
        '
        Me.TxtTotalCuota.Location = New System.Drawing.Point(131, 202)
        Me.TxtTotalCuota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalCuota.Name = "TxtTotalCuota"
        Me.TxtTotalCuota.ReadOnly = True
        Me.TxtTotalCuota.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotalCuota.TabIndex = 27
        '
        'TxtNumCuotas
        '
        Me.TxtNumCuotas.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNumCuotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.TxtNumCuotas.Enabled = False
        Me.TxtNumCuotas.Location = New System.Drawing.Point(248, 170)
        Me.TxtNumCuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumCuotas.Name = "TxtNumCuotas"
        Me.TxtNumCuotas.Size = New System.Drawing.Size(33, 22)
        Me.TxtNumCuotas.TabIndex = 26
        '
        'TxtNumPagos
        '
        Me.TxtNumPagos.Location = New System.Drawing.Point(131, 170)
        Me.TxtNumPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumPagos.Name = "TxtNumPagos"
        Me.TxtNumPagos.ReadOnly = True
        Me.TxtNumPagos.Size = New System.Drawing.Size(33, 22)
        Me.TxtNumPagos.TabIndex = 12
        '
        'TxtPago
        '
        Me.TxtPago.Location = New System.Drawing.Point(131, 138)
        Me.TxtPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.ReadOnly = True
        Me.TxtPago.Size = New System.Drawing.Size(160, 22)
        Me.TxtPago.TabIndex = 11
        '
        'TxtTipoCuota
        '
        Me.TxtTipoCuota.Location = New System.Drawing.Point(131, 106)
        Me.TxtTipoCuota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTipoCuota.Name = "TxtTipoCuota"
        Me.TxtTipoCuota.ReadOnly = True
        Me.TxtTipoCuota.Size = New System.Drawing.Size(160, 22)
        Me.TxtTipoCuota.TabIndex = 10
        '
        'txtnCuotas
        '
        Me.txtnCuotas.Location = New System.Drawing.Point(255, 170)
        Me.txtnCuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnCuotas.Name = "txtnCuotas"
        Me.txtnCuotas.Size = New System.Drawing.Size(21, 22)
        Me.txtnCuotas.TabIndex = 67
        '
        'TxtIdCuota
        '
        Me.TxtIdCuota.Location = New System.Drawing.Point(343, 39)
        Me.TxtIdCuota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdCuota.Name = "TxtIdCuota"
        Me.TxtIdCuota.Size = New System.Drawing.Size(43, 22)
        Me.TxtIdCuota.TabIndex = 65
        '
        'TxtIdDto
        '
        Me.TxtIdDto.Location = New System.Drawing.Point(343, 71)
        Me.TxtIdDto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdDto.Name = "TxtIdDto"
        Me.TxtIdDto.Size = New System.Drawing.Size(43, 22)
        Me.TxtIdDto.TabIndex = 66
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtFallaRecJCF)
        Me.GroupBox2.Controls.Add(Me.TxtRecJCF)
        Me.GroupBox2.Controls.Add(Me.CboFalla)
        Me.GroupBox2.Controls.Add(Me.CboRecompensa)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TxtAñoRecJCF)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 226)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1049, 65)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recompensas de JCF"
        '
        'TxtFallaRecJCF
        '
        Me.TxtFallaRecJCF.Location = New System.Drawing.Point(664, 26)
        Me.TxtFallaRecJCF.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFallaRecJCF.Name = "TxtFallaRecJCF"
        Me.TxtFallaRecJCF.ReadOnly = True
        Me.TxtFallaRecJCF.Size = New System.Drawing.Size(56, 22)
        Me.TxtFallaRecJCF.TabIndex = 57
        '
        'TxtRecJCF
        '
        Me.TxtRecJCF.Location = New System.Drawing.Point(252, 26)
        Me.TxtRecJCF.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecJCF.Name = "TxtRecJCF"
        Me.TxtRecJCF.ReadOnly = True
        Me.TxtRecJCF.Size = New System.Drawing.Size(53, 22)
        Me.TxtRecJCF.TabIndex = 56
        '
        'CboFalla
        '
        Me.CboFalla.DataSource = Me.FallasBindingSource
        Me.CboFalla.DisplayMember = "DESFAL"
        Me.CboFalla.DropDownWidth = 250
        Me.CboFalla.FormattingEnabled = True
        Me.CboFalla.Location = New System.Drawing.Point(493, 26)
        Me.CboFalla.Margin = New System.Windows.Forms.Padding(4)
        Me.CboFalla.Name = "CboFalla"
        Me.CboFalla.Size = New System.Drawing.Size(157, 24)
        Me.CboFalla.TabIndex = 1
        Me.CboFalla.ValueMember = "NUMFAL"
        '
        'FallasBindingSource
        '
        Me.FallasBindingSource.DataMember = "fallas"
        Me.FallasBindingSource.DataSource = Me.DbCensos
        '
        'CboRecompensa
        '
        Me.CboRecompensa.DataSource = Me.RecompensasBindingSource
        Me.CboRecompensa.DisplayMember = "DESREC"
        Me.CboRecompensa.FormattingEnabled = True
        Me.CboRecompensa.Location = New System.Drawing.Point(101, 26)
        Me.CboRecompensa.Margin = New System.Windows.Forms.Padding(4)
        Me.CboRecompensa.Name = "CboRecompensa"
        Me.CboRecompensa.Size = New System.Drawing.Size(141, 24)
        Me.CboRecompensa.TabIndex = 0
        Me.CboRecompensa.ValueMember = "RECOM"
        '
        'RecompensasBindingSource
        '
        Me.RecompensasBindingSource.DataMember = "recompensas"
        Me.RecompensasBindingSource.DataSource = Me.DbCensos
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(787, 31)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 17)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Año Rec. JCF:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(380, 31)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 17)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Falla Rec. JCF:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Rec. JCF:"
        '
        'TxtAñoRecJCF
        '
        Me.TxtAñoRecJCF.Location = New System.Drawing.Point(896, 27)
        Me.TxtAñoRecJCF.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAñoRecJCF.Name = "TxtAñoRecJCF"
        Me.TxtAñoRecJCF.Size = New System.Drawing.Size(132, 22)
        Me.TxtAñoRecJCF.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.CboCargo)
        Me.GroupBox1.Controls.Add(Me.CboSexo)
        Me.GroupBox1.Controls.Add(Me.CboComision)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.TxtCP)
        Me.GroupBox1.Controls.Add(Me.TxtPoblacion)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.TxtDNI)
        Me.GroupBox1.Controls.Add(Me.TxtApellidos)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 143)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filiación"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(97, 66)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'CboCargo
        '
        Me.CboCargo.DataSource = Me.CargoBindingSource
        Me.CboCargo.DisplayMember = "DESCRIP"
        Me.CboCargo.FormattingEnabled = True
        Me.CboCargo.Location = New System.Drawing.Point(903, 98)
        Me.CboCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.CboCargo.Name = "CboCargo"
        Me.CboCargo.Size = New System.Drawing.Size(127, 24)
        Me.CboCargo.TabIndex = 11
        Me.CboCargo.ValueMember = "CARGO"
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.DbCensos
        '
        'CboSexo
        '
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.CboSexo.Location = New System.Drawing.Point(920, 32)
        Me.CboSexo.Margin = New System.Windows.Forms.Padding(4)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(111, 24)
        Me.CboSexo.TabIndex = 3
        '
        'CboComision
        '
        Me.CboComision.DataSource = Me.ComisionBindingSource
        Me.CboComision.DisplayMember = "comision"
        Me.CboComision.FormattingEnabled = True
        Me.CboComision.Location = New System.Drawing.Point(689, 96)
        Me.CboComision.Margin = New System.Windows.Forms.Padding(4)
        Me.CboComision.Name = "CboComision"
        Me.CboComision.Size = New System.Drawing.Size(131, 24)
        Me.CboComision.TabIndex = 10
        Me.CboComision.ValueMember = "tipfal"
        '
        'ComisionBindingSource
        '
        Me.ComisionBindingSource.DataMember = "comision"
        Me.ComisionBindingSource.DataSource = Me.DbCensos
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(844, 102)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "*Cargo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(611, 101)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "*Comisión:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(276, 102)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "E mail:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "*Teléfono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(904, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "C.P.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(604, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "*Población:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "*Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "*Fecha Nac.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(867, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "*Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "DNI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "*Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "*Nombre:"
        '
        'TxtEmail
        '
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.Location = New System.Drawing.Point(335, 97)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(253, 22)
        Me.TxtEmail.TabIndex = 9
        '
        'TxtCP
        '
        Me.TxtCP.Location = New System.Drawing.Point(952, 65)
        Me.TxtCP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(77, 22)
        Me.TxtCP.TabIndex = 7
        '
        'TxtPoblacion
        '
        Me.TxtPoblacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPoblacion.Location = New System.Drawing.Point(688, 65)
        Me.TxtPoblacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPoblacion.Name = "TxtPoblacion"
        Me.TxtPoblacion.Size = New System.Drawing.Size(200, 22)
        Me.TxtPoblacion.TabIndex = 6
        '
        'TxtDireccion
        '
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Location = New System.Drawing.Point(317, 65)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(271, 22)
        Me.TxtDireccion.TabIndex = 5
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(100, 98)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(132, 22)
        Me.TxtTelefono.TabIndex = 8
        '
        'TxtDNI
        '
        Me.TxtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDNI.Location = New System.Drawing.Point(688, 33)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(132, 22)
        Me.TxtDNI.TabIndex = 2
        '
        'TxtApellidos
        '
        Me.TxtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidos.Location = New System.Drawing.Point(360, 33)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(228, 22)
        Me.TxtApellidos.TabIndex = 1
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(100, 33)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 22)
        Me.TxtNombre.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(47, 25)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Código:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(879, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 17)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Año Censo:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.TxtCodigo.Location = New System.Drawing.Point(112, 20)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(55, 22)
        Me.TxtCodigo.TabIndex = 62
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DbCensos
        '
        'TxtAñoCenso
        '
        Me.TxtAñoCenso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.TxtAñoCenso.Location = New System.Drawing.Point(970, 20)
        Me.TxtAñoCenso.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAñoCenso.Name = "TxtAñoCenso"
        Me.TxtAñoCenso.ReadOnly = True
        Me.TxtAñoCenso.Size = New System.Drawing.Size(75, 22)
        Me.TxtAñoCenso.TabIndex = 61
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'RecompensasTableAdapter
        '
        Me.RecompensasTableAdapter.ClearBeforeFill = True
        '
        'FallasTableAdapter
        '
        Me.FallasTableAdapter.ClearBeforeFill = True
        '
        'Tipo_de_cuotasTableAdapter
        '
        Me.Tipo_de_cuotasTableAdapter.ClearBeforeFill = True
        '
        'Descuentos_de_la_cuotaTableAdapter
        '
        Me.Descuentos_de_la_cuotaTableAdapter.ClearBeforeFill = True
        '
        'ComisionTableAdapter
        '
        Me.ComisionTableAdapter.ClearBeforeFill = True
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'TxtNumcuotasMensuales
        '
        Me.TxtNumcuotasMensuales.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNumcuotasMensuales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.TxtNumcuotasMensuales.Location = New System.Drawing.Point(791, 20)
        Me.TxtNumcuotasMensuales.Name = "TxtNumcuotasMensuales"
        Me.TxtNumcuotasMensuales.ReadOnly = True
        Me.TxtNumcuotasMensuales.Size = New System.Drawing.Size(47, 22)
        Me.TxtNumcuotasMensuales.TabIndex = 69
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(613, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(172, 17)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "Nº de cuotas del ejercicio:"
        '
        'LblAnoCen
        '
        Me.LblAnoCen.AutoSize = True
        Me.LblAnoCen.Location = New System.Drawing.Point(970, 50)
        Me.LblAnoCen.Name = "LblAnoCen"
        Me.LblAnoCen.Size = New System.Drawing.Size(59, 17)
        Me.LblAnoCen.TabIndex = 71
        Me.LblAnoCen.Text = "Label29"
        '
        'FrmAltaFallero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1096, 607)
        Me.Controls.Add(Me.LblAnoCen)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TxtNumcuotasMensuales)
        Me.Controls.Add(Me.PasemayorTextBox)
        Me.Controls.Add(PasemayorLabel)
        Me.Controls.Add(PasejuvenilLabel)
        Me.Controls.Add(Me.PasejuvenilTextBox)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TxtAñoCenso)
        Me.HelpProvider1.SetHelpKeyword(Me, "27")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAltaFallero"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Fallero"
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasemayorTextBox As TextBox
    Friend WithEvents PasejuvenilTextBox As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtCuenta As MaskedTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtTitular As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents ChkBanco As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents TxtValCuota As TextBox
    Friend WithEvents ChkLoteria As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CboDescrDto As ComboBox
    Friend WithEvents CboDescCuota As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtDeuda As TextBox
    Friend WithEvents TxtTotalCuota As TextBox
    Friend WithEvents TxtNumCuotas As TextBox
    Friend WithEvents TxtNumPagos As TextBox
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents TxtTipoCuota As TextBox
    Friend WithEvents txtnCuotas As TextBox
    Friend WithEvents TxtIdCuota As TextBox
    Friend WithEvents TxtIdDto As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtFallaRecJCF As TextBox
    Friend WithEvents TxtRecJCF As TextBox
    Friend WithEvents CboFalla As ComboBox
    Friend WithEvents CboRecompensa As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtAñoRecJCF As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CboCargo As ComboBox
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents CboComision As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtCP As TextBox
    Friend WithEvents TxtPoblacion As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtAñoCenso As TextBox
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DbCensosTableAdapters.ejercicioTableAdapter
    Friend WithEvents RecompensasBindingSource As BindingSource
    Friend WithEvents RecompensasTableAdapter As DbCensosTableAdapters.recompensasTableAdapter
    Friend WithEvents FallasBindingSource As BindingSource
    Friend WithEvents FallasTableAdapter As DbCensosTableAdapters.fallasTableAdapter
    Friend WithEvents TipoDeCuotasBindingSource As BindingSource
    Friend WithEvents Tipo_de_cuotasTableAdapter As DbCensosTableAdapters.tipo_de_cuotasTableAdapter
    Friend WithEvents DescuentosDeLaCuotaBindingSource As BindingSource
    Friend WithEvents Descuentos_de_la_cuotaTableAdapter As DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter
    Friend WithEvents ComisionBindingSource As BindingSource
    Friend WithEvents ComisionTableAdapter As DbCensosTableAdapters.comisionTableAdapter
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As DbCensosTableAdapters.cargoTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TxtNumcuotasMensuales As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents LblAnoCen As Label
End Class
