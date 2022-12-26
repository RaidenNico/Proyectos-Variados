Public Class Empleados
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HOSPITALDataSet)

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HOSPITALDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.HOSPITALDataSet.Empleado)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.EmpleadoTableAdapter.AgregarEmpleado(ID_EmpleadoTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, PuestoTextBox.Text, ID_AREATextBox.Text, TeléfonoTextBox.Text, SueldoTextBox.Text, ID_SUBTextBox.Text)
        Me.EmpleadoTableAdapter.Fill(Me.HOSPITALDataSet.Empleado)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.EmpleadoTableAdapter.ModificarEmpleado(ID_EmpleadoTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, PuestoTextBox.Text, ID_AREATextBox.Text, TeléfonoTextBox.Text, SueldoTextBox.Text, ID_SUBTextBox.Text, ID_EmpleadoTextBox.Text)
        Me.EmpleadoTableAdapter.Fill(Me.HOSPITALDataSet.Empleado)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.EmpleadoTableAdapter.EliminarEmpleado(ID_EmpleadoTextBox.Text)
        Me.EmpleadoTableAdapter.Fill(Me.HOSPITALDataSet.Empleado)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.EmpleadoTableAdapter.BuscarEmpleado(HOSPITALDataSet.Empleado, ID_EmpleadoTextBox.Text)

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.EmpleadoTableAdapter.Fill(Me.HOSPITALDataSet.Empleado)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        rempleados.Show()
    End Sub
End Class