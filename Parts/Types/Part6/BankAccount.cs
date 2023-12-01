namespace CSharpClass2.Part6
{
    public class BankAccount
    {
        private static int s_accountNumberSeed = 123456789;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get 
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private List<Transaction> _allTransactions = new List<Transaction>();

        public BankAccount(string name)
        {
            s_accountNumberSeed++;
            Number = s_accountNumberSeed.ToString();
            Owner = name;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("No sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }        
    }

    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            Amount = amount;
            Date = date;
            Notes = notes;
        }
    }

    public class OopsSample
    {
        public static void Sample()
        {
            var account1 = new BankAccount("Ajeesh");

            account1.MakeDeposit(10, DateTime.Now, "Initial deposit");
            account1.MakeWithdrawal(5, DateTime.Now, "Chaya");
            account1.MakeDeposit(5, DateTime.Now, "Present");
            account1.MakeWithdrawal(3, DateTime.Now, "Sweets");

            var accountStatement = account1.GetAccountHistory();

            Console.WriteLine(accountStatement);
        }
    }
}