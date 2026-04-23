<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddPago
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
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim OtroscargosLabel As System.Windows.Forms.Label
        Dim Total_cargoLabel As System.Windows.Forms.Label
        Dim Total_cuotaLabel As System.Windows.Forms.Label
        Dim TotalreciboLabel As System.Windows.Forms.Label
        Dim ValordevLabel As System.Windows.Forms.Label
        Dim RecdevLabel As System.Windows.Forms.Label
        Dim RestoLabel As System.Windows.Forms.Label
        Dim DEV_BENEFILabel As System.Windows.Forms.Label
        Dim BENEFICIOSLabel As System.Windows.Forms.Label
        Dim REGALOSFMSLabel As System.Windows.Forms.Label
        Dim PAGOLabel As System.Windows.Forms.Label
        Dim Id_RemesaLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim TIPO_CUOTALabel As System.Windows.Forms.Label
        Dim ComisiónLabel As System.Windows.Forms.Label
        Dim APELLILabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim TITULARLabel As System.Windows.Forms.Label
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim MESESLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddPago))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSumaAbonoRecibo = New System.Windows.Forms.TextBox()
        Me.TxtSumaCargosRecibo = New System.Windows.Forms.TextBox()
        Me.TxtTotalFinalrecibo = New System.Windows.Forms.TextBox()
        Me.TxtAcuentaRecibo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCuotasRecibo = New System.Windows.Forms.TextBox()
        Me.TxtValorDevRecibo = New System.Windows.Forms.TextBox()
        Me.TxtRecDevRecibo = New System.Windows.Forms.TextBox()
        Me.TxtOtrosCargosRecibo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNumCuotas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSumaAbonos = New System.Windows.Forms.TextBox()
        Me.TxtTotCuotaAnual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMesesDeuda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotCuota = New System.Windows.Forms.TextBox()
        Me.TxtAcuenta = New System.Windows.Forms.TextBox()
        Me.TxtTotalcargo = New System.Windows.Forms.TextBox()
        Me.TxtDeuda = New System.Windows.Forms.TextBox()
        Me.TxtTotalrecibo = New System.Windows.Forms.TextBox()
        Me.TxtValorDev = New System.Windows.Forms.TextBox()
        Me.TxtRecDev = New System.Windows.Forms.TextBox()
        Me.TxtRestoBenef = New System.Windows.Forms.TextBox()
        Me.TxtBenefAbonado = New System.Windows.Forms.TextBox()
        Me.TxtBeneficios = New System.Windows.Forms.TextBox()
        Me.TxtCargos = New System.Windows.Forms.TextBox()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.TxtAbonoBenefRecibo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCUENTA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtIdRemesa = New System.Windows.Forms.TextBox()
        Me.TxtTitular = New System.Windows.Forms.TextBox()
        Me.TxtTipoCuota = New System.Windows.Forms.TextBox()
        Me.TxtComision = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtNumMeses = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DbCensos = New AppGestion.DbCensos()
        Me.RemesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemesasTableAdapter = New AppGestion.DbCensosTableAdapters.remesasTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.RemesasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FalleroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        OtroscargosLabel = New System.Windows.Forms.Label()
        Total_cargoLabel = New System.Windows.Forms.Label()
        Total_cuotaLabel = New System.Windows.Forms.Label()
        TotalreciboLabel = New System.Windows.Forms.Label()
        ValordevLabel = New System.Windows.Forms.Label()
        RecdevLabel = New System.Windows.Forms.Label()
        RestoLabel = New System.Windows.Forms.Label()
        DEV_BENEFILabel = New System.Windows.Forms.Label()
        BENEFICIOSLabel = New System.Windows.Forms.Label()
        REGALOSFMSLabel = New System.Windows.Forms.Label()
        PAGOLabel = New System.Windows.Forms.Label()
        Id_RemesaLabel = New System.Windows.Forms.Label()
        FECHALabel = New System.Windows.Forms.Label()
        TIPO_CUOTALabel = New System.Windows.Forms.Label()
        ComisiónLabel = New System.Windows.Forms.Label()
        APELLILabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        TITULARLabel = New System.Windows.Forms.Label()
        CODIGOLabel = New System.Windows.Forms.Label()
        MESESLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Enabled = False
        Label14.Location = New System.Drawing.Point(366, 599)
        Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(97, 17)
        Label14.TabIndex = 185
        Label14.Text = "Suma Cargos:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(83, 599)
        Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(87, 17)
        Label15.TabIndex = 184
        Label15.Text = "Total recibo:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Enabled = False
        Label12.Location = New System.Drawing.Point(712, 444)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(70, 17)
        Label12.TabIndex = 182
        Label12.Text = "A Cuenta:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(379, 534)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(74, 17)
        Label9.TabIndex = 176
        Label9.Text = "valor dev.:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(358, 502)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(94, 17)
        Label10.TabIndex = 175
        Label10.Text = "Recibos dev.:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(362, 472)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(94, 17)
        Label11.TabIndex = 174
        Label11.Text = "Otros cargos:"
        '
        'OtroscargosLabel
        '
        OtroscargosLabel.AutoSize = True
        OtroscargosLabel.Enabled = False
        OtroscargosLabel.Location = New System.Drawing.Point(685, 36)
        OtroscargosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OtroscargosLabel.Name = "OtroscargosLabel"
        OtroscargosLabel.Size = New System.Drawing.Size(70, 17)
        OtroscargosLabel.TabIndex = 86
        OtroscargosLabel.Text = "A Cuenta:"
        '
        'Total_cargoLabel
        '
        Total_cargoLabel.AutoSize = True
        Total_cargoLabel.Enabled = False
        Total_cargoLabel.Location = New System.Drawing.Point(336, 193)
        Total_cargoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_cargoLabel.Name = "Total_cargoLabel"
        Total_cargoLabel.Size = New System.Drawing.Size(93, 17)
        Total_cargoLabel.TabIndex = 85
        Total_cargoLabel.Text = "Total Cargos:"
        '
        'Total_cuotaLabel
        '
        Total_cuotaLabel.AutoSize = True
        Total_cuotaLabel.Enabled = False
        Total_cuotaLabel.Location = New System.Drawing.Point(63, 132)
        Total_cuotaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_cuotaLabel.Name = "Total_cuotaLabel"
        Total_cuotaLabel.Size = New System.Drawing.Size(83, 17)
        Total_cuotaLabel.TabIndex = 84
        Total_cuotaLabel.Text = "total deuda:"
        '
        'TotalreciboLabel
        '
        TotalreciboLabel.AutoSize = True
        TotalreciboLabel.Location = New System.Drawing.Point(59, 193)
        TotalreciboLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalreciboLabel.Name = "TotalreciboLabel"
        TotalreciboLabel.Size = New System.Drawing.Size(87, 17)
        TotalreciboLabel.TabIndex = 83
        TotalreciboLabel.Text = "Total recibo:"
        '
        'ValordevLabel
        '
        ValordevLabel.AutoSize = True
        ValordevLabel.Location = New System.Drawing.Point(352, 132)
        ValordevLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ValordevLabel.Name = "ValordevLabel"
        ValordevLabel.Size = New System.Drawing.Size(74, 17)
        ValordevLabel.TabIndex = 82
        ValordevLabel.Text = "valor dev.:"
        '
        'RecdevLabel
        '
        RecdevLabel.AutoSize = True
        RecdevLabel.Location = New System.Drawing.Point(331, 100)
        RecdevLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RecdevLabel.Name = "RecdevLabel"
        RecdevLabel.Size = New System.Drawing.Size(94, 17)
        RecdevLabel.TabIndex = 81
        RecdevLabel.Text = "Recibos dev.:"
        '
        'RestoLabel
        '
        RestoLabel.AutoSize = True
        RestoLabel.Location = New System.Drawing.Point(639, 135)
        RestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RestoLabel.Name = "RestoLabel"
        RestoLabel.Size = New System.Drawing.Size(117, 17)
        RestoLabel.TabIndex = 80
        RestoLabel.Text = "Resto beneficios:"
        '
        'DEV_BENEFILabel
        '
        DEV_BENEFILabel.AutoSize = True
        DEV_BENEFILabel.Location = New System.Drawing.Point(612, 103)
        DEV_BENEFILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DEV_BENEFILabel.Name = "DEV_BENEFILabel"
        DEV_BENEFILabel.Size = New System.Drawing.Size(144, 17)
        DEV_BENEFILabel.TabIndex = 79
        DEV_BENEFILabel.Text = "Beneficios abonados:"
        '
        'BENEFICIOSLabel
        '
        BENEFICIOSLabel.AutoSize = True
        BENEFICIOSLabel.Location = New System.Drawing.Point(640, 69)
        BENEFICIOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BENEFICIOSLabel.Name = "BENEFICIOSLabel"
        BENEFICIOSLabel.Size = New System.Drawing.Size(114, 17)
        BENEFICIOSLabel.TabIndex = 78
        BENEFICIOSLabel.Text = "Beneficio Lotería"
        '
        'REGALOSFMSLabel
        '
        REGALOSFMSLabel.AutoSize = True
        REGALOSFMSLabel.Location = New System.Drawing.Point(335, 70)
        REGALOSFMSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        REGALOSFMSLabel.Name = "REGALOSFMSLabel"
        REGALOSFMSLabel.Size = New System.Drawing.Size(94, 17)
        REGALOSFMSLabel.TabIndex = 76
        REGALOSFMSLabel.Text = "Otros cargos:"
        '
        'PAGOLabel
        '
        PAGOLabel.AutoSize = True
        PAGOLabel.Location = New System.Drawing.Point(44, 38)
        PAGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PAGOLabel.Name = "PAGOLabel"
        PAGOLabel.Size = New System.Drawing.Size(100, 17)
        PAGOLabel.TabIndex = 70
        PAGOLabel.Text = "Importe Cuota:"
        '
        'Id_RemesaLabel
        '
        Id_RemesaLabel.AutoSize = True
        Id_RemesaLabel.Enabled = False
        Id_RemesaLabel.Location = New System.Drawing.Point(66, 104)
        Id_RemesaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_RemesaLabel.Name = "Id_RemesaLabel"
        Id_RemesaLabel.Size = New System.Drawing.Size(79, 17)
        Id_RemesaLabel.TabIndex = 154
        Id_RemesaLabel.Text = "Id Remesa:"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(80, 445)
        FECHALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(88, 17)
        FECHALabel.TabIndex = 150
        FECHALabel.Text = "Fecha Pago:"
        '
        'TIPO_CUOTALabel
        '
        TIPO_CUOTALabel.AutoSize = True
        TIPO_CUOTALabel.Enabled = False
        TIPO_CUOTALabel.Location = New System.Drawing.Point(251, 72)
        TIPO_CUOTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIPO_CUOTALabel.Name = "TIPO_CUOTALabel"
        TIPO_CUOTALabel.Size = New System.Drawing.Size(96, 17)
        TIPO_CUOTALabel.TabIndex = 149
        TIPO_CUOTALabel.Text = "TIPO CUOTA:"
        '
        'ComisiónLabel
        '
        ComisiónLabel.AutoSize = True
        ComisiónLabel.Enabled = False
        ComisiónLabel.Location = New System.Drawing.Point(80, 72)
        ComisiónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ComisiónLabel.Name = "ComisiónLabel"
        ComisiónLabel.Size = New System.Drawing.Size(69, 17)
        ComisiónLabel.TabIndex = 148
        ComisiónLabel.Text = "Comisión:"
        '
        'APELLILabel
        '
        APELLILabel.AutoSize = True
        APELLILabel.Enabled = False
        APELLILabel.Location = New System.Drawing.Point(556, 40)
        APELLILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLILabel.Name = "APELLILabel"
        APELLILabel.Size = New System.Drawing.Size(88, 17)
        APELLILabel.TabIndex = 147
        APELLILabel.Text = "APELLIDOS:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Enabled = False
        NOMBRELabel.Location = New System.Drawing.Point(274, 40)
        NOMBRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(72, 17)
        NOMBRELabel.TabIndex = 146
        NOMBRELabel.Text = "NOMBRE:"
        '
        'TITULARLabel
        '
        TITULARLabel.AutoSize = True
        TITULARLabel.Enabled = False
        TITULARLabel.Location = New System.Drawing.Point(575, 72)
        TITULARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TITULARLabel.Name = "TITULARLabel"
        TITULARLabel.Size = New System.Drawing.Size(70, 17)
        TITULARLabel.TabIndex = 145
        TITULARLabel.Text = "TITULAR:"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Enabled = False
        CODIGOLabel.Location = New System.Drawing.Point(80, 40)
        CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(67, 17)
        CODIGOLabel.TabIndex = 144
        CODIGOLabel.Text = "CODIGO:"
        '
        'MESESLabel
        '
        MESESLabel.AutoSize = True
        MESESLabel.Location = New System.Drawing.Point(63, 530)
        MESESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MESESLabel.Name = "MESESLabel"
        MESESLabel.Size = New System.Drawing.Size(106, 17)
        MESESLabel.TabIndex = 151
        MESESLabel.Text = "Meses a pagar:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(666, 599)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 17)
        Me.Label13.TabIndex = 189
        Me.Label13.Text = "Suma de Abonos:"
        '
        'TxtSumaAbonoRecibo
        '
        Me.TxtSumaAbonoRecibo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtSumaAbonoRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSumaAbonoRecibo.Location = New System.Drawing.Point(795, 595)
        Me.TxtSumaAbonoRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSumaAbonoRecibo.Name = "TxtSumaAbonoRecibo"
        Me.TxtSumaAbonoRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtSumaAbonoRecibo.TabIndex = 188
        '
        'TxtSumaCargosRecibo
        '
        Me.TxtSumaCargosRecibo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSumaCargosRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSumaCargosRecibo.Location = New System.Drawing.Point(466, 595)
        Me.TxtSumaCargosRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSumaCargosRecibo.Name = "TxtSumaCargosRecibo"
        Me.TxtSumaCargosRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtSumaCargosRecibo.TabIndex = 187
        '
        'TxtTotalFinalrecibo
        '
        Me.TxtTotalFinalrecibo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtTotalFinalrecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtTotalFinalrecibo.Location = New System.Drawing.Point(178, 595)
        Me.TxtTotalFinalrecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalFinalrecibo.Name = "TxtTotalFinalrecibo"
        Me.TxtTotalFinalrecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotalFinalrecibo.TabIndex = 186
        '
        'TxtAcuentaRecibo
        '
        Me.TxtAcuentaRecibo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtAcuentaRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtAcuentaRecibo.Location = New System.Drawing.Point(792, 440)
        Me.TxtAcuentaRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAcuentaRecibo.Name = "TxtAcuentaRecibo"
        Me.TxtAcuentaRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtAcuentaRecibo.TabIndex = 183
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 438)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 17)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "Total Cuotas:"
        '
        'TxtCuotasRecibo
        '
        Me.TxtCuotasRecibo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtCuotasRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCuotasRecibo.Location = New System.Drawing.Point(463, 434)
        Me.TxtCuotasRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCuotasRecibo.Name = "TxtCuotasRecibo"
        Me.TxtCuotasRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtCuotasRecibo.TabIndex = 180
        '
        'TxtValorDevRecibo
        '
        Me.TxtValorDevRecibo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtValorDevRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtValorDevRecibo.Location = New System.Drawing.Point(463, 530)
        Me.TxtValorDevRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorDevRecibo.Name = "TxtValorDevRecibo"
        Me.TxtValorDevRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtValorDevRecibo.TabIndex = 179
        '
        'TxtRecDevRecibo
        '
        Me.TxtRecDevRecibo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtRecDevRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtRecDevRecibo.Location = New System.Drawing.Point(463, 498)
        Me.TxtRecDevRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecDevRecibo.Name = "TxtRecDevRecibo"
        Me.TxtRecDevRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtRecDevRecibo.TabIndex = 178
        '
        'TxtOtrosCargosRecibo
        '
        Me.TxtOtrosCargosRecibo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtOtrosCargosRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtOtrosCargosRecibo.Location = New System.Drawing.Point(463, 466)
        Me.TxtOtrosCargosRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOtrosCargosRecibo.Name = "TxtOtrosCargosRecibo"
        Me.TxtOtrosCargosRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtOtrosCargosRecibo.TabIndex = 177
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNumCuotas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtSumaAbonos)
        Me.GroupBox1.Controls.Add(Me.TxtTotCuotaAnual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtMesesDeuda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtTotCuota)
        Me.GroupBox1.Controls.Add(Me.TxtAcuenta)
        Me.GroupBox1.Controls.Add(Me.TxtTotalcargo)
        Me.GroupBox1.Controls.Add(Me.TxtDeuda)
        Me.GroupBox1.Controls.Add(Me.TxtTotalrecibo)
        Me.GroupBox1.Controls.Add(Me.TxtValorDev)
        Me.GroupBox1.Controls.Add(Me.TxtRecDev)
        Me.GroupBox1.Controls.Add(Me.TxtRestoBenef)
        Me.GroupBox1.Controls.Add(Me.TxtBenefAbonado)
        Me.GroupBox1.Controls.Add(Me.TxtBeneficios)
        Me.GroupBox1.Controls.Add(Me.TxtCargos)
        Me.GroupBox1.Controls.Add(Me.TxtPago)
        Me.GroupBox1.Controls.Add(OtroscargosLabel)
        Me.GroupBox1.Controls.Add(Total_cargoLabel)
        Me.GroupBox1.Controls.Add(Total_cuotaLabel)
        Me.GroupBox1.Controls.Add(TotalreciboLabel)
        Me.GroupBox1.Controls.Add(ValordevLabel)
        Me.GroupBox1.Controls.Add(RecdevLabel)
        Me.GroupBox1.Controls.Add(RestoLabel)
        Me.GroupBox1.Controls.Add(DEV_BENEFILabel)
        Me.GroupBox1.Controls.Add(BENEFICIOSLabel)
        Me.GroupBox1.Controls.Add(REGALOSFMSLabel)
        Me.GroupBox1.Controls.Add(PAGOLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 147)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(919, 234)
        Me.GroupBox1.TabIndex = 173
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Inicio"
        '
        'TxtNumCuotas
        '
        Me.TxtNumCuotas.Location = New System.Drawing.Point(241, 34)
        Me.TxtNumCuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumCuotas.Name = "TxtNumCuotas"
        Me.TxtNumCuotas.Size = New System.Drawing.Size(44, 22)
        Me.TxtNumCuotas.TabIndex = 144
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(636, 193)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Suma de Abonos:"
        '
        'TxtSumaAbonos
        '
        Me.TxtSumaAbonos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtSumaAbonos.ForeColor = System.Drawing.Color.Green
        Me.TxtSumaAbonos.Location = New System.Drawing.Point(765, 190)
        Me.TxtSumaAbonos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSumaAbonos.Name = "TxtSumaAbonos"
        Me.TxtSumaAbonos.ReadOnly = True
        Me.TxtSumaAbonos.Size = New System.Drawing.Size(132, 22)
        Me.TxtSumaAbonos.TabIndex = 125
        Me.TxtSumaAbonos.TabStop = False
        '
        'TxtTotCuotaAnual
        '
        Me.TxtTotCuotaAnual.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtTotCuotaAnual.ForeColor = System.Drawing.Color.Navy
        Me.TxtTotCuotaAnual.Location = New System.Drawing.Point(153, 66)
        Me.TxtTotCuotaAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotCuotaAnual.Name = "TxtTotCuotaAnual"
        Me.TxtTotCuotaAnual.ReadOnly = True
        Me.TxtTotCuotaAnual.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotCuotaAnual.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Total Cuota Anual:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Meses Adeudados:"
        '
        'TxtMesesDeuda
        '
        Me.TxtMesesDeuda.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtMesesDeuda.ForeColor = System.Drawing.Color.Navy
        Me.TxtMesesDeuda.Location = New System.Drawing.Point(153, 98)
        Me.TxtMesesDeuda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMesesDeuda.Name = "TxtMesesDeuda"
        Me.TxtMesesDeuda.ReadOnly = True
        Me.TxtMesesDeuda.Size = New System.Drawing.Size(132, 22)
        Me.TxtMesesDeuda.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Total Cuotas:"
        '
        'TxtTotCuota
        '
        Me.TxtTotCuota.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtTotCuota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtTotCuota.Location = New System.Drawing.Point(436, 32)
        Me.TxtTotCuota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotCuota.Name = "TxtTotCuota"
        Me.TxtTotCuota.ReadOnly = True
        Me.TxtTotCuota.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotCuota.TabIndex = 117
        '
        'TxtAcuenta
        '
        Me.TxtAcuenta.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtAcuenta.ForeColor = System.Drawing.Color.Green
        Me.TxtAcuenta.Location = New System.Drawing.Point(765, 32)
        Me.TxtAcuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAcuenta.Name = "TxtAcuenta"
        Me.TxtAcuenta.ReadOnly = True
        Me.TxtAcuenta.Size = New System.Drawing.Size(132, 22)
        Me.TxtAcuenta.TabIndex = 108
        Me.TxtAcuenta.TabStop = False
        '
        'TxtTotalcargo
        '
        Me.TxtTotalcargo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtTotalcargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtTotalcargo.Location = New System.Drawing.Point(436, 190)
        Me.TxtTotalcargo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalcargo.Name = "TxtTotalcargo"
        Me.TxtTotalcargo.ReadOnly = True
        Me.TxtTotalcargo.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotalcargo.TabIndex = 107
        '
        'TxtDeuda
        '
        Me.TxtDeuda.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtDeuda.ForeColor = System.Drawing.Color.Navy
        Me.TxtDeuda.Location = New System.Drawing.Point(153, 130)
        Me.TxtDeuda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDeuda.Name = "TxtDeuda"
        Me.TxtDeuda.ReadOnly = True
        Me.TxtDeuda.Size = New System.Drawing.Size(132, 22)
        Me.TxtDeuda.TabIndex = 106
        '
        'TxtTotalrecibo
        '
        Me.TxtTotalrecibo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtTotalrecibo.ForeColor = System.Drawing.Color.Navy
        Me.TxtTotalrecibo.Location = New System.Drawing.Point(153, 190)
        Me.TxtTotalrecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalrecibo.Name = "TxtTotalrecibo"
        Me.TxtTotalrecibo.ReadOnly = True
        Me.TxtTotalrecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotalrecibo.TabIndex = 102
        '
        'TxtValorDev
        '
        Me.TxtValorDev.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtValorDev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtValorDev.Location = New System.Drawing.Point(436, 128)
        Me.TxtValorDev.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorDev.Name = "TxtValorDev"
        Me.TxtValorDev.Size = New System.Drawing.Size(132, 22)
        Me.TxtValorDev.TabIndex = 101
        '
        'TxtRecDev
        '
        Me.TxtRecDev.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtRecDev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtRecDev.Location = New System.Drawing.Point(436, 96)
        Me.TxtRecDev.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecDev.Name = "TxtRecDev"
        Me.TxtRecDev.ReadOnly = True
        Me.TxtRecDev.Size = New System.Drawing.Size(132, 22)
        Me.TxtRecDev.TabIndex = 100
        '
        'TxtRestoBenef
        '
        Me.TxtRestoBenef.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtRestoBenef.ForeColor = System.Drawing.Color.Green
        Me.TxtRestoBenef.Location = New System.Drawing.Point(765, 128)
        Me.TxtRestoBenef.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRestoBenef.Name = "TxtRestoBenef"
        Me.TxtRestoBenef.ReadOnly = True
        Me.TxtRestoBenef.Size = New System.Drawing.Size(132, 22)
        Me.TxtRestoBenef.TabIndex = 99
        Me.TxtRestoBenef.TabStop = False
        '
        'TxtBenefAbonado
        '
        Me.TxtBenefAbonado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtBenefAbonado.ForeColor = System.Drawing.Color.Green
        Me.TxtBenefAbonado.Location = New System.Drawing.Point(765, 96)
        Me.TxtBenefAbonado.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBenefAbonado.Name = "TxtBenefAbonado"
        Me.TxtBenefAbonado.ReadOnly = True
        Me.TxtBenefAbonado.Size = New System.Drawing.Size(132, 22)
        Me.TxtBenefAbonado.TabIndex = 98
        Me.TxtBenefAbonado.TabStop = False
        '
        'TxtBeneficios
        '
        Me.TxtBeneficios.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtBeneficios.ForeColor = System.Drawing.Color.Green
        Me.TxtBeneficios.Location = New System.Drawing.Point(765, 64)
        Me.TxtBeneficios.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBeneficios.Name = "TxtBeneficios"
        Me.TxtBeneficios.ReadOnly = True
        Me.TxtBeneficios.Size = New System.Drawing.Size(132, 22)
        Me.TxtBeneficios.TabIndex = 97
        Me.TxtBeneficios.TabStop = False
        '
        'TxtCargos
        '
        Me.TxtCargos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtCargos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtCargos.Location = New System.Drawing.Point(436, 64)
        Me.TxtCargos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCargos.Name = "TxtCargos"
        Me.TxtCargos.ReadOnly = True
        Me.TxtCargos.Size = New System.Drawing.Size(132, 22)
        Me.TxtCargos.TabIndex = 95
        '
        'TxtPago
        '
        Me.TxtPago.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtPago.ForeColor = System.Drawing.Color.Navy
        Me.TxtPago.Location = New System.Drawing.Point(153, 34)
        Me.TxtPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.ReadOnly = True
        Me.TxtPago.Size = New System.Drawing.Size(79, 22)
        Me.TxtPago.TabIndex = 92
        '
        'TxtAbonoBenefRecibo
        '
        Me.TxtAbonoBenefRecibo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtAbonoBenefRecibo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtAbonoBenefRecibo.Location = New System.Drawing.Point(792, 472)
        Me.TxtAbonoBenefRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAbonoBenefRecibo.Name = "TxtAbonoBenefRecibo"
        Me.TxtAbonoBenefRecibo.Size = New System.Drawing.Size(132, 22)
        Me.TxtAbonoBenefRecibo.TabIndex = 172
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(667, 476)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Abono beneficios:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(578, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "CUENTA:"
        '
        'TxtCUENTA
        '
        Me.TxtCUENTA.Enabled = False
        Me.TxtCUENTA.Location = New System.Drawing.Point(658, 101)
        Me.TxtCUENTA.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCUENTA.Name = "TxtCUENTA"
        Me.TxtCUENTA.Size = New System.Drawing.Size(287, 22)
        Me.TxtCUENTA.TabIndex = 168
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 476)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Forma de pago:"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(499, 764)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 42)
        Me.Button3.TabIndex = 166
        Me.Button3.Text = "Guardar Registro"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(242, 764)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 42)
        Me.Button2.TabIndex = 165
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(179, 441)
        Me.DTPFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(131, 22)
        Me.DTPFecha.TabIndex = 164
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(772, 764)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 42)
        Me.Button1.TabIndex = 163
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtIdRemesa
        '
        Me.TxtIdRemesa.Enabled = False
        Me.TxtIdRemesa.Location = New System.Drawing.Point(155, 101)
        Me.TxtIdRemesa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRemesa.Name = "TxtIdRemesa"
        Me.TxtIdRemesa.Size = New System.Drawing.Size(61, 22)
        Me.TxtIdRemesa.TabIndex = 162
        '
        'TxtTitular
        '
        Me.TxtTitular.Enabled = False
        Me.TxtTitular.Location = New System.Drawing.Point(658, 69)
        Me.TxtTitular.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTitular.Name = "TxtTitular"
        Me.TxtTitular.Size = New System.Drawing.Size(287, 22)
        Me.TxtTitular.TabIndex = 161
        '
        'TxtTipoCuota
        '
        Me.TxtTipoCuota.Enabled = False
        Me.TxtTipoCuota.Location = New System.Drawing.Point(359, 69)
        Me.TxtTipoCuota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTipoCuota.Name = "TxtTipoCuota"
        Me.TxtTipoCuota.Size = New System.Drawing.Size(157, 22)
        Me.TxtTipoCuota.TabIndex = 160
        '
        'TxtComision
        '
        Me.TxtComision.Enabled = False
        Me.TxtComision.Location = New System.Drawing.Point(155, 69)
        Me.TxtComision.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtComision.Name = "TxtComision"
        Me.TxtComision.Size = New System.Drawing.Size(61, 22)
        Me.TxtComision.TabIndex = 158
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Enabled = False
        Me.TxtApellidos.Location = New System.Drawing.Point(658, 37)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(287, 22)
        Me.TxtApellidos.TabIndex = 157
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(359, 37)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(157, 22)
        Me.TxtNombre.TabIndex = 156
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(154, 37)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(63, 22)
        Me.TxtCodigo.TabIndex = 155
        '
        'TxtNumMeses
        '
        Me.TxtNumMeses.AcceptsReturn = True
        Me.TxtNumMeses.Location = New System.Drawing.Point(178, 529)
        Me.TxtNumMeses.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumMeses.Name = "TxtNumMeses"
        Me.TxtNumMeses.Size = New System.Drawing.Size(132, 22)
        Me.TxtNumMeses.TabIndex = 159
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(178, 501)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(117, 21)
        Me.RadioButton2.TabIndex = 153
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Transferencia"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(179, 473)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(91, 21)
        Me.RadioButton1.TabIndex = 152
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Caja Falla"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RemesasBindingSource
        '
        Me.RemesasBindingSource.DataMember = "remesas"
        Me.RemesasBindingSource.DataSource = Me.DbCensos
        '
        'RemesasTableAdapter
        '
        Me.RemesasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.letradniTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Me.RemesasTableAdapter
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'RemesasDataGridView
        '
        Me.RemesasDataGridView.AutoGenerateColumns = False
        Me.RemesasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemesasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3})
        Me.RemesasDataGridView.DataSource = Me.RemesasBindingSource
        Me.RemesasDataGridView.Location = New System.Drawing.Point(163, 655)
        Me.RemesasDataGridView.Name = "RemesasDataGridView"
        Me.RemesasDataGridView.RowHeadersWidth = 51
        Me.RemesasDataGridView.RowTemplate.Height = 24
        Me.RemesasDataGridView.Size = New System.Drawing.Size(300, 54)
        Me.RemesasDataGridView.TabIndex = 190
        Me.RemesasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdRemesa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdRemesa"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaCreacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaCreacion"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaCargo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaCargo"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "FijarDatos"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "FijarDatos"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TITULAR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TITULAR"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "APELLIDOS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "APELLIDOS"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TIPO_CUOTA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TIPO_CUOTA"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ImporteCuota"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ImporteCuota"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MesesAdeudo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "MesesAdeudo"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "BENEFICIOS"
        Me.DataGridViewTextBoxColumn11.HeaderText = "BENEFICIOS"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DEV_BENEFI"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DEV_BENEFI"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TotalCuotaAnual"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TotalCuotaAnual"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "OtrosCargos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "OtrosCargos"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "EntregasAcuenta"
        Me.DataGridViewTextBoxColumn15.HeaderText = "EntregasAcuenta"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CtaBanco"
        Me.DataGridViewTextBoxColumn16.HeaderText = "CtaBanco"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "RestoBeneficio"
        Me.DataGridViewTextBoxColumn17.HeaderText = "RestoBeneficio"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PagosPdtes"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PagosPdtes"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Recdev"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Recdev"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "valordev"
        Me.DataGridViewTextBoxColumn20.HeaderText = "valordev"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "totalCuota"
        Me.DataGridViewTextBoxColumn21.HeaderText = "totalCuota"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "totalCargo"
        Me.DataGridViewTextBoxColumn22.HeaderText = "totalCargo"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "abonobenefi"
        Me.DataGridViewTextBoxColumn23.HeaderText = "abonobenefi"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "SumaOtrosCargos"
        Me.DataGridViewTextBoxColumn24.HeaderText = "SumaOtrosCargos"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 125
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "totalrecibo"
        Me.DataGridViewTextBoxColumn25.HeaderText = "totalrecibo"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 125
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "devolucion"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "devolucion"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 125
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "bloqueado"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "bloqueado"
        Me.DataGridViewCheckBoxColumn3.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 125
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DbCensos
        '
        'FalleroDataGridView
        '
        Me.FalleroDataGridView.AutoGenerateColumns = False
        Me.FalleroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FalleroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67})
        Me.FalleroDataGridView.DataSource = Me.FalleroBindingSource
        Me.FalleroDataGridView.Location = New System.Drawing.Point(466, 653)
        Me.FalleroDataGridView.Name = "FalleroDataGridView"
        Me.FalleroDataGridView.RowHeadersWidth = 51
        Me.FalleroDataGridView.RowTemplate.Height = 24
        Me.FalleroDataGridView.Size = New System.Drawing.Size(300, 56)
        Me.FalleroDataGridView.TabIndex = 190
        Me.FalleroDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "FALLERO_CODIGO"
        Me.DataGridViewTextBoxColumn26.HeaderText = "FALLERO_CODIGO"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "COD_JCF"
        Me.DataGridViewTextBoxColumn27.HeaderText = "COD_JCF"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 125
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "APELLIDOS"
        Me.DataGridViewTextBoxColumn28.HeaderText = "APELLIDOS"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn29.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn30.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "SEXO"
        Me.DataGridViewTextBoxColumn31.HeaderText = "SEXO"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 125
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "FECHA_NAC"
        Me.DataGridViewTextBoxColumn32.HeaderText = "FECHA_NAC"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 125
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxColumn33.HeaderText = "DIRECCION"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "POBLACION"
        Me.DataGridViewTextBoxColumn34.HeaderText = "POBLACION"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 125
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "COD_POSTAL"
        Me.DataGridViewTextBoxColumn35.HeaderText = "COD_POSTAL"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 125
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "TELEFONO"
        Me.DataGridViewTextBoxColumn36.HeaderText = "TELEFONO"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 125
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 125
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ANO_CEN"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ANO_CEN"
        Me.DataGridViewTextBoxColumn38.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 125
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "TIPFAL"
        Me.DataGridViewTextBoxColumn39.HeaderText = "TIPFAL"
        Me.DataGridViewTextBoxColumn39.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 125
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn40.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn40.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 125
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "BAJA"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "BAJA"
        Me.DataGridViewCheckBoxColumn4.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "ULTCAR"
        Me.DataGridViewTextBoxColumn41.HeaderText = "ULTCAR"
        Me.DataGridViewTextBoxColumn41.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 125
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "COD_REC"
        Me.DataGridViewTextBoxColumn42.HeaderText = "COD_REC"
        Me.DataGridViewTextBoxColumn42.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 125
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "ANO_REC"
        Me.DataGridViewTextBoxColumn43.HeaderText = "ANO_REC"
        Me.DataGridViewTextBoxColumn43.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 125
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "FAL_REC"
        Me.DataGridViewTextBoxColumn44.HeaderText = "FAL_REC"
        Me.DataGridViewTextBoxColumn44.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 125
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "FAL_CEN"
        Me.DataGridViewTextBoxColumn45.HeaderText = "FAL_CEN"
        Me.DataGridViewTextBoxColumn45.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 125
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "REC_FAL"
        Me.DataGridViewTextBoxColumn46.HeaderText = "REC_FAL"
        Me.DataGridViewTextBoxColumn46.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 125
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn47.HeaderText = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn47.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 125
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "BANCO"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "BANCO"
        Me.DataGridViewCheckBoxColumn5.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "TITULAR"
        Me.DataGridViewTextBoxColumn48.HeaderText = "TITULAR"
        Me.DataGridViewTextBoxColumn48.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.Width = 125
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "CUENTA"
        Me.DataGridViewTextBoxColumn49.HeaderText = "CUENTA"
        Me.DataGridViewTextBoxColumn49.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 125
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "LOTERIA"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "LOTERIA"
        Me.DataGridViewCheckBoxColumn6.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "BENEFICIOS"
        Me.DataGridViewTextBoxColumn50.HeaderText = "BENEFICIOS"
        Me.DataGridViewTextBoxColumn50.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 125
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "DEV_BENEFI"
        Me.DataGridViewTextBoxColumn51.HeaderText = "DEV_BENEFI"
        Me.DataGridViewTextBoxColumn51.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Width = 125
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "RECDEV"
        Me.DataGridViewTextBoxColumn52.HeaderText = "RECDEV"
        Me.DataGridViewTextBoxColumn52.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Width = 125
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "OtrosCargos"
        Me.DataGridViewTextBoxColumn53.HeaderText = "OtrosCargos"
        Me.DataGridViewTextBoxColumn53.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 125
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "EntregasAcuenta"
        Me.DataGridViewTextBoxColumn54.HeaderText = "EntregasAcuenta"
        Me.DataGridViewTextBoxColumn54.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 125
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "Id_cuota"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Id_cuota"
        Me.DataGridViewTextBoxColumn55.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Width = 125
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "DESCRIP_CUOTA"
        Me.DataGridViewTextBoxColumn56.HeaderText = "DESCRIP_CUOTA"
        Me.DataGridViewTextBoxColumn56.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.Width = 125
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "VALOR_CUOTA"
        Me.DataGridViewTextBoxColumn57.HeaderText = "VALOR_CUOTA"
        Me.DataGridViewTextBoxColumn57.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.Width = 125
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "TIPO_CUOTA"
        Me.DataGridViewTextBoxColumn58.HeaderText = "TIPO_CUOTA"
        Me.DataGridViewTextBoxColumn58.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.Width = 125
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "Id_DESCUENTO"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Id_DESCUENTO"
        Me.DataGridViewTextBoxColumn59.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.Width = 125
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "DESCRIP_DESCUENTO"
        Me.DataGridViewTextBoxColumn60.HeaderText = "DESCRIP_DESCUENTO"
        Me.DataGridViewTextBoxColumn60.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.Width = 125
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "DESCUENTO"
        Me.DataGridViewTextBoxColumn61.HeaderText = "DESCUENTO"
        Me.DataGridViewTextBoxColumn61.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.Width = 125
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "PAGO"
        Me.DataGridViewTextBoxColumn62.HeaderText = "PAGO"
        Me.DataGridViewTextBoxColumn62.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.Width = 125
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "NUM_CUOTAS"
        Me.DataGridViewTextBoxColumn63.HeaderText = "NUM_CUOTAS"
        Me.DataGridViewTextBoxColumn63.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.Width = 125
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "NUM_PAGOS"
        Me.DataGridViewTextBoxColumn64.HeaderText = "NUM_PAGOS"
        Me.DataGridViewTextBoxColumn64.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.Width = 125
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "DEUDA"
        Me.DataGridViewTextBoxColumn65.HeaderText = "DEUDA"
        Me.DataGridViewTextBoxColumn65.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.Width = 125
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "TOTAL_CUOTA"
        Me.DataGridViewTextBoxColumn66.HeaderText = "TOTAL_CUOTA"
        Me.DataGridViewTextBoxColumn66.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.Width = 125
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "A_CUENTA"
        Me.DataGridViewTextBoxColumn67.HeaderText = "A_CUENTA"
        Me.DataGridViewTextBoxColumn67.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.Width = 125
        '
        'FrmAddPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(972, 925)
        Me.Controls.Add(Me.FalleroDataGridView)
        Me.Controls.Add(Me.RemesasDataGridView)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtSumaAbonoRecibo)
        Me.Controls.Add(Me.TxtSumaCargosRecibo)
        Me.Controls.Add(Me.TxtTotalFinalrecibo)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Me.TxtAcuentaRecibo)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCuotasRecibo)
        Me.Controls.Add(Me.TxtValorDevRecibo)
        Me.Controls.Add(Me.TxtRecDevRecibo)
        Me.Controls.Add(Me.TxtOtrosCargosRecibo)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtAbonoBenefRecibo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCUENTA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtIdRemesa)
        Me.Controls.Add(Me.TxtTitular)
        Me.Controls.Add(Me.TxtTipoCuota)
        Me.Controls.Add(Me.TxtComision)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TxtNumMeses)
        Me.Controls.Add(Id_RemesaLabel)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(TIPO_CUOTALabel)
        Me.Controls.Add(ComisiónLabel)
        Me.Controls.Add(APELLILabel)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(TITULARLabel)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(MESESLabel)
        Me.HelpProvider1.SetHelpKeyword(Me, "51")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmAddPago"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAddPago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents TxtSumaAbonoRecibo As TextBox
    Friend WithEvents TxtSumaCargosRecibo As TextBox
    Friend WithEvents TxtTotalFinalrecibo As TextBox
    Friend WithEvents TxtAcuentaRecibo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCuotasRecibo As TextBox
    Friend WithEvents TxtValorDevRecibo As TextBox
    Friend WithEvents TxtRecDevRecibo As TextBox
    Friend WithEvents TxtOtrosCargosRecibo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNumCuotas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtSumaAbonos As TextBox
    Friend WithEvents TxtTotCuotaAnual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMesesDeuda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotCuota As TextBox
    Friend WithEvents TxtAcuenta As TextBox
    Friend WithEvents TxtTotalcargo As TextBox
    Friend WithEvents TxtDeuda As TextBox
    Friend WithEvents TxtTotalrecibo As TextBox
    Friend WithEvents TxtValorDev As TextBox
    Friend WithEvents TxtRecDev As TextBox
    Friend WithEvents TxtRestoBenef As TextBox
    Friend WithEvents TxtBenefAbonado As TextBox
    Friend WithEvents TxtBeneficios As TextBox
    Friend WithEvents TxtCargos As TextBox
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents TxtAbonoBenefRecibo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCUENTA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtIdRemesa As TextBox
    Friend WithEvents TxtTitular As TextBox
    Friend WithEvents TxtTipoCuota As TextBox
    Friend WithEvents TxtComision As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtNumMeses As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents RemesasBindingSource As BindingSource
    Friend WithEvents RemesasTableAdapter As DbCensosTableAdapters.remesasTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents RemesasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
