Public Class Facturas
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HOSPITALDataSet)

    End Sub

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HOSPITALDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.HOSPITALDataSet.Factura)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.FacturaTableAdapter.AgregarFactura(ID_FACTURATextBox.Text, ID_CONSULTATextBox.Text, NombreTextBox.Text, DirecciónTextBox.Text, (FechaDateTimePicker.Text), TelefónoTextBox.Text, NitTextBox.Text, TotalTextBox.Text)
        Me.FacturaTableAdapter.Fill(Me.HOSPITALDataSet.Factura)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.FacturaTableAdapter.ModificarFactura(ID_FACTURATextBox.Text, ID_CONSULTATextBox.Text, NombreTextBox.Text, DirecciónTextBox.Text, (FechaDateTimePicker.Text), TelefónoTextBox.Text, NitTextBox.Text, TotalTextBox.Text, ID_FACTURATextBox.Text)
        Me.FacturaTableAdapter.Fill(Me.HOSPITALDataSet.Factura)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.FacturaTableAdapter.EliminarFactura(ID_FACTURATextBox.Text)
        Me.FacturaTableAdapter.Fill(Me.HOSPITALDataSet.Factura)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.FacturaTableAdapter.BuscarFactura(HOSPITALDataSet.Factura, ID_FACTURATextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.FacturaTableAdapter.Fill(Me.HOSPITALDataSet.Factura)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        rfacturas.Show()
    End Sub
End Class