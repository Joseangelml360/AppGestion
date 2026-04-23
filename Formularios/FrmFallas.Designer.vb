<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFallas
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
        Dim DESFALLabel As System.Windows.Forms.Label
        Dim NUMFALLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFallas))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TxtDesFal = New System.Windows.Forms.TextBox()
        Me.TxtNumFal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DESFALTextBox = New System.Windows.Forms.TextBox()
        Me.FallasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.NUMFALTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FALLASDataGridView = New System.Windows.Forms.DataGridView()
        Me.NUMFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESFALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FallasTableAdapter = New AppGestion.DbCensosTableAdapters.fallasTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        DESFALLabel = New System.Windows.Forms.Label()
        NUMFALLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FALLASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(11, 54)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(54, 17)
        Label3.TabIndex = 15
        Label3.Text = "FALLA:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(37, 22)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(27, 17)
        Label4.TabIndex = 13
        Label4.Text = "Nº:"
        '
        'DESFALLabel
        '
        DESFALLabel.AutoSize = True
        DESFALLabel.Location = New System.Drawing.Point(9, 65)
        DESFALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DESFALLabel.Name = "DESFALLabel"
        DESFALLabel.Size = New System.Drawing.Size(54, 17)
        DESFALLabel.TabIndex = 8
        DESFALLabel.Text = "FALLA:"
        '
        'NUMFALLabel
        '
        NUMFALLabel.AutoSize = True
        NUMFALLabel.Location = New System.Drawing.Point(36, 33)
        NUMFALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NUMFALLabel.Name = "NUMFALLabel"
        NUMFALLabel.Size = New System.Drawing.Size(27, 17)
        NUMFALLabel.TabIndex = 6
        NUMFALLabel.Text = "Nº:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.TxtDesFal)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.TxtNumFal)
        Me.GroupBox2.Location = New System.Drawing.Point(623, 358)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(453, 176)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(75, 103)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(157, 46)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(272, 103)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(157, 46)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Añadir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TxtDesFal
        '
        Me.TxtDesFal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesFal.Location = New System.Drawing.Point(75, 50)
        Me.TxtDesFal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDesFal.Name = "TxtDesFal"
        Me.TxtDesFal.Size = New System.Drawing.Size(353, 22)
        Me.TxtDesFal.TabIndex = 16
        '
        'TxtNumFal
        '
        Me.TxtNumFal.Location = New System.Drawing.Point(75, 18)
        Me.TxtNumFal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumFal.Name = "TxtNumFal"
        Me.TxtNumFal.Size = New System.Drawing.Size(132, 22)
        Me.TxtNumFal.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(DESFALLabel)
        Me.GroupBox1.Controls.Add(Me.DESFALTextBox)
        Me.GroupBox1.Controls.Add(NUMFALLabel)
        Me.GroupBox1.Controls.Add(Me.NUMFALTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(623, 93)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 187)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Image = Global.AppGestion.My.Resources.Resources.InsertFila
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(271, 117)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 46)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Añadir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(73, 117)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DESFALTextBox
        '
        Me.DESFALTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DESFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FallasBindingSource, "DESFAL", True))
        Me.DESFALTextBox.Location = New System.Drawing.Point(73, 62)
        Me.DESFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESFALTextBox.Name = "DESFALTextBox"
        Me.DESFALTextBox.Size = New System.Drawing.Size(353, 22)
        Me.DESFALTextBox.TabIndex = 9
        '
        'FallasBindingSource
        '
        Me.FallasBindingSource.DataMember = "fallas"
        Me.FallasBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NUMFALTextBox
        '
        Me.NUMFALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FallasBindingSource, "NUMFAL", True))
        Me.NUMFALTextBox.Location = New System.Drawing.Point(73, 30)
        Me.NUMFALTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NUMFALTextBox.Name = "NUMFALTextBox"
        Me.NUMFALTextBox.Size = New System.Drawing.Size(132, 22)
        Me.NUMFALTextBox.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(919, 18)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 46)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(228, 82)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(379, 22)
        Me.TextBox1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 77)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Todas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Mantenimiento Fallas"
        '
        'FALLASDataGridView
        '
        Me.FALLASDataGridView.AllowUserToAddRows = False
        Me.FALLASDataGridView.AllowUserToDeleteRows = False
        Me.FALLASDataGridView.AllowUserToOrderColumns = True
        Me.FALLASDataGridView.AutoGenerateColumns = False
        Me.FALLASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FALLASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMFALDataGridViewTextBoxColumn, Me.DESFALDataGridViewTextBoxColumn})
        Me.FALLASDataGridView.DataSource = Me.FallasBindingSource
        Me.FALLASDataGridView.Location = New System.Drawing.Point(16, 123)
        Me.FALLASDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.FALLASDataGridView.Name = "FALLASDataGridView"
        Me.FALLASDataGridView.ReadOnly = True
        Me.FALLASDataGridView.RowHeadersWidth = 51
        Me.FALLASDataGridView.Size = New System.Drawing.Size(592, 411)
        Me.FALLASDataGridView.TabIndex = 20
        '
        'NUMFALDataGridViewTextBoxColumn
        '
        Me.NUMFALDataGridViewTextBoxColumn.DataPropertyName = "NUMFAL"
        Me.NUMFALDataGridViewTextBoxColumn.HeaderText = "Id Falla"
        Me.NUMFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMFALDataGridViewTextBoxColumn.Name = "NUMFALDataGridViewTextBoxColumn"
        Me.NUMFALDataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMFALDataGridViewTextBoxColumn.Width = 125
        '
        'DESFALDataGridViewTextBoxColumn
        '
        Me.DESFALDataGridViewTextBoxColumn.DataPropertyName = "DESFAL"
        Me.DESFALDataGridViewTextBoxColumn.HeaderText = "Nombre Falla"
        Me.DESFALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESFALDataGridViewTextBoxColumn.Name = "DESFALDataGridViewTextBoxColumn"
        Me.DESFALDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESFALDataGridViewTextBoxColumn.Width = 300
        '
        'FallasTableAdapter
        '
        Me.FallasTableAdapter.ClearBeforeFill = True
        '
        'FrmFallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1092, 553)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FALLASDataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "45")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFallas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fallas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FallasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FALLASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TxtDesFal As TextBox
    Friend WithEvents TxtNumFal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DESFALTextBox As TextBox
    Friend WithEvents NUMFALTextBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FALLASDataGridView As DataGridView
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents FallasBindingSource As BindingSource
    Friend WithEvents FallasTableAdapter As DbCensosTableAdapters.fallasTableAdapter
    Friend WithEvents NUMFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESFALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
