Public Class Employee
    Inherits Person

    Public Property Bank As String

    Public Overrides Sub Display()
        Console.WriteLine(FirstName & " " & LastName & " works in " & Bank)
    End Sub

    Public Sub New(fName As String, lName As String, _bank As String)
        MyBase.New(fName, lName)
        Bank = _bank
    End Sub

End Class
