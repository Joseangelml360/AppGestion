<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCuotasEjercicio
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNegativo = New System.Windows.Forms.TextBox()
        Me.TxtPositivo = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtAbonos = New System.Windows.Forms.TextBox()
        Me.TxtDeudas = New System.Windows.Forms.TextBox()
        Me.TxtBenef = New System.Windows.Forms.TextBox()
        Me.TxtLotJuv = New System.Windows.Forms.TextBox()
        Me.TxtLotMay = New System.Windows.Forms.TextBox()
        Me.TxtCuotas = New System.Windows.Forms.TextBox()
        Me.DataSetCuotas = New AppGestion.DataSetCuotas()
        Me.FalleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FalleroTableAdapter = New AppGestion.DataSetCuotasTableAdapters.falleroTableAdapter()
        Me.TableAdapterManager = New AppGestion.DataSetCuotasTableAdapters.TableAdapterManager()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(269, 338)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Abonos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(263, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Ingresos:"
        '
        'TxtNegativo
        '
        Me.TxtNegativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNegativo.ForeColor = System.Drawing.Color.Red
        Me.TxtNegativo.Location = New System.Drawing.Point(335, 335)
        Me.TxtNegativo.Name = "TxtNegativo"
        Me.TxtNegativo.Size = New System.Drawing.Size(159, 22)
        Me.TxtNegativo.TabIndex = 29
        Me.TxtNegativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPositivo
        '
        Me.TxtPositivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPositivo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtPositivo.Location = New System.Drawing.Point(335, 238)
        Me.TxtPositivo.Name = "TxtPositivo"
        Me.TxtPositivo.Size = New System.Drawing.Size(159, 22)
        Me.TxtPositivo.TabIndex = 25
        Me.TxtPositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(412, 31)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(118, 37)
        Me.BtnSalir.TabIndex = 20
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Ingresos por Cuotas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(145, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Total Cuotas Ejercicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Abonos ejercicio anterior:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Deudas ejercicio anterior:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Devolución Beneficios lotería:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Cuotas por lotería juveniles:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Cuotas por lotería mayores:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cuotas directas:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtTotal.Location = New System.Drawing.Point(335, 398)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(159, 22)
        Me.TxtTotal.TabIndex = 31
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtAbonos
        '
        Me.TxtAbonos.ForeColor = System.Drawing.Color.Red
        Me.TxtAbonos.Location = New System.Drawing.Point(229, 307)
        Me.TxtAbonos.Name = "TxtAbonos"
        Me.TxtAbonos.Size = New System.Drawing.Size(116, 22)
        Me.TxtAbonos.TabIndex = 27
        Me.TxtAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDeudas
        '
        Me.TxtDeudas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtDeudas.Location = New System.Drawing.Point(229, 210)
        Me.TxtDeudas.Name = "TxtDeudas"
        Me.TxtDeudas.Size = New System.Drawing.Size(116, 22)
        Me.TxtDeudas.TabIndex = 24
        Me.TxtDeudas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBenef
        '
        Me.TxtBenef.ForeColor = System.Drawing.Color.Red
        Me.TxtBenef.Location = New System.Drawing.Point(229, 279)
        Me.TxtBenef.Name = "TxtBenef"
        Me.TxtBenef.Size = New System.Drawing.Size(116, 22)
        Me.TxtBenef.TabIndex = 26
        Me.TxtBenef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtLotJuv
        '
        Me.TxtLotJuv.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtLotJuv.Location = New System.Drawing.Point(229, 182)
        Me.TxtLotJuv.Name = "TxtLotJuv"
        Me.TxtLotJuv.Size = New System.Drawing.Size(116, 22)
        Me.TxtLotJuv.TabIndex = 23
        Me.TxtLotJuv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtLotMay
        '
        Me.TxtLotMay.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtLotMay.Location = New System.Drawing.Point(229, 153)
        Me.TxtLotMay.Name = "TxtLotMay"
        Me.TxtLotMay.Size = New System.Drawing.Size(116, 22)
        Me.TxtLotMay.TabIndex = 22
        Me.TxtLotMay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCuotas
        '
        Me.TxtCuotas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtCuotas.Location = New System.Drawing.Point(229, 124)
        Me.TxtCuotas.Name = "TxtCuotas"
        Me.TxtCuotas.Size = New System.Drawing.Size(116, 22)
        Me.TxtCuotas.TabIndex = 21
        Me.TxtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataSetCuotas
        '
        Me.DataSetCuotas.DataSetName = "DataSetCuotas"
        Me.DataSetCuotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FalleroBindingSource
        '
        Me.FalleroBindingSource.DataMember = "fallero"
        Me.FalleroBindingSource.DataSource = Me.DataSetCuotas
        '
        'FalleroTableAdapter
        '
        Me.FalleroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.descuentos_de_la_cuotaTableAdapter = Nothing
        Me.TableAdapterManager.ejercicioTableAdapter = Nothing
        Me.TableAdapterManager.estadoTableAdapter = Nothing
        Me.TableAdapterManager.tipo_de_cuotasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppGestion.DataSetCuotasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmCuotasEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(558, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNegativo)
        Me.Controls.Add(Me.TxtPositivo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtAbonos)
        Me.Controls.Add(Me.TxtDeudas)
        Me.Controls.Add(Me.TxtBenef)
        Me.Controls.Add(Me.TxtLotJuv)
        Me.Controls.Add(Me.TxtLotMay)
        Me.Controls.Add(Me.TxtCuotas)
        Me.HelpProvider1.SetHelpKeyword(Me, "23")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FrmCuotasEjercicio"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCuotasEjercicio"
        CType(Me.DataSetCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNegativo As TextBox
    Friend WithEvents TxtPositivo As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtAbonos As TextBox
    Friend WithEvents TxtDeudas As TextBox
    Friend WithEvents TxtBenef As TextBox
    Friend WithEvents TxtLotJuv As TextBox
    Friend WithEvents TxtLotMay As TextBox
    Friend WithEvents TxtCuotas As TextBox
    Friend WithEvents DataSetCuotas As DataSetCuotas
    Friend WithEvents FalleroBindingSource As BindingSource
    Friend WithEvents FalleroTableAdapter As DataSetCuotasTableAdapters.falleroTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCuotasTableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
