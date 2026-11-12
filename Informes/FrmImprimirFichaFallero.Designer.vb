<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirFichaFallero
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
        Dim FALLERO_CODIGOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim FECHA_NACLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim POBLACIONLabel As System.Windows.Forms.Label
        Dim COD_POSTALLabel As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim COD_JCFLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.historfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.FECHA_NACDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox()
        Me.POBLACIONTextBox = New System.Windows.Forms.TextBox()
        Me.COD_POSTALTextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONOTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.historfaTableAdapter = New AppGestion.DbCensosTableAdapters.historfaTableAdapter()
        Me.COD_JCFTextBox = New System.Windows.Forms.TextBox()
        FALLERO_CODIGOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        FECHA_NACLabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        POBLACIONLabel = New System.Windows.Forms.Label()
        COD_POSTALLabel = New System.Windows.Forms.Label()
        TELEFONOLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        COD_JCFLabel = New System.Windows.Forms.Label()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.historfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(13, 72)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(86, 17)
        FALLERO_CODIGOLabel.TabIndex = 1
        FALLERO_CODIGOLabel.Text = "Código Falla"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(133, 56)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(58, 17)
        NOMBRELabel.TabIndex = 2
        NOMBRELabel.Text = "Nombre"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(293, 56)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(65, 17)
        APELLIDOSLabel.TabIndex = 4
        APELLIDOSLabel.Text = "Apellidos"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(578, 56)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(31, 17)
        DNILabel.TabIndex = 6
        DNILabel.Text = "DNI"
        '
        'FECHA_NACLabel
        '
        FECHA_NACLabel.AutoSize = True
        FECHA_NACLabel.Location = New System.Drawing.Point(732, 56)
        FECHA_NACLabel.Name = "FECHA_NACLabel"
        FECHA_NACLabel.Size = New System.Drawing.Size(121, 17)
        FECHA_NACLabel.TabIndex = 8
        FECHA_NACLabel.Text = "Fecha Nacimiento"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(133, 110)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(67, 17)
        DIRECCIONLabel.TabIndex = 10
        DIRECCIONLabel.Text = "Dirección"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(402, 110)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(70, 17)
        POBLACIONLabel.TabIndex = 12
        POBLACIONLabel.Text = "Población"
        '
        'COD_POSTALLabel
        '
        COD_POSTALLabel.AutoSize = True
        COD_POSTALLabel.Location = New System.Drawing.Point(568, 110)
        COD_POSTALLabel.Name = "COD_POSTALLabel"
        COD_POSTALLabel.Size = New System.Drawing.Size(80, 17)
        COD_POSTALLabel.TabIndex = 14
        COD_POSTALLabel.Text = "Cód. Postal"
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.AutoSize = True
        TELEFONOLabel.Location = New System.Drawing.Point(664, 110)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(64, 17)
        TELEFONOLabel.TabIndex = 16
        TELEFONOLabel.Text = "Teléfono"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(785, 110)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "Email:"
        '
        'COD_JCFLabel
        '
        COD_JCFLabel.AutoSize = True
        COD_JCFLabel.Location = New System.Drawing.Point(1173, 72)
        COD_JCFLabel.Name = "COD_JCFLabel"
        COD_JCFLabel.Size = New System.Drawing.Size(84, 17)
        COD_JCFLabel.TabIndex = 26
        COD_JCFLabel.Text = "Código JCF:"
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
        'historfaBindingSource
        '
        Me.historfaBindingSource.DataMember = "historfa"
        Me.historfaBindingSource.DataSource = Me.DbCensos
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
        'FALLERO_CODIGOTextBox
        '
        Me.FALLERO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.FALLERO_CODIGOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(13, 92)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(100, 53)
        Me.FALLERO_CODIGOTextBox.TabIndex = 2
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(136, 76)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(151, 22)
        Me.NOMBRETextBox.TabIndex = 3
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(293, 76)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(257, 22)
        Me.APELLIDOSTextBox.TabIndex = 5
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(581, 76)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(122, 22)
        Me.DNITextBox.TabIndex = 7
        '
        'FECHA_NACDateTimePicker
        '
        Me.FECHA_NACDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FalleroBindingSource, "FECHA_NAC", True))
        Me.FECHA_NACDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA_NACDateTimePicker.Location = New System.Drawing.Point(735, 76)
        Me.FECHA_NACDateTimePicker.Name = "FECHA_NACDateTimePicker"
        Me.FECHA_NACDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FECHA_NACDateTimePicker.TabIndex = 9
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(136, 130)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(263, 22)
        Me.DIRECCIONTextBox.TabIndex = 11
        '
        'POBLACIONTextBox
        '
        Me.POBLACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "POBLACION", True))
        Me.POBLACIONTextBox.Location = New System.Drawing.Point(405, 130)
        Me.POBLACIONTextBox.Name = "POBLACIONTextBox"
        Me.POBLACIONTextBox.Size = New System.Drawing.Size(150, 22)
        Me.POBLACIONTextBox.TabIndex = 13
        '
        'COD_POSTALTextBox
        '
        Me.COD_POSTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_POSTAL", True))
        Me.COD_POSTALTextBox.Location = New System.Drawing.Point(569, 130)
        Me.COD_POSTALTextBox.Name = "COD_POSTALTextBox"
        Me.COD_POSTALTextBox.Size = New System.Drawing.Size(74, 22)
        Me.COD_POSTALTextBox.TabIndex = 15
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "TELEFONO", True))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(667, 130)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TELEFONOTextBox.TabIndex = 17
        '
        'EmailTextBox
        '
        Me.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(788, 130)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(214, 22)
        Me.EmailTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 36)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "IMPRESIÓN FICHA DE FALLERO"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(995, 13)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(170, 22)
        Me.TxtBuscar.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(896, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Buscar fallero"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.NOMBRE})
        Me.DataGridView1.DataSource = Me.FalleroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(837, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(573, 72)
        Me.DataGridView1.TabIndex = 23
        Me.DataGridView1.Visible = False
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.FillWeight = 123.5294!
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 77
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.FillWeight = 88.23529!
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 270
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.FillWeight = 88.23529!
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 150
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1343, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.FalleroBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.historfaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptFichaDatos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 176)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1405, 292)
        Me.ReportViewer1.TabIndex = 25
        '
        'historfaTableAdapter
        '
        Me.historfaTableAdapter.ClearBeforeFill = True
        '
        'COD_JCFTextBox
        '
        Me.COD_JCFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "COD_JCF", True))
        Me.COD_JCFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COD_JCFTextBox.Location = New System.Drawing.Point(1173, 92)
        Me.COD_JCFTextBox.Name = "COD_JCFTextBox"
        Me.COD_JCFTextBox.Size = New System.Drawing.Size(170, 53)
        Me.COD_JCFTextBox.TabIndex = 27
        Me.COD_JCFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmImprimirFichaFallero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1430, 469)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(COD_JCFLabel)
        Me.Controls.Add(Me.COD_JCFTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TELEFONOLabel)
        Me.Controls.Add(Me.TELEFONOTextBox)
        Me.Controls.Add(COD_POSTALLabel)
        Me.Controls.Add(Me.COD_POSTALTextBox)
        Me.Controls.Add(POBLACIONLabel)
        Me.Controls.Add(Me.POBLACIONTextBox)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.DIRECCIONTextBox)
        Me.Controls.Add(FECHA_NACLabel)
        Me.Controls.Add(Me.FECHA_NACDateTimePicker)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(APELLIDOSLabel)
        Me.Controls.Add(Me.APELLIDOSTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(FALLERO_CODIGOLabel)
        Me.Controls.Add(Me.FALLERO_CODIGOTextBox)
        Me.Name = "FrmImprimirFichaFallero"
        Me.Text = "Imprimir Ficha de fallero"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.historfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents FECHA_NACDateTimePicker As DateTimePicker
    Friend WithEvents DIRECCIONTextBox As TextBox
    Friend WithEvents POBLACIONTextBox As TextBox
    Friend WithEvents COD_POSTALTextBox As TextBox
    Friend WithEvents TELEFONOTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents historfaBindingSource As BindingSource
    Friend WithEvents historfaTableAdapter As DbCensosTableAdapters.historfaTableAdapter
    Friend WithEvents COD_JCFTextBox As TextBox
End Class
