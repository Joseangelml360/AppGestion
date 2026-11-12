<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBancos
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
        Dim CIFPresLabel As System.Windows.Forms.Label
        Dim SufPresLabel As System.Windows.Forms.Label
        Dim Nombre_PresLabel As System.Windows.Forms.Label
        Dim EntPresLabel As System.Windows.Forms.Label
        Dim OfPresLabel As System.Windows.Forms.Label
        Dim OrdenanteLabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim SufOrdLabel As System.Windows.Forms.Label
        Dim EntOrdLabel As System.Windows.Forms.Label
        Dim OfOrdLabel As System.Windows.Forms.Label
        Dim DCOrdLabel As System.Windows.Forms.Label
        Dim CuentaOrdLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBancos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Banco_RemesaDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoremesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OfPresTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EntPresTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SufPresTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CIFPresTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_PresTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CuentaOrdTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DCOrdTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.OfOrdTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EntOrdTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SufOrdTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.OrdenanteTextBox = New System.Windows.Forms.TextBox()
        Me.CIFTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.BancoTextBox = New System.Windows.Forms.TextBox()
        Me.Banco_remesaTableAdapter = New AppGestion.DbCensosTableAdapters.banco_remesaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DbCensosTableAdapters.TableAdapterManager()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CIFPresLabel = New System.Windows.Forms.Label()
        SufPresLabel = New System.Windows.Forms.Label()
        Nombre_PresLabel = New System.Windows.Forms.Label()
        EntPresLabel = New System.Windows.Forms.Label()
        OfPresLabel = New System.Windows.Forms.Label()
        OrdenanteLabel = New System.Windows.Forms.Label()
        CIFLabel = New System.Windows.Forms.Label()
        SufOrdLabel = New System.Windows.Forms.Label()
        EntOrdLabel = New System.Windows.Forms.Label()
        OfOrdLabel = New System.Windows.Forms.Label()
        DCOrdLabel = New System.Windows.Forms.Label()
        CuentaOrdLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        CType(Me.Banco_RemesaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoremesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CIFPresLabel
        '
        CIFPresLabel.AutoSize = True
        CIFPresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CIFPresLabel.Location = New System.Drawing.Point(56, 97)
        CIFPresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CIFPresLabel.Name = "CIFPresLabel"
        CIFPresLabel.Size = New System.Drawing.Size(32, 17)
        CIFPresLabel.TabIndex = 21
        CIFPresLabel.Text = "CIF:"
        '
        'SufPresLabel
        '
        SufPresLabel.AutoSize = True
        SufPresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SufPresLabel.Location = New System.Drawing.Point(43, 130)
        SufPresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SufPresLabel.Name = "SufPresLabel"
        SufPresLabel.Size = New System.Drawing.Size(47, 17)
        SufPresLabel.TabIndex = 23
        SufPresLabel.Text = "Sufijo:"
        '
        'Nombre_PresLabel
        '
        Nombre_PresLabel.AutoSize = True
        Nombre_PresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_PresLabel.Location = New System.Drawing.Point(28, 65)
        Nombre_PresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_PresLabel.Name = "Nombre_PresLabel"
        Nombre_PresLabel.Size = New System.Drawing.Size(62, 17)
        Nombre_PresLabel.TabIndex = 25
        Nombre_PresLabel.Text = "Nombre:"
        '
        'EntPresLabel
        '
        EntPresLabel.AutoSize = True
        EntPresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EntPresLabel.Location = New System.Drawing.Point(29, 161)
        EntPresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EntPresLabel.Name = "EntPresLabel"
        EntPresLabel.Size = New System.Drawing.Size(60, 17)
        EntPresLabel.TabIndex = 27
        EntPresLabel.Text = "Entidad:"
        '
        'OfPresLabel
        '
        OfPresLabel.AutoSize = True
        OfPresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OfPresLabel.Location = New System.Drawing.Point(33, 193)
        OfPresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OfPresLabel.Name = "OfPresLabel"
        OfPresLabel.Size = New System.Drawing.Size(56, 17)
        OfPresLabel.TabIndex = 29
        OfPresLabel.Text = "Oficina:"
        '
        'OrdenanteLabel
        '
        OrdenanteLabel.AutoSize = True
        OrdenanteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OrdenanteLabel.Location = New System.Drawing.Point(23, 31)
        OrdenanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OrdenanteLabel.Name = "OrdenanteLabel"
        OrdenanteLabel.Size = New System.Drawing.Size(80, 17)
        OrdenanteLabel.TabIndex = 5
        OrdenanteLabel.Text = "Ordenante:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CIFLabel.Location = New System.Drawing.Point(68, 63)
        CIFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(32, 17)
        CIFLabel.TabIndex = 7
        CIFLabel.Text = "CIF:"
        '
        'SufOrdLabel
        '
        SufOrdLabel.AutoSize = True
        SufOrdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SufOrdLabel.Location = New System.Drawing.Point(55, 95)
        SufOrdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SufOrdLabel.Name = "SufOrdLabel"
        SufOrdLabel.Size = New System.Drawing.Size(47, 17)
        SufOrdLabel.TabIndex = 9
        SufOrdLabel.Text = "Sufijo:"
        '
        'EntOrdLabel
        '
        EntOrdLabel.AutoSize = True
        EntOrdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EntOrdLabel.Location = New System.Drawing.Point(41, 127)
        EntOrdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EntOrdLabel.Name = "EntOrdLabel"
        EntOrdLabel.Size = New System.Drawing.Size(60, 17)
        EntOrdLabel.TabIndex = 11
        EntOrdLabel.Text = "Entidad:"
        '
        'OfOrdLabel
        '
        OfOrdLabel.AutoSize = True
        OfOrdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OfOrdLabel.Location = New System.Drawing.Point(45, 159)
        OfOrdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OfOrdLabel.Name = "OfOrdLabel"
        OfOrdLabel.Size = New System.Drawing.Size(56, 17)
        OfOrdLabel.TabIndex = 13
        OfOrdLabel.Text = "Oficina:"
        '
        'DCOrdLabel
        '
        DCOrdLabel.AutoSize = True
        DCOrdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DCOrdLabel.Location = New System.Drawing.Point(69, 191)
        DCOrdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DCOrdLabel.Name = "DCOrdLabel"
        DCOrdLabel.Size = New System.Drawing.Size(31, 17)
        DCOrdLabel.TabIndex = 15
        DCOrdLabel.Text = "DC:"
        '
        'CuentaOrdLabel
        '
        CuentaOrdLabel.AutoSize = True
        CuentaOrdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuentaOrdLabel.Location = New System.Drawing.Point(44, 223)
        CuentaOrdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CuentaOrdLabel.Name = "CuentaOrdLabel"
        CuentaOrdLabel.Size = New System.Drawing.Size(57, 17)
        CuentaOrdLabel.TabIndex = 17
        CuentaOrdLabel.Text = "Cuenta:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalidadLabel.Location = New System.Drawing.Point(28, 255)
        LocalidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(73, 17)
        LocalidadLabel.TabIndex = 19
        LocalidadLabel.Text = "Localidad:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(43, 184)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 40
        IdLabel.Text = "Id:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(157, 184)
        BancoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(52, 17)
        BancoLabel.TabIndex = 42
        BancoLabel.Text = "Banco:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Datos de Banco para Remesas"
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(334, 552)
        Me.BtnAñadir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(157, 46)
        Me.BtnAñadir.TabIndex = 48
        Me.BtnAñadir.Text = "Añadir Nuevo"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(802, 552)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(157, 46)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.AppGestion.My.Resources.Resources.page_edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(47, 552)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(157, 46)
        Me.BtnEditar.TabIndex = 47
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Banco_RemesaDataGridView
        '
        Me.Banco_RemesaDataGridView.AllowUserToAddRows = False
        Me.Banco_RemesaDataGridView.AllowUserToDeleteRows = False
        Me.Banco_RemesaDataGridView.AutoGenerateColumns = False
        Me.Banco_RemesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Banco_RemesaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.BancoDataGridViewTextBoxColumn})
        Me.Banco_RemesaDataGridView.DataSource = Me.BancoremesaBindingSource
        Me.Banco_RemesaDataGridView.Location = New System.Drawing.Point(47, 90)
        Me.Banco_RemesaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Banco_RemesaDataGridView.Name = "Banco_RemesaDataGridView"
        Me.Banco_RemesaDataGridView.ReadOnly = True
        Me.Banco_RemesaDataGridView.RowHeadersWidth = 51
        Me.Banco_RemesaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Banco_RemesaDataGridView.Size = New System.Drawing.Size(459, 57)
        Me.Banco_RemesaDataGridView.TabIndex = 45
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 60
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        Me.BancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BancoDataGridViewTextBoxColumn.Width = 250
        '
        'BancoremesaBindingSource
        '
        Me.BancoremesaBindingSource.DataMember = "banco_remesa"
        Me.BancoremesaBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(790, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OfPresTextBox)
        Me.GroupBox2.Controls.Add(Me.EntPresTextBox)
        Me.GroupBox2.Controls.Add(Me.SufPresTextBox)
        Me.GroupBox2.Controls.Add(CIFPresLabel)
        Me.GroupBox2.Controls.Add(Me.CIFPresTextBox)
        Me.GroupBox2.Controls.Add(SufPresLabel)
        Me.GroupBox2.Controls.Add(Nombre_PresLabel)
        Me.GroupBox2.Controls.Add(EntPresLabel)
        Me.GroupBox2.Controls.Add(Me.Nombre_PresTextBox)
        Me.GroupBox2.Controls.Add(OfPresLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(517, 233)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(443, 311)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRESENTADOR"
        '
        'OfPresTextBox
        '
        Me.OfPresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "OfPres", True))
        Me.OfPresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfPresTextBox.Location = New System.Drawing.Point(99, 190)
        Me.OfPresTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OfPresTextBox.Mask = "0000"
        Me.OfPresTextBox.Name = "OfPresTextBox"
        Me.OfPresTextBox.Size = New System.Drawing.Size(132, 23)
        Me.OfPresTextBox.TabIndex = 4
        '
        'EntPresTextBox
        '
        Me.EntPresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "EntPres", True))
        Me.EntPresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntPresTextBox.Location = New System.Drawing.Point(99, 156)
        Me.EntPresTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EntPresTextBox.Mask = "0000"
        Me.EntPresTextBox.Name = "EntPresTextBox"
        Me.EntPresTextBox.Size = New System.Drawing.Size(132, 23)
        Me.EntPresTextBox.TabIndex = 3
        '
        'SufPresTextBox
        '
        Me.SufPresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "SufPres", True))
        Me.SufPresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SufPresTextBox.Location = New System.Drawing.Point(99, 126)
        Me.SufPresTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SufPresTextBox.Mask = "000"
        Me.SufPresTextBox.Name = "SufPresTextBox"
        Me.SufPresTextBox.Size = New System.Drawing.Size(132, 23)
        Me.SufPresTextBox.TabIndex = 2
        '
        'CIFPresTextBox
        '
        Me.CIFPresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CIFPresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "CIFPres", True))
        Me.CIFPresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIFPresTextBox.Location = New System.Drawing.Point(99, 94)
        Me.CIFPresTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CIFPresTextBox.Name = "CIFPresTextBox"
        Me.CIFPresTextBox.Size = New System.Drawing.Size(132, 23)
        Me.CIFPresTextBox.TabIndex = 1
        '
        'Nombre_PresTextBox
        '
        Me.Nombre_PresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nombre_PresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Nombre Pres", True))
        Me.Nombre_PresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_PresTextBox.Location = New System.Drawing.Point(99, 62)
        Me.Nombre_PresTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre_PresTextBox.Name = "Nombre_PresTextBox"
        Me.Nombre_PresTextBox.Size = New System.Drawing.Size(319, 23)
        Me.Nombre_PresTextBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CuentaOrdTextBox)
        Me.GroupBox1.Controls.Add(Me.DCOrdTextBox)
        Me.GroupBox1.Controls.Add(Me.OfOrdTextBox)
        Me.GroupBox1.Controls.Add(Me.EntOrdTextBox)
        Me.GroupBox1.Controls.Add(Me.SufOrdTextBox)
        Me.GroupBox1.Controls.Add(OrdenanteLabel)
        Me.GroupBox1.Controls.Add(Me.OrdenanteTextBox)
        Me.GroupBox1.Controls.Add(CIFLabel)
        Me.GroupBox1.Controls.Add(Me.CIFTextBox)
        Me.GroupBox1.Controls.Add(SufOrdLabel)
        Me.GroupBox1.Controls.Add(EntOrdLabel)
        Me.GroupBox1.Controls.Add(OfOrdLabel)
        Me.GroupBox1.Controls.Add(DCOrdLabel)
        Me.GroupBox1.Controls.Add(CuentaOrdLabel)
        Me.GroupBox1.Controls.Add(LocalidadLabel)
        Me.GroupBox1.Controls.Add(Me.LocalidadTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 234)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(444, 310)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ORDENANTE"
        '
        'CuentaOrdTextBox
        '
        Me.CuentaOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "CuentaOrd", True))
        Me.CuentaOrdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuentaOrdTextBox.Location = New System.Drawing.Point(111, 219)
        Me.CuentaOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CuentaOrdTextBox.Mask = "0000000000"
        Me.CuentaOrdTextBox.Name = "CuentaOrdTextBox"
        Me.CuentaOrdTextBox.Size = New System.Drawing.Size(132, 23)
        Me.CuentaOrdTextBox.TabIndex = 6
        '
        'DCOrdTextBox
        '
        Me.DCOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "DCOrd", True))
        Me.DCOrdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DCOrdTextBox.Location = New System.Drawing.Point(111, 188)
        Me.DCOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DCOrdTextBox.Mask = "00"
        Me.DCOrdTextBox.Name = "DCOrdTextBox"
        Me.DCOrdTextBox.Size = New System.Drawing.Size(132, 23)
        Me.DCOrdTextBox.TabIndex = 5
        '
        'OfOrdTextBox
        '
        Me.OfOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "OfOrd", True))
        Me.OfOrdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfOrdTextBox.Location = New System.Drawing.Point(111, 156)
        Me.OfOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OfOrdTextBox.Mask = "0000"
        Me.OfOrdTextBox.Name = "OfOrdTextBox"
        Me.OfOrdTextBox.Size = New System.Drawing.Size(132, 23)
        Me.OfOrdTextBox.TabIndex = 4
        '
        'EntOrdTextBox
        '
        Me.EntOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "EntOrd", True))
        Me.EntOrdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntOrdTextBox.Location = New System.Drawing.Point(111, 123)
        Me.EntOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EntOrdTextBox.Mask = "0000"
        Me.EntOrdTextBox.Name = "EntOrdTextBox"
        Me.EntOrdTextBox.Size = New System.Drawing.Size(132, 23)
        Me.EntOrdTextBox.TabIndex = 3
        '
        'SufOrdTextBox
        '
        Me.SufOrdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "SufOrd", True))
        Me.SufOrdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SufOrdTextBox.Location = New System.Drawing.Point(111, 91)
        Me.SufOrdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SufOrdTextBox.Mask = "000"
        Me.SufOrdTextBox.Name = "SufOrdTextBox"
        Me.SufOrdTextBox.Size = New System.Drawing.Size(132, 23)
        Me.SufOrdTextBox.TabIndex = 2
        '
        'OrdenanteTextBox
        '
        Me.OrdenanteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OrdenanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Ordenante", True))
        Me.OrdenanteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdenanteTextBox.Location = New System.Drawing.Point(111, 27)
        Me.OrdenanteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OrdenanteTextBox.Name = "OrdenanteTextBox"
        Me.OrdenanteTextBox.Size = New System.Drawing.Size(319, 23)
        Me.OrdenanteTextBox.TabIndex = 0
        '
        'CIFTextBox
        '
        Me.CIFTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "CIF", True))
        Me.CIFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIFTextBox.Location = New System.Drawing.Point(111, 59)
        Me.CIFTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CIFTextBox.Name = "CIFTextBox"
        Me.CIFTextBox.Size = New System.Drawing.Size(132, 23)
        Me.CIFTextBox.TabIndex = 1
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(111, 251)
        Me.LocalidadTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(132, 23)
        Me.LocalidadTextBox.TabIndex = 7
        '
        'IdTextBox
        '
        Me.IdTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(77, 180)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(60, 22)
        Me.IdTextBox.TabIndex = 41
        '
        'BancoTextBox
        '
        Me.BancoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancoremesaBindingSource, "Banco", True))
        Me.BancoTextBox.Location = New System.Drawing.Point(219, 180)
        Me.BancoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BancoTextBox.Name = "BancoTextBox"
        Me.BancoTextBox.Size = New System.Drawing.Size(285, 22)
        Me.BancoTextBox.TabIndex = 38
        '
        'Banco_remesaTableAdapter
        '
        Me.Banco_remesaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adeudosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banco_remesaTableAdapter = Me.Banco_remesaTableAdapter
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
        'FrmBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1003, 618)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Banco_RemesaDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(BancoLabel)
        Me.Controls.Add(Me.BancoTextBox)
        Me.HelpProvider1.SetHelpKeyword(Me, "22")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBancos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Banco para remesas"
        CType(Me.Banco_RemesaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoremesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Banco_RemesaDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OfPresTextBox As MaskedTextBox
    Friend WithEvents EntPresTextBox As MaskedTextBox
    Friend WithEvents SufPresTextBox As MaskedTextBox
    Friend WithEvents CIFPresTextBox As TextBox
    Friend WithEvents Nombre_PresTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CuentaOrdTextBox As MaskedTextBox
    Friend WithEvents DCOrdTextBox As MaskedTextBox
    Friend WithEvents OfOrdTextBox As MaskedTextBox
    Friend WithEvents EntOrdTextBox As MaskedTextBox
    Friend WithEvents SufOrdTextBox As MaskedTextBox
    Friend WithEvents OrdenanteTextBox As TextBox
    Friend WithEvents CIFTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents BancoTextBox As TextBox
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents BancoremesaBindingSource As BindingSource
    Friend WithEvents Banco_remesaTableAdapter As DbCensosTableAdapters.banco_remesaTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DbCensosTableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
