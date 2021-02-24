Public Class Autoturisme
    Public Property Marca As String
    Public Property Model As String

    'constructor fara parametrii
    Public Sub New()

    End Sub

    'constructor cu parametrii
    Public Sub New(ByVal marca As String, ByVal model As String)
        Me.Marca = marca
        Me.Model = model
    End Sub

    'toString
    Public Overrides Function ToString() As String
        Return String.Format(Marca & " - " & Model)
    End Function
End Class
