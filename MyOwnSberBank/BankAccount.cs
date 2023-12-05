using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnSberBank
{
    using System;

    // Создаем класс для представления банковского аккаунта
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public delegate void WithdrawalDelegate(double amount);

        public WithdrawalDelegate OnWithdrawal;

        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;

                OnWithdrawal?.Invoke(amount);

                Console.WriteLine($"Средства успешно списаны. Новый баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
    }
}
