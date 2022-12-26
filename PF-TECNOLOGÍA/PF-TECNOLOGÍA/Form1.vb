Imports System.Runtime.InteropServices
Public Class Form1
#Region "Form Behaviors"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim User, pass As String
        User = txtUsuario.Text
        pass = txtPass.Text
        If User = "Administrador" And pass = "1234" Then
            MsgBox("Bienvenido Administrador al Sistema del HOSPITAL")
            Administrador.Show()
            Me.Hide()
        Else

        End If

        Dim User2, pass2 As String
        User2 = txtUsuario.Text
        pass2 = txtPass.Text
        If User = "Paciente" And pass = "56789" Then
            MsgBox("Bienvenido Paciente al Sistema del HOSPITAL")
            Admin2.Show()
            Me.Hide()
        End If

        txtUsuario.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITEN LETRAS", vbCritical)
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False 'Estable un evento'
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITEN NUMEROS", vbCritical)
        End If
    End Sub
#End Region
End Class
