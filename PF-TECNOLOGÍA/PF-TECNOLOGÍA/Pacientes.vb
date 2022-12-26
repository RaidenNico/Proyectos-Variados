Public Class Pacientes
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PacienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PacienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PacienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HOSPITALDataSet)

    End Sub

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HOSPITALDataSet.Paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.HOSPITALDataSet.Paciente)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.PacienteTableAdapter.AgregarPaciente(DPI_PACIENTETextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DirecciónTextBox.Text, (Fecha_IngresoDateTimePicker.Text))
        Me.PacienteTableAdapter.Fill(Me.HOSPITALDataSet.Paciente)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.PacienteTableAdapter.ModificarPaciente(DPI_PACIENTETextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DirecciónTextBox.Text, (Fecha_IngresoDateTimePicker.Text), DPI_PACIENTETextBox.Text)
        Me.PacienteTableAdapter.Fill(Me.HOSPITALDataSet.Paciente)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.PacienteTableAdapter.EliminarPaciente(DPI_PACIENTETextBox.Text)
        Me.PacienteTableAdapter.Fill(Me.HOSPITALDataSet.Paciente)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.PacienteTableAdapter.BuscarPaciente(HOSPITALDataSet.Paciente, DPI_PACIENTETextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.PacienteTableAdapter.Fill(Me.HOSPITALDataSet.Paciente)
    End Sub
    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        rpacientes.Show()
    End Sub
End Class