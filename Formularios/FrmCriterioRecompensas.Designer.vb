<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCriterioRecompensas
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
        Dim CODRECLabel As System.Windows.Forms.Label
        Dim NUMEJEFALLEROLabel As System.Windows.Forms.Label
        Dim NUMEJECARGOLabel As System.Windows.Forms.Label
        Dim MINEJECARGOLabel As System.Windows.Forms.Label
        Dim RECOMFALLALabel As System.Windows.Forms.Label
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.CriteriorecompDataGridView = New System.Windows.Forms.DataGridView()
        Me.CriteriorecompBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.CODRECTextBox = New System.Windows.Forms.TextBox()
        Me.NUMEJEFALLEROTextBox = New System.Windows.Forms.TextBox()
        Me.NUMEJECARGOTextBox = New System.Windows.Forms.TextBox()
        Me.MINEJECARGOTextBox = New System.Windows.Forms.TextBox()
        Me.RECOMFALLATextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriteriorecomprecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CriteriorecompTableAdapter = New AppGestion.DataSet1TableAdapters.criteriorecompTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.RecompensasTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasTableAdapter()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.CODRECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEJEFALLERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEJECARGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MINEJECARGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECOMFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CODRECLabel = New System.Windows.Forms.Label()
        NUMEJEFALLEROLabel = New System.Windows.Forms.Label()
        NUMEJECARGOLabel = New System.Windows.Forms.Label()
        MINEJECARGOLabel = New System.Windows.Forms.Label()
        RECOMFALLALabel = New System.Windows.Forms.Label()
        CType(Me.CriteriorecompDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriorecompBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriorecomprecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODRECLabel
        '
        CODRECLabel.AutoSize = True
        CODRECLabel.Location = New System.Drawing.Point(107, 52)
        CODRECLabel.Name = "CODRECLabel"
        CODRECLabel.Size = New System.Drawing.Size(91, 17)
        CODRECLabel.TabIndex = 17
        CODRECLabel.Text = "Recompensa"
        '
        'NUMEJEFALLEROLabel
        '
        NUMEJEFALLEROLabel.AutoSize = True
        NUMEJEFALLEROLabel.Location = New System.Drawing.Point(64, 80)
        NUMEJEFALLEROLabel.Name = "NUMEJEFALLEROLabel"
        NUMEJEFALLEROLabel.Size = New System.Drawing.Size(134, 17)
        NUMEJEFALLEROLabel.TabIndex = 19
        NUMEJEFALLEROLabel.Text = "Nº ejercicios en JCF"
        '
        'NUMEJECARGOLabel
        '
        NUMEJECARGOLabel.AutoSize = True
        NUMEJECARGOLabel.Location = New System.Drawing.Point(63, 108)
        NUMEJECARGOLabel.Name = "NUMEJECARGOLabel"
        NUMEJECARGOLabel.Size = New System.Drawing.Size(135, 17)
        NUMEJECARGOLabel.TabIndex = 21
        NUMEJECARGOLabel.Text = "Ejercicios con cargo"
        '
        'MINEJECARGOLabel
        '
        MINEJECARGOLabel.AutoSize = True
        MINEJECARGOLabel.Location = New System.Drawing.Point(15, 136)
        MINEJECARGOLabel.Name = "MINEJECARGOLabel"
        MINEJECARGOLabel.Size = New System.Drawing.Size(183, 17)
        MINEJECARGOLabel.TabIndex = 23
        MINEJECARGOLabel.Text = "Mín. Nº ejercicios con cargo"
        '
        'RECOMFALLALabel
        '
        RECOMFALLALabel.AutoSize = True
        RECOMFALLALabel.Location = New System.Drawing.Point(16, 164)
        RECOMFALLALabel.Name = "RECOMFALLALabel"
        RECOMFALLALabel.Size = New System.Drawing.Size(182, 17)
        RECOMFALLALabel.TabIndex = 25
        RECOMFALLALabel.Text = "Nº ejercicios para Rec Falla"
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.AppGestion.My.Resources.Resources.page_edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(49, 99)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(131, 43)
        Me.BtnEditar.TabIndex = 12
        Me.BtnEditar.Text = "Editar valores"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1101, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 43)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(313, 99)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(143, 43)
        Me.BtnAñadir.TabIndex = 14
        Me.BtnAñadir.Text = "Añadir criterio"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(19, 229)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(149, 43)
        Me.BtnGuardar.TabIndex = 15
        Me.BtnGuardar.Text = "Guardar cambios"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(12, 40)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(417, 25)
        Me.LblTitulo.TabIndex = 16
        Me.LblTitulo.Text = "Criterios para asignación de recompensas"
        '
        'CriteriorecompDataGridView
        '
        Me.CriteriorecompDataGridView.AllowUserToAddRows = False
        Me.CriteriorecompDataGridView.AllowUserToDeleteRows = False
        Me.CriteriorecompDataGridView.AllowUserToOrderColumns = True
        Me.CriteriorecompDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CriteriorecompDataGridView.AutoGenerateColumns = False
        Me.CriteriorecompDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CriteriorecompDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODRECDataGridViewTextBoxColumn, Me.NUMEJEFALLERODataGridViewTextBoxColumn, Me.NUMEJECARGODataGridViewTextBoxColumn, Me.MINEJECARGODataGridViewTextBoxColumn, Me.RECOMFALLADataGridViewTextBoxColumn})
        Me.CriteriorecompDataGridView.DataSource = Me.CriteriorecompBindingSource
        Me.CriteriorecompDataGridView.Location = New System.Drawing.Point(49, 167)
        Me.CriteriorecompDataGridView.Name = "CriteriorecompDataGridView"
        Me.CriteriorecompDataGridView.ReadOnly = True
        Me.CriteriorecompDataGridView.RowHeadersWidth = 51
        Me.CriteriorecompDataGridView.RowTemplate.Height = 24
        Me.CriteriorecompDataGridView.Size = New System.Drawing.Size(684, 341)
        Me.CriteriorecompDataGridView.TabIndex = 17
        '
        'CriteriorecompBindingSource
        '
        Me.CriteriorecompBindingSource.DataMember = "criteriorecomp"
        Me.CriteriorecompBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CODRECTextBox
        '
        Me.CODRECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriorecompBindingSource, "CODREC", True))
        Me.CODRECTextBox.Location = New System.Drawing.Point(204, 49)
        Me.CODRECTextBox.Name = "CODRECTextBox"
        Me.CODRECTextBox.Size = New System.Drawing.Size(53, 22)
        Me.CODRECTextBox.TabIndex = 18
        '
        'NUMEJEFALLEROTextBox
        '
        Me.NUMEJEFALLEROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriorecompBindingSource, "NUMEJEFALLERO", True))
        Me.NUMEJEFALLEROTextBox.Location = New System.Drawing.Point(204, 77)
        Me.NUMEJEFALLEROTextBox.Name = "NUMEJEFALLEROTextBox"
        Me.NUMEJEFALLEROTextBox.Size = New System.Drawing.Size(53, 22)
        Me.NUMEJEFALLEROTextBox.TabIndex = 20
        '
        'NUMEJECARGOTextBox
        '
        Me.NUMEJECARGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriorecompBindingSource, "NUMEJECARGO", True))
        Me.NUMEJECARGOTextBox.Location = New System.Drawing.Point(204, 105)
        Me.NUMEJECARGOTextBox.Name = "NUMEJECARGOTextBox"
        Me.NUMEJECARGOTextBox.Size = New System.Drawing.Size(53, 22)
        Me.NUMEJECARGOTextBox.TabIndex = 22
        '
        'MINEJECARGOTextBox
        '
        Me.MINEJECARGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriorecompBindingSource, "MINEJECARGO", True))
        Me.MINEJECARGOTextBox.Location = New System.Drawing.Point(204, 133)
        Me.MINEJECARGOTextBox.Name = "MINEJECARGOTextBox"
        Me.MINEJECARGOTextBox.Size = New System.Drawing.Size(53, 22)
        Me.MINEJECARGOTextBox.TabIndex = 24
        '
        'RECOMFALLATextBox
        '
        Me.RECOMFALLATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriorecompBindingSource, "RECOMFALLA", True))
        Me.RECOMFALLATextBox.Location = New System.Drawing.Point(204, 161)
        Me.RECOMFALLATextBox.Name = "RECOMFALLATextBox"
        Me.RECOMFALLATextBox.Size = New System.Drawing.Size(53, 22)
        Me.RECOMFALLATextBox.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(CODRECLabel)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.CODRECTextBox)
        Me.GroupBox1.Controls.Add(Me.RECOMFALLATextBox)
        Me.GroupBox1.Controls.Add(NUMEJEFALLEROLabel)
        Me.GroupBox1.Controls.Add(RECOMFALLALabel)
        Me.GroupBox1.Controls.Add(Me.NUMEJEFALLEROTextBox)
        Me.GroupBox1.Controls.Add(Me.MINEJECARGOTextBox)
        Me.GroupBox1.Controls.Add(NUMEJECARGOLabel)
        Me.GroupBox1.Controls.Add(MINEJECARGOLabel)
        Me.GroupBox1.Controls.Add(Me.NUMEJECARGOTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(816, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 302)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RecompensasBindingSource, "DESREC", True))
        Me.ComboBox1.DataSource = Me.CriteriorecomprecompensasBindingSource
        Me.ComboBox1.DisplayMember = "DESREC"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(263, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 29
        Me.ComboBox1.ValueMember = "CODREC"
        '
        'RecompensasBindingSource
        '
        Me.RecompensasBindingSource.DataMember = "recompensas"
        Me.RecompensasBindingSource.DataSource = Me.DataSet1
        '
        'CriteriorecomprecompensasBindingSource
        '
        Me.CriteriorecomprecompensasBindingSource.DataMember = "criteriorecomp_recompensas"
        Me.CriteriorecomprecompensasBindingSource.DataSource = Me.CriteriorecompBindingSource
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(273, 230)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(110, 42)
        Me.BtnCancel.TabIndex = 28
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager.historfaTableAdapter = Nothing
        Me.TableAdapterManager.MensajesTableAdapter = Nothing
        Me.TableAdapterManager.recompensasejercicioTableAdapter = Nothing
        Me.TableAdapterManager.recompensasTableAdapter = Me.RecompensasTableAdapter
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecompensasTableAdapter
        '
        Me.RecompensasTableAdapter.ClearBeforeFill = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.AppGestion.My.Resources.Resources.table_row_delete
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(589, 99)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(143, 43)
        Me.BtnEliminar.TabIndex = 29
        Me.BtnEliminar.Text = "Eliminar registro"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'CODRECDataGridViewTextBoxColumn
        '
        Me.CODRECDataGridViewTextBoxColumn.DataPropertyName = "CODREC"
        Me.CODRECDataGridViewTextBoxColumn.HeaderText = "Código REC"
        Me.CODRECDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODRECDataGridViewTextBoxColumn.Name = "CODRECDataGridViewTextBoxColumn"
        Me.CODRECDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODRECDataGridViewTextBoxColumn.Width = 75
        '
        'NUMEJEFALLERODataGridViewTextBoxColumn
        '
        Me.NUMEJEFALLERODataGridViewTextBoxColumn.DataPropertyName = "NUMEJEFALLERO"
        Me.NUMEJEFALLERODataGridViewTextBoxColumn.HeaderText = "Nº Ejercicios JCF"
        Me.NUMEJEFALLERODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEJEFALLERODataGridViewTextBoxColumn.Name = "NUMEJEFALLERODataGridViewTextBoxColumn"
        Me.NUMEJEFALLERODataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMEJEFALLERODataGridViewTextBoxColumn.Width = 75
        '
        'NUMEJECARGODataGridViewTextBoxColumn
        '
        Me.NUMEJECARGODataGridViewTextBoxColumn.DataPropertyName = "NUMEJECARGO"
        Me.NUMEJECARGODataGridViewTextBoxColumn.HeaderText = "Nº Ejercicios con cargo"
        Me.NUMEJECARGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEJECARGODataGridViewTextBoxColumn.Name = "NUMEJECARGODataGridViewTextBoxColumn"
        Me.NUMEJECARGODataGridViewTextBoxColumn.ReadOnly = True
        '
        'MINEJECARGODataGridViewTextBoxColumn
        '
        Me.MINEJECARGODataGridViewTextBoxColumn.DataPropertyName = "MINEJECARGO"
        Me.MINEJECARGODataGridViewTextBoxColumn.HeaderText = "Nº ejercicios mínimo con cargo"
        Me.MINEJECARGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MINEJECARGODataGridViewTextBoxColumn.Name = "MINEJECARGODataGridViewTextBoxColumn"
        Me.MINEJECARGODataGridViewTextBoxColumn.ReadOnly = True
        '
        'RECOMFALLADataGridViewTextBoxColumn
        '
        Me.RECOMFALLADataGridViewTextBoxColumn.DataPropertyName = "RECOMFALLA"
        Me.RECOMFALLADataGridViewTextBoxColumn.HeaderText = "Nº ejercicio para REC falla"
        Me.RECOMFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECOMFALLADataGridViewTextBoxColumn.Name = "RECOMFALLADataGridViewTextBoxColumn"
        Me.RECOMFALLADataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmCriterioRecompensas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 520)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.CriteriorecompDataGridView)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCriterioRecompensas"
        Me.Text = "Criterio Recompensas"
        CType(Me.CriteriorecompDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriorecompBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriorecomprecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblTitulo As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CriteriorecompBindingSource As BindingSource
    Friend WithEvents CriteriorecompTableAdapter As DataSet1TableAdapters.criteriorecompTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CriteriorecompDataGridView As DataGridView
    Friend WithEvents CODRECTextBox As TextBox
    Friend WithEvents NUMEJEFALLEROTextBox As TextBox
    Friend WithEvents NUMEJECARGOTextBox As TextBox
    Friend WithEvents MINEJECARGOTextBox As TextBox
    Friend WithEvents RECOMFALLATextBox As TextBox
    Friend WithEvents RecompensasTableAdapter As DataSet1TableAdapters.recompensasTableAdapter
    Friend WithEvents RecompensasBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CriteriorecomprecompensasBindingSource As BindingSource
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents CODRECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEJEFALLERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEJECARGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MINEJECARGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECOMFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
