<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmElegirBoxActual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmElegirBoxActual))
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.BoxesCtrl1 = New CMR_DOS.CTRL.BoxesCtrl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdAceptar = New Telerik.WinControls.UI.RadButton()
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BoxesCtrl1
        '
        Me.BoxesCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxesCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BoxesCtrl1.FormattingEnabled = True
        Me.BoxesCtrl1.Location = New System.Drawing.Point(28, 50)
        Me.BoxesCtrl1.Name = "BoxesCtrl1"
        Me.BoxesCtrl1.Size = New System.Drawing.Size(154, 21)
        Me.BoxesCtrl1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(25, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "ELIJA EL BOX ACTUAL:"
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdAceptar.Location = New System.Drawing.Point(53, 91)
        Me.CmdAceptar.Name = "CmdAceptar"
        '
        '
        '
        Me.CmdAceptar.RootElement.ControlBounds = New System.Drawing.Rectangle(53, 91, 110, 24)
        Me.CmdAceptar.Size = New System.Drawing.Size(97, 24)
        Me.CmdAceptar.TabIndex = 83
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.ThemeName = "Office2007Silver"
        '
        'FrmElegirBoxActual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(197, 132)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BoxesCtrl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(213, 171)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(213, 171)
        Me.Name = "FrmElegirBoxActual"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elige el box actual"
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents BoxesCtrl1 As CMR_DOS.CTRL.BoxesCtrl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents CmdAceptar As Telerik.WinControls.UI.RadButton

End Class
