<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeriodos


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeriodos))
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblAccion = New System.Windows.Forms.Label()
        Me.ToolTipControl = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtID = New Controles_Ideas.TextData(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdAgregar = New Telerik.WinControls.UI.RadButton()
        Me.CmdModificar = New Telerik.WinControls.UI.RadButton()
        Me.CmdEliminar = New Telerik.WinControls.UI.RadButton()
        Me.CmdLimpiar = New Telerik.WinControls.UI.RadButton()
        Me.CmdCancelar = New Telerik.WinControls.UI.RadButton()
        Me.CmdAceptar = New Telerik.WinControls.UI.RadButton()
        Me.CmdExportar = New Telerik.WinControls.UI.RadButton()
        Me.CmdGrid = New Telerik.WinControls.UI.RadButton()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.Grilla = New Telerik.WinControls.UI.RadGridView()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TxtNombre = New Controles_Ideas.TextData(Me.components)
        Me.FechaHasta = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.FechaDesde = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelColor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grilla.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.FechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
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
        'TxtID
        '
        Me.TxtID.BackColor = System.Drawing.Color.White
        Me.TxtID.ColorEnter = System.Drawing.Color.Yellow
        Me.TxtID.ColorLeave = System.Drawing.Color.White
        Me.TxtID.Enabled = False
        Me.TxtID.Location = New System.Drawing.Point(214, 12)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 22)
        Me.TxtID.TabEnable = True
        Me.TxtID.TabIndex = 0
        Me.TxtID.TipoDato = System.Data.DbType.Int32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(190, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(154, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "NOMBRE"
        '
        'CmdAgregar
        '
        Me.CmdAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdAgregar.Location = New System.Drawing.Point(348, 195)
        Me.CmdAgregar.Name = "CmdAgregar"
        '
        '
        '
        Me.CmdAgregar.RootElement.ControlBounds = New System.Drawing.Rectangle(348, 195, 110, 24)
        Me.CmdAgregar.Size = New System.Drawing.Size(97, 24)
        Me.CmdAgregar.TabIndex = 67
        Me.CmdAgregar.Text = "Nuevo"
        Me.CmdAgregar.ThemeName = "Office2007Silver"
        '
        'CmdModificar
        '
        Me.CmdModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdModificar.Location = New System.Drawing.Point(451, 195)
        Me.CmdModificar.Name = "CmdModificar"
        '
        '
        '
        Me.CmdModificar.RootElement.ControlBounds = New System.Drawing.Rectangle(451, 195, 110, 24)
        Me.CmdModificar.Size = New System.Drawing.Size(97, 24)
        Me.CmdModificar.TabIndex = 68
        Me.CmdModificar.Text = "Editar"
        Me.CmdModificar.ThemeName = "Office2007Silver"
        '
        'CmdEliminar
        '
        Me.CmdEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdEliminar.Location = New System.Drawing.Point(554, 195)
        Me.CmdEliminar.Name = "CmdEliminar"
        '
        '
        '
        Me.CmdEliminar.RootElement.ControlBounds = New System.Drawing.Rectangle(554, 195, 110, 24)
        Me.CmdEliminar.Size = New System.Drawing.Size(97, 24)
        Me.CmdEliminar.TabIndex = 69
        Me.CmdEliminar.Text = "Eliminar"
        Me.CmdEliminar.ThemeName = "Office2007Silver"
        '
        'CmdLimpiar
        '
        Me.CmdLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLimpiar.Location = New System.Drawing.Point(7, 195)
        Me.CmdLimpiar.Name = "CmdLimpiar"
        '
        '
        '
        Me.CmdLimpiar.RootElement.ControlBounds = New System.Drawing.Rectangle(7, 195, 110, 24)
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
        Me.CmdCancelar.TabIndex = 5
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
        Me.CmdAceptar.TabIndex = 4
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.ThemeName = "Office2007Silver"
        '
        'CmdExportar
        '
        Me.CmdExportar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdExportar.Location = New System.Drawing.Point(53, 518)
        Me.CmdExportar.Name = "CmdExportar"
        '
        '
        '
        Me.CmdExportar.RootElement.ControlBounds = New System.Drawing.Rectangle(53, 518, 110, 24)
        Me.CmdExportar.Size = New System.Drawing.Size(97, 24)
        Me.CmdExportar.TabIndex = 90
        Me.CmdExportar.Text = "Exportar"
        Me.CmdExportar.ThemeName = "Office2007Silver"
        '
        'CmdGrid
        '
        Me.CmdGrid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdGrid.Location = New System.Drawing.Point(7, 518)
        Me.CmdGrid.Name = "CmdGrid"
        '
        '
        '
        Me.CmdGrid.RootElement.ControlBounds = New System.Drawing.Rectangle(7, 518, 110, 24)
        Me.CmdGrid.Size = New System.Drawing.Size(40, 24)
        Me.CmdGrid.TabIndex = 89
        Me.CmdGrid.Text = "+"
        Me.CmdGrid.ThemeName = "Office2007Silver"
        '
        'Grilla
        '
        Me.Grilla.AllowShowFocusCues = True
        Me.Grilla.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Grilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grilla.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Grilla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Grilla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grilla.Location = New System.Drawing.Point(6, 12)
        '
        'Grilla
        '
        Me.Grilla.MasterTemplate.AllowAddNewRow = False
        Me.Grilla.MasterTemplate.AllowColumnReorder = False
        Me.Grilla.MasterTemplate.AllowRowResize = False
        Me.Grilla.MasterTemplate.EnableAlternatingRowColor = True
        Me.Grilla.MasterTemplate.EnableFiltering = True
        Me.Grilla.MasterTemplate.EnableGrouping = False
        Me.Grilla.MasterTemplate.ShowRowHeaderColumn = False
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Grilla.ReadOnly = True
        Me.Grilla.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.Grilla.RootElement.ControlBounds = New System.Drawing.Rectangle(6, 12, 240, 150)
        Me.Grilla.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Grilla.Size = New System.Drawing.Size(645, 177)
        Me.Grilla.TabIndex = 91
        Me.Grilla.Text = "RadGridView1"
        Me.Grilla.ThemeName = "Office2007Silver"
        '
        'RadPageView1
        '
        Me.RadPageView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageView1.Location = New System.Drawing.Point(7, 227)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.PageBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage1
        Me.RadPageView1.Size = New System.Drawing.Size(644, 278)
        Me.RadPageView1.TabIndex = 92
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Silver"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RadPageViewPage1.Controls.Add(Me.TxtNombre)
        Me.RadPageViewPage1.Controls.Add(Me.FechaHasta)
        Me.RadPageViewPage1.Controls.Add(Me.FechaDesde)
        Me.RadPageViewPage1.Controls.Add(Me.Label5)
        Me.RadPageViewPage1.Controls.Add(Me.Label4)
        Me.RadPageViewPage1.Controls.Add(Me.Label2)
        Me.RadPageViewPage1.Controls.Add(Me.Label1)
        Me.RadPageViewPage1.Controls.Add(Me.TxtID)
        Me.RadPageViewPage1.ForeColor = System.Drawing.Color.Black
        Me.RadPageViewPage1.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(620, 226)
        Me.RadPageViewPage1.Text = "Información"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.ColorEnter = System.Drawing.Color.White
        Me.TxtNombre.ColorLeave = System.Drawing.Color.White
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TxtNombre.Location = New System.Drawing.Point(214, 40)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(271, 22)
        Me.TxtNombre.TabEnable = True
        Me.TxtNombre.TabIndex = 96
        Me.TxtNombre.TipoDato = System.Data.DbType.[String]
        '
        'FechaHasta
        '
        Me.FechaHasta.Location = New System.Drawing.Point(214, 95)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(271, 20)
        Me.FechaHasta.TabIndex = 95
        Me.FechaHasta.TabStop = False
        Me.FechaHasta.Text = "viernes, 21 de septiembre de 2018"
        Me.FechaHasta.ThemeName = "Office2007Silver"
        Me.FechaHasta.Value = New Date(2018, 9, 21, 9, 32, 50, 973)
        '
        'FechaDesde
        '
        Me.FechaDesde.Location = New System.Drawing.Point(214, 69)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(271, 20)
        Me.FechaDesde.TabIndex = 94
        Me.FechaDesde.TabStop = False
        Me.FechaDesde.Text = "viernes, 21 de septiembre de 2018"
        Me.FechaDesde.ThemeName = "Office2007Silver"
        Me.FechaDesde.Value = New Date(2018, 9, 21, 9, 32, 50, 973)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(168, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "HASTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(166, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "DESDE"
        '
        'FrmPeriodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(658, 573)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.CmdExportar)
        Me.Controls.Add(Me.CmdGrid)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdLimpiar)
        Me.Controls.Add(Me.CmdEliminar)
        Me.Controls.Add(Me.CmdModificar)
        Me.Controls.Add(Me.CmdAgregar)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.RadPageView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(674, 612)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(674, 612)
        Me.Name = "FrmPeriodos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodos.-"
        Me.PanelColor.ResumeLayout(False)
        Me.PanelColor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdExportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grilla.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage1.ResumeLayout(False)
        Me.RadPageViewPage1.PerformLayout()
        CType(Me.FechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme




    Friend WithEvents PanelColor As System.Windows.Forms.Panel
    Friend WithEvents LblAccion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTipControl As System.Windows.Forms.ToolTip
    Friend WithEvents TxtID As Controles_Ideas.TextData
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents CmdAgregar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdModificar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdEliminar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdLimpiar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdCancelar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdAceptar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdExportar As Telerik.WinControls.UI.RadButton
    Private WithEvents CmdGrid As Telerik.WinControls.UI.RadButton
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Private WithEvents Grilla As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FechaHasta As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents FechaDesde As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents TxtNombre As Controles_Ideas.TextData



End Class
