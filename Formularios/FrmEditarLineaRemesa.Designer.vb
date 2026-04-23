<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarLineaRemesa
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
        Dim TotalreciboLabel As System.Windows.Forms.Label
        Dim TotalCargoLabel As System.Windows.Forms.Label
        Dim AbonobenefiLabel As System.Windows.Forms.Label
        Dim TotalCuotaLabel As System.Windows.Forms.Label
        Dim SumaAbonosLabel As System.Windows.Forms.Label
        Dim EntregasAcuentaLabel As System.Windows.Forms.Label
        Dim RestoBeneficioLabel As System.Windows.Forms.Label
        Dim DEV_BENEFILabel As System.Windows.Forms.Label
        Dim BENEFICIOSLabel As System.Windows.Forms.Label
        Dim SumaCargosLabel As System.Windows.Forms.Label
        Dim ValordevLabel As System.Windows.Forms.Label
        Dim RecdevLabel As System.Windows.Forms.Label
        Dim OtrosCargosLabel As System.Windows.Forms.Label
        Dim NumPagosLabel As System.Windows.Forms.Label
        Dim PAGOLabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim TITULARLabel As System.Windows.Forms.Label
        Dim FALLERO_CODIGOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarLineaRemesa))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDeuda = New System.Windows.Forms.TextBox()
        Me.DetallesDeRemesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalreciboTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCargoTextBox = New System.Windows.Forms.TextBox()
        Me.AbonobenefiTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCuotaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SumaAbonosTextBox = New System.Windows.Forms.TextBox()
        Me.EntregasAcuentaTextBox = New System.Windows.Forms.TextBox()
        Me.RestoBeneficioTextBox = New System.Windows.Forms.TextBox()
        Me.DEV_BENEFITextBox = New System.Windows.Forms.TextBox()
        Me.BENEFICIOSTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SumaCargosTextBox = New System.Windows.Forms.TextBox()
        Me.ValordevTextBox = New System.Windows.Forms.TextBox()
        Me.RecdevTextBox = New System.Windows.Forms.TextBox()
        Me.OtrosCargosTextBox = New System.Windows.Forms.TextBox()
        Me.NumPagosTextBox = New System.Windows.Forms.TextBox()
        Me.PAGOTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.TITULARTextBox = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Detalles_de_remesaTableAdapter = New AppGestion.DataSet1TableAdapters.detalles_de_remesaTableAdapter()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        TotalreciboLabel = New System.Windows.Forms.Label()
        TotalCargoLabel = New System.Windows.Forms.Label()
        AbonobenefiLabel = New System.Windows.Forms.Label()
        TotalCuotaLabel = New System.Windows.Forms.Label()
        SumaAbonosLabel = New System.Windows.Forms.Label()
        EntregasAcuentaLabel = New System.Windows.Forms.Label()
        RestoBeneficioLabel = New System.Windows.Forms.Label()
        DEV_BENEFILabel = New System.Windows.Forms.Label()
        BENEFICIOSLabel = New System.Windows.Forms.Label()
        SumaCargosLabel = New System.Windows.Forms.Label()
        ValordevLabel = New System.Windows.Forms.Label()
        RecdevLabel = New System.Windows.Forms.Label()
        OtrosCargosLabel = New System.Windows.Forms.Label()
        NumPagosLabel = New System.Windows.Forms.Label()
        PAGOLabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        TITULARLabel = New System.Windows.Forms.Label()
        FALLERO_CODIGOLabel = New System.Windows.Forms.Label()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalreciboLabel
        '
        TotalreciboLabel.AutoSize = True
        TotalreciboLabel.Location = New System.Drawing.Point(42, 192)
        TotalreciboLabel.Name = "TotalreciboLabel"
        TotalreciboLabel.Size = New System.Drawing.Size(92, 17)
        TotalreciboLabel.TabIndex = 6
        TotalreciboLabel.Text = "Total Recibo:"
        '
        'TotalCargoLabel
        '
        TotalCargoLabel.AutoSize = True
        TotalCargoLabel.Location = New System.Drawing.Point(48, 86)
        TotalCargoLabel.Name = "TotalCargoLabel"
        TotalCargoLabel.Size = New System.Drawing.Size(86, 17)
        TotalCargoLabel.TabIndex = 4
        TotalCargoLabel.Text = "Total Cargo:"
        '
        'AbonobenefiLabel
        '
        AbonobenefiLabel.AutoSize = True
        AbonobenefiLabel.Location = New System.Drawing.Point(21, 58)
        AbonobenefiLabel.Name = "AbonobenefiLabel"
        AbonobenefiLabel.Size = New System.Drawing.Size(113, 17)
        AbonobenefiLabel.TabIndex = 2
        AbonobenefiLabel.Text = "Benef. abonado:"
        '
        'TotalCuotaLabel
        '
        TotalCuotaLabel.AutoSize = True
        TotalCuotaLabel.Location = New System.Drawing.Point(49, 30)
        TotalCuotaLabel.Name = "TotalCuotaLabel"
        TotalCuotaLabel.Size = New System.Drawing.Size(85, 17)
        TotalCuotaLabel.TabIndex = 0
        TotalCuotaLabel.Text = "Total Cuota:"
        '
        'SumaAbonosLabel
        '
        SumaAbonosLabel.AutoSize = True
        SumaAbonosLabel.Location = New System.Drawing.Point(44, 192)
        SumaAbonosLabel.Name = "SumaAbonosLabel"
        SumaAbonosLabel.Size = New System.Drawing.Size(100, 17)
        SumaAbonosLabel.TabIndex = 8
        SumaAbonosLabel.Text = "Suma Abonos:"
        '
        'EntregasAcuentaLabel
        '
        EntregasAcuentaLabel.AutoSize = True
        EntregasAcuentaLabel.Location = New System.Drawing.Point(76, 129)
        EntregasAcuentaLabel.Name = "EntregasAcuentaLabel"
        EntregasAcuentaLabel.Size = New System.Drawing.Size(68, 17)
        EntregasAcuentaLabel.TabIndex = 6
        EntregasAcuentaLabel.Text = "A cuenta:"
        '
        'RestoBeneficioLabel
        '
        RestoBeneficioLabel.AutoSize = True
        RestoBeneficioLabel.Location = New System.Drawing.Point(33, 101)
        RestoBeneficioLabel.Name = "RestoBeneficioLabel"
        RestoBeneficioLabel.Size = New System.Drawing.Size(111, 17)
        RestoBeneficioLabel.TabIndex = 4
        RestoBeneficioLabel.Text = "Resto Beneficio:"
        '
        'DEV_BENEFILabel
        '
        DEV_BENEFILabel.AutoSize = True
        DEV_BENEFILabel.Location = New System.Drawing.Point(23, 68)
        DEV_BENEFILabel.Name = "DEV_BENEFILabel"
        DEV_BENEFILabel.Size = New System.Drawing.Size(121, 17)
        DEV_BENEFILabel.TabIndex = 2
        DEV_BENEFILabel.Text = "Benef. Abonados:"
        '
        'BENEFICIOSLabel
        '
        BENEFICIOSLabel.AutoSize = True
        BENEFICIOSLabel.Location = New System.Drawing.Point(67, 43)
        BENEFICIOSLabel.Name = "BENEFICIOSLabel"
        BENEFICIOSLabel.Size = New System.Drawing.Size(77, 17)
        BENEFICIOSLabel.TabIndex = 0
        BENEFICIOSLabel.Text = "Benef. Lot."
        '
        'SumaCargosLabel
        '
        SumaCargosLabel.AutoSize = True
        SumaCargosLabel.Location = New System.Drawing.Point(15, 192)
        SumaCargosLabel.Name = "SumaCargosLabel"
        SumaCargosLabel.Size = New System.Drawing.Size(97, 17)
        SumaCargosLabel.TabIndex = 6
        SumaCargosLabel.Text = "Suma Cargos:"
        '
        'ValordevLabel
        '
        ValordevLabel.AutoSize = True
        ValordevLabel.Location = New System.Drawing.Point(26, 101)
        ValordevLabel.Name = "ValordevLabel"
        ValordevLabel.Size = New System.Drawing.Size(86, 17)
        ValordevLabel.TabIndex = 4
        ValordevLabel.Text = "Importe dev:"
        '
        'RecdevLabel
        '
        RecdevLabel.AutoSize = True
        RecdevLabel.Location = New System.Drawing.Point(22, 73)
        RecdevLabel.Name = "RecdevLabel"
        RecdevLabel.Size = New System.Drawing.Size(90, 17)
        RecdevLabel.TabIndex = 2
        RecdevLabel.Text = "Recibos dev:"
        '
        'OtrosCargosLabel
        '
        OtrosCargosLabel.AutoSize = True
        OtrosCargosLabel.Location = New System.Drawing.Point(16, 43)
        OtrosCargosLabel.Name = "OtrosCargosLabel"
        OtrosCargosLabel.Size = New System.Drawing.Size(96, 17)
        OtrosCargosLabel.TabIndex = 0
        OtrosCargosLabel.Text = "Otros Cargos:"
        '
        'NumPagosLabel
        '
        NumPagosLabel.AutoSize = True
        NumPagosLabel.Location = New System.Drawing.Point(269, 165)
        NumPagosLabel.Name = "NumPagosLabel"
        NumPagosLabel.Size = New System.Drawing.Size(71, 17)
        NumPagosLabel.TabIndex = 32
        NumPagosLabel.Text = "Nº Pagos:"
        '
        'PAGOLabel
        '
        PAGOLabel.AutoSize = True
        PAGOLabel.Location = New System.Drawing.Point(37, 165)
        PAGOLabel.Name = "PAGOLabel"
        PAGOLabel.Size = New System.Drawing.Size(100, 17)
        PAGOLabel.TabIndex = 30
        PAGOLabel.Text = "Importe Cuota:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(343, 95)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(88, 17)
        APELLIDOSLabel.TabIndex = 27
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(28, 95)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(72, 17)
        NOMBRELabel.TabIndex = 25
        NOMBRELabel.Text = "NOMBRE:"
        '
        'TITULARLabel
        '
        TITULARLabel.AutoSize = True
        TITULARLabel.Location = New System.Drawing.Point(284, 67)
        TITULARLabel.Name = "TITULARLabel"
        TITULARLabel.Size = New System.Drawing.Size(70, 17)
        TITULARLabel.TabIndex = 23
        TITULARLabel.Text = "TITULAR:"
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(33, 64)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(67, 17)
        FALLERO_CODIGOLabel.TabIndex = 21
        FALLERO_CODIGOLabel.Text = "CODIGO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(545, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Deuda:"
        '
        'TxtDeuda
        '
        Me.TxtDeuda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "parcial1", True))
        Me.TxtDeuda.Location = New System.Drawing.Point(605, 162)
        Me.TxtDeuda.Name = "TxtDeuda"
        Me.TxtDeuda.Size = New System.Drawing.Size(100, 22)
        Me.TxtDeuda.TabIndex = 40
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
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(645, 475)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(118, 37)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(187, 475)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(118, 37)
        Me.BtnActualizar.TabIndex = 38
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(TotalreciboLabel)
        Me.GroupBox3.Controls.Add(Me.TotalreciboTextBox)
        Me.GroupBox3.Controls.Add(TotalCargoLabel)
        Me.GroupBox3.Controls.Add(Me.TotalCargoTextBox)
        Me.GroupBox3.Controls.Add(AbonobenefiLabel)
        Me.GroupBox3.Controls.Add(Me.AbonobenefiTextBox)
        Me.GroupBox3.Controls.Add(TotalCuotaLabel)
        Me.GroupBox3.Controls.Add(Me.TotalCuotaTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(543, 215)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 231)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'TotalreciboTextBox
        '
        Me.TotalreciboTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalreciboTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "totalrecibo", True))
        Me.TotalreciboTextBox.Location = New System.Drawing.Point(140, 189)
        Me.TotalreciboTextBox.Name = "TotalreciboTextBox"
        Me.TotalreciboTextBox.ReadOnly = True
        Me.TotalreciboTextBox.Size = New System.Drawing.Size(67, 22)
        Me.TotalreciboTextBox.TabIndex = 7
        '
        'TotalCargoTextBox
        '
        Me.TotalCargoTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalCargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "totalCargo", True))
        Me.TotalCargoTextBox.Location = New System.Drawing.Point(140, 83)
        Me.TotalCargoTextBox.Name = "TotalCargoTextBox"
        Me.TotalCargoTextBox.ReadOnly = True
        Me.TotalCargoTextBox.Size = New System.Drawing.Size(67, 22)
        Me.TotalCargoTextBox.TabIndex = 5
        '
        'AbonobenefiTextBox
        '
        Me.AbonobenefiTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AbonobenefiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "abonobenefi", True))
        Me.AbonobenefiTextBox.Location = New System.Drawing.Point(140, 55)
        Me.AbonobenefiTextBox.Name = "AbonobenefiTextBox"
        Me.AbonobenefiTextBox.ReadOnly = True
        Me.AbonobenefiTextBox.Size = New System.Drawing.Size(67, 22)
        Me.AbonobenefiTextBox.TabIndex = 3
        '
        'TotalCuotaTextBox
        '
        Me.TotalCuotaTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalCuotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "totalCuota", True))
        Me.TotalCuotaTextBox.Location = New System.Drawing.Point(140, 27)
        Me.TotalCuotaTextBox.Name = "TotalCuotaTextBox"
        Me.TotalCuotaTextBox.ReadOnly = True
        Me.TotalCuotaTextBox.Size = New System.Drawing.Size(67, 22)
        Me.TotalCuotaTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(SumaAbonosLabel)
        Me.GroupBox2.Controls.Add(Me.SumaAbonosTextBox)
        Me.GroupBox2.Controls.Add(EntregasAcuentaLabel)
        Me.GroupBox2.Controls.Add(Me.EntregasAcuentaTextBox)
        Me.GroupBox2.Controls.Add(RestoBeneficioLabel)
        Me.GroupBox2.Controls.Add(Me.RestoBeneficioTextBox)
        Me.GroupBox2.Controls.Add(DEV_BENEFILabel)
        Me.GroupBox2.Controls.Add(Me.DEV_BENEFITextBox)
        Me.GroupBox2.Controls.Add(BENEFICIOSLabel)
        Me.GroupBox2.Controls.Add(Me.BENEFICIOSTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(287, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 231)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Abonos"
        '
        'SumaAbonosTextBox
        '
        Me.SumaAbonosTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SumaAbonosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "SumaAbonos", True))
        Me.SumaAbonosTextBox.Location = New System.Drawing.Point(150, 189)
        Me.SumaAbonosTextBox.Name = "SumaAbonosTextBox"
        Me.SumaAbonosTextBox.ReadOnly = True
        Me.SumaAbonosTextBox.Size = New System.Drawing.Size(67, 22)
        Me.SumaAbonosTextBox.TabIndex = 9
        '
        'EntregasAcuentaTextBox
        '
        Me.EntregasAcuentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "EntregasAcuenta", True))
        Me.EntregasAcuentaTextBox.Location = New System.Drawing.Point(150, 126)
        Me.EntregasAcuentaTextBox.Name = "EntregasAcuentaTextBox"
        Me.EntregasAcuentaTextBox.Size = New System.Drawing.Size(67, 22)
        Me.EntregasAcuentaTextBox.TabIndex = 7
        '
        'RestoBeneficioTextBox
        '
        Me.RestoBeneficioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "RestoBeneficio", True))
        Me.RestoBeneficioTextBox.Location = New System.Drawing.Point(150, 98)
        Me.RestoBeneficioTextBox.Name = "RestoBeneficioTextBox"
        Me.RestoBeneficioTextBox.Size = New System.Drawing.Size(67, 22)
        Me.RestoBeneficioTextBox.TabIndex = 5
        '
        'DEV_BENEFITextBox
        '
        Me.DEV_BENEFITextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DEV_BENEFITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "DEV_BENEFI", True))
        Me.DEV_BENEFITextBox.Location = New System.Drawing.Point(150, 70)
        Me.DEV_BENEFITextBox.Name = "DEV_BENEFITextBox"
        Me.DEV_BENEFITextBox.Size = New System.Drawing.Size(67, 22)
        Me.DEV_BENEFITextBox.TabIndex = 3
        '
        'BENEFICIOSTextBox
        '
        Me.BENEFICIOSTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BENEFICIOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "BENEFICIOS", True))
        Me.BENEFICIOSTextBox.Location = New System.Drawing.Point(150, 40)
        Me.BENEFICIOSTextBox.Name = "BENEFICIOSTextBox"
        Me.BENEFICIOSTextBox.ReadOnly = True
        Me.BENEFICIOSTextBox.Size = New System.Drawing.Size(67, 22)
        Me.BENEFICIOSTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(SumaCargosLabel)
        Me.GroupBox1.Controls.Add(Me.SumaCargosTextBox)
        Me.GroupBox1.Controls.Add(ValordevLabel)
        Me.GroupBox1.Controls.Add(Me.ValordevTextBox)
        Me.GroupBox1.Controls.Add(RecdevLabel)
        Me.GroupBox1.Controls.Add(Me.RecdevTextBox)
        Me.GroupBox1.Controls.Add(OtrosCargosLabel)
        Me.GroupBox1.Controls.Add(Me.OtrosCargosTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 231)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cargos"
        '
        'SumaCargosTextBox
        '
        Me.SumaCargosTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SumaCargosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "SumaCargos", True))
        Me.SumaCargosTextBox.Location = New System.Drawing.Point(118, 189)
        Me.SumaCargosTextBox.Name = "SumaCargosTextBox"
        Me.SumaCargosTextBox.ReadOnly = True
        Me.SumaCargosTextBox.Size = New System.Drawing.Size(67, 22)
        Me.SumaCargosTextBox.TabIndex = 7
        '
        'ValordevTextBox
        '
        Me.ValordevTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "valordev", True))
        Me.ValordevTextBox.Location = New System.Drawing.Point(118, 96)
        Me.ValordevTextBox.Name = "ValordevTextBox"
        Me.ValordevTextBox.Size = New System.Drawing.Size(67, 22)
        Me.ValordevTextBox.TabIndex = 5
        '
        'RecdevTextBox
        '
        Me.RecdevTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "Recdev", True))
        Me.RecdevTextBox.Location = New System.Drawing.Point(118, 68)
        Me.RecdevTextBox.Name = "RecdevTextBox"
        Me.RecdevTextBox.Size = New System.Drawing.Size(67, 22)
        Me.RecdevTextBox.TabIndex = 3
        '
        'OtrosCargosTextBox
        '
        Me.OtrosCargosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "OtrosCargos", True))
        Me.OtrosCargosTextBox.Location = New System.Drawing.Point(118, 40)
        Me.OtrosCargosTextBox.Name = "OtrosCargosTextBox"
        Me.OtrosCargosTextBox.Size = New System.Drawing.Size(67, 22)
        Me.OtrosCargosTextBox.TabIndex = 1
        '
        'NumPagosTextBox
        '
        Me.NumPagosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "NumPagos", True))
        Me.NumPagosTextBox.Location = New System.Drawing.Point(346, 162)
        Me.NumPagosTextBox.Name = "NumPagosTextBox"
        Me.NumPagosTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NumPagosTextBox.TabIndex = 33
        '
        'PAGOTextBox
        '
        Me.PAGOTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PAGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "PAGO", True))
        Me.PAGOTextBox.Location = New System.Drawing.Point(143, 162)
        Me.PAGOTextBox.Name = "PAGOTextBox"
        Me.PAGOTextBox.ReadOnly = True
        Me.PAGOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PAGOTextBox.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Editar Línea de Remesa"
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(437, 92)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.ReadOnly = True
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(302, 22)
        Me.APELLIDOSTextBox.TabIndex = 28
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(106, 92)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.ReadOnly = True
        Me.NOMBRETextBox.Size = New System.Drawing.Size(185, 22)
        Me.NOMBRETextBox.TabIndex = 26
        '
        'TITULARTextBox
        '
        Me.TITULARTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TITULARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "TITULAR", True))
        Me.TITULARTextBox.Location = New System.Drawing.Point(360, 64)
        Me.TITULARTextBox.Name = "TITULARTextBox"
        Me.TITULARTextBox.ReadOnly = True
        Me.TITULARTextBox.Size = New System.Drawing.Size(379, 22)
        Me.TITULARTextBox.TabIndex = 24
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtCodigo.Location = New System.Drawing.Point(106, 64)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(61, 22)
        Me.TxtCodigo.TabIndex = 22
        '
        'Detalles_de_remesaTableAdapter
        '
        Me.Detalles_de_remesaTableAdapter.ClearBeforeFill = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Image = Global.AppGestion.My.Resources.Resources.calculator
        Me.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalcular.Location = New System.Drawing.Point(39, 474)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(118, 37)
        Me.BtnCalcular.TabIndex = 37
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'FrmEditarLineaRemesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 537)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDeuda)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(NumPagosLabel)
        Me.Controls.Add(Me.NumPagosTextBox)
        Me.Controls.Add(PAGOLabel)
        Me.Controls.Add(Me.PAGOTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(APELLIDOSLabel)
        Me.Controls.Add(Me.APELLIDOSTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(TITULARLabel)
        Me.Controls.Add(Me.TITULARTextBox)
        Me.Controls.Add(FALLERO_CODIGOLabel)
        Me.Controls.Add(Me.TxtCodigo)
        Me.HelpProvider1.SetHelpKeyword(Me, "55")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditarLineaRemesa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Linea Remesa"
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDeuda As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TotalreciboTextBox As TextBox
    Friend WithEvents TotalCargoTextBox As TextBox
    Friend WithEvents AbonobenefiTextBox As TextBox
    Friend WithEvents TotalCuotaTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SumaAbonosTextBox As TextBox
    Friend WithEvents EntregasAcuentaTextBox As TextBox
    Friend WithEvents RestoBeneficioTextBox As TextBox
    Friend WithEvents DEV_BENEFITextBox As TextBox
    Friend WithEvents BENEFICIOSTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SumaCargosTextBox As TextBox
    Friend WithEvents ValordevTextBox As TextBox
    Friend WithEvents RecdevTextBox As TextBox
    Friend WithEvents OtrosCargosTextBox As TextBox
    Friend WithEvents NumPagosTextBox As TextBox
    Friend WithEvents PAGOTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents TITULARTextBox As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DetallesDeRemesaBindingSource As BindingSource
    Friend WithEvents Detalles_de_remesaTableAdapter As DataSet1TableAdapters.detalles_de_remesaTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
