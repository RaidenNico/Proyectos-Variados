Imports System.Runtime.InteropServices
Public Class Admin2
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panelcabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelcabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If Panelmenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If Panelmenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width + 20
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panelmenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf Panelmenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.Panelcontenedor.Controls.Count > 0 Then Me.Panelcontenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panelcontenedor.Controls.Add(fh)
        Me.Panelcontenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        AbrirFormEnPanel(New rpacientes)
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        AbrirFormEnPanel(New rconsultas)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        AbrirFormEnPanel(New rempleados)
    End Sub

    Private Sub btnAreas_Click(sender As Object, e As EventArgs) Handles btnAreas.Click
        AbrirFormEnPanel(New rareas)
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        AbrirFormEnPanel(New rfacturas)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MsgBox("En este momento regresará al Login")
        Form1.Show()
        Me.Hide()
    End Sub
End Class