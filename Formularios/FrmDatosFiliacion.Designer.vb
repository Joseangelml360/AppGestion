<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDatosFiliacion
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
        Dim PasejuvenilLabel As System.Windows.Forms.Label
        Dim PasemayorLabel As System.Windows.Forms.Label
        Dim TIPFALLabel As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim REC_FALLabel As System.Windows.Forms.Label
        Dim FAL_RECLabel As System.Windows.Forms.Label
        Dim ANO_RECLabel As System.Windows.Forms.Label
        Dim COD_RECLabel As System.Windows.Forms.Label
        Dim ULTCARLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim E_MAILLabel As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim AñoejeLabel As System.Windows.Forms.Label
        Dim COD_POSTALLabel As System.Windows.Forms.Label
        Dim POBLACIONLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim SEXOLabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim FECHA_NACLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim COD_JCFLabel As System.Windows.Forms.Label
        Dim FALLERO_CODIGOLabel As System.Windows.Forms.Label
        Dim BAJALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatosFiliacion))
        Dim ANO_CENLabel As System.Windows.Forms.Label
        Me.FECHA_NACDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.PasejuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasemayorTextBox = New System.Windows.Forms.TextBox()
        Me.ComisionTextBox = New System.Windows.Forms.TextBox()
        Me.ComisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPFALTextBox = New System.Windows.Forms.TextBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgvFALLERO = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ActivosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.DESFALTextBox = New System.Windows.Forms.TextBox()
        Me.FallasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUMFALComboBox = New System.Windows.Forms.ComboBox()
        Me.DESRECTextBox = New System.Windows.Forms.TextBox()
        Me.RecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECOMComboBox = New System.Windows.Forms.ComboBox()
        Me.DESCRIPTextBox = New System.Windows.Forms.TextBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CARGOComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ULTCARTextBox = New System.Windows.Forms.TextBox()
        Me.OBSERVACIONESTextBox = New System.Windows.Forms.TextBox()
        Me.REC_FALTextBox = New System.Windows.Forms.TextBox()
        Me.FAL_RECTextBox = New System.Windows.Forms.TextBox()
        Me.ANO_RECTextBox = New System.Windows.Forms.TextBox()
        Me.COD_RECTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.E_MAILTextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONOTextBox = New System.Windows.Forms.TextBox()
        Me.AñoejeTextBox = New System.Windows.Forms.TextBox()
        Me.COD_POSTALTextBox = New System.Windows.Forms.TextBox()
        Me.POBLACIONTextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox()
        Me.SEXOTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.COD_JCFTextBox = New System.Windows.Forms.TextBox()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.EjercicioTableAdapter = New AppGestion.DbCensosTableAdapters.ejercicioTableAdapter()
        Me.ComisionTableAdapter = New AppGestion.DbCensosTableAdapters.comisionTableAdapter()
        Me.CargoTableAdapter = New AppGestion.DbCensosTableAdapters.cargoTableAdapter()
        Me.RecompensasTableAdapter = New AppGestion.DbCensosTableAdapters.recompensasTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.FallasTableAdapter = New AppGestion.DbCensosTableAdapters.fallasTableAdapter()
        Me.BAJACheckBox = New System.Windows.Forms.CheckBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.BtnBuscarCodigo = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CboComision = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RecompensasFallaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecompensasFallaTableAdapter = New AppGestion.DbCensosTableAdapters.RecompensasFallaTableAdapter()
        Me.DESRECTextBox1 = New System.Windows.Forms.TextBox()
        Me.ANO_CENTextBox = New System.Windows.Forms.TextBox()
        PasejuvenilLabel = New System.Windows.Forms.Label()
        PasemayorLabel = New System.Windows.Forms.Label()
        TIPFALLabel = New System.Windows.Forms.Label()
        OBSERVACIONESLabel = New System.Windows.Forms.Label()
        REC_FALLabel = New System.Windows.Forms.Label()
        FAL_RECLabel = New System.Windows.Forms.Label()
        ANO_RECLabel = New System.Windows.Forms.Label()
        COD_RECLabel = New System.Windows.Forms.Label()
        ULTCARLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        E_MAILLabel = New System.Windows.Forms.Label()
        TELEFONOLabel = New System.Windows.Forms.Label()
        AñoejeLabel = New System.Windows.Forms.Label()
        COD_POSTALLabel = New System.Windows.Forms.Label()
        POBLACIONLabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        SEXOLabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        FECHA_NACLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        COD_JCFLabel = New System.Windows.Forms.Label()
        FALLERO_CODIGOLabel = New System.Windows.Forms.Label()
        BAJALabel = New System.Windows.Forms.Label()
        ANO_CENLabel = New System.Windows.Forms.Label()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFALLERO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivosToolStrip.SuspendLayout()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.RecompensasFallaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasejuvenilLabel
        '
        PasejuvenilLabel.AutoSize = True
        PasejuvenilLabel.Location = New System.Drawing.Point(839, 462)
        PasejuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasejuvenilLabel.Name = "PasejuvenilLabel"
        PasejuvenilLabel.Size = New System.Drawing.Size(83, 17)
        PasejuvenilLabel.TabIndex = 188
        PasejuvenilLabel.Text = "pasejuvenil:"
        PasejuvenilLabel.Visible = False
        '
        'PasemayorLabel
        '
        PasemayorLabel.AutoSize = True
        PasemayorLabel.Location = New System.Drawing.Point(840, 428)
        PasemayorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasemayorLabel.Name = "PasemayorLabel"
        PasemayorLabel.Size = New System.Drawing.Size(82, 17)
        PasemayorLabel.TabIndex = 186
        PasemayorLabel.Text = "pasemayor:"
        PasemayorLabel.Visible = False
        '
        'TIPFALLabel
        '
        TIPFALLabel.AutoSize = True
        TIPFALLabel.Location = New System.Drawing.Point(796, 386)
        TIPFALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIPFALLabel.Name = "TIPFALLabel"
        TIPFALLabel.Size = New System.Drawing.Size(69, 17)
        TIPFALLabel.TabIndex = 183
        TIPFALLabel.Text = "Comisión:"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.Location = New System.Drawing.Point(505, 465)
        OBSERVACIONESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(129, 17)
        OBSERVACIONESLabel.TabIndex = 174
        OBSERVACIONESLabel.Text = "OBSERVACIONES:"
        '
        'REC_FALLabel
        '
        REC_FALLabel.AutoSize = True
        REC_FALLabel.Location = New System.Drawing.Point(62, 603)
        REC_FALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        REC_FALLabel.Name = "REC_FALLabel"
        REC_FALLabel.Size = New System.Drawing.Size(86, 17)
        REC_FALLabel.TabIndex = 173
        REC_FALLabel.Text = "REC FALLA:"
        '
        'FAL_RECLabel
        '
        FAL_RECLabel.AutoSize = True
        FAL_RECLabel.Location = New System.Drawing.Point(62, 538)
        FAL_RECLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FAL_RECLabel.Name = "FAL_RECLabel"
        FAL_RECLabel.Size = New System.Drawing.Size(86, 17)
        FAL_RECLabel.TabIndex = 171
        FAL_RECLabel.Text = "FALLA REC:"
        '
        'ANO_RECLabel
        '
        ANO_RECLabel.AutoSize = True
        ANO_RECLabel.Location = New System.Drawing.Point(74, 568)
        ANO_RECLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ANO_RECLabel.Name = "ANO_RECLabel"
        ANO_RECLabel.Size = New System.Drawing.Size(74, 17)
        ANO_RECLabel.TabIndex = 170
        ANO_RECLabel.Text = "AÑO REC:"
        '
        'COD_RECLabel
        '
        COD_RECLabel.AutoSize = True
        COD_RECLabel.Location = New System.Drawing.Point(80, 506)
        COD_RECLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COD_RECLabel.Name = "COD_RECLabel"
        COD_RECLabel.Size = New System.Drawing.Size(68, 17)
        COD_RECLabel.TabIndex = 168
        COD_RECLabel.Text = "REC. JCF"
        '
        'ULTCARLabel
        '
        ULTCARLabel.AutoSize = True
        ULTCARLabel.Location = New System.Drawing.Point(86, 474)
        ULTCARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ULTCARLabel.Name = "ULTCARLabel"
        ULTCARLabel.Size = New System.Drawing.Size(62, 17)
        ULTCARLabel.TabIndex = 167
        ULTCARLabel.Text = "CARGO:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(924, 134)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(34, 20)
        IDLabel.TabIndex = 162
        IDLabel.Text = "ID:"
        '
        'E_MAILLabel
        '
        E_MAILLabel.AutoSize = True
        E_MAILLabel.Location = New System.Drawing.Point(381, 384)
        E_MAILLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        E_MAILLabel.Name = "E_MAILLabel"
        E_MAILLabel.Size = New System.Drawing.Size(57, 17)
        E_MAILLabel.TabIndex = 161
        E_MAILLabel.Text = "E-MAIL:"
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.AutoSize = True
        TELEFONOLabel.Location = New System.Drawing.Point(89, 381)
        TELEFONOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(87, 17)
        TELEFONOLabel.TabIndex = 160
        TELEFONOLabel.Text = "TELEFONO:"
        '
        'AñoejeLabel
        '
        AñoejeLabel.AutoSize = True
        AñoejeLabel.Location = New System.Drawing.Point(10, 51)
        AñoejeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AñoejeLabel.Name = "AñoejeLabel"
        AñoejeLabel.Size = New System.Drawing.Size(61, 17)
        AñoejeLabel.TabIndex = 159
        AñoejeLabel.Text = "Ejercicio"
        '
        'COD_POSTALLabel
        '
        COD_POSTALLabel.AutoSize = True
        COD_POSTALLabel.Location = New System.Drawing.Point(848, 332)
        COD_POSTALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COD_POSTALLabel.Name = "COD_POSTALLabel"
        COD_POSTALLabel.Size = New System.Drawing.Size(101, 17)
        COD_POSTALLabel.TabIndex = 158
        COD_POSTALLabel.Text = "COD POSTAL:"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(491, 332)
        POBLACIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(91, 17)
        POBLACIONLabel.TabIndex = 157
        POBLACIONLabel.Text = "POBLACION:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(76, 332)
        DIRECCIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(86, 17)
        DIRECCIONLabel.TabIndex = 156
        DIRECCIONLabel.Text = "DIRECCION:"
        '
        'SEXOLabel
        '
        SEXOLabel.AutoSize = True
        SEXOLabel.Location = New System.Drawing.Point(763, 234)
        SEXOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SEXOLabel.Name = "SEXOLabel"
        SEXOLabel.Size = New System.Drawing.Size(50, 17)
        SEXOLabel.TabIndex = 155
        SEXOLabel.Text = "SEXO:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(325, 282)
        APELLIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(88, 17)
        APELLIDOSLabel.TabIndex = 154
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(92, 282)
        NOMBRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(72, 17)
        NOMBRELabel.TabIndex = 153
        NOMBRELabel.Text = "NOMBRE:"
        '
        'FECHA_NACLabel
        '
        FECHA_NACLabel.AutoSize = True
        FECHA_NACLabel.Location = New System.Drawing.Point(769, 282)
        FECHA_NACLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FECHA_NACLabel.Name = "FECHA_NACLabel"
        FECHA_NACLabel.Size = New System.Drawing.Size(145, 17)
        FECHA_NACLabel.TabIndex = 152
        FECHA_NACLabel.Text = "FECHA NACIMIENTO:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(547, 234)
        DNILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(35, 17)
        DNILabel.TabIndex = 151
        DNILabel.Text = "DNI:"
        '
        'COD_JCFLabel
        '
        COD_JCFLabel.AutoSize = True
        COD_JCFLabel.Location = New System.Drawing.Point(345, 234)
        COD_JCFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COD_JCFLabel.Name = "COD_JCFLabel"
        COD_JCFLabel.Size = New System.Drawing.Size(70, 17)
        COD_JCFLabel.TabIndex = 150
        COD_JCFLabel.Text = "COD JCF:"
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(81, 234)
        FALLERO_CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(67, 17)
        FALLERO_CODIGOLabel.TabIndex = 148
        FALLERO_CODIGOLabel.Text = "CODIGO:"
        '
        'BAJALabel
        '
        BAJALabel.AutoSize = True
        BAJALabel.Location = New System.Drawing.Point(78, 178)
        BAJALabel.Name = "BAJALabel"
        BAJALabel.Size = New System.Drawing.Size(46, 17)
        BAJALabel.TabIndex = 189
        BAJALabel.Text = "BAJA:"
        '
        'FECHA_NACDateTimePicker
        '
        Me.FECHA_NACDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FalleroBindingSource, "FECHA_NAC", True))
        Me.FECHA_NACDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA_NACDateTimePicker.Location = New System.Drawing.Point(931, 274)
        Me.FECHA_NACDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FECHA_NACDateTimePicker.Name = "FECHA_NACDateTimePicker"
        Me.FECHA_NACDateTimePicker.Size = New System.Drawing.Size(132, 22)
        Me.FECHA_NACDateTimePicker.TabIndex = 132
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
        'PasejuvenilTextBox
        '
        Me.PasejuvenilTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PasejuvenilTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasejuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasejuvenil", True))
        Me.PasejuvenilTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.PasejuvenilTextBox.Location = New System.Drawing.Point(931, 459)
        Me.PasejuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasejuvenilTextBox.Name = "PasejuvenilTextBox"
        Me.PasejuvenilTextBox.Size = New System.Drawing.Size(133, 15)
        Me.PasejuvenilTextBox.TabIndex = 189
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DbCensos
        '
        'PasemayorTextBox
        '
        Me.PasemayorTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PasemayorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasemayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasemayor", True))
        Me.PasemayorTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.PasemayorTextBox.Location = New System.Drawing.Point(927, 428)
        Me.PasemayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasemayorTextBox.Name = "PasemayorTextBox"
        Me.PasemayorTextBox.Size = New System.Drawing.Size(133, 15)
        Me.PasemayorTextBox.TabIndex = 187
        '
        'ComisionTextBox
        '
        Me.ComisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComisionBindingSource, "comision", True))
        Me.ComisionTextBox.Location = New System.Drawing.Point(911, 378)
        Me.ComisionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ComisionTextBox.Name = "ComisionTextBox"
        Me.ComisionTextBox.ReadOnly = True
        Me.ComisionTextBox.Size = New System.Drawing.Size(108, 22)
        Me.ComisionTextBox.TabIndex = 185
        '
        'ComisionBindingSource
        '
        Me.ComisionBindingSource.DataMember = "comision"
        Me.ComisionBindingSource.DataSource = Me.DbCensos
        '
        'TIPFALTextBox
        '
        Me.TIPFALTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.TIPFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TIPFAL", True))
        Me.TIPFALTextBox.Location = New System.Drawing.Point(873, 378)
        Me.TIPFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TIPFALTextBox.Name = "TIPFALTextBox"
        Me.TIPFALTextBox.ReadOnly = True
        Me.TIPFALTextBox.Size = New System.Drawing.Size(30, 22)
        Me.TIPFALTextBox.TabIndex = 139
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.Location = New System.Drawing.Point(956, 37)
        Me.lblFiltro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(71, 20)
        Me.lblFiltro.TabIndex = 184
        Me.lblFiltro.Text = "Activos"
        Me.lblFiltro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.Location = New System.Drawing.Point(161, 172)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 33)
        Me.Button3.TabIndex = 182
        Me.Button3.Text = "Dar de baja"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(746, 648)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 42)
        Me.Button2.TabIndex = 146
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(215, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 17)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "         Buscar fallero por Apellidos:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(441, 70)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(331, 22)
        Me.TxtBuscar.TabIndex = 131
        '
        'DgvFALLERO
        '
        Me.DgvFALLERO.AllowUserToAddRows = False
        Me.DgvFALLERO.AllowUserToDeleteRows = False
        Me.DgvFALLERO.AutoGenerateColumns = False
        Me.DgvFALLERO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFALLERO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn})
        Me.DgvFALLERO.DataSource = Me.FalleroBindingSource
        Me.DgvFALLERO.Location = New System.Drawing.Point(385, 102)
        Me.DgvFALLERO.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvFALLERO.Name = "DgvFALLERO"
        Me.DgvFALLERO.ReadOnly = True
        Me.DgvFALLERO.RowHeadersWidth = 51
        Me.DgvFALLERO.Size = New System.Drawing.Size(651, 171)
        Me.DgvFALLERO.TabIndex = 179
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
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 200
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 125
        '
        'ActivosToolStrip
        '
        Me.ActivosToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ActivosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivosToolStripButton, Me.ToolStripSeparator7, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripButton5, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator6, Me.ToolStripButton4})
        Me.ActivosToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ActivosToolStrip.Name = "ActivosToolStrip"
        Me.ActivosToolStrip.Size = New System.Drawing.Size(1090, 27)
        Me.ActivosToolStrip.TabIndex = 180
        Me.ActivosToolStrip.Text = "ActivosToolStrip"
        '
        'ActivosToolStripButton
        '
        Me.ActivosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ActivosToolStripButton.Name = "ActivosToolStripButton"
        Me.ActivosToolStripButton.Size = New System.Drawing.Size(61, 24)
        Me.ActivosToolStripButton.Text = "Activos"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 24)
        Me.ToolStripButton1.Text = "Mayores"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(71, 24)
        Me.ToolStripButton5.Text = "Juveniles"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(73, 24)
        Me.ToolStripButton2.Text = "Infantiles"
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
        Me.ToolStripButton3.Size = New System.Drawing.Size(60, 24)
        Me.ToolStripButton3.Text = "Familia"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(48, 24)
        Me.ToolStripButton4.Text = "Bajas"
        '
        'DESFALTextBox
        '
        Me.DESFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FallasBindingSource, "DESFAL", True))
        Me.DESFALTextBox.Location = New System.Drawing.Point(228, 531)
        Me.DESFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESFALTextBox.Name = "DESFALTextBox"
        Me.DESFALTextBox.ReadOnly = True
        Me.DESFALTextBox.Size = New System.Drawing.Size(161, 22)
        Me.DESFALTextBox.TabIndex = 178
        '
        'FallasBindingSource
        '
        Me.FallasBindingSource.DataMember = "fallas"
        Me.FallasBindingSource.DataSource = Me.DbCensos
        '
        'NUMFALComboBox
        '
        Me.NUMFALComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FalleroBindingSource, "FAL_REC", True))
        Me.NUMFALComboBox.DataSource = Me.FallasBindingSource
        Me.NUMFALComboBox.DisplayMember = "DESFAL"
        Me.NUMFALComboBox.DropDownWidth = 200
        Me.NUMFALComboBox.FormattingEnabled = True
        Me.NUMFALComboBox.Location = New System.Drawing.Point(397, 531)
        Me.NUMFALComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NUMFALComboBox.Name = "NUMFALComboBox"
        Me.NUMFALComboBox.Size = New System.Drawing.Size(25, 24)
        Me.NUMFALComboBox.TabIndex = 142
        Me.NUMFALComboBox.ValueMember = "NUMFAL"
        '
        'DESRECTextBox
        '
        Me.DESRECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasBindingSource, "DESREC", True))
        Me.DESRECTextBox.Location = New System.Drawing.Point(228, 497)
        Me.DESRECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESRECTextBox.Name = "DESRECTextBox"
        Me.DESRECTextBox.ReadOnly = True
        Me.DESRECTextBox.Size = New System.Drawing.Size(161, 22)
        Me.DESRECTextBox.TabIndex = 177
        '
        'RecompensasBindingSource
        '
        Me.RecompensasBindingSource.DataMember = "recompensas"
        Me.RecompensasBindingSource.DataSource = Me.DbCensos
        '
        'RECOMComboBox
        '
        Me.RECOMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FalleroBindingSource, "COD_REC", True))
        Me.RECOMComboBox.DataSource = Me.RecompensasBindingSource
        Me.RECOMComboBox.DisplayMember = "DESREC"
        Me.RECOMComboBox.DropDownWidth = 100
        Me.RECOMComboBox.FormattingEnabled = True
        Me.RECOMComboBox.Location = New System.Drawing.Point(397, 499)
        Me.RECOMComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RECOMComboBox.Name = "RECOMComboBox"
        Me.RECOMComboBox.Size = New System.Drawing.Size(25, 24)
        Me.RECOMComboBox.TabIndex = 141
        Me.RECOMComboBox.ValueMember = "RECOM"
        '
        'DESCRIPTextBox
        '
        Me.DESCRIPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargoBindingSource, "DESCRIP", True))
        Me.DESCRIPTextBox.Location = New System.Drawing.Point(228, 467)
        Me.DESCRIPTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCRIPTextBox.Name = "DESCRIPTextBox"
        Me.DESCRIPTextBox.ReadOnly = True
        Me.DESCRIPTextBox.Size = New System.Drawing.Size(161, 22)
        Me.DESCRIPTextBox.TabIndex = 176
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.DbCensos
        '
        'CARGOComboBox
        '
        Me.CARGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FalleroBindingSource, "ULTCAR", True))
        Me.CARGOComboBox.DataSource = Me.CargoBindingSource
        Me.CARGOComboBox.DisplayMember = "DESCRIP"
        Me.CARGOComboBox.DropDownWidth = 100
        Me.CARGOComboBox.FormattingEnabled = True
        Me.CARGOComboBox.Location = New System.Drawing.Point(397, 467)
        Me.CARGOComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CARGOComboBox.Name = "CARGOComboBox"
        Me.CARGOComboBox.Size = New System.Drawing.Size(24, 24)
        Me.CARGOComboBox.TabIndex = 140
        Me.CARGOComboBox.ValueMember = "CARGO"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(911, 648)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 42)
        Me.Button1.TabIndex = 147
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ULTCARTextBox
        '
        Me.ULTCARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ULTCAR", True))
        Me.ULTCARTextBox.Location = New System.Drawing.Point(165, 467)
        Me.ULTCARTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ULTCARTextBox.Name = "ULTCARTextBox"
        Me.ULTCARTextBox.ReadOnly = True
        Me.ULTCARTextBox.Size = New System.Drawing.Size(55, 22)
        Me.ULTCARTextBox.TabIndex = 175
        '
        'OBSERVACIONESTextBox
        '
        Me.OBSERVACIONESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "OBSERVACIONES", True))
        Me.OBSERVACIONESTextBox.Location = New System.Drawing.Point(509, 493)
        Me.OBSERVACIONESTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OBSERVACIONESTextBox.Multiline = True
        Me.OBSERVACIONESTextBox.Name = "OBSERVACIONESTextBox"
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(552, 66)
        Me.OBSERVACIONESTextBox.TabIndex = 145
        '
        'REC_FALTextBox
        '
        Me.REC_FALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "REC_FAL", True))
        Me.REC_FALTextBox.Location = New System.Drawing.Point(165, 598)
        Me.REC_FALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.REC_FALTextBox.Name = "REC_FALTextBox"
        Me.REC_FALTextBox.Size = New System.Drawing.Size(55, 22)
        Me.REC_FALTextBox.TabIndex = 144
        '
        'FAL_RECTextBox
        '
        Me.FAL_RECTextBox.AcceptsTab = True
        Me.FAL_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FAL_REC", True))
        Me.FAL_RECTextBox.Location = New System.Drawing.Point(165, 531)
        Me.FAL_RECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FAL_RECTextBox.Name = "FAL_RECTextBox"
        Me.FAL_RECTextBox.Size = New System.Drawing.Size(55, 22)
        Me.FAL_RECTextBox.TabIndex = 172
        '
        'ANO_RECTextBox
        '
        Me.ANO_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ANO_REC", True))
        Me.ANO_RECTextBox.Location = New System.Drawing.Point(165, 563)
        Me.ANO_RECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ANO_RECTextBox.Name = "ANO_RECTextBox"
        Me.ANO_RECTextBox.Size = New System.Drawing.Size(55, 22)
        Me.ANO_RECTextBox.TabIndex = 143
        '
        'COD_RECTextBox
        '
        Me.COD_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_REC", True))
        Me.COD_RECTextBox.Location = New System.Drawing.Point(165, 499)
        Me.COD_RECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COD_RECTextBox.Name = "COD_RECTextBox"
        Me.COD_RECTextBox.ReadOnly = True
        Me.COD_RECTextBox.Size = New System.Drawing.Size(55, 22)
        Me.COD_RECTextBox.TabIndex = 169
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox3.Location = New System.Drawing.Point(187, 130)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 13, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(277, 26)
        Me.TextBox3.TabIndex = 166
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(473, 130)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(413, 26)
        Me.TextBox2.TabIndex = 165
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(80, 130)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 26)
        Me.TextBox1.TabIndex = 164
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IDTextBox.Location = New System.Drawing.Point(972, 130)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(90, 26)
        Me.IDTextBox.TabIndex = 163
        '
        'E_MAILTextBox
        '
        Me.E_MAILTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.E_MAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "Email", True))
        Me.E_MAILTextBox.Location = New System.Drawing.Point(449, 380)
        Me.E_MAILTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.E_MAILTextBox.Name = "E_MAILTextBox"
        Me.E_MAILTextBox.Size = New System.Drawing.Size(248, 22)
        Me.E_MAILTextBox.TabIndex = 138
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TELEFONO", True))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(187, 378)
        Me.TELEFONOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TELEFONOTextBox.TabIndex = 137
        '
        'AñoejeTextBox
        '
        Me.AñoejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.AñoejeTextBox.Location = New System.Drawing.Point(79, 47)
        Me.AñoejeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AñoejeTextBox.Name = "AñoejeTextBox"
        Me.AñoejeTextBox.ReadOnly = True
        Me.AñoejeTextBox.Size = New System.Drawing.Size(89, 22)
        Me.AñoejeTextBox.TabIndex = 128
        '
        'COD_POSTALTextBox
        '
        Me.COD_POSTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_POSTAL", True))
        Me.COD_POSTALTextBox.Location = New System.Drawing.Point(960, 328)
        Me.COD_POSTALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COD_POSTALTextBox.Name = "COD_POSTALTextBox"
        Me.COD_POSTALTextBox.Size = New System.Drawing.Size(101, 22)
        Me.COD_POSTALTextBox.TabIndex = 136
        '
        'POBLACIONTextBox
        '
        Me.POBLACIONTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.POBLACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "POBLACION", True))
        Me.POBLACIONTextBox.Location = New System.Drawing.Point(593, 328)
        Me.POBLACIONTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.POBLACIONTextBox.Name = "POBLACIONTextBox"
        Me.POBLACIONTextBox.Size = New System.Drawing.Size(192, 22)
        Me.POBLACIONTextBox.TabIndex = 135
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(176, 328)
        Me.DIRECCIONTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(245, 22)
        Me.DIRECCIONTextBox.TabIndex = 134
        '
        'SEXOTextBox
        '
        Me.SEXOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SEXOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "SEXO", True))
        Me.SEXOTextBox.Location = New System.Drawing.Point(823, 229)
        Me.SEXOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SEXOTextBox.Name = "SEXOTextBox"
        Me.SEXOTextBox.Size = New System.Drawing.Size(48, 22)
        Me.SEXOTextBox.TabIndex = 127
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(425, 278)
        Me.APELLIDOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(327, 22)
        Me.APELLIDOSTextBox.TabIndex = 130
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(176, 278)
        Me.NOMBRETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(132, 22)
        Me.NOMBRETextBox.TabIndex = 129
        '
        'DNITextBox
        '
        Me.DNITextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(593, 229)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(132, 22)
        Me.DNITextBox.TabIndex = 126
        '
        'COD_JCFTextBox
        '
        Me.COD_JCFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_JCF", True))
        Me.COD_JCFTextBox.Location = New System.Drawing.Point(425, 229)
        Me.COD_JCFTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COD_JCFTextBox.Name = "COD_JCFTextBox"
        Me.COD_JCFTextBox.Size = New System.Drawing.Size(77, 22)
        Me.COD_JCFTextBox.TabIndex = 125
        '
        'FALLERO_CODIGOTextBox
        '
        Me.FALLERO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(176, 229)
        Me.FALLERO_CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.ReadOnly = True
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(76, 22)
        Me.FALLERO_CODIGOTextBox.TabIndex = 149
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'ComisionTableAdapter
        '
        Me.ComisionTableAdapter.ClearBeforeFill = True
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'RecompensasTableAdapter
        '
        Me.RecompensasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adeudosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banco_remesaTableAdapter = Nothing
        Me.TableAdapterManager.cargoTableAdapter = Me.CargoTableAdapter
        Me.TableAdapterManager.CensoTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.comisionTableAdapter = Me.ComisionTableAdapter
        Me.TableAdapterManager.datos_banco_para_abonosTableAdapter = Nothing
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa1TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa2TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Me.EjercicioTableAdapter
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.fallasTableAdapter = Me.FallasTableAdapter
        Me.TableAdapterManager.falleroTableAdapter = Me.FalleroTableAdapter
        Me.TableAdapterManager.letradniTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Me.RecompensasTableAdapter
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FallasTableAdapter
        '
        Me.FallasTableAdapter.ClearBeforeFill = True
        '
        'BAJACheckBox
        '
        Me.BAJACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FalleroBindingSource, "BAJA", True))
        Me.BAJACheckBox.Enabled = False
        Me.BAJACheckBox.Location = New System.Drawing.Point(128, 176)
        Me.BAJACheckBox.Name = "BAJACheckBox"
        Me.BAJACheckBox.Size = New System.Drawing.Size(30, 24)
        Me.BAJACheckBox.TabIndex = 190
        Me.BAJACheckBox.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.FalleroBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 710)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1090, 27)
        Me.BindingNavigator1.TabIndex = 191
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Button4
        '
        Me.Button4.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(459, 648)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 42)
        Me.Button4.TabIndex = 192
        Me.Button4.Text = "Ver Cuotas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(228, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 17)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "         Buscar fallero por Código:"
        '
        'TxtBuscarCodigo
        '
        Me.TxtBuscarCodigo.Location = New System.Drawing.Point(441, 42)
        Me.TxtBuscarCodigo.Name = "TxtBuscarCodigo"
        Me.TxtBuscarCodigo.Size = New System.Drawing.Size(100, 22)
        Me.TxtBuscarCodigo.TabIndex = 194
        '
        'BtnBuscarCodigo
        '
        Me.BtnBuscarCodigo.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnBuscarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarCodigo.Location = New System.Drawing.Point(550, 37)
        Me.BtnBuscarCodigo.Name = "BtnBuscarCodigo"
        Me.BtnBuscarCodigo.Size = New System.Drawing.Size(130, 31)
        Me.BtnBuscarCodigo.TabIndex = 195
        Me.BtnBuscarCodigo.Text = "Buscar código"
        Me.BtnBuscarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(281, 648)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(157, 42)
        Me.Button5.TabIndex = 196
        Me.Button5.Text = "Ver Historial"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CboComision
        '
        Me.CboComision.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FalleroBindingSource, "TIPFAL", True))
        Me.CboComision.DataSource = Me.ComisionBindingSource
        Me.CboComision.DisplayMember = "comision"
        Me.CboComision.DropDownWidth = 100
        Me.CboComision.FormattingEnabled = True
        Me.CboComision.Location = New System.Drawing.Point(1012, 376)
        Me.CboComision.Name = "CboComision"
        Me.CboComision.Size = New System.Drawing.Size(24, 24)
        Me.CboComision.TabIndex = 197
        Me.CboComision.ValueMember = "tipfal"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FalleroBindingSource, "REC_FAL", True))
        Me.ComboBox1.DataSource = Me.RecompensasFallaBindingSource
        Me.ComboBox1.DisplayMember = "DESREC"
        Me.ComboBox1.DropDownWidth = 100
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(398, 595)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(24, 24)
        Me.ComboBox1.TabIndex = 198
        Me.ComboBox1.ValueMember = "RECOM"
        '
        'RecompensasFallaBindingSource
        '
        Me.RecompensasFallaBindingSource.DataMember = "RecompensasFalla"
        Me.RecompensasFallaBindingSource.DataSource = Me.DbCensos
        '
        'RecompensasFallaTableAdapter
        '
        Me.RecompensasFallaTableAdapter.ClearBeforeFill = True
        '
        'DESRECTextBox1
        '
        Me.DESRECTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.DESRECTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasFallaBindingSource, "DESREC", True))
        Me.DESRECTextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DESRECTextBox1.Location = New System.Drawing.Point(231, 597)
        Me.DESRECTextBox1.Name = "DESRECTextBox1"
        Me.DESRECTextBox1.Size = New System.Drawing.Size(158, 22)
        Me.DESRECTextBox1.TabIndex = 199
        '
        'ANO_CENLabel
        '
        ANO_CENLabel.AutoSize = True
        ANO_CENLabel.Location = New System.Drawing.Point(899, 234)
        ANO_CENLabel.Name = "ANO_CENLabel"
        ANO_CENLabel.Size = New System.Drawing.Size(94, 17)
        ANO_CENLabel.TabIndex = 199
        ANO_CENLabel.Text = "AÑO CENSO:"
        '
        'ANO_CENTextBox
        '
        Me.ANO_CENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ANO_CEN", True))
        Me.ANO_CENTextBox.Location = New System.Drawing.Point(1004, 229)
        Me.ANO_CENTextBox.Name = "ANO_CENTextBox"
        Me.ANO_CENTextBox.Size = New System.Drawing.Size(58, 22)
        Me.ANO_CENTextBox.TabIndex = 200
        '
        'FrmDatosFiliacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1090, 737)
        Me.Controls.Add(Me.DgvFALLERO)
        Me.Controls.Add(ANO_CENLabel)
        Me.Controls.Add(Me.ANO_CENTextBox)
        Me.Controls.Add(Me.DESRECTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CboComision)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnBuscarCodigo)
        Me.Controls.Add(Me.TxtBuscarCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(BAJALabel)
        Me.Controls.Add(Me.BAJACheckBox)
        Me.Controls.Add(Me.FECHA_NACDateTimePicker)
        Me.Controls.Add(PasejuvenilLabel)
        Me.Controls.Add(Me.PasejuvenilTextBox)
        Me.Controls.Add(PasemayorLabel)
        Me.Controls.Add(Me.PasemayorTextBox)
        Me.Controls.Add(Me.ComisionTextBox)
        Me.Controls.Add(TIPFALLabel)
        Me.Controls.Add(Me.TIPFALTextBox)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.ActivosToolStrip)
        Me.Controls.Add(Me.DESFALTextBox)
        Me.Controls.Add(Me.NUMFALComboBox)
        Me.Controls.Add(Me.DESRECTextBox)
        Me.Controls.Add(Me.RECOMComboBox)
        Me.Controls.Add(Me.DESCRIPTextBox)
        Me.Controls.Add(Me.CARGOComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ULTCARTextBox)
        Me.Controls.Add(OBSERVACIONESLabel)
        Me.Controls.Add(Me.OBSERVACIONESTextBox)
        Me.Controls.Add(REC_FALLabel)
        Me.Controls.Add(Me.REC_FALTextBox)
        Me.Controls.Add(FAL_RECLabel)
        Me.Controls.Add(Me.FAL_RECTextBox)
        Me.Controls.Add(ANO_RECLabel)
        Me.Controls.Add(Me.ANO_RECTextBox)
        Me.Controls.Add(COD_RECLabel)
        Me.Controls.Add(Me.COD_RECTextBox)
        Me.Controls.Add(ULTCARLabel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(E_MAILLabel)
        Me.Controls.Add(Me.E_MAILTextBox)
        Me.Controls.Add(TELEFONOLabel)
        Me.Controls.Add(Me.TELEFONOTextBox)
        Me.Controls.Add(AñoejeLabel)
        Me.Controls.Add(Me.AñoejeTextBox)
        Me.Controls.Add(COD_POSTALLabel)
        Me.Controls.Add(Me.COD_POSTALTextBox)
        Me.Controls.Add(POBLACIONLabel)
        Me.Controls.Add(Me.POBLACIONTextBox)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.DIRECCIONTextBox)
        Me.Controls.Add(SEXOLabel)
        Me.Controls.Add(Me.SEXOTextBox)
        Me.Controls.Add(APELLIDOSLabel)
        Me.Controls.Add(Me.APELLIDOSTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(FECHA_NACLabel)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(COD_JCFLabel)
        Me.Controls.Add(Me.COD_JCFTextBox)
        Me.Controls.Add(FALLERO_CODIGOLabel)
        Me.Controls.Add(Me.FALLERO_CODIGOTextBox)
        Me.HelpProvider1.SetHelpKeyword(Me, "25")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDatosFiliacion"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha fallero"
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFALLERO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivosToolStrip.ResumeLayout(False)
        Me.ActivosToolStrip.PerformLayout()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.RecompensasFallaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FECHA_NACDateTimePicker As DateTimePicker
    Friend WithEvents PasejuvenilTextBox As TextBox
    Friend WithEvents PasemayorTextBox As TextBox
    Friend WithEvents ComisionTextBox As TextBox
    Friend WithEvents TIPFALTextBox As TextBox
    Friend WithEvents lblFiltro As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgvFALLERO As DataGridView
    Friend WithEvents ActivosToolStrip As ToolStrip
    Friend WithEvents ActivosToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents DESFALTextBox As TextBox
    Friend WithEvents NUMFALComboBox As ComboBox
    Friend WithEvents DESRECTextBox As TextBox
    Friend WithEvents RECOMComboBox As ComboBox
    Friend WithEvents DESCRIPTextBox As TextBox
    Friend WithEvents CARGOComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ULTCARTextBox As TextBox
    Friend WithEvents OBSERVACIONESTextBox As TextBox
    Friend WithEvents REC_FALTextBox As TextBox
    Friend WithEvents FAL_RECTextBox As TextBox
    Friend WithEvents ANO_RECTextBox As TextBox
    Friend WithEvents COD_RECTextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents E_MAILTextBox As TextBox
    Friend WithEvents TELEFONOTextBox As TextBox
    Friend WithEvents AñoejeTextBox As TextBox
    Friend WithEvents COD_POSTALTextBox As TextBox
    Friend WithEvents POBLACIONTextBox As TextBox
    Friend WithEvents DIRECCIONTextBox As TextBox
    Friend WithEvents SEXOTextBox As TextBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents COD_JCFTextBox As TextBox
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DbCensosTableAdapters.ejercicioTableAdapter
    Friend WithEvents ComisionBindingSource As BindingSource
    Friend WithEvents ComisionTableAdapter As DbCensosTableAdapters.comisionTableAdapter
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As DbCensosTableAdapters.cargoTableAdapter
    Friend WithEvents RecompensasBindingSource As BindingSource
    Friend WithEvents RecompensasTableAdapter As DbCensosTableAdapters.recompensasTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents BAJACheckBox As CheckBox
    Friend WithEvents FallasTableAdapter As DbCensosTableAdapters.fallasTableAdapter
    Friend WithEvents FallasBindingSource As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscarCodigo As TextBox
    Friend WithEvents BtnBuscarCodigo As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents CboComision As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RecompensasFallaBindingSource As BindingSource
    Friend WithEvents RecompensasFallaTableAdapter As DbCensosTableAdapters.RecompensasFallaTableAdapter
    Friend WithEvents DESRECTextBox1 As TextBox
    Friend WithEvents ANO_CENTextBox As TextBox
End Class
