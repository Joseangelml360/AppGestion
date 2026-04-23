<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubDatosFiliación
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
        Dim BAJALabel As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubDatosFiliación))
        Me.BAJACheckBox = New System.Windows.Forms.CheckBox()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.FECHA_NACDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PasejuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasemayorTextBox = New System.Windows.Forms.TextBox()
        Me.ComisionTextBox = New System.Windows.Forms.TextBox()
        Me.ComisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPFALTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.FallasTableAdapter = New AppGestion.DbCensosTableAdapters.fallasTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        BAJALabel = New System.Windows.Forms.Label()
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
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BAJALabel
        '
        BAJALabel.AutoSize = True
        BAJALabel.Location = New System.Drawing.Point(24, 74)
        BAJALabel.Name = "BAJALabel"
        BAJALabel.Size = New System.Drawing.Size(46, 17)
        BAJALabel.TabIndex = 252
        BAJALabel.Text = "BAJA:"
        '
        'PasejuvenilLabel
        '
        PasejuvenilLabel.AutoSize = True
        PasejuvenilLabel.Location = New System.Drawing.Point(785, 358)
        PasejuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasejuvenilLabel.Name = "PasejuvenilLabel"
        PasejuvenilLabel.Size = New System.Drawing.Size(83, 17)
        PasejuvenilLabel.TabIndex = 250
        PasejuvenilLabel.Text = "pasejuvenil:"
        PasejuvenilLabel.Visible = False
        '
        'PasemayorLabel
        '
        PasemayorLabel.AutoSize = True
        PasemayorLabel.Location = New System.Drawing.Point(786, 324)
        PasemayorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasemayorLabel.Name = "PasemayorLabel"
        PasemayorLabel.Size = New System.Drawing.Size(82, 17)
        PasemayorLabel.TabIndex = 248
        PasemayorLabel.Text = "pasemayor:"
        PasemayorLabel.Visible = False
        '
        'TIPFALLabel
        '
        TIPFALLabel.AutoSize = True
        TIPFALLabel.Location = New System.Drawing.Point(710, 280)
        TIPFALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIPFALLabel.Name = "TIPFALLabel"
        TIPFALLabel.Size = New System.Drawing.Size(69, 17)
        TIPFALLabel.TabIndex = 246
        TIPFALLabel.Text = "Comisión:"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.Location = New System.Drawing.Point(451, 361)
        OBSERVACIONESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(129, 17)
        OBSERVACIONESLabel.TabIndex = 240
        OBSERVACIONESLabel.Text = "OBSERVACIONES:"
        '
        'REC_FALLabel
        '
        REC_FALLabel.AutoSize = True
        REC_FALLabel.Location = New System.Drawing.Point(31, 498)
        REC_FALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        REC_FALLabel.Name = "REC_FALLabel"
        REC_FALLabel.Size = New System.Drawing.Size(69, 17)
        REC_FALLabel.TabIndex = 239
        REC_FALLabel.Text = "REC FAL:"
        '
        'FAL_RECLabel
        '
        FAL_RECLabel.AutoSize = True
        FAL_RECLabel.Location = New System.Drawing.Point(31, 435)
        FAL_RECLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FAL_RECLabel.Name = "FAL_RECLabel"
        FAL_RECLabel.Size = New System.Drawing.Size(69, 17)
        FAL_RECLabel.TabIndex = 237
        FAL_RECLabel.Text = "FAL REC:"
        '
        'ANO_RECLabel
        '
        ANO_RECLabel.AutoSize = True
        ANO_RECLabel.Location = New System.Drawing.Point(26, 464)
        ANO_RECLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ANO_RECLabel.Name = "ANO_RECLabel"
        ANO_RECLabel.Size = New System.Drawing.Size(74, 17)
        ANO_RECLabel.TabIndex = 236
        ANO_RECLabel.Text = "ANO REC:"
        '
        'COD_RECLabel
        '
        COD_RECLabel.AutoSize = True
        COD_RECLabel.Location = New System.Drawing.Point(26, 402)
        COD_RECLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COD_RECLabel.Name = "COD_RECLabel"
        COD_RECLabel.Size = New System.Drawing.Size(74, 17)
        COD_RECLabel.TabIndex = 234
        COD_RECLabel.Text = "COD REC:"
        '
        'ULTCARLabel
        '
        ULTCARLabel.AutoSize = True
        ULTCARLabel.Location = New System.Drawing.Point(33, 370)
        ULTCARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ULTCARLabel.Name = "ULTCARLabel"
        ULTCARLabel.Size = New System.Drawing.Size(67, 17)
        ULTCARLabel.TabIndex = 233
        ULTCARLabel.Text = "ULTCAR:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(870, 30)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(34, 20)
        IDLabel.TabIndex = 228
        IDLabel.Text = "ID:"
        '
        'E_MAILLabel
        '
        E_MAILLabel.AutoSize = True
        E_MAILLabel.Location = New System.Drawing.Point(327, 280)
        E_MAILLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        E_MAILLabel.Name = "E_MAILLabel"
        E_MAILLabel.Size = New System.Drawing.Size(57, 17)
        E_MAILLabel.TabIndex = 227
        E_MAILLabel.Text = "E-MAIL:"
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.AutoSize = True
        TELEFONOLabel.Location = New System.Drawing.Point(35, 277)
        TELEFONOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(87, 17)
        TELEFONOLabel.TabIndex = 226
        TELEFONOLabel.Text = "TELEFONO:"
        '
        'AñoejeLabel
        '
        AñoejeLabel.AutoSize = True
        AñoejeLabel.Location = New System.Drawing.Point(854, 125)
        AñoejeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AñoejeLabel.Name = "AñoejeLabel"
        AñoejeLabel.Size = New System.Drawing.Size(61, 17)
        AñoejeLabel.TabIndex = 225
        AñoejeLabel.Text = "Ejercicio"
        '
        'COD_POSTALLabel
        '
        COD_POSTALLabel.AutoSize = True
        COD_POSTALLabel.Location = New System.Drawing.Point(794, 228)
        COD_POSTALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COD_POSTALLabel.Name = "COD_POSTALLabel"
        COD_POSTALLabel.Size = New System.Drawing.Size(101, 17)
        COD_POSTALLabel.TabIndex = 224
        COD_POSTALLabel.Text = "COD POSTAL:"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(437, 228)
        POBLACIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(91, 17)
        POBLACIONLabel.TabIndex = 223
        POBLACIONLabel.Text = "POBLACION:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(22, 228)
        DIRECCIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(86, 17)
        DIRECCIONLabel.TabIndex = 222
        DIRECCIONLabel.Text = "DIRECCION:"
        '
        'SEXOLabel
        '
        SEXOLabel.AutoSize = True
        SEXOLabel.Location = New System.Drawing.Point(709, 125)
        SEXOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SEXOLabel.Name = "SEXOLabel"
        SEXOLabel.Size = New System.Drawing.Size(50, 17)
        SEXOLabel.TabIndex = 221
        SEXOLabel.Text = "SEXO:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(271, 178)
        APELLIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(88, 17)
        APELLIDOSLabel.TabIndex = 220
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(38, 178)
        NOMBRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(72, 17)
        NOMBRELabel.TabIndex = 219
        NOMBRELabel.Text = "NOMBRE:"
        '
        'FECHA_NACLabel
        '
        FECHA_NACLabel.AutoSize = True
        FECHA_NACLabel.Location = New System.Drawing.Point(715, 178)
        FECHA_NACLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FECHA_NACLabel.Name = "FECHA_NACLabel"
        FECHA_NACLabel.Size = New System.Drawing.Size(145, 17)
        FECHA_NACLabel.TabIndex = 218
        FECHA_NACLabel.Text = "FECHA NACIMIENTO:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(493, 130)
        DNILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(35, 17)
        DNILabel.TabIndex = 217
        DNILabel.Text = "DNI:"
        '
        'COD_JCFLabel
        '
        COD_JCFLabel.AutoSize = True
        COD_JCFLabel.Location = New System.Drawing.Point(291, 130)
        COD_JCFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COD_JCFLabel.Name = "COD_JCFLabel"
        COD_JCFLabel.Size = New System.Drawing.Size(70, 17)
        COD_JCFLabel.TabIndex = 216
        COD_JCFLabel.Text = "COD JCF:"
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(27, 130)
        FALLERO_CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(67, 17)
        FALLERO_CODIGOLabel.TabIndex = 214
        FALLERO_CODIGOLabel.Text = "CODIGO:"
        '
        'BAJACheckBox
        '
        Me.BAJACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "BAJA", True))
        Me.BAJACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FalleroBindingSource, "BAJA", True))
        Me.BAJACheckBox.Enabled = False
        Me.BAJACheckBox.Location = New System.Drawing.Point(74, 72)
        Me.BAJACheckBox.Name = "BAJACheckBox"
        Me.BAJACheckBox.Size = New System.Drawing.Size(30, 24)
        Me.BAJACheckBox.TabIndex = 253
        Me.BAJACheckBox.UseVisualStyleBackColor = True
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
        'FECHA_NACDateTimePicker
        '
        Me.FECHA_NACDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FalleroBindingSource, "FECHA_NAC", True))
        Me.FECHA_NACDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA_NACDateTimePicker.Location = New System.Drawing.Point(877, 170)
        Me.FECHA_NACDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FECHA_NACDateTimePicker.Name = "FECHA_NACDateTimePicker"
        Me.FECHA_NACDateTimePicker.Size = New System.Drawing.Size(132, 22)
        Me.FECHA_NACDateTimePicker.TabIndex = 199
        '
        'PasejuvenilTextBox
        '
        Me.PasejuvenilTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PasejuvenilTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasejuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "pasejuvenil", True))
        Me.PasejuvenilTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.PasejuvenilTextBox.Location = New System.Drawing.Point(877, 355)
        Me.PasejuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasejuvenilTextBox.Name = "PasejuvenilTextBox"
        Me.PasejuvenilTextBox.Size = New System.Drawing.Size(133, 15)
        Me.PasejuvenilTextBox.TabIndex = 251
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
        Me.PasemayorTextBox.Location = New System.Drawing.Point(873, 324)
        Me.PasemayorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasemayorTextBox.Name = "PasemayorTextBox"
        Me.PasemayorTextBox.Size = New System.Drawing.Size(133, 15)
        Me.PasemayorTextBox.TabIndex = 249
        '
        'ComisionTextBox
        '
        Me.ComisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComisionBindingSource, "comision", True))
        Me.ComisionTextBox.Location = New System.Drawing.Point(874, 276)
        Me.ComisionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ComisionTextBox.Name = "ComisionTextBox"
        Me.ComisionTextBox.ReadOnly = True
        Me.ComisionTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ComisionTextBox.TabIndex = 247
        '
        'ComisionBindingSource
        '
        Me.ComisionBindingSource.DataMember = "comision"
        Me.ComisionBindingSource.DataSource = Me.DbCensos
        '
        'TIPFALTextBox
        '
        Me.TIPFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TIPFAL", True))
        Me.TIPFALTextBox.Location = New System.Drawing.Point(786, 276)
        Me.TIPFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TIPFALTextBox.Name = "TIPFALTextBox"
        Me.TIPFALTextBox.Size = New System.Drawing.Size(79, 22)
        Me.TIPFALTextBox.TabIndex = 205
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.Location = New System.Drawing.Point(107, 68)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 245
        Me.Button3.Text = "Dar de baja"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(686, 494)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 42)
        Me.Button2.TabIndex = 212
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DESFALTextBox
        '
        Me.DESFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FallasBindingSource, "DESFAL", True))
        Me.DESFALTextBox.Location = New System.Drawing.Point(174, 427)
        Me.DESFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESFALTextBox.Name = "DESFALTextBox"
        Me.DESFALTextBox.ReadOnly = True
        Me.DESFALTextBox.Size = New System.Drawing.Size(161, 22)
        Me.DESFALTextBox.TabIndex = 244
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
        Me.NUMFALComboBox.Location = New System.Drawing.Point(343, 427)
        Me.NUMFALComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NUMFALComboBox.Name = "NUMFALComboBox"
        Me.NUMFALComboBox.Size = New System.Drawing.Size(25, 24)
        Me.NUMFALComboBox.TabIndex = 208
        Me.NUMFALComboBox.ValueMember = "NUMFAL"
        '
        'DESRECTextBox
        '
        Me.DESRECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasBindingSource, "DESREC", True))
        Me.DESRECTextBox.Location = New System.Drawing.Point(174, 393)
        Me.DESRECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESRECTextBox.Name = "DESRECTextBox"
        Me.DESRECTextBox.ReadOnly = True
        Me.DESRECTextBox.Size = New System.Drawing.Size(161, 22)
        Me.DESRECTextBox.TabIndex = 243
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
        Me.RECOMComboBox.Location = New System.Drawing.Point(343, 395)
        Me.RECOMComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RECOMComboBox.Name = "RECOMComboBox"
        Me.RECOMComboBox.Size = New System.Drawing.Size(25, 24)
        Me.RECOMComboBox.TabIndex = 207
        Me.RECOMComboBox.ValueMember = "RECOM"
        '
        'DESCRIPTextBox
        '
        Me.DESCRIPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargoBindingSource, "DESCRIP", True))
        Me.DESCRIPTextBox.Location = New System.Drawing.Point(174, 363)
        Me.DESCRIPTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCRIPTextBox.Name = "DESCRIPTextBox"
        Me.DESCRIPTextBox.ReadOnly = True
        Me.DESCRIPTextBox.Size = New System.Drawing.Size(161, 22)
        Me.DESCRIPTextBox.TabIndex = 242
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
        Me.CARGOComboBox.Location = New System.Drawing.Point(343, 363)
        Me.CARGOComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CARGOComboBox.Name = "CARGOComboBox"
        Me.CARGOComboBox.Size = New System.Drawing.Size(24, 24)
        Me.CARGOComboBox.TabIndex = 206
        Me.CARGOComboBox.ValueMember = "CARGO"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(851, 494)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 42)
        Me.Button1.TabIndex = 213
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ULTCARTextBox
        '
        Me.ULTCARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ULTCAR", True))
        Me.ULTCARTextBox.Location = New System.Drawing.Point(111, 363)
        Me.ULTCARTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ULTCARTextBox.Name = "ULTCARTextBox"
        Me.ULTCARTextBox.ReadOnly = True
        Me.ULTCARTextBox.Size = New System.Drawing.Size(55, 22)
        Me.ULTCARTextBox.TabIndex = 241
        '
        'OBSERVACIONESTextBox
        '
        Me.OBSERVACIONESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "OBSERVACIONES", True))
        Me.OBSERVACIONESTextBox.Location = New System.Drawing.Point(455, 389)
        Me.OBSERVACIONESTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OBSERVACIONESTextBox.Multiline = True
        Me.OBSERVACIONESTextBox.Name = "OBSERVACIONESTextBox"
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(552, 66)
        Me.OBSERVACIONESTextBox.TabIndex = 211
        '
        'REC_FALTextBox
        '
        Me.REC_FALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "REC_FAL", True))
        Me.REC_FALTextBox.Location = New System.Drawing.Point(111, 494)
        Me.REC_FALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.REC_FALTextBox.Name = "REC_FALTextBox"
        Me.REC_FALTextBox.Size = New System.Drawing.Size(55, 22)
        Me.REC_FALTextBox.TabIndex = 210
        '
        'FAL_RECTextBox
        '
        Me.FAL_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FAL_REC", True))
        Me.FAL_RECTextBox.Location = New System.Drawing.Point(111, 427)
        Me.FAL_RECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FAL_RECTextBox.Name = "FAL_RECTextBox"
        Me.FAL_RECTextBox.ReadOnly = True
        Me.FAL_RECTextBox.Size = New System.Drawing.Size(55, 22)
        Me.FAL_RECTextBox.TabIndex = 238
        '
        'ANO_RECTextBox
        '
        Me.ANO_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ANO_REC", True))
        Me.ANO_RECTextBox.Location = New System.Drawing.Point(111, 459)
        Me.ANO_RECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ANO_RECTextBox.Name = "ANO_RECTextBox"
        Me.ANO_RECTextBox.Size = New System.Drawing.Size(55, 22)
        Me.ANO_RECTextBox.TabIndex = 209
        '
        'COD_RECTextBox
        '
        Me.COD_RECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_REC", True))
        Me.COD_RECTextBox.Location = New System.Drawing.Point(111, 395)
        Me.COD_RECTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COD_RECTextBox.Name = "COD_RECTextBox"
        Me.COD_RECTextBox.ReadOnly = True
        Me.COD_RECTextBox.Size = New System.Drawing.Size(55, 22)
        Me.COD_RECTextBox.TabIndex = 235
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox3.Location = New System.Drawing.Point(133, 26)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 13, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(277, 26)
        Me.TextBox3.TabIndex = 232
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(419, 26)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(413, 26)
        Me.TextBox2.TabIndex = 231
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(26, 26)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 26)
        Me.TextBox1.TabIndex = 230
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IDTextBox.Location = New System.Drawing.Point(918, 26)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(90, 26)
        Me.IDTextBox.TabIndex = 229
        '
        'E_MAILTextBox
        '
        Me.E_MAILTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.E_MAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "Email", True))
        Me.E_MAILTextBox.Location = New System.Drawing.Point(395, 276)
        Me.E_MAILTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.E_MAILTextBox.Name = "E_MAILTextBox"
        Me.E_MAILTextBox.Size = New System.Drawing.Size(248, 22)
        Me.E_MAILTextBox.TabIndex = 204
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TELEFONO", True))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(133, 274)
        Me.TELEFONOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TELEFONOTextBox.TabIndex = 203
        '
        'AñoejeTextBox
        '
        Me.AñoejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.AñoejeTextBox.Location = New System.Drawing.Point(918, 121)
        Me.AñoejeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AñoejeTextBox.Name = "AñoejeTextBox"
        Me.AñoejeTextBox.ReadOnly = True
        Me.AñoejeTextBox.Size = New System.Drawing.Size(89, 22)
        Me.AñoejeTextBox.TabIndex = 196
        '
        'COD_POSTALTextBox
        '
        Me.COD_POSTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_POSTAL", True))
        Me.COD_POSTALTextBox.Location = New System.Drawing.Point(906, 224)
        Me.COD_POSTALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COD_POSTALTextBox.Name = "COD_POSTALTextBox"
        Me.COD_POSTALTextBox.Size = New System.Drawing.Size(101, 22)
        Me.COD_POSTALTextBox.TabIndex = 202
        '
        'POBLACIONTextBox
        '
        Me.POBLACIONTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.POBLACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "POBLACION", True))
        Me.POBLACIONTextBox.Location = New System.Drawing.Point(539, 224)
        Me.POBLACIONTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.POBLACIONTextBox.Name = "POBLACIONTextBox"
        Me.POBLACIONTextBox.Size = New System.Drawing.Size(192, 22)
        Me.POBLACIONTextBox.TabIndex = 201
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(122, 224)
        Me.DIRECCIONTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(245, 22)
        Me.DIRECCIONTextBox.TabIndex = 200
        '
        'SEXOTextBox
        '
        Me.SEXOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SEXOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "SEXO", True))
        Me.SEXOTextBox.Location = New System.Drawing.Point(769, 121)
        Me.SEXOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SEXOTextBox.Name = "SEXOTextBox"
        Me.SEXOTextBox.Size = New System.Drawing.Size(48, 22)
        Me.SEXOTextBox.TabIndex = 195
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(371, 174)
        Me.APELLIDOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(327, 22)
        Me.APELLIDOSTextBox.TabIndex = 198
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(122, 174)
        Me.NOMBRETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(132, 22)
        Me.NOMBRETextBox.TabIndex = 197
        '
        'DNITextBox
        '
        Me.DNITextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(539, 126)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(132, 22)
        Me.DNITextBox.TabIndex = 194
        '
        'COD_JCFTextBox
        '
        Me.COD_JCFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_JCF", True))
        Me.COD_JCFTextBox.Location = New System.Drawing.Point(371, 126)
        Me.COD_JCFTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COD_JCFTextBox.Name = "COD_JCFTextBox"
        Me.COD_JCFTextBox.Size = New System.Drawing.Size(77, 22)
        Me.COD_JCFTextBox.TabIndex = 193
        '
        'FALLERO_CODIGOTextBox
        '
        Me.FALLERO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(122, 125)
        Me.FALLERO_CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.ReadOnly = True
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(76, 22)
        Me.FALLERO_CODIGOTextBox.TabIndex = 215
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
        'FallasTableAdapter
        '
        Me.FallasTableAdapter.ClearBeforeFill = True
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
        'Me.TableAdapterManager.historfaTableAdapter = Nothing
        Me.TableAdapterManager.letradniTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Me.RecompensasTableAdapter
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmSubDatosFiliación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 555)
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
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSubDatosFiliación"
        Me.Text = "Datos Censo fallero seleccionado"
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAJACheckBox As CheckBox
    Friend WithEvents FECHA_NACDateTimePicker As DateTimePicker
    Friend WithEvents PasejuvenilTextBox As TextBox
    Friend WithEvents PasemayorTextBox As TextBox
    Friend WithEvents ComisionTextBox As TextBox
    Friend WithEvents TIPFALTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
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
    Friend WithEvents FallasBindingSource As BindingSource
    Friend WithEvents FallasTableAdapter As DbCensosTableAdapters.fallasTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
End Class
