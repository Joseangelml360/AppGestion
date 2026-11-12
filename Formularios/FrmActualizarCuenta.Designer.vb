<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarCuenta
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
        Dim CUENTALabel As System.Windows.Forms.Label
        Dim TITULARLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.CUENTATextbox = New System.Windows.Forms.MaskedTextBox()
        Me.TitularesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCuotas = New AppGestion.DataSetCuotas()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TITULARTextBox = New System.Windows.Forms.TextBox()
        Me.TitularesDataGridView = New System.Windows.Forms.DataGridView()
        Me.TITULARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularesTableAdapter = New AppGestion.DataSetCuotasTableAdapters.TitularesTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CUENTALabel = New System.Windows.Forms.Label()
        TITULARLabel = New System.Windows.Forms.Label()
        CType(Me.TitularesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitularesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CUENTALabel
        '
        CUENTALabel.AutoSize = True
        CUENTALabel.Location = New System.Drawing.Point(695, 198)
        CUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CUENTALabel.Name = "CUENTALabel"
        CUENTALabel.Size = New System.Drawing.Size(57, 17)
        CUENTALabel.TabIndex = 18
        CUENTALabel.Text = "Cuenta:"
        '
        'TITULARLabel
        '
        TITULARLabel.AutoSize = True
        TITULARLabel.Location = New System.Drawing.Point(693, 166)
        TITULARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TITULARLabel.Name = "TITULARLabel"
        TITULARLabel.Size = New System.Drawing.Size(52, 17)
        TITULARLabel.TabIndex = 16
        TITULARLabel.Text = "Titular:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.Label3, "44")
        Me.HelpProvider1.SetHelpNavigator(Me.Label3, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Label3.Location = New System.Drawing.Point(683, 254)
        Me.Label3.Name = "Label3"
        Me.HelpProvider1.SetShowHelp(Me.Label3, True)
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Cta. Nueva:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(771, 251)
        Me.MaskedTextBox1.Mask = "ES00 0000 0000 0000 0000 0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(273, 22)
        Me.MaskedTextBox1.TabIndex = 26
        '
        'CUENTATextbox
        '
        Me.CUENTATextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitularesBindingSource, "CUENTA", True))
        Me.CUENTATextbox.Location = New System.Drawing.Point(771, 195)
        Me.CUENTATextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.CUENTATextbox.Mask = "ES00 0000 0000 0000 0000 0000"
        Me.CUENTATextbox.Name = "CUENTATextbox"
        Me.CUENTATextbox.ReadOnly = True
        Me.CUENTATextbox.Size = New System.Drawing.Size(273, 22)
        Me.CUENTATextbox.TabIndex = 25
        '
        'TitularesBindingSource
        '
        Me.TitularesBindingSource.DataMember = "Titulares"
        Me.TitularesBindingSource.DataSource = Me.DataSetCuotas
        '
        'DataSetCuotas
        '
        Me.DataSetCuotas.DataSetName = "DataSetCuotas"
        Me.DataSetCuotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(20, 117)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Todos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Mantenimiento Cuenta Bancaria"
        '
        'Button2
        '
        Me.Button2.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(887, 314)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(887, 30)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(258, 117)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 22)
        Me.TextBox1.TabIndex = 19
        '
        'TITULARTextBox
        '
        Me.TITULARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitularesBindingSource, "TITULAR", True))
        Me.TITULARTextBox.Location = New System.Drawing.Point(771, 163)
        Me.TITULARTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TITULARTextBox.Name = "TITULARTextBox"
        Me.TITULARTextBox.ReadOnly = True
        Me.TITULARTextBox.Size = New System.Drawing.Size(273, 22)
        Me.TITULARTextBox.TabIndex = 17
        '
        'TitularesDataGridView
        '
        Me.TitularesDataGridView.AllowUserToAddRows = False
        Me.TitularesDataGridView.AllowUserToDeleteRows = False
        Me.TitularesDataGridView.AllowUserToOrderColumns = True
        Me.TitularesDataGridView.AutoGenerateColumns = False
        Me.TitularesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TitularesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TITULARDataGridViewTextBoxColumn, Me.CUENTADataGridViewTextBoxColumn})
        Me.TitularesDataGridView.DataSource = Me.TitularesBindingSource
        Me.TitularesDataGridView.Location = New System.Drawing.Point(20, 165)
        Me.TitularesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TitularesDataGridView.Name = "TitularesDataGridView"
        Me.TitularesDataGridView.ReadOnly = True
        Me.TitularesDataGridView.RowHeadersWidth = 51
        Me.TitularesDataGridView.Size = New System.Drawing.Size(637, 358)
        Me.TitularesDataGridView.TabIndex = 15
        '
        'TITULARDataGridViewTextBoxColumn
        '
        Me.TITULARDataGridViewTextBoxColumn.DataPropertyName = "TITULAR"
        Me.TITULARDataGridViewTextBoxColumn.HeaderText = "TITULAR"
        Me.TITULARDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TITULARDataGridViewTextBoxColumn.Name = "TITULARDataGridViewTextBoxColumn"
        Me.TITULARDataGridViewTextBoxColumn.ReadOnly = True
        Me.TITULARDataGridViewTextBoxColumn.Width = 220
        '
        'CUENTADataGridViewTextBoxColumn
        '
        Me.CUENTADataGridViewTextBoxColumn.DataPropertyName = "CUENTA"
        Me.CUENTADataGridViewTextBoxColumn.HeaderText = "CUENTA"
        Me.CUENTADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CUENTADataGridViewTextBoxColumn.Name = "CUENTADataGridViewTextBoxColumn"
        Me.CUENTADataGridViewTextBoxColumn.ReadOnly = True
        Me.CUENTADataGridViewTextBoxColumn.Width = 170
        '
        'TitularesTableAdapter
        '
        Me.TitularesTableAdapter.ClearBeforeFill = True
        '
        'FrmActualizarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1059, 553)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.CUENTATextbox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(CUENTALabel)
        Me.Controls.Add(TITULARLabel)
        Me.Controls.Add(Me.TITULARTextBox)
        Me.Controls.Add(Me.TitularesDataGridView)
        Me.HelpProvider1.SetHelpKeyword(Me, "44")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmActualizarCuenta"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Cuenta de Titular"
        CType(Me.TitularesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitularesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents CUENTATextbox As MaskedTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TITULARTextBox As TextBox
    Friend WithEvents TitularesDataGridView As DataGridView
    Friend WithEvents DataSetCuotas As DataSetCuotas
    Friend WithEvents TitularesBindingSource As BindingSource
    Friend WithEvents TitularesTableAdapter As DataSetCuotasTableAdapters.TitularesTableAdapter
    Friend WithEvents TITULARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUENTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
