Imports System.Data.OleDb

Public Class DatabaseForm
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TopochoDatabase.accdb"
    Private connection As OleDbConnection


    Private Sub DatabaseForm(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(connectionString)
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM Topocho"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim ds As New DataSet()
            adapter.Fill(ds, "Topocho")
            DataGridView1.DataSource = ds.Tables("Topocho")
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Topocho (Pelicula, Genero, FechaDeLanzamiento, Director) VALUES (?, ?, ?, ?)"
            Dim cmd As New OleDbCommand(query, connection)
            cmd.Parameters.AddWithValue("@Pelicula", txtNombrePelicula.Text)
            cmd.Parameters.AddWithValue("@Genero", txtGeneroPelicula.Text)
            cmd.Parameters.AddWithValue("@FechaDeLanzamiento", txtFechaLanzamiento.Text)
            cmd.Parameters.AddWithValue("@Director", txtNombreDirector.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos guardados en la base")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE Topocho SET Pelicula = ?, Genero = ?, FechaDeLanzamiento = ?, Director = ? WHERE ID = ?"
            Dim cmd As New OleDbCommand(query, connection)
            cmd.Parameters.AddWithValue("@Pelicula", txtNombrePelicula.Text)
            cmd.Parameters.AddWithValue("@Genero", txtGeneroPelicula.Text)
            cmd.Parameters.AddWithValue("@FechaDeLanzamiento", txtFechaLanzamiento.Text)
            cmd.Parameters.AddWithValue("@Director", txtNombreDirector.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos actualizados en la base")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM Topocho WHERE ID = ?"
            Dim cmd As New OleDbCommand(query, connection)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos eliminados de la base")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar los datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        ' Mostrar el formulario de créditos
        Dim creditsForm As New Credits()
        creditsForm.Show()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtNombrePelicula.Text = row.Cells("Pelicula").Value.ToString()
            txtGeneroPelicula.Text = row.Cells("Genero").Value.ToString()
            txtFechaLanzamiento.Text = row.Cells("FechaDeLanzamiento").Value.ToString()
            txtNombreDirector.Text = row.Cells("Director").Value.ToString()
        End If
    End Sub

    Private Sub DatabaseForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TopochoDatabaseDataSet.Topocho' Puede moverla o quitarla según sea necesario.
        Me.TopochoTableAdapter.Fill(Me.TopochoDatabaseDataSet.Topocho)

    End Sub
End Class

