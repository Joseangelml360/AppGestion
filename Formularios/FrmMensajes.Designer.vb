<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMensajes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMensajes))
        Me.IdMensajesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvMensajes = New System.Windows.Forms.DataGridView()
        Me.BtnNoLeidos = New System.Windows.Forms.Button()
        Me.BtnLeidos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.DtFecha = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.BtnNuevaNota = New System.Windows.Forms.Button()
        Me.ChkVisto = New System.Windows.Forms.CheckBox()
        Me.LblLeido = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardarNuevo = New System.Windows.Forms.Button()
        Me.MensajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.MensajesTableAdapter = New AppGestion.DataSet1TableAdapters.MensajesTableAdapter()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.IdMensajesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeidoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DgvMensajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdMensajesDataGridViewTextBoxColumn
        '
        Me.IdMensajesDataGridViewTextBoxColumn.DataPropertyName = "idMensajes"
        Me.IdMensajesDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdMensajesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdMensajesDataGridViewTextBoxColumn.Name = "IdMensajesDataGridViewTextBoxColumn"
        Me.IdMensajesDataGridViewTextBoxColumn.Width = 40
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 125
        '
        'TextoDataGridViewTextBoxColumn
        '
        Me.TextoDataGridViewTextBoxColumn.DataPropertyName = "Texto"
        Me.TextoDataGridViewTextBoxColumn.HeaderText = "Texto"
        Me.TextoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TextoDataGridViewTextBoxColumn.Name = "TextoDataGridViewTextBoxColumn"
        Me.TextoDataGridViewTextBoxColumn.Width = 500
        '
        'DgvMensajes
        '
        Me.DgvMensajes.AllowUserToAddRows = False
        Me.DgvMensajes.AllowUserToDeleteRows = False
        Me.DgvMensajes.AutoGenerateColumns = False
        Me.DgvMensajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMensajes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMensajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMensajesDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn1, Me.TextoDataGridViewTextBoxColumn1, Me.LeidoDataGridViewCheckBoxColumn})
        Me.DgvMensajes.DataSource = Me.MensajesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMensajes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMensajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DgvMensajes.Location = New System.Drawing.Point(12, 73)
        Me.DgvMensajes.Name = "DgvMensajes"
        Me.DgvMensajes.RowHeadersWidth = 51
        Me.DgvMensajes.RowTemplate.Height = 24
        Me.DgvMensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMensajes.Size = New System.Drawing.Size(987, 150)
        Me.DgvMensajes.TabIndex = 0
        '
        'BtnNoLeidos
        '
        Me.BtnNoLeidos.Image = Global.AppGestion.My.Resources.Resources.folder_page
        Me.BtnNoLeidos.Location = New System.Drawing.Point(28, 12)
        Me.BtnNoLeidos.Name = "BtnNoLeidos"
        Me.BtnNoLeidos.Size = New System.Drawing.Size(75, 44)
        Me.BtnNoLeidos.TabIndex = 1
        Me.BtnNoLeidos.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnNoLeidos.UseVisualStyleBackColor = True
        '
        'BtnLeidos
        '
        Me.BtnLeidos.Image = Global.AppGestion.My.Resources.Resources.eye
        Me.BtnLeidos.Location = New System.Drawing.Point(275, 12)
        Me.BtnLeidos.Name = "BtnLeidos"
        Me.BtnLeidos.Size = New System.Drawing.Size(75, 44)
        Me.BtnLeidos.TabIndex = 2
        Me.BtnLeidos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mensajes sin leer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mensajes leídos"
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(924, 14)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 41)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.AppGestion.My.Resources.Resources.accept
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(69, 398)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(142, 32)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar cambios"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.UseVisualStyleBackColor = True
        Me.BtnAceptar.Visible = False
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Location = New System.Drawing.Point(70, 312)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(531, 64)
        Me.TxtMensaje.TabIndex = 8
        '
        'DtFecha
        '
        Me.DtFecha.Enabled = False
        Me.DtFecha.Location = New System.Drawing.Point(70, 275)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(100, 22)
        Me.DtFecha.TabIndex = 9
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(70, 246)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 22)
        Me.TxtId.TabIndex = 10
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(28, 246)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(19, 17)
        Me.LblId.TabIndex = 12
        Me.LblId.Text = "Id"
        '
        'LblTexto
        '
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Location = New System.Drawing.Point(12, 312)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(43, 17)
        Me.LblTexto.TabIndex = 14
        Me.LblTexto.Text = "Texto"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(12, 280)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(47, 17)
        Me.LblFecha.TabIndex = 15
        Me.LblFecha.Text = "Fecha"
        '
        'BtnNuevaNota
        '
        Me.BtnNuevaNota.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnNuevaNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevaNota.Location = New System.Drawing.Point(834, 398)
        Me.BtnNuevaNota.Name = "BtnNuevaNota"
        Me.BtnNuevaNota.Size = New System.Drawing.Size(140, 32)
        Me.BtnNuevaNota.TabIndex = 16
        Me.BtnNuevaNota.Text = "Nueva nota"
        Me.BtnNuevaNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevaNota.UseVisualStyleBackColor = True
        '
        'ChkVisto
        '
        Me.ChkVisto.AutoSize = True
        Me.ChkVisto.Location = New System.Drawing.Point(501, 262)
        Me.ChkVisto.Name = "ChkVisto"
        Me.ChkVisto.Size = New System.Drawing.Size(18, 17)
        Me.ChkVisto.TabIndex = 17
        Me.ChkVisto.UseVisualStyleBackColor = True
        '
        'LblLeido
        '
        Me.LblLeido.AutoSize = True
        Me.LblLeido.Location = New System.Drawing.Point(525, 262)
        Me.LblLeido.Name = "LblLeido"
        Me.LblLeido.Size = New System.Drawing.Size(43, 17)
        Me.LblLeido.TabIndex = 18
        Me.LblLeido.Text = "Leído"
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.AppGestion.My.Resources.Resources.page_edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(835, 339)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(139, 37)
        Me.BtnEditar.TabIndex = 19
        Me.BtnEditar.Text = "Editar selección"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardarNuevo
        '
        Me.BtnGuardarNuevo.Image = Global.AppGestion.My.Resources.Resources.accept
        Me.BtnGuardarNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarNuevo.Location = New System.Drawing.Point(235, 399)
        Me.BtnGuardarNuevo.Name = "BtnGuardarNuevo"
        Me.BtnGuardarNuevo.Size = New System.Drawing.Size(138, 32)
        Me.BtnGuardarNuevo.TabIndex = 20
        Me.BtnGuardarNuevo.Text = "Guardar nota"
        Me.BtnGuardarNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardarNuevo.UseVisualStyleBackColor = True
        Me.BtnGuardarNuevo.Visible = False
        '
        'MensajesBindingSource
        '
        Me.MensajesBindingSource.DataMember = "Mensajes"
        Me.MensajesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MensajesTableAdapter
        '
        Me.MensajesTableAdapter.ClearBeforeFill = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(494, 398)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(107, 33)
        Me.BtnCancel.TabIndex = 21
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = True
        Me.BtnCancel.Visible = False
        '
        'IdMensajesDataGridViewTextBoxColumn1
        '
        Me.IdMensajesDataGridViewTextBoxColumn1.DataPropertyName = "idMensajes"
        Me.IdMensajesDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdMensajesDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdMensajesDataGridViewTextBoxColumn1.Name = "IdMensajesDataGridViewTextBoxColumn1"
        Me.IdMensajesDataGridViewTextBoxColumn1.Visible = False
        Me.IdMensajesDataGridViewTextBoxColumn1.Width = 40
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.Width = 75
        '
        'TextoDataGridViewTextBoxColumn1
        '
        Me.TextoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.TextoDataGridViewTextBoxColumn1.DataPropertyName = "Texto"
        Me.TextoDataGridViewTextBoxColumn1.HeaderText = "Texto"
        Me.TextoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.TextoDataGridViewTextBoxColumn1.Name = "TextoDataGridViewTextBoxColumn1"
        Me.TextoDataGridViewTextBoxColumn1.Width = 6
        '
        'LeidoDataGridViewCheckBoxColumn
        '
        Me.LeidoDataGridViewCheckBoxColumn.DataPropertyName = "Leido"
        Me.LeidoDataGridViewCheckBoxColumn.HeaderText = "Leido"
        Me.LeidoDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.LeidoDataGridViewCheckBoxColumn.Name = "LeidoDataGridViewCheckBoxColumn"
        Me.LeidoDataGridViewCheckBoxColumn.Width = 40
        '
        'FrmMensajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1011, 443)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnGuardarNuevo)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.LblLeido)
        Me.Controls.Add(Me.ChkVisto)
        Me.Controls.Add(Me.BtnNuevaNota)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblTexto)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLeidos)
        Me.Controls.Add(Me.BtnNoLeidos)
        Me.Controls.Add(Me.DgvMensajes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FrmMensajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensajes"
        CType(Me.DgvMensajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MensajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdMensajesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DgvMensajes As DataGridView
    Friend WithEvents BtnNoLeidos As Button
    Friend WithEvents BtnLeidos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtMensaje As TextBox
    Friend WithEvents DtFecha As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents LblTexto As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents BtnNuevaNota As Button
    Friend WithEvents ChkVisto As CheckBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MensajesBindingSource As BindingSource
    Friend WithEvents MensajesTableAdapter As DataSet1TableAdapters.MensajesTableAdapter
    Friend WithEvents LblLeido As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardarNuevo As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents IdMensajesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TextoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LeidoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
