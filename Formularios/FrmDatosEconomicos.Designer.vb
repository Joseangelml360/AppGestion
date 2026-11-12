<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDatosEconomicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatosEconomicos))
        Me.ActivosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TOTAL_CUOTATextBox = New System.Windows.Forms.TextBox()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LOTERIACheckBox = New System.Windows.Forms.CheckBox()
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
        Me.NumcuotasmesTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUM_PAGOSTextBox = New System.Windows.Forms.TextBox()
        Me.Id_CUOTAComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoDeCuotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_DESCUENTOComboBox = New System.Windows.Forms.ComboBox()
        Me.DescuentosDeLaCuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUM_CUOTASTextBox = New System.Windows.Forms.TextBox()
        Me.DESCUENTOTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIP_DESCUENTOTextBox = New System.Windows.Forms.TextBox()
        Me.Id_DESCUENTOTextBox = New System.Windows.Forms.TextBox()
        Me.DEUDATextBox = New System.Windows.Forms.TextBox()
        Me.PAGOTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_CUOTAComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_cuotaTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIP_CUOTATextBox = New System.Windows.Forms.TextBox()
        Me.VALOR_CUOTATextBox = New System.Windows.Forms.TextBox()
        Me.DgvFallero = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.ActivosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BtnVerPagos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnAddPago = New System.Windows.Forms.Button()
        Me.Lblfiltro = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.Descuentos_de_la_cuotaTableAdapter = New AppGestion.DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter()
        Me.EjercicioTableAdapter = New AppGestion.DbCensosTableAdapters.ejercicioTableAdapter()
        Me.Tipo_de_cuotasTableAdapter = New AppGestion.DbCensosTableAdapters.tipo_de_cuotasTableAdapter()
        Me.FalleroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FalleroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBuscarCodigo = New System.Windows.Forms.Button()
        Me.TxtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ActivosToolStrip.SuspendLayout()
        CType(Me.FalleroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FalleroBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'A_CUENTALabel
        '
        A_CUENTALabel.AutoSize = True
        A_CUENTALabel.Location = New System.Drawing.Point(297, 153)
        A_CUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        A_CUENTALabel.Name = "A_CUENTALabel"
        A_CUENTALabel.Size = New System.Drawing.Size(117, 17)
        A_CUENTALabel.TabIndex = 53
        A_CUENTALabel.Text = "Acumulado a cta:"
        '
        'ENTREGAS_A_CUENTALabel
        '
        ENTREGAS_A_CUENTALabel.AutoSize = True
        ENTREGAS_A_CUENTALabel.Location = New System.Drawing.Point(263, 121)
        ENTREGAS_A_CUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ENTREGAS_A_CUENTALabel.Name = "ENTREGAS_A_CUENTALabel"
        ENTREGAS_A_CUENTALabel.Size = New System.Drawing.Size(148, 17)
        ENTREGAS_A_CUENTALabel.TabIndex = 52
        ENTREGAS_A_CUENTALabel.Text = "INGRESO A CUENTA:"
        '
        'OTROS_CARGOSLabel
        '
        OTROS_CARGOSLabel.AutoSize = True
        OTROS_CARGOSLabel.Location = New System.Drawing.Point(289, 94)
        OTROS_CARGOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OTROS_CARGOSLabel.Name = "OTROS_CARGOSLabel"
        OTROS_CARGOSLabel.Size = New System.Drawing.Size(125, 17)
        OTROS_CARGOSLabel.TabIndex = 51
        OTROS_CARGOSLabel.Text = "OTROS CARGOS:"
        '
        'RECDEVLabel
        '
        RECDEVLabel.AutoSize = True
        RECDEVLabel.Location = New System.Drawing.Point(345, 58)
        RECDEVLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RECDEVLabel.Name = "RECDEVLabel"
        RECDEVLabel.Size = New System.Drawing.Size(68, 17)
        RECDEVLabel.TabIndex = 50
        RECDEVLabel.Text = "RECDEV:"
        '
        'DEV_BENEFILabel
        '
        DEV_BENEFILabel.AutoSize = True
        DEV_BENEFILabel.Location = New System.Drawing.Point(29, 117)
        DEV_BENEFILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DEV_BENEFILabel.Name = "DEV_BENEFILabel"
        DEV_BENEFILabel.Size = New System.Drawing.Size(92, 17)
        DEV_BENEFILabel.TabIndex = 47
        DEV_BENEFILabel.Text = "DEV BENEFI:"
        '
        'BENEFICIOSLabel
        '
        BENEFICIOSLabel.AutoSize = True
        BENEFICIOSLabel.Location = New System.Drawing.Point(29, 85)
        BENEFICIOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BENEFICIOSLabel.Name = "BENEFICIOSLabel"
        BENEFICIOSLabel.Size = New System.Drawing.Size(92, 17)
        BENEFICIOSLabel.TabIndex = 46
        BENEFICIOSLabel.Text = "BENEFICIOS:"
        '
        'LOTERIALabel
        '
        LOTERIALabel.AutoSize = True
        LOTERIALabel.Location = New System.Drawing.Point(52, 50)
        LOTERIALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LOTERIALabel.Name = "LOTERIALabel"
        LOTERIALabel.Size = New System.Drawing.Size(71, 17)
        LOTERIALabel.TabIndex = 45
        LOTERIALabel.Text = "LOTERIA:"
        '
        'CUENTALabel
        '
        CUENTALabel.AutoSize = True
        CUENTALabel.Location = New System.Drawing.Point(55, 105)
        CUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CUENTALabel.Name = "CUENTALabel"
        CUENTALabel.Size = New System.Drawing.Size(68, 17)
        CUENTALabel.TabIndex = 44
        CUENTALabel.Text = "CUENTA:"
        '
        'TITULARLabel
        '
        TITULARLabel.AutoSize = True
        TITULARLabel.Location = New System.Drawing.Point(56, 73)
        TITULARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TITULARLabel.Name = "TITULARLabel"
        TITULARLabel.Size = New System.Drawing.Size(70, 17)
        TITULARLabel.TabIndex = 43
        TITULARLabel.Text = "TITULAR:"
        '
        'BANCOLabel
        '
        BANCOLabel.AutoSize = True
        BANCOLabel.Location = New System.Drawing.Point(64, 38)
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
        TIPFALLabel.Location = New System.Drawing.Point(896, 36)
        TIPFALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIPFALLabel.Name = "TIPFALLabel"
        TIPFALLabel.Size = New System.Drawing.Size(69, 17)
        TIPFALLabel.TabIndex = 59
        TIPFALLabel.Text = "Comisión:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(504, 36)
        APELLIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(88, 17)
        APELLIDOSLabel.TabIndex = 5
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(255, 36)
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
        'ActivosToolStripButton
        '
        Me.ActivosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ActivosToolStripButton.Name = "ActivosToolStripButton"
        Me.ActivosToolStripButton.Size = New System.Drawing.Size(61, 24)
        Me.ActivosToolStripButton.Text = "Activos"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Image = CType(resources.GetObject("BtnCalcular.Image"), System.Drawing.Image)
        Me.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalcular.Location = New System.Drawing.Point(657, 681)
        Me.BtnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(157, 46)
        Me.BtnCalcular.TabIndex = 70
        Me.BtnCalcular.Text = "Calcular todo"
        Me.BtnCalcular.UseVisualStyleBackColor = True
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
        Me.GroupBox5.Location = New System.Drawing.Point(485, 452)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(601, 198)
        Me.GroupBox5.TabIndex = 69
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lotería y otros"
        '
        'LOTERIACheckBox
        '
        Me.LOTERIACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FalleroBindingSource, "LOTERIA", True))
        Me.LOTERIACheckBox.Enabled = False
        Me.LOTERIACheckBox.Location = New System.Drawing.Point(135, 47)
        Me.LOTERIACheckBox.Name = "LOTERIACheckBox"
        Me.LOTERIACheckBox.Size = New System.Drawing.Size(24, 24)
        Me.LOTERIACheckBox.TabIndex = 54
        Me.LOTERIACheckBox.UseVisualStyleBackColor = True
        '
        'A_CUENTATextBox
        '
        Me.A_CUENTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "A_CUENTA", True))
        Me.A_CUENTATextBox.Enabled = False
        Me.A_CUENTATextBox.Location = New System.Drawing.Point(425, 149)
        Me.A_CUENTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.A_CUENTATextBox.Name = "A_CUENTATextBox"
        Me.A_CUENTATextBox.Size = New System.Drawing.Size(132, 22)
        Me.A_CUENTATextBox.TabIndex = 7
        '
        'ENTREGAS_A_CUENTATextBox
        '
        Me.ENTREGAS_A_CUENTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "EntregasAcuenta", True))
        Me.ENTREGAS_A_CUENTATextBox.Location = New System.Drawing.Point(425, 117)
        Me.ENTREGAS_A_CUENTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ENTREGAS_A_CUENTATextBox.Name = "ENTREGAS_A_CUENTATextBox"
        Me.ENTREGAS_A_CUENTATextBox.Size = New System.Drawing.Size(132, 22)
        Me.ENTREGAS_A_CUENTATextBox.TabIndex = 6
        '
        'OTROS_CARGOSTextBox
        '
        Me.OTROS_CARGOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "OtrosCargos", True))
        Me.OTROS_CARGOSTextBox.Location = New System.Drawing.Point(425, 85)
        Me.OTROS_CARGOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OTROS_CARGOSTextBox.Name = "OTROS_CARGOSTextBox"
        Me.OTROS_CARGOSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.OTROS_CARGOSTextBox.TabIndex = 5
        '
        'RECDEVTextBox
        '
        Me.RECDEVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "RECDEV", True))
        Me.RECDEVTextBox.Location = New System.Drawing.Point(425, 54)
        Me.RECDEVTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RECDEVTextBox.Name = "RECDEVTextBox"
        Me.RECDEVTextBox.Size = New System.Drawing.Size(132, 22)
        Me.RECDEVTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Resto Benef.:"
        '
        'RESTOTxt
        '
        Me.RESTOTxt.Enabled = False
        Me.RESTOTxt.Location = New System.Drawing.Point(135, 145)
        Me.RESTOTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.RESTOTxt.Name = "RESTOTxt"
        Me.RESTOTxt.Size = New System.Drawing.Size(71, 22)
        Me.RESTOTxt.TabIndex = 3
        '
        'DEV_BENEFITextBox
        '
        Me.DEV_BENEFITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DEV_BENEFI", True))
        Me.DEV_BENEFITextBox.Location = New System.Drawing.Point(135, 113)
        Me.DEV_BENEFITextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DEV_BENEFITextBox.Name = "DEV_BENEFITextBox"
        Me.DEV_BENEFITextBox.Size = New System.Drawing.Size(71, 22)
        Me.DEV_BENEFITextBox.TabIndex = 2
        '
        'BENEFICIOSTextBox
        '
        Me.BENEFICIOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "BENEFICIOS", True))
        Me.BENEFICIOSTextBox.Location = New System.Drawing.Point(135, 81)
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
        Me.GroupBox4.Location = New System.Drawing.Point(484, 287)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(603, 146)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Domiciliación bancaria"
        '
        'MiCuentaTxt
        '
        Me.MiCuentaTxt.BackColor = System.Drawing.SystemColors.Menu
        Me.MiCuentaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MiCuentaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "CUENTA", True))
        Me.MiCuentaTxt.ForeColor = System.Drawing.SystemColors.Control
        Me.MiCuentaTxt.Location = New System.Drawing.Point(176, 38)
        Me.MiCuentaTxt.Name = "MiCuentaTxt"
        Me.MiCuentaTxt.Size = New System.Drawing.Size(267, 15)
        Me.MiCuentaTxt.TabIndex = 47
        '
        'CUENTATextBox
        '
        Me.CUENTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "CUENTA", True))
        Me.CUENTATextBox.Location = New System.Drawing.Point(136, 102)
        Me.CUENTATextBox.Mask = "ES00 0000 0000 0000 0000 0000"
        Me.CUENTATextBox.Name = "CUENTATextBox"
        Me.CUENTATextBox.Size = New System.Drawing.Size(307, 22)
        Me.CUENTATextBox.TabIndex = 46
        '
        'BANCOCheckBox
        '
        Me.BANCOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FalleroBindingSource, "BANCO", True))
        Me.BANCOCheckBox.Location = New System.Drawing.Point(131, 35)
        Me.BANCOCheckBox.Name = "BANCOCheckBox"
        Me.BANCOCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.BANCOCheckBox.TabIndex = 45
        Me.BANCOCheckBox.UseVisualStyleBackColor = True
        '
        'TITULARTextBox
        '
        Me.TITULARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TITULAR", True))
        Me.TITULARTextBox.Location = New System.Drawing.Point(135, 69)
        Me.TITULARTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TITULARTextBox.Name = "TITULARTextBox"
        Me.TITULARTextBox.Size = New System.Drawing.Size(308, 22)
        Me.TITULARTextBox.TabIndex = 1
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
        Me.GroupBox3.Location = New System.Drawing.Point(19, 205)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(425, 446)
        Me.GroupBox3.TabIndex = 75
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
        'DgvFallero
        '
        Me.DgvFallero.AllowUserToAddRows = False
        Me.DgvFallero.AllowUserToDeleteRows = False
        Me.DgvFallero.AutoGenerateColumns = False
        Me.DgvFallero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFallero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.NOMBRE})
        Me.DgvFallero.DataSource = Me.FalleroBindingSource
        Me.DgvFallero.Location = New System.Drawing.Point(483, 109)
        Me.DgvFallero.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvFallero.Name = "DgvFallero"
        Me.DgvFallero.ReadOnly = True
        Me.DgvFallero.RowHeadersWidth = 51
        Me.DgvFallero.Size = New System.Drawing.Size(603, 170)
        Me.DgvFallero.TabIndex = 77
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "COD."
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 50
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 250
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 150
        '
        'TIPFALTextBox
        '
        Me.TIPFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TIPFAL", True))
        Me.TIPFALTextBox.Enabled = False
        Me.TIPFALTextBox.Location = New System.Drawing.Point(971, 32)
        Me.TIPFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TIPFALTextBox.Name = "TIPFALTextBox"
        Me.TIPFALTextBox.Size = New System.Drawing.Size(45, 22)
        Me.TIPFALTextBox.TabIndex = 2
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 115)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1060, 82)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fallero"
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Enabled = False
        Me.APELLIDOSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(604, 32)
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
        Me.NOMBRETextBox.Location = New System.Drawing.Point(339, 32)
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
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(72, 23)
        Me.FALLERO_CODIGOTextBox.TabIndex = 2
        '
        'ActivosToolStrip
        '
        Me.ActivosToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ActivosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivosToolStripButton, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ToolStripButton7, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator9, Me.ToolStripButton4, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripSeparator7, Me.ToolStripButton6, Me.ToolStripSeparator8, Me.ToolStripButton1})
        Me.ActivosToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ActivosToolStrip.Name = "ActivosToolStrip"
        Me.ActivosToolStrip.Size = New System.Drawing.Size(1112, 27)
        Me.ActivosToolStrip.TabIndex = 76
        Me.ActivosToolStrip.Text = "ActivosToolStrip"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(69, 24)
        Me.ToolStripButton2.Text = "Mayores"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(71, 24)
        Me.ToolStripButton7.Text = "Juveniles"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(73, 24)
        Me.ToolStripButton3.Text = "Infantiles"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(51, 24)
        Me.ToolStripButton4.Text = "Anual"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(68, 24)
        Me.ToolStripButton5.Text = "Mensual"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(55, 24)
        Me.ToolStripButton6.Text = "Titular"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(48, 24)
        Me.ToolStripButton1.Text = "Bajas"
        '
        'BtnVerPagos
        '
        Me.BtnVerPagos.Image = CType(resources.GetObject("BtnVerPagos.Image"), System.Drawing.Image)
        Me.BtnVerPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerPagos.Location = New System.Drawing.Point(223, 681)
        Me.BtnVerPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVerPagos.Name = "BtnVerPagos"
        Me.BtnVerPagos.Size = New System.Drawing.Size(157, 46)
        Me.BtnVerPagos.TabIndex = 72
        Me.BtnVerPagos.Text = "Ver Pagos"
        Me.BtnVerPagos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Buscar por apellidos:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(619, 82)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(237, 22)
        Me.TxtBuscar.TabIndex = 65
        '
        'BtnAddPago
        '
        Me.BtnAddPago.Image = CType(resources.GetObject("BtnAddPago.Image"), System.Drawing.Image)
        Me.BtnAddPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddPago.Location = New System.Drawing.Point(16, 681)
        Me.BtnAddPago.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddPago.Name = "BtnAddPago"
        Me.BtnAddPago.Size = New System.Drawing.Size(157, 46)
        Me.BtnAddPago.TabIndex = 73
        Me.BtnAddPago.Text = "Añadir Pago"
        Me.BtnAddPago.UseVisualStyleBackColor = True
        '
        'Lblfiltro
        '
        Me.Lblfiltro.AutoSize = True
        Me.Lblfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfiltro.Location = New System.Drawing.Point(1005, 28)
        Me.Lblfiltro.Name = "Lblfiltro"
        Me.Lblfiltro.Size = New System.Drawing.Size(71, 20)
        Me.Lblfiltro.TabIndex = 79
        Me.Lblfiltro.Text = "Activos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Ejercicio:"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(822, 681)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(157, 46)
        Me.BtnActualizar.TabIndex = 71
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(987, 681)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 46)
        Me.BtnSalir.TabIndex = 74
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Me.Descuentos_de_la_cuotaTableAdapter
        Me.TableAdapterManager.detalles_de_remesa1TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa2TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Me.EjercicioTableAdapter
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.fallasTableAdapter = Nothing
        Me.TableAdapterManager.falleroTableAdapter = Me.FalleroTableAdapter
        Me.TableAdapterManager.letradniTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Me.Tipo_de_cuotasTableAdapter
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Descuentos_de_la_cuotaTableAdapter
        '
        Me.Descuentos_de_la_cuotaTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'Tipo_de_cuotasTableAdapter
        '
        Me.Tipo_de_cuotasTableAdapter.ClearBeforeFill = True
        '
        'FalleroBindingNavigator
        '
        Me.FalleroBindingNavigator.AddNewItem = Nothing
        Me.FalleroBindingNavigator.BindingSource = Me.FalleroBindingSource
        Me.FalleroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FalleroBindingNavigator.DeleteItem = Nothing
        Me.FalleroBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FalleroBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FalleroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.FalleroBindingNavigatorSaveItem})
        Me.FalleroBindingNavigator.Location = New System.Drawing.Point(0, 748)
        Me.FalleroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FalleroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FalleroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FalleroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FalleroBindingNavigator.Name = "FalleroBindingNavigator"
        Me.FalleroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FalleroBindingNavigator.Size = New System.Drawing.Size(1112, 27)
        Me.FalleroBindingNavigator.TabIndex = 82
        Me.FalleroBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'FalleroBindingNavigatorSaveItem
        '
        Me.FalleroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FalleroBindingNavigatorSaveItem.Image = CType(resources.GetObject("FalleroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FalleroBindingNavigatorSaveItem.Name = "FalleroBindingNavigatorSaveItem"
        Me.FalleroBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.FalleroBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(438, 681)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Ver Datos Censo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBuscarCodigo
        '
        Me.BtnBuscarCodigo.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnBuscarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarCodigo.Location = New System.Drawing.Point(726, 48)
        Me.BtnBuscarCodigo.Name = "BtnBuscarCodigo"
        Me.BtnBuscarCodigo.Size = New System.Drawing.Size(130, 31)
        Me.BtnBuscarCodigo.TabIndex = 198
        Me.BtnBuscarCodigo.Text = "Buscar código"
        Me.BtnBuscarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'TxtBuscarCodigo
        '
        Me.TxtBuscarCodigo.Location = New System.Drawing.Point(617, 53)
        Me.TxtBuscarCodigo.Name = "TxtBuscarCodigo"
        Me.TxtBuscarCodigo.Size = New System.Drawing.Size(100, 22)
        Me.TxtBuscarCodigo.TabIndex = 197
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(404, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 17)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "         Buscar fallero por Código:"
        '
        'FrmDatosEconomicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1112, 775)
        Me.Controls.Add(Me.BtnBuscarCodigo)
        Me.Controls.Add(Me.TxtBuscarCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FalleroBindingNavigator)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DgvFallero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ActivosToolStrip)
        Me.Controls.Add(Me.BtnVerPagos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnAddPago)
        Me.Controls.Add(Me.Lblfiltro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnSalir)
        Me.HelpProvider1.SetHelpKeyword(Me, "26")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDatosEconomicos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos económicos"
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ActivosToolStrip.ResumeLayout(False)
        Me.ActivosToolStrip.PerformLayout()
        CType(Me.FalleroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FalleroBindingNavigator.ResumeLayout(False)
        Me.FalleroBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActivosToolStripButton As ToolStripButton
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TOTAL_CUOTATextBox As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents A_CUENTATextBox As TextBox
    Friend WithEvents ENTREGAS_A_CUENTATextBox As TextBox
    Friend WithEvents OTROS_CARGOSTextBox As TextBox
    Friend WithEvents RECDEVTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RESTOTxt As TextBox
    Friend WithEvents DEV_BENEFITextBox As TextBox
    Friend WithEvents BENEFICIOSTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TITULARTextBox As TextBox
    Friend WithEvents NumcuotasmesTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NUM_PAGOSTextBox As TextBox
    Friend WithEvents Id_CUOTAComboBox As ComboBox
    Friend WithEvents Id_DESCUENTOComboBox As ComboBox
    Friend WithEvents NUM_CUOTASTextBox As TextBox
    Friend WithEvents DESCUENTOTextBox As TextBox
    Friend WithEvents DESCRIP_DESCUENTOTextBox As TextBox
    Friend WithEvents Id_DESCUENTOTextBox As TextBox
    Friend WithEvents DEUDATextBox As TextBox
    Friend WithEvents PAGOTextBox As TextBox
    Friend WithEvents TIPO_CUOTAComboBox As ComboBox
    Friend WithEvents Id_cuotaTextBox As TextBox
    Friend WithEvents DESCRIP_CUOTATextBox As TextBox
    Friend WithEvents VALOR_CUOTATextBox As TextBox
    Friend WithEvents DgvFallero As DataGridView
    Friend WithEvents TIPFALTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents ActivosToolStrip As ToolStrip
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BtnVerPagos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnAddPago As Button
    Friend WithEvents Lblfiltro As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents FalleroBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FalleroBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tipo_de_cuotasTableAdapter As DbCensosTableAdapters.tipo_de_cuotasTableAdapter
    Friend WithEvents TipoDeCuotasBindingSource As BindingSource
    Friend WithEvents Descuentos_de_la_cuotaTableAdapter As DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter
    Friend WithEvents DescuentosDeLaCuotaBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DbCensosTableAdapters.ejercicioTableAdapter
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents LOTERIACheckBox As CheckBox
    Friend WithEvents BANCOCheckBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CUENTATextBox As MaskedTextBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents MiCuentaTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnBuscarCodigo As Button
    Friend WithEvents TxtBuscarCodigo As TextBox
    Friend WithEvents Label6 As Label
End Class
