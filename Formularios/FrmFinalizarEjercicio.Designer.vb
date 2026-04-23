<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFinalizarEjercicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFinalizarEjercicio))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EstablecerValoresInicioCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.AsignarCuotaNuevaCheckBox = New System.Windows.Forms.CheckBox()
        Me.AsignarDtoNuevoCheckBox = New System.Windows.Forms.CheckBox()
        Me.AsignarValoresFalleroCheckBox = New System.Windows.Forms.CheckBox()
        Me.AsignarCambioComisionJuvCheckBox = New System.Windows.Forms.CheckBox()
        Me.AsignarCambioComisiónInfCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ChkCopiarCenso = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ChkEliminarRemesa = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ChkExportRemesas = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.HistorfaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorfaTableAdapter = New AppGestion.DataSet1TableAdapters.historfaTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSet1TableAdapters.TableAdapterManager()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox3.SuspendLayout()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.EstablecerValoresInicioCheckBox)
        Me.GroupBox3.Controls.Add(Me.AsignarCuotaNuevaCheckBox)
        Me.GroupBox3.Controls.Add(Me.AsignarDtoNuevoCheckBox)
        Me.GroupBox3.Controls.Add(Me.AsignarValoresFalleroCheckBox)
        Me.GroupBox3.Controls.Add(Me.AsignarCambioComisionJuvCheckBox)
        Me.GroupBox3.Controls.Add(Me.AsignarCambioComisiónInfCheckBox)
        Me.GroupBox3.Location = New System.Drawing.Point(761, 207)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(47, 366)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        '
        'EstablecerValoresInicioCheckBox
        '
        Me.EstablecerValoresInicioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "EstablecerValoresInicio", True))
        Me.EstablecerValoresInicioCheckBox.Location = New System.Drawing.Point(8, 27)
        Me.EstablecerValoresInicioCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EstablecerValoresInicioCheckBox.Name = "EstablecerValoresInicioCheckBox"
        Me.EstablecerValoresInicioCheckBox.Size = New System.Drawing.Size(28, 30)
        Me.EstablecerValoresInicioCheckBox.TabIndex = 37
        Me.EstablecerValoresInicioCheckBox.Text = "CheckBox1"
        Me.EstablecerValoresInicioCheckBox.UseVisualStyleBackColor = True
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsignarCuotaNuevaCheckBox
        '
        Me.AsignarCuotaNuevaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarCuotaNueva", True))
        Me.AsignarCuotaNuevaCheckBox.Location = New System.Drawing.Point(8, 205)
        Me.AsignarCuotaNuevaCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarCuotaNuevaCheckBox.Name = "AsignarCuotaNuevaCheckBox"
        Me.AsignarCuotaNuevaCheckBox.Size = New System.Drawing.Size(28, 30)
        Me.AsignarCuotaNuevaCheckBox.TabIndex = 28
        Me.AsignarCuotaNuevaCheckBox.UseVisualStyleBackColor = True
        '
        'AsignarDtoNuevoCheckBox
        '
        Me.AsignarDtoNuevoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarDtoNuevo", True))
        Me.AsignarDtoNuevoCheckBox.Location = New System.Drawing.Point(8, 267)
        Me.AsignarDtoNuevoCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarDtoNuevoCheckBox.Name = "AsignarDtoNuevoCheckBox"
        Me.AsignarDtoNuevoCheckBox.Size = New System.Drawing.Size(28, 30)
        Me.AsignarDtoNuevoCheckBox.TabIndex = 29
        Me.AsignarDtoNuevoCheckBox.UseVisualStyleBackColor = True
        '
        'AsignarValoresFalleroCheckBox
        '
        Me.AsignarValoresFalleroCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarValoresFallero", True))
        Me.AsignarValoresFalleroCheckBox.Location = New System.Drawing.Point(8, 324)
        Me.AsignarValoresFalleroCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarValoresFalleroCheckBox.Name = "AsignarValoresFalleroCheckBox"
        Me.AsignarValoresFalleroCheckBox.Size = New System.Drawing.Size(28, 30)
        Me.AsignarValoresFalleroCheckBox.TabIndex = 30
        Me.AsignarValoresFalleroCheckBox.UseVisualStyleBackColor = True
        '
        'AsignarCambioComisionJuvCheckBox
        '
        Me.AsignarCambioComisionJuvCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarCambioComisionJuv", True))
        Me.AsignarCambioComisionJuvCheckBox.Location = New System.Drawing.Point(8, 145)
        Me.AsignarCambioComisionJuvCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarCambioComisionJuvCheckBox.Name = "AsignarCambioComisionJuvCheckBox"
        Me.AsignarCambioComisionJuvCheckBox.Size = New System.Drawing.Size(28, 30)
        Me.AsignarCambioComisionJuvCheckBox.TabIndex = 36
        Me.AsignarCambioComisionJuvCheckBox.UseVisualStyleBackColor = True
        '
        'AsignarCambioComisiónInfCheckBox
        '
        Me.AsignarCambioComisiónInfCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "AsignarCambioComisionInf", True))
        Me.AsignarCambioComisiónInfCheckBox.Location = New System.Drawing.Point(8, 83)
        Me.AsignarCambioComisiónInfCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignarCambioComisiónInfCheckBox.Name = "AsignarCambioComisiónInfCheckBox"
        Me.AsignarCambioComisiónInfCheckBox.Size = New System.Drawing.Size(28, 30)
        Me.AsignarCambioComisiónInfCheckBox.TabIndex = 35
        Me.AsignarCambioComisiónInfCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(64, 437)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 25)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Finalizado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 477)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 85)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Finalizar Ejercicio/Iniciar Nuevo Ejercicio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ha concluido con éxito" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ya se pueden" &
    " iniciar altas y bajas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ya se puede asignar beneficios Lotería" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ya se puede gene" &
    "rar primera remesa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.ChkCopiarCenso)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ChkEliminarRemesa)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ChkExportRemesas)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 207)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(337, 202)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(225, 158)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(225, 96)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(225, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(17, 154)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(185, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Añadir Censo a Historial"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ChkCopiarCenso
        '
        Me.ChkCopiarCenso.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "CopiarCensoAHistorial", True))
        Me.ChkCopiarCenso.Location = New System.Drawing.Point(259, 158)
        Me.ChkCopiarCenso.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkCopiarCenso.Name = "ChkCopiarCenso"
        Me.ChkCopiarCenso.Size = New System.Drawing.Size(47, 30)
        Me.ChkCopiarCenso.TabIndex = 15
        Me.ChkCopiarCenso.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(17, 92)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Vaciar tabla de Remesas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ChkEliminarRemesa
        '
        Me.ChkEliminarRemesa.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "EliminarRemesa", True))
        Me.ChkEliminarRemesa.Location = New System.Drawing.Point(259, 96)
        Me.ChkEliminarRemesa.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkEliminarRemesa.Name = "ChkEliminarRemesa"
        Me.ChkEliminarRemesa.Size = New System.Drawing.Size(33, 30)
        Me.ChkEliminarRemesa.TabIndex = 13
        Me.ChkEliminarRemesa.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exportar Remesas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ChkExportRemesas
        '
        Me.ChkExportRemesas.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "ExportRemesas", True))
        Me.ChkExportRemesas.Location = New System.Drawing.Point(259, 34)
        Me.ChkExportRemesas.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkExportRemesas.Name = "ChkExportRemesas"
        Me.ChkExportRemesas.Size = New System.Drawing.Size(47, 30)
        Me.ChkExportRemesas.TabIndex = 11
        Me.ChkExportRemesas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox9)
        Me.GroupBox2.Controls.Add(Me.PictureBox8)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Location = New System.Drawing.Point(517, 207)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(243, 366)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(209, 325)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 34
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(209, 267)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 33
        Me.PictureBox8.TabStop = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(16, 322)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(185, 27)
        Me.Button11.TabIndex = 32
        Me.Button11.Text = "Actualizar registro Falleros"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(16, 265)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(185, 27)
        Me.Button10.TabIndex = 31
        Me.Button10.Text = "Actualizar Descuentos"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(209, 207)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 27
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(209, 146)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(209, 84)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 25
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(209, 27)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(16, 204)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(185, 27)
        Me.Button9.TabIndex = 23
        Me.Button9.Text = "Asignar Cuotas"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(16, 143)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(185, 27)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Pase Juvenil-Mayor"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(16, 81)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(185, 27)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Pase Infantil-Juvenil"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(16, 27)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(185, 27)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Iniciar Ejercicio"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Fase 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(528, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fase 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(481, 85)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 29)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Finalizar Ejercicio"
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'HistorfaBindingSource
        '
        Me.HistorfaBindingSource.DataMember = "historfa"
        Me.HistorfaBindingSource.DataSource = Me.DataSet1
        '
        'HistorfaTableAdapter
        '
        Me.HistorfaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargoTableAdapter = Nothing
        Me.TableAdapterManager.detalles_de_remesaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Me.EstadoTableAdapter
        Me.TableAdapterManager.Fallero1TableAdapter = Nothing
        Me.TableAdapterManager.FalleroDetalleRemesaTableAdapter = Nothing
        Me.TableAdapterManager.historfaTableAdapter = Me.HistorfaTableAdapter
        Me.TableAdapterManager.recompensasTableAdapter = Nothing
        Me.TableAdapterManager.remesasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.AppGestion.My.Resources.Resources._new
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(690, 99)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(118, 37)
        Me.BtnNuevo.TabIndex = 54
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.AppGestion.My.Resources.Resources.Finalizar
        Me.PictureBox10.Location = New System.Drawing.Point(65, 477)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(68, 80)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 48
        Me.PictureBox10.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(695, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 37)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmFinalizarEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(857, 603)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "40")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFinalizarEjercicio"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finalizar/Iniciar Ejercicio"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorfaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EstablecerValoresInicioCheckBox As CheckBox
    Friend WithEvents AsignarCuotaNuevaCheckBox As CheckBox
    Friend WithEvents AsignarDtoNuevoCheckBox As CheckBox
    Friend WithEvents AsignarValoresFalleroCheckBox As CheckBox
    Friend WithEvents AsignarCambioComisionJuvCheckBox As CheckBox
    Friend WithEvents AsignarCambioComisiónInfCheckBox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ChkCopiarCenso As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ChkEliminarRemesa As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ChkExportRemesas As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents HistorfaBindingSource As BindingSource
    Friend WithEvents HistorfaTableAdapter As DataSet1TableAdapters.historfaTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
