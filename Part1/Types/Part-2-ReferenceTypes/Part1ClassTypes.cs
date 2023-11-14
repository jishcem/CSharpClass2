using CSharpClass2.Classes;

namespace CSharpClass2
{
    public static class Part1ClassTypes
    {
        public static void DefinedBankAccount()
        {

        }

        public static void OpenNewAccount()
        {
            var account = new BankAccount("Ajeesh", 1000);
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            try
            {
                account.MakeWithdrawal(700, DateTime.Now, "Buying a PS5");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}