<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFichaDatos
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
        Dim COD_JCFLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim COD_POSTALLabel As System.Windows.Forms.Label
        Dim POBLACIONLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim FECHA_NACLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim FALLERO_CODIGOLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.falleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.historfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_JCFTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONOTextBox = New System.Windows.Forms.TextBox()
        Me.COD_POSTALTextBox = New System.Windows.Forms.TextBox()
        Me.POBLACIONTextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox()
        Me.FECHA_NACDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.falleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.historfaTableAdapter = New AppGestion.DbCensosTableAdapters.historfaTableAdapter()
        COD_JCFLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TELEFONOLabel = New System.Windows.Forms.Label()
        COD_POSTALLabel = New System.Windows.Forms.Label()
        POBLACIONLabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        FECHA_NACLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        FALLERO_CODIGOLabel = New System.Windows.Forms.Label()
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.historfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COD_JCFLabel
        '
        COD_JCFLabel.AutoSize = True
        COD_JCFLabel.Location = New System.Drawing.Point(1171, 81)
        COD_JCFLabel.Name = "COD_JCFLabel"
        COD_JCFLabel.Size = New System.Drawing.Size(84, 17)
        COD_JCFLabel.TabIndex = 53
        COD_JCFLabel.Text = "Código JCF:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(783, 119)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 46
        EmailLabel.Text = "Email:"
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.AutoSize = True
        TELEFONOLabel.Location = New System.Drawing.Point(662, 119)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(64, 17)
        TELEFONOLabel.TabIndex = 44
        TELEFONOLabel.Text = "Teléfono"
        '
        'COD_POSTALLabel
        '
        COD_POSTALLabel.AutoSize = True
        COD_POSTALLabel.Location = New System.Drawing.Point(566, 119)
        COD_POSTALLabel.Name = "COD_POSTALLabel"
        COD_POSTALLabel.Size = New System.Drawing.Size(80, 17)
        COD_POSTALLabel.TabIndex = 42
        COD_POSTALLabel.Text = "Cód. Postal"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(400, 119)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(70, 17)
        POBLACIONLabel.TabIndex = 40
        POBLACIONLabel.Text = "Población"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(131, 119)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(67, 17)
        DIRECCIONLabel.TabIndex = 38
        DIRECCIONLabel.Text = "Dirección"
        '
        'FECHA_NACLabel
        '
        FECHA_NACLabel.AutoSize = True
        FECHA_NACLabel.Location = New System.Drawing.Point(730, 65)
        FECHA_NACLabel.Name = "FECHA_NACLabel"
        FECHA_NACLabel.Size = New System.Drawing.Size(121, 17)
        FECHA_NACLabel.TabIndex = 36
        FECHA_NACLabel.Text = "Fecha Nacimiento"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(576, 65)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(31, 17)
        DNILabel.TabIndex = 34
        DNILabel.Text = "DNI"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(291, 65)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(65, 17)
        APELLIDOSLabel.TabIndex = 32
        APELLIDOSLabel.Text = "Apellidos"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(131, 65)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(58, 17)
        NOMBRELabel.TabIndex = 30
        NOMBRELabel.Text = "Nombre"
        '
        'FALLERO_CODIGOLabel
        '
        FALLERO_CODIGOLabel.AutoSize = True
        FALLERO_CODIGOLabel.Location = New System.Drawing.Point(11, 81)
        FALLERO_CODIGOLabel.Name = "FALLERO_CODIGOLabel"
        FALLERO_CODIGOLabel.Size = New System.Drawing.Size(86, 17)
        FALLERO_CODIGOLabel.TabIndex = 28
        FALLERO_CODIGOLabel.Text = "Código Falla"
        '
        'falleroBindingSource
        '
        Me.falleroBindingSource.DataMember = "fallero"
        Me.falleroBindingSource.DataSource = Me.DbCensos
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.NOMBRE})
        Me.DataGridView1.DataSource = Me.falleroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(835, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(573, 20)
        Me.DataGridView1.TabIndex = 51
        Me.DataGridView1.Visible = False
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 75
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
        Me.NOMBRE.FillWeight = 88.23529!
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 150
        '
        'COD_JCFTextBox
        '
        Me.COD_JCFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "COD_JCF", True))
        Me.COD_JCFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COD_JCFTextBox.Location = New System.Drawing.Point(1171, 101)
        Me.COD_JCFTextBox.Name = "COD_JCFTextBox"
        Me.COD_JCFTextBox.Size = New System.Drawing.Size(170, 53)
        Me.COD_JCFTextBox.TabIndex = 54
        Me.COD_JCFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1341, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(894, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Buscar fallero"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(993, 22)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(170, 22)
        Me.TxtBuscar.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 36)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "IMPRESIÓN FICHA DE FALLERO"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(786, 139)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(214, 22)
        Me.EmailTextBox.TabIndex = 47
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "TELEFONO", True))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(665, 139)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TELEFONOTextBox.TabIndex = 45
        '
        'COD_POSTALTextBox
        '
        Me.COD_POSTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "COD_POSTAL", True))
        Me.COD_POSTALTextBox.Location = New System.Drawing.Point(567, 139)
        Me.COD_POSTALTextBox.Name = "COD_POSTALTextBox"
        Me.COD_POSTALTextBox.Size = New System.Drawing.Size(74, 22)
        Me.COD_POSTALTextBox.TabIndex = 43
        '
        'POBLACIONTextBox
        '
        Me.POBLACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "POBLACION", True))
        Me.POBLACIONTextBox.Location = New System.Drawing.Point(403, 139)
        Me.POBLACIONTextBox.Name = "POBLACIONTextBox"
        Me.POBLACIONTextBox.Size = New System.Drawing.Size(150, 22)
        Me.POBLACIONTextBox.TabIndex = 41
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(134, 139)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(263, 22)
        Me.DIRECCIONTextBox.TabIndex = 39
        '
        'FECHA_NACDateTimePicker
        '
        Me.FECHA_NACDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.falleroBindingSource, "FECHA_NAC", True))
        Me.FECHA_NACDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA_NACDateTimePicker.Location = New System.Drawing.Point(733, 85)
        Me.FECHA_NACDateTimePicker.Name = "FECHA_NACDateTimePicker"
        Me.FECHA_NACDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FECHA_NACDateTimePicker.TabIndex = 37
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(579, 85)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(122, 22)
        Me.DNITextBox.TabIndex = 35
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(291, 85)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(257, 22)
        Me.APELLIDOSTextBox.TabIndex = 33
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(134, 85)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(151, 22)
        Me.NOMBRETextBox.TabIndex = 31
        '
        'FALLERO_CODIGOTextBox
        '
        Me.FALLERO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.falleroBindingSource, "FALLERO_CODIGO", True))
        Me.FALLERO_CODIGOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(11, 101)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(100, 53)
        Me.FALLERO_CODIGOTextBox.TabIndex = 29
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.falleroBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.historfaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptFichaDatos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 180)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1409, 285)
        Me.ReportViewer1.TabIndex = 55
        '
        'falleroTableAdapter
        '
        Me.falleroTableAdapter.ClearBeforeFill = True
        '
        'historfaTableAdapter
        '
        Me.historfaTableAdapter.ClearBeforeFill = True
        '
        'FrmFichaDatos
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
        Me.Name = "FrmFichaDatos"
        Me.Text = "FrmFichaDatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.falleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.historfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents COD_JCFTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TELEFONOTextBox As TextBox
    Friend WithEvents COD_POSTALTextBox As TextBox
    Friend WithEvents POBLACIONTextBox As TextBox
    Friend WithEvents DIRECCIONTextBox As TextBox
    Friend WithEvents FECHA_NACDateTimePicker As DateTimePicker
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents falleroBindingSource As BindingSource
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents historfaBindingSource As BindingSource
    Friend WithEvents falleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents historfaTableAdapter As DbCensosTableAdapters.historfaTableAdapter
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
End Class
