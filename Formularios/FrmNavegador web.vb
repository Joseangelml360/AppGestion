Public Class FrmNavegador_web
    Private Sub FrmNavegador_web_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer el motor de renderizado a IE11
        'Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION")
        'key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName & ".exe", 11001, Microsoft.Win32.RegistryValueKind.DWord)
        'key.Close()
        ' Suprimir errores de script
        WebBrowser1.ScriptErrorsSuppressed = True
        'cargar la página web de secretaría virtual JCF
        WebBrowser1.Navigate("https://virtual.fallas.com/j15")
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        WebBrowser1.Navigate(Me.txtURL.Text)
    End Sub

    Private Sub BtnAdelante_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub BtnJCF_Click(sender As Object, e As EventArgs) Handles BtnJCF.Click
        WebBrowser1.Navigate("https://virtual.fallas.com/j15")
    End Sub

End Class