Public Interface IAccount
    'Текущая сумма на счете
    ReadOnly Property CurentSum() As Integer
    'Процент начислений
    ReadOnly Property Procentage() As Integer
    'Метод для добавления денег на счет
    Sub Put(sum As Integer)
    'Метод для снятия денег со счета
    Sub Withdraw(sum As Integer)

End Interface
