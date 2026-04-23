<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnviarRemesa
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
        Dim FechaCargoLabel1 As System.Windows.Forms.Label
        Dim IdRemesaLabel As System.Windows.Forms.Label
        Dim FechaCargoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnviarRemesa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EnviarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConsolidarRemesaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEnviar = New System.Windows.Forms.TextBox()
        Me.TxtConsolidar = New System.Windows.Forms.TextBox()
        Me.DtpFechCgoGen = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechCgoEnv = New System.Windows.Forms.DateTimePicker()
        Me.IdRemesaTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BancoTextBox = New System.Windows.Forms.TextBox()
        Me.BancoremesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Banco_remesaTableAdapter = New AppGestion.DbCensosTableAdapters.banco_remesaTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New AppGestion.DbCensosTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.AdeudosTableAdapter = New AppGestion.DbCensosTableAdapters.adeudosTableAdapter()
        Me.AdeudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnDeshacer = New System.Windows.Forms.Button()
        Me.BtnConsolidar = New System.Windows.Forms.Button()
        Me.BtnInforme = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.DetallesDeRemesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.RemesasTableAdapter = New AppGestion.DataSet1TableAdapters.remesasTableAdapter()
        Me.Detalles_de_remesaTableAdapter = New AppGestion.DataSet1TableAdapters.detalles_de_remesaTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        FechaCargoLabel1 = New System.Windows.Forms.Label()
        IdRemesaLabel = New System.Windows.Forms.Label()
        FechaCargoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BancoremesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdeudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaCargoLabel1
        '
        FechaCargoLabel1.AutoSize = True
        FechaCargoLabel1.Location = New System.Drawing.Point(327, 23)
        FechaCargoLabel1.Name = "FechaCargoLabel1"
        FechaCargoLabel1.Size = New System.Drawing.Size(93, 17)
        FechaCargoLabel1.TabIndex = 9
        FechaCargoLabel1.Text = "Fecha Cargo:"
        '
        'IdRemesaLabel
        '
        IdRemesaLabel.AutoSize = True
        IdRemesaLabel.Location = New System.Drawing.Point(21, 26)
        IdRemesaLabel.Name = "IdRemesaLabel"
        IdRemesaLabel.Size = New System.Drawing.Size(161, 17)
        IdRemesaLabel.TabIndex = 7
        IdRemesaLabel.Text = "Última Remesa enviada:"
        '
        'FechaCargoLabel
        '
        FechaCargoLabel.AutoSize = True
        FechaCargoLabel.Location = New System.Drawing.Point(327, 76)
        FechaCargoLabel.Name = "FechaCargoLabel"
        FechaCargoLabel.Size = New System.Drawing.Size(93, 17)
        FechaCargoLabel.TabIndex = 5
        FechaCargoLabel.Text = "Fecha Cargo:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(7, 81)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(175, 17)
        IdLabel.TabIndex = 3
        IdLabel.Text = "Última Remesa Generada:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(179, 359)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(52, 17)
        BancoLabel.TabIndex = 39
        BancoLabel.Text = "Banco:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EnviarRemesaCheckBox)
        Me.GroupBox1.Controls.Add(Me.ConsolidarRemesaCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtEnviar)
        Me.GroupBox1.Controls.Add(Me.TxtConsolidar)
        Me.GroupBox1.Controls.Add(Me.DtpFechCgoGen)
        Me.GroupBox1.Controls.Add(FechaCargoLabel1)
        Me.GroupBox1.Controls.Add(Me.DtpFechCgoEnv)
        Me.GroupBox1.Controls.Add(IdRemesaLabel)
        Me.GroupBox1.Controls.Add(Me.IdRemesaTextBox)
        Me.GroupBox1.Controls.Add(FechaCargoLabel)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 151)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'EnviarRemesaCheckBox
        '
        Me.EnviarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "EnviarRemesa", True))
        Me.EnviarRemesaCheckBox.Location = New System.Drawing.Point(551, 104)
        Me.EnviarRemesaCheckBox.Name = "EnviarRemesaCheckBox"
        Me.EnviarRemesaCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.EnviarRemesaCheckBox.TabIndex = 25
        Me.EnviarRemesaCheckBox.UseVisualStyleBackColor = True
        '
        'ConsolidarRemesaCheckBox
        '
        Me.ConsolidarRemesaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "ConsolidarRemesa", True))
        Me.ConsolidarRemesaCheckBox.Location = New System.Drawing.Point(339, 102)
        Me.ConsolidarRemesaCheckBox.Name = "ConsolidarRemesaCheckBox"
        Me.ConsolidarRemesaCheckBox.Size = New System.Drawing.Size(30, 24)
        Me.ConsolidarRemesaCheckBox.TabIndex = 2
        Me.ConsolidarRemesaCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Estado última generada:"
        '
        'TxtEnviar
        '
        Me.TxtEnviar.Location = New System.Drawing.Point(413, 104)
        Me.TxtEnviar.Name = "TxtEnviar"
        Me.TxtEnviar.Size = New System.Drawing.Size(132, 22)
        Me.TxtEnviar.TabIndex = 23
        '
        'TxtConsolidar
        '
        Me.TxtConsolidar.Location = New System.Drawing.Point(188, 104)
        Me.TxtConsolidar.Name = "TxtConsolidar"
        Me.TxtConsolidar.Size = New System.Drawing.Size(145, 22)
        Me.TxtConsolidar.TabIndex = 22
        '
        'DtpFechCgoGen
        '
        Me.DtpFechCgoGen.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetallesDeRemesaBindingSource, "FechaCargo", True))
        Me.DtpFechCgoGen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechCgoGen.Location = New System.Drawing.Point(427, 76)
        Me.DtpFechCgoGen.Name = "DtpFechCgoGen"
        Me.DtpFechCgoGen.Size = New System.Drawing.Size(131, 22)
        Me.DtpFechCgoGen.TabIndex = 21
        '
        'DtpFechCgoEnv
        '
        Me.DtpFechCgoEnv.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RemesasBindingSource, "FechaCargo", True))
        Me.DtpFechCgoEnv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechCgoEnv.Location = New System.Drawing.Point(426, 19)
        Me.DtpFechCgoEnv.Name = "DtpFechCgoEnv"
        Me.DtpFechCgoEnv.Size = New System.Drawing.Size(132, 22)
        Me.DtpFechCgoEnv.TabIndex = 10
        '
        'IdRemesaTextBox
        '
        Me.IdRemesaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RemesasBindingSource, "IdRemesa", True))
        Me.IdRemesaTextBox.Location = New System.Drawing.Point(188, 23)
        Me.IdRemesaTextBox.Name = "IdRemesaTextBox"
        Me.IdRemesaTextBox.Size = New System.Drawing.Size(74, 22)
        Me.IdRemesaTextBox.TabIndex = 8
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallesDeRemesaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(188, 78)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(74, 22)
        Me.IdTextBox.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(237, 395)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(248, 23)
        Me.ProgressBar1.TabIndex = 41
        Me.ProgressBar1.Visible = False
        '
        'BancoTextBox
        '
        Me.BancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Banco", True))
        Me.BancoTextBox.Location = New System.Drawing.Point(237, 354)
        Me.BancoTextBox.Name = "BancoTextBox"
        Me.BancoTextBox.Size = New System.Drawing.Size(248, 22)
        Me.BancoTextBox.TabIndex = 40
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Operar con Remesa Generada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Generar archivo para el Banco"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Deshacer Remesa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Consolidar Remesa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Informe Remesa Generada"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(659, 405)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 37)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Image = Global.AppGestion.My.Resources.Resources.page_edit
        Me.BtnEnviar.Location = New System.Drawing.Point(368, 285)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(37, 37)
        Me.BtnEnviar.TabIndex = 32
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'Banco_remesaTableAdapter
        '
        Me.Banco_remesaTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.DbCensos
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adeudosTableAdapter = Me.AdeudosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banco_remesaTableAdapter = Me.Banco_remesaTableAdapter
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.CensoTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.comisionTableAdapter = Nothing
        Me.TableAdapterManager.datos_banco_para_abonosTableAdapter = Nothing
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa1TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesa2TableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.fallasTableAdapter = Nothing
        Me.TableAdapterManager.falleroTableAdapter = Nothing
        'Me.TableAdapterManager.historfaTableAdapter = Nothing
        Me.TableAdapterManager.letradniTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DbCensosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AdeudosTableAdapter
        '
        Me.AdeudosTableAdapter.ClearBeforeFill = True
        '
        'AdeudosBindingSource
        '
        Me.AdeudosBindingSource.DataMember = "adeudos"
        Me.AdeudosBindingSource.DataSource = Me.DbCensos
        '
        'BtnDeshacer
        '
        Me.BtnDeshacer.Image = Global.AppGestion.My.Resources.Resources.table_row_delete
        Me.BtnDeshacer.Location = New System.Drawing.Point(368, 232)
        Me.BtnDeshacer.Name = "BtnDeshacer"
        Me.BtnDeshacer.Size = New System.Drawing.Size(37, 37)
        Me.BtnDeshacer.TabIndex = 31
        Me.BtnDeshacer.UseVisualStyleBackColor = True
        '
        'BtnConsolidar
        '
        Me.BtnConsolidar.Image = Global.AppGestion.My.Resources.Resources.folder_page
        Me.BtnConsolidar.Location = New System.Drawing.Point(32, 285)
        Me.BtnConsolidar.Name = "BtnConsolidar"
        Me.BtnConsolidar.Size = New System.Drawing.Size(37, 37)
        Me.BtnConsolidar.TabIndex = 30
        Me.BtnConsolidar.UseVisualStyleBackColor = True
        '
        'BtnInforme
        '
        Me.BtnInforme.Image = Global.AppGestion.My.Resources.Resources.report
        Me.BtnInforme.Location = New System.Drawing.Point(32, 233)
        Me.BtnInforme.Name = "BtnInforme"
        Me.BtnInforme.Size = New System.Drawing.Size(37, 37)
        Me.BtnInforme.TabIndex = 29
        Me.BtnInforme.UseVisualStyleBackColor = True
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
        'DetallesDeRemesaBindingSource
        '
        Me.DetallesDeRemesaBindingSource.DataMember = "detalles de remesa"
        Me.DetallesDeRemesaBindingSource.DataSource = Me.DataSet1
        '
        'RemesasBindingSource
        '
        Me.RemesasBindingSource.DataMember = "remesas"
        Me.RemesasBindingSource.DataSource = Me.DataSet1
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'RemesasTableAdapter
        '
        Me.RemesasTableAdapter.ClearBeforeFill = True
        '
        'Detalles_de_remesaTableAdapter
        '
        Me.Detalles_de_remesaTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 17)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Escribiendo archivo en tabla ...   clientes"
        '
        'FrmEnviarRemesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(BancoLabel)
        Me.Controls.Add(Me.BancoTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.BtnDeshacer)
        Me.Controls.Add(Me.BtnConsolidar)
        Me.Controls.Add(Me.BtnInforme)
        Me.HelpProvider1.SetHelpKeyword(Me, "18")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEnviarRemesa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operar con Remesa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BancoremesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdeudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallesDeRemesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EnviarRemesaCheckBox As CheckBox
    Friend WithEvents ConsolidarRemesaCheckBox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEnviar As TextBox
    Friend WithEvents TxtConsolidar As TextBox
    Friend WithEvents DtpFechCgoGen As DateTimePicker
    Friend WithEvents DtpFechCgoEnv As DateTimePicker
    Friend WithEvents IdRemesaTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BancoTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnDeshacer As Button
    Friend WithEvents BtnConsolidar As Button
    Friend WithEvents BtnInforme As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents RemesasBindingSource As BindingSource
    Friend WithEvents RemesasTableAdapter As DataSet1TableAdapters.remesasTableAdapter
    Friend WithEvents DetallesDeRemesaBindingSource As BindingSource
    Friend WithEvents Detalles_de_remesaTableAdapter As DataSet1TableAdapters.detalles_de_remesaTableAdapter
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents BancoremesaBindingSource As BindingSource
    Friend WithEvents Banco_remesaTableAdapter As DbCensosTableAdapters.banco_remesaTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DbCensosTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents AdeudosTableAdapter As DbCensosTableAdapters.adeudosTableAdapter
    Friend WithEvents AdeudosBindingSource As BindingSource
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label7 As Label
End Class
