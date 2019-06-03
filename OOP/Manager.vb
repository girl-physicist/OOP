Public Class Manager
    Inherits Employee

    Public Overrides Sub Display()
        Console.WriteLine(FirstName & " " & LastName & " is a manager of " & Bank)
    End Sub

    Public Sub New(fName As String, lName As String, company As String)
        MyBase.New(fName, lName, company)
    End Sub
End Class
