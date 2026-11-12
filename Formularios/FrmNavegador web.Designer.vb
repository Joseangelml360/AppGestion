<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNavegador_web
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNavegador_web))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnIr = New System.Windows.Forms.Button()
        Me.btnJCF = New System.Windows.Forms.Button()
        Me.btnAdelante = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1209, 456)
        Me.WebBrowser1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Controls.Add(Me.btnAdelante)
        Me.Panel1.Controls.Add(Me.btnJCF)
        Me.Panel1.Controls.Add(Me.btnIr)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.TxtURL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1209, 70)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1209, 456)
        Me.Panel2.TabIndex = 2
        '
        'TxtURL
        '
        Me.TxtURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtURL.Location = New System.Drawing.Point(133, 21)
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(789, 27)
        Me.TxtURL.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(1115, 13)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(70, 40)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnIr
        '
        Me.btnIr.Location = New System.Drawing.Point(927, 18)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(75, 30)
        Me.btnIr.TabIndex = 2
        Me.btnIr.Text = "Ir a"
        Me.btnIr.UseVisualStyleBackColor = True
        '
        'btnJCF
        '
        Me.btnJCF.Location = New System.Drawing.Point(1006, 18)
        Me.btnJCF.Name = "btnJCF"
        Me.btnJCF.Size = New System.Drawing.Size(75, 30)
        Me.btnJCF.TabIndex = 3
        Me.btnJCF.Text = "Web JCF"
        Me.btnJCF.UseVisualStyleBackColor = True
        '
        'btnAdelante
        '
        Me.btnAdelante.Image = Global.AppGestion.My.Resources.Resources.arrow_right
        Me.btnAdelante.Location = New System.Drawing.Point(77, 18)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(50, 30)
        Me.btnAdelante.TabIndex = 4
        Me.btnAdelante.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.AppGestion.My.Resources.Resources.arrow_left
        Me.btnAtras.Location = New System.Drawing.Point(21, 18)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(50, 30)
        Me.btnAtras.TabIndex = 5
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'FrmNavegador_web
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNavegador_web"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Navegador WEB"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAdelante As Button
    Friend WithEvents btnJCF As Button
    Friend WithEvents btnIr As Button
    Friend WithEvents btnCerrar As Button
End Class
