Public Class FrmAsignarCuotas
    Private Sub FrmAsignarCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.Fill(Me.DataSetCuotas.fallero)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DbCensos.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.tipo_de_cuotas' Puede moverla o quitarla según sea necesario.
        Me.Tipo_de_cuotasTableAdapter.Fill(Me.DbCensos.tipo_de_cuotas)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Dim nCancelado As Integer

        If AsignarValoresFalleroCheckBox.CheckState = 0 Then
            Me.AsignarValoresFalleroCheckBox.Visible = True
            Me.AsignarValoresFalleroCheckBox.Text = "Asignado"
            Me.LblAsigValFallero.Visible = True
        End If

        BtnCalcular.Enabled = False
        BtnGuardarCambios.Enabled = False
        BtnSalir.Enabled = True
        BtnActualizarTablaFalleros.Enabled = False

        'Copia en los textbox de entrada de datos los valores que están definidos en la tabla EJERCICIO
        Me.TxtBase.Text = Me.CuotaBaseTextBox.Text
        Me.TxtCuotas.Text = Me.NumCuotasTextBox.Text
        Me.TxtNumOrdinarios.Text = Me.NumordinariosTextBox.Text
        Me.TxtOrdJuvenil.Text = Me.OrdinariojuvenilTextBox.Text
        Me.TxtOrdMayor.Text = Me.OrdinariomayorTextBox.Text
        Me.TxtNavidadJuvenil.Text = Me.NavidadjuvenilTextBox.Text
        Me.TxtNavidadMayor.Text = Me.NavidadmayorTextBox.Text
        Me.TxtNiñoJuvenil.Text = Me.NiñojuvenilTextBox.Text
        Me.TxtNiñoMayor.Text = Me.NiñomayorTextBox.Text
        Me.TxtLotJuvenil.Text = Val(TxtNumOrdinarios.Text) * Val(Me.TxtOrdJuvenil.Text) + Val(Me.TxtNavidadJuvenil.Text) + Val(Me.TxtNiñoJuvenil.Text)
        Me.TxtLotMayor.Text = Val(TxtNumOrdinarios.Text) * Val(Me.TxtOrdMayor.Text) + Val(TxtNavidadMayor.Text) + Val(Me.TxtNiñoMayor.Text)
        Me.AsignarCuotaNuevaCheckBox.Enabled = False

        If Me.Estado.Text = "True" Then     '
            Me.AsignarCuotaNuevaCheckBox.CheckState = 1
            Me.AsignarCuotaNuevaCheckBox.Text = "Asignado"
            nCancelado = MsgBox("Ya se han asignado cuotas anteriormente." &
                   vbCrLf & "¿Estás seguro que quieres volver a asignar nuevas cuotas?", vbYesNo + vbCritical + vbDefaultButton2, "Confirmar acción")
            If nCancelado = 7 Then
                BtnCalcular.Enabled = False
                BtnGuardarCambios.Enabled = False
                BtnSalir.Enabled = True
                BtnActualizarTablaFalleros.Enabled = False
            Else
                BtnCalcular.Enabled = True
                BtnGuardarCambios.Enabled = False
                BtnSalir.Enabled = True
                BtnActualizarTablaFalleros.Enabled = False
            End If
        Else
            BtnCalcular.Enabled = True
            BtnGuardarCambios.Enabled = False
            BtnSalir.Enabled = True
            BtnActualizarTablaFalleros.Enabled = False
            Me.AsignarCuotaNuevaCheckBox.Checked = 0
            Me.AsignarCuotaNuevaCheckBox.Text = "Sin asignar"

        End If




    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Validar campo de cuota base, número de cuotas y número de sorteos ordinarios
        If Not IsNumeric(Me.TxtBase.Text) Then
            MsgBox("Debes introducir un número en 'Cuota Base'", vbExclamation, "Error en la entrada de datos")
            Me.TxtBase.Focus()
            Exit Sub
        End If
        If Not IsNumeric(Me.TxtCuotas.Text) Then
            MsgBox("Debes introducir un número en 'Número de cuotas'", vbExclamation, "Error en la entrada de datos")
            Me.TxtCuotas.Focus()
            Exit Sub
        End If
        If Not IsNumeric(Me.TxtNumOrdinarios.Text) Then
            MsgBox("Debes introducir un número en 'Número de sorteos Ordinarios", vbExclamation, "Error en la entrada de datos")
            Me.TxtNumOrdinarios.Focus()
            Exit Sub
        End If


        'Calculo de nuevos valores para cuotas, tomando como base el importe de cuota de mayores sin descuento
        ' Dim valor As Decimal

        Me.TxtLotJuvenil.Text = Val(TxtNumOrdinarios.Text) * Val(Me.TxtOrdJuvenil.Text) + Val(Me.TxtNavidadJuvenil.Text) + Val(Me.TxtNiñoJuvenil.Text)
        Me.TxtLotMayor.Text = Val(TxtNumOrdinarios.Text) * Val(Me.TxtOrdMayor.Text) + Val(TxtNavidadMayor.Text) + Val(Me.TxtNiñoMayor.Text)
        Me.TxtBenefMayor.Text = Val(Me.TxtLotMayor.Text) * 0.2
        Me.TxtBenefJuvenil.Text = Val(Me.TxtLotJuvenil.Text) * 0.2
        'Me.Txt1.Text = Val(Me.TxtBase.Text) * 0.95
        Me.Txt1.Text = String.Format("{0:N2}", Val(Me.TxtBase.Text) * 0.95)
        Me.Txt2.Text = String.Format("{0:N2}", Val(Me.TxtBase.Text))
        Me.Txt3.Text = String.Format("{0:N2}", Val(Me.TxtBase.Text) / Val(TxtCuotas.Text))
        Me.Txt5.Text = String.Format("{0:N2}", Val(Me.TxtBase.Text) * 0.75)
        Me.Txt4.Text = String.Format("{0:N2}", Val(Me.Txt5.Text) * 0.95)
        Me.Txt6.Text = String.Format("{0:N2}", Val(Me.Txt5.Text) / Val(TxtCuotas.Text))
        Me.Txt8.Text = String.Format("{0:N2}", Val(Me.TxtBase.Text) * 0.5)
        Me.Txt7.Text = String.Format("{0:N2}", Val(Me.Txt8.Text) * 0.95)
        Me.Txt10.Text = String.Format("{0:N2}", Val(Me.Txt8.Text) * 0.95)
        Me.Txt9.Text = String.Format("{0:N2}", Val(Me.Txt10.Text) * 0.95)
        Me.Txt12.Text = String.Format("{0:N2}", Val(Me.Txt8.Text) * 0.9)
        Me.Txt11.Text = String.Format("{0:N2}", Val(Me.Txt12.Text) * 0.95)
        Me.Txt14.Text = String.Format("{0:N2}", Val(Me.TxtBase.Text) * 0.25)
        Me.Txt13.Text = String.Format("{0:N2}", Val(Me.Txt14.Text) * 0.95)
        Me.Txt15.Text = String.Format("{0:N2}", Val(Me.Txt8.Text) / Val(Me.TxtCuotas.Text))
        Me.Txt16.Text = String.Format("{0:N2}", Val(Me.Txt15.Text) * 0.95)
        Me.Txt17.Text = String.Format("{0:N2}", Val(Me.Txt15.Text) * 0.9)
        Me.Txt18.Text = String.Format("{0:N2}", Val(Me.Txt14.Text) / Val(Me.TxtCuotas.Text))
        Me.Txt19.Text = String.Format("{0:N2}", (Val(Me.Txt3.Text) - (Val(Me.TxtBenefMayor.Text)) / Val(Me.TxtCuotas.Text)))
        Me.Txt20.Text = String.Format("{0:N2}", (Val(Me.Txt6.Text) - (Val(Me.TxtBenefJuvenil.Text)) / Val(Me.TxtCuotas.Text)))
        Me.Txt21.Text = 0

        BtnCalcular.Enabled = True
        BtnGuardarCambios.Enabled = True
        BtnSalir.Enabled = True
        BtnActualizarTablaFalleros.Enabled = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnGuardarCambios_Click(sender As Object, e As EventArgs) Handles BtnGuardarCambios.Click

        MsgBox("Si aceptas se sobrescribirán todos los datos viejos con los nuevos", vbYesNo + vbCritical, "Guardar datos")

        If MsgBoxResult.Yes = False Then
            Exit Sub
        End If

        If MsgBoxResult.Yes Then
            BtnCalcular.Enabled = False
            BtnGuardarCambios.Enabled = False
            BtnSalir.Enabled = False

            Dim nuevoaño As Integer
            Dim nuevoOrdMayor, nuevoOrdJuvenil, nuevoNavMayor, nuevoNavJuvenil, nuevoNiñoMayor As Double
            Dim nuevoNiñoJuvenil, nuevoLotMayor, nuevoLotJuvenil, nuevoNumOrd As Double
            Dim nuevoCuotaBase, nuevoNumCuotas As Double
            nuevoaño = Val(Me.AñoejeTextBox.Text)
            nuevoLotMayor = Val(Me.TxtLotMayor.Text)
            nuevoLotJuvenil = Val(Me.TxtLotJuvenil.Text)
            nuevoOrdMayor = Val(Me.TxtOrdMayor.Text)
            nuevoOrdJuvenil = Val(Me.TxtOrdJuvenil.Text)
            nuevoNavMayor = Val(Me.TxtNavidadMayor.Text)
            nuevoNavJuvenil = Val(Me.TxtNavidadJuvenil.Text)
            nuevoNiñoMayor = Val(Me.TxtNiñoMayor.Text)
            nuevoNiñoJuvenil = Val(Me.TxtNiñoJuvenil.Text)
            nuevoNumOrd = Val(Me.TxtNumOrdinarios.Text)
            nuevoCuotaBase = Val(Me.TxtBase.Text)
            nuevoNumCuotas = Val(Me.TxtCuotas.Text)

            Try
                EjercicioTableAdapter.UpdateLoteria(nuevoLotMayor, nuevoLotJuvenil, nuevoOrdMayor, nuevoOrdJuvenil,
                nuevoNavMayor, nuevoNavJuvenil, nuevoNiñoMayor, nuevoNiñoJuvenil, nuevoNumOrd, nuevoCuotaBase, nuevoNumCuotas)

            Catch ex As Exception
                MsgBox("error al guardar")
            End Try

            'Actualizar importe Cuota en Tipos_de_Cuota

            Dim c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11 As Double
            Dim c12, c13, c14, c15, c16, c17, c18, c19, c20, c21 As Double

            c1 = Val(Txt1.Text)
            c2 = Val(Txt2.Text)
            c3 = Val(Txt3.Text)
            c4 = Val(Txt4.Text)
            c5 = Val(Txt5.Text)
            c6 = Val(Txt6.Text)
            c7 = Val(Txt7.Text)
            c8 = Val(Txt8.Text)
            c9 = Val(Txt9.Text)
            c10 = Val(Txt10.Text)
            c11 = Val(Txt11.Text)
            c12 = Val(Txt12.Text)
            c13 = Val(Txt13.Text)
            c14 = Val(Txt14.Text)
            c15 = Val(Txt15.Text)
            c16 = Val(Txt16.Text)
            c17 = Val(Txt17.Text)
            c18 = Val(Txt18.Text)
            c19 = Val(Txt19.Text)
            c20 = Val(Txt20.Text)
            c21 = Val(Txt21.Text)

            Dim objadapterCuotas As New DbCensosTableAdapters.tipo_de_cuotasTableAdapter

            Try
                objadapterCuotas.UpdateCuota(c1, 1)
                objadapterCuotas.UpdateCuota(c2, 2)
                objadapterCuotas.UpdateCuota(c3, 3)
                objadapterCuotas.UpdateCuota(c4, 4)
                objadapterCuotas.UpdateCuota(c5, 5)
                objadapterCuotas.UpdateCuota(c6, 6)
                objadapterCuotas.UpdateCuota(c7, 7)
                objadapterCuotas.UpdateCuota(c8, 8)
                objadapterCuotas.UpdateCuota(c9, 9)
                objadapterCuotas.UpdateCuota(c10, 10)
                objadapterCuotas.UpdateCuota(c11, 11)
                objadapterCuotas.UpdateCuota(c12, 12)
                objadapterCuotas.UpdateCuota(c13, 13)
                objadapterCuotas.UpdateCuota(c14, 14)
                objadapterCuotas.UpdateCuota(c15, 15)
                objadapterCuotas.UpdateCuota(c16, 16)
                objadapterCuotas.UpdateCuota(c17, 17)
                objadapterCuotas.UpdateCuota(c18, 18)
                objadapterCuotas.UpdateCuota(c19, 19)
                objadapterCuotas.UpdateCuota(c20, 20)
                objadapterCuotas.UpdateCuota(c21, 21)

                EstadoTableAdapter.UpdateEstadoCuotas()
                Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)

                Me.Validate()
                'Me.Tipo_de_cuotasBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.DbCensosDataSet)
                'Me.DbCensosDataSet.AcceptChanges()
                MsgBox("Actualizado Cuotas" & vbCrLf & ">>>  Si es una nueva cuota durante el ejercicio en curso, debes Actualizar la tabla de falleros")

                Me.AsignarCuotaNuevaCheckBox.Enabled = False
                Me.AsignarCuotaNuevaCheckBox.Text = "Cuotas asignadas"
                Me.AsignarCuotaNuevaCheckBox.Checked = 1
            Catch ex As Exception
                MsgBox("error al guardar")
            End Try

        End If
        Me.Tipo_de_cuotasTableAdapter.Fill(DbCensos.tipo_de_cuotas)
        Me.Tipo_de_cuotasDataGridView.Refresh()
        BtnCalcular.Enabled = True
        BtnGuardarCambios.Enabled = False
        BtnSalir.Enabled = True
        If AsignarValoresFalleroCheckBox.CheckState = 1 Then
            BtnActualizarTablaFalleros.Enabled = True
        End If

    End Sub

    Private Sub BtnActualizarTablaFalleros_Click(sender As Object, e As EventArgs) Handles BtnActualizarTablaFalleros.Click
        Dim frm As New FrmCambiarCuotas
        frm.Show()
    End Sub
End Class