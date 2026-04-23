<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarArchivoQ19
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
        Me.DbCensos = New AppGestion.DbCensos()
        Me.AdeudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdeudosTableAdapter = New AppGestion.DbCensosTableAdapters.adeudosTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.AdeudosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdeudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdeudosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdeudosBindingSource
        '
        Me.AdeudosBindingSource.DataMember = "adeudos"
        Me.AdeudosBindingSource.DataSource = Me.DbCensos
        '
        'AdeudosTableAdapter
        '
        Me.AdeudosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adeudosTableAdapter = Me.AdeudosTableAdapter
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
        'AdeudosDataGridView
        '
        Me.AdeudosDataGridView.AllowUserToAddRows = False
        Me.AdeudosDataGridView.AllowUserToDeleteRows = False
        Me.AdeudosDataGridView.AutoGenerateColumns = False
        Me.AdeudosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdeudosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.AdeudosDataGridView.DataSource = Me.AdeudosBindingSource
        Me.AdeudosDataGridView.Location = New System.Drawing.Point(12, 91)
        Me.AdeudosDataGridView.Name = "AdeudosDataGridView"
        Me.AdeudosDataGridView.ReadOnly = True
        Me.AdeudosDataGridView.RowHeadersWidth = 51
        Me.AdeudosDataGridView.RowTemplate.Height = 24
        Me.AdeudosDataGridView.Size = New System.Drawing.Size(1191, 220)
        Me.AdeudosDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(545, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Generar de nuevo archivo de adeudos .q19 para enviar al banco"
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.folder_page
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1085, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha de cargo (último creado):"
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(229, 63)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 22)
        Me.TxtFecha.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "linea"
        Me.DataGridViewTextBoxColumn1.HeaderText = "linea"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 1100
        '
        'FrmGenerarArchivoQ19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 379)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AdeudosDataGridView)
        Me.Name = "FrmGenerarArchivoQ19"
        Me.Text = "Generar Archivo q19"
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdeudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdeudosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents AdeudosBindingSource As BindingSource
    Friend WithEvents AdeudosTableAdapter As DbCensosTableAdapters.adeudosTableAdapter
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents AdeudosDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
