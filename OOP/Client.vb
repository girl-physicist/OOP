Public Class Client
    Inherits Person
    Implements IAccount

    'Переменная для хранения суммы
    Dim _sum As Integer
    'Переменная для хранения процента
    Dim _procentage As Integer

    Public Property Bank As String

    'Текущая сумма на счете
    ReadOnly Property CurentSum() As Integer Implements IAccount.CurentSum
        Get
            Return _sum
        End Get
    End Property
    'Метод для добавления денег на счет
    Sub Put(sum As Integer) Implements IAccount.Put
        _sum += sum
    End Sub
    'Метод для снятия денег со счета
    Sub Withdraw(sum As Integer) Implements IAccount.Withdraw
        If sum <= CurentSum Then
            _sum -= sum
        End If
    End Sub
    'Процент начислений
    ReadOnly Property Procentage() As Integer Implements IAccount.Procentage
        Get
            Return _procentage
        End Get
    End Property

    Public Overrides Sub Display()
        Console.WriteLine(FirstName & " " & LastName & " has an account in bank " & Bank)
    End Sub

    Public Sub New(fName As String, lName As String, _bank As String, _sum As Integer)
        MyBase.New(fName, lName)
        Bank = _bank
        Me._sum = _sum
    End Sub
End Class
