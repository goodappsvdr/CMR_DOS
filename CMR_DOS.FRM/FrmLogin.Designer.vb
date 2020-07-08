<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Superior = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_Inferior = New System.Windows.Forms.Panel()
        Me.Btn_IniciarSesion = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Superior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(39, 241)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(202, 27)
        Me.PasswordLabel.TabIndex = 33
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(39, 190)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 27)
        Me.UsernameLabel.TabIndex = 31
        Me.UsernameLabel.Text = "Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(40, 220)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(251, 22)
        Me.UsernameTextBox.TabIndex = 32
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(40, 271)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(251, 22)
        Me.PasswordTextBox.TabIndex = 34
        '
        'Panel_Superior
        '
        Me.Panel_Superior.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel_Superior.Controls.Add(Me.Panel1)
        Me.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Superior.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Superior.Name = "Panel_Superior"
        Me.Panel_Superior.Size = New System.Drawing.Size(318, 32)
        Me.Panel_Superior.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 50)
        Me.Panel1.TabIndex = 38
        '
        'Panel_Inferior
        '
        Me.Panel_Inferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Inferior.Location = New System.Drawing.Point(0, 475)
        Me.Panel_Inferior.Name = "Panel_Inferior"
        Me.Panel_Inferior.Size = New System.Drawing.Size(318, 15)
        Me.Panel_Inferior.TabIndex = 38
        '
        'Btn_IniciarSesion
        '
        Me.Btn_IniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_IniciarSesion.FlatAppearance.BorderSize = 0
        Me.Btn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_IniciarSesion.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Btn_IniciarSesion.ForeColor = System.Drawing.Color.White
        Me.Btn_IniciarSesion.Location = New System.Drawing.Point(41, 314)
        Me.Btn_IniciarSesion.Name = "Btn_IniciarSesion"
        Me.Btn_IniciarSesion.Size = New System.Drawing.Size(250, 45)
        Me.Btn_IniciarSesion.TabIndex = 40
        Me.Btn_IniciarSesion.Text = "Iniciar Sesion"
        Me.Btn_IniciarSesion.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Location = New System.Drawing.Point(41, 374)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(250, 45)
        Me.Btn_Cancelar.TabIndex = 41
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CMR_DOS.FRM.My.Resources.Resources.logo_coop
        Me.PictureBox1.Location = New System.Drawing.Point(40, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(318, 490)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_IniciarSesion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel_Inferior)
        Me.Controls.Add(Me.Panel_Superior)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.Panel_Superior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Panel_Superior As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_Inferior As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_IniciarSesion As Button
    Friend WithEvents Btn_Cancelar As Button
End Class
