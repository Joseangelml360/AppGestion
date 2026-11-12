<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAplicarDevoluciones
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvFallero = New System.Windows.Forms.DataGridView()
        Me.CodFalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtroCgo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DevBenef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReciboDev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntAcuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fallero1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.DgvTitular = New System.Windows.Forms.DataGridView()
        Me.IdRemesaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New AppGestion.ReportsDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAplicar = New System.Windows.Forms.Button()
        Me.DgvDevolucion = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecDev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Benef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.devolucion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bloqueado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Remesas1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtTitular = New System.Windows.Forms.TextBox()
        Me.CboSelect = New System.Windows.Forms.ComboBox()
        Me.Fallero1TableAdapter = New AppGestion.DataSet1TableAdapters.Fallero1TableAdapter()
        Me.RemesasTableAdapter = New AppGestion.ReportsDataSetTableAdapters.remesasTableAdapter()
        Me.Remesas1TableAdapter = New AppGestion.ReportsDataSetTableAdapters.remesas1TableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTitular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remesas1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(795, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Titular:"
        '
        'DgvFallero
        '
        Me.DgvFallero.AllowUserToAddRows = False
        Me.DgvFallero.AllowUserToDeleteRows = False
        Me.DgvFallero.AutoGenerateColumns = False
        Me.DgvFallero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFallero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodFalle, Me.PAGO, Me.NumPagos, Me.OtroCgo, Me.DevBenef, Me.ReciboDev, Me.EntAcuenta, Me.Deuda})
        Me.DgvFallero.DataSource = Me.Fallero1BindingSource
        Me.DgvFallero.Location = New System.Drawing.Point(453, 297)
        Me.DgvFallero.Name = "DgvFallero"
        Me.DgvFallero.ReadOnly = True
        Me.DgvFallero.RowHeadersWidth = 51
        Me.DgvFallero.RowTemplate.Height = 24
        Me.DgvFallero.Size = New System.Drawing.Size(300, 62)
        Me.DgvFallero.TabIndex = 17
        Me.DgvFallero.Visible = False
        '
        'CodFalle
        '
        Me.CodFalle.DataPropertyName = "FALLERO_CODIGO"
        Me.CodFalle.HeaderText = "FALLERO_CODIGO"
        Me.CodFalle.MinimumWidth = 6
        Me.CodFalle.Name = "CodFalle"
        Me.CodFalle.ReadOnly = True
        Me.CodFalle.Width = 125
        '
        'PAGO
        '
        Me.PAGO.DataPropertyName = "PAGO"
        Me.PAGO.HeaderText = "PAGO"
        Me.PAGO.MinimumWidth = 6
        Me.PAGO.Name = "PAGO"
        Me.PAGO.ReadOnly = True
        Me.PAGO.Width = 125
        '
        'NumPagos
        '
        Me.NumPagos.DataPropertyName = "NUM_PAGOS"
        Me.NumPagos.HeaderText = "NUM_PAGOS"
        Me.NumPagos.MinimumWidth = 6
        Me.NumPagos.Name = "NumPagos"
        Me.NumPagos.ReadOnly = True
        Me.NumPagos.Width = 125
        '
        'OtroCgo
        '
        Me.OtroCgo.DataPropertyName = "OtrosCargos"
        Me.OtroCgo.HeaderText = "OtrosCargos"
        Me.OtroCgo.MinimumWidth = 6
        Me.OtroCgo.Name = "OtroCgo"
        Me.OtroCgo.ReadOnly = True
        Me.OtroCgo.Width = 125
        '
        'DevBenef
        '
        Me.DevBenef.DataPropertyName = "DEV_BENEFI"
        Me.DevBenef.HeaderText = "DEV_BENEFI"
        Me.DevBenef.MinimumWidth = 6
        Me.DevBenef.Name = "DevBenef"
        Me.DevBenef.ReadOnly = True
        Me.DevBenef.Width = 125
        '
        'ReciboDev
        '
        Me.ReciboDev.DataPropertyName = "RECDEV"
        Me.ReciboDev.HeaderText = "RECDEV"
        Me.ReciboDev.MinimumWidth = 6
        Me.ReciboDev.Name = "ReciboDev"
        Me.ReciboDev.ReadOnly = True
        Me.ReciboDev.Width = 125
        '
        'EntAcuenta
        '
        Me.EntAcuenta.DataPropertyName = "EntregasAcuenta"
        Me.EntAcuenta.HeaderText = "EntregasAcuenta"
        Me.EntAcuenta.MinimumWidth = 6
        Me.EntAcuenta.Name = "EntAcuenta"
        Me.EntAcuenta.ReadOnly = True
        Me.EntAcuenta.Width = 125
        '
        'Deuda
        '
        Me.Deuda.DataPropertyName = "DEUDA"
        Me.Deuda.HeaderText = "DEUDA"
        Me.Deuda.MinimumWidth = 6
        Me.Deuda.Name = "Deuda"
        Me.Deuda.ReadOnly = True
        Me.Deuda.Width = 125
        '
        'Fallero1BindingSource
        '
        Me.Fallero1BindingSource.DataMember = "Fallero1"
        Me.Fallero1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DgvTitular
        '
        Me.DgvTitular.AllowUserToAddRows = False
        Me.DgvTitular.AllowUserToDeleteRows = False
        Me.DgvTitular.AutoGenerateColumns = False
        Me.DgvTitular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTitular.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRemesaDataGridViewTextBoxColumn, Me.FechaCargoDataGridViewTextBoxColumn, Me.TITULAR})
        Me.DgvTitular.DataSource = Me.RemesasBindingSource
        Me.DgvTitular.Location = New System.Drawing.Point(358, 76)
        Me.DgvTitular.Name = "DgvTitular"
        Me.DgvTitular.ReadOnly = True
        Me.DgvTitular.RowHeadersWidth = 51
        Me.DgvTitular.RowTemplate.Height = 24
        Me.DgvTitular.Size = New System.Drawing.Size(647, 215)
        Me.DgvTitular.TabIndex = 11
        '
        'IdRemesaDataGridViewTextBoxColumn
        '
        Me.IdRemesaDataGridViewTextBoxColumn.DataPropertyName = "IdRemesa"
        Me.IdRemesaDataGridViewTextBoxColumn.HeaderText = "IdRemesa"
        Me.IdRemesaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdRemesaDataGridViewTextBoxColumn.Name = "IdRemesaDataGridViewTextBoxColumn"
        Me.IdRemesaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRemesaDataGridViewTextBoxColumn.Width = 60
        '
        'FechaCargoDataGridViewTextBoxColumn
        '
        Me.FechaCargoDataGridViewTextBoxColumn.DataPropertyName = "FechaCargo"
        Me.FechaCargoDataGridViewTextBoxColumn.HeaderText = "FechaCargo"
        Me.FechaCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaCargoDataGridViewTextBoxColumn.Name = "FechaCargoDataGridViewTextBoxColumn"
        Me.FechaCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCargoDataGridViewTextBoxColumn.Width = 125
        '
        'TITULAR
        '
        Me.TITULAR.DataPropertyName = "TITULAR"
        Me.TITULAR.HeaderText = "TITULAR"
        Me.TITULAR.MinimumWidth = 6
        Me.TITULAR.Name = "TITULAR"
        Me.TITULAR.ReadOnly = True
        Me.TITULAR.Width = 250
        '
        'RemesasBindingSource
        '
        Me.RemesasBindingSource.DataMember = "remesas"
        Me.RemesasBindingSource.DataSource = Me.ReportsDataSetBindingSource
        '
        'ReportsDataSetBindingSource
        '
        Me.ReportsDataSetBindingSource.DataSource = Me.ReportsDataSet
        Me.ReportsDataSetBindingSource.Position = 0
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(853, 337)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 22)
        Me.TextBox1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Aplicar Devoluciones"
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1107, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(118, 37)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAplicar
        '
        Me.BtnAplicar.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAplicar.Location = New System.Drawing.Point(1107, 330)
        Me.BtnAplicar.Name = "BtnAplicar"
        Me.BtnAplicar.Size = New System.Drawing.Size(118, 37)
        Me.BtnAplicar.TabIndex = 14
        Me.BtnAplicar.Text = "Aplicar"
        Me.BtnAplicar.UseVisualStyleBackColor = True
        '
        'DgvDevolucion
        '
        Me.DgvDevolucion.AllowUserToAddRows = False
        Me.DgvDevolucion.AllowUserToDeleteRows = False
        Me.DgvDevolucion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDevolucion.AutoGenerateColumns = False
        Me.DgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDevolucion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Cod, Me.FechaCargo, Me.Nombre, Me.Apellidos, Me.Pagos, Me.Cargos, Me.RecDev, Me.Benef, Me.Acuenta, Me.Importe, Me.devolucion, Me.bloqueado})
        Me.DgvDevolucion.DataSource = Me.Remesas1BindingSource
        Me.DgvDevolucion.Location = New System.Drawing.Point(13, 76)
        Me.DgvDevolucion.Name = "DgvDevolucion"
        Me.DgvDevolucion.ReadOnly = True
        Me.DgvDevolucion.RowHeadersWidth = 51
        Me.DgvDevolucion.RowTemplate.Height = 24
        Me.DgvDevolucion.Size = New System.Drawing.Size(1213, 220)
        Me.DgvDevolucion.TabIndex = 13
        '
        'Id
        '
        Me.Id.DataPropertyName = "IdRemesa"
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 30
        '
        'Cod
        '
        Me.Cod.DataPropertyName = "CODIGO"
        Me.Cod.HeaderText = "CODIGO"
        Me.Cod.MinimumWidth = 6
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Width = 60
        '
        'FechaCargo
        '
        Me.FechaCargo.DataPropertyName = "FechaCargo"
        Me.FechaCargo.HeaderText = "Fecha"
        Me.FechaCargo.MinimumWidth = 6
        Me.FechaCargo.Name = "FechaCargo"
        Me.FechaCargo.ReadOnly = True
        Me.FechaCargo.Width = 70
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NOMBRE"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 125
        '
        'Apellidos
        '
        Me.Apellidos.DataPropertyName = "APELLIDOS"
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.MinimumWidth = 6
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        Me.Apellidos.Width = 125
        '
        'Pagos
        '
        Me.Pagos.DataPropertyName = "PagosPdtes"
        Me.Pagos.HeaderText = "Nº Pagos"
        Me.Pagos.MinimumWidth = 6
        Me.Pagos.Name = "Pagos"
        Me.Pagos.ReadOnly = True
        Me.Pagos.Width = 50
        '
        'Cargos
        '
        Me.Cargos.DataPropertyName = "OtrosCargos"
        Me.Cargos.HeaderText = "Cargos"
        Me.Cargos.MinimumWidth = 6
        Me.Cargos.Name = "Cargos"
        Me.Cargos.ReadOnly = True
        Me.Cargos.Width = 50
        '
        'RecDev
        '
        Me.RecDev.DataPropertyName = "Recdev"
        Me.RecDev.HeaderText = "Rec. Dev,"
        Me.RecDev.MinimumWidth = 6
        Me.RecDev.Name = "RecDev"
        Me.RecDev.ReadOnly = True
        Me.RecDev.Width = 50
        '
        'Benef
        '
        Me.Benef.DataPropertyName = "abonobenefi"
        Me.Benef.HeaderText = "Benef. Lot."
        Me.Benef.MinimumWidth = 6
        Me.Benef.Name = "Benef"
        Me.Benef.ReadOnly = True
        Me.Benef.Width = 50
        '
        'Acuenta
        '
        Me.Acuenta.DataPropertyName = "EntregasAcuenta"
        Me.Acuenta.HeaderText = "A cuenta"
        Me.Acuenta.MinimumWidth = 6
        Me.Acuenta.Name = "Acuenta"
        Me.Acuenta.ReadOnly = True
        Me.Acuenta.Width = 50
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "totalrecibo"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 70
        '
        'devolucion
        '
        Me.devolucion.DataPropertyName = "devolucion"
        Me.devolucion.HeaderText = "Dev."
        Me.devolucion.MinimumWidth = 6
        Me.devolucion.Name = "devolucion"
        Me.devolucion.ReadOnly = True
        Me.devolucion.Width = 50
        '
        'bloqueado
        '
        Me.bloqueado.DataPropertyName = "bloqueado"
        Me.bloqueado.HeaderText = "Bloq."
        Me.bloqueado.MinimumWidth = 6
        Me.bloqueado.Name = "bloqueado"
        Me.bloqueado.ReadOnly = True
        Me.bloqueado.Width = 50
        '
        'Remesas1BindingSource
        '
        Me.Remesas1BindingSource.DataMember = "remesas1"
        Me.Remesas1BindingSource.DataSource = Me.ReportsDataSetBindingSource
        '
        'TxtTitular
        '
        Me.TxtTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTitular.Location = New System.Drawing.Point(515, 46)
        Me.TxtTitular.Name = "TxtTitular"
        Me.TxtTitular.Size = New System.Drawing.Size(185, 22)
        Me.TxtTitular.TabIndex = 12
        '
        'CboSelect
        '
        Me.CboSelect.FormattingEnabled = True
        Me.CboSelect.Location = New System.Drawing.Point(168, 46)
        Me.CboSelect.Name = "CboSelect"
        Me.CboSelect.Size = New System.Drawing.Size(136, 24)
        Me.CboSelect.TabIndex = 10
        '
        'Fallero1TableAdapter
        '
        Me.Fallero1TableAdapter.ClearBeforeFill = True
        '
        'RemesasTableAdapter
        '
        Me.RemesasTableAdapter.ClearBeforeFill = True
        '
        'Remesas1TableAdapter
        '
        Me.Remesas1TableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Selecciona Remesa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Selecciona Titular:"
        '
        'FrmAplicarDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1238, 373)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgvFallero)
        Me.Controls.Add(Me.DgvTitular)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAplicar)
        Me.Controls.Add(Me.DgvDevolucion)
        Me.Controls.Add(Me.TxtTitular)
        Me.Controls.Add(Me.CboSelect)
        Me.HelpProvider1.SetHelpKeyword(Me, "21")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmAplicarDevoluciones"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicar Devoluciones"
        CType(Me.DgvFallero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fallero1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTitular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remesas1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DgvFallero As DataGridView
    Friend WithEvents DgvTitular As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnAplicar As Button
    Friend WithEvents DgvDevolucion As DataGridView
    Friend WithEvents TxtTitular As TextBox
    Friend WithEvents CboSelect As ComboBox
    Friend WithEvents ReportsDataSetBindingSource As BindingSource
    Friend WithEvents ReportsDataSet As ReportsDataSet
    Friend WithEvents RemesasBindingSource As BindingSource
    Friend WithEvents RemesasTableAdapter As ReportsDataSetTableAdapters.remesasTableAdapter
    Friend WithEvents IdRemesaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITULAR As DataGridViewTextBoxColumn
    Friend WithEvents Remesas1BindingSource As BindingSource
    Friend WithEvents Remesas1TableAdapter As ReportsDataSetTableAdapters.remesas1TableAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Fallero1BindingSource As BindingSource
    Friend WithEvents Fallero1TableAdapter As DataSet1TableAdapters.Fallero1TableAdapter
    Friend WithEvents CodFalle As DataGridViewTextBoxColumn
    Friend WithEvents PAGO As DataGridViewTextBoxColumn
    Friend WithEvents NumPagos As DataGridViewTextBoxColumn
    Friend WithEvents OtroCgo As DataGridViewTextBoxColumn
    Friend WithEvents DevBenef As DataGridViewTextBoxColumn
    Friend WithEvents ReciboDev As DataGridViewTextBoxColumn
    Friend WithEvents EntAcuenta As DataGridViewTextBoxColumn
    Friend WithEvents Deuda As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents FechaCargo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Pagos As DataGridViewTextBoxColumn
    Friend WithEvents Cargos As DataGridViewTextBoxColumn
    Friend WithEvents RecDev As DataGridViewTextBoxColumn
    Friend WithEvents Benef As DataGridViewTextBoxColumn
    Friend WithEvents Acuenta As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents devolucion As DataGridViewCheckBoxColumn
    Friend WithEvents bloqueado As DataGridViewCheckBoxColumn
End Class
