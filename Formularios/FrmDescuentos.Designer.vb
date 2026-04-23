<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescuentos
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
        Dim AsignarDtoNuevoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDescuentos))
        Me.AsignarDtoNuevoCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Descuentos_de_la_cuotaDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDESCUENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCUENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentosDeLaCuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Descuentos_de_la_cuotaTableAdapter = New AppGestion.DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        AsignarDtoNuevoLabel = New System.Windows.Forms.Label()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Descuentos_de_la_cuotaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AsignarDtoNuevoLabel
        '
        AsignarDtoNuevoLabel.AutoSize = True
        AsignarDtoNuevoLabel.Location = New System.Drawing.Point(29, 56)
        AsignarDtoNuevoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AsignarDtoNuevoLabel.Name = "AsignarDtoNuevoLabel"
        AsignarDtoNuevoLabel.Size = New System.Drawing.Size(131, 17)
        AsignarDtoNuevoLabel.TabIndex = 9
        AsignarDtoNuevoLabel.Text = "Asignar Dto Nuevo:"
        '
        'AsignarDtoNuevoCheckBox
        '
        Me.AsignarDtoNuevoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarDtoNuevo", True))
        Me.AsignarDtoNuevoCheckBox.Location = New System.Drawing.Point(170, 50)
        Me.AsignarDtoNuevoCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarDtoNuevoCheckBox.Name = "AsignarDtoNuevoCheckBox"
        Me.AsignarDtoNuevoCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.AsignarDtoNuevoCheckBox.TabIndex = 11
        Me.AsignarDtoNuevoCheckBox.Text = "Sin asignar"
        Me.AsignarDtoNuevoCheckBox.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(404, 386)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(33, 386)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Descuentos_de_la_cuotaDataGridView
        '
        Me.Descuentos_de_la_cuotaDataGridView.AllowUserToAddRows = False
        Me.Descuentos_de_la_cuotaDataGridView.AllowUserToDeleteRows = False
        Me.Descuentos_de_la_cuotaDataGridView.AllowUserToOrderColumns = True
        Me.Descuentos_de_la_cuotaDataGridView.AutoGenerateColumns = False
        Me.Descuentos_de_la_cuotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Descuentos_de_la_cuotaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDESCUENTODataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn, Me.DESCUENTODataGridViewTextBoxColumn})
        Me.Descuentos_de_la_cuotaDataGridView.DataSource = Me.DescuentosDeLaCuotaBindingSource
        Me.Descuentos_de_la_cuotaDataGridView.Location = New System.Drawing.Point(33, 95)
        Me.Descuentos_de_la_cuotaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Descuentos_de_la_cuotaDataGridView.Name = "Descuentos_de_la_cuotaDataGridView"
        Me.Descuentos_de_la_cuotaDataGridView.ReadOnly = True
        Me.Descuentos_de_la_cuotaDataGridView.RowHeadersWidth = 51
        Me.Descuentos_de_la_cuotaDataGridView.Size = New System.Drawing.Size(528, 255)
        Me.Descuentos_de_la_cuotaDataGridView.TabIndex = 7
        '
        'IdDESCUENTODataGridViewTextBoxColumn
        '
        Me.IdDESCUENTODataGridViewTextBoxColumn.DataPropertyName = "Id_DESCUENTO"
        Me.IdDESCUENTODataGridViewTextBoxColumn.HeaderText = "Id_DESCUENTO"
        Me.IdDESCUENTODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDESCUENTODataGridViewTextBoxColumn.Name = "IdDESCUENTODataGridViewTextBoxColumn"
        Me.IdDESCUENTODataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDESCUENTODataGridViewTextBoxColumn.Width = 125
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Width = 125
        '
        'DESCUENTODataGridViewTextBoxColumn
        '
        Me.DESCUENTODataGridViewTextBoxColumn.DataPropertyName = "DESCUENTO"
        Me.DESCUENTODataGridViewTextBoxColumn.HeaderText = "DESCUENTO"
        Me.DESCUENTODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESCUENTODataGridViewTextBoxColumn.Name = "DESCUENTODataGridViewTextBoxColumn"
        Me.DESCUENTODataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCUENTODataGridViewTextBoxColumn.Width = 125
        '
        'DescuentosDeLaCuotaBindingSource
        '
        Me.DescuentosDeLaCuotaBindingSource.DataMember = "descuentos de la cuota"
        Me.DescuentosDeLaCuotaBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ajuste Descuentos de la Cuota"
        '
        'Descuentos_de_la_cuotaTableAdapter
        '
        Me.Descuentos_de_la_cuotaTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Me.Descuentos_de_la_cuotaTableAdapter
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
        'FrmDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(597, 454)
        Me.Controls.Add(AsignarDtoNuevoLabel)
        Me.Controls.Add(Me.AsignarDtoNuevoCheckBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Descuentos_de_la_cuotaDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "43")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDescuentos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descuentos de la cuota"
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Descuentos_de_la_cuotaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDeLaCuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AsignarDtoNuevoCheckBox As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Descuentos_de_la_cuotaDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents DescuentosDeLaCuotaBindingSource As BindingSource
    Friend WithEvents Descuentos_de_la_cuotaTableAdapter As DbCensosTableAdapters.descuentos_de_la_cuotaTableAdapter
    Friend WithEvents IdDESCUENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCUENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
