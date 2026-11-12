<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompararJCF_Falla
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSelectFile = New System.Windows.Forms.Button()
        Me.TxtExcelName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comparar Censo con registros de JCF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccionar archivo de JCF"
        '
        'BtnSelectFile
        '
        Me.BtnSelectFile.Image = Global.AppGestion.My.Resources.Resources.folder_page
        Me.BtnSelectFile.Location = New System.Drawing.Point(215, 57)
        Me.BtnSelectFile.Name = "BtnSelectFile"
        Me.BtnSelectFile.Size = New System.Drawing.Size(51, 50)
        Me.BtnSelectFile.TabIndex = 1
        Me.BtnSelectFile.Text = "..."
        Me.BtnSelectFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSelectFile.UseVisualStyleBackColor = True
        '
        'TxtExcelName
        '
        Me.TxtExcelName.Location = New System.Drawing.Point(283, 74)
        Me.TxtExcelName.Name = "TxtExcelName"
        Me.TxtExcelName.Size = New System.Drawing.Size(275, 22)
        Me.TxtExcelName.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.AppGestion.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1308, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCompararJCF_Falla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtExcelName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSelectFile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCompararJCF_Falla"
        Me.Text = "FrmCompararJCF_Falla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSelectFile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtExcelName As TextBox
    Friend WithEvents Button1 As Button
End Class
