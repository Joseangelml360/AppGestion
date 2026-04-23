<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerPagos
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
        Dim IdRemesaLabel As System.Windows.Forms.Label
        Dim TITULARLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerPagos))
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.RemesasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdRemesaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosPdtesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosCargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecdevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasAcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonobenefiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalreciboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DevolucionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RemesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.IdRemesaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnVerFallero = New System.Windows.Forms.Button()
        Me.BtnVerGrupo = New System.Windows.Forms.Button()
        Me.TITULARTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.RemesasTableAdapter = New AppGestion.DbCensosTableAdapters.remesasTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        IdRemesaLabel = New System.Windows.Forms.Label()
        TITULARLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        CODIGOLabel = New System.Windows.Forms.Label()
        CType(Me.RemesasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdRemesaLabel
        '
        IdRemesaLabel.AutoSize = True
        IdRemesaLabel.Location = New System.Drawing.Point(777, 29)
        IdRemesaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdRemesaLabel.Name = "IdRemesaLabel"
        IdRemesaLabel.Size = New System.Drawing.Size(79, 17)
        IdRemesaLabel.TabIndex = 25
        IdRemesaLabel.Text = "Id Remesa:"
        '
        'TITULARLabel
        '
        TITULARLabel.AutoSize = True
        TITULARLabel.Location = New System.Drawing.Point(574, 71)
        TITULARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TITULARLabel.Name = "TITULARLabel"
        TITULARLabel.Size = New System.Drawing.Size(70, 17)
        TITULARLabel.TabIndex = 22
        TITULARLabel.Text = "TITULAR:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(9, 71)
        NOMBRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(72, 17)
        NOMBRELabel.TabIndex = 18
        NOMBRELabel.Text = "NOMBRE:"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(17, 29)
        CODIGOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(67, 17)
        CODIGOLabel.TabIndex = 24
        CODIGOLabel.Text = "CODIGO:"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(215, 28)
        Me.Txt1.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(132, 22)
        Me.Txt1.TabIndex = 26
        '
        'RemesasDataGridView
        '
        Me.RemesasDataGridView.AllowUserToAddRows = False
        Me.RemesasDataGridView.AllowUserToDeleteRows = False
        Me.RemesasDataGridView.AutoGenerateColumns = False
        Me.RemesasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemesasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRemesaDataGridViewTextBoxColumn, Me.FechaCargoDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.ImporteCuotaDataGridViewTextBoxColumn, Me.PagosPdtesDataGridViewTextBoxColumn, Me.OtrosCargosDataGridViewTextBoxColumn, Me.RecdevDataGridViewTextBoxColumn, Me.TotalCargoDataGridViewTextBoxColumn, Me.EntregasAcuentaDataGridViewTextBoxColumn, Me.AbonobenefiDataGridViewTextBoxColumn, Me.TotalreciboDataGridViewTextBoxColumn, Me.DevolucionDataGridViewCheckBoxColumn})
        Me.RemesasDataGridView.DataSource = Me.RemesasBindingSource
        Me.RemesasDataGridView.Location = New System.Drawing.Point(13, 127)
        Me.RemesasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.RemesasDataGridView.Name = "RemesasDataGridView"
        Me.RemesasDataGridView.ReadOnly = True
        Me.RemesasDataGridView.RowHeadersWidth = 51
        Me.RemesasDataGridView.Size = New System.Drawing.Size(1275, 331)
        Me.RemesasDataGridView.TabIndex = 23
        '
        'IdRemesaDataGridViewTextBoxColumn
        '
        Me.IdRemesaDataGridViewTextBoxColumn.DataPropertyName = "IdRemesa"
        Me.IdRemesaDataGridViewTextBoxColumn.HeaderText = "Id Remesa"
        Me.IdRemesaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdRemesaDataGridViewTextBoxColumn.Name = "IdRemesaDataGridViewTextBoxColumn"
        Me.IdRemesaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRemesaDataGridViewTextBoxColumn.Width = 50
        '
        'FechaCargoDataGridViewTextBoxColumn
        '
        Me.FechaCargoDataGridViewTextBoxColumn.DataPropertyName = "FechaCargo"
        Me.FechaCargoDataGridViewTextBoxColumn.HeaderText = "Fecha Cargo"
        Me.FechaCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaCargoDataGridViewTextBoxColumn.Name = "FechaCargoDataGridViewTextBoxColumn"
        Me.FechaCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCargoDataGridViewTextBoxColumn.Width = 70
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 120
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
        'ImporteCuotaDataGridViewTextBoxColumn
        '
        Me.ImporteCuotaDataGridViewTextBoxColumn.DataPropertyName = "ImporteCuota"
        Me.ImporteCuotaDataGridViewTextBoxColumn.HeaderText = "Importe Cuota"
        Me.ImporteCuotaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImporteCuotaDataGridViewTextBoxColumn.Name = "ImporteCuotaDataGridViewTextBoxColumn"
        Me.ImporteCuotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteCuotaDataGridViewTextBoxColumn.Width = 50
        '
        'PagosPdtesDataGridViewTextBoxColumn
        '
        Me.PagosPdtesDataGridViewTextBoxColumn.DataPropertyName = "PagosPdtes"
        Me.PagosPdtesDataGridViewTextBoxColumn.HeaderText = "Nº Cuotas"
        Me.PagosPdtesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PagosPdtesDataGridViewTextBoxColumn.Name = "PagosPdtesDataGridViewTextBoxColumn"
        Me.PagosPdtesDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagosPdtesDataGridViewTextBoxColumn.Width = 50
        '
        'OtrosCargosDataGridViewTextBoxColumn
        '
        Me.OtrosCargosDataGridViewTextBoxColumn.DataPropertyName = "OtrosCargos"
        Me.OtrosCargosDataGridViewTextBoxColumn.HeaderText = "Otros Cargos"
        Me.OtrosCargosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OtrosCargosDataGridViewTextBoxColumn.Name = "OtrosCargosDataGridViewTextBoxColumn"
        Me.OtrosCargosDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtrosCargosDataGridViewTextBoxColumn.Width = 50
        '
        'RecdevDataGridViewTextBoxColumn
        '
        Me.RecdevDataGridViewTextBoxColumn.DataPropertyName = "Recdev"
        Me.RecdevDataGridViewTextBoxColumn.HeaderText = "Recibos dev."
        Me.RecdevDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RecdevDataGridViewTextBoxColumn.Name = "RecdevDataGridViewTextBoxColumn"
        Me.RecdevDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecdevDataGridViewTextBoxColumn.Width = 50
        '
        'TotalCargoDataGridViewTextBoxColumn
        '
        Me.TotalCargoDataGridViewTextBoxColumn.DataPropertyName = "totalCargo"
        Me.TotalCargoDataGridViewTextBoxColumn.HeaderText = "Total cargo"
        Me.TotalCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCargoDataGridViewTextBoxColumn.Name = "TotalCargoDataGridViewTextBoxColumn"
        Me.TotalCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCargoDataGridViewTextBoxColumn.Width = 50
        '
        'EntregasAcuentaDataGridViewTextBoxColumn
        '
        Me.EntregasAcuentaDataGridViewTextBoxColumn.DataPropertyName = "EntregasAcuenta"
        Me.EntregasAcuentaDataGridViewTextBoxColumn.HeaderText = "Entregas a cuenta"
        Me.EntregasAcuentaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EntregasAcuentaDataGridViewTextBoxColumn.Name = "EntregasAcuentaDataGridViewTextBoxColumn"
        Me.EntregasAcuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntregasAcuentaDataGridViewTextBoxColumn.Width = 70
        '
        'AbonobenefiDataGridViewTextBoxColumn
        '
        Me.AbonobenefiDataGridViewTextBoxColumn.DataPropertyName = "abonobenefi"
        Me.AbonobenefiDataGridViewTextBoxColumn.HeaderText = "Beneficios abonados"
        Me.AbonobenefiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AbonobenefiDataGridViewTextBoxColumn.Name = "AbonobenefiDataGridViewTextBoxColumn"
        Me.AbonobenefiDataGridViewTextBoxColumn.ReadOnly = True
        Me.AbonobenefiDataGridViewTextBoxColumn.Width = 70
        '
        'TotalreciboDataGridViewTextBoxColumn
        '
        Me.TotalreciboDataGridViewTextBoxColumn.DataPropertyName = "totalrecibo"
        Me.TotalreciboDataGridViewTextBoxColumn.HeaderText = "Total recibo"
        Me.TotalreciboDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalreciboDataGridViewTextBoxColumn.Name = "TotalreciboDataGridViewTextBoxColumn"
        Me.TotalreciboDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalreciboDataGridViewTextBoxColumn.Width = 60
        '
        'DevolucionDataGridViewCheckBoxColumn
        '
        Me.DevolucionDataGridViewCheckBoxColumn.DataPropertyName = "devolucion"
        Me.DevolucionDataGridViewCheckBoxColumn.HeaderText = "Devolucion"
        Me.DevolucionDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.DevolucionDataGridViewCheckBoxColumn.Name = "DevolucionDataGridViewCheckBoxColumn"
        Me.DevolucionDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DevolucionDataGridViewCheckBoxColumn.Width = 70
        '
        'RemesasBindingSource
        '
        Me.RemesasBindingSource.DataMember = "remesas"
        Me.RemesasBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdRemesaTextBox
        '
        Me.IdRemesaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RemesasBindingSource, "IdRemesa", True))
        Me.IdRemesaTextBox.Location = New System.Drawing.Point(866, 26)
        Me.IdRemesaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdRemesaTextBox.Name = "IdRemesaTextBox"
        Me.IdRemesaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdRemesaTextBox.TabIndex = 15
        '
        'BtnVerFallero
        '
        Me.BtnVerFallero.Image = CType(resources.GetObject("BtnVerFallero.Image"), System.Drawing.Image)
        Me.BtnVerFallero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerFallero.Location = New System.Drawing.Point(33, 498)
        Me.BtnVerFallero.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVerFallero.Name = "BtnVerFallero"
        Me.BtnVerFallero.Size = New System.Drawing.Size(159, 43)
        Me.BtnVerFallero.TabIndex = 21
        Me.BtnVerFallero.Text = "Ver fallero"
        Me.BtnVerFallero.UseVisualStyleBackColor = True
        '
        'BtnVerGrupo
        '
        Me.BtnVerGrupo.Image = CType(resources.GetObject("BtnVerGrupo.Image"), System.Drawing.Image)
        Me.BtnVerGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerGrupo.Location = New System.Drawing.Point(286, 498)
        Me.BtnVerGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVerGrupo.Name = "BtnVerGrupo"
        Me.BtnVerGrupo.Size = New System.Drawing.Size(159, 43)
        Me.BtnVerGrupo.TabIndex = 20
        Me.BtnVerGrupo.Text = "Ver Grupo"
        Me.BtnVerGrupo.UseVisualStyleBackColor = True
        '
        'TITULARTextBox
        '
        Me.TITULARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RemesasBindingSource, "TITULAR", True))
        Me.TITULARTextBox.Location = New System.Drawing.Point(657, 68)
        Me.TITULARTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TITULARTextBox.Name = "TITULARTextBox"
        Me.TITULARTextBox.Size = New System.Drawing.Size(341, 22)
        Me.TITULARTextBox.TabIndex = 19
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RemesasBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(253, 68)
        Me.APELLIDOSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(296, 22)
        Me.APELLIDOSTextBox.TabIndex = 17
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RemesasBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(93, 68)
        Me.NOMBRETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(151, 22)
        Me.NOMBRETextBox.TabIndex = 16
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RemesasBindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(94, 26)
        Me.CODIGOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(71, 22)
        Me.CODIGOTextBox.TabIndex = 14
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1125, 498)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(159, 43)
        Me.BtnSalir.TabIndex = 27
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'RemesasTableAdapter
        '
        Me.RemesasTableAdapter.ClearBeforeFill = True
        '
        'FrmVerPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1297, 567)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.RemesasDataGridView)
        Me.Controls.Add(IdRemesaLabel)
        Me.Controls.Add(Me.IdRemesaTextBox)
        Me.Controls.Add(Me.BtnVerFallero)
        Me.Controls.Add(Me.BtnVerGrupo)
        Me.Controls.Add(TITULARLabel)
        Me.Controls.Add(Me.TITULARTextBox)
        Me.Controls.Add(Me.APELLIDOSTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.HelpProvider1.SetHelpKeyword(Me, "50")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVerPagos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos de fallero"
        CType(Me.RemesasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt1 As TextBox
    Friend WithEvents RemesasDataGridView As DataGridView
    Friend WithEvents IdRemesaTextBox As TextBox
    Friend WithEvents BtnVerFallero As Button
    Friend WithEvents BtnVerGrupo As Button
    Friend WithEvents TITULARTextBox As TextBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents RemesasBindingSource As BindingSource
    Friend WithEvents RemesasTableAdapter As DbCensosTableAdapters.remesasTableAdapter
    Friend WithEvents IdRemesaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteCuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagosPdtesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtrosCargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecdevDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntregasAcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbonobenefiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalreciboDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DevolucionDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
