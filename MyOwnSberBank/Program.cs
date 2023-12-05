using System;
using MyOwnSberBank;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount("Иван Иванов", 1000);

        myAccount.OnWithdrawal += HandleWithdrawal;

        myAccount.Withdraw(500);

        Console.ReadLine();
    }

    // Метод-обработчик события списания средств
    static void HandleWithdrawal(double amount)
    {
        Console.WriteLine($"Списано {amount} средств со счета.");
    }
}
