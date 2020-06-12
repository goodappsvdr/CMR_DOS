<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblAccion = New System.Windows.Forms.Label()
        Me.ToolTipControl = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtID = New Controles_Ideas.TextData(Me.components)
        Me.TxtNombre = New Controles_Ideas.TextData(Me.components)
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
        Me.pag1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RolesCtrl1 = New CMR_DOS.CTRL.RolesCtrl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPassword = New Controles_Ideas.TextData(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLogin = New Controles_Ideas.TextData(Me.components)
        Me.EstadosCtrl1 = New CMR_DOS.CTRL.EstadosCtrl()
        Me.pag2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAceptarseccion = New Telerik.WinControls.UI.RadButton()
        Me.txtIDSeccion = New Controles_Ideas.TextData(Me.components)
        Me.btnEditarSeccion = New Telerik.WinControls.UI.RadButton()
        Me.btnNuevaSeccion = New Telerik.WinControls.UI.RadButton()
        Me.SeccionesCtrl1 = New CMR_DOS.CTRL.SeccionesCtrl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EstadosCtrl2 = New CMR_DOS.CTRL.EstadosCtrl()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
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
        Me.pag1.SuspendLayout()
        Me.pag2.SuspendLayout()
        CType(Me.btnAceptarseccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditarSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevaSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(65, Byte), Integer))
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(163, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "ESTADO"
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
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.TipoDato = System.Data.DbType.[String]
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(180, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "NRO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(157, 43)
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
        Me.CmdCancelar.TabIndex = 7
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
        Me.CmdAceptar.TabIndex = 6
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
        Me.RadPageView1.Controls.Add(Me.pag1)
        Me.RadPageView1.Controls.Add(Me.pag2)
        Me.RadPageView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageView1.Location = New System.Drawing.Point(7, 227)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.PageBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageView1.SelectedPage = Me.pag1
        Me.RadPageView1.Size = New System.Drawing.Size(644, 278)
        Me.RadPageView1.TabIndex = 92
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Silver"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'pag1
        '
        Me.pag1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pag1.Controls.Add(Me.RolesCtrl1)
        Me.pag1.Controls.Add(Me.Label6)
        Me.pag1.Controls.Add(Me.Label4)
        Me.pag1.Controls.Add(Me.TxtPassword)
        Me.pag1.Controls.Add(Me.Label3)
        Me.pag1.Controls.Add(Me.TxtLogin)
        Me.pag1.Controls.Add(Me.Label2)
        Me.pag1.Controls.Add(Me.Label1)
        Me.pag1.Controls.Add(Me.Label5)
        Me.pag1.Controls.Add(Me.TxtNombre)
        Me.pag1.Controls.Add(Me.TxtID)
        Me.pag1.Controls.Add(Me.EstadosCtrl1)
        Me.pag1.Location = New System.Drawing.Point(12, 40)
        Me.pag1.Name = "pag1"
        Me.pag1.Size = New System.Drawing.Size(620, 226)
        Me.pag1.Text = "Información de Usuario"
        '
        'RolesCtrl1
        '
        Me.RolesCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RolesCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RolesCtrl1.FormattingEnabled = True
        Me.RolesCtrl1.Location = New System.Drawing.Point(213, 124)
        Me.RolesCtrl1.Name = "RolesCtrl1"
        Me.RolesCtrl1.Size = New System.Drawing.Size(272, 21)
        Me.RolesCtrl1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(183, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "ROL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(144, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "PASSWORD"
        '
        'TxtPassword
        '
        Me.TxtPassword.ColorEnter = System.Drawing.Color.White
        Me.TxtPassword.ColorLeave = System.Drawing.Color.White
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TxtPassword.Location = New System.Drawing.Point(214, 96)
        Me.TxtPassword.MaxLength = 50
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(271, 22)
        Me.TxtPassword.TabEnable = True
        Me.TxtPassword.TabIndex = 3
        Me.TxtPassword.TipoDato = System.Data.DbType.[String]
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(171, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "LOGIN"
        '
        'TxtLogin
        '
        Me.TxtLogin.ColorEnter = System.Drawing.Color.White
        Me.TxtLogin.ColorLeave = System.Drawing.Color.White
        Me.TxtLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TxtLogin.Location = New System.Drawing.Point(214, 68)
        Me.TxtLogin.MaxLength = 50
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(271, 22)
        Me.TxtLogin.TabEnable = True
        Me.TxtLogin.TabIndex = 2
        Me.TxtLogin.TipoDato = System.Data.DbType.[String]
        '
        'EstadosCtrl1
        '
        Me.EstadosCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadosCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.EstadosCtrl1.FormattingEnabled = True
        Me.EstadosCtrl1.Location = New System.Drawing.Point(213, 151)
        Me.EstadosCtrl1.Name = "EstadosCtrl1"
        Me.EstadosCtrl1.Size = New System.Drawing.Size(272, 21)
        Me.EstadosCtrl1.TabIndex = 5
        '
        'pag2
        '
        Me.pag2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pag2.Controls.Add(Me.Label9)
        Me.pag2.Controls.Add(Me.btnAceptarseccion)
        Me.pag2.Controls.Add(Me.txtIDSeccion)
        Me.pag2.Controls.Add(Me.btnEditarSeccion)
        Me.pag2.Controls.Add(Me.btnNuevaSeccion)
        Me.pag2.Controls.Add(Me.SeccionesCtrl1)
        Me.pag2.Controls.Add(Me.Label7)
        Me.pag2.Controls.Add(Me.Label8)
        Me.pag2.Controls.Add(Me.EstadosCtrl2)
        Me.pag2.Controls.Add(Me.RadGridView1)
        Me.pag2.Location = New System.Drawing.Point(12, 40)
        Me.pag2.Name = "pag2"
        Me.pag2.Size = New System.Drawing.Size(620, 226)
        Me.pag2.Text = "Secciones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(208, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "NRO"
        '
        'btnAceptarseccion
        '
        Me.btnAceptarseccion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAceptarseccion.Location = New System.Drawing.Point(520, 199)
        Me.btnAceptarseccion.Name = "btnAceptarseccion"
        '
        '
        '
        Me.btnAceptarseccion.RootElement.ControlBounds = New System.Drawing.Rectangle(520, 199, 110, 24)
        Me.btnAceptarseccion.Size = New System.Drawing.Size(97, 24)
        Me.btnAceptarseccion.TabIndex = 99
        Me.btnAceptarseccion.Text = "Aceptar"
        Me.btnAceptarseccion.ThemeName = "Office2007Silver"
        '
        'txtIDSeccion
        '
        Me.txtIDSeccion.BackColor = System.Drawing.Color.White
        Me.txtIDSeccion.ColorEnter = System.Drawing.Color.Yellow
        Me.txtIDSeccion.ColorLeave = System.Drawing.Color.White
        Me.txtIDSeccion.Enabled = False
        Me.txtIDSeccion.Location = New System.Drawing.Point(249, 139)
        Me.txtIDSeccion.Name = "txtIDSeccion"
        Me.txtIDSeccion.Size = New System.Drawing.Size(69, 22)
        Me.txtIDSeccion.TabEnable = True
        Me.txtIDSeccion.TabIndex = 41
        Me.txtIDSeccion.TipoDato = System.Data.DbType.Int32
        '
        'btnEditarSeccion
        '
        Me.btnEditarSeccion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditarSeccion.Location = New System.Drawing.Point(520, 169)
        Me.btnEditarSeccion.Name = "btnEditarSeccion"
        '
        '
        '
        Me.btnEditarSeccion.RootElement.ControlBounds = New System.Drawing.Rectangle(520, 169, 110, 24)
        Me.btnEditarSeccion.Size = New System.Drawing.Size(97, 24)
        Me.btnEditarSeccion.TabIndex = 98
        Me.btnEditarSeccion.Text = "Editar"
        Me.btnEditarSeccion.ThemeName = "Office2007Silver"
        '
        'btnNuevaSeccion
        '
        Me.btnNuevaSeccion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevaSeccion.Location = New System.Drawing.Point(520, 139)
        Me.btnNuevaSeccion.Name = "btnNuevaSeccion"
        '
        '
        '
        Me.btnNuevaSeccion.RootElement.ControlBounds = New System.Drawing.Rectangle(520, 139, 110, 24)
        Me.btnNuevaSeccion.Size = New System.Drawing.Size(97, 24)
        Me.btnNuevaSeccion.TabIndex = 97
        Me.btnNuevaSeccion.Text = "Nuevo"
        Me.btnNuevaSeccion.ThemeName = "Office2007Silver"
        '
        'SeccionesCtrl1
        '
        Me.SeccionesCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeccionesCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.SeccionesCtrl1.FormattingEnabled = True
        Me.SeccionesCtrl1.Location = New System.Drawing.Point(249, 167)
        Me.SeccionesCtrl1.Name = "SeccionesCtrl1"
        Me.SeccionesCtrl1.Size = New System.Drawing.Size(179, 21)
        Me.SeccionesCtrl1.TabIndex = 96
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(191, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "SECCIÓN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(195, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "ESTADO"
        '
        'EstadosCtrl2
        '
        Me.EstadosCtrl2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadosCtrl2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.EstadosCtrl2.FormattingEnabled = True
        Me.EstadosCtrl2.Location = New System.Drawing.Point(249, 194)
        Me.EstadosCtrl2.Name = "EstadosCtrl2"
        Me.EstadosCtrl2.Size = New System.Drawing.Size(179, 21)
        Me.EstadosCtrl2.TabIndex = 93
        '
        'RadGridView1
        '
        Me.RadGridView1.AllowShowFocusCues = True
        Me.RadGridView1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.MasterTemplate.AllowRowResize = False
        Me.RadGridView1.MasterTemplate.EnableAlternatingRowColor = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableGrouping = False
        Me.RadGridView1.MasterTemplate.ShowRowHeaderColumn = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.RadGridView1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 240, 150)
        Me.RadGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.RadGridView1.Size = New System.Drawing.Size(620, 133)
        Me.RadGridView1.TabIndex = 92
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Office2007Silver"
        '
        'FrmUsuarios
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
        Me.MinimizeBox = False
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios.-"
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
        Me.pag1.ResumeLayout(False)
        Me.pag1.PerformLayout()
        Me.pag2.ResumeLayout(False)
        Me.pag2.PerformLayout()
        CType(Me.btnAceptarseccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditarSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevaSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme




    Friend WithEvents PanelColor As System.Windows.Forms.Panel
    Friend WithEvents LblAccion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTipControl As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtID As Controles_Ideas.TextData
    Friend WithEvents TxtNombre As Controles_Ideas.TextData
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EstadosCtrl1 As CMR_DOS.CTRL.EstadosCtrl
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
    Friend WithEvents pag1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As Controles_Ideas.TextData
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtLogin As Controles_Ideas.TextData
    Friend WithEvents RolesCtrl1 As CMR_DOS.CTRL.RolesCtrl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pag2 As Telerik.WinControls.UI.RadPageViewPage
    Private WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents SeccionesCtrl1 As CMR_DOS.CTRL.SeccionesCtrl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EstadosCtrl2 As CMR_DOS.CTRL.EstadosCtrl
    Private WithEvents btnEditarSeccion As Telerik.WinControls.UI.RadButton
    Private WithEvents btnNuevaSeccion As Telerik.WinControls.UI.RadButton
    Private WithEvents btnAceptarseccion As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIDSeccion As Controles_Ideas.TextData



End Class
