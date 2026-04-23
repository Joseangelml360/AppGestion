<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargos
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
        Dim CargoLbl As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim IDlabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtDescrip = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.DescripTxt = New System.Windows.Forms.TextBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.IdText = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CARGODataGridView = New System.Windows.Forms.DataGridView()
        Me.CARGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoTableAdapter = New AppGestion.DbCensosTableAdapters.cargoTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CargoLbl = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        IDlabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARGODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CargoLbl
        '
        CargoLbl.AutoSize = True
        CargoLbl.Location = New System.Drawing.Point(19, 65)
        CargoLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CargoLbl.Name = "CargoLbl"
        CargoLbl.Size = New System.Drawing.Size(86, 17)
        CargoLbl.TabIndex = 8
        CargoLbl.Text = "Descripción:"
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
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(19, 65)
        CargoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(86, 17)
        CargoLabel.TabIndex = 8
        CargoLabel.Text = "Descripción:"
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
        Me.GroupBox2.Controls.Add(Me.BtnAddNew)
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(CargoLbl)
        Me.GroupBox2.Controls.Add(Me.TxtDescrip)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Me.TxtID)
        Me.GroupBox2.Location = New System.Drawing.Point(508, 312)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(453, 175)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(271, 114)
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
        Me.BtnCancel.Location = New System.Drawing.Point(73, 114)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(157, 46)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TxtDescrip
        '
        Me.TxtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescrip.Location = New System.Drawing.Point(115, 62)
        Me.TxtDescrip.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(312, 22)
        Me.TxtDescrip.TabIndex = 9
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
        Me.GroupBox1.Controls.Add(Me.BtnAñadir)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(CargoLabel)
        Me.GroupBox1.Controls.Add(Me.DescripTxt)
        Me.GroupBox1.Controls.Add(IDlabel)
        Me.GroupBox1.Controls.Add(Me.IdText)
        Me.GroupBox1.Location = New System.Drawing.Point(508, 93)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 186)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(271, 116)
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
        Me.BtnActualizar.Location = New System.Drawing.Point(73, 116)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(157, 46)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'DescripTxt
        '
        Me.DescripTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargoBindingSource, "DESCRIP", True))
        Me.DescripTxt.Location = New System.Drawing.Point(115, 62)
        Me.DescripTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripTxt.Name = "DescripTxt"
        Me.DescripTxt.Size = New System.Drawing.Size(312, 22)
        Me.DescripTxt.TabIndex = 9
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdText
        '
        Me.IdText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargoBindingSource, "CARGO", True))
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
        Me.BtnSalir.Location = New System.Drawing.Point(804, 16)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 46)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Mantenimiento Cargos"
        '
        'CARGODataGridView
        '
        Me.CARGODataGridView.AllowUserToAddRows = False
        Me.CARGODataGridView.AllowUserToDeleteRows = False
        Me.CARGODataGridView.AllowUserToOrderColumns = True
        Me.CARGODataGridView.AutoGenerateColumns = False
        Me.CARGODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CARGODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CARGODataGridViewTextBoxColumn, Me.DESCRIPDataGridViewTextBoxColumn})
        Me.CARGODataGridView.DataSource = Me.CargoBindingSource
        Me.CARGODataGridView.Location = New System.Drawing.Point(16, 93)
        Me.CARGODataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CARGODataGridView.Name = "CARGODataGridView"
        Me.CARGODataGridView.ReadOnly = True
        Me.CARGODataGridView.RowHeadersWidth = 51
        Me.CARGODataGridView.Size = New System.Drawing.Size(465, 444)
        Me.CARGODataGridView.TabIndex = 27
        '
        'CARGODataGridViewTextBoxColumn
        '
        Me.CARGODataGridViewTextBoxColumn.DataPropertyName = "CARGO"
        Me.CARGODataGridViewTextBoxColumn.HeaderText = "Id Cargo"
        Me.CARGODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CARGODataGridViewTextBoxColumn.Name = "CARGODataGridViewTextBoxColumn"
        Me.CARGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CARGODataGridViewTextBoxColumn.Width = 125
        '
        'DESCRIPDataGridViewTextBoxColumn
        '
        Me.DESCRIPDataGridViewTextBoxColumn.DataPropertyName = "DESCRIP"
        Me.DESCRIPDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DESCRIPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESCRIPDataGridViewTextBoxColumn.Name = "DESCRIPDataGridViewTextBoxColumn"
        Me.DESCRIPDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPDataGridViewTextBoxColumn.Width = 200
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'FrmCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(977, 553)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CARGODataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "47")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmCargos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Cargos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARGODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtDescrip As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents DescripTxt As TextBox
    Friend WithEvents IdText As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CARGODataGridView As DataGridView
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As DbCensosTableAdapters.cargoTableAdapter
    Friend WithEvents CARGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
