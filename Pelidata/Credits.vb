Public Class Credits
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide() ' Oculta el formulario de créditos
        Dim databaseForm As New DatabaseForm()
        databaseForm.Show() ' Muestra el formulario de la base de datos
    End Sub

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

