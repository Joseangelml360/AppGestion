<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIniciarEjercicio
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
        Dim PasemayorLabel As System.Windows.Forms.Label
        Dim AñojuvenilLabel As System.Windows.Forms.Label
        Dim MesjuvenilLabel As System.Windows.Forms.Label
        Dim DiajuvenilLabel As System.Windows.Forms.Label
        Dim PasejuvenilLabel As System.Windows.Forms.Label
        Dim AñoinfantilLabel As System.Windows.Forms.Label
        Dim MesinfantilLabel As System.Windows.Forms.Label
        Dim DiainfantilLabel As System.Windows.Forms.Label
        Dim AñoejeLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIniciarEjercicio))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EstablecerValoresInicioCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnPasarDatos = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtAñoPaseJuv = New System.Windows.Forms.TextBox()
        Me.TxtFechaPaseInf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAñoJuv = New System.Windows.Forms.TextBox()
        Me.TxtMesJuv = New System.Windows.Forms.TextBox()
        Me.TxtDiaJuv = New System.Windows.Forms.TextBox()
        Me.TxtAñoInf = New System.Windows.Forms.TextBox()
        Me.TxtMesInf = New System.Windows.Forms.TextBox()
        Me.TxtDiaInf = New System.Windows.Forms.TextBox()
        Me.PasemayorDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AñojuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.MesjuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.DiajuvenilTextBox = New System.Windows.Forms.TextBox()
        Me.PasejuvenilDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AñoinfantilTextBox = New System.Windows.Forms.TextBox()
        Me.MesinfantilTextBox = New System.Windows.Forms.TextBox()
        Me.DiainfantilTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAñoEjeNew = New System.Windows.Forms.TextBox()
        Me.AñoejeTextBox = New System.Windows.Forms.TextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppGestion.DataSet1()
        Me.EjercicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New AppGestion.DataSet1TableAdapters.estadoTableAdapter()
        Me.EjercicioTableAdapter = New AppGestion.DataSet1TableAdapters.ejercicioTableAdapter()
        Me.TxtFechapase0_3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAño0_3 = New System.Windows.Forms.TextBox()
        Me.TxtMes0_3 = New System.Windows.Forms.TextBox()
        Me.TxtDia0_3 = New System.Windows.Forms.TextBox()
        Me.Pase0_3DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Año0_3Textbox = New System.Windows.Forms.TextBox()
        Me.Mes0_3Textbox = New System.Windows.Forms.TextBox()
        Me.Dia0_3Textbox = New System.Windows.Forms.TextBox()
        PasemayorLabel = New System.Windows.Forms.Label()
        AñojuvenilLabel = New System.Windows.Forms.Label()
        MesjuvenilLabel = New System.Windows.Forms.Label()
        DiajuvenilLabel = New System.Windows.Forms.Label()
        PasejuvenilLabel = New System.Windows.Forms.Label()
        AñoinfantilLabel = New System.Windows.Forms.Label()
        MesinfantilLabel = New System.Windows.Forms.Label()
        DiainfantilLabel = New System.Windows.Forms.Label()
        AñoejeLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasemayorLabel
        '
        PasemayorLabel.AutoSize = True
        PasemayorLabel.Location = New System.Drawing.Point(690, 389)
        PasemayorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasemayorLabel.Name = "PasemayorLabel"
        PasemayorLabel.Size = New System.Drawing.Size(137, 17)
        PasemayorLabel.TabIndex = 61
        PasemayorLabel.Text = "Fecha pase a mayor"
        '
        'AñojuvenilLabel
        '
        AñojuvenilLabel.AutoSize = True
        AñojuvenilLabel.Location = New System.Drawing.Point(659, 335)
        AñojuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AñojuvenilLabel.Name = "AñojuvenilLabel"
        AñojuvenilLabel.Size = New System.Drawing.Size(76, 17)
        AñojuvenilLabel.TabIndex = 59
        AñojuvenilLabel.Text = "añojuvenil:"
        '
        'MesjuvenilLabel
        '
        MesjuvenilLabel.AutoSize = True
        MesjuvenilLabel.Location = New System.Drawing.Point(658, 303)
        MesjuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MesjuvenilLabel.Name = "MesjuvenilLabel"
        MesjuvenilLabel.Size = New System.Drawing.Size(78, 17)
        MesjuvenilLabel.TabIndex = 57
        MesjuvenilLabel.Text = "mesjuvenil:"
        '
        'DiajuvenilLabel
        '
        DiajuvenilLabel.AutoSize = True
        DiajuvenilLabel.Location = New System.Drawing.Point(665, 271)
        DiajuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DiajuvenilLabel.Name = "DiajuvenilLabel"
        DiajuvenilLabel.Size = New System.Drawing.Size(71, 17)
        DiajuvenilLabel.TabIndex = 55
        DiajuvenilLabel.Text = "diajuvenil:"
        '
        'PasejuvenilLabel
        '
        PasejuvenilLabel.AutoSize = True
        PasejuvenilLabel.Location = New System.Drawing.Point(375, 389)
        PasejuvenilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasejuvenilLabel.Name = "PasejuvenilLabel"
        PasejuvenilLabel.Size = New System.Drawing.Size(138, 17)
        PasejuvenilLabel.TabIndex = 53
        PasejuvenilLabel.Text = "Fecha pase a juvenil"
        '
        'AñoinfantilLabel
        '
        AñoinfantilLabel.AutoSize = True
        AñoinfantilLabel.Location = New System.Drawing.Point(339, 336)
        AñoinfantilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AñoinfantilLabel.Name = "AñoinfantilLabel"
        AñoinfantilLabel.Size = New System.Drawing.Size(77, 17)
        AñoinfantilLabel.TabIndex = 51
        AñoinfantilLabel.Text = "añoinfantil:"
        '
        'MesinfantilLabel
        '
        MesinfantilLabel.AutoSize = True
        MesinfantilLabel.Location = New System.Drawing.Point(337, 303)
        MesinfantilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MesinfantilLabel.Name = "MesinfantilLabel"
        MesinfantilLabel.Size = New System.Drawing.Size(79, 17)
        MesinfantilLabel.TabIndex = 49
        MesinfantilLabel.Text = "mesinfantil:"
        '
        'DiainfantilLabel
        '
        DiainfantilLabel.AutoSize = True
        DiainfantilLabel.Location = New System.Drawing.Point(344, 270)
        DiainfantilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DiainfantilLabel.Name = "DiainfantilLabel"
        DiainfantilLabel.Size = New System.Drawing.Size(72, 17)
        DiainfantilLabel.TabIndex = 47
        DiainfantilLabel.Text = "diainfantil:"
        '
        'AñoejeLabel
        '
        AñoejeLabel.AutoSize = True
        AñoejeLabel.Location = New System.Drawing.Point(50, 96)
        AñoejeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AñoejeLabel.Name = "AñoejeLabel"
        AñoejeLabel.Size = New System.Drawing.Size(103, 17)
        AñoejeLabel.TabIndex = 43
        AñoejeLabel.Text = "Ejercicio actual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(155, 167)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Haga Click en Generar"
        '
        'EstablecerValoresInicioCheckBox
        '
        Me.EstablecerValoresInicioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EstadoBindingSource, "EstablecerValoresInicio", True))
        Me.EstablecerValoresInicioCheckBox.Location = New System.Drawing.Point(475, 160)
        Me.EstablecerValoresInicioCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EstablecerValoresInicioCheckBox.Name = "EstablecerValoresInicioCheckBox"
        Me.EstablecerValoresInicioCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.EstablecerValoresInicioCheckBox.TabIndex = 80
        Me.EstablecerValoresInicioCheckBox.Text = "Sin Generar"
        Me.EstablecerValoresInicioCheckBox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 35)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 20)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Generar nuevo Ejercicio"
        '
        'BtnPasarDatos
        '
        Me.BtnPasarDatos.Image = Global.AppGestion.My.Resources.Resources.arrow_right
        Me.BtnPasarDatos.Location = New System.Drawing.Point(334, 92)
        Me.BtnPasarDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPasarDatos.Name = "BtnPasarDatos"
        Me.BtnPasarDatos.Size = New System.Drawing.Size(100, 21)
        Me.BtnPasarDatos.TabIndex = 78
        Me.BtnPasarDatos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(339, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Pasar datos"
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Image = Global.AppGestion.My.Resources.Resources._new
        Me.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerar.Location = New System.Drawing.Point(319, 159)
        Me.BtnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(133, 30)
        Me.BtnGenerar.TabIndex = 76
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Image = Global.AppGestion.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(780, 13)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(157, 46)
        Me.BtnCancelar.TabIndex = 75
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtAñoPaseJuv
        '
        Me.TxtAñoPaseJuv.Location = New System.Drawing.Point(766, 409)
        Me.TxtAñoPaseJuv.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAñoPaseJuv.Name = "TxtAñoPaseJuv"
        Me.TxtAñoPaseJuv.Size = New System.Drawing.Size(111, 22)
        Me.TxtAñoPaseJuv.TabIndex = 74
        '
        'TxtFechaPaseInf
        '
        Me.TxtFechaPaseInf.Location = New System.Drawing.Point(451, 409)
        Me.TxtFechaPaseInf.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFechaPaseInf.Name = "TxtFechaPaseInf"
        Me.TxtFechaPaseInf.Size = New System.Drawing.Size(109, 22)
        Me.TxtFechaPaseInf.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(826, 248)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Nuevo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(757, 248)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(509, 248)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Nuevo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(439, 248)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Actual"
        '
        'TxtAñoJuv
        '
        Me.TxtAñoJuv.Location = New System.Drawing.Point(814, 331)
        Me.TxtAñoJuv.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAñoJuv.Name = "TxtAñoJuv"
        Me.TxtAñoJuv.Size = New System.Drawing.Size(63, 22)
        Me.TxtAñoJuv.TabIndex = 68
        '
        'TxtMesJuv
        '
        Me.TxtMesJuv.Location = New System.Drawing.Point(814, 299)
        Me.TxtMesJuv.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMesJuv.Name = "TxtMesJuv"
        Me.TxtMesJuv.Size = New System.Drawing.Size(63, 22)
        Me.TxtMesJuv.TabIndex = 67
        '
        'TxtDiaJuv
        '
        Me.TxtDiaJuv.Location = New System.Drawing.Point(814, 267)
        Me.TxtDiaJuv.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDiaJuv.Name = "TxtDiaJuv"
        Me.TxtDiaJuv.Size = New System.Drawing.Size(63, 22)
        Me.TxtDiaJuv.TabIndex = 66
        '
        'TxtAñoInf
        '
        Me.TxtAñoInf.Location = New System.Drawing.Point(497, 331)
        Me.TxtAñoInf.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAñoInf.Name = "TxtAñoInf"
        Me.TxtAñoInf.Size = New System.Drawing.Size(63, 22)
        Me.TxtAñoInf.TabIndex = 65
        '
        'TxtMesInf
        '
        Me.TxtMesInf.Location = New System.Drawing.Point(497, 299)
        Me.TxtMesInf.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMesInf.Name = "TxtMesInf"
        Me.TxtMesInf.Size = New System.Drawing.Size(63, 22)
        Me.TxtMesInf.TabIndex = 64
        '
        'TxtDiaInf
        '
        Me.TxtDiaInf.Location = New System.Drawing.Point(497, 267)
        Me.TxtDiaInf.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDiaInf.Name = "TxtDiaInf"
        Me.TxtDiaInf.Size = New System.Drawing.Size(63, 22)
        Me.TxtDiaInf.TabIndex = 63
        '
        'PasemayorDateTimePicker
        '
        Me.PasemayorDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EjercicioBindingSource, "pasemayor", True))
        Me.PasemayorDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PasemayorDateTimePicker.Location = New System.Drawing.Point(643, 409)
        Me.PasemayorDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.PasemayorDateTimePicker.Name = "PasemayorDateTimePicker"
        Me.PasemayorDateTimePicker.Size = New System.Drawing.Size(113, 22)
        Me.PasemayorDateTimePicker.TabIndex = 62
        '
        'AñojuvenilTextBox
        '
        Me.AñojuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anojuvenil", True))
        Me.AñojuvenilTextBox.Location = New System.Drawing.Point(745, 331)
        Me.AñojuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AñojuvenilTextBox.Name = "AñojuvenilTextBox"
        Me.AñojuvenilTextBox.Size = New System.Drawing.Size(63, 22)
        Me.AñojuvenilTextBox.TabIndex = 60
        '
        'MesjuvenilTextBox
        '
        Me.MesjuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "mesjuvenil", True))
        Me.MesjuvenilTextBox.Location = New System.Drawing.Point(745, 299)
        Me.MesjuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MesjuvenilTextBox.Name = "MesjuvenilTextBox"
        Me.MesjuvenilTextBox.Size = New System.Drawing.Size(63, 22)
        Me.MesjuvenilTextBox.TabIndex = 58
        '
        'DiajuvenilTextBox
        '
        Me.DiajuvenilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "diajuvenil", True))
        Me.DiajuvenilTextBox.Location = New System.Drawing.Point(745, 267)
        Me.DiajuvenilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DiajuvenilTextBox.Name = "DiajuvenilTextBox"
        Me.DiajuvenilTextBox.Size = New System.Drawing.Size(63, 22)
        Me.DiajuvenilTextBox.TabIndex = 56
        '
        'PasejuvenilDateTimePicker
        '
        Me.PasejuvenilDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EjercicioBindingSource, "pasejuvenil", True))
        Me.PasejuvenilDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PasejuvenilDateTimePicker.Location = New System.Drawing.Point(332, 409)
        Me.PasejuvenilDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.PasejuvenilDateTimePicker.Name = "PasejuvenilDateTimePicker"
        Me.PasejuvenilDateTimePicker.Size = New System.Drawing.Size(108, 22)
        Me.PasejuvenilDateTimePicker.TabIndex = 54
        '
        'AñoinfantilTextBox
        '
        Me.AñoinfantilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoinfantil", True))
        Me.AñoinfantilTextBox.Location = New System.Drawing.Point(426, 331)
        Me.AñoinfantilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AñoinfantilTextBox.Name = "AñoinfantilTextBox"
        Me.AñoinfantilTextBox.Size = New System.Drawing.Size(61, 22)
        Me.AñoinfantilTextBox.TabIndex = 52
        '
        'MesinfantilTextBox
        '
        Me.MesinfantilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "mesinfantil", True))
        Me.MesinfantilTextBox.Location = New System.Drawing.Point(426, 299)
        Me.MesinfantilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MesinfantilTextBox.Name = "MesinfantilTextBox"
        Me.MesinfantilTextBox.Size = New System.Drawing.Size(61, 22)
        Me.MesinfantilTextBox.TabIndex = 50
        '
        'DiainfantilTextBox
        '
        Me.DiainfantilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "diainfantil", True))
        Me.DiainfantilTextBox.Location = New System.Drawing.Point(426, 267)
        Me.DiainfantilTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DiainfantilTextBox.Name = "DiainfantilTextBox"
        Me.DiainfantilTextBox.Size = New System.Drawing.Size(61, 22)
        Me.DiainfantilTextBox.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nuevo ejercicio:"
        '
        'TxtAñoEjeNew
        '
        Me.TxtAñoEjeNew.Location = New System.Drawing.Point(598, 93)
        Me.TxtAñoEjeNew.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAñoEjeNew.Name = "TxtAñoEjeNew"
        Me.TxtAñoEjeNew.Size = New System.Drawing.Size(132, 22)
        Me.TxtAñoEjeNew.TabIndex = 45
        '
        'AñoejeTextBox
        '
        Me.AñoejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "anoeje", True))
        Me.AñoejeTextBox.Location = New System.Drawing.Point(163, 92)
        Me.AñoejeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AñoejeTextBox.Name = "AñoejeTextBox"
        Me.AñoejeTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AñoejeTextBox.TabIndex = 44
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
        'EjercicioBindingSource
        '
        Me.EjercicioBindingSource.DataMember = "ejercicio"
        Me.EjercicioBindingSource.DataSource = Me.DataSet1
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'EjercicioTableAdapter
        '
        Me.EjercicioTableAdapter.ClearBeforeFill = True
        '
        'TxtFechapase0_3
        '
        Me.TxtFechapase0_3.Location = New System.Drawing.Point(143, 408)
        Me.TxtFechapase0_3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFechapase0_3.Name = "TxtFechapase0_3"
        Me.TxtFechapase0_3.Size = New System.Drawing.Size(111, 22)
        Me.TxtFechapase0_3.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(203, 247)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Nuevo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(134, 247)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Actual"
        '
        'TxtAño0_3
        '
        Me.TxtAño0_3.Location = New System.Drawing.Point(191, 330)
        Me.TxtAño0_3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAño0_3.Name = "TxtAño0_3"
        Me.TxtAño0_3.Size = New System.Drawing.Size(63, 22)
        Me.TxtAño0_3.TabIndex = 92
        '
        'TxtMes0_3
        '
        Me.TxtMes0_3.Location = New System.Drawing.Point(191, 298)
        Me.TxtMes0_3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMes0_3.Name = "TxtMes0_3"
        Me.TxtMes0_3.Size = New System.Drawing.Size(63, 22)
        Me.TxtMes0_3.TabIndex = 91
        '
        'TxtDia0_3
        '
        Me.TxtDia0_3.Location = New System.Drawing.Point(191, 266)
        Me.TxtDia0_3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDia0_3.Name = "TxtDia0_3"
        Me.TxtDia0_3.Size = New System.Drawing.Size(63, 22)
        Me.TxtDia0_3.TabIndex = 90
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(61, 387)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(154, 17)
        Label11.TabIndex = 88
        Label11.Text = "Fecha pase > 0-3 años"
        '
        'Pase0_3DateTimePicker1
        '
        Me.Pase0_3DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EjercicioBindingSource, "pase0_3", True))
        Me.Pase0_3DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Pase0_3DateTimePicker1.Location = New System.Drawing.Point(20, 408)
        Me.Pase0_3DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.Pase0_3DateTimePicker1.Name = "Pase0_3DateTimePicker1"
        Me.Pase0_3DateTimePicker1.Size = New System.Drawing.Size(113, 22)
        Me.Pase0_3DateTimePicker1.TabIndex = 89
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(17, 333)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(96, 17)
        Label12.TabIndex = 86
        Label12.Text = "año 0-3 años:"
        '
        'Año0_3Textbox
        '
        Me.Año0_3Textbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "ano0_3", True))
        Me.Año0_3Textbox.Location = New System.Drawing.Point(122, 330)
        Me.Año0_3Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Año0_3Textbox.Name = "Año0_3Textbox"
        Me.Año0_3Textbox.Size = New System.Drawing.Size(63, 22)
        Me.Año0_3Textbox.TabIndex = 87
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(15, 302)
        Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(98, 17)
        Label13.TabIndex = 84
        Label13.Text = "mes 0-3 años:"
        '
        'Mes0_3Textbox
        '
        Me.Mes0_3Textbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "mes0_3", True))
        Me.Mes0_3Textbox.Location = New System.Drawing.Point(122, 298)
        Me.Mes0_3Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Mes0_3Textbox.Name = "Mes0_3Textbox"
        Me.Mes0_3Textbox.Size = New System.Drawing.Size(63, 22)
        Me.Mes0_3Textbox.TabIndex = 85
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(22, 269)
        Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(91, 17)
        Label14.TabIndex = 82
        Label14.Text = "dia 0-3 años:"
        '
        'Dia0_3Textbox
        '
        Me.Dia0_3Textbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EjercicioBindingSource, "dia0_3", True))
        Me.Dia0_3Textbox.Location = New System.Drawing.Point(122, 266)
        Me.Dia0_3Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Dia0_3Textbox.Name = "Dia0_3Textbox"
        Me.Dia0_3Textbox.Size = New System.Drawing.Size(63, 22)
        Me.Dia0_3Textbox.TabIndex = 83
        '
        'FrmIniciarEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(950, 483)
        Me.Controls.Add(Me.TxtFechapase0_3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtAño0_3)
        Me.Controls.Add(Me.TxtMes0_3)
        Me.Controls.Add(Me.TxtDia0_3)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.Pase0_3DateTimePicker1)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.Año0_3Textbox)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Me.Mes0_3Textbox)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Me.Dia0_3Textbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EstablecerValoresInicioCheckBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnPasarDatos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.TxtAñoPaseJuv)
        Me.Controls.Add(Me.TxtFechaPaseInf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAñoJuv)
        Me.Controls.Add(Me.TxtMesJuv)
        Me.Controls.Add(Me.TxtDiaJuv)
        Me.Controls.Add(Me.TxtAñoInf)
        Me.Controls.Add(Me.TxtMesInf)
        Me.Controls.Add(Me.TxtDiaInf)
        Me.Controls.Add(PasemayorLabel)
        Me.Controls.Add(Me.PasemayorDateTimePicker)
        Me.Controls.Add(AñojuvenilLabel)
        Me.Controls.Add(Me.AñojuvenilTextBox)
        Me.Controls.Add(MesjuvenilLabel)
        Me.Controls.Add(Me.MesjuvenilTextBox)
        Me.Controls.Add(DiajuvenilLabel)
        Me.Controls.Add(Me.DiajuvenilTextBox)
        Me.Controls.Add(PasejuvenilLabel)
        Me.Controls.Add(Me.PasejuvenilDateTimePicker)
        Me.Controls.Add(AñoinfantilLabel)
        Me.Controls.Add(Me.AñoinfantilTextBox)
        Me.Controls.Add(MesinfantilLabel)
        Me.Controls.Add(Me.MesinfantilTextBox)
        Me.Controls.Add(DiainfantilLabel)
        Me.Controls.Add(Me.DiainfantilTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAñoEjeNew)
        Me.Controls.Add(AñoejeLabel)
        Me.Controls.Add(Me.AñoejeTextBox)
        Me.HelpProvider1.SetHelpKeyword(Me, "61")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIniciarEjercicio"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Ejercicio"
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents EstablecerValoresInicioCheckBox As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnPasarDatos As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtAñoPaseJuv As TextBox
    Friend WithEvents TxtFechaPaseInf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAñoJuv As TextBox
    Friend WithEvents TxtMesJuv As TextBox
    Friend WithEvents TxtDiaJuv As TextBox
    Friend WithEvents TxtAñoInf As TextBox
    Friend WithEvents TxtMesInf As TextBox
    Friend WithEvents TxtDiaInf As TextBox
    Friend WithEvents PasemayorDateTimePicker As DateTimePicker
    Friend WithEvents AñojuvenilTextBox As TextBox
    Friend WithEvents MesjuvenilTextBox As TextBox
    Friend WithEvents DiajuvenilTextBox As TextBox
    Friend WithEvents PasejuvenilDateTimePicker As DateTimePicker
    Friend WithEvents AñoinfantilTextBox As TextBox
    Friend WithEvents MesinfantilTextBox As TextBox
    Friend WithEvents DiainfantilTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAñoEjeNew As TextBox
    Friend WithEvents AñoejeTextBox As TextBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As DataSet1TableAdapters.estadoTableAdapter
    Friend WithEvents EjercicioBindingSource As BindingSource
    Friend WithEvents EjercicioTableAdapter As DataSet1TableAdapters.ejercicioTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TxtFechapase0_3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAño0_3 As TextBox
    Friend WithEvents TxtMes0_3 As TextBox
    Friend WithEvents TxtDia0_3 As TextBox
    Friend WithEvents Pase0_3DateTimePicker1 As DateTimePicker
    Friend WithEvents Año0_3Textbox As TextBox
    Friend WithEvents Mes0_3Textbox As TextBox
    Friend WithEvents Dia0_3Textbox As TextBox
End Class
