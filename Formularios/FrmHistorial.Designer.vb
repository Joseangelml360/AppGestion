<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHistorial
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim BAJALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistorial))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.DgvFallero = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_JCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HistorfaDataGridView = New System.Windows.Forms.DataGridView()
        Me.CODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ANOCENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECAGRUPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistorfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos1 = New AppGestion.DbCensos()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.HistorfaTableAdapter = New AppGestion.DbCensosTableAdapters.historfaTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.TxtEjeFalla = New System.Windows.Forms.TextBox()
        Me.TxtEjeJCF = New System.Windows.Forms.TextBox()
        Me.TxtEjeCargo = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.HistorfaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorfaTableAdapter1 = New AppGestion.DataSet1TableAdapters.historfaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.TxtComision = New System.Windows.Forms.TextBox()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager1 = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.ChkbBAJA = New System.Windows.Forms.CheckBox()
        DNILabel = New System.Windows.Forms.Label()
        FALLERO_CODIGOLabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        CODIGOLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        BAJALabel = New System.Windows.Forms.Label()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(130, 116)
        DNILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(35, 17)
        DNILabel.TabIndex = 32
        DNILabel.Text = "DNI:"
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(52, 86)
        FALLERO_CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(113, 17)
        FALLERO_CODIGOLabel.TabIndex = 30
        FALLERO_CODIGOLabel.Text = "CODIGO FALLA:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(77, 176)
        APELLIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(88, 17)
        APELLIDOSLabel.TabIndex = 24
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(93, 146)
        NOMBRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(72, 17)
        NOMBRELabel.TabIndex = 22
        NOMBRELabel.Text = "NOMBRE:"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(70, 56)
        CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(95, 17)
        CODIGOLabel.TabIndex = 20
        CODIGOLabel.Text = "CODIGO JCF:"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(1022, 127)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(152, 17)
        Label4.TabIndex = 41
        Label4.Text = "Nº EJERCICIOS FALLA"
        '
        'Label5
        '
        Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(1040, 157)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(134, 17)
        Label5.TabIndex = 42
        Label5.Text = "Nº EJERCICIOS JCF"
        '
        'Label6
        '
        Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(1014, 187)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(160, 17)
        Label6.TabIndex = 44
        Label6.Text = "Nº EJERCICIOS CARGO"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(87, 206)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(79, 17)
        Label7.TabIndex = 46
        Label7.Text = "COMISION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Historial de fallero"
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(169, 112)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(132, 22)
        Me.DNITextBox.TabIndex = 33
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
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(169, 82)
        Me.FALLERO_CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(132, 22)
        Me.FALLERO_CODIGOTextBox.TabIndex = 31
        '
        'BtnVer
        '
        Me.BtnVer.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVer.Location = New System.Drawing.Point(735, 37)
        Me.BtnVer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(133, 31)
        Me.BtnVer.TabIndex = 29
        Me.BtnVer.Text = "Ver historial"
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'DgvFallero
        '
        Me.DgvFallero.AllowUserToAddRows = False
        Me.DgvFallero.AllowUserToDeleteRows = False
        Me.DgvFallero.AutoGenerateColumns = False
        Me.DgvFallero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFallero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.COD_JCF, Me.APELLIDOS, Me.NOMBRE})
        Me.DgvFallero.DataSource = Me.FalleroBindingSource
        Me.DgvFallero.Location = New System.Drawing.Point(474, 109)
        Me.DgvFallero.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvFallero.Name = "DgvFallero"
        Me.DgvFallero.ReadOnly = True
        Me.DgvFallero.RowHeadersWidth = 51
        Me.DgvFallero.Size = New System.Drawing.Size(509, 164)
        Me.DgvFallero.TabIndex = 28
        Me.DgvFallero.Visible = False
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
        'COD_JCF
        '
        Me.COD_JCF.DataPropertyName = "COD_JCF"
        Me.COD_JCF.HeaderText = "COD_JCF"
        Me.COD_JCF.MinimumWidth = 6
        Me.COD_JCF.Name = "COD_JCF"
        Me.COD_JCF.ReadOnly = True
        Me.COD_JCF.Visible = False
        Me.COD_JCF.Width = 125
        '
        'APELLIDOS
        '
        Me.APELLIDOS.DataPropertyName = "APELLIDOS"
        Me.APELLIDOS.HeaderText = "Apellidos"
        Me.APELLIDOS.MinimumWidth = 6
        Me.APELLIDOS.Name = "APELLIDOS"
        Me.APELLIDOS.ReadOnly = True
        Me.APELLIDOS.Width = 200
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 125
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(622, 71)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(246, 22)
        Me.TxtBuscar.TabIndex = 27
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(169, 172)
        Me.APELLIDOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(199, 22)
        Me.APELLIDOSTextBox.TabIndex = 25
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(169, 142)
        Me.NOMBRETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(132, 22)
        Me.NOMBRETextBox.TabIndex = 23
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_JCF", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(169, 52)
        Me.CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CODIGOTextBox.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(477, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Buscar por apellidos"
        '
        'HistorfaDataGridView
        '
        Me.HistorfaDataGridView.AllowUserToAddRows = False
        Me.HistorfaDataGridView.AllowUserToDeleteRows = False
        Me.HistorfaDataGridView.AllowUserToOrderColumns = True
        Me.HistorfaDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.HistorfaDataGridView.AutoGenerateColumns = False
        Me.HistorfaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorfaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGODataGridViewTextBoxColumn, Me.ANOCENDataGridViewTextBoxColumn, Me.FALLADataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.CARGODataGridViewTextBoxColumn, Me.RECOMDataGridViewTextBoxColumn, Me.TIPFALDataGridViewTextBoxColumn, Me.CODFALLADataGridViewTextBoxColumn, Me.RECFALDataGridViewTextBoxColumn, Me.RECAGRUPDataGridViewTextBoxColumn, Me.OBSERVACIODataGridViewTextBoxColumn})
        Me.HistorfaDataGridView.DataSource = Me.HistorfaBindingSource
        Me.HistorfaDataGridView.Location = New System.Drawing.Point(61, 307)
        Me.HistorfaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.HistorfaDataGridView.Name = "HistorfaDataGridView"
        Me.HistorfaDataGridView.ReadOnly = True
        Me.HistorfaDataGridView.RowHeadersWidth = 51
        Me.HistorfaDataGridView.Size = New System.Drawing.Size(1207, 334)
        Me.HistorfaDataGridView.TabIndex = 18
        Me.HistorfaDataGridView.Visible = False
        '
        'CODIGODataGridViewTextBoxColumn
        '
        Me.CODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.HeaderText = "Cód. JCF"
        Me.CODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODIGODataGridViewTextBoxColumn.Name = "CODIGODataGridViewTextBoxColumn"
        Me.CODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGODataGridViewTextBoxColumn.Width = 60
        '
        'ANOCENDataGridViewTextBoxColumn
        '
        Me.ANOCENDataGridViewTextBoxColumn.DataPropertyName = "ANOCEN"
        Me.ANOCENDataGridViewTextBoxColumn.HeaderText = "Año Censo"
        Me.ANOCENDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ANOCENDataGridViewTextBoxColumn.Name = "ANOCENDataGridViewTextBoxColumn"
        Me.ANOCENDataGridViewTextBoxColumn.ReadOnly = True
        Me.ANOCENDataGridViewTextBoxColumn.Width = 60
        '
        'FALLADataGridViewTextBoxColumn
        '
        Me.FALLADataGridViewTextBoxColumn.DataPropertyName = "FALLA"
        Me.FALLADataGridViewTextBoxColumn.HeaderText = "FALLA"
        Me.FALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLADataGridViewTextBoxColumn.Name = "FALLADataGridViewTextBoxColumn"
        Me.FALLADataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLADataGridViewTextBoxColumn.Width = 60
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        Me.DNIDataGridViewTextBoxColumn.Width = 125
        '
        'CARGODataGridViewTextBoxColumn
        '
        Me.CARGODataGridViewTextBoxColumn.DataPropertyName = "CARGO"
        Me.CARGODataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.CARGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CARGODataGridViewTextBoxColumn.Name = "CARGODataGridViewTextBoxColumn"
        Me.CARGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CARGODataGridViewTextBoxColumn.Width = 50
        '
        'RECOMDataGridViewTextBoxColumn
        '
        Me.RECOMDataGridViewTextBoxColumn.DataPropertyName = "RECOM"
        Me.RECOMDataGridViewTextBoxColumn.HeaderText = "Recomp. JCF"
        Me.RECOMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECOMDataGridViewTextBoxColumn.Name = "RECOMDataGridViewTextBoxColumn"
        Me.RECOMDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECOMDataGridViewTextBoxColumn.Width = 70
        '
        'TIPFALDataGridViewTextBoxColumn
        '
        Me.TIPFALDataGridViewTextBoxColumn.DataPropertyName = "TIPFAL"
        Me.TIPFALDataGridViewTextBoxColumn.HeaderText = "Comisión"
        Me.TIPFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPFALDataGridViewTextBoxColumn.Name = "TIPFALDataGridViewTextBoxColumn"
        Me.TIPFALDataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPFALDataGridViewTextBoxColumn.Width = 70
        '
        'CODFALLADataGridViewTextBoxColumn
        '
        Me.CODFALLADataGridViewTextBoxColumn.DataPropertyName = "COD_FALLA"
        Me.CODFALLADataGridViewTextBoxColumn.HeaderText = "Cód. Falla"
        Me.CODFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODFALLADataGridViewTextBoxColumn.Name = "CODFALLADataGridViewTextBoxColumn"
        Me.CODFALLADataGridViewTextBoxColumn.ReadOnly = True
        Me.CODFALLADataGridViewTextBoxColumn.Width = 60
        '
        'RECFALDataGridViewTextBoxColumn
        '
        Me.RECFALDataGridViewTextBoxColumn.DataPropertyName = "REC_FAL"
        Me.RECFALDataGridViewTextBoxColumn.HeaderText = "Recomp. falla"
        Me.RECFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECFALDataGridViewTextBoxColumn.Name = "RECFALDataGridViewTextBoxColumn"
        Me.RECFALDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECFALDataGridViewTextBoxColumn.Width = 70
        '
        'RECAGRUPDataGridViewTextBoxColumn
        '
        Me.RECAGRUPDataGridViewTextBoxColumn.DataPropertyName = "REC_AGRUP"
        Me.RECAGRUPDataGridViewTextBoxColumn.HeaderText = "Recomp. Agrup."
        Me.RECAGRUPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECAGRUPDataGridViewTextBoxColumn.Name = "RECAGRUPDataGridViewTextBoxColumn"
        Me.RECAGRUPDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECAGRUPDataGridViewTextBoxColumn.Width = 70
        '
        'OBSERVACIODataGridViewTextBoxColumn
        '
        Me.OBSERVACIODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIO"
        Me.OBSERVACIODataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.OBSERVACIODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OBSERVACIODataGridViewTextBoxColumn.Name = "OBSERVACIODataGridViewTextBoxColumn"
        Me.OBSERVACIODataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIODataGridViewTextBoxColumn.Width = 150
        '
        'HistorfaBindingSource
        '
        Me.HistorfaBindingSource.DataMember = "historfa"
        Me.HistorfaBindingSource.DataSource = Me.DbCensos1
        '
        'DbCensos1
        '
        Me.DbCensos1.DataSetName = "DbCensos"
        Me.DbCensos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Image = Global.AppGestion.My.Resources.Resources.table_row_delete
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(804, 253)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 46)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Borrar Línea"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.AppGestion.My.Resources.Resources.page_edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(621, 253)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 46)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "    Editar Línea"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(444, 254)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "    Añadir registro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1111, 41)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'HistorfaTableAdapter
        '
        Me.HistorfaTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Buscar por código"
        '
        'TxtBuscarCodigo
        '
        Me.TxtBuscarCodigo.Location = New System.Drawing.Point(620, 41)
        Me.TxtBuscarCodigo.Name = "TxtBuscarCodigo"
        Me.TxtBuscarCodigo.Size = New System.Drawing.Size(108, 22)
        Me.TxtBuscarCodigo.TabIndex = 39
        '
        'TxtEjeFalla
        '
        Me.TxtEjeFalla.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtEjeFalla.Location = New System.Drawing.Point(1178, 123)
        Me.TxtEjeFalla.Name = "TxtEjeFalla"
        Me.TxtEjeFalla.Size = New System.Drawing.Size(100, 22)
        Me.TxtEjeFalla.TabIndex = 40
        '
        'TxtEjeJCF
        '
        Me.TxtEjeJCF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtEjeJCF.Location = New System.Drawing.Point(1178, 153)
        Me.TxtEjeJCF.Name = "TxtEjeJCF"
        Me.TxtEjeJCF.Size = New System.Drawing.Size(100, 22)
        Me.TxtEjeJCF.TabIndex = 43
        '
        'TxtEjeCargo
        '
        Me.TxtEjeCargo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtEjeCargo.Location = New System.Drawing.Point(1178, 183)
        Me.TxtEjeCargo.Name = "TxtEjeCargo"
        Me.TxtEjeCargo.Size = New System.Drawing.Size(100, 22)
        Me.TxtEjeCargo.TabIndex = 45
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistorfaBindingSource1
        '
        Me.HistorfaBindingSource1.DataMember = "historfa"
        Me.HistorfaBindingSource1.DataSource = Me.DataSet1
        '
        'HistorfaTableAdapter1
        '
        Me.HistorfaTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.criteriorecompTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager.historfaTableAdapter = Me.HistorfaTableAdapter1
        Me.TableAdapterManager.MensajesTableAdapter = Nothing
        Me.TableAdapterManager.recompensasejercicioTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TxtComision
        '
        Me.TxtComision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TIPFAL", True))
        Me.TxtComision.Location = New System.Drawing.Point(169, 202)
        Me.TxtComision.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtComision.Name = "TxtComision"
        Me.TxtComision.Size = New System.Drawing.Size(132, 22)
        Me.TxtComision.TabIndex = 47
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(87, 236)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(62, 17)
        Label8.TabIndex = 48
        Label8.Text = "CARGO:"
        '
        'TxtCargo
        '
        Me.TxtCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ULTCAR", True))
        Me.TxtCargo.Location = New System.Drawing.Point(169, 232)
        Me.TxtCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(132, 22)
        Me.TxtCargo.TabIndex = 49
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.adeudosTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.banco_remesaTableAdapter = Nothing
        Me.TableAdapterManager1.cargoTableAdapter = Nothing
        Me.TableAdapterManager1.CensoTableAdapter = Nothing
        Me.TableAdapterManager1.clientesTableAdapter = Nothing
        Me.TableAdapterManager1.comisionTableAdapter = Nothing
        Me.TableAdapterManager1.datos_banco_para_abonosTableAdapter = Nothing
        Me.TableAdapterManager1.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager1.detalles_de_remesa1TableAdapter = Nothing
        Me.TableAdapterManager1.detalles_de_remesa2TableAdapter = Nothing
        Me.TableAdapterManager1.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager1.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager1.estadoTableAdapter = Nothing
        Me.TableAdapterManager1.fallasTableAdapter = Nothing
        Me.TableAdapterManager1.falleroTableAdapter = Me.FalleroTableAdapter
        Me.TableAdapterManager1.letradniTableAdapter = Nothing
        Me.TableAdapterManager1.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager1.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager1.recompensasTableAdapter = Nothing
        Me.TableAdapterManager1.remesasTableAdapter = Nothing
        Me.TableAdapterManager1.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BAJALabel
        '
        BAJALabel.AutoSize = True
        BAJALabel.Location = New System.Drawing.Point(117, 270)
        BAJALabel.Name = "BAJALabel"
        BAJALabel.Size = New System.Drawing.Size(46, 17)
        BAJALabel.TabIndex = 49
        BAJALabel.Text = "BAJA:"
        BAJALabel.Visible = False
        '
        'ChkbBAJA
        '
        Me.ChkbBAJA.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FalleroBindingSource, "BAJA", True))
        Me.ChkbBAJA.Location = New System.Drawing.Point(169, 265)
        Me.ChkbBAJA.Name = "ChkbBAJA"
        Me.ChkbBAJA.Size = New System.Drawing.Size(104, 24)
        Me.ChkbBAJA.TabIndex = 50
        Me.ChkbBAJA.Text = "CheckBox1"
        Me.ChkbBAJA.UseVisualStyleBackColor = True
        Me.ChkbBAJA.Visible = False
        '
        'FrmHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1297, 654)
        Me.Controls.Add(BAJALabel)
        Me.Controls.Add(Me.ChkbBAJA)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.TxtComision)
        Me.Controls.Add(Me.TxtEjeCargo)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.TxtEjeJCF)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.TxtEjeFalla)
        Me.Controls.Add(Me.TxtBuscarCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(FALLERO_CODIGOLabel)
        Me.Controls.Add(Me.FALLERO_CODIGOTextBox)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.DgvFallero)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(APELLIDOSLabel)
        Me.Controls.Add(Me.APELLIDOSTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HistorfaDataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "29")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHistorial"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial"
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents BtnVer As Button
    Friend WithEvents DgvFallero As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HistorfaDataGridView As DataGridView
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COD_JCF As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents DbCensos1 As DbCensos
    Friend WithEvents HistorfaBindingSource As BindingSource
    Friend WithEvents HistorfaTableAdapter As DbCensosTableAdapters.historfaTableAdapter
    Friend WithEvents CODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ANOCENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CARGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECOMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECAGRUPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBuscarCodigo As TextBox
    Friend WithEvents TxtEjeFalla As TextBox
    Friend WithEvents TxtEjeJCF As TextBox
    Friend WithEvents TxtEjeCargo As TextBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents HistorfaBindingSource1 As BindingSource
    Friend WithEvents HistorfaTableAdapter1 As DataSet1TableAdapters.historfaTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TxtComision As TextBox
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents TableAdapterManager1 As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents ChkbBAJA As CheckBox
End Class
