Partial Class R_TurnosPorSecciones


    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.0R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox7, Me.TextBox10, Me.TextBox19, Me.TextBox24, Me.TextBox25})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.90000015497207642R), Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R))
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(2.6000001430511475R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.373140335083008R), Telerik.Reporting.Drawing.Unit.Cm(1.5R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3898000717163086R), Telerik.Reporting.Drawing.Unit.Cm(1.2145603895187378R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox7.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Style.Visible = True
        Me.TextBox7.Value = "= ToUpper(Fields.Seccion)"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.373140335083008R), Telerik.Reporting.Drawing.Unit.Cm(1.0001012086868286R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3898000717163086R), Telerik.Reporting.Drawing.Unit.Cm(0.49969896674156189R))
        Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox10.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "Sección"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.373140335083008R), Telerik.Reporting.Drawing.Unit.Cm(0.30010139942169189R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3897991180419922R), Telerik.Reporting.Drawing.Unit.Cm(0.69980001449584961R))
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Value = "{Now()}"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.5866823196411133R), Telerik.Reporting.Drawing.Unit.Cm(0.59999990463256836R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.4133172035217285R), Telerik.Reporting.Drawing.Unit.Cm(1.3000001907348633R))
        Me.TextBox24.Style.Font.Name = "Arial Black"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "Reporte de Turnos"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.5866827964782715R), Telerik.Reporting.Drawing.Unit.Cm(1.9002001285552979R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.4133172035217285R), Telerik.Reporting.Drawing.Unit.Cm(0.69979977607727051R))
        Me.TextBox25.Value = "= ""DESDE "" + Substr(CStr(Parameters.fechadesde.Value),0,10) + "" HASTA "" +Substr(C" & _
    "Str(Parameters.fechahasta.Value),0,10)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(4.4998998641967773R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox8, Me.TextBox22, Me.TextBox21, Me.TextBox23, Me.TextBox13, Me.TextBox12, Me.TextBox9, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox27, Me.TextBox28, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox17, Me.TextBox18, Me.TextBox3, Me.TextBox11, Me.TextBox5, Me.TextBox29, Me.TextBox26, Me.TextBox33, Me.TextBox1})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.2268834114074707R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749331R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.7495982646942139R), Telerik.Reporting.Drawing.Unit.Cm(0.49969935417175293R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "= ToUpper(Fields.Seccion)"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.7997746467590332R), Telerik.Reporting.Drawing.Unit.Cm(1.8057109117507935R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.542893409729004R), Telerik.Reporting.Drawing.Unit.Cm(0.894287645816803R))
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox8.Value = "= ToUpper(Fields.Motivo)"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.07371711730957R), Telerik.Reporting.Drawing.Unit.Cm(0.60009944438934326R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.2866578102111816R), Telerik.Reporting.Drawing.Unit.Cm(0.49969983100891113R))
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "= Fields.FechaAtencion"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.259597778320313R), Telerik.Reporting.Drawing.Unit.Cm(0.60010063648223877R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.2866578102111816R), Telerik.Reporting.Drawing.Unit.Cm(0.49969854950904846R))
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "= Fields.FechaResolucion"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.900200366973877R), Telerik.Reporting.Drawing.Unit.Cm(0.59115010499954224R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.2866578102111816R), Telerik.Reporting.Drawing.Unit.Cm(0.49979868531227112R))
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "= Fields.FechaObtencion.Date"
        '
        'TextBox1
        '
        Me.TextBox1.Angle = 270.0R
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.01344132237136364R), Telerik.Reporting.Drawing.Unit.Cm(0.00010133424802916124R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9999001026153564R), Telerik.Reporting.Drawing.Unit.Cm(4.4996981620788574R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.Turno + """ & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """ + ToUpper(Fields.Estado)"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.026883602142334R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749331R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1997992992401123R), Telerik.Reporting.Drawing.Unit.Cm(0.49969935417175293R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Sección:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9766817092895508R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2131416797637939R), Telerik.Reporting.Drawing.Unit.Cm(0.49969944357872009R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox12.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "SubSección:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0135414600372314R), Telerik.Reporting.Drawing.Unit.Cm(1.7999999523162842R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7860331535339355R), Telerik.Reporting.Drawing.Unit.Cm(0.49085018038749695R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "Motivo:"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0135414600372314R), Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8864585161209106R), Telerik.Reporting.Drawing.Unit.Cm(0.49979910254478455R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox14.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox14.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "Obtención:"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.1870584487915039R), Telerik.Reporting.Drawing.Unit.Cm(0.60009944438934326R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8864586353302002R), Telerik.Reporting.Drawing.Unit.Cm(0.49969944357872009R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox15.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox15.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Atención:"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.386507034301758R), Telerik.Reporting.Drawing.Unit.Cm(0.60010063648223877R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.872891902923584R), Telerik.Reporting.Drawing.Unit.Cm(0.49969896674156189R))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox16.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox16.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "Resolución:"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.026883602142334R), Telerik.Reporting.Drawing.Unit.Cm(1.1999998092651367R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1829161643981934R), Telerik.Reporting.Drawing.Unit.Cm(0.49979910254478455R))
        Me.TextBox27.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox27.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "Espera hasta ser atendido:"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.1870584487915039R), Telerik.Reporting.Drawing.Unit.Cm(1.2088501453399658R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1829161643981934R), Telerik.Reporting.Drawing.Unit.Cm(0.49979910254478455R))
        Me.TextBox28.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox28.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox28.Value = "Tiempo en solucionarse:"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2100005149841309R), Telerik.Reporting.Drawing.Unit.Cm(1.1999998092651367R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9768571853637695R), Telerik.Reporting.Drawing.Unit.Cm(0.508649468421936R))
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.Value = "= Fields.TiempoParaSerLlamado"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.569623947143555R), Telerik.Reporting.Drawing.Unit.Cm(1.1999998092651367R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.97685706615448R), Telerik.Reporting.Drawing.Unit.Cm(0.51883542537689209R))
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = "= Fields.TiempoTotal"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.383517265319824R), Telerik.Reporting.Drawing.Unit.Cm(1.2190357446670532R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.97685706615448R), Telerik.Reporting.Drawing.Unit.Cm(0.49979910254478455R))
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "= Fields.TiempoParaSerSolucionado"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0135414600372314R), Telerik.Reporting.Drawing.Unit.Cm(3.5996639728546143R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7860329151153564R), Telerik.Reporting.Drawing.Unit.Cm(0.49969896674156189R))
        Me.TextBox17.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox17.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "Observaciones:"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.7997746467590332R), Telerik.Reporting.Drawing.Unit.Cm(3.609799861907959R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.542891502380371R), Telerik.Reporting.Drawing.Unit.Cm(0.88999998569488525R))
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox18.Value = "= ToUpper(Fields.Observaciones)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.190023422241211R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.49969938397407532R))
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= ToUpper(Fields.SubSeccion)"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.290224075317383R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1995749473571777R), Telerik.Reporting.Drawing.Unit.Cm(0.49969896674156189R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Operador:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.489999771118164R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.09663200378418R), Telerik.Reporting.Drawing.Unit.Cm(0.49969896674156189R))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "= ToUpper(Fields.Operador)"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.386507034301758R), Telerik.Reporting.Drawing.Unit.Cm(1.2190361022949219R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1829161643981934R), Telerik.Reporting.Drawing.Unit.Cm(0.49979910254478455R))
        Me.TextBox29.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox29.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox29.Value = "Tiempo total:"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0135414600372314R), Telerik.Reporting.Drawing.Unit.Cm(2.7153122425079346R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7860331535339355R), Telerik.Reporting.Drawing.Unit.Cm(0.49085018038749695R))
        Me.TextBox26.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox26.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "Resolución:"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.7997746467590332R), Telerik.Reporting.Drawing.Unit.Cm(2.7210233211517334R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.534785270690918R), Telerik.Reporting.Drawing.Unit.Cm(0.88857579231262207R))
        Me.TextBox33.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox33.Value = "= ToUpper(Fields.Resolucion)"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634R)
        Me.pageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox20})
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.799999237060547R), Telerik.Reporting.Drawing.Unit.Cm(0.00010093052696902305R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.3000006675720215R), Telerik.Reporting.Drawing.Unit.Cm(0.59989875555038452R))
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "= ""Página ("" + PageNumber + ""/"" + PageCount + "")"""
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Conn"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@id_Seccion", System.Data.DbType.Int32, "=Parameters.idSeccion.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechadesde", System.Data.DbType.[Date], "=Parameters.fechadesde.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechahasta", System.Data.DbType.[Date], "=Parameters.fechahasta.Value"), New Telerik.Reporting.SqlDataSourceParameter("@id_estado", System.Data.DbType.Int32, "=Parameters.idestado.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.R_TurnosBuscarPorSeccion"
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
        'R_TurnosPorSecciones
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "R_TurnosPorMotivos"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(2.0R), Telerik.Reporting.Drawing.Unit.Mm(2.0R), Telerik.Reporting.Drawing.Unit.Mm(2.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "fechadesde"
        ReportParameter1.Text = "fechadesde"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Value = ""
        ReportParameter2.Name = "fechahasta"
        ReportParameter2.Text = "fechahasta"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Value = ""
        ReportParameter3.Name = "idSeccion"
        ReportParameter3.Text = "idSeccion"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(20.600000381469727R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
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
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
End Class