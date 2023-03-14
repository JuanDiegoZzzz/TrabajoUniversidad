Friend Class Contacto
    Inherits Persona

    Private telefono As String
    Public Property telefono_ As String
        Get

            Return telefono
        End Get
        Set(value As String)
            telefono = telefono_
            telefono = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        telefono = String.Empty

    End Sub

    Public Sub New(ByVal nombre As String, ByVal fechadenaciemineto As DateTime, ByVal telefono As String)
        MyBase.New()
        telefono = telefono
    End Sub

    Public Overrides Function ToString() As String

        Return MyBase.ToString() + " " + telefono
    End Function

End Class
