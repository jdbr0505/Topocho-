Imports System.Data.OleDb

Public Class Login
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TopochoDatabase.accdb"

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim command As New OleDbCommand("SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = ? AND Contraseña = ?", connection)
            command.Parameters.AddWithValue("@NombreUsuario", txtUsername.Text)
            command.Parameters.AddWithValue("@Contraseña", txtPassword.Text)
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("Login exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim databaseForm As New DatabaseForm()
                databaseForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    Private Sub ChkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowHidePassword.CheckedChanged
        If txtPassword.UseSystemPasswordChar Then
            txtPassword.UseSystemPasswordChar = False
            chkShowHidePassword.Text = "Ocultar contraseña"
        Else
            txtPassword.UseSystemPasswordChar = True
            chkShowHidePassword.Text = "Mostrar contraseña"
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class
