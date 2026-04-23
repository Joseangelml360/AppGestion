<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditarLineaRecomp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarLineaRecomp))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.RecompensasejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.TxtRecAgrup = New System.Windows.Forms.TextBox()
        Me.TxtRecJCF = New System.Windows.Forms.TextBox()
        Me.TxtRecFalla = New System.Windows.Forms.TextBox()
        Me.TxtApeliidos = New System.Windows.Forms.TextBox()
        Me.TxtCodJCF = New System.Windows.Forms.TextBox()
        Me.TxtCodFal = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.RecompensasejercicioTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasejercicioTableAdapter()
        Me.CboRecFalla = New System.Windows.Forms.ComboBox()
        Me.RecompensasFallaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCensos = New AppGestion.DbCensos()
        Me.RecompensasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecompensasTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasTableAdapter()
        Me.CboRecJCF = New System.Windows.Forms.ComboBox()
        Me.RecompensasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboRecAgrup = New System.Windows.Forms.ComboBox()
        Me.RecompensasAgrupacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecompensasTableAdapter1 = New AppGestion.DbCensosTableAdapters.recompensasTableAdapter()
        Me.RecompensasFallaTableAdapter = New AppGestion.DbCensosTableAdapters.RecompensasFallaTableAdapter()
        Me.RecompensasAgrupacionTableAdapter = New AppGestion.DbCensosTableAdapters.RecompensasAgrupacionTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasFallaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecompensasAgrupacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(350, 25)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Edición de recompensas de Fallero"
        '
        'TxtNombre
        '
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasejercicioBindingSource, "NOMBRE", True))
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(85, 73)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'RecompensasejercicioBindingSource
        '
        Me.RecompensasejercicioBindingSource.DataMember = "recompensasejercicio"
        Me.RecompensasejercicioBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtRecAgrup
        '
        Me.TxtRecAgrup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasejercicioBindingSource, "RECAGRUP", True))
        Me.TxtRecAgrup.Location = New System.Drawing.Point(114, 206)
        Me.TxtRecAgrup.Name = "TxtRecAgrup"
        Me.TxtRecAgrup.Size = New System.Drawing.Size(32, 22)
        Me.TxtRecAgrup.TabIndex = 2
        '
        'TxtRecJCF
        '
        Me.TxtRecJCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasejercicioBindingSource, "RECJF", True))
        Me.TxtRecJCF.Location = New System.Drawing.Point(114, 144)
        Me.TxtRecJCF.Name = "TxtRecJCF"
        Me.TxtRecJCF.Size = New System.Drawing.Size(32, 22)
        Me.TxtRecJCF.TabIndex = 3
        '
        'TxtRecFalla
        '
        Me.TxtRecFalla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasejercicioBindingSource, "RECFALLA", True))
        Me.TxtRecFalla.Location = New System.Drawing.Point(114, 174)
        Me.TxtRecFalla.Name = "TxtRecFalla"
        Me.TxtRecFalla.Size = New System.Drawing.Size(32, 22)
        Me.TxtRecFalla.TabIndex = 4
        '
        'TxtApeliidos
        '
        Me.TxtApeliidos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasejercicioBindingSource, "APELLIDOS", True))
        Me.TxtApeliidos.Enabled = False
        Me.TxtApeliidos.Location = New System.Drawing.Point(201, 73)
        Me.TxtApeliidos.Name = "TxtApeliidos"
        Me.TxtApeliidos.Size = New System.Drawing.Size(167, 22)
        Me.TxtApeliidos.TabIndex = 5
        '
        'TxtCodJCF
        '
        Me.TxtCodJCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasejercicioBindingSource, "CODIGO", True))
        Me.TxtCodJCF.Enabled = False
        Me.TxtCodJCF.Location = New System.Drawing.Point(390, 73)
        Me.TxtCodJCF.Name = "TxtCodJCF"
        Me.TxtCodJCF.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodJCF.TabIndex = 6
        '
        'TxtCodFal
        '
        Me.TxtCodFal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecompensasejercicioBindingSource, "CODFALLA", True))
        Me.TxtCodFal.Enabled = False
        Me.TxtCodFal.Location = New System.Drawing.Point(17, 73)
        Me.TxtCodFal.Name = "TxtCodFal"
        Me.TxtCodFal.Size = New System.Drawing.Size(62, 22)
        Me.TxtCodFal.TabIndex = 7
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AppGestion.My.Resources.Resources.database_save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(639, 220)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(149, 37)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.Text = "Guardar cambios"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(705, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(83, 45)
        Me.BtnSalir.TabIndex = 9
        Me.BtnSalir.Text = "Volver"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'RecompensasejercicioTableAdapter
        '
        Me.RecompensasejercicioTableAdapter.ClearBeforeFill = True
        '
        'CboRecFalla
        '
        Me.CboRecFalla.DataSource = Me.RecompensasFallaBindingSource
        Me.CboRecFalla.DisplayMember = "DESREC"
        Me.CboRecFalla.FormattingEnabled = True
        Me.CboRecFalla.Location = New System.Drawing.Point(152, 174)
        Me.CboRecFalla.Name = "CboRecFalla"
        Me.CboRecFalla.Size = New System.Drawing.Size(170, 24)
        Me.CboRecFalla.TabIndex = 10
        Me.CboRecFalla.ValueMember = "RECOM"
        '
        'RecompensasFallaBindingSource
        '
        Me.RecompensasFallaBindingSource.DataMember = "RecompensasFalla"
        Me.RecompensasFallaBindingSource.DataSource = Me.DbCensos
        '
        'DbCensos
        '
        Me.DbCensos.DataSetName = "DbCensos"
        Me.DbCensos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecompensasBindingSource
        '
        Me.RecompensasBindingSource.DataMember = "recompensas"
        Me.RecompensasBindingSource.DataSource = Me.DataSet1
        '
        'RecompensasTableAdapter
        '
        Me.RecompensasTableAdapter.ClearBeforeFill = True
        '
        'CboRecJCF
        '
        Me.CboRecJCF.DataSource = Me.RecompensasBindingSource1
        Me.CboRecJCF.DisplayMember = "DESREC"
        Me.CboRecJCF.FormattingEnabled = True
        Me.CboRecJCF.Location = New System.Drawing.Point(152, 144)
        Me.CboRecJCF.Name = "CboRecJCF"
        Me.CboRecJCF.Size = New System.Drawing.Size(170, 24)
        Me.CboRecJCF.TabIndex = 11
        Me.CboRecJCF.ValueMember = "RECOM"
        '
        'RecompensasBindingSource1
        '
        Me.RecompensasBindingSource1.DataMember = "recompensas"
        Me.RecompensasBindingSource1.DataSource = Me.DbCensos
        '
        'CboRecAgrup
        '
        Me.CboRecAgrup.DataSource = Me.RecompensasAgrupacionBindingSource
        Me.CboRecAgrup.DisplayMember = "DESREC"
        Me.CboRecAgrup.FormattingEnabled = True
        Me.CboRecAgrup.Location = New System.Drawing.Point(152, 204)
        Me.CboRecAgrup.Name = "CboRecAgrup"
        Me.CboRecAgrup.Size = New System.Drawing.Size(170, 24)
        Me.CboRecAgrup.TabIndex = 12
        Me.CboRecAgrup.ValueMember = "RECOM"
        '
        'RecompensasAgrupacionBindingSource
        '
        Me.RecompensasAgrupacionBindingSource.DataMember = "RecompensasAgrupacion"
        Me.RecompensasAgrupacionBindingSource.DataSource = Me.DbCensos
        '
        'RecompensasTableAdapter1
        '
        Me.RecompensasTableAdapter1.ClearBeforeFill = True
        '
        'RecompensasFallaTableAdapter
        '
        Me.RecompensasFallaTableAdapter.ClearBeforeFill = True
        '
        'RecompensasAgrupacionTableAdapter
        '
        Me.RecompensasAgrupacionTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(387, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Código JCF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "JCF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Falla"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Agrupación"
        '
        'FrmEditarLineaRecomp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 271)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboRecAgrup)
        Me.Controls.Add(Me.CboRecJCF)
        Me.Controls.Add(Me.CboRecFalla)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtCodFal)
        Me.Controls.Add(Me.TxtCodJCF)
        Me.Controls.Add(Me.TxtApeliidos)
        Me.Controls.Add(Me.TxtRecFalla)
        Me.Controls.Add(Me.TxtRecJCF)
        Me.Controls.Add(Me.TxtRecAgrup)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditarLineaRecomp"
        Me.Text = "Editar Recompensas de Fallero"
        CType(Me.RecompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasFallaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCensos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecompensasAgrupacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtRecAgrup As TextBox
    Friend WithEvents TxtRecJCF As TextBox
    Friend WithEvents TxtRecFalla As TextBox
    Friend WithEvents TxtApeliidos As TextBox
    Friend WithEvents TxtCodJCF As TextBox
    Friend WithEvents TxtCodFal As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents RecompensasejercicioBindingSource As BindingSource
    Friend WithEvents RecompensasejercicioTableAdapter As DataSet1TableAdapters.recompensasejercicioTableAdapter
    Friend WithEvents CboRecFalla As ComboBox
    Friend WithEvents RecompensasBindingSource As BindingSource
    Friend WithEvents RecompensasTableAdapter As DataSet1TableAdapters.recompensasTableAdapter
    Friend WithEvents CboRecJCF As ComboBox
    Friend WithEvents CboRecAgrup As ComboBox
    Friend WithEvents DbCensos As DbCensos
    Friend WithEvents RecompensasBindingSource1 As BindingSource
    Friend WithEvents RecompensasTableAdapter1 As DbCensosTableAdapters.recompensasTableAdapter
    Friend WithEvents RecompensasFallaBindingSource As BindingSource
    Friend WithEvents RecompensasFallaTableAdapter As DbCensosTableAdapters.RecompensasFallaTableAdapter
    Friend WithEvents RecompensasAgrupacionBindingSource As BindingSource
    Friend WithEvents RecompensasAgrupacionTableAdapter As DbCensosTableAdapters.RecompensasAgrupacionTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
