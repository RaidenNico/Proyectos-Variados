Public Class Consultas
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ConsultaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ConsultaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConsultaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HOSPITALDataSet)

    End Sub

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HOSPITALDataSet.Consulta' Puede moverla o quitarla según sea necesario.
        Me.ConsultaTableAdapter.Fill(Me.HOSPITALDataSet.Consulta)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.ConsultaTableAdapter.AgregarConsulta(ID_CONSULTATextBox.Text, DPI_PACIENTETextBox.Text, ID_EMPLEADOTextBox.Text, ID_AREATextBox.Text, (Fecha_ConsultaDateTimePicker.Text), PadecimientoTextBox.Text, Estado_ConsultaTextBox.Text)
        Me.ConsultaTableAdapter.Fill(Me.HOSPITALDataSet.Consulta)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.ConsultaTableAdapter.ModificarConsulta(ID_CONSULTATextBox.Text, DPI_PACIENTETextBox.Text, ID_EMPLEADOTextBox.Text, ID_AREATextBox.Text, (Fecha_ConsultaDateTimePicker.Text), PadecimientoTextBox.Text, Estado_ConsultaTextBox.Text, ID_CONSULTATextBox.Text)
        Me.ConsultaTableAdapter.Fill(Me.HOSPITALDataSet.Consulta)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.ConsultaTableAdapter.EliminarConsulta(ID_CONSULTATextBox.Text)
        Me.ConsultaTableAdapter.Fill(Me.HOSPITALDataSet.Consulta)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ConsultaTableAdapter.BuscarConsulta(HOSPITALDataSet.Consulta, ID_CONSULTATextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.ConsultaTableAdapter.Fill(Me.HOSPITALDataSet.Consulta)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        rconsultas.Show()
    End Sub
End Class