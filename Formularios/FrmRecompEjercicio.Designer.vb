<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRecompEjercicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecompEjercicio))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RecompensasejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnoejeTextBox = New System.Windows.Forms.TextBox()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BtnSalr = New System.Windows.Forms.Button()
        Me.BtnListado = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.LblProgreso = New System.Windows.Forms.Label()
        Me.LblRecsJCF = New System.Windows.Forms.Label()
        Me.LblRecsFalla = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblJ13 = New System.Windows.Forms.Label()
        Me.LblJ12 = New System.Windows.Forms.Label()
        Me.LblJ11 = New System.Windows.Forms.Label()
        Me.LblJ5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblJ4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblJ3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblJ2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblJ1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblF6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblF8 = New System.Windows.Forms.Label()
        Me.LblF4 = New System.Windows.Forms.Label()
        Me.LblF3 = New System.Windows.Forms.Label()
        Me.LblF2 = New System.Windows.Forms.Label()
        Me.LblF1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.RbtJCF = New System.Windows.Forms.RadioButton()
        Me.RbtFalla = New System.Windows.Forms.RadioButton()
        Me.BtnTodos = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbtFallaJCF = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbtMayores = New System.Windows.Forms.RadioButton()
        Me.RbtInfantiles = New System.Windows.Forms.RadioButton()
        Me.HistorfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecompensasejercicioTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasejercicioTableAdapter()
        Me.CriteriorecompBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriteriorecompTableAdapter = New AppGestion.DataSet1TableAdapters.criteriorecompTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.Fallero1TableAdapter = New AppGestion.DataSet1TableAdapters.Fallero1TableAdapter()
        Me.HistorfaTableAdapter = New AppGestion.DataSet1TableAdapters.historfaTableAdapter()
        Me.Fallero1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EjercicioTableAdapter = New AppGestion.DataSet1TableAdapters.ejercicioTableAdapter()
        Me.LblFiltro = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.EJERCICIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFALLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECJF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULTRECJCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEJE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEJECARGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULTRECFALLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEJEFALLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECAGRUPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriorecompBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EJERCICIODataGridViewTextBoxColumn, Me.CODIGODataGridViewTextBoxColumn, Me.CODFALLA, Me.DNI, Me.TIPFALDataGridViewTextBoxColumn, Me.CARGO, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.RECJF, Me.RECFALLADataGridViewTextBoxColumn, Me.ULTRECJCF, Me.NUMEJE, Me.NUMEJECARGO, Me.ULTRECFALLA, Me.NUMEJEFALLA, Me.RECAGRUPDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RecompensasejercicioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1449, 257)
        Me.DataGridView1.TabIndex = 0
        '
        'RecompensasejercicioBindingSource
        '
        Me.RecompensasejercicioBindingSource.DataMember = "recompensasejercicio"
        Me.RecompensasejercicioBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Recompensas del ejercicio"
        '
        'AnoejeTextBox
        '
        Me.AnoejeTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.AnoejeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnoejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.AnoejeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoejeTextBox.ForeColor = System.Drawing.SystemColors.Menu
        Me.AnoejeTextBox.Location = New System.Drawing.Point(1302, 13)
        Me.AnoejeTextBox.Name = "AnoejeTextBox"
        Me.AnoejeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnoejeTextBox.TabIndex = 7
        '
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSet1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(226, 68)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(806, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'BtnSalr
        '
        Me.BtnSalr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalr.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalr.Location = New System.Drawing.Point(1280, 53)
        Me.BtnSalr.Name = "BtnSalr"
        Me.BtnSalr.Size = New System.Drawing.Size(175, 42)
        Me.BtnSalr.TabIndex = 3
        Me.BtnSalr.Text = "Salir"
        Me.BtnSalr.UseVisualStyleBackColor = True
        '
        'BtnListado
        '
        Me.BtnListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnListado.Image = Global.AppGestion.My.Resources.Resources.report
        Me.BtnListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListado.Location = New System.Drawing.Point(1073, 53)
        Me.BtnListado.Name = "BtnListado"
        Me.BtnListado.Size = New System.Drawing.Size(175, 42)
        Me.BtnListado.TabIndex = 2
        Me.BtnListado.Text = "Ver Listado"
        Me.BtnListado.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Image = Global.AppGestion.My.Resources.Resources.text_signature
        Me.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerar.Location = New System.Drawing.Point(12, 53)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(175, 42)
        Me.BtnGenerar.TabIndex = 1
        Me.BtnGenerar.Text = "Generar/Calcular"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'LblProgreso
        '
        Me.LblProgreso.AutoSize = True
        Me.LblProgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblProgreso.Location = New System.Drawing.Point(1046, 68)
        Me.LblProgreso.Name = "LblProgreso"
        Me.LblProgreso.Size = New System.Drawing.Size(0, 17)
        Me.LblProgreso.TabIndex = 9
        '
        'LblRecsJCF
        '
        Me.LblRecsJCF.AutoSize = True
        Me.LblRecsJCF.Location = New System.Drawing.Point(111, 0)
        Me.LblRecsJCF.Name = "LblRecsJCF"
        Me.LblRecsJCF.Size = New System.Drawing.Size(149, 17)
        Me.LblRecsJCF.TabIndex = 10
        Me.LblRecsJCF.Text = "Nº Recompensas JCF:"
        '
        'LblRecsFalla
        '
        Me.LblRecsFalla.AutoSize = True
        Me.LblRecsFalla.Location = New System.Drawing.Point(131, 0)
        Me.LblRecsFalla.Name = "LblRecsFalla"
        Me.LblRecsFalla.Size = New System.Drawing.Size(155, 17)
        Me.LblRecsFalla.TabIndex = 11
        Me.LblRecsFalla.Text = "Nª Recompensas Falla:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblJ13)
        Me.GroupBox1.Controls.Add(Me.LblJ12)
        Me.GroupBox1.Controls.Add(Me.LblJ11)
        Me.GroupBox1.Controls.Add(Me.LblJ5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblJ4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LblJ3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblJ2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblJ1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblRecsJCF)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'LblJ13
        '
        Me.LblJ13.AutoSize = True
        Me.LblJ13.Location = New System.Drawing.Point(122, 82)
        Me.LblJ13.Name = "LblJ13"
        Me.LblJ13.Size = New System.Drawing.Size(50, 17)
        Me.LblJ13.TabIndex = 35
        Me.LblJ13.Text = "LblJ13"
        Me.LblJ13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblJ12
        '
        Me.LblJ12.AutoSize = True
        Me.LblJ12.Location = New System.Drawing.Point(122, 59)
        Me.LblJ12.Name = "LblJ12"
        Me.LblJ12.Size = New System.Drawing.Size(50, 17)
        Me.LblJ12.TabIndex = 34
        Me.LblJ12.Text = "LblJ12"
        Me.LblJ12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblJ11
        '
        Me.LblJ11.AutoSize = True
        Me.LblJ11.Location = New System.Drawing.Point(122, 32)
        Me.LblJ11.Name = "LblJ11"
        Me.LblJ11.Size = New System.Drawing.Size(50, 17)
        Me.LblJ11.TabIndex = 33
        Me.LblJ11.Text = "LblJ11"
        Me.LblJ11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblJ5
        '
        Me.LblJ5.AutoSize = True
        Me.LblJ5.Location = New System.Drawing.Point(580, 57)
        Me.LblJ5.Name = "LblJ5"
        Me.LblJ5.Size = New System.Drawing.Size(42, 17)
        Me.LblJ5.TabIndex = 32
        Me.LblJ5.Text = "LblJ5"
        Me.LblJ5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(457, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Bunyol Brillants"
        '
        'LblJ4
        '
        Me.LblJ4.AutoSize = True
        Me.LblJ4.Location = New System.Drawing.Point(580, 30)
        Me.LblJ4.Name = "LblJ4"
        Me.LblJ4.Size = New System.Drawing.Size(42, 17)
        Me.LblJ4.TabIndex = 31
        Me.LblJ4.Text = "LblJ4"
        Me.LblJ4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(457, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Bunyol Fulles"
        '
        'LblJ3
        '
        Me.LblJ3.AutoSize = True
        Me.LblJ3.Location = New System.Drawing.Point(345, 80)
        Me.LblJ3.Name = "LblJ3"
        Me.LblJ3.Size = New System.Drawing.Size(42, 17)
        Me.LblJ3.TabIndex = 30
        Me.LblJ3.Text = "LblJ3"
        Me.LblJ3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Bunyol d'Or"
        '
        'LblJ2
        '
        Me.LblJ2.AutoSize = True
        Me.LblJ2.Location = New System.Drawing.Point(345, 57)
        Me.LblJ2.Name = "LblJ2"
        Me.LblJ2.Size = New System.Drawing.Size(42, 17)
        Me.LblJ2.TabIndex = 29
        Me.LblJ2.Text = "LblJ2"
        Me.LblJ2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Bunyol d'Argent"
        '
        'LblJ1
        '
        Me.LblJ1.AutoSize = True
        Me.LblJ1.Location = New System.Drawing.Point(345, 30)
        Me.LblJ1.Name = "LblJ1"
        Me.LblJ1.Size = New System.Drawing.Size(42, 17)
        Me.LblJ1.TabIndex = 28
        Me.LblJ1.Text = "LblJ1"
        Me.LblJ1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Bunyol d'Coure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Distintiu d'Or"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Distintiu d'Argent"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Distintiu d'Coure"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblF6)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.LblF8)
        Me.GroupBox2.Controls.Add(Me.LblF4)
        Me.GroupBox2.Controls.Add(Me.LblF3)
        Me.GroupBox2.Controls.Add(Me.LblF2)
        Me.GroupBox2.Controls.Add(Me.LblF1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LblRecsFalla)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(737, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 100)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'LblF6
        '
        Me.LblF6.AutoSize = True
        Me.LblF6.Location = New System.Drawing.Point(388, 81)
        Me.LblF6.Name = "LblF6"
        Me.LblF6.Size = New System.Drawing.Size(43, 17)
        Me.LblF6.TabIndex = 29
        Me.LblF6.Text = "LblF6"
        Me.LblF6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(275, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 17)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Joia"
        '
        'LblF8
        '
        Me.LblF8.AutoSize = True
        Me.LblF8.Location = New System.Drawing.Point(388, 56)
        Me.LblF8.Name = "LblF8"
        Me.LblF8.Size = New System.Drawing.Size(43, 17)
        Me.LblF8.TabIndex = 27
        Me.LblF8.Text = "LblF8"
        Me.LblF8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF4
        '
        Me.LblF4.AutoSize = True
        Me.LblF4.Location = New System.Drawing.Point(388, 29)
        Me.LblF4.Name = "LblF4"
        Me.LblF4.Size = New System.Drawing.Size(43, 17)
        Me.LblF4.TabIndex = 26
        Me.LblF4.Text = "LblF4"
        Me.LblF4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF3
        '
        Me.LblF3.AutoSize = True
        Me.LblF3.Location = New System.Drawing.Point(146, 78)
        Me.LblF3.Name = "LblF3"
        Me.LblF3.Size = New System.Drawing.Size(43, 17)
        Me.LblF3.TabIndex = 25
        Me.LblF3.Text = "LblF3"
        Me.LblF3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF2
        '
        Me.LblF2.AutoSize = True
        Me.LblF2.Location = New System.Drawing.Point(146, 55)
        Me.LblF2.Name = "LblF2"
        Me.LblF2.Size = New System.Drawing.Size(43, 17)
        Me.LblF2.TabIndex = 24
        Me.LblF2.Text = "LblF2"
        Me.LblF2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF1
        '
        Me.LblF1.AutoSize = True
        Me.LblF1.Location = New System.Drawing.Point(146, 28)
        Me.LblF1.Name = "LblF1"
        Me.LblF1.Size = New System.Drawing.Size(43, 17)
        Me.LblF1.TabIndex = 23
        Me.LblF1.Text = "LblF1"
        Me.LblF1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Bunyol Brillants"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Bunyol d'Coure"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(275, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Bunyol Fulles"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Bunyol d'Argent"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Bunyol d'Or"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Location = New System.Drawing.Point(1229, 190)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(93, 31)
        Me.BtnFiltrar.TabIndex = 16
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'RbtJCF
        '
        Me.RbtJCF.AutoSize = True
        Me.RbtJCF.Location = New System.Drawing.Point(6, 16)
        Me.RbtJCF.Name = "RbtJCF"
        Me.RbtJCF.Size = New System.Drawing.Size(53, 21)
        Me.RbtJCF.TabIndex = 18
        Me.RbtJCF.TabStop = True
        Me.RbtJCF.Text = "JCF"
        Me.RbtJCF.UseVisualStyleBackColor = True
        '
        'RbtFalla
        '
        Me.RbtFalla.AutoSize = True
        Me.RbtFalla.Location = New System.Drawing.Point(72, 16)
        Me.RbtFalla.Name = "RbtFalla"
        Me.RbtFalla.Size = New System.Drawing.Size(59, 21)
        Me.RbtFalla.TabIndex = 19
        Me.RbtFalla.TabStop = True
        Me.RbtFalla.Text = "Falla"
        Me.RbtFalla.UseVisualStyleBackColor = True
        '
        'BtnTodos
        '
        Me.BtnTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTodos.Location = New System.Drawing.Point(1345, 190)
        Me.BtnTodos.Name = "BtnTodos"
        Me.BtnTodos.Size = New System.Drawing.Size(98, 31)
        Me.BtnTodos.TabIndex = 20
        Me.BtnTodos.Text = "Borrar filtro"
        Me.BtnTodos.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.RbtFallaJCF)
        Me.GroupBox3.Controls.Add(Me.RbtJCF)
        Me.GroupBox3.Controls.Add(Me.RbtFalla)
        Me.GroupBox3.Location = New System.Drawing.Point(1213, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 45)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'RbtFallaJCF
        '
        Me.RbtFallaJCF.AutoSize = True
        Me.RbtFallaJCF.Location = New System.Drawing.Point(147, 16)
        Me.RbtFallaJCF.Name = "RbtFallaJCF"
        Me.RbtFallaJCF.Size = New System.Drawing.Size(87, 21)
        Me.RbtFallaJCF.TabIndex = 20
        Me.RbtFallaJCF.TabStop = True
        Me.RbtFallaJCF.Text = "JCF/Falla"
        Me.RbtFallaJCF.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.RbtMayores)
        Me.GroupBox4.Controls.Add(Me.RbtInfantiles)
        Me.GroupBox4.Location = New System.Drawing.Point(1213, 101)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(242, 44)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        '
        'RbtMayores
        '
        Me.RbtMayores.AutoSize = True
        Me.RbtMayores.Location = New System.Drawing.Point(6, 16)
        Me.RbtMayores.Name = "RbtMayores"
        Me.RbtMayores.Size = New System.Drawing.Size(83, 21)
        Me.RbtMayores.TabIndex = 18
        Me.RbtMayores.TabStop = True
        Me.RbtMayores.Text = "Mayores"
        Me.RbtMayores.UseVisualStyleBackColor = True
        '
        'RbtInfantiles
        '
        Me.RbtInfantiles.AutoSize = True
        Me.RbtInfantiles.Location = New System.Drawing.Point(145, 16)
        Me.RbtInfantiles.Name = "RbtInfantiles"
        Me.RbtInfantiles.Size = New System.Drawing.Size(85, 21)
        Me.RbtInfantiles.TabIndex = 19
        Me.RbtInfantiles.TabStop = True
        Me.RbtInfantiles.Text = "Infantiles"
        Me.RbtInfantiles.UseVisualStyleBackColor = True
        '
        'HistorfaBindingSource
        '
        Me.HistorfaBindingSource.DataMember = "historfa"
        Me.HistorfaBindingSource.DataSource = Me.DataSet1
        '
        'RecompensasejercicioTableAdapter
        '
        Me.RecompensasejercicioTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.criteriorecompTableAdapter = Me.CriteriorecompTableAdapter
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.Fallero1TableAdapter = Me.Fallero1TableAdapter
        Me.TableAdapterManager.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager.historfaTableAdapter = Me.HistorfaTableAdapter
        Me.TableAdapterManager.MensajesTableAdapter = Nothing
        Me.TableAdapterManager.recompensasejercicioTableAdapter = Me.RecompensasejercicioTableAdapter
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Fallero1TableAdapter
        '
        Me.Fallero1TableAdapter.ClearBeforeFill = True
        '
        'HistorfaTableAdapter
        '
        Me.HistorfaTableAdapter.ClearBeforeFill = True
        '
        'Fallero1BindingSource
        '
        Me.Fallero1BindingSource.DataMember = "Fallero1"
        Me.Fallero1BindingSource.DataSource = Me.DataSet1
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'LblFiltro
        '
        Me.LblFiltro.AutoSize = True
        Me.LblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltro.Location = New System.Drawing.Point(704, 13)
        Me.LblFiltro.Name = "LblFiltro"
        Me.LblFiltro.Size = New System.Drawing.Size(89, 25)
        Me.LblFiltro.TabIndex = 23
        Me.LblFiltro.Text = "Label15"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(12, 55)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(175, 42)
        Me.BtnCancelar.TabIndex = 25
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'EJERCICIODataGridViewTextBoxColumn
        '
        Me.EJERCICIODataGridViewTextBoxColumn.DataPropertyName = "EJERCICIO"
        Me.EJERCICIODataGridViewTextBoxColumn.HeaderText = "Ejercicio"
        Me.EJERCICIODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EJERCICIODataGridViewTextBoxColumn.Name = "EJERCICIODataGridViewTextBoxColumn"
        '
        'CODIGODataGridViewTextBoxColumn
        '
        Me.CODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODIGODataGridViewTextBoxColumn.Name = "CODIGODataGridViewTextBoxColumn"
        '
        'CODFALLA
        '
        Me.CODFALLA.DataPropertyName = "CODFALLA"
        Me.CODFALLA.HeaderText = "Cod. Falla"
        Me.CODFALLA.MinimumWidth = 6
        Me.CODFALLA.Name = "CODFALLA"
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "DNI"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.MinimumWidth = 6
        Me.DNI.Name = "DNI"
        '
        'TIPFALDataGridViewTextBoxColumn
        '
        Me.TIPFALDataGridViewTextBoxColumn.DataPropertyName = "TIPFAL"
        Me.TIPFALDataGridViewTextBoxColumn.HeaderText = "Comisión"
        Me.TIPFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPFALDataGridViewTextBoxColumn.Name = "TIPFALDataGridViewTextBoxColumn"
        '
        'CARGO
        '
        Me.CARGO.DataPropertyName = "CARGO"
        Me.CARGO.HeaderText = "Cargo"
        Me.CARGO.MinimumWidth = 6
        Me.CARGO.Name = "CARGO"
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        '
        'RECJF
        '
        Me.RECJF.DataPropertyName = "RECJF"
        Me.RECJF.HeaderText = "Rec. JCF"
        Me.RECJF.MinimumWidth = 6
        Me.RECJF.Name = "RECJF"
        '
        'RECFALLADataGridViewTextBoxColumn
        '
        Me.RECFALLADataGridViewTextBoxColumn.DataPropertyName = "RECFALLA"
        Me.RECFALLADataGridViewTextBoxColumn.HeaderText = "Rec. Falla"
        Me.RECFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECFALLADataGridViewTextBoxColumn.Name = "RECFALLADataGridViewTextBoxColumn"
        '
        'ULTRECJCF
        '
        Me.ULTRECJCF.DataPropertyName = "ULTRECJCF"
        Me.ULTRECJCF.HeaderText = "Ult. JCF"
        Me.ULTRECJCF.MinimumWidth = 6
        Me.ULTRECJCF.Name = "ULTRECJCF"
        '
        'NUMEJE
        '
        Me.NUMEJE.DataPropertyName = "NUMEJE"
        Me.NUMEJE.HeaderText = "Eje JCF"
        Me.NUMEJE.MinimumWidth = 6
        Me.NUMEJE.Name = "NUMEJE"
        '
        'NUMEJECARGO
        '
        Me.NUMEJECARGO.DataPropertyName = "NUMEJECARGO"
        Me.NUMEJECARGO.HeaderText = "Eje Cargo"
        Me.NUMEJECARGO.MinimumWidth = 6
        Me.NUMEJECARGO.Name = "NUMEJECARGO"
        '
        'ULTRECFALLA
        '
        Me.ULTRECFALLA.DataPropertyName = "ULTRECFALLA"
        Me.ULTRECFALLA.HeaderText = "Ult. Falla"
        Me.ULTRECFALLA.MinimumWidth = 6
        Me.ULTRECFALLA.Name = "ULTRECFALLA"
        '
        'NUMEJEFALLA
        '
        Me.NUMEJEFALLA.DataPropertyName = "NUMEJEFALLA"
        Me.NUMEJEFALLA.HeaderText = "Eje Falla"
        Me.NUMEJEFALLA.MinimumWidth = 6
        Me.NUMEJEFALLA.Name = "NUMEJEFALLA"
        '
        'RECAGRUPDataGridViewTextBoxColumn
        '
        Me.RECAGRUPDataGridViewTextBoxColumn.DataPropertyName = "RECAGRUP"
        Me.RECAGRUPDataGridViewTextBoxColumn.HeaderText = "Rec. Agrup"
        Me.RECAGRUPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECAGRUPDataGridViewTextBoxColumn.Name = "RECAGRUPDataGridViewTextBoxColumn"
        '
        'FrmRecompEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 505)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblFiltro)
        Me.Controls.Add(Me.LblProgreso)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnTodos)
        Me.Controls.Add(Me.BtnFiltrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AnoejeTextBox)
        Me.Controls.Add(Me.BtnSalr)
        Me.Controls.Add(Me.BtnListado)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRecompEjercicio"
        Me.Text = "Recompensas del Ejercicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriorecompBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents RecompensasejercicioBindingSource As BindingSource
    Friend WithEvents RecompensasejercicioTableAdapter As DataSet1TableAdapters.recompensasejercicioTableAdapter
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents BtnListado As Button
    Friend WithEvents BtnSalr As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CriteriorecompBindingSource As BindingSource
    Friend WithEvents CriteriorecompTableAdapter As DataSet1TableAdapters.criteriorecompTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents HistorfaTableAdapter As DataSet1TableAdapters.historfaTableAdapter
    Friend WithEvents HistorfaBindingSource As BindingSource
    Friend WithEvents Fallero1TableAdapter As DataSet1TableAdapters.Fallero1TableAdapter
    Friend WithEvents Fallero1BindingSource As BindingSource
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DataSet1TableAdapters.ejercicioTableAdapter
    Friend WithEvents AnoejeTextBox As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LblProgreso As Label
    Friend WithEvents LblRecsJCF As Label
    Friend WithEvents LblRecsFalla As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblJ13 As Label
    Friend WithEvents LblJ12 As Label
    Friend WithEvents LblJ11 As Label
    Friend WithEvents LblJ5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblJ4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblJ3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblJ2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblJ1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblF6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblF8 As Label
    Friend WithEvents LblF4 As Label
    Friend WithEvents LblF3 As Label
    Friend WithEvents LblF2 As Label
    Friend WithEvents LblF1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents RbtJCF As RadioButton
    Friend WithEvents RbtFalla As RadioButton
    Friend WithEvents BtnTodos As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RbtMayores As RadioButton
    Friend WithEvents RbtInfantiles As RadioButton
    Friend WithEvents RbtFallaJCF As RadioButton
    Friend WithEvents LblFiltro As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents EJERCICIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODFALLA As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CARGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECJF As DataGridViewTextBoxColumn
    Friend WithEvents RECFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ULTRECJCF As DataGridViewTextBoxColumn
    Friend WithEvents NUMEJE As DataGridViewTextBoxColumn
    Friend WithEvents NUMEJECARGO As DataGridViewTextBoxColumn
    Friend WithEvents ULTRECFALLA As DataGridViewTextBoxColumn
    Friend WithEvents NUMEJEFALLA As DataGridViewTextBoxColumn
    Friend WithEvents RECAGRUPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
