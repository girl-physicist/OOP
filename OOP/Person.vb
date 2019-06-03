Public MustInherit Class Person

    Public Property FirstName() As String
    Public Property LastName() As String
    'Абстрактный метод
    Public MustOverride Sub Display()

    Public Sub New(fName As String, lName As String)
        FirstName = fName
        LastName = lName
    End Sub
End Class
