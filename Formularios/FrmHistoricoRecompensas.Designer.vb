<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoricoRecompensas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEjercicio = New System.Windows.Forms.TextBox()
        Me.DgvHistoricoRec = New System.Windows.Forms.DataGridView()
        Me.ANOCEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRecJCF = New System.Windows.Forms.TextBox()
        Me.TxtRecFalla = New System.Windows.Forms.TextBox()
        Me.CODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESRECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECAGRUPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CensoHistoricoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.CensoHistoricoTableAdapter = New AppGestion.DataSet1TableAdapters.CensoHistoricoTableAdapter()
        Me.HistorfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorfaTableAdapter = New AppGestion.DataSet1TableAdapters.historfaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DgvHistoricoRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CensoHistoricoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Histórico recompensas ejercicio"
        '
        'TxtEjercicio
        '
        Me.TxtEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEjercicio.Location = New System.Drawing.Point(374, 17)
        Me.TxtEjercicio.Name = "TxtEjercicio"
        Me.TxtEjercicio.Size = New System.Drawing.Size(100, 27)
        Me.TxtEjercicio.TabIndex = 1
        '
        'DgvHistoricoRec
        '
        Me.DgvHistoricoRec.AllowUserToAddRows = False
        Me.DgvHistoricoRec.AllowUserToDeleteRows = False
        Me.DgvHistoricoRec.AllowUserToOrderColumns = True
        Me.DgvHistoricoRec.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvHistoricoRec.AutoGenerateColumns = False
        Me.DgvHistoricoRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHistoricoRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ANOCEN, Me.CODIGODataGridViewTextBoxColumn, Me.CODFALLADataGridViewTextBoxColumn, Me.TIPFALDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.DESCRIPDataGridViewTextBoxColumn, Me.DESRECDataGridViewTextBoxColumn, Me.RECFALDataGridViewTextBoxColumn, Me.RECAGRUPDataGridViewTextBoxColumn})
        Me.DgvHistoricoRec.DataSource = Me.CensoHistoricoBindingSource
        Me.DgvHistoricoRec.Location = New System.Drawing.Point(17, 69)
        Me.DgvHistoricoRec.Name = "DgvHistoricoRec"
        Me.DgvHistoricoRec.ReadOnly = True
        Me.DgvHistoricoRec.RowHeadersWidth = 51
        Me.DgvHistoricoRec.RowTemplate.Height = 24
        Me.DgvHistoricoRec.Size = New System.Drawing.Size(1363, 377)
        Me.DgvHistoricoRec.TabIndex = 2
        '
        'ANOCEN
        '
        Me.ANOCEN.DataPropertyName = "ANOCEN"
        Me.ANOCEN.HeaderText = "Año"
        Me.ANOCEN.MinimumWidth = 6
        Me.ANOCEN.Name = "ANOCEN"
        Me.ANOCEN.ReadOnly = True
        Me.ANOCEN.Width = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(695, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nº Recompensas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(835, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Falla:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(835, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "JCF:"
        '
        'TxtRecJCF
        '
        Me.TxtRecJCF.Location = New System.Drawing.Point(878, 12)
        Me.TxtRecJCF.Name = "TxtRecJCF"
        Me.TxtRecJCF.Size = New System.Drawing.Size(100, 22)
        Me.TxtRecJCF.TabIndex = 8
        '
        'TxtRecFalla
        '
        Me.TxtRecFalla.Location = New System.Drawing.Point(878, 41)
        Me.TxtRecFalla.Name = "TxtRecFalla"
        Me.TxtRecFalla.Size = New System.Drawing.Size(100, 22)
        Me.TxtRecFalla.TabIndex = 9
        '
        'CODIGODataGridViewTextBoxColumn
        '
        Me.CODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.HeaderText = "Cód. JCF"
        Me.CODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODIGODataGridViewTextBoxColumn.Name = "CODIGODataGridViewTextBoxColumn"
        Me.CODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGODataGridViewTextBoxColumn.Width = 70
        '
        'CODFALLADataGridViewTextBoxColumn
        '
        Me.CODFALLADataGridViewTextBoxColumn.DataPropertyName = "COD_FALLA"
        Me.CODFALLADataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CODFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODFALLADataGridViewTextBoxColumn.Name = "CODFALLADataGridViewTextBoxColumn"
        Me.CODFALLADataGridViewTextBoxColumn.ReadOnly = True
        Me.CODFALLADataGridViewTextBoxColumn.Width = 60
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
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 90
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 150
        '
        'DESCRIPDataGridViewTextBoxColumn
        '
        Me.DESCRIPDataGridViewTextBoxColumn.DataPropertyName = "DESCRIP"
        Me.DESCRIPDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.DESCRIPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESCRIPDataGridViewTextBoxColumn.Name = "DESCRIPDataGridViewTextBoxColumn"
        Me.DESCRIPDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPDataGridViewTextBoxColumn.Width = 125
        '
        'DESRECDataGridViewTextBoxColumn
        '
        Me.DESRECDataGridViewTextBoxColumn.DataPropertyName = "DESREC"
        Me.DESRECDataGridViewTextBoxColumn.HeaderText = "Rec. JCF"
        Me.DESRECDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESRECDataGridViewTextBoxColumn.Name = "DESRECDataGridViewTextBoxColumn"
        Me.DESRECDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESRECDataGridViewTextBoxColumn.Width = 125
        '
        'RECFALDataGridViewTextBoxColumn
        '
        Me.RECFALDataGridViewTextBoxColumn.DataPropertyName = "REC_FAL"
        Me.RECFALDataGridViewTextBoxColumn.HeaderText = "Rec. Falla"
        Me.RECFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECFALDataGridViewTextBoxColumn.Name = "RECFALDataGridViewTextBoxColumn"
        Me.RECFALDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECFALDataGridViewTextBoxColumn.Width = 50
        '
        'RECAGRUPDataGridViewTextBoxColumn
        '
        Me.RECAGRUPDataGridViewTextBoxColumn.DataPropertyName = "REC_AGRUP"
        Me.RECAGRUPDataGridViewTextBoxColumn.HeaderText = "Rec. Agrup"
        Me.RECAGRUPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECAGRUPDataGridViewTextBoxColumn.Name = "RECAGRUPDataGridViewTextBoxColumn"
        Me.RECAGRUPDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECAGRUPDataGridViewTextBoxColumn.Width = 50
        '
        'CensoHistoricoBindingSource
        '
        Me.CensoHistoricoBindingSource.DataMember = "CensoHistorico"
        Me.CensoHistoricoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CensoHistoricoTableAdapter
        '
        Me.CensoHistoricoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.historfaTableAdapter = Me.HistorfaTableAdapter
        Me.TableAdapterManager.recompensasejercicioTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1266, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVer.Location = New System.Drawing.Point(513, 15)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(118, 33)
        Me.btnVer.TabIndex = 3
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.report
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1044, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Ver listado"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmHistoricoRecompensas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 458)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtRecFalla)
        Me.Controls.Add(Me.TxtRecJCF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.DgvHistoricoRec)
        Me.Controls.Add(Me.TxtEjercicio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmHistoricoRecompensas"
        Me.Text = "FrmRecompensasEjercicio"
        CType(Me.DgvHistoricoRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CensoHistoricoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEjercicio As TextBox
    Friend WithEvents DgvHistoricoRec As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CensoHistoricoBindingSource As BindingSource
    Friend WithEvents CensoHistoricoTableAdapter As DataSet1TableAdapters.CensoHistoricoTableAdapter
    Friend WithEvents btnVer As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ANOCEN As DataGridViewTextBoxColumn
    Friend WithEvents CODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESRECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECAGRUPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRecJCF As TextBox
    Friend WithEvents TxtRecFalla As TextBox
    Friend WithEvents HistorfaBindingSource As BindingSource
    Friend WithEvents HistorfaTableAdapter As DataSet1TableAdapters.historfaTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
End Class
