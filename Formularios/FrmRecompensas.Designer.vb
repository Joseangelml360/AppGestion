<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecompensas
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim ComisionLabel2 As System.Windows.Forms.Label
        Dim RECLabel As System.Windows.Forms.Label
        Dim IDlabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecompensas))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TxtComision = New System.Windows.Forms.TextBox()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtRecompensa = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComisionTxt = New System.Windows.Forms.TextBox()
        Me.RecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.RecompensaTxt = New System.Windows.Forms.TextBox()
        Me.IdText = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RecompensasDataGridView = New System.Windows.Forms.DataGridView()
        Me.RECOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESRECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecompensasTableAdapter = New AppGestion.DbCensosTableAdapters.recompensasTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        ComisionLabel2 = New System.Windows.Forms.Label()
        RECLabel = New System.Windows.Forms.Label()
        IDlabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(37, 97)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(69, 17)
        Label3.TabIndex = 12
        Label3.Text = "Comisión:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(11, 65)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(95, 17)
        Label4.TabIndex = 8
        Label4.Text = "Recompensa:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(79, 33)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(25, 17)
        Label5.TabIndex = 6
        Label5.Text = "ID:"
        '
        'ComisionLabel2
        '
        ComisionLabel2.AutoSize = True
        ComisionLabel2.Location = New System.Drawing.Point(37, 97)
        ComisionLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ComisionLabel2.Name = "ComisionLabel2"
        ComisionLabel2.Size = New System.Drawing.Size(69, 17)
        ComisionLabel2.TabIndex = 12
        ComisionLabel2.Text = "Comisión:"
        '
        'RECLabel
        '
        RECLabel.AutoSize = True
        RECLabel.Location = New System.Drawing.Point(11, 65)
        RECLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RECLabel.Name = "RECLabel"
        RECLabel.Size = New System.Drawing.Size(95, 17)
        RECLabel.TabIndex = 8
        RECLabel.Text = "Recompensa:"
        '
        'IDlabel
        '
        IDlabel.AutoSize = True
        IDlabel.Location = New System.Drawing.Point(79, 33)
        IDlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDlabel.Name = "IDlabel"
        IDlabel.Size = New System.Drawing.Size(25, 17)
        IDlabel.TabIndex = 6
        IDlabel.Text = "ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.TxtComision)
        Me.GroupBox2.Controls.Add(Me.BtnAddNew)
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.TxtRecompensa)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Me.TxtID)
        Me.GroupBox2.Location = New System.Drawing.Point(605, 306)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(453, 229)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Infantiles", "Mayores"})
        Me.ComboBox2.Location = New System.Drawing.Point(165, 92)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(261, 24)
        Me.ComboBox2.TabIndex = 14
        '
        'TxtComision
        '
        Me.TxtComision.Location = New System.Drawing.Point(115, 94)
        Me.TxtComision.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtComision.Name = "TxtComision"
        Me.TxtComision.Size = New System.Drawing.Size(41, 22)
        Me.TxtComision.TabIndex = 13
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(271, 151)
        Me.BtnAddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(157, 46)
        Me.BtnAddNew.TabIndex = 11
        Me.BtnAddNew.Text = "Guardar"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(73, 151)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(157, 46)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TxtRecompensa
        '
        Me.TxtRecompensa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRecompensa.Location = New System.Drawing.Point(115, 62)
        Me.TxtRecompensa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecompensa.Name = "TxtRecompensa"
        Me.TxtRecompensa.Size = New System.Drawing.Size(312, 22)
        Me.TxtRecompensa.TabIndex = 9
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(115, 30)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(132, 22)
        Me.TxtID.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(ComisionLabel2)
        Me.GroupBox1.Controls.Add(Me.ComisionTxt)
        Me.GroupBox1.Controls.Add(Me.BtnAñadir)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(RECLabel)
        Me.GroupBox1.Controls.Add(Me.RecompensaTxt)
        Me.GroupBox1.Controls.Add(IDlabel)
        Me.GroupBox1.Controls.Add(Me.IdText)
        Me.GroupBox1.Location = New System.Drawing.Point(605, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 229)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Infantiles", "Mayores"})
        Me.ComboBox1.Location = New System.Drawing.Point(165, 94)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(261, 24)
        Me.ComboBox1.TabIndex = 14
        '
        'ComisionTxt
        '
        Me.ComisionTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasBindingSource, "TIPFAL", True))
        Me.ComisionTxt.Location = New System.Drawing.Point(115, 94)
        Me.ComisionTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ComisionTxt.Name = "ComisionTxt"
        Me.ComisionTxt.Size = New System.Drawing.Size(41, 22)
        Me.ComisionTxt.TabIndex = 13
        '
        'RecompensasBindingSource
        '
        Me.RecompensasBindingSource.DataMember = "recompensas"
        Me.RecompensasBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(271, 151)
        Me.BtnAñadir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(157, 46)
        Me.BtnAñadir.TabIndex = 11
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(73, 151)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(157, 46)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'RecompensaTxt
        '
        Me.RecompensaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RecompensaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasBindingSource, "DESREC", True))
        Me.RecompensaTxt.Location = New System.Drawing.Point(115, 62)
        Me.RecompensaTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.RecompensaTxt.Name = "RecompensaTxt"
        Me.RecompensaTxt.Size = New System.Drawing.Size(312, 22)
        Me.RecompensaTxt.TabIndex = 9
        '
        'IdText
        '
        Me.IdText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasBindingSource, "RECOM", True))
        Me.IdText.Location = New System.Drawing.Point(115, 30)
        Me.IdText.Margin = New System.Windows.Forms.Padding(4)
        Me.IdText.Name = "IdText"
        Me.IdText.Size = New System.Drawing.Size(132, 22)
        Me.IdText.TabIndex = 7
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(901, 17)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 25
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Mantenimiento Recompensas"
        '
        'RecompensasDataGridView
        '
        Me.RecompensasDataGridView.AllowUserToAddRows = False
        Me.RecompensasDataGridView.AllowUserToDeleteRows = False
        Me.RecompensasDataGridView.AllowUserToOrderColumns = True
        Me.RecompensasDataGridView.AutoGenerateColumns = False
        Me.RecompensasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecompensasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RECOMDataGridViewTextBoxColumn, Me.DESRECDataGridViewTextBoxColumn, Me.TIPFALDataGridViewTextBoxColumn})
        Me.RecompensasDataGridView.DataSource = Me.RecompensasBindingSource
        Me.RecompensasDataGridView.Location = New System.Drawing.Point(24, 99)
        Me.RecompensasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.RecompensasDataGridView.Name = "RecompensasDataGridView"
        Me.RecompensasDataGridView.ReadOnly = True
        Me.RecompensasDataGridView.RowHeadersWidth = 51
        Me.RecompensasDataGridView.Size = New System.Drawing.Size(573, 437)
        Me.RecompensasDataGridView.TabIndex = 23
        '
        'RECOMDataGridViewTextBoxColumn
        '
        Me.RECOMDataGridViewTextBoxColumn.DataPropertyName = "RECOM"
        Me.RECOMDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.RECOMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RECOMDataGridViewTextBoxColumn.Name = "RECOMDataGridViewTextBoxColumn"
        Me.RECOMDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECOMDataGridViewTextBoxColumn.Width = 70
        '
        'DESRECDataGridViewTextBoxColumn
        '
        Me.DESRECDataGridViewTextBoxColumn.DataPropertyName = "DESREC"
        Me.DESRECDataGridViewTextBoxColumn.HeaderText = "Recompensa"
        Me.DESRECDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESRECDataGridViewTextBoxColumn.Name = "DESRECDataGridViewTextBoxColumn"
        Me.DESRECDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESRECDataGridViewTextBoxColumn.Width = 200
        '
        'TIPFALDataGridViewTextBoxColumn
        '
        Me.TIPFALDataGridViewTextBoxColumn.DataPropertyName = "TIPFAL"
        Me.TIPFALDataGridViewTextBoxColumn.HeaderText = "Comisión"
        Me.TIPFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPFALDataGridViewTextBoxColumn.Name = "TIPFALDataGridViewTextBoxColumn"
        Me.TIPFALDataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPFALDataGridViewTextBoxColumn.Width = 125
        '
        'RecompensasTableAdapter
        '
        Me.RecompensasTableAdapter.ClearBeforeFill = True
        '
        'FrmRecompensas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1082, 553)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecompensasDataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "46")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRecompensas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recompensas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TxtComision As TextBox
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtRecompensa As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComisionTxt As TextBox
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents RecompensaTxt As TextBox
    Friend WithEvents IdText As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RecompensasDataGridView As DataGridView
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents RecompensasBindingSource As BindingSource
    Friend WithEvents RecompensasTableAdapter As DbCensosTableAdapters.recompensasTableAdapter
    Friend WithEvents RECOMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESRECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
