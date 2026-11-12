Public Class FrmBrillantesFalla
    Private estado As Integer
    Private Sub FrmBrillantesFalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.FalleroComision' Puede moverla o quitarla según sea necesario.
        Me.FalleroComisionTableAdapter.FillListadoFalleros(Me.DataSetFallero.FalleroComision)
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.brillantesfalla' Puede moverla o quitarla según sea necesario.
        Me.BrillantesfallaTableAdapter.Fill(Me.DataSetFallero.brillantesfalla)
        Me.DataGridView1.Width = 580
        Me.DataGridView1.Refresh()
        Me.DgvBuscarFallero.Visible = False
        Me.TxtBuscar.Visible = False
        Me.Panel1.Visible = False
        Me.TxtBuscar.Visible = False
        Me.TxtCodigo.Enabled = False
        Me.TxtNombre.Enabled = False
        Me.TxtApellidos.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Me.DataGridView1.Width = 400
        Me.DataGridView1.Visible = False
        Me.Panel1.Visible = True
        Me.TxtBuscar.Visible = True
        Me.LblSelect.Visible = True
        Me.TxtBuscar.Focus()
        Me.TxtBuscar.Text = ""
        Me.BtnAñadir.Enabled = False
        Me.BtnEditar.Enabled = False
        Me.BtnGuardar.Enabled = False

        estado = 1

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Me.DataGridView1.Width = 400
        Me.Panel1.Visible = True
        Me.TxtBuscar.Visible = False
        Me.BtnAñadir.Enabled = False
        Me.BtnEditar.Enabled = False

        estado = 2
        Me.TxtId.Text = Me.DataGridView1.CurrentRow.Cells(0).Value
        Me.TxtCodigo.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
        Me.TxtNombre.Text = Me.DataGridView1.CurrentRow.Cells(2).Value
        Me.TxtApellidos.Text = Me.DataGridView1.CurrentRow.Cells(3).Value
        Me.TxtNSerie.Text = Me.DataGridView1.CurrentRow.Cells(4).Value

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DataGridView1.Width = 580
        Me.DataGridView1.Refresh()
        Me.DgvBuscarFallero.Visible = False
        Me.TxtBuscar.Visible = False
        Me.Panel1.Visible = False
        Me.TxtBuscar.Visible = False
        Me.BtnAñadir.Enabled = True
        Me.BtnEditar.Enabled = True
        estado = 0

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim id, serie, codigo As Integer
        Dim nombre, apellidos As String

        If Me.TxtId.Text = "" Then
            TxtId.Text = 0
        Else
            id = CInt(Me.TxtId.Text)
        End If

        For Each c As Control In Me.Panel1.Controls
            If TypeOf c Is TextBox Then
                If c.Text = "" Then
                    MsgBox("No se puede guardar si hay un campo sin datos." & vbCrLf &
                           "Revisa y vuelve a intentarlo")
                    Exit Sub
                End If
            End If
        Next

        codigo = CInt(TxtCodigo.Text)
        nombre = TxtNombre.Text
        apellidos = TxtApellidos.Text
        If IsNumeric(TxtNSerie.Text) Then
            serie = CInt(TxtNSerie.Text)
        Else
            MsgBox("Error de escritura, el Nº de serie tiene que ser un número")
            Me.TxtNSerie.Text = ""
            Me.TxtNSerie.Focus()
            Exit Sub
        End If

        If estado = 1 Then
            Try
                Me.BrillantesfallaTableAdapter.InsertQuery(codigo, nombre, apellidos, serie)
                MsgBox("Registro guardado")
            Catch ex As MySql.Data.MySqlClient.MySqlException
                If ex.Number = 1062 Then
                    MsgBox("El Nº de serie no puede estar repetido, debe ser un valor único para cada fallero")
                End If
                'MsgBox("No se ha guardado el registro, error: " & ex.Number & ex.Message)
            End Try

        ElseIf estado = 2 Then
            Try
                Me.BrillantesfallaTableAdapter.UpdateQuery(codigo, nombre, apellidos, serie, id)
                MsgBox("Registro guardado")
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox("No se ha guardado el registro, error: " & ex.number & ex.Message)
            End Try
        End If

        Me.DataGridView1.Width = 580
        Me.DgvBuscarFallero.Visible = False
        Me.TxtBuscar.Visible = False
        Me.Panel1.Visible = False
        estado = 0
        For Each c As Control In Me.Panel1.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        Me.DataSetFallero.brillantesfalla.Clear()
        Me.BrillantesfallaTableAdapter.Fill(DataSetFallero.brillantesfalla)
        Me.DataGridView1.DataSource = Me.DataSetFallero.brillantesfalla
        Me.DataGridView1.Refresh()
        Me.BtnAñadir.Enabled = True
        Me.BtnEditar.Enabled = True

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim vista As New DataView(DataSetFallero.FalleroComision)
        If TxtBuscar.Text <> "" Then
            vista.RowFilter = $"Apellidos LIKE '%{TxtBuscar.Text}%'"
        End If
        Me.DgvBuscarFallero.DataSource = vista
        Me.DgvBuscarFallero.Visible = True
        Me.DgvBuscarFallero.Width = 400
        Me.DgvBuscarFallero.Height = 400
        Me.DgvBuscarFallero.Refresh()

    End Sub

    Private Sub DgvBuscarFallero_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBuscarFallero.CellContentClick
        Me.TxtCodigo.Text = Me.DgvBuscarFallero.CurrentRow.Cells(0).Value
        Me.TxtApellidos.Text = Me.DgvBuscarFallero.CurrentRow.Cells(1).Value
        Me.TxtNombre.Text = Me.DgvBuscarFallero.CurrentRow.Cells(2).Value
        Me.DgvBuscarFallero.Visible = False
        Me.TxtBuscar.Visible = False
        Me.LblSelect.Visible = False
        Me.BtnGuardar.Enabled = True
        Me.DataGridView1.Visible = True

    End Sub
End Class