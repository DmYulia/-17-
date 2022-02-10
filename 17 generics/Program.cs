using static System.Console;

namespace _17_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 457747753;
            string s = "Фамилия Имя Отчество";
            double m = 45.4878537;
            BankAccount<int> intaccount = new BankAccount<int>(n, s, m);
            string N = "SL46216647";
            string S = "Family FirstName SecondName";
            double M = -45612.121;
            BankAccount<string> straccount = new BankAccount<string>(N, S, M);
            intaccount.ShowInfo();
            straccount.ShowInfo();
            WriteLine();
            BankAccount<int> intaccount2 = new BankAccount<int>();
            intaccount2.Account = n;
            intaccount2.FullName = s;
            intaccount2.Score = m;
            BankAccount<string> straccount2 = new BankAccount<string>();
            straccount2.Account = N;
            straccount2.FullName = S;
            straccount2.Score = M;
            intaccount2.ShowInfo();
            straccount2.ShowInfo();
            ReadLine();
        }
    }
}