<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignarCuotas
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
        Dim AsignarCuotaNuevaLabel As System.Windows.Forms.Label
        Dim AñoejeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarCuotas))
        Me.AsignarCuotaNuevaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.NumCuotasTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.CuotaBaseTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumordinariosTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LoteriajuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.LoteriamayorTextBox = New System.Windows.Forms.TextBox()
        Me.NiñojuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.NiñomayorTextBox = New System.Windows.Forms.TextBox()
        Me.NavidadjuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.NavidadmayorTextBox = New System.Windows.Forms.TextBox()
        Me.OrdinariojuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.OrdinariomayorTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNumOrdinarios = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNiñoJuvenil = New System.Windows.Forms.TextBox()
        Me.TxtNavidadJuvenil = New System.Windows.Forms.TextBox()
        Me.TxtOrdJuvenil = New System.Windows.Forms.TextBox()
        Me.TxtNiñoMayor = New System.Windows.Forms.TextBox()
        Me.TxtNavidadMayor = New System.Windows.Forms.TextBox()
        Me.TxtOrdMayor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBenefJuvenil = New System.Windows.Forms.TextBox()
        Me.TxtBenefMayor = New System.Windows.Forms.TextBox()
        Me.TxtLotJuvenil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLotMayor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AñoejeTextBox = New System.Windows.Forms.TextBox()
        Me.Txt21 = New System.Windows.Forms.TextBox()
        Me.Txt20 = New System.Windows.Forms.TextBox()
        Me.Txt19 = New System.Windows.Forms.TextBox()
        Me.Txt18 = New System.Windows.Forms.TextBox()
        Me.Txt17 = New System.Windows.Forms.TextBox()
        Me.Txt16 = New System.Windows.Forms.TextBox()
        Me.Txt15 = New System.Windows.Forms.TextBox()
        Me.Txt14 = New System.Windows.Forms.TextBox()
        Me.Txt13 = New System.Windows.Forms.TextBox()
        Me.Txt12 = New System.Windows.Forms.TextBox()
        Me.Txt11 = New System.Windows.Forms.TextBox()
        Me.Txt10 = New System.Windows.Forms.TextBox()
        Me.Txt9 = New System.Windows.Forms.TextBox()
        Me.Txt8 = New System.Windows.Forms.TextBox()
        Me.Txt7 = New System.Windows.Forms.TextBox()
        Me.Txt6 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCuotas = New System.Windows.Forms.TextBox()
        Me.TxtBase = New System.Windows.Forms.TextBox()
        Me.Tipo_de_cuotasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdCUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeCuotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_de_cuotasTableAdapter = New AppGestion.DbCensosTableAdapters.tipo_de_cuotasTableAdapter()
        Me.EjercicioTableAdapter = New AppGestion.DbCensosTableAdapters.ejercicioTableAdapter()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.BtnActualizarTablaFalleros = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardarCambios = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.DataSetCuotas = New AppGestion.DataSetCuotas()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FalleroTableAdapter = New AppGestion.DataSetCuotasTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSetCuotasTableAdapters.TableAdapterManager()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager1 = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.AsignarValoresFalleroCheckBox = New System.Windows.Forms.CheckBox()
        Me.LblAsigValFallero = New System.Windows.Forms.Label()
        AsignarCuotaNuevaLabel = New System.Windows.Forms.Label()
        AñoejeLabel = New System.Windows.Forms.Label()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tipo_de_cuotasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AsignarCuotaNuevaLabel
        '
        AsignarCuotaNuevaLabel.AutoSize = True
        AsignarCuotaNuevaLabel.Location = New System.Drawing.Point(83, 44)
        AsignarCuotaNuevaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AsignarCuotaNuevaLabel.Name = "AsignarCuotaNuevaLabel"
        AsignarCuotaNuevaLabel.Size = New System.Drawing.Size(146, 17)
        AsignarCuotaNuevaLabel.TabIndex = 104
        AsignarCuotaNuevaLabel.Text = "Asignar Cuota Nueva:"
        '
        'AñoejeLabel
        '
        AñoejeLabel.AutoSize = True
        AñoejeLabel.Location = New System.Drawing.Point(59, 83)
        AñoejeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AñoejeLabel.Name = "AñoejeLabel"
        AñoejeLabel.Size = New System.Drawing.Size(82, 17)
        AñoejeLabel.TabIndex = 98
        AñoejeLabel.Text = "EJERCICIO:"
        '
        'AsignarCuotaNuevaCheckBox
        '
        Me.AsignarCuotaNuevaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadoBindingSource, "AsignarCuotaNueva", True))
        Me.AsignarCuotaNuevaCheckBox.Enabled = False
        Me.AsignarCuotaNuevaCheckBox.Location = New System.Drawing.Point(237, 38)
        Me.AsignarCuotaNuevaCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarCuotaNuevaCheckBox.Name = "AsignarCuotaNuevaCheckBox"
        Me.AsignarCuotaNuevaCheckBox.Size = New System.Drawing.Size(201, 30)
        Me.AsignarCuotaNuevaCheckBox.TabIndex = 105
        Me.AsignarCuotaNuevaCheckBox.Text = "Sin Asignar"
        Me.AsignarCuotaNuevaCheckBox.UseVisualStyleBackColor = True
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
        'NumCuotasTextBox
        '
        Me.NumCuotasTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.NumCuotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numcuotasmes", True))
        Me.NumCuotasTextBox.Location = New System.Drawing.Point(258, 143)
        Me.NumCuotasTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumCuotasTextBox.Name = "NumCuotasTextBox"
        Me.NumCuotasTextBox.ReadOnly = True
        Me.NumCuotasTextBox.Size = New System.Drawing.Size(92, 22)
        Me.NumCuotasTextBox.TabIndex = 103
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
        'CuotaBaseTextBox
        '
        Me.CuotaBaseTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CuotaBaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "cuotabase", True))
        Me.CuotaBaseTextBox.Location = New System.Drawing.Point(258, 111)
        Me.CuotaBaseTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CuotaBaseTextBox.Name = "CuotaBaseTextBox"
        Me.CuotaBaseTextBox.ReadOnly = True
        Me.CuotaBaseTextBox.Size = New System.Drawing.Size(92, 22)
        Me.CuotaBaseTextBox.TabIndex = 102
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1074, 38)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 17)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "Valores Nuevos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumordinariosTextBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.LoteriajuvenilTextBox)
        Me.GroupBox1.Controls.Add(Me.LoteriamayorTextBox)
        Me.GroupBox1.Controls.Add(Me.NiñojuvenilTextBox)
        Me.GroupBox1.Controls.Add(Me.NiñomayorTextBox)
        Me.GroupBox1.Controls.Add(Me.NavidadjuvenilTextBox)
        Me.GroupBox1.Controls.Add(Me.NavidadmayorTextBox)
        Me.GroupBox1.Controls.Add(Me.OrdinariojuvenilTextBox)
        Me.GroupBox1.Controls.Add(Me.OrdinariomayorTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtNumOrdinarios)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtNiñoJuvenil)
        Me.GroupBox1.Controls.Add(Me.TxtNavidadJuvenil)
        Me.GroupBox1.Controls.Add(Me.TxtOrdJuvenil)
        Me.GroupBox1.Controls.Add(Me.TxtNiñoMayor)
        Me.GroupBox1.Controls.Add(Me.TxtNavidadMayor)
        Me.GroupBox1.Controls.Add(Me.TxtOrdMayor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBenefJuvenil)
        Me.GroupBox1.Controls.Add(Me.TxtBenefMayor)
        Me.GroupBox1.Controls.Add(Me.TxtLotJuvenil)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtLotMayor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 197)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(463, 283)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajustes Lotería"
        '
        'NumordinariosTextBox
        '
        Me.NumordinariosTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.NumordinariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "numordinarios", True))
        Me.NumordinariosTextBox.Location = New System.Drawing.Point(352, 70)
        Me.NumordinariosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumordinariosTextBox.Name = "NumordinariosTextBox"
        Me.NumordinariosTextBox.ReadOnly = True
        Me.NumordinariosTextBox.Size = New System.Drawing.Size(67, 22)
        Me.NumordinariosTextBox.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 42)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 17)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Valores guardados"
        '
        'LoteriajuvenilTextBox
        '
        Me.LoteriajuvenilTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LoteriajuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "loteriajuvenil", True))
        Me.LoteriajuvenilTextBox.Location = New System.Drawing.Point(391, 199)
        Me.LoteriajuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LoteriajuvenilTextBox.Name = "LoteriajuvenilTextBox"
        Me.LoteriajuvenilTextBox.ReadOnly = True
        Me.LoteriajuvenilTextBox.Size = New System.Drawing.Size(53, 22)
        Me.LoteriajuvenilTextBox.TabIndex = 62
        '
        'LoteriamayorTextBox
        '
        Me.LoteriamayorTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LoteriamayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "loteriamayor", True))
        Me.LoteriamayorTextBox.Location = New System.Drawing.Point(327, 201)
        Me.LoteriamayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LoteriamayorTextBox.Name = "LoteriamayorTextBox"
        Me.LoteriamayorTextBox.ReadOnly = True
        Me.LoteriamayorTextBox.Size = New System.Drawing.Size(55, 22)
        Me.LoteriamayorTextBox.TabIndex = 60
        '
        'NiñojuvenilTextBox
        '
        Me.NiñojuvenilTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.NiñojuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "infjuvenil", True))
        Me.NiñojuvenilTextBox.Location = New System.Drawing.Point(391, 167)
        Me.NiñojuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NiñojuvenilTextBox.Name = "NiñojuvenilTextBox"
        Me.NiñojuvenilTextBox.ReadOnly = True
        Me.NiñojuvenilTextBox.Size = New System.Drawing.Size(53, 22)
        Me.NiñojuvenilTextBox.TabIndex = 58
        '
        'NiñomayorTextBox
        '
        Me.NiñomayorTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.NiñomayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "infmayor", True))
        Me.NiñomayorTextBox.Location = New System.Drawing.Point(327, 169)
        Me.NiñomayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NiñomayorTextBox.Name = "NiñomayorTextBox"
        Me.NiñomayorTextBox.ReadOnly = True
        Me.NiñomayorTextBox.Size = New System.Drawing.Size(55, 22)
        Me.NiñomayorTextBox.TabIndex = 56
        '
        'NavidadjuvenilTextBox
        '
        Me.NavidadjuvenilTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.NavidadjuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "navidadjuvenil", True))
        Me.NavidadjuvenilTextBox.Location = New System.Drawing.Point(391, 133)
        Me.NavidadjuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NavidadjuvenilTextBox.Name = "NavidadjuvenilTextBox"
        Me.NavidadjuvenilTextBox.ReadOnly = True
        Me.NavidadjuvenilTextBox.Size = New System.Drawing.Size(53, 22)
        Me.NavidadjuvenilTextBox.TabIndex = 54
        '
        'NavidadmayorTextBox
        '
        Me.NavidadmayorTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.NavidadmayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "navidadmayor", True))
        Me.NavidadmayorTextBox.Location = New System.Drawing.Point(327, 133)
        Me.NavidadmayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NavidadmayorTextBox.Name = "NavidadmayorTextBox"
        Me.NavidadmayorTextBox.ReadOnly = True
        Me.NavidadmayorTextBox.Size = New System.Drawing.Size(55, 22)
        Me.NavidadmayorTextBox.TabIndex = 53
        '
        'OrdinariojuvenilTextBox
        '
        Me.OrdinariojuvenilTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.OrdinariojuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "ordinariojuvenil", True))
        Me.OrdinariojuvenilTextBox.Location = New System.Drawing.Point(391, 101)
        Me.OrdinariojuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OrdinariojuvenilTextBox.Name = "OrdinariojuvenilTextBox"
        Me.OrdinariojuvenilTextBox.ReadOnly = True
        Me.OrdinariojuvenilTextBox.Size = New System.Drawing.Size(53, 22)
        Me.OrdinariojuvenilTextBox.TabIndex = 52
        '
        'OrdinariomayorTextBox
        '
        Me.OrdinariomayorTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.OrdinariomayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "ordinariomayor", True))
        Me.OrdinariomayorTextBox.Location = New System.Drawing.Point(327, 101)
        Me.OrdinariomayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OrdinariomayorTextBox.Name = "OrdinariomayorTextBox"
        Me.OrdinariomayorTextBox.ReadOnly = True
        Me.OrdinariomayorTextBox.Size = New System.Drawing.Size(55, 22)
        Me.OrdinariomayorTextBox.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 171)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Niño"
        '
        'TxtNumOrdinarios
        '
        Me.TxtNumOrdinarios.Location = New System.Drawing.Point(172, 70)
        Me.TxtNumOrdinarios.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumOrdinarios.Name = "TxtNumOrdinarios"
        Me.TxtNumOrdinarios.Size = New System.Drawing.Size(69, 22)
        Me.TxtNumOrdinarios.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 138)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Navidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Ordinario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Nº Ordinarios"
        '
        'TxtNiñoJuvenil
        '
        Me.TxtNiñoJuvenil.Location = New System.Drawing.Point(217, 167)
        Me.TxtNiñoJuvenil.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNiñoJuvenil.Name = "TxtNiñoJuvenil"
        Me.TxtNiñoJuvenil.Size = New System.Drawing.Size(83, 22)
        Me.TxtNiñoJuvenil.TabIndex = 43
        '
        'TxtNavidadJuvenil
        '
        Me.TxtNavidadJuvenil.Location = New System.Drawing.Point(217, 134)
        Me.TxtNavidadJuvenil.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNavidadJuvenil.Name = "TxtNavidadJuvenil"
        Me.TxtNavidadJuvenil.Size = New System.Drawing.Size(83, 22)
        Me.TxtNavidadJuvenil.TabIndex = 42
        '
        'TxtOrdJuvenil
        '
        Me.TxtOrdJuvenil.Location = New System.Drawing.Point(217, 101)
        Me.TxtOrdJuvenil.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOrdJuvenil.Name = "TxtOrdJuvenil"
        Me.TxtOrdJuvenil.Size = New System.Drawing.Size(83, 22)
        Me.TxtOrdJuvenil.TabIndex = 41
        '
        'TxtNiñoMayor
        '
        Me.TxtNiñoMayor.Location = New System.Drawing.Point(111, 169)
        Me.TxtNiñoMayor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNiñoMayor.Name = "TxtNiñoMayor"
        Me.TxtNiñoMayor.Size = New System.Drawing.Size(83, 22)
        Me.TxtNiñoMayor.TabIndex = 40
        '
        'TxtNavidadMayor
        '
        Me.TxtNavidadMayor.Location = New System.Drawing.Point(111, 135)
        Me.TxtNavidadMayor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNavidadMayor.Name = "TxtNavidadMayor"
        Me.TxtNavidadMayor.Size = New System.Drawing.Size(83, 22)
        Me.TxtNavidadMayor.TabIndex = 39
        '
        'TxtOrdMayor
        '
        Me.TxtOrdMayor.Location = New System.Drawing.Point(111, 102)
        Me.TxtOrdMayor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOrdMayor.Name = "TxtOrdMayor"
        Me.TxtOrdMayor.Size = New System.Drawing.Size(83, 22)
        Me.TxtOrdMayor.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Beneficio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Total"
        '
        'TxtBenefJuvenil
        '
        Me.TxtBenefJuvenil.Enabled = False
        Me.TxtBenefJuvenil.Location = New System.Drawing.Point(217, 233)
        Me.TxtBenefJuvenil.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBenefJuvenil.Name = "TxtBenefJuvenil"
        Me.TxtBenefJuvenil.Size = New System.Drawing.Size(83, 22)
        Me.TxtBenefJuvenil.TabIndex = 35
        '
        'TxtBenefMayor
        '
        Me.TxtBenefMayor.Enabled = False
        Me.TxtBenefMayor.Location = New System.Drawing.Point(111, 233)
        Me.TxtBenefMayor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBenefMayor.Name = "TxtBenefMayor"
        Me.TxtBenefMayor.Size = New System.Drawing.Size(83, 22)
        Me.TxtBenefMayor.TabIndex = 34
        '
        'TxtLotJuvenil
        '
        Me.TxtLotJuvenil.Enabled = False
        Me.TxtLotJuvenil.Location = New System.Drawing.Point(217, 201)
        Me.TxtLotJuvenil.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLotJuvenil.Name = "TxtLotJuvenil"
        Me.TxtLotJuvenil.Size = New System.Drawing.Size(83, 22)
        Me.TxtLotJuvenil.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Juveniles"
        '
        'TxtLotMayor
        '
        Me.TxtLotMayor.Enabled = False
        Me.TxtLotMayor.Location = New System.Drawing.Point(111, 201)
        Me.TxtLotMayor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLotMayor.Name = "TxtLotMayor"
        Me.TxtLotMayor.Size = New System.Drawing.Size(83, 22)
        Me.TxtLotMayor.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mayores"
        '
        'AñoejeTextBox
        '
        Me.AñoejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.AñoejeTextBox.Location = New System.Drawing.Point(154, 79)
        Me.AñoejeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AñoejeTextBox.Name = "AñoejeTextBox"
        Me.AñoejeTextBox.Size = New System.Drawing.Size(77, 22)
        Me.AñoejeTextBox.TabIndex = 99
        '
        'Txt21
        '
        Me.Txt21.Location = New System.Drawing.Point(1073, 603)
        Me.Txt21.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt21.Name = "Txt21"
        Me.Txt21.Size = New System.Drawing.Size(132, 22)
        Me.Txt21.TabIndex = 97
        '
        'Txt20
        '
        Me.Txt20.Location = New System.Drawing.Point(1073, 576)
        Me.Txt20.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt20.Name = "Txt20"
        Me.Txt20.Size = New System.Drawing.Size(132, 22)
        Me.Txt20.TabIndex = 96
        '
        'Txt19
        '
        Me.Txt19.Location = New System.Drawing.Point(1073, 549)
        Me.Txt19.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt19.Name = "Txt19"
        Me.Txt19.Size = New System.Drawing.Size(132, 22)
        Me.Txt19.TabIndex = 95
        '
        'Txt18
        '
        Me.Txt18.Location = New System.Drawing.Point(1073, 522)
        Me.Txt18.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt18.Name = "Txt18"
        Me.Txt18.Size = New System.Drawing.Size(132, 22)
        Me.Txt18.TabIndex = 94
        '
        'Txt17
        '
        Me.Txt17.Location = New System.Drawing.Point(1073, 495)
        Me.Txt17.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt17.Name = "Txt17"
        Me.Txt17.Size = New System.Drawing.Size(132, 22)
        Me.Txt17.TabIndex = 93
        '
        'Txt16
        '
        Me.Txt16.Location = New System.Drawing.Point(1073, 468)
        Me.Txt16.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt16.Name = "Txt16"
        Me.Txt16.Size = New System.Drawing.Size(132, 22)
        Me.Txt16.TabIndex = 92
        '
        'Txt15
        '
        Me.Txt15.Location = New System.Drawing.Point(1073, 441)
        Me.Txt15.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt15.Name = "Txt15"
        Me.Txt15.Size = New System.Drawing.Size(132, 22)
        Me.Txt15.TabIndex = 91
        '
        'Txt14
        '
        Me.Txt14.Location = New System.Drawing.Point(1073, 414)
        Me.Txt14.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt14.Name = "Txt14"
        Me.Txt14.Size = New System.Drawing.Size(132, 22)
        Me.Txt14.TabIndex = 90
        '
        'Txt13
        '
        Me.Txt13.Location = New System.Drawing.Point(1073, 387)
        Me.Txt13.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt13.Name = "Txt13"
        Me.Txt13.Size = New System.Drawing.Size(132, 22)
        Me.Txt13.TabIndex = 89
        '
        'Txt12
        '
        Me.Txt12.Location = New System.Drawing.Point(1073, 360)
        Me.Txt12.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt12.Name = "Txt12"
        Me.Txt12.Size = New System.Drawing.Size(132, 22)
        Me.Txt12.TabIndex = 88
        '
        'Txt11
        '
        Me.Txt11.Location = New System.Drawing.Point(1073, 332)
        Me.Txt11.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt11.Name = "Txt11"
        Me.Txt11.Size = New System.Drawing.Size(132, 22)
        Me.Txt11.TabIndex = 87
        '
        'Txt10
        '
        Me.Txt10.Location = New System.Drawing.Point(1073, 305)
        Me.Txt10.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt10.Name = "Txt10"
        Me.Txt10.Size = New System.Drawing.Size(132, 22)
        Me.Txt10.TabIndex = 86
        '
        'Txt9
        '
        Me.Txt9.Location = New System.Drawing.Point(1073, 278)
        Me.Txt9.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt9.Name = "Txt9"
        Me.Txt9.Size = New System.Drawing.Size(132, 22)
        Me.Txt9.TabIndex = 85
        '
        'Txt8
        '
        Me.Txt8.Location = New System.Drawing.Point(1073, 251)
        Me.Txt8.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt8.Name = "Txt8"
        Me.Txt8.Size = New System.Drawing.Size(132, 22)
        Me.Txt8.TabIndex = 84
        '
        'Txt7
        '
        Me.Txt7.Location = New System.Drawing.Point(1073, 224)
        Me.Txt7.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt7.Name = "Txt7"
        Me.Txt7.Size = New System.Drawing.Size(132, 22)
        Me.Txt7.TabIndex = 83
        '
        'Txt6
        '
        Me.Txt6.Location = New System.Drawing.Point(1073, 197)
        Me.Txt6.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt6.Name = "Txt6"
        Me.Txt6.Size = New System.Drawing.Size(132, 22)
        Me.Txt6.TabIndex = 82
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(1073, 170)
        Me.Txt5.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(132, 22)
        Me.Txt5.TabIndex = 81
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(1073, 143)
        Me.Txt4.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(132, 22)
        Me.Txt4.TabIndex = 80
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(1073, 116)
        Me.Txt3.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(132, 22)
        Me.Txt3.TabIndex = 79
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(1073, 89)
        Me.Txt2.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(132, 22)
        Me.Txt2.TabIndex = 78
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(1073, 62)
        Me.Txt1.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(132, 22)
        Me.Txt1.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(43, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 32)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Número de cuotas al año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Cuota base"
        '
        'TxtCuotas
        '
        Me.TxtCuotas.Location = New System.Drawing.Point(155, 144)
        Me.TxtCuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCuotas.Name = "TxtCuotas"
        Me.TxtCuotas.Size = New System.Drawing.Size(76, 22)
        Me.TxtCuotas.TabIndex = 71
        '
        'TxtBase
        '
        Me.TxtBase.Location = New System.Drawing.Point(155, 112)
        Me.TxtBase.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(76, 22)
        Me.TxtBase.TabIndex = 70
        '
        'Tipo_de_cuotasDataGridView
        '
        Me.Tipo_de_cuotasDataGridView.AllowUserToAddRows = False
        Me.Tipo_de_cuotasDataGridView.AllowUserToDeleteRows = False
        Me.Tipo_de_cuotasDataGridView.AutoGenerateColumns = False
        Me.Tipo_de_cuotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tipo_de_cuotasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCUOTADataGridViewTextBoxColumn, Me.DESCRIPCUOTADataGridViewTextBoxColumn, Me.CUOTADataGridViewTextBoxColumn, Me.COMISIONDataGridViewTextBoxColumn})
        Me.Tipo_de_cuotasDataGridView.DataSource = Me.TipoDeCuotasBindingSource
        Me.Tipo_de_cuotasDataGridView.Location = New System.Drawing.Point(511, 32)
        Me.Tipo_de_cuotasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Tipo_de_cuotasDataGridView.Name = "Tipo_de_cuotasDataGridView"
        Me.Tipo_de_cuotasDataGridView.ReadOnly = True
        Me.Tipo_de_cuotasDataGridView.RowHeadersWidth = 51
        Me.Tipo_de_cuotasDataGridView.Size = New System.Drawing.Size(553, 613)
        Me.Tipo_de_cuotasDataGridView.TabIndex = 69
        '
        'IdCUOTADataGridViewTextBoxColumn
        '
        Me.IdCUOTADataGridViewTextBoxColumn.DataPropertyName = "Id_CUOTA"
        Me.IdCUOTADataGridViewTextBoxColumn.HeaderText = "Id Cuota"
        Me.IdCUOTADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCUOTADataGridViewTextBoxColumn.Name = "IdCUOTADataGridViewTextBoxColumn"
        Me.IdCUOTADataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCUOTADataGridViewTextBoxColumn.Width = 70
        '
        'DESCRIPCUOTADataGridViewTextBoxColumn
        '
        Me.DESCRIPCUOTADataGridViewTextBoxColumn.DataPropertyName = "DESCRIP_CUOTA"
        Me.DESCRIPCUOTADataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DESCRIPCUOTADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESCRIPCUOTADataGridViewTextBoxColumn.Name = "DESCRIPCUOTADataGridViewTextBoxColumn"
        Me.DESCRIPCUOTADataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPCUOTADataGridViewTextBoxColumn.Width = 200
        '
        'CUOTADataGridViewTextBoxColumn
        '
        Me.CUOTADataGridViewTextBoxColumn.DataPropertyName = "CUOTA"
        Me.CUOTADataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.CUOTADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CUOTADataGridViewTextBoxColumn.Name = "CUOTADataGridViewTextBoxColumn"
        Me.CUOTADataGridViewTextBoxColumn.ReadOnly = True
        Me.CUOTADataGridViewTextBoxColumn.Width = 125
        '
        'COMISIONDataGridViewTextBoxColumn
        '
        Me.COMISIONDataGridViewTextBoxColumn.DataPropertyName = "COMISION"
        Me.COMISIONDataGridViewTextBoxColumn.HeaderText = "COMISION"
        Me.COMISIONDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.COMISIONDataGridViewTextBoxColumn.Name = "COMISIONDataGridViewTextBoxColumn"
        Me.COMISIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMISIONDataGridViewTextBoxColumn.Visible = False
        Me.COMISIONDataGridViewTextBoxColumn.Width = 125
        '
        'TipoDeCuotasBindingSource
        '
        Me.TipoDeCuotasBindingSource.DataMember = "tipo de cuotas"
        Me.TipoDeCuotasBindingSource.DataSource = Me.DbCensos
        '
        'Tipo_de_cuotasTableAdapter
        '
        Me.Tipo_de_cuotasTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'BtnActualizarTablaFalleros
        '
        Me.BtnActualizarTablaFalleros.Image = Global.AppGestion.My.Resources.Resources.page_edit
        Me.BtnActualizarTablaFalleros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizarTablaFalleros.Location = New System.Drawing.Point(55, 603)
        Me.BtnActualizarTablaFalleros.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizarTablaFalleros.Name = "BtnActualizarTablaFalleros"
        Me.BtnActualizarTablaFalleros.Size = New System.Drawing.Size(157, 46)
        Me.BtnActualizarTablaFalleros.TabIndex = 106
        Me.BtnActualizarTablaFalleros.Text = "Actualizar tabla falleros"
        Me.BtnActualizarTablaFalleros.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(283, 603)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(155, 46)
        Me.BtnSalir.TabIndex = 74
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnGuardarCambios
        '
        Me.BtnGuardarCambios.Image = CType(resources.GetObject("BtnGuardarCambios.Image"), System.Drawing.Image)
        Me.BtnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarCambios.Location = New System.Drawing.Point(258, 495)
        Me.BtnGuardarCambios.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardarCambios.Name = "BtnGuardarCambios"
        Me.BtnGuardarCambios.Size = New System.Drawing.Size(180, 46)
        Me.BtnGuardarCambios.TabIndex = 73
        Me.BtnGuardarCambios.Text = "Guardar cambios"
        Me.BtnGuardarCambios.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Image = CType(resources.GetObject("BtnCalcular.Image"), System.Drawing.Image)
        Me.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalcular.Location = New System.Drawing.Point(55, 495)
        Me.BtnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(157, 46)
        Me.BtnCalcular.TabIndex = 72
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'DataSetCuotas
        '
        Me.DataSetCuotas.DataSetName = "DataSetCuotas"
        Me.DataSetCuotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DataSetCuotas
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSetCuotasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Estado
        '
        Me.Estado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadoBindingSource, "AsignarCuotaNueva", True))
        Me.Estado.Location = New System.Drawing.Point(12, 12)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(41, 22)
        Me.Estado.TabIndex = 107
        Me.Estado.Visible = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cargoTableAdapter = Nothing
        Me.TableAdapterManager1.criteriorecompTableAdapter = Nothing
        Me.TableAdapterManager1.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager1.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager1.estadoTableAdapter = Me.EstadoTableAdapter
        Me.TableAdapterManager1.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager1.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager1.historfaTableAdapter = Nothing
        Me.TableAdapterManager1.MensajesTableAdapter = Nothing
        Me.TableAdapterManager1.recompensasejercicioTableAdapter = Nothing
        Me.TableAdapterManager1.recompensasTableAdapter = Nothing
        Me.TableAdapterManager1.remesasTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AsignarValoresFalleroCheckBox
        '
        Me.AsignarValoresFalleroCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarValoresFallero", True))
        Me.AsignarValoresFalleroCheckBox.Enabled = False
        Me.AsignarValoresFalleroCheckBox.Location = New System.Drawing.Point(237, 12)
        Me.AsignarValoresFalleroCheckBox.Name = "AsignarValoresFalleroCheckBox"
        Me.AsignarValoresFalleroCheckBox.Size = New System.Drawing.Size(183, 24)
        Me.AsignarValoresFalleroCheckBox.TabIndex = 108
        Me.AsignarValoresFalleroCheckBox.Text = "Sin Asignar"
        Me.AsignarValoresFalleroCheckBox.UseVisualStyleBackColor = True
        Me.AsignarValoresFalleroCheckBox.Visible = False
        '
        'LblAsigValFallero
        '
        Me.LblAsigValFallero.AutoSize = True
        Me.LblAsigValFallero.Location = New System.Drawing.Point(53, 12)
        Me.LblAsigValFallero.Name = "LblAsigValFallero"
        Me.LblAsigValFallero.Size = New System.Drawing.Size(176, 17)
        Me.LblAsigValFallero.TabIndex = 109
        Me.LblAsigValFallero.Text = "Valores Fallero asignados:"
        '
        'FrmAsignarCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1242, 678)
        Me.Controls.Add(Me.LblAsigValFallero)
        Me.Controls.Add(Me.AsignarValoresFalleroCheckBox)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.BtnActualizarTablaFalleros)
        Me.Controls.Add(AsignarCuotaNuevaLabel)
        Me.Controls.Add(Me.AsignarCuotaNuevaCheckBox)
        Me.Controls.Add(Me.NumCuotasTextBox)
        Me.Controls.Add(Me.CuotaBaseTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(AñoejeLabel)
        Me.Controls.Add(Me.AñoejeTextBox)
        Me.Controls.Add(Me.Txt21)
        Me.Controls.Add(Me.Txt20)
        Me.Controls.Add(Me.Txt19)
        Me.Controls.Add(Me.Txt18)
        Me.Controls.Add(Me.Txt17)
        Me.Controls.Add(Me.Txt16)
        Me.Controls.Add(Me.Txt15)
        Me.Controls.Add(Me.Txt14)
        Me.Controls.Add(Me.Txt13)
        Me.Controls.Add(Me.Txt12)
        Me.Controls.Add(Me.Txt11)
        Me.Controls.Add(Me.Txt10)
        Me.Controls.Add(Me.Txt9)
        Me.Controls.Add(Me.Txt8)
        Me.Controls.Add(Me.Txt7)
        Me.Controls.Add(Me.Txt6)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardarCambios)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtCuotas)
        Me.Controls.Add(Me.TxtBase)
        Me.Controls.Add(Me.Tipo_de_cuotasDataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "42")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAsignarCuotas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Cuotas"
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tipo_de_cuotasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDeCuotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AsignarCuotaNuevaCheckBox As CheckBox
    Friend WithEvents NumCuotasTextBox As TextBox
    Friend WithEvents CuotaBaseTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumordinariosTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LoteriajuvenilTextBox As TextBox
    Friend WithEvents LoteriamayorTextBox As TextBox
    Friend WithEvents NiñojuvenilTextBox As TextBox
    Friend WithEvents NiñomayorTextBox As TextBox
    Friend WithEvents NavidadjuvenilTextBox As TextBox
    Friend WithEvents NavidadmayorTextBox As TextBox
    Friend WithEvents OrdinariojuvenilTextBox As TextBox
    Friend WithEvents OrdinariomayorTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNumOrdinarios As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNiñoJuvenil As TextBox
    Friend WithEvents TxtNavidadJuvenil As TextBox
    Friend WithEvents TxtOrdJuvenil As TextBox
    Friend WithEvents TxtNiñoMayor As TextBox
    Friend WithEvents TxtNavidadMayor As TextBox
    Friend WithEvents TxtOrdMayor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBenefJuvenil As TextBox
    Friend WithEvents TxtBenefMayor As TextBox
    Friend WithEvents TxtLotJuvenil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLotMayor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AñoejeTextBox As TextBox
    Friend WithEvents Txt21 As TextBox
    Friend WithEvents Txt20 As TextBox
    Friend WithEvents Txt19 As TextBox
    Friend WithEvents Txt18 As TextBox
    Friend WithEvents Txt17 As TextBox
    Friend WithEvents Txt16 As TextBox
    Friend WithEvents Txt15 As TextBox
    Friend WithEvents Txt14 As TextBox
    Friend WithEvents Txt13 As TextBox
    Friend WithEvents Txt12 As TextBox
    Friend WithEvents Txt11 As TextBox
    Friend WithEvents Txt10 As TextBox
    Friend WithEvents Txt9 As TextBox
    Friend WithEvents Txt8 As TextBox
    Friend WithEvents Txt7 As TextBox
    Friend WithEvents Txt6 As TextBox
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardarCambios As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxtCuotas As TextBox
    Friend WithEvents TxtBase As TextBox
    Friend WithEvents Tipo_de_cuotasDataGridView As DataGridView
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents TipoDeCuotasBindingSource As BindingSource
    Friend WithEvents Tipo_de_cuotasTableAdapter As DbCensosTableAdapters.tipo_de_cuotasTableAdapter
    Friend WithEvents IdCUOTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCUOTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUOTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMISIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DbCensosTableAdapters.ejercicioTableAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents BtnActualizarTablaFalleros As Button
    Friend WithEvents DataSetCuotas As DataSetCuotas
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DataSetCuotasTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCuotasTableAdapters.TableAdapterManager
    Friend WithEvents Estado As TextBox
    Friend WithEvents TableAdapterManager1 As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AsignarValoresFalleroCheckBox As CheckBox
    Friend WithEvents LblAsigValFallero As Label
End Class
