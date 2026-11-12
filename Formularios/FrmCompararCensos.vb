Imports System.Data.OleDb


Public Class FrmCompararCensos

    Dim flag As Integer

    Private Sub FrmCompararCensos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        flag = 0

        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        Me.DgvInterno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvInterno.Columns(0).Width = 35
        Me.DgvInterno.Columns(3).Width = 35
        Me.DgvInterno.Visible = True
        Me.DgvOficial.Visible = True
        Me.DgvFaltan.Visible = False
        Me.DgvSobran.Visible = False
        Me.BtnAnalizar.Hide()


    End Sub
    Private Sub BtnSelectFile_Click(sender As Object, e As EventArgs) Handles BtnSelectFile.Click
        ' 1. Seleccionar archivo
        Dim ruta = SeleccionarArchivoExcel()
        If ruta Is Nothing Then
            MessageBox.Show("No se seleccionó ningún archivo.")
            Exit Sub
        End If

        ' 2. Cargar Excel en DataTable
        Dim dt = CargarExcelEnDataTable(ruta)
        DgvOficial.DataSource = dt
        'DgvOficial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvOficial.Columns(0).HeaderText = "Censo"
        DgvOficial.Columns(3).HeaderText = "Apellidos"
        DgvOficial.Columns(4).HeaderText = "Nombre"

        DgvOficial.Columns(3).DisplayIndex = 4
        DgvOficial.Columns(4).DisplayIndex = 3

        DgvOficial.Columns(1).Visible = False
        DgvOficial.Columns(2).Visible = False
        DgvOficial.Columns(5).Visible = False
        DgvOficial.Columns(6).Visible = False
        DgvOficial.Columns(7).Visible = False
        DgvOficial.Columns(8).Visible = False
        DgvOficial.Columns(9).Visible = False
        DgvOficial.Columns(10).Visible = False
        DgvOficial.Columns(11).Visible = False
        DgvOficial.Columns(12).Visible = False
        DgvOficial.Columns(13).Visible = False
        DgvOficial.Columns(14).Visible = False
        DgvOficial.Columns(15).Visible = False

        DgvOficial.Columns(0).Width = 45
        DgvOficial.Columns(4).Width = 125
        DgvOficial.Columns(3).Width = 175

        DgvOficial.Refresh()

        MessageBox.Show("Censo oficial cargado correctamente")
        Me.TxtExcelName.Text = ruta
        Me.BtnAnalizar.Show()

    End Sub

    Private Sub BtnAnalizar_Click(sender As Object, e As EventArgs) Handles BtnAnalizar.Click

        If flag = 1 Then
            DgvOficial.Show()
            DgvInterno.Show()
            DgvFaltan.Hide()
            DgvSobran.Hide()
            Me.BtnAnalizar.Text = "Analizar"
            flag = 0
            Exit Sub
        End If

        ' 3. Extraer listas
        Dim dt = CargarExcelEnDataTable(Me.TxtExcelName.Text)
        Dim listaOficial = ExtraerOficial(dt)
        Dim listaInterna = ExtraerInterno(DgvInterno)

        ' 4. Comparar y mostrar resultados
        CompararCensos(listaOficial, listaInterna, DgvFaltan, DgvSobran)
        MessageBox.Show("Comparación completada.")
        DgvOficial.Hide()
        DgvInterno.Hide()
        DgvFaltan.Show()
        DgvSobran.Show()
        DgvFaltan.Refresh()
        DgvSobran.Refresh()

        Me.BtnAnalizar.Text = "Mostrar tablas"
        flag = 1

    End Sub
    Private Function SeleccionarArchivoExcel() As String
        Dim ofd As New OpenFileDialog With {
        .Filter = "Archivos Excel|*.xlsx;*.xls",
        .Title = "Seleccionar archivo de censo oficial"
    }

        If ofd.ShowDialog() = DialogResult.OK Then

            Return ofd.FileName
        Else
            Return Nothing
        End If
    End Function

    Public Function CargarExcelEnDataTable(ruta As String) As DataTable
        Dim dt As New DataTable()

        Dim cadena As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & ruta & ";" &
        "Extended Properties='Excel 12.0 Xml;HDR=YES;'"

        Using cn As New OleDbConnection(cadena)
            cn.Open()

            Dim cmd As New OleDbCommand("SELECT * FROM [Censo$]", cn)
            Dim da As New OleDbDataAdapter(cmd)

            da.Fill(dt)
        End Using

        Return dt
    End Function

    Public Function ExtraerOficial(dt As DataTable) As List(Of (Codigo As String, Nombre As String, Apellidos As String))
        Dim lista As New List(Of (String, String, String))

        For Each row As DataRow In dt.Rows
            Dim codigo = row("NUM#CENS").ToString().Trim()
            Dim nombre = row("NOM").ToString().Trim()
            Dim apellidos = row("COGNOMS").ToString().Trim()

            lista.Add((codigo, nombre, apellidos))
        Next

        Return lista
    End Function

    Public Function ExtraerInterno(dgv As DataGridView) As List(Of (Codigo As String, Nombre As String, Apellidos As String))
        Dim lista As New List(Of (String, String, String))

        For Each fila As DataGridViewRow In dgv.Rows
            If Not fila.IsNewRow Then
                Dim codigo = GetCellByDataPropertyName(fila, "FALLERO_CODIGO")?.ToString().Trim()
                Dim nombre = GetCellByDataPropertyName(fila, "NOMBRE")?.ToString().Trim()
                Dim apellidos = GetCellByDataPropertyName(fila, "APELLIDOS")?.ToString().Trim()
                If codigo IsNot Nothing Then
                    lista.Add((codigo, nombre, apellidos))
                End If
            End If
        Next

        Return lista
    End Function

    Public Sub CompararCensos(
    listaOficial As List(Of (Codigo As String, Nombre As String, Apellidos As String)),
    listaInterna As List(Of (Codigo As String, Nombre As String, Apellidos As String)),
    dgvFaltan As DataGridView,
    dgvSobran As DataGridView)

        ' 1. Crear conjuntos de códigos para comparación rápida
        Dim codOficial = listaOficial.Select(Function(x) x.Codigo).ToHashSet()
        Dim codInterno = listaInterna.Select(Function(x) x.Codigo).ToHashSet()

        ' 2. Registros que están en oficial pero NO en interna
        Dim faltan = listaOficial.Where(Function(x) Not codInterno.Contains(x.Codigo)).ToList()

        ' 3. Registros que están en interna pero NO en oficial
        Dim sobran = listaInterna.Where(Function(x) Not codOficial.Contains(x.Codigo)).ToList()

        ' 4. Convertir listas a DataTable para mostrarlas en los DGV
        dgvFaltan.DataSource = ListaATabla(faltan)
        dgvSobran.DataSource = ListaATabla(sobran)
        dgvFaltan.Columns(0).Width = 45
        dgvFaltan.Columns(1).Width = 75
        dgvFaltan.Columns(2).Width = 125
        dgvSobran.Columns(0).Width = 45
        dgvSobran.Columns(1).Width = 75
        dgvSobran.Columns(2).Width = 125



    End Sub

    Public Function ListaATabla(lista As List(Of (Codigo As String, Nombre As String, Apellidos As String))) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Codigo", GetType(String))
        dt.Columns.Add("Nombre", GetType(String))
        dt.Columns.Add("Apellidos", GetType(String))

        For Each item In lista
            dt.Rows.Add(item.Codigo, item.Nombre, item.Apellidos)
        Next

        Return dt
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Para usar esta funcionalidad es necesario descargar el archivo excel de la web de JCF" + Chr(13) +
               "En Mi Censo:" + Chr(13) +
               "    1. Marcar Todos Activos" + Chr(13) +
               "    2. Pulsar el botón DESCARGAR" + Chr(13) +
               "    3. En la nueva ventana, pulsar de nuevo DESCARGAR" + Chr(13) +
               "    4. Una vez generado el archivo, pulsar en Guardar como... y selecciona una carpeta para ubicarlo" + Chr(13) +
               "    5. En esta pantalla pulsa el botón Seleccionar archivo de JCF y busca el archivo .xls que has guardado y selecciónalo" + Chr(13) +
               "    6. Una vez cargado pulsa Analizar para ver las diferencias entre el Censo de JCF y el de la Falla.",, "GENERACION DEL ARCHIVO DE CENSO DE JCF")
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class