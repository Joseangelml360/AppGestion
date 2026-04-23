<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrillantesFalla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrillantesFalla))
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvBuscarFallero = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNSerie = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrillantesfallaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFallero = New AppGestion.DataSetFallero()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FalleroComisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrillantesfallaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrillantesfallaTableAdapter = New AppGestion.DataSetFalleroTableAdapters.brillantesfallaTableAdapter()
        Me.FalleroComisionTableAdapter = New AppGestion.DataSetFalleroTableAdapters.FalleroComisionTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblSelect = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvBuscarFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrillantesfallaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrillantesfallaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(45, 88)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(176, 22)
        Me.TxtId.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtNSerie)
        Me.Panel1.Controls.Add(Me.TxtApellidos)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtId)
        Me.Panel1.Location = New System.Drawing.Point(552, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 344)
        Me.Panel1.TabIndex = 1
        '
        'DgvBuscarFallero
        '
        Me.DgvBuscarFallero.AllowUserToAddRows = False
        Me.DgvBuscarFallero.AllowUserToDeleteRows = False
        Me.DgvBuscarFallero.AutoGenerateColumns = False
        Me.DgvBuscarFallero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBuscarFallero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBuscarFallero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn1, Me.NOMBREDataGridViewTextBoxColumn1})
        Me.DgvBuscarFallero.DataSource = Me.FalleroComisionBindingSource
        Me.DgvBuscarFallero.Location = New System.Drawing.Point(58, 160)
        Me.DgvBuscarFallero.Name = "DgvBuscarFallero"
        Me.DgvBuscarFallero.ReadOnly = True
        Me.DgvBuscarFallero.RowHeadersWidth = 51
        Me.DgvBuscarFallero.RowTemplate.Height = 24
        Me.DgvBuscarFallero.Size = New System.Drawing.Size(273, 42)
        Me.DgvBuscarFallero.TabIndex = 4
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AppGestion.My.Resources.Resources.luzverde
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(138, 306)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(94, 30)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(13, 306)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 30)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(132, 143)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(199, 22)
        Me.TxtBuscar.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Código:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(80, 116)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(141, 22)
        Me.TxtCodigo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nº Serie:"
        '
        'TxtNSerie
        '
        Me.TxtNSerie.Location = New System.Drawing.Point(86, 200)
        Me.TxtNSerie.Name = "TxtNSerie"
        Me.TxtNSerie.Size = New System.Drawing.Size(135, 22)
        Me.TxtNSerie.TabIndex = 4
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Enabled = False
        Me.TxtApellidos.Location = New System.Drawing.Point(19, 172)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(202, 22)
        Me.TxtApellidos.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(19, 144)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(202, 22)
        Me.TxtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.NumeroSerieDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BrillantesfallaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(13, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(533, 344)
        Me.DataGridView1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(553, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Registro de falleros con Bunyol D'Or i Brillants de la falla"
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.AppGestion.My.Resources.Resources.Modificar
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(126, 55)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 30)
        Me.BtnEditar.TabIndex = 5
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.AppGestion.My.Resources.Resources.Añadir
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(13, 55)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(90, 30)
        Me.BtnAñadir.TabIndex = 4
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(706, 28)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 30)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BrillantesfallaBindingSource1
        '
        Me.BrillantesfallaBindingSource1.DataMember = "brillantesfalla"
        Me.BrillantesfallaBindingSource1.DataSource = Me.DataSetFallero
        '
        'DataSetFallero
        '
        Me.DataSetFallero.DataSetName = "DataSetFallero"
        Me.DataSetFallero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'APELLIDOSDataGridViewTextBoxColumn1
        '
        Me.APELLIDOSDataGridViewTextBoxColumn1.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn1.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn1.MinimumWidth = 125
        Me.APELLIDOSDataGridViewTextBoxColumn1.Name = "APELLIDOSDataGridViewTextBoxColumn1"
        Me.APELLIDOSDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn1
        '
        Me.NOMBREDataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn1.Name = "NOMBREDataGridViewTextBoxColumn1"
        Me.NOMBREDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FalleroComisionBindingSource
        '
        Me.FalleroComisionBindingSource.DataMember = "FalleroComision"
        Me.FalleroComisionBindingSource.DataSource = Me.DataSetFallero
        '
        'BrillantesfallaBindingSource
        '
        Me.BrillantesfallaBindingSource.DataMember = "brillantesfalla"
        Me.BrillantesfallaBindingSource.DataSource = Me.DataSetFallero
        '
        'BrillantesfallaTableAdapter
        '
        Me.BrillantesfallaTableAdapter.ClearBeforeFill = True
        '
        'FalleroComisionTableAdapter
        '
        Me.FalleroComisionTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroSerieDataGridViewTextBoxColumn
        '
        Me.NumeroSerieDataGridViewTextBoxColumn.DataPropertyName = "NumeroSerie"
        Me.NumeroSerieDataGridViewTextBoxColumn.HeaderText = "Nº Serie"
        Me.NumeroSerieDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroSerieDataGridViewTextBoxColumn.Name = "NumeroSerieDataGridViewTextBoxColumn"
        Me.NumeroSerieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LblSelect
        '
        Me.LblSelect.AutoSize = True
        Me.LblSelect.Location = New System.Drawing.Point(137, 120)
        Me.LblSelect.Name = "LblSelect"
        Me.LblSelect.Size = New System.Drawing.Size(144, 17)
        Me.LblSelect.TabIndex = 9
        Me.LblSelect.Text = "Selecciona un fallero:"
        Me.LblSelect.Visible = False
        '
        'FrmBrillantesFalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblSelect)
        Me.Controls.Add(Me.DgvBuscarFallero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBrillantesFalla"
        Me.Text = "Registro de Brillantes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvBuscarFallero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrillantesfallaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroComisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrillantesfallaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNSerie As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSetFallero As DataSetFallero
    Friend WithEvents BrillantesfallaBindingSource As BindingSource
    Friend WithEvents BrillantesfallaTableAdapter As DataSetFalleroTableAdapters.brillantesfallaTableAdapter
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents DgvBuscarFallero As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BrillantesfallaBindingSource1 As BindingSource
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents FalleroComisionBindingSource As BindingSource
    Friend WithEvents FalleroComisionTableAdapter As DataSetFalleroTableAdapters.FalleroComisionTableAdapter
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LblSelect As Label
End Class
