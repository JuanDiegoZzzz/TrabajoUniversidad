Public Class Form1
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        Dim X As Contacto
        X = New Contacto()
        X.fechadenacimiento_ = DateTime.Parse("2003/01/01")
        X.nombre_ = TextBox1.Text
        X.telefono_ = TextBox2.Text
        LVLCOMPRIMIR.Text = X.ToString
    End Sub
End Class
