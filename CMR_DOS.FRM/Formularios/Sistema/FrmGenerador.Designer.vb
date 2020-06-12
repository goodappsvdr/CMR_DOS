<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerador))
        Me.CboTablas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstColumnasClave = New System.Windows.Forms.CheckedListBox()
        Me.LstColumnas = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmdGenerar = New System.Windows.Forms.Button()
        Me.Cmd_SP = New System.Windows.Forms.Button()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelColor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboTablas
        '
        Me.CboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTablas.FormattingEnabled = True
        Me.CboTablas.Location = New System.Drawing.Point(46, 23)
        Me.CboTablas.Name = "CboTablas"
        Me.CboTablas.Size = New System.Drawing.Size(434, 21)
        Me.CboTablas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tabla"
        '
        'LstColumnasClave
        '
        Me.LstColumnasClave.CheckOnClick = True
        Me.LstColumnasClave.FormattingEnabled = True
        Me.LstColumnasClave.Location = New System.Drawing.Point(46, 74)
        Me.LstColumnasClave.Name = "LstColumnasClave"
        Me.LstColumnasClave.Size = New System.Drawing.Size(214, 276)
        Me.LstColumnasClave.TabIndex = 2
        '
        'LstColumnas
        '
        Me.LstColumnas.CheckOnClick = True
        Me.LstColumnas.FormattingEnabled = True
        Me.LstColumnas.Location = New System.Drawing.Point(266, 74)
        Me.LstColumnas.Name = "LstColumnas"
        Me.LstColumnas.Size = New System.Drawing.Size(214, 276)
        Me.LstColumnas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Campos Clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Buscar por Campos"
        '
        'CmdGenerar
        '
        Me.CmdGenerar.Location = New System.Drawing.Point(46, 356)
        Me.CmdGenerar.Name = "CmdGenerar"
        Me.CmdGenerar.Size = New System.Drawing.Size(214, 48)
        Me.CmdGenerar.TabIndex = 6
        Me.CmdGenerar.Text = "Generar Clase"
        Me.CmdGenerar.UseVisualStyleBackColor = True
        '
        'Cmd_SP
        '
        Me.Cmd_SP.Location = New System.Drawing.Point(266, 356)
        Me.Cmd_SP.Name = "Cmd_SP"
        Me.Cmd_SP.Size = New System.Drawing.Size(214, 48)
        Me.Cmd_SP.TabIndex = 7
        Me.Cmd_SP.Text = "Generar Procedimientos Almacenados"
        Me.Cmd_SP.UseVisualStyleBackColor = True
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelColor.Controls.Add(Me.PictureBox2)
        Me.PanelColor.Controls.Add(Me.PictureBox1)
        Me.PanelColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelColor.Location = New System.Drawing.Point(0, 439)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(525, 25)
        Me.PanelColor.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent

        Me.PictureBox1.Location = New System.Drawing.Point(588, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(458, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(67, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'FrmGenerador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 464)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.Cmd_SP)
        Me.Controls.Add(Me.CmdGenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LstColumnas)
        Me.Controls.Add(Me.LstColumnasClave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboTablas)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGenerador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Clases by IDEAS SA"
        Me.PanelColor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboTablas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstColumnasClave As System.Windows.Forms.CheckedListBox
    Friend WithEvents LstColumnas As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdGenerar As System.Windows.Forms.Button
    Friend WithEvents Cmd_SP As System.Windows.Forms.Button
    Friend WithEvents PanelColor As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
