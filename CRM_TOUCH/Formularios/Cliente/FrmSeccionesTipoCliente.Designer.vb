<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class FrmSeccionesTipoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeccionesTipoCliente))
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Energia = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Internet = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Telefonia = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_Television = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Btn_Servicios = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btn_Cementerio = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Btn_Amicos = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Btn_Otros = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblFechayHs = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PrintDocument1
        '
        '
        'Timer3
        '
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.911591!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.777778!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.92535!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(790, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel4, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel6, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel7, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel8, 3, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 83)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(784, 364)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Energia)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 176)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Energia
        '
        Me.Btn_Energia.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.energia
        Me.Btn_Energia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Energia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Energia.FlatAppearance.BorderSize = 0
        Me.Btn_Energia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Energia.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Energia.Name = "Btn_Energia"
        Me.Btn_Energia.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Energia.TabIndex = 0
        Me.Btn_Energia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Energia.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_Internet)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(199, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 176)
        Me.Panel2.TabIndex = 1
        '
        'Btn_Internet
        '
        Me.Btn_Internet.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.internet
        Me.Btn_Internet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Internet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Internet.FlatAppearance.BorderSize = 0
        Me.Btn_Internet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Internet.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Internet.Name = "Btn_Internet"
        Me.Btn_Internet.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Internet.TabIndex = 1
        Me.Btn_Internet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Internet.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btn_Telefonia)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(395, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 176)
        Me.Panel3.TabIndex = 2
        '
        'Btn_Telefonia
        '
        Me.Btn_Telefonia.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.telefonia
        Me.Btn_Telefonia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Telefonia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Telefonia.FlatAppearance.BorderSize = 0
        Me.Btn_Telefonia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Telefonia.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Telefonia.Name = "Btn_Telefonia"
        Me.Btn_Telefonia.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Telefonia.TabIndex = 1
        Me.Btn_Telefonia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Telefonia.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_Television)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(591, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(190, 176)
        Me.Panel4.TabIndex = 3
        '
        'Btn_Television
        '
        Me.Btn_Television.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.television
        Me.Btn_Television.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Television.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Television.FlatAppearance.BorderSize = 0
        Me.Btn_Television.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Television.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Television.Name = "Btn_Television"
        Me.Btn_Television.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Television.TabIndex = 1
        Me.Btn_Television.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Television.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Btn_Servicios)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 185)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(190, 176)
        Me.Panel5.TabIndex = 4
        '
        'Btn_Servicios
        '
        Me.Btn_Servicios.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.servicios_sociales
        Me.Btn_Servicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Servicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Servicios.FlatAppearance.BorderSize = 0
        Me.Btn_Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Servicios.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Servicios.Name = "Btn_Servicios"
        Me.Btn_Servicios.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Servicios.TabIndex = 1
        Me.Btn_Servicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Servicios.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Btn_Cementerio)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(199, 185)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(190, 176)
        Me.Panel6.TabIndex = 5
        '
        'Btn_Cementerio
        '
        Me.Btn_Cementerio.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.cementerio_parque
        Me.Btn_Cementerio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Cementerio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Cementerio.FlatAppearance.BorderSize = 0
        Me.Btn_Cementerio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cementerio.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Cementerio.Name = "Btn_Cementerio"
        Me.Btn_Cementerio.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Cementerio.TabIndex = 1
        Me.Btn_Cementerio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Cementerio.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Btn_Amicos)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(395, 185)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(190, 176)
        Me.Panel7.TabIndex = 6
        '
        'Btn_Amicos
        '
        Me.Btn_Amicos.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.amicos
        Me.Btn_Amicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Amicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Amicos.FlatAppearance.BorderSize = 0
        Me.Btn_Amicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Amicos.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Amicos.Name = "Btn_Amicos"
        Me.Btn_Amicos.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Amicos.TabIndex = 1
        Me.Btn_Amicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Amicos.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Btn_Otros)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(591, 185)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(190, 176)
        Me.Panel8.TabIndex = 7
        '
        'Btn_Otros
        '
        Me.Btn_Otros.BackgroundImage = Global.CRM_TOUCH.My.Resources.Resources.otros
        Me.Btn_Otros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Otros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Otros.FlatAppearance.BorderSize = 0
        Me.Btn_Otros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Otros.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Otros.Name = "Btn_Otros"
        Me.Btn_Otros.Size = New System.Drawing.Size(190, 176)
        Me.Btn_Otros.TabIndex = 1
        Me.Btn_Otros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Otros.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.65605!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.019108!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.32484!))
        Me.TableLayoutPanel2.Controls.Add(Me.LblFechayHs, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel9, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(784, 44)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'LblFechayHs
        '
        Me.LblFechayHs.AutoSize = True
        Me.LblFechayHs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFechayHs.Font = New System.Drawing.Font("Oswald", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechayHs.ForeColor = System.Drawing.Color.White
        Me.LblFechayHs.Image = Global.CRM_TOUCH.My.Resources.Resources.hora
        Me.LblFechayHs.Location = New System.Drawing.Point(336, 0)
        Me.LblFechayHs.Name = "LblFechayHs"
        Me.LblFechayHs.Size = New System.Drawing.Size(445, 44)
        Me.LblFechayHs.TabIndex = 0
        Me.LblFechayHs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(320, 38)
        Me.Panel9.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.CRM_TOUCH.My.Resources.Resources.logo_coop
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmSeccionesTipoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmSeccionesTipoCliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Timer3 As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Energia As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LblFechayHs As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Internet As Button
    Friend WithEvents Btn_Telefonia As Button
    Friend WithEvents Btn_Television As Button
    Friend WithEvents Btn_Servicios As Button
    Friend WithEvents Btn_Cementerio As Button
    Friend WithEvents Btn_Amicos As Button
    Friend WithEvents Btn_Otros As Button
End Class
