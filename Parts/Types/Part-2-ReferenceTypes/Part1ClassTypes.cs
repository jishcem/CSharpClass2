using CSharpClass2.Classes;
using CSharpClass2.Oops;

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

        public static void OpenGiftCardAccount()
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());
        }

        public static void OpenInterestEarningAccount()
        {
            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());
        }

        public static void OpenLineOfCreditAccount()
        {
            var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
        }
    }
}