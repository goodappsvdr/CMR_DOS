<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTurnosOperador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTurnosOperador))
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.LblAccion = New System.Windows.Forms.Label()
        Me.ToolTipControl = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmdOcupado = New FontAwesome.Sharp.IconButton()
        Me.CmdDisponible = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BoxesCtrl1 = New CMR_DOS.CTRL.BoxesCtrl()
        Me.PictureAtender = New System.Windows.Forms.PictureBox()
        Me.CmdAtendiendo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EstadosCtrl1 = New CMR_DOS.CTRL.EstadosCtrl()
        Me.CmdAgregar = New System.Windows.Forms.Button()
        Me.SeccionesCtrl1 = New CMR_DOS.CTRL.SeccionesCtrl()
        Me.TxtID_Turno = New Controles_Ideas.TextData(Me.components)
        Me.MotivosCtrl1 = New CMR_DOS.CTRL.MotivosCtrl()
        Me.ResolucionesCtrl1 = New CMR_DOS.CTRL.ResolucionesCtrl()
        Me.LblCronometro = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New Controles_Ideas.TextData(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New Controles_Ideas.TextData(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFechaLlamado = New Controles_Ideas.TextData(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFechaObtencion = New Controles_Ideas.TextData(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PopupNotifier1 = New Tulpep.NotificationWindow.PopupNotifier()
        Me.PanelColor.SuspendLayout()
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
        CType(Me.PictureAtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelColor.Controls.Add(Me.LblAccion)
        Me.PanelColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelColor.Location = New System.Drawing.Point(0, 577)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(658, 25)
        Me.PanelColor.TabIndex = 47
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
        Me.Label1.Location = New System.Drawing.Point(141, 12)
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
        Me.Label2.Location = New System.Drawing.Point(107, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "SECCION"
        '
        'CmdLimpiar
        '
        Me.CmdLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLimpiar.Location = New System.Drawing.Point(6, 197)
        Me.CmdLimpiar.Name = "CmdLimpiar"
        '
        '
        '
        Me.CmdLimpiar.RootElement.ControlBounds = New System.Drawing.Rectangle(6, 197, 110, 24)
        Me.CmdLimpiar.Size = New System.Drawing.Size(78, 24)
        Me.CmdLimpiar.TabIndex = 71
        Me.CmdLimpiar.Text = "Actualizar"
        Me.CmdLimpiar.ThemeName = "Office2007Silver"
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdCancelar.Location = New System.Drawing.Point(554, 547)
        Me.CmdCancelar.Name = "CmdCancelar"
        '
        '
        '
        Me.CmdCancelar.RootElement.ControlBounds = New System.Drawing.Rectangle(554, 547, 110, 24)
        Me.CmdCancelar.Size = New System.Drawing.Size(97, 24)
        Me.CmdCancelar.TabIndex = 5
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.ThemeName = "Office2007Silver"
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdAceptar.Enabled = False
        Me.CmdAceptar.Location = New System.Drawing.Point(451, 547)
        Me.CmdAceptar.Name = "CmdAceptar"
        '
        '
        '
        Me.CmdAceptar.RootElement.ControlBounds = New System.Drawing.Rectangle(451, 547, 110, 24)
        Me.CmdAceptar.Size = New System.Drawing.Size(97, 24)
        Me.CmdAceptar.TabIndex = 4
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.ThemeName = "Office2007Silver"
        '
        'CmdExportar
        '
        Me.CmdExportar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdExportar.Location = New System.Drawing.Point(54, 547)
        Me.CmdExportar.Name = "CmdExportar"
        '
        '
        '
        Me.CmdExportar.RootElement.ControlBounds = New System.Drawing.Rectangle(54, 547, 110, 24)
        Me.CmdExportar.Size = New System.Drawing.Size(97, 24)
        Me.CmdExportar.TabIndex = 90
        Me.CmdExportar.Text = "Exportar"
        Me.CmdExportar.ThemeName = "Office2007Silver"
        '
        'CmdGrid
        '
        Me.CmdGrid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdGrid.Location = New System.Drawing.Point(8, 547)
        Me.CmdGrid.Name = "CmdGrid"
        '
        '
        '
        Me.CmdGrid.RootElement.ControlBounds = New System.Drawing.Rectangle(8, 547, 110, 24)
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
        Me.RadPageView1.Size = New System.Drawing.Size(644, 314)
        Me.RadPageView1.TabIndex = 92
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Silver"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.RadPageViewPage1.Controls.Add(Me.Label10)
        Me.RadPageViewPage1.Controls.Add(Me.CmdOcupado)
        Me.RadPageViewPage1.Controls.Add(Me.CmdDisponible)
        Me.RadPageViewPage1.Controls.Add(Me.Label8)
        Me.RadPageViewPage1.Controls.Add(Me.BoxesCtrl1)
        Me.RadPageViewPage1.Controls.Add(Me.PictureAtender)
        Me.RadPageViewPage1.Controls.Add(Me.CmdAtendiendo)
        Me.RadPageViewPage1.Controls.Add(Me.Label3)
        Me.RadPageViewPage1.Controls.Add(Me.EstadosCtrl1)
        Me.RadPageViewPage1.Controls.Add(Me.CmdAgregar)
        Me.RadPageViewPage1.Controls.Add(Me.SeccionesCtrl1)
        Me.RadPageViewPage1.Controls.Add(Me.TxtID_Turno)
        Me.RadPageViewPage1.Controls.Add(Me.MotivosCtrl1)
        Me.RadPageViewPage1.Controls.Add(Me.ResolucionesCtrl1)
        Me.RadPageViewPage1.Controls.Add(Me.LblCronometro)
        Me.RadPageViewPage1.Controls.Add(Me.Label9)
        Me.RadPageViewPage1.Controls.Add(Me.txtObservaciones)
        Me.RadPageViewPage1.Controls.Add(Me.Label5)
        Me.RadPageViewPage1.Controls.Add(Me.Label4)
        Me.RadPageViewPage1.Controls.Add(Me.TxtCodigo)
        Me.RadPageViewPage1.Controls.Add(Me.Label7)
        Me.RadPageViewPage1.Controls.Add(Me.TxtFechaLlamado)
        Me.RadPageViewPage1.Controls.Add(Me.Label6)
        Me.RadPageViewPage1.Controls.Add(Me.TxtFechaObtencion)
        Me.RadPageViewPage1.Controls.Add(Me.Label2)
        Me.RadPageViewPage1.Controls.Add(Me.Label1)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(620, 262)
        Me.RadPageViewPage1.Text = "Información"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(109, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "CÓDIGO"
        '
        'CmdOcupado
        '
        Me.CmdOcupado.FlatAppearance.BorderSize = 0
        Me.CmdOcupado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOcupado.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.CmdOcupado.ForeColor = System.Drawing.Color.Red
        Me.CmdOcupado.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.CmdOcupado.IconColor = System.Drawing.Color.Red
        Me.CmdOcupado.IconSize = 52
        Me.CmdOcupado.Location = New System.Drawing.Point(3, 3)
        Me.CmdOcupado.Name = "CmdOcupado"
        Me.CmdOcupado.Rotation = 0R
        Me.CmdOcupado.Size = New System.Drawing.Size(98, 81)
        Me.CmdOcupado.TabIndex = 115
        Me.CmdOcupado.Text = "OCUPADO"
        Me.CmdOcupado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdOcupado.UseVisualStyleBackColor = True
        '
        'CmdDisponible
        '
        Me.CmdDisponible.FlatAppearance.BorderSize = 0
        Me.CmdDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDisponible.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.CmdDisponible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDisponible.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.CmdDisponible.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDisponible.IconSize = 52
        Me.CmdDisponible.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdDisponible.Location = New System.Drawing.Point(3, 3)
        Me.CmdDisponible.Name = "CmdDisponible"
        Me.CmdDisponible.Rotation = 0R
        Me.CmdDisponible.Size = New System.Drawing.Size(98, 81)
        Me.CmdDisponible.TabIndex = 114
        Me.CmdDisponible.Text = "LIBRE"
        Me.CmdDisponible.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdDisponible.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(130, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "BOX"
        '
        'BoxesCtrl1
        '
        Me.BoxesCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxesCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BoxesCtrl1.FormattingEnabled = True
        Me.BoxesCtrl1.Location = New System.Drawing.Point(165, 77)
        Me.BoxesCtrl1.Name = "BoxesCtrl1"
        Me.BoxesCtrl1.Size = New System.Drawing.Size(271, 21)
        Me.BoxesCtrl1.TabIndex = 112
        '
        'PictureAtender
        '
        Me.PictureAtender.Image = Global.CMR_DOS.FRM.My.Resources.Resources.llamado
        Me.PictureAtender.Location = New System.Drawing.Point(475, 12)
        Me.PictureAtender.Name = "PictureAtender"
        Me.PictureAtender.Size = New System.Drawing.Size(131, 100)
        Me.PictureAtender.TabIndex = 111
        Me.PictureAtender.TabStop = False
        '
        'CmdAtendiendo
        '
        Me.CmdAtendiendo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdAtendiendo.BackgroundImage = Global.CMR_DOS.FRM.My.Resources.Resources.atendido
        Me.CmdAtendiendo.FlatAppearance.BorderSize = 0
        Me.CmdAtendiendo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAtendiendo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAtendiendo.ForeColor = System.Drawing.Color.Black
        Me.CmdAtendiendo.Location = New System.Drawing.Point(475, 12)
        Me.CmdAtendiendo.Name = "CmdAtendiendo"
        Me.CmdAtendiendo.Size = New System.Drawing.Size(131, 100)
        Me.CmdAtendiendo.TabIndex = 110
        Me.CmdAtendiendo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(271, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "ESTADO"
        '
        'EstadosCtrl1
        '
        Me.EstadosCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadosCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.EstadosCtrl1.FormattingEnabled = True
        Me.EstadosCtrl1.Location = New System.Drawing.Point(325, 30)
        Me.EstadosCtrl1.Name = "EstadosCtrl1"
        Me.EstadosCtrl1.Size = New System.Drawing.Size(111, 21)
        Me.EstadosCtrl1.TabIndex = 96
        '
        'CmdAgregar
        '
        Me.CmdAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdAgregar.BackgroundImage = Global.CMR_DOS.FRM.My.Resources.Resources.siguiente
        Me.CmdAgregar.FlatAppearance.BorderSize = 0
        Me.CmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAgregar.ForeColor = System.Drawing.Color.Black
        Me.CmdAgregar.Location = New System.Drawing.Point(475, 12)
        Me.CmdAgregar.Name = "CmdAgregar"
        Me.CmdAgregar.Size = New System.Drawing.Size(131, 100)
        Me.CmdAgregar.TabIndex = 108
        Me.CmdAgregar.UseVisualStyleBackColor = False
        '
        'SeccionesCtrl1
        '
        Me.SeccionesCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeccionesCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.SeccionesCtrl1.FormattingEnabled = True
        Me.SeccionesCtrl1.Location = New System.Drawing.Point(165, 53)
        Me.SeccionesCtrl1.Name = "SeccionesCtrl1"
        Me.SeccionesCtrl1.Size = New System.Drawing.Size(271, 21)
        Me.SeccionesCtrl1.TabIndex = 97
        '
        'TxtID_Turno
        '
        Me.TxtID_Turno.BackColor = System.Drawing.Color.White
        Me.TxtID_Turno.ColorEnter = System.Drawing.Color.Yellow
        Me.TxtID_Turno.ColorLeave = System.Drawing.Color.White
        Me.TxtID_Turno.Enabled = False
        Me.TxtID_Turno.Location = New System.Drawing.Point(164, 5)
        Me.TxtID_Turno.Name = "TxtID_Turno"
        Me.TxtID_Turno.Size = New System.Drawing.Size(69, 22)
        Me.TxtID_Turno.TabEnable = True
        Me.TxtID_Turno.TabIndex = 107
        Me.TxtID_Turno.TipoDato = System.Data.DbType.Int32
        '
        'MotivosCtrl1
        '
        Me.MotivosCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MotivosCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MotivosCtrl1.FormattingEnabled = True
        Me.MotivosCtrl1.Location = New System.Drawing.Point(165, 148)
        Me.MotivosCtrl1.Name = "MotivosCtrl1"
        Me.MotivosCtrl1.Size = New System.Drawing.Size(271, 21)
        Me.MotivosCtrl1.TabIndex = 106
        '
        'ResolucionesCtrl1
        '
        Me.ResolucionesCtrl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResolucionesCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ResolucionesCtrl1.FormattingEnabled = True
        Me.ResolucionesCtrl1.Location = New System.Drawing.Point(165, 171)
        Me.ResolucionesCtrl1.Name = "ResolucionesCtrl1"
        Me.ResolucionesCtrl1.Size = New System.Drawing.Size(271, 21)
        Me.ResolucionesCtrl1.TabIndex = 105
        '
        'LblCronometro
        '
        Me.LblCronometro.AutoSize = True
        Me.LblCronometro.ForeColor = System.Drawing.Color.White
        Me.LblCronometro.Location = New System.Drawing.Point(517, 117)
        Me.LblCronometro.Name = "LblCronometro"
        Me.LblCronometro.Size = New System.Drawing.Size(43, 13)
        Me.LblCronometro.TabIndex = 103
        Me.LblCronometro.Text = "0.00.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(48, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "MOTIVO DEL TURNO"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.ColorEnter = System.Drawing.Color.White
        Me.txtObservaciones.ColorLeave = System.Drawing.Color.White
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtObservaciones.Location = New System.Drawing.Point(164, 195)
        Me.txtObservaciones.MaxLength = 50
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(272, 45)
        Me.txtObservaciones.TabEnable = True
        Me.txtObservaciones.TabIndex = 98
        Me.txtObservaciones.TipoDato = System.Data.DbType.[String]
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(65, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "OBSERVACIONES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(84, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "RESOLUCION"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.White
        Me.TxtCodigo.ColorEnter = System.Drawing.Color.Yellow
        Me.TxtCodigo.ColorLeave = System.Drawing.Color.White
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(164, 29)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodigo.TabEnable = True
        Me.TxtCodigo.TabIndex = 92
        Me.TxtCodigo.TipoDato = System.Data.DbType.Int32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(65, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "FECHA LLAMADO"
        '
        'TxtFechaLlamado
        '
        Me.TxtFechaLlamado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaLlamado.ColorEnter = System.Drawing.Color.White
        Me.TxtFechaLlamado.ColorLeave = System.Drawing.Color.White
        Me.TxtFechaLlamado.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TxtFechaLlamado.Location = New System.Drawing.Point(165, 124)
        Me.TxtFechaLlamado.MaxLength = 50
        Me.TxtFechaLlamado.Name = "TxtFechaLlamado"
        Me.TxtFechaLlamado.Size = New System.Drawing.Size(271, 22)
        Me.TxtFechaLlamado.TabEnable = True
        Me.TxtFechaLlamado.TabIndex = 84
        Me.TxtFechaLlamado.TipoDato = System.Data.DbType.[String]
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(54, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "FECHA OBTENCION"
        '
        'TxtFechaObtencion
        '
        Me.TxtFechaObtencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaObtencion.ColorEnter = System.Drawing.Color.White
        Me.TxtFechaObtencion.ColorLeave = System.Drawing.Color.White
        Me.TxtFechaObtencion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TxtFechaObtencion.Location = New System.Drawing.Point(165, 100)
        Me.TxtFechaObtencion.MaxLength = 50
        Me.TxtFechaObtencion.Name = "TxtFechaObtencion"
        Me.TxtFechaObtencion.Size = New System.Drawing.Size(271, 22)
        Me.TxtFechaObtencion.TabEnable = True
        Me.TxtFechaObtencion.TabIndex = 82
        Me.TxtFechaObtencion.TipoDato = System.Data.DbType.[String]
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'PopupNotifier1
        '
        Me.PopupNotifier1.ContentFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.PopupNotifier1.ContentText = Nothing
        Me.PopupNotifier1.Image = Nothing
        Me.PopupNotifier1.IsRightToLeft = False
        Me.PopupNotifier1.OptionsMenu = Nothing
        Me.PopupNotifier1.Size = New System.Drawing.Size(400, 100)
        Me.PopupNotifier1.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PopupNotifier1.TitleText = Nothing
        '
        'FrmTurnosOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(658, 602)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.CmdExportar)
        Me.Controls.Add(Me.CmdGrid)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdLimpiar)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.RadPageView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(674, 641)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(674, 641)
        Me.Name = "FrmTurnosOperador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Turnos.-"
        Me.PanelColor.ResumeLayout(False)
        Me.PanelColor.PerformLayout()
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
        CType(Me.PictureAtender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme




    Friend WithEvents PanelColor As System.Windows.Forms.Panel
    Friend WithEvents LblAccion As System.Windows.Forms.Label
    Friend WithEvents ToolTipControl As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaLlamado As Controles_Ideas.TextData
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaObtencion As Controles_Ideas.TextData
    Friend WithEvents TxtCodigo As Controles_Ideas.TextData
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As Controles_Ideas.TextData
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EstadosCtrl1 As CMR_DOS.CTRL.EstadosCtrl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblCronometro As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents MotivosCtrl1 As CTRL.MotivosCtrl
    Friend WithEvents ResolucionesCtrl1 As CTRL.ResolucionesCtrl
    Friend WithEvents SeccionesCtrl1 As CTRL.SeccionesCtrl
    Friend WithEvents TxtID_Turno As Controles_Ideas.TextData
    Friend WithEvents CmdAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CmdAtendiendo As Button
    Friend WithEvents PictureAtender As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BoxesCtrl1 As CTRL.BoxesCtrl
    Friend WithEvents CmdOcupado As FontAwesome.Sharp.IconButton
    Friend WithEvents CmdDisponible As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents PopupNotifier1 As Tulpep.NotificationWindow.PopupNotifier
End Class
