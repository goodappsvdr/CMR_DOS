Partial Class R_TurnosPorOperador_Exp


    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_TurnosPorOperador_Exp))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.4151620864868164R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox24, Me.TextBox25, Me.TextBox19, Me.TextBox5, Me.TextBox11})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.3901004791259766R), Telerik.Reporting.Drawing.Unit.Cm(0.00040135023300535977R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(45.009796142578125R), Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R))
        Me.TextBox24.Style.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox24.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.Font.Name = "Arial Black"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "Reporte de Turnos"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.3901004791259766R), Telerik.Reporting.Drawing.Unit.Cm(1.20060133934021R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(45.009696960449219R), Telerik.Reporting.Drawing.Unit.Cm(1.2145606279373169R))
        Me.TextBox25.Style.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox25.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "= ""DESDE "" + Substr(CStr(Parameters.fechadesde.Value),0,10) + "" HASTA "" +Substr(C" & _
    "Str(Parameters.fechahasta.Value),0,10)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(1.7147605419158936R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3896956443786621R), Telerik.Reporting.Drawing.Unit.Cm(0.69980001449584961R))
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Value = "{Now()}"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(0.50060129165649414R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3895955085754395R), Telerik.Reporting.Drawing.Unit.Cm(1.2139595746994019R))
        Me.TextBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "= ToUpper(Fields.Operador)"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.00040129979606717825R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3896956443786621R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox11.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Operador"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(32.611251831054687R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749331R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1910805702209473R), Telerik.Reporting.Drawing.Unit.Cm(0.514309823513031R))
        Me.TextBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Style.Visible = True
        Me.TextBox7.Value = "= Fields.Motivo"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(32.611251831054687R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1911869049072266R), Telerik.Reporting.Drawing.Unit.Cm(0.49969896674156189R))
        Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox10.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "Motivo:"
        '
        'detail
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("=rownumber()%2", Telerik.Reporting.FilterOperator.Equal, "0"))
        FormattingRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.51451009511947632R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox21, Me.TextBox32, Me.TextBox3, Me.TextBox22, Me.TextBox23, Me.TextBox30, Me.TextBox34, Me.TextBox31, Me.TextBox8, Me.TextBox18, Me.TextBox1, Me.TextBox7})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.931556224822998R), Telerik.Reporting.Drawing.Unit.Cm(0.00020014523761346936R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.49989652633667R), Telerik.Reporting.Drawing.Unit.Cm(0.51410871744155884R))
        Me.TextBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "= ToUpper(Fields.Seccion)"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.32086181640625R), Telerik.Reporting.Drawing.Unit.Cm(0.00020105361181776971R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6942059993743896R), Telerik.Reporting.Drawing.Unit.Cm(0.51410818099975586R))
        Me.TextBox21.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = resources.GetString("TextBox21.Value")
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(28.213962554931641R), Telerik.Reporting.Drawing.Unit.Cm(0.0056104250252246857R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1983985900878906R), Telerik.Reporting.Drawing.Unit.Cm(0.50869888067245483R))
        Me.TextBox32.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox32.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox32.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox32.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox32.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "= Fields.TiempoParaSerSolucionado"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.431756019592285R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.49989652633667R), Telerik.Reporting.Drawing.Unit.Cm(0.51430898904800415R))
        Me.TextBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= ToUpper(Fields.SubSeccion)"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.626359939575195R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749331R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6942009925842285R), Telerik.Reporting.Drawing.Unit.Cm(0.51410871744155884R))
        Me.TextBox22.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = resources.GetString("TextBox22.Value")
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.931853294372559R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6942036151885986R), Telerik.Reporting.Drawing.Unit.Cm(0.51430898904800415R))
        Me.TextBox23.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = resources.GetString("TextBox23.Value")
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(26.015266418457031R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1983985900878906R), Telerik.Reporting.Drawing.Unit.Cm(0.51430898904800415R))
        Me.TextBox30.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox30.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox30.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox30.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox30.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox30.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox30.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox30.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox30.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.Value = "= Fields.TiempoParaSerLlamado"
        '
        'TextBox34
        '
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8203721046447754R), Telerik.Reporting.Drawing.Unit.Cm(0.005610728170722723R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1108810901641846R), Telerik.Reporting.Drawing.Unit.Cm(0.50869834423065186R))
        Me.TextBox34.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox34.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox34.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox34.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox34.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox34.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox34.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox34.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox34.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox34.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.Value = "= ToUpper(Fields.Estado)"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(30.412664413452148R), Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1984009742736816R), Telerik.Reporting.Drawing.Unit.Cm(0.5142093300819397R))
        Me.TextBox31.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox31.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox31.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox31.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox31.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = "= Fields.TiempoTotal"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(36.802532196044922R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.8970623016357422R), Telerik.Reporting.Drawing.Unit.Cm(0.50869834423065186R))
        Me.TextBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "= ToUpper(Fields.Resolucion)"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(43.700004577636719R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.6998920440673828R), Telerik.Reporting.Drawing.Unit.Cm(0.50869834423065186R))
        Me.TextBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox18.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox18.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox18.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox18.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.Value = "= ToUpper(Fields.Observaciones)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8201720714569092R), Telerik.Reporting.Drawing.Unit.Cm(0.51430952548980713R))
        Me.TextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.Turno"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.9315547943115234R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.49989652633667R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox13.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Sección"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.431756019592285R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.49989652633667R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox12.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "SubSección"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(36.802639007568359R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.8970551490783691R), Telerik.Reporting.Drawing.Unit.Cm(0.49970078468322754R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "Resolución"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.93195629119873R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6942036151885986R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox14.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "Obtención"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.626462936401367R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6942036151885986R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox15.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Atención"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.320972442626953R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6942036151885986R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox16.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "Resolución"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(26.015266418457031R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1983985900878906R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox27.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox27.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox27.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox27.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox27.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "Se atendio en"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(28.213958740234375R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1983985900878906R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox28.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox28.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox28.Value = "Se resolvio en"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(43.699897766113281R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.6998968124389648R), Telerik.Reporting.Drawing.Unit.Cm(0.49999994039535522R))
        Me.TextBox17.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox17.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox17.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox17.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "Observaciones"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(30.412660598754883R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1983985900878906R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox29.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox29.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox29.Value = "Tiempo total"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.7296711802482605R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Conn"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@id_Operador", System.Data.DbType.Int32, "=Parameters.idOperador.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechadesde", System.Data.DbType.[Date], "=Parameters.fechadesde.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechahasta", System.Data.DbType.[Date], "=Parameters.fechahasta.Value"), New Telerik.Reporting.SqlDataSourceParameter("@id_estado", System.Data.DbType.Int32, "=Parameters.idestado.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.R_TurnosBuscarPorOperador"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.9999661445617676R), Telerik.Reporting.Drawing.Unit.Cm(1.2699999809265137R))
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.9999661445617676R), Telerik.Reporting.Drawing.Unit.Cm(1.2699999809265137R))
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox12, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox27, Me.TextBox28, Me.TextBox13, Me.TextBox29, Me.TextBox26, Me.TextBox33, Me.TextBox9, Me.TextBox17, Me.TextBox10})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ReportHeaderSection1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.5R)
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.000099618431704584509R), Telerik.Reporting.Drawing.Unit.Cm(0.0000015139578408707166R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8200726509094238R), Telerik.Reporting.Drawing.Unit.Cm(0.49969935417175293R))
        Me.TextBox26.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox26.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox26.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox26.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox26.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "Turno"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8203728199005127R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1108810901641846R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox33.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox33.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox33.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox33.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox33.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox33.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox33.Value = "Estado"
        '
        'R_TurnosPorOperador_Exp
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1, Me.ReportHeaderSection1})
        Me.Name = "R_TurnosPorMotivos"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(2.0R), Telerik.Reporting.Drawing.Unit.Mm(2.0R), Telerik.Reporting.Drawing.Unit.Mm(2.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(25.0R), Telerik.Reporting.Drawing.Unit.Inch(20.0R))
        ReportParameter1.Name = "idOperador"
        ReportParameter1.Text = "idOperador"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = ""
        ReportParameter2.Name = "fechadesde"
        ReportParameter2.Text = "fechadesde"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Value = ""
        ReportParameter3.Name = "fechahasta"
        ReportParameter3.Text = "fechahasta"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Value = ""
        ReportParameter4.Name = "idestado"
        ReportParameter4.Text = "idestado"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter4.Value = ""
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(50.399997711181641R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents ReportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class