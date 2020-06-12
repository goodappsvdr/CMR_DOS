Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports CMR_DOS.AD

Partial Public Class R_TurnosPorOperador


    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        cargarlogo()
    End Sub

    Sub cargarlogo()


        Dim image1 As Image = Image.FromFile("C:\IDEAS_CRM_MUNI\MuniVDR.png")
        PictureBox1.Value = image1
    End Sub
End Class