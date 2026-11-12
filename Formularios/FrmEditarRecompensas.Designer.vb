<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditarRecompensas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarRecompensas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EJERCICIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECJFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECAGRUPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULTRECJCFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULTRECFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEJEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEJEFALLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecompensasejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTodas = New System.Windows.Forms.Button()
        Me.BtnDeFalla = New System.Windows.Forms.Button()
        Me.BtnDeJCF = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.RecompensasejercicioTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasejercicioTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EJERCICIODataGridViewTextBoxColumn, Me.CODFALLADataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.TIPFALDataGridViewTextBoxColumn, Me.CARGODataGridViewTextBoxColumn, Me.RECJFDataGridViewTextBoxColumn, Me.RECFALLADataGridViewTextBoxColumn, Me.RECAGRUPDataGridViewTextBoxColumn, Me.ULTRECJCFDataGridViewTextBoxColumn, Me.ULTRECFALLADataGridViewTextBoxColumn, Me.NUMEJEDataGridViewTextBoxColumn, Me.NUMEJEFALLADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RecompensasejercicioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1462, 447)
        Me.DataGridView1.TabIndex = 0
        '
        'EJERCICIODataGridViewTextBoxColumn
        '
        Me.EJERCICIODataGridViewTextBoxColumn.DataPropertyName = "EJERCICIO"
        Me.EJERCICIODataGridViewTextBoxColumn.HeaderText = "Ejercicio"
        Me.EJERCICIODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EJERCICIODataGridViewTextBoxColumn.Name = "EJERCICIODataGridViewTextBoxColumn"
        Me.EJERCICIODataGridViewTextBoxColumn.Width = 60
        '
        'CODFALLADataGridViewTextBoxColumn
        '
        Me.CODFALLADataGridViewTextBoxColumn.DataPropertyName = "CODFALLA"
        Me.CODFALLADataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CODFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODFALLADataGridViewTextBoxColumn.Name = "CODFALLADataGridViewTextBoxColumn"
        Me.CODFALLADataGridViewTextBoxColumn.Width = 60
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.Width = 125
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 150
        '
        'TIPFALDataGridViewTextBoxColumn
        '
        Me.TIPFALDataGridViewTextBoxColumn.DataPropertyName = "TIPFAL"
        Me.TIPFALDataGridViewTextBoxColumn.HeaderText = "Comisión"
        Me.TIPFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPFALDataGridViewTextBoxColumn.Name = "TIPFALDataGridViewTextBoxColumn"
        Me.TIPFALDataGridViewTextBoxColumn.Width = 70
        '
        'CARGODataGridViewTextBoxColumn
        '
        Me.CARGODataGridViewTextBoxColumn.DataPropertyName = "CARGO"
        Me.CARGODataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.CARGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CARGODataGridViewTextBoxColumn.Name = "CARGODataGridViewTextBoxColumn"
        Me.CARGODataGridViewTextBoxColumn.Width = 60
        '
        'RECJFDataGridViewTextBoxColumn
        '
        Me.RECJFDataGridViewTextBoxColumn.DataPropertyName = "RECJF"
        Me.RECJFDataGridViewTextBoxColumn.HeaderText = "Rec.JCF"
        Me.RECJFDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECJFDataGridViewTextBoxColumn.Name = "RECJFDataGridViewTextBoxColumn"
        Me.RECJFDataGridViewTextBoxColumn.Width = 60
        '
        'RECFALLADataGridViewTextBoxColumn
        '
        Me.RECFALLADataGridViewTextBoxColumn.DataPropertyName = "RECFALLA"
        Me.RECFALLADataGridViewTextBoxColumn.HeaderText = "Rec.Falla"
        Me.RECFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECFALLADataGridViewTextBoxColumn.Name = "RECFALLADataGridViewTextBoxColumn"
        Me.RECFALLADataGridViewTextBoxColumn.Width = 65
        '
        'RECAGRUPDataGridViewTextBoxColumn
        '
        Me.RECAGRUPDataGridViewTextBoxColumn.DataPropertyName = "RECAGRUP"
        Me.RECAGRUPDataGridViewTextBoxColumn.HeaderText = "Rec.Agrup"
        Me.RECAGRUPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECAGRUPDataGridViewTextBoxColumn.Name = "RECAGRUPDataGridViewTextBoxColumn"
        Me.RECAGRUPDataGridViewTextBoxColumn.Width = 70
        '
        'ULTRECJCFDataGridViewTextBoxColumn
        '
        Me.ULTRECJCFDataGridViewTextBoxColumn.DataPropertyName = "ULTRECJCF"
        Me.ULTRECJCFDataGridViewTextBoxColumn.HeaderText = "Ult.JCF"
        Me.ULTRECJCFDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ULTRECJCFDataGridViewTextBoxColumn.Name = "ULTRECJCFDataGridViewTextBoxColumn"
        Me.ULTRECJCFDataGridViewTextBoxColumn.Width = 60
        '
        'ULTRECFALLADataGridViewTextBoxColumn
        '
        Me.ULTRECFALLADataGridViewTextBoxColumn.DataPropertyName = "ULTRECFALLA"
        Me.ULTRECFALLADataGridViewTextBoxColumn.HeaderText = "Ult.Falla"
        Me.ULTRECFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ULTRECFALLADataGridViewTextBoxColumn.Name = "ULTRECFALLADataGridViewTextBoxColumn"
        Me.ULTRECFALLADataGridViewTextBoxColumn.Width = 60
        '
        'NUMEJEDataGridViewTextBoxColumn
        '
        Me.NUMEJEDataGridViewTextBoxColumn.DataPropertyName = "NUMEJE"
        Me.NUMEJEDataGridViewTextBoxColumn.HeaderText = "NºEjeJCF"
        Me.NUMEJEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEJEDataGridViewTextBoxColumn.Name = "NUMEJEDataGridViewTextBoxColumn"
        Me.NUMEJEDataGridViewTextBoxColumn.Width = 65
        '
        'NUMEJEFALLADataGridViewTextBoxColumn
        '
        Me.NUMEJEFALLADataGridViewTextBoxColumn.DataPropertyName = "NUMEJEFALLA"
        Me.NUMEJEFALLADataGridViewTextBoxColumn.HeaderText = "NºEjeFalla"
        Me.NUMEJEFALLADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEJEFALLADataGridViewTextBoxColumn.Name = "NUMEJEFALLADataGridViewTextBoxColumn"
        Me.NUMEJEFALLADataGridViewTextBoxColumn.Width = 70
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Recompensas ejercicio"
        '
        'BtnTodas
        '
        Me.BtnTodas.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTodas.Location = New System.Drawing.Point(744, 55)
        Me.BtnTodas.Name = "BtnTodas"
        Me.BtnTodas.Size = New System.Drawing.Size(95, 29)
        Me.BtnTodas.TabIndex = 9
        Me.BtnTodas.Text = "Todas"
        Me.BtnTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTodas.UseVisualStyleBackColor = True
        '
        'BtnDeFalla
        '
        Me.BtnDeFalla.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnDeFalla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeFalla.Location = New System.Drawing.Point(625, 55)
        Me.BtnDeFalla.Name = "BtnDeFalla"
        Me.BtnDeFalla.Size = New System.Drawing.Size(95, 29)
        Me.BtnDeFalla.TabIndex = 8
        Me.BtnDeFalla.Text = "De Falla"
        Me.BtnDeFalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeFalla.UseVisualStyleBackColor = True
        '
        'BtnDeJCF
        '
        Me.BtnDeJCF.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnDeJCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeJCF.Location = New System.Drawing.Point(502, 55)
        Me.BtnDeJCF.Name = "BtnDeJCF"
        Me.BtnDeJCF.Size = New System.Drawing.Size(95, 29)
        Me.BtnDeJCF.TabIndex = 7
        Me.BtnDeJCF.Text = "De JCF"
        Me.BtnDeJCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeJCF.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1109, 55)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(95, 29)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.AppGestion.My.Resources.Resources.page_edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(140, 55)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(95, 29)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.table_row_delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(269, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Eliminar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(15, 55)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(95, 29)
        Me.BtnAñadir.TabIndex = 1
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'RecompensasejercicioTableAdapter
        '
        Me.RecompensasejercicioTableAdapter.ClearBeforeFill = True
        '
        'FrmEditarRecompensas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1486, 566)
        Me.Controls.Add(Me.BtnTodas)
        Me.Controls.Add(Me.BtnDeFalla)
        Me.Controls.Add(Me.BtnDeJCF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditarRecompensas"
        Me.Text = "Editar Recompensas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents RecompensasejercicioBindingSource As BindingSource
    Friend WithEvents RecompensasejercicioTableAdapter As DataSet1TableAdapters.recompensasejercicioTableAdapter
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDeJCF As Button
    Friend WithEvents BtnDeFalla As Button
    Friend WithEvents BtnTodas As Button
    Friend WithEvents EJERCICIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CARGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECJFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECAGRUPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ULTRECJCFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ULTRECFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEJEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEJEFALLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
