<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAñadirCensoAHistorfa
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
        Dim CopiarCensoAHistorialLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAñadirCensoAHistorfa))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCopiarCenso = New System.Windows.Forms.Button()
        Me.CopiarCensoAHistorialCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CensoDataGridView = New System.Windows.Forms.DataGridView()
        Me.CODJCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ANOCEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FALCEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULTCAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CensoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFallero = New AppGestion.DataSetFallero()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.FALLERO_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.LblAcción = New System.Windows.Forms.Label()
        Me.LblAnoCen = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CensoTableAdapter = New AppGestion.DataSetFalleroTableAdapters.CensoTableAdapter()
        Me.HistorfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorfaTableAdapter = New AppGestion.DataSetFalleroTableAdapters.historfaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSetFalleroTableAdapters.TableAdapterManager()
        Me.RecompensasejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecompensasejercicioTableAdapter = New AppGestion.DataSetFalleroTableAdapters.recompensasejercicioTableAdapter()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager1 = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.lblBW = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CopiarCensoAHistorialLabel = New System.Windows.Forms.Label()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CensoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CensoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CopiarCensoAHistorialLabel
        '
        CopiarCensoAHistorialLabel.AutoSize = True
        CopiarCensoAHistorialLabel.Location = New System.Drawing.Point(29, 76)
        CopiarCensoAHistorialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CopiarCensoAHistorialLabel.Name = "CopiarCensoAHistorialLabel"
        CopiarCensoAHistorialLabel.Size = New System.Drawing.Size(173, 17)
        CopiarCensoAHistorialLabel.TabIndex = 7
        CopiarCensoAHistorialLabel.Text = "Haz click en Copiar Censo"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(899, 13)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Cancelar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCopiarCenso
        '
        Me.BtnCopiarCenso.Location = New System.Drawing.Point(213, 69)
        Me.BtnCopiarCenso.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCopiarCenso.Name = "BtnCopiarCenso"
        Me.BtnCopiarCenso.Size = New System.Drawing.Size(147, 28)
        Me.BtnCopiarCenso.TabIndex = 10
        Me.BtnCopiarCenso.Text = "Copiar censo"
        Me.BtnCopiarCenso.UseVisualStyleBackColor = True
        '
        'CopiarCensoAHistorialCheckBox
        '
        Me.CopiarCensoAHistorialCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "CopiarCensoAHistorial", True))
        Me.CopiarCensoAHistorialCheckBox.Location = New System.Drawing.Point(367, 69)
        Me.CopiarCensoAHistorialCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CopiarCensoAHistorialCheckBox.Name = "CopiarCensoAHistorialCheckBox"
        Me.CopiarCensoAHistorialCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.CopiarCensoAHistorialCheckBox.TabIndex = 9
        Me.CopiarCensoAHistorialCheckBox.Text = "Sin copiar"
        Me.CopiarCensoAHistorialCheckBox.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Añadir Censo a Historial"
        '
        'CensoDataGridView
        '
        Me.CensoDataGridView.AllowUserToAddRows = False
        Me.CensoDataGridView.AllowUserToDeleteRows = False
        Me.CensoDataGridView.AllowUserToOrderColumns = True
        Me.CensoDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CensoDataGridView.AutoGenerateColumns = False
        Me.CensoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CensoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CensoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODJCF, Me.ANOCEN, Me.FALCEN, Me.DNI, Me.ULTCAR, Me.TIPFAL, Me.CODIGO})
        Me.CensoDataGridView.DataSource = Me.CensoBindingSource
        Me.CensoDataGridView.Location = New System.Drawing.Point(14, 113)
        Me.CensoDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CensoDataGridView.Name = "CensoDataGridView"
        Me.CensoDataGridView.ReadOnly = True
        Me.CensoDataGridView.RowHeadersWidth = 51
        Me.CensoDataGridView.Size = New System.Drawing.Size(1035, 426)
        Me.CensoDataGridView.TabIndex = 6
        '
        'CODJCF
        '
        Me.CODJCF.DataPropertyName = "COD_JCF"
        Me.CODJCF.HeaderText = "COD_JCF"
        Me.CODJCF.MinimumWidth = 6
        Me.CODJCF.Name = "CODJCF"
        Me.CODJCF.ReadOnly = True
        '
        'ANOCEN
        '
        Me.ANOCEN.DataPropertyName = "ANO_CEN"
        Me.ANOCEN.HeaderText = "ANO_CEN"
        Me.ANOCEN.MinimumWidth = 6
        Me.ANOCEN.Name = "ANOCEN"
        Me.ANOCEN.ReadOnly = True
        '
        'FALCEN
        '
        Me.FALCEN.DataPropertyName = "FAL_CEN"
        Me.FALCEN.HeaderText = "FAL_CEN"
        Me.FALCEN.MinimumWidth = 6
        Me.FALCEN.Name = "FALCEN"
        Me.FALCEN.ReadOnly = True
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "DNI"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.MinimumWidth = 6
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'ULTCAR
        '
        Me.ULTCAR.DataPropertyName = "ULTCAR"
        Me.ULTCAR.HeaderText = "ULTCAR"
        Me.ULTCAR.MinimumWidth = 6
        Me.ULTCAR.Name = "ULTCAR"
        Me.ULTCAR.ReadOnly = True
        '
        'TIPFAL
        '
        Me.TIPFAL.DataPropertyName = "TIPFAL"
        Me.TIPFAL.HeaderText = "TIPFAL"
        Me.TIPFAL.MinimumWidth = 6
        Me.TIPFAL.Name = "TIPFAL"
        Me.TIPFAL.ReadOnly = True
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "FALLERO_CODIGO"
        Me.CODIGO.HeaderText = "FALLERO_CODIGO"
        Me.CODIGO.MinimumWidth = 6
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'CensoBindingSource
        '
        Me.CensoBindingSource.DataMember = "Censo"
        Me.CensoBindingSource.DataSource = Me.DataSetFallero
        '
        'DataSetFallero
        '
        Me.DataSetFallero.DataSetName = "DataSetFallero"
        Me.DataSetFallero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'FALLERO_CODIGOTextBox
        '
        Me.FALLERO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FalleroBindingSource, "FALLERO_CODIGO", True))
        Me.FALLERO_CODIGOTextBox.Location = New System.Drawing.Point(31, 46)
        Me.FALLERO_CODIGOTextBox.Name = "FALLERO_CODIGOTextBox"
        Me.FALLERO_CODIGOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FALLERO_CODIGOTextBox.TabIndex = 12
        Me.FALLERO_CODIGOTextBox.Visible = False
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
        'LblAcción
        '
        Me.LblAcción.AutoSize = True
        Me.LblAcción.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAcción.ForeColor = System.Drawing.Color.Green
        Me.LblAcción.Location = New System.Drawing.Point(387, 23)
        Me.LblAcción.Name = "LblAcción"
        Me.LblAcción.Size = New System.Drawing.Size(218, 20)
        Me.LblAcción.TabIndex = 13
        Me.LblAcción.Text = "Añadiendo Censo a historial"
        Me.LblAcción.Visible = False
        '
        'LblAnoCen
        '
        Me.LblAnoCen.AutoSize = True
        Me.LblAnoCen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CensoBindingSource, "ANO_CEN", True))
        Me.LblAnoCen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnoCen.Location = New System.Drawing.Point(267, 23)
        Me.LblAnoCen.Name = "LblAnoCen"
        Me.LblAnoCen.Size = New System.Drawing.Size(74, 20)
        Me.LblAnoCen.TabIndex = 14
        Me.LblAnoCen.Text = "AnoCen"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(531, 74)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(345, 23)
        Me.ProgressBar1.TabIndex = 15
        '
        'CensoTableAdapter
        '
        Me.CensoTableAdapter.ClearBeforeFill = True
        '
        'HistorfaBindingSource
        '
        Me.HistorfaBindingSource.DataMember = "historfa"
        Me.HistorfaBindingSource.DataSource = Me.DataSetFallero
        '
        'HistorfaTableAdapter
        '
        Me.HistorfaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.CensoTableAdapter = Me.CensoTableAdapter
        Me.TableAdapterManager.comisionTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasAgrupacionTableAdapter = Nothing
        Me.TableAdapterManager.recompensasejercicioTableAdapter = Nothing
        Me.TableAdapterManager.RecompensasFallaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSetFalleroTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecompensasejercicioBindingSource
        '
        Me.RecompensasejercicioBindingSource.DataMember = "recompensasejercicio"
        Me.RecompensasejercicioBindingSource.DataSource = Me.DataSetFallero
        '
        'RecompensasejercicioTableAdapter
        '
        Me.RecompensasejercicioTableAdapter.ClearBeforeFill = True
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
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
        'lblBW
        '
        Me.lblBW.AutoSize = True
        Me.lblBW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBW.ForeColor = System.Drawing.Color.Red
        Me.lblBW.Location = New System.Drawing.Point(527, 46)
        Me.lblBW.Name = "lblBW"
        Me.lblBW.Size = New System.Drawing.Size(77, 20)
        Me.lblBW.TabIndex = 17
        Me.lblBW.Text = "Progreso"
        '
        'FrmAñadirCensoAHistorfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1069, 563)
        Me.Controls.Add(Me.lblBW)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LblAnoCen)
        Me.Controls.Add(Me.LblAcción)
        Me.Controls.Add(Me.FALLERO_CODIGOTextBox)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCopiarCenso)
        Me.Controls.Add(CopiarCensoAHistorialLabel)
        Me.Controls.Add(Me.CopiarCensoAHistorialCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CensoDataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "60")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAñadirCensoAHistorfa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Censo a Historial"
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CensoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CensoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCopiarCenso As Button
    Friend WithEvents CopiarCensoAHistorialCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CensoDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents DataSetFallero As DataSetFallero
    Friend WithEvents CensoBindingSource As BindingSource
    Friend WithEvents CensoTableAdapter As DataSetFalleroTableAdapters.CensoTableAdapter
    Friend WithEvents CODJCF As DataGridViewTextBoxColumn
    Friend WithEvents ANOCEN As DataGridViewTextBoxColumn
    Friend WithEvents FALCEN As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents ULTCAR As DataGridViewTextBoxColumn
    Friend WithEvents TIPFAL As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents HistorfaBindingSource As BindingSource
    Friend WithEvents HistorfaTableAdapter As DataSetFalleroTableAdapters.historfaTableAdapter
    Friend WithEvents TableAdapterManager As DataSetFalleroTableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents RecompensasejercicioBindingSource As BindingSource
    Friend WithEvents RecompensasejercicioTableAdapter As DataSetFalleroTableAdapters.recompensasejercicioTableAdapter
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager1 As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents FALLERO_CODIGOTextBox As TextBox
    Friend WithEvents LblAcción As Label
    Private WithEvents LblAnoCen As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblBW As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
