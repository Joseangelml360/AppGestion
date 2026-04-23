<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaRemesa
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
        Dim LblEnviada As System.Windows.Forms.Label
        Dim LblConsolidada As System.Windows.Forms.Label
        Dim CIFPresLabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim NumcuotasmesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevaRemesa))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblGenerada = New System.Windows.Forms.Label()
        Me.EnviarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.ConsolidarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.GenerarRemesaNuevaCheckBox = New System.Windows.Forms.CheckBox()
        Me.BtnFijar = New System.Windows.Forms.Button()
        Me.GroupBoxNueva = New System.Windows.Forms.GroupBox()
        Me.TxtRecPagados = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumcuotasmesTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtImpRecDev = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BancoremesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TxtnCuotas = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.CuentaOrdTextBox = New System.Windows.Forms.TextBox()
        Me.DCOrdTextBox = New System.Windows.Forms.TextBox()
        Me.OfOrdTextBox = New System.Windows.Forms.TextBox()
        Me.EntOrdTextBox = New System.Windows.Forms.TextBox()
        Me.SufOrdTextBox = New System.Windows.Forms.TextBox()
        Me.CIFPresTextBox = New System.Windows.Forms.TextBox()
        Me.CIFTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtUltRemesa = New System.Windows.Forms.TextBox()
        Me.RemesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DTFechaCargo = New System.Windows.Forms.DateTimePicker()
        Me.DTFechaCreac = New System.Windows.Forms.DateTimePicker()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.Banco_remesaTableAdapter = New AppGestion.DbCensosTableAdapters.banco_remesaTableAdapter()
        Me.RemesasTableAdapter = New AppGestion.DbCensosTableAdapters.remesasTableAdapter()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.EjercicioTableAdapter = New AppGestion.DataSet1TableAdapters.ejercicioTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        LblEnviada = New System.Windows.Forms.Label()
        LblConsolidada = New System.Windows.Forms.Label()
        CIFPresLabel = New System.Windows.Forms.Label()
        CIFLabel = New System.Windows.Forms.Label()
        NumcuotasmesLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxNueva.SuspendLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BancoremesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblEnviada
        '
        LblEnviada.AutoSize = True
        LblEnviada.Location = New System.Drawing.Point(642, 17)
        LblEnviada.Name = "LblEnviada"
        LblEnviada.Size = New System.Drawing.Size(59, 17)
        LblEnviada.TabIndex = 23
        LblEnviada.Text = "Enviada"
        '
        'LblConsolidada
        '
        LblConsolidada.AutoSize = True
        LblConsolidada.Location = New System.Drawing.Point(390, 17)
        LblConsolidada.Name = "LblConsolidada"
        LblConsolidada.Size = New System.Drawing.Size(86, 17)
        LblConsolidada.TabIndex = 22
        LblConsolidada.Text = "Consolidada"
        '
        'CIFPresLabel
        '
        CIFPresLabel.AutoSize = True
        CIFPresLabel.Location = New System.Drawing.Point(324, 97)
        CIFPresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CIFPresLabel.Name = "CIFPresLabel"
        CIFPresLabel.Size = New System.Drawing.Size(61, 17)
        CIFPresLabel.TabIndex = 6
        CIFPresLabel.Text = "CIFPres:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(28, 97)
        CIFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(32, 17)
        CIFLabel.TabIndex = 4
        CIFLabel.Text = "CIF:"
        '
        'NumcuotasmesLabel
        '
        NumcuotasmesLabel.AutoSize = True
        NumcuotasmesLabel.Location = New System.Drawing.Point(17, 253)
        NumcuotasmesLabel.Name = "NumcuotasmesLabel"
        NumcuotasmesLabel.Size = New System.Drawing.Size(157, 17)
        NumcuotasmesLabel.TabIndex = 23
        NumcuotasmesLabel.Text = "Nº Total de cuotas/año:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblGenerada)
        Me.GroupBox2.Controls.Add(LblEnviada)
        Me.GroupBox2.Controls.Add(Me.EnviarRemesaCheckBox)
        Me.GroupBox2.Controls.Add(LblConsolidada)
        Me.GroupBox2.Controls.Add(Me.ConsolidarRemesaCheckBox)
        Me.GroupBox2.Controls.Add(Me.GenerarRemesaNuevaCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(57, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(878, 45)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado última Remesa"
        '
        'LblGenerada
        '
        Me.LblGenerada.AutoSize = True
        Me.LblGenerada.Location = New System.Drawing.Point(197, 17)
        Me.LblGenerada.Name = "LblGenerada"
        Me.LblGenerada.Size = New System.Drawing.Size(72, 17)
        Me.LblGenerada.TabIndex = 25
        Me.LblGenerada.Text = "Generada"
        '
        'EnviarRemesaCheckBox
        '
        Me.EnviarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "EnviarRemesa", True))
        Me.EnviarRemesaCheckBox.Location = New System.Drawing.Point(623, 13)
        Me.EnviarRemesaCheckBox.Name = "EnviarRemesaCheckBox"
        Me.EnviarRemesaCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.EnviarRemesaCheckBox.TabIndex = 24
        Me.EnviarRemesaCheckBox.UseVisualStyleBackColor = True
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
        'ConsolidarRemesaCheckBox
        '
        Me.ConsolidarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "ConsolidarRemesa", True))
        Me.ConsolidarRemesaCheckBox.Location = New System.Drawing.Point(371, 13)
        Me.ConsolidarRemesaCheckBox.Name = "ConsolidarRemesaCheckBox"
        Me.ConsolidarRemesaCheckBox.Size = New System.Drawing.Size(33, 24)
        Me.ConsolidarRemesaCheckBox.TabIndex = 23
        Me.ConsolidarRemesaCheckBox.UseVisualStyleBackColor = True
        '
        'GenerarRemesaNuevaCheckBox
        '
        Me.GenerarRemesaNuevaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "GenerarRemesaNueva", True))
        Me.GenerarRemesaNuevaCheckBox.Location = New System.Drawing.Point(179, 10)
        Me.GenerarRemesaNuevaCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GenerarRemesaNuevaCheckBox.Name = "GenerarRemesaNuevaCheckBox"
        Me.GenerarRemesaNuevaCheckBox.Size = New System.Drawing.Size(117, 30)
        Me.GenerarRemesaNuevaCheckBox.TabIndex = 21
        Me.GenerarRemesaNuevaCheckBox.UseVisualStyleBackColor = True
        '
        'BtnFijar
        '
        Me.BtnFijar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnFijar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFijar.Location = New System.Drawing.Point(534, 523)
        Me.BtnFijar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFijar.Name = "BtnFijar"
        Me.BtnFijar.Size = New System.Drawing.Size(157, 46)
        Me.BtnFijar.TabIndex = 40
        Me.BtnFijar.Text = "Fijar Datos"
        Me.BtnFijar.UseVisualStyleBackColor = True
        '
        'GroupBoxNueva
        '
        Me.GroupBoxNueva.Controls.Add(Me.TxtRecPagados)
        Me.GroupBoxNueva.Controls.Add(Me.Label12)
        Me.GroupBoxNueva.Controls.Add(NumcuotasmesLabel)
        Me.GroupBoxNueva.Controls.Add(Me.NumcuotasmesTextBox)
        Me.GroupBoxNueva.Controls.Add(Me.GroupBox1)
        Me.GroupBoxNueva.Controls.Add(Me.Label11)
        Me.GroupBoxNueva.Controls.Add(Me.Label10)
        Me.GroupBoxNueva.Controls.Add(Me.TxtImpRecDev)
        Me.GroupBoxNueva.Controls.Add(Me.Label6)
        Me.GroupBoxNueva.Controls.Add(Me.TextBox5)
        Me.GroupBoxNueva.Controls.Add(Me.Label5)
        Me.GroupBoxNueva.Controls.Add(Me.TextBox6)
        Me.GroupBoxNueva.Controls.Add(Me.TxtnCuotas)
        Me.GroupBoxNueva.Controls.Add(Me.TextBox7)
        Me.GroupBoxNueva.Controls.Add(Me.CuentaOrdTextBox)
        Me.GroupBoxNueva.Controls.Add(Me.DCOrdTextBox)
        Me.GroupBoxNueva.Controls.Add(Me.OfOrdTextBox)
        Me.GroupBoxNueva.Controls.Add(Me.EntOrdTextBox)
        Me.GroupBoxNueva.Controls.Add(Me.SufOrdTextBox)
        Me.GroupBoxNueva.Controls.Add(CIFPresLabel)
        Me.GroupBoxNueva.Controls.Add(Me.CIFPresTextBox)
        Me.GroupBoxNueva.Controls.Add(CIFLabel)
        Me.GroupBoxNueva.Controls.Add(Me.CIFTextBox)
        Me.GroupBoxNueva.Controls.Add(Me.Label9)
        Me.GroupBoxNueva.Controls.Add(Me.TextBox2)
        Me.GroupBoxNueva.Controls.Add(Me.TextBox1)
        Me.GroupBoxNueva.Controls.Add(Me.Label8)
        Me.GroupBoxNueva.Location = New System.Drawing.Point(51, 219)
        Me.GroupBoxNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxNueva.Name = "GroupBoxNueva"
        Me.GroupBoxNueva.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxNueva.Size = New System.Drawing.Size(881, 284)
        Me.GroupBoxNueva.TabIndex = 39
        Me.GroupBoxNueva.TabStop = False
        Me.GroupBoxNueva.Text = "Datos fijos nueva Remesa"
        '
        'TxtRecPagados
        '
        Me.TxtRecPagados.Location = New System.Drawing.Point(496, 246)
        Me.TxtRecPagados.Name = "TxtRecPagados"
        Me.TxtRecPagados.Size = New System.Drawing.Size(98, 22)
        Me.TxtRecPagados.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(360, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Recibos pagados:"
        '
        'NumcuotasmesTextBox
        '
        Me.NumcuotasmesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.NumcuotasmesTextBox.Location = New System.Drawing.Point(180, 250)
        Me.NumcuotasmesTextBox.Name = "NumcuotasmesTextBox"
        Me.NumcuotasmesTextBox.ReadOnly = True
        Me.NumcuotasmesTextBox.Size = New System.Drawing.Size(89, 22)
        Me.NumcuotasmesTextBox.TabIndex = 24
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSet1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(661, 59)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(180, 161)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Remesa"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(24, 123)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Mensual/Anual"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(24, 84)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 21)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Anual"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 52)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mensual"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(397, 135)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Oficina"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 135)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cuenta"
        '
        'TxtImpRecDev
        '
        Me.TxtImpRecDev.Location = New System.Drawing.Point(496, 210)
        Me.TxtImpRecDev.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtImpRecDev.Name = "TxtImpRecDev"
        Me.TxtImpRecDev.Size = New System.Drawing.Size(97, 22)
        Me.TxtImpRecDev.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Importe recibo devuelto"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "OfPres", True))
        Me.TextBox5.Location = New System.Drawing.Point(447, 155)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(40, 22)
        Me.TextBox5.TabIndex = 16
        '
        'BancoremesaBindingSource
        '
        Me.BancoremesaBindingSource.DataMember = "banco_remesa"
        Me.BancoremesaBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 214)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nº de cuotas a pagar"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "EntPres", True))
        Me.TextBox6.Location = New System.Drawing.Point(401, 155)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(47, 22)
        Me.TextBox6.TabIndex = 15
        '
        'TxtnCuotas
        '
        Me.TxtnCuotas.Location = New System.Drawing.Point(169, 210)
        Me.TxtnCuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtnCuotas.Name = "TxtnCuotas"
        Me.TxtnCuotas.Size = New System.Drawing.Size(99, 22)
        Me.TxtnCuotas.TabIndex = 10
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "SufPres", True))
        Me.TextBox7.Location = New System.Drawing.Point(352, 155)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(35, 22)
        Me.TextBox7.TabIndex = 14
        '
        'CuentaOrdTextBox
        '
        Me.CuentaOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "CuentaOrd", True))
        Me.CuentaOrdTextBox.Location = New System.Drawing.Point(193, 155)
        Me.CuentaOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CuentaOrdTextBox.Name = "CuentaOrdTextBox"
        Me.CuentaOrdTextBox.ReadOnly = True
        Me.CuentaOrdTextBox.Size = New System.Drawing.Size(88, 22)
        Me.CuentaOrdTextBox.TabIndex = 13
        '
        'DCOrdTextBox
        '
        Me.DCOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "DCOrd", True))
        Me.DCOrdTextBox.Location = New System.Drawing.Point(160, 155)
        Me.DCOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DCOrdTextBox.Name = "DCOrdTextBox"
        Me.DCOrdTextBox.ReadOnly = True
        Me.DCOrdTextBox.Size = New System.Drawing.Size(33, 22)
        Me.DCOrdTextBox.TabIndex = 12
        '
        'OfOrdTextBox
        '
        Me.OfOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "OfOrd", True))
        Me.OfOrdTextBox.Location = New System.Drawing.Point(120, 155)
        Me.OfOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OfOrdTextBox.Name = "OfOrdTextBox"
        Me.OfOrdTextBox.ReadOnly = True
        Me.OfOrdTextBox.Size = New System.Drawing.Size(40, 22)
        Me.OfOrdTextBox.TabIndex = 11
        '
        'EntOrdTextBox
        '
        Me.EntOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "EntOrd", True))
        Me.EntOrdTextBox.Location = New System.Drawing.Point(75, 155)
        Me.EntOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EntOrdTextBox.Name = "EntOrdTextBox"
        Me.EntOrdTextBox.ReadOnly = True
        Me.EntOrdTextBox.Size = New System.Drawing.Size(47, 22)
        Me.EntOrdTextBox.TabIndex = 10
        '
        'SufOrdTextBox
        '
        Me.SufOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "SufOrd", True))
        Me.SufOrdTextBox.Location = New System.Drawing.Point(27, 155)
        Me.SufOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SufOrdTextBox.Name = "SufOrdTextBox"
        Me.SufOrdTextBox.ReadOnly = True
        Me.SufOrdTextBox.Size = New System.Drawing.Size(35, 22)
        Me.SufOrdTextBox.TabIndex = 9
        '
        'CIFPresTextBox
        '
        Me.CIFPresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "CIFPres", True))
        Me.CIFPresTextBox.Location = New System.Drawing.Point(395, 94)
        Me.CIFPresTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CIFPresTextBox.Name = "CIFPresTextBox"
        Me.CIFPresTextBox.ReadOnly = True
        Me.CIFPresTextBox.Size = New System.Drawing.Size(199, 22)
        Me.CIFPresTextBox.TabIndex = 7
        '
        'CIFTextBox
        '
        Me.CIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "CIF", True))
        Me.CIFTextBox.Location = New System.Drawing.Point(71, 94)
        Me.CIFTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CIFTextBox.Name = "CIFTextBox"
        Me.CIFTextBox.ReadOnly = True
        Me.CIFTextBox.Size = New System.Drawing.Size(211, 22)
        Me.CIFTextBox.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(320, 38)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Presentador"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Nombre Pres", True))
        Me.TextBox2.Location = New System.Drawing.Point(324, 59)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(269, 22)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Ordenante", True))
        Me.TextBox1.Location = New System.Drawing.Point(27, 59)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(255, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ordenante"
        '
        'TxtUltRemesa
        '
        Me.TxtUltRemesa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RemesasBindingSource, "IdRemesa", True))
        Me.TxtUltRemesa.Location = New System.Drawing.Point(648, 122)
        Me.TxtUltRemesa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUltRemesa.Name = "TxtUltRemesa"
        Me.TxtUltRemesa.Size = New System.Drawing.Size(41, 22)
        Me.TxtUltRemesa.TabIndex = 38
        '
        'RemesasBindingSource
        '
        Me.RemesasBindingSource.DataMember = "remesas"
        Me.RemesasBindingSource.DataSource = Me.DbCensos
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Id Nueva Remesa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(515, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Fecha de cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Fecha de creación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Seleccionar Banco"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(778, 521)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 33
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Remesa Nueva"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BancoremesaBindingSource
        Me.ComboBox1.DisplayMember = "Banco"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(193, 122)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(267, 24)
        Me.ComboBox1.TabIndex = 29
        Me.ComboBox1.ValueMember = "Id"
        '
        'DTFechaCargo
        '
        Me.DTFechaCargo.Location = New System.Drawing.Point(630, 157)
        Me.DTFechaCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.DTFechaCargo.Name = "DTFechaCargo"
        Me.DTFechaCargo.Size = New System.Drawing.Size(302, 22)
        Me.DTFechaCargo.TabIndex = 28
        '
        'DTFechaCreac
        '
        Me.DTFechaCreac.Location = New System.Drawing.Point(187, 157)
        Me.DTFechaCreac.Margin = New System.Windows.Forms.Padding(4)
        Me.DTFechaCreac.Name = "DTFechaCreac"
        Me.DTFechaCreac.Size = New System.Drawing.Size(270, 22)
        Me.DTFechaCreac.TabIndex = 27
        '
        'BtnVer
        '
        Me.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnVer.Image = CType(resources.GetObject("BtnVer.Image"), System.Drawing.Image)
        Me.BtnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVer.Location = New System.Drawing.Point(52, 521)
        Me.BtnVer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(161, 46)
        Me.BtnVer.TabIndex = 32
        Me.BtnVer.Text = "   Ver/Modificar Remesa"
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnGenerar.Image = CType(resources.GetObject("BtnGenerar.Image"), System.Drawing.Image)
        Me.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerar.Location = New System.Drawing.Point(299, 521)
        Me.BtnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(149, 46)
        Me.BtnGenerar.TabIndex = 31
        Me.BtnGenerar.Text = "     Generar Nueva Remesa"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'Banco_remesaTableAdapter
        '
        Me.Banco_remesaTableAdapter.ClearBeforeFill = True
        '
        'RemesasTableAdapter
        '
        Me.RemesasTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Me.EjercicioTableAdapter
        Me.TableAdapterManager.estadoTableAdapter = Me.EstadoTableAdapter
        Me.TableAdapterManager.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager.historfaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmNuevaRemesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(979, 588)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnFijar)
        Me.Controls.Add(Me.GroupBoxNueva)
        Me.Controls.Add(Me.TxtUltRemesa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DTFechaCargo)
        Me.Controls.Add(Me.DTFechaCreac)
        Me.HelpProvider1.SetHelpKeyword(Me, "15")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNuevaRemesa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remesa Nueva"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxNueva.ResumeLayout(False)
        Me.GroupBoxNueva.PerformLayout()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BancoremesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblGenerada As Label
    Friend WithEvents EnviarRemesaCheckBox As CheckBox
    Friend WithEvents ConsolidarRemesaCheckBox As CheckBox
    Friend WithEvents GenerarRemesaNuevaCheckBox As CheckBox
    Friend WithEvents BtnFijar As Button
    Friend WithEvents GroupBoxNueva As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtImpRecDev As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TxtnCuotas As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents CuentaOrdTextBox As TextBox
    Friend WithEvents DCOrdTextBox As TextBox
    Friend WithEvents OfOrdTextBox As TextBox
    Friend WithEvents EntOrdTextBox As TextBox
    Friend WithEvents SufOrdTextBox As TextBox
    Friend WithEvents CIFPresTextBox As TextBox
    Friend WithEvents CIFTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtUltRemesa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnVer As Button
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DTFechaCargo As DateTimePicker
    Friend WithEvents DTFechaCreac As DateTimePicker
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents BancoremesaBindingSource As BindingSource
    Friend WithEvents Banco_remesaTableAdapter As DbCensosTableAdapters.banco_remesaTableAdapter
    Friend WithEvents RemesasBindingSource As BindingSource
    Friend WithEvents RemesasTableAdapter As DbCensosTableAdapters.remesasTableAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DataSet1TableAdapters.ejercicioTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TxtRecPagados As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents NumcuotasmesTextBox As TextBox
End Class
