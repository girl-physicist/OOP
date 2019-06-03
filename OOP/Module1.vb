Module Module1

    Sub Main()
        Dim emp1 As New Employee("Bill", "Gates", "Microsoft")
        emp1.Display()

        Dim manager1 As Manager = New Manager("John", "Johnson", "City Bank")
        manager1.Display()

        Dim cl As Client = New Client("Tom", "Johnson", "City Bank", 100)
        cl.Display()
        cl.Put(200)
        Console.WriteLine("Остаток на счете клиента {0} {1} равен : {2}", cl.FirstName, cl.LastName, cl.CurentSum)

        Console.ReadLine()
    End Sub

End Module
