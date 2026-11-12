<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJuntaDirectiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJuntaDirectiva))
        Me.LblComision = New System.Windows.Forms.Label()
        Me.CboComision = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CARGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FALLEROCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuntaDirectivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFallero = New AppGestion.DataSetFallero()
        Me.JuntaDirectivaTableAdapter = New AppGestion.DataSetFalleroTableAdapters.JuntaDirectivaTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuntaDirectivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblComision
        '
        Me.LblComision.AutoSize = True
        Me.LblComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComision.Location = New System.Drawing.Point(418, 21)
        Me.LblComision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblComision.Name = "LblComision"
        Me.LblComision.Size = New System.Drawing.Size(80, 20)
        Me.LblComision.TabIndex = 11
        Me.LblComision.Text = "Mayores"
        '
        'CboComision
        '
        Me.CboComision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboComision.FormattingEnabled = True
        Me.CboComision.Items.AddRange(New Object() {"Mayores", "Infantiles"})
        Me.CboComision.Location = New System.Drawing.Point(682, 20)
        Me.CboComision.Margin = New System.Windows.Forms.Padding(4)
        Me.CboComision.Name = "CboComision"
        Me.CboComision.Size = New System.Drawing.Size(160, 24)
        Me.CboComision.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Junta Directiva del Ejercicio"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CARGODataGridViewTextBoxColumn, Me.DESCRIPDataGridViewTextBoxColumn, Me.FALLEROCODIGODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.TIPFALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JuntaDirectivaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 61)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(824, 416)
        Me.DataGridView1.TabIndex = 6
        '
        'CARGODataGridViewTextBoxColumn
        '
        Me.CARGODataGridViewTextBoxColumn.DataPropertyName = "CARGO"
        Me.CARGODataGridViewTextBoxColumn.HeaderText = "Id"
        Me.CARGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CARGODataGridViewTextBoxColumn.Name = "CARGODataGridViewTextBoxColumn"
        Me.CARGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CARGODataGridViewTextBoxColumn.Width = 50
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
        'FALLEROCODIGODataGridViewTextBoxColumn
        '
        Me.FALLEROCODIGODataGridViewTextBoxColumn.DataPropertyName = "FALLERO_CODIGO"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.HeaderText = "Código"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Name = "FALLEROCODIGODataGridViewTextBoxColumn"
        Me.FALLEROCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FALLEROCODIGODataGridViewTextBoxColumn.Width = 125
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 125
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 200
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
        'JuntaDirectivaBindingSource
        '
        Me.JuntaDirectivaBindingSource.DataMember = "JuntaDirectiva"
        Me.JuntaDirectivaBindingSource.DataSource = Me.DataSetFallero
        '
        'DataSetFallero
        '
        Me.DataSetFallero.DataSetName = "DataSetFallero"
        Me.DataSetFallero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JuntaDirectivaTableAdapter
        '
        Me.JuntaDirectivaTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.report
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(23, 486)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Informe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(686, 485)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmJuntaDirectiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(862, 553)
        Me.Controls.Add(Me.LblComision)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CboComision)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.HelpProvider1.SetHelpKeyword(Me, "35")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmJuntaDirectiva"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Junta Directiva"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuntaDirectivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblComision As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CboComision As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CARGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FALLEROCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JuntaDirectivaBindingSource As BindingSource
    Friend WithEvents DataSetFallero As DataSetFallero
    Friend WithEvents JuntaDirectivaTableAdapter As DataSetFalleroTableAdapters.JuntaDirectivaTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
