<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAñadirRegistroRecompensa
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
        Dim DNILabel As System.Windows.Forms.Label
        Dim FALLERO_CODIGOLabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim TIPFALLabel As System.Windows.Forms.Label
        Dim COD_RECLabel As System.Windows.Forms.Label
        Dim ANO_RECLabel As System.Windows.Forms.Label
        Dim FAL_RECLabel As System.Windows.Forms.Label
        Dim FAL_CENLabel As System.Windows.Forms.Label
        Dim REC_FALLabel As System.Windows.Forms.Label
        Dim ANO_CENLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim ULTCARLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.TxtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.DgvFallero = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.TIPFALTextBox = New System.Windows.Forms.TextBox()
        Me.COD_RECTextBox = New System.Windows.Forms.TextBox()
        Me.ANO_RECTextBox = New System.Windows.Forms.TextBox()
        Me.FAL_RECTextBox = New System.Windows.Forms.TextBox()
        Me.FAL_CENTextBox = New System.Windows.Forms.TextBox()
        Me.REC_FALTextBox = New System.Windows.Forms.TextBox()
        Me.ANO_CENTextBox = New System.Windows.Forms.TextBox()
        Me.TxtNEjeJCF = New System.Windows.Forms.TextBox()
        Me.ULTCARTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCalculo = New System.Windows.Forms.GroupBox()
        Me.TxtRecFalla = New System.Windows.Forms.TextBox()
        Me.TxtRecJCF = New System.Windows.Forms.TextBox()
        Me.TxtEjeFalla = New System.Windows.Forms.TextBox()
        Me.TxtEjeCargo = New System.Windows.Forms.TextBox()
        Me.TxtRecFalnew = New System.Windows.Forms.TextBox()
        Me.TxtRecAgrnew = New System.Windows.Forms.TextBox()
        Me.TxtRecJCFnew = New System.Windows.Forms.TextBox()
        Me.GroupBoxAñadir = New System.Windows.Forms.GroupBox()
        Me.BtnVerHistorfa = New System.Windows.Forms.Button()
        Me.BtnInsertReg = New System.Windows.Forms.Button()
        Me.BtnCalculoRec = New System.Windows.Forms.Button()
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.HistorfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorfaTableAdapter = New AppGestion.DataSet1TableAdapters.historfaTableAdapter()
        Me.TableAdapterManager1 = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.CriteriorecompBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriteriorecompTableAdapter = New AppGestion.DataSet1TableAdapters.criteriorecompTableAdapter()
        Me.RecompensasejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecompensasejercicioTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasejercicioTableAdapter()
        Me.RecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecompensasTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasTableAdapter()
        DNILabel = New System.Windows.Forms.Label()
        FALLERO_CODIGOLabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        CODIGOLabel = New System.Windows.Forms.Label()
        TIPFALLabel = New System.Windows.Forms.Label()
        COD_RECLabel = New System.Windows.Forms.Label()
        ANO_RECLabel = New System.Windows.Forms.Label()
        FAL_RECLabel = New System.Windows.Forms.Label()
        FAL_CENLabel = New System.Windows.Forms.Label()
        REC_FALLabel = New System.Windows.Forms.Label()
        ANO_CENLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        ULTCARLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxCalculo.SuspendLayout()
        Me.GroupBoxAñadir.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriorecompBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(95, 149)
        DNILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(37, 18)
        DNILabel.TabIndex = 53
        DNILabel.Text = "DNI:"
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(41, 119)
        FALLERO_CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(91, 18)
        FALLERO_CODIGOLabel.TabIndex = 51
        FALLERO_CODIGOLabel.Text = "Código Falla"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(65, 209)
        APELLIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(67, 18)
        APELLIDOSLabel.TabIndex = 45
        APELLIDOSLabel.Text = "Apellidos"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(70, 176)
        NOMBRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(62, 18)
        NOMBRELabel.TabIndex = 43
        NOMBRELabel.Text = "Nombre"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(44, 89)
        CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(88, 18)
        CODIGOLabel.TabIndex = 41
        CODIGOLabel.Text = "Código JCF"
        '
        'TIPFALLabel
        '
        TIPFALLabel.AutoSize = True
        TIPFALLabel.Location = New System.Drawing.Point(60, 238)
        TIPFALLabel.Name = "TIPFALLabel"
        TIPFALLabel.Size = New System.Drawing.Size(72, 18)
        TIPFALLabel.TabIndex = 57
        TIPFALLabel.Text = "Comisión"
        '
        'COD_RECLabel
        '
        COD_RECLabel.AutoSize = True
        COD_RECLabel.Location = New System.Drawing.Point(19, 266)
        COD_RECLabel.Name = "COD_RECLabel"
        COD_RECLabel.Size = New System.Drawing.Size(113, 18)
        COD_RECLabel.TabIndex = 58
        COD_RECLabel.Text = "Ultima Rec JCF"
        '
        'ANO_RECLabel
        '
        ANO_RECLabel.AutoSize = True
        ANO_RECLabel.Location = New System.Drawing.Point(25, 322)
        ANO_RECLabel.Name = "ANO_RECLabel"
        ANO_RECLabel.Size = New System.Drawing.Size(107, 18)
        ANO_RECLabel.TabIndex = 59
        ANO_RECLabel.Text = "Año concesión"
        '
        'FAL_RECLabel
        '
        FAL_RECLabel.AutoSize = True
        FAL_RECLabel.Location = New System.Drawing.Point(6, 294)
        FAL_RECLabel.Name = "FAL_RECLabel"
        FAL_RECLabel.Size = New System.Drawing.Size(126, 18)
        FAL_RECLabel.TabIndex = 60
        FAL_RECLabel.Text = "Falla recompensa"
        '
        'FAL_CENLabel
        '
        FAL_CENLabel.AutoSize = True
        FAL_CENLabel.Location = New System.Drawing.Point(93, 31)
        FAL_CENLabel.Name = "FAL_CENLabel"
        FAL_CENLabel.Size = New System.Drawing.Size(39, 18)
        FAL_CENLabel.TabIndex = 61
        FAL_CENLabel.Text = "Falla"
        '
        'REC_FALLabel
        '
        REC_FALLabel.AutoSize = True
        REC_FALLabel.Location = New System.Drawing.Point(12, 352)
        REC_FALLabel.Name = "REC_FALLabel"
        REC_FALLabel.Size = New System.Drawing.Size(120, 18)
        REC_FALLabel.TabIndex = 62
        REC_FALLabel.Text = "Ultima Rec. Falla"
        '
        'ANO_CENLabel
        '
        ANO_CENLabel.AutoSize = True
        ANO_CENLabel.Location = New System.Drawing.Point(50, 60)
        ANO_CENLabel.Name = "ANO_CENLabel"
        ANO_CENLabel.Size = New System.Drawing.Size(82, 18)
        ANO_CENLabel.TabIndex = 63
        ANO_CENLabel.Text = "Año Censo"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(50, 47)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(115, 17)
        Label4.TabIndex = 66
        Label4.Text = "Nº Ejercicios JCF"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(40, 160)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(125, 17)
        Label5.TabIndex = 67
        Label5.Text = "Recompensa Falla"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(44, 102)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(121, 17)
        Label6.TabIndex = 68
        Label6.Text = "Nº Ejercicios Falla"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(11, 74)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(154, 17)
        Label7.TabIndex = 69
        Label7.Text = "Nº Ejercicios con cargo"
        '
        'ULTCARLabel
        '
        ULTCARLabel.AutoSize = True
        ULTCARLabel.Location = New System.Drawing.Point(83, 378)
        ULTCARLabel.Name = "ULTCARLabel"
        ULTCARLabel.Size = New System.Drawing.Size(49, 18)
        ULTCARLabel.TabIndex = 69
        ULTCARLabel.Text = "Cargo"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(46, 130)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(119, 17)
        Label8.TabIndex = 73
        Label8.Text = "Recompensa JCF"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(62, 53)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(119, 17)
        Label9.TabIndex = 78
        Label9.Text = "Recompensa JCF"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(14, 111)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(167, 17)
        Label10.TabIndex = 79
        Label10.Text = "Recompensa Agrupación"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(56, 81)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(125, 17)
        Label11.TabIndex = 80
        Label11.Text = "Recompensa Falla"
        '
        'TxtBuscarCodigo
        '
        Me.TxtBuscarCodigo.Location = New System.Drawing.Point(605, 51)
        Me.TxtBuscarCodigo.Name = "TxtBuscarCodigo"
        Me.TxtBuscarCodigo.Size = New System.Drawing.Size(108, 22)
        Me.TxtBuscarCodigo.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(476, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Buscar por código"
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DNI", True))
        Me.DNITextBox.Enabled = False
        Me.DNITextBox.Location = New System.Drawing.Point(141, 146)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(132, 24)
        Me.DNITextBox.TabIndex = 54
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
        'FALLERO_CODIGOTextBox
        '
        Me.FALLERO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.FALLERO_CODIGOTextBox.Enabled = False
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(141, 116)
        Me.FALLERO_CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(132, 24)
        Me.FALLERO_CODIGOTextBox.TabIndex = 52
        '
        'DgvFallero
        '
        Me.DgvFallero.AllowUserToAddRows = False
        Me.DgvFallero.AllowUserToDeleteRows = False
        Me.DgvFallero.AutoGenerateColumns = False
        Me.DgvFallero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFallero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.APELLIDOS, Me.NOMBRE})
        Me.DgvFallero.DataSource = Me.FalleroBindingSource
        Me.DgvFallero.Location = New System.Drawing.Point(422, 119)
        Me.DgvFallero.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvFallero.Name = "DgvFallero"
        Me.DgvFallero.ReadOnly = True
        Me.DgvFallero.RowHeadersWidth = 51
        Me.DgvFallero.Size = New System.Drawing.Size(509, 129)
        Me.DgvFallero.TabIndex = 49
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "Cód."
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 50
        '
        'APELLIDOS
        '
        Me.APELLIDOS.DataPropertyName = "APELLIDOS"
        Me.APELLIDOS.HeaderText = "Apellidos"
        Me.APELLIDOS.MinimumWidth = 6
        Me.APELLIDOS.Name = "APELLIDOS"
        Me.APELLIDOS.ReadOnly = True
        Me.APELLIDOS.Width = 126
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 200
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(607, 81)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(246, 22)
        Me.TxtBuscar.TabIndex = 48
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1162, 13)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 47
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Enabled = False
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(141, 206)
        Me.APELLIDOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(199, 24)
        Me.APELLIDOSTextBox.TabIndex = 46
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Enabled = False
        Me.NOMBRETextBox.Location = New System.Drawing.Point(141, 176)
        Me.NOMBRETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(132, 24)
        Me.NOMBRETextBox.TabIndex = 44
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_JCF", True))
        Me.CODIGOTextBox.Enabled = False
        Me.CODIGOTextBox.Location = New System.Drawing.Point(141, 86)
        Me.CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(132, 24)
        Me.CODIGOTextBox.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(462, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Buscar por apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Añadir Registro de fallero a Recompensas"
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
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TIPFALTextBox
        '
        Me.TIPFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TIPFAL", True))
        Me.TIPFALTextBox.Enabled = False
        Me.TIPFALTextBox.Location = New System.Drawing.Point(141, 235)
        Me.TIPFALTextBox.Name = "TIPFALTextBox"
        Me.TIPFALTextBox.Size = New System.Drawing.Size(100, 24)
        Me.TIPFALTextBox.TabIndex = 58
        '
        'COD_RECTextBox
        '
        Me.COD_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_REC", True))
        Me.COD_RECTextBox.Enabled = False
        Me.COD_RECTextBox.Location = New System.Drawing.Point(141, 263)
        Me.COD_RECTextBox.Name = "COD_RECTextBox"
        Me.COD_RECTextBox.Size = New System.Drawing.Size(100, 24)
        Me.COD_RECTextBox.TabIndex = 59
        '
        'ANO_RECTextBox
        '
        Me.ANO_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ANO_REC", True))
        Me.ANO_RECTextBox.Enabled = False
        Me.ANO_RECTextBox.Location = New System.Drawing.Point(141, 319)
        Me.ANO_RECTextBox.Name = "ANO_RECTextBox"
        Me.ANO_RECTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ANO_RECTextBox.TabIndex = 60
        '
        'FAL_RECTextBox
        '
        Me.FAL_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FAL_REC", True))
        Me.FAL_RECTextBox.Enabled = False
        Me.FAL_RECTextBox.Location = New System.Drawing.Point(141, 291)
        Me.FAL_RECTextBox.Name = "FAL_RECTextBox"
        Me.FAL_RECTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FAL_RECTextBox.TabIndex = 61
        '
        'FAL_CENTextBox
        '
        Me.FAL_CENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FAL_CEN", True))
        Me.FAL_CENTextBox.Enabled = False
        Me.FAL_CENTextBox.Location = New System.Drawing.Point(141, 29)
        Me.FAL_CENTextBox.Name = "FAL_CENTextBox"
        Me.FAL_CENTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FAL_CENTextBox.TabIndex = 62
        '
        'REC_FALTextBox
        '
        Me.REC_FALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "REC_FAL", True))
        Me.REC_FALTextBox.Enabled = False
        Me.REC_FALTextBox.Location = New System.Drawing.Point(141, 348)
        Me.REC_FALTextBox.Name = "REC_FALTextBox"
        Me.REC_FALTextBox.Size = New System.Drawing.Size(100, 24)
        Me.REC_FALTextBox.TabIndex = 63
        '
        'ANO_CENTextBox
        '
        Me.ANO_CENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ANO_CEN", True))
        Me.ANO_CENTextBox.Enabled = False
        Me.ANO_CENTextBox.Location = New System.Drawing.Point(141, 57)
        Me.ANO_CENTextBox.Name = "ANO_CENTextBox"
        Me.ANO_CENTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ANO_CENTextBox.TabIndex = 64
        '
        'TxtNEjeJCF
        '
        Me.TxtNEjeJCF.Enabled = False
        Me.TxtNEjeJCF.Location = New System.Drawing.Point(171, 44)
        Me.TxtNEjeJCF.Name = "TxtNEjeJCF"
        Me.TxtNEjeJCF.Size = New System.Drawing.Size(53, 22)
        Me.TxtNEjeJCF.TabIndex = 65
        '
        'ULTCARTextBox
        '
        Me.ULTCARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ULTCAR", True))
        Me.ULTCARTextBox.Enabled = False
        Me.ULTCARTextBox.Location = New System.Drawing.Point(141, 375)
        Me.ULTCARTextBox.Name = "ULTCARTextBox"
        Me.ULTCARTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ULTCARTextBox.TabIndex = 70
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CODIGOLabel)
        Me.GroupBox1.Controls.Add(ULTCARLabel)
        Me.GroupBox1.Controls.Add(Me.CODIGOTextBox)
        Me.GroupBox1.Controls.Add(Me.ULTCARTextBox)
        Me.GroupBox1.Controls.Add(Me.NOMBRETextBox)
        Me.GroupBox1.Controls.Add(NOMBRELabel)
        Me.GroupBox1.Controls.Add(FAL_CENLabel)
        Me.GroupBox1.Controls.Add(ANO_CENLabel)
        Me.GroupBox1.Controls.Add(Me.FAL_CENTextBox)
        Me.GroupBox1.Controls.Add(Me.APELLIDOSTextBox)
        Me.GroupBox1.Controls.Add(Me.ANO_CENTextBox)
        Me.GroupBox1.Controls.Add(APELLIDOSLabel)
        Me.GroupBox1.Controls.Add(Me.FALLERO_CODIGOTextBox)
        Me.GroupBox1.Controls.Add(FALLERO_CODIGOLabel)
        Me.GroupBox1.Controls.Add(Me.REC_FALTextBox)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(REC_FALLabel)
        Me.GroupBox1.Controls.Add(Me.TIPFALTextBox)
        Me.GroupBox1.Controls.Add(TIPFALLabel)
        Me.GroupBox1.Controls.Add(Me.COD_RECTextBox)
        Me.GroupBox1.Controls.Add(COD_RECLabel)
        Me.GroupBox1.Controls.Add(FAL_RECLabel)
        Me.GroupBox1.Controls.Add(Me.ANO_RECTextBox)
        Me.GroupBox1.Controls.Add(Me.FAL_RECTextBox)
        Me.GroupBox1.Controls.Add(ANO_RECLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 434)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de censo"
        '
        'GroupBoxCalculo
        '
        Me.GroupBoxCalculo.Controls.Add(Me.TxtRecFalla)
        Me.GroupBoxCalculo.Controls.Add(Me.TxtRecJCF)
        Me.GroupBoxCalculo.Controls.Add(Me.TxtEjeFalla)
        Me.GroupBoxCalculo.Controls.Add(Me.TxtEjeCargo)
        Me.GroupBoxCalculo.Controls.Add(Label8)
        Me.GroupBoxCalculo.Controls.Add(Label6)
        Me.GroupBoxCalculo.Controls.Add(Label5)
        Me.GroupBoxCalculo.Controls.Add(Label4)
        Me.GroupBoxCalculo.Controls.Add(Label7)
        Me.GroupBoxCalculo.Controls.Add(Me.TxtNEjeJCF)
        Me.GroupBoxCalculo.Location = New System.Drawing.Point(993, 119)
        Me.GroupBoxCalculo.Name = "GroupBoxCalculo"
        Me.GroupBoxCalculo.Size = New System.Drawing.Size(263, 201)
        Me.GroupBoxCalculo.TabIndex = 72
        Me.GroupBoxCalculo.TabStop = False
        Me.GroupBoxCalculo.Text = "Datos calculados"
        '
        'TxtRecFalla
        '
        Me.TxtRecFalla.Enabled = False
        Me.TxtRecFalla.Location = New System.Drawing.Point(171, 155)
        Me.TxtRecFalla.Name = "TxtRecFalla"
        Me.TxtRecFalla.Size = New System.Drawing.Size(53, 22)
        Me.TxtRecFalla.TabIndex = 74
        '
        'TxtRecJCF
        '
        Me.TxtRecJCF.Enabled = False
        Me.TxtRecJCF.Location = New System.Drawing.Point(171, 127)
        Me.TxtRecJCF.Name = "TxtRecJCF"
        Me.TxtRecJCF.Size = New System.Drawing.Size(53, 22)
        Me.TxtRecJCF.TabIndex = 75
        '
        'TxtEjeFalla
        '
        Me.TxtEjeFalla.Enabled = False
        Me.TxtEjeFalla.Location = New System.Drawing.Point(171, 99)
        Me.TxtEjeFalla.Name = "TxtEjeFalla"
        Me.TxtEjeFalla.Size = New System.Drawing.Size(53, 22)
        Me.TxtEjeFalla.TabIndex = 76
        '
        'TxtEjeCargo
        '
        Me.TxtEjeCargo.Enabled = False
        Me.TxtEjeCargo.Location = New System.Drawing.Point(171, 71)
        Me.TxtEjeCargo.Name = "TxtEjeCargo"
        Me.TxtEjeCargo.Size = New System.Drawing.Size(53, 22)
        Me.TxtEjeCargo.TabIndex = 77
        '
        'TxtRecFalnew
        '
        Me.TxtRecFalnew.Location = New System.Drawing.Point(187, 78)
        Me.TxtRecFalnew.Name = "TxtRecFalnew"
        Me.TxtRecFalnew.Size = New System.Drawing.Size(53, 22)
        Me.TxtRecFalnew.TabIndex = 73
        '
        'TxtRecAgrnew
        '
        Me.TxtRecAgrnew.Location = New System.Drawing.Point(187, 106)
        Me.TxtRecAgrnew.Name = "TxtRecAgrnew"
        Me.TxtRecAgrnew.Size = New System.Drawing.Size(53, 22)
        Me.TxtRecAgrnew.TabIndex = 74
        '
        'TxtRecJCFnew
        '
        Me.TxtRecJCFnew.Location = New System.Drawing.Point(187, 50)
        Me.TxtRecJCFnew.Name = "TxtRecJCFnew"
        Me.TxtRecJCFnew.Size = New System.Drawing.Size(53, 22)
        Me.TxtRecJCFnew.TabIndex = 75
        '
        'GroupBoxAñadir
        '
        Me.GroupBoxAñadir.Controls.Add(Label11)
        Me.GroupBoxAñadir.Controls.Add(Me.TxtRecFalnew)
        Me.GroupBoxAñadir.Controls.Add(Label10)
        Me.GroupBoxAñadir.Controls.Add(Me.TxtRecAgrnew)
        Me.GroupBoxAñadir.Controls.Add(Label9)
        Me.GroupBoxAñadir.Controls.Add(Me.TxtRecJCFnew)
        Me.GroupBoxAñadir.Location = New System.Drawing.Point(988, 347)
        Me.GroupBoxAñadir.Name = "GroupBoxAñadir"
        Me.GroupBoxAñadir.Size = New System.Drawing.Size(268, 139)
        Me.GroupBoxAñadir.TabIndex = 81
        Me.GroupBoxAñadir.TabStop = False
        Me.GroupBoxAñadir.Text = "Asignar Recompensas"
        '
        'BtnVerHistorfa
        '
        Me.BtnVerHistorfa.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnVerHistorfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerHistorfa.Location = New System.Drawing.Point(594, 302)
        Me.BtnVerHistorfa.Name = "BtnVerHistorfa"
        Me.BtnVerHistorfa.Size = New System.Drawing.Size(122, 35)
        Me.BtnVerHistorfa.TabIndex = 82
        Me.BtnVerHistorfa.Text = "Ver historial"
        Me.BtnVerHistorfa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVerHistorfa.UseVisualStyleBackColor = True
        '
        'BtnInsertReg
        '
        Me.BtnInsertReg.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnInsertReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsertReg.Location = New System.Drawing.Point(572, 400)
        Me.BtnInsertReg.Name = "BtnInsertReg"
        Me.BtnInsertReg.Size = New System.Drawing.Size(167, 35)
        Me.BtnInsertReg.TabIndex = 83
        Me.BtnInsertReg.Text = "Guardar cambios"
        Me.BtnInsertReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsertReg.UseVisualStyleBackColor = True
        '
        'BtnCalculoRec
        '
        Me.BtnCalculoRec.Image = Global.AppGestion.My.Resources.Resources.calculator
        Me.BtnCalculoRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalculoRec.Location = New System.Drawing.Point(594, 354)
        Me.BtnCalculoRec.Name = "BtnCalculoRec"
        Me.BtnCalculoRec.Size = New System.Drawing.Size(122, 35)
        Me.BtnCalculoRec.TabIndex = 84
        Me.BtnCalculoRec.Text = "Calcular"
        Me.BtnCalculoRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCalculoRec.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistorfaBindingSource
        '
        Me.HistorfaBindingSource.DataMember = "historfa"
        Me.HistorfaBindingSource.DataSource = Me.DataSet1
        '
        'HistorfaTableAdapter
        '
        Me.HistorfaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cargoTableAdapter = Nothing
        Me.TableAdapterManager1.criteriorecompTableAdapter = Me.CriteriorecompTableAdapter
        Me.TableAdapterManager1.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager1.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager1.estadoTableAdapter = Nothing
        Me.TableAdapterManager1.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager1.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager1.historfaTableAdapter = Me.HistorfaTableAdapter
        Me.TableAdapterManager1.MensajesTableAdapter = Nothing
        Me.TableAdapterManager1.recompensasejercicioTableAdapter = Me.RecompensasejercicioTableAdapter
        Me.TableAdapterManager1.recompensasTableAdapter = Me.RecompensasTableAdapter
        Me.TableAdapterManager1.remesasTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CriteriorecompBindingSource
        '
        Me.CriteriorecompBindingSource.DataMember = "criteriorecomp"
        Me.CriteriorecompBindingSource.DataSource = Me.DataSet1
        '
        'CriteriorecompTableAdapter
        '
        Me.CriteriorecompTableAdapter.ClearBeforeFill = True
        '
        'RecompensasejercicioBindingSource
        '
        Me.RecompensasejercicioBindingSource.DataMember = "recompensasejercicio"
        Me.RecompensasejercicioBindingSource.DataSource = Me.DataSet1
        '
        'RecompensasejercicioTableAdapter
        '
        Me.RecompensasejercicioTableAdapter.ClearBeforeFill = True
        '
        'RecompensasBindingSource
        '
        Me.RecompensasBindingSource.DataMember = "recompensas"
        Me.RecompensasBindingSource.DataSource = Me.DataSet1
        '
        'RecompensasTableAdapter
        '
        Me.RecompensasTableAdapter.ClearBeforeFill = True
        '
        'FrmAñadirRegistroRecompensa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 535)
        Me.Controls.Add(Me.BtnCalculoRec)
        Me.Controls.Add(Me.BtnInsertReg)
        Me.Controls.Add(Me.BtnVerHistorfa)
        Me.Controls.Add(Me.GroupBoxAñadir)
        Me.Controls.Add(Me.GroupBoxCalculo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscarCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DgvFallero)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "REC_FAL", True))
        Me.Name = "FrmAñadirRegistroRecompensa"
        Me.Text = "Añadir Registro a Recompensa"
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxCalculo.ResumeLayout(False)
        Me.GroupBoxCalculo.PerformLayout()
        Me.GroupBoxAñadir.ResumeLayout(False)
        Me.GroupBoxAñadir.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriorecompBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBuscarCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents DgvFallero As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents TIPFALTextBox As TextBox
    Friend WithEvents COD_RECTextBox As TextBox
    Friend WithEvents ANO_RECTextBox As TextBox
    Friend WithEvents FAL_RECTextBox As TextBox
    Friend WithEvents FAL_CENTextBox As TextBox
    Friend WithEvents REC_FALTextBox As TextBox
    Friend WithEvents ANO_CENTextBox As TextBox
    Friend WithEvents TxtNEjeJCF As TextBox
    Friend WithEvents ULTCARTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBoxCalculo As GroupBox
    Friend WithEvents TxtRecFalla As TextBox
    Friend WithEvents TxtRecJCF As TextBox
    Friend WithEvents TxtEjeFalla As TextBox
    Friend WithEvents TxtEjeCargo As TextBox
    Friend WithEvents TxtRecFalnew As TextBox
    Friend WithEvents TxtRecAgrnew As TextBox
    Friend WithEvents TxtRecJCFnew As TextBox
    Friend WithEvents GroupBoxAñadir As GroupBox
    Friend WithEvents BtnVerHistorfa As Button
    Friend WithEvents BtnInsertReg As Button
    Friend WithEvents BtnCalculoRec As Button
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents HistorfaBindingSource As BindingSource
    Friend WithEvents HistorfaTableAdapter As DataSet1TableAdapters.historfaTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CriteriorecompTableAdapter As DataSet1TableAdapters.criteriorecompTableAdapter
    Friend WithEvents CriteriorecompBindingSource As BindingSource
    Friend WithEvents RecompensasejercicioTableAdapter As DataSet1TableAdapters.recompensasejercicioTableAdapter
    Friend WithEvents RecompensasejercicioBindingSource As BindingSource
    Friend WithEvents RecompensasTableAdapter As DataSet1TableAdapters.recompensasTableAdapter
    Friend WithEvents RecompensasBindingSource As BindingSource
End Class
