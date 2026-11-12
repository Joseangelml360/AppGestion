<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarHistorial
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim TIPFALLabel As System.Windows.Forms.Label
        Dim ANO_CENLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarHistorial))
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.RecompensasAgrupacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.RecompensasFallaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.RecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FallasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.HistorfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtObserv = New System.Windows.Forms.TextBox()
        Me.TxtRecAgrup = New System.Windows.Forms.TextBox()
        Me.TxtRecFal = New System.Windows.Forms.TextBox()
        Me.TxtRecJCF = New System.Windows.Forms.TextBox()
        Me.TxtComision = New System.Windows.Forms.TextBox()
        Me.TxtFalCen = New System.Windows.Forms.TextBox()
        Me.TxtAnoCen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtCodFalla = New System.Windows.Forms.TextBox()
        Me.TxtCodJCF = New System.Windows.Forms.TextBox()
        Me.FallasTableAdapter = New AppGestion.DbCensosTableAdapters.fallasTableAdapter()
        Me.CargoTableAdapter = New AppGestion.DbCensosTableAdapters.cargoTableAdapter()
        Me.RecompensasTableAdapter = New AppGestion.DbCensosTableAdapters.recompensasTableAdapter()
        Me.RecompensasFallaTableAdapter = New AppGestion.DbCensosTableAdapters.RecompensasFallaTableAdapter()
        Me.RecompensasAgrupacionTableAdapter = New AppGestion.DbCensosTableAdapters.RecompensasAgrupacionTableAdapter()
        Me.HistorfaTableAdapter = New AppGestion.DbCensosTableAdapters.historfaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        TIPFALLabel = New System.Windows.Forms.Label()
        ANO_CENLabel = New System.Windows.Forms.Label()
        CType(Me.RecompensasAgrupacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasFallaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(79, 417)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(101, 17)
        Label9.TabIndex = 112
        Label9.Text = "REC. AGRUP.:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(91, 385)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(90, 17)
        Label10.TabIndex = 111
        Label10.Text = "REC. FALLA:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(78, 353)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(103, 17)
        Label11.TabIndex = 110
        Label11.Text = "RECOMP. JCF:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(75, 254)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(106, 17)
        Label12.TabIndex = 109
        Label12.Text = "FALLA CENSO:"
        '
        'TIPFALLabel
        '
        TIPFALLabel.AutoSize = True
        TIPFALLabel.Location = New System.Drawing.Point(104, 286)
        TIPFALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIPFALLabel.Name = "TIPFALLabel"
        TIPFALLabel.Size = New System.Drawing.Size(76, 17)
        TIPFALLabel.TabIndex = 108
        TIPFALLabel.Text = "COMISÓN:"
        '
        'ANO_CENLabel
        '
        ANO_CENLabel.AutoSize = True
        ANO_CENLabel.Location = New System.Drawing.Point(87, 222)
        ANO_CENLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ANO_CENLabel.Name = "ANO_CENLabel"
        ANO_CENLabel.Size = New System.Drawing.Size(94, 17)
        ANO_CENLabel.TabIndex = 107
        ANO_CENLabel.Text = "AÑO CENSO:"
        '
        'ComboBox6
        '
        Me.ComboBox6.DataSource = Me.RecompensasAgrupacionBindingSource
        Me.ComboBox6.DisplayMember = "DESREC"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(263, 412)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox6.TabIndex = 93
        Me.ComboBox6.ValueMember = "RECOM"
        '
        'RecompensasAgrupacionBindingSource
        '
        Me.RecompensasAgrupacionBindingSource.DataMember = "RecompensasAgrupacion"
        Me.RecompensasAgrupacionBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox5
        '
        Me.ComboBox5.DataSource = Me.RecompensasFallaBindingSource
        Me.ComboBox5.DisplayMember = "DESREC"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(263, 378)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox5.TabIndex = 92
        Me.ComboBox5.ValueMember = "RECOM"
        '
        'RecompensasFallaBindingSource
        '
        Me.RecompensasFallaBindingSource.DataMember = "RecompensasFalla"
        Me.RecompensasFallaBindingSource.DataSource = Me.DbCensos
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.RecompensasBindingSource
        Me.ComboBox4.DisplayMember = "DESREC"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(263, 345)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox4.TabIndex = 91
        Me.ComboBox4.ValueMember = "RECOM"
        '
        'RecompensasBindingSource
        '
        Me.RecompensasBindingSource.DataMember = "recompensas"
        Me.RecompensasBindingSource.DataSource = Me.DbCensos
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.CargoBindingSource
        Me.ComboBox3.DisplayMember = "DESCRIP"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(263, 316)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox3.TabIndex = 90
        Me.ComboBox3.ValueMember = "CARGO"
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.DbCensos
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Mayores", "Juveniles", "Infantiles"})
        Me.ComboBox2.Location = New System.Drawing.Point(263, 282)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox2.TabIndex = 89
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.FallasBindingSource
        Me.ComboBox1.DisplayMember = "DESFAL"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(263, 249)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 88
        Me.ComboBox1.ValueMember = "NUMFAL"
        '
        'FallasBindingSource
        '
        Me.FallasBindingSource.DataMember = "fallas"
        Me.FallasBindingSource.DataSource = Me.DbCensos
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(520, 500)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 95
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(46, 500)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(157, 46)
        Me.BtnGuardar.TabIndex = 94
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtCargo
        '
        Me.TxtCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "CARGO", True))
        Me.TxtCargo.Location = New System.Drawing.Point(192, 316)
        Me.TxtCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(61, 22)
        Me.TxtCargo.TabIndex = 83
        '
        'HistorfaBindingSource
        '
        Me.HistorfaBindingSource.DataMember = "historfa"
        Me.HistorfaBindingSource.DataSource = Me.DbCensos
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 319)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "CARGO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 449)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 17)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "OBSERVACIONES:"
        '
        'TxtObserv
        '
        Me.TxtObserv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "OBSERVACIO", True))
        Me.TxtObserv.Location = New System.Drawing.Point(192, 445)
        Me.TxtObserv.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtObserv.Name = "TxtObserv"
        Me.TxtObserv.Size = New System.Drawing.Size(481, 22)
        Me.TxtObserv.TabIndex = 87
        '
        'TxtRecAgrup
        '
        Me.TxtRecAgrup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "REC_AGRUP", True))
        Me.TxtRecAgrup.Location = New System.Drawing.Point(192, 413)
        Me.TxtRecAgrup.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecAgrup.Name = "TxtRecAgrup"
        Me.TxtRecAgrup.Size = New System.Drawing.Size(61, 22)
        Me.TxtRecAgrup.TabIndex = 86
        '
        'TxtRecFal
        '
        Me.TxtRecFal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "REC_FAL", True))
        Me.TxtRecFal.Location = New System.Drawing.Point(192, 381)
        Me.TxtRecFal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecFal.Name = "TxtRecFal"
        Me.TxtRecFal.Size = New System.Drawing.Size(61, 22)
        Me.TxtRecFal.TabIndex = 85
        '
        'TxtRecJCF
        '
        Me.TxtRecJCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "RECOM", True))
        Me.TxtRecJCF.Location = New System.Drawing.Point(192, 349)
        Me.TxtRecJCF.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecJCF.Name = "TxtRecJCF"
        Me.TxtRecJCF.Size = New System.Drawing.Size(61, 22)
        Me.TxtRecJCF.TabIndex = 84
        '
        'TxtComision
        '
        Me.TxtComision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "TIPFAL", True))
        Me.TxtComision.Location = New System.Drawing.Point(192, 282)
        Me.TxtComision.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtComision.Name = "TxtComision"
        Me.TxtComision.Size = New System.Drawing.Size(61, 22)
        Me.TxtComision.TabIndex = 82
        '
        'TxtFalCen
        '
        Me.TxtFalCen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "FALLA", True))
        Me.TxtFalCen.Location = New System.Drawing.Point(192, 250)
        Me.TxtFalCen.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFalCen.Name = "TxtFalCen"
        Me.TxtFalCen.Size = New System.Drawing.Size(61, 22)
        Me.TxtFalCen.TabIndex = 81
        '
        'TxtAnoCen
        '
        Me.TxtAnoCen.Location = New System.Drawing.Point(192, 218)
        Me.TxtAnoCen.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAnoCen.Name = "TxtAnoCen"
        Me.TxtAnoCen.Size = New System.Drawing.Size(61, 22)
        Me.TxtAnoCen.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(360, 125)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Apellidos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(498, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Cód. falla:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Cód. JCF:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 20)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Editar registro de Historial de fallero"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(438, 121)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(239, 22)
        Me.TxtApellidos.TabIndex = 100
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(170, 121)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 22)
        Me.TxtNombre.TabIndex = 99
        '
        'TxtDNI
        '
        Me.TxtDNI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "DNI", True))
        Me.TxtDNI.Location = New System.Drawing.Point(544, 89)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(132, 22)
        Me.TxtDNI.TabIndex = 98
        '
        'TxtCodFalla
        '
        Me.TxtCodFalla.Location = New System.Drawing.Point(364, 89)
        Me.TxtCodFalla.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodFalla.Name = "TxtCodFalla"
        Me.TxtCodFalla.Size = New System.Drawing.Size(56, 22)
        Me.TxtCodFalla.TabIndex = 97
        '
        'TxtCodJCF
        '
        Me.TxtCodJCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorfaBindingSource, "CODIGO", True))
        Me.TxtCodJCF.Location = New System.Drawing.Point(170, 89)
        Me.TxtCodJCF.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodJCF.Name = "TxtCodJCF"
        Me.TxtCodJCF.Size = New System.Drawing.Size(60, 22)
        Me.TxtCodJCF.TabIndex = 96
        '
        'FallasTableAdapter
        '
        Me.FallasTableAdapter.ClearBeforeFill = True
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'RecompensasTableAdapter
        '
        Me.RecompensasTableAdapter.ClearBeforeFill = True
        '
        'RecompensasFallaTableAdapter
        '
        Me.RecompensasFallaTableAdapter.ClearBeforeFill = True
        '
        'RecompensasAgrupacionTableAdapter
        '
        Me.RecompensasAgrupacionTableAdapter.ClearBeforeFill = True
        '
        'HistorfaTableAdapter
        '
        Me.HistorfaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.datos_banco_para_abonosTableAdapter = Nothing
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa1TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa2TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.fallasTableAdapter = Nothing
        Me.TableAdapterManager.falleroTableAdapter = Nothing
        Me.TableAdapterManager.letradniTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmEditarHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(722, 573)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtObserv)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.TxtRecAgrup)
        Me.Controls.Add(Me.TxtRecFal)
        Me.Controls.Add(Me.TxtRecJCF)
        Me.Controls.Add(Me.TxtComision)
        Me.Controls.Add(Me.TxtFalCen)
        Me.Controls.Add(Me.TxtAnoCen)
        Me.Controls.Add(TIPFALLabel)
        Me.Controls.Add(ANO_CENLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtCodFalla)
        Me.Controls.Add(Me.TxtCodJCF)
        Me.HelpProvider1.SetHelpKeyword(Me, "52")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditarHistorial"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Historial"
        CType(Me.RecompensasAgrupacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasFallaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtObserv As TextBox
    Friend WithEvents TxtRecAgrup As TextBox
    Friend WithEvents TxtRecFal As TextBox
    Friend WithEvents TxtRecJCF As TextBox
    Friend WithEvents TxtComision As TextBox
    Friend WithEvents TxtFalCen As TextBox
    Friend WithEvents TxtAnoCen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtCodFalla As TextBox
    Friend WithEvents TxtCodJCF As TextBox
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FallasBindingSource As BindingSource
    Friend WithEvents FallasTableAdapter As DbCensosTableAdapters.fallasTableAdapter
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As DbCensosTableAdapters.cargoTableAdapter
    Friend WithEvents RecompensasBindingSource As BindingSource
    Friend WithEvents RecompensasTableAdapter As DbCensosTableAdapters.recompensasTableAdapter
    Friend WithEvents RecompensasFallaBindingSource As BindingSource
    Friend WithEvents RecompensasFallaTableAdapter As DbCensosTableAdapters.RecompensasFallaTableAdapter
    Friend WithEvents RecompensasAgrupacionBindingSource As BindingSource
    Friend WithEvents RecompensasAgrupacionTableAdapter As DbCensosTableAdapters.RecompensasAgrupacionTableAdapter
    Friend WithEvents HistorfaBindingSource As BindingSource
    Friend WithEvents HistorfaTableAdapter As DbCensosTableAdapters.historfaTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
