<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompararCensos
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
        Me.TxtExcelName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvOficial = New System.Windows.Forms.DataGridView()
        Me.DgvInterno = New System.Windows.Forms.DataGridView()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODRECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FalleroTableAdapter = New AppGestion.DbCensosTableAdapters.falleroTableAdapter()
        Me.DgvFaltan = New System.Windows.Forms.DataGridView()
        Me.DgvSobran = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAnalizar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnSelectFile = New System.Windows.Forms.Button()
        CType(Me.DgvOficial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvInterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFaltan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSobran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtExcelName
        '
        Me.TxtExcelName.Location = New System.Drawing.Point(283, 74)
        Me.TxtExcelName.Name = "TxtExcelName"
        Me.TxtExcelName.Size = New System.Drawing.Size(525, 22)
        Me.TxtExcelName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Seleccionar archivo de JCF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Comparar Censo con registros de JCF"
        '
        'DgvOficial
        '
        Me.DgvOficial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvOficial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOficial.Location = New System.Drawing.Point(19, 160)
        Me.DgvOficial.Name = "DgvOficial"
        Me.DgvOficial.RowHeadersWidth = 51
        Me.DgvOficial.RowTemplate.Height = 24
        Me.DgvOficial.Size = New System.Drawing.Size(600, 483)
        Me.DgvOficial.TabIndex = 10
        '
        'DgvInterno
        '
        Me.DgvInterno.AllowUserToAddRows = False
        Me.DgvInterno.AllowUserToDeleteRows = False
        Me.DgvInterno.AllowUserToOrderColumns = True
        Me.DgvInterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvInterno.AutoGenerateColumns = False
        Me.DgvInterno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInterno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.CODRECDataGridViewTextBoxColumn})
        Me.DgvInterno.DataSource = Me.FalleroBindingSource
        Me.DgvInterno.Location = New System.Drawing.Point(659, 160)
        Me.DgvInterno.Name = "DgvInterno"
        Me.DgvInterno.ReadOnly = True
        Me.DgvInterno.RowHeadersWidth = 51
        Me.DgvInterno.RowTemplate.Height = 24
        Me.DgvInterno.Size = New System.Drawing.Size(600, 483)
        Me.DgvInterno.TabIndex = 11
        '
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 125
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 125
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 125
        '
        'CODRECDataGridViewTextBoxColumn
        '
        Me.CODRECDataGridViewTextBoxColumn.DataPropertyName = "COD_REC"
        Me.CODRECDataGridViewTextBoxColumn.HeaderText = "COD_REC"
        Me.CODRECDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODRECDataGridViewTextBoxColumn.Name = "CODRECDataGridViewTextBoxColumn"
        Me.CODRECDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODRECDataGridViewTextBoxColumn.Width = 125
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Censo JCF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(664, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Censo Falla"
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'DgvFaltan
        '
        Me.DgvFaltan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFaltan.Location = New System.Drawing.Point(12, 173)
        Me.DgvFaltan.Name = "DgvFaltan"
        Me.DgvFaltan.RowHeadersWidth = 51
        Me.DgvFaltan.RowTemplate.Height = 24
        Me.DgvFaltan.Size = New System.Drawing.Size(591, 290)
        Me.DgvFaltan.TabIndex = 15
        '
        'DgvSobran
        '
        Me.DgvSobran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSobran.Location = New System.Drawing.Point(648, 173)
        Me.DgvSobran.Name = "DgvSobran"
        Me.DgvSobran.RowHeadersWidth = 51
        Me.DgvSobran.RowTemplate.Height = 24
        Me.DgvSobran.Size = New System.Drawing.Size(595, 290)
        Me.DgvSobran.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.help
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1027, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 31)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ayuda"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnAnalizar
        '
        Me.BtnAnalizar.Image = Global.AppGestion.My.Resources.Resources._001_37
        Me.BtnAnalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnalizar.Location = New System.Drawing.Point(852, 65)
        Me.BtnAnalizar.Name = "BtnAnalizar"
        Me.BtnAnalizar.Size = New System.Drawing.Size(156, 31)
        Me.BtnAnalizar.TabIndex = 14
        Me.BtnAnalizar.Text = "Analizar"
        Me.BtnAnalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnalizar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1177, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(82, 31)
        Me.BtnSalir.TabIndex = 9
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnSelectFile
        '
        Me.BtnSelectFile.Image = Global.AppGestion.My.Resources.Resources.folder_page
        Me.BtnSelectFile.Location = New System.Drawing.Point(215, 57)
        Me.BtnSelectFile.Name = "BtnSelectFile"
        Me.BtnSelectFile.Size = New System.Drawing.Size(51, 50)
        Me.BtnSelectFile.TabIndex = 6
        Me.BtnSelectFile.Text = "..."
        Me.BtnSelectFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSelectFile.UseVisualStyleBackColor = True
        '
        'FrmCompararCensos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 655)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvSobran)
        Me.Controls.Add(Me.DgvFaltan)
        Me.Controls.Add(Me.BtnAnalizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DgvInterno)
        Me.Controls.Add(Me.DgvOficial)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtExcelName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSelectFile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCompararCensos"
        Me.Text = "FrmCompararCensos"
        CType(Me.DgvOficial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvInterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFaltan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSobran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtExcelName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSelectFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvOficial As DataGridView
    Friend WithEvents DgvInterno As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DbCensosTableAdapters.falleroTableAdapter
    Friend WithEvents BtnAnalizar As Button
    Friend WithEvents DgvFaltan As DataGridView
    Friend WithEvents DgvSobran As DataGridView
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODRECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
