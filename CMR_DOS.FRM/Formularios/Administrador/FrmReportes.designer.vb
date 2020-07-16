<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportes))
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblAccion = New System.Windows.Forms.Label()
        Me.ToolTipControl = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etiqueta1 = New System.Windows.Forms.Label()
        Me.CmdLimpiar = New Telerik.WinControls.UI.RadButton()
        Me.CmdCancelar = New Telerik.WinControls.UI.RadButton()
        Me.CmdAceptar = New Telerik.WinControls.UI.RadButton()
        Me.CmdExportar = New Telerik.WinControls.UI.RadButton()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fechahasta = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.fechadesde = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.etiqueta3 = New System.Windows.Forms.Label()
        Me.EstadosCtrl1 = New CMR_DOS.CTRL.EstadosCtrl()
        Me.GeneralCrl4 = New CMR_DOS.CTRL.GeneralCrl()
        Me.GeneralCrl2 = New CMR_DOS.CTRL.GeneralCrl()
        Me.GeneralCrl1 = New CMR_DOS.CTRL.GeneralCrl()
        Me.PanelColor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.fechahasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechadesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelColor.Controls.Add(Me.PictureBox1)
        Me.PanelColor.Controls.Add(Me.LblAccion)
        Me.PanelColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelColor.Location = New System.Drawing.Point(0, 548)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(658, 25)
        Me.PanelColor.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblAccion
        '
        Me.LblAccion.AutoSize = True
        Me.LblAccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccion.ForeColor = System.Drawing.Color.White
        Me.LblAccion.Location = New System.Drawing.Point(9, 6)
        Me.LblAccion.Name = "LblAccion"
        Me.LblAccion.Size = New System.Drawing.Size(38, 13)
        Me.LblAccion.TabIndex = 0
        Me.LblAccion.Text = "Ready"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(87, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "VER SEGÚN"
        '
        'etiqueta1
        '
        Me.etiqueta1.BackColor = System.Drawing.Color.Transparent
        Me.etiqueta1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.etiqueta1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.etiqueta1.Location = New System.Drawing.Point(3, 113)
        Me.etiqueta1.Name = "etiqueta1"
        Me.etiqueta1.Size = New System.Drawing.Size(150, 16)
        Me.etiqueta1.TabIndex = 41
        Me.etiqueta1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdLimpiar
        '
        Me.CmdLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLimpiar.Location = New System.Drawing.Point(12, 518)
        Me.CmdLimpiar.Name = "CmdLimpiar"
        '
        '
        '
        Me.CmdLimpiar.RootElement.ControlBounds = New System.Drawing.Rectangle(12, 518, 110, 24)
        Me.CmdLimpiar.Size = New System.Drawing.Size(97, 24)
        Me.CmdLimpiar.TabIndex = 71
        Me.CmdLimpiar.Text = "Limpiar"
        Me.CmdLimpiar.ThemeName = "Office2007Silver"
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdCancelar.Location = New System.Drawing.Point(553, 518)
        Me.CmdCancelar.Name = "CmdCancelar"
        '
        '
        '
        Me.CmdCancelar.RootElement.ControlBounds = New System.Drawing.Rectangle(553, 518, 110, 24)
        Me.CmdCancelar.Size = New System.Drawing.Size(97, 24)
        Me.CmdCancelar.TabIndex = 6
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.ThemeName = "Office2007Silver"
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdAceptar.Location = New System.Drawing.Point(450, 518)
        Me.CmdAceptar.Name = "CmdAceptar"
        '
        '
        '
        Me.CmdAceptar.RootElement.ControlBounds = New System.Drawing.Rectangle(450, 518, 110, 24)
        Me.CmdAceptar.Size = New System.Drawing.Size(97, 24)
        Me.CmdAceptar.TabIndex = 5
        Me.CmdAceptar.Text = "Ver Reporte"
        Me.CmdAceptar.ThemeName = "Office2007Silver"
        '
        'CmdExportar
        '
        Me.CmdExportar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdExportar.Location = New System.Drawing.Point(347, 518)
        Me.CmdExportar.Name = "CmdExportar"
        '
        '
        '
        Me.CmdExportar.RootElement.ControlBounds = New System.Drawing.Rectangle(347, 518, 110, 24)
        Me.CmdExportar.Size = New System.Drawing.Size(97, 24)
        Me.CmdExportar.TabIndex = 90
        Me.CmdExportar.Text = "Exportar"
        Me.CmdExportar.ThemeName = "Office2007Silver"
        '
        'RadPageView1
        '
        Me.RadPageView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageView1.Location = New System.Drawing.Point(7, 12)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.PageBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage1
        Me.RadPageView1.Size = New System.Drawing.Size(644, 493)
        Me.RadPageView1.TabIndex = 92
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Silver"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageViewPage1.Controls.Add(Me.Label4)
        Me.RadPageViewPage1.Controls.Add(Me.Label3)
        Me.RadPageViewPage1.Controls.Add(Me.fechahasta)
        Me.RadPageViewPage1.Controls.Add(Me.fechadesde)
        Me.RadPageViewPage1.Controls.Add(Me.Label2)
        Me.RadPageViewPage1.Controls.Add(Me.etiqueta3)
        Me.RadPageViewPage1.Controls.Add(Me.etiqueta1)
        Me.RadPageViewPage1.Controls.Add(Me.Label1)
        Me.RadPageViewPage1.Controls.Add(Me.EstadosCtrl1)
        Me.RadPageViewPage1.Controls.Add(Me.GeneralCrl4)
        Me.RadPageViewPage1.Controls.Add(Me.GeneralCrl2)
        Me.RadPageViewPage1.Controls.Add(Me.GeneralCrl1)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(620, 441)
        Me.RadPageViewPage1.Text = "Información"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(367, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(87, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "BUSCAR DE"
        '
        'fechahasta
        '
        Me.fechahasta.Location = New System.Drawing.Point(387, 58)
        Me.fechahasta.Name = "fechahasta"
        Me.fechahasta.Size = New System.Drawing.Size(203, 20)
        Me.fechahasta.TabIndex = 100
        Me.fechahasta.TabStop = False
        Me.fechahasta.Text = "jueves, 11 de octubre de 2018"
        Me.fechahasta.ThemeName = "Office2007Silver"
        Me.fechahasta.Value = New Date(2018, 10, 11, 11, 8, 42, 0)
        '
        'fechadesde
        '
        Me.fechadesde.Location = New System.Drawing.Point(159, 58)
        Me.fechadesde.Name = "fechadesde"
        Me.fechadesde.Size = New System.Drawing.Size(203, 20)
        Me.fechadesde.TabIndex = 99
        Me.fechadesde.TabStop = False
        Me.fechadesde.Text = "martes, 9 de octubre de 2018"
        Me.fechadesde.ThemeName = "Office2007Silver"
        Me.fechadesde.Value = New Date(2018, 10, 9, 11, 30, 16, 893)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(42, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "ESTADO DE TURNOS"
        '
        'etiqueta3
        '
        Me.etiqueta3.BackColor = System.Drawing.Color.Transparent
        Me.etiqueta3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.etiqueta3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.etiqueta3.Location = New System.Drawing.Point(3, 140)
        Me.etiqueta3.Name = "etiqueta3"
        Me.etiqueta3.Size = New System.Drawing.Size(150, 16)
        Me.etiqueta3.TabIndex = 82
        Me.etiqueta3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EstadosCtrl1
        '
        Me.EstadosCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadosCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.EstadosCtrl1.FormattingEnabled = True
        Me.EstadosCtrl1.Location = New System.Drawing.Point(159, 31)
        Me.EstadosCtrl1.Name = "EstadosCtrl1"
        Me.EstadosCtrl1.Size = New System.Drawing.Size(431, 21)
        Me.EstadosCtrl1.TabIndex = 97
        '
        'GeneralCrl4
        '
        Me.GeneralCrl4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneralCrl4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GeneralCrl4.FormattingEnabled = True
        Me.GeneralCrl4.Location = New System.Drawing.Point(159, 139)
        Me.GeneralCrl4.Name = "GeneralCrl4"
        Me.GeneralCrl4.Size = New System.Drawing.Size(431, 21)
        Me.GeneralCrl4.TabIndex = 96
        '
        'GeneralCrl2
        '
        Me.GeneralCrl2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneralCrl2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GeneralCrl2.FormattingEnabled = True
        Me.GeneralCrl2.Location = New System.Drawing.Point(159, 112)
        Me.GeneralCrl2.Name = "GeneralCrl2"
        Me.GeneralCrl2.Size = New System.Drawing.Size(431, 21)
        Me.GeneralCrl2.TabIndex = 94
        '
        'GeneralCrl1
        '
        Me.GeneralCrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneralCrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GeneralCrl1.FormattingEnabled = True
        Me.GeneralCrl1.Location = New System.Drawing.Point(159, 84)
        Me.GeneralCrl1.Name = "GeneralCrl1"
        Me.GeneralCrl1.Size = New System.Drawing.Size(431, 21)
        Me.GeneralCrl1.TabIndex = 93
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(658, 573)
        Me.Controls.Add(Me.CmdExportar)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdLimpiar)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.RadPageView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(674, 612)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(674, 612)
        Me.Name = "FrmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubSecciones para Usuarios .-"
        Me.PanelColor.ResumeLayout(False)
        Me.PanelColor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdExportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage1.ResumeLayout(False)
        Me.RadPageViewPage1.PerformLayout()
        CType(Me.fechahasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechadesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme




    Friend WithEvents PanelColor As System.Windows.Forms.Panel
    Friend WithEvents LblAccion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTipControl As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etiqueta1 As System.Windows.Forms.Label
    Private WithEvents CmdLimpiar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdCancelar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdAceptar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdExportar As Telerik.WinControls.UI.RadButton
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents GeneralCrl1 As CMR_DOS.CTRL.GeneralCrl
    Friend WithEvents GeneralCrl2 As CMR_DOS.CTRL.GeneralCrl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EstadosCtrl1 As CMR_DOS.CTRL.EstadosCtrl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fechahasta As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents fechadesde As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents etiqueta3 As Label
    Friend WithEvents GeneralCrl4 As CTRL.GeneralCrl


End Class
