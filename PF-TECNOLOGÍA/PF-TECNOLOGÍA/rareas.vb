Public Class rareas
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub rareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HOSPITALDataSet.Area' Puede moverla o quitarla según sea necesario.
        Me.AreaTableAdapter.Fill(Me.HOSPITALDataSet.Area)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub
End Class