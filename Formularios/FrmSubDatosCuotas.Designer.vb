<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubDatosCuotas
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
        Dim A_CUENTALabel As System.Windows.Forms.Label
        Dim ENTREGAS_A_CUENTALabel As System.Windows.Forms.Label
        Dim OTROS_CARGOSLabel As System.Windows.Forms.Label
        Dim RECDEVLabel As System.Windows.Forms.Label
        Dim DEV_BENEFILabel As System.Windows.Forms.Label
        Dim BENEFICIOSLabel As System.Windows.Forms.Label
        Dim LOTERIALabel As System.Windows.Forms.Label
        Dim CUENTALabel As System.Windows.Forms.Label
        Dim TITULARLabel As System.Windows.Forms.Label
        Dim BANCOLabel As System.Windows.Forms.Label
        Dim PAGOS_PDTESLabel As System.Windows.Forms.Label
        Dim DESCUENTOLabel1 As System.Windows.Forms.Label
        Dim Id_DESCUENTOLabel1 As System.Windows.Forms.Label
        Dim TOTAL_CUOTALabel As System.Windows.Forms.Label
        Dim DEUDALabel As System.Windows.Forms.Label
        Dim NUM_PAGOSLabel As System.Windows.Forms.Label
        Dim PAGOLabel As System.Windows.Forms.Label
        Dim TIPO_CUOTALabel As System.Windows.Forms.Label
        Dim Id_cuotaLabel As System.Windows.Forms.Label
        Dim VALOR_CUOTALabel As System.Windows.Forms.Label
        Dim Id_cuotaLabel1 As System.Windows.Forms.Label
        Dim TIPFALLabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim FALLERO_CODIGOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubDatosCuotas))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LOTERIACheckBox = New System.Windows.Forms.CheckBox()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.A_CUENTATextBox = New System.Windows.Forms.TextBox()
        Me.ENTREGAS_A_CUENTATextBox = New System.Windows.Forms.TextBox()
        Me.OTROS_CARGOSTextBox = New System.Windows.Forms.TextBox()
        Me.RECDEVTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RESTOTxt = New System.Windows.Forms.TextBox()
        Me.DEV_BENEFITextBox = New System.Windows.Forms.TextBox()
        Me.BENEFICIOSTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MiCuentaTxt = New System.Windows.Forms.TextBox()
        Me.CUENTATextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BANCOCheckBox = New System.Windows.Forms.CheckBox()
        Me.TITULARTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUM_PAGOSTextBox = New System.Windows.Forms.TextBox()
        Me.Id_CUOTAComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoDeCuotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_DESCUENTOComboBox = New System.Windows.Forms.ComboBox()
        Me.DescuentosDeLaCuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumcuotasmesTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUM_CUOTASTextBox = New System.Windows.Forms.TextBox()
        Me.DESCUENTOTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIP_DESCUENTOTextBox = New System.Windows.Forms.TextBox()
        Me.Id_DESCUENTOTextBox = New System.Windows.Forms.TextBox()
        Me.TOTAL_CUOTATextBox = New System.Windows.Forms.TextBox()
        Me.DEUDATextBox = New System.Windows.Forms.TextBox()
        Me.PAGOTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_CUOTAComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_cuotaTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIP_CUOTATextBox = New System.Windows.Forms.TextBox()
        Me.VALOR_CUOTATextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TIPFALTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.Tipo_de_cuotasTableAdapter = New AppGestion.DbCensosTableAdapters.tipo_de_cuotasTableAdapter()
        Me.Descuentos_de_la_cuotaTableAdapter = New AppGestion.DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnVerPagos = New System.Windows.Forms.Button()
        Me.BtnAddPago = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.EjercicioTableAdapter = New AppGestion.DbCensosTableAdapters.ejercicioTableAdapter()
        A_CUENTALabel = New System.Windows.Forms.Label()
        ENTREGAS_A_CUENTALabel = New System.Windows.Forms.Label()
        OTROS_CARGOSLabel = New System.Windows.Forms.Label()
        RECDEVLabel = New System.Windows.Forms.Label()
        DEV_BENEFILabel = New System.Windows.Forms.Label()
        BENEFICIOSLabel = New System.Windows.Forms.Label()
        LOTERIALabel = New System.Windows.Forms.Label()
        CUENTALabel = New System.Windows.Forms.Label()
        TITULARLabel = New System.Windows.Forms.Label()
        BANCOLabel = New System.Windows.Forms.Label()
        PAGOS_PDTESLabel = New System.Windows.Forms.Label()
        DESCUENTOLabel1 = New System.Windows.Forms.Label()
        Id_DESCUENTOLabel1 = New System.Windows.Forms.Label()
        TOTAL_CUOTALabel = New System.Windows.Forms.Label()
        DEUDALabel = New System.Windows.Forms.Label()
        NUM_PAGOSLabel = New System.Windows.Forms.Label()
        PAGOLabel = New System.Windows.Forms.Label()
        TIPO_CUOTALabel = New System.Windows.Forms.Label()
        Id_cuotaLabel = New System.Windows.Forms.Label()
        VALOR_CUOTALabel = New System.Windows.Forms.Label()
        Id_cuotaLabel1 = New System.Windows.Forms.Label()
        TIPFALLabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        FALLERO_CODIGOLabel = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A_CUENTALabel
        '
        A_CUENTALabel.AutoSize = True
        A_CUENTALabel.Location = New System.Drawing.Point(243, 151)
        A_CUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        A_CUENTALabel.Name = "A_CUENTALabel"
        A_CUENTALabel.Size = New System.Drawing.Size(117, 17)
        A_CUENTALabel.TabIndex = 53
        A_CUENTALabel.Text = "Acumulado a cta:"
        '
        'ENTREGAS_A_CUENTALabel
        '
        ENTREGAS_A_CUENTALabel.AutoSize = True
        ENTREGAS_A_CUENTALabel.Location = New System.Drawing.Point(209, 119)
        ENTREGAS_A_CUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ENTREGAS_A_CUENTALabel.Name = "ENTREGAS_A_CUENTALabel"
        ENTREGAS_A_CUENTALabel.Size = New System.Drawing.Size(148, 17)
        ENTREGAS_A_CUENTALabel.TabIndex = 52
        ENTREGAS_A_CUENTALabel.Text = "INGRESO A CUENTA:"
        '
        'OTROS_CARGOSLabel
        '
        OTROS_CARGOSLabel.AutoSize = True
        OTROS_CARGOSLabel.Location = New System.Drawing.Point(235, 92)
        OTROS_CARGOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OTROS_CARGOSLabel.Name = "OTROS_CARGOSLabel"
        OTROS_CARGOSLabel.Size = New System.Drawing.Size(125, 17)
        OTROS_CARGOSLabel.TabIndex = 51
        OTROS_CARGOSLabel.Text = "OTROS CARGOS:"
        '
        'RECDEVLabel
        '
        RECDEVLabel.AutoSize = True
        RECDEVLabel.Location = New System.Drawing.Point(291, 56)
        RECDEVLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RECDEVLabel.Name = "RECDEVLabel"
        RECDEVLabel.Size = New System.Drawing.Size(68, 17)
        RECDEVLabel.TabIndex = 50
        RECDEVLabel.Text = "RECDEV:"
        '
        'DEV_BENEFILabel
        '
        DEV_BENEFILabel.AutoSize = True
        DEV_BENEFILabel.Location = New System.Drawing.Point(11, 115)
        DEV_BENEFILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DEV_BENEFILabel.Name = "DEV_BENEFILabel"
        DEV_BENEFILabel.Size = New System.Drawing.Size(92, 17)
        DEV_BENEFILabel.TabIndex = 47
        DEV_BENEFILabel.Text = "DEV BENEFI:"
        '
        'BENEFICIOSLabel
        '
        BENEFICIOSLabel.AutoSize = True
        BENEFICIOSLabel.Location = New System.Drawing.Point(11, 83)
        BENEFICIOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BENEFICIOSLabel.Name = "BENEFICIOSLabel"
        BENEFICIOSLabel.Size = New System.Drawing.Size(92, 17)
        BENEFICIOSLabel.TabIndex = 46
        BENEFICIOSLabel.Text = "BENEFICIOS:"
        '
        'LOTERIALabel
        '
        LOTERIALabel.AutoSize = True
        LOTERIALabel.Location = New System.Drawing.Point(34, 48)
        LOTERIALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LOTERIALabel.Name = "LOTERIALabel"
        LOTERIALabel.Size = New System.Drawing.Size(71, 17)
        LOTERIALabel.TabIndex = 45
        LOTERIALabel.Text = "LOTERIA:"
        '
        'CUENTALabel
        '
        CUENTALabel.AutoSize = True
        CUENTALabel.Location = New System.Drawing.Point(9, 107)
        CUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CUENTALabel.Name = "CUENTALabel"
        CUENTALabel.Size = New System.Drawing.Size(68, 17)
        CUENTALabel.TabIndex = 44
        CUENTALabel.Text = "CUENTA:"
        '
        'TITULARLabel
        '
        TITULARLabel.AutoSize = True
        TITULARLabel.Location = New System.Drawing.Point(10, 75)
        TITULARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TITULARLabel.Name = "TITULARLabel"
        TITULARLabel.Size = New System.Drawing.Size(70, 17)
        TITULARLabel.TabIndex = 43
        TITULARLabel.Text = "TITULAR:"
        '
        'BANCOLabel
        '
        BANCOLabel.AutoSize = True
        BANCOLabel.Location = New System.Drawing.Point(18, 40)
        BANCOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BANCOLabel.Name = "BANCOLabel"
        BANCOLabel.Size = New System.Drawing.Size(60, 17)
        BANCOLabel.TabIndex = 42
        BANCOLabel.Text = "BANCO:"
        '
        'PAGOS_PDTESLabel
        '
        PAGOS_PDTESLabel.AutoSize = True
        PAGOS_PDTESLabel.Location = New System.Drawing.Point(33, 268)
        PAGOS_PDTESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PAGOS_PDTESLabel.Name = "PAGOS_PDTESLabel"
        PAGOS_PDTESLabel.Size = New System.Drawing.Size(115, 17)
        PAGOS_PDTESLabel.TabIndex = 37
        PAGOS_PDTESLabel.Text = "Nº Cuotas Pdtes:"
        '
        'DESCUENTOLabel1
        '
        DESCUENTOLabel1.AutoSize = True
        DESCUENTOLabel1.Location = New System.Drawing.Point(50, 139)
        DESCUENTOLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DESCUENTOLabel1.Name = "DESCUENTOLabel1"
        DESCUENTOLabel1.Size = New System.Drawing.Size(98, 17)
        DESCUENTOLabel1.TabIndex = 36
        DESCUENTOLabel1.Text = "DESCUENTO:"
        '
        'Id_DESCUENTOLabel1
        '
        Id_DESCUENTOLabel1.AutoSize = True
        Id_DESCUENTOLabel1.Location = New System.Drawing.Point(44, 107)
        Id_DESCUENTOLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_DESCUENTOLabel1.Name = "Id_DESCUENTOLabel1"
        Id_DESCUENTOLabel1.Size = New System.Drawing.Size(49, 17)
        Id_DESCUENTOLabel1.TabIndex = 34
        Id_DESCUENTOLabel1.Text = "Id Dto:"
        '
        'TOTAL_CUOTALabel
        '
        TOTAL_CUOTALabel.AutoSize = True
        TOTAL_CUOTALabel.Location = New System.Drawing.Point(33, 349)
        TOTAL_CUOTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TOTAL_CUOTALabel.Name = "TOTAL_CUOTALabel"
        TOTAL_CUOTALabel.Size = New System.Drawing.Size(110, 17)
        TOTAL_CUOTALabel.TabIndex = 30
        TOTAL_CUOTALabel.Text = "TOTAL CUOTA:"
        '
        'DEUDALabel
        '
        DEUDALabel.AutoSize = True
        DEUDALabel.Location = New System.Drawing.Point(83, 381)
        DEUDALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DEUDALabel.Name = "DEUDALabel"
        DEUDALabel.Size = New System.Drawing.Size(60, 17)
        DEUDALabel.TabIndex = 28
        DEUDALabel.Text = "DEUDA:"
        '
        'NUM_PAGOSLabel
        '
        NUM_PAGOSLabel.AutoSize = True
        NUM_PAGOSLabel.Location = New System.Drawing.Point(44, 241)
        NUM_PAGOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NUM_PAGOSLabel.Name = "NUM_PAGOSLabel"
        NUM_PAGOSLabel.Size = New System.Drawing.Size(104, 17)
        NUM_PAGOSLabel.TabIndex = 26
        NUM_PAGOSLabel.Text = "Nº Cuotas Año:"
        '
        'PAGOLabel
        '
        PAGOLabel.AutoSize = True
        PAGOLabel.Location = New System.Drawing.Point(48, 209)
        PAGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PAGOLabel.Name = "PAGOLabel"
        PAGOLabel.Size = New System.Drawing.Size(100, 17)
        PAGOLabel.TabIndex = 25
        PAGOLabel.Text = "Importe Cuota:"
        '
        'TIPO_CUOTALabel
        '
        TIPO_CUOTALabel.AutoSize = True
        TIPO_CUOTALabel.Location = New System.Drawing.Point(52, 176)
        TIPO_CUOTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIPO_CUOTALabel.Name = "TIPO_CUOTALabel"
        TIPO_CUOTALabel.Size = New System.Drawing.Size(96, 17)
        TIPO_CUOTALabel.TabIndex = 20
        TIPO_CUOTALabel.Text = "TIPO CUOTA:"
        '
        'Id_cuotaLabel
        '
        Id_cuotaLabel.AutoSize = True
        Id_cuotaLabel.Location = New System.Drawing.Point(32, 44)
        Id_cuotaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_cuotaLabel.Name = "Id_cuotaLabel"
        Id_cuotaLabel.Size = New System.Drawing.Size(64, 17)
        Id_cuotaLabel.TabIndex = 17
        Id_cuotaLabel.Text = "Id Cuota:"
        '
        'VALOR_CUOTALabel
        '
        VALOR_CUOTALabel.AutoSize = True
        VALOR_CUOTALabel.Location = New System.Drawing.Point(41, 75)
        VALOR_CUOTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VALOR_CUOTALabel.Name = "VALOR_CUOTALabel"
        VALOR_CUOTALabel.Size = New System.Drawing.Size(100, 17)
        VALOR_CUOTALabel.TabIndex = 11
        VALOR_CUOTALabel.Text = "CUOTA BASE:"
        '
        'Id_cuotaLabel1
        '
        Id_cuotaLabel1.AutoSize = True
        Id_cuotaLabel1.Location = New System.Drawing.Point(153, 71)
        Id_cuotaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_cuotaLabel1.Name = "Id_cuotaLabel1"
        Id_cuotaLabel1.Size = New System.Drawing.Size(0, 17)
        Id_cuotaLabel1.TabIndex = 9
        '
        'TIPFALLabel
        '
        TIPFALLabel.AutoSize = True
        TIPFALLabel.Location = New System.Drawing.Point(819, 35)
        TIPFALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIPFALLabel.Name = "TIPFALLabel"
        TIPFALLabel.Size = New System.Drawing.Size(69, 17)
        TIPFALLabel.TabIndex = 59
        TIPFALLabel.Text = "Comisión:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(459, 36)
        APELLIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(88, 17)
        APELLIDOSLabel.TabIndex = 5
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(234, 36)
        NOMBRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(72, 17)
        NOMBRELabel.TabIndex = 3
        NOMBRELabel.Text = "NOMBRE:"
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(9, 36)
        FALLERO_CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(134, 17)
        FALLERO_CODIGOLabel.TabIndex = 1
        FALLERO_CODIGOLabel.Text = "FALLERO CODIGO:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LOTERIACheckBox)
        Me.GroupBox5.Controls.Add(A_CUENTALabel)
        Me.GroupBox5.Controls.Add(Me.A_CUENTATextBox)
        Me.GroupBox5.Controls.Add(ENTREGAS_A_CUENTALabel)
        Me.GroupBox5.Controls.Add(Me.ENTREGAS_A_CUENTATextBox)
        Me.GroupBox5.Controls.Add(OTROS_CARGOSLabel)
        Me.GroupBox5.Controls.Add(Me.OTROS_CARGOSTextBox)
        Me.GroupBox5.Controls.Add(RECDEVLabel)
        Me.GroupBox5.Controls.Add(Me.RECDEVTextBox)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.RESTOTxt)
        Me.GroupBox5.Controls.Add(DEV_BENEFILabel)
        Me.GroupBox5.Controls.Add(Me.DEV_BENEFITextBox)
        Me.GroupBox5.Controls.Add(BENEFICIOSLabel)
        Me.GroupBox5.Controls.Add(Me.BENEFICIOSTextBox)
        Me.GroupBox5.Controls.Add(LOTERIALabel)
        Me.GroupBox5.Location = New System.Drawing.Point(449, 350)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(523, 198)
        Me.GroupBox5.TabIndex = 78
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lotería y otros"
        '
        'LOTERIACheckBox
        '
        Me.LOTERIACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "LOTERIA", True))
        Me.LOTERIACheckBox.Enabled = False
        Me.LOTERIACheckBox.Location = New System.Drawing.Point(117, 45)
        Me.LOTERIACheckBox.Name = "LOTERIACheckBox"
        Me.LOTERIACheckBox.Size = New System.Drawing.Size(24, 24)
        Me.LOTERIACheckBox.TabIndex = 54
        Me.LOTERIACheckBox.UseVisualStyleBackColor = True
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'A_CUENTATextBox
        '
        Me.A_CUENTATextBox.Enabled = False
        Me.A_CUENTATextBox.Location = New System.Drawing.Point(371, 147)
        Me.A_CUENTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.A_CUENTATextBox.Name = "A_CUENTATextBox"
        Me.A_CUENTATextBox.Size = New System.Drawing.Size(132, 22)
        Me.A_CUENTATextBox.TabIndex = 7
        '
        'ENTREGAS_A_CUENTATextBox
        '
        Me.ENTREGAS_A_CUENTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "A_CUENTA", True))
        Me.ENTREGAS_A_CUENTATextBox.Location = New System.Drawing.Point(371, 115)
        Me.ENTREGAS_A_CUENTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ENTREGAS_A_CUENTATextBox.Name = "ENTREGAS_A_CUENTATextBox"
        Me.ENTREGAS_A_CUENTATextBox.Size = New System.Drawing.Size(132, 22)
        Me.ENTREGAS_A_CUENTATextBox.TabIndex = 6
        '
        'OTROS_CARGOSTextBox
        '
        Me.OTROS_CARGOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "OtrosCargos", True))
        Me.OTROS_CARGOSTextBox.Location = New System.Drawing.Point(371, 83)
        Me.OTROS_CARGOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OTROS_CARGOSTextBox.Name = "OTROS_CARGOSTextBox"
        Me.OTROS_CARGOSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.OTROS_CARGOSTextBox.TabIndex = 5
        '
        'RECDEVTextBox
        '
        Me.RECDEVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "RECDEV", True))
        Me.RECDEVTextBox.Location = New System.Drawing.Point(371, 52)
        Me.RECDEVTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RECDEVTextBox.Name = "RECDEVTextBox"
        Me.RECDEVTextBox.Size = New System.Drawing.Size(132, 22)
        Me.RECDEVTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Resto Benef.:"
        '
        'RESTOTxt
        '
        Me.RESTOTxt.Enabled = False
        Me.RESTOTxt.Location = New System.Drawing.Point(117, 143)
        Me.RESTOTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.RESTOTxt.Name = "RESTOTxt"
        Me.RESTOTxt.Size = New System.Drawing.Size(71, 22)
        Me.RESTOTxt.TabIndex = 3
        '
        'DEV_BENEFITextBox
        '
        Me.DEV_BENEFITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DEV_BENEFI", True))
        Me.DEV_BENEFITextBox.Location = New System.Drawing.Point(117, 111)
        Me.DEV_BENEFITextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DEV_BENEFITextBox.Name = "DEV_BENEFITextBox"
        Me.DEV_BENEFITextBox.Size = New System.Drawing.Size(71, 22)
        Me.DEV_BENEFITextBox.TabIndex = 2
        '
        'BENEFICIOSTextBox
        '
        Me.BENEFICIOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "BENEFICIOS", True))
        Me.BENEFICIOSTextBox.Location = New System.Drawing.Point(117, 79)
        Me.BENEFICIOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BENEFICIOSTextBox.Name = "BENEFICIOSTextBox"
        Me.BENEFICIOSTextBox.Size = New System.Drawing.Size(71, 22)
        Me.BENEFICIOSTextBox.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MiCuentaTxt)
        Me.GroupBox4.Controls.Add(Me.CUENTATextBox)
        Me.GroupBox4.Controls.Add(Me.BANCOCheckBox)
        Me.GroupBox4.Controls.Add(CUENTALabel)
        Me.GroupBox4.Controls.Add(TITULARLabel)
        Me.GroupBox4.Controls.Add(Me.TITULARTextBox)
        Me.GroupBox4.Controls.Add(BANCOLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(448, 185)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(518, 146)
        Me.GroupBox4.TabIndex = 77
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Domiciliación bancaria"
        '
        'MiCuentaTxt
        '
        Me.MiCuentaTxt.BackColor = System.Drawing.SystemColors.Menu
        Me.MiCuentaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MiCuentaTxt.ForeColor = System.Drawing.SystemColors.Control
        Me.MiCuentaTxt.Location = New System.Drawing.Point(130, 40)
        Me.MiCuentaTxt.Name = "MiCuentaTxt"
        Me.MiCuentaTxt.Size = New System.Drawing.Size(267, 15)
        Me.MiCuentaTxt.TabIndex = 47
        '
        'CUENTATextBox
        '
        Me.CUENTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "CUENTA", True))
        Me.CUENTATextBox.Location = New System.Drawing.Point(90, 104)
        Me.CUENTATextBox.Mask = "ES00 0000 0000 0000 0000 0000"
        Me.CUENTATextBox.Name = "CUENTATextBox"
        Me.CUENTATextBox.Size = New System.Drawing.Size(307, 22)
        Me.CUENTATextBox.TabIndex = 46
        '
        'BANCOCheckBox
        '
        Me.BANCOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "BANCO", True))
        Me.BANCOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FalleroBindingSource, "BANCO", True))
        Me.BANCOCheckBox.Location = New System.Drawing.Point(85, 37)
        Me.BANCOCheckBox.Name = "BANCOCheckBox"
        Me.BANCOCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.BANCOCheckBox.TabIndex = 45
        Me.BANCOCheckBox.UseVisualStyleBackColor = True
        '
        'TITULARTextBox
        '
        Me.TITULARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TITULAR", True))
        Me.TITULARTextBox.Location = New System.Drawing.Point(89, 71)
        Me.TITULARTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TITULARTextBox.Name = "TITULARTextBox"
        Me.TITULARTextBox.Size = New System.Drawing.Size(308, 22)
        Me.TITULARTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.NUM_PAGOSTextBox)
        Me.GroupBox3.Controls.Add(Me.Id_CUOTAComboBox)
        Me.GroupBox3.Controls.Add(Me.Id_DESCUENTOComboBox)
        Me.GroupBox3.Controls.Add(Me.NumcuotasmesTextBox)
        Me.GroupBox3.Controls.Add(Me.NUM_CUOTASTextBox)
        Me.GroupBox3.Controls.Add(PAGOS_PDTESLabel)
        Me.GroupBox3.Controls.Add(DESCUENTOLabel1)
        Me.GroupBox3.Controls.Add(Me.DESCUENTOTextBox)
        Me.GroupBox3.Controls.Add(Me.DESCRIP_DESCUENTOTextBox)
        Me.GroupBox3.Controls.Add(Id_DESCUENTOLabel1)
        Me.GroupBox3.Controls.Add(Me.Id_DESCUENTOTextBox)
        Me.GroupBox3.Controls.Add(TOTAL_CUOTALabel)
        Me.GroupBox3.Controls.Add(Me.TOTAL_CUOTATextBox)
        Me.GroupBox3.Controls.Add(DEUDALabel)
        Me.GroupBox3.Controls.Add(Me.DEUDATextBox)
        Me.GroupBox3.Controls.Add(NUM_PAGOSLabel)
        Me.GroupBox3.Controls.Add(PAGOLabel)
        Me.GroupBox3.Controls.Add(Me.PAGOTextBox)
        Me.GroupBox3.Controls.Add(TIPO_CUOTALabel)
        Me.GroupBox3.Controls.Add(Me.TIPO_CUOTAComboBox)
        Me.GroupBox3.Controls.Add(Id_cuotaLabel)
        Me.GroupBox3.Controls.Add(Me.Id_cuotaTextBox)
        Me.GroupBox3.Controls.Add(Me.DESCRIP_CUOTATextBox)
        Me.GroupBox3.Controls.Add(VALOR_CUOTALabel)
        Me.GroupBox3.Controls.Add(Me.VALOR_CUOTATextBox)
        Me.GroupBox3.Controls.Add(Id_cuotaLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 103)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(425, 446)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de cuotas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "numcuotas-Eje"
        Me.Label2.Visible = False
        '
        'NUM_PAGOSTextBox
        '
        Me.NUM_PAGOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NUM_PAGOS", True))
        Me.NUM_PAGOSTextBox.Location = New System.Drawing.Point(156, 268)
        Me.NUM_PAGOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NUM_PAGOSTextBox.Name = "NUM_PAGOSTextBox"
        Me.NUM_PAGOSTextBox.Size = New System.Drawing.Size(131, 22)
        Me.NUM_PAGOSTextBox.TabIndex = 39
        '
        'Id_CUOTAComboBox
        '
        Me.Id_CUOTAComboBox.DataSource = Me.TipoDeCuotasBindingSource
        Me.Id_CUOTAComboBox.DisplayMember = "DESCRIP_CUOTA"
        Me.Id_CUOTAComboBox.DropDownWidth = 175
        Me.Id_CUOTAComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_CUOTAComboBox.FormattingEnabled = True
        Me.Id_CUOTAComboBox.Location = New System.Drawing.Point(288, 39)
        Me.Id_CUOTAComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_CUOTAComboBox.Name = "Id_CUOTAComboBox"
        Me.Id_CUOTAComboBox.Size = New System.Drawing.Size(21, 25)
        Me.Id_CUOTAComboBox.TabIndex = 0
        Me.Id_CUOTAComboBox.ValueMember = "CUOTA"
        '
        'TipoDeCuotasBindingSource
        '
        Me.TipoDeCuotasBindingSource.DataMember = "tipo de cuotas"
        Me.TipoDeCuotasBindingSource.DataSource = Me.DbCensos
        '
        'Id_DESCUENTOComboBox
        '
        Me.Id_DESCUENTOComboBox.DataSource = Me.DescuentosDeLaCuotaBindingSource
        Me.Id_DESCUENTOComboBox.DisplayMember = "DESCRIPCION"
        Me.Id_DESCUENTOComboBox.DropDownWidth = 125
        Me.Id_DESCUENTOComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_DESCUENTOComboBox.FormattingEnabled = True
        Me.Id_DESCUENTOComboBox.Location = New System.Drawing.Point(288, 103)
        Me.Id_DESCUENTOComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_DESCUENTOComboBox.Name = "Id_DESCUENTOComboBox"
        Me.Id_DESCUENTOComboBox.Size = New System.Drawing.Size(22, 25)
        Me.Id_DESCUENTOComboBox.TabIndex = 1
        Me.Id_DESCUENTOComboBox.ValueMember = "DESCUENTO"
        '
        'DescuentosDeLaCuotaBindingSource
        '
        Me.DescuentosDeLaCuotaBindingSource.DataMember = "descuentos de la cuota"
        Me.DescuentosDeLaCuotaBindingSource.DataSource = Me.DbCensos
        '
        'NumcuotasmesTextBox
        '
        Me.NumcuotasmesTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NumcuotasmesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumcuotasmesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.NumcuotasmesTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.NumcuotasmesTextBox.Location = New System.Drawing.Point(302, 268)
        Me.NumcuotasmesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumcuotasmesTextBox.Name = "NumcuotasmesTextBox"
        Me.NumcuotasmesTextBox.Size = New System.Drawing.Size(36, 15)
        Me.NumcuotasmesTextBox.TabIndex = 62
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DbCensos
        '
        'NUM_CUOTASTextBox
        '
        Me.NUM_CUOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NUM_CUOTAS", True))
        Me.NUM_CUOTASTextBox.Enabled = False
        Me.NUM_CUOTASTextBox.Location = New System.Drawing.Point(156, 238)
        Me.NUM_CUOTASTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NUM_CUOTASTextBox.Name = "NUM_CUOTASTextBox"
        Me.NUM_CUOTASTextBox.Size = New System.Drawing.Size(131, 22)
        Me.NUM_CUOTASTextBox.TabIndex = 38
        '
        'DESCUENTOTextBox
        '
        Me.DESCUENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DESCUENTO", True))
        Me.DESCUENTOTextBox.Enabled = False
        Me.DESCUENTOTextBox.Location = New System.Drawing.Point(156, 135)
        Me.DESCUENTOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCUENTOTextBox.Name = "DESCUENTOTextBox"
        Me.DESCUENTOTextBox.Size = New System.Drawing.Size(132, 22)
        Me.DESCUENTOTextBox.TabIndex = 37
        '
        'DESCRIP_DESCUENTOTextBox
        '
        Me.DESCRIP_DESCUENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DESCRIP_DESCUENTO", True))
        Me.DESCRIP_DESCUENTOTextBox.Enabled = False
        Me.DESCRIP_DESCUENTOTextBox.Location = New System.Drawing.Point(156, 103)
        Me.DESCRIP_DESCUENTOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCRIP_DESCUENTOTextBox.Name = "DESCRIP_DESCUENTOTextBox"
        Me.DESCRIP_DESCUENTOTextBox.Size = New System.Drawing.Size(132, 22)
        Me.DESCRIP_DESCUENTOTextBox.TabIndex = 36
        '
        'Id_DESCUENTOTextBox
        '
        Me.Id_DESCUENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "Id_DESCUENTO", True))
        Me.Id_DESCUENTOTextBox.Enabled = False
        Me.Id_DESCUENTOTextBox.Location = New System.Drawing.Point(104, 103)
        Me.Id_DESCUENTOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_DESCUENTOTextBox.Name = "Id_DESCUENTOTextBox"
        Me.Id_DESCUENTOTextBox.Size = New System.Drawing.Size(41, 22)
        Me.Id_DESCUENTOTextBox.TabIndex = 35
        '
        'TOTAL_CUOTATextBox
        '
        Me.TOTAL_CUOTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TOTAL_CUOTA", True))
        Me.TOTAL_CUOTATextBox.Enabled = False
        Me.TOTAL_CUOTATextBox.Location = New System.Drawing.Point(156, 346)
        Me.TOTAL_CUOTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TOTAL_CUOTATextBox.Name = "TOTAL_CUOTATextBox"
        Me.TOTAL_CUOTATextBox.Size = New System.Drawing.Size(132, 22)
        Me.TOTAL_CUOTATextBox.TabIndex = 31
        '
        'DEUDATextBox
        '
        Me.DEUDATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DEUDA", True))
        Me.DEUDATextBox.Enabled = False
        Me.DEUDATextBox.Location = New System.Drawing.Point(156, 378)
        Me.DEUDATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DEUDATextBox.Name = "DEUDATextBox"
        Me.DEUDATextBox.Size = New System.Drawing.Size(132, 22)
        Me.DEUDATextBox.TabIndex = 29
        '
        'PAGOTextBox
        '
        Me.PAGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "PAGO", True))
        Me.PAGOTextBox.Enabled = False
        Me.PAGOTextBox.Location = New System.Drawing.Point(156, 206)
        Me.PAGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PAGOTextBox.Name = "PAGOTextBox"
        Me.PAGOTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PAGOTextBox.TabIndex = 26
        '
        'TIPO_CUOTAComboBox
        '
        Me.TIPO_CUOTAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TIPO_CUOTA", True))
        Me.TIPO_CUOTAComboBox.Enabled = False
        Me.TIPO_CUOTAComboBox.FormattingEnabled = True
        Me.TIPO_CUOTAComboBox.Items.AddRange(New Object() {"ANUAL", "MENSUAL"})
        Me.TIPO_CUOTAComboBox.Location = New System.Drawing.Point(156, 172)
        Me.TIPO_CUOTAComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TIPO_CUOTAComboBox.Name = "TIPO_CUOTAComboBox"
        Me.TIPO_CUOTAComboBox.Size = New System.Drawing.Size(132, 24)
        Me.TIPO_CUOTAComboBox.TabIndex = 21
        '
        'Id_cuotaTextBox
        '
        Me.Id_cuotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "Id_cuota", True))
        Me.Id_cuotaTextBox.Enabled = False
        Me.Id_cuotaTextBox.Location = New System.Drawing.Point(104, 39)
        Me.Id_cuotaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_cuotaTextBox.Name = "Id_cuotaTextBox"
        Me.Id_cuotaTextBox.Size = New System.Drawing.Size(41, 22)
        Me.Id_cuotaTextBox.TabIndex = 18
        '
        'DESCRIP_CUOTATextBox
        '
        Me.DESCRIP_CUOTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DESCRIP_CUOTA", True))
        Me.DESCRIP_CUOTATextBox.Enabled = False
        Me.DESCRIP_CUOTATextBox.Location = New System.Drawing.Point(156, 39)
        Me.DESCRIP_CUOTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCRIP_CUOTATextBox.Name = "DESCRIP_CUOTATextBox"
        Me.DESCRIP_CUOTATextBox.Size = New System.Drawing.Size(132, 22)
        Me.DESCRIP_CUOTATextBox.TabIndex = 14
        '
        'VALOR_CUOTATextBox
        '
        Me.VALOR_CUOTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "VALOR_CUOTA", True))
        Me.VALOR_CUOTATextBox.Enabled = False
        Me.VALOR_CUOTATextBox.Location = New System.Drawing.Point(156, 71)
        Me.VALOR_CUOTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.VALOR_CUOTATextBox.Name = "VALOR_CUOTATextBox"
        Me.VALOR_CUOTATextBox.Size = New System.Drawing.Size(132, 22)
        Me.VALOR_CUOTATextBox.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TIPFALLabel)
        Me.GroupBox1.Controls.Add(APELLIDOSLabel)
        Me.GroupBox1.Controls.Add(Me.TIPFALTextBox)
        Me.GroupBox1.Controls.Add(Me.APELLIDOSTextBox)
        Me.GroupBox1.Controls.Add(NOMBRELabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRETextBox)
        Me.GroupBox1.Controls.Add(FALLERO_CODIGOLabel)
        Me.GroupBox1.Controls.Add(Me.FALLERO_CODIGOTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(962, 82)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fallero"
        '
        'TIPFALTextBox
        '
        Me.TIPFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TIPFAL", True))
        Me.TIPFALTextBox.Enabled = False
        Me.TIPFALTextBox.Location = New System.Drawing.Point(894, 31)
        Me.TIPFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TIPFALTextBox.Name = "TIPFALTextBox"
        Me.TIPFALTextBox.Size = New System.Drawing.Size(45, 22)
        Me.TIPFALTextBox.TabIndex = 2
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Enabled = False
        Me.APELLIDOSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(551, 32)
        Me.APELLIDOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(237, 23)
        Me.APELLIDOSTextBox.TabIndex = 1
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Enabled = False
        Me.NOMBRETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(314, 32)
        Me.NOMBRETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(132, 23)
        Me.NOMBRETextBox.TabIndex = 0
        '
        'FALLERO_CODIGOTextBox
        '
        Me.FALLERO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.FALLERO_CODIGOTextBox.Enabled = False
        Me.FALLERO_CODIGOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(155, 32)
        Me.FALLERO_CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(59, 23)
        Me.FALLERO_CODIGOTextBox.TabIndex = 2
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'Tipo_de_cuotasTableAdapter
        '
        Me.Tipo_de_cuotasTableAdapter.ClearBeforeFill = True
        '
        'Descuentos_de_la_cuotaTableAdapter
        '
        Me.Descuentos_de_la_cuotaTableAdapter.ClearBeforeFill = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Image = CType(resources.GetObject("BtnCalcular.Image"), System.Drawing.Image)
        Me.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalcular.Location = New System.Drawing.Point(448, 556)
        Me.BtnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(157, 46)
        Me.BtnCalcular.TabIndex = 80
        Me.BtnCalcular.Text = "Calcular todo"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnVerPagos
        '
        Me.BtnVerPagos.Image = CType(resources.GetObject("BtnVerPagos.Image"), System.Drawing.Image)
        Me.BtnVerPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerPagos.Location = New System.Drawing.Point(188, 557)
        Me.BtnVerPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVerPagos.Name = "BtnVerPagos"
        Me.BtnVerPagos.Size = New System.Drawing.Size(157, 46)
        Me.BtnVerPagos.TabIndex = 82
        Me.BtnVerPagos.Text = "Ver Pagos"
        Me.BtnVerPagos.UseVisualStyleBackColor = True
        '
        'BtnAddPago
        '
        Me.BtnAddPago.Image = CType(resources.GetObject("BtnAddPago.Image"), System.Drawing.Image)
        Me.BtnAddPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddPago.Location = New System.Drawing.Point(8, 557)
        Me.BtnAddPago.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddPago.Name = "BtnAddPago"
        Me.BtnAddPago.Size = New System.Drawing.Size(157, 46)
        Me.BtnAddPago.TabIndex = 83
        Me.BtnAddPago.Text = "Añadir Pago"
        Me.BtnAddPago.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(619, 557)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(157, 46)
        Me.BtnActualizar.TabIndex = 81
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(872, 557)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 46)
        Me.BtnSalir.TabIndex = 84
        Me.BtnSalir.Text = "Volver"
        Me.BtnSalir.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Me.Descuentos_de_la_cuotaTableAdapter
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
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Me.Tipo_de_cuotasTableAdapter
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'FrmSubDatosCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 634)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnVerPagos)
        Me.Controls.Add(Me.BtnAddPago)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSubDatosCuotas"
        Me.Text = "Datos Cuotas Fallero seleccionado"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LOTERIACheckBox As CheckBox
    Friend WithEvents A_CUENTATextBox As TextBox
    Friend WithEvents ENTREGAS_A_CUENTATextBox As TextBox
    Friend WithEvents OTROS_CARGOSTextBox As TextBox
    Friend WithEvents RECDEVTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RESTOTxt As TextBox
    Friend WithEvents DEV_BENEFITextBox As TextBox
    Friend WithEvents BENEFICIOSTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MiCuentaTxt As TextBox
    Friend WithEvents CUENTATextBox As MaskedTextBox
    Friend WithEvents BANCOCheckBox As CheckBox
    Friend WithEvents TITULARTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NUM_PAGOSTextBox As TextBox
    Friend WithEvents Id_CUOTAComboBox As ComboBox
    Friend WithEvents Id_DESCUENTOComboBox As ComboBox
    Friend WithEvents NumcuotasmesTextBox As TextBox
    Friend WithEvents NUM_CUOTASTextBox As TextBox
    Friend WithEvents DESCUENTOTextBox As TextBox
    Friend WithEvents DESCRIP_DESCUENTOTextBox As TextBox
    Friend WithEvents Id_DESCUENTOTextBox As TextBox
    Friend WithEvents TOTAL_CUOTATextBox As TextBox
    Friend WithEvents DEUDATextBox As TextBox
    Friend WithEvents PAGOTextBox As TextBox
    Friend WithEvents TIPO_CUOTAComboBox As ComboBox
    Friend WithEvents Id_cuotaTextBox As TextBox
    Friend WithEvents DESCRIP_CUOTATextBox As TextBox
    Friend WithEvents VALOR_CUOTATextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TIPFALTextBox As TextBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents TipoDeCuotasBindingSource As BindingSource
    Friend WithEvents Tipo_de_cuotasTableAdapter As DbCensosTableAdapters.tipo_de_cuotasTableAdapter
    Friend WithEvents DescuentosDeLaCuotaBindingSource As BindingSource
    Friend WithEvents Descuentos_de_la_cuotaTableAdapter As DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnVerPagos As Button
    Friend WithEvents BtnAddPago As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DbCensosTableAdapters.ejercicioTableAdapter
End Class
