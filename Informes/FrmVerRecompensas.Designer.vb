<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerRecompensas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerRecompensas))
        Me.recompensasejercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbtMayores = New System.Windows.Forms.RadioButton()
        Me.RbtInfantiles = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbtFallaJCF = New System.Windows.Forms.RadioButton()
        Me.RbtJCF = New System.Windows.Forms.RadioButton()
        Me.RbtFalla = New System.Windows.Forms.RadioButton()
        Me.BtnBorrarFiltro = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblF6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblF8 = New System.Windows.Forms.Label()
        Me.LblF4 = New System.Windows.Forms.Label()
        Me.LblF3 = New System.Windows.Forms.Label()
        Me.LblF2 = New System.Windows.Forms.Label()
        Me.LblF1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblRecsFalla = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblJ13 = New System.Windows.Forms.Label()
        Me.LblJ12 = New System.Windows.Forms.Label()
        Me.LblJ11 = New System.Windows.Forms.Label()
        Me.LblJ5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblJ4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblJ3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblJ2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblJ1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblRecsJCF = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblFiltro = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.recompensasejercicioTableAdapter = New AppGestion.DataSet1TableAdapters.recompensasejercicioTableAdapter()
        CType(Me.recompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'recompensasejercicioBindingSource
        '
        Me.recompensasejercicioBindingSource.DataMember = "recompensasejercicio"
        Me.recompensasejercicioBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de Recompensas del ejercicio"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.Location = New System.Drawing.Point(1296, 9)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(145, 40)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Cerrar Listado"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.RbtMayores)
        Me.GroupBox4.Controls.Add(Me.RbtInfantiles)
        Me.GroupBox4.Location = New System.Drawing.Point(1187, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 45)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'RbtMayores
        '
        Me.RbtMayores.AutoSize = True
        Me.RbtMayores.Location = New System.Drawing.Point(6, 16)
        Me.RbtMayores.Name = "RbtMayores"
        Me.RbtMayores.Size = New System.Drawing.Size(83, 21)
        Me.RbtMayores.TabIndex = 18
        Me.RbtMayores.TabStop = True
        Me.RbtMayores.Text = "Mayores"
        Me.RbtMayores.UseVisualStyleBackColor = True
        '
        'RbtInfantiles
        '
        Me.RbtInfantiles.AutoSize = True
        Me.RbtInfantiles.Location = New System.Drawing.Point(169, 16)
        Me.RbtInfantiles.Name = "RbtInfantiles"
        Me.RbtInfantiles.Size = New System.Drawing.Size(85, 21)
        Me.RbtInfantiles.TabIndex = 19
        Me.RbtInfantiles.TabStop = True
        Me.RbtInfantiles.Text = "Infantiles"
        Me.RbtInfantiles.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.RbtFallaJCF)
        Me.GroupBox3.Controls.Add(Me.RbtJCF)
        Me.GroupBox3.Controls.Add(Me.RbtFalla)
        Me.GroupBox3.Location = New System.Drawing.Point(1187, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 36)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'RbtFallaJCF
        '
        Me.RbtFallaJCF.AutoSize = True
        Me.RbtFallaJCF.Location = New System.Drawing.Point(170, 14)
        Me.RbtFallaJCF.Name = "RbtFallaJCF"
        Me.RbtFallaJCF.Size = New System.Drawing.Size(87, 21)
        Me.RbtFallaJCF.TabIndex = 20
        Me.RbtFallaJCF.TabStop = True
        Me.RbtFallaJCF.Text = "JCF/Falla"
        Me.RbtFallaJCF.UseVisualStyleBackColor = True
        '
        'RbtJCF
        '
        Me.RbtJCF.AutoSize = True
        Me.RbtJCF.Location = New System.Drawing.Point(6, 16)
        Me.RbtJCF.Name = "RbtJCF"
        Me.RbtJCF.Size = New System.Drawing.Size(53, 21)
        Me.RbtJCF.TabIndex = 18
        Me.RbtJCF.TabStop = True
        Me.RbtJCF.Text = "JCF"
        Me.RbtJCF.UseVisualStyleBackColor = True
        '
        'RbtFalla
        '
        Me.RbtFalla.AutoSize = True
        Me.RbtFalla.Location = New System.Drawing.Point(80, 15)
        Me.RbtFalla.Name = "RbtFalla"
        Me.RbtFalla.Size = New System.Drawing.Size(59, 21)
        Me.RbtFalla.TabIndex = 19
        Me.RbtFalla.TabStop = True
        Me.RbtFalla.Text = "Falla"
        Me.RbtFalla.UseVisualStyleBackColor = True
        '
        'BtnBorrarFiltro
        '
        Me.BtnBorrarFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrarFiltro.Location = New System.Drawing.Point(1319, 145)
        Me.BtnBorrarFiltro.Name = "BtnBorrarFiltro"
        Me.BtnBorrarFiltro.Size = New System.Drawing.Size(98, 31)
        Me.BtnBorrarFiltro.TabIndex = 26
        Me.BtnBorrarFiltro.Text = "Borrar filtro"
        Me.BtnBorrarFiltro.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Location = New System.Drawing.Point(1203, 145)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(93, 31)
        Me.BtnFiltrar.TabIndex = 25
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblF6)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.LblF8)
        Me.GroupBox2.Controls.Add(Me.LblF4)
        Me.GroupBox2.Controls.Add(Me.LblF3)
        Me.GroupBox2.Controls.Add(Me.LblF2)
        Me.GroupBox2.Controls.Add(Me.LblF1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LblRecsFalla)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(711, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 111)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'LblF6
        '
        Me.LblF6.AutoSize = True
        Me.LblF6.Location = New System.Drawing.Point(388, 81)
        Me.LblF6.Name = "LblF6"
        Me.LblF6.Size = New System.Drawing.Size(43, 17)
        Me.LblF6.TabIndex = 29
        Me.LblF6.Text = "LblF6"
        Me.LblF6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(275, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 17)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Joia"
        '
        'LblF8
        '
        Me.LblF8.AutoSize = True
        Me.LblF8.Location = New System.Drawing.Point(388, 56)
        Me.LblF8.Name = "LblF8"
        Me.LblF8.Size = New System.Drawing.Size(43, 17)
        Me.LblF8.TabIndex = 27
        Me.LblF8.Text = "LblF8"
        Me.LblF8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF4
        '
        Me.LblF4.AutoSize = True
        Me.LblF4.Location = New System.Drawing.Point(388, 29)
        Me.LblF4.Name = "LblF4"
        Me.LblF4.Size = New System.Drawing.Size(43, 17)
        Me.LblF4.TabIndex = 26
        Me.LblF4.Text = "LblF4"
        Me.LblF4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF3
        '
        Me.LblF3.AutoSize = True
        Me.LblF3.Location = New System.Drawing.Point(146, 78)
        Me.LblF3.Name = "LblF3"
        Me.LblF3.Size = New System.Drawing.Size(43, 17)
        Me.LblF3.TabIndex = 25
        Me.LblF3.Text = "LblF3"
        Me.LblF3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF2
        '
        Me.LblF2.AutoSize = True
        Me.LblF2.Location = New System.Drawing.Point(146, 55)
        Me.LblF2.Name = "LblF2"
        Me.LblF2.Size = New System.Drawing.Size(43, 17)
        Me.LblF2.TabIndex = 24
        Me.LblF2.Text = "LblF2"
        Me.LblF2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblF1
        '
        Me.LblF1.AutoSize = True
        Me.LblF1.Location = New System.Drawing.Point(146, 28)
        Me.LblF1.Name = "LblF1"
        Me.LblF1.Size = New System.Drawing.Size(43, 17)
        Me.LblF1.TabIndex = 23
        Me.LblF1.Text = "LblF1"
        Me.LblF1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Bunyol Brillants"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Bunyol d'Coure"
        '
        'LblRecsFalla
        '
        Me.LblRecsFalla.AutoSize = True
        Me.LblRecsFalla.Location = New System.Drawing.Point(131, 0)
        Me.LblRecsFalla.Name = "LblRecsFalla"
        Me.LblRecsFalla.Size = New System.Drawing.Size(155, 17)
        Me.LblRecsFalla.TabIndex = 11
        Me.LblRecsFalla.Text = "Nª Recompensas Falla:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(275, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Bunyol Fulles"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Bunyol d'Argent"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Bunyol d'Or"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblJ13)
        Me.GroupBox1.Controls.Add(Me.LblJ12)
        Me.GroupBox1.Controls.Add(Me.LblJ11)
        Me.GroupBox1.Controls.Add(Me.LblJ5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblJ4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LblJ3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblJ2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblJ1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblRecsJCF)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 111)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'LblJ13
        '
        Me.LblJ13.AutoSize = True
        Me.LblJ13.Location = New System.Drawing.Point(122, 82)
        Me.LblJ13.Name = "LblJ13"
        Me.LblJ13.Size = New System.Drawing.Size(50, 17)
        Me.LblJ13.TabIndex = 35
        Me.LblJ13.Text = "LblJ13"
        Me.LblJ13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblJ12
        '
        Me.LblJ12.AutoSize = True
        Me.LblJ12.Location = New System.Drawing.Point(122, 59)
        Me.LblJ12.Name = "LblJ12"
        Me.LblJ12.Size = New System.Drawing.Size(50, 17)
        Me.LblJ12.TabIndex = 34
        Me.LblJ12.Text = "LblJ12"
        Me.LblJ12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblJ11
        '
        Me.LblJ11.AutoSize = True
        Me.LblJ11.Location = New System.Drawing.Point(122, 32)
        Me.LblJ11.Name = "LblJ11"
        Me.LblJ11.Size = New System.Drawing.Size(50, 17)
        Me.LblJ11.TabIndex = 33
        Me.LblJ11.Text = "LblJ11"
        Me.LblJ11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblJ5
        '
        Me.LblJ5.AutoSize = True
        Me.LblJ5.Location = New System.Drawing.Point(580, 57)
        Me.LblJ5.Name = "LblJ5"
        Me.LblJ5.Size = New System.Drawing.Size(42, 17)
        Me.LblJ5.TabIndex = 32
        Me.LblJ5.Text = "LblJ5"
        Me.LblJ5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(457, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Bunyol Brillants"
        '
        'LblJ4
        '
        Me.LblJ4.AutoSize = True
        Me.LblJ4.Location = New System.Drawing.Point(580, 30)
        Me.LblJ4.Name = "LblJ4"
        Me.LblJ4.Size = New System.Drawing.Size(42, 17)
        Me.LblJ4.TabIndex = 31
        Me.LblJ4.Text = "LblJ4"
        Me.LblJ4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(457, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Bunyol Fulles"
        '
        'LblJ3
        '
        Me.LblJ3.AutoSize = True
        Me.LblJ3.Location = New System.Drawing.Point(345, 80)
        Me.LblJ3.Name = "LblJ3"
        Me.LblJ3.Size = New System.Drawing.Size(42, 17)
        Me.LblJ3.TabIndex = 30
        Me.LblJ3.Text = "LblJ3"
        Me.LblJ3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Bunyol d'Or"
        '
        'LblJ2
        '
        Me.LblJ2.AutoSize = True
        Me.LblJ2.Location = New System.Drawing.Point(345, 57)
        Me.LblJ2.Name = "LblJ2"
        Me.LblJ2.Size = New System.Drawing.Size(42, 17)
        Me.LblJ2.TabIndex = 29
        Me.LblJ2.Text = "LblJ2"
        Me.LblJ2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Bunyol d'Argent"
        '
        'LblJ1
        '
        Me.LblJ1.AutoSize = True
        Me.LblJ1.Location = New System.Drawing.Point(345, 30)
        Me.LblJ1.Name = "LblJ1"
        Me.LblJ1.Size = New System.Drawing.Size(42, 17)
        Me.LblJ1.TabIndex = 28
        Me.LblJ1.Text = "LblJ1"
        Me.LblJ1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Bunyol d'Coure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Distintiu d'Or"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Distintiu d'Argent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Distintiu d'Coure"
        '
        'LblRecsJCF
        '
        Me.LblRecsJCF.AutoSize = True
        Me.LblRecsJCF.Location = New System.Drawing.Point(111, 0)
        Me.LblRecsJCF.Name = "LblRecsJCF"
        Me.LblRecsJCF.Size = New System.Drawing.Size(149, 17)
        Me.LblRecsJCF.TabIndex = 10
        Me.LblRecsJCF.Text = "Nº Recompensas JCF:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblFiltro)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.BtnBorrarFiltro)
        Me.Panel2.Controls.Add(Me.BtnFiltrar)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1465, 190)
        Me.Panel2.TabIndex = 30
        '
        'LblFiltro
        '
        Me.LblFiltro.AutoSize = True
        Me.LblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltro.Location = New System.Drawing.Point(611, 14)
        Me.LblFiltro.Name = "LblFiltro"
        Me.LblFiltro.Size = New System.Drawing.Size(242, 25)
        Me.LblFiltro.TabIndex = 29
        Me.LblFiltro.Text = "Todas las recompensas"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.recompensasejercicioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppGestion.RptVerRecompensas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 196)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1448, 351)
        Me.ReportViewer1.TabIndex = 0
        '
        'recompensasejercicioTableAdapter
        '
        Me.recompensasejercicioTableAdapter.ClearBeforeFill = True
        '
        'FrmVerRecompensas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1465, 544)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVerRecompensas"
        Me.Text = "Listado Recompensas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.recompensasejercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents recompensasejercicioBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents recompensasejercicioTableAdapter As DataSet1TableAdapters.recompensasejercicioTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RbtMayores As RadioButton
    Friend WithEvents RbtInfantiles As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbtJCF As RadioButton
    Friend WithEvents RbtFalla As RadioButton
    Friend WithEvents BtnBorrarFiltro As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblF6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblF8 As Label
    Friend WithEvents LblF4 As Label
    Friend WithEvents LblF3 As Label
    Friend WithEvents LblF2 As Label
    Friend WithEvents LblF1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblRecsFalla As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblJ13 As Label
    Friend WithEvents LblJ12 As Label
    Friend WithEvents LblJ11 As Label
    Friend WithEvents LblJ5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblJ4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblJ3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblJ2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblJ1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblRecsJCF As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RbtFallaJCF As RadioButton
    Friend WithEvents LblFiltro As Label
End Class
