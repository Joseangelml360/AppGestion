Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form With {.MdiParent = Me}

        ChildForm.Show()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog With
            {.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            .Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"}
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog With
            {.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            .Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"}

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    'Private m_ChildFormNumber As Integer

    Private Sub Censos_Click(sender As Object, e As EventArgs) Handles Censos.Click

    End Sub

    Private Sub DataEconomicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataEconomicosToolStripMenuItem.Click
        Dim frm As New FrmDatosEconomicos With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        End
    End Sub

    Private Sub DataFiliacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataFiliacionToolStripMenuItem.Click
        Dim frm As New FrmDatosFiliacion With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub AltaFalleroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaFalleroToolStripMenuItem.Click
        Dim frm As New FrmAltaFallero With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub HistorialDeFalleroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeFalleroToolStripMenuItem.Click
        Dim frm As New FrmHistorial With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub HistóricoPorAñoEjercicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoPorAñoEjercicioToolStripMenuItem.Click
        Dim frm As New FrmCensoHistorico With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub EstadísiticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísiticaToolStripMenuItem.Click
        Dim frm As New FrmEstadisticaCenso With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        Dim frm As New FrmNuevaRemesa With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub VerRemesaGeneradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerRemesaGeneradaToolStripMenuItem.Click
        Dim frm As New FrmGenerarRemesa With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub EnviarAlBancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarAlBancoToolStripMenuItem.Click
        Dim frm As New FrmEnviarRemesa With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click
        Dim frm As New FrmRemesaGenerada With {.MdiParent = Me}
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub ListadoRemesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoRemesasToolStripMenuItem.Click
        Dim frm As New FrmRemesas() With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub VerDevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerDevolucionesToolStripMenuItem.Click
        Dim frm As New FrmDevoluciones With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub TsApliDev_Click(sender As Object, e As EventArgs) Handles TsApliDev.Click
        Dim frm As New FrmAplicarDevoluciones With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub DeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudoresToolStripMenuItem.Click
        Dim frm As New Deudores With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub BancoOrdenanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancoOrdenanteToolStripMenuItem.Click
        Dim frm As New FrmBancos With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub CuotasEjercicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuotasEjercicioToolStripMenuItem.Click
        Dim frm As New FrmCuotasEjercicio With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub CensoPorApellidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CensoPorApellidosToolStripMenuItem.Click
        Dim frm As New FrmListadoFalleros With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub BeneficiosEjercicioAnteriorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiosEjercicioAnteriorToolStripMenuItem.Click
        Dim frm As New FrmBenefLot With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub FallerosConLoteríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FallerosConLoteríaToolStripMenuItem.Click
        Dim frm As New FrmFallerosConLoteria With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub JuntaDirectivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuntaDirectivaToolStripMenuItem.Click
        Dim frm As New FrmJuntaDirectiva With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub VerCambiosDeComisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerCambiosDeComisiónToolStripMenuItem.Click
        Dim frm As New FrmVerPases With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub CuotasConErrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuotasConErrorToolStripMenuItem.Click
        Dim frm As New FrmCuotasError With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub TitularesCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitularesCuentaToolStripMenuItem.Click
        Dim frm As New FrmActualizarCuenta With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub TablaFallas_Click(sender As Object, e As EventArgs) Handles TablaFallas.Click
        Dim frm As New FrmFallas With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub TablaRecompensas_Click(sender As Object, e As EventArgs) Handles TablaRecompensas.Click
        Dim frm As New FrmRecompensas With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TablaCargos.Click
        Dim frm As New FrmCargos With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub FinalizarIniciarNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizarIniciarNuevoToolStripMenuItem.Click
        Dim frm As New FrmFinalizarEjercicio With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub DatosDeInicioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DatosDeInicioToolStripMenuItem1.Click
        Dim frm As New FrmIniciarEjercicio With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub DescuentoDeLaCuotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentoDeLaCuotaToolStripMenuItem.Click
        Dim frm As New FrmDescuentos With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StatusBar1.Panels(0).Text = "Usuario: " & user & " (" & cRol & ")"
        Me.StatusBar1.Panels(1).Text = Now
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If nRol <> 1 Then
            GenerarToolStripMenuItem.Enabled = False
        End If

        Select Case nRol
            Case 2
                Remesas.Enabled = False
                GenerarToolStripMenuItem.Enabled = True
            Case 3
                FinalizarEjercicioToolStripMenuItem.Enabled = False
                TablaCargos.Enabled = False
                TablaRecompensas.Enabled = False
                TablaFallas.Enabled = False
                DataFiliacionToolStripMenuItem.Enabled = False
                FrmHistorial.Button2.Enabled = False
                FrmHistorial.Button3.Enabled = False
                FrmHistorial.Button4.Enabled = False
            Case 4
                Censos.Enabled = False
                Remesas.Enabled = False
                MantenimientoMenu.Enabled = False
            Case 5
                Censos.Enabled = False
                Remesas.Enabled = False
                MantenimientoMenu.Enabled = False
        End Select


    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
        Help.ShowHelp(Me, "Ayuda.chm", HelpNavigator.TopicId, "MenuCensos")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New AboutBox1 With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub FichaFalleroVacia_Click(sender As Object, e As EventArgs) Handles FichaFalleroVacia.Click
        'Dim frm As New FichaEnBlanco With {.MdiParent = Me}
        'frm.Show()
    End Sub

    Private Sub VolverACrearArchivoQ19ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverACrearArchivoQ19ToolStripMenuItem.Click
        Dim frm As New FrmGenerarArchivoQ19 With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub DetalleDeCuotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeCuotasToolStripMenuItem.Click
        Dim frm As New FrmDetalleCuotas With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub ListadoRamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoRamosToolStripMenuItem.Click
        Dim frm As New FrmRamosPresentacionOfrenda With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub ListadoPorFamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoPorFamiliaToolStripMenuItem.Click
        Dim frm As New FrmListadoPorFamilias With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Dim frm As New FrmVerRecompensas With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub GenerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarToolStripMenuItem.Click
        Dim frm As New FrmRecompEjercicio With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub HistóricoRecompensasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoRecompensasToolStripMenuItem.Click
        Dim frm As New FrmHistoricoRecompensas With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub AcreedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcreedoresToolStripMenuItem.Click
        Dim frm As New FrmAcreedores With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub ListadoCuotasDelEjercicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoCuotasDelEjercicioToolStripMenuItem.Click
        Dim frm As New FrmOpcionesCuotasEjercicio With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub AsignarNuevasCuotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarNuevasCuotasToolStripMenuItem.Click
        Dim frm As New FrmAsignarCuotas With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub FallerosSinDomiciliarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FallerosSinDomiciliarToolStripMenuItem.Click
        Dim frm As New FrmFallerosSinBanco With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub AltasDelEjercicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasDelEjercicioToolStripMenuItem.Click
        Dim frm As New FrmAltasEjercicio With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub BajasDelEjercicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasDelEjercicioToolStripMenuItem.Click
        Dim frm As New FrmBajasEjercicio With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub MensajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MensajesToolStripMenuItem.Click
        Dim frm As New FrmMensajes With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub EditarRecompensasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarRecompensasToolStripMenuItem.Click
        Dim frm As New FrmEditarRecompensas With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub CriterioRecompensasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriterioRecompensasToolStripMenuItem.Click
        Dim frm As New FrmCriterioRecompensas With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub WebJCFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebJCFToolStripMenuItem.Click
        Dim frm As New FrmNavegador_web With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub ListadoFallerosConDescuentoPorFamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoFallerosConDescuentoPorFamiliaToolStripMenuItem.Click
        Dim frm As New FrmFallerosDescuentoFamilia With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub RegistroBrillantesFallaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroBrillantesFallaToolStripMenuItem.Click
        Dim frm As New FrmBrillantesFalla With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub PlantillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlantillaToolStripMenuItem.Click
        Dim frm As New FrmFicha With {.MdiParent = Me}
        frm.Show()

    End Sub

    Private Sub FichaFalleroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FichaFalleroToolStripMenuItem1.Click
        Dim frm As New FrmFichaDatos With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub HistorialParaExternosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialParaExternosToolStripMenuItem.Click
        Dim frm As New FrmHistroialDeFallero With {.MdiParent = Me}
        frm.Show()
    End Sub
End Class
