
Public Class R_Viewer

    Private Sub R_Viewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case R_Reporte
            Case Is = "MOTIVOS"
                Dim report As New R_TurnosPorMotivos
                report.ReportParameters("idMotivo").Value = R_IDMotivo
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = "MOTIVOS_EXP"
                Dim report As New R_TurnosPorMotivos_Exp
                report.ReportParameters("idMotivo").Value = R_IDMotivo
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = "RESOLUCIONES"
                Dim report As New R_TurnosPorResoluciones
                report.ReportParameters("idresolucion").Value = R_IDResolucion
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = "RESOLUCIONES_EXP"
                Dim report As New R_TurnosPorResoluciones_Exp
                report.ReportParameters("idresolucion").Value = R_IDResolucion
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()


            Case Is = "OPERADORES"
                Dim report As New R_TurnosPorOperador
                report.ReportParameters("idoperador").Value = R_IDOperador
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = "OPERADORES_EXP"
                Dim report As New R_TurnosPorOperador_Exp
                report.ReportParameters("idoperador").Value = R_IDOperador
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = "SECCIONES"
                Dim report As New R_TurnosPorSecciones
                report.ReportParameters("idseccion").Value = R_IDSeccion
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = "SECCIONES_EXP"
                Dim report As New R_TurnosPorSecciones_EXP
                report.ReportParameters("idseccion").Value = R_IDSeccion
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()

            Case Is = "SUBSECCIONES"
                Dim report As New R_TurnosPorSubSecciones
                report.ReportParameters("idSeccionTipo").Value = R_IDSeccionTipo
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = "SUBSECCIONES_EXP"
                Dim report As New R_TurnosPorSubSeccion_Exp
                report.ReportParameters("idSeccionTipo").Value = R_IDSeccionTipo
                report.ReportParameters("fechaDesde").Value = R_Fechadesde
                report.ReportParameters("fechaHasta").Value = R_FechaHasta.AddDays(1)
                report.ReportParameters("idestado").Value = R_IDEstado
                ReportViewer1.ReportSource = report
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()
            Case Is = Nothing
                Me.Dispose()
        End Select


    End Sub
End Class