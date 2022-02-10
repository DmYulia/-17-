using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_generics
{
    internal class BankAccount<T>
    {
        public T Account { get; set; }
        public string FullName { get; set; }
        public double Score { get; set; }
        public BankAccount()
        {
            WriteLine($"класс создан и заполнен конструктором без параметров.");
        }
        public BankAccount(T value, string name, double sc)
        {
            Account = value;
            FullName = name;
            Score = sc;
            WriteLine($"класс создан и заполнен конструктором с параметрами.");
        }
        public void ShowInfo()
        {
            WriteLine($"User {FullName} bankaccount is {Account}.\nMoney: {Score}.");
        }
    }
}
