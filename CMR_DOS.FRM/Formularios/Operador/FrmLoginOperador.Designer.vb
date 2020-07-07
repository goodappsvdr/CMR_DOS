<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLoginOperador
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoginOperador))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CmdCancelar = New Telerik.WinControls.UI.RadButton()
        Me.CmdAceptar = New Telerik.WinControls.UI.RadButton()
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.CmdCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(18, 14)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(18, 71)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(202, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(20, 35)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(205, 22)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(20, 92)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(205, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Location = New System.Drawing.Point(123, 147)
        Me.CmdCancelar.Name = "CmdCancelar"
        '
        '
        '
        Me.CmdCancelar.RootElement.ControlBounds = New System.Drawing.Rectangle(123, 147, 110, 24)
        Me.CmdCancelar.Size = New System.Drawing.Size(97, 24)
        Me.CmdCancelar.TabIndex = 30
        Me.CmdCancelar.TabStop = False
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.ThemeName = "Office2007Silver"
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Location = New System.Drawing.Point(20, 147)
        Me.CmdAceptar.Name = "CmdAceptar"
        '
        '
        '
        Me.CmdAceptar.RootElement.ControlBounds = New System.Drawing.Rectangle(20, 147, 110, 24)
        Me.CmdAceptar.Size = New System.Drawing.Size(97, 24)
        Me.CmdAceptar.TabIndex = 29
        Me.CmdAceptar.TabStop = False
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.ThemeName = "Office2007Silver"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(Me.CmdCancelar)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.CmdAceptar)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(113, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 187)
        Me.Panel1.TabIndex = 31
        '
        'FrmLoginOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 366)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 366)
        Me.Name = "FrmLoginOperador"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Operadores"
        CType(Me.CmdCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents CmdCancelar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdAceptar As Telerik.WinControls.UI.RadButton
    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
