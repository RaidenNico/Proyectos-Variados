Public Class Areas
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub AreaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AreaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AreaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HOSPITALDataSet)

    End Sub

    Private Sub Areas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HOSPITALDataSet.Area' Puede moverla o quitarla según sea necesario.
        Me.AreaTableAdapter.Fill(Me.HOSPITALDataSet.Area)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AreaTableAdapter.AgregarArea(ID_AREATextBox.Text, NombreTextBox.Text)
        Me.AreaTableAdapter.Fill(Me.HOSPITALDataSet.Area)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.AreaTableAdapter.ModificarArea(ID_AREATextBox.Text, NombreTextBox.Text, ID_AREATextBox.Text)
        Me.AreaTableAdapter.Fill(Me.HOSPITALDataSet.Area)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.AreaTableAdapter.EliminarArea(ID_AREATextBox.Text)
        Me.AreaTableAdapter.Fill(Me.HOSPITALDataSet.Area)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.AreaTableAdapter.BuscarArea(HOSPITALDataSet.Area, ID_AREATextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.AreaTableAdapter.Fill(Me.HOSPITALDataSet.Area)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        rareas.Show()
    End Sub
End Class